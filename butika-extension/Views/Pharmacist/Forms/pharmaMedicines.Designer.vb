<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pharmaMedicines
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
        components = New ComponentModel.Container()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pharmaMedicines))
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        flpMedicine = New FlowLayoutPanel()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        allmedsLbl = New Label()
        infoIcon = New PictureBox()
        medicineSearch = New Guna.UI2.WinForms.Guna2TextBox()
        medicinesLbl = New Label()
        Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        infoManagerIcon = New ToolTip(components)
        Guna2Panel2.SuspendLayout()
        CType(infoIcon, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2Panel2
        ' 
        Guna2Panel2.BackColor = Color.Transparent
        Guna2Panel2.BorderRadius = 10
        Guna2Panel2.Controls.Add(Label4)
        Guna2Panel2.Controls.Add(Label3)
        Guna2Panel2.Controls.Add(Label2)
        Guna2Panel2.Controls.Add(Label1)
        Guna2Panel2.CustomizableEdges = CustomizableEdges1
        Guna2Panel2.FillColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Guna2Panel2.Location = New Point(36, 144)
        Guna2Panel2.Margin = New Padding(3, 3, 3, 0)
        Guna2Panel2.Name = "Guna2Panel2"
        Guna2Panel2.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Panel2.Size = New Size(972, 37)
        Guna2Panel2.TabIndex = 19
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        Label4.Location = New Point(834, 10)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 18)
        Label4.TabIndex = 3
        Label4.Text = "Dosage"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        Label3.Location = New Point(565, 10)
        Label3.Name = "Label3"
        Label3.Size = New Size(107, 18)
        Label3.TabIndex = 2
        Label3.Text = "Manufacturer"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        Label2.Location = New Point(249, 10)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 18)
        Label2.TabIndex = 1
        Label2.Text = "Medicine Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        Label1.Location = New Point(26, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 18)
        Label1.TabIndex = 0
        Label1.Text = "Medicine ID"
        ' 
        ' flpMedicine
        ' 
        flpMedicine.AutoScroll = True
        flpMedicine.FlowDirection = FlowDirection.TopDown
        flpMedicine.Location = New Point(36, 181)
        flpMedicine.Margin = New Padding(0)
        flpMedicine.Name = "flpMedicine"
        flpMedicine.Size = New Size(972, 527)
        flpMedicine.TabIndex = 0
        flpMedicine.WrapContents = False
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.CustomizableEdges = CustomizableEdges3
        Guna2Panel1.FillColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Guna2Panel1.Location = New Point(39, 124)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Panel1.Size = New Size(105, 3)
        Guna2Panel1.TabIndex = 18
        ' 
        ' allmedsLbl
        ' 
        allmedsLbl.AutoSize = True
        allmedsLbl.Cursor = Cursors.Hand
        allmedsLbl.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        allmedsLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        allmedsLbl.Location = New Point(36, 100)
        allmedsLbl.Name = "allmedsLbl"
        allmedsLbl.Size = New Size(112, 19)
        allmedsLbl.TabIndex = 17
        allmedsLbl.Text = "All Medicines"
        ' 
        ' infoIcon
        ' 
        infoIcon.Cursor = Cursors.Hand
        infoIcon.Image = CType(resources.GetObject("infoIcon.Image"), Image)
        infoIcon.Location = New Point(988, 37)
        infoIcon.Name = "infoIcon"
        infoIcon.Size = New Size(20, 20)
        infoIcon.SizeMode = PictureBoxSizeMode.CenterImage
        infoIcon.TabIndex = 15
        infoIcon.TabStop = False
        ' 
        ' medicineSearch
        ' 
        medicineSearch.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        medicineSearch.BorderRadius = 4
        medicineSearch.BorderThickness = 2
        medicineSearch.CustomizableEdges = CustomizableEdges5
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
        medicineSearch.Location = New Point(783, 100)
        medicineSearch.Name = "medicineSearch"
        medicineSearch.PlaceholderForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        medicineSearch.PlaceholderText = "Search medicines"
        medicineSearch.SelectedText = ""
        medicineSearch.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        medicineSearch.Size = New Size(225, 34)
        medicineSearch.TabIndex = 14
        ' 
        ' medicinesLbl
        ' 
        medicinesLbl.AutoSize = True
        medicinesLbl.Font = New Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        medicinesLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        medicinesLbl.Location = New Point(29, 19)
        medicinesLbl.Name = "medicinesLbl"
        medicinesLbl.Size = New Size(186, 38)
        medicinesLbl.TabIndex = 11
        medicinesLbl.Text = "MEDICINES"
        ' 
        ' Guna2Separator1
        ' 
        Guna2Separator1.Location = New Point(12, 73)
        Guna2Separator1.Name = "Guna2Separator1"
        Guna2Separator1.Size = New Size(1019, 10)
        Guna2Separator1.TabIndex = 21
        ' 
        ' pharmaMedicines
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        ClientSize = New Size(1043, 720)
        Controls.Add(flpMedicine)
        Controls.Add(Guna2Separator1)
        Controls.Add(Guna2Panel2)
        Controls.Add(Guna2Panel1)
        Controls.Add(allmedsLbl)
        Controls.Add(infoIcon)
        Controls.Add(medicineSearch)
        Controls.Add(medicinesLbl)
        FormBorderStyle = FormBorderStyle.None
        Name = "pharmaMedicines"
        Text = "pharmaMedicine"
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
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents allmedsLbl As Label
    Friend WithEvents infoIcon As PictureBox
    Friend WithEvents medicineSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents medicinesLbl As Label
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents infoManagerIcon As ToolTip
    Friend WithEvents medicinesPnl As Panel
    Friend WithEvents flpMedicine As FlowLayoutPanel
End Class
