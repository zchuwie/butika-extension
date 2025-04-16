Imports System.Runtime.CompilerServices
Imports butika.Configurations
Imports butika.Helpers
Imports butika.Models
Imports Dapper

Public Class SecuritySettings
    Dim accountRep As New AccountRepository()
    Dim account As New Account()
    Public Sub New(account As Account)
        InitializeComponent()
        Me.account = account

    End Sub

    Private Async Sub SecuritySettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If account IsNot Nothing Then
            Debug.WriteLine("SecurityLoad LOADED:")
            Debug.WriteLine("SecurityLoad First Name: " & account.FirstName)
            Debug.WriteLine("SecurityLoad User ID: " & account.UserID)
        Else
            Debug.WriteLine("Account is null or empty.")
            Debug.WriteLine("old pass from load is: " & account.Password)
        End If

        Me.account = Await accountRep.populateDataThroughUserID(account.UserID)
    End Sub

#Region "Functions"
    Private Async Function EditPasswordApproval() As Task
        Dim newPass As String = NewPasswordTxtbox.Text
        Dim confNewPass As String = ConfirmPasswordTxtbox.Text

        If String.IsNullOrEmpty(newPass) OrElse String.IsNullOrEmpty(confNewPass) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        If Not InputValidation.isPasswordValid(newPass) OrElse Not InputValidation.isPasswordValid(confNewPass) Then
            MessageBox.Show("Invalid password format.")
            Return
        End If

        If newPass <> confNewPass Then
            MessageBox.Show("Password must be the same.")
            Return
        End If

        Dim newPasswordInfo As New Account With {
            .Password = newPass
        }

        'Dim updatePasswordSuccess = Await accountRep.UpdatePassword(newPasswordInfo)

        Using conn = DatabaseConnection.GetConnection()
            Try
                Await conn.OpenAsync()

                Dim hash As New PasswordHashing(newPasswordInfo.Password)

                Dim query As String = "
                 UPDATE userAccount 
                 SET 
                        password = @password
                 WHERE user_id = @user_id;
                 "

                Debug.WriteLine("password userid: " + newPasswordInfo.UserID.ToString())

                Dim result As Boolean = Await conn.ExecuteAsync(query, New With {
                     .password = hash.hashCombinedDisplay,
                     .user_id = account.UserID
                 })

                If result <> 0 Then
                    Await accountRep.UpdateHashingData(hash, account.UserID)
                End If

                If Not result Then
                    MessageBox.Show("An error occured. Try again.")
                End If


            Catch ex As Exception
                MessageBox.Show("Error updating password: " & ex.Message)
            End Try
        End Using

        'If updatePasswordSuccess Then
        '    MessageBox.Show("An error occured. Try again.")
        '    Return
        'End If

        MessageBox.Show("Password updated successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'MsgBox("Password updated successfully")
        OldPasswordTxtbox.Text = ""
        NewPasswordTxtbox.Text = ""
        ConfirmPasswordTxtbox.Text = ""
        OldPasswordTxtbox.Enabled = True
        NewPasswordTxtbox.Enabled = False
        ConfirmPasswordTxtbox.Enabled = False

        SaveBtn.Visible = False
        CancelBtn.Visible = False
    End Function
#End Region

    'just in case someone needs this structure (double messagebox)
    'Private Async Sub DeacBtn_Click(sender As Object, e As EventArgs)
    '    If MessageBox.Show("Your account will be deactivated, and you'll not be able to log in.", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
    '        If MessageBox.Show("This action cannot be reverted/reversed.", "Are you really sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
    '            Await DeactivateAccountFunc()
    '            Dim login As New Login
    '            Close()
    '            login.Show()
    '            '            Login Login = New Login()
    '            '            MainPage mp = New MainPage()
    '            '            Admin_ admin = New Admin_(account)
    '            '            admin.Admin_AddUserLog("User_InformationUpdated")
    '            '            mp.Close()
    '            '            this.Close()
    '            '            Login.Show()
    '        End If
    '    End If
    'End Sub


    Private Sub OldPasswordTxtbox_KeyDown(sender As Object, e As KeyEventArgs) Handles OldPasswordTxtbox.KeyDown
        If e.KeyCode = Keys.Enter Then

            Dim storedOldHash As String
            Dim oldPassHash As New PasswordHashing(OldPasswordTxtbox.Text)
            storedOldHash = oldPassHash.hashCombinedDisplay

            If storedOldHash <> account.Password Then
                MessageBox.Show("Wrong password. Try again.", "Wrong Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'MsgBox("Wrong password. Try again.")
            Else
                OldPasswordTxtbox.Enabled = False
                NewPasswordTxtbox.Enabled = True
                ConfirmPasswordTxtbox.Enabled = True

                SaveBtn.Visible = True
                CancelBtn.Visible = True
            End If

        End If
    End Sub

    'only adjust visibility here if there is no error (remember to show error via something ie. msgbox)
    Private Async Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Try
            Await EditPasswordApproval()

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
            Console.Write(ex)
        End Try

        account = Await accountRep.populateDataThroughUserID(account.UserID)
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        OldPasswordTxtbox.Enabled = True
        NewPasswordTxtbox.Enabled = False
        ConfirmPasswordTxtbox.Enabled = False

        NewPasswordTxtbox.Text = ""
        ConfirmPasswordTxtbox.Text = ""
        OldPasswordTxtbox.Text = ""

        SaveBtn.Visible = False
        CancelBtn.Visible = False


    End Sub

    Private Sub OldPasswordTxtbox_TextChanged(sender As Object, e As EventArgs) Handles OldPasswordTxtbox.TextChanged
        'storedOldPass = oldPassHash.ToString
    End Sub
End Class