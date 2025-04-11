<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adminDiscounts
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Label2 = New Label()
        Label1 = New Label()
        Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        discountTable = New Guna.UI2.WinForms.Guna2DataGridView()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        statusBtn = New Guna.UI2.WinForms.Guna2Button()
        Label5 = New Label()
        Label4 = New Label()
        verificationImage = New PictureBox()
        age = New Label()
        namedata = New Label()
        id = New Label()
        Label15 = New Label()
        Label14 = New Label()
        Label13 = New Label()
        Label3 = New Label()
        verifiedBtn = New Guna.UI2.WinForms.Guna2Button()
        NotverifiedBtn = New Guna.UI2.WinForms.Guna2Button()
        adminDiscountText = New RoundedButton()
        adminLogsText = New RoundedButton()
        adminUserText = New RoundedButton()
        adminDashboardText = New RoundedButton()
        allBtn = New Guna.UI2.WinForms.Guna2Button()
        Guna2Panel5.SuspendLayout()
        CType(discountTable, ComponentModel.ISupportInitialize).BeginInit()
        Guna2Panel1.SuspendLayout()
        CType(verificationImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        Label2.Location = New Point(40, 48)
        Label2.Name = "Label2"
        Label2.Size = New Size(173, 16)
        Label2.TabIndex = 53
        Label2.Text = "View all discount updates here"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        Label1.Location = New Point(37, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(198, 23)
        Label1.TabIndex = 52
        Label1.Text = "Discount Verification"
        ' 
        ' Guna2Panel5
        ' 
        Guna2Panel5.BorderColor = Color.FromArgb(CByte(110), CByte(126), CByte(124))
        Guna2Panel5.BorderRadius = 20
        Guna2Panel5.BorderThickness = 1
        Guna2Panel5.Controls.Add(discountTable)
        Guna2Panel5.CustomizableEdges = CustomizableEdges1
        Guna2Panel5.FillColor = Color.FromArgb(CByte(196), CByte(218), CByte(212))
        Guna2Panel5.Location = New Point(40, 104)
        Guna2Panel5.Name = "Guna2Panel5"
        Guna2Panel5.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Panel5.Size = New Size(831, 563)
        Guna2Panel5.TabIndex = 54
        ' 
        ' discountTable
        ' 
        discountTable.AllowUserToAddRows = False
        discountTable.AllowUserToDeleteRows = False
        discountTable.AllowUserToResizeColumns = False
        discountTable.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        discountTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        discountTable.BackgroundColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        DataGridViewCellStyle2.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        discountTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        discountTable.ColumnHeadersHeight = 20
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(110), CByte(126), CByte(124))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(110), CByte(126), CByte(124))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        discountTable.DefaultCellStyle = DataGridViewCellStyle3
        discountTable.GridColor = Color.FromArgb(CByte(110), CByte(126), CByte(124))
        discountTable.Location = New Point(15, 14)
        discountTable.Name = "discountTable"
        discountTable.ReadOnly = True
        discountTable.RowHeadersVisible = False
        discountTable.ScrollBars = ScrollBars.None
        discountTable.Size = New Size(801, 532)
        discountTable.TabIndex = 5
        discountTable.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        discountTable.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        discountTable.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        discountTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        discountTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        discountTable.ThemeStyle.BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        discountTable.ThemeStyle.GridColor = Color.FromArgb(CByte(110), CByte(126), CByte(124))
        discountTable.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        discountTable.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        discountTable.ThemeStyle.HeaderStyle.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        discountTable.ThemeStyle.HeaderStyle.ForeColor = Color.White
        discountTable.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        discountTable.ThemeStyle.HeaderStyle.Height = 20
        discountTable.ThemeStyle.ReadOnly = True
        discountTable.ThemeStyle.RowsStyle.BackColor = Color.White
        discountTable.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        discountTable.ThemeStyle.RowsStyle.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        discountTable.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        discountTable.ThemeStyle.RowsStyle.Height = 25
        discountTable.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        discountTable.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BorderColor = Color.FromArgb(CByte(110), CByte(126), CByte(124))
        Guna2Panel1.BorderRadius = 20
        Guna2Panel1.BorderThickness = 1
        Guna2Panel1.Controls.Add(statusBtn)
        Guna2Panel1.Controls.Add(Label5)
        Guna2Panel1.Controls.Add(Label4)
        Guna2Panel1.Controls.Add(verificationImage)
        Guna2Panel1.Controls.Add(age)
        Guna2Panel1.Controls.Add(namedata)
        Guna2Panel1.Controls.Add(id)
        Guna2Panel1.Controls.Add(Label15)
        Guna2Panel1.Controls.Add(Label14)
        Guna2Panel1.Controls.Add(Label13)
        Guna2Panel1.Controls.Add(Label3)
        Guna2Panel1.CustomizableEdges = CustomizableEdges5
        Guna2Panel1.FillColor = Color.FromArgb(CByte(196), CByte(218), CByte(212))
        Guna2Panel1.Location = New Point(884, 104)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2Panel1.Size = New Size(282, 563)
        Guna2Panel1.TabIndex = 55
        ' 
        ' statusBtn
        ' 
        statusBtn.BorderRadius = 5
        statusBtn.CustomizableEdges = CustomizableEdges3
        statusBtn.DisabledState.BorderColor = Color.DarkGray
        statusBtn.DisabledState.CustomBorderColor = Color.DarkGray
        statusBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        statusBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        statusBtn.Enabled = False
        statusBtn.FillColor = Color.FromArgb(CByte(102), CByte(102), CByte(102))
        statusBtn.Font = New Font("Century Gothic", 9F)
        statusBtn.ForeColor = Color.White
        statusBtn.Location = New Point(62, 514)
        statusBtn.Name = "statusBtn"
        statusBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        statusBtn.Size = New Size(125, 23)
        statusBtn.TabIndex = 90
        statusBtn.Text = "-"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        Label5.Location = New Point(18, 517)
        Label5.Name = "Label5"
        Label5.Size = New Size(41, 15)
        Label5.TabIndex = 84
        Label5.Text = "Status:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        Label4.Location = New Point(19, 138)
        Label4.Name = "Label4"
        Label4.Size = New Size(107, 15)
        Label4.TabIndex = 83
        Label4.Text = "Verification Image:"
        ' 
        ' verificationImage
        ' 
        verificationImage.Location = New Point(18, 156)
        verificationImage.Name = "verificationImage"
        verificationImage.Size = New Size(243, 341)
        verificationImage.TabIndex = 82
        verificationImage.TabStop = False
        ' 
        ' age
        ' 
        age.AutoSize = True
        age.BackColor = Color.Transparent
        age.Font = New Font("Century Gothic", 6.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        age.ForeColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        age.Location = New Point(98, 98)
        age.Name = "age"
        age.Size = New Size(10, 13)
        age.TabIndex = 81
        age.Text = "-"
        ' 
        ' namedata
        ' 
        namedata.AutoSize = True
        namedata.BackColor = Color.Transparent
        namedata.Font = New Font("Century Gothic", 6.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        namedata.ForeColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        namedata.Location = New Point(98, 81)
        namedata.Name = "namedata"
        namedata.Size = New Size(10, 13)
        namedata.TabIndex = 80
        namedata.Text = "-"
        ' 
        ' id
        ' 
        id.AutoSize = True
        id.BackColor = Color.Transparent
        id.Font = New Font("Century Gothic", 6.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        id.ForeColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        id.Location = New Point(98, 64)
        id.Name = "id"
        id.Size = New Size(10, 13)
        id.TabIndex = 79
        id.Text = "-"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = Color.Transparent
        Label15.Font = New Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        Label15.Location = New Point(19, 96)
        Label15.Name = "Label15"
        Label15.Size = New Size(32, 15)
        Label15.TabIndex = 78
        Label15.Text = "Age:"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.Transparent
        Label14.Font = New Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        Label14.Location = New Point(19, 79)
        Label14.Name = "Label14"
        Label14.Size = New Size(42, 15)
        Label14.TabIndex = 77
        Label14.Text = "Name:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        Label13.Location = New Point(18, 62)
        Label13.Name = "Label13"
        Label13.Size = New Size(20, 15)
        Label13.TabIndex = 76
        Label13.Text = "ID:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        Label3.Location = New Point(19, 19)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 16)
        Label3.TabIndex = 53
        Label3.Text = "User Details"
        ' 
        ' verifiedBtn
        ' 
        verifiedBtn.BorderColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        verifiedBtn.BorderRadius = 1
        verifiedBtn.BorderThickness = 1
        verifiedBtn.CustomizableEdges = CustomizableEdges7
        verifiedBtn.DisabledState.BorderColor = Color.DarkGray
        verifiedBtn.DisabledState.CustomBorderColor = Color.DarkGray
        verifiedBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        verifiedBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        verifiedBtn.FillColor = Color.FromArgb(CByte(196), CByte(218), CByte(212))
        verifiedBtn.Font = New Font("Century Gothic", 9F)
        verifiedBtn.ForeColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        verifiedBtn.Location = New Point(666, 75)
        verifiedBtn.Name = "verifiedBtn"
        verifiedBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        verifiedBtn.Size = New Size(92, 23)
        verifiedBtn.TabIndex = 88
        verifiedBtn.Text = "Verified"
        ' 
        ' NotverifiedBtn
        ' 
        NotverifiedBtn.BorderColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        NotverifiedBtn.BorderRadius = 1
        NotverifiedBtn.BorderThickness = 1
        NotverifiedBtn.CustomizableEdges = CustomizableEdges9
        NotverifiedBtn.DisabledState.BorderColor = Color.DarkGray
        NotverifiedBtn.DisabledState.CustomBorderColor = Color.DarkGray
        NotverifiedBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        NotverifiedBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        NotverifiedBtn.FillColor = Color.FromArgb(CByte(196), CByte(218), CByte(212))
        NotverifiedBtn.Font = New Font("Century Gothic", 9F)
        NotverifiedBtn.ForeColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        NotverifiedBtn.Location = New Point(767, 75)
        NotverifiedBtn.Name = "NotverifiedBtn"
        NotverifiedBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        NotverifiedBtn.Size = New Size(104, 23)
        NotverifiedBtn.TabIndex = 89
        NotverifiedBtn.Text = "Not Verified"
        ' 
        ' adminDiscountText
        ' 
        adminDiscountText.BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        adminDiscountText.CornerRadius = 60
        adminDiscountText.FlatStyle = FlatStyle.Flat
        adminDiscountText.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        adminDiscountText.ForeColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        adminDiscountText.Location = New Point(-8, 256)
        adminDiscountText.Name = "adminDiscountText"
        adminDiscountText.Size = New Size(152, 64)
        adminDiscountText.TabIndex = 93
        adminDiscountText.Text = "Discount Status"
        adminDiscountText.UseVisualStyleBackColor = False
        adminDiscountText.Visible = False
        ' 
        ' adminLogsText
        ' 
        adminLogsText.BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        adminLogsText.CornerRadius = 60
        adminLogsText.FlatStyle = FlatStyle.Flat
        adminLogsText.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        adminLogsText.ForeColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        adminLogsText.Location = New Point(-6, 192)
        adminLogsText.Name = "adminLogsText"
        adminLogsText.Size = New Size(103, 64)
        adminLogsText.TabIndex = 92
        adminLogsText.Text = "User Logs"
        adminLogsText.UseVisualStyleBackColor = False
        adminLogsText.Visible = False
        ' 
        ' adminUserText
        ' 
        adminUserText.BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        adminUserText.CornerRadius = 60
        adminUserText.FlatStyle = FlatStyle.Flat
        adminUserText.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        adminUserText.ForeColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        adminUserText.Location = New Point(-9, 128)
        adminUserText.Name = "adminUserText"
        adminUserText.Size = New Size(138, 64)
        adminUserText.TabIndex = 91
        adminUserText.Text = "User Account"
        adminUserText.UseVisualStyleBackColor = False
        adminUserText.Visible = False
        ' 
        ' adminDashboardText
        ' 
        adminDashboardText.BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        adminDashboardText.CornerRadius = 60
        adminDashboardText.FlatStyle = FlatStyle.Flat
        adminDashboardText.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        adminDashboardText.ForeColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        adminDashboardText.Location = New Point(-4, 64)
        adminDashboardText.Name = "adminDashboardText"
        adminDashboardText.Size = New Size(109, 64)
        adminDashboardText.TabIndex = 90
        adminDashboardText.Text = "Dashboard"
        adminDashboardText.UseVisualStyleBackColor = False
        adminDashboardText.Visible = False
        ' 
        ' allBtn
        ' 
        allBtn.BorderColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        allBtn.BorderRadius = 1
        allBtn.BorderThickness = 1
        allBtn.CustomizableEdges = CustomizableEdges11
        allBtn.DisabledState.BorderColor = Color.DarkGray
        allBtn.DisabledState.CustomBorderColor = Color.DarkGray
        allBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        allBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        allBtn.FillColor = Color.FromArgb(CByte(196), CByte(218), CByte(212))
        allBtn.Font = New Font("Century Gothic", 9F)
        allBtn.ForeColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        allBtn.Location = New Point(565, 75)
        allBtn.Name = "allBtn"
        allBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        allBtn.Size = New Size(92, 23)
        allBtn.TabIndex = 94
        allBtn.Text = "All"
        ' 
        ' adminDiscounts
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(231), CByte(245), CByte(240))
        ClientSize = New Size(1204, 714)
        Controls.Add(allBtn)
        Controls.Add(adminDiscountText)
        Controls.Add(adminLogsText)
        Controls.Add(adminUserText)
        Controls.Add(adminDashboardText)
        Controls.Add(NotverifiedBtn)
        Controls.Add(verifiedBtn)
        Controls.Add(Guna2Panel1)
        Controls.Add(Guna2Panel5)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "adminDiscounts"
        Guna2Panel5.ResumeLayout(False)
        CType(discountTable, ComponentModel.ISupportInitialize).EndInit()
        Guna2Panel1.ResumeLayout(False)
        Guna2Panel1.PerformLayout()
        CType(verificationImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents verificationImage As PictureBox
    Friend WithEvents age As Label
    Friend WithEvents namedata As Label
    Friend WithEvents id As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents verifiedBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents NotverifiedBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents adminDiscountText As RoundedButton
    Friend WithEvents adminLogsText As RoundedButton
    Friend WithEvents adminUserText As RoundedButton
    Friend WithEvents adminDashboardText As RoundedButton
    Friend WithEvents statusBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents allBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents discountTable As Guna.UI2.WinForms.Guna2DataGridView
End Class
