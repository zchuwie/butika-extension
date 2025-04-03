<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SecuritySettings
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
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        DeactivateSubtext = New Label()
        DeactivateAccount = New Label()
        DeactivateDivider = New Panel()
        ConfirmPasswordLbl = New Label()
        NewPasswordLbl = New Label()
        OldPasswordLbl = New Label()
        ConfirmPasswordTxtbox = New Guna.UI2.WinForms.Guna2TextBox()
        NewPasswordTxtbox = New Guna.UI2.WinForms.Guna2TextBox()
        OldPasswordTxtbox = New Guna.UI2.WinForms.Guna2TextBox()
        SecuritySubtext = New Label()
        Security = New Label()
        SecurityDivider = New Panel()
        ChangePassword = New Label()
        VerifyAccBtn = New RoundedButton()
        VerifyText = New Label()
        CancelBtn = New RoundedButton()
        SaveBtn = New RoundedButton()
        CancelBtnOutline = New RoundedButton()
        SuspendLayout()
        ' 
        ' DeactivateSubtext
        ' 
        DeactivateSubtext.AutoSize = True
        DeactivateSubtext.Font = New Font("Century Gothic", 9.75F)
        DeactivateSubtext.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        DeactivateSubtext.Location = New Point(29, 405)
        DeactivateSubtext.Name = "DeactivateSubtext"
        DeactivateSubtext.Size = New Size(175, 17)
        DeactivateSubtext.TabIndex = 63
        DeactivateSubtext.Text = "Deactivate your account."
        ' 
        ' DeactivateAccount
        ' 
        DeactivateAccount.AutoSize = True
        DeactivateAccount.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        DeactivateAccount.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        DeactivateAccount.Location = New Point(24, 377)
        DeactivateAccount.Name = "DeactivateAccount"
        DeactivateAccount.Size = New Size(244, 28)
        DeactivateAccount.TabIndex = 62
        DeactivateAccount.Text = "Deactivate Account"
        DeactivateAccount.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DeactivateDivider
        ' 
        DeactivateDivider.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        DeactivateDivider.Location = New Point(23, 429)
        DeactivateDivider.Name = "DeactivateDivider"
        DeactivateDivider.RightToLeft = RightToLeft.No
        DeactivateDivider.Size = New Size(700, 2)
        DeactivateDivider.TabIndex = 61
        ' 
        ' ConfirmPasswordLbl
        ' 
        ConfirmPasswordLbl.AutoSize = True
        ConfirmPasswordLbl.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ConfirmPasswordLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        ConfirmPasswordLbl.Location = New Point(27, 284)
        ConfirmPasswordLbl.Name = "ConfirmPasswordLbl"
        ConfirmPasswordLbl.Size = New Size(191, 16)
        ConfirmPasswordLbl.TabIndex = 60
        ConfirmPasswordLbl.Text = "Confirm your new password:"
        ' 
        ' NewPasswordLbl
        ' 
        NewPasswordLbl.AutoSize = True
        NewPasswordLbl.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        NewPasswordLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        NewPasswordLbl.Location = New Point(27, 223)
        NewPasswordLbl.Name = "NewPasswordLbl"
        NewPasswordLbl.Size = New Size(172, 16)
        NewPasswordLbl.TabIndex = 59
        NewPasswordLbl.Text = "Enter your new password:"
        ' 
        ' OldPasswordLbl
        ' 
        OldPasswordLbl.AutoSize = True
        OldPasswordLbl.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        OldPasswordLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        OldPasswordLbl.Location = New Point(27, 164)
        OldPasswordLbl.Name = "OldPasswordLbl"
        OldPasswordLbl.Size = New Size(167, 16)
        OldPasswordLbl.TabIndex = 58
        OldPasswordLbl.Text = "Enter your old password:"
        ' 
        ' ConfirmPasswordTxtbox
        ' 
        ConfirmPasswordTxtbox.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        ConfirmPasswordTxtbox.CustomizableEdges = CustomizableEdges7
        ConfirmPasswordTxtbox.DefaultText = ""
        ConfirmPasswordTxtbox.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        ConfirmPasswordTxtbox.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        ConfirmPasswordTxtbox.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        ConfirmPasswordTxtbox.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        ConfirmPasswordTxtbox.FillColor = Color.FromArgb(CByte(196), CByte(218), CByte(212))
        ConfirmPasswordTxtbox.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        ConfirmPasswordTxtbox.Font = New Font("Century Gothic", 9.75F)
        ConfirmPasswordTxtbox.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        ConfirmPasswordTxtbox.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        ConfirmPasswordTxtbox.Location = New Point(28, 303)
        ConfirmPasswordTxtbox.Name = "ConfirmPasswordTxtbox"
        ConfirmPasswordTxtbox.PlaceholderText = ""
        ConfirmPasswordTxtbox.SelectedText = ""
        ConfirmPasswordTxtbox.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        ConfirmPasswordTxtbox.Size = New Size(229, 27)
        ConfirmPasswordTxtbox.TabIndex = 57
        ' 
        ' NewPasswordTxtbox
        ' 
        NewPasswordTxtbox.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        NewPasswordTxtbox.CustomizableEdges = CustomizableEdges9
        NewPasswordTxtbox.DefaultText = ""
        NewPasswordTxtbox.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        NewPasswordTxtbox.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        NewPasswordTxtbox.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        NewPasswordTxtbox.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        NewPasswordTxtbox.FillColor = Color.FromArgb(CByte(196), CByte(218), CByte(212))
        NewPasswordTxtbox.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        NewPasswordTxtbox.Font = New Font("Century Gothic", 9.75F)
        NewPasswordTxtbox.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        NewPasswordTxtbox.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        NewPasswordTxtbox.Location = New Point(27, 242)
        NewPasswordTxtbox.Name = "NewPasswordTxtbox"
        NewPasswordTxtbox.PlaceholderText = ""
        NewPasswordTxtbox.SelectedText = ""
        NewPasswordTxtbox.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        NewPasswordTxtbox.Size = New Size(229, 27)
        NewPasswordTxtbox.TabIndex = 56
        ' 
        ' OldPasswordTxtbox
        ' 
        OldPasswordTxtbox.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        OldPasswordTxtbox.CustomizableEdges = CustomizableEdges11
        OldPasswordTxtbox.DefaultText = ""
        OldPasswordTxtbox.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        OldPasswordTxtbox.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        OldPasswordTxtbox.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        OldPasswordTxtbox.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        OldPasswordTxtbox.FillColor = Color.FromArgb(CByte(196), CByte(218), CByte(212))
        OldPasswordTxtbox.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        OldPasswordTxtbox.Font = New Font("Century Gothic", 9.75F)
        OldPasswordTxtbox.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        OldPasswordTxtbox.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        OldPasswordTxtbox.Location = New Point(25, 183)
        OldPasswordTxtbox.Name = "OldPasswordTxtbox"
        OldPasswordTxtbox.PlaceholderText = ""
        OldPasswordTxtbox.SelectedText = ""
        OldPasswordTxtbox.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        OldPasswordTxtbox.Size = New Size(229, 27)
        OldPasswordTxtbox.TabIndex = 55
        ' 
        ' SecuritySubtext
        ' 
        SecuritySubtext.AutoSize = True
        SecuritySubtext.Font = New Font("Century Gothic", 9.75F)
        SecuritySubtext.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        SecuritySubtext.Location = New Point(29, 71)
        SecuritySubtext.Name = "SecuritySubtext"
        SecuritySubtext.Size = New Size(136, 17)
        SecuritySubtext.TabIndex = 54
        SecuritySubtext.Text = "Secure your privacy,"
        ' 
        ' Security
        ' 
        Security.AutoSize = True
        Security.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        Security.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Security.Location = New Point(28, 46)
        Security.Name = "Security"
        Security.Size = New Size(103, 28)
        Security.TabIndex = 53
        Security.Text = "Security"
        Security.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' SecurityDivider
        ' 
        SecurityDivider.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        SecurityDivider.Location = New Point(27, 98)
        SecurityDivider.Name = "SecurityDivider"
        SecurityDivider.RightToLeft = RightToLeft.No
        SecurityDivider.Size = New Size(700, 2)
        SecurityDivider.TabIndex = 52
        ' 
        ' ChangePassword
        ' 
        ChangePassword.AutoSize = True
        ChangePassword.Font = New Font("Century Gothic", 13F, FontStyle.Bold)
        ChangePassword.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        ChangePassword.Location = New Point(27, 130)
        ChangePassword.Name = "ChangePassword"
        ChangePassword.Size = New Size(169, 22)
        ChangePassword.TabIndex = 68
        ChangePassword.Text = "Change Password"
        ChangePassword.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' VerifyAccBtn
        ' 
        VerifyAccBtn.BackColor = Color.FromArgb(CByte(228), CByte(64), CByte(64))
        VerifyAccBtn.CornerRadius = 6
        VerifyAccBtn.Font = New Font("Century Gothic", 8.75F, FontStyle.Bold)
        VerifyAccBtn.ForeColor = Color.White
        VerifyAccBtn.Location = New Point(29, 479)
        VerifyAccBtn.Name = "VerifyAccBtn"
        VerifyAccBtn.Size = New Size(149, 29)
        VerifyAccBtn.TabIndex = 70
        VerifyAccBtn.Text = "Deactivate Account"
        VerifyAccBtn.UseVisualStyleBackColor = False
        ' 
        ' VerifyText
        ' 
        VerifyText.AutoSize = True
        VerifyText.Font = New Font("Century Gothic", 9.75F)
        VerifyText.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        VerifyText.Location = New Point(28, 455)
        VerifyText.Name = "VerifyText"
        VerifyText.Size = New Size(613, 17)
        VerifyText.TabIndex = 69
        VerifyText.Text = "If for some reason, you may need to deactivate your account, please press the button below."
        ' 
        ' CancelBtn
        ' 
        CancelBtn.BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        CancelBtn.CornerRadius = 6
        CancelBtn.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        CancelBtn.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        CancelBtn.Location = New Point(557, 611)
        CancelBtn.Name = "CancelBtn"
        CancelBtn.Size = New Size(75, 33)
        CancelBtn.TabIndex = 72
        CancelBtn.Text = "Cancel"
        CancelBtn.UseVisualStyleBackColor = False
        ' 
        ' SaveBtn
        ' 
        SaveBtn.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        SaveBtn.CornerRadius = 6
        SaveBtn.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        SaveBtn.ForeColor = Color.White
        SaveBtn.Location = New Point(650, 610)
        SaveBtn.Name = "SaveBtn"
        SaveBtn.Size = New Size(77, 35)
        SaveBtn.TabIndex = 71
        SaveBtn.Text = "Save"
        SaveBtn.UseVisualStyleBackColor = False
        ' 
        ' CancelBtnOutline
        ' 
        CancelBtnOutline.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        CancelBtnOutline.CornerRadius = 6
        CancelBtnOutline.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        CancelBtnOutline.ForeColor = Color.White
        CancelBtnOutline.Location = New Point(556, 610)
        CancelBtnOutline.Name = "CancelBtnOutline"
        CancelBtnOutline.Size = New Size(77, 35)
        CancelBtnOutline.TabIndex = 73
        CancelBtnOutline.Text = "Save"
        CancelBtnOutline.UseVisualStyleBackColor = False
        ' 
        ' SecuritySettings
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        ClientSize = New Size(753, 675)
        Controls.Add(CancelBtn)
        Controls.Add(SaveBtn)
        Controls.Add(CancelBtnOutline)
        Controls.Add(VerifyAccBtn)
        Controls.Add(VerifyText)
        Controls.Add(ChangePassword)
        Controls.Add(DeactivateSubtext)
        Controls.Add(DeactivateAccount)
        Controls.Add(DeactivateDivider)
        Controls.Add(ConfirmPasswordLbl)
        Controls.Add(NewPasswordLbl)
        Controls.Add(OldPasswordLbl)
        Controls.Add(ConfirmPasswordTxtbox)
        Controls.Add(NewPasswordTxtbox)
        Controls.Add(OldPasswordTxtbox)
        Controls.Add(SecuritySubtext)
        Controls.Add(Security)
        Controls.Add(SecurityDivider)
        FormBorderStyle = FormBorderStyle.None
        Name = "SecuritySettings"
        Text = "Deactivate your account."
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DeactivateSubtext As Label
    Friend WithEvents DeactivateAccount As Label
    Friend WithEvents DeactivateDivider As Panel
    Friend WithEvents ConfirmPasswordLbl As Label
    Friend WithEvents NewPasswordLbl As Label
    Friend WithEvents OldPasswordLbl As Label
    Friend WithEvents ConfirmPasswordTxtbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents NewPasswordTxtbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents OldPasswordTxtbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents SecuritySubtext As Label
    Friend WithEvents Security As Label
    Friend WithEvents SecurityDivider As Panel
    Friend WithEvents ChangePassword As Label
    Friend WithEvents VerifyAccBtn As RoundedButton
    Friend WithEvents VerifyText As Label
    Friend WithEvents CancelBtn As RoundedButton
    Friend WithEvents SaveBtn As RoundedButton
    Friend WithEvents CancelBtnOutline As RoundedButton
End Class
