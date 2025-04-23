Imports butika.Models

Public Class pharmaViewTransaction
    Dim transactions As New Transaction()
    Dim allOrderMeds As List(Of Transaction)
    Dim transacRepo As New PharmaRepository()
    Public Sub New(transac As Transaction)
        Me.transactions = transac

        InitializeComponent()
    End Sub
    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub
    Public Async Function LoadAllOrderMeds() As Task
        flpItems.Controls.Clear()

        allOrderMeds = Await transacRepo.GetAllOrderMeds(transactions.TransactionID)

        Dim totalItem As Decimal = getTotalSumOfItems(allOrderMeds)
        totalamount.Text = $"Php {totalItem}"
        username.Text = transactions.Account.UserName
        transactionid.Text = transactions.TransactionID

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
    Private Function getTotalSumOfItems(totalItems As List(Of Transaction)) As Decimal
        Dim itemList As New List(Of Decimal)()

        For Each item In totalItems
            Dim itemPrice As Decimal

            If item.Account?.IsVerified = True AndAlso
            item.Account.VerifiedDate.HasValue AndAlso
            item.TransactionDate >= item.Account.VerifiedDate.Value Then

                itemPrice = item.Medicine.DiscountedPrice
            Else
                itemPrice = item.Medicine.MedicinePrice
            End If

            Dim itemQuantity As Integer = item.Cart.Quantity
            Dim totalItemPrice As Decimal = itemPrice * itemQuantity
            itemList.Add(totalItemPrice)
        Next


        Dim totalSum As Decimal = itemList.Sum()
        Return totalSum
    End Function
    Private Async Sub pharmaViewTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadAllOrderMeds()
    End Sub
End Class