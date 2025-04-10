Imports Microsoft.IdentityModel.Tokens
Imports Microsoft.VisualBasic.ApplicationServices

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

            ' Get both user_id and userType from the Login function as a tuple
            Dim loginResult = Await accountRep.Login(username, password)
            Dim userID As Integer = loginResult.Item1
            Dim userType As Integer = loginResult.Item2

            ' Check userID and route to respective pages based on userType
            If userID > 0 Then
                If userType = 1 Then
                    ' Admin user
                    Dim activityLogged As Boolean = Await AdminRepository.AddActivityLogAsync(userID, userType)
                    Dim dashboard As New adminPage()
                    dashboard.Show()
                    Me.Hide()
                ElseIf userType = 2 Then
                    ' Pharma user
                    Dim activityLogged As Boolean = Await AdminRepository.AddActivityLogAsync(userID, userType)
                    Dim dashboard As New pharmaMainPage()
                    dashboard.Show()
                    Me.Hide()
                ElseIf userType = 3 Then
                    ' Inventory Custodian user
                    Dim activityLogged As Boolean = Await AdminRepository.AddActivityLogAsync(userID, userType)
                    Dim dashboard As New InventoryCustodian_MainPanel()
                    dashboard.Show()
                    Me.Hide()
                Else
                    ' Regular user
                    Dim activityLogged As Boolean = Await AdminRepository.AddActivityLogAsync(userID, userType)
                    If activityLogged Then
                        Dim customer As New MainPage(userID)
                        customer.Show()
                        Me.Hide()
                    End If
                End If
            Else
                ' Invalid credentials
                MessageBox.Show("Your username or password is incorrect", "Incorrect", MessageBoxButtons.OK)
                usernameTxtBox.Clear()
                passwordTxtBox.Clear()
            End If
        Catch ex As Exception
            Debug.WriteLine("Error during login: " & ex.Message)
            MessageBox.Show("An error occurred. Please try again.", "Error", MessageBoxButtons.OK)
        End Try
    End Function

End Class
