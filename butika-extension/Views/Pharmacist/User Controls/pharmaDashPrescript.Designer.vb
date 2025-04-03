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
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label1.Location = New Point(23, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 16)
        Label1.TabIndex = 0
        Label1.Text = "Prescription ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        Label2.Location = New Point(163, 10)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 16)
        Label2.TabIndex = 1
        Label2.Text = "Approved"
        ' 
        ' pharmaDashPrescript
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "pharmaDashPrescript"
        Size = New Size(246, 35)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

End Class
