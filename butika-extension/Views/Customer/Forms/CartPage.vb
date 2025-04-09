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
        underlineFilter(True, False, False, False)
        Await displayAllCartUser()
    End Sub

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
    End Sub

    Private Sub selectDeselectState()
        isSelected = Not isSelected
        selectOrDeselectBtn.Text = If(isSelected, "Deselect All", "Select All")
        selectOrDeselectBtn.Enabled = True
    End Sub

    Private Async Sub CheckoutBtn_Click(sender As Object, e As EventArgs) Handles CheckoutBtn.Click
        Dim transactRepo As New TransactionRepository(account)
        Dim cartRepo As New CartRepository(account)

        CheckOutBtnText(True)

        'gets the ticked items only
        Dim cartInfoInCheckout As List(Of Cart) = Await cartRepo.GetCartInfoForCheckOutPanel()

        If cartInfoInCheckout.Count = 0 Then
            MessageBox.Show("Please select at least one item to checkout.")
            CheckOutBtnText(False)
            Return
        End If

        'checks if the ticked item is pending
        Dim pending As Integer = 0
        For Each item In cartInfoInCheckout
            If item.isApproved = 0 Then
                pending += 1
            End If
        Next

        If pending > 0 Then
            Dim result As DialogResult = MessageBox.Show("You have checked out an item that needs a prescription. Do you want to proceed to the prescription form?", "Prescription Needed", MessageBoxButtons.OKCancel)

            If result = DialogResult.OK Then
                Dim isAlreadyPrescribed As Boolean = Await cartRepo.IsPrescriptionAlreadySent()

                ' Check if the cart already has a prescription, they can't make another one
                If isAlreadyPrescribed Then
                    MessageBox.Show("It seems that you have already submitted a form for the checked medicines...", "Please Wait")
                    CheckOutBtnText(False)
                    Return
                End If

                ' Open the prescription submission form
                Using sf As New PrescriptionForm(account)
                    sf.ShowDialog()
                End Using

                CheckOutBtnText(False)
                Return
            End If

            If result = DialogResult.Cancel Then
                MessageBox.Show("Have a good day ahead!", "Cancelled")
                CheckoutBtn.Enabled = True
                CheckoutBtn.Text = "Checkout"
                Return
            End If
        End If

        CheckOutBtnText(False)

        'getting transaction in preparation for checkout
        Dim transactionID As String = Await transactRepo.GenerateUniqueTransactionID()
        Dim insertInUserCheckout As Boolean = Await cartRepo.InsertIndividualTransactionToCheckout(transactionID, cartInfoInCheckout)

        If Not insertInUserCheckout Then
            MessageBox.Show("Please try again.")
            Console.WriteLine("Error inserting individual data from another table with transaction ID.")
            CheckOutBtnText(False)
            Return
        End If

        Dim updateCheckoutStatus As Boolean = Await cartRepo.UpdateAlreadyCheckoutStatus(cartInfoInCheckout)

        If Not updateCheckoutStatus Then
            MessageBox.Show("Please try again.")
            Console.WriteLine("Error updating the values of alreadyCheckout to 1.")
            CheckoutBtn.Enabled = True
            CheckoutBtn.Text = "Checkout"
            Return
        End If

        Dim insertedInUserTransaction As Boolean = Await transactRepo.InsertIntoUserTransaction(transactionID)

        If Not insertedInUserTransaction Then
            MessageBox.Show("Please try again.")
            Console.WriteLine("Error inserting the transactionID with userID to userTransaction table.")
            CheckoutBtn.Enabled = True
            CheckoutBtn.Text = "Checkout"
            Return
        End If

        Dim resultCheckout As DialogResult = MessageBox.Show("You have successfully checked out the item. Do you want to see the receipt?", "Checkout Successful", MessageBoxButtons.OKCancel)

        'Polishing the receipt
        Dim receipt As New Receipt(account)
        Dim getDataReceipt As List(Of Cart) = Await cartRepo.GetUserReceiptData()
        Dim totalItem As Decimal = getTotalSumOfItems(getDataReceipt)

        'If resultCheckout = DialogResult.OK Then
        '    receipt.AutoView()
        'Else
        '    MessageBox.Show("Have a good day ahead!", "Success", MessageBoxButtons.OK)
        'End If

        'Reduce stock after checkout
        Dim itemsToReduceStock As List(Of Cart) = Await cartRepo.GetInfoForStockReduce()

        Dim isStockReduced As Boolean = Await cartRepo.ListOfStockToReduce(itemsToReduceStock)

        If Not isStockReduced Then
            MessageBox.Show("Please try again.")
            Debug.WriteLine("Error reducing stock items from the usersCart table.")
            CheckOutBtnText(False)
            Return
        End If

        Dim deleteFromUserCart As Boolean = Await cartRepo.DeleteCheckoutItemFromUsersCart()

        If Not deleteFromUserCart Then
            MessageBox.Show("Error processing your checkout.")
            Debug.WriteLine("Error deleting items from the usersCart table.")
            CheckoutBtn.Enabled = True
            CheckoutBtn.Text = "Checkout"
            Return
        End If

        ' Clear the cart items from the UI
        CheckOutBtnText(False)
        CartPage_Load(sender, e)

        'receipt.PdfReceipt(getDataReceipt, totalItem, transactionID, account)

    End Sub

    Private Function getTotalSumOfItems(totalItems As List(Of Cart)) As Decimal
        Dim itemList As New List(Of Decimal)()

        For Each item In totalItems
            Dim itemPrice As Decimal = item.Medicine.MedicinePrice
            Dim itemQuantity As Integer = item.Quantity
            Dim totalItemPrice As Decimal = itemPrice * itemQuantity
            itemList.Add(totalItemPrice)
        Next

        Dim totalSum As Decimal = itemList.Sum()
        Return totalSum
    End Function

    Private Sub CheckOutBtnText(isCheckingOut As Boolean)
        If Not isCheckingOut Then
            CheckoutBtn.Text = "Checkout"
            CheckoutBtn.Enabled = True
        Else
            CheckoutBtn.Text = "Checking Out..."
            CheckoutBtn.Enabled = False
        End If
    End Sub
End Class