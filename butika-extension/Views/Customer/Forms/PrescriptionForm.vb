Imports butika.Models

Public Class PrescriptionForm

    Dim account As New Account
    Public Sub New(account As Account)
        Me.account = account
        InitializeComponent()

    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub
End Class