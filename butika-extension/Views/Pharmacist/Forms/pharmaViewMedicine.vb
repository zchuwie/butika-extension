Imports System.Runtime.CompilerServices
Imports butika.Models
Imports Guna.UI2.WinForms.Suite
Imports Org.BouncyCastle.Math
Imports PdfSharp

Public Class pharmaViewMedicine
    Dim account As New Account()
    Dim medicine As New Medicine()
    Public Sub New(medicine As Medicine)
        Me.medicine = medicine
        Me.account = account

        InitializeComponent()
        LoadMedicine()
    End Sub
    Public Sub LoadMedicine()
        mednameLbl.Text = medicine.FormattedMedicineName
        manufacturerLbl.Text = medicine.MedicineManufacturer
        descriptionLbl.Text = medicine.MedicineDescription
        medicinePicture.Image = Image.FromFile(medicine.MedicineImagePath)
        dosageLbl.Text = medicine.MedicineDosage
        stocksLbl.Text = medicine.MedicineStock.ToString()
        expirationDateLbl.Text = medicine.MedicineExpirationDate.ToString()
    End Sub
    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub
End Class
