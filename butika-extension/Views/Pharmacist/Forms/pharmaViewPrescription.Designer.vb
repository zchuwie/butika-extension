<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pharmaViewPrescription
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pharmaViewPrescription))
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        prescriptNumLbl = New Label()
        Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Label2 = New Label()
        displayToApproved = New ListBox()
        prescriptImage = New PictureBox()
        briefinfoTxt = New TextBox()
        contactTxt = New TextBox()
        clinicTxt = New TextBox()
        doctornameTxt = New TextBox()
        patientageTxt = New TextBox()
        patientnameTxt = New TextBox()
        Guna2Separator5 = New Guna.UI2.WinForms.Guna2Separator()
        Guna2Separator4 = New Guna.UI2.WinForms.Guna2Separator()
        Guna2Separator3 = New Guna.UI2.WinForms.Guna2Separator()
        Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Label20 = New Label()
        Label19 = New Label()
        Label18 = New Label()
        Label17 = New Label()
        Label16 = New Label()
        Label15 = New Label()
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        dateLbl = New Label()
        Label9 = New Label()
        Label8 = New Label()
        remarksLbl = New Label()
        Label6 = New Label()
        reviewdateLbl = New Label()
        Label4 = New Label()
        Label3 = New Label()
        statusLbl = New Label()
        Label1 = New Label()
        closeBtn = New Guna.UI2.WinForms.Guna2Button()
        CType(prescriptImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' prescriptNumLbl
        ' 
        prescriptNumLbl.AutoSize = True
        prescriptNumLbl.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        prescriptNumLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        prescriptNumLbl.Location = New Point(185, 23)
        prescriptNumLbl.Name = "prescriptNumLbl"
        prescriptNumLbl.Size = New Size(21, 23)
        prescriptNumLbl.TabIndex = 84
        prescriptNumLbl.Text = "1"
        ' 
        ' Guna2Button2
        ' 
        Guna2Button2.BorderColor = Color.FromArgb(CByte(44), CByte(102), CByte(94))
        Guna2Button2.BorderRadius = 6
        Guna2Button2.BorderThickness = 1
        Guna2Button2.Cursor = Cursors.Hand
        Guna2Button2.CustomizableEdges = CustomizableEdges1
        Guna2Button2.DisabledState.BorderColor = Color.DarkGray
        Guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button2.FillColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        Guna2Button2.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2Button2.ForeColor = Color.FromArgb(CByte(44), CByte(102), CByte(94))
        Guna2Button2.HoverState.FillColor = Color.Red
        Guna2Button2.Location = New Point(507, 559)
        Guna2Button2.Name = "Guna2Button2"
        Guna2Button2.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button2.Size = New Size(124, 45)
        Guna2Button2.TabIndex = 83
        Guna2Button2.Text = "Decline"
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.BorderColor = Color.FromArgb(CByte(44), CByte(102), CByte(94))
        Guna2Button1.BorderRadius = 6
        Guna2Button1.BorderThickness = 3
        Guna2Button1.Cursor = Cursors.Hand
        Guna2Button1.CustomizableEdges = CustomizableEdges3
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.FromArgb(CByte(44), CByte(102), CByte(94))
        Guna2Button1.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2Button1.ForeColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        Guna2Button1.Location = New Point(658, 559)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Button1.Size = New Size(124, 45)
        Guna2Button1.TabIndex = 82
        Guna2Button1.Text = "Approve"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(85, 295)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 32)
        Label2.TabIndex = 81
        Label2.Text = "Click anywhere to " & vbCrLf & "upload"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' displayToApproved
        ' 
        displayToApproved.BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        displayToApproved.Enabled = False
        displayToApproved.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        displayToApproved.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        displayToApproved.FormattingEnabled = True
        displayToApproved.Location = New Point(36, 445)
        displayToApproved.Name = "displayToApproved"
        displayToApproved.Size = New Size(255, 164)
        displayToApproved.TabIndex = 80
        ' 
        ' prescriptImage
        ' 
        prescriptImage.Location = New Point(36, 247)
        prescriptImage.Name = "prescriptImage"
        prescriptImage.Size = New Size(196, 136)
        prescriptImage.TabIndex = 79
        prescriptImage.TabStop = False
        ' 
        ' briefinfoTxt
        ' 
        briefinfoTxt.BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        briefinfoTxt.BorderStyle = BorderStyle.FixedSingle
        briefinfoTxt.Enabled = False
        briefinfoTxt.Location = New Point(424, 418)
        briefinfoTxt.Multiline = True
        briefinfoTxt.Name = "briefinfoTxt"
        briefinfoTxt.ReadOnly = True
        briefinfoTxt.Size = New Size(294, 95)
        briefinfoTxt.TabIndex = 78
        ' 
        ' contactTxt
        ' 
        contactTxt.BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        contactTxt.BorderStyle = BorderStyle.FixedSingle
        contactTxt.Enabled = False
        contactTxt.Location = New Point(499, 329)
        contactTxt.Name = "contactTxt"
        contactTxt.ReadOnly = True
        contactTxt.Size = New Size(219, 23)
        contactTxt.TabIndex = 77
        ' 
        ' clinicTxt
        ' 
        clinicTxt.BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        clinicTxt.BorderStyle = BorderStyle.FixedSingle
        clinicTxt.Enabled = False
        clinicTxt.Location = New Point(499, 300)
        clinicTxt.Name = "clinicTxt"
        clinicTxt.ReadOnly = True
        clinicTxt.Size = New Size(219, 23)
        clinicTxt.TabIndex = 76
        ' 
        ' doctornameTxt
        ' 
        doctornameTxt.BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        doctornameTxt.BorderStyle = BorderStyle.FixedSingle
        doctornameTxt.Enabled = False
        doctornameTxt.Location = New Point(499, 271)
        doctornameTxt.Name = "doctornameTxt"
        doctornameTxt.ReadOnly = True
        doctornameTxt.Size = New Size(219, 23)
        doctornameTxt.TabIndex = 75
        ' 
        ' patientageTxt
        ' 
        patientageTxt.BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        patientageTxt.BorderStyle = BorderStyle.FixedSingle
        patientageTxt.Enabled = False
        patientageTxt.Location = New Point(496, 193)
        patientageTxt.Name = "patientageTxt"
        patientageTxt.ReadOnly = True
        patientageTxt.Size = New Size(219, 23)
        patientageTxt.TabIndex = 74
        ' 
        ' patientnameTxt
        ' 
        patientnameTxt.BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        patientnameTxt.BorderStyle = BorderStyle.FixedSingle
        patientnameTxt.Enabled = False
        patientnameTxt.Location = New Point(496, 164)
        patientnameTxt.Name = "patientnameTxt"
        patientnameTxt.ReadOnly = True
        patientnameTxt.Size = New Size(219, 23)
        patientnameTxt.TabIndex = 73
        ' 
        ' Guna2Separator5
        ' 
        Guna2Separator5.Location = New Point(26, 231)
        Guna2Separator5.Name = "Guna2Separator5"
        Guna2Separator5.Size = New Size(302, 10)
        Guna2Separator5.TabIndex = 72
        ' 
        ' Guna2Separator4
        ' 
        Guna2Separator4.Location = New Point(26, 429)
        Guna2Separator4.Name = "Guna2Separator4"
        Guna2Separator4.Size = New Size(302, 10)
        Guna2Separator4.TabIndex = 71
        ' 
        ' Guna2Separator3
        ' 
        Guna2Separator3.Location = New Point(416, 402)
        Guna2Separator3.Name = "Guna2Separator3"
        Guna2Separator3.Size = New Size(302, 10)
        Guna2Separator3.TabIndex = 70
        ' 
        ' Guna2Separator2
        ' 
        Guna2Separator2.Location = New Point(413, 255)
        Guna2Separator2.Name = "Guna2Separator2"
        Guna2Separator2.Size = New Size(302, 10)
        Guna2Separator2.TabIndex = 69
        ' 
        ' Guna2Separator1
        ' 
        Guna2Separator1.Location = New Point(413, 148)
        Guna2Separator1.Name = "Guna2Separator1"
        Guna2Separator1.Size = New Size(302, 10)
        Guna2Separator1.TabIndex = 68
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label20.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label20.Location = New Point(413, 380)
        Label20.Name = "Label20"
        Label20.Size = New Size(133, 19)
        Label20.TabIndex = 67
        Label20.Text = "Brief Information"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Century Gothic", 9F)
        Label19.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label19.Location = New Point(424, 332)
        Label19.Name = "Label19"
        Label19.Size = New Size(61, 17)
        Label19.TabIndex = 66
        Label19.Text = "Contact:"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Century Gothic", 9F)
        Label18.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label18.Location = New Point(424, 302)
        Label18.Name = "Label18"
        Label18.Size = New Size(47, 17)
        Label18.TabIndex = 65
        Label18.Text = "Clinic: "
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Century Gothic", 9F)
        Label17.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label17.Location = New Point(424, 273)
        Label17.Name = "Label17"
        Label17.Size = New Size(47, 17)
        Label17.TabIndex = 64
        Label17.Text = "Name:"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label16.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label16.Location = New Point(410, 233)
        Label16.Name = "Label16"
        Label16.Size = New Size(161, 19)
        Label16.TabIndex = 63
        Label16.Text = "Doctor's Information"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Century Gothic", 9F)
        Label15.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label15.Location = New Point(421, 197)
        Label15.Name = "Label15"
        Label15.Size = New Size(36, 17)
        Label15.TabIndex = 62
        Label15.Text = "Age:"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Century Gothic", 9F)
        Label14.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label14.Location = New Point(421, 166)
        Label14.Name = "Label14"
        Label14.Size = New Size(47, 17)
        Label14.TabIndex = 61
        Label14.Text = "Name:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label13.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label13.Location = New Point(410, 126)
        Label13.Name = "Label13"
        Label13.Size = New Size(163, 19)
        Label13.TabIndex = 60
        Label13.Text = "Patient's Information"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label12.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label12.Location = New Point(26, 407)
        Label12.Name = "Label12"
        Label12.Size = New Size(77, 19)
        Label12.TabIndex = 59
        Label12.Text = "Drug Lists"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label11.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label11.Location = New Point(26, 202)
        Label11.Name = "Label11"
        Label11.Size = New Size(206, 19)
        Label11.TabIndex = 58
        Label11.Text = "Prescription's Digital Copy"
        ' 
        ' dateLbl
        ' 
        dateLbl.AutoSize = True
        dateLbl.Font = New Font("Century Gothic", 10F)
        dateLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        dateLbl.Location = New Point(74, 155)
        dateLbl.Name = "dateLbl"
        dateLbl.Size = New Size(120, 19)
        dateLbl.TabIndex = 57
        dateLbl.Text = "Date Submission"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 10F, FontStyle.Bold)
        Label9.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label9.Location = New Point(26, 155)
        Label9.Name = "Label9"
        Label9.Size = New Size(44, 17)
        Label9.TabIndex = 56
        Label9.Text = "Date:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        Label8.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label8.Location = New Point(26, 123)
        Label8.Name = "Label8"
        Label8.Size = New Size(226, 23)
        Label8.TabIndex = 55
        Label8.Text = "Prescription Information"
        ' 
        ' remarksLbl
        ' 
        remarksLbl.AutoSize = True
        remarksLbl.Font = New Font("Century Gothic", 10F)
        remarksLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        remarksLbl.Location = New Point(538, 51)
        remarksLbl.Name = "remarksLbl"
        remarksLbl.Size = New Size(66, 19)
        remarksLbl.TabIndex = 54
        remarksLbl.Text = "Pending"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        Label6.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label6.Location = New Point(538, 28)
        Label6.Name = "Label6"
        Label6.Size = New Size(168, 18)
        Label6.TabIndex = 53
        Label6.Text = "Pharmacist's Remarks:"
        ' 
        ' reviewdateLbl
        ' 
        reviewdateLbl.AutoSize = True
        reviewdateLbl.Font = New Font("Century Gothic", 10F)
        reviewdateLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        reviewdateLbl.Location = New Point(302, 51)
        reviewdateLbl.Name = "reviewdateLbl"
        reviewdateLbl.Size = New Size(66, 19)
        reviewdateLbl.TabIndex = 52
        reviewdateLbl.Text = "Pending"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label4.Location = New Point(302, 29)
        Label4.Name = "Label4"
        Label4.Size = New Size(197, 18)
        Label4.TabIndex = 51
        Label4.Text = "Pharmacist's Review Date:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label3.Location = New Point(26, 56)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 19)
        Label3.TabIndex = 50
        Label3.Text = "Status:"
        ' 
        ' statusLbl
        ' 
        statusLbl.AutoSize = True
        statusLbl.Font = New Font("Century Gothic", 12F)
        statusLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        statusLbl.Location = New Point(88, 55)
        statusLbl.Name = "statusLbl"
        statusLbl.Size = New Size(74, 21)
        statusLbl.TabIndex = 49
        statusLbl.Text = "Pending"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label1.Location = New Point(26, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(153, 23)
        Label1.TabIndex = 48
        Label1.Text = "Prescription No."
        ' 
        ' closeBtn
        ' 
        closeBtn.CustomizableEdges = CustomizableEdges5
        closeBtn.DisabledState.BorderColor = Color.DarkGray
        closeBtn.DisabledState.CustomBorderColor = Color.DarkGray
        closeBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        closeBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        closeBtn.FillColor = Color.Transparent
        closeBtn.Font = New Font("Segoe UI", 9F)
        closeBtn.ForeColor = Color.White
        closeBtn.HoverState.FillColor = Color.Red
        closeBtn.Image = CType(resources.GetObject("closeBtn.Image"), Image)
        closeBtn.Location = New Point(747, 29)
        closeBtn.Name = "closeBtn"
        closeBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        closeBtn.Size = New Size(35, 35)
        closeBtn.TabIndex = 47
        ' 
        ' pharmaViewPrescription
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        ClientSize = New Size(808, 632)
        Controls.Add(prescriptNumLbl)
        Controls.Add(Guna2Button2)
        Controls.Add(Guna2Button1)
        Controls.Add(Label2)
        Controls.Add(displayToApproved)
        Controls.Add(prescriptImage)
        Controls.Add(briefinfoTxt)
        Controls.Add(contactTxt)
        Controls.Add(clinicTxt)
        Controls.Add(doctornameTxt)
        Controls.Add(patientageTxt)
        Controls.Add(patientnameTxt)
        Controls.Add(Guna2Separator5)
        Controls.Add(Guna2Separator4)
        Controls.Add(Guna2Separator3)
        Controls.Add(Guna2Separator2)
        Controls.Add(Guna2Separator1)
        Controls.Add(Label20)
        Controls.Add(Label19)
        Controls.Add(Label18)
        Controls.Add(Label17)
        Controls.Add(Label16)
        Controls.Add(Label15)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(dateLbl)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(remarksLbl)
        Controls.Add(Label6)
        Controls.Add(reviewdateLbl)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(statusLbl)
        Controls.Add(Label1)
        Controls.Add(closeBtn)
        FormBorderStyle = FormBorderStyle.None
        Name = "pharmaViewPrescription"
        Text = "pharmaViewPrescription"
        CType(prescriptImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents prescriptNumLbl As Label
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents displayToApproved As ListBox
    Friend WithEvents prescriptImage As PictureBox
    Friend WithEvents briefinfoTxt As TextBox
    Friend WithEvents contactTxt As TextBox
    Friend WithEvents clinicTxt As TextBox
    Friend WithEvents doctornameTxt As TextBox
    Friend WithEvents patientageTxt As TextBox
    Friend WithEvents patientnameTxt As TextBox
    Friend WithEvents Guna2Separator5 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Separator4 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Separator3 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents dateLbl As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents remarksLbl As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents reviewdateLbl As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents statusLbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents closeBtn As Guna.UI2.WinForms.Guna2Button
End Class
