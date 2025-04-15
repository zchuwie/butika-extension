Imports butika.Models

Public Class pharmaTransacItem
    Dim transactions As New Transaction()

    Public Sub Initialize(transac As Transaction)
        Me.transactions = transac

        userIdLbl.Text = transac.Account.UserID.ToString()
        usernameLbl.Text = transac.Account.UserName
        transacIdLbl.Text = transac.TransactionID
        dateLbl.Text = transac.TransactionDate
        ClickAll()
    End Sub
    Private Sub ClickAll()
        AddHandler userIdLbl.Click, Sub(sender, e) Call pharmaTransacItem_Click(sender, e)
        AddHandler usernameLbl.Click, Sub(sender, e) Call pharmaTransacItem_Click(sender, e)
        AddHandler transacIdLbl.Click, Sub(sender, e) Call pharmaTransacItem_Click(sender, e)
        AddHandler dateLbl.Click, Sub(sender, e) Call pharmaTransacItem_Click(sender, e)
        AddHandler Guna2Panel1.Click, Sub(sender, e) Call pharmaTransacItem_Click(sender, e)
    End Sub
    Private Sub pharmaTransacItem_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Dim viewtransac As New pharmaViewTransaction(transactions)
        viewtransac.ShowDialog()
    End Sub
End Class
