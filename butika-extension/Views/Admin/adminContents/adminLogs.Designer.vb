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
        Label2 = New Label()
        Label1 = New Label()
        Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        userAccTable = New Guna.UI2.WinForms.Guna2DataGridView()
        Guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
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
        Guna2Panel5.CustomizableEdges = CustomizableEdges1
        Guna2Panel5.FillColor = Color.FromArgb(CByte(196), CByte(218), CByte(212))
        Guna2Panel5.Location = New Point(40, 125)
        Guna2Panel5.Name = "Guna2Panel5"
        Guna2Panel5.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Panel5.Size = New Size(1112, 542)
        Guna2Panel5.TabIndex = 52
        ' 
        ' userAccTable
        ' 
        userAccTable.AllowUserToAddRows = False
        userAccTable.AllowUserToDeleteRows = False
        userAccTable.AllowUserToResizeColumns = False
        userAccTable.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        userAccTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        userAccTable.BackgroundColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        DataGridViewCellStyle2.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        userAccTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        userAccTable.ColumnHeadersHeight = 20
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(110), CByte(126), CByte(124))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(110), CByte(126), CByte(124))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        userAccTable.DefaultCellStyle = DataGridViewCellStyle3
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
        Guna2Button5.CustomizableEdges = CustomizableEdges3
        Guna2Button5.DisabledState.BorderColor = Color.DarkGray
        Guna2Button5.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button5.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button5.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button5.FillColor = Color.FromArgb(CByte(196), CByte(218), CByte(212))
        Guna2Button5.Font = New Font("Century Gothic", 9F)
        Guna2Button5.ForeColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        Guna2Button5.Location = New Point(1038, 86)
        Guna2Button5.Name = "Guna2Button5"
        Guna2Button5.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Button5.Size = New Size(114, 23)
        Guna2Button5.TabIndex = 87
        Guna2Button5.Text = "Sort by Date"
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.BorderColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        Guna2Button1.BorderRadius = 1
        Guna2Button1.BorderThickness = 1
        Guna2Button1.CustomizableEdges = CustomizableEdges5
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.FromArgb(CByte(196), CByte(218), CByte(212))
        Guna2Button1.Font = New Font("Century Gothic", 9F)
        Guna2Button1.ForeColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        Guna2Button1.Location = New Point(37, 86)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2Button1.Size = New Size(83, 23)
        Guna2Button1.TabIndex = 88
        Guna2Button1.Text = "All Logs"
        ' 
        ' Guna2Button2
        ' 
        Guna2Button2.BorderColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        Guna2Button2.BorderRadius = 1
        Guna2Button2.BorderThickness = 1
        Guna2Button2.CustomizableEdges = CustomizableEdges7
        Guna2Button2.DisabledState.BorderColor = Color.DarkGray
        Guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button2.FillColor = Color.FromArgb(CByte(196), CByte(218), CByte(212))
        Guna2Button2.Font = New Font("Century Gothic", 9F)
        Guna2Button2.ForeColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        Guna2Button2.Location = New Point(126, 86)
        Guna2Button2.Name = "Guna2Button2"
        Guna2Button2.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2Button2.Size = New Size(120, 23)
        Guna2Button2.TabIndex = 89
        Guna2Button2.Text = "Customer Logs"
        ' 
        ' Guna2Button3
        ' 
        Guna2Button3.BorderColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        Guna2Button3.BorderRadius = 1
        Guna2Button3.BorderThickness = 1
        Guna2Button3.CustomizableEdges = CustomizableEdges9
        Guna2Button3.DisabledState.BorderColor = Color.DarkGray
        Guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button3.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button3.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button3.FillColor = Color.FromArgb(CByte(196), CByte(218), CByte(212))
        Guna2Button3.Font = New Font("Century Gothic", 9F)
        Guna2Button3.ForeColor = Color.FromArgb(CByte(13), CByte(40), CByte(36))
        Guna2Button3.Location = New Point(252, 86)
        Guna2Button3.Name = "Guna2Button3"
        Guna2Button3.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        Guna2Button3.Size = New Size(101, 23)
        Guna2Button3.TabIndex = 90
        Guna2Button3.Text = "Admin Logs"
        ' 
        ' adminLogs
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(231), CByte(245), CByte(240))
        ClientSize = New Size(1204, 714)
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
End Class
