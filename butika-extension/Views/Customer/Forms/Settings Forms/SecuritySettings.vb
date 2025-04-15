Imports System.Runtime.CompilerServices
Imports butika.Configurations
Imports butika.Helpers
Imports butika.Models
Imports Dapper

Public Class SecuritySettings
    Dim account As New Account()
    Dim storedPass As String = account.Password

    Public Sub New(account As Account)
        InitializeComponent()
        Me.account = account
    End Sub

#Region "Functions"
    Private Async Function DeactivateAccountFunc() As Task

        Using conn = DatabaseConnection.GetConnection()
            Try
                Await conn.OpenAsync()

                Dim query As String = "
                 UPDATE userAccount 
                 SET 
                        status = @status
                 WHERE user_id = @user_id;
                 "

                Debug.WriteLine("userid: " + account.UserID.ToString())

                Dim result As Boolean = Await conn.ExecuteAsync(query, New With {
                     .status = "inactive",
                     .user_id = account.UserID
                 })

                If Not result Then
                    MessageBox.Show("An error occured. Try again.")
                    Return
                End If


            Catch ex As Exception
                MessageBox.Show("Error deactivating account: " & ex.Message)
            End Try
        End Using

        MessageBox.Show("Account deactivated successfully")
    End Function

#End Region

    Private Sub SecuritySettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If account IsNot Nothing Then
            Debug.WriteLine("SecurityLoad LOADED:")
            Debug.WriteLine("SecurityLoad First Name: " & account.FirstName)
            Debug.WriteLine("SecurityLoad User ID: " & account.UserID)
        Else
            Debug.WriteLine("Account is null or empty.")
        End If
    End Sub

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

    Private Sub EditSecurityBtn_Click(sender As Object, e As EventArgs)
        AdjustVisibility(False, True, True, True, True, True)

    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs)
        AdjustVisibility(True, False, False, False, False, False)
    End Sub

    'only adjust visibility here if there is no error (remember to show error via something ie. msgbox)
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs)
        AdjustVisibility(True, False, False, False, False, False)

        If storedPass = OldPasswordTxtbox.Text.Trim Then
            NewPasswordTxtbox
        End If
    End Sub
End Class