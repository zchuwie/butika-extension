<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MedicinePage
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
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        MedPanel = New Guna.UI2.WinForms.Guna2Panel()
        Medicines = New Label()
        MedSubtext = New Label()
        AllMeds = New Label()
        OverTheCounter = New Label()
        NeedsPrescription = New Label()
        Manufacturer = New Label()
        Price = New Label()
        Type = New Label()
        MedSearch = New Guna.UI2.WinForms.Guna2TextBox()
        AllMedsUnderline = New Guna.UI2.WinForms.Guna2Panel()
        OTCUnderline = New Guna.UI2.WinForms.Guna2Panel()
        PrescUnderline = New Guna.UI2.WinForms.Guna2Panel()
        MedIcon = New PictureBox()
        ManuDown = New PictureBox()
        PriceDown = New PictureBox()
        TypeDown = New PictureBox()
        ManuUp = New PictureBox()
        PriceUp = New PictureBox()
        TypeUp = New PictureBox()
        SearchIcon = New PictureBox()
        Information = New PictureBox()
        CType(MedIcon, ComponentModel.ISupportInitialize).BeginInit()
        CType(ManuDown, ComponentModel.ISupportInitialize).BeginInit()
        CType(PriceDown, ComponentModel.ISupportInitialize).BeginInit()
        CType(TypeDown, ComponentModel.ISupportInitialize).BeginInit()
        CType(ManuUp, ComponentModel.ISupportInitialize).BeginInit()
        CType(PriceUp, ComponentModel.ISupportInitialize).BeginInit()
        CType(TypeUp, ComponentModel.ISupportInitialize).BeginInit()
        CType(SearchIcon, ComponentModel.ISupportInitialize).BeginInit()
        CType(Information, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MedPanel
        ' 
        MedPanel.AutoScroll = True
        MedPanel.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        MedPanel.BorderThickness = 1
        MedPanel.CustomizableEdges = CustomizableEdges1
        MedPanel.Location = New Point(34, 132)
        MedPanel.Name = "MedPanel"
        MedPanel.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        MedPanel.Size = New Size(1174, 549)
        MedPanel.TabIndex = 0
        ' 
        ' Medicines
        ' 
        Medicines.AutoSize = True
        Medicines.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        Medicines.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Medicines.Location = New Point(96, 25)
        Medicines.Name = "Medicines"
        Medicines.Size = New Size(132, 28)
        Medicines.TabIndex = 0
        Medicines.Text = "Medicines"
        ' 
        ' MedSubtext
        ' 
        MedSubtext.AutoSize = True
        MedSubtext.Font = New Font("Century Gothic", 9.75F)
        MedSubtext.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        MedSubtext.Location = New Point(97, 55)
        MedSubtext.Name = "MedSubtext"
        MedSubtext.Size = New Size(222, 17)
        MedSubtext.TabIndex = 1
        MedSubtext.Text = "View all our available medicines."
        ' 
        ' AllMeds
        ' 
        AllMeds.AutoSize = True
        AllMeds.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        AllMeds.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        AllMeds.Location = New Point(55, 98)
        AllMeds.Name = "AllMeds"
        AllMeds.Size = New Size(64, 16)
        AllMeds.TabIndex = 2
        AllMeds.Text = "All Meds"
        ' 
        ' OverTheCounter
        ' 
        OverTheCounter.AutoSize = True
        OverTheCounter.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        OverTheCounter.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        OverTheCounter.Location = New Point(131, 98)
        OverTheCounter.Name = "OverTheCounter"
        OverTheCounter.Size = New Size(119, 16)
        OverTheCounter.TabIndex = 3
        OverTheCounter.Text = "Over The Counter"
        ' 
        ' NeedsPrescription
        ' 
        NeedsPrescription.AutoSize = True
        NeedsPrescription.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        NeedsPrescription.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        NeedsPrescription.Location = New Point(260, 98)
        NeedsPrescription.Name = "NeedsPrescription"
        NeedsPrescription.Size = New Size(128, 16)
        NeedsPrescription.TabIndex = 4
        NeedsPrescription.Text = "Needs Prescription"
        ' 
        ' Manufacturer
        ' 
        Manufacturer.AutoSize = True
        Manufacturer.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        Manufacturer.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Manufacturer.Location = New Point(878, 105)
        Manufacturer.Name = "Manufacturer"
        Manufacturer.Size = New Size(95, 16)
        Manufacturer.TabIndex = 5
        Manufacturer.Text = "Manufacturer"
        ' 
        ' Price
        ' 
        Price.AutoSize = True
        Price.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        Price.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Price.Location = New Point(1006, 105)
        Price.Name = "Price"
        Price.Size = New Size(39, 16)
        Price.TabIndex = 6
        Price.Text = "Price"
        ' 
        ' Type
        ' 
        Type.AutoSize = True
        Type.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        Type.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Type.Location = New Point(1083, 105)
        Type.Name = "Type"
        Type.Size = New Size(38, 16)
        Type.TabIndex = 7
        Type.Text = "Type"
        ' 
        ' MedSearch
        ' 
        MedSearch.BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        MedSearch.BackgroundImageLayout = ImageLayout.None
        MedSearch.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        MedSearch.CustomizableEdges = CustomizableEdges3
        MedSearch.DefaultText = ""
        MedSearch.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        MedSearch.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        MedSearch.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        MedSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        MedSearch.FillColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        MedSearch.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        MedSearch.Font = New Font("Century Gothic", 9.75F)
        MedSearch.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        MedSearch.Location = New Point(905, 44)
        MedSearch.Name = "MedSearch"
        MedSearch.PlaceholderForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        MedSearch.PlaceholderText = "Search"
        MedSearch.SelectedText = ""
        MedSearch.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        MedSearch.Size = New Size(289, 26)
        MedSearch.TabIndex = 8
        ' 
        ' AllMedsUnderline
        ' 
        AllMedsUnderline.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        AllMedsUnderline.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        AllMedsUnderline.CustomizableEdges = CustomizableEdges5
        AllMedsUnderline.Location = New Point(55, 116)
        AllMedsUnderline.Name = "AllMedsUnderline"
        AllMedsUnderline.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        AllMedsUnderline.Size = New Size(62, 4)
        AllMedsUnderline.TabIndex = 1
        ' 
        ' OTCUnderline
        ' 
        OTCUnderline.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        OTCUnderline.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        OTCUnderline.CustomizableEdges = CustomizableEdges7
        OTCUnderline.Location = New Point(133, 116)
        OTCUnderline.Name = "OTCUnderline"
        OTCUnderline.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        OTCUnderline.Size = New Size(115, 4)
        OTCUnderline.TabIndex = 2
        ' 
        ' PrescUnderline
        ' 
        PrescUnderline.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        PrescUnderline.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        PrescUnderline.CustomizableEdges = CustomizableEdges9
        PrescUnderline.Location = New Point(264, 117)
        PrescUnderline.Name = "PrescUnderline"
        PrescUnderline.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        PrescUnderline.Size = New Size(120, 4)
        PrescUnderline.TabIndex = 4
        ' 
        ' MedIcon
        ' 
        MedIcon.Image = My.Resources.Resources.medIcon
        MedIcon.Location = New Point(28, 17)
        MedIcon.Name = "MedIcon"
        MedIcon.Size = New Size(67, 64)
        MedIcon.SizeMode = PictureBoxSizeMode.Zoom
        MedIcon.TabIndex = 9
        MedIcon.TabStop = False
        ' 
        ' ManuDown
        ' 
        ManuDown.Image = My.Resources.Resources.down
        ManuDown.Location = New Point(976, 104)
        ManuDown.Name = "ManuDown"
        ManuDown.Size = New Size(17, 17)
        ManuDown.SizeMode = PictureBoxSizeMode.Zoom
        ManuDown.TabIndex = 10
        ManuDown.TabStop = False
        ' 
        ' PriceDown
        ' 
        PriceDown.Image = My.Resources.Resources.down
        PriceDown.Location = New Point(1051, 105)
        PriceDown.Name = "PriceDown"
        PriceDown.Size = New Size(17, 17)
        PriceDown.SizeMode = PictureBoxSizeMode.Zoom
        PriceDown.TabIndex = 11
        PriceDown.TabStop = False
        ' 
        ' TypeDown
        ' 
        TypeDown.Image = My.Resources.Resources.down
        TypeDown.Location = New Point(1127, 105)
        TypeDown.Name = "TypeDown"
        TypeDown.Size = New Size(17, 17)
        TypeDown.SizeMode = PictureBoxSizeMode.Zoom
        TypeDown.TabIndex = 12
        TypeDown.TabStop = False
        ' 
        ' ManuUp
        ' 
        ManuUp.Image = My.Resources.Resources.up
        ManuUp.Location = New Point(976, 81)
        ManuUp.Name = "ManuUp"
        ManuUp.Size = New Size(17, 17)
        ManuUp.SizeMode = PictureBoxSizeMode.Zoom
        ManuUp.TabIndex = 13
        ManuUp.TabStop = False
        ' 
        ' PriceUp
        ' 
        PriceUp.Image = My.Resources.Resources.up
        PriceUp.Location = New Point(1051, 82)
        PriceUp.Name = "PriceUp"
        PriceUp.Size = New Size(17, 17)
        PriceUp.SizeMode = PictureBoxSizeMode.Zoom
        PriceUp.TabIndex = 14
        PriceUp.TabStop = False
        ' 
        ' TypeUp
        ' 
        TypeUp.Image = My.Resources.Resources.up
        TypeUp.Location = New Point(1127, 82)
        TypeUp.Name = "TypeUp"
        TypeUp.Size = New Size(17, 17)
        TypeUp.SizeMode = PictureBoxSizeMode.Zoom
        TypeUp.TabIndex = 15
        TypeUp.TabStop = False
        ' 
        ' SearchIcon
        ' 
        SearchIcon.Image = My.Resources.Resources.search
        SearchIcon.Location = New Point(1170, 49)
        SearchIcon.Name = "SearchIcon"
        SearchIcon.Size = New Size(17, 17)
        SearchIcon.SizeMode = PictureBoxSizeMode.Zoom
        SearchIcon.TabIndex = 14
        SearchIcon.TabStop = False
        ' 
        ' Information
        ' 
        Information.Image = My.Resources.Resources.information
        Information.Location = New Point(1177, 105)
        Information.Name = "Information"
        Information.Size = New Size(17, 17)
        Information.SizeMode = PictureBoxSizeMode.Zoom
        Information.TabIndex = 16
        Information.TabStop = False
        ' 
        ' MedicinePage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        ClientSize = New Size(1220, 720)
        Controls.Add(Information)
        Controls.Add(SearchIcon)
        Controls.Add(TypeUp)
        Controls.Add(PriceUp)
        Controls.Add(ManuUp)
        Controls.Add(TypeDown)
        Controls.Add(PriceDown)
        Controls.Add(ManuDown)
        Controls.Add(PrescUnderline)
        Controls.Add(OTCUnderline)
        Controls.Add(AllMedsUnderline)
        Controls.Add(MedSearch)
        Controls.Add(Type)
        Controls.Add(Price)
        Controls.Add(Manufacturer)
        Controls.Add(NeedsPrescription)
        Controls.Add(OverTheCounter)
        Controls.Add(AllMeds)
        Controls.Add(MedSubtext)
        Controls.Add(Medicines)
        Controls.Add(MedPanel)
        Controls.Add(MedIcon)
        ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        FormBorderStyle = FormBorderStyle.None
        Name = "MedicinePage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MedicinePage"
        CType(MedIcon, ComponentModel.ISupportInitialize).EndInit()
        CType(ManuDown, ComponentModel.ISupportInitialize).EndInit()
        CType(PriceDown, ComponentModel.ISupportInitialize).EndInit()
        CType(TypeDown, ComponentModel.ISupportInitialize).EndInit()
        CType(ManuUp, ComponentModel.ISupportInitialize).EndInit()
        CType(PriceUp, ComponentModel.ISupportInitialize).EndInit()
        CType(TypeUp, ComponentModel.ISupportInitialize).EndInit()
        CType(SearchIcon, ComponentModel.ISupportInitialize).EndInit()
        CType(Information, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MedPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Medicines As Label
    Friend WithEvents MedSubtext As Label
    Friend WithEvents AllMeds As Label
    Friend WithEvents OverTheCounter As Label
    Friend WithEvents NeedsPrescription As Label
    Friend WithEvents Manufacturer As Label
    Friend WithEvents Price As Label
    Friend WithEvents Type As Label
    Friend WithEvents MedSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents AllMedsUnderline As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents OTCUnderline As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PrescUnderline As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents MedIcon As PictureBox
    Friend WithEvents SearchIcon As PictureBox
    Friend WithEvents ManuDown As PictureBox
    Friend WithEvents PriceDown As PictureBox
    Friend WithEvents TypeDown As PictureBox
    Friend WithEvents ManuUp As PictureBox
    Friend WithEvents PriceUp As PictureBox
    Friend WithEvents TypeUp As PictureBox
    Friend WithEvents Information As PictureBox
End Class
