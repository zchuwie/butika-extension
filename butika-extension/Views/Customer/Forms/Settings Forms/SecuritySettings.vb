Imports butika.Helpers
Imports butika.Models

Public Class SecuritySettings
    Dim account As New Account()

    Public Sub New(account As Account)
        InitializeComponent()
        Me.account = account
    End Sub

    Private Sub SecuritySettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If account IsNot Nothing Then
            Debug.WriteLine("SecurityLoad LOADED:")
            Debug.WriteLine("SecurityLoad First Name: " & account.FirstName)
            Debug.WriteLine("SecurityLoad User ID: " & account.UserID)
        Else
            Debug.WriteLine("Account is null or empty.")
        End If
    End Sub
End Class