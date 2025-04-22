Imports System.IO
Imports butika.Models
Imports PdfSharp.Snippets.Drawing

Public Class AddMedicinePanel_InventoryCustodian
    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Me.Close()
    End Sub

    Private Sub loadData()
        prescription_cbox.Items.Add("Yes")
        prescription_cbox.Items.Add("No")
    End Sub

    Dim medicine As New Medicine
    Dim imageName As String
    Dim selectedImagePath As String


    Private Sub chooseImageButton_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox12.Click
        Try
            Using openFileDialog As New OpenFileDialog
                openFileDialog.Filter = "Image Files (*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg"
                If openFileDialog.ShowDialog = DialogResult.OK Then
                    selectedImagePath = openFileDialog.FileName ' Get the selected image's path
                    imageName = medicine.MedicineID.ToString + Path.GetFileName(selectedImagePath)

                End If
                Guna2PictureBox12.Image = Image.FromFile(selectedImagePath) ' Display the image in PictureBox 
            End Using

        Catch ex As Exception

        End Try
    End Sub


    Private Async Sub add_medicine_btn_Click(sender As Object, e As EventArgs) Handles add_medicine_btn.Click
        If String.IsNullOrWhiteSpace(medicine_name_txtbox.Text) OrElse
       String.IsNullOrWhiteSpace(brand_txtbox.Text) OrElse
       String.IsNullOrWhiteSpace(dosage_txtbox.Text) OrElse
       String.IsNullOrWhiteSpace(manufacturer_txtbox.Text) OrElse
       String.IsNullOrWhiteSpace(description_txtbox.Text) OrElse
       String.IsNullOrWhiteSpace(price_txtbox.Text) OrElse
       String.IsNullOrWhiteSpace(stock_txtbox.Text) OrElse
       String.IsNullOrWhiteSpace(expdate_datetime.Text) Then
            MessageBox.Show("Please fill in all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Price validation
        Dim price As Decimal
        If Not Decimal.TryParse(price_txtbox.Text, price) Then
            MessageBox.Show("Invalid price format.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Stock validation
        Dim stock As Integer
        If Not Integer.TryParse(stock_txtbox.Text, stock) Then
            MessageBox.Show("Invalid stock value.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim prescription As Integer
        If prescription_cbox.SelectedIndex = 0 Then
            prescription = 0
        Else
            prescription = 1
        End If

        ' Create a new Medicine object with the provided data
        Dim newMedicine As New Medicine With {
        .MedicineName = medicine_name_txtbox.Text,
        .MedicineBrand = brand_txtbox.Text,
        .MedicineDosage = dosage_txtbox.Text,
        .MedicineManufacturer = manufacturer_txtbox.Text,
        .MedicineType = medtype_txtbox.Text,
        .MedicineDescription = description_txtbox.Text,
        .MedicinePrescription = prescription,
        .MedicinePrice = price,
        .MedicineStock = stock,
        .MedicineExpirationDate = expdate_datetime.Value,
        .MedicineImageName = imageName, ' Assuming the image path is saved here
        .MedicineDateAdded = DateTime.Now
    }
        Dim projectRoot As String = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.FullName
        Dim destinationFolder As String = Path.Combine(projectRoot, GetImagePath.DrugPathName)
        Dim isImageSaved As Boolean = ImageInsertion.SaveImageToFolder(selectedImagePath, imageName, destinationFolder)

        If Not isImageSaved Then
            Debug.WriteLine("Image has not been saved.")
            Return
        End If

        ' Call the AddMedicine method from the MedicineRepository
        Dim repo As New MedicineRepository()
        Await repo.AddMedicine(newMedicine)

        ' Optionally, clear the form fields after successful insertion
        medicine_name_txtbox.Clear()
        brand_txtbox.Clear()
        dosage_txtbox.Clear()
        manufacturer_txtbox.Clear()
        description_txtbox.Clear()
        medtype_txtbox.Clear()
        price_txtbox.Clear()
        stock_txtbox.Clear()
        expdate_datetime.Value = DateTime.Now
        Guna2PictureBox12.Image = My.Resources.Group_78
        imageName = ""

    End Sub

    Private Sub AddMedicinePanel_InventoryCustodian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub clear_fields_btn_Click(sender As Object, e As EventArgs) Handles clear_fields_btn.Click
        medicine_name_txtbox.Clear()
        brand_txtbox.Clear()
        dosage_txtbox.Clear()
        manufacturer_txtbox.Clear()
        description_txtbox.Clear()
        medtype_txtbox.Clear()
        price_txtbox.Clear()
        stock_txtbox.Clear()
        expdate_datetime.Value = DateTime.Now
        Guna2PictureBox12.Image = My.Resources.Group_78
        imageName = ""
    End Sub
End Class