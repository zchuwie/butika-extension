Imports butika.Models

Public Class HomePage
    Dim account As New Account()

    Public Sub New(account As Account)
        InitializeComponent()
        Me.account = account
    End Sub


End Class