<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pharmaMainPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pharmaMainPage))
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        mainPanel = New Panel()
        sidebarPanel = New Panel()
        PictureBox1 = New PictureBox()
        logoutBtn = New Guna.UI2.WinForms.Guna2Button()
        prescriptionBtn = New Guna.UI2.WinForms.Guna2Button()
        medicineBtn = New Guna.UI2.WinForms.Guna2Button()
        transactionBtn = New Guna.UI2.WinForms.Guna2Button()
        dashboardBtn = New Guna.UI2.WinForms.Guna2Button()
        separator2 = New Panel()
        separator3 = New Panel()
        sidebarPanel.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' mainPanel
        ' 
        mainPanel.BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        mainPanel.Dock = DockStyle.Fill
        mainPanel.ForeColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        mainPanel.Location = New Point(237, 0)
        mainPanel.Name = "mainPanel"
        mainPanel.Size = New Size(1043, 720)
        mainPanel.TabIndex = 3
        ' 
        ' sidebarPanel
        ' 
        sidebarPanel.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        sidebarPanel.Controls.Add(PictureBox1)
        sidebarPanel.Controls.Add(logoutBtn)
        sidebarPanel.Controls.Add(prescriptionBtn)
        sidebarPanel.Controls.Add(medicineBtn)
        sidebarPanel.Controls.Add(transactionBtn)
        sidebarPanel.Controls.Add(dashboardBtn)
        sidebarPanel.Controls.Add(separator2)
        sidebarPanel.Controls.Add(separator3)
        sidebarPanel.Dock = DockStyle.Left
        sidebarPanel.Location = New Point(0, 0)
        sidebarPanel.Name = "sidebarPanel"
        sidebarPanel.Size = New Size(237, 720)
        sidebarPanel.TabIndex = 2
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.logolandscapegreen
        PictureBox1.Location = New Point(10, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(219, 54)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' logoutBtn
        ' 
        logoutBtn.CustomizableEdges = CustomizableEdges1
        logoutBtn.DisabledState.BorderColor = Color.DarkGray
        logoutBtn.DisabledState.CustomBorderColor = Color.DarkGray
        logoutBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        logoutBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        logoutBtn.FillColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        logoutBtn.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        logoutBtn.ForeColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        logoutBtn.Image = CType(resources.GetObject("logoutBtn.Image"), Image)
        logoutBtn.ImageAlign = HorizontalAlignment.Left
        logoutBtn.ImageOffset = New Point(35, 0)
        logoutBtn.ImageSize = New Size(25, 25)
        logoutBtn.Location = New Point(0, 661)
        logoutBtn.Margin = New Padding(3, 0, 3, 0)
        logoutBtn.Name = "logoutBtn"
        logoutBtn.PressedColor = Color.Transparent
        logoutBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        logoutBtn.Size = New Size(237, 53)
        logoutBtn.TabIndex = 7
        logoutBtn.Text = "Logout"
        logoutBtn.TextAlign = HorizontalAlignment.Left
        logoutBtn.TextOffset = New Point(50, 0)
        ' 
        ' prescriptionBtn
        ' 
        prescriptionBtn.CustomizableEdges = CustomizableEdges3
        prescriptionBtn.DisabledState.BorderColor = Color.DarkGray
        prescriptionBtn.DisabledState.CustomBorderColor = Color.DarkGray
        prescriptionBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        prescriptionBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        prescriptionBtn.FillColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        prescriptionBtn.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        prescriptionBtn.ForeColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        prescriptionBtn.Image = CType(resources.GetObject("prescriptionBtn.Image"), Image)
        prescriptionBtn.ImageAlign = HorizontalAlignment.Left
        prescriptionBtn.ImageOffset = New Point(35, 0)
        prescriptionBtn.ImageSize = New Size(25, 25)
        prescriptionBtn.Location = New Point(0, 294)
        prescriptionBtn.Margin = New Padding(3, 0, 3, 0)
        prescriptionBtn.Name = "prescriptionBtn"
        prescriptionBtn.PressedColor = Color.Transparent
        prescriptionBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        prescriptionBtn.Size = New Size(237, 53)
        prescriptionBtn.TabIndex = 6
        prescriptionBtn.Text = "Prescriptions"
        prescriptionBtn.TextAlign = HorizontalAlignment.Left
        prescriptionBtn.TextOffset = New Point(50, 0)
        ' 
        ' medicineBtn
        ' 
        medicineBtn.CustomizableEdges = CustomizableEdges5
        medicineBtn.DisabledState.BorderColor = Color.DarkGray
        medicineBtn.DisabledState.CustomBorderColor = Color.DarkGray
        medicineBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        medicineBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        medicineBtn.FillColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        medicineBtn.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        medicineBtn.ForeColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        medicineBtn.Image = CType(resources.GetObject("medicineBtn.Image"), Image)
        medicineBtn.ImageAlign = HorizontalAlignment.Left
        medicineBtn.ImageOffset = New Point(35, 0)
        medicineBtn.ImageSize = New Size(25, 25)
        medicineBtn.Location = New Point(0, 241)
        medicineBtn.Margin = New Padding(3, 0, 3, 0)
        medicineBtn.Name = "medicineBtn"
        medicineBtn.PressedColor = Color.Transparent
        medicineBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        medicineBtn.Size = New Size(237, 53)
        medicineBtn.TabIndex = 5
        medicineBtn.Text = "Medicines"
        medicineBtn.TextAlign = HorizontalAlignment.Left
        medicineBtn.TextOffset = New Point(50, 0)
        ' 
        ' transactionBtn
        ' 
        transactionBtn.CustomizableEdges = CustomizableEdges7
        transactionBtn.DisabledState.BorderColor = Color.DarkGray
        transactionBtn.DisabledState.CustomBorderColor = Color.DarkGray
        transactionBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        transactionBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        transactionBtn.FillColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        transactionBtn.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        transactionBtn.ForeColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        transactionBtn.Image = CType(resources.GetObject("transactionBtn.Image"), Image)
        transactionBtn.ImageAlign = HorizontalAlignment.Left
        transactionBtn.ImageOffset = New Point(35, 0)
        transactionBtn.ImageSize = New Size(25, 25)
        transactionBtn.Location = New Point(0, 188)
        transactionBtn.Margin = New Padding(3, 0, 3, 0)
        transactionBtn.Name = "transactionBtn"
        transactionBtn.PressedColor = Color.Transparent
        transactionBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        transactionBtn.Size = New Size(237, 53)
        transactionBtn.TabIndex = 4
        transactionBtn.Text = "Transactions"
        transactionBtn.TextAlign = HorizontalAlignment.Left
        transactionBtn.TextOffset = New Point(50, 0)
        ' 
        ' dashboardBtn
        ' 
        dashboardBtn.CustomizableEdges = CustomizableEdges9
        dashboardBtn.DisabledState.BorderColor = Color.DarkGray
        dashboardBtn.DisabledState.CustomBorderColor = Color.DarkGray
        dashboardBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        dashboardBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        dashboardBtn.FillColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        dashboardBtn.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dashboardBtn.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        dashboardBtn.Image = My.Resources.Resources.ddashboard_icon
        dashboardBtn.ImageAlign = HorizontalAlignment.Left
        dashboardBtn.ImageOffset = New Point(35, 0)
        dashboardBtn.ImageSize = New Size(25, 25)
        dashboardBtn.Location = New Point(0, 135)
        dashboardBtn.Margin = New Padding(3, 0, 3, 0)
        dashboardBtn.Name = "dashboardBtn"
        dashboardBtn.PressedColor = Color.Transparent
        dashboardBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        dashboardBtn.Size = New Size(237, 53)
        dashboardBtn.TabIndex = 3
        dashboardBtn.Text = "Dashboard"
        dashboardBtn.TextAlign = HorizontalAlignment.Left
        dashboardBtn.TextOffset = New Point(50, 0)
        ' 
        ' separator2
        ' 
        separator2.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        separator2.ForeColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        separator2.Location = New Point(3, 652)
        separator2.Name = "separator2"
        separator2.Size = New Size(237, 2)
        separator2.TabIndex = 1
        ' 
        ' separator3
        ' 
        separator3.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        separator3.ForeColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        separator3.Location = New Point(0, 79)
        separator3.Name = "separator3"
        separator3.Size = New Size(237, 2)
        separator3.TabIndex = 0
        ' 
        ' pharmaMainPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1280, 720)
        Controls.Add(mainPanel)
        Controls.Add(sidebarPanel)
        FormBorderStyle = FormBorderStyle.None
        Name = "pharmaMainPage"
        Text = "pharmaMainPage"
        sidebarPanel.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents mainPanel As Panel
    Friend WithEvents sidebarPanel As Panel
    Friend WithEvents logoutBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents prescriptionBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents medicineBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents transactionBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dashboardBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents separator2 As Panel
    Friend WithEvents separator3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
