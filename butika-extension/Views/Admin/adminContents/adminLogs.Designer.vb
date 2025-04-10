<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminLogs
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
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
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Label2 = New Label()
        Label1 = New Label()
        Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        userLogsTable = New Guna.UI2.WinForms.Guna2DataGridView()
        SortingBtn = New Guna.UI2.WinForms.Guna2Button()
        showAll_Logs = New Guna.UI2.WinForms.Guna2Button()
        customer_Logs = New Guna.UI2.WinForms.Guna2Button()
        admin_Logs = New Guna.UI2.WinForms.Guna2Button()
        adminDiscountText = New RoundedButton()
        adminLogsText = New RoundedButton()
        adminUserText = New RoundedButton()
        adminDashboardText = New RoundedButton()
        inventory_Logs = New Guna.UI2.WinForms.Guna2Button()
        pharmacist_Logs = New Guna.UI2.WinForms.Guna2Button()
        Guna2Panel5.SuspendLayout()
        CType(userLogsTable, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        Label2.Location = New Point(40, 48)
        Label2.Name = "Label2"
        Label2.Size = New Size(126, 16)
        Label2.TabIndex = 51
        Label2.Text = "View all activities here"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        Label1.Location = New Point(37, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(95, 23)
        Label1.TabIndex = 50
        Label1.Text = "User Logs"
        ' 
        ' Guna2Panel5
        ' 
        Guna2Panel5.BorderColor = Color.FromArgb(CByte(110), CByte(126), CByte(124))
        Guna2Panel5.BorderRadius = 20
        Guna2Panel5.BorderThickness = 1
        Guna2Panel5.Controls.Add(userLogsTable)
        Guna2Panel5.CustomizableEdges = CustomizableEdges1
        Guna2Panel5.FillColor = Color.FromArgb(CByte(196), CByte(218), CByte(212))
        Guna2Panel5.Location = New Point(40, 125)
        Guna2Panel5.Name = "Guna2Panel5"
        Guna2Panel5.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Panel5.Size = New Size(1112, 542)
        Guna2Panel5.TabIndex = 52
        ' 
        ' userLogsTable
        ' 
        userLogsTable.AllowUserToAddRows = False
        userLogsTable.AllowUserToDeleteRows = False
        userLogsTable.AllowUserToResizeColumns = False
        userLogsTable.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        userLogsTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        userLogsTable.BackgroundColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        DataGridViewCellStyle2.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        userLogsTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        userLogsTable.ColumnHeadersHeight = 20
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(110), CByte(126), CByte(124))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(110), CByte(126), CByte(124))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        userLogsTable.DefaultCellStyle = DataGridViewCellStyle3
        userLogsTable.GridColor = Color.FromArgb(CByte(110), CByte(126), CByte(124))
        userLogsTable.Location = New Point(21, 19)
        userLogsTable.Name = "userLogsTable"
        userLogsTable.RowHeadersVisible = False
        userLogsTable.Size = New Size(1071, 499)
        userLogsTable.TabIndex = 4
        userLogsTable.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        userLogsTable.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        userLogsTable.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        userLogsTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        userLogsTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        userLogsTable.ThemeStyle.BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        userLogsTable.ThemeStyle.GridColor = Color.FromArgb(CByte(110), CByte(126), CByte(124))
        userLogsTable.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        userLogsTable.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        userLogsTable.ThemeStyle.HeaderStyle.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        userLogsTable.ThemeStyle.HeaderStyle.ForeColor = Color.White
        userLogsTable.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        userLogsTable.ThemeStyle.HeaderStyle.Height = 20
        userLogsTable.ThemeStyle.ReadOnly = False
        userLogsTable.ThemeStyle.RowsStyle.BackColor = Color.White
        userLogsTable.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        userLogsTable.ThemeStyle.RowsStyle.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        userLogsTable.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        userLogsTable.ThemeStyle.RowsStyle.Height = 25
        userLogsTable.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        userLogsTable.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' SortingBtn
        ' 
        SortingBtn.BorderColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        SortingBtn.BorderRadius = 1
        SortingBtn.BorderThickness = 1
        SortingBtn.CustomizableEdges = CustomizableEdges3
        SortingBtn.DisabledState.BorderColor = Color.DarkGray
        SortingBtn.DisabledState.CustomBorderColor = Color.DarkGray
        SortingBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        SortingBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        SortingBtn.FillColor = Color.FromArgb(CByte(196), CByte(218), CByte(212))
        SortingBtn.Font = New Font("Century Gothic", 9F)
        SortingBtn.ForeColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        SortingBtn.Location = New Point(1038, 86)
        SortingBtn.Name = "SortingBtn"
        SortingBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        SortingBtn.Size = New Size(114, 23)
        SortingBtn.TabIndex = 87
        SortingBtn.Text = "Sort by Date"
        ' 
        ' showAll_Logs
        ' 
        showAll_Logs.BorderColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        showAll_Logs.BorderRadius = 1
        showAll_Logs.BorderThickness = 1
        showAll_Logs.CustomizableEdges = CustomizableEdges5
        showAll_Logs.DisabledState.BorderColor = Color.DarkGray
        showAll_Logs.DisabledState.CustomBorderColor = Color.DarkGray
        showAll_Logs.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        showAll_Logs.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        showAll_Logs.FillColor = Color.FromArgb(CByte(196), CByte(218), CByte(212))
        showAll_Logs.Font = New Font("Century Gothic", 9F)
        showAll_Logs.ForeColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        showAll_Logs.Location = New Point(37, 86)
        showAll_Logs.Name = "showAll_Logs"
        showAll_Logs.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        showAll_Logs.Size = New Size(83, 23)
        showAll_Logs.TabIndex = 88
        showAll_Logs.Text = "All Logs"
        ' 
        ' customer_Logs
        ' 
        customer_Logs.BorderColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        customer_Logs.BorderRadius = 1
        customer_Logs.BorderThickness = 1
        customer_Logs.CustomizableEdges = CustomizableEdges7
        customer_Logs.DisabledState.BorderColor = Color.DarkGray
        customer_Logs.DisabledState.CustomBorderColor = Color.DarkGray
        customer_Logs.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        customer_Logs.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        customer_Logs.FillColor = Color.FromArgb(CByte(196), CByte(218), CByte(212))
        customer_Logs.Font = New Font("Century Gothic", 9F)
        customer_Logs.ForeColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        customer_Logs.Location = New Point(126, 86)
        customer_Logs.Name = "customer_Logs"
        customer_Logs.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        customer_Logs.Size = New Size(120, 23)
        customer_Logs.TabIndex = 89
        customer_Logs.Text = "Customer Logs"
        ' 
        ' admin_Logs
        ' 
        admin_Logs.BorderColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        admin_Logs.BorderRadius = 1
        admin_Logs.BorderThickness = 1
        admin_Logs.CustomizableEdges = CustomizableEdges9
        admin_Logs.DisabledState.BorderColor = Color.DarkGray
        admin_Logs.DisabledState.CustomBorderColor = Color.DarkGray
        admin_Logs.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        admin_Logs.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        admin_Logs.FillColor = Color.FromArgb(CByte(196), CByte(218), CByte(212))
        admin_Logs.Font = New Font("Century Gothic", 9F)
        admin_Logs.ForeColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        admin_Logs.Location = New Point(252, 86)
        admin_Logs.Name = "admin_Logs"
        admin_Logs.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        admin_Logs.Size = New Size(101, 23)
        admin_Logs.TabIndex = 90
        admin_Logs.Text = "Admin Logs"
        ' 
        ' adminDiscountText
        ' 
        adminDiscountText.BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        adminDiscountText.CornerRadius = 60
        adminDiscountText.FlatStyle = FlatStyle.Flat
        adminDiscountText.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        adminDiscountText.ForeColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        adminDiscountText.Location = New Point(-6, 256)
        adminDiscountText.Name = "adminDiscountText"
        adminDiscountText.Size = New Size(152, 64)
        adminDiscountText.TabIndex = 97
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
        adminLogsText.Location = New Point(-4, 192)
        adminLogsText.Name = "adminLogsText"
        adminLogsText.Size = New Size(103, 64)
        adminLogsText.TabIndex = 96
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
        adminUserText.Location = New Point(-7, 128)
        adminUserText.Name = "adminUserText"
        adminUserText.Size = New Size(138, 64)
        adminUserText.TabIndex = 95
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
        adminDashboardText.Location = New Point(-2, 64)
        adminDashboardText.Name = "adminDashboardText"
        adminDashboardText.Size = New Size(109, 64)
        adminDashboardText.TabIndex = 94
        adminDashboardText.Text = "Dashboard"
        adminDashboardText.UseVisualStyleBackColor = False
        adminDashboardText.Visible = False
        ' 
        ' inventory_Logs
        ' 
        inventory_Logs.BorderColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        inventory_Logs.BorderRadius = 1
        inventory_Logs.BorderThickness = 1
        inventory_Logs.CustomizableEdges = CustomizableEdges11
        inventory_Logs.DisabledState.BorderColor = Color.DarkGray
        inventory_Logs.DisabledState.CustomBorderColor = Color.DarkGray
        inventory_Logs.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        inventory_Logs.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        inventory_Logs.FillColor = Color.FromArgb(CByte(196), CByte(218), CByte(212))
        inventory_Logs.Font = New Font("Century Gothic", 9F)
        inventory_Logs.ForeColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        inventory_Logs.Location = New Point(496, 86)
        inventory_Logs.Name = "inventory_Logs"
        inventory_Logs.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        inventory_Logs.Size = New Size(192, 23)
        inventory_Logs.TabIndex = 98
        inventory_Logs.Text = "Inverntory Custodian Logs"
        ' 
        ' pharmacist_Logs
        ' 
        pharmacist_Logs.BorderColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        pharmacist_Logs.BorderRadius = 1
        pharmacist_Logs.BorderThickness = 1
        pharmacist_Logs.CustomizableEdges = CustomizableEdges13
        pharmacist_Logs.DisabledState.BorderColor = Color.DarkGray
        pharmacist_Logs.DisabledState.CustomBorderColor = Color.DarkGray
        pharmacist_Logs.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        pharmacist_Logs.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        pharmacist_Logs.FillColor = Color.FromArgb(CByte(196), CByte(218), CByte(212))
        pharmacist_Logs.Font = New Font("Century Gothic", 9F)
        pharmacist_Logs.ForeColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        pharmacist_Logs.Location = New Point(359, 86)
        pharmacist_Logs.Name = "pharmacist_Logs"
        pharmacist_Logs.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        pharmacist_Logs.Size = New Size(131, 23)
        pharmacist_Logs.TabIndex = 99
        pharmacist_Logs.Text = "Pharmacist Logs"
        ' 
        ' adminLogs
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(231), CByte(245), CByte(240))
        ClientSize = New Size(1204, 714)
        Controls.Add(pharmacist_Logs)
        Controls.Add(inventory_Logs)
        Controls.Add(adminDiscountText)
        Controls.Add(adminLogsText)
        Controls.Add(adminUserText)
        Controls.Add(adminDashboardText)
        Controls.Add(admin_Logs)
        Controls.Add(customer_Logs)
        Controls.Add(showAll_Logs)
        Controls.Add(SortingBtn)
        Controls.Add(Guna2Panel5)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "adminLogs"
        Text = "adminLogs"
        Guna2Panel5.ResumeLayout(False)
        CType(userLogsTable, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents userLogsTable As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents SortingBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents showAll_Logs As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents customer_Logs As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents admin_Logs As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents adminDiscountText As RoundedButton
    Friend WithEvents adminLogsText As RoundedButton
    Friend WithEvents adminUserText As RoundedButton
    Friend WithEvents adminDashboardText As RoundedButton
    Friend WithEvents inventory_Logs As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pharmacist_Logs As Guna.UI2.WinForms.Guna2Button
End Class
