<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pharmaPrescriptions
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
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pharmaPrescriptions))
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges17 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges18 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges19 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges20 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        medicinesPnl = New Panel()
        allprescriptPnl = New Guna.UI2.WinForms.Guna2Panel()
        allprescriptLbl = New Label()
        infoIcon = New PictureBox()
        medicineSearch = New Guna.UI2.WinForms.Guna2TextBox()
        prescriptionsLbl = New Label()
        pendingPnl = New Guna.UI2.WinForms.Guna2Panel()
        Label5 = New Label()
        declinedPnl = New Guna.UI2.WinForms.Guna2Panel()
        Label6 = New Label()
        Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Guna2Panel2.SuspendLayout()
        CType(infoIcon, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2Panel2
        ' 
        Guna2Panel2.BorderRadius = 10
        Guna2Panel2.Controls.Add(Label4)
        Guna2Panel2.Controls.Add(Label3)
        Guna2Panel2.Controls.Add(Label2)
        Guna2Panel2.Controls.Add(Label1)
        Guna2Panel2.CustomizableEdges = CustomizableEdges11
        Guna2Panel2.FillColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Guna2Panel2.Location = New Point(36, 141)
        Guna2Panel2.Margin = New Padding(3, 3, 3, 0)
        Guna2Panel2.Name = "Guna2Panel2"
        Guna2Panel2.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        Guna2Panel2.Size = New Size(972, 37)
        Guna2Panel2.TabIndex = 27
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        Label4.Location = New Point(843, 10)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 18)
        Label4.TabIndex = 3
        Label4.Text = "Action"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        Label3.Location = New Point(580, 10)
        Label3.Name = "Label3"
        Label3.Size = New Size(145, 18)
        Label3.TabIndex = 2
        Label3.Text = "Date of Submission"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        Label2.Location = New Point(301, 10)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 18)
        Label2.TabIndex = 1
        Label2.Text = "Patient Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        Label1.Location = New Point(26, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 18)
        Label1.TabIndex = 0
        Label1.Text = "Prescription ID"
        ' 
        ' medicinesPnl
        ' 
        medicinesPnl.AutoScroll = True
        medicinesPnl.Location = New Point(36, 178)
        medicinesPnl.Margin = New Padding(3, 0, 3, 3)
        medicinesPnl.Name = "medicinesPnl"
        medicinesPnl.Size = New Size(972, 527)
        medicinesPnl.TabIndex = 28
        ' 
        ' allprescriptPnl
        ' 
        allprescriptPnl.CustomizableEdges = CustomizableEdges13
        allprescriptPnl.FillColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        allprescriptPnl.Location = New Point(39, 121)
        allprescriptPnl.Name = "allprescriptPnl"
        allprescriptPnl.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        allprescriptPnl.Size = New Size(118, 3)
        allprescriptPnl.TabIndex = 26
        ' 
        ' allprescriptLbl
        ' 
        allprescriptLbl.AutoSize = True
        allprescriptLbl.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        allprescriptLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        allprescriptLbl.Location = New Point(36, 97)
        allprescriptLbl.Name = "allprescriptLbl"
        allprescriptLbl.Size = New Size(127, 19)
        allprescriptLbl.TabIndex = 25
        allprescriptLbl.Text = "All Prescriptions"
        ' 
        ' infoIcon
        ' 
        infoIcon.Image = CType(resources.GetObject("infoIcon.Image"), Image)
        infoIcon.Location = New Point(988, 34)
        infoIcon.Name = "infoIcon"
        infoIcon.Size = New Size(20, 20)
        infoIcon.SizeMode = PictureBoxSizeMode.CenterImage
        infoIcon.TabIndex = 23
        infoIcon.TabStop = False
        ' 
        ' medicineSearch
        ' 
        medicineSearch.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        medicineSearch.BorderRadius = 4
        medicineSearch.BorderThickness = 2
        medicineSearch.CustomizableEdges = CustomizableEdges15
        medicineSearch.DefaultText = ""
        medicineSearch.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        medicineSearch.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        medicineSearch.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        medicineSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        medicineSearch.FillColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        medicineSearch.FocusedState.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        medicineSearch.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        medicineSearch.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        medicineSearch.HoverState.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        medicineSearch.IconRight = CType(resources.GetObject("medicineSearch.IconRight"), Image)
        medicineSearch.Location = New Point(783, 97)
        medicineSearch.Name = "medicineSearch"
        medicineSearch.PlaceholderForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        medicineSearch.PlaceholderText = "Search medicines"
        medicineSearch.SelectedText = ""
        medicineSearch.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        medicineSearch.Size = New Size(225, 34)
        medicineSearch.TabIndex = 22
        ' 
        ' prescriptionsLbl
        ' 
        prescriptionsLbl.AutoSize = True
        prescriptionsLbl.Font = New Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        prescriptionsLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        prescriptionsLbl.Location = New Point(29, 16)
        prescriptionsLbl.Name = "prescriptionsLbl"
        prescriptionsLbl.Size = New Size(249, 38)
        prescriptionsLbl.TabIndex = 21
        prescriptionsLbl.Text = "PRESCRIPTIONS"
        ' 
        ' pendingPnl
        ' 
        pendingPnl.CustomizableEdges = CustomizableEdges17
        pendingPnl.FillColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        pendingPnl.Location = New Point(173, 121)
        pendingPnl.Name = "pendingPnl"
        pendingPnl.ShadowDecoration.CustomizableEdges = CustomizableEdges18
        pendingPnl.Size = New Size(68, 3)
        pendingPnl.TabIndex = 30
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label5.Location = New Point(169, 97)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 19)
        Label5.TabIndex = 29
        Label5.Text = "Pendings"
        ' 
        ' declinedPnl
        ' 
        declinedPnl.CustomizableEdges = CustomizableEdges19
        declinedPnl.FillColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        declinedPnl.Location = New Point(260, 121)
        declinedPnl.Name = "declinedPnl"
        declinedPnl.ShadowDecoration.CustomizableEdges = CustomizableEdges20
        declinedPnl.Size = New Size(69, 3)
        declinedPnl.TabIndex = 32
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label6.Location = New Point(255, 97)
        Label6.Name = "Label6"
        Label6.Size = New Size(79, 19)
        Label6.TabIndex = 31
        Label6.Text = "Declined"
        ' 
        ' Guna2Separator1
        ' 
        Guna2Separator1.Location = New Point(12, 73)
        Guna2Separator1.Name = "Guna2Separator1"
        Guna2Separator1.Size = New Size(1019, 10)
        Guna2Separator1.TabIndex = 33
        ' 
        ' pharmaPrescriptions
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        ClientSize = New Size(1043, 720)
        Controls.Add(Guna2Separator1)
        Controls.Add(declinedPnl)
        Controls.Add(Label6)
        Controls.Add(pendingPnl)
        Controls.Add(Label5)
        Controls.Add(Guna2Panel2)
        Controls.Add(medicinesPnl)
        Controls.Add(allprescriptPnl)
        Controls.Add(allprescriptLbl)
        Controls.Add(infoIcon)
        Controls.Add(medicineSearch)
        Controls.Add(prescriptionsLbl)
        FormBorderStyle = FormBorderStyle.None
        Name = "pharmaPrescriptions"
        Text = "pharmaPrescriptions"
        Guna2Panel2.ResumeLayout(False)
        Guna2Panel2.PerformLayout()
        CType(infoIcon, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents medicinesPnl As Panel
    Friend WithEvents allprescriptPnl As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents allprescriptLbl As Label
    Friend WithEvents infoIcon As PictureBox
    Friend WithEvents medicineSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents prescriptionsLbl As Label
    Friend WithEvents pendingPnl As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents declinedPnl As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
End Class
