<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pharmaDashPrescript
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
        usernameLbl = New Label()
        statusLbl = New Label()
        SuspendLayout()
        ' 
        ' usernameLbl
        ' 
        usernameLbl.AutoSize = True
        usernameLbl.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        usernameLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        usernameLbl.Location = New Point(23, 10)
        usernameLbl.Name = "usernameLbl"
        usernameLbl.Size = New Size(66, 16)
        usernameLbl.TabIndex = 0
        usernameLbl.Text = "Username"
        ' 
        ' statusLbl
        ' 
        statusLbl.AutoSize = True
        statusLbl.Cursor = Cursors.Hand
        statusLbl.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        statusLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        statusLbl.Location = New Point(148, 10)
        statusLbl.Name = "statusLbl"
        statusLbl.Size = New Size(67, 16)
        statusLbl.TabIndex = 1
        statusLbl.Text = "Approved"
        ' 
        ' pharmaDashPrescript
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        Controls.Add(statusLbl)
        Controls.Add(usernameLbl)
        Name = "pharmaDashPrescript"
        Size = New Size(240, 35)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents usernameLbl As Label
    Friend WithEvents statusLbl As Label

End Class
