Imports butika.Models

Public Class pharmaTransactions
    Private Async Sub pharmaTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        infoManagerIcon.SetToolTip(infoIcon, "View recorded transactions and their Transaction IDs. Click on a transaction to see detailed order information and confirm the medicines listed in the receipt.")
        infoManagerIcon.ShowAlways = True

        Await LoadAllTransactions()
    End Sub
    Public Async Function LoadAllTransactions() As Task
        flpTransaction.Controls.Clear()

        Dim transacRepo As New PharmaRepository()
        Dim allTransactions As List(Of Transaction) = Await transacRepo.GetAllTransactions()

        Dim batchSize As Integer = 5

        For i As Integer = 0 To allTransactions.Count - 1 Step batchSize
            Dim batch = allTransactions.Skip(i).Take(batchSize).ToList()

            For Each indivTransac In batch
                Dim usc As New pharmaTransacItem()
                usc.Initialize(indivTransac)
                flpTransaction.Controls.Add(usc)
            Next

            Await Task.Delay(50)
        Next

    End Function
End Class