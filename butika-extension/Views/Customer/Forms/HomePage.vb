Imports butika.Models

Public Class HomePage
    Dim account As New Account()
    Dim cartList As New List(Of Cart)

    Public Sub New(account As Account)
        InitializeComponent()
        Me.account = account
    End Sub

    Private Sub carousel2_Click(sender As Object, e As EventArgs) Handles carousel2.Click
        dashboardPctBx.Image = My.Resources.monthly
        carousel2.FillColor = Color.FromArgb(22, 66, 60)
        carousel1.FillColor = Color.Silver
    End Sub

    Private Sub carousel1_Click(sender As Object, e As EventArgs) Handles carousel1.Click
        dashboardPctBx.Image = My.Resources.welcomehere
        carousel1.FillColor = Color.FromArgb(22, 66, 60)
        carousel2.FillColor = Color.Silver
    End Sub

    Private Async Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cartRepo As New CartRepository(account)

        usernameLbl.Text = $"Welcome back, {account.UserName}"
        totalTransacLbl.Text = Await cartRepo.getTotalTransactionsMade()
        cartProgressLbl.Text = Await cartRepo.getTotalCartInProgress()
        totalPrescLbl.Text = Await cartRepo.getTotalPrescriptionMade()
        pendingApprovalLbl.Text = Await cartRepo.getPendingCart()
        totalItemsLbl.Text = Await cartRepo.getCheckoutItem()

        cartList = Await cartRepo.GetCartInfoForCheckOutPanel()

        If account.IsVerified = True Then
            amountLbl.Text = "PHP" & getTotalSumOfItems(cartList, True).ToString()
            originalPrice.Text = "PHP" & getTotalSumOfItems(cartList, False).ToString()

            If cartList.Count = 0 Then
                originalPrice.Visible = False
            Else
                originalPrice.Visible = True
            End If
        Else
            amountLbl.Text = "PHP" & getTotalSumOfItems(cartList, False).ToString()
        End If

    End Sub

    Function getTotalSumOfItems(cart As List(Of Cart), useDiscountedPrice As Boolean) As Decimal
        Dim total As Decimal = 0

        For Each item In cart
            Dim price As Decimal = If(useDiscountedPrice, item.Medicine.DiscountedPrice, item.Medicine.MedicinePrice)
            total += price * item.Quantity
        Next

        Return total
    End Function
End Class