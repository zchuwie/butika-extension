Imports butika.Configurations
Imports butika.Models
Imports Dapper
Public Class PharmaRepository
    Dim transaction As New Transaction()

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

    ' pangdisplay ng meds sa order
    Public Async Function GetAllOrderMeds(transactionid As String) As Task(Of List(Of Transaction))
        Using conn = DatabaseConnection.GetConnection()
            Await conn.OpenAsync()
            Dim query = "
            SELECT 
                uc.transaction_id AS TransactionID,
                med.drug_id AS MedicineID,
                med.drug_name AS MedicineName,
                uc.quantity AS Quantity
            FROM userscheckout uc
            LEFT JOIN drug_inventory med ON uc.drug_id = med.drug_id
            WHERE uc.transaction_id = @TransactionID
            "

            Dim result = Await conn.QueryAsync(Of Transaction, Medicine, Cart, Transaction)(
            query,
            Function(tran, med, cart)
                tran.Medicine = med
                tran.Cart = cart
                Return tran
            End Function,
            param:=New With {.TransactionID = transactionid},
            splitOn:="MedicineID,Quantity"
            )

            Return result.ToList()
        End Using
    End Function

    ' pang display sa mga porescriptions
End Class
