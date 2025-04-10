Imports butika.Models

Public Class pharmaViewTransaction
    Dim transactions As New Transaction()
    Dim account As New Account()
    Public Sub New(transac As Transaction, acc As Account)
        Me.transactions = transac
        Me.account = acc

        InitializeComponent()
        LoadTransaction()
    End Sub
    Public Sub LoadTransaction()
        username.Text = account.UserName
        transactionid.Text = transactions.TransactionID
    End Sub
    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub
End Class