<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pharmaTransacItem
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
        dateLbl = New Label()
        transacIdLbl = New Label()
        usernameLbl = New Label()
        userIdLbl = New Label()
        Guna2Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Guna2Panel1.BorderRadius = 10
        Guna2Panel1.BorderThickness = 3
        Guna2Panel1.Controls.Add(dateLbl)
        Guna2Panel1.Controls.Add(transacIdLbl)
        Guna2Panel1.Controls.Add(usernameLbl)
        Guna2Panel1.Controls.Add(userIdLbl)
        Guna2Panel1.CustomizableEdges = CustomizableEdges1
        Guna2Panel1.Dock = DockStyle.Fill
        Guna2Panel1.Location = New Point(0, 0)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Panel1.Size = New Size(964, 37)
        Guna2Panel1.TabIndex = 1
        ' 
        ' dateLbl
        ' 
        dateLbl.AutoSize = True
        dateLbl.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        dateLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        dateLbl.Location = New Point(783, 10)
        dateLbl.Name = "dateLbl"
        dateLbl.Size = New Size(132, 16)
        dateLbl.TabIndex = 3
        dateLbl.Text = "Date of Transaction"
        ' 
        ' transacIdLbl
        ' 
        transacIdLbl.AutoSize = True
        transacIdLbl.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        transacIdLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        transacIdLbl.Location = New Point(538, 10)
        transacIdLbl.Name = "transacIdLbl"
        transacIdLbl.Size = New Size(99, 16)
        transacIdLbl.TabIndex = 2
        transacIdLbl.Text = "Transaction ID"
        ' 
        ' usernameLbl
        ' 
        usernameLbl.AutoSize = True
        usernameLbl.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        usernameLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        usernameLbl.Location = New Point(267, 10)
        usernameLbl.Name = "usernameLbl"
        usernameLbl.Size = New Size(71, 16)
        usernameLbl.TabIndex = 1
        usernameLbl.Text = "Username"
        ' 
        ' userIdLbl
        ' 
        userIdLbl.AutoSize = True
        userIdLbl.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        userIdLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        userIdLbl.Location = New Point(26, 10)
        userIdLbl.Name = "userIdLbl"
        userIdLbl.Size = New Size(51, 16)
        userIdLbl.TabIndex = 0
        userIdLbl.Text = "User ID"
        ' 
        ' pharmaTransacItem
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        Controls.Add(Guna2Panel1)
        Cursor = Cursors.Hand
        Name = "pharmaTransacItem"
        Size = New Size(964, 37)
        Guna2Panel1.ResumeLayout(False)
        Guna2Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dateLbl As Label
    Friend WithEvents transacIdLbl As Label
    Friend WithEvents usernameLbl As Label
    Friend WithEvents userIdLbl As Label

End Class
