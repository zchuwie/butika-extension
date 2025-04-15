Imports butika.Models
Imports Guna.UI2.WinForms

Public Class pharmaDashTransac
    Dim transactions As New Transaction()

    Public Sub Initialize(transac As Transaction)
        Me.transactions = transac

        'amountLbl.Text = transac.Account.UserID.ToString()
        dateLbl.Text = transac.TransactionDate
        transacIdLbl.Text = transac.TransactionID
        ClickAll()
    End Sub
    Private Sub ClickAll()
        AddHandler dateLbl.Click, Sub(sender, e) Call pharmaDashTransac_Click(sender, e)
        'AddHandler amountLbl.Click, Sub(sender, e) Call pharmaDashTransac_Click(sender, e)
        AddHandler transacIdLbl.Click, Sub(sender, e) Call pharmaDashTransac_Click(sender, e)
    End Sub
    Private Sub pharmaDashTransac_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Dim viewtransac As New pharmaViewTransaction(transactions)
        viewtransac.ShowDialog()
    End Sub
End Class
