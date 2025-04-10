Imports System.IO
Imports butika.Models

Public Class PrescriptionForm

    Dim account As New Account

    Public Sub New(account As Account)
        Me.account = account
        InitializeComponent()
    End Sub

End Class