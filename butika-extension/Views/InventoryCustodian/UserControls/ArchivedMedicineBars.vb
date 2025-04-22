Imports butika.Helpers
Imports butika.Models

Public Class ArchivedMedicineBars

    Public Property MedicineInfo As Medicine

    Public Sub New(med As Medicine)
        InitializeComponent()
        LoadData(med)
    End Sub

    Private Sub LoadData(med As Medicine)
        medicineID.Text = med.MedicineID.ToString()
        medicineName.Text = HelperMethod.CapitalizeEachFirstWord(med.MedicineName)
        manufacturerName.Text = HelperMethod.CapitalizeEachFirstWord(med.MedicineManufacturer)


        Me.MedicineInfo = med

        Dim today As Date = Date.Today
        Dim oneMonthFromNow As Date = today.AddMonths(1)

        If MedicineInfo.MedicineStock <= 10 AndAlso MedicineInfo.MedicineExpirationDate <= today Then
            ' Expired + Low stock
            medicinebar_bg.FillColor = Color.FromArgb(24, 36, 36)
            medicinebar_bg.FillColor2 = Color.FromArgb(24, 36, 36)
            medicinebar_bg.FillColor3 = Color.FromArgb(24, 36, 36)
            medicinebar_bg.FillColor4 = Color.FromArgb(24, 36, 36)
            medicineID.ForeColor = Color.White
            medicineName.ForeColor = Color.White
            manufacturerName.ForeColor = Color.White

        ElseIf MedicineInfo.MedicineStock <= 30 AndAlso MedicineInfo.MedicineExpirationDate <= oneMonthFromNow Then
            ' Expiring soon + Medium stock
            medicinebar_bg.FillColor = Color.FromArgb(184, 129, 184)
            medicinebar_bg.FillColor2 = Color.FromArgb(184, 129, 184)
            medicinebar_bg.FillColor3 = Color.FromArgb(184, 129, 184)
            medicinebar_bg.FillColor4 = Color.FromArgb(184, 129, 184)
            medicineID.ForeColor = Color.White
            medicineName.ForeColor = Color.White
            manufacturerName.ForeColor = Color.White

        ElseIf MedicineInfo.MedicineStock <= 10 AndAlso MedicineInfo.MedicineExpirationDate > oneMonthFromNow Then
            ' Good expiry + Critically low stock
            medicinebar_bg.FillColor = Color.FromArgb(194, 139, 62)
            medicinebar_bg.FillColor2 = Color.FromArgb(194, 139, 62)
            medicinebar_bg.FillColor3 = Color.FromArgb(194, 139, 62)
            medicinebar_bg.FillColor4 = Color.FromArgb(194, 139, 62)
            medicineID.ForeColor = Color.White
            medicineName.ForeColor = Color.White
            manufacturerName.ForeColor = Color.White

        ElseIf MedicineInfo.MedicineStock <= 30 AndAlso MedicineInfo.MedicineExpirationDate > oneMonthFromNow Then
            ' Good expiry + Medium stock
            medicinebar_bg.FillColor = Color.FromArgb(255, 153, 102)
            medicinebar_bg.FillColor2 = Color.FromArgb(255, 153, 102)
            medicinebar_bg.FillColor3 = Color.FromArgb(255, 153, 102)
            medicinebar_bg.FillColor4 = Color.FromArgb(255, 153, 102)
            medicineID.ForeColor = Color.White
            medicineName.ForeColor = Color.FromArgb(22, 66, 60)
            manufacturerName.ForeColor = Color.FromArgb(22, 66, 60)

        ElseIf MedicineInfo.MedicineStock > 30 AndAlso MedicineInfo.MedicineExpirationDate <= today Then
            ' Expired + High stock
            medicinebar_bg.FillColor = Color.FromArgb(229, 65, 65)
            medicinebar_bg.FillColor2 = Color.FromArgb(229, 65, 65)
            medicinebar_bg.FillColor3 = Color.FromArgb(229, 65, 65)
            medicinebar_bg.FillColor4 = Color.FromArgb(229, 65, 65)
            medicineID.ForeColor = Color.White
            medicineName.ForeColor = Color.White
            manufacturerName.ForeColor = Color.White

        ElseIf MedicineInfo.MedicineStock > 30 AndAlso MedicineInfo.MedicineExpirationDate <= oneMonthFromNow Then
            ' Expiring soon + High stock
            medicinebar_bg.FillColor = Color.FromArgb(239, 239, 141)
            medicinebar_bg.FillColor2 = Color.FromArgb(239, 239, 141)
            medicinebar_bg.FillColor3 = Color.FromArgb(239, 239, 141)
            medicinebar_bg.FillColor4 = Color.FromArgb(239, 239, 141)
            medicineID.ForeColor = Color.FromArgb(22, 66, 60)
            medicineName.ForeColor = Color.FromArgb(22, 66, 60)
            manufacturerName.ForeColor = Color.FromArgb(22, 66, 60)
        End If

    End Sub



    Private Async Function removeToArchive() As Task
        Dim medId = MedicineInfo.MedicineID
        If MessageBox.Show($"Continue with restoring the medicine?{vbCrLf}{vbCrLf}Medicine ID: {medId}{vbCrLf}Name: {HelperMethod.CapitalizeEachFirstWord(MedicineInfo.MedicineName)}{vbCrLf}Manufacturer: {HelperMethod.CapitalizeEachFirstWord(MedicineInfo.MedicineManufacturer)}",
                            "Unarchive Medicine",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) = DialogResult.Yes Then


            Dim repo As New MedicineRepository
            Dim arcSuccess = Await repo.RemoveToArchiveMedicine(medId)

            If arcSuccess Then
                MessageBox.Show("Medicine restored successfully!")
            Else
                MessageBox.Show("Failed to restore medicine.")
            End If

        End If
    End Function

    Private Async Sub ArchivedMedicineBars_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Await removeToArchive
    End Sub
End Class
