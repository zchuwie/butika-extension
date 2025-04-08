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
        medicineImageBox = New PictureBox()
        indicatorPanel = New Guna.UI2.WinForms.Guna2Panel()
        Price = New Label()
        Total = New Label()
        SelectItem = New Guna.UI2.WinForms.Guna2CheckBox()
        MedicineName = New Label()
        Manufacturer = New Label()
        Quantity = New Label()
        CType(medicineImageBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' medicineImageBox
        ' 
        medicineImageBox.BackColor = Color.White
        medicineImageBox.Image = My.Resources.Resources.pressedPills
        medicineImageBox.Location = New Point(83, 17)
        medicineImageBox.Name = "medicineImageBox"
        medicineImageBox.Size = New Size(100, 100)
        medicineImageBox.SizeMode = PictureBoxSizeMode.Zoom
        medicineImageBox.TabIndex = 0
        medicineImageBox.TabStop = False
        ' 
        ' indicatorPanel
        ' 
        indicatorPanel.BackColor = Color.FromArgb(CByte(228), CByte(64), CByte(64))
        indicatorPanel.BorderRadius = 20
        CustomizableEdges1.BottomRight = False
        CustomizableEdges1.TopRight = False
        indicatorPanel.CustomizableEdges = CustomizableEdges1
        indicatorPanel.Location = New Point(0, 0)
        indicatorPanel.Name = "indicatorPanel"
        indicatorPanel.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        indicatorPanel.Size = New Size(54, 135)
        indicatorPanel.TabIndex = 1
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
        Total.Location = New Point(588, 60)
        Total.Name = "Total"
        Total.Size = New Size(46, 18)
        Total.TabIndex = 3
        Total.Text = "Total:"
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
        SelectItem.Location = New Point(721, 56)
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
        ' Quantity
        ' 
        Quantity.AutoSize = True
        Quantity.Font = New Font("Century Gothic", 10.75F, FontStyle.Bold)
        Quantity.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Quantity.Location = New Point(468, 60)
        Quantity.Name = "Quantity"
        Quantity.Size = New Size(70, 18)
        Quantity.TabIndex = 9
        Quantity.Text = "Quantity"
        ' 
        ' cartItem
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BorderStyle = BorderStyle.FixedSingle
        Controls.Add(Quantity)
        Controls.Add(Manufacturer)
        Controls.Add(MedicineName)
        Controls.Add(SelectItem)
        Controls.Add(Total)
        Controls.Add(Price)
        Controls.Add(indicatorPanel)
        Controls.Add(medicineImageBox)
        Name = "cartItem"
        Size = New Size(764, 134)
        CType(medicineImageBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents medicineImageBox As PictureBox
    Friend WithEvents indicatorPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Price As Label
    Friend WithEvents Total As Label
    Friend WithEvents SelectItem As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents MedicineName As Label
    Friend WithEvents Manufacturer As Label
    Friend WithEvents Quantity As Label

End Class
