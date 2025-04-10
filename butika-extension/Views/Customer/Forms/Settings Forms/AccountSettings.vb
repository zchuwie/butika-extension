Imports butika.Configurations
Imports butika.Helpers
Imports butika.Models
Imports Dapper
Imports Microsoft.VisualBasic.ApplicationServices

Public Class AccountSettings

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

        FirstNameTxtbox.Text = account.FirstName
        MiddleInitialTxtbox.Text = account.MiddleInitial
        LastNameTxtbox.Text = account.LastName
        UsernameTxtbox.Text = account.UserName

        usernameStored = UsernameTxtbox.Text

        FillUpProfileInfo()
        FillUpContactInfo()
    End Sub

#Region "Functions"

    Private usernameStored As String
    Private emailStored As String

    Private Sub FillUpProfileInfo()
        FirstNameTxtbox.Text = account.FirstName
        MiddleInitialTxtbox.Text = account.MiddleInitial
        LastNameTxtbox.Text = account.LastName
        UsernameTxtbox.Text = account.UserName

        usernameStored = UsernameTxtbox.Text
    End Sub

    Private Sub FillUpContactInfo()
        EmailTxtbox.Text = account.Email
        MobileNumberTxtbox.Text = account.Contact

        emailStored = EmailTxtbox.Text
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
            FillUpProfileInfo()
            Return
        End If

        Dim existingAccount = Await accountRep.CheckDuplicate(username)
        If existingAccount And usernameStored <> UsernameTxtbox.Text Then
            MessageBox.Show("Username already taken.")
            FillUpProfileInfo()
            Return
        End If

        Dim newProfileInfo As New Account With {
            .FirstName = firstName,
            .MiddleInitial = midName,
            .LastName = lastName,
            .UserName = username,
            .BirthDate = birthday
        }

        Using conn = DatabaseConnection.GetConnection()
            Try
                Await conn.OpenAsync()

                Dim query As String = "
                UPDATE userAccount 
                SET 
                    fullname = @fullname, 
                    first_name = @first_name, 
                    middle_initial = @middle_initial, 
                    last_name = @last_name, 
                    username = @username, 
                    birthdate = @birthdate
                WHERE user_id = @user_id;
                "

                Dim result As Integer = Await conn.ExecuteScalarAsync(Of Integer)(query, New With {
                .fullname = newProfileInfo.FirstName + "" + newProfileInfo.MiddleInitial + "" + newProfileInfo.LastName,
                .first_name = newProfileInfo.FirstName,
                .middle_initial = newProfileInfo.MiddleInitial,
                .last_name = newProfileInfo.LastName,
                .username = newProfileInfo.UserName,
                .birthdate = newProfileInfo.BirthDate,
                .user_id = account.UserID
            })
                If Not result Then
                    MessageBox.Show("An error occured. Try again.")
                    FillUpProfileInfo()
                    Return
                End If

            Catch ex As Exception
                MessageBox.Show("Error updating info: " & ex.Message)
            End Try
        End Using

        MessageBox.Show("Profile updated successfully")
    End Function

    Private Async Function EditContactApproval() As Task
        Dim email As String = EmailTxtbox.Text
        Dim contact As String = MobileNumberTxtbox.Text

        If String.IsNullOrEmpty(email) OrElse String.IsNullOrEmpty(contact) Then
            MessageBox.Show("Please fill in all fields.")
            FillUpContactInfo()
            Return
        End If

        If Not InputValidation.isEmailValid(email) Then
            MessageBox.Show("Invalid email format.")
            FillUpContactInfo()
            Return
        End If

        If Not InputValidation.isContactValid(contact) Then
            MessageBox.Show("Invalid contact format.")
            FillUpContactInfo()
            Return
        End If

        Dim existingEmail = Await accountRep.CheckDuplicateEmail(email)
        If existingEmail And emailStored <> EmailTxtbox.Text Then
            MessageBox.Show("Email already taken.")
            FillUpContactInfo()
            Return
        End If

        Dim newContactInfo As New Account With {
            .Email = email,
            .Contact = contact
        }

        Using conn = DatabaseConnection.GetConnection()
            Try
                Await conn.OpenAsync()

                Dim query As String = "
                 UPDATE userAccount 
                 SET 
                     email = @email, 
                     contact = @contact
                 WHERE user_id = @user_id;
                 "

                Debug.WriteLine("userid: " + account.UserID.ToString())

                Dim result As Boolean = Await conn.ExecuteAsync(query, New With {
                     .email = newContactInfo.Email,
                     .contact = newContactInfo.Contact,
                     .user_id = account.UserID
                 })

                If Not result Then
                    MessageBox.Show("An error occured. Try again.")
                    FillUpContactInfo()
                    Return
                End If


            Catch ex As Exception
                MessageBox.Show("Error updating contact: " & ex.Message)
            End Try
        End Using



        MessageBox.Show("Contact updated successfully")
    End Function
#End Region

#Region "Edit Profile"
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

        FillUpProfileInfo()
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

        FillUpProfileInfo()
    End Sub

    Private Sub BirthdayPicker_ValueChanged(sender As Object, e As EventArgs) Handles BirthdayPicker.ValueChanged
        BirthdayPicker.Format = DateTimePickerFormat.Custom
        BirthdayPicker.CustomFormat = "MM-dd-yyyy"
    End Sub
#End Region

#Region "Contacts"
    Private Sub EditContactBtn_Click(sender As Object, e As EventArgs) Handles EditContactBtn.Click
        EditContactEnable(True, True, False, True, True)

    End Sub

    Private Sub CancelContactBtn_Click(sender As Object, e As EventArgs) Handles CancelContactBtn.Click
        EditContactEnable(False, False, True, False, False)

        FillUpContactInfo()
    End Sub

    Private Async Sub SaveContactBtn_Click(sender As Object, e As EventArgs) Handles SaveContactBtn.Click
        EditContactEnable(False, False, True, False, False)

        Try
            Await EditContactApproval()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
            Console.Write(ex)
        End Try

        FillUpContactInfo()
    End Sub






#End Region

    Private Sub VerifyButton_Click(sender As Object, e As EventArgs) Handles VerifyButton.Click
        Dim verify1 As New VerifyStep1(account)
        verify1.ShowDialog()
    End Sub
End Class