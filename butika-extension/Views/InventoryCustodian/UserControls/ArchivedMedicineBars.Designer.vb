<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArchivedMedicineBars
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
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        medicinebar_bg = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        manufacturerName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        medicineName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        medicineID = New Guna.UI2.WinForms.Guna2HtmlLabel()
        medicinebar_bg.SuspendLayout()
        SuspendLayout()
        ' 
        ' medicinebar_bg
        ' 
        medicinebar_bg.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(50))
        medicinebar_bg.BorderRadius = 6
        medicinebar_bg.BorderThickness = 1
        medicinebar_bg.Controls.Add(medicineID)
        medicinebar_bg.Controls.Add(manufacturerName)
        medicinebar_bg.Controls.Add(medicineName)
        medicinebar_bg.CustomizableEdges = CustomizableEdges1
        medicinebar_bg.Enabled = False
        medicinebar_bg.FillColor = Color.FromArgb(CByte(196), CByte(218), CByte(212))
        medicinebar_bg.FillColor2 = Color.FromArgb(CByte(196), CByte(218), CByte(212))
        medicinebar_bg.FillColor3 = Color.FromArgb(CByte(196), CByte(218), CByte(212))
        medicinebar_bg.FillColor4 = Color.FromArgb(CByte(196), CByte(218), CByte(212))
        medicinebar_bg.Location = New Point(0, 0)
        medicinebar_bg.Margin = New Padding(7, 6, 7, 6)
        medicinebar_bg.Name = "medicinebar_bg"
        medicinebar_bg.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        medicinebar_bg.Size = New Size(610, 41)
        medicinebar_bg.TabIndex = 1
        ' 
        ' manufacturerName
        ' 
        manufacturerName.AutoSize = False
        manufacturerName.BackColor = Color.Transparent
        manufacturerName.Font = New Font("Century Gothic", 8.5F, FontStyle.Bold)
        manufacturerName.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        manufacturerName.Location = New Point(413, 12)
        manufacturerName.Margin = New Padding(3, 2, 3, 2)
        manufacturerName.Name = "manufacturerName"
        manufacturerName.Size = New Size(171, 14)
        manufacturerName.TabIndex = 1
        manufacturerName.Text = "Manufacturer Name Here"
        ' 
        ' medicineName
        ' 
        medicineName.AutoSize = False
        medicineName.BackColor = Color.Transparent
        medicineName.Font = New Font("Century Gothic", 8.5F, FontStyle.Bold)
        medicineName.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        medicineName.Location = New Point(87, 12)
        medicineName.Margin = New Padding(3, 2, 3, 2)
        medicineName.Name = "medicineName"
        medicineName.Size = New Size(309, 14)
        medicineName.TabIndex = 0
        medicineName.Text = "Medicine Name Here"
        ' 
        ' medicineID
        ' 
        medicineID.AutoSize = False
        medicineID.BackColor = Color.Transparent
        medicineID.Font = New Font("Century Gothic", 8.5F, FontStyle.Bold)
        medicineID.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        medicineID.Location = New Point(18, 12)
        medicineID.Margin = New Padding(3, 2, 3, 2)
        medicineID.Name = "medicineID"
        medicineID.Size = New Size(42, 14)
        medicineID.TabIndex = 5
        medicineID.Text = "00"
        ' 
        ' ArchivedMedicineBars
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(medicinebar_bg)
        Name = "ArchivedMedicineBars"
        Size = New Size(610, 41)
        medicinebar_bg.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents medicinebar_bg As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents manufacturerName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents medicineName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents medicineID As Guna.UI2.WinForms.Guna2HtmlLabel

End Class
