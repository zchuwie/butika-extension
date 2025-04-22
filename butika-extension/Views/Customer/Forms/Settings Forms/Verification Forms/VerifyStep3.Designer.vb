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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        ProgBar3 = New Panel()
        VerifySubtext = New Label()
        VerifyProfile = New Label()
        ProgBar = New Panel()
        Phase3Txt = New Label()
        VerifyPendingImg = New PictureBox()
        VerifiedIcon = New PictureBox()
        CancelVerifyBtn = New Guna.UI2.WinForms.Guna2Button()
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
        VerifyPendingImg.Image = My.Resources.Resources.verifyPending1
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
        ' CancelVerifyBtn
        ' 
        CancelVerifyBtn.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        CancelVerifyBtn.BorderRadius = 6
        CancelVerifyBtn.BorderThickness = 1
        CancelVerifyBtn.CustomizableEdges = CustomizableEdges1
        CancelVerifyBtn.DisabledState.BorderColor = Color.DarkGray
        CancelVerifyBtn.DisabledState.CustomBorderColor = Color.DarkGray
        CancelVerifyBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        CancelVerifyBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        CancelVerifyBtn.FillColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        CancelVerifyBtn.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        CancelVerifyBtn.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        CancelVerifyBtn.Location = New Point(786, 578)
        CancelVerifyBtn.Name = "CancelVerifyBtn"
        CancelVerifyBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        CancelVerifyBtn.Size = New Size(81, 35)
        CancelVerifyBtn.TabIndex = 101
        CancelVerifyBtn.Text = "Cancel"
        CancelVerifyBtn.Visible = False
        ' 
        ' VerifyStep3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        ClientSize = New Size(915, 649)
        Controls.Add(CancelVerifyBtn)
        Controls.Add(VerifiedIcon)
        Controls.Add(VerifyPendingImg)
        Controls.Add(Phase3Txt)
        Controls.Add(ProgBar3)
        Controls.Add(VerifySubtext)
        Controls.Add(VerifyProfile)
        Controls.Add(ProgBar)
        FormBorderStyle = FormBorderStyle.None
        Name = "VerifyStep3"
        StartPosition = FormStartPosition.CenterParent
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
    Friend WithEvents CancelVerifyBtn As Guna.UI2.WinForms.Guna2Button
End Class
