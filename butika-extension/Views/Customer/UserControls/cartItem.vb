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

        isSent.Visible = If(cart.PrescriptionID <> 0, True, False)

        MedicineName.Text = cart.Medicine.FormattedMedicineName
        Manufacturer.Text = cart.Medicine.MedicineManufacturer
        medicineImageBox.Image = Image.FromFile(cart.Medicine.MedicineImagePath)
        Quantity.Text = cart.Quantity.ToString()
        SelectItem.Checked = cart.isTicked

        If account.IsVerified = 1 Then
            Total.Text = "₱" & (cart.Medicine.DiscountedPrice * cart.Quantity).ToString()
            Price.Text = "₱" & cart.Medicine.DiscountedPrice.ToString()
        Else
            Total.Text = "₱" & (cart.Medicine.MedicinePrice * cart.Quantity).ToString()
            Price.Text = "₱" & cart.Medicine.MedicinePrice.ToString()
        End If


        CheckIndicatorPanel()

        SelectItem.Checked = cart.isTicked
    End Sub

    Private Async Sub SelectItem_CheckedChanged(sender As Object, e As EventArgs) Handles SelectItem.CheckedChanged
        Dim cartRepo As New CartRepository(account)
        Await cartRepo.UpdateCheckBoxTickFromCart(cart.CartID, SelectItem.Checked)
    End Sub

    Private Sub CheckIndicatorPanel()
        If cart.isApproved = 0 Then
            indicatorPanel.BackColor = Color.Yellow
        ElseIf cart.isApproved = 1 Then
            indicatorPanel.BackColor = Color.Green
        ElseIf cart.isApproved = 2 Then
            indicatorPanel.BackColor = Color.Red
        End If
    End Sub
End Class
