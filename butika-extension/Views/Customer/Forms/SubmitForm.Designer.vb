<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubmitForm
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
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        CancelBtn = New Guna.UI2.WinForms.Guna2Button()
        SubmitBtn = New Guna.UI2.WinForms.Guna2Button()
        DateSubmitted = New Label()
        DateLbl = New Label()
        PrescInfoLbl = New Label()
        imageView = New PictureBox()
        BriefInfoTextbox = New Guna.UI2.WinForms.Guna2TextBox()
        BriefInfoLbl = New Label()
        ContactTxtbox = New Guna.UI2.WinForms.Guna2TextBox()
        DocContactLbl = New Label()
        ClinicTxtbox = New Guna.UI2.WinForms.Guna2TextBox()
        DocNameTxtbox = New Guna.UI2.WinForms.Guna2TextBox()
        ClinicLbl = New Label()
        DocNameLbl = New Label()
        DocInfoLbl = New Label()
        PatientAgeTxtbox = New Guna.UI2.WinForms.Guna2TextBox()
        PatientNameTxtbox = New Guna.UI2.WinForms.Guna2TextBox()
        PatientAgeLbl = New Label()
        PatientNameLbl = New Label()
        PatientInfoLbl = New Label()
        prescriptionImageLbl = New Label()
        clickAnywhereLbl = New Label()
        prescriptNumLbl = New Label()
        CType(imageView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' CancelBtn
        ' 
        CancelBtn.BorderRadius = 10
        CancelBtn.CustomizableEdges = CustomizableEdges1
        CancelBtn.DisabledState.BorderColor = Color.DarkGray
        CancelBtn.DisabledState.CustomBorderColor = Color.DarkGray
        CancelBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        CancelBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        CancelBtn.FillColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        CancelBtn.Font = New Font("Segoe UI", 9F)
        CancelBtn.ForeColor = Color.White
        CancelBtn.Location = New Point(238, 537)
        CancelBtn.Name = "CancelBtn"
        CancelBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        CancelBtn.Size = New Size(138, 32)
        CancelBtn.TabIndex = 57
        CancelBtn.Text = "Cancel"
        ' 
        ' SubmitBtn
        ' 
        SubmitBtn.BorderRadius = 10
        SubmitBtn.CustomizableEdges = CustomizableEdges3
        SubmitBtn.DisabledState.BorderColor = Color.DarkGray
        SubmitBtn.DisabledState.CustomBorderColor = Color.DarkGray
        SubmitBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        SubmitBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        SubmitBtn.FillColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        SubmitBtn.Font = New Font("Segoe UI", 9F)
        SubmitBtn.ForeColor = Color.White
        SubmitBtn.Location = New Point(407, 537)
        SubmitBtn.Name = "SubmitBtn"
        SubmitBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        SubmitBtn.Size = New Size(138, 32)
        SubmitBtn.TabIndex = 56
        SubmitBtn.Text = "Submit"
        ' 
        ' DateSubmitted
        ' 
        DateSubmitted.AutoSize = True
        DateSubmitted.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        DateSubmitted.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        DateSubmitted.Location = New Point(542, 101)
        DateSubmitted.Name = "DateSubmitted"
        DateSubmitted.Size = New Size(106, 16)
        DateSubmitted.TabIndex = 54
        DateSubmitted.Text = "Date Submitted"
        DateSubmitted.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DateLbl
        ' 
        DateLbl.AutoSize = True
        DateLbl.Font = New Font("Century Gothic", 9.75F)
        DateLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        DateLbl.Location = New Point(501, 101)
        DateLbl.Name = "DateLbl"
        DateLbl.Size = New Size(44, 17)
        DateLbl.TabIndex = 53
        DateLbl.Text = "Date:"
        DateLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PrescInfoLbl
        ' 
        PrescInfoLbl.AutoSize = True
        PrescInfoLbl.Font = New Font("Century Gothic", 12.75F, FontStyle.Bold)
        PrescInfoLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        PrescInfoLbl.Location = New Point(499, 77)
        PrescInfoLbl.Name = "PrescInfoLbl"
        PrescInfoLbl.Size = New Size(205, 19)
        PrescInfoLbl.TabIndex = 52
        PrescInfoLbl.Text = "Prescription Information:"
        PrescInfoLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' imageView
        ' 
        imageView.BorderStyle = BorderStyle.FixedSingle
        imageView.Location = New Point(501, 180)
        imageView.Name = "imageView"
        imageView.Size = New Size(217, 155)
        imageView.SizeMode = PictureBoxSizeMode.Zoom
        imageView.TabIndex = 50
        imageView.TabStop = False
        ' 
        ' BriefInfoTextbox
        ' 
        BriefInfoTextbox.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        BriefInfoTextbox.CustomizableEdges = CustomizableEdges5
        BriefInfoTextbox.DefaultText = ""
        BriefInfoTextbox.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        BriefInfoTextbox.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        BriefInfoTextbox.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        BriefInfoTextbox.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        BriefInfoTextbox.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        BriefInfoTextbox.Font = New Font("Century Gothic", 9.75F)
        BriefInfoTextbox.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        BriefInfoTextbox.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        BriefInfoTextbox.Location = New Point(21, 396)
        BriefInfoTextbox.Multiline = True
        BriefInfoTextbox.Name = "BriefInfoTextbox"
        BriefInfoTextbox.PlaceholderText = ""
        BriefInfoTextbox.SelectedText = ""
        BriefInfoTextbox.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        BriefInfoTextbox.Size = New Size(697, 105)
        BriefInfoTextbox.TabIndex = 49
        ' 
        ' BriefInfoLbl
        ' 
        BriefInfoLbl.AutoSize = True
        BriefInfoLbl.Font = New Font("Century Gothic", 12.75F, FontStyle.Bold)
        BriefInfoLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        BriefInfoLbl.Location = New Point(18, 369)
        BriefInfoLbl.Name = "BriefInfoLbl"
        BriefInfoLbl.Size = New Size(146, 19)
        BriefInfoLbl.TabIndex = 48
        BriefInfoLbl.Text = "Brief Information:"
        BriefInfoLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ContactTxtbox
        ' 
        ContactTxtbox.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        ContactTxtbox.CustomizableEdges = CustomizableEdges7
        ContactTxtbox.DefaultText = ""
        ContactTxtbox.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        ContactTxtbox.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        ContactTxtbox.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        ContactTxtbox.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        ContactTxtbox.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        ContactTxtbox.Font = New Font("Century Gothic", 9.75F)
        ContactTxtbox.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        ContactTxtbox.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        ContactTxtbox.Location = New Point(114, 305)
        ContactTxtbox.Name = "ContactTxtbox"
        ContactTxtbox.PlaceholderText = ""
        ContactTxtbox.SelectedText = ""
        ContactTxtbox.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        ContactTxtbox.Size = New Size(229, 30)
        ContactTxtbox.TabIndex = 47
        ' 
        ' DocContactLbl
        ' 
        DocContactLbl.AutoSize = True
        DocContactLbl.Font = New Font("Century Gothic", 9.75F)
        DocContactLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        DocContactLbl.Location = New Point(18, 314)
        DocContactLbl.Name = "DocContactLbl"
        DocContactLbl.Size = New Size(90, 17)
        DocContactLbl.TabIndex = 46
        DocContactLbl.Text = "Contact No:"
        DocContactLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ClinicTxtbox
        ' 
        ClinicTxtbox.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        ClinicTxtbox.CustomizableEdges = CustomizableEdges9
        ClinicTxtbox.DefaultText = ""
        ClinicTxtbox.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        ClinicTxtbox.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        ClinicTxtbox.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        ClinicTxtbox.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        ClinicTxtbox.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        ClinicTxtbox.Font = New Font("Century Gothic", 9.75F)
        ClinicTxtbox.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        ClinicTxtbox.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        ClinicTxtbox.Location = New Point(114, 259)
        ClinicTxtbox.Name = "ClinicTxtbox"
        ClinicTxtbox.PlaceholderText = ""
        ClinicTxtbox.SelectedText = ""
        ClinicTxtbox.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        ClinicTxtbox.Size = New Size(229, 30)
        ClinicTxtbox.TabIndex = 45
        ' 
        ' DocNameTxtbox
        ' 
        DocNameTxtbox.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        DocNameTxtbox.CustomizableEdges = CustomizableEdges11
        DocNameTxtbox.DefaultText = ""
        DocNameTxtbox.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        DocNameTxtbox.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        DocNameTxtbox.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        DocNameTxtbox.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        DocNameTxtbox.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        DocNameTxtbox.Font = New Font("Century Gothic", 9.75F)
        DocNameTxtbox.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        DocNameTxtbox.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        DocNameTxtbox.Location = New Point(114, 215)
        DocNameTxtbox.Name = "DocNameTxtbox"
        DocNameTxtbox.PlaceholderText = ""
        DocNameTxtbox.SelectedText = ""
        DocNameTxtbox.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        DocNameTxtbox.Size = New Size(229, 30)
        DocNameTxtbox.TabIndex = 44
        ' 
        ' ClinicLbl
        ' 
        ClinicLbl.AutoSize = True
        ClinicLbl.Font = New Font("Century Gothic", 9.75F)
        ClinicLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        ClinicLbl.Location = New Point(18, 267)
        ClinicLbl.Name = "ClinicLbl"
        ClinicLbl.Size = New Size(48, 17)
        ClinicLbl.TabIndex = 43
        ClinicLbl.Text = "Clinic:"
        ClinicLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DocNameLbl
        ' 
        DocNameLbl.AutoSize = True
        DocNameLbl.Font = New Font("Century Gothic", 9.75F)
        DocNameLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        DocNameLbl.Location = New Point(18, 223)
        DocNameLbl.Name = "DocNameLbl"
        DocNameLbl.Size = New Size(52, 17)
        DocNameLbl.TabIndex = 42
        DocNameLbl.Text = "Name:"
        DocNameLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DocInfoLbl
        ' 
        DocInfoLbl.AutoSize = True
        DocInfoLbl.Font = New Font("Century Gothic", 12.75F, FontStyle.Bold)
        DocInfoLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        DocInfoLbl.Location = New Point(16, 184)
        DocInfoLbl.Name = "DocInfoLbl"
        DocInfoLbl.Size = New Size(177, 19)
        DocInfoLbl.TabIndex = 41
        DocInfoLbl.Text = "Doctor's Information:"
        DocInfoLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PatientAgeTxtbox
        ' 
        PatientAgeTxtbox.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        PatientAgeTxtbox.CustomizableEdges = CustomizableEdges13
        PatientAgeTxtbox.DefaultText = ""
        PatientAgeTxtbox.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        PatientAgeTxtbox.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        PatientAgeTxtbox.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        PatientAgeTxtbox.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        PatientAgeTxtbox.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        PatientAgeTxtbox.Font = New Font("Century Gothic", 9.75F)
        PatientAgeTxtbox.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        PatientAgeTxtbox.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        PatientAgeTxtbox.Location = New Point(80, 130)
        PatientAgeTxtbox.Name = "PatientAgeTxtbox"
        PatientAgeTxtbox.PlaceholderText = ""
        PatientAgeTxtbox.SelectedText = ""
        PatientAgeTxtbox.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        PatientAgeTxtbox.Size = New Size(229, 30)
        PatientAgeTxtbox.TabIndex = 40
        ' 
        ' PatientNameTxtbox
        ' 
        PatientNameTxtbox.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        PatientNameTxtbox.CustomizableEdges = CustomizableEdges15
        PatientNameTxtbox.DefaultText = ""
        PatientNameTxtbox.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        PatientNameTxtbox.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        PatientNameTxtbox.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        PatientNameTxtbox.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        PatientNameTxtbox.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        PatientNameTxtbox.Font = New Font("Century Gothic", 9.75F)
        PatientNameTxtbox.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        PatientNameTxtbox.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        PatientNameTxtbox.Location = New Point(80, 88)
        PatientNameTxtbox.Name = "PatientNameTxtbox"
        PatientNameTxtbox.PlaceholderText = ""
        PatientNameTxtbox.SelectedText = ""
        PatientNameTxtbox.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        PatientNameTxtbox.Size = New Size(229, 30)
        PatientNameTxtbox.TabIndex = 39
        ' 
        ' PatientAgeLbl
        ' 
        PatientAgeLbl.AutoSize = True
        PatientAgeLbl.Font = New Font("Century Gothic", 9.75F)
        PatientAgeLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        PatientAgeLbl.Location = New Point(16, 137)
        PatientAgeLbl.Name = "PatientAgeLbl"
        PatientAgeLbl.Size = New Size(38, 17)
        PatientAgeLbl.TabIndex = 38
        PatientAgeLbl.Text = "Age:"
        PatientAgeLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PatientNameLbl
        ' 
        PatientNameLbl.AutoSize = True
        PatientNameLbl.Font = New Font("Century Gothic", 9.75F)
        PatientNameLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        PatientNameLbl.Location = New Point(16, 93)
        PatientNameLbl.Name = "PatientNameLbl"
        PatientNameLbl.Size = New Size(52, 17)
        PatientNameLbl.TabIndex = 37
        PatientNameLbl.Text = "Name:"
        PatientNameLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PatientInfoLbl
        ' 
        PatientInfoLbl.AutoSize = True
        PatientInfoLbl.Font = New Font("Century Gothic", 12.75F, FontStyle.Bold)
        PatientInfoLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        PatientInfoLbl.Location = New Point(14, 54)
        PatientInfoLbl.Name = "PatientInfoLbl"
        PatientInfoLbl.Size = New Size(165, 19)
        PatientInfoLbl.TabIndex = 36
        PatientInfoLbl.Text = "Patient Information:"
        PatientInfoLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' prescriptionImageLbl
        ' 
        prescriptionImageLbl.Font = New Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        prescriptionImageLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        prescriptionImageLbl.Location = New Point(499, 143)
        prescriptionImageLbl.Name = "prescriptionImageLbl"
        prescriptionImageLbl.Size = New Size(219, 17)
        prescriptionImageLbl.TabIndex = 58
        prescriptionImageLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' clickAnywhereLbl
        ' 
        clickAnywhereLbl.Font = New Font("Century Gothic", 9.75F)
        clickAnywhereLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        clickAnywhereLbl.Location = New Point(542, 232)
        clickAnywhereLbl.Name = "clickAnywhereLbl"
        clickAnywhereLbl.Size = New Size(140, 52)
        clickAnywhereLbl.TabIndex = 59
        clickAnywhereLbl.Text = "Click anywhere to upload a photo" & vbCrLf
        clickAnywhereLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' prescriptNumLbl
        ' 
        prescriptNumLbl.AutoSize = True
        prescriptNumLbl.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        prescriptNumLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        prescriptNumLbl.Location = New Point(296, 9)
        prescriptNumLbl.Name = "prescriptNumLbl"
        prescriptNumLbl.Size = New Size(170, 25)
        prescriptNumLbl.TabIndex = 60
        prescriptNumLbl.Text = "Prescription No."
        prescriptNumLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' SubmitForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(741, 607)
        Controls.Add(prescriptNumLbl)
        Controls.Add(clickAnywhereLbl)
        Controls.Add(prescriptionImageLbl)
        Controls.Add(CancelBtn)
        Controls.Add(SubmitBtn)
        Controls.Add(DateSubmitted)
        Controls.Add(DateLbl)
        Controls.Add(PrescInfoLbl)
        Controls.Add(imageView)
        Controls.Add(BriefInfoTextbox)
        Controls.Add(BriefInfoLbl)
        Controls.Add(ContactTxtbox)
        Controls.Add(DocContactLbl)
        Controls.Add(ClinicTxtbox)
        Controls.Add(DocNameTxtbox)
        Controls.Add(ClinicLbl)
        Controls.Add(DocNameLbl)
        Controls.Add(DocInfoLbl)
        Controls.Add(PatientAgeTxtbox)
        Controls.Add(PatientNameTxtbox)
        Controls.Add(PatientAgeLbl)
        Controls.Add(PatientNameLbl)
        Controls.Add(PatientInfoLbl)
        FormBorderStyle = FormBorderStyle.None
        Name = "SubmitForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SubmitForm"
        CType(imageView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CancelBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SubmitBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DateSubmitted As Label
    Friend WithEvents DateLbl As Label
    Friend WithEvents PrescInfoLbl As Label
    Friend WithEvents imageView As PictureBox
    Friend WithEvents BriefInfoTextbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BriefInfoLbl As Label
    Friend WithEvents ContactTxtbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DocContactLbl As Label
    Friend WithEvents ClinicTxtbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DocNameTxtbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ClinicLbl As Label
    Friend WithEvents DocNameLbl As Label
    Friend WithEvents DocInfoLbl As Label
    Friend WithEvents PatientAgeTxtbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PatientNameTxtbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PatientAgeLbl As Label
    Friend WithEvents PatientNameLbl As Label
    Friend WithEvents PatientInfoLbl As Label
    Friend WithEvents prescriptionImageLbl As Label
    Friend WithEvents clickAnywhereLbl As Label
    Friend WithEvents prescriptNumLbl As Label
End Class
