<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pharmaMedItem
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
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        dosageLbl = New Label()
        manufacturerLbl = New Label()
        mednameLbl = New Label()
        medIdLbl = New Label()
        Guna2Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Guna2Panel1.BorderRadius = 10
        Guna2Panel1.BorderThickness = 3
        Guna2Panel1.Controls.Add(dosageLbl)
        Guna2Panel1.Controls.Add(manufacturerLbl)
        Guna2Panel1.Controls.Add(mednameLbl)
        Guna2Panel1.Controls.Add(medIdLbl)
        Guna2Panel1.CustomizableEdges = CustomizableEdges3
        Guna2Panel1.Dock = DockStyle.Fill
        Guna2Panel1.Location = New Point(0, 0)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Panel1.Size = New Size(972, 37)
        Guna2Panel1.TabIndex = 0
        ' 
        ' dosageLbl
        ' 
        dosageLbl.AutoSize = True
        dosageLbl.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        dosageLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        dosageLbl.Location = New Point(834, 10)
        dosageLbl.Name = "dosageLbl"
        dosageLbl.Size = New Size(56, 16)
        dosageLbl.TabIndex = 3
        dosageLbl.Text = "Dosage"
        ' 
        ' manufacturerLbl
        ' 
        manufacturerLbl.AutoSize = True
        manufacturerLbl.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        manufacturerLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        manufacturerLbl.Location = New Point(618, 10)
        manufacturerLbl.Name = "manufacturerLbl"
        manufacturerLbl.Size = New Size(95, 16)
        manufacturerLbl.TabIndex = 2
        manufacturerLbl.Text = "Manufacturer"
        ' 
        ' mednameLbl
        ' 
        mednameLbl.AutoSize = True
        mednameLbl.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        mednameLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        mednameLbl.Location = New Point(296, 10)
        mednameLbl.Name = "mednameLbl"
        mednameLbl.Size = New Size(111, 16)
        mednameLbl.TabIndex = 1
        mednameLbl.Text = "Medicine Name"
        ' 
        ' medIdLbl
        ' 
        medIdLbl.AutoSize = True
        medIdLbl.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        medIdLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        medIdLbl.Location = New Point(26, 10)
        medIdLbl.Name = "medIdLbl"
        medIdLbl.Size = New Size(85, 16)
        medIdLbl.TabIndex = 0
        medIdLbl.Text = "Medicine Id"
        ' 
        ' pharmaMedItem
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        Controls.Add(Guna2Panel1)
        Name = "pharmaMedItem"
        Size = New Size(972, 37)
        Guna2Panel1.ResumeLayout(False)
        Guna2Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dosageLbl As Label
    Friend WithEvents manufacturerLbl As Label
    Friend WithEvents mednameLbl As Label
    Friend WithEvents medIdLbl As Label

End Class
