<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pharmaPaymentSummary
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pharmaPaymentSummary))
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        totalamount = New Label()
        transactionid = New Label()
        username = New Label()
        Panel1 = New Panel()
        closeBtn = New Guna.UI2.WinForms.Guna2Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label1.Location = New Point(319, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(231, 28)
        Label1.TabIndex = 0
        Label1.Text = "Payment Summary"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 14.25F)
        Label2.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label2.Location = New Point(49, 101)
        Label2.Name = "Label2"
        Label2.Size = New Size(144, 22)
        Label2.TabIndex = 1
        Label2.Text = "Transaction ID:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 14.25F)
        Label3.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label3.Location = New Point(526, 101)
        Label3.Name = "Label3"
        Label3.Size = New Size(106, 22)
        Label3.TabIndex = 2
        Label3.Text = "Username:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label4.Location = New Point(49, 455)
        Label4.Name = "Label4"
        Label4.Size = New Size(136, 23)
        Label4.TabIndex = 3
        Label4.Text = "Total Amount:"
        ' 
        ' totalamount
        ' 
        totalamount.AutoSize = True
        totalamount.Font = New Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        totalamount.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        totalamount.Location = New Point(671, 442)
        totalamount.Name = "totalamount"
        totalamount.Size = New Size(125, 36)
        totalamount.TabIndex = 4
        totalamount.Text = "Amount"
        ' 
        ' transactionid
        ' 
        transactionid.AutoSize = True
        transactionid.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold)
        transactionid.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        transactionid.Location = New Point(212, 101)
        transactionid.Name = "transactionid"
        transactionid.Size = New Size(104, 23)
        transactionid.TabIndex = 5
        transactionid.Text = "id number"
        ' 
        ' username
        ' 
        username.AutoSize = True
        username.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold)
        username.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        username.Location = New Point(656, 101)
        username.Name = "username"
        username.Size = New Size(101, 23)
        username.TabIndex = 6
        username.Text = "username"
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(168, 144)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(498, 268)
        Panel1.TabIndex = 7
        ' 
        ' closeBtn
        ' 
        closeBtn.CustomizableEdges = CustomizableEdges1
        closeBtn.DisabledState.BorderColor = Color.DarkGray
        closeBtn.DisabledState.CustomBorderColor = Color.DarkGray
        closeBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        closeBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        closeBtn.FillColor = Color.Transparent
        closeBtn.Font = New Font("Segoe UI", 9F)
        closeBtn.ForeColor = Color.White
        closeBtn.HoverState.FillColor = Color.Red
        closeBtn.Image = CType(resources.GetObject("closeBtn.Image"), Image)
        closeBtn.Location = New Point(807, 15)
        closeBtn.Name = "closeBtn"
        closeBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        closeBtn.Size = New Size(35, 35)
        closeBtn.TabIndex = 8
        ' 
        ' pharmaPaymentSummary
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        Controls.Add(closeBtn)
        Controls.Add(Panel1)
        Controls.Add(username)
        Controls.Add(transactionid)
        Controls.Add(totalamount)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "pharmaPaymentSummary"
        Size = New Size(858, 507)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents totalamount As Label
    Friend WithEvents transactionid As Label
    Friend WithEvents username As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents closeBtn As Guna.UI2.WinForms.Guna2Button

End Class
