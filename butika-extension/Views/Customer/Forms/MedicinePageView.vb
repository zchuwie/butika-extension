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
        Price.Text = medicine.MedicinePrice.ToString("C")
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

        Dim medQuantityFromBox As Integer

        If Integer.TryParse(Quantity.Text, medQuantityFromBox) Then
            Debug.WriteLine("Quantity entered: " & medQuantityFromBox)
        Else
            MessageBox.Show("Please enter a valid number.")
            AddToCartBtn.Enabled = True
            Return
        End If

        If medicine.MedicineStock < medQuantityFromBox Then
            MessageBox.Show("Not enough stock available. Please reduce the quantity.", "Stock Limit", MessageBoxButtons.OK)
            AddToCartBtn.Enabled = True
            Return
        End If

        Dim isAddedToCart As Boolean = Await cartRepo.AddToCart(medicine.MedicineID, medQuantityFromBox)

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

        Price.Text = Convert.ToString(medicine.MedicinePrice * medicineQuantity)
    End Sub

    Private Sub DecreaseBtn_Click(sender As Object, e As EventArgs) Handles DecreaseBtn.Click
        If medicineQuantity > 1 Then
            medicineQuantity -= 1
            Quantity.Text = medicineQuantity.ToString()

            Price.Text = Convert.ToString(medicine.MedicinePrice * medicineQuantity)
        Else
            MessageBox.Show("Quantity cannot be less than 1.")
        End If
    End Sub
End Class