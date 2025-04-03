<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pharmaViewMed
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
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pharmaViewMed))
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        closeBtn = New Guna.UI2.WinForms.Guna2Button()
        medicinePicture = New PictureBox()
        manufacturerLbl = New Label()
        mednameLbl = New Label()
        Label3 = New Label()
        dosageLbl = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        descriptionLbl = New Label()
        Label6 = New Label()
        stocksLbl = New Label()
        CType(medicinePicture, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' closeBtn
        ' 
        closeBtn.CustomizableEdges = CustomizableEdges5
        closeBtn.DisabledState.BorderColor = Color.DarkGray
        closeBtn.DisabledState.CustomBorderColor = Color.DarkGray
        closeBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        closeBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        closeBtn.FillColor = Color.Transparent
        closeBtn.Font = New Font("Segoe UI", 9F)
        closeBtn.ForeColor = Color.White
        closeBtn.HoverState.FillColor = Color.Red
        closeBtn.Image = CType(resources.GetObject("closeBtn.Image"), Image)
        closeBtn.Location = New Point(646, 21)
        closeBtn.Name = "closeBtn"
        closeBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        closeBtn.Size = New Size(35, 35)
        closeBtn.TabIndex = 9
        ' 
        ' medicinePicture
        ' 
        medicinePicture.Location = New Point(21, 21)
        medicinePicture.Name = "medicinePicture"
        medicinePicture.Size = New Size(209, 205)
        medicinePicture.TabIndex = 10
        medicinePicture.TabStop = False
        ' 
        ' manufacturerLbl
        ' 
        manufacturerLbl.AutoSize = True
        manufacturerLbl.Font = New Font("Century Gothic", 11F)
        manufacturerLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        manufacturerLbl.Location = New Point(258, 41)
        manufacturerLbl.Name = "manufacturerLbl"
        manufacturerLbl.Size = New Size(111, 20)
        manufacturerLbl.TabIndex = 11
        manufacturerLbl.Text = "Manufacturer"
        ' 
        ' mednameLbl
        ' 
        mednameLbl.AutoSize = True
        mednameLbl.Font = New Font("Century Gothic", 14F, FontStyle.Bold)
        mednameLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        mednameLbl.Location = New Point(256, 66)
        mednameLbl.Name = "mednameLbl"
        mednameLbl.Size = New Size(159, 23)
        mednameLbl.TabIndex = 12
        mednameLbl.Text = "Medicine Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label3.Location = New Point(251, 203)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 19)
        Label3.TabIndex = 13
        Label3.Text = "Dosage:"
        ' 
        ' dosageLbl
        ' 
        dosageLbl.AutoSize = True
        dosageLbl.Font = New Font("Century Gothic", 12F)
        dosageLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        dosageLbl.Location = New Point(329, 201)
        dosageLbl.Name = "dosageLbl"
        dosageLbl.Size = New Size(136, 21)
        dosageLbl.TabIndex = 14
        dosageLbl.Text = "dosage amount"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label1.Location = New Point(21, 242)
        Label1.Name = "Label1"
        Label1.Size = New Size(123, 18)
        Label1.TabIndex = 15
        Label1.Text = "Expiration Date:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 11F)
        Label2.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label2.Location = New Point(186, 240)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 20)
        Label2.TabIndex = 16
        Label2.Text = "date"
        Label2.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 10F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label4.Location = New Point(38, 310)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 17)
        Label4.TabIndex = 17
        Label4.Text = "About"
        ' 
        ' descriptionLbl
        ' 
        descriptionLbl.AutoSize = True
        descriptionLbl.Font = New Font("Century Gothic", 10F)
        descriptionLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        descriptionLbl.Location = New Point(38, 349)
        descriptionLbl.Name = "descriptionLbl"
        descriptionLbl.Size = New Size(85, 19)
        descriptionLbl.TabIndex = 18
        descriptionLbl.Text = "description"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label6.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label6.Location = New Point(508, 433)
        Label6.Name = "Label6"
        Label6.Size = New Size(64, 19)
        Label6.TabIndex = 19
        Label6.Text = "Stocks: "
        ' 
        ' stocksLbl
        ' 
        stocksLbl.AutoSize = True
        stocksLbl.Font = New Font("Century Gothic", 13F, FontStyle.Bold)
        stocksLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        stocksLbl.Location = New Point(578, 430)
        stocksLbl.Name = "stocksLbl"
        stocksLbl.Size = New Size(76, 22)
        stocksLbl.TabIndex = 20
        stocksLbl.Text = "stocks#"
        stocksLbl.TextAlign = ContentAlignment.TopRight
        ' 
        ' phramaViewMed
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        Controls.Add(stocksLbl)
        Controls.Add(Label6)
        Controls.Add(descriptionLbl)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dosageLbl)
        Controls.Add(Label3)
        Controls.Add(mednameLbl)
        Controls.Add(manufacturerLbl)
        Controls.Add(medicinePicture)
        Controls.Add(closeBtn)
        Name = "phramaViewMed"
        Size = New Size(700, 500)
        CType(medicinePicture, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents closeBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents medicinePicture As PictureBox
    Friend WithEvents manufacturerLbl As Label
    Friend WithEvents mednameLbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dosageLbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents descriptionLbl As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents stocksLbl As Label

End Class
