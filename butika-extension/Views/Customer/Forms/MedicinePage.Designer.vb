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
        ManuComBox = New ComboBox()
        Medicines = New Label()
        MedSubtext = New Label()
        AllMeds = New Label()
        OverTheCounter = New Label()
        NeedsPrescription = New Label()
        MedSearch = New Guna.UI2.WinForms.Guna2TextBox()
        AllMedsUnderline = New Guna.UI2.WinForms.Guna2Panel()
        OTCUnderline = New Guna.UI2.WinForms.Guna2Panel()
        PrescUnderline = New Guna.UI2.WinForms.Guna2Panel()
        MedIcon = New PictureBox()
        SearchIcon = New PictureBox()
        Information = New PictureBox()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        CType(MedIcon, ComponentModel.ISupportInitialize).BeginInit()
        CType(SearchIcon, ComponentModel.ISupportInitialize).BeginInit()
        CType(Information, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MedPanel
        ' 
        MedPanel.AutoScroll = True
        MedPanel.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        MedPanel.BorderThickness = 1
        MedPanel.Cursor = Cursors.Hand
        MedPanel.CustomizableEdges = CustomizableEdges1
        MedPanel.Location = New Point(49, 132)
        MedPanel.Name = "MedPanel"
        MedPanel.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        MedPanel.Size = New Size(1121, 549)
        MedPanel.TabIndex = 0
        ' 
        ' ManuComBox
        ' 
        ManuComBox.BackColor = Color.White
        ManuComBox.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        ManuComBox.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        ManuComBox.FormattingEnabled = True
        ManuComBox.Items.AddRange(New Object() {"test1", "test2", "test3", "test4", "test5"})
        ManuComBox.Location = New Point(834, 100)
        ManuComBox.Name = "ManuComBox"
        ManuComBox.Size = New Size(121, 24)
        ManuComBox.TabIndex = 1
        ManuComBox.Text = "Manufacturer"
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
        AllMeds.Cursor = Cursors.Hand
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
        OverTheCounter.Cursor = Cursors.Hand
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
        NeedsPrescription.Cursor = Cursors.Hand
        NeedsPrescription.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        NeedsPrescription.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        NeedsPrescription.Location = New Point(260, 98)
        NeedsPrescription.Name = "NeedsPrescription"
        NeedsPrescription.Size = New Size(128, 16)
        NeedsPrescription.TabIndex = 4
        NeedsPrescription.Text = "Needs Prescription"
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
        MedSearch.Location = New Point(875, 43)
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
        AllMedsUnderline.Location = New Point(55, 115)
        AllMedsUnderline.Name = "AllMedsUnderline"
        AllMedsUnderline.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        AllMedsUnderline.Size = New Size(62, 4)
        AllMedsUnderline.TabIndex = 1
        AllMedsUnderline.Visible = False
        ' 
        ' OTCUnderline
        ' 
        OTCUnderline.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        OTCUnderline.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        OTCUnderline.CustomizableEdges = CustomizableEdges7
        OTCUnderline.Location = New Point(133, 115)
        OTCUnderline.Name = "OTCUnderline"
        OTCUnderline.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        OTCUnderline.Size = New Size(115, 4)
        OTCUnderline.TabIndex = 2
        OTCUnderline.Visible = False
        ' 
        ' PrescUnderline
        ' 
        PrescUnderline.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        PrescUnderline.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        PrescUnderline.CustomizableEdges = CustomizableEdges9
        PrescUnderline.Location = New Point(264, 116)
        PrescUnderline.Name = "PrescUnderline"
        PrescUnderline.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        PrescUnderline.Size = New Size(120, 4)
        PrescUnderline.TabIndex = 4
        PrescUnderline.Visible = False
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
        ' SearchIcon
        ' 
        SearchIcon.Image = My.Resources.Resources.search
        SearchIcon.Location = New Point(1140, 48)
        SearchIcon.Name = "SearchIcon"
        SearchIcon.Size = New Size(17, 17)
        SearchIcon.SizeMode = PictureBoxSizeMode.Zoom
        SearchIcon.TabIndex = 14
        SearchIcon.TabStop = False
        ' 
        ' Information
        ' 
        Information.Image = My.Resources.Resources.information
        Information.Location = New Point(1147, 104)
        Information.Name = "Information"
        Information.Size = New Size(17, 17)
        Information.SizeMode = PictureBoxSizeMode.Zoom
        Information.TabIndex = 16
        Information.TabStop = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.White
        ComboBox1.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        ComboBox1.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"test1", "test2", "test3", "test4", "test5"})
        ComboBox1.Location = New Point(961, 100)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(75, 24)
        ComboBox1.TabIndex = 2
        ComboBox1.Text = "Price"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.BackColor = Color.White
        ComboBox2.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        ComboBox2.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"test1", "test2", "test3", "test4", "test5"})
        ComboBox2.Location = New Point(1042, 100)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(84, 24)
        ComboBox2.TabIndex = 17
        ComboBox2.Text = "Type"
        ' 
        ' MedicinePage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        ClientSize = New Size(1220, 720)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(ManuComBox)
        Controls.Add(Information)
        Controls.Add(SearchIcon)
        Controls.Add(PrescUnderline)
        Controls.Add(OTCUnderline)
        Controls.Add(AllMedsUnderline)
        Controls.Add(MedSearch)
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
    Friend WithEvents MedSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents AllMedsUnderline As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents OTCUnderline As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PrescUnderline As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents MedIcon As PictureBox
    Friend WithEvents SearchIcon As PictureBox
    Friend WithEvents Information As PictureBox
    Friend WithEvents ManuCombo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents ManuComBox As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
End Class
