Imports butika.Models

Public Class CartPage

#Region "Functions"
    Private Sub underlineFilter(ByVal all As Boolean, ByVal pending As Boolean, ByVal ready As Boolean, ByVal declined As Boolean)
        AllItemsUnderline.Visible = all
        PendingUnderline.Visible = pending
        ReadyUnderline.Visible = ready
        DeclinedUnderline.Visible = declined
    End Sub

#End Region

    Dim account As New Account()
    Dim panelSelected As Integer = -1
    Dim isSelected As Boolean = False
    Dim cartItems As New Stack(Of Cart)
    Dim cartOfSelectedItem As New List(Of Cart)

    Public Sub New(account As Account)
        Me.account = account
        InitializeComponent()

    End Sub

    Private Async Sub Pending_Click(sender As Object, e As EventArgs) Handles Pending.Click
        underlineFilter(False, True, False, False)
        Await displaySpecificCartUser(0)
        panelSelected = 0
    End Sub

    Private Async Sub AllItems_Click(sender As Object, e As EventArgs) Handles AllItems.Click
        underlineFilter(True, False, False, False)
        Await displayAllCartUser()
        panelSelected = -1
    End Sub

    Private Async Sub Ready_Click(sender As Object, e As EventArgs) Handles Ready.Click
        underlineFilter(False, False, True, False)
        Await displaySpecificCartUser(1)
        panelSelected = 1
    End Sub

    Private Async Sub Declined_Click(sender As Object, e As EventArgs) Handles Declined.Click
        underlineFilter(False, False, False, True)
        Await displaySpecificCartUser(2)
        panelSelected = 2
    End Sub

    Private Async Sub CartPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cartRepo As New CartRepository(account)
        underlineFilter(True, False, False, False)
        Await displayAllCartUser()
        displayCheckoutPanel()

        cartOfSelectedItem = Await cartRepo.GetCartInfoForCheckOutPanel()

        If cartOfSelectedItem.Count = 0 Then
            originalPrice.Visible = False
        End If

        If account.IsVerified = True Then
            TotalPriceTxt.Text = "₱" & getTotalSumOfItems(cartOfSelectedItem, True).ToString()
            Dim amountSaved As Decimal = getTotalSumOfItems(cartOfSelectedItem, False) - getTotalSumOfItems(cartOfSelectedItem, True).ToString()
            originalPrice.Text = "You have saved " + "₱ " & amountSaved
            originalPrice.Visible = True
        Else
            TotalPriceTxt.Text = "₱" & getTotalSumOfItems(cartOfSelectedItem, False).ToString()
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


    Private Async Function displayAllCartUser() As Task
        CartPanel.Controls.Clear()

        Dim cartRepo As New CartRepository(account)
        cartItems = Await cartRepo.GetUserCart()
        For Each item In cartItems
            Dim cartItemControl As New cartItem(account)
            cartItemControl.Initialize(item)
            CartPanel.Controls.Add(cartItemControl)
        Next
    End Function

    Private Async Sub displayCheckoutPanel()
        OrderPanel.Controls.Clear()

        Dim cartRepo As New CartRepository(account)

        Dim checkoutCart As Stack(Of Cart) = Await cartRepo.GetCheckoutCart()

        For Each item In checkoutCart
            Dim cartItemControl As New checkoutItem(account)
            cartItemControl.Initialize(item)
            OrderPanel.Controls.Add(cartItemControl)
        Next
    End Sub

    Private Async Function displaySpecificCartUser(IsApproved As Integer) As Task
        CartPanel.Controls.Clear()

        Dim cartRepo As New CartRepository(account)
        cartItems = Await cartRepo.GetUserCart(IsApproved)
        For Each item In cartItems
            Dim cartItemControl As New cartItem(account)
            cartItemControl.Initialize(item)
            CartPanel.Controls.Add(cartItemControl)
        Next
    End Function

    Private Async Sub selectOrDeselectBtn_Click(sender As Object, e As EventArgs) Handles selectOrDeselectBtn.Click
        Dim cartRepo As New CartRepository(account)
        selectOrDeselectBtn.Enabled = False

        If Not isSelected Then
            Await cartRepo.SelectOrDeselectAllUserMedicine(True, panelSelected)
        Else
            Await cartRepo.SelectOrDeselectAllUserMedicine(False, panelSelected)
        End If

        isSelected = Not isSelected
        selectOrDeselectBtn.Text = If(isSelected, "Deselect All", "Select All")
        selectOrDeselectBtn.Enabled = True

        If panelSelected = 0 Then
            Await displaySpecificCartUser(0)
        ElseIf panelSelected = 1 Then
            Await displaySpecificCartUser(1)
        ElseIf panelSelected = 2 Then
            Await displaySpecificCartUser(2)
        Else
            Await displayAllCartUser()
        End If

        CartPage_Load(sender, e)
    End Sub

    Private Sub selectDeselectState()
        isSelected = Not isSelected
        selectOrDeselectBtn.Text = If(isSelected, "Deselect All", "Select All")
        selectOrDeselectBtn.Enabled = True
    End Sub

