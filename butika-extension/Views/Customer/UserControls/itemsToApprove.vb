Imports butika.Models

Public Class itemsToApprove
    Dim account As New Account()
    Dim cart As New Cart()
    Public Sub New(account As Account)
        InitializeComponent()
        Me.account = account
    End Sub

    Public Sub Initialize(cart As Cart)
        Me.cart = cart

        medNameLbl.Text = cart.Medicine.MedicineName
        Quantity.Text = cart.Quantity

    End Sub
End Class
