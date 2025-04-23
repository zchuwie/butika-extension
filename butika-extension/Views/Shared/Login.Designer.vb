<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        loginBtn = New Guna.UI2.WinForms.Guna2Button()
        RoundedPanel1 = New RoundedPanel()
        forgetPassTxtBtn = New Label()
        signUpTxtBtn = New Label()
        usernameTxtBox = New Guna.UI2.WinForms.Guna2TextBox()
        passwordTxtBox = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        closeBtn = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(closeBtn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(36, 53)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(126, 109)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(156, 39)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(370, 147)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' loginBtn
        ' 
        loginBtn.BorderRadius = 20
        loginBtn.CustomizableEdges = CustomizableEdges1
        loginBtn.DisabledState.BorderColor = Color.DarkGray
        loginBtn.DisabledState.CustomBorderColor = Color.DarkGray
        loginBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        loginBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        loginBtn.FillColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        loginBtn.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        loginBtn.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        loginBtn.Location = New Point(200, 556)
        loginBtn.Name = "loginBtn"
        loginBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        loginBtn.Size = New Size(180, 45)
        loginBtn.TabIndex = 3
        loginBtn.Text = "Login"
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        RoundedPanel1.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        RoundedPanel1.BottomLeftRadius = 0
        RoundedPanel1.BottomRightRadius = 104
        RoundedPanel1.Controls.Add(forgetPassTxtBtn)
        RoundedPanel1.Controls.Add(signUpTxtBtn)
        RoundedPanel1.Controls.Add(usernameTxtBox)
        RoundedPanel1.Controls.Add(passwordTxtBox)
        RoundedPanel1.Controls.Add(Guna2HtmlLabel5)
        RoundedPanel1.Controls.Add(Guna2HtmlLabel4)
        RoundedPanel1.Controls.Add(Guna2HtmlLabel2)
        RoundedPanel1.Controls.Add(loginBtn)
        RoundedPanel1.Controls.Add(Guna2HtmlLabel1)
        RoundedPanel1.Controls.Add(PictureBox2)
        RoundedPanel1.Controls.Add(PictureBox1)
        RoundedPanel1.Dock = DockStyle.Left
        RoundedPanel1.Location = New Point(0, 0)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(591, 720)
        RoundedPanel1.TabIndex = 0
        RoundedPanel1.TopLeftRadius = 0
        RoundedPanel1.TopRightRadius = 104
        ' 
        ' forgetPassTxtBtn
        ' 
        forgetPassTxtBtn.Cursor = Cursors.Hand
        forgetPassTxtBtn.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        forgetPassTxtBtn.ForeColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        forgetPassTxtBtn.Location = New Point(83, 480)
        forgetPassTxtBtn.Name = "forgetPassTxtBtn"
        forgetPassTxtBtn.Size = New Size(120, 16)
        forgetPassTxtBtn.TabIndex = 2
        forgetPassTxtBtn.Text = "Forget Password?"
        ' 
        ' signUpTxtBtn
        ' 
        signUpTxtBtn.Cursor = Cursors.Hand
        signUpTxtBtn.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        signUpTxtBtn.ForeColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        signUpTxtBtn.Location = New Point(312, 617)
        signUpTxtBtn.Name = "signUpTxtBtn"
        signUpTxtBtn.Size = New Size(94, 16)
        signUpTxtBtn.TabIndex = 4
        signUpTxtBtn.Text = "Sign up here"
        ' 
        ' usernameTxtBox
        ' 
        usernameTxtBox.BorderColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        usernameTxtBox.BorderRadius = 10
        usernameTxtBox.BorderThickness = 0
        usernameTxtBox.CustomizableEdges = CustomizableEdges3
        usernameTxtBox.DefaultText = ""
        usernameTxtBox.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        usernameTxtBox.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        usernameTxtBox.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        usernameTxtBox.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        usernameTxtBox.FillColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        usernameTxtBox.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        usernameTxtBox.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        usernameTxtBox.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        usernameTxtBox.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        usernameTxtBox.Location = New Point(83, 301)
        usernameTxtBox.Margin = New Padding(4)
        usernameTxtBox.Name = "usernameTxtBox"
        usernameTxtBox.Padding = New Padding(14)
        usernameTxtBox.PlaceholderText = ""
        usernameTxtBox.SelectedText = ""
        usernameTxtBox.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        usernameTxtBox.Size = New Size(424, 47)
        usernameTxtBox.TabIndex = 0
        ' 
        ' passwordTxtBox
        ' 
        passwordTxtBox.BorderColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        passwordTxtBox.BorderRadius = 10
        passwordTxtBox.BorderThickness = 0
        passwordTxtBox.CustomizableEdges = CustomizableEdges5
        passwordTxtBox.DefaultText = ""
        passwordTxtBox.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        passwordTxtBox.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        passwordTxtBox.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        passwordTxtBox.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        passwordTxtBox.FillColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        passwordTxtBox.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        passwordTxtBox.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        passwordTxtBox.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        passwordTxtBox.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        passwordTxtBox.Location = New Point(83, 417)
        passwordTxtBox.Margin = New Padding(4)
        passwordTxtBox.Name = "passwordTxtBox"
        passwordTxtBox.Padding = New Padding(14)
        passwordTxtBox.PlaceholderText = ""
        passwordTxtBox.SelectedText = ""
        passwordTxtBox.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        passwordTxtBox.Size = New Size(424, 47)
        passwordTxtBox.TabIndex = 1
        passwordTxtBox.UseSystemPasswordChar = True
        ' 
        ' Guna2HtmlLabel5
        ' 
        Guna2HtmlLabel5.BackColor = Color.Transparent
        Guna2HtmlLabel5.Font = New Font("Century Gothic", 10F)
        Guna2HtmlLabel5.ForeColor = SystemColors.ButtonFace
        Guna2HtmlLabel5.Location = New Point(83, 391)
        Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Guna2HtmlLabel5.Size = New Size(64, 19)
        Guna2HtmlLabel5.TabIndex = 9
        Guna2HtmlLabel5.Text = "Password"
        ' 
        ' Guna2HtmlLabel4
        ' 
        Guna2HtmlLabel4.BackColor = Color.Transparent
        Guna2HtmlLabel4.Font = New Font("Century Gothic", 10F)
        Guna2HtmlLabel4.ForeColor = SystemColors.ButtonFace
        Guna2HtmlLabel4.Location = New Point(83, 275)
        Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Guna2HtmlLabel4.Size = New Size(66, 19)
        Guna2HtmlLabel4.TabIndex = 8
        Guna2HtmlLabel4.Text = "Username"
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Century Gothic", 10F)
        Guna2HtmlLabel2.ForeColor = SystemColors.ButtonFace
        Guna2HtmlLabel2.Location = New Point(164, 617)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(142, 19)
        Guna2HtmlLabel2.TabIndex = 6
        Guna2HtmlLabel2.Text = "Don't have account?"
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Century Gothic", 10F)
        Guna2HtmlLabel1.ForeColor = SystemColors.ControlLight
        Guna2HtmlLabel1.Location = New Point(190, 192)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(216, 19)
        Guna2HtmlLabel1.TabIndex = 2
        Guna2HtmlLabel1.Text = "We are so gald to see you again! "
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(777, 292)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(462, 108)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 10
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(661, 303)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(110, 92)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 10
        PictureBox4.TabStop = False
        ' 
        ' closeBtn
        ' 
        closeBtn.Cursor = Cursors.Hand
        closeBtn.Image = CType(resources.GetObject("closeBtn.Image"), Image)
        closeBtn.Location = New Point(1245, 26)
        closeBtn.Name = "closeBtn"
        closeBtn.Size = New Size(23, 19)
        closeBtn.SizeMode = PictureBoxSizeMode.Zoom
        closeBtn.TabIndex = 11
        closeBtn.TabStop = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        AutoValidate = AutoValidate.EnablePreventFocusChange
        BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        ClientSize = New Size(1280, 720)
        Controls.Add(closeBtn)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(RoundedPanel1)
        FormBorderStyle = FormBorderStyle.None
        MaximumSize = New Size(1280, 720)
        MinimumSize = New Size(1278, 718)
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LoginForm"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(closeBtn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents loginBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents passwordTxtBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents usernameTxtBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents signUpTxtBtn As Label
    Friend WithEvents forgetPassTxtBtn As Label
    Friend WithEvents closeBtn As PictureBox

End Class
