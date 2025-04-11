Imports System.IO
Imports butika.Helpers
Imports butika.Models

Public Class ViewMedicineBar

    Public Property MedicineInfo As Medicine
    Private selectedImagePath As String = String.Empty

    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Me.Close()
    End Sub

    Private Sub edit_medicine_btn_Click(sender As Object, e As EventArgs) Handles edit_medicine_btn.Click
        ToggleEditMode(True)
    End Sub

    Private Sub cancel_update_btn_Click(sender As Object, e As EventArgs) Handles cancel_update_btn.Click
        ToggleEditMode(False)
    End Sub

    Private Sub ToggleEditMode(enabled As Boolean)
        medicine_name_txtbox.ReadOnly = Not enabled
        brand_txtbox.ReadOnly = Not enabled
        dosage_txtbox.ReadOnly = Not enabled
        manufacturer_txtbox.ReadOnly = Not enabled
        description_txtbox.ReadOnly = Not enabled
        price_txtbox.ReadOnly = Not enabled
        medtype_txtbox.ReadOnly = Not enabled
        stock_txtbox.ReadOnly = Not enabled
        prescription_cbox.Enabled = enabled
        expdate_datetime.Enabled = enabled
        addimage_btn.Enabled = enabled

        save_update_btn.Visible = enabled
        save_update_btn.Enabled = enabled
        cancel_update_btn.Visible = enabled
        cancel_update_btn.Enabled = enabled
        edit_medicine_btn.Visible = Not enabled
        edit_medicine_btn.Enabled = Not enabled
    End Sub

    Private Sub LoadMedicineData(sender As Object, e As EventArgs) Handles MyBase.Load
        ToggleEditMode(False)

        medicine_id_lbl.Text = "Medicine ID# " + MedicineInfo.MedicineID.ToString()
        medicine_added_date_lbl.Text = "Date added: " + MedicineInfo.MedicineDateAdded
        If MedicineInfo.MedicineLastUpdated = Nothing Then
            medicine_updated_date_lbl.Text = ""
        Else
            medicine_updated_date_lbl.Text = "Last updated: " + MedicineInfo.MedicineLastUpdated.ToString("yyyy-MM-dd HH:mm:ss")
        End If


        prescription_cbox.Items.Add("No")
        prescription_cbox.Items.Add("Yes")

        If MedicineInfo IsNot Nothing Then
            medicine_name_txtbox.Text = MedicineInfo.FormattedMedicineName
            brand_txtbox.Text = HelperMethod.CapitalizeEachFirstWord(MedicineInfo.MedicineBrand)
            dosage_txtbox.Text = HelperMethod.CapitalizeEachFirstWord(MedicineInfo.MedicineDosage)
            manufacturer_txtbox.Text = HelperMethod.CapitalizeEachFirstWord(MedicineInfo.MedicineManufacturer)
            description_txtbox.Text = MedicineInfo.MedicineDescription
            price_txtbox.Text = MedicineInfo.MedicinePrice.ToString("F2")
            medtype_txtbox.Text = HelperMethod.CapitalizeEachFirstWord(MedicineInfo.MedicineType)
            stock_txtbox.Text = MedicineInfo.MedicineStock.ToString()
            expdate_datetime.Value = MedicineInfo.MedicineExpirationDate

            If MedicineInfo.MedicinePrescription = 0 Then
                prescription_cbox.SelectedIndex = 0
            Else
                prescription_cbox.SelectedIndex = 1
            End If

            ' Load image if exists
            If File.Exists(MedicineInfo.MedicineImagePath) Then
                addimage_btn.Image = Image.FromFile(MedicineInfo.MedicineImagePath)
            End If
        End If

        Dim today As Date = Date.Today
        Dim oneMonthFromNow As Date = today.AddMonths(1)

        If MedicineInfo.MedicineStock <= 10 AndAlso MedicineInfo.MedicineExpirationDate <= today Then
            ' Expired + Low stock
            medstatus_indicator.FillColor = Color.FromArgb(24, 36, 36)
            medstatus_indicator.FillColor2 = Color.FromArgb(24, 36, 36)

        ElseIf MedicineInfo.MedicineStock <= 30 AndAlso MedicineInfo.MedicineExpirationDate <= oneMonthFromNow Then
            ' Expiring soon + Medium stock
            medstatus_indicator.FillColor = Color.FromArgb(184, 129, 184)
            medstatus_indicator.FillColor2 = Color.FromArgb(184, 129, 184)

        ElseIf MedicineInfo.MedicineStock <= 10 AndAlso MedicineInfo.MedicineExpirationDate > oneMonthFromNow Then
            ' Good expiry + Critically low stock
            medstatus_indicator.FillColor = Color.FromArgb(194, 139, 62)
            medstatus_indicator.FillColor2 = Color.FromArgb(194, 139, 62)

        ElseIf MedicineInfo.MedicineStock <= 30 AndAlso MedicineInfo.MedicineExpirationDate > oneMonthFromNow Then
            ' Good expiry + Medium stock
            medstatus_indicator.FillColor = Color.FromArgb(255, 153, 102)
            medstatus_indicator.FillColor2 = Color.FromArgb(255, 153, 102)

        ElseIf MedicineInfo.MedicineStock > 30 AndAlso MedicineInfo.MedicineExpirationDate <= today Then
            ' Expired + High stock
            medstatus_indicator.FillColor = Color.FromArgb(229, 65, 65)
            medstatus_indicator.FillColor2 = Color.FromArgb(229, 65, 65)

        ElseIf MedicineInfo.MedicineStock > 30 AndAlso MedicineInfo.MedicineExpirationDate <= oneMonthFromNow Then
            ' Expiring soon + High stock
            medstatus_indicator.FillColor = Color.FromArgb(239, 239, 141)
            medstatus_indicator.FillColor2 = Color.FromArgb(239, 239, 141)
        ElseIf MedicineInfo.MedicineStock > 30 AndAlso MedicineInfo.MedicineExpirationDate > oneMonthFromNow Then
            ' Expiring soon + High stock
            medstatus_indicator.FillColor = Color.FromArgb(196, 218, 212)
            medstatus_indicator.FillColor2 = Color.FromArgb(196, 218, 212)
        End If

    End Sub

    Private Sub choose_img_btn_Click(sender As Object, e As EventArgs) Handles addimage_btn.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png"
            If ofd.ShowDialog() = DialogResult.OK Then
                selectedImagePath = ofd.FileName ' Store the selected image path
                addimage_btn.Image = Image.FromFile(selectedImagePath)
                addimage_btn.SizeMode = PictureBoxSizeMode.Zoom
            End If
        End Using
    End Sub

    Private Async Sub UpdateMedicineButton_Click(sender As Object, e As EventArgs) Handles save_update_btn.Click
        ' Validation
        If String.IsNullOrWhiteSpace(medicine_name_txtbox.Text) OrElse
           String.IsNullOrWhiteSpace(brand_txtbox.Text) OrElse
           String.IsNullOrWhiteSpace(dosage_txtbox.Text) OrElse
           String.IsNullOrWhiteSpace(manufacturer_txtbox.Text) OrElse
           String.IsNullOrWhiteSpace(description_txtbox.Text) OrElse
           String.IsNullOrWhiteSpace(price_txtbox.Text) OrElse
           String.IsNullOrWhiteSpace(medtype_txtbox.Text) OrElse
           String.IsNullOrWhiteSpace(stock_txtbox.Text) Then
            MessageBox.Show("Please fill in all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Price validation
        Dim price As Decimal
        If Not InputValidation.IsValidDecimalInput(price_txtbox.Text, price) Then
            MessageBox.Show("Invalid price format.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Stock validation
        Dim stock As Integer
        If Not Integer.TryParse(stock_txtbox.Text, stock) Then
            MessageBox.Show("Invalid stock value.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Prepare image file
        Dim finalImageName As String = MedicineInfo.MedicineImageName
        If Not String.IsNullOrEmpty(selectedImagePath) Then
            Dim imageFolderPath As String = Path.Combine(Application.StartupPath, "drug_images")
            Dim originalFileName As String = Path.GetFileNameWithoutExtension(selectedImagePath)
            Dim extension As String = Path.GetExtension(selectedImagePath)
            Dim targetPath As String = Path.Combine(imageFolderPath, originalFileName & extension)
            Dim index As Integer = 1

            While File.Exists(targetPath)
                targetPath = Path.Combine(imageFolderPath, $"{originalFileName}({index}){extension}")
                index += 1
            End While

            finalImageName = Path.GetFileName(targetPath)
            File.Copy(selectedImagePath, targetPath, overwrite:=False) ' Copy the selected image to folder
        End If

        Dim prescription As Integer
        If prescription_cbox.SelectedIndex = 0 Then
            prescription = 0
        Else
            prescription = 1
        End If

        ' Create new updated model
        Dim updatedMedicine As New Medicine With {
            .MedicineID = MedicineInfo.MedicineID,
            .MedicineName = medicine_name_txtbox.Text,
            .MedicineBrand = brand_txtbox.Text,
            .MedicineDosage = dosage_txtbox.Text,
            .MedicineManufacturer = manufacturer_txtbox.Text,
            .MedicineDescription = description_txtbox.Text,
            .MedicinePrescription = prescription,
            .MedicinePrice = Math.Round(price, 2),
            .MedicineType = medtype_txtbox.Text,
            .MedicineStock = stock,
            .MedicineExpirationDate = expdate_datetime.Value,
            .MedicineImageName = finalImageName,
            .MedicineLastUpdated = DateTime.Now
        }

        ' Update database with new medicine details
        Dim repo As New MedicineRepository()
        Await repo.UpdateMedicine(updatedMedicine)

        ' Update the UI Image control (refresh the image after update)
        If Not String.IsNullOrEmpty(finalImageName) Then
            ' Assuming image is stored in "drug_images" folder
            Dim imagePath As String = Path.Combine(Application.StartupPath, "drug_images", finalImageName)
            If File.Exists(imagePath) Then
                addimage_btn.Image = Image.FromFile(imagePath)
                addimage_btn.SizeMode = PictureBoxSizeMode.Zoom
            End If
        End If

        MessageBox.Show("Medicine updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

End Class
