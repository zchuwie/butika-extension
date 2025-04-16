<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pharmaOrderMedList
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
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        quantityLbl = New Label()
        mednameLbl = New Label()
        Guna2Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Guna2Panel1.BorderRadius = 10
        Guna2Panel1.BorderThickness = 3
        Guna2Panel1.Controls.Add(quantityLbl)
        Guna2Panel1.Controls.Add(mednameLbl)
        Guna2Panel1.CustomizableEdges = CustomizableEdges1
        Guna2Panel1.Dock = DockStyle.Fill
        Guna2Panel1.Location = New Point(0, 0)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Panel1.Size = New Size(490, 35)
        Guna2Panel1.TabIndex = 0
        ' 
        ' quantityLbl
        ' 
        quantityLbl.AutoSize = True
        quantityLbl.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        quantityLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        quantityLbl.Location = New Point(415, 9)
        quantityLbl.Name = "quantityLbl"
        quantityLbl.Size = New Size(63, 16)
        quantityLbl.TabIndex = 1
        quantityLbl.Text = "Quantity"
        ' 
        ' mednameLbl
        ' 
        mednameLbl.AutoSize = True
        mednameLbl.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        mednameLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        mednameLbl.Location = New Point(20, 9)
        mednameLbl.Name = "mednameLbl"
        mednameLbl.Size = New Size(111, 16)
        mednameLbl.TabIndex = 0
        mednameLbl.Text = "Medicine Name"
        ' 
        ' pharmaOrderMedList
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        Controls.Add(Guna2Panel1)
        Cursor = Cursors.Default
        Name = "pharmaOrderMedList"
        Size = New Size(490, 35)
        Guna2Panel1.ResumeLayout(False)
        Guna2Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents quantityLbl As Label
    Friend WithEvents mednameLbl As Label

End Class
