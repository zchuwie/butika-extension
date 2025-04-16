Imports System.Windows.Forms.VisualStyles
Imports butika.Models

Public Class MedicinePageView

    Dim account As New Account()
    Dim medicine As New Medicine()

    Public medicineQuantity As Integer = 1

    Public Sub New(medicine As Medicine, account As Account)

        Me.medicine = medicine
        Me.account = account

        InitializeComponent()
        LoadMedicine()
    End Sub

    Public Sub LoadMedicine()
        MedName.Text = medicine.FormattedMedicineName
        Manufacturer.Text = medicine.MedicineManufacturer
        Stock.Text = medicine.MedicineStock

        If account.IsVerified = True Then
            originalPrice.Text = "₱" + medicine.MedicinePrice.ToString()
            Price.Text = "₱" + medicine.DiscountedPrice.ToString()
            originalPrice.Visible = True
        Else
            Price.Text = "₱" + medicine.MedicinePrice.ToString()

        End If


        Description.Text = medicine.MedicineDescription
        medicineImageBox.Image = Image.FromFile(medicine.MedicineImagePath)
        Dosage.Text = medicine.MedicineDosage
        Quantity.Text = medicineQuantity.ToString()
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Private Async Sub AddToCartBtn_Click(sender As Object, e As EventArgs) Handles AddToCartBtn.Click
        AddToCartBtn.Enabled = False
        Dim cartRepo As New CartRepository(account)

        If medicine.MedicineStock < 0 Then
            MessageBox.Show("Stock is now empty. Wait for another time...", "Empty Stock", MessageBoxButtons.OK)
            AddToCartBtn.Enabled = True
            Return
        End If

        If Integer.TryParse(Quantity.Text, medicineQuantity) Then
            Debug.WriteLine("Quantity entered: " & medicineQuantity)
        Else
            MessageBox.Show("Please enter a valid number.")
            AddToCartBtn.Enabled = True
            Return
        End If

        If medicine.MedicineStock < medicineQuantity Then
            MessageBox.Show("Not enough stock available. Please reduce the quantity.", "Stock Limit", MessageBoxButtons.OK)
            AddToCartBtn.Enabled = True
            Return
        End If

        Dim isAddedToCart As Boolean = Await cartRepo.AddToCart(medicine.MedicineID, medicineQuantity)

        If Not isAddedToCart Then
            MessageBox.Show("Error inserting the items in the cart.", "Error", MessageBoxButtons.OK)
            Quantity.Text = "1"
            AddToCartBtn.Enabled = True
            Return
        End If

        MessageBox.Show("You have successfully inserted the items in the cart", "Success", MessageBoxButtons.OK)
        Me.Close()
    End Sub

    Private Sub IncreaseBtn_Click(sender As Object, e As EventArgs) Handles IncreaseBtn.Click
        medicineQuantity += 1
        Quantity.Text = medicineQuantity.ToString()

        If account.IsVerified = True Then
            Price.Text = "₱" & Convert.ToString(medicine.DiscountedPrice * medicineQuantity)
            originalPrice.Text = "₱" & Convert.ToString(medicine.MedicinePrice * medicineQuantity)
        Else
            Price.Text = "₱" & Convert.ToString(medicine.MedicinePrice * medicineQuantity)
        End If

    End Sub

    Private Sub DecreaseBtn_Click(sender As Object, e As EventArgs) Handles DecreaseBtn.Click
        If medicineQuantity > 1 Then
            medicineQuantity -= 1
            Quantity.Text = medicineQuantity.ToString()

            If account.IsVerified = True Then
                Price.Text = "₱" & Convert.ToString(medicine.MedicinePrice * medicineQuantity)
                originalPrice.Text = "₱" & Convert.ToString(medicine.MedicinePrice * medicineQuantity)
            Else
                Price.Text = "₱" & Convert.ToString(medicine.DiscountedPrice * medicineQuantity)
            End If

        Else
            MessageBox.Show("Quantity cannot be less than 1.")
        End If
    End Sub

    Private Async Sub BuyNowBtn_Click(sender As Object, e As EventArgs) Handles BuyNowBtn.Click
        Dim transactRepo As New TransactionRepository(account)
        Dim cartRepo As New CartRepository(account)

        If medicine.MedicinePrescription = 1 Then
            Dim addToCart As Boolean = Await cartRepo.AddToCart(medicine.MedicineID, medicineQuantity)

            If Not addToCart Then
                MessageBox.Show("Cannot add to cart. Try Again")
                Return
            End If

            Dim result As DialogResult = MessageBox.Show(
            "You have checked out an item that needs a prescription. Do you want to proceed to the prescription form?",
            "Prescription Needed",
            MessageBoxButtons.OKCancel)

            If result = DialogResult.No Then
                MessageBox.Show("Understandable.. Have a good day!")
                Return
            End If

            Dim sf As New SubmitForm(account)
            sf.ShowDialog()
            Return

        End If

        Dim uniqueTransactionID As String = Await transactRepo.GenerateUniqueTransactionID()
        Dim buyItem As Boolean = Await cartRepo.buyIndividualItem(medicine.MedicineID, medicineQuantity, uniqueTransactionID)

        If Not buyItem Then
            MessageBox.Show("Cannot buy an item due to unexpected error", "Error", MessageBoxButtons.OK)
            Return
        End If

        Dim insertIntoTransaction = Await transactRepo.InsertIntoUserTransaction(uniqueTransactionID)

        If Not insertIntoTransaction Then
            MessageBox.Show("Cannot insert into transaction due to unexpected error", "Error", MessageBoxButtons.OK)
            Return
        End If

        MessageBox.Show("Your item have been successfully bought")



    End Sub
End Class