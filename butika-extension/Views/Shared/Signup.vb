Imports System.Runtime.CompilerServices
Imports butika.Helpers
Imports butika.Models

Public Class Signup
    Dim accountRep As New AccountRepository()
    Private Sub signUpTxtBtn_Click(sender As Object, e As EventArgs) Handles signUpTxtBtn.Click
        Dim login As New Login()
        login.Show()
        Me.Close()
    End Sub

    Private Async Sub signUpBtn_Click(sender As Object, e As EventArgs) Handles signUpBtn.Click
        signUpBtn.Text = "Signing In..."
        signUpBtn.Enabled = False

        Try
            Await signUpApproval()
            signUpBtn.Text = "Sign Up"
            signUpBtn.Enabled = True
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
            signUpBtn.Text = "Sign Up"
            signUpBtn.Enabled = True
        End Try

    End Sub

    Private Async Function signUpApproval() As Task
        Dim username As String = usernameTxtBox.Text
        Dim email As String = emailTxtBox.Text
        Dim password As String = PasswordTxtBox.Text
        Dim confirmedPass As String = ConfirmPasswordTxtBox.Text

        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(email) OrElse
       String.IsNullOrEmpty(password) OrElse String.IsNullOrEmpty(confirmedPass) Then
            MessageBox.Show("Looks like you missed something. Please fill out all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            ClearTextFields()
            Return
        End If

        Dim existingAccount = Await accountRep.CheckDuplicate(username)
        If existingAccount Then
            MessageBox.Show("Username has been already taken. Use other username", "Existing account", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ClearTextFields()
            Return
        End If

        If Not InputValidation.isEmailValid(email) Then
            MessageBox.Show("Invalid email format.")
            ClearTextFields()
            Return
        End If

        If Not InputValidation.isPasswordValid(password) Then
            MessageBox.Show("Password must be at least 8 characters long and contain at least one uppercase letter, one number, and one special character.")
            ClearTextFields()
            Return
        End If

        If password <> confirmedPass Then
            MessageBox.Show("Passwords do not match.")
            Return
        End If

        Dim newAccount As New Account With {
            .UserName = username,
            .Email = email,
            .Password = password,
            .DateJoined = DateTime.Now
        }

        Dim signUpSuccess = Await accountRep.Signup(newAccount)
        If Not signUpSuccess Then
            MessageBox.Show("An error occured. Try again.")
            ClearTextFields()
            Return
        End If


        Dim userID As Integer = Await AdminRepository.GetLastInsertedUserID()
        Dim signupLogged As Boolean = Await AdminRepository.AddSignupLogAsync(userID)

        MessageBox.Show("Account created successfully")

        Dim login As New Login()
        login.Show()
        Me.Close()
    End Function

    Private Sub ClearTextFields()
        usernameTxtBox.Clear()
        emailTxtBox.Clear()
        PasswordTxtBox.Clear()
        ConfirmPasswordTxtBox.Clear()
    End Sub

    Private Sub usernameTxtBox_KeyDown(sender As Object, e As KeyEventArgs) Handles usernameTxtBox.KeyDown
        HelperMethod.KeyCode(e, emailTxtBox)
    End Sub

    Private Sub emailTxtBox_KeyDown(sender As Object, e As KeyEventArgs) Handles emailTxtBox.KeyDown
        HelperMethod.KeyCode(e, PasswordTxtBox)
    End Sub

    Private Sub PasswordTxtBox_KeyDown(sender As Object, e As KeyEventArgs) Handles PasswordTxtBox.KeyDown
        HelperMethod.KeyCode(e, ConfirmPasswordTxtBox)
    End Sub

    Private Sub ConfirmPasswordTxtBox_KeyDown(sender As Object, e As KeyEventArgs) Handles ConfirmPasswordTxtBox.KeyDown
        HelperMethod.KeyCode(e, signUpBtn)
    End Sub
End Class