Imports butika.Models

Public Class PrescriptionPage
    Private account As New Account()
    Dim accountRep As New AccountRepository()
    Public Sub New(account As Account)
        InitializeComponent()
        Me.account = account
    End Sub
End Class