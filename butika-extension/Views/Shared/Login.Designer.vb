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
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges17 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges18 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges19 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges20 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        loginBtn = New Guna.UI2.WinForms.Guna2Button()
        RoundedPanel2 = New RoundedPanel()
        Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        usernameTxtBox = New Guna.UI2.WinForms.Guna2TextBox()
        RoundedPanel1 = New RoundedPanel()
        RoundedPanel3 = New RoundedPanel()
        passworrdTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2TextBox3 = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        signUpTxtBtn = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        forgetPassTxtBtn = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel2.SuspendLayout()
        RoundedPanel1.SuspendLayout()
        RoundedPanel3.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
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
        loginBtn.CustomizableEdges = CustomizableEdges11
        loginBtn.DisabledState.BorderColor = Color.DarkGray
        loginBtn.DisabledState.CustomBorderColor = Color.DarkGray
        loginBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        loginBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        loginBtn.FillColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        loginBtn.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        loginBtn.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        loginBtn.Location = New Point(211, 533)
        loginBtn.Name = "loginBtn"
        loginBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        loginBtn.Size = New Size(180, 45)
        loginBtn.TabIndex = 3
        loginBtn.Text = "Login"
        ' 
        ' RoundedPanel2
        ' 
        RoundedPanel2.BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        RoundedPanel2.BottomLeftRadius = 10
        RoundedPanel2.BottomRightRadius = 10
        RoundedPanel2.Controls.Add(Guna2TextBox1)
        RoundedPanel2.Controls.Add(usernameTxtBox)
        RoundedPanel2.Location = New Point(107, 299)
        RoundedPanel2.Name = "RoundedPanel2"
        RoundedPanel2.Padding = New Padding(5)
        RoundedPanel2.Size = New Size(396, 49)
        RoundedPanel2.TabIndex = 4
        RoundedPanel2.TopLeftRadius = 10
        RoundedPanel2.TopRightRadius = 10
        ' 
        ' Guna2TextBox1
        ' 
        Guna2TextBox1.BorderThickness = 0
        Guna2TextBox1.CustomizableEdges = CustomizableEdges13
        Guna2TextBox1.DefaultText = ""
        Guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox1.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.Dock = DockStyle.Fill
        Guna2TextBox1.FillColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        Guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2TextBox1.ForeColor = Color.Black
        Guna2TextBox1.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.Location = New Point(5, 5)
        Guna2TextBox1.Margin = New Padding(14)
        Guna2TextBox1.Name = "Guna2TextBox1"
        Guna2TextBox1.Padding = New Padding(14)
        Guna2TextBox1.PlaceholderText = ""
        Guna2TextBox1.SelectedText = ""
        Guna2TextBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        Guna2TextBox1.Size = New Size(386, 39)
        Guna2TextBox1.TabIndex = 1
        ' 
        ' usernameTxtBox
        ' 
        usernameTxtBox.BorderThickness = 0
        usernameTxtBox.CustomizableEdges = CustomizableEdges15
        usernameTxtBox.DefaultText = ""
        usernameTxtBox.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        usernameTxtBox.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        usernameTxtBox.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        usernameTxtBox.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        usernameTxtBox.Dock = DockStyle.Fill
        usernameTxtBox.FillColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        usernameTxtBox.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        usernameTxtBox.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        usernameTxtBox.ForeColor = Color.White
        usernameTxtBox.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        usernameTxtBox.Location = New Point(5, 5)
        usernameTxtBox.Margin = New Padding(14)
        usernameTxtBox.Name = "usernameTxtBox"
        usernameTxtBox.Padding = New Padding(14)
        usernameTxtBox.PlaceholderText = ""
        usernameTxtBox.SelectedText = ""
        usernameTxtBox.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        usernameTxtBox.Size = New Size(386, 39)
        usernameTxtBox.TabIndex = 0
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        RoundedPanel1.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        RoundedPanel1.BottomLeftRadius = 0
        RoundedPanel1.BottomRightRadius = 50
        RoundedPanel1.Controls.Add(forgetPassTxtBtn)
        RoundedPanel1.Controls.Add(RoundedPanel3)
        RoundedPanel1.Controls.Add(Guna2HtmlLabel5)
        RoundedPanel1.Controls.Add(Guna2HtmlLabel4)
        RoundedPanel1.Controls.Add(signUpTxtBtn)
        RoundedPanel1.Controls.Add(Guna2HtmlLabel2)
        RoundedPanel1.Controls.Add(RoundedPanel2)
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
        RoundedPanel1.TopRightRadius = 50
        ' 
        ' RoundedPanel3
        ' 
        RoundedPanel3.BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        RoundedPanel3.BottomLeftRadius = 10
        RoundedPanel3.BottomRightRadius = 10
        RoundedPanel3.Controls.Add(passworrdTextBox)
        RoundedPanel3.Controls.Add(Guna2TextBox3)
        RoundedPanel3.Location = New Point(107, 415)
        RoundedPanel3.Name = "RoundedPanel3"
        RoundedPanel3.Padding = New Padding(5)
        RoundedPanel3.Size = New Size(396, 49)
        RoundedPanel3.TabIndex = 10
        RoundedPanel3.TopLeftRadius = 10
        RoundedPanel3.TopRightRadius = 10
        ' 
        ' passworrdTextBox
        ' 
        passworrdTextBox.BorderThickness = 0
        passworrdTextBox.CustomizableEdges = CustomizableEdges17
        passworrdTextBox.DefaultText = ""
        passworrdTextBox.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        passworrdTextBox.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        passworrdTextBox.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        passworrdTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        passworrdTextBox.Dock = DockStyle.Fill
        passworrdTextBox.FillColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        passworrdTextBox.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        passworrdTextBox.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        passworrdTextBox.ForeColor = Color.Black
        passworrdTextBox.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        passworrdTextBox.Location = New Point(5, 5)
        passworrdTextBox.Margin = New Padding(14)
        passworrdTextBox.Name = "passworrdTextBox"
        passworrdTextBox.Padding = New Padding(14)
        passworrdTextBox.PlaceholderText = ""
        passworrdTextBox.SelectedText = ""
        passworrdTextBox.ShadowDecoration.CustomizableEdges = CustomizableEdges18
        passworrdTextBox.Size = New Size(386, 39)
        passworrdTextBox.TabIndex = 1
        passworrdTextBox.UseSystemPasswordChar = True
        ' 
        ' Guna2TextBox3
        ' 
        Guna2TextBox3.BorderThickness = 0
        Guna2TextBox3.CustomizableEdges = CustomizableEdges19
        Guna2TextBox3.DefaultText = ""
        Guna2TextBox3.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox3.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox3.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox3.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox3.Dock = DockStyle.Fill
        Guna2TextBox3.FillColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        Guna2TextBox3.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox3.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2TextBox3.ForeColor = Color.White
        Guna2TextBox3.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox3.Location = New Point(5, 5)
        Guna2TextBox3.Margin = New Padding(14)
        Guna2TextBox3.Name = "Guna2TextBox3"
        Guna2TextBox3.Padding = New Padding(14)
        Guna2TextBox3.PlaceholderText = ""
        Guna2TextBox3.SelectedText = ""
        Guna2TextBox3.ShadowDecoration.CustomizableEdges = CustomizableEdges20
        Guna2TextBox3.Size = New Size(386, 39)
        Guna2TextBox3.TabIndex = 0
        ' 
        ' Guna2HtmlLabel5
        ' 
        Guna2HtmlLabel5.BackColor = Color.Transparent
        Guna2HtmlLabel5.Font = New Font("Century Gothic", 10F)
        Guna2HtmlLabel5.ForeColor = SystemColors.ButtonFace
        Guna2HtmlLabel5.Location = New Point(107, 390)
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
        Guna2HtmlLabel4.Location = New Point(107, 274)
        Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Guna2HtmlLabel4.Size = New Size(66, 19)
        Guna2HtmlLabel4.TabIndex = 8
        Guna2HtmlLabel4.Text = "Username"
        ' 
        ' signUpTxtBtn
        ' 
        signUpTxtBtn.BackColor = Color.Transparent
        signUpTxtBtn.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        signUpTxtBtn.ForeColor = SystemColors.ButtonFace
        signUpTxtBtn.Location = New Point(330, 584)
        signUpTxtBtn.Name = "signUpTxtBtn"
        signUpTxtBtn.Size = New Size(85, 18)
        signUpTxtBtn.TabIndex = 7
        signUpTxtBtn.Text = "Sign up here"
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Century Gothic", 10F)
        Guna2HtmlLabel2.ForeColor = SystemColors.ButtonFace
        Guna2HtmlLabel2.Location = New Point(182, 584)
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
        PictureBox3.Location = New Point(777, 251)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(462, 108)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 10
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(661, 262)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(110, 92)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 10
        PictureBox4.TabStop = False
        ' 
        ' forgetPassTxtBtn
        ' 
        forgetPassTxtBtn.BackColor = Color.Transparent
        forgetPassTxtBtn.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        forgetPassTxtBtn.ForeColor = SystemColors.ButtonFace
        forgetPassTxtBtn.Location = New Point(112, 476)
        forgetPassTxtBtn.Name = "forgetPassTxtBtn"
        forgetPassTxtBtn.Size = New Size(114, 18)
        forgetPassTxtBtn.TabIndex = 11
        forgetPassTxtBtn.Text = "Forget Password?"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        AutoValidate = AutoValidate.EnablePreventFocusChange
        BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        ClientSize = New Size(1280, 720)
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
        RoundedPanel2.ResumeLayout(False)
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        RoundedPanel3.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents loginBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents RoundedPanel2 As RoundedPanel
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents signUpTxtBtn As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents usernameTxtBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents RoundedPanel3 As RoundedPanel
    Friend WithEvents passworrdTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents forgetPassTxtBtn As Guna.UI2.WinForms.Guna2HtmlLabel

End Class
