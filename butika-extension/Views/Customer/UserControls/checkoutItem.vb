Imports butika.Models
Imports Org.BouncyCastle.Math

Public Class checkoutItem
    Dim account As New Account()
    Dim cart As New Cart()
    Public Sub New(account As Account)
        InitializeComponent()
        Me.account = account
    End Sub

    Public Sub Initialize(cart As Cart)
        Me.cart = cart

        medNameLbl.Text = If(cart.Medicine.MedicineName.Contains(","), cart.Medicine.FormattedMedicineName, cart.Medicine.MedicineName)
        Quantity.Text = cart.Quantity
        FinalPrice.Text = cart.Medicine.MedicinePrice * cart.Quantity

        If account.IsVerified = True Then
            FinalPrice.Text = cart.Medicine.DiscountedPrice * cart.Quantity
        Else
            FinalPrice.Text = cart.Medicine.MedicinePrice * cart.Quantity
        End If
    End Sub
End Class
