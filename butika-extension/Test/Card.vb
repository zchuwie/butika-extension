Imports butika.Models

Public Class Card
    Public Property MedicineData As Medicine

    Public Sub Initialize(medicine As Medicine)
        MedicineData = medicine
        Label1.Text = medicine.FormattedMedicineName
        Label2.Text = medicine.MedicinePrice.ToString("C")
        PictureBox1.Image = Image.FromFile(medicine.MedicineImagePath)

        ClickAll()
    End Sub

    Private Sub Card_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Dim detailForm As New Detail(MedicineData)
        detailForm.ShowDialog()
    End Sub

    Private Sub ClickAll()
        AddHandler Label2.Click, Sub(sender, e) Call Card_Click(sender, e)
        AddHandler Label1.Click, Sub(sender, e) Call Card_Click(sender, e)
        AddHandler PictureBox1.Click, Sub(sender, e) Call Card_Click(sender, e)
    End Sub
End Class
