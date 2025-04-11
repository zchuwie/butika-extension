<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MedicineBars
    Inherits System.Windows.Forms.UserControl

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
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        medicinebar_bg = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Guna2CustomCheckBox1 = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        expirationDate = New Guna.UI2.WinForms.Guna2HtmlLabel()
        stockQuantity = New Guna.UI2.WinForms.Guna2HtmlLabel()
        manufacturerName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        medicineName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        medicinebar_bg.SuspendLayout()
        SuspendLayout()
        ' 
        ' medicinebar_bg
        ' 
        medicinebar_bg.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(50))
        medicinebar_bg.BorderRadius = 6
        medicinebar_bg.BorderThickness = 1
        medicinebar_bg.Controls.Add(Guna2CustomCheckBox1)
        medicinebar_bg.Controls.Add(expirationDate)
        medicinebar_bg.Controls.Add(stockQuantity)
        medicinebar_bg.Controls.Add(manufacturerName)
        medicinebar_bg.Controls.Add(medicineName)
        medicinebar_bg.CustomizableEdges = CustomizableEdges7
        medicinebar_bg.Enabled = False
        medicinebar_bg.FillColor = Color.FromArgb(CByte(196), CByte(218), CByte(212))
        medicinebar_bg.FillColor2 = Color.FromArgb(CByte(196), CByte(218), CByte(212))
        medicinebar_bg.FillColor3 = Color.FromArgb(CByte(196), CByte(218), CByte(212))
        medicinebar_bg.FillColor4 = Color.FromArgb(CByte(196), CByte(218), CByte(212))
        medicinebar_bg.Location = New Point(0, 0)
        medicinebar_bg.Margin = New Padding(7, 6, 7, 6)
        medicinebar_bg.Name = "medicinebar_bg"
        medicinebar_bg.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        medicinebar_bg.Size = New Size(905, 41)
        medicinebar_bg.TabIndex = 0
        ' 
        ' Guna2CustomCheckBox1
        ' 
        Guna2CustomCheckBox1.Animated = True
        Guna2CustomCheckBox1.BackColor = Color.FromArgb(CByte(196), CByte(218), CByte(212))
        Guna2CustomCheckBox1.CheckedState.BorderColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        Guna2CustomCheckBox1.CheckedState.BorderRadius = 2
        Guna2CustomCheckBox1.CheckedState.BorderThickness = 0
        Guna2CustomCheckBox1.CheckedState.FillColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        Guna2CustomCheckBox1.CheckMarkColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        Guna2CustomCheckBox1.CustomizableEdges = CustomizableEdges5
        Guna2CustomCheckBox1.Location = New Point(857, 12)
        Guna2CustomCheckBox1.Margin = New Padding(3, 2, 3, 2)
        Guna2CustomCheckBox1.Name = "Guna2CustomCheckBox1"
        Guna2CustomCheckBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2CustomCheckBox1.Size = New Size(17, 14)
        Guna2CustomCheckBox1.TabIndex = 4
        Guna2CustomCheckBox1.Text = "Guna2CustomCheckBox1"
        Guna2CustomCheckBox1.UncheckedState.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        Guna2CustomCheckBox1.UncheckedState.BorderRadius = 2
        Guna2CustomCheckBox1.UncheckedState.BorderThickness = 0
        Guna2CustomCheckBox1.UncheckedState.FillColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        Guna2CustomCheckBox1.Visible = False
        ' 
        ' expirationDate
        ' 
        expirationDate.AutoSize = False
        expirationDate.BackColor = Color.Transparent
        expirationDate.Font = New Font("Century Gothic", 8.5F, FontStyle.Bold)
        expirationDate.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        expirationDate.Location = New Point(703, 12)
        expirationDate.Margin = New Padding(3, 2, 3, 2)
        expirationDate.Name = "expirationDate"
        expirationDate.Size = New Size(112, 14)
        expirationDate.TabIndex = 3
        expirationDate.Text = "2999/12/31"
        ' 
        ' stockQuantity
        ' 
        stockQuantity.AutoSize = False
        stockQuantity.BackColor = Color.Transparent
        stockQuantity.Font = New Font("Century Gothic", 8.5F, FontStyle.Bold)
        stockQuantity.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        stockQuantity.Location = New Point(565, 12)
        stockQuantity.Margin = New Padding(3, 2, 3, 2)
        stockQuantity.Name = "stockQuantity"
        stockQuantity.Size = New Size(42, 14)
        stockQuantity.TabIndex = 2
        stockQuantity.Text = "00"
        ' 
        ' manufacturerName
        ' 
        manufacturerName.AutoSize = False
        manufacturerName.BackColor = Color.Transparent
        manufacturerName.Font = New Font("Century Gothic", 8.5F, FontStyle.Bold)
        manufacturerName.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        manufacturerName.Location = New Point(287, 12)
        manufacturerName.Margin = New Padding(3, 2, 3, 2)
        manufacturerName.Name = "manufacturerName"
        manufacturerName.Size = New Size(232, 14)
        manufacturerName.TabIndex = 1
        manufacturerName.Text = "Manufacturer Name Here"
        ' 
        ' medicineName
        ' 
        medicineName.AutoSize = False
        medicineName.BackColor = Color.Transparent
        medicineName.Font = New Font("Century Gothic", 8.5F, FontStyle.Bold)
        medicineName.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        medicineName.Location = New Point(18, 12)
        medicineName.Margin = New Padding(3, 2, 3, 2)
        medicineName.Name = "medicineName"
        medicineName.Size = New Size(211, 14)
        medicineName.TabIndex = 0
        medicineName.Text = "Medicine Name Here"
        ' 
        ' MedicineBars
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(244))
        Controls.Add(medicinebar_bg)
        Margin = New Padding(0, 0, 0, 4)
        Name = "MedicineBars"
        Size = New Size(907, 41)
        medicinebar_bg.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents medicinebar_bg As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents medicineName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents expirationDate As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents stockQuantity As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents manufacturerName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2CustomCheckBox1 As Guna.UI2.WinForms.Guna2CustomCheckBox

End Class
