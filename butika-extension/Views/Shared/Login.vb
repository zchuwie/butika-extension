Public Class Login

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Dim username As String = usernameTxtBox.Text
        Dim password As String = passwordTxtBox.Text

        If username = "admin" And password = "admin" Then
            Dim dashboard As New AdminLogin()
            dashboard.Show()
            Me.Hide()
        Else
            MsgBox("Invalid username or password")
        End If
    End Sub

    Private Sub forgetPassTxtBtn_Click(sender As Object, e As EventArgs) Handles forgetPassTxtBtn.Click
        Dim forgetPassword As New ForgetPassword()
        forgetPassword.Show()
        Me.Hide()
    End Sub

    Private Sub signUpTxtBtn_Click(sender As Object, e As EventArgs) Handles signUpTxtBtn.Click
        Dim signUp As New Signup
        signUp.Show()
        Hide()
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Application.Exit()
    End Sub
End Class
