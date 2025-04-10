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
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges17 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges18 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges19 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges20 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Label2 = New Label()
        Label1 = New Label()
        Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        userAccTable = New Guna.UI2.WinForms.Guna2DataGridView()
        Guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        adminDiscountText = New RoundedButton()
        adminLogsText = New RoundedButton()
        adminUserText = New RoundedButton()
        adminDashboardText = New RoundedButton()
        Guna2Panel5.SuspendLayout()
        CType(userAccTable, ComponentModel.ISupportInitialize).BeginInit()
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
        Guna2Panel5.Controls.Add(userAccTable)
        Guna2Panel5.CustomizableEdges = CustomizableEdges11
        Guna2Panel5.FillColor = Color.FromArgb(CByte(196), CByte(218), CByte(212))
        Guna2Panel5.Location = New Point(40, 125)
        Guna2Panel5.Name = "Guna2Panel5"
        Guna2Panel5.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        Guna2Panel5.Size = New Size(1112, 542)
        Guna2Panel5.TabIndex = 52
        ' 
        ' userAccTable
        ' 
        userAccTable.AllowUserToAddRows = False
        userAccTable.AllowUserToDeleteRows = False
        userAccTable.AllowUserToResizeColumns = False
        userAccTable.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = Color.White
        userAccTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        userAccTable.BackgroundColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        DataGridViewCellStyle5.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        DataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        userAccTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        userAccTable.ColumnHeadersHeight = 20
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.White
        DataGridViewCellStyle6.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = Color.FromArgb(CByte(110), CByte(126), CByte(124))
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(CByte(110), CByte(126), CByte(124))
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        userAccTable.DefaultCellStyle = DataGridViewCellStyle6
        userAccTable.GridColor = Color.FromArgb(CByte(110), CByte(126), CByte(124))
        userAccTable.Location = New Point(21, 19)
        userAccTable.Name = "userAccTable"
        userAccTable.RowHeadersVisible = False
        userAccTable.Size = New Size(1071, 499)
        userAccTable.TabIndex = 4
        userAccTable.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        userAccTable.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        userAccTable.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        userAccTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        userAccTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        userAccTable.ThemeStyle.BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        userAccTable.ThemeStyle.GridColor = Color.FromArgb(CByte(110), CByte(126), CByte(124))
        userAccTable.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        userAccTable.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        userAccTable.ThemeStyle.HeaderStyle.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        userAccTable.ThemeStyle.HeaderStyle.ForeColor = Color.White
        userAccTable.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        userAccTable.ThemeStyle.HeaderStyle.Height = 20
        userAccTable.ThemeStyle.ReadOnly = False
        userAccTable.ThemeStyle.RowsStyle.BackColor = Color.White
        userAccTable.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        userAccTable.ThemeStyle.RowsStyle.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        userAccTable.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        userAccTable.ThemeStyle.RowsStyle.Height = 25
        userAccTable.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        userAccTable.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' Guna2Button5
        ' 
        Guna2Button5.BorderColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        Guna2Button5.BorderRadius = 1
        Guna2Button5.BorderThickness = 1
        Guna2Button5.CustomizableEdges = CustomizableEdges13
        Guna2Button5.DisabledState.BorderColor = Color.DarkGray
        Guna2Button5.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button5.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button5.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button5.FillColor = Color.FromArgb(CByte(196), CByte(218), CByte(212))
        Guna2Button5.Font = New Font("Century Gothic", 9F)
        Guna2Button5.ForeColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        Guna2Button5.Location = New Point(1038, 86)
        Guna2Button5.Name = "Guna2Button5"
        Guna2Button5.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        Guna2Button5.Size = New Size(114, 23)
        Guna2Button5.TabIndex = 87
        Guna2Button5.Text = "Sort by Date"
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.BorderColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        Guna2Button1.BorderRadius = 1
        Guna2Button1.BorderThickness = 1
        Guna2Button1.CustomizableEdges = CustomizableEdges15
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.FromArgb(CByte(196), CByte(218), CByte(212))
        Guna2Button1.Font = New Font("Century Gothic", 9F)
        Guna2Button1.ForeColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        Guna2Button1.Location = New Point(37, 86)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        Guna2Button1.Size = New Size(83, 23)
        Guna2Button1.TabIndex = 88
        Guna2Button1.Text = "All Logs"
        ' 
        ' Guna2Button2
        ' 
        Guna2Button2.BorderColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        Guna2Button2.BorderRadius = 1
        Guna2Button2.BorderThickness = 1
        Guna2Button2.CustomizableEdges = CustomizableEdges17
        Guna2Button2.DisabledState.BorderColor = Color.DarkGray
        Guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button2.FillColor = Color.FromArgb(CByte(196), CByte(218), CByte(212))
        Guna2Button2.Font = New Font("Century Gothic", 9F)
        Guna2Button2.ForeColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        Guna2Button2.Location = New Point(126, 86)
        Guna2Button2.Name = "Guna2Button2"
        Guna2Button2.ShadowDecoration.CustomizableEdges = CustomizableEdges18
        Guna2Button2.Size = New Size(120, 23)
        Guna2Button2.TabIndex = 89
        Guna2Button2.Text = "Customer Logs"
        ' 
        ' Guna2Button3
        ' 
        Guna2Button3.BorderColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        Guna2Button3.BorderRadius = 1
        Guna2Button3.BorderThickness = 1
        Guna2Button3.CustomizableEdges = CustomizableEdges19
        Guna2Button3.DisabledState.BorderColor = Color.DarkGray
        Guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button3.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button3.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button3.FillColor = Color.FromArgb(CByte(196), CByte(218), CByte(212))
        Guna2Button3.Font = New Font("Century Gothic", 9F)
        Guna2Button3.ForeColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        Guna2Button3.Location = New Point(252, 86)
        Guna2Button3.Name = "Guna2Button3"
        Guna2Button3.ShadowDecoration.CustomizableEdges = CustomizableEdges20
        Guna2Button3.Size = New Size(101, 23)
        Guna2Button3.TabIndex = 90
        Guna2Button3.Text = "Admin Logs"
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
        ' adminLogs
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(231), CByte(245), CByte(240))
        ClientSize = New Size(1204, 714)
        Controls.Add(adminDiscountText)
        Controls.Add(adminLogsText)
        Controls.Add(adminUserText)
        Controls.Add(adminDashboardText)
        Controls.Add(Guna2Button3)
        Controls.Add(Guna2Button2)
        Controls.Add(Guna2Button1)
        Controls.Add(Guna2Button5)
        Controls.Add(Guna2Panel5)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "adminLogs"
        Text = "adminLogs"
        Guna2Panel5.ResumeLayout(False)
        CType(userAccTable, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents userAccTable As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Button5 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents adminDiscountText As RoundedButton
    Friend WithEvents adminLogsText As RoundedButton
    Friend WithEvents adminUserText As RoundedButton
    Friend WithEvents adminDashboardText As RoundedButton
End Class
