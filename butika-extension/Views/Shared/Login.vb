Imports Microsoft.IdentityModel.Tokens

Public Class Login
    Dim accountRep As New AccountRepository()

    Private Async Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Await LoginApproval()
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

    Private Async Function LoginApproval() As Task
        Try
            Dim username As String = usernameTxtBox.Text
            Dim password As String = passwordTxtBox.Text

            Dim userID As Integer = Await accountRep.Login(username, password)

            If userID = 1 Then
                Dim dashboard As New AdminLogin()
                dashboard.Show()
                Me.Hide()
                Return
            End If
            If userID <> 0 AndAlso userID <> 1 Then
                Dim customer As New MainPage(userID)
                customer.Show()
                Me.Hide()
                Return
            End If

            MessageBox.Show("Your username or password is incorrect", "Incorrect", MessageBoxButtons.OK)
            username = ""
            password = ""
        Catch ex As Exception
            Debug.WriteLine("Error")
        End Try
    End Function
End Class
