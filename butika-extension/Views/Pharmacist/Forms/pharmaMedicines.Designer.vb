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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pharmaMedicines))
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        flpMedicine = New FlowLayoutPanel()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        allmedsLbl = New Label()
        medicineSearch = New Guna.UI2.WinForms.Guna2TextBox()
        medicinesLbl = New Label()
        Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Panel5 = New Panel()
        Panel6 = New Panel()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Guna2Panel2.SuspendLayout()
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
        Guna2Panel2.Location = New Point(36, 147)
        Guna2Panel2.Margin = New Padding(3, 3, 3, 0)
        Guna2Panel2.Name = "Guna2Panel2"
        Guna2Panel2.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Panel2.Size = New Size(972, 39)
        Guna2Panel2.TabIndex = 19
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        Label4.Location = New Point(834, 11)
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
        Label3.Location = New Point(565, 11)
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
        Label2.Location = New Point(249, 11)
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
        Label1.Location = New Point(26, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 18)
        Label1.TabIndex = 0
        Label1.Text = "Medicine ID"
        ' 
        ' flpMedicine
        ' 
        flpMedicine.AutoScroll = True
        flpMedicine.FlowDirection = FlowDirection.TopDown
        flpMedicine.Location = New Point(36, 186)
        flpMedicine.Margin = New Padding(0)
        flpMedicine.Name = "flpMedicine"
        flpMedicine.Size = New Size(995, 525)
        flpMedicine.TabIndex = 0
        flpMedicine.WrapContents = False
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.CustomizableEdges = CustomizableEdges3
        Guna2Panel1.FillColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Guna2Panel1.Location = New Point(39, 125)
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
        medicineSearch.Location = New Point(776, 93)
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
        Guna2Separator1.Location = New Point(12, 71)
        Guna2Separator1.Name = "Guna2Separator1"
        Guna2Separator1.Size = New Size(1019, 11)
        Guna2Separator1.TabIndex = 21
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(24), CByte(36), CByte(36))
        Panel1.Location = New Point(1009, 40)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(15, 16)
        Panel1.TabIndex = 22
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(184), CByte(129), CByte(184))
        Panel2.Location = New Point(658, 18)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(15, 16)
        Panel2.TabIndex = 23
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(194), CByte(139), CByte(62))
        Panel3.Location = New Point(1009, 18)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(15, 16)
        Panel3.TabIndex = 24
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(255), CByte(153), CByte(102))
        Panel4.Location = New Point(658, 40)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(15, 16)
        Panel4.TabIndex = 27
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(229), CByte(65), CByte(65))
        Panel5.Location = New Point(831, 18)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(15, 16)
        Panel5.TabIndex = 26
        ' 
        ' Panel6
        ' 
        Panel6.BorderStyle = BorderStyle.FixedSingle
        Panel6.Location = New Point(831, 40)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(15, 16)
        Panel6.TabIndex = 25
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        Label5.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label5.Location = New Point(562, 40)
        Label5.Name = "Label5"
        Label5.Size = New Size(90, 16)
        Label5.TabIndex = 28
        Label5.Text = "Medium Stock"
        Label5.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        Label6.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label6.Location = New Point(734, 18)
        Label6.Name = "Label6"
        Label6.Size = New Size(91, 16)
        Label6.TabIndex = 29
        Label6.Text = "Expired Stocks"
        Label6.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        Label7.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label7.Location = New Point(779, 40)
        Label7.Name = "Label7"
        Label7.Size = New Size(46, 16)
        Label7.TabIndex = 30
        Label7.Text = "Goods"
        Label7.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        Label8.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label8.Location = New Point(891, 38)
        Label8.Name = "Label8"
        Label8.Size = New Size(112, 16)
        Label8.TabIndex = 33
        Label8.Text = "Expired Low Stock"
        Label8.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        Label9.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label9.Location = New Point(513, 18)
        Label9.Name = "Label9"
        Label9.Size = New Size(139, 16)
        Label9.TabIndex = 32
        Label9.Text = "Expiring Medium Stock"
        Label9.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        Label10.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label10.Location = New Point(884, 18)
        Label10.Name = "Label10"
        Label10.Size = New Size(119, 16)
        Label10.TabIndex = 31
        Label10.Text = "Critically Low Stock"
        Label10.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' pharmaMedicines
        ' 
        AutoScaleDimensions = New SizeF(7F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        ClientSize = New Size(1043, 720)
        Controls.Add(Label8)
        Controls.Add(Label9)
        Controls.Add(Label10)
        Controls.Add(Label7)
        Controls.Add(flpMedicine)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Panel4)
        Controls.Add(Panel5)
        Controls.Add(Panel6)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Guna2Separator1)
        Controls.Add(Guna2Panel2)
        Controls.Add(Guna2Panel1)
        Controls.Add(allmedsLbl)
        Controls.Add(medicineSearch)
        Controls.Add(medicinesLbl)
        Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        FormBorderStyle = FormBorderStyle.None
        Name = "pharmaMedicines"
        Guna2Panel2.ResumeLayout(False)
        Guna2Panel2.PerformLayout()
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
    Friend WithEvents medicineSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents medicinesLbl As Label
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents medicinesPnl As Panel
    Friend WithEvents flpMedicine As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
