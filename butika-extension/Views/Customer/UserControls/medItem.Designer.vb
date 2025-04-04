<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class medItem
    Inherits RoundedUserControl

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
        MedImg = New PictureBox()
        MedName = New Label()
        Manufacturer = New Label()
        CType(MedImg, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MedImg
        ' 
        MedImg.Location = New Point(13, 13)
        MedImg.Name = "MedImg"
        MedImg.Size = New Size(117, 74)
        MedImg.TabIndex = 0
        MedImg.TabStop = False
        ' 
        ' MedName
        ' 
        MedName.AutoSize = True
        MedName.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        MedName.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        MedName.Location = New Point(33, 97)
        MedName.Name = "MedName"
        MedName.Size = New Size(79, 16)
        MedName.TabIndex = 1
        MedName.Text = "Med Name"
        MedName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Manufacturer
        ' 
        Manufacturer.AutoSize = True
        Manufacturer.Font = New Font("Century Gothic", 9.75F)
        Manufacturer.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Manufacturer.Location = New Point(26, 117)
        Manufacturer.Name = "Manufacturer"
        Manufacturer.Size = New Size(94, 17)
        Manufacturer.TabIndex = 2
        Manufacturer.Text = "Manufacturer"
        Manufacturer.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' medItem
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Manufacturer)
        Controls.Add(MedName)
        Controls.Add(MedImg)
        CornerRadius = 8
        Name = "medItem"
        Size = New Size(143, 158)
        CType(MedImg, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MedImg As PictureBox
    Friend WithEvents MedName As Label
    Friend WithEvents Manufacturer As Label

End Class
