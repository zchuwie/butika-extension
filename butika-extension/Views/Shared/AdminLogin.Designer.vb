<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminLogin))
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Panel1 = New Panel()
        Panel2 = New Panel()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        adminBtn = New Guna.UI2.WinForms.Guna2PictureBox()
        inveBtn = New Guna.UI2.WinForms.Guna2PictureBox()
        pharmaBtn = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(adminBtn, ComponentModel.ISupportInitialize).BeginInit()
        CType(inveBtn, ComponentModel.ISupportInitialize).BeginInit()
        CType(pharmaBtn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1281, 40)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Panel2.Location = New Point(0, 680)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1281, 40)
        Panel2.TabIndex = 1
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(364, 108)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(110, 92)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 11
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(480, 97)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(462, 108)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 12
        PictureBox3.TabStop = False
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel1.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Guna2HtmlLabel1.Location = New Point(325, 233)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(662, 38)
        Guna2HtmlLabel1.TabIndex = 13
        Guna2HtmlLabel1.Text = "Welcome! Please choose your designated role"
        ' 
        ' adminBtn
        ' 
        adminBtn.Cursor = Cursors.Hand
        adminBtn.CustomizableEdges = CustomizableEdges1
        adminBtn.Image = CType(resources.GetObject("adminBtn.Image"), Image)
        adminBtn.ImageRotate = 0F
        adminBtn.Location = New Point(192, 331)
        adminBtn.Margin = New Padding(0)
        adminBtn.Name = "adminBtn"
        adminBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        adminBtn.Size = New Size(281, 232)
        adminBtn.SizeMode = PictureBoxSizeMode.Zoom
        adminBtn.TabIndex = 14
        adminBtn.TabStop = False
        ' 
        ' inveBtn
        ' 
        inveBtn.Cursor = Cursors.Hand
        inveBtn.CustomizableEdges = CustomizableEdges3
        inveBtn.Image = CType(resources.GetObject("inveBtn.Image"), Image)
        inveBtn.ImageRotate = 0F
        inveBtn.Location = New Point(496, 331)
        inveBtn.Margin = New Padding(0)
        inveBtn.Name = "inveBtn"
        inveBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        inveBtn.Size = New Size(281, 232)
        inveBtn.SizeMode = PictureBoxSizeMode.Zoom
        inveBtn.TabIndex = 15
        inveBtn.TabStop = False
        ' 
        ' pharmaBtn
        ' 
        pharmaBtn.Cursor = Cursors.Hand
        pharmaBtn.CustomizableEdges = CustomizableEdges5
        pharmaBtn.Image = CType(resources.GetObject("pharmaBtn.Image"), Image)
        pharmaBtn.ImageRotate = 0F
        pharmaBtn.Location = New Point(811, 331)
        pharmaBtn.Margin = New Padding(0)
        pharmaBtn.Name = "pharmaBtn"
        pharmaBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        pharmaBtn.Size = New Size(281, 232)
        pharmaBtn.SizeMode = PictureBoxSizeMode.Zoom
        pharmaBtn.TabIndex = 16
        pharmaBtn.TabStop = False
        ' 
        ' AdminLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        ClientSize = New Size(1280, 720)
        Controls.Add(pharmaBtn)
        Controls.Add(inveBtn)
        Controls.Add(adminBtn)
        Controls.Add(Guna2HtmlLabel1)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        MaximumSize = New Size(1280, 720)
        MinimumSize = New Size(1280, 720)
        Name = "AdminLogin"
        Text = "AdminLogin"
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(adminBtn, ComponentModel.ISupportInitialize).EndInit()
        CType(inveBtn, ComponentModel.ISupportInitialize).EndInit()
        CType(pharmaBtn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents adminBtn As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents inveBtn As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents pharmaBtn As Guna.UI2.WinForms.Guna2PictureBox
End Class
