Imports System.IO
Imports butika.Models

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
        Dim openFileDialog = New OpenFileDialog()
        openFileDialog.Filter = "Image Files (*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            selectedImagePath = openFileDialog.FileName
            imageName = Path.GetFileName(selectedImagePath).ToString()

            idImage.Image = Image.FromFile(selectedImagePath)
        End If

        'If (openFileDialog.ShowDialog() == DialogResult.OK) Then {

        '            selectedImagePath = openFileDialog.FileName; // Get the selected image's path
        '            prescriptionImageLbl.Text = Path.GetFileName(selectedImagePath); // Set the file name In the TextBox
        '            imageName = Path.GetFileName(selectedImagePath).ToString();

        '            If (!string.IsNullOrWhiteSpace(selectedImagePath)) Then {
        '                clickAnywhereLbl.SendToBack();
        '            } else {
        '                clickAnywhereLbl.BringToFront();
        '            }

        '            imageView.Image = Image.FromFile(selectedImagePath); // Display the image In PictureBox

    End Sub
End Class