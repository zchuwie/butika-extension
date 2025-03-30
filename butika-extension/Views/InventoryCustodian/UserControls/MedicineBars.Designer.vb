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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        medicineName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2CustomCheckBox1 = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Guna2CustomGradientPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2CustomGradientPanel1
        ' 
        Guna2CustomGradientPanel1.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(50))
        Guna2CustomGradientPanel1.BorderRadius = 6
        Guna2CustomGradientPanel1.BorderThickness = 1
        Guna2CustomGradientPanel1.Controls.Add(Guna2CustomCheckBox1)
        Guna2CustomGradientPanel1.Controls.Add(Guna2HtmlLabel3)
        Guna2CustomGradientPanel1.Controls.Add(Guna2HtmlLabel2)
        Guna2CustomGradientPanel1.Controls.Add(Guna2HtmlLabel1)
        Guna2CustomGradientPanel1.Controls.Add(medicineName)
        Guna2CustomGradientPanel1.CustomizableEdges = CustomizableEdges3
        Guna2CustomGradientPanel1.Enabled = False
        Guna2CustomGradientPanel1.FillColor = Color.FromArgb(CByte(196), CByte(218), CByte(212))
        Guna2CustomGradientPanel1.FillColor2 = Color.FromArgb(CByte(196), CByte(218), CByte(212))
        Guna2CustomGradientPanel1.FillColor3 = Color.FromArgb(CByte(196), CByte(218), CByte(212))
        Guna2CustomGradientPanel1.FillColor4 = Color.FromArgb(CByte(196), CByte(218), CByte(212))
        Guna2CustomGradientPanel1.Location = New Point(0, 0)
        Guna2CustomGradientPanel1.Margin = New Padding(8)
        Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2CustomGradientPanel1.Size = New Size(896, 41)
        Guna2CustomGradientPanel1.TabIndex = 0
        ' 
        ' Guna2HtmlLabel3
        ' 
        Guna2HtmlLabel3.AutoSize = False
        Guna2HtmlLabel3.BackColor = Color.Transparent
        Guna2HtmlLabel3.Font = New Font("Century Gothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel3.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Guna2HtmlLabel3.Location = New Point(703, 10)
        Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Guna2HtmlLabel3.Size = New Size(128, 18)
        Guna2HtmlLabel3.TabIndex = 3
        Guna2HtmlLabel3.Text = "2999/12/31"
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.AutoSize = False
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Century Gothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel2.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Guna2HtmlLabel2.Location = New Point(565, 10)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(48, 18)
        Guna2HtmlLabel2.TabIndex = 2
        Guna2HtmlLabel2.Text = "00"
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.AutoSize = False
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Century Gothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel1.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Guna2HtmlLabel1.Location = New Point(281, 10)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(265, 18)
        Guna2HtmlLabel1.TabIndex = 1
        Guna2HtmlLabel1.Text = "Manufacturer Name Here"
        ' 
        ' medicineName
        ' 
        medicineName.AutoSize = False
        medicineName.BackColor = Color.Transparent
        medicineName.Font = New Font("Century Gothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        medicineName.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        medicineName.Location = New Point(20, 10)
        medicineName.Name = "medicineName"
        medicineName.Size = New Size(241, 18)
        medicineName.TabIndex = 0
        medicineName.Text = "Medicine Name Here"
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
        Guna2CustomCheckBox1.CustomizableEdges = CustomizableEdges1
        Guna2CustomCheckBox1.Location = New Point(854, 10)
        Guna2CustomCheckBox1.Name = "Guna2CustomCheckBox1"
        Guna2CustomCheckBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2CustomCheckBox1.Size = New Size(19, 18)
        Guna2CustomCheckBox1.TabIndex = 4
        Guna2CustomCheckBox1.Text = "Guna2CustomCheckBox1"
        Guna2CustomCheckBox1.UncheckedState.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        Guna2CustomCheckBox1.UncheckedState.BorderRadius = 2
        Guna2CustomCheckBox1.UncheckedState.BorderThickness = 0
        Guna2CustomCheckBox1.UncheckedState.FillColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        Guna2CustomCheckBox1.Visible = False
        ' 
        ' MedicineBars
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(244))
        Controls.Add(Guna2CustomGradientPanel1)
        Margin = New Padding(0, 0, 0, 5)
        Name = "MedicineBars"
        Size = New Size(896, 41)
        Guna2CustomGradientPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents medicineName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2CustomCheckBox1 As Guna.UI2.WinForms.Guna2CustomCheckBox

End Class
