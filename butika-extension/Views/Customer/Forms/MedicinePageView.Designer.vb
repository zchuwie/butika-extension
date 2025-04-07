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
        Dim CustomizableEdges17 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges18 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges19 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges20 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges21 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges22 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges23 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges24 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        MedImg = New PictureBox()
        Manufacturer = New Label()
        MedName = New Label()
        Desc = New Label()
        Label1 = New Label()
        Dosage = New Label()
        Label2 = New Label()
        Divider = New Panel()
        DecreaseBtn = New Guna.UI2.WinForms.Guna2Button()
        Price = New Label()
        StockLbl = New Label()
        Stock = New Label()
        IncreaseBtn = New Guna.UI2.WinForms.Guna2Button()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Quantity = New Guna.UI2.WinForms.Guna2TextBox()
        QuantityLbl = New Label()
        BuyNowBtn = New RoundedButton()
        AddToCartBtn = New RoundedButton()
        CType(MedImg, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MedImg
        ' 
        MedImg.Location = New Point(22, 26)
        MedImg.Name = "MedImg"
        MedImg.Size = New Size(221, 211)
        MedImg.TabIndex = 1
        MedImg.TabStop = False
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
        ' Desc
        ' 
        Desc.AutoSize = True
        Desc.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        Desc.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Desc.Location = New Point(255, 82)
        Desc.Name = "Desc"
        Desc.Size = New Size(80, 16)
        Desc.TabIndex = 5
        Desc.Text = "Description"
        Desc.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Century Gothic", 9.75F)
        Label1.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label1.Location = New Point(256, 102)
        Label1.Name = "Label1"
        Label1.Size = New Size(236, 78)
        Label1.TabIndex = 6
        Label1.Text = "This medicine is the best because it is the best. This is the best because it has alll the things you need for a medicine."
        ' 
        ' Dosage
        ' 
        Dosage.AutoSize = True
        Dosage.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        Dosage.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Dosage.ImageAlign = ContentAlignment.BottomLeft
        Dosage.LiveSetting = Automation.AutomationLiveSetting.Polite
        Dosage.Location = New Point(255, 191)
        Dosage.Name = "Dosage"
        Dosage.Size = New Size(60, 16)
        Dosage.TabIndex = 7
        Dosage.Text = "Dosage:"
        Dosage.TextAlign = ContentAlignment.MiddleLeft
        Dosage.UseMnemonic = False
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Century Gothic", 9.75F)
        Label2.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label2.Location = New Point(312, 191)
        Label2.Name = "Label2"
        Label2.Size = New Size(210, 52)
        Label2.TabIndex = 8
        Label2.Text = "Uminom ka ng 1 pc. everyday."
        ' 
        ' Divider
        ' 
        Divider.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Divider.Location = New Point(533, 21)
        Divider.Name = "Divider"
        Divider.Size = New Size(2, 228)
        Divider.TabIndex = 9
        ' 
        ' DecreaseBtn
        ' 
        DecreaseBtn.AutoRoundedCorners = True
        DecreaseBtn.Cursor = Cursors.Hand
        DecreaseBtn.CustomizableEdges = CustomizableEdges17
        DecreaseBtn.DisabledState.BorderColor = Color.DarkGray
        DecreaseBtn.DisabledState.CustomBorderColor = Color.DarkGray
        DecreaseBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        DecreaseBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        DecreaseBtn.FillColor = Color.Transparent
        DecreaseBtn.Font = New Font("Century Gothic", 12.75F, FontStyle.Bold)
        DecreaseBtn.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        DecreaseBtn.ImageSize = New Size(30, 30)
        DecreaseBtn.Location = New Point(698, 5)
        DecreaseBtn.Name = "DecreaseBtn"
        DecreaseBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges18
        DecreaseBtn.Size = New Size(31, 30)
        DecreaseBtn.TabIndex = 11
        DecreaseBtn.Text = "X"
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
        Stock.Size = New Size(22, 17)
        Stock.TabIndex = 14
        Stock.Text = "99"
        Stock.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' IncreaseBtn
        ' 
        IncreaseBtn.AutoRoundedCorners = True
        IncreaseBtn.Cursor = Cursors.Hand
        IncreaseBtn.CustomizableEdges = CustomizableEdges19
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
        IncreaseBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges20
        IncreaseBtn.Size = New Size(30, 30)
        IncreaseBtn.TabIndex = 17
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.AutoRoundedCorners = True
        Guna2Button1.Cursor = Cursors.Hand
        Guna2Button1.CustomizableEdges = CustomizableEdges21
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.Transparent
        Guna2Button1.Font = New Font("Century Gothic", 12.75F, FontStyle.Bold)
        Guna2Button1.ForeColor = Color.White
        Guna2Button1.HoverState.Image = My.Resources.Resources.minusPressed
        Guna2Button1.Image = My.Resources.Resources.minus
        Guna2Button1.ImageSize = New Size(18, 18)
        Guna2Button1.Location = New Point(615, 115)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges22
        Guna2Button1.Size = New Size(30, 30)
        Guna2Button1.TabIndex = 16
        ' 
        ' Quantity
        ' 
        Quantity.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Quantity.Cursor = Cursors.Hand
        Quantity.CustomizableEdges = CustomizableEdges23
        Quantity.DefaultText = ""
        Quantity.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Quantity.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Quantity.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Quantity.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Quantity.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Quantity.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        Quantity.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Quantity.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Quantity.Location = New Point(644, 115)
        Quantity.Name = "Quantity"
        Quantity.PlaceholderText = ""
        Quantity.SelectedText = ""
        Quantity.ShadowDecoration.CustomizableEdges = CustomizableEdges24
        Quantity.Size = New Size(39, 30)
        Quantity.TabIndex = 15
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
        AddToCartBtn.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        AddToCartBtn.ForeColor = Color.White
        AddToCartBtn.Location = New Point(565, 162)
        AddToCartBtn.Name = "AddToCartBtn"
        AddToCartBtn.Size = New Size(133, 30)
        AddToCartBtn.TabIndex = 27
        AddToCartBtn.Text = "Add To Cart"
        AddToCartBtn.UseVisualStyleBackColor = False
        ' 
        ' MedicinePageView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(734, 269)
        Controls.Add(BuyNowBtn)
        Controls.Add(AddToCartBtn)
        Controls.Add(QuantityLbl)
        Controls.Add(Quantity)
        Controls.Add(IncreaseBtn)
        Controls.Add(Guna2Button1)
        Controls.Add(Stock)
        Controls.Add(StockLbl)
        Controls.Add(Price)
        Controls.Add(DecreaseBtn)
        Controls.Add(Divider)
        Controls.Add(Dosage)
        Controls.Add(Label1)
        Controls.Add(Desc)
        Controls.Add(Manufacturer)
        Controls.Add(MedName)
        Controls.Add(MedImg)
        Controls.Add(Label2)
        FormBorderStyle = FormBorderStyle.None
        Name = "MedicinePageView"
        Text = "MedicinePageView"
        CType(MedImg, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MedImg As PictureBox
    Friend WithEvents Manufacturer As Label
    Friend WithEvents MedName As Label
    Friend WithEvents Desc As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Dosage As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Divider As Panel
    Friend WithEvents DecreaseBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Price As Label
    Friend WithEvents StockLbl As Label
    Friend WithEvents Stock As Label
    Friend WithEvents IncreaseBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Quantity As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents QuantityLbl As Label
    Friend WithEvents BuyNowBtn As RoundedButton
    Friend WithEvents AddToCartBtn As RoundedButton
End Class
