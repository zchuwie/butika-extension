<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerifyStep2
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
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        VerifySubtext = New Label()
        VerifyAccount = New Label()
        ProgBar = New Panel()
        ProgBar2 = New Panel()
        Phase2Txt = New Label()
        Verify2Direction = New Label()
        EmailCode1 = New Guna.UI2.WinForms.Guna2TextBox()
        EmailCode2 = New Guna.UI2.WinForms.Guna2TextBox()
        EmailCode3 = New Guna.UI2.WinForms.Guna2TextBox()
        EmailCode4 = New Guna.UI2.WinForms.Guna2TextBox()
        EnterEmailCodeBtn = New RoundedButton()
        RefreshCodeLbl = New Label()
        RefreshCodeBtn = New Label()
        RefreshUnderline = New Panel()
        GoBackBtn = New Label()
        SuspendLayout()
        ' 
        ' VerifySubtext
        ' 
        VerifySubtext.AutoSize = True
        VerifySubtext.Font = New Font("Century Gothic", 9.75F)
        VerifySubtext.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        VerifySubtext.Location = New Point(80, 57)
        VerifySubtext.Name = "VerifySubtext"
        VerifySubtext.Size = New Size(136, 17)
        VerifySubtext.TabIndex = 76
        VerifySubtext.Text = "Verify your account."
        ' 
        ' VerifyAccount
        ' 
        VerifyAccount.AutoSize = True
        VerifyAccount.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        VerifyAccount.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        VerifyAccount.Location = New Point(76, 32)
        VerifyAccount.Name = "VerifyAccount"
        VerifyAccount.Size = New Size(184, 28)
        VerifyAccount.TabIndex = 75
        VerifyAccount.Text = "Verify Account"
        VerifyAccount.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ProgBar
        ' 
        ProgBar.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        ProgBar.Location = New Point(23, 105)
        ProgBar.Name = "ProgBar"
        ProgBar.RightToLeft = RightToLeft.No
        ProgBar.Size = New Size(700, 2)
        ProgBar.TabIndex = 74
        ' 
        ' ProgBar2
        ' 
        ProgBar2.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        ProgBar2.Location = New Point(256, 102)
        ProgBar2.Name = "ProgBar2"
        ProgBar2.RightToLeft = RightToLeft.No
        ProgBar2.Size = New Size(233, 7)
        ProgBar2.TabIndex = 78
        ' 
        ' Phase2Txt
        ' 
        Phase2Txt.AutoSize = True
        Phase2Txt.Font = New Font("Century Gothic", 8.75F)
        Phase2Txt.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Phase2Txt.Location = New Point(311, 112)
        Phase2Txt.Name = "Phase2Txt"
        Phase2Txt.Size = New Size(112, 17)
        Phase2Txt.TabIndex = 83
        Phase2Txt.Text = "Email Verification"
        ' 
        ' Verify2Direction
        ' 
        Verify2Direction.Font = New Font("Century Gothic", 15.75F)
        Verify2Direction.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Verify2Direction.Location = New Point(219, 171)
        Verify2Direction.Name = "Verify2Direction"
        Verify2Direction.Size = New Size(301, 60)
        Verify2Direction.TabIndex = 84
        Verify2Direction.Text = "Enter the code that will be sent to your account."
        Verify2Direction.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' EmailCode1
        ' 
        EmailCode1.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        EmailCode1.BorderRadius = 8
        EmailCode1.CustomizableEdges = CustomizableEdges9
        EmailCode1.DefaultText = ""
        EmailCode1.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        EmailCode1.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        EmailCode1.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        EmailCode1.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        EmailCode1.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        EmailCode1.Font = New Font("Century Gothic", 16.25F, FontStyle.Bold)
        EmailCode1.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        EmailCode1.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        EmailCode1.Location = New Point(261, 244)
        EmailCode1.Margin = New Padding(5, 6, 5, 6)
        EmailCode1.MaxLength = 1
        EmailCode1.Name = "EmailCode1"
        EmailCode1.PlaceholderText = ""
        EmailCode1.SelectedText = ""
        EmailCode1.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        EmailCode1.Size = New Size(46, 60)
        EmailCode1.TabIndex = 85
        EmailCode1.TextAlign = HorizontalAlignment.Center
        ' 
        ' EmailCode2
        ' 
        EmailCode2.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        EmailCode2.BorderRadius = 8
        EmailCode2.CustomizableEdges = CustomizableEdges11
        EmailCode2.DefaultText = ""
        EmailCode2.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        EmailCode2.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        EmailCode2.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        EmailCode2.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        EmailCode2.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        EmailCode2.Font = New Font("Century Gothic", 16.25F, FontStyle.Bold)
        EmailCode2.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        EmailCode2.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        EmailCode2.Location = New Point(317, 244)
        EmailCode2.Margin = New Padding(5, 6, 5, 6)
        EmailCode2.MaxLength = 1
        EmailCode2.Name = "EmailCode2"
        EmailCode2.PlaceholderText = ""
        EmailCode2.SelectedText = ""
        EmailCode2.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        EmailCode2.Size = New Size(46, 60)
        EmailCode2.TabIndex = 86
        EmailCode2.TextAlign = HorizontalAlignment.Center
        ' 
        ' EmailCode3
        ' 
        EmailCode3.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        EmailCode3.BorderRadius = 8
        EmailCode3.CustomizableEdges = CustomizableEdges13
        EmailCode3.DefaultText = ""
        EmailCode3.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        EmailCode3.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        EmailCode3.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        EmailCode3.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        EmailCode3.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        EmailCode3.Font = New Font("Century Gothic", 16.25F, FontStyle.Bold)
        EmailCode3.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        EmailCode3.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        EmailCode3.Location = New Point(373, 244)
        EmailCode3.Margin = New Padding(5, 6, 5, 6)
        EmailCode3.MaxLength = 1
        EmailCode3.Name = "EmailCode3"
        EmailCode3.PlaceholderText = ""
        EmailCode3.SelectedText = ""
        EmailCode3.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        EmailCode3.Size = New Size(46, 60)
        EmailCode3.TabIndex = 87
        EmailCode3.TextAlign = HorizontalAlignment.Center
        ' 
        ' EmailCode4
        ' 
        EmailCode4.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        EmailCode4.BorderRadius = 8
        EmailCode4.CustomizableEdges = CustomizableEdges15
        EmailCode4.DefaultText = ""
        EmailCode4.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        EmailCode4.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        EmailCode4.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        EmailCode4.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        EmailCode4.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        EmailCode4.Font = New Font("Century Gothic", 16.25F, FontStyle.Bold)
        EmailCode4.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        EmailCode4.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        EmailCode4.Location = New Point(429, 244)
        EmailCode4.Margin = New Padding(5, 6, 5, 6)
        EmailCode4.MaxLength = 1
        EmailCode4.Name = "EmailCode4"
        EmailCode4.PlaceholderText = ""
        EmailCode4.SelectedText = ""
        EmailCode4.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        EmailCode4.Size = New Size(46, 60)
        EmailCode4.TabIndex = 88
        EmailCode4.TextAlign = HorizontalAlignment.Center
        ' 
        ' EnterEmailCodeBtn
        ' 
        EnterEmailCodeBtn.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        EnterEmailCodeBtn.CornerRadius = 6
        EnterEmailCodeBtn.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        EnterEmailCodeBtn.ForeColor = Color.White
        EnterEmailCodeBtn.Location = New Point(318, 325)
        EnterEmailCodeBtn.Name = "EnterEmailCodeBtn"
        EnterEmailCodeBtn.Size = New Size(104, 30)
        EnterEmailCodeBtn.TabIndex = 89
        EnterEmailCodeBtn.Text = "Enter Code"
        EnterEmailCodeBtn.UseVisualStyleBackColor = False
        ' 
        ' RefreshCodeLbl
        ' 
        RefreshCodeLbl.AutoSize = True
        RefreshCodeLbl.Font = New Font("Century Gothic", 8.75F)
        RefreshCodeLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        RefreshCodeLbl.Location = New Point(246, 387)
        RefreshCodeLbl.Name = "RefreshCodeLbl"
        RefreshCodeLbl.Size = New Size(200, 17)
        RefreshCodeLbl.TabIndex = 90
        RefreshCodeLbl.Text = "Still haven't received the code?"
        ' 
        ' RefreshCodeBtn
        ' 
        RefreshCodeBtn.AutoSize = True
        RefreshCodeBtn.Font = New Font("Century Gothic", 8.75F, FontStyle.Bold)
        RefreshCodeBtn.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        RefreshCodeBtn.Location = New Point(444, 387)
        RefreshCodeBtn.Name = "RefreshCodeBtn"
        RefreshCodeBtn.Size = New Size(49, 16)
        RefreshCodeBtn.TabIndex = 91
        RefreshCodeBtn.Text = "Refresh"
        ' 
        ' RefreshUnderline
        ' 
        RefreshUnderline.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        RefreshUnderline.Location = New Point(448, 401)
        RefreshUnderline.Name = "RefreshUnderline"
        RefreshUnderline.RightToLeft = RightToLeft.No
        RefreshUnderline.Size = New Size(40, 2)
        RefreshUnderline.TabIndex = 92
        ' 
        ' GoBackBtn
        ' 
        GoBackBtn.AutoSize = True
        GoBackBtn.Font = New Font("Century Gothic", 10.5F, FontStyle.Bold)
        GoBackBtn.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        GoBackBtn.Location = New Point(656, 479)
        GoBackBtn.Name = "GoBackBtn"
        GoBackBtn.Size = New Size(67, 17)
        GoBackBtn.TabIndex = 93
        GoBackBtn.Text = "Go Back"
        ' 
        ' VerifyStep2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        ClientSize = New Size(753, 520)
        Controls.Add(GoBackBtn)
        Controls.Add(RefreshUnderline)
        Controls.Add(RefreshCodeBtn)
        Controls.Add(RefreshCodeLbl)
        Controls.Add(EnterEmailCodeBtn)
        Controls.Add(EmailCode4)
        Controls.Add(EmailCode3)
        Controls.Add(EmailCode2)
        Controls.Add(EmailCode1)
        Controls.Add(Verify2Direction)
        Controls.Add(Phase2Txt)
        Controls.Add(ProgBar2)
        Controls.Add(VerifySubtext)
        Controls.Add(VerifyAccount)
        Controls.Add(ProgBar)
        FormBorderStyle = FormBorderStyle.None
        Name = "VerifyStep2"
        Text = "VerifyStep2"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents VerifySubtext As Label
    Friend WithEvents VerifyAccount As Label
    Friend WithEvents ProgBar As Panel
    Friend WithEvents ProgBar2 As Panel
    Friend WithEvents Phase2Txt As Label
    Friend WithEvents Verify2Direction As Label
    Friend WithEvents EmailCode1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents EmailCode2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents EmailCode3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents EmailCode4 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents EnterEmailCodeBtn As RoundedButton
    Friend WithEvents RefreshCodeLbl As Label
    Friend WithEvents RefreshCodeBtn As Label
    Friend WithEvents RefreshUnderline As Panel
    Friend WithEvents GoBackBtn As Label
End Class
