<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pharmaTransactions
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
        Dim CustomizableEdges21 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pharmaTransactions))
        Dim CustomizableEdges22 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges23 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges24 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges25 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges26 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges27 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges28 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges29 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges30 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        transactionLbl = New Label()
        useridSearch = New Guna.UI2.WinForms.Guna2TextBox()
        transacidSearch = New Guna.UI2.WinForms.Guna2TextBox()
        usernameSearch = New Guna.UI2.WinForms.Guna2TextBox()
        infoIcon = New PictureBox()
        allorderLbl = New Label()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        infoManagerIcon = New ToolTip(components)
        flpTransaction = New FlowLayoutPanel()
        CType(infoIcon, ComponentModel.ISupportInitialize).BeginInit()
        Guna2Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' transactionLbl
        ' 
        transactionLbl.AutoSize = True
        transactionLbl.Font = New Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        transactionLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        transactionLbl.Location = New Point(29, 19)
        transactionLbl.Name = "transactionLbl"
        transactionLbl.Size = New Size(253, 38)
        transactionLbl.TabIndex = 0
        transactionLbl.Text = "TRANSACTIONS"
        ' 
        ' useridSearch
        ' 
        useridSearch.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        useridSearch.BorderRadius = 4
        useridSearch.BorderThickness = 2
        useridSearch.CustomizableEdges = CustomizableEdges21
        useridSearch.DefaultText = ""
        useridSearch.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        useridSearch.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        useridSearch.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        useridSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        useridSearch.FillColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        useridSearch.FocusedState.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        useridSearch.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        useridSearch.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        useridSearch.HoverState.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        useridSearch.IconRight = CType(resources.GetObject("useridSearch.IconRight"), Image)
        useridSearch.Location = New Point(654, 100)
        useridSearch.Name = "useridSearch"
        useridSearch.PlaceholderForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        useridSearch.PlaceholderText = "User ID"
        useridSearch.SelectedText = ""
        useridSearch.ShadowDecoration.CustomizableEdges = CustomizableEdges22
        useridSearch.Size = New Size(91, 34)
        useridSearch.TabIndex = 1
        ' 
        ' transacidSearch
        ' 
        transacidSearch.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        transacidSearch.BorderRadius = 4
        transacidSearch.BorderThickness = 2
        transacidSearch.CustomizableEdges = CustomizableEdges23
        transacidSearch.DefaultText = ""
        transacidSearch.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        transacidSearch.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        transacidSearch.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        transacidSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        transacidSearch.FillColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        transacidSearch.FocusedState.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        transacidSearch.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        transacidSearch.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        transacidSearch.HoverState.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        transacidSearch.IconRight = CType(resources.GetObject("transacidSearch.IconRight"), Image)
        transacidSearch.Location = New Point(751, 100)
        transacidSearch.Name = "transacidSearch"
        transacidSearch.PlaceholderForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        transacidSearch.PlaceholderText = "Transaction ID"
        transacidSearch.SelectedText = ""
        transacidSearch.ShadowDecoration.CustomizableEdges = CustomizableEdges24
        transacidSearch.Size = New Size(137, 34)
        transacidSearch.TabIndex = 2
        ' 
        ' usernameSearch
        ' 
        usernameSearch.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        usernameSearch.BorderRadius = 4
        usernameSearch.BorderThickness = 2
        usernameSearch.CustomizableEdges = CustomizableEdges25
        usernameSearch.DefaultText = ""
        usernameSearch.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        usernameSearch.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        usernameSearch.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        usernameSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        usernameSearch.FillColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        usernameSearch.FocusedState.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        usernameSearch.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        usernameSearch.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        usernameSearch.HoverState.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        usernameSearch.IconRight = CType(resources.GetObject("usernameSearch.IconRight"), Image)
        usernameSearch.Location = New Point(894, 100)
        usernameSearch.Name = "usernameSearch"
        usernameSearch.PlaceholderForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        usernameSearch.PlaceholderText = "Username"
        usernameSearch.SelectedText = ""
        usernameSearch.ShadowDecoration.CustomizableEdges = CustomizableEdges26
        usernameSearch.Size = New Size(114, 34)
        usernameSearch.TabIndex = 3
        ' 
        ' infoIcon
        ' 
        infoIcon.Cursor = Cursors.Hand
        infoIcon.Image = CType(resources.GetObject("infoIcon.Image"), Image)
        infoIcon.Location = New Point(988, 37)
        infoIcon.Name = "infoIcon"
        infoIcon.Size = New Size(20, 20)
        infoIcon.SizeMode = PictureBoxSizeMode.CenterImage
        infoIcon.TabIndex = 5
        infoIcon.TabStop = False
        ' 
        ' allorderLbl
        ' 
        allorderLbl.AutoSize = True
        allorderLbl.Cursor = Cursors.Hand
        allorderLbl.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        allorderLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        allorderLbl.Location = New Point(36, 100)
        allorderLbl.Name = "allorderLbl"
        allorderLbl.Size = New Size(77, 19)
        allorderLbl.TabIndex = 7
        allorderLbl.Text = "All Order"
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.CustomizableEdges = CustomizableEdges27
        Guna2Panel1.FillColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Guna2Panel1.Location = New Point(39, 124)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges28
        Guna2Panel1.Size = New Size(70, 3)
        Guna2Panel1.TabIndex = 8
        ' 
        ' Guna2Panel2
        ' 
        Guna2Panel2.BorderRadius = 10
        Guna2Panel2.Controls.Add(Label4)
        Guna2Panel2.Controls.Add(Label3)
        Guna2Panel2.Controls.Add(Label2)
        Guna2Panel2.Controls.Add(Label1)
        Guna2Panel2.CustomizableEdges = CustomizableEdges29
        Guna2Panel2.FillColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Guna2Panel2.Location = New Point(36, 144)
        Guna2Panel2.Margin = New Padding(3, 3, 3, 0)
        Guna2Panel2.Name = "Guna2Panel2"
        Guna2Panel2.ShadowDecoration.CustomizableEdges = CustomizableEdges30
        Guna2Panel2.Size = New Size(972, 37)
        Guna2Panel2.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        Label4.Location = New Point(783, 10)
        Label4.Name = "Label4"
        Label4.Size = New Size(148, 18)
        Label4.TabIndex = 3
        Label4.Text = "Date of Transaction"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        Label3.Location = New Point(538, 10)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 18)
        Label3.TabIndex = 2
        Label3.Text = "Transaction ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        Label2.Location = New Point(267, 10)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 18)
        Label2.TabIndex = 1
        Label2.Text = "Username"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        Label1.Location = New Point(26, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 18)
        Label1.TabIndex = 0
        Label1.Text = "User ID"
        ' 
        ' Guna2Separator1
        ' 
        Guna2Separator1.Location = New Point(12, 73)
        Guna2Separator1.Name = "Guna2Separator1"
        Guna2Separator1.Size = New Size(1019, 10)
        Guna2Separator1.TabIndex = 11
        ' 
        ' flpTransaction
        ' 
        flpTransaction.AutoScroll = True
        flpTransaction.Location = New Point(36, 181)
        flpTransaction.Margin = New Padding(3, 0, 3, 3)
        flpTransaction.Name = "flpTransaction"
        flpTransaction.Size = New Size(972, 527)
        flpTransaction.TabIndex = 0
        ' 
        ' pharmaTransactions
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        AutoSize = True
        BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        ClientSize = New Size(1043, 720)
        Controls.Add(flpTransaction)
        Controls.Add(Guna2Separator1)
        Controls.Add(Guna2Panel2)
        Controls.Add(Guna2Panel1)
        Controls.Add(allorderLbl)
        Controls.Add(infoIcon)
        Controls.Add(usernameSearch)
        Controls.Add(transacidSearch)
        Controls.Add(useridSearch)
        Controls.Add(transactionLbl)
        FormBorderStyle = FormBorderStyle.None
        Name = "pharmaTransactions"
        Text = "pharmaTransactions"
        CType(infoIcon, ComponentModel.ISupportInitialize).EndInit()
        Guna2Panel2.ResumeLayout(False)
        Guna2Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents transactionLbl As Label
    Friend WithEvents useridSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents transacidSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents usernameSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents infoIcon As PictureBox
    Friend WithEvents allorderLbl As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents infoManagerIcon As ToolTip
    Friend WithEvents flpTransaction As FlowLayoutPanel
End Class
