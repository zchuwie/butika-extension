Imports butika.Models
Imports Guna.UI2.WinForms

Public Class pharmaDashTransac
    Dim transactions As New Transaction()
    Dim allOrderMeds As List(Of Transaction)
    Dim transacRepo As New PharmaRepository()

    Public Async Sub Initialize(transac As Transaction)
        Me.transactions = transac

        allOrderMeds = Await transacRepo.GetAllOrderMeds(transac.TransactionID)
        Dim totalItem As Decimal = getTotalSumOfItems(allOrderMeds)
        amountLbl.Text = $"Php {totalItem}"
        dateLbl.Text = transac.TransactionDate
        transacIdLbl.Text = transac.TransactionID
        ClickAll()
    End Sub
    Private Sub ClickAll()
        AddHandler dateLbl.Click, Sub(sender, e) Call pharmaDashTransac_Click(sender, e)
        AddHandler amountLbl.Click, Sub(sender, e) Call pharmaDashTransac_Click(sender, e)
        AddHandler transacIdLbl.Click, Sub(sender, e) Call pharmaDashTransac_Click(sender, e)
    End Sub
    Private Sub pharmaDashTransac_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Dim viewtransac As New pharmaViewTransaction(transactions)
        viewtransac.ShowDialog()
    End Sub
    Private Function getTotalSumOfItems(totalItems As List(Of Transaction)) As Decimal
        Dim itemList As New List(Of Decimal)()

        For Each item In totalItems
            Dim itemPrice As Decimal
            If item.Account.IsVerified = True Then
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
End Class
