<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class medItem
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
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(60), CByte(66), CByte(29))
        PictureBox1.Location = New Point(83, 27)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(114, 116)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = Color.Red
        Guna2Panel1.BorderRadius = 20
        CustomizableEdges5.BottomRight = False
        CustomizableEdges5.TopRight = False
        Guna2Panel1.CustomizableEdges = CustomizableEdges5
        Guna2Panel1.Location = New Point(0, 0)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2Panel1.Size = New Size(54, 167)
        Guna2Panel1.TabIndex = 1
        ' 
        ' Price
        ' 
        Price.AutoSize = True
        Price.Location = New Point(279, 70)
        Price.Name = "Price"
        Price.Size = New Size(33, 15)
        Price.TabIndex = 2
        Price.Text = "Price"
        ' 
        ' Total
        ' 
        Total.AutoSize = True
        Total.Location = New Point(542, 76)
        Total.Name = "Total"
        Total.Size = New Size(35, 15)
        Total.TabIndex = 3
        Total.Text = "Total:"
        ' 
        ' Quantity
        ' 
        Quantity.CustomizableEdges = CustomizableEdges7
        Quantity.DefaultText = ""
        Quantity.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Quantity.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Quantity.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Quantity.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Quantity.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Quantity.Font = New Font("Segoe UI", 9F)
        Quantity.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Quantity.Location = New Point(417, 70)
        Quantity.Name = "Quantity"
        Quantity.PlaceholderText = ""
        Quantity.SelectedText = ""
        Quantity.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Quantity.Size = New Size(46, 36)
        Quantity.TabIndex = 5
        ' 
        ' SelectItem
        ' 
        SelectItem.AutoSize = True
        SelectItem.CheckedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        SelectItem.CheckedState.BorderRadius = 0
        SelectItem.CheckedState.BorderThickness = 0
        SelectItem.CheckedState.FillColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        SelectItem.Location = New Point(738, 76)
        SelectItem.Name = "SelectItem"
        SelectItem.Size = New Size(15, 14)
        SelectItem.TabIndex = 6
        SelectItem.UncheckedState.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        SelectItem.UncheckedState.BorderRadius = 0
        SelectItem.UncheckedState.BorderThickness = 0
        SelectItem.UncheckedState.FillColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        ' 
        ' medItem
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(SelectItem)
        Controls.Add(Quantity)
        Controls.Add(Total)
        Controls.Add(Price)
        Controls.Add(Guna2Panel1)
        Controls.Add(PictureBox1)
        Name = "medItem"
        Size = New Size(818, 167)
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

End Class
