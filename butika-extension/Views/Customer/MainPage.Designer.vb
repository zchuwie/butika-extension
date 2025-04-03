<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainPage))
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        sidebar = New Guna.UI2.WinForms.Guna2Panel()
        pressedSettingsPanel = New Panel()
        pressedSettings = New PictureBox()
        PressedNotifPanel = New Panel()
        PressedNotif = New PictureBox()
        PressedCartPanel = New Panel()
        PressedCart = New PictureBox()
        pressedPillsPanel = New Panel()
        pressedPills = New PictureBox()
        pressedHomePanel = New Panel()
        pressedHome = New PictureBox()
        SettingsBtn = New PictureBox()
        HomePageBtn = New PictureBox()
        PictureBox5 = New PictureBox()
        MedPageBtn = New PictureBox()
        PrescPageBtn = New PictureBox()
        CartPageBtn = New PictureBox()
        MainPanel = New Guna.UI2.WinForms.Guna2Panel()
        sidebar.SuspendLayout()
        pressedSettingsPanel.SuspendLayout()
        CType(pressedSettings, ComponentModel.ISupportInitialize).BeginInit()
        PressedNotifPanel.SuspendLayout()
        CType(PressedNotif, ComponentModel.ISupportInitialize).BeginInit()
        PressedCartPanel.SuspendLayout()
        CType(PressedCart, ComponentModel.ISupportInitialize).BeginInit()
        pressedPillsPanel.SuspendLayout()
        CType(pressedPills, ComponentModel.ISupportInitialize).BeginInit()
        pressedHomePanel.SuspendLayout()
        CType(pressedHome, ComponentModel.ISupportInitialize).BeginInit()
        CType(SettingsBtn, ComponentModel.ISupportInitialize).BeginInit()
        CType(HomePageBtn, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(MedPageBtn, ComponentModel.ISupportInitialize).BeginInit()
        CType(PrescPageBtn, ComponentModel.ISupportInitialize).BeginInit()
        CType(CartPageBtn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' sidebar
        ' 
        sidebar.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        sidebar.Controls.Add(pressedSettingsPanel)
        sidebar.Controls.Add(PressedNotifPanel)
        sidebar.Controls.Add(PressedCartPanel)
        sidebar.Controls.Add(pressedPillsPanel)
        sidebar.Controls.Add(pressedHomePanel)
        sidebar.Controls.Add(SettingsBtn)
        sidebar.Controls.Add(HomePageBtn)
        sidebar.Controls.Add(PictureBox5)
        sidebar.Controls.Add(MedPageBtn)
        sidebar.Controls.Add(PrescPageBtn)
        sidebar.Controls.Add(CartPageBtn)
        sidebar.CustomizableEdges = CustomizableEdges1
        sidebar.Dock = DockStyle.Left
        sidebar.Location = New Point(0, 0)
        sidebar.Name = "sidebar"
        sidebar.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        sidebar.Size = New Size(70, 720)
        sidebar.TabIndex = 1
        ' 
        ' pressedSettingsPanel
        ' 
        pressedSettingsPanel.BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        pressedSettingsPanel.Controls.Add(pressedSettings)
        pressedSettingsPanel.Location = New Point(0, 636)
        pressedSettingsPanel.Name = "pressedSettingsPanel"
        pressedSettingsPanel.Size = New Size(71, 67)
        pressedSettingsPanel.TabIndex = 2
        pressedSettingsPanel.Visible = False
        ' 
        ' pressedSettings
        ' 
        pressedSettings.Cursor = Cursors.Hand
        pressedSettings.Image = My.Resources.Resources.pressedSettings
        pressedSettings.Location = New Point(12, 13)
        pressedSettings.Name = "pressedSettings"
        pressedSettings.Size = New Size(45, 40)
        pressedSettings.SizeMode = PictureBoxSizeMode.Zoom
        pressedSettings.TabIndex = 1
        pressedSettings.TabStop = False
        ' 
        ' PressedNotifPanel
        ' 
        PressedNotifPanel.BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        PressedNotifPanel.Controls.Add(PressedNotif)
        PressedNotifPanel.Location = New Point(0, 219)
        PressedNotifPanel.Name = "PressedNotifPanel"
        PressedNotifPanel.Size = New Size(71, 67)
        PressedNotifPanel.TabIndex = 1
        PressedNotifPanel.Visible = False
        ' 
        ' PressedNotif
        ' 
        PressedNotif.Cursor = Cursors.Hand
        PressedNotif.Image = My.Resources.Resources.pressedNotif
        PressedNotif.Location = New Point(12, 13)
        PressedNotif.Name = "PressedNotif"
        PressedNotif.Size = New Size(45, 40)
        PressedNotif.SizeMode = PictureBoxSizeMode.Zoom
        PressedNotif.TabIndex = 1
        PressedNotif.TabStop = False
        ' 
        ' PressedCartPanel
        ' 
        PressedCartPanel.BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        PressedCartPanel.Controls.Add(PressedCart)
        PressedCartPanel.Location = New Point(0, 149)
        PressedCartPanel.Name = "PressedCartPanel"
        PressedCartPanel.Size = New Size(71, 71)
        PressedCartPanel.TabIndex = 1
        PressedCartPanel.Visible = False
        ' 
        ' PressedCart
        ' 
        PressedCart.Cursor = Cursors.Hand
        PressedCart.Image = My.Resources.Resources.pressedCart
        PressedCart.Location = New Point(12, 13)
        PressedCart.Name = "PressedCart"
        PressedCart.Size = New Size(45, 40)
        PressedCart.SizeMode = PictureBoxSizeMode.Zoom
        PressedCart.TabIndex = 1
        PressedCart.TabStop = False
        ' 
        ' pressedPillsPanel
        ' 
        pressedPillsPanel.BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        pressedPillsPanel.Controls.Add(pressedPills)
        pressedPillsPanel.Location = New Point(0, 79)
        pressedPillsPanel.Name = "pressedPillsPanel"
        pressedPillsPanel.Size = New Size(71, 70)
        pressedPillsPanel.TabIndex = 1
        pressedPillsPanel.Visible = False
        ' 
        ' pressedPills
        ' 
        pressedPills.Cursor = Cursors.Hand
        pressedPills.Image = My.Resources.Resources.pressedPills
        pressedPills.Location = New Point(12, 13)
        pressedPills.Name = "pressedPills"
        pressedPills.Size = New Size(45, 40)
        pressedPills.SizeMode = PictureBoxSizeMode.Zoom
        pressedPills.TabIndex = 1
        pressedPills.TabStop = False
        ' 
        ' pressedHomePanel
        ' 
        pressedHomePanel.BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        pressedHomePanel.Controls.Add(pressedHome)
        pressedHomePanel.Location = New Point(0, 12)
        pressedHomePanel.Name = "pressedHomePanel"
        pressedHomePanel.Size = New Size(71, 68)
        pressedHomePanel.TabIndex = 0
        pressedHomePanel.Visible = False
        ' 
        ' pressedHome
        ' 
        pressedHome.Cursor = Cursors.Hand
        pressedHome.Image = My.Resources.Resources.pressedHome
        pressedHome.Location = New Point(12, 13)
        pressedHome.Name = "pressedHome"
        pressedHome.Size = New Size(45, 40)
        pressedHome.SizeMode = PictureBoxSizeMode.Zoom
        pressedHome.TabIndex = 1
        pressedHome.TabStop = False
        ' 
        ' SettingsBtn
        ' 
        SettingsBtn.Cursor = Cursors.Hand
        SettingsBtn.Image = CType(resources.GetObject("SettingsBtn.Image"), Image)
        SettingsBtn.Location = New Point(12, 650)
        SettingsBtn.Name = "SettingsBtn"
        SettingsBtn.Size = New Size(45, 40)
        SettingsBtn.SizeMode = PictureBoxSizeMode.Zoom
        SettingsBtn.TabIndex = 5
        SettingsBtn.TabStop = False
        ' 
        ' HomePageBtn
        ' 
        HomePageBtn.Cursor = Cursors.Hand
        HomePageBtn.Image = CType(resources.GetObject("HomePageBtn.Image"), Image)
        HomePageBtn.Location = New Point(12, 25)
        HomePageBtn.Name = "HomePageBtn"
        HomePageBtn.Size = New Size(45, 40)
        HomePageBtn.SizeMode = PictureBoxSizeMode.Zoom
        HomePageBtn.TabIndex = 0
        HomePageBtn.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Cursor = Cursors.Hand
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(12, 582)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(45, 40)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 4
        PictureBox5.TabStop = False
        ' 
        ' MedPageBtn
        ' 
        MedPageBtn.Cursor = Cursors.Hand
        MedPageBtn.Image = CType(resources.GetObject("MedPageBtn.Image"), Image)
        MedPageBtn.Location = New Point(12, 93)
        MedPageBtn.Name = "MedPageBtn"
        MedPageBtn.Size = New Size(45, 40)
        MedPageBtn.SizeMode = PictureBoxSizeMode.Zoom
        MedPageBtn.TabIndex = 1
        MedPageBtn.TabStop = False
        ' 
        ' PrescPageBtn
        ' 
        PrescPageBtn.Cursor = Cursors.Hand
        PrescPageBtn.Image = CType(resources.GetObject("PrescPageBtn.Image"), Image)
        PrescPageBtn.Location = New Point(12, 231)
        PrescPageBtn.Name = "PrescPageBtn"
        PrescPageBtn.Size = New Size(45, 40)
        PrescPageBtn.SizeMode = PictureBoxSizeMode.Zoom
        PrescPageBtn.TabIndex = 3
        PrescPageBtn.TabStop = False
        ' 
        ' CartPageBtn
        ' 
        CartPageBtn.Cursor = Cursors.Hand
        CartPageBtn.Image = CType(resources.GetObject("CartPageBtn.Image"), Image)
        CartPageBtn.Location = New Point(12, 162)
        CartPageBtn.Name = "CartPageBtn"
        CartPageBtn.Size = New Size(45, 40)
        CartPageBtn.SizeMode = PictureBoxSizeMode.Zoom
        CartPageBtn.TabIndex = 2
        CartPageBtn.TabStop = False
        ' 
        ' MainPanel
        ' 
        MainPanel.BackColor = Color.Transparent
        MainPanel.BorderColor = Color.FromArgb(CByte(20), CByte(66), CByte(60))
        MainPanel.CustomizableEdges = CustomizableEdges3
        MainPanel.Dock = DockStyle.Fill
        MainPanel.Location = New Point(70, 0)
        MainPanel.Name = "MainPanel"
        MainPanel.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        MainPanel.Size = New Size(1210, 720)
        MainPanel.TabIndex = 2
        ' 
        ' MainPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        ClientSize = New Size(1280, 720)
        Controls.Add(MainPanel)
        Controls.Add(sidebar)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "MainPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MainPage"
        sidebar.ResumeLayout(False)
        pressedSettingsPanel.ResumeLayout(False)
        CType(pressedSettings, ComponentModel.ISupportInitialize).EndInit()
        PressedNotifPanel.ResumeLayout(False)
        CType(PressedNotif, ComponentModel.ISupportInitialize).EndInit()
        PressedCartPanel.ResumeLayout(False)
        CType(PressedCart, ComponentModel.ISupportInitialize).EndInit()
        pressedPillsPanel.ResumeLayout(False)
        CType(pressedPills, ComponentModel.ISupportInitialize).EndInit()
        pressedHomePanel.ResumeLayout(False)
        CType(pressedHome, ComponentModel.ISupportInitialize).EndInit()
        CType(SettingsBtn, ComponentModel.ISupportInitialize).EndInit()
        CType(HomePageBtn, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(MedPageBtn, ComponentModel.ISupportInitialize).EndInit()
        CType(PrescPageBtn, ComponentModel.ISupportInitialize).EndInit()
        CType(CartPageBtn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents sidebar As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents MainPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents HomePageBtn As PictureBox
    Friend WithEvents SettingsBtn As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PrescPageBtn As PictureBox
    Friend WithEvents CartPageBtn As PictureBox
    Friend WithEvents MedPageBtn As PictureBox
    Friend WithEvents pressedHomePanel As Panel
    Friend WithEvents pressedPillsPanel As Panel
    Friend WithEvents pressedPills As PictureBox
    Friend WithEvents pressedHome As PictureBox
    Friend WithEvents PressedNotifPanel As Panel
    Friend WithEvents PressedNotif As PictureBox
    Friend WithEvents PressedCartPanel As Panel
    Friend WithEvents PressedCart As PictureBox
    Friend WithEvents pressedSettingsPanel As Panel
    Friend WithEvents pressedSettings As PictureBox
End Class
