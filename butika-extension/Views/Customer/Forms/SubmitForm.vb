Imports System.IO
Imports butika.Helpers
Imports butika.Models
Imports Guna.UI2.WinForms
Imports PdfSharp.Snippets.Drawing

Public Class SubmitForm

    Dim account As New Account
    Dim imageName As String
    Dim selectedImagePath As String

    Dim isDirect As Boolean
    Public Property DidSubmitted As Boolean

    Public Sub New(account As Account, isDirect As Boolean)
        Me.account = account
        Me.isDirect = isDirect

        InitializeComponent()
    End Sub

    Private Sub imageView_Click(sender As Object, e As EventArgs) Handles imageView.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files (*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                selectedImagePath = openFileDialog.FileName ' Get the selected image's path
                prescriptionImageLbl.Text = Path.GetFileName(selectedImagePath) ' Set the file name in the label
                imageName = account.UserName + Path.GetFileName(selectedImagePath)

                If Not String.IsNullOrWhiteSpace(selectedImagePath) Then
                    clickAnywhereLbl.SendToBack()
                Else
                    clickAnywhereLbl.BringToFront()
                End If

                imageView.Image = Image.FromFile(selectedImagePath) ' Display the image in PictureBox
            End If
        End Using
    End Sub


    Private Async Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click
        Dim prescriptRepo As New PrescriptionRepository(account)
        Dim cartRepo As New CartRepository(account)

        If Not AreInputsValid() Then
            MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrEmpty(selectedImagePath) OrElse Not File.Exists(selectedImagePath) Then
            MessageBox.Show("Please upload an image before submitting the form.", "Image Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim pname As String = PatientNameTxtbox.Text
        Dim age As String = PatientAgeTxtbox.Text.Trim()
        Dim dname As String = DocNameTxtbox.Text
        Dim clinic As String = ClinicTxtbox.Text
        Dim contact As String = ContactTxtbox.Text
        Dim brieftext As String = BriefInfoTextbox.Text
        Dim dateSubmitted As DateTime = DateTime.Now

        Dim prescription As New Prescription() With {
        .PatientName = pname,
        .PatientAge = age,
        .DoctorName = dname,
        .DoctorPlace = clinic,
        .DoctorContact = contact,
        .PatientConcern = brieftext,
        .PrescriptionImageName = imageName,
        .PrescriptionDate = dateSubmitted.ToString("yyyy-MM-dd HH:mm")
        }

        Dim projectRoot As String = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.FullName
        Dim destinationFolder As String = Path.Combine(projectRoot, GetImagePath.PrescriptionPathName)
        Dim isImageSaved As Boolean = ImageInsertion.SaveImageToFolder(selectedImagePath, imageName, destinationFolder)

        If Not isImageSaved Then
            Debug.WriteLine("Image has not been saved.")
            SubmitBtn.Enabled = True
            Return
        End If

        Dim isFormSuccess As Boolean = Await prescriptRepo.InsertPrescriptionDetails(prescription)

        If Not isFormSuccess Then
            Debug.WriteLine("Failed inserting the prescription form in db.")
            SubmitBtn.Enabled = True
            Return
        End If

        Dim prescriptionID As Integer = Await prescriptRepo.getPrescriptionID()

        If prescriptionID = 0 Then
            Debug.WriteLine("Empty set of prescription error")
            SubmitBtn.Enabled = True
            Return
        End If

        If isDirect = True Then
            DidSubmitted = True
            Me.Close()
            Return
        End If

        Dim updateTickedItemPrescription As Boolean = Await cartRepo.insertPrescriptionInUsersTicked(prescriptionID)

        If Not updateTickedItemPrescription Then
            Console.WriteLine("Updating prescription id in ticked items in cart error")
            Return
        End If

        MessageBox.Show("You have successfully submitted a form. Please wait for the pharmacist to verify your medicines.", "Success", MessageBoxButtons.OK)
        Await AdminRepository.AddActivityLogAsync(SessionInfo.CurrentUserID, SessionInfo.CurrentUserType, "Customer submitted a form")

        Me.Close()

    End Sub

    Private Async Sub SubmitForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim prescriptRepo As New PrescriptionRepository(account)
        DateSubmitted.Text = DateTime.Now.ToString("yyyy-MM-dd")
        Dim prescriptNumber = Await prescriptRepo.countPrescriptionOfUser()
        prescriptNumLbl.Text = "Prescription No. " + prescriptNumber.ToString()
        ClickAll()

    End Sub

#Region "Validation"

    Private Sub PatientAgeTxtbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PatientAgeTxtbox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Block the key from being entered
        End If
    End Sub

    Private Sub PatientAgeTxtbox_TextChanged(sender As Object, e As EventArgs) Handles PatientAgeTxtbox.TextChanged
        With PatientAgeTxtbox
            Dim input As String = .Text.Trim()

            If String.IsNullOrEmpty(input) Then
                .BorderColor = Color.Black
                .FocusedState.BorderColor = Color.Black
            ElseIf Not IsNumeric(input) Then
                .BorderColor = Color.Red
                .FocusedState.BorderColor = Color.Red
            Else
                Dim age As Integer = CInt(input)
                Dim isValid As Boolean = age >= 0 AndAlso age <= 120

                .BorderColor = If(isValid, Color.Black, Color.Red)
                .FocusedState.BorderColor = If(isValid, Color.Black, Color.Red)
            End If
        End With

    End Sub

    Private Sub ContactTxtbox_TextChanged(sender As Object, e As EventArgs) Handles ContactTxtbox.TextChanged
        With ContactTxtbox
            Dim input As String = .Text.Trim()

            If String.IsNullOrEmpty(input) Then
                .BorderColor = Color.Black
                .FocusedState.BorderColor = Color.Black
            Else
                Dim isValid As Boolean = InputValidation.isContactValid(input)

                .BorderColor = If(isValid, Color.Black, Color.Red)
                .FocusedState.BorderColor = If(isValid, Color.Black, Color.Red)
            End If
        End With

    End Sub

    Private Sub ContactTxtbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ContactTxtbox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Block the key from being entered
        End If
    End Sub

    Private Function AreInputsValid() As Boolean
        If String.IsNullOrWhiteSpace(PatientNameTxtbox.Text) Then Return False
        If String.IsNullOrWhiteSpace(PatientAgeTxtbox.Text) Then Return False
        If String.IsNullOrWhiteSpace(DocNameTxtbox.Text) Then Return False
        If String.IsNullOrWhiteSpace(ClinicTxtbox.Text) Then Return False
        If String.IsNullOrWhiteSpace(ContactTxtbox.Text) Then Return False
        If String.IsNullOrWhiteSpace(BriefInfoTextbox.Text) Then Return False
        Return True
    End Function


#End Region
    Private Sub ClickAll()
        AddHandler clickAnywhereLbl.Click, Sub(sender, e) Call imageView_Click(sender, e)
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Close()
    End Sub
End Class