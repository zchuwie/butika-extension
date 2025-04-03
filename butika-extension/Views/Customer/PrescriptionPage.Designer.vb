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
        PrescListPanel = New Panel()
        PrescInfoPanel = New Panel()
        DeleteApprovalBtn = New RoundedButton()
        CType(MedIcon, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MedSubtext
        ' 
        MedSubtext.AutoSize = True
        MedSubtext.Font = New Font("Century Gothic", 9.75F)
        MedSubtext.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        MedSubtext.Location = New Point(113, 84)
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
        Medicines.Location = New Point(109, 54)
        Medicines.Name = "Medicines"
        Medicines.Size = New Size(155, 28)
        Medicines.TabIndex = 10
        Medicines.Text = "Notifications"
        ' 
        ' MedIcon
        ' 
        MedIcon.Image = My.Resources.Resources.prescription
        MedIcon.Location = New Point(40, 46)
        MedIcon.Name = "MedIcon"
        MedIcon.Size = New Size(67, 57)
        MedIcon.SizeMode = PictureBoxSizeMode.Zoom
        MedIcon.TabIndex = 12
        MedIcon.TabStop = False
        ' 
        ' PrescListPanel
        ' 
        PrescListPanel.BorderStyle = BorderStyle.FixedSingle
        PrescListPanel.Location = New Point(40, 120)
        PrescListPanel.Name = "PrescListPanel"
        PrescListPanel.Size = New Size(311, 519)
        PrescListPanel.TabIndex = 13
        ' 
        ' PrescInfoPanel
        ' 
        PrescInfoPanel.AutoScroll = True
        PrescInfoPanel.BorderStyle = BorderStyle.FixedSingle
        PrescInfoPanel.Location = New Point(378, 32)
        PrescInfoPanel.Name = "PrescInfoPanel"
        PrescInfoPanel.Size = New Size(796, 607)
        PrescInfoPanel.TabIndex = 14
        ' 
        ' DeleteApprovalBtn
        ' 
        DeleteApprovalBtn.BackColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        DeleteApprovalBtn.CornerRadius = 6
        DeleteApprovalBtn.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        DeleteApprovalBtn.ForeColor = Color.White
        DeleteApprovalBtn.Location = New Point(1008, 655)
        DeleteApprovalBtn.Name = "DeleteApprovalBtn"
        DeleteApprovalBtn.Size = New Size(166, 35)
        DeleteApprovalBtn.TabIndex = 26
        DeleteApprovalBtn.Text = "Delete Approval"
        DeleteApprovalBtn.UseVisualStyleBackColor = False
        ' 
        ' PrescriptionPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        ClientSize = New Size(1210, 720)
        Controls.Add(DeleteApprovalBtn)
        Controls.Add(PrescInfoPanel)
        Controls.Add(PrescListPanel)
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
    Friend WithEvents PrescListPanel As Panel
    Friend WithEvents PrescInfoPanel As Panel
    Friend WithEvents DeleteApprovalBtn As RoundedButton
End Class
