Imports butika.Models

Public Class Detail
    Private ReadOnly _medicine As Medicine

    Public Sub New(medicine As Medicine)
        InitializeComponent()
        _medicine = medicine
    End Sub

    Private Sub Detail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = _medicine.FormattedMedicineName
        Label2.Text = _medicine.MedicinePrice.ToString("C")
        Label3.Text = _medicine.MedicineStock.ToString()
        PictureBox1.Image = Image.FromFile(_medicine.MedicineImagePath)
    End Sub
End Class