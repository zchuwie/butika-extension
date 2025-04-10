Imports butika.Configurations
Imports butika.Models
Imports Dapper
Public Class PharmaRepository

    ' pangdisplay ng lahat ng transaction
    Public Async Function GetAllTransactions() As Task(Of List(Of Transaction))
        Using conn = DatabaseConnection.GetConnection()
            Await conn.OpenAsync()
            Dim query = "
                SELECT 
                    ut.transaction_id AS TransactionID,
                    ut.transaction_date AS TransactionDate,
                    ua.username AS UserName,
                    ua.user_id AS UserID
                FROM usertransaction ut
                LEFT JOIN useraccount ua ON ut.user_id = ua.user_id"

            Dim result = Await conn.QueryAsync(Of Transaction, Account, Transaction)(
                query,
                Function(tran, acc)
                    tran.Account = acc
                    Return tran
                End Function,
                splitOn:="UserName"
            )
            Return result.ToList()
        End Using
    End Function

    Public Class List(Of T1, T2)
    End Class
End Class
