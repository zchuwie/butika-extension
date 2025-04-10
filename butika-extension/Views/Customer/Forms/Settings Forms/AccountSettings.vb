Imports butika.Helpers
Imports butika.Models
Imports Microsoft.VisualBasic.ApplicationServices

Public Class AccountSettings

#Region "Functions"

    Private usernameStored As String
    Private Async Sub FillUpInfo()
        FirstNameTxtbox.Text = account.FirstName
        MiddleInitialTxtbox.Text = account.MiddleInitial
        LastNameTxtbox.Text = account.LastName
        UsernameTxtbox.Text = account.UserName

        EmailTxtbox.Text = account.Email
        MobileNumberTxtbox.Text = account.Contact

        usernameStored = UsernameTxtbox.Text
    End Sub

    'handles editProfile element's enability or visibility
    Private Sub EditProfileEnable(ByVal first As Boolean, ByVal mid As Boolean, ByVal last As Boolean, ByVal username As Boolean, ByVal bday As Boolean, ByVal profEdit As Boolean, ByVal profCancel As Boolean, ByVal profSave As Boolean)
        FirstNameTxtbox.Enabled = first
        MiddleInitialTxtbox.Enabled = mid
        LastNameTxtbox.Enabled = last
        UsernameTxtbox.Enabled = username
        BirthdayPicker.Enabled = bday

        EditProfileBtn.Visible = profEdit
        CancelProfileBtn.Visible = profCancel
        SaveProfileBtn.Visible = profSave
    End Sub

    Private Sub EditContactEnable(ByVal email As Boolean, ByVal mobile As Boolean, ByVal contactEdit As Boolean, ByVal contactCancel As Boolean, ByVal contactSave As Boolean)
        EmailTxtbox.Enabled = email
        MobileNumberTxtbox.Enabled = mobile

        EditContactBtn.Visible = contactEdit
        CancelContactBtn.Visible = contactCancel
        SaveContactBtn.Visible = contactSave
    End Sub

    Private Async Function EditProfileApproval() As Task
        Dim firstName As String = FirstNameTxtbox.Text
        Dim midName As String = MiddleInitialTxtbox.Text
        Dim lastName As String = LastNameTxtbox.Text
        Dim username As String = UsernameTxtbox.Text
        Dim birthday As Date = BirthdayPicker.Value

        If String.IsNullOrEmpty(firstName) OrElse String.IsNullOrEmpty(midName) OrElse
       String.IsNullOrEmpty(lastName) OrElse String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(birthday) Then
            MessageBox.Show("Please fill in all fields.")
            FillUpInfo()
            Return
        End If

        Dim existingAccount = Await accountRep.CheckDuplicate(username)
        If existingAccount And username <> UsernameTxtbox.Text Then
            MessageBox.Show("Username already taken.")
            FillUpInfo()
            Return
        End If

        Dim newProfileInfo As New Account With {
            .FirstName = firstName,
            .MiddleInitial = midName,
            .LastName = lastName,
            .UserName = username,
            .BirthDate = birthday
        }

        Dim signUpSuccess = Await accountRep.UpdateProfileInfo(newProfileInfo)
        If Not signUpSuccess Then
            MessageBox.Show("An error occured. Try again.")
            FillUpInfo()
            Return
        End If

        MessageBox.Show("Profile updated successfully")

        Dim login As New Login()
        login.Show()
        Me.Close()
    End Function
#End Region

    Dim accountRep As New AccountRepository()
    Dim account As New Account()

    Public Sub New(account As Account)
        InitializeComponent()
        Me.account = account
    End Sub

    Private Sub AccountSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If account IsNot Nothing Then
            Debug.WriteLine("AccountLoad LOADED:")
            Debug.WriteLine("AccountLoad First Name: " & account.FirstName)
            Debug.WriteLine("AccountLoad User ID: " & account.UserID)
        Else
            Debug.WriteLine("Account is null or empty.")
        End If

        If account.BirthDate IsNot Nothing Then
            BirthdayPicker.CustomFormat = "MM-dd-yyyy"
            BirthdayPicker.Value = account.BirthDate
        Else
            BirthdayPicker.Value = DateTime.Now ' Or any safe default
            BirthdayPicker.Format = DateTimePickerFormat.Custom
            BirthdayPicker.CustomFormat = " "

        End If

        FillUpInfo()
    End Sub

    Private Sub EditProfileBtn_Click(sender As Object, e As EventArgs) Handles EditProfileBtn.Click
        EditProfileEnable(True, True, True, True, True, False, True, True)
    End Sub

    Private Sub CancelProfileBtn_Click(sender As Object, e As EventArgs) Handles CancelProfileBtn.Click
        EditProfileEnable(False, False, False, False, False, True, False, False)

        If account.BirthDate IsNot Nothing Then
            BirthdayPicker.CustomFormat = "MM-dd-yyyy"
            BirthdayPicker.Value = account.BirthDate
        Else
            BirthdayPicker.Value = DateTime.Now ' Or any safe default
            BirthdayPicker.Format = DateTimePickerFormat.Custom
            BirthdayPicker.CustomFormat = " "

        End If

        FillUpInfo()
    End Sub

    Private Async Sub SaveProfileBtn_Click(sender As Object, e As EventArgs) Handles SaveProfileBtn.Click
        Try
            Await EditProfileApproval()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
            Console.Write(ex)
        End Try

        EditProfileEnable(False, False, False, False, False, True, False, False)

        If account.BirthDate IsNot Nothing Then
            BirthdayPicker.CustomFormat = "MM-dd-yyyy"
            BirthdayPicker.Value = account.BirthDate
        Else
            BirthdayPicker.Value = DateTime.Now ' Or any safe default
            BirthdayPicker.Format = DateTimePickerFormat.Custom
            BirthdayPicker.CustomFormat = " "

        End If

        FillUpInfo()
    End Sub

    Private Sub BirthdayPicker_ValueChanged(sender As Object, e As EventArgs) Handles BirthdayPicker.ValueChanged
        BirthdayPicker.Format = DateTimePickerFormat.Custom
        BirthdayPicker.CustomFormat = "MM-dd-yyyy"
    End Sub
End Class