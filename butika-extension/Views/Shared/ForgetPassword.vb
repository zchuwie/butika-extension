Imports butika.Models
Imports butika.Helpers
Imports butika.Services

Public Class ForgetPassword
    Private verificationStep As Integer = 1
    Private remainingTime As Integer = 59
    Private labelArray As Label()
    Dim account As New Account()
    Dim accountRepo As New AccountRepository()
    Dim verificationCode As String

#Region "UI with Logic Bind"
    Private Sub backToLogin_Click(sender As Object, e As EventArgs) Handles backToLogin.Click
        Dim login As New Login()
        login.Show()
        Me.Close()
    End Sub

    Private Async Sub getVerificationBtn_Click(sender As Object, e As EventArgs) Handles getVerificationBtn.Click
        verificationStep = 2
        getVerificationBtn.Enabled = False
        getVerificationBtn.Text = "Loading"

        Dim userEmail As String = verificationEmailTxtBox.Text
        Dim isEmailValid As Boolean = InputValidation.isEmailValid(userEmail)
        Dim doesEmailExists As Boolean = Await accountRepo.CheckDuplicateEmail(userEmail)

        If Not isEmailValid Then
            invalidEmailLabel.Visible = True
            Debug.WriteLine("Email is not valid input")
            getVerificationBtn.Text = "Get a verification code"
            getVerificationBtn.Enabled = True
            Return
        End If

        If Not doesEmailExists Then
            MessageBox.Show("You have no record of your email in the database.")
            getVerificationBtn.Text = "Get a verification code"
            getVerificationBtn.Enabled = True
            Return
        End If

        emailLabel.Text = userEmail
        invalidEmailLabel.Visible = False

        account = Await accountRepo.populateDataThroughEmail(userEmail)
        Dim emailVerification As New EmailVerification(account)

        verificationCode = Await emailVerification.SendVerificationCodeForPassword()

        getVerificationBtn.Enabled = True
        getVerificationBtn.Text = "Get a verification code"


        changeTextSidePanel()
        ShowOnlyPanel(verifyPanel)

    End Sub

    Private Sub codeBtn_Click(sender As Object, e As EventArgs) Handles codeBtn.Click
        verificationStep = 3

        emailLabel.Text = account.Email
        Dim code As String = codeTxtBox.Text

        If Not code = verificationCode Then
            MessageBox.Show("Your input is incorrect. Try again.")
            Return
        End If

        changeTextSidePanel()
        ShowOnlyPanel(passwordPanel)
    End Sub

    Private Async Sub passwordChangeBtn_Click(sender As Object, e As EventArgs) Handles passwordChangeBtn.Click
        verificationStep = 4

        Dim password As String = passwordTxtBox.Text
        Dim confirmPassword As String = confirmPassTxtBox.Text

        Dim isPasswordValid As Boolean = InputValidation.isPasswordValid(password)

        If Not isPasswordValid Then
            MessageBox.Show("Make sure your password contains 8 characters, a capital letter, a number, and a symbol")
            Return
        End If

        If Not password.Equals(confirmPassword) Then
            MessageBox.Show("Your password does not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        account.Password = confirmPassword

        Dim isPasswordUpdated As Boolean = Await accountRepo.UpdatePassword(account)

        If Not isPasswordUpdated Then
            MessageBox.Show("An error occurred updating your password. Try again")
            Return
        End If

        changeTextSidePanel()
        ShowOnlyPanel(successPanel)

        backToLoginPanel.Visible = False
    End Sub

    Private Sub ShowOnlyPanel(panel As Panel)
        verifyPanel.Visible = False
        passwordPanel.Visible = False
        successPanel.Visible = False

        panel.Visible = True
    End Sub

    Private Sub successVerificationBtn_Click(sender As Object, e As EventArgs) Handles successVerificationBtn.Click
        Dim login As New Login
        login.Show()
        Me.Close()
    End Sub

    Private Sub ForgetPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        labelArray = {VerificationStep1, VerificationStep2, VerificationStep3, VerificationStep4}
        changeTextSidePanel()

    End Sub

    Private Sub changeTextSidePanel()
        For i As Integer = 0 To labelArray.Length - 1
            If i = verificationStep - 1 Then
                labelArray(i).Font = New Font(labelArray(i).Font, FontStyle.Bold)
            Else
                labelArray(i).Font = New Font(labelArray(i).Font, FontStyle.Regular)
            End If
        Next
    End Sub

    Private Sub codeTimer_Tick(sender As Object, e As EventArgs) Handles codeTimer.Tick
        If remainingTime > 0 Then
            remainingTime -= 1
            secondsTickingLabel.Text = remainingTime.ToString() & "s"
        Else
            codeTimer.Stop()
            ongoingOtpPanel.Visible = False
            clickToResendPanel.Visible = True
            remainingTime = 60
        End If
    End Sub

    Private Async Sub resendLabel_Click(sender As Object, e As EventArgs) Handles resendLabel.Click
        resendLabel.Enabled = False
        resendLabel.ForeColor = Color.Gray

        Dim emailVerification As New EmailVerification(account)
        verificationCode = Await emailVerification.SendVerificationCodeForPassword()

        ongoingOtpPanel.Visible = True
        clickToResendPanel.Visible = False
        codeTimer.Start()

        resendLabel.Enabled = True
        resendLabel.ForeColor = Color.FromArgb(22, 66, 60)


    End Sub

    Private Sub verificationEmailTxtBox_TextChanged(sender As Object, e As EventArgs) Handles verificationEmailTxtBox.TextChanged
        invalidEmailLabel.Visible = False
    End Sub

#End Region
End Class