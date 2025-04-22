<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pharmaViewTransaction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pharmaViewTransaction))
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        closeBtn = New Guna.UI2.WinForms.Guna2Button()
        username = New Label()
        transactionid = New Label()
        totalamount = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        flpItems = New FlowLayoutPanel()
        SuspendLayout()
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
        closeBtn.Location = New Point(809, 16)
        closeBtn.Name = "closeBtn"
        closeBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        closeBtn.Size = New Size(35, 35)
        closeBtn.TabIndex = 17
        ' 
        ' username
        ' 
        username.AutoSize = True
        username.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold)
        username.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        username.Location = New Point(658, 102)
        username.Name = "username"
        username.Size = New Size(101, 23)
        username.TabIndex = 15
        username.Text = "username"
        ' 
        ' transactionid
        ' 
        transactionid.AutoSize = True
        transactionid.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold)
        transactionid.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        transactionid.Location = New Point(214, 102)
        transactionid.Name = "transactionid"
        transactionid.Size = New Size(104, 23)
        transactionid.TabIndex = 14
        transactionid.Text = "id number"
        ' 
        ' totalamount
        ' 
        totalamount.AutoSize = True
        totalamount.Font = New Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        totalamount.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        totalamount.Location = New Point(673, 443)
        totalamount.Name = "totalamount"
        totalamount.Size = New Size(125, 36)
        totalamount.TabIndex = 13
        totalamount.Text = "Amount"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label4.Location = New Point(51, 456)
        Label4.Name = "Label4"
        Label4.Size = New Size(136, 23)
        Label4.TabIndex = 12
        Label4.Text = "Total Amount:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 14.25F)
        Label3.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label3.Location = New Point(528, 102)
        Label3.Name = "Label3"
        Label3.Size = New Size(106, 22)
        Label3.TabIndex = 11
        Label3.Text = "Username:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 14.25F)
        Label2.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label2.Location = New Point(51, 102)
        Label2.Name = "Label2"
        Label2.Size = New Size(144, 22)
        Label2.TabIndex = 10
        Label2.Text = "Transaction ID:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label1.Location = New Point(321, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(231, 28)
        Label1.TabIndex = 9
        Label1.Text = "Payment Summary"
        ' 
        ' flpItems
        ' 
        flpItems.AutoScroll = True
        flpItems.Location = New Point(143, 150)
        flpItems.Name = "flpItems"
        flpItems.Size = New Size(541, 268)
        flpItems.TabIndex = 18
        ' 
        ' pharmaViewTransaction
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        ClientSize = New Size(858, 507)
        Controls.Add(flpItems)
        Controls.Add(closeBtn)
        Controls.Add(username)
        Controls.Add(transactionid)
        Controls.Add(totalamount)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "pharmaViewTransaction"
        StartPosition = FormStartPosition.CenterScreen
        Text = "pharmaViewTransaction"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents closeBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents username As Label
    Friend WithEvents transactionid As Label
    Friend WithEvents totalamount As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents flpItems As FlowLayoutPanel
End Class
