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
        ShoppingCart = New Label()
        AccountBtnPanel = New Panel()
        Medicines = New Label()
        MedSubtext = New Label()
        SecurityBtnPanel = New Panel()
        SecurityLbl = New Label()
        SecuritySubtext = New Label()
        Divider = New Panel()
        SettingsPanel = New Panel()
        MedIcon = New PictureBox()
        PictureBox1 = New PictureBox()
        AccountBtnPanel.SuspendLayout()
        SecurityBtnPanel.SuspendLayout()
        CType(MedIcon, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ShoppingCart
        ' 
        ShoppingCart.AutoSize = True
        ShoppingCart.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        ShoppingCart.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        ShoppingCart.Location = New Point(38, 49)
        ShoppingCart.Name = "ShoppingCart"
        ShoppingCart.Size = New Size(100, 28)
        ShoppingCart.TabIndex = 11
        ShoppingCart.Text = "Settings"
        ShoppingCart.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' AccountBtnPanel
        ' 
        AccountBtnPanel.Controls.Add(MedIcon)
        AccountBtnPanel.Controls.Add(Medicines)
        AccountBtnPanel.Controls.Add(MedSubtext)
        AccountBtnPanel.Location = New Point(38, 85)
        AccountBtnPanel.Name = "AccountBtnPanel"
        AccountBtnPanel.Size = New Size(171, 50)
        AccountBtnPanel.TabIndex = 12
        ' 
        ' Medicines
        ' 
        Medicines.AutoSize = True
        Medicines.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Medicines.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Medicines.Location = New Point(51, 11)
        Medicines.Name = "Medicines"
        Medicines.Size = New Size(75, 19)
        Medicines.TabIndex = 14
        Medicines.Text = "Account"
        ' 
        ' MedSubtext
        ' 
        MedSubtext.AutoSize = True
        MedSubtext.Font = New Font("Century Gothic", 6.75F)
        MedSubtext.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        MedSubtext.Location = New Point(53, 28)
        MedSubtext.Name = "MedSubtext"
        MedSubtext.Size = New Size(108, 13)
        MedSubtext.TabIndex = 15
        MedSubtext.Text = "Customize your profile."
        ' 
        ' SecurityBtnPanel
        ' 
        SecurityBtnPanel.Controls.Add(PictureBox1)
        SecurityBtnPanel.Controls.Add(SecurityLbl)
        SecurityBtnPanel.Controls.Add(SecuritySubtext)
        SecurityBtnPanel.Location = New Point(38, 136)
        SecurityBtnPanel.Name = "SecurityBtnPanel"
        SecurityBtnPanel.Size = New Size(171, 50)
        SecurityBtnPanel.TabIndex = 13
        ' 
        ' SecurityLbl
        ' 
        SecurityLbl.AutoSize = True
        SecurityLbl.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        SecurityLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        SecurityLbl.Location = New Point(53, 10)
        SecurityLbl.Name = "SecurityLbl"
        SecurityLbl.Size = New Size(69, 19)
        SecurityLbl.TabIndex = 16
        SecurityLbl.Text = "Security"
        ' 
        ' SecuritySubtext
        ' 
        SecuritySubtext.AutoSize = True
        SecuritySubtext.Font = New Font("Century Gothic", 6.75F)
        SecuritySubtext.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        SecuritySubtext.Location = New Point(55, 27)
        SecuritySubtext.Name = "SecuritySubtext"
        SecuritySubtext.Size = New Size(97, 13)
        SecuritySubtext.TabIndex = 17
        SecuritySubtext.Text = "Ensure your privacy."
        ' 
        ' Divider
        ' 
        Divider.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Divider.Location = New Point(234, 38)
        Divider.Name = "Divider"
        Divider.RightToLeft = RightToLeft.No
        Divider.Size = New Size(2, 520)
        Divider.TabIndex = 16
        ' 
        ' SettingsPanel
        ' 
        SettingsPanel.AutoScroll = True
        SettingsPanel.Location = New Point(253, 38)
        SettingsPanel.Name = "SettingsPanel"
        SettingsPanel.Size = New Size(753, 520)
        SettingsPanel.TabIndex = 13
        ' 
        ' MedIcon
        ' 
        MedIcon.Image = My.Resources.Resources.editProfileUnpressed
        MedIcon.Location = New Point(11, 8)
        MedIcon.Name = "MedIcon"
        MedIcon.Size = New Size(37, 35)
        MedIcon.SizeMode = PictureBoxSizeMode.Zoom
        MedIcon.TabIndex = 17
        MedIcon.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.EditSecurityUnpressed
        PictureBox1.Location = New Point(11, 7)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(37, 35)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' Settings
        ' 
        AutoScaleDimensions = New SizeF(6F, 13F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        ClientSize = New Size(1032, 586)
        Controls.Add(SettingsPanel)
        Controls.Add(Divider)
        Controls.Add(SecurityBtnPanel)
        Controls.Add(AccountBtnPanel)
        Controls.Add(ShoppingCart)
        Font = New Font("Microsoft Sans Serif", 8.25F)
        FormBorderStyle = FormBorderStyle.None
        Name = "Settings"
        Text = "Settings"
        AccountBtnPanel.ResumeLayout(False)
        AccountBtnPanel.PerformLayout()
        SecurityBtnPanel.ResumeLayout(False)
        SecurityBtnPanel.PerformLayout()
        CType(MedIcon, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ShoppingCart As Label
    Friend WithEvents AccountBtnPanel As Panel
    Friend WithEvents SecurityBtnPanel As Panel
    Friend WithEvents MedSubtext As Label
    Friend WithEvents Medicines As Label
    Friend WithEvents Divider As Panel
    Friend WithEvents SettingsPanel As Panel
    Friend WithEvents SecurityLbl As Label
    Friend WithEvents SecuritySubtext As Label
    Friend WithEvents MedIcon As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
