<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryCustodian_MainPanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InventoryCustodian_MainPanel))
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Panel1 = New Panel()
        DashboardButtonPanel = New Panel()
        Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        dashboard_medicine_btn = New Guna.UI2.WinForms.Guna2Button()
        Spacing = New Panel()
        LogoutPanel = New Panel()
        dashboard_logout_btn = New Guna.UI2.WinForms.Guna2Button()
        Panel2 = New Panel()
        LogoContainer = New Panel()
        Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        DisplayPanel_InventoryCustodian = New Panel()
        Panel1.SuspendLayout()
        DashboardButtonPanel.SuspendLayout()
        LogoutPanel.SuspendLayout()
        LogoContainer.SuspendLayout()
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Panel1.Controls.Add(DashboardButtonPanel)
        Panel1.Controls.Add(LogoutPanel)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(LogoContainer)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(248, 720)
        Panel1.TabIndex = 0
        ' 
        ' DashboardButtonPanel
        ' 
        DashboardButtonPanel.Controls.Add(Guna2Button2)
        DashboardButtonPanel.Controls.Add(dashboard_medicine_btn)
        DashboardButtonPanel.Controls.Add(Spacing)
        DashboardButtonPanel.Dock = DockStyle.Fill
        DashboardButtonPanel.Location = New Point(0, 70)
        DashboardButtonPanel.Margin = New Padding(3, 2, 3, 2)
        DashboardButtonPanel.Name = "DashboardButtonPanel"
        DashboardButtonPanel.Size = New Size(248, 582)
        DashboardButtonPanel.TabIndex = 3
        ' 
        ' Guna2Button2
        ' 
        Guna2Button2.CustomizableEdges = CustomizableEdges1
        Guna2Button2.DisabledState.BorderColor = Color.DarkGray
        Guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button2.Dock = DockStyle.Top
        Guna2Button2.FillColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Guna2Button2.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        Guna2Button2.ForeColor = Color.White
        Guna2Button2.Location = New Point(0, 72)
        Guna2Button2.Margin = New Padding(3, 2, 3, 2)
        Guna2Button2.Name = "Guna2Button2"
        Guna2Button2.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button2.Size = New Size(248, 36)
        Guna2Button2.TabIndex = 2
        Guna2Button2.Text = "Reserve Button"
        ' 
        ' dashboard_medicine_btn
        ' 
        dashboard_medicine_btn.CustomizableEdges = CustomizableEdges3
        dashboard_medicine_btn.DisabledState.BorderColor = Color.DarkGray
        dashboard_medicine_btn.DisabledState.CustomBorderColor = Color.DarkGray
        dashboard_medicine_btn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        dashboard_medicine_btn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        dashboard_medicine_btn.Dock = DockStyle.Top
        dashboard_medicine_btn.FillColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        dashboard_medicine_btn.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        dashboard_medicine_btn.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        dashboard_medicine_btn.Image = CType(resources.GetObject("dashboard_medicine_btn.Image"), Image)
        dashboard_medicine_btn.Location = New Point(0, 36)
        dashboard_medicine_btn.Margin = New Padding(3, 2, 3, 2)
        dashboard_medicine_btn.Name = "dashboard_medicine_btn"
        dashboard_medicine_btn.Padding = New Padding(20, 0, 0, 0)
        dashboard_medicine_btn.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        dashboard_medicine_btn.Size = New Size(248, 36)
        dashboard_medicine_btn.TabIndex = 1
        dashboard_medicine_btn.Text = "Medicines"
        ' 
        ' Spacing
        ' 
        Spacing.Dock = DockStyle.Top
        Spacing.Location = New Point(0, 0)
        Spacing.Margin = New Padding(3, 2, 3, 2)
        Spacing.Name = "Spacing"
        Spacing.Size = New Size(248, 36)
        Spacing.TabIndex = 0
        ' 
        ' LogoutPanel
        ' 
        LogoutPanel.Controls.Add(dashboard_logout_btn)
        LogoutPanel.Dock = DockStyle.Bottom
        LogoutPanel.Location = New Point(0, 652)
        LogoutPanel.Margin = New Padding(3, 2, 3, 2)
        LogoutPanel.Name = "LogoutPanel"
        LogoutPanel.Size = New Size(248, 68)
        LogoutPanel.TabIndex = 2
        ' 
        ' dashboard_logout_btn
        ' 
        dashboard_logout_btn.CustomizableEdges = CustomizableEdges5
        dashboard_logout_btn.DisabledState.BorderColor = Color.DarkGray
        dashboard_logout_btn.DisabledState.CustomBorderColor = Color.DarkGray
        dashboard_logout_btn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        dashboard_logout_btn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        dashboard_logout_btn.FillColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        dashboard_logout_btn.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        dashboard_logout_btn.ForeColor = Color.White
        dashboard_logout_btn.Image = CType(resources.GetObject("dashboard_logout_btn.Image"), Image)
        dashboard_logout_btn.Location = New Point(0, 14)
        dashboard_logout_btn.Margin = New Padding(3, 2, 3, 2)
        dashboard_logout_btn.Name = "dashboard_logout_btn"
        dashboard_logout_btn.Padding = New Padding(20, 0, 0, 0)
        dashboard_logout_btn.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        dashboard_logout_btn.Size = New Size(248, 36)
        dashboard_logout_btn.TabIndex = 0
        dashboard_logout_btn.Text = "Logout"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 68)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(248, 2)
        Panel2.TabIndex = 1
        ' 
        ' LogoContainer
        ' 
        LogoContainer.Controls.Add(Guna2PictureBox1)
        LogoContainer.Dock = DockStyle.Top
        LogoContainer.Location = New Point(0, 0)
        LogoContainer.Margin = New Padding(3, 2, 3, 2)
        LogoContainer.Name = "LogoContainer"
        LogoContainer.Size = New Size(248, 68)
        LogoContainer.TabIndex = 0
        ' 
        ' Guna2PictureBox1
        ' 
        Guna2PictureBox1.CustomizableEdges = CustomizableEdges7
        Guna2PictureBox1.FillColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), Image)
        Guna2PictureBox1.ImageRotate = 0F
        Guna2PictureBox1.InitialImage = CType(resources.GetObject("Guna2PictureBox1.InitialImage"), Image)
        Guna2PictureBox1.Location = New Point(23, 9)
        Guna2PictureBox1.Margin = New Padding(3, 2, 3, 2)
        Guna2PictureBox1.Name = "Guna2PictureBox1"
        Guna2PictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2PictureBox1.Size = New Size(193, 47)
        Guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        Guna2PictureBox1.TabIndex = 0
        Guna2PictureBox1.TabStop = False
        ' 
        ' DisplayPanel_InventoryCustodian
        ' 
        DisplayPanel_InventoryCustodian.BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(244))
        DisplayPanel_InventoryCustodian.Dock = DockStyle.Fill
        DisplayPanel_InventoryCustodian.Location = New Point(248, 0)
        DisplayPanel_InventoryCustodian.Margin = New Padding(3, 2, 3, 2)
        DisplayPanel_InventoryCustodian.Name = "DisplayPanel_InventoryCustodian"
        DisplayPanel_InventoryCustodian.Size = New Size(1032, 720)
        DisplayPanel_InventoryCustodian.TabIndex = 1
        ' 
        ' InventoryCustodian_MainPanel
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1280, 720)
        Controls.Add(DisplayPanel_InventoryCustodian)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "InventoryCustodian_MainPanel"
        StartPosition = FormStartPosition.CenterScreen
        Text = "InventoryCustodian_MainPanel"
        Panel1.ResumeLayout(False)
        DashboardButtonPanel.ResumeLayout(False)
        LogoutPanel.ResumeLayout(False)
        LogoContainer.ResumeLayout(False)
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DisplayPanel_InventoryCustodian As Panel
    Friend WithEvents LogoutPanel As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LogoContainer As Panel
    Friend WithEvents DashboardButtonPanel As Panel
    Friend WithEvents Spacing As Panel
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dashboard_medicine_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dashboard_logout_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
