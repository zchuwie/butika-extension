Imports Microsoft.IdentityModel.Tokens
Imports Microsoft.VisualBasic.ApplicationServices

Public Class Login
    Dim accountRep As New AccountRepository()
    Dim userId = SessionInfo.CurrentUserID
    Dim userType = SessionInfo.CurrentUserType

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
        loginBtn.Enabled = False

        Try
            Dim username As String = usernameTxtBox.Text
            Dim password As String = passwordTxtBox.Text
            Dim loginResult = Await accountRep.Login(username, password)
            Dim userID As Integer = loginResult.Item1
            Dim userType As Integer = loginResult.Item2

            If userID > 0 Then
                SessionInfo.CurrentUserID = userID
                SessionInfo.CurrentUserType = userType

                Await AdminRepository.AddActivityLogAsync(userID, userType)

                Select Case userType
                    Case 1
                        Dim adminForm As New adminPage()
                        adminForm.Show()
                    Case 2
                        Dim pharmaForm As New pharmaMainPage()
                        pharmaForm.Show()
                    Case 3
                        Dim inventoryForm As New InventoryCustodian_MainPanel()
                        inventoryForm.Show()
                    Case Else
                        Dim customerForm As New MainPage(userID)
                        customerForm.Show()
                End Select

                Me.Hide()
            Else
                MessageBox.Show("Your username or password is incorrect.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                usernameTxtBox.Clear()
                passwordTxtBox.Clear()
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred during login: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            loginBtn.Enabled = True
        End Try
    End Function


End Class
