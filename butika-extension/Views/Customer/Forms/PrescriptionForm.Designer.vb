<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrescriptionForm
    Inherits UserControl

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
        ClinicLbl = New Label()
        DocNameLbl = New Label()
        DocInfoLbl = New Label()
        DocContactLbl = New Label()
        BriefInfoLbl = New Label()
        PrescDigiCopy = New PictureBox()
        DateLbl = New Label()
        PrescInfoLbl = New Label()
        DateSubmitted = New Label()
        PrescDigiCopyLbl = New Label()
        DrugListLbl = New Label()
        PatientName = New Label()
        Age = New Label()
        DoctorName = New Label()
        Clinic = New Label()
        Contact = New Label()
        briefInfo = New Label()
        itemsToApproved = New FlowLayoutPanel()
        Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Guna2Separator3 = New Guna.UI2.WinForms.Guna2Separator()
        Guna2Separator4 = New Guna.UI2.WinForms.Guna2Separator()
        Guna2Separator5 = New Guna.UI2.WinForms.Guna2Separator()
        CType(PrescDigiCopy, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' StatusLbl
        ' 
        StatusLbl.AutoSize = True
        StatusLbl.Font = New Font("Century Gothic", 12F)
        StatusLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        StatusLbl.Location = New Point(23, 58)
        StatusLbl.Name = "StatusLbl"
        StatusLbl.Size = New Size(63, 21)
        StatusLbl.TabIndex = 6
        StatusLbl.Text = "Status:"
        StatusLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PrescNo
        ' 
        PrescNo.AutoSize = True
        PrescNo.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        PrescNo.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        PrescNo.Location = New Point(21, 26)
        PrescNo.Name = "PrescNo"
        PrescNo.Size = New Size(153, 23)
        PrescNo.TabIndex = 5
        PrescNo.Text = "Prescription No."
        PrescNo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Status
        ' 
        Status.AutoSize = True
        Status.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Status.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Status.Location = New Point(92, 60)
        Status.Name = "Status"
        Status.Size = New Size(74, 19)
        Status.TabIndex = 7
        Status.Text = "Pending"
        Status.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ReviewDateLbl
        ' 
        ReviewDateLbl.AutoSize = True
        ReviewDateLbl.Font = New Font("Century Gothic", 9.75F)
        ReviewDateLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        ReviewDateLbl.Location = New Point(290, 29)
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
        ReviewDate.Location = New Point(290, 49)
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
        RemarkLbl.Location = New Point(552, 29)
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
        Remark.Location = New Point(552, 49)
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
        PatientInfoLbl.Location = New Point(57, 134)
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
        PatientNameLbl.Location = New Point(74, 189)
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
        PatientAgeLbl.Location = New Point(74, 231)
        PatientAgeLbl.Name = "PatientAgeLbl"
        PatientAgeLbl.Size = New Size(38, 17)
        PatientAgeLbl.TabIndex = 14
        PatientAgeLbl.Text = "Age:"
        PatientAgeLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ClinicLbl
        ' 
        ClinicLbl.AutoSize = True
        ClinicLbl.Font = New Font("Century Gothic", 9.75F)
        ClinicLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        ClinicLbl.Location = New Point(76, 399)
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
        DocNameLbl.Location = New Point(76, 355)
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
        DocInfoLbl.Location = New Point(57, 293)
        DocInfoLbl.Name = "DocInfoLbl"
        DocInfoLbl.Size = New Size(177, 19)
        DocInfoLbl.TabIndex = 17
        DocInfoLbl.Text = "Doctor's Information:"
        DocInfoLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DocContactLbl
        ' 
        DocContactLbl.AutoSize = True
        DocContactLbl.Font = New Font("Century Gothic", 9.75F)
        DocContactLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        DocContactLbl.Location = New Point(76, 446)
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
        BriefInfoLbl.Location = New Point(51, 504)
        BriefInfoLbl.Name = "BriefInfoLbl"
        BriefInfoLbl.Size = New Size(146, 19)
        BriefInfoLbl.TabIndex = 24
        BriefInfoLbl.Text = "Brief Information:"
        BriefInfoLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PrescDigiCopy
        ' 
        PrescDigiCopy.BorderStyle = BorderStyle.FixedSingle
        PrescDigiCopy.Location = New Point(498, 268)
        PrescDigiCopy.Name = "PrescDigiCopy"
        PrescDigiCopy.Size = New Size(245, 180)
        PrescDigiCopy.SizeMode = PictureBoxSizeMode.Zoom
        PrescDigiCopy.TabIndex = 27
        PrescDigiCopy.TabStop = False
        ' 
        ' DateLbl
        ' 
        DateLbl.AutoSize = True
        DateLbl.Font = New Font("Century Gothic", 9.75F)
        DateLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        DateLbl.Location = New Point(498, 156)
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
        PrescInfoLbl.Location = New Point(477, 125)
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
        DateSubmitted.Location = New Point(539, 156)
        DateSubmitted.Name = "DateSubmitted"
        DateSubmitted.Size = New Size(106, 16)
        DateSubmitted.TabIndex = 31
        DateSubmitted.Text = "Date Submitted"
        DateSubmitted.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PrescDigiCopyLbl
        ' 
        PrescDigiCopyLbl.AutoSize = True
        PrescDigiCopyLbl.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        PrescDigiCopyLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        PrescDigiCopyLbl.Location = New Point(479, 208)
        PrescDigiCopyLbl.Name = "PrescDigiCopyLbl"
        PrescDigiCopyLbl.Size = New Size(210, 19)
        PrescDigiCopyLbl.TabIndex = 32
        PrescDigiCopyLbl.Text = "Prescription's Digital Copy:"
        PrescDigiCopyLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DrugListLbl
        ' 
        DrugListLbl.AutoSize = True
        DrugListLbl.Font = New Font("Century Gothic", 12.75F, FontStyle.Bold)
        DrugListLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        DrugListLbl.Location = New Point(477, 466)
        DrugListLbl.Name = "DrugListLbl"
        DrugListLbl.Size = New Size(88, 19)
        DrugListLbl.TabIndex = 33
        DrugListLbl.Text = "Drug Lists:"
        DrugListLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PatientName
        ' 
        PatientName.AutoSize = True
        PatientName.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PatientName.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        PatientName.Location = New Point(157, 189)
        PatientName.Name = "PatientName"
        PatientName.Size = New Size(90, 16)
        PatientName.TabIndex = 34
        PatientName.Text = "PatientName"
        PatientName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Age
        ' 
        Age.AutoSize = True
        Age.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Age.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Age.Location = New Point(155, 232)
        Age.Name = "Age"
        Age.Size = New Size(34, 16)
        Age.TabIndex = 35
        Age.Text = "Age"
        Age.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DoctorName
        ' 
        DoctorName.AutoSize = True
        DoctorName.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DoctorName.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        DoctorName.Location = New Point(187, 356)
        DoctorName.Name = "DoctorName"
        DoctorName.Size = New Size(88, 16)
        DoctorName.TabIndex = 36
        DoctorName.Text = "DoctorName"
        DoctorName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Clinic
        ' 
        Clinic.AutoSize = True
        Clinic.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Clinic.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Clinic.Location = New Point(187, 399)
        Clinic.Name = "Clinic"
        Clinic.Size = New Size(45, 16)
        Clinic.TabIndex = 37
        Clinic.Text = "Clinic"
        Clinic.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Contact
        ' 
        Contact.AutoSize = True
        Contact.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Contact.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Contact.Location = New Point(187, 447)
        Contact.Name = "Contact"
        Contact.Size = New Size(58, 16)
        Contact.TabIndex = 38
        Contact.Text = "Contact"
        Contact.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' briefInfo
        ' 
        briefInfo.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        briefInfo.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        briefInfo.Location = New Point(74, 556)
        briefInfo.Name = "briefInfo"
        briefInfo.Size = New Size(306, 117)
        briefInfo.TabIndex = 39
        briefInfo.Text = "briefInfo"
        ' 
        ' itemsToApproved
        ' 
        itemsToApproved.AutoScroll = True
        itemsToApproved.Location = New Point(498, 520)
        itemsToApproved.Name = "itemsToApproved"
        itemsToApproved.Size = New Size(285, 153)
        itemsToApproved.TabIndex = 40
        ' 
        ' Guna2Separator1
        ' 
        Guna2Separator1.Location = New Point(60, 163)
        Guna2Separator1.Name = "Guna2Separator1"
        Guna2Separator1.Size = New Size(251, 10)
        Guna2Separator1.TabIndex = 41
        ' 
        ' Guna2Separator2
        ' 
        Guna2Separator2.Location = New Point(60, 325)
        Guna2Separator2.Name = "Guna2Separator2"
        Guna2Separator2.Size = New Size(251, 10)
        Guna2Separator2.TabIndex = 42
        ' 
        ' Guna2Separator3
        ' 
        Guna2Separator3.Location = New Point(51, 532)
        Guna2Separator3.Name = "Guna2Separator3"
        Guna2Separator3.Size = New Size(251, 10)
        Guna2Separator3.TabIndex = 43
        ' 
        ' Guna2Separator4
        ' 
        Guna2Separator4.Location = New Point(479, 241)
        Guna2Separator4.Name = "Guna2Separator4"
        Guna2Separator4.Size = New Size(251, 10)
        Guna2Separator4.TabIndex = 44
        ' 
        ' Guna2Separator5
        ' 
        Guna2Separator5.Location = New Point(479, 499)
        Guna2Separator5.Name = "Guna2Separator5"
        Guna2Separator5.Size = New Size(251, 10)
        Guna2Separator5.TabIndex = 45
        ' 
        ' PrescriptionForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        Controls.Add(Guna2Separator5)
        Controls.Add(Guna2Separator4)
        Controls.Add(Guna2Separator3)
        Controls.Add(Guna2Separator2)
        Controls.Add(Guna2Separator1)
        Controls.Add(itemsToApproved)
        Controls.Add(briefInfo)
        Controls.Add(Contact)
        Controls.Add(Clinic)
        Controls.Add(DoctorName)
        Controls.Add(Age)
        Controls.Add(PatientName)
        Controls.Add(DrugListLbl)
        Controls.Add(PrescDigiCopyLbl)
        Controls.Add(DateSubmitted)
        Controls.Add(DateLbl)
        Controls.Add(PrescInfoLbl)
        Controls.Add(PrescDigiCopy)
        Controls.Add(BriefInfoLbl)
        Controls.Add(DocContactLbl)
        Controls.Add(ClinicLbl)
        Controls.Add(DocNameLbl)
        Controls.Add(DocInfoLbl)
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
        Name = "PrescriptionForm"
        Size = New Size(820, 686)
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
    Friend WithEvents ClinicLbl As Label
    Friend WithEvents DocNameLbl As Label
    Friend WithEvents DocInfoLbl As Label
    Friend WithEvents DocContactLbl As Label
    Friend WithEvents BriefInfoLbl As Label
    Friend WithEvents PrescDigiCopy As PictureBox
    Friend WithEvents DateLbl As Label
    Friend WithEvents PrescInfoLbl As Label
    Friend WithEvents DateSubmitted As Label
    Friend WithEvents PrescDigiCopyLbl As Label
    Friend WithEvents DrugListLbl As Label
    Friend WithEvents PatientName As Label
    Friend WithEvents Age As Label
    Friend WithEvents DoctorName As Label
    Friend WithEvents Clinic As Label
    Friend WithEvents Contact As Label
    Friend WithEvents briefInfo As Label
    Friend WithEvents itemsToApproved As FlowLayoutPanel
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Separator3 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Separator4 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Separator5 As Guna.UI2.WinForms.Guna2Separator
End Class
