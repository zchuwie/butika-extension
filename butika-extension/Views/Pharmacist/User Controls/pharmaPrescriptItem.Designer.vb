<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pharmaPrescriptItem
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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pharmaPrescriptItem))
        prescriptIdLbl = New Label()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        dateLbl = New Label()
        patientLbl = New Label()
        morePicture = New PictureBox()
        Guna2Panel1.SuspendLayout()
        CType(morePicture, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' prescriptIdLbl
        ' 
        prescriptIdLbl.AutoSize = True
        prescriptIdLbl.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        prescriptIdLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        prescriptIdLbl.Location = New Point(26, 10)
        prescriptIdLbl.Name = "prescriptIdLbl"
        prescriptIdLbl.Size = New Size(100, 16)
        prescriptIdLbl.TabIndex = 0
        prescriptIdLbl.Text = "Prescription ID"
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Guna2Panel1.BorderRadius = 10
        Guna2Panel1.BorderThickness = 3
        Guna2Panel1.Controls.Add(morePicture)
        Guna2Panel1.Controls.Add(dateLbl)
        Guna2Panel1.Controls.Add(patientLbl)
        Guna2Panel1.Controls.Add(prescriptIdLbl)
        Guna2Panel1.CustomizableEdges = CustomizableEdges3
        Guna2Panel1.Dock = DockStyle.Fill
        Guna2Panel1.Location = New Point(0, 0)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Panel1.Size = New Size(972, 37)
        Guna2Panel1.TabIndex = 2
        ' 
        ' dateLbl
        ' 
        dateLbl.AutoSize = True
        dateLbl.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        dateLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        dateLbl.Location = New Point(580, 10)
        dateLbl.Name = "dateLbl"
        dateLbl.Size = New Size(129, 16)
        dateLbl.TabIndex = 3
        dateLbl.Text = "Date of Submission"
        ' 
        ' patientLbl
        ' 
        patientLbl.AutoSize = True
        patientLbl.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        patientLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        patientLbl.Location = New Point(301, 10)
        patientLbl.Name = "patientLbl"
        patientLbl.Size = New Size(94, 16)
        patientLbl.TabIndex = 1
        patientLbl.Text = "Patient Name"
        ' 
        ' morePicture
        ' 
        morePicture.Image = CType(resources.GetObject("morePicture.Image"), Image)
        morePicture.Location = New Point(858, 8)
        morePicture.Name = "morePicture"
        morePicture.Size = New Size(20, 20)
        morePicture.SizeMode = PictureBoxSizeMode.StretchImage
        morePicture.TabIndex = 4
        morePicture.TabStop = False
        ' 
        ' pharmaPrescriptItem
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        Controls.Add(Guna2Panel1)
        Name = "pharmaPrescriptItem"
        Size = New Size(972, 37)
        Guna2Panel1.ResumeLayout(False)
        Guna2Panel1.PerformLayout()
        CType(morePicture, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents prescriptIdLbl As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dateLbl As Label
    Friend WithEvents patientLbl As Label
    Friend WithEvents morePicture As PictureBox

End Class
