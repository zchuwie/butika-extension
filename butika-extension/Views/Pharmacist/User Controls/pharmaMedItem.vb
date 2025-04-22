Imports butika.Models
Imports Windows.Win32

Public Class pharmaMedItem
    Dim medicine As New Medicine()

    Public Sub Initialize(medicine As Medicine)
        Me.medicine = medicine
        medIdLbl.Text = medicine.MedicineID.ToString()
        mednameLbl.Text = medicine.FormattedMedicineName
        manufacturerLbl.Text = medicine.MedicineManufacturer
        dosageLbl.Text = medicine.MedicineDosage
        LoadColor(medicine)
        ClickAll()
    End Sub
    Private Sub ClickAll()
        AddHandler mednameLbl.Click, Sub(sender, e) Call pharmaMedItem_Click(sender, e)
        AddHandler manufacturerLbl.Click, Sub(sender, e) Call pharmaMedItem_Click(sender, e)
        AddHandler medIdLbl.Click, Sub(sender, e) Call pharmaMedItem_Click(sender, e)
        AddHandler dosageLbl.Click, Sub(sender, e) Call pharmaMedItem_Click(sender, e)
        AddHandler medPanel.Click, Sub(sender, e) Call pharmaMedItem_Click(sender, e)
    End Sub
    Private Sub pharmaMedItem_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Dim viewmed As New pharmaViewMedicine(medicine)
        viewmed.ShowDialog()
    End Sub
    Private Sub LoadColor(med As Medicine)
        Dim today As Date = Date.Today
        Dim oneMonthFromNow As Date = today.AddMonths(1)

        If med.MedicineStock <= 10 AndAlso med.MedicineExpirationDate <= today Then
            ' Expired + Low stock
            ColorChange(Color.FromArgb(24, 36, 36), Color.White)
        ElseIf med.MedicineStock <= 30 AndAlso med.MedicineExpirationDate <= oneMonthFromNow Then
            ' Expiring soon + Medium stock
            ColorChange(Color.FromArgb(184, 129, 184), Color.White)
        ElseIf med.MedicineStock <= 10 AndAlso med.MedicineExpirationDate > oneMonthFromNow Then
            ' Good expiry + Critically low stock
            ColorChange(Color.FromArgb(194, 139, 62), Color.White)
        ElseIf med.MedicineStock <= 30 AndAlso med.MedicineExpirationDate > oneMonthFromNow Then
            ' Good expiry + Medium stock
            ColorChange(Color.FromArgb(255, 153, 102), Color.FromArgb(22, 66, 60))
        ElseIf med.MedicineStock > 30 AndAlso med.MedicineExpirationDate <= today Then
            ' Expired + High stock
            ColorChange(Color.FromArgb(229, 65, 65), Color.White)
        ElseIf med.MedicineStock > 30 AndAlso med.MedicineExpirationDate <= oneMonthFromNow Then
            ' Expiring soon + High stock
            ColorChange(Color.FromArgb(220, 229, 219), Color.FromArgb(22, 66, 60))
        End If
    End Sub
    Private Sub ColorChange(panel As Color, label As Color)
        medPanel.FillColor = panel
        medIdLbl.ForeColor = label
        mednameLbl.ForeColor = label
        manufacturerLbl.ForeColor = label
        dosageLbl.ForeColor = label
    End Sub
End Class