#Region "Checkout"
    Private Async Sub CheckoutBtn_Click(sender As Object, e As EventArgs) Handles CheckoutBtn.Click
        Dim cartRepo As New CartRepository(account)
        Dim transactRepo As New TransactionRepository(account)

        CheckOutBtnText(True)

        Dim cartInfoInCheckout As List(Of Cart) = Await cartRepo.GetCartInfoForCheckOutPanel()
        If Not ValidateCartSelection(cartInfoInCheckout) Then Exit Sub

        If Await HasPendingPrescriptions(cartInfoInCheckout, cartRepo) Then
            CheckOutBtnText(False)
            Return
        End If

        Dim transactionID As String = Await transactRepo.GenerateUniqueTransactionID()
        If Not Await ProcessCheckoutData(cartRepo, transactRepo, cartInfoInCheckout, transactionID) Then Exit Sub

        Dim getDataReceipt As List(Of Cart) = Await cartRepo.GetUserReceiptData()
        Dim totalItem As Decimal = getTotalSumOfItems(getDataReceipt)

        If Not Await ReduceStockAndClearCart(cartRepo) Then Exit Sub

        CartPage_Load(sender, e) ' Refresh the cart view

        If MessageBox.Show("You have successfully checked out the item. Do you want to see the receipt?", "Checkout Successful", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            Dim receipt As New Receipt(account)
            receipt.PdfReceipt(getDataReceipt, totalItem, transactionID, account)
            receipt.OpenPDF()
        Else
            MessageBox.Show("Have a good day ahead!", "Success", MessageBoxButtons.OK)
        End If
    End Sub

    Private Function ValidateCartSelection(cartItems As List(Of Cart)) As Boolean
        If cartItems.Count = 0 Then
            MessageBox.Show("You already have inserted prescription for this/these medicine/s. Please wait for the approval.")
            CheckOutBtnText(False)
            Return False
        End If
        Return True
    End Function

    Private Async Function HasPendingPrescriptions(cartItems As List(Of Cart), cartRepo As CartRepository) As Task(Of Boolean)
        If cartItems.Any(Function(item) item.isApproved = 0) Then
            Dim result As DialogResult = MessageBox.Show(
            "You have checked out an item that needs a prescription. Do you want to proceed to the prescription form?",
            "Prescription Needed",
            MessageBoxButtons.OKCancel
        )

            If result = DialogResult.OK Then
                If Await cartRepo.IsPrescriptionAlreadySent() Then
                    MessageBox.Show("It seems that you have already submitted a form for the checked medicines...", "Please Wait")
                    Return True
                End If

                Using sf As New SubmitForm(account)
                    sf.ShowDialog()
                End Using

                Return True
            ElseIf result = DialogResult.Cancel Then
                MessageBox.Show("Have a good day ahead!", "Cancelled")
                CheckoutBtn.Enabled = True
                CheckoutBtn.Text = "Checkout"
                Return True
            End If
        End If
        Return False
    End Function

    Private Async Function ProcessCheckoutData(cartRepo As CartRepository, transactRepo As TransactionRepository, cartItems As List(Of Cart), transactionID As String) As Task(Of Boolean)
        If Not Await cartRepo.InsertIndividualTransactionToCheckout(transactionID, cartItems) Then
            MessageBox.Show("Please try again.")
            Debug.WriteLine("Error inserting individual data from another table with transaction ID.")
            CheckOutBtnText(False)
            Return False
        End If

        If Not Await cartRepo.UpdateAlreadyCheckoutStatus(cartItems) Then
            MessageBox.Show("Please try again.")
            Debug.WriteLine("Error updating the values of alreadyCheckout to 1.")
            CheckOutBtnText(False)
            Return False
        End If

        If Not Await transactRepo.InsertIntoUserTransaction(transactionID) Then
            MessageBox.Show("Please try again.")
            Debug.WriteLine("Error inserting the transactionID with userID to userTransaction table.")
            CheckOutBtnText(False)
            Return False
        End If

        Return True
    End Function

    Private Async Function ReduceStockAndClearCart(cartRepo As CartRepository) As Task(Of Boolean)
        Dim itemsToReduceStock As List(Of Cart) = Await cartRepo.GetInfoForStockReduce()
        If Not Await cartRepo.listOfStockToReduce(itemsToReduceStock) Then
            MessageBox.Show("Please try again.")
            Debug.WriteLine("Error reducing stock items from the usersCart table.")
            CheckOutBtnText(False)
            Return False
        End If

        If Not Await cartRepo.deleteCheckoutItemFromUsersCart() Then
            MessageBox.Show("Error processing your checkout.")
            Debug.WriteLine("Error deleting items from the usersCart table.")
            CheckOutBtnText(False)
            Return False
        End If

        CheckOutBtnText(False)
        Return True
    End Function
#End Region

    Private Function getTotalSumOfItems(totalItems As List(Of Cart)) As Decimal
        Dim itemList As New List(Of Decimal)()

        For Each item In totalItems
            Dim itemPrice As Decimal

            If account.IsVerified = 1 Then
                itemPrice = item.Medicine.MedicinePrice
            Else
                itemPrice = item.Medicine.DiscountedPrice
            End If

            Dim itemQuantity As Integer = item.Quantity
            Dim totalItemPrice As Decimal = itemPrice * itemQuantity
            itemList.Add(totalItemPrice)
        Next


        Dim totalSum As Decimal = itemList.Sum()
        Return totalSum
    End Function

    Private Sub CheckOutBtnText(isProcessing As Boolean)
        CheckoutBtn.Enabled = Not isProcessing
        CheckoutBtn.Text = If(isProcessing, "Processing...", "Checkout")
    End Sub

    Private Async Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Dim cartRepo As New CartRepository(account)
        Dim isDeleted = Await cartRepo.deleteTickedItemFromUsersCart

        If Not isDeleted Then
            MessageBox.Show("An error occured. Try again", "Uh oh")
            Return
        End If

        MessageBox.Show("Items have been deleted")
        CartPage_Load(sender, e)
    End Sub
End Class