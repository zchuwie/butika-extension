Imports butika.Models
Imports butika.Helpers

Public Class ForgetPassword
    Private verificationStep As Integer = 1
    Private remainingTime As Integer = 59
    Private labelArray As Label()
    Private account As Account = New Account()

#Region "UI with Logic Bind"
    Private Sub backToLogin_Click(sender As Object, e As EventArgs) Handles backToLogin.Click
        Dim login As New Login()
        login.Show()
        Me.Close()
    End Sub

    Private Sub getVerificationBtn_Click(sender As Object, e As EventArgs) Handles getVerificationBtn.Click
        verificationStep = 2

        Dim userEmail As String = verificationEmailTxtBox.Text
        Dim isEmailValid As Boolean = InputValidation.isEmailValid(userEmail)

        If Not isEmailValid Then
            invalidEmailLabel.Visible = True
            Debug.WriteLine("Email is not valid input")
            Return
        End If

        emailLabel.Text = userEmail
        invalidEmailLabel.Visible = False
        changeTextSidePanel()
        ShowOnlyPanel(verifyPanel)

    End Sub

    Private Sub codeBtn_Click(sender As Object, e As EventArgs) Handles codeBtn.Click
        verificationStep = 3

        emailLabel.Text = account.Email
        changeTextSidePanel()
        ShowOnlyPanel(passwordPanel)
    End Sub

    Private Sub passwordChangeBtn_Click(sender As Object, e As EventArgs) Handles passwordChangeBtn.Click
        verificationStep = 4
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

    Private Sub resendLabel_Click(sender As Object, e As EventArgs) Handles resendLabel.Click
        ongoingOtpPanel.Visible = True
        clickToResendPanel.Visible = False
        codeTimer.Start()
    End Sub

    Private Sub verificationEmailTxtBox_TextChanged(sender As Object, e As EventArgs) Handles verificationEmailTxtBox.TextChanged
        invalidEmailLabel.Visible = False
    End Sub

#End Region
End Class