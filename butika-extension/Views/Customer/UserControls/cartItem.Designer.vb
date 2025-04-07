<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cartItem
    Inherits RoundedUserControl

    'UserControl overrides dispose to clean up the component list.
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
        PictureBox1 = New PictureBox()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Price = New Label()
        Total = New Label()
        Quantity = New Guna.UI2.WinForms.Guna2TextBox()
        SelectItem = New Guna.UI2.WinForms.Guna2CheckBox()
        MedicineName = New Label()
        Manufacturer = New Label()
        DecreaseBtn = New Guna.UI2.WinForms.Guna2Button()
        IncreaseBtn = New Guna.UI2.WinForms.Guna2Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.Image = My.Resources.Resources.pressedPills
        PictureBox1.Location = New Point(83, 17)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 100)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = Color.FromArgb(CByte(228), CByte(64), CByte(64))
        Guna2Panel1.BorderRadius = 20
        CustomizableEdges1.BottomRight = False
        CustomizableEdges1.TopRight = False
        Guna2Panel1.CustomizableEdges = CustomizableEdges1
        Guna2Panel1.Location = New Point(0, 0)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Panel1.Size = New Size(54, 135)
        Guna2Panel1.TabIndex = 1
        ' 
        ' Price
        ' 
        Price.AutoSize = True
        Price.Font = New Font("Century Gothic", 10.75F, FontStyle.Bold)
        Price.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Price.Location = New Point(353, 60)
        Price.Name = "Price"
        Price.Size = New Size(66, 18)
        Price.TabIndex = 2
        Price.Text = "PHP 1.00"
        ' 
        ' Total
        ' 
        Total.AutoSize = True
        Total.Font = New Font("Century Gothic", 10.75F, FontStyle.Bold)
        Total.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Total.Location = New Point(576, 60)
        Total.Name = "Total"
        Total.Size = New Size(46, 18)
        Total.TabIndex = 3
        Total.Text = "Total:"
        ' 
        ' Quantity
        ' 
        Quantity.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Quantity.Cursor = Cursors.Hand
        Quantity.CustomizableEdges = CustomizableEdges3
        Quantity.DefaultText = ""
        Quantity.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Quantity.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Quantity.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Quantity.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Quantity.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Quantity.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        Quantity.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Quantity.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Quantity.Location = New Point(482, 49)
        Quantity.Name = "Quantity"
        Quantity.PlaceholderText = ""
        Quantity.SelectedText = ""
        Quantity.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Quantity.Size = New Size(43, 38)
        Quantity.TabIndex = 5
        ' 
        ' SelectItem
        ' 
        SelectItem.AutoSize = True
        SelectItem.BackColor = Color.WhiteSmoke
        SelectItem.CheckedState.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        SelectItem.CheckedState.BorderRadius = 0
        SelectItem.CheckedState.BorderThickness = 1
        SelectItem.CheckedState.FillColor = Color.White
        SelectItem.CheckMarkColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        SelectItem.Cursor = Cursors.Hand
        SelectItem.Location = New Point(718, 64)
        SelectItem.Name = "SelectItem"
        SelectItem.Size = New Size(15, 14)
        SelectItem.TabIndex = 6
        SelectItem.UncheckedState.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        SelectItem.UncheckedState.BorderRadius = 0
        SelectItem.UncheckedState.BorderThickness = 0
        SelectItem.UncheckedState.FillColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        SelectItem.UseVisualStyleBackColor = False
        ' 
        ' MedicineName
        ' 
        MedicineName.AutoSize = True
        MedicineName.Font = New Font("Century Gothic", 11.75F, FontStyle.Bold)
        MedicineName.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        MedicineName.Location = New Point(192, 51)
        MedicineName.Name = "MedicineName"
        MedicineName.Size = New Size(139, 19)
        MedicineName.TabIndex = 7
        MedicineName.Text = " Medicine Name"
        MedicineName.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Manufacturer
        ' 
        Manufacturer.AutoSize = True
        Manufacturer.Font = New Font("Century Gothic", 8.75F)
        Manufacturer.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Manufacturer.Location = New Point(198, 72)
        Manufacturer.Name = "Manufacturer"
        Manufacturer.Size = New Size(89, 17)
        Manufacturer.TabIndex = 8
        Manufacturer.Text = "Manufacturer"
        Manufacturer.TextAlign = ContentAlignment.MiddleLeft
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
        DecreaseBtn.ImageSize = New Size(30, 30)
        DecreaseBtn.Location = New Point(448, 54)
        DecreaseBtn.Name = "DecreaseBtn"
        DecreaseBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        DecreaseBtn.Size = New Size(30, 30)
        DecreaseBtn.TabIndex = 10
        ' 
        ' IncreaseBtn
        ' 
        IncreaseBtn.AutoRoundedCorners = True
        IncreaseBtn.Cursor = Cursors.Hand
        IncreaseBtn.CustomizableEdges = CustomizableEdges7
        IncreaseBtn.DisabledState.BorderColor = Color.DarkGray
        IncreaseBtn.DisabledState.CustomBorderColor = Color.DarkGray
        IncreaseBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        IncreaseBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        IncreaseBtn.FillColor = Color.Transparent
        IncreaseBtn.Font = New Font("Century Gothic", 12.75F, FontStyle.Bold)
        IncreaseBtn.ForeColor = Color.White
        IncreaseBtn.HoverState.Image = My.Resources.Resources.addPressed
        IncreaseBtn.Image = My.Resources.Resources.add
        IncreaseBtn.ImageSize = New Size(30, 30)
        IncreaseBtn.Location = New Point(529, 54)
        IncreaseBtn.Name = "IncreaseBtn"
        IncreaseBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        IncreaseBtn.Size = New Size(30, 30)
        IncreaseBtn.TabIndex = 11
        ' 
        ' cartItem
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BorderStyle = BorderStyle.FixedSingle
        Controls.Add(IncreaseBtn)
        Controls.Add(DecreaseBtn)
        Controls.Add(Manufacturer)
        Controls.Add(MedicineName)
        Controls.Add(SelectItem)
        Controls.Add(Quantity)
        Controls.Add(Total)
        Controls.Add(Price)
        Controls.Add(Guna2Panel1)
        Controls.Add(PictureBox1)
        Name = "cartItem"
        Size = New Size(764, 134)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Price As Label
    Friend WithEvents Total As Label
    Friend WithEvents Quantity As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents SelectItem As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents MedicineName As Label
    Friend WithEvents Manufacturer As Label
    Friend WithEvents DecreaseBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents IncreaseBtn As Guna.UI2.WinForms.Guna2Button

End Class
