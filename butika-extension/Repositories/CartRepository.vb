Imports butika.Configurations
Imports butika.Models
Imports Dapper

Public Class CartRepository
    Dim account As New Account()
    Public Sub New(account As Account)
        Me.account = account
    End Sub

#Region "Adding Medicines To Cart"
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

#Region "Display Items From Cart"

    Public Async Function GetUserCart() As Task(Of Stack(Of Cart))
        Dim cartStack As New Stack(Of Cart)()

        Using conn = DatabaseConnection.GetConnection()
            Dim sql As String = "
                SELECT 
                    cart.cart_id AS CartID, 
                    cart.user_id AS UserID, 
                    cart.Quantity, 
                    cart.isTicked, 
                    cart.isApproved,
                    cart.Prescription_id As PrescriptionID,
                    med.drug_id AS MedicineID,             
                    med.drug_name AS MedicineName,          
                    med.drug_brand AS MedicineBrand,        
                    med.drug_manufacturer AS MedicineManufacturer,
                    med.drug_description AS MedicineDescription,
                    med.drug_dosage AS MedicineDosage,
                    med.drug_price AS MedicinePrice,
                    med.drug_image AS MedicineImageName
                FROM usersCart cart
                LEFT JOIN drug_inventory med ON med.drug_id = cart.drug_id
                WHERE cart.user_id = @user_id AND cart.isApproved <= 1"

            Dim result = Await conn.QueryAsync(Of Cart, Medicine, Cart)(
            sql,
            Function(cart, medicine)
                cart.Medicine = medicine
                Return cart
            End Function,
            param:=New With {.user_id = account.UserID},
            splitOn:="MedicineID"
        )

            For Each cartItem In result
                cartStack.Push(cartItem)
            Next

            Return cartStack
        End Using
    End Function
    Public Async Function GetUserCart(isApproved As Integer) As Task(Of Stack(Of Cart))
        Dim cartStack As New Stack(Of Cart)()

        Using conn = DatabaseConnection.GetConnection()
            Dim sql As String = "
                SELECT 
                    cart.cart_id AS CartID, 
                    cart.user_id AS UserID, 
                    cart.Quantity, 
                    cart.isTicked, 
                    cart.isApproved,
                    cart.Prescription_id As PrescriptionID,
                    med.drug_id AS MedicineID,             
                    med.drug_name AS MedicineName,          
                    med.drug_brand AS MedicineBrand,        
                    med.drug_manufacturer AS MedicineManufacturer,
                    med.drug_description AS MedicineDescription,
                    med.drug_dosage AS MedicineDosage,
                    med.drug_price AS MedicinePrice,
                    med.drug_image AS MedicineImageName
                FROM usersCart cart
                LEFT JOIN drug_inventory med ON med.drug_id = cart.drug_id
                WHERE cart.user_id = @user_id AND cart.isApproved = @isApproved"

            Dim result = Await conn.QueryAsync(Of Cart, Medicine, Cart)(
            sql,
            Function(cart, medicine)
                cart.Medicine = medicine
                Return cart
            End Function,
            param:=New With {.user_id = account.UserID, .isApproved = isApproved},
            splitOn:="MedicineID"
        )

            For Each cartItem In result
                cartStack.Push(cartItem)
            Next

            Return cartStack
        End Using
    End Function

#End Region

#Region "Checkbox State"
    Public Async Function UpdateCheckBoxTickFromCart(cart_id As Integer, isTicked As Boolean) As Task
        Dim conn = DatabaseConnection.GetConnection()

        Using conn
            Try
                Await conn.OpenAsync()

                Dim query As String = "UPDATE usersCart SET isTicked = @isTicked WHERE cart_id = @cart_id AND user_id = @user_id"

                Dim parameters = New With {
                .isTicked = If(isTicked, 1, 0),
                .cart_id = cart_id,
                .user_id = account.UserID
            }

                Await conn.ExecuteAsync(query, parameters)

            Catch ex As Exception
                Debug.WriteLine("Updating checkbox state failed, bruh: " & ex.Message)
            End Try
        End Using
    End Function

    Public Async Function SelectOrDeselectAllUserMedicine(isTicked As Boolean, whoToSelect As Integer) As Task
        Dim conn = DatabaseConnection.GetConnection()

        Using conn
            Try
                Await conn.OpenAsync()

                Dim query As String
                If whoToSelect = -1 Then
                    query = "
                    UPDATE usersCart 
                    SET isTicked = @isTicked 
                    WHERE user_id = @user_id AND isApproved <> 2"
                Else
                    query = "
                    UPDATE usersCart 
                    SET isTicked = @isTicked 
                    WHERE user_id = @user_id AND isApproved = @whoToSelect"
                End If

                Dim parameters = New With {
                    .isTicked = If(isTicked, 1, 0),
                    .user_id = account.UserID,
                    .whoToSelect = whoToSelect
                }

                Await conn.ExecuteAsync(query, parameters)

            Catch ex As Exception
                Debug.WriteLine("An error occurred while updating selection status: " & ex.Message)
            End Try
        End Using
    End Function



#End Region

#Region "Checkout"
    Public Async Function GetCartInfoForCheckOutPanel() As Task(Of List(Of Cart))
        Dim cartInfo As New List(Of Cart)()

        Using conn = DatabaseConnection.GetConnection()
            Try
                ' Open the connection
                Await conn.OpenAsync()

                Dim sql As String = "
                        SELECT 
                            cart.cart_id AS CartID, 
                            cart.user_id AS UserID, 
                            cart.Quantity, 
                            cart.isTicked, 
                            cart.isApproved,
                            med.drug_id AS MedicineID,
                            med.drug_name AS MedicineName,
                            med.drug_brand AS MedicineBrand,
                            med.drug_price AS MedicinePrice                            
                        FROM usersCart cart
                        LEFT JOIN drug_inventory med ON med.drug_id = cart.drug_id
                        WHERE cart.user_id = @user_id AND cart.isTicked = 1 AND cart.isApproved != 2 AND cart.prescription_id = 0"

                Dim result = Await conn.QueryAsync(Of Cart, Medicine, Cart)(
                    sql,
                    Function(cart, medicine)
                        cart.Medicine = medicine
                        Return cart
                    End Function,
                    param:=New With {.user_id = account.UserID},
                    splitOn:="MedicineID"
                )
                cartInfo = result.ToList()

                Return cartInfo
            Catch ex As Exception
                Debug.WriteLine("Error while retrieving cart info: " & ex.Message)
                Return Nothing
            End Try
        End Using
    End Function

    Public Async Function InsertIndividualTransactionToCheckout(transactionID As String, userCheckouts As List(Of Cart)) As Task(Of Boolean)
        Using conn = DatabaseConnection.GetConnection()
            Try
                Await conn.OpenAsync()

                Dim query As String = "INSERT INTO usersCheckout (drug_id, transaction_id, quantity) VALUES (@drug_id, @transaction_id, @quantity)"

                For Each checkout In userCheckouts
                    Await conn.ExecuteAsync(query, New With {
                    .drug_id = checkout.Medicine.MedicineID,
                    .transaction_id = transactionID,
                    .quantity = checkout.Quantity
                })
                Next

                Return True

            Catch ex As Exception
                Debug.WriteLine("Error inserting to userCheckout table in database: " & ex.Message)
                Return False
            End Try
        End Using
    End Function

    Public Async Function UpdateAlreadyCheckoutStatus(userCheckouts As List(Of Cart)) As Task(Of Boolean)
        Using conn = DatabaseConnection.GetConnection()
            Try
                Await conn.OpenAsync()

                Dim query As String = "UPDATE usersCart SET alreadyCheckout = 1 WHERE cart_id = @cart_id AND user_id = @user_id AND isTicked = 1 AND isApproved != 2"

                For Each checkout In userCheckouts
                    Await conn.ExecuteAsync(query, New With {
                    Key .user_id = account.UserID,
                    Key .cart_id = checkout.CartID
                })
                Next

                Return True

            Catch ex As Exception
                Console.WriteLine("Error updating the checkout status: " & ex.Message)
                Return False
            End Try
        End Using
    End Function

#End Region

#Region "Prescription"
    Public Async Function IsPrescriptionAlreadySent() As Task(Of Boolean)
        Using conn = DatabaseConnection.GetConnection()
            Try
                Await conn.OpenAsync()

                Dim query As String = "SELECT COUNT(*) FROM usersCart WHERE user_id = @user_id AND isTicked = 1 AND prescription_id != 0 AND isApproved = 0"

                Dim result As Integer = Await conn.ExecuteScalarAsync(Of Integer)(query, New With {.user_id = account.UserID})

                Return result > 0
            Catch ex As Exception
                Debug.WriteLine("Error while getting the prescription: " & ex.Message)
                Return False
            End Try
        End Using
    End Function

    Public Async Function insertPrescriptionInUsersTicked(prescriptionID As Integer) As Task(Of Boolean)
        Using conn = DatabaseConnection.GetConnection()
            Try
                Await conn.OpenAsync()

                Dim query As String = "UPDATE usersCart SET prescription_id = @prescription_id WHERE isTicked = 1 AND user_id = @user_id"

                ' Execute the query using Dapper
                Await conn.ExecuteAsync(query, New With {.prescription_id = prescriptionID, .user_id = account.UserID})

                Return True
            Catch ex As Exception
                Debug.WriteLine("Error updating prescription_id: " & ex.Message)
                Return False
            End Try
        End Using
    End Function


#End Region

#Region "Stock Manipulation"
    Public Async Function GetInfoForStockReduce() As Task(Of List(Of Cart))
        Dim itemsToReduce As New List(Of Cart)()

        Using conn = DatabaseConnection.GetConnection()
            Try
                Await conn.OpenAsync()

                ' Define your query for multi-mapping
                Dim query As String = "
                SELECT 
                    cart.cart_id AS CartID, 
                    cart.user_id AS UserID, 
                    cart.quantity AS Quantity, 
                    cart.drug_id AS MedicineID,
                    med.drug_name AS MedicineName,
                    med.drug_price AS MedicinePrice,
                    med.drug_stocks AS MedicineStock
                FROM usersCart cart
                LEFT JOIN drug_inventory med ON med.drug_id = cart.drug_id
                WHERE cart.user_id = @user_id AND cart.isApproved = 1 AND cart.isTicked = 1 AND cart.alreadyCheckout = 1"

                Dim result = Await conn.QueryAsync(Of Cart, Medicine, Cart)(
                query,
                Function(cart, medicine)
                    cart.Medicine = medicine
                    Return cart
                End Function,
                param:=New With {.user_id = account.UserID},
                splitOn:="MedicineID"
            )

                itemsToReduce = result.ToList()

                Return itemsToReduce

            Catch ex As Exception
                Debug.WriteLine("Error while getting stock to reduce: " & ex.Message)
                Return Nothing
            End Try
        End Using
    End Function

    Public Async Function listOfStockToReduce(itemsCart As List(Of Cart)) As Task(Of Boolean)
        Using conn = DatabaseConnection.GetConnection()
            Try
                Await conn.OpenAsync()

                For Each items In itemsCart
                    Dim query As String = "UPDATE drug_inventory SET drug_stocks = drug_stocks - @drug_stocks WHERE drug_id = @drug_id"
                    Await conn.ExecuteAsync(query, New With {.drug_stocks = items.Quantity, Key .drug_id = items.Medicine.MedicineID})
                Next

                Debug.WriteLine("Successfully decreased stock.")
                Return True

            Catch ex As Exception
                Debug.WriteLine("Error while decreasing stock: " & ex.Message)
                Return False
            End Try
        End Using
    End Function



#End Region

#Region "Receipt"
    Public Async Function GetUserReceiptData() As Task(Of List(Of Cart))
        Dim cartItems As New List(Of Cart)()

        Using conn = DatabaseConnection.GetConnection()
            Try
                Await conn.OpenAsync()

                Dim query As String = "
                SELECT 
                    cart.cart_id AS CartID, 
                    cart.user_id AS UserID, 
                    cart.quantity AS Quantity, 
                    med.drug_id AS MedicineID, 
                    med.drug_name AS MedicineName, 
                    med.drug_brand AS MedicineBrand, 
                    med.drug_price AS MedicinePrice
                FROM usersCart cart
                LEFT JOIN drug_inventory med ON med.drug_id = cart.drug_id
                WHERE cart.user_id = @user_id 
                AND cart.isTicked = 1 
                AND cart.isApproved = 1
                AND cart.alreadyCheckout = 1"

                Dim result = Await conn.QueryAsync(Of Cart, Medicine, Cart)(
                query,
                Function(cart, medicine)
                    cart.Medicine = medicine
                    Return cart
                End Function,
                param:=New With {.user_id = account.UserID},
                splitOn:="MedicineID"
            )

                ' Convert the result to a List(Of Cart)
                cartItems = result.ToList()

                Return cartItems
            Catch ex As Exception
                Debug.WriteLine("Error while getting the cart data: " & ex.Message)
                Return Nothing
            End Try
        End Using
    End Function

#End Region

#Region "Delete checkout items"
    Public Async Function deleteCheckoutItemFromUsersCart() As Task(Of Boolean)
        Using conn = DatabaseConnection.GetConnection()
            Try
                Await conn.OpenAsync()
                Dim query As String = "DELETE FROM usersCart WHERE user_id = @user_id AND alreadyCheckout = 1"

                Await conn.ExecuteAsync(query, New With {.user_id = account.UserID})

                Return True
            Catch ex As Exception
                Debug.WriteLine("Error while removing checkout items from cart: " & ex.Message)
                Return False
            End Try
        End Using
    End Function

#End Region



End Class
