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

        SetTextIndicator()

        MedicineName.Text = cart.Medicine.FormattedMedicineName
        Manufacturer.Text = cart.Medicine.MedicineManufacturer
        medicineImageBox.Image = Image.FromFile(cart.Medicine.MedicineImagePath)
        Quantity.Text = cart.Quantity.ToString()
        SelectItem.Checked = cart.isTicked

        If account.IsVerified = True Then
            Total.Text = "₱" & (cart.Medicine.DiscountedPrice * cart.Quantity).ToString("F2")
            Price.Text = "₱" & cart.Medicine.DiscountedPrice.ToString("F2")
        Else
            Total.Text = "₱" & (cart.Medicine.MedicinePrice * cart.Quantity).ToString("F2")
            Price.Text = "₱" & cart.Medicine.MedicinePrice.ToString("F2")
        End If


        CheckIndicatorPanel()

        SelectItem.Checked = cart.isTicked
    End Sub

    Private Async Sub SelectItem_CheckedChanged(sender As Object, e As EventArgs) Handles SelectItem.CheckedChanged
        Dim cartRepo As New CartRepository(account)
        Await cartRepo.UpdateCheckBoxTickFromCart(cart.CartID, SelectItem.Checked)
    End Sub

    Private Sub CheckIndicatorPanel()
        If cart.Medicine.MedicineArchived = 1 Then
            indicatorPanel.FillColor = Color.DarkGray
            Return
        End If

        If cart.isApproved = 0 Then
            indicatorPanel.FillColor = Color.Yellow
        ElseIf cart.isApproved = 1 Then
            indicatorPanel.FillColor = Color.Green
        ElseIf cart.isApproved = 2 Then
            indicatorPanel.FillColor = Color.Red
        End If
    End Sub

    Private Sub SetTextIndicator()
        If cart.Medicine.MedicineArchived = 1 Then
            unavailableLbl.Visible = True
            isSent.Visible = False
            Exit Sub
        End If

        unavailableLbl.Visible = False
        isSent.Visible = (cart.PrescriptionID <> 0)
    End Sub

End Class
