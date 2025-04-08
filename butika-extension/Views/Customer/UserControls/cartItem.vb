Imports butika.Models

Public Class cartItem
    Dim account As New Account()
    Dim cart As New Cart()
    Public Sub New(account As Account)
        InitializeComponent()
        Me.account = account
    End Sub

    Public Sub Initialize(cart As Cart)
        Me.cart = cart
        MedicineName.Text = cart.Medicine.FormattedMedicineName
        Manufacturer.Text = cart.Medicine.MedicineManufacturer
        medicineImageBox.Image = Image.FromFile(cart.Medicine.MedicineImagePath)
        Price.Text = cart.Medicine.MedicinePrice.ToString()
        Quantity.Text = cart.Quantity.ToString()
        SelectItem.Checked = cart.isTicked
    End Sub

    Private Sub SelectItem_CheckedChanged(sender As Object, e As EventArgs) Handles SelectItem.CheckedChanged
        Dim cartRepo As New CartRepository(account)
    End Sub
End Class
