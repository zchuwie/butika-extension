<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomePage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomePage))
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
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        prescriptionsPnl = New Guna.UI2.WinForms.Guna2Panel()
        Label3 = New Label()
        totalPrescLbl = New Label()
        Label1 = New Label()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Label2 = New Label()
        totalTransacLbl = New Label()
        Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Label5 = New Label()
        cartProgressLbl = New Label()
        Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Label7 = New Label()
        totalItemsLbl = New Label()
        Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Label9 = New Label()
        pendingApprovalLbl = New Label()
        dashboardPctBx = New PictureBox()
        carousel1 = New Guna.UI2.WinForms.Guna2Panel()
        carousel2 = New Guna.UI2.WinForms.Guna2Panel()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        usernameLbl = New Label()
        amountLbl = New Label()
        originalPrice = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        prescriptionsPnl.SuspendLayout()
        Guna2Panel1.SuspendLayout()
        Guna2Panel2.SuspendLayout()
        Guna2Panel3.SuspendLayout()
        Guna2Panel4.SuspendLayout()
        CType(dashboardPctBx, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(443, 28)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(80, 66)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.butika
        PictureBox2.Location = New Point(529, 35)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(265, 57)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' prescriptionsPnl
        ' 
        prescriptionsPnl.BorderRadius = 20
        prescriptionsPnl.Controls.Add(Label3)
        prescriptionsPnl.Controls.Add(totalPrescLbl)
        prescriptionsPnl.CustomizableEdges = CustomizableEdges1
        prescriptionsPnl.FillColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        prescriptionsPnl.Location = New Point(491, 185)
        prescriptionsPnl.Name = "prescriptionsPnl"
        prescriptionsPnl.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        prescriptionsPnl.Size = New Size(226, 117)
        prescriptionsPnl.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        Label3.Location = New Point(116, 29)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 54)
        Label3.TabIndex = 1
        Label3.Text = "Total" & vbCrLf & "Prescriptions" & vbCrLf & "Made"
        ' 
        ' totalPrescLbl
        ' 
        totalPrescLbl.BackColor = Color.Transparent
        totalPrescLbl.Font = New Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        totalPrescLbl.ForeColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        totalPrescLbl.Location = New Point(3, 22)
        totalPrescLbl.Name = "totalPrescLbl"
        totalPrescLbl.Size = New Size(107, 68)
        totalPrescLbl.TabIndex = 0
        totalPrescLbl.Text = "00"
        totalPrescLbl.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label1.Location = New Point(317, 95)
        Label1.Name = "Label1"
        Label1.Size = New Size(602, 29)
        Label1.TabIndex = 3
        Label1.Text = "Smarter Pharmacies, Safer Care: Automate, Streamline, Heal."
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BorderRadius = 20
        Guna2Panel1.Controls.Add(Label2)
        Guna2Panel1.Controls.Add(totalTransacLbl)
        Guna2Panel1.CustomizableEdges = CustomizableEdges3
        Guna2Panel1.FillColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Guna2Panel1.Location = New Point(27, 185)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Panel1.Size = New Size(226, 117)
        Guna2Panel1.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        Label2.Location = New Point(118, 33)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 54)
        Label2.TabIndex = 1
        Label2.Text = "Total" & vbCrLf & "Transactions" & vbCrLf & "Made"
        ' 
        ' totalTransacLbl
        ' 
        totalTransacLbl.BackColor = Color.Transparent
        totalTransacLbl.Font = New Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        totalTransacLbl.ForeColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        totalTransacLbl.Location = New Point(5, 26)
        totalTransacLbl.Name = "totalTransacLbl"
        totalTransacLbl.Size = New Size(107, 68)
        totalTransacLbl.TabIndex = 0
        totalTransacLbl.Text = "00"
        totalTransacLbl.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Guna2Panel2
        ' 
        Guna2Panel2.BorderRadius = 20
        Guna2Panel2.Controls.Add(Label5)
        Guna2Panel2.Controls.Add(cartProgressLbl)
        Guna2Panel2.CustomizableEdges = CustomizableEdges5
        Guna2Panel2.FillColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Guna2Panel2.Location = New Point(259, 185)
        Guna2Panel2.Name = "Guna2Panel2"
        Guna2Panel2.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2Panel2.Size = New Size(226, 117)
        Guna2Panel2.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        Label5.Location = New Point(119, 28)
        Label5.Name = "Label5"
        Label5.Size = New Size(68, 54)
        Label5.TabIndex = 1
        Label5.Text = "Cart" & vbCrLf & "In" & vbCrLf & "Progress"
        ' 
        ' cartProgressLbl
        ' 
        cartProgressLbl.BackColor = Color.Transparent
        cartProgressLbl.Font = New Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cartProgressLbl.ForeColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        cartProgressLbl.Location = New Point(3, 21)
        cartProgressLbl.Name = "cartProgressLbl"
        cartProgressLbl.Size = New Size(110, 68)
        cartProgressLbl.TabIndex = 0
        cartProgressLbl.Text = "00"
        cartProgressLbl.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Guna2Panel3
        ' 
        Guna2Panel3.BorderRadius = 20
        Guna2Panel3.Controls.Add(Label7)
        Guna2Panel3.Controls.Add(totalItemsLbl)
        Guna2Panel3.CustomizableEdges = CustomizableEdges7
        Guna2Panel3.FillColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Guna2Panel3.Location = New Point(955, 185)
        Guna2Panel3.Name = "Guna2Panel3"
        Guna2Panel3.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2Panel3.Size = New Size(226, 117)
        Guna2Panel3.TabIndex = 3
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        Label7.Location = New Point(119, 30)
        Label7.Name = "Label7"
        Label7.Size = New Size(59, 54)
        Label7.TabIndex = 1
        Label7.Text = "Total" & vbCrLf & "Items" & vbCrLf & "Bought"
        ' 
        ' totalItemsLbl
        ' 
        totalItemsLbl.BackColor = Color.Transparent
        totalItemsLbl.Font = New Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        totalItemsLbl.ForeColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        totalItemsLbl.Location = New Point(3, 23)
        totalItemsLbl.Name = "totalItemsLbl"
        totalItemsLbl.Size = New Size(110, 68)
        totalItemsLbl.TabIndex = 0
        totalItemsLbl.Text = "00"
        totalItemsLbl.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Guna2Panel4
        ' 
        Guna2Panel4.BorderRadius = 20
        Guna2Panel4.Controls.Add(Label9)
        Guna2Panel4.Controls.Add(pendingApprovalLbl)
        Guna2Panel4.CustomizableEdges = CustomizableEdges9
        Guna2Panel4.FillColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Guna2Panel4.Location = New Point(723, 185)
        Guna2Panel4.Name = "Guna2Panel4"
        Guna2Panel4.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        Guna2Panel4.Size = New Size(226, 117)
        Guna2Panel4.TabIndex = 3
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        Label9.Location = New Point(119, 30)
        Label9.Name = "Label9"
        Label9.Size = New Size(76, 54)
        Label9.TabIndex = 1
        Label9.Text = "Pending" & vbCrLf & "Approval" & vbCrLf & "Items"
        ' 
        ' pendingApprovalLbl
        ' 
        pendingApprovalLbl.BackColor = Color.Transparent
        pendingApprovalLbl.Font = New Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        pendingApprovalLbl.ForeColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        pendingApprovalLbl.Location = New Point(4, 23)
        pendingApprovalLbl.Name = "pendingApprovalLbl"
        pendingApprovalLbl.Size = New Size(107, 68)
        pendingApprovalLbl.TabIndex = 0
        pendingApprovalLbl.Text = "00"
        pendingApprovalLbl.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' dashboardPctBx
        ' 
        dashboardPctBx.Image = My.Resources.Resources.welcomehere
        dashboardPctBx.Location = New Point(188, 331)
        dashboardPctBx.Name = "dashboardPctBx"
        dashboardPctBx.Size = New Size(846, 312)
        dashboardPctBx.SizeMode = PictureBoxSizeMode.StretchImage
        dashboardPctBx.TabIndex = 4
        dashboardPctBx.TabStop = False
        ' 
        ' carousel1
        ' 
        carousel1.BorderRadius = 10
        carousel1.Cursor = Cursors.Hand
        carousel1.CustomizableEdges = CustomizableEdges11
        carousel1.FillColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        carousel1.Location = New Point(569, 649)
        carousel1.Name = "carousel1"
        carousel1.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        carousel1.Size = New Size(57, 8)
        carousel1.TabIndex = 5
        ' 
        ' carousel2
        ' 
        carousel2.BorderRadius = 10
        carousel2.Cursor = Cursors.Hand
        carousel2.CustomizableEdges = CustomizableEdges13
        carousel2.FillColor = Color.Silver
        carousel2.Location = New Point(632, 649)
        carousel2.Name = "carousel2"
        carousel2.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        carousel2.Size = New Size(57, 8)
        carousel2.TabIndex = 6
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.account_icon
        PictureBox3.Location = New Point(28, 28)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(31, 32)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 13
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.dtransactions_icon1
        PictureBox4.Location = New Point(1003, 28)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(31, 32)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 14
        PictureBox4.TabStop = False
        ' 
        ' usernameLbl
        ' 
        usernameLbl.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        usernameLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        usernameLbl.Location = New Point(60, 28)
        usernameLbl.Name = "usernameLbl"
        usernameLbl.Size = New Size(372, 32)
        usernameLbl.TabIndex = 15
        usernameLbl.Text = "Hello, user!"
        usernameLbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' amountLbl
        ' 
        amountLbl.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        amountLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        amountLbl.Location = New Point(1040, 28)
        amountLbl.Name = "amountLbl"
        amountLbl.Size = New Size(144, 32)
        amountLbl.TabIndex = 16
        amountLbl.Text = "PHP 0.00"
        amountLbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' originalPrice
        ' 
        originalPrice.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold Or FontStyle.Strikeout, GraphicsUnit.Point, CByte(0))
        originalPrice.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        originalPrice.Location = New Point(1040, 60)
        originalPrice.Name = "originalPrice"
        originalPrice.Size = New Size(144, 32)
        originalPrice.TabIndex = 17
        originalPrice.Text = "PHP 0.00"
        originalPrice.TextAlign = ContentAlignment.MiddleLeft
        originalPrice.Visible = False
        ' 
        ' HomePage
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        ClientSize = New Size(1210, 720)
        Controls.Add(originalPrice)
        Controls.Add(amountLbl)
        Controls.Add(usernameLbl)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(carousel2)
        Controls.Add(carousel1)
        Controls.Add(dashboardPctBx)
        Controls.Add(Guna2Panel4)
        Controls.Add(Guna2Panel3)
        Controls.Add(Guna2Panel2)
        Controls.Add(Guna2Panel1)
        Controls.Add(Label1)
        Controls.Add(prescriptionsPnl)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Name = "HomePage"
        Text = "HomePage"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        prescriptionsPnl.ResumeLayout(False)
        prescriptionsPnl.PerformLayout()
        Guna2Panel1.ResumeLayout(False)
        Guna2Panel1.PerformLayout()
        Guna2Panel2.ResumeLayout(False)
        Guna2Panel2.PerformLayout()
        Guna2Panel3.ResumeLayout(False)
        Guna2Panel3.PerformLayout()
        Guna2Panel4.ResumeLayout(False)
        Guna2Panel4.PerformLayout()
        CType(dashboardPctBx, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents prescriptionsPnl As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents totalPrescLbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents totalTransacLbl As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents cartProgressLbl As Label
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents totalItemsLbl As Label
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents pendingApprovalLbl As Label
    Friend WithEvents dashboardPctBx As PictureBox
    Friend WithEvents carousel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents carousel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents usernameLbl As Label
    Friend WithEvents amountLbl As Label
    Friend WithEvents originalPrice As Label
End Class
