<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        ShoppingCart = New Label()
        SettingsPanel = New Panel()
        AccountBtn = New Guna.UI2.WinForms.Guna2Button()
        SecurityBtn = New Guna.UI2.WinForms.Guna2Button()
        SecurityLbl = New Label()
        SecuritySubtext = New Label()
        AccountLbl = New Label()
        AccountSubtext = New Label()
        SuspendLayout()
        ' 
        ' ShoppingCart
        ' 
        ShoppingCart.AutoSize = True
        ShoppingCart.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        ShoppingCart.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        ShoppingCart.Location = New Point(33, 49)
        ShoppingCart.Name = "ShoppingCart"
        ShoppingCart.Size = New Size(100, 28)
        ShoppingCart.TabIndex = 11
        ShoppingCart.Text = "Settings"
        ShoppingCart.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' SettingsPanel
        ' 
        SettingsPanel.AutoScroll = True
        SettingsPanel.BorderStyle = BorderStyle.FixedSingle
        SettingsPanel.Location = New Point(258, 38)
        SettingsPanel.Name = "SettingsPanel"
        SettingsPanel.Size = New Size(915, 649)
        SettingsPanel.TabIndex = 13
        ' 
        ' AccountBtn
        ' 
        AccountBtn.CustomizableEdges = CustomizableEdges1
        AccountBtn.DisabledState.BorderColor = Color.DarkGray
        AccountBtn.DisabledState.CustomBorderColor = Color.DarkGray
        AccountBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        AccountBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        AccountBtn.FillColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        AccountBtn.Font = New Font("Segoe UI", 9F)
        AccountBtn.ForeColor = Color.White
        AccountBtn.Image = My.Resources.Resources.editProfileUnpressed
        AccountBtn.ImageAlign = HorizontalAlignment.Left
        AccountBtn.ImageSize = New Size(43, 43)
        AccountBtn.Location = New Point(33, 80)
        AccountBtn.Name = "AccountBtn"
        AccountBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        AccountBtn.Size = New Size(178, 63)
        AccountBtn.TabIndex = 19
        ' 
        ' SecurityBtn
        ' 
        SecurityBtn.CustomizableEdges = CustomizableEdges3
        SecurityBtn.DisabledState.BorderColor = Color.DarkGray
        SecurityBtn.DisabledState.CustomBorderColor = Color.DarkGray
        SecurityBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        SecurityBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        SecurityBtn.FillColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        SecurityBtn.Font = New Font("Segoe UI", 9F)
        SecurityBtn.ForeColor = Color.White
        SecurityBtn.Image = My.Resources.Resources.EditSecurityUnpressed
        SecurityBtn.ImageAlign = HorizontalAlignment.Left
        SecurityBtn.ImageSize = New Size(43, 43)
        SecurityBtn.Location = New Point(33, 148)
        SecurityBtn.Name = "SecurityBtn"
        SecurityBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        SecurityBtn.Size = New Size(178, 63)
        SecurityBtn.TabIndex = 20
        ' 
        ' SecurityLbl
        ' 
        SecurityLbl.AutoSize = True
        SecurityLbl.BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        SecurityLbl.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        SecurityLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        SecurityLbl.Location = New Point(96, 167)
        SecurityLbl.Name = "SecurityLbl"
        SecurityLbl.Size = New Size(69, 19)
        SecurityLbl.TabIndex = 18
        SecurityLbl.Text = "Security"
        ' 
        ' SecuritySubtext
        ' 
        SecuritySubtext.AutoSize = True
        SecuritySubtext.BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        SecuritySubtext.Font = New Font("Century Gothic", 6.75F)
        SecuritySubtext.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        SecuritySubtext.Location = New Point(98, 184)
        SecuritySubtext.Name = "SecuritySubtext"
        SecuritySubtext.Size = New Size(97, 13)
        SecuritySubtext.TabIndex = 19
        SecuritySubtext.Text = "Ensure your privacy."
        ' 
        ' AccountLbl
        ' 
        AccountLbl.AutoSize = True
        AccountLbl.BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        AccountLbl.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        AccountLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        AccountLbl.Location = New Point(96, 97)
        AccountLbl.Name = "AccountLbl"
        AccountLbl.Size = New Size(75, 19)
        AccountLbl.TabIndex = 16
        AccountLbl.Text = "Account"
        ' 
        ' AccountSubtext
        ' 
        AccountSubtext.AutoSize = True
        AccountSubtext.BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        AccountSubtext.Font = New Font("Century Gothic", 6.75F)
        AccountSubtext.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        AccountSubtext.Location = New Point(98, 114)
        AccountSubtext.Name = "AccountSubtext"
        AccountSubtext.Size = New Size(108, 13)
        AccountSubtext.TabIndex = 17
        AccountSubtext.Text = "Customize your profile."
        ' 
        ' Settings
        ' 
        AutoScaleDimensions = New SizeF(6F, 13F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        ClientSize = New Size(1210, 720)
        Controls.Add(AccountLbl)
        Controls.Add(AccountSubtext)
        Controls.Add(SecurityLbl)
        Controls.Add(SecuritySubtext)
        Controls.Add(SecurityBtn)
        Controls.Add(AccountBtn)
        Controls.Add(SettingsPanel)
        Controls.Add(ShoppingCart)
        Font = New Font("Microsoft Sans Serif", 8.25F)
        FormBorderStyle = FormBorderStyle.None
        Name = "Settings"
        Text = "Settings"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ShoppingCart As Label
    Friend WithEvents SettingsPanel As Panel
    Friend WithEvents AccountBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SecurityBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SecurityLbl As Label
    Friend WithEvents SecuritySubtext As Label
    Friend WithEvents AccountLbl As Label
    Friend WithEvents AccountSubtext As Label
End Class
