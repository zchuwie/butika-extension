<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pharmaViewMedicine
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pharmaViewMedicine))
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        stocksLbl = New Label()
        Label6 = New Label()
        descriptionLbl = New Label()
        Label4 = New Label()
        expirationDateLbl = New Label()
        Label1 = New Label()
        dosageLbl = New Label()
        Label3 = New Label()
        mednameLbl = New Label()
        manufacturerLbl = New Label()
        medicinePicture = New PictureBox()
        closeBtn = New Guna.UI2.WinForms.Guna2Button()
        CType(medicinePicture, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' stocksLbl
        ' 
        stocksLbl.AutoSize = True
        stocksLbl.Font = New Font("Century Gothic", 13F, FontStyle.Bold)
        stocksLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        stocksLbl.Location = New Point(578, 432)
        stocksLbl.Name = "stocksLbl"
        stocksLbl.Size = New Size(76, 22)
        stocksLbl.TabIndex = 32
        stocksLbl.Text = "stocks#"
        stocksLbl.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label6.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label6.Location = New Point(508, 435)
        Label6.Name = "Label6"
        Label6.Size = New Size(64, 19)
        Label6.TabIndex = 31
        Label6.Text = "Stocks: "
        ' 
        ' descriptionLbl
        ' 
        descriptionLbl.Font = New Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        descriptionLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        descriptionLbl.Location = New Point(38, 330)
        descriptionLbl.Name = "descriptionLbl"
        descriptionLbl.Size = New Size(616, 70)
        descriptionLbl.TabIndex = 30
        descriptionLbl.Text = "description"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 10F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label4.Location = New Point(38, 299)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 17)
        Label4.TabIndex = 29
        Label4.Text = "About"
        ' 
        ' expirationDateLbl
        ' 
        expirationDateLbl.AutoSize = True
        expirationDateLbl.Font = New Font("Century Gothic", 11F)
        expirationDateLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        expirationDateLbl.Location = New Point(186, 242)
        expirationDateLbl.Name = "expirationDateLbl"
        expirationDateLbl.Size = New Size(44, 20)
        expirationDateLbl.TabIndex = 28
        expirationDateLbl.Text = "date"
        expirationDateLbl.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label1.Location = New Point(21, 244)
        Label1.Name = "Label1"
        Label1.Size = New Size(123, 18)
        Label1.TabIndex = 27
        Label1.Text = "Expiration Date:"
        ' 
        ' dosageLbl
        ' 
        dosageLbl.AutoSize = True
        dosageLbl.Font = New Font("Century Gothic", 12F)
        dosageLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        dosageLbl.Location = New Point(329, 186)
        dosageLbl.Name = "dosageLbl"
        dosageLbl.Size = New Size(136, 21)
        dosageLbl.TabIndex = 26
        dosageLbl.Text = "dosage amount"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label3.Location = New Point(251, 188)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 19)
        Label3.TabIndex = 25
        Label3.Text = "Dosage:"
        ' 
        ' mednameLbl
        ' 
        mednameLbl.AutoSize = True
        mednameLbl.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        mednameLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        mednameLbl.Location = New Point(256, 77)
        mednameLbl.Name = "mednameLbl"
        mednameLbl.Size = New Size(159, 23)
        mednameLbl.TabIndex = 24
        mednameLbl.Text = "Medicine Name"
        ' 
        ' manufacturerLbl
        ' 
        manufacturerLbl.AutoSize = True
        manufacturerLbl.Font = New Font("Century Gothic", 11F)
        manufacturerLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        manufacturerLbl.Location = New Point(258, 52)
        manufacturerLbl.Name = "manufacturerLbl"
        manufacturerLbl.Size = New Size(111, 20)
        manufacturerLbl.TabIndex = 23
        manufacturerLbl.Text = "Manufacturer"
        ' 
        ' medicinePicture
        ' 
        medicinePicture.Location = New Point(21, 23)
        medicinePicture.Name = "medicinePicture"
        medicinePicture.Size = New Size(209, 205)
        medicinePicture.SizeMode = PictureBoxSizeMode.StretchImage
        medicinePicture.TabIndex = 22
        medicinePicture.TabStop = False
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
        closeBtn.Location = New Point(646, 23)
        closeBtn.Name = "closeBtn"
        closeBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        closeBtn.Size = New Size(35, 35)
        closeBtn.TabIndex = 21
        ' 
        ' pharmaViewMedicine
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        ClientSize = New Size(700, 500)
        Controls.Add(stocksLbl)
        Controls.Add(Label6)
        Controls.Add(descriptionLbl)
        Controls.Add(Label4)
        Controls.Add(expirationDateLbl)
        Controls.Add(Label1)
        Controls.Add(dosageLbl)
        Controls.Add(Label3)
        Controls.Add(mednameLbl)
        Controls.Add(manufacturerLbl)
        Controls.Add(medicinePicture)
        Controls.Add(closeBtn)
        FormBorderStyle = FormBorderStyle.None
        Name = "pharmaViewMedicine"
        StartPosition = FormStartPosition.CenterScreen
        Text = "pharmaViewMedicine"
        CType(medicinePicture, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents stocksLbl As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents descriptionLbl As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents expirationDateLbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dosageLbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents mednameLbl As Label
    Friend WithEvents manufacturerLbl As Label
    Friend WithEvents medicinePicture As PictureBox
    Friend WithEvents closeBtn As Guna.UI2.WinForms.Guna2Button
End Class
