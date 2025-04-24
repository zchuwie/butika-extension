<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MedicinePageView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        medicineImageBox = New PictureBox()
        Manufacturer = New Label()
        MedName = New Label()
        labelDescription = New Label()
        Description = New Label()
        labelDosage = New Label()
        Dosage = New Label()
        Divider = New Panel()
        closeBtn = New Guna.UI2.WinForms.Guna2Button()
        Price = New Label()
        StockLbl = New Label()
        Stock = New Label()
        IncreaseBtn = New Guna.UI2.WinForms.Guna2Button()
        DecreaseBtn = New Guna.UI2.WinForms.Guna2Button()
        Quantity = New Guna.UI2.WinForms.Guna2TextBox()
        QuantityLbl = New Label()
        BuyNowBtn = New RoundedButton()
        AddToCartBtn = New RoundedButton()
        originalPrice = New Label()
        CType(medicineImageBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' medicineImageBox
        ' 
        medicineImageBox.Location = New Point(22, 26)
        medicineImageBox.Name = "medicineImageBox"
        medicineImageBox.Size = New Size(221, 211)
        medicineImageBox.SizeMode = PictureBoxSizeMode.Zoom
        medicineImageBox.TabIndex = 1
        medicineImageBox.TabStop = False
        ' 
        ' Manufacturer
        ' 
        Manufacturer.AutoSize = True
        Manufacturer.Font = New Font("Century Gothic", 9.75F)
        Manufacturer.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Manufacturer.Location = New Point(258, 49)
        Manufacturer.Name = "Manufacturer"
        Manufacturer.Size = New Size(156, 17)
        Manufacturer.TabIndex = 4
        Manufacturer.Text = "Medicine Manufacturer"
        Manufacturer.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' MedName
        ' 
        MedName.AutoSize = True
        MedName.Font = New Font("Century Gothic", 12.75F, FontStyle.Bold)
        MedName.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        MedName.Location = New Point(257, 30)
        MedName.Name = "MedName"
        MedName.Size = New Size(142, 19)
        MedName.TabIndex = 3
        MedName.Text = "Medicine Name"
        MedName.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' labelDescription
        ' 
        labelDescription.AutoSize = True
        labelDescription.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        labelDescription.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        labelDescription.Location = New Point(255, 82)
        labelDescription.Name = "labelDescription"
        labelDescription.Size = New Size(80, 16)
        labelDescription.TabIndex = 5
        labelDescription.Text = "Description"
        labelDescription.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Description
        ' 
        Description.Font = New Font("Century Gothic", 9.75F)
        Description.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Description.Location = New Point(256, 102)
        Description.Name = "Description"
        Description.Size = New Size(236, 78)
        Description.TabIndex = 6
        Description.Text = "This medicine is the best because it is the best. This is the best because it has alll the things you need for a medicine."
        ' 
        ' labelDosage
        ' 
        labelDosage.AutoSize = True
        labelDosage.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        labelDosage.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        labelDosage.ImageAlign = ContentAlignment.BottomLeft
        labelDosage.LiveSetting = Automation.AutomationLiveSetting.Polite
        labelDosage.Location = New Point(255, 191)
        labelDosage.Name = "labelDosage"
        labelDosage.Size = New Size(60, 16)
        labelDosage.TabIndex = 7
        labelDosage.Text = "Dosage:"
        labelDosage.TextAlign = ContentAlignment.MiddleLeft
        labelDosage.UseMnemonic = False
        ' 
        ' Dosage
        ' 
        Dosage.Font = New Font("Century Gothic", 9.75F)
        Dosage.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Dosage.Location = New Point(312, 191)
        Dosage.Name = "Dosage"
        Dosage.Size = New Size(210, 52)
        Dosage.TabIndex = 8
        Dosage.Text = "Uminom ka ng 1 pc. everyday."
        ' 
        ' Divider
        ' 
        Divider.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Divider.Location = New Point(533, 21)
        Divider.Name = "Divider"
        Divider.Size = New Size(2, 228)
        Divider.TabIndex = 9
        ' 
        ' closeBtn
        ' 
        closeBtn.AutoRoundedCorners = True
        closeBtn.Cursor = Cursors.Hand
        closeBtn.CustomizableEdges = CustomizableEdges1
        closeBtn.DisabledState.BorderColor = Color.DarkGray
        closeBtn.DisabledState.CustomBorderColor = Color.DarkGray
        closeBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        closeBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        closeBtn.FillColor = Color.Transparent
        closeBtn.Font = New Font("Century Gothic", 12.75F, FontStyle.Bold)
        closeBtn.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        closeBtn.ImageSize = New Size(30, 30)
        closeBtn.Location = New Point(698, 5)
        closeBtn.Name = "closeBtn"
        closeBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        closeBtn.Size = New Size(31, 30)
        closeBtn.TabIndex = 11
        closeBtn.Text = "X"
        ' 
        ' Price
        ' 
        Price.AutoSize = True
        Price.Font = New Font("Century Gothic", 12.75F, FontStyle.Bold)
        Price.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Price.Location = New Point(547, 46)
        Price.Name = "Price"
        Price.Size = New Size(81, 19)
        Price.TabIndex = 12
        Price.Text = "PHP 1.00"
        Price.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' StockLbl
        ' 
        StockLbl.AutoSize = True
        StockLbl.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        StockLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        StockLbl.Location = New Point(547, 84)
        StockLbl.Name = "StockLbl"
        StockLbl.Size = New Size(46, 16)
        StockLbl.TabIndex = 13
        StockLbl.Text = "Stock:"
        StockLbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Stock
        ' 
        Stock.AutoSize = True
        Stock.Font = New Font("Century Gothic", 9.75F)
        Stock.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Stock.Location = New Point(591, 84)
        Stock.Name = "Stock"
        Stock.Size = New Size(15, 17)
        Stock.TabIndex = 14
        Stock.Text = "0"
        Stock.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' IncreaseBtn
        ' 
        IncreaseBtn.AutoRoundedCorners = True
        IncreaseBtn.Cursor = Cursors.Hand
        IncreaseBtn.CustomizableEdges = CustomizableEdges3
        IncreaseBtn.DisabledState.BorderColor = Color.DarkGray
        IncreaseBtn.DisabledState.CustomBorderColor = Color.DarkGray
        IncreaseBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        IncreaseBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        IncreaseBtn.FillColor = Color.Transparent
        IncreaseBtn.Font = New Font("Century Gothic", 12.75F, FontStyle.Bold)
        IncreaseBtn.ForeColor = Color.White
        IncreaseBtn.HoverState.Image = My.Resources.Resources.addPressed
        IncreaseBtn.Image = My.Resources.Resources.add
        IncreaseBtn.ImageSize = New Size(18, 18)
        IncreaseBtn.Location = New Point(683, 115)
        IncreaseBtn.Name = "IncreaseBtn"
        IncreaseBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        IncreaseBtn.Size = New Size(30, 30)
        IncreaseBtn.TabIndex = 17
        ' 
        ' DecreaseBtn
        ' 
        DecreaseBtn.AutoRoundedCorners = True
        DecreaseBtn.Cursor = Cursors.Hand
        DecreaseBtn.CustomizableEdges = CustomizableEdges5
        DecreaseBtn.DisabledState.BorderColor = Color.DarkGray
        DecreaseBtn.DisabledState.CustomBorderColor = Color.DarkGray
        DecreaseBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        DecreaseBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        DecreaseBtn.FillColor = Color.Transparent
        DecreaseBtn.Font = New Font("Century Gothic", 12.75F, FontStyle.Bold)
        DecreaseBtn.ForeColor = Color.White
        DecreaseBtn.HoverState.Image = My.Resources.Resources.minusPressed
        DecreaseBtn.Image = My.Resources.Resources.minus
        DecreaseBtn.ImageSize = New Size(18, 18)
        DecreaseBtn.Location = New Point(615, 115)
        DecreaseBtn.Name = "DecreaseBtn"
        DecreaseBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        DecreaseBtn.Size = New Size(30, 30)
        DecreaseBtn.TabIndex = 16
        ' 
        ' Quantity
        ' 
        Quantity.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Quantity.Cursor = Cursors.Hand
        Quantity.CustomizableEdges = CustomizableEdges7
        Quantity.DefaultText = ""
        Quantity.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Quantity.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Quantity.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Quantity.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Quantity.FillColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        Quantity.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Quantity.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        Quantity.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Quantity.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Quantity.Location = New Point(644, 115)
        Quantity.Name = "Quantity"
        Quantity.PlaceholderText = ""
        Quantity.SelectedText = ""
        Quantity.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Quantity.Size = New Size(39, 30)
        Quantity.TabIndex = 15
        Quantity.TextAlign = HorizontalAlignment.Center
        ' 
        ' QuantityLbl
        ' 
        QuantityLbl.AutoSize = True
        QuantityLbl.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        QuantityLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        QuantityLbl.Location = New Point(547, 120)
        QuantityLbl.Name = "QuantityLbl"
        QuantityLbl.Size = New Size(67, 16)
        QuantityLbl.TabIndex = 18
        QuantityLbl.Text = "Quantity:"
        QuantityLbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' BuyNowBtn
        ' 
        BuyNowBtn.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        BuyNowBtn.CornerRadius = 6
        BuyNowBtn.Cursor = Cursors.Hand
        BuyNowBtn.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        BuyNowBtn.ForeColor = Color.White
        BuyNowBtn.Location = New Point(565, 208)
        BuyNowBtn.Name = "BuyNowBtn"
        BuyNowBtn.Size = New Size(133, 30)
        BuyNowBtn.TabIndex = 28
        BuyNowBtn.Text = "Buy Now"
        BuyNowBtn.UseVisualStyleBackColor = False
        ' 
        ' AddToCartBtn
        ' 
        AddToCartBtn.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        AddToCartBtn.CornerRadius = 6
        AddToCartBtn.Cursor = Cursors.Hand
        AddToCartBtn.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        AddToCartBtn.ForeColor = Color.White
        AddToCartBtn.Location = New Point(565, 162)
        AddToCartBtn.Name = "AddToCartBtn"
        AddToCartBtn.Size = New Size(133, 30)
        AddToCartBtn.TabIndex = 27
        AddToCartBtn.Text = "Add To Cart"
        AddToCartBtn.UseVisualStyleBackColor = False
        ' 
        ' originalPrice
        ' 
        originalPrice.AutoSize = True
        originalPrice.Font = New Font("Century Gothic", 8.25F, FontStyle.Bold Or FontStyle.Strikeout, GraphicsUnit.Point, CByte(0))
        originalPrice.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        originalPrice.Location = New Point(547, 30)
        originalPrice.Name = "originalPrice"
        originalPrice.Size = New Size(29, 15)
        originalPrice.TabIndex = 29
        originalPrice.Text = "PHP"
        originalPrice.TextAlign = ContentAlignment.MiddleLeft
        originalPrice.Visible = False
        ' 
        ' MedicinePageView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        ClientSize = New Size(734, 269)
        Controls.Add(originalPrice)
        Controls.Add(BuyNowBtn)
        Controls.Add(AddToCartBtn)
        Controls.Add(QuantityLbl)
        Controls.Add(Quantity)
        Controls.Add(IncreaseBtn)
        Controls.Add(DecreaseBtn)
        Controls.Add(Stock)
        Controls.Add(StockLbl)
        Controls.Add(Price)
        Controls.Add(closeBtn)
        Controls.Add(Divider)
        Controls.Add(labelDosage)
        Controls.Add(Description)
        Controls.Add(labelDescription)
        Controls.Add(Manufacturer)
        Controls.Add(MedName)
        Controls.Add(medicineImageBox)
        Controls.Add(Dosage)
        FormBorderStyle = FormBorderStyle.None
        Name = "MedicinePageView"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MedicinePageView"
        CType(medicineImageBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents medicineImageBox As PictureBox
    Friend WithEvents Manufacturer As Label
    Friend WithEvents MedName As Label
    Friend WithEvents labelDescription As Label
    Friend WithEvents Description As Label
    Friend WithEvents labelDosage As Label
    Friend WithEvents Dosage As Label
    Friend WithEvents Divider As Panel
    Friend WithEvents closeBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Price As Label
    Friend WithEvents StockLbl As Label
    Friend WithEvents Stock As Label
    Friend WithEvents IncreaseBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DecreaseBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Quantity As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents QuantityLbl As Label
    Friend WithEvents BuyNowBtn As RoundedButton
    Friend WithEvents AddToCartBtn As RoundedButton
    Friend WithEvents originalPrice As Label
End Class
