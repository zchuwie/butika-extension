Imports System.IO
Imports butika.Models

Public Class AddMedicinePanel_InventoryCustodian
    Dim imagePathTextBox As String
    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Me.Close()
    End Sub

    Private Sub loadData()
        prescription_cbox.Items.Add("Yes")
        prescription_cbox.Items.Add("No")
    End Sub

    Private Sub chooseImageButton_Click(sender As Object, e As EventArgs) Handles addimage_btn.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png"
            If ofd.ShowDialog() = DialogResult.OK Then
                ' Get the selected image file path
                Dim selectedImagePath As String = ofd.FileName

                ' Define the folder where the image will be saved (relative to the application folder)
                Dim imageFolderPath As String = Path.Combine(Application.StartupPath, "drug_images")

                ' Ensure the folder exists, create it if necessary
                If Not Directory.Exists(imageFolderPath) Then
                    Directory.CreateDirectory(imageFolderPath)
                End If

                ' Get the filename and extension of the selected image
                Dim imageFileName As String = Path.GetFileName(selectedImagePath)
                Dim targetImagePath As String = Path.Combine(imageFolderPath, imageFileName)

                ' If the file already exists, append a number to make the name unique
                Dim index As Integer = 1
                While File.Exists(targetImagePath)
                    targetImagePath = Path.Combine(imageFolderPath, Path.GetFileNameWithoutExtension(imageFileName) & $"({index})" & Path.GetExtension(imageFileName))
                    index += 1
                End While

                ' Copy the selected image to the target folder
                File.Copy(selectedImagePath, targetImagePath, overwrite:=False)

                ' Optionally, show the image in a PictureBox (if you want to display the image in the form)
                addimage_btn.Image = Image.FromFile(targetImagePath)

                ' Store the path of the image in a textbox or hidden field (for use when saving to the database)
                imagePathTextBox = imageFileName
            End If
        End Using
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
        .MedicineImageName = imagePathTextBox ' Assuming the image path is saved here
    }

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
        imagePathTextBox = ""

    End Sub

    Private Sub AddMedicinePanel_InventoryCustodian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub
End Class