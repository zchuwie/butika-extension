<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerifyStep1
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
        VerifyProfileSubtext = New Label()
        VerifyAccount = New Label()
        VerifyProgBar = New Panel()
        idImage = New PictureBox()
        ProgBar1 = New Panel()
        Phase1Txt = New Label()
        VerifiedIcon = New PictureBox()
        CType(idImage, ComponentModel.ISupportInitialize).BeginInit()
        CType(VerifiedIcon, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' VerifyProfileSubtext
        ' 
        VerifyProfileSubtext.AutoSize = True
        VerifyProfileSubtext.Font = New Font("Century Gothic", 9.75F)
        VerifyProfileSubtext.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        VerifyProfileSubtext.Location = New Point(89, 54)
        VerifyProfileSubtext.Name = "VerifyProfileSubtext"
        VerifyProfileSubtext.Size = New Size(136, 17)
        VerifyProfileSubtext.TabIndex = 41
        VerifyProfileSubtext.Text = "Verify your account."
        ' 
        ' VerifyAccount
        ' 
        VerifyAccount.AutoSize = True
        VerifyAccount.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        VerifyAccount.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        VerifyAccount.Location = New Point(83, 29)
        VerifyAccount.Name = "VerifyAccount"
        VerifyAccount.Size = New Size(184, 28)
        VerifyAccount.TabIndex = 40
        VerifyAccount.Text = "Verify Account"
        VerifyAccount.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' VerifyProgBar
        ' 
        VerifyProgBar.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        VerifyProgBar.Location = New Point(24, 101)
        VerifyProgBar.Name = "VerifyProgBar"
        VerifyProgBar.RightToLeft = RightToLeft.No
        VerifyProgBar.Size = New Size(700, 2)
        VerifyProgBar.TabIndex = 39
        ' 
        ' idImage
        ' 
        idImage.Image = My.Resources.Resources.verifyImage
        idImage.InitialImage = My.Resources.Resources.verifyImage
        idImage.Location = New Point(193, 138)
        idImage.Name = "idImage"
        idImage.Size = New Size(377, 253)
        idImage.SizeMode = PictureBoxSizeMode.StretchImage
        idImage.TabIndex = 42
        idImage.TabStop = False
        ' 
        ' ProgBar1
        ' 
        ProgBar1.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        ProgBar1.Location = New Point(23, 99)
        ProgBar1.Name = "ProgBar1"
        ProgBar1.RightToLeft = RightToLeft.No
        ProgBar1.Size = New Size(233, 7)
        ProgBar1.TabIndex = 73
        ' 
        ' Phase1Txt
        ' 
        Phase1Txt.AutoSize = True
        Phase1Txt.Font = New Font("Century Gothic", 8.75F)
        Phase1Txt.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Phase1Txt.Location = New Point(79, 108)
        Phase1Txt.Name = "Phase1Txt"
        Phase1Txt.Size = New Size(102, 17)
        Phase1Txt.TabIndex = 83
        Phase1Txt.Text = "Submit ID Photo"
        ' 
        ' VerifiedIcon
        ' 
        VerifiedIcon.Image = My.Resources.Resources.VerifiedIcon
        VerifiedIcon.Location = New Point(31, 24)
        VerifiedIcon.Name = "VerifiedIcon"
        VerifiedIcon.Size = New Size(51, 53)
        VerifiedIcon.SizeMode = PictureBoxSizeMode.Zoom
        VerifiedIcon.TabIndex = 91
        VerifiedIcon.TabStop = False
        ' 
        ' VerifyStep1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        ClientSize = New Size(753, 520)
        Controls.Add(VerifiedIcon)
        Controls.Add(Phase1Txt)
        Controls.Add(ProgBar1)
        Controls.Add(idImage)
        Controls.Add(VerifyProfileSubtext)
        Controls.Add(VerifyAccount)
        Controls.Add(VerifyProgBar)
        FormBorderStyle = FormBorderStyle.None
        Name = "VerifyStep1"
        Text = "VerifyStep1"
        CType(idImage, ComponentModel.ISupportInitialize).EndInit()
        CType(VerifiedIcon, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents VerifyProfileSubtext As Label
    Friend WithEvents VerifyAccount As Label
    Friend WithEvents VerifyProgBar As Panel
    Friend WithEvents idImage As PictureBox
    Friend WithEvents SubmitIdImgBtn As RoundedButton
    Friend WithEvents ProgBar1 As Panel
    Friend WithEvents Phase1Txt As Label
    Friend WithEvents VerifiedIcon As PictureBox
End Class
