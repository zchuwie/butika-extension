Imports butika.Models

Public Class pharmaViewTransaction
    Dim transactions As New Transaction()
    Public Sub New(transac As Transaction)
        Me.transactions = transac

        InitializeComponent()
    End Sub
    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub
    Public Async Function LoadAllOrderMeds() As Task
        username.Text = transactions.Account.UserName
        transactionid.Text = transactions.TransactionID
        flpItems.Controls.Clear()

        Dim transacRepo As New PharmaRepository()
        Dim allOrderMeds As List(Of Transaction) = Await transacRepo.GetAllOrderMeds(transactions.TransactionID)

        Dim batchSize As Integer = 5

        For i As Integer = 0 To allOrderMeds.Count - 1 Step batchSize
            Dim batch = allOrderMeds.Skip(i).Take(batchSize).ToList()

            For Each indivOrders In batch
                Dim usc As New pharmaOrderMedList()
                usc.Initialize(indivOrders)
                flpItems.Controls.Add(usc)
            Next

            Await Task.Delay(50)
        Next

    End Function

    Private Async Sub pharmaViewTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadAllOrderMeds()
    End Sub
End Class