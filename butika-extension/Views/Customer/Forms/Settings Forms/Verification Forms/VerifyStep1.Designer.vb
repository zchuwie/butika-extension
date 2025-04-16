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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        VerifyProfileSubtext = New Label()
        VerifyAccount = New Label()
        VerifyProgBar = New Panel()
        idImage = New PictureBox()
        ProgBar1 = New Panel()
        Phase1Txt = New Label()
        VerifiedIcon = New PictureBox()
        SubmitIdBtn = New RoundedButton()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        IdImgFileName = New Label()
        CancelVerifyBtn = New Guna.UI2.WinForms.Guna2Button()
        CType(idImage, ComponentModel.ISupportInitialize).BeginInit()
        CType(VerifiedIcon, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' VerifyProfileSubtext
        ' 
        VerifyProfileSubtext.AutoSize = True
        VerifyProfileSubtext.Font = New Font("Century Gothic", 9.75F)
        VerifyProfileSubtext.ForeColor = Color.White
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
        VerifyAccount.ForeColor = Color.White
        VerifyAccount.Location = New Point(83, 29)
        VerifyAccount.Name = "VerifyAccount"
        VerifyAccount.Size = New Size(184, 28)
        VerifyAccount.TabIndex = 40
        VerifyAccount.Text = "Verify Account"
        VerifyAccount.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' VerifyProgBar
        ' 
        VerifyProgBar.BackColor = Color.White
        VerifyProgBar.Location = New Point(24, 101)
        VerifyProgBar.Name = "VerifyProgBar"
        VerifyProgBar.RightToLeft = RightToLeft.No
        VerifyProgBar.Size = New Size(860, 2)
        VerifyProgBar.TabIndex = 39
        ' 
        ' idImage
        ' 
        idImage.Cursor = Cursors.Hand
        idImage.Image = My.Resources.Resources.verifyImage1
        idImage.InitialImage = My.Resources.Resources.verifyImage
        idImage.Location = New Point(262, 180)
        idImage.Name = "idImage"
        idImage.Size = New Size(377, 242)
        idImage.SizeMode = PictureBoxSizeMode.Zoom
        idImage.TabIndex = 42
        idImage.TabStop = False
        ' 
        ' ProgBar1
        ' 
        ProgBar1.BackColor = Color.White
        ProgBar1.Location = New Point(23, 99)
        ProgBar1.Name = "ProgBar1"
        ProgBar1.RightToLeft = RightToLeft.No
        ProgBar1.Size = New Size(287, 7)
        ProgBar1.TabIndex = 73
        ' 
        ' Phase1Txt
        ' 
        Phase1Txt.AutoSize = True
        Phase1Txt.Font = New Font("Century Gothic", 8.75F)
        Phase1Txt.ForeColor = Color.White
        Phase1Txt.Location = New Point(111, 109)
        Phase1Txt.Name = "Phase1Txt"
        Phase1Txt.Size = New Size(102, 17)
        Phase1Txt.TabIndex = 83
        Phase1Txt.Text = "Submit ID Photo"
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
        ' SubmitIdBtn
        ' 
        SubmitIdBtn.BackColor = Color.White
        SubmitIdBtn.CornerRadius = 8
        SubmitIdBtn.Font = New Font("Century Gothic", 10.75F, FontStyle.Bold)
        SubmitIdBtn.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        SubmitIdBtn.Location = New Point(372, 473)
        SubmitIdBtn.Name = "SubmitIdBtn"
        SubmitIdBtn.Size = New Size(157, 38)
        SubmitIdBtn.TabIndex = 97
        SubmitIdBtn.Text = "Submit"
        SubmitIdBtn.UseVisualStyleBackColor = False
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Guna2Panel1.BorderRadius = 1
        Guna2Panel1.BorderThickness = 1
        Guna2Panel1.CustomizableEdges = CustomizableEdges1
        Guna2Panel1.Location = New Point(255, 174)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Panel1.Size = New Size(392, 254)
        Guna2Panel1.TabIndex = 98
        ' 
        ' IdImgFileName
        ' 
        IdImgFileName.Font = New Font("Century Gothic", 8.75F)
        IdImgFileName.ForeColor = Color.White
        IdImgFileName.Location = New Point(255, 431)
        IdImgFileName.Name = "IdImgFileName"
        IdImgFileName.Size = New Size(392, 21)
        IdImgFileName.TabIndex = 99
        IdImgFileName.Text = "ID Image File Name"
        IdImgFileName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' CancelVerifyBtn
        ' 
        CancelVerifyBtn.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        CancelVerifyBtn.BorderRadius = 6
        CancelVerifyBtn.BorderThickness = 1
        CancelVerifyBtn.CustomizableEdges = CustomizableEdges3
        CancelVerifyBtn.DisabledState.BorderColor = Color.DarkGray
        CancelVerifyBtn.DisabledState.CustomBorderColor = Color.DarkGray
        CancelVerifyBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        CancelVerifyBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        CancelVerifyBtn.FillColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        CancelVerifyBtn.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        CancelVerifyBtn.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        CancelVerifyBtn.Location = New Point(803, 587)
        CancelVerifyBtn.Name = "CancelVerifyBtn"
        CancelVerifyBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        CancelVerifyBtn.Size = New Size(81, 35)
        CancelVerifyBtn.TabIndex = 100
        CancelVerifyBtn.Text = "Cancel"
        CancelVerifyBtn.Visible = False
        ' 
        ' VerifyStep1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        ClientSize = New Size(915, 649)
        Controls.Add(CancelVerifyBtn)
        Controls.Add(IdImgFileName)
        Controls.Add(SubmitIdBtn)
        Controls.Add(VerifiedIcon)
        Controls.Add(Phase1Txt)
        Controls.Add(ProgBar1)
        Controls.Add(idImage)
        Controls.Add(VerifyProfileSubtext)
        Controls.Add(VerifyAccount)
        Controls.Add(VerifyProgBar)
        Controls.Add(Guna2Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "VerifyStep1"
        StartPosition = FormStartPosition.CenterParent
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
    Friend WithEvents SubmitIdBtn As RoundedButton
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents IdImgFileName As Label
    Friend WithEvents CancelVerifyBtn As Guna.UI2.WinForms.Guna2Button
End Class
