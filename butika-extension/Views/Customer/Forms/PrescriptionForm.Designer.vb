<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrescriptionForm
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
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges17 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges18 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges19 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges20 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges21 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges22 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges23 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges24 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        StatusLbl = New Label()
        PrescNo = New Label()
        Status = New Label()
        ReviewDateLbl = New Label()
        ReviewDate = New Label()
        RemarkLbl = New Label()
        Remark = New Label()
        PatientInfoLbl = New Label()
        PatientNameLbl = New Label()
        PatientAgeLbl = New Label()
        PatientNameTxtbox = New Guna.UI2.WinForms.Guna2TextBox()
        PatientAgeTxtbox = New Guna.UI2.WinForms.Guna2TextBox()
        ClinicTxtbox = New Guna.UI2.WinForms.Guna2TextBox()
        DocNameTxtbox = New Guna.UI2.WinForms.Guna2TextBox()
        ClinicLbl = New Label()
        DocNameLbl = New Label()
        DocInfoLbl = New Label()
        ContactTxtbox = New Guna.UI2.WinForms.Guna2TextBox()
        DocContactLbl = New Label()
        BriefInfoLbl = New Label()
        BriefInfoTextbox = New Guna.UI2.WinForms.Guna2TextBox()
        PrescDigiCopy = New PictureBox()
        DrugListBox = New ListBox()
        DateLbl = New Label()
        PrescInfoLbl = New Label()
        DateSubmitted = New Label()
        PrescDigiCopyLbl = New Label()
        DrugListLbl = New Label()
        CType(PrescDigiCopy, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' StatusLbl
        ' 
        StatusLbl.AutoSize = True
        StatusLbl.Font = New Font("Century Gothic", 9.75F)
        StatusLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        StatusLbl.Location = New Point(23, 50)
        StatusLbl.Name = "StatusLbl"
        StatusLbl.Size = New Size(50, 17)
        StatusLbl.TabIndex = 6
        StatusLbl.Text = "Status:"
        StatusLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PrescNo
        ' 
        PrescNo.AutoSize = True
        PrescNo.Font = New Font("Century Gothic", 12.75F, FontStyle.Bold)
        PrescNo.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        PrescNo.Location = New Point(21, 26)
        PrescNo.Name = "PrescNo"
        PrescNo.Size = New Size(137, 19)
        PrescNo.TabIndex = 5
        PrescNo.Text = "Prescription No."
        PrescNo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Status
        ' 
        Status.AutoSize = True
        Status.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        Status.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Status.Location = New Point(70, 51)
        Status.Name = "Status"
        Status.Size = New Size(60, 16)
        Status.TabIndex = 7
        Status.Text = "Pending"
        Status.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ReviewDateLbl
        ' 
        ReviewDateLbl.AutoSize = True
        ReviewDateLbl.Font = New Font("Century Gothic", 9.75F)
        ReviewDateLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        ReviewDateLbl.Location = New Point(271, 29)
        ReviewDateLbl.Name = "ReviewDateLbl"
        ReviewDateLbl.Size = New Size(179, 17)
        ReviewDateLbl.TabIndex = 8
        ReviewDateLbl.Text = "Pharmacist's Review Date:"
        ReviewDateLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ReviewDate
        ' 
        ReviewDate.AutoSize = True
        ReviewDate.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        ReviewDate.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        ReviewDate.Location = New Point(271, 49)
        ReviewDate.Name = "ReviewDate"
        ReviewDate.Size = New Size(94, 16)
        ReviewDate.TabIndex = 9
        ReviewDate.Text = "Under Review"
        ReviewDate.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' RemarkLbl
        ' 
        RemarkLbl.AutoSize = True
        RemarkLbl.Font = New Font("Century Gothic", 9.75F)
        RemarkLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        RemarkLbl.Location = New Point(525, 29)
        RemarkLbl.Name = "RemarkLbl"
        RemarkLbl.Size = New Size(150, 17)
        RemarkLbl.TabIndex = 10
        RemarkLbl.Text = "Pharmacist's Remarks:"
        RemarkLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Remark
        ' 
        Remark.AutoSize = True
        Remark.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        Remark.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Remark.Location = New Point(525, 49)
        Remark.Name = "Remark"
        Remark.Size = New Size(94, 16)
        Remark.TabIndex = 11
        Remark.Text = "Under Review"
        Remark.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PatientInfoLbl
        ' 
        PatientInfoLbl.AutoSize = True
        PatientInfoLbl.Font = New Font("Century Gothic", 12.75F, FontStyle.Bold)
        PatientInfoLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        PatientInfoLbl.Location = New Point(23, 95)
        PatientInfoLbl.Name = "PatientInfoLbl"
        PatientInfoLbl.Size = New Size(165, 19)
        PatientInfoLbl.TabIndex = 12
        PatientInfoLbl.Text = "Patient Information:"
        PatientInfoLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PatientNameLbl
        ' 
        PatientNameLbl.AutoSize = True
        PatientNameLbl.Font = New Font("Century Gothic", 9.75F)
        PatientNameLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        PatientNameLbl.Location = New Point(25, 134)
        PatientNameLbl.Name = "PatientNameLbl"
        PatientNameLbl.Size = New Size(52, 17)
        PatientNameLbl.TabIndex = 13
        PatientNameLbl.Text = "Name:"
        PatientNameLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PatientAgeLbl
        ' 
        PatientAgeLbl.AutoSize = True
        PatientAgeLbl.Font = New Font("Century Gothic", 9.75F)
        PatientAgeLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        PatientAgeLbl.Location = New Point(25, 178)
        PatientAgeLbl.Name = "PatientAgeLbl"
        PatientAgeLbl.Size = New Size(38, 17)
        PatientAgeLbl.TabIndex = 14
        PatientAgeLbl.Text = "Age:"
        PatientAgeLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PatientNameTxtbox
        ' 
        PatientNameTxtbox.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        PatientNameTxtbox.CustomizableEdges = CustomizableEdges13
        PatientNameTxtbox.DefaultText = ""
        PatientNameTxtbox.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        PatientNameTxtbox.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        PatientNameTxtbox.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        PatientNameTxtbox.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        PatientNameTxtbox.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        PatientNameTxtbox.Font = New Font("Century Gothic", 9.75F)
        PatientNameTxtbox.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        PatientNameTxtbox.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        PatientNameTxtbox.Location = New Point(89, 129)
        PatientNameTxtbox.Name = "PatientNameTxtbox"
        PatientNameTxtbox.PlaceholderText = ""
        PatientNameTxtbox.SelectedText = ""
        PatientNameTxtbox.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        PatientNameTxtbox.Size = New Size(229, 30)
        PatientNameTxtbox.TabIndex = 15
        ' 
        ' PatientAgeTxtbox
        ' 
        PatientAgeTxtbox.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        PatientAgeTxtbox.CustomizableEdges = CustomizableEdges15
        PatientAgeTxtbox.DefaultText = ""
        PatientAgeTxtbox.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        PatientAgeTxtbox.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        PatientAgeTxtbox.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        PatientAgeTxtbox.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        PatientAgeTxtbox.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        PatientAgeTxtbox.Font = New Font("Century Gothic", 9.75F)
        PatientAgeTxtbox.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        PatientAgeTxtbox.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        PatientAgeTxtbox.Location = New Point(89, 171)
        PatientAgeTxtbox.Name = "PatientAgeTxtbox"
        PatientAgeTxtbox.PlaceholderText = ""
        PatientAgeTxtbox.SelectedText = ""
        PatientAgeTxtbox.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        PatientAgeTxtbox.Size = New Size(229, 30)
        PatientAgeTxtbox.TabIndex = 16
        ' 
        ' ClinicTxtbox
        ' 
        ClinicTxtbox.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        ClinicTxtbox.CustomizableEdges = CustomizableEdges17
        ClinicTxtbox.DefaultText = ""
        ClinicTxtbox.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        ClinicTxtbox.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        ClinicTxtbox.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        ClinicTxtbox.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        ClinicTxtbox.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        ClinicTxtbox.Font = New Font("Century Gothic", 9.75F)
        ClinicTxtbox.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        ClinicTxtbox.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        ClinicTxtbox.Location = New Point(123, 300)
        ClinicTxtbox.Name = "ClinicTxtbox"
        ClinicTxtbox.PlaceholderText = ""
        ClinicTxtbox.SelectedText = ""
        ClinicTxtbox.ShadowDecoration.CustomizableEdges = CustomizableEdges18
        ClinicTxtbox.Size = New Size(229, 30)
        ClinicTxtbox.TabIndex = 21
        ' 
        ' DocNameTxtbox
        ' 
        DocNameTxtbox.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        DocNameTxtbox.CustomizableEdges = CustomizableEdges19
        DocNameTxtbox.DefaultText = ""
        DocNameTxtbox.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        DocNameTxtbox.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        DocNameTxtbox.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        DocNameTxtbox.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        DocNameTxtbox.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        DocNameTxtbox.Font = New Font("Century Gothic", 9.75F)
        DocNameTxtbox.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        DocNameTxtbox.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        DocNameTxtbox.Location = New Point(123, 256)
        DocNameTxtbox.Name = "DocNameTxtbox"
        DocNameTxtbox.PlaceholderText = ""
        DocNameTxtbox.SelectedText = ""
        DocNameTxtbox.ShadowDecoration.CustomizableEdges = CustomizableEdges20
        DocNameTxtbox.Size = New Size(229, 30)
        DocNameTxtbox.TabIndex = 20
        ' 
        ' ClinicLbl
        ' 
        ClinicLbl.AutoSize = True
        ClinicLbl.Font = New Font("Century Gothic", 9.75F)
        ClinicLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        ClinicLbl.Location = New Point(27, 308)
        ClinicLbl.Name = "ClinicLbl"
        ClinicLbl.Size = New Size(48, 17)
        ClinicLbl.TabIndex = 19
        ClinicLbl.Text = "Clinic:"
        ClinicLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DocNameLbl
        ' 
        DocNameLbl.AutoSize = True
        DocNameLbl.Font = New Font("Century Gothic", 9.75F)
        DocNameLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        DocNameLbl.Location = New Point(27, 264)
        DocNameLbl.Name = "DocNameLbl"
        DocNameLbl.Size = New Size(52, 17)
        DocNameLbl.TabIndex = 18
        DocNameLbl.Text = "Name:"
        DocNameLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DocInfoLbl
        ' 
        DocInfoLbl.AutoSize = True
        DocInfoLbl.Font = New Font("Century Gothic", 12.75F, FontStyle.Bold)
        DocInfoLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        DocInfoLbl.Location = New Point(25, 225)
        DocInfoLbl.Name = "DocInfoLbl"
        DocInfoLbl.Size = New Size(177, 19)
        DocInfoLbl.TabIndex = 17
        DocInfoLbl.Text = "Doctor's Information:"
        DocInfoLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ContactTxtbox
        ' 
        ContactTxtbox.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        ContactTxtbox.CustomizableEdges = CustomizableEdges21
        ContactTxtbox.DefaultText = ""
        ContactTxtbox.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        ContactTxtbox.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        ContactTxtbox.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        ContactTxtbox.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        ContactTxtbox.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        ContactTxtbox.Font = New Font("Century Gothic", 9.75F)
        ContactTxtbox.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        ContactTxtbox.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        ContactTxtbox.Location = New Point(123, 346)
        ContactTxtbox.Name = "ContactTxtbox"
        ContactTxtbox.PlaceholderText = ""
        ContactTxtbox.SelectedText = ""
        ContactTxtbox.ShadowDecoration.CustomizableEdges = CustomizableEdges22
        ContactTxtbox.Size = New Size(229, 30)
        ContactTxtbox.TabIndex = 23
        ' 
        ' DocContactLbl
        ' 
        DocContactLbl.AutoSize = True
        DocContactLbl.Font = New Font("Century Gothic", 9.75F)
        DocContactLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        DocContactLbl.Location = New Point(27, 355)
        DocContactLbl.Name = "DocContactLbl"
        DocContactLbl.Size = New Size(90, 17)
        DocContactLbl.TabIndex = 22
        DocContactLbl.Text = "Contact No:"
        DocContactLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BriefInfoLbl
        ' 
        BriefInfoLbl.AutoSize = True
        BriefInfoLbl.Font = New Font("Century Gothic", 12.75F, FontStyle.Bold)
        BriefInfoLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        BriefInfoLbl.Location = New Point(27, 410)
        BriefInfoLbl.Name = "BriefInfoLbl"
        BriefInfoLbl.Size = New Size(146, 19)
        BriefInfoLbl.TabIndex = 24
        BriefInfoLbl.Text = "Brief Information:"
        BriefInfoLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BriefInfoTextbox
        ' 
        BriefInfoTextbox.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        BriefInfoTextbox.CustomizableEdges = CustomizableEdges23
        BriefInfoTextbox.DefaultText = ""
        BriefInfoTextbox.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        BriefInfoTextbox.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        BriefInfoTextbox.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        BriefInfoTextbox.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        BriefInfoTextbox.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        BriefInfoTextbox.Font = New Font("Century Gothic", 9.75F)
        BriefInfoTextbox.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        BriefInfoTextbox.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        BriefInfoTextbox.Location = New Point(30, 437)
        BriefInfoTextbox.Name = "BriefInfoTextbox"
        BriefInfoTextbox.PlaceholderText = ""
        BriefInfoTextbox.SelectedText = ""
        BriefInfoTextbox.ShadowDecoration.CustomizableEdges = CustomizableEdges24
        BriefInfoTextbox.Size = New Size(429, 105)
        BriefInfoTextbox.TabIndex = 25
        ' 
        ' PrescDigiCopy
        ' 
        PrescDigiCopy.BorderStyle = BorderStyle.FixedSingle
        PrescDigiCopy.Location = New Point(510, 221)
        PrescDigiCopy.Name = "PrescDigiCopy"
        PrescDigiCopy.Size = New Size(217, 155)
        PrescDigiCopy.SizeMode = PictureBoxSizeMode.Zoom
        PrescDigiCopy.TabIndex = 27
        PrescDigiCopy.TabStop = False
        ' 
        ' DrugListBox
        ' 
        DrugListBox.FormattingEnabled = True
        DrugListBox.ItemHeight = 15
        DrugListBox.Items.AddRange(New Object() {"ItemPrescriptionMed"})
        DrugListBox.Location = New Point(510, 437)
        DrugListBox.Name = "DrugListBox"
        DrugListBox.Size = New Size(217, 94)
        DrugListBox.TabIndex = 28
        ' 
        ' DateLbl
        ' 
        DateLbl.AutoSize = True
        DateLbl.Font = New Font("Century Gothic", 9.75F)
        DateLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        DateLbl.Location = New Point(510, 142)
        DateLbl.Name = "DateLbl"
        DateLbl.Size = New Size(44, 17)
        DateLbl.TabIndex = 30
        DateLbl.Text = "Date:"
        DateLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PrescInfoLbl
        ' 
        PrescInfoLbl.AutoSize = True
        PrescInfoLbl.Font = New Font("Century Gothic", 12.75F, FontStyle.Bold)
        PrescInfoLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        PrescInfoLbl.Location = New Point(508, 118)
        PrescInfoLbl.Name = "PrescInfoLbl"
        PrescInfoLbl.Size = New Size(205, 19)
        PrescInfoLbl.TabIndex = 29
        PrescInfoLbl.Text = "Prescription Information:"
        PrescInfoLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DateSubmitted
        ' 
        DateSubmitted.AutoSize = True
        DateSubmitted.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        DateSubmitted.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        DateSubmitted.Location = New Point(551, 142)
        DateSubmitted.Name = "DateSubmitted"
        DateSubmitted.Size = New Size(106, 16)
        DateSubmitted.TabIndex = 31
        DateSubmitted.Text = "Date Submitted"
        DateSubmitted.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PrescDigiCopyLbl
        ' 
        PrescDigiCopyLbl.AutoSize = True
        PrescDigiCopyLbl.Font = New Font("Century Gothic", 9.75F)
        PrescDigiCopyLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        PrescDigiCopyLbl.Location = New Point(510, 201)
        PrescDigiCopyLbl.Name = "PrescDigiCopyLbl"
        PrescDigiCopyLbl.Size = New Size(179, 17)
        PrescDigiCopyLbl.TabIndex = 32
        PrescDigiCopyLbl.Text = "Prescription's Digital Copy:"
        PrescDigiCopyLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DrugListLbl
        ' 
        DrugListLbl.AutoSize = True
        DrugListLbl.Font = New Font("Century Gothic", 12.75F, FontStyle.Bold)
        DrugListLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        DrugListLbl.Location = New Point(510, 410)
        DrugListLbl.Name = "DrugListLbl"
        DrugListLbl.Size = New Size(88, 19)
        DrugListLbl.TabIndex = 33
        DrugListLbl.Text = "Drug Lists:"
        DrugListLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PrescriptionForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(780, 568)
        Controls.Add(DrugListLbl)
        Controls.Add(PrescDigiCopyLbl)
        Controls.Add(DateSubmitted)
        Controls.Add(DateLbl)
        Controls.Add(PrescInfoLbl)
        Controls.Add(DrugListBox)
        Controls.Add(PrescDigiCopy)
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
        Controls.Add(Remark)
        Controls.Add(RemarkLbl)
        Controls.Add(ReviewDate)
        Controls.Add(ReviewDateLbl)
        Controls.Add(Status)
        Controls.Add(StatusLbl)
        Controls.Add(PrescNo)
        FormBorderStyle = FormBorderStyle.None
        Name = "PrescriptionForm"
        Text = "PrescriptionForm"
        CType(PrescDigiCopy, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents StatusLbl As Label
    Friend WithEvents PrescNo As Label
    Friend WithEvents Status As Label
    Friend WithEvents ReviewDateLbl As Label
    Friend WithEvents ReviewDate As Label
    Friend WithEvents RemarkLbl As Label
    Friend WithEvents Remark As Label
    Friend WithEvents PatientInfoLbl As Label
    Friend WithEvents PatientNameLbl As Label
    Friend WithEvents PatientAgeLbl As Label
    Friend WithEvents PatientNameTxtbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PatientAgeTxtbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ClinicTxtbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DocNameTxtbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ClinicLbl As Label
    Friend WithEvents DocNameLbl As Label
    Friend WithEvents DocInfoLbl As Label
    Friend WithEvents ContactTxtbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DocContactLbl As Label
    Friend WithEvents BriefInfoLbl As Label
    Friend WithEvents BriefInfoTextbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PrescDigiCopy As PictureBox
    Friend WithEvents DrugListBox As ListBox
    Friend WithEvents DateLbl As Label
    Friend WithEvents PrescInfoLbl As Label
    Friend WithEvents DateSubmitted As Label
    Friend WithEvents PrescDigiCopyLbl As Label
    Friend WithEvents DrugListLbl As Label
End Class
