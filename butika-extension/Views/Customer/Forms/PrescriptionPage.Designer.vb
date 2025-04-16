<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrescriptionPage
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
        MedSubtext = New Label()
        Medicines = New Label()
        MedIcon = New PictureBox()
        PrescInfoPanel = New Panel()
        prescriptionListPanel = New FlowLayoutPanel()
        CType(MedIcon, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MedSubtext
        ' 
        MedSubtext.AutoSize = True
        MedSubtext.Font = New Font("Century Gothic", 9.75F)
        MedSubtext.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        MedSubtext.Location = New Point(113, 93)
        MedSubtext.Name = "MedSubtext"
        MedSubtext.Size = New Size(191, 17)
        MedSubtext.TabIndex = 11
        MedSubtext.Text = "See pending and approved."
        ' 
        ' Medicines
        ' 
        Medicines.AutoSize = True
        Medicines.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        Medicines.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Medicines.Location = New Point(109, 63)
        Medicines.Name = "Medicines"
        Medicines.Size = New Size(155, 28)
        Medicines.TabIndex = 10
        Medicines.Text = "Notifications"
        ' 
        ' MedIcon
        ' 
        MedIcon.Image = My.Resources.Resources.prescription
        MedIcon.Location = New Point(40, 55)
        MedIcon.Name = "MedIcon"
        MedIcon.Size = New Size(67, 57)
        MedIcon.SizeMode = PictureBoxSizeMode.Zoom
        MedIcon.TabIndex = 12
        MedIcon.TabStop = False
        ' 
        ' PrescInfoPanel
        ' 
        PrescInfoPanel.BorderStyle = BorderStyle.FixedSingle
        PrescInfoPanel.Location = New Point(388, 54)
        PrescInfoPanel.Name = "PrescInfoPanel"
        PrescInfoPanel.Size = New Size(796, 607)
        PrescInfoPanel.TabIndex = 14
        ' 
        ' prescriptionListPanel
        ' 
        prescriptionListPanel.FlowDirection = FlowDirection.TopDown
        prescriptionListPanel.Location = New Point(40, 137)
        prescriptionListPanel.Name = "prescriptionListPanel"
        prescriptionListPanel.Padding = New Padding(18, 15, 18, 0)
        prescriptionListPanel.Size = New Size(311, 519)
        prescriptionListPanel.TabIndex = 27
        ' 
        ' PrescriptionPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        ClientSize = New Size(1210, 720)
        Controls.Add(prescriptionListPanel)
        Controls.Add(PrescInfoPanel)
        Controls.Add(MedSubtext)
        Controls.Add(Medicines)
        Controls.Add(MedIcon)
        FormBorderStyle = FormBorderStyle.None
        Name = "PrescriptionPage"
        Text = "PrescriptionPage"
        CType(MedIcon, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MedSubtext As Label
    Friend WithEvents Medicines As Label
    Friend WithEvents MedIcon As PictureBox
    Friend WithEvents PrescInfoPanel As Panel
    Friend WithEvents prescriptionListPanel As FlowLayoutPanel
End Class
