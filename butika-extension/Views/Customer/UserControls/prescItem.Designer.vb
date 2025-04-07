<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class prescItem
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
        DateSub = New Label()
        PrescNo = New Label()
        StatusLbl = New Label()
        Status = New Label()
        SuspendLayout()
        ' 
        ' DateSub
        ' 
        DateSub.AutoSize = True
        DateSub.Font = New Font("Century Gothic", 9.75F)
        DateSub.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        DateSub.Location = New Point(19, 34)
        DateSub.Name = "DateSub"
        DateSub.Size = New Size(110, 17)
        DateSub.TabIndex = 4
        DateSub.Text = "Date Submitted"
        DateSub.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PrescNo
        ' 
        PrescNo.AutoSize = True
        PrescNo.Font = New Font("Century Gothic", 12.75F, FontStyle.Bold)
        PrescNo.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        PrescNo.Location = New Point(17, 13)
        PrescNo.Name = "PrescNo"
        PrescNo.Size = New Size(137, 19)
        PrescNo.TabIndex = 3
        PrescNo.Text = "Prescription No."
        PrescNo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' StatusLbl
        ' 
        StatusLbl.AutoSize = True
        StatusLbl.Font = New Font("Century Gothic", 9.75F)
        StatusLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        StatusLbl.Location = New Point(17, 68)
        StatusLbl.Name = "StatusLbl"
        StatusLbl.Size = New Size(50, 17)
        StatusLbl.TabIndex = 5
        StatusLbl.Text = "Status:"
        StatusLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Status
        ' 
        Status.AutoSize = True
        Status.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        Status.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Status.Location = New Point(63, 68)
        Status.Name = "Status"
        Status.Size = New Size(81, 16)
        Status.TabIndex = 6
        Status.Text = "Load Status"
        Status.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' prescItem
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(StatusLbl)
        Controls.Add(DateSub)
        Controls.Add(PrescNo)
        Controls.Add(Status)
        CornerRadius = 8
        Name = "prescItem"
        Size = New Size(272, 98)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DateSub As Label
    Friend WithEvents PrescNo As Label
    Friend WithEvents StatusLbl As Label
    Friend WithEvents Status As Label

End Class
