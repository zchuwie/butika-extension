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
        PictureBox6 = New PictureBox()
        HomePageBtn = New PictureBox()
        PictureBox5 = New PictureBox()
        MedPageBtn = New PictureBox()
        PrescPageBtn = New PictureBox()
        CartPageBtn = New PictureBox()
        MainPanel = New Guna.UI2.WinForms.Guna2Panel()
        sidebar.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
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
        sidebar.Controls.Add(PictureBox6)
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
        ' PictureBox6
        ' 
        PictureBox6.Cursor = Cursors.Hand
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(12, 650)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(45, 40)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 5
        PictureBox6.TabStop = False
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
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PrescPageBtn As PictureBox
    Friend WithEvents CartPageBtn As PictureBox
    Friend WithEvents MedPageBtn As PictureBox
End Class
