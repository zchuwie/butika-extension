Imports butika.Configurations
Imports butika.Models
Imports Dapper

Public Class CartRepository
    Dim account As New Account()
    Public Sub New(account As Account)
        Me.account = account
    End Sub

#Region "Add To Cart Functionality"
    Public Async Function AddToCart(drugId As Integer, quantity As Integer) As Task(Of Boolean)
        Using conn = DatabaseConnection.GetConnection()
            Try
                Await conn.OpenAsync()

                Dim isAlreadyExists As Boolean = Await IsAlreadyExistInCart(drugId)

                If isAlreadyExists Then
                    Dim quantityFromDB As Integer = Await GetQuantityOfItem(drugId)
                    If quantityFromDB > 0 Then
                        Await AddItemToExistingCart(drugId, quantity, quantityFromDB)
                        Return True
                    Else
                        Return False
                    End If
                End If

                Dim prescriptionStatus As Integer = Await GetPrescriptionStatus(drugId)

                Dim query As String = "
                INSERT INTO usersCart (drug_id, user_id, alreadyCheckout, quantity, isTicked, isApproved)
                VALUES (@drug_id, @user_id, 0, @quantity, 0, @isApproved)
            "

                Dim rows As Integer = Await conn.ExecuteAsync(query, New With {
                .drug_id = drugId,
                .user_id = account.UserID,
                .quantity = quantity,
                .isApproved = prescriptionStatus
            })

                Return rows > 0
            Catch ex As Exception
                Debug.WriteLine("Error while adding to the cart: " & ex.Message)
                Return False
            End Try
        End Using
    End Function

    Public Async Function IsAlreadyExistInCart(drugId As Integer) As Task(Of Boolean)
        Using conn = DatabaseConnection.GetConnection()
            Try
                Await conn.OpenAsync()

                Dim query As String = "
                SELECT COUNT(*) FROM usersCart 
                WHERE user_id = @user_id AND drug_id = @drug_id AND prescription_id = 0
            "

                Dim result As Integer = Await conn.ExecuteScalarAsync(Of Integer)(query, New With {
                .user_id = account.UserID,
                .drug_id = drugId
            })

                Return result > 0
            Catch ex As Exception
                Debug.WriteLine("Error finding duplicate in the list: " & ex.Message)
                Return False
            End Try
        End Using
    End Function

    Public Async Function AddItemToExistingCart(drugId As Integer, quantity As Integer, quantityFromDB As Integer) As Task(Of Boolean)
        Using conn = DatabaseConnection.GetConnection()
            Try
                Await conn.OpenAsync()

                Dim query As String = "
                UPDATE usersCart 
                SET quantity = @newQuantity 
                WHERE drug_id = @drug_id AND user_id = @user_id
            "

                Dim rows As Integer = Await conn.ExecuteAsync(query, New With {
                .newQuantity = quantityFromDB + quantity,
                .drug_id = drugId,
                .user_id = account.UserID
            })

                Return rows > 0
            Catch ex As Exception
                Debug.WriteLine("Error adding duplicate item in the list: " & ex.Message)
                Return False
            End Try
        End Using
    End Function

    Public Async Function GetQuantityOfItem(drugId As Integer) As Task(Of Integer)
        Using conn = DatabaseConnection.GetConnection()
            Try
                Await conn.OpenAsync()

                Dim query As String = "SELECT quantity FROM usersCart WHERE user_id = @user_id AND drug_id = @drug_id"

                ' Use Dapper to execute the query and get the quantity
                Dim result As Integer = Await conn.ExecuteScalarAsync(Of Integer)(query, New With {.user_id = account.UserID, .drug_id = drugId})

                Return result
            Catch ex As Exception
                Debug.WriteLine("Error finding quantity of the item in the list: " & ex.Message)
                Return 0
            End Try
        End Using
    End Function

    Public Async Function GetPrescriptionStatus(drugId As Integer) As Task(Of Integer)
        Using conn = DatabaseConnection.GetConnection()
            Try
                Await conn.OpenAsync()

                Dim query As String = "SELECT prescription_needed FROM drug_inventory WHERE drug_id = @drug_id"
                Dim result As Integer = Await conn.ExecuteScalarAsync(Of Integer)(query, New With {
                .drug_id = drugId
            })

                If result = 1 Then
                    Return 0 ' Alter so that when inserted into usersCart, it will be 0
                Else
                    Return 1
                End If
            Catch ex As Exception
                Debug.WriteLine("Error retrieving prescription status: " & ex.Message)
                Return 1
            End Try
        End Using
    End Function
#End Region

#Region "Cart Functionalities"



#End Region



End Class
