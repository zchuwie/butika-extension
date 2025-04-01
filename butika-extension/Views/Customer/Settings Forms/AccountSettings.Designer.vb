<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountSettings
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
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        CancelBtn = New RoundedButton()
        SaveBtn = New RoundedButton()
        LastName = New Label()
        MiddleInitial = New Label()
        FirstName = New Label()
        LastNameTxtbox = New Guna.UI2.WinForms.Guna2TextBox()
        MiddleInitialTxtbox = New Guna.UI2.WinForms.Guna2TextBox()
        FirstNameTxtbox = New Guna.UI2.WinForms.Guna2TextBox()
        EditProfileSubtext = New Label()
        EditProfile = New Label()
        EditProfilePanel = New Panel()
        CancelBtnOutline = New RoundedButton()
        ContactPanel = New Panel()
        Contact = New Label()
        ContactSubtext = New Label()
        EmailTxtbox = New Guna.UI2.WinForms.Guna2TextBox()
        MobileNumberTxtbox = New Guna.UI2.WinForms.Guna2TextBox()
        EmailAddress = New Label()
        MobileNumber = New Label()
        VerifyText = New Label()
        VerifySubtext = New Label()
        Verify = New Label()
        VerifyPanel = New Panel()
        VerifyAccBtn = New RoundedButton()
        SuspendLayout()
        ' 
        ' CancelBtn
        ' 
        CancelBtn.BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        CancelBtn.CornerRadius = 6
        CancelBtn.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        CancelBtn.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        CancelBtn.Location = New Point(556, 742)
        CancelBtn.Name = "CancelBtn"
        CancelBtn.Size = New Size(75, 33)
        CancelBtn.TabIndex = 53
        CancelBtn.Text = "Cancel"
        CancelBtn.UseVisualStyleBackColor = False
        ' 
        ' SaveBtn
        ' 
        SaveBtn.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        SaveBtn.CornerRadius = 6
        SaveBtn.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        SaveBtn.ForeColor = Color.White
        SaveBtn.Location = New Point(649, 741)
        SaveBtn.Name = "SaveBtn"
        SaveBtn.Size = New Size(77, 35)
        SaveBtn.TabIndex = 52
        SaveBtn.Text = "Save"
        SaveBtn.UseVisualStyleBackColor = False
        ' 
        ' LastName
        ' 
        LastName.AutoSize = True
        LastName.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LastName.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        LastName.Location = New Point(31, 213)
        LastName.Name = "LastName"
        LastName.Size = New Size(79, 16)
        LastName.TabIndex = 44
        LastName.Text = "Last Name:"
        ' 
        ' MiddleInitial
        ' 
        MiddleInitial.AutoSize = True
        MiddleInitial.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MiddleInitial.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        MiddleInitial.Location = New Point(31, 152)
        MiddleInitial.Name = "MiddleInitial"
        MiddleInitial.Size = New Size(98, 16)
        MiddleInitial.TabIndex = 43
        MiddleInitial.Text = "Middle Initial:"
        ' 
        ' FirstName
        ' 
        FirstName.AutoSize = True
        FirstName.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FirstName.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        FirstName.Location = New Point(31, 93)
        FirstName.Name = "FirstName"
        FirstName.Size = New Size(79, 16)
        FirstName.TabIndex = 42
        FirstName.Text = "First Name:"
        ' 
        ' LastNameTxtbox
        ' 
        LastNameTxtbox.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        LastNameTxtbox.CustomizableEdges = CustomizableEdges1
        LastNameTxtbox.DefaultText = ""
        LastNameTxtbox.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        LastNameTxtbox.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        LastNameTxtbox.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        LastNameTxtbox.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        LastNameTxtbox.FillColor = Color.FromArgb(CByte(196), CByte(218), CByte(212))
        LastNameTxtbox.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        LastNameTxtbox.Font = New Font("Century Gothic", 9.75F)
        LastNameTxtbox.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        LastNameTxtbox.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        LastNameTxtbox.Location = New Point(31, 232)
        LastNameTxtbox.Name = "LastNameTxtbox"
        LastNameTxtbox.PlaceholderText = ""
        LastNameTxtbox.SelectedText = ""
        LastNameTxtbox.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        LastNameTxtbox.Size = New Size(229, 27)
        LastNameTxtbox.TabIndex = 41
        ' 
        ' MiddleInitialTxtbox
        ' 
        MiddleInitialTxtbox.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        MiddleInitialTxtbox.CustomizableEdges = CustomizableEdges3
        MiddleInitialTxtbox.DefaultText = ""
        MiddleInitialTxtbox.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        MiddleInitialTxtbox.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        MiddleInitialTxtbox.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        MiddleInitialTxtbox.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        MiddleInitialTxtbox.FillColor = Color.FromArgb(CByte(196), CByte(218), CByte(212))
        MiddleInitialTxtbox.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        MiddleInitialTxtbox.Font = New Font("Century Gothic", 9.75F)
        MiddleInitialTxtbox.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        MiddleInitialTxtbox.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        MiddleInitialTxtbox.Location = New Point(31, 171)
        MiddleInitialTxtbox.Name = "MiddleInitialTxtbox"
        MiddleInitialTxtbox.PlaceholderText = ""
        MiddleInitialTxtbox.SelectedText = ""
        MiddleInitialTxtbox.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        MiddleInitialTxtbox.Size = New Size(229, 27)
        MiddleInitialTxtbox.TabIndex = 40
        ' 
        ' FirstNameTxtbox
        ' 
        FirstNameTxtbox.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        FirstNameTxtbox.CustomizableEdges = CustomizableEdges5
        FirstNameTxtbox.DefaultText = ""
        FirstNameTxtbox.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        FirstNameTxtbox.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        FirstNameTxtbox.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        FirstNameTxtbox.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        FirstNameTxtbox.FillColor = Color.FromArgb(CByte(196), CByte(218), CByte(212))
        FirstNameTxtbox.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        FirstNameTxtbox.Font = New Font("Century Gothic", 9.75F)
        FirstNameTxtbox.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        FirstNameTxtbox.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        FirstNameTxtbox.Location = New Point(31, 112)
        FirstNameTxtbox.Name = "FirstNameTxtbox"
        FirstNameTxtbox.PlaceholderText = ""
        FirstNameTxtbox.SelectedText = ""
        FirstNameTxtbox.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        FirstNameTxtbox.Size = New Size(229, 27)
        FirstNameTxtbox.TabIndex = 39
        ' 
        ' EditProfileSubtext
        ' 
        EditProfileSubtext.AutoSize = True
        EditProfileSubtext.Font = New Font("Century Gothic", 9.75F)
        EditProfileSubtext.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        EditProfileSubtext.Location = New Point(31, 42)
        EditProfileSubtext.Name = "EditProfileSubtext"
        EditProfileSubtext.Size = New Size(155, 17)
        EditProfileSubtext.TabIndex = 38
        EditProfileSubtext.Text = "Customize your profile."
        ' 
        ' EditProfile
        ' 
        EditProfile.AutoSize = True
        EditProfile.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        EditProfile.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        EditProfile.Location = New Point(30, 17)
        EditProfile.Name = "EditProfile"
        EditProfile.Size = New Size(130, 28)
        EditProfile.TabIndex = 37
        EditProfile.Text = "Edit Profile"
        EditProfile.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' EditProfilePanel
        ' 
        EditProfilePanel.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        EditProfilePanel.Location = New Point(29, 69)
        EditProfilePanel.Name = "EditProfilePanel"
        EditProfilePanel.RightToLeft = RightToLeft.No
        EditProfilePanel.Size = New Size(700, 2)
        EditProfilePanel.TabIndex = 36
        ' 
        ' CancelBtnOutline
        ' 
        CancelBtnOutline.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        CancelBtnOutline.CornerRadius = 6
        CancelBtnOutline.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        CancelBtnOutline.ForeColor = Color.White
        CancelBtnOutline.Location = New Point(555, 741)
        CancelBtnOutline.Name = "CancelBtnOutline"
        CancelBtnOutline.Size = New Size(77, 35)
        CancelBtnOutline.TabIndex = 54
        CancelBtnOutline.Text = "Save"
        CancelBtnOutline.UseVisualStyleBackColor = False
        ' 
        ' ContactPanel
        ' 
        ContactPanel.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        ContactPanel.Location = New Point(27, 358)
        ContactPanel.Name = "ContactPanel"
        ContactPanel.RightToLeft = RightToLeft.No
        ContactPanel.Size = New Size(700, 2)
        ContactPanel.TabIndex = 45
        ' 
        ' Contact
        ' 
        Contact.AutoSize = True
        Contact.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        Contact.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Contact.Location = New Point(28, 306)
        Contact.Name = "Contact"
        Contact.Size = New Size(105, 28)
        Contact.TabIndex = 46
        Contact.Text = "Contact"
        Contact.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ContactSubtext
        ' 
        ContactSubtext.AutoSize = True
        ContactSubtext.Font = New Font("Century Gothic", 9.75F)
        ContactSubtext.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        ContactSubtext.Location = New Point(29, 331)
        ContactSubtext.Name = "ContactSubtext"
        ContactSubtext.Size = New Size(163, 17)
        ContactSubtext.TabIndex = 47
        ContactSubtext.Text = "How we can reach you."
        ' 
        ' EmailTxtbox
        ' 
        EmailTxtbox.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        EmailTxtbox.CustomizableEdges = CustomizableEdges7
        EmailTxtbox.DefaultText = ""
        EmailTxtbox.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        EmailTxtbox.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        EmailTxtbox.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        EmailTxtbox.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        EmailTxtbox.FillColor = Color.FromArgb(CByte(196), CByte(218), CByte(212))
        EmailTxtbox.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        EmailTxtbox.Font = New Font("Century Gothic", 9.75F)
        EmailTxtbox.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        EmailTxtbox.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        EmailTxtbox.Location = New Point(29, 401)
        EmailTxtbox.Name = "EmailTxtbox"
        EmailTxtbox.PlaceholderText = ""
        EmailTxtbox.SelectedText = ""
        EmailTxtbox.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        EmailTxtbox.Size = New Size(229, 27)
        EmailTxtbox.TabIndex = 48
        ' 
        ' MobileNumberTxtbox
        ' 
        MobileNumberTxtbox.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        MobileNumberTxtbox.CustomizableEdges = CustomizableEdges9
        MobileNumberTxtbox.DefaultText = ""
        MobileNumberTxtbox.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        MobileNumberTxtbox.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        MobileNumberTxtbox.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        MobileNumberTxtbox.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        MobileNumberTxtbox.FillColor = Color.FromArgb(CByte(196), CByte(218), CByte(212))
        MobileNumberTxtbox.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        MobileNumberTxtbox.Font = New Font("Century Gothic", 9.75F)
        MobileNumberTxtbox.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        MobileNumberTxtbox.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        MobileNumberTxtbox.Location = New Point(29, 460)
        MobileNumberTxtbox.Name = "MobileNumberTxtbox"
        MobileNumberTxtbox.PlaceholderText = ""
        MobileNumberTxtbox.SelectedText = ""
        MobileNumberTxtbox.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        MobileNumberTxtbox.Size = New Size(229, 27)
        MobileNumberTxtbox.TabIndex = 49
        ' 
        ' EmailAddress
        ' 
        EmailAddress.AutoSize = True
        EmailAddress.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        EmailAddress.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        EmailAddress.Location = New Point(29, 382)
        EmailAddress.Name = "EmailAddress"
        EmailAddress.Size = New Size(104, 16)
        EmailAddress.TabIndex = 50
        EmailAddress.Text = "Email Address:"
        ' 
        ' MobileNumber
        ' 
        MobileNumber.AutoSize = True
        MobileNumber.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MobileNumber.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        MobileNumber.Location = New Point(29, 441)
        MobileNumber.Name = "MobileNumber"
        MobileNumber.Size = New Size(112, 16)
        MobileNumber.TabIndex = 51
        MobileNumber.Text = "Mobile Number:"
        ' 
        ' VerifyText
        ' 
        VerifyText.AutoSize = True
        VerifyText.Font = New Font("Century Gothic", 9.75F)
        VerifyText.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        VerifyText.Location = New Point(28, 606)
        VerifyText.Name = "VerifyText"
        VerifyText.Size = New Size(411, 17)
        VerifyText.TabIndex = 60
        VerifyText.Text = "To unlock certain features, verify your account using a valid ID."
        ' 
        ' VerifySubtext
        ' 
        VerifySubtext.AutoSize = True
        VerifySubtext.Font = New Font("Century Gothic", 9.75F)
        VerifySubtext.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        VerifySubtext.Location = New Point(31, 566)
        VerifySubtext.Name = "VerifySubtext"
        VerifySubtext.Size = New Size(136, 17)
        VerifySubtext.TabIndex = 57
        VerifySubtext.Text = "Verify your account."
        ' 
        ' Verify
        ' 
        Verify.AutoSize = True
        Verify.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        Verify.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Verify.Location = New Point(29, 538)
        Verify.Name = "Verify"
        Verify.Size = New Size(79, 28)
        Verify.TabIndex = 56
        Verify.Text = "Verify"
        Verify.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' VerifyPanel
        ' 
        VerifyPanel.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        VerifyPanel.Location = New Point(26, 590)
        VerifyPanel.Name = "VerifyPanel"
        VerifyPanel.RightToLeft = RightToLeft.No
        VerifyPanel.Size = New Size(700, 2)
        VerifyPanel.TabIndex = 55
        ' 
        ' VerifyAccBtn
        ' 
        VerifyAccBtn.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        VerifyAccBtn.CornerRadius = 6
        VerifyAccBtn.Font = New Font("Century Gothic", 8.75F, FontStyle.Bold)
        VerifyAccBtn.ForeColor = Color.White
        VerifyAccBtn.Location = New Point(29, 630)
        VerifyAccBtn.Name = "VerifyAccBtn"
        VerifyAccBtn.Size = New Size(149, 29)
        VerifyAccBtn.TabIndex = 61
        VerifyAccBtn.Text = "Verify Account"
        VerifyAccBtn.UseVisualStyleBackColor = False
        ' 
        ' AccountSettings
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        ClientSize = New Size(753, 788)
        Controls.Add(VerifyAccBtn)
        Controls.Add(VerifyText)
        Controls.Add(VerifySubtext)
        Controls.Add(Verify)
        Controls.Add(VerifyPanel)
        Controls.Add(CancelBtn)
        Controls.Add(SaveBtn)
        Controls.Add(MobileNumber)
        Controls.Add(EmailAddress)
        Controls.Add(MobileNumberTxtbox)
        Controls.Add(EmailTxtbox)
        Controls.Add(ContactSubtext)
        Controls.Add(Contact)
        Controls.Add(ContactPanel)
        Controls.Add(LastName)
        Controls.Add(MiddleInitial)
        Controls.Add(FirstName)
        Controls.Add(LastNameTxtbox)
        Controls.Add(MiddleInitialTxtbox)
        Controls.Add(FirstNameTxtbox)
        Controls.Add(EditProfileSubtext)
        Controls.Add(EditProfile)
        Controls.Add(EditProfilePanel)
        Controls.Add(CancelBtnOutline)
        FormBorderStyle = FormBorderStyle.None
        Name = "AccountSettings"
        Text = "AccountSettings"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CancelBtn As RoundedButton
    Friend WithEvents SaveBtn As RoundedButton
    Friend WithEvents LastName As Label
    Friend WithEvents MiddleInitial As Label
    Friend WithEvents FirstName As Label
    Friend WithEvents LastNameTxtbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents MiddleInitialTxtbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents FirstNameTxtbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents EditProfileSubtext As Label
    Friend WithEvents EditProfile As Label
    Friend WithEvents EditProfilePanel As Panel
    Friend WithEvents CancelBtnOutline As RoundedButton
    Friend WithEvents ContactPanel As Panel
    Friend WithEvents Contact As Label
    Friend WithEvents ContactSubtext As Label
    Friend WithEvents EmailTxtbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents MobileNumberTxtbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents EmailAddress As Label
    Friend WithEvents MobileNumber As Label
    Friend WithEvents VerifyText As Label
    Friend WithEvents VerifySubtext As Label
    Friend WithEvents Verify As Label
    Friend WithEvents VerifyPanel As Panel
    Friend WithEvents VerifyAccBtn As RoundedButton
End Class
