Imports System.IO
Imports butika.Helpers
Imports butika.Models

Public Class ViewMedicineBar

    Public Property MedicineInfo As Medicine
    Private selectedImagePath As String
    Dim imageName As String

    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Me.Close()
    End Sub

    Private Sub edit_medicine_btn_Click(sender As Object, e As EventArgs) Handles edit_medicine_btn.Click
        ToggleEditMode(True)
        AddHandler stock_clickable.Click, AddressOf Guna2CustomGradientPanel18_Click
        AddHandler edit_stock_btn.Click, AddressOf Guna2CustomGradientPanel18_Click
        AddHandler stock_label.Click, AddressOf Guna2CustomGradientPanel18_Click
    End Sub

    Private Sub cancel_update_btn_Click(sender As Object, e As EventArgs) Handles cancel_update_btn.Click
        ToggleEditMode(False)
        RemoveHandler stock_clickable.Click, AddressOf Guna2CustomGradientPanel18_Click
        RemoveHandler edit_stock_btn.Click, AddressOf Guna2CustomGradientPanel18_Click
        RemoveHandler stock_label.Click, AddressOf Guna2CustomGradientPanel18_Click

        reloadData()
    End Sub

    Private Sub ToggleEditMode(enabled As Boolean)
        medicine_name_txtbox.ReadOnly = Not enabled
        brand_txtbox.ReadOnly = Not enabled
        dosage_txtbox.ReadOnly = Not enabled
        manufacturer_txtbox.ReadOnly = Not enabled
        description_txtbox.ReadOnly = Not enabled
        price_txtbox.ReadOnly = Not enabled
        medtype_txtbox.ReadOnly = Not enabled
        prescription_cbox.Enabled = enabled
        expdate_datetime.Enabled = enabled
        addimage_btn.Enabled = enabled

        save_update_btn.Visible = enabled
        save_update_btn.Enabled = enabled
        cancel_update_btn.Visible = enabled
        cancel_update_btn.Enabled = enabled
        edit_stock_btn.Enabled = enabled
        edit_stock_btn.Visible = enabled
        edit_medicine_btn.Visible = Not enabled
        edit_medicine_btn.Enabled = Not enabled
    End Sub

    Private Function reloadData()
        ToggleEditMode(False)
        RemoveHandler stock_clickable.Click, AddressOf Guna2CustomGradientPanel18_Click
        RemoveHandler edit_stock_btn.Click, AddressOf Guna2CustomGradientPanel18_Click
        RemoveHandler stock_label.Click, AddressOf Guna2CustomGradientPanel18_Click

        medicine_id_lbl.Text = "Medicine ID# " + MedicineInfo.MedicineID.ToString()

        If MedicineInfo.MedicineDateAdded.HasValue Then
            medicine_added_date_lbl.Text = "Date added: " & MedicineInfo.MedicineDateAdded.Value.ToString("MMMM dd, yyyy")
        Else
            medicine_added_date_lbl.Text = "Date added: " & DateTime.Now.ToString("MMMM dd, yyyy")
        End If

        If MedicineInfo.MedicineLastUpdated.HasValue Then
            medicine_updated_date_lbl.Text = "Last Updated: " & MedicineInfo.MedicineLastUpdated.Value.ToString("MMMM dd, yyyy")
        Else
            medicine_updated_date_lbl.Text = "Last Updated: " & DateTime.Now.ToString("MMMM dd, yyyy")
        End If

        prescription_cbox.Items.Add("No")
        prescription_cbox.Items.Add("Yes")

        If MedicineInfo IsNot Nothing Then
            medicine_name_txtbox.Text = HelperMethod.CapitalizeEachFirstWord(MedicineInfo.MedicineName)
            brand_txtbox.Text = HelperMethod.CapitalizeEachFirstWord(MedicineInfo.MedicineBrand)
            dosage_txtbox.Text = HelperMethod.CapitalizeEachFirstWord(MedicineInfo.MedicineDosage)
            manufacturer_txtbox.Text = HelperMethod.CapitalizeEachFirstWord(MedicineInfo.MedicineManufacturer)
            description_txtbox.Text = MedicineInfo.MedicineDescription
            stock_label.Text = MedicineInfo.MedicineStock.ToString()
            price_txtbox.Text = MedicineInfo.MedicinePrice.ToString("F2")
            medtype_txtbox.Text = HelperMethod.CapitalizeEachFirstWord(MedicineInfo.MedicineType)
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
            medstatus_indicator.FillColor3 = Color.FromArgb(24, 36, 36)

        ElseIf MedicineInfo.MedicineStock <= 30 AndAlso MedicineInfo.MedicineExpirationDate <= oneMonthFromNow Then
            ' Expiring soon + Medium stock
            medstatus_indicator.FillColor = Color.FromArgb(184, 129, 184)
            medstatus_indicator.FillColor2 = Color.FromArgb(184, 129, 184)
            medstatus_indicator.FillColor3 = Color.FromArgb(184, 129, 184)

        ElseIf MedicineInfo.MedicineStock <= 10 AndAlso MedicineInfo.MedicineExpirationDate > oneMonthFromNow Then
            ' Good expiry + Critically low stock
            medstatus_indicator.FillColor = Color.FromArgb(194, 139, 62)
            medstatus_indicator.FillColor2 = Color.FromArgb(194, 139, 62)
            medstatus_indicator.FillColor3 = Color.FromArgb(194, 139, 62)

        ElseIf MedicineInfo.MedicineStock <= 30 AndAlso MedicineInfo.MedicineExpirationDate > oneMonthFromNow Then
            ' Good expiry + Medium stock
            medstatus_indicator.FillColor = Color.FromArgb(255, 153, 102)
            medstatus_indicator.FillColor2 = Color.FromArgb(255, 153, 102)
            medstatus_indicator.FillColor3 = Color.FromArgb(255, 153, 102)

        ElseIf MedicineInfo.MedicineStock > 30 AndAlso MedicineInfo.MedicineExpirationDate <= today Then
            ' Expired + High stock
            medstatus_indicator.FillColor = Color.FromArgb(229, 65, 65)
            medstatus_indicator.FillColor2 = Color.FromArgb(229, 65, 65)
            medstatus_indicator.FillColor3 = Color.FromArgb(229, 65, 65)

        ElseIf MedicineInfo.MedicineStock > 30 AndAlso MedicineInfo.MedicineExpirationDate <= oneMonthFromNow Then
            ' Expiring soon + High stock
            medstatus_indicator.FillColor = Color.FromArgb(239, 239, 141)
            medstatus_indicator.FillColor2 = Color.FromArgb(239, 239, 141)
            medstatus_indicator.FillColor3 = Color.FromArgb(239, 239, 141)

        ElseIf MedicineInfo.MedicineStock > 30 AndAlso MedicineInfo.MedicineExpirationDate > oneMonthFromNow Then
            ' Expiring soon + High stock
            medstatus_indicator.FillColor = Color.FromArgb(196, 218, 212)
            medstatus_indicator.FillColor2 = Color.FromArgb(196, 218, 212)
            medstatus_indicator.FillColor3 = Color.FromArgb(196, 218, 212)
        End If

    End Function

    Private Sub LoadMedicineData(sender As Object, e As EventArgs) Handles MyBase.Load
        reloadData()
    End Sub


    Private Sub choose_img_btn_Click(sender As Object, e As EventArgs) Handles addimage_btn.Click
        Try
            Using openFileDialog As New OpenFileDialog()
                openFileDialog.Filter = "Image Files (*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg"
                If openFileDialog.ShowDialog() = DialogResult.OK Then
                    selectedImagePath = openFileDialog.FileName ' Get the selected image's path
                    imageName = MedicineInfo.MedicineID.ToString() + Path.GetFileName(selectedImagePath)

                End If
                addimage_btn.Image = Image.FromFile(selectedImagePath)
            End Using
        Catch ex As Exception

        End Try
    End Sub



    Private Async Sub UpdateMedicineButton_Click(sender As Object, e As EventArgs) Handles save_update_btn.Click
        ' Validation
        If String.IsNullOrWhiteSpace(medicine_name_txtbox.Text) OrElse
       String.IsNullOrWhiteSpace(brand_txtbox.Text) OrElse
       String.IsNullOrWhiteSpace(dosage_txtbox.Text) OrElse
       String.IsNullOrWhiteSpace(manufacturer_txtbox.Text) OrElse
       String.IsNullOrWhiteSpace(description_txtbox.Text) OrElse
       String.IsNullOrWhiteSpace(price_txtbox.Text) OrElse
       String.IsNullOrWhiteSpace(medtype_txtbox.Text) Then
            MessageBox.Show("Please fill in all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Price validation
        Dim price As Decimal
        If Not InputValidation.IsValidDecimalInput(price_txtbox.Text, price) Then
            MessageBox.Show("Invalid price format.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Determine final image name (use existing if no new image)
        Dim finalImageName As String = MedicineInfo.MedicineImageName
        If Not String.IsNullOrEmpty(selectedImagePath) Then
            finalImageName = MedicineInfo.MedicineID.ToString() + Path.GetFileName(selectedImagePath)
            Dim projectRoot As String = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.FullName
            Dim destinationFolder As String = Path.Combine(projectRoot, GetImagePath.DrugPathName)
            Dim isImageSaved As Boolean = ImageInsertion.SaveImageToFolder(selectedImagePath, finalImageName, destinationFolder)

            If Not isImageSaved Then
                Debug.WriteLine("Image has not been saved.")
                Return
            End If
        End If

        ' Handle prescription value
        Dim prescription As Integer = If(prescription_cbox.SelectedIndex = 0, 0, 1)

        ' Construct updated model
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
        .MedicineExpirationDate = expdate_datetime.Value,
        .MedicineImageName = finalImageName,
        .MedicineLastUpdated = DateTime.Now
    }

        ' Compare with original to check for changes
        Dim original = MedicineInfo
        Dim isChanged As Boolean =
        updatedMedicine.MedicineName <> original.MedicineName OrElse
        updatedMedicine.MedicineBrand <> original.MedicineBrand OrElse
        updatedMedicine.MedicineDosage <> original.MedicineDosage OrElse
        updatedMedicine.MedicineManufacturer <> original.MedicineManufacturer OrElse
        updatedMedicine.MedicineDescription <> original.MedicineDescription OrElse
        updatedMedicine.MedicinePrescription <> original.MedicinePrescription OrElse
        updatedMedicine.MedicinePrice <> original.MedicinePrice OrElse
        updatedMedicine.MedicineType <> original.MedicineType OrElse
        updatedMedicine.MedicineExpirationDate <> original.MedicineExpirationDate OrElse
        updatedMedicine.MedicineImageName <> original.MedicineImageName

        If Not isChanged Then
            MessageBox.Show("Can't update. No info were changed.", "No Changes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Ask for confirmation before updating
        Dim confirmResult = MessageBox.Show("Are you sure you want to update the medicine details?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmResult <> DialogResult.Yes Then
            Return
        End If

        ' Proceed with update
        Dim repo As New MedicineRepository()
        Await repo.UpdateMedicine(updatedMedicine)

        ' Update UI image
        Dim imagePath As String = Path.Combine(Application.StartupPath, "drug_images", finalImageName)
        If File.Exists(imagePath) Then
            addimage_btn.Image = Image.FromFile(imagePath)
            addimage_btn.SizeMode = PictureBoxSizeMode.Zoom
        End If

        ' Show success message
        MessageBox.Show("Medicine updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.DialogResult = DialogResult.OK

        ' Log activity
        Dim userID As Integer = SessionInfo.CurrentUserID
        Dim userType As Integer = SessionInfo.CurrentUserType
        Await AdminRepository.LogMedicineUpdateActivity(userID, userType, MedicineInfo.MedicineID)

        reloadData()
    End Sub

    Private Sub Guna2CustomGradientPanel18_Click(sender As Object, e As EventArgs) Handles stock_clickable.Click, edit_stock_btn.Click, stock_label.Click
        Dim stockForm As New StockRequestForm(MedicineInfo)
        stockForm.ShowDialog()

    End Sub

    Private Async Sub archive_medicine_btn_Click(sender As Object, e As EventArgs) Handles archive_medicine_btn.Click
        If MessageBox.Show("Continue with archiving the medicine?", "Archive Medicine", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim medId = MedicineInfo.MedicineID

            Dim repo As New MedicineRepository()
            Dim arcSuccess As Boolean = Await repo.ArchiveMedicine(medId)

            If arcSuccess Then
                MessageBox.Show("Medicine archived successfully!")
                Dim userID As Integer = SessionInfo.CurrentUserID
                Dim userType As Integer = SessionInfo.CurrentUserType
                Dim activityLogged As Boolean = Await AdminRepository.LogMedicineArchiveActivity(userID, userType, medId)
            Else
                MessageBox.Show("Failed to archive medicine.")
            End If

            Me.Close()

        End If
    End Sub
End Class
