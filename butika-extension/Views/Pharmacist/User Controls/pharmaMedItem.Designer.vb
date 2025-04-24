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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        medPanel = New Guna.UI2.WinForms.Guna2Panel()
        dosageLbl = New Label()
        manufacturerLbl = New Label()
        mednameLbl = New Label()
        medIdLbl = New Label()
        medPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' medPanel
        ' 
        medPanel.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        medPanel.BorderRadius = 10
        medPanel.BorderThickness = 3
        medPanel.Controls.Add(dosageLbl)
        medPanel.Controls.Add(manufacturerLbl)
        medPanel.Controls.Add(mednameLbl)
        medPanel.Controls.Add(medIdLbl)
        medPanel.CustomizableEdges = CustomizableEdges1
        medPanel.Dock = DockStyle.Fill
        medPanel.FillColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        medPanel.Location = New Point(0, 0)
        medPanel.Name = "medPanel"
        medPanel.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        medPanel.Size = New Size(972, 37)
        medPanel.TabIndex = 0
        ' 
        ' dosageLbl
        ' 
        dosageLbl.AutoSize = True
        dosageLbl.BackColor = Color.Transparent
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
        manufacturerLbl.BackColor = Color.Transparent
        manufacturerLbl.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        manufacturerLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        manufacturerLbl.Location = New Point(565, 10)
        manufacturerLbl.Name = "manufacturerLbl"
        manufacturerLbl.Size = New Size(95, 16)
        manufacturerLbl.TabIndex = 2
        manufacturerLbl.Text = "Manufacturer"
        ' 
        ' mednameLbl
        ' 
        mednameLbl.AutoSize = True
        mednameLbl.BackColor = Color.Transparent
        mednameLbl.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        mednameLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        mednameLbl.Location = New Point(249, 10)
        mednameLbl.Name = "mednameLbl"
        mednameLbl.Size = New Size(111, 16)
        mednameLbl.TabIndex = 1
        mednameLbl.Text = "Medicine Name"
        ' 
        ' medIdLbl
        ' 
        medIdLbl.AutoSize = True
        medIdLbl.BackColor = Color.Transparent
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
        Controls.Add(medPanel)
        Cursor = Cursors.Hand
        Margin = New Padding(0, 3, 0, 0)
        Name = "pharmaMedItem"
        Size = New Size(972, 37)
        medPanel.ResumeLayout(False)
        medPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents medPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dosageLbl As Label
    Friend WithEvents manufacturerLbl As Label
    Friend WithEvents mednameLbl As Label
    Friend WithEvents medIdLbl As Label

End Class
