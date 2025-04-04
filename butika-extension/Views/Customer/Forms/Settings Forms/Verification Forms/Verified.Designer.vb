<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Verified
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
        VerifiedImg = New PictureBox()
        Phase3Txt = New Label()
        ProgBar3 = New Panel()
        VerifySubtext = New Label()
        VerifyAccount = New Label()
        ProgBar = New Panel()
        VerifiedIcon = New PictureBox()
        CType(VerifiedImg, ComponentModel.ISupportInitialize).BeginInit()
        CType(VerifiedIcon, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' VerifiedImg
        ' 
        VerifiedImg.Image = My.Resources.Resources.verifyVerified
        VerifiedImg.InitialImage = Nothing
        VerifiedImg.Location = New Point(317, 252)
        VerifiedImg.Name = "VerifiedImg"
        VerifiedImg.Size = New Size(273, 136)
        VerifiedImg.SizeMode = PictureBoxSizeMode.Zoom
        VerifiedImg.TabIndex = 89
        VerifiedImg.TabStop = False
        ' 
        ' Phase3Txt
        ' 
        Phase3Txt.AutoSize = True
        Phase3Txt.Font = New Font("Century Gothic", 8.75F)
        Phase3Txt.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Phase3Txt.Location = New Point(681, 109)
        Phase3Txt.Name = "Phase3Txt"
        Phase3Txt.Size = New Size(143, 17)
        Phase3Txt.TabIndex = 88
        Phase3Txt.Text = "Verification Successful"
        ' 
        ' ProgBar3
        ' 
        ProgBar3.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        ProgBar3.Location = New Point(600, 99)
        ProgBar3.Name = "ProgBar3"
        ProgBar3.RightToLeft = RightToLeft.No
        ProgBar3.Size = New Size(287, 7)
        ProgBar3.TabIndex = 87
        ' 
        ' VerifySubtext
        ' 
        VerifySubtext.AutoSize = True
        VerifySubtext.Font = New Font("Century Gothic", 9.75F)
        VerifySubtext.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        VerifySubtext.Location = New Point(89, 54)
        VerifySubtext.Name = "VerifySubtext"
        VerifySubtext.Size = New Size(136, 17)
        VerifySubtext.TabIndex = 86
        VerifySubtext.Text = "Verify your account."
        ' 
        ' VerifyAccount
        ' 
        VerifyAccount.AutoSize = True
        VerifyAccount.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        VerifyAccount.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        VerifyAccount.Location = New Point(83, 29)
        VerifyAccount.Name = "VerifyAccount"
        VerifyAccount.Size = New Size(184, 28)
        VerifyAccount.TabIndex = 85
        VerifyAccount.Text = "Verify Account"
        VerifyAccount.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ProgBar
        ' 
        ProgBar.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        ProgBar.Location = New Point(27, 102)
        ProgBar.Name = "ProgBar"
        ProgBar.RightToLeft = RightToLeft.No
        ProgBar.Size = New Size(860, 2)
        ProgBar.TabIndex = 84
        ' 
        ' VerifiedIcon
        ' 
        VerifiedIcon.Image = My.Resources.Resources.VerifiedIcon
        VerifiedIcon.Location = New Point(31, 24)
        VerifiedIcon.Name = "VerifiedIcon"
        VerifiedIcon.Size = New Size(51, 53)
        VerifiedIcon.SizeMode = PictureBoxSizeMode.Zoom
        VerifiedIcon.TabIndex = 90
        VerifiedIcon.TabStop = False
        ' 
        ' Verified
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        ClientSize = New Size(915, 649)
        Controls.Add(VerifiedIcon)
        Controls.Add(VerifiedImg)
        Controls.Add(Phase3Txt)
        Controls.Add(ProgBar3)
        Controls.Add(VerifySubtext)
        Controls.Add(VerifyAccount)
        Controls.Add(ProgBar)
        FormBorderStyle = FormBorderStyle.None
        Name = "Verified"
        Text = "Verified"
        CType(VerifiedImg, ComponentModel.ISupportInitialize).EndInit()
        CType(VerifiedIcon, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents VerifiedImg As PictureBox
    Friend WithEvents Phase3Txt As Label
    Friend WithEvents ProgBar3 As Panel
    Friend WithEvents VerifySubtext As Label
    Friend WithEvents VerifyAccount As Label
    Friend WithEvents ProgBar As Panel
    Friend WithEvents VerifiedIcon As PictureBox
End Class
