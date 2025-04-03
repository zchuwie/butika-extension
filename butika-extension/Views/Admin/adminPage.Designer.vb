<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminPage))
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        adminSidePanel = New Panel()
        adminExit = New Guna.UI2.WinForms.Guna2Button()
        adminDiscount = New Guna.UI2.WinForms.Guna2Button()
        adminLogs = New Guna.UI2.WinForms.Guna2Button()
        adminUser = New Guna.UI2.WinForms.Guna2Button()
        adminDashboard = New Guna.UI2.WinForms.Guna2Button()
        adminLogo = New Guna.UI2.WinForms.Guna2Button()
        adminViewPanel = New Panel()
        adminSidePanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' adminSidePanel
        ' 
        adminSidePanel.BackColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        adminSidePanel.Controls.Add(adminExit)
        adminSidePanel.Controls.Add(adminDiscount)
        adminSidePanel.Controls.Add(adminLogs)
        adminSidePanel.Controls.Add(adminUser)
        adminSidePanel.Controls.Add(adminDashboard)
        adminSidePanel.Controls.Add(adminLogo)
        adminSidePanel.Dock = DockStyle.Left
        adminSidePanel.Location = New Point(0, 0)
        adminSidePanel.Name = "adminSidePanel"
        adminSidePanel.Size = New Size(64, 720)
        adminSidePanel.TabIndex = 6
        ' 
        ' adminExit
        ' 
        adminExit.Cursor = Cursors.Hand
        adminExit.CustomizableEdges = CustomizableEdges1
        adminExit.DisabledState.FillColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        adminExit.Dock = DockStyle.Bottom
        adminExit.FillColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        adminExit.Font = New Font("Segoe UI", 9F)
        adminExit.ForeColor = Color.White
        adminExit.HoverState.FillColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        adminExit.Image = CType(resources.GetObject("adminExit.Image"), Image)
        adminExit.ImageSize = New Size(40, 40)
        adminExit.Location = New Point(0, 656)
        adminExit.Name = "adminExit"
        adminExit.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        adminExit.Size = New Size(64, 64)
        adminExit.TabIndex = 7
        ' 
        ' adminDiscount
        ' 
        adminDiscount.Cursor = Cursors.Hand
        adminDiscount.CustomizableEdges = CustomizableEdges3
        adminDiscount.DisabledState.BorderColor = Color.DarkGray
        adminDiscount.DisabledState.CustomBorderColor = Color.DarkGray
        adminDiscount.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        adminDiscount.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        adminDiscount.Dock = DockStyle.Top
        adminDiscount.FillColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        adminDiscount.Font = New Font("Segoe UI", 9F)
        adminDiscount.ForeColor = Color.White
        adminDiscount.HoverState.FillColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        adminDiscount.HoverState.Image = CType(resources.GetObject("resource.Image"), Image)
        adminDiscount.Image = CType(resources.GetObject("adminDiscount.Image"), Image)
        adminDiscount.ImageSize = New Size(40, 40)
        adminDiscount.Location = New Point(0, 256)
        adminDiscount.Name = "adminDiscount"
        adminDiscount.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        adminDiscount.Size = New Size(64, 64)
        adminDiscount.TabIndex = 6
        ' 
        ' adminLogs
        ' 
        adminLogs.Cursor = Cursors.Hand
        adminLogs.CustomizableEdges = CustomizableEdges5
        adminLogs.DisabledState.BorderColor = Color.DarkGray
        adminLogs.DisabledState.CustomBorderColor = Color.DarkGray
        adminLogs.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        adminLogs.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        adminLogs.Dock = DockStyle.Top
        adminLogs.FillColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        adminLogs.Font = New Font("Segoe UI", 9F)
        adminLogs.ForeColor = Color.White
        adminLogs.HoverState.FillColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        adminLogs.HoverState.Image = CType(resources.GetObject("resource.Image1"), Image)
        adminLogs.Image = CType(resources.GetObject("adminLogs.Image"), Image)
        adminLogs.ImageSize = New Size(40, 40)
        adminLogs.Location = New Point(0, 192)
        adminLogs.Name = "adminLogs"
        adminLogs.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        adminLogs.Size = New Size(64, 64)
        adminLogs.TabIndex = 5
        ' 
        ' adminUser
        ' 
        adminUser.Cursor = Cursors.Hand
        adminUser.CustomizableEdges = CustomizableEdges7
        adminUser.DisabledState.BorderColor = Color.DarkGray
        adminUser.DisabledState.CustomBorderColor = Color.DarkGray
        adminUser.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        adminUser.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        adminUser.Dock = DockStyle.Top
        adminUser.FillColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        adminUser.Font = New Font("Segoe UI", 9F)
        adminUser.ForeColor = Color.White
        adminUser.HoverState.FillColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        adminUser.HoverState.Image = CType(resources.GetObject("resource.Image2"), Image)
        adminUser.Image = CType(resources.GetObject("adminUser.Image"), Image)
        adminUser.ImageSize = New Size(40, 40)
        adminUser.Location = New Point(0, 128)
        adminUser.Name = "adminUser"
        adminUser.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        adminUser.Size = New Size(64, 64)
        adminUser.TabIndex = 4
        ' 
        ' adminDashboard
        ' 
        adminDashboard.Cursor = Cursors.Hand
        adminDashboard.CustomizableEdges = CustomizableEdges9
        adminDashboard.DisabledState.BorderColor = Color.DarkGray
        adminDashboard.DisabledState.CustomBorderColor = Color.DarkGray
        adminDashboard.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        adminDashboard.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        adminDashboard.Dock = DockStyle.Top
        adminDashboard.FillColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        adminDashboard.Font = New Font("Segoe UI", 9F)
        adminDashboard.ForeColor = Color.White
        adminDashboard.HoverState.FillColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        adminDashboard.HoverState.Image = CType(resources.GetObject("resource.Image3"), Image)
        adminDashboard.Image = CType(resources.GetObject("adminDashboard.Image"), Image)
        adminDashboard.ImageSize = New Size(40, 40)
        adminDashboard.Location = New Point(0, 64)
        adminDashboard.Name = "adminDashboard"
        adminDashboard.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        adminDashboard.Size = New Size(64, 64)
        adminDashboard.TabIndex = 3
        ' 
        ' adminLogo
        ' 
        adminLogo.CustomizableEdges = CustomizableEdges11
        adminLogo.DisabledState.BorderColor = Color.DarkGray
        adminLogo.DisabledState.CustomBorderColor = Color.DarkGray
        adminLogo.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        adminLogo.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        adminLogo.Dock = DockStyle.Top
        adminLogo.FillColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        adminLogo.Font = New Font("Segoe UI", 9F)
        adminLogo.ForeColor = Color.White
        adminLogo.HoverState.FillColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        adminLogo.Image = CType(resources.GetObject("adminLogo.Image"), Image)
        adminLogo.ImageSize = New Size(50, 50)
        adminLogo.Location = New Point(0, 0)
        adminLogo.Name = "adminLogo"
        adminLogo.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        adminLogo.Size = New Size(64, 64)
        adminLogo.TabIndex = 2
        ' 
        ' adminViewPanel
        ' 
        adminViewPanel.Dock = DockStyle.Fill
        adminViewPanel.Location = New Point(64, 0)
        adminViewPanel.Name = "adminViewPanel"
        adminViewPanel.Size = New Size(1216, 720)
        adminViewPanel.TabIndex = 5
        ' 
        ' adminPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        ClientSize = New Size(1280, 720)
        Controls.Add(adminViewPanel)
        Controls.Add(adminSidePanel)
        FormBorderStyle = FormBorderStyle.None
        Name = "adminPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "adminPage"
        adminSidePanel.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents adminSidePanel As Panel
    Friend WithEvents adminExit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents adminDiscount As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents adminLogs As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents adminUser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents adminDashboard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents adminLogo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents adminViewPanel As Panel
End Class
