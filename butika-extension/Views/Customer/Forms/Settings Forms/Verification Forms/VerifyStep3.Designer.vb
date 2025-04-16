<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerifyStep3
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
        ProgBar3 = New Panel()
        VerifySubtext = New Label()
        VerifyProfile = New Label()
        ProgBar = New Panel()
        Phase3Txt = New Label()
        VerifyPendingImg = New PictureBox()
        VerifiedIcon = New PictureBox()
        CType(VerifyPendingImg, ComponentModel.ISupportInitialize).BeginInit()
        CType(VerifiedIcon, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ProgBar3
        ' 
        ProgBar3.BackColor = Color.White
        ProgBar3.Location = New Point(595, 99)
        ProgBar3.Name = "ProgBar3"
        ProgBar3.RightToLeft = RightToLeft.No
        ProgBar3.Size = New Size(287, 7)
        ProgBar3.TabIndex = 81
        ' 
        ' VerifySubtext
        ' 
        VerifySubtext.AutoSize = True
        VerifySubtext.Font = New Font("Century Gothic", 9.75F)
        VerifySubtext.ForeColor = Color.White
        VerifySubtext.Location = New Point(89, 54)
        VerifySubtext.Name = "VerifySubtext"
        VerifySubtext.Size = New Size(136, 17)
        VerifySubtext.TabIndex = 80
        VerifySubtext.Text = "Verify your account."
        ' 
        ' VerifyProfile
        ' 
        VerifyProfile.AutoSize = True
        VerifyProfile.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        VerifyProfile.ForeColor = Color.White
        VerifyProfile.Location = New Point(83, 29)
        VerifyProfile.Name = "VerifyProfile"
        VerifyProfile.Size = New Size(184, 28)
        VerifyProfile.TabIndex = 79
        VerifyProfile.Text = "Verify Account"
        VerifyProfile.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ProgBar
        ' 
        ProgBar.BackColor = Color.White
        ProgBar.Location = New Point(22, 101)
        ProgBar.Name = "ProgBar"
        ProgBar.RightToLeft = RightToLeft.No
        ProgBar.Size = New Size(860, 2)
        ProgBar.TabIndex = 78
        ' 
        ' Phase3Txt
        ' 
        Phase3Txt.AutoSize = True
        Phase3Txt.Font = New Font("Century Gothic", 8.75F)
        Phase3Txt.ForeColor = Color.White
        Phase3Txt.Location = New Point(673, 109)
        Phase3Txt.Name = "Phase3Txt"
        Phase3Txt.Size = New Size(129, 17)
        Phase3Txt.TabIndex = 82
        Phase3Txt.Text = "Verification Pending"
        ' 
        ' VerifyPendingImg
        ' 
        VerifyPendingImg.Image = My.Resources.Resources.verifyVerified3
        VerifyPendingImg.InitialImage = My.Resources.Resources.verifyImage
        VerifyPendingImg.Location = New Point(225, 187)
        VerifyPendingImg.Name = "VerifyPendingImg"
        VerifyPendingImg.Size = New Size(465, 277)
        VerifyPendingImg.SizeMode = PictureBoxSizeMode.Zoom
        VerifyPendingImg.TabIndex = 83
        VerifyPendingImg.TabStop = False
        ' 
        ' VerifiedIcon
        ' 
        VerifiedIcon.Image = My.Resources.Resources.VerifiedIcon___Copy
        VerifiedIcon.Location = New Point(31, 24)
        VerifiedIcon.Name = "VerifiedIcon"
        VerifiedIcon.Size = New Size(51, 53)
        VerifiedIcon.SizeMode = PictureBoxSizeMode.Zoom
        VerifiedIcon.TabIndex = 91
        VerifiedIcon.TabStop = False
        ' 
        ' VerifyStep3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        ClientSize = New Size(915, 649)
        Controls.Add(VerifiedIcon)
        Controls.Add(VerifyPendingImg)
        Controls.Add(Phase3Txt)
        Controls.Add(ProgBar3)
        Controls.Add(VerifySubtext)
        Controls.Add(VerifyProfile)
        Controls.Add(ProgBar)
        FormBorderStyle = FormBorderStyle.None
        Name = "VerifyStep3"
        Text = "VerifyStep3"
        CType(VerifyPendingImg, ComponentModel.ISupportInitialize).EndInit()
        CType(VerifiedIcon, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ProgBar3 As Panel
    Friend WithEvents VerifySubtext As Label
    Friend WithEvents VerifyProfile As Label
    Friend WithEvents ProgBar As Panel
    Friend WithEvents Phase3Txt As Label
    Friend WithEvents VerifyPendingImg As PictureBox
    Friend WithEvents VerifiedIcon As PictureBox
End Class
