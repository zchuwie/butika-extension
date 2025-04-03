Imports System.Runtime.CompilerServices
Imports butika.Helpers
Imports butika.Models

Public Class Signup
    Private account As Account = New Account()
    Private Sub signUpTxtBtn_Click(sender As Object, e As EventArgs) Handles signUpTxtBtn.Click
        Dim login As New Login()
        login.Show()
        Me.Close()
    End Sub

    Private Sub emailTxtBox_TextChanged(sender As Object, e As EventArgs) Handles emailTxtBox.TextChanged

    End Sub
End Class