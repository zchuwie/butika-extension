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
        ClickAll()
    End Sub
    Private Sub ClickAll()
        AddHandler mednameLbl.Click, Sub(sender, e) Call pharmaMedItem_Click(sender, e)
        AddHandler manufacturerLbl.Click, Sub(sender, e) Call pharmaMedItem_Click(sender, e)
        AddHandler medIdLbl.Click, Sub(sender, e) Call pharmaMedItem_Click(sender, e)
        AddHandler dosageLbl.Click, Sub(sender, e) Call pharmaMedItem_Click(sender, e)
        AddHandler Guna2Panel1.Click, Sub(sender, e) Call pharmaMedItem_Click(sender, e)
    End Sub
    Private Sub pharmaMedItem_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Dim viewmed As New pharmaViewMedicine(medicine)
        viewmed.ShowDialog()
    End Sub
End Class
