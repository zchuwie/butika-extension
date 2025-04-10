Imports System.IO
Imports butika.Models

Public Class SubmitForm

    Dim account As New Account
    Dim imageName As String
    Dim selectedImagePath As String

    Public Sub New(account As Account)
        Me.account = account
        InitializeComponent()
    End Sub

    Private Sub imageView_Click(sender As Object, e As EventArgs) Handles imageView.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files (*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                selectedImagePath = openFileDialog.FileName ' Get the selected image's path
                prescriptionImageLbl.Text = Path.GetFileName(selectedImagePath) ' Set the file name in the label
                imageName = Path.GetFileName(selectedImagePath)

                If Not String.IsNullOrWhiteSpace(selectedImagePath) Then
                    clickAnywhereLbl.SendToBack()
                Else
                    clickAnywhereLbl.BringToFront()
                End If

                imageView.Image = Image.FromFile(selectedImagePath) ' Display the image in PictureBox
            End If
        End Using
    End Sub

    Private Function insertImageIntoFolder() As Boolean
        If String.IsNullOrEmpty(selectedImagePath) Then
            Console.WriteLine("No image selected.")
            Return False
        End If

        Dim projectRoot As String = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.FullName
        Dim destinationFolder As String = Path.Combine(projectRoot, GetImagePath.PrescriptionPathName)
        Dim destinationPath As String = Path.Combine(destinationFolder, imageName)

        Try
            If Not Directory.Exists(destinationFolder) Then
                Console.WriteLine("Folder doesn't exist, creating...")
                Directory.CreateDirectory(destinationFolder)
            End If

            If Not File.Exists(selectedImagePath) Then
                Console.WriteLine("Image file does not exist.")
                Return False
            End If

            File.Copy(selectedImagePath, destinationPath, True) ' Overwrite the existing file

            Console.WriteLine($"Image saved successfully to {destinationPath}!")
            Return True
        Catch ex As Exception
            Console.WriteLine("Error inserting image into the folder: " & ex.Message)
            Return False
        End Try
    End Function

    Private Async Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click
        Dim prescriptRepo As New PrescriptionRepository(account)
        Dim cartRepo As New CartRepository(account)

        Dim pname As String = PatientNameTxtbox.Text
        Dim age As String = PatientAgeTxtbox.Text
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

        Dim isImageSaved As Boolean = insertImageIntoFolder()

        If Not isImageSaved Then
            Console.WriteLine("Image has not been saved.")
            SubmitBtn.Enabled = True
            Return
        End If

        Dim isFormSuccess As Boolean = Await prescriptRepo.InsertPrescriptionDetails(prescription)

        If Not isFormSuccess Then
            Console.WriteLine("Failed inserting the prescription form in db.")
            SubmitBtn.Enabled = True
            Return
        End If

        Dim prescriptionID As Integer = Await prescriptRepo.getPrescriptionID()

        If prescriptionID = 0 Then
            Console.WriteLine("Empty set of prescription error")
            SubmitBtn.Enabled = True
            Return
        End If

        Dim updateTickedItemPrescription As Boolean = Await cartRepo.insertPrescriptionInUsersTicked(prescriptionID)

        If Not updateTickedItemPrescription Then
            Console.WriteLine("Updating prescription id in ticked items in cart error")
            Return
        End If

        MessageBox.Show("You have successfully submitted a form. Please wait for the pharmacist to verify your medicines.", "Success", MessageBoxButtons.OK)
        Me.Close()

    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub

    Private Async Sub SubmitForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim prescriptRepo As New PrescriptionRepository(account)
        DateSubmitted.Text = DateTime.Now.ToString("yyyy-MM-dd")
        Dim prescriptNumber = Await prescriptRepo.countPrescriptionOfUser()
        prescriptNumLbl.Text = "Prescription No. " + prescriptNumber.ToString()


    End Sub
End Class