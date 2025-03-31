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
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
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
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        PrescUnderline = New Guna.UI2.WinForms.Guna2Panel()
        Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        OTCUnderline.SuspendLayout()
        PrescUnderline.SuspendLayout()
        SuspendLayout()
        ' 
        ' MedPanel
        ' 
        MedPanel.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        MedPanel.CustomizableEdges = CustomizableEdges1
        MedPanel.Location = New Point(34, 132)
        MedPanel.Name = "MedPanel"
        MedPanel.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        MedPanel.Size = New Size(1174, 576)
        MedPanel.TabIndex = 0
        ' 
        ' Medicines
        ' 
        Medicines.AutoSize = True
        Medicines.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        Medicines.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Medicines.Location = New Point(85, 23)
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
        MedSubtext.Location = New Point(86, 53)
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
        AllMeds.Location = New Point(60, 101)
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
        OverTheCounter.Location = New Point(136, 101)
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
        NeedsPrescription.Location = New Point(265, 101)
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
        Manufacturer.Location = New Point(927, 101)
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
        Price.Location = New Point(1055, 101)
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
        Type.Location = New Point(1132, 101)
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
        MedSearch.Location = New Point(948, 49)
        MedSearch.Name = "MedSearch"
        MedSearch.PlaceholderForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        MedSearch.PlaceholderText = "Search"
        MedSearch.SelectedText = ""
        MedSearch.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        MedSearch.Size = New Size(246, 21)
        MedSearch.TabIndex = 8
        ' 
        ' AllMedsUnderline
        ' 
        AllMedsUnderline.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        AllMedsUnderline.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        AllMedsUnderline.CustomizableEdges = CustomizableEdges5
        AllMedsUnderline.Location = New Point(60, 119)
        AllMedsUnderline.Name = "AllMedsUnderline"
        AllMedsUnderline.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        AllMedsUnderline.Size = New Size(62, 4)
        AllMedsUnderline.TabIndex = 1
        ' 
        ' OTCUnderline
        ' 
        OTCUnderline.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        OTCUnderline.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        OTCUnderline.Controls.Add(Guna2Panel1)
        OTCUnderline.CustomizableEdges = CustomizableEdges9
        OTCUnderline.Location = New Point(138, 119)
        OTCUnderline.Name = "OTCUnderline"
        OTCUnderline.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        OTCUnderline.Size = New Size(115, 4)
        OTCUnderline.TabIndex = 2
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Guna2Panel1.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Guna2Panel1.CustomizableEdges = CustomizableEdges7
        Guna2Panel1.Location = New Point(176, 0)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2Panel1.Size = New Size(64, 4)
        Guna2Panel1.TabIndex = 3
        ' 
        ' PrescUnderline
        ' 
        PrescUnderline.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        PrescUnderline.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        PrescUnderline.Controls.Add(Guna2Panel3)
        PrescUnderline.CustomizableEdges = CustomizableEdges13
        PrescUnderline.Location = New Point(269, 120)
        PrescUnderline.Name = "PrescUnderline"
        PrescUnderline.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        PrescUnderline.Size = New Size(120, 4)
        PrescUnderline.TabIndex = 4
        ' 
        ' Guna2Panel3
        ' 
        Guna2Panel3.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Guna2Panel3.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Guna2Panel3.CustomizableEdges = CustomizableEdges11
        Guna2Panel3.Location = New Point(176, 0)
        Guna2Panel3.Name = "Guna2Panel3"
        Guna2Panel3.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        Guna2Panel3.Size = New Size(64, 4)
        Guna2Panel3.TabIndex = 3
        ' 
        ' MedicinePage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        ClientSize = New Size(1220, 720)
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
        ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        FormBorderStyle = FormBorderStyle.None
        Name = "MedicinePage"
        StartPosition = FormStartPosition.CenterParent
        Text = "MedicinePage"
        OTCUnderline.ResumeLayout(False)
        PrescUnderline.ResumeLayout(False)
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
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PrescUnderline As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
End Class
