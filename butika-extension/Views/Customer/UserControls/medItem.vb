Imports butika.Models

Public Class medItem
    Dim medicine As New Medicine()
    Dim account As New Account()

    Public Sub New(account As Account)
        Me.account = account
        InitializeComponent()

    End Sub

    Public Sub Initialize(medicine As Medicine)
        Me.medicine = medicine
        MedName.Text = medicine.FormattedMedicineName
        Manufacturer.Text = medicine.MedicineManufacturer
        medImg.Image = Image.FromFile(medicine.MedicineImagePath)
        ClickAll()
    End Sub

    Private Sub medItem_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Dim mv As New MedicinePageView(medicine, account)
        mv.ShowDialog()
    End Sub

    Private Sub ClickAll()
        AddHandler MedName.Click, Sub(sender, e) Call medItem_Click(sender, e)
        AddHandler Manufacturer.Click, Sub(sender, e) Call medItem_Click(sender, e)
        AddHandler medImg.Click, Sub(sender, e) Call medItem_Click(sender, e)
    End Sub
End Class
