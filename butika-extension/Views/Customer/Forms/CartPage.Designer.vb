<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CartPage
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
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        SelectLbl = New Label()
        TotalLbl = New Label()
        QuantityLbl = New Label()
        PriceLbl = New Label()
        ProductLbl = New Label()
        IndicationLbl = New Label()
        BtnsPanel = New Guna.UI2.WinForms.Guna2Panel()
        CheckoutBtn = New RoundedButton()
        DeleteBtn = New RoundedButton()
        CartSubtext = New Label()
        ShoppingCart = New Label()
        MedIcon = New PictureBox()
        YourOrderSubtext = New Label()
        YourOrders = New Label()
        YourOrderIcon = New PictureBox()
        ReadyUnderline = New Guna.UI2.WinForms.Guna2Panel()
        PendingUnderline = New Guna.UI2.WinForms.Guna2Panel()
        AllItemsUnderline = New Guna.UI2.WinForms.Guna2Panel()
        ReadyLbl = New Label()
        PendingLbl = New Label()
        AllItems = New Label()
        DeclinedUnderline = New Guna.UI2.WinForms.Guna2Panel()
        DeclinedLbl = New Label()
        originalPrice = New Label()
        TotalPriceLbl = New Label()
        CartPanel = New FlowLayoutPanel()
        TotalPriceTxt = New Label()
        selectOrDeselectBtn = New Guna.UI2.WinForms.Guna2Button()
        OrderPanel = New FlowLayoutPanel()
        BtnsPanel.SuspendLayout()
        CType(MedIcon, ComponentModel.ISupportInitialize).BeginInit()
        CType(YourOrderIcon, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SelectLbl
        ' 
        SelectLbl.AutoSize = True
        SelectLbl.Font = New Font("Century Gothic", 7.8F, FontStyle.Bold)
        SelectLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        SelectLbl.Location = New Point(759, 143)
        SelectLbl.Name = "SelectLbl"
        SelectLbl.Size = New Size(43, 15)
        SelectLbl.TabIndex = 24
        SelectLbl.Text = "SELECT"
        ' 
        ' TotalLbl
        ' 
        TotalLbl.AutoSize = True
        TotalLbl.Font = New Font("Century Gothic", 7.8F, FontStyle.Bold)
        TotalLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        TotalLbl.Location = New Point(674, 143)
        TotalLbl.Name = "TotalLbl"
        TotalLbl.Size = New Size(39, 15)
        TotalLbl.TabIndex = 23
        TotalLbl.Text = "TOTAL"
        ' 
        ' QuantityLbl
        ' 
        QuantityLbl.AutoSize = True
        QuantityLbl.Font = New Font("Century Gothic", 7.8F, FontStyle.Bold)
        QuantityLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        QuantityLbl.Location = New Point(540, 143)
        QuantityLbl.Name = "QuantityLbl"
        QuantityLbl.Size = New Size(59, 15)
        QuantityLbl.TabIndex = 22
        QuantityLbl.Text = "QUANTITY"
        ' 
        ' PriceLbl
        ' 
        PriceLbl.AutoSize = True
        PriceLbl.Font = New Font("Century Gothic", 7.8F, FontStyle.Bold)
        PriceLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        PriceLbl.Location = New Point(427, 143)
        PriceLbl.Name = "PriceLbl"
        PriceLbl.Size = New Size(37, 15)
        PriceLbl.TabIndex = 21
        PriceLbl.Text = "PRICE"
        ' 
        ' ProductLbl
        ' 
        ProductLbl.AutoSize = True
        ProductLbl.Font = New Font("Century Gothic", 7.8F, FontStyle.Bold)
        ProductLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        ProductLbl.Location = New Point(245, 143)
        ProductLbl.Name = "ProductLbl"
        ProductLbl.Size = New Size(58, 15)
        ProductLbl.TabIndex = 20
        ProductLbl.Text = "PRODUCT"
        ' 
        ' IndicationLbl
        ' 
        IndicationLbl.AutoSize = True
        IndicationLbl.Font = New Font("Century Gothic", 7.8F, FontStyle.Bold)
        IndicationLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        IndicationLbl.Location = New Point(57, 143)
        IndicationLbl.Name = "IndicationLbl"
        IndicationLbl.Size = New Size(69, 15)
        IndicationLbl.TabIndex = 19
        IndicationLbl.Text = "INDICATION"
        ' 
        ' BtnsPanel
        ' 
        BtnsPanel.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        BtnsPanel.Controls.Add(CheckoutBtn)
        BtnsPanel.Controls.Add(DeleteBtn)
        BtnsPanel.CustomizableEdges = CustomizableEdges1
        BtnsPanel.Location = New Point(895, 563)
        BtnsPanel.Name = "BtnsPanel"
        BtnsPanel.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        BtnsPanel.Size = New Size(289, 118)
        BtnsPanel.TabIndex = 3
        ' 
        ' CheckoutBtn
        ' 
        CheckoutBtn.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        CheckoutBtn.CornerRadius = 6
        CheckoutBtn.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        CheckoutBtn.ForeColor = Color.White
        CheckoutBtn.Location = New Point(14, 69)
        CheckoutBtn.Name = "CheckoutBtn"
        CheckoutBtn.Size = New Size(253, 30)
        CheckoutBtn.TabIndex = 26
        CheckoutBtn.Text = "Checkout"
        CheckoutBtn.UseVisualStyleBackColor = False
        ' 
        ' DeleteBtn
        ' 
        DeleteBtn.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        DeleteBtn.CornerRadius = 6
        DeleteBtn.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        DeleteBtn.ForeColor = Color.White
        DeleteBtn.Location = New Point(14, 23)
        DeleteBtn.Name = "DeleteBtn"
        DeleteBtn.Size = New Size(253, 30)
        DeleteBtn.TabIndex = 25
        DeleteBtn.Text = "Delete"
        DeleteBtn.UseVisualStyleBackColor = False
        ' 
        ' CartSubtext
        ' 
        CartSubtext.AutoSize = True
        CartSubtext.Font = New Font("Century Gothic", 9.75F)
        CartSubtext.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        CartSubtext.Location = New Point(95, 52)
        CartSubtext.Name = "CartSubtext"
        CartSubtext.Size = New Size(140, 17)
        CartSubtext.TabIndex = 11
        CartSubtext.Text = "Manage your orders."
        ' 
        ' ShoppingCart
        ' 
        ShoppingCart.AutoSize = True
        ShoppingCart.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        ShoppingCart.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        ShoppingCart.Location = New Point(94, 22)
        ShoppingCart.Name = "ShoppingCart"
        ShoppingCart.Size = New Size(178, 28)
        ShoppingCart.TabIndex = 10
        ShoppingCart.Text = "Shopping Cart"
        ' 
        ' MedIcon
        ' 
        MedIcon.Image = My.Resources.Resources.cart
        MedIcon.Location = New Point(24, 12)
        MedIcon.Name = "MedIcon"
        MedIcon.Size = New Size(64, 64)
        MedIcon.SizeMode = PictureBoxSizeMode.Zoom
        MedIcon.TabIndex = 12
        MedIcon.TabStop = False
        ' 
        ' YourOrderSubtext
        ' 
        YourOrderSubtext.AutoSize = True
        YourOrderSubtext.Font = New Font("Century Gothic", 6.75F)
        YourOrderSubtext.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        YourOrderSubtext.Location = New Point(942, 86)
        YourOrderSubtext.Name = "YourOrderSubtext"
        YourOrderSubtext.Size = New Size(108, 13)
        YourOrderSubtext.TabIndex = 14
        YourOrderSubtext.Text = "Check out your orders."
        ' 
        ' YourOrders
        ' 
        YourOrders.AutoSize = True
        YourOrders.Font = New Font("Century Gothic", 15F, FontStyle.Bold)
        YourOrders.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        YourOrders.Location = New Point(938, 64)
        YourOrders.Name = "YourOrders"
        YourOrders.Size = New Size(123, 23)
        YourOrders.TabIndex = 13
        YourOrders.Text = "Your Orders"
        ' 
        ' YourOrderIcon
        ' 
        YourOrderIcon.Image = My.Resources.Resources.orderBasket
        YourOrderIcon.Location = New Point(895, 60)
        YourOrderIcon.Name = "YourOrderIcon"
        YourOrderIcon.Size = New Size(38, 45)
        YourOrderIcon.SizeMode = PictureBoxSizeMode.Zoom
        YourOrderIcon.TabIndex = 15
        YourOrderIcon.TabStop = False
        ' 
        ' ReadyUnderline
        ' 
        ReadyUnderline.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        ReadyUnderline.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        ReadyUnderline.CustomizableEdges = CustomizableEdges3
        ReadyUnderline.Location = New Point(193, 122)
        ReadyUnderline.Name = "ReadyUnderline"
        ReadyUnderline.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        ReadyUnderline.Size = New Size(42, 4)
        ReadyUnderline.TabIndex = 20
        ReadyUnderline.Visible = False
        ' 
        ' PendingUnderline
        ' 
        PendingUnderline.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        PendingUnderline.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        PendingUnderline.CustomizableEdges = CustomizableEdges5
        PendingUnderline.Location = New Point(121, 122)
        PendingUnderline.Name = "PendingUnderline"
        PendingUnderline.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        PendingUnderline.Size = New Size(55, 4)
        PendingUnderline.TabIndex = 17
        PendingUnderline.Visible = False
        ' 
        ' AllItemsUnderline
        ' 
        AllItemsUnderline.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        AllItemsUnderline.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        AllItemsUnderline.CustomizableEdges = CustomizableEdges7
        AllItemsUnderline.Location = New Point(48, 122)
        AllItemsUnderline.Name = "AllItemsUnderline"
        AllItemsUnderline.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        AllItemsUnderline.Size = New Size(62, 4)
        AllItemsUnderline.TabIndex = 16
        AllItemsUnderline.Visible = False
        ' 
        ' ReadyLbl
        ' 
        ReadyLbl.AutoSize = True
        ReadyLbl.Cursor = Cursors.Hand
        ReadyLbl.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        ReadyLbl.ForeColor = Color.Gray
        ReadyLbl.Location = New Point(193, 103)
        ReadyLbl.Name = "ReadyLbl"
        ReadyLbl.Size = New Size(49, 16)
        ReadyLbl.TabIndex = 21
        ReadyLbl.Text = "Ready"
        ' 
        ' PendingLbl
        ' 
        PendingLbl.AutoSize = True
        PendingLbl.Cursor = Cursors.Hand
        PendingLbl.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        PendingLbl.ForeColor = Color.Gray
        PendingLbl.Location = New Point(121, 103)
        PendingLbl.Name = "PendingLbl"
        PendingLbl.Size = New Size(60, 16)
        PendingLbl.TabIndex = 19
        PendingLbl.Text = "Pending"
        ' 
        ' AllItems
        ' 
        AllItems.AutoSize = True
        AllItems.Cursor = Cursors.Hand
        AllItems.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        AllItems.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        AllItems.Location = New Point(44, 103)
        AllItems.Name = "AllItems"
        AllItems.Size = New Size(63, 16)
        AllItems.TabIndex = 18
        AllItems.Text = "All Items"
        ' 
        ' DeclinedUnderline
        ' 
        DeclinedUnderline.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        DeclinedUnderline.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        DeclinedUnderline.CustomizableEdges = CustomizableEdges9
        DeclinedUnderline.Location = New Point(249, 122)
        DeclinedUnderline.Name = "DeclinedUnderline"
        DeclinedUnderline.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        DeclinedUnderline.Size = New Size(60, 4)
        DeclinedUnderline.TabIndex = 22
        DeclinedUnderline.Visible = False
        ' 
        ' DeclinedLbl
        ' 
        DeclinedLbl.AutoSize = True
        DeclinedLbl.Cursor = Cursors.Hand
        DeclinedLbl.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        DeclinedLbl.ForeColor = Color.Gray
        DeclinedLbl.Location = New Point(249, 103)
        DeclinedLbl.Name = "DeclinedLbl"
        DeclinedLbl.Size = New Size(65, 16)
        DeclinedLbl.TabIndex = 23
        DeclinedLbl.Text = "Declined"
        ' 
        ' originalPrice
        ' 
        originalPrice.Font = New Font("Century Gothic", 8.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        originalPrice.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        originalPrice.ImageAlign = ContentAlignment.MiddleRight
        originalPrice.Location = New Point(938, 505)
        originalPrice.Name = "originalPrice"
        originalPrice.Size = New Size(246, 18)
        originalPrice.TabIndex = 25
        originalPrice.Text = "0"
        originalPrice.TextAlign = ContentAlignment.MiddleRight
        originalPrice.Visible = False
        ' 
        ' TotalPriceLbl
        ' 
        TotalPriceLbl.AutoSize = True
        TotalPriceLbl.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        TotalPriceLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        TotalPriceLbl.Location = New Point(895, 523)
        TotalPriceLbl.Name = "TotalPriceLbl"
        TotalPriceLbl.Size = New Size(87, 18)
        TotalPriceLbl.TabIndex = 27
        TotalPriceLbl.Text = "Total Price:"
        ' 
        ' CartPanel
        ' 
        CartPanel.AutoScroll = True
        CartPanel.BorderStyle = BorderStyle.FixedSingle
        CartPanel.FlowDirection = FlowDirection.TopDown
        CartPanel.Location = New Point(44, 171)
        CartPanel.Name = "CartPanel"
        CartPanel.Padding = New Padding(23, 0, 23, 0)
        CartPanel.Size = New Size(806, 537)
        CartPanel.TabIndex = 28
        CartPanel.WrapContents = False
        ' 
        ' TotalPriceTxt
        ' 
        TotalPriceTxt.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        TotalPriceTxt.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        TotalPriceTxt.ImageAlign = ContentAlignment.MiddleRight
        TotalPriceTxt.Location = New Point(1020, 523)
        TotalPriceTxt.Name = "TotalPriceTxt"
        TotalPriceTxt.Size = New Size(164, 18)
        TotalPriceTxt.TabIndex = 29
        TotalPriceTxt.Text = "0"
        TotalPriceTxt.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' selectOrDeselectBtn
        ' 
        selectOrDeselectBtn.BorderRadius = 5
        selectOrDeselectBtn.CustomizableEdges = CustomizableEdges11
        selectOrDeselectBtn.DisabledState.BorderColor = Color.DarkGray
        selectOrDeselectBtn.DisabledState.CustomBorderColor = Color.DarkGray
        selectOrDeselectBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        selectOrDeselectBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        selectOrDeselectBtn.FillColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        selectOrDeselectBtn.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        selectOrDeselectBtn.ForeColor = Color.White
        selectOrDeselectBtn.Location = New Point(740, 60)
        selectOrDeselectBtn.Name = "selectOrDeselectBtn"
        selectOrDeselectBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        selectOrDeselectBtn.Size = New Size(101, 39)
        selectOrDeselectBtn.TabIndex = 30
        selectOrDeselectBtn.Text = "Select All"
        ' 
        ' OrderPanel
        ' 
        OrderPanel.FlowDirection = FlowDirection.TopDown
        OrderPanel.Location = New Point(895, 130)
        OrderPanel.Name = "OrderPanel"
        OrderPanel.Size = New Size(289, 360)
        OrderPanel.TabIndex = 31
        ' 
        ' CartPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        ClientSize = New Size(1220, 720)
        Controls.Add(OrderPanel)
        Controls.Add(selectOrDeselectBtn)
        Controls.Add(TotalPriceTxt)
        Controls.Add(SelectLbl)
        Controls.Add(TotalLbl)
        Controls.Add(QuantityLbl)
        Controls.Add(PriceLbl)
        Controls.Add(ProductLbl)
        Controls.Add(IndicationLbl)
        Controls.Add(CartPanel)
        Controls.Add(TotalPriceLbl)
        Controls.Add(originalPrice)
        Controls.Add(DeclinedUnderline)
        Controls.Add(DeclinedLbl)
        Controls.Add(ReadyUnderline)
        Controls.Add(PendingUnderline)
        Controls.Add(AllItemsUnderline)
        Controls.Add(ReadyLbl)
        Controls.Add(PendingLbl)
        Controls.Add(AllItems)
        Controls.Add(YourOrderSubtext)
        Controls.Add(YourOrders)
        Controls.Add(YourOrderIcon)
        Controls.Add(BtnsPanel)
        Controls.Add(CartSubtext)
        Controls.Add(ShoppingCart)
        Controls.Add(MedIcon)
        FormBorderStyle = FormBorderStyle.None
        Name = "CartPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CartPage"
        BtnsPanel.ResumeLayout(False)
        CType(MedIcon, ComponentModel.ISupportInitialize).EndInit()
        CType(YourOrderIcon, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents BtnsPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents CartSubtext As Label
    Friend WithEvents ShoppingCart As Label
    Friend WithEvents MedIcon As PictureBox
    Friend WithEvents YourOrderSubtext As Label
    Friend WithEvents YourOrders As Label
    Friend WithEvents YourOrderIcon As PictureBox
    Friend WithEvents ReadyUnderline As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PendingUnderline As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents AllItemsUnderline As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ReadyLbl As Label
    Friend WithEvents PendingLbl As Label
    Friend WithEvents AllItems As Label
    Friend WithEvents DeclinedUnderline As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents DeclinedLbl As Label
    Friend WithEvents DeleteBtn As RoundedButton
    Friend WithEvents CheckoutBtn As RoundedButton
    Friend WithEvents originalPrice As Label
    Friend WithEvents TotalPriceLbl As Label
    Friend WithEvents SelectLbl As Label
    Friend WithEvents TotalLbl As Label
    Friend WithEvents QuantityLbl As Label
    Friend WithEvents PriceLbl As Label
    Friend WithEvents ProductLbl As Label
    Friend WithEvents IndicationLbl As Label
    Friend WithEvents CartPanel As FlowLayoutPanel
    Friend WithEvents MedItem1 As cartItem
    Friend WithEvents CartItem1 As cartItem
    Friend WithEvents TotalPriceTxt As Label
    Friend WithEvents selectOrDeselectBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents OrderPanel As FlowLayoutPanel
End Class
