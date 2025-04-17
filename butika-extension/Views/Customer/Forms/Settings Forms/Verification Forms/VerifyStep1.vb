Imports System.ComponentModel.Design
Imports System.IO
Imports butika.Models
Imports Guna.UI2

Public Class VerifyStep1
    Private userID As Integer
    Private accountRepo As New AccountRepository()
    Dim account As New Account()

    Public Sub New(account As Account)
        InitializeComponent()
        Me.account = account
    End Sub

    Dim imageName As String
    Dim selectedImagePath As String

    Private Sub idImage_Click(sender As Object, e As EventArgs) Handles idImage.Click
        'Dim openFileDialog = New OpenFileDialog()
        'openFileDialog.Filter = "Image Files (*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg"

        'If openFileDialog.ShowDialog() = DialogResult.OK Then
        '    selectedImagePath = openFileDialog.FileName
        '    imageName = Path.GetFileName(selectedImagePath).ToString()

        '    idImage.Image = Image.FromFile(selectedImagePath)
        'End If

        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files (*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                selectedImagePath = openFileDialog.FileName ' Get the selected image's path
                IdImgFileName.Text = Path.GetFileName(selectedImagePath) ' Set the file name in the label
                imageName = "userid" + account.UserID.ToString + "_" + account.UserName + "_" + Path.GetFileName(selectedImagePath)

                If Not String.IsNullOrWhiteSpace(selectedImagePath) Then
                    idImage.Image = Image.FromFile(selectedImagePath) ' Display the image in PictureBox
                Else
                    idImage.Image = My.Resources.verifyImage1
                End If
            End If
        End Using
    End Sub

    Private Sub VerifyStep1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IdImgFileName.Text = ""
        idImage.Image = My.Resources.verifyImage1

    End Sub

    Private Sub CancelVerifyBtn_Click(sender As Object, e As EventArgs) Handles CancelVerifyBtn.Click
        Me.Close()
    End Sub

    Private Async Sub SubmitIdBtn_Click(sender As Object, e As EventArgs) Handles SubmitIdBtn.Click
        Dim projectRoot As String = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.FullName
        Dim destinationFolder As String = Path.Combine(projectRoot, GetImagePath.IdImgPathName)
        Dim isImageSaved As Boolean = ImageInsertion.SaveImageToFolder(selectedImagePath, imageName, destinationFolder)

        If Not isImageSaved Then
            Debug.WriteLine("Image has not been saved.")
            Return
        End If

        MessageBox.Show("You have successfully subitted your ID. Please wait while your informatiaon is being verified.", "Success", MessageBoxButtons.OK)

        Dim result As Boolean = Await accountRepo.SetPendingNum(account, 1)
        If result = False Then
            MsgBox("SetPendingNumToZero did not work properly [returned false]")
        End If

        Me.Close()
    End Sub
End Class