Imports butika.Configurations
Imports butika.Models
Imports Dapper

Public Class TransactionRepository
    Dim account As New Account()
    Public Sub New(account As Account)
        Me.account = account
    End Sub

    ' Insert a new transaction for the user
    Public Async Function InsertIntoUserTransaction(transactionID As String) As Task(Of Boolean)
        Using conn = DatabaseConnection.GetConnection()
            Try
                Await conn.OpenAsync()

                Dim query As String = "INSERT INTO userTransaction (transaction_id, user_id, transaction_date) 
                                           VALUES (@transactionID, @userID, @date)"
                Dim parameters = New With {
                        Key .transactionID = transactionID,
                        Key .userID = account.UserID,
                        Key .date = DateTime.Now
                    }

                Await conn.ExecuteAsync(query, parameters)
                Return True
            Catch ex As Exception
                Console.WriteLine("Error inserting into user transaction: " & ex.Message)
                Return False
            End Try
        End Using
    End Function

    ' Generate a unique transaction ID
    Public Async Function GenerateUniqueTransactionID() As Task(Of String)
        Dim rnd As New Random()
        Dim transactionID As String = ""

        Using conn = DatabaseConnection.GetConnection()
            Try
                Await conn.OpenAsync()

                Do
                    Dim generatedNumber As Integer = rnd.Next(1000, 9999)
                    transactionID = "100" & generatedNumber.ToString()

                    Dim query As String = "SELECT COUNT(*) FROM userTransaction WHERE userTransactionID = @userTransactionID"
                    Dim parameters = New With {Key .userTransactionID = transactionID}

                    Dim count As Integer = Await conn.ExecuteScalarAsync(Of Integer)(query, parameters)

                    If count = 0 Then
                        Exit Do
                    End If
                Loop
            Catch ex As Exception
                Console.WriteLine("Error finding unique transaction ID: " & ex.Message)
            End Try
        End Using

        Return transactionID
    End Function

    ' Get total number of transactions for the user
    Public Async Function GetTotalUserTransactions() As Task(Of Integer)

        Using conn = DatabaseConnection.GetConnection()
            Try
                Await conn.OpenAsync()

                Dim query As String = "SELECT COUNT(*) FROM userTransaction WHERE user_id = @user_id"
                Dim parameters = New With {Key .user_id = account.UserID}

                Return Await conn.ExecuteScalarAsync(Of Integer)(query, parameters)
            Catch ex As Exception
                Console.WriteLine("Error counting user transactions: " & ex.Message)
                Return 0
            End Try
        End Using
    End Function
End Class

