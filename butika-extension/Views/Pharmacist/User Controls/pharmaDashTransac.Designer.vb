<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pharmaDashTransac
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
        transacIdLbl = New Label()
        dateLbl = New Label()
        amountLbl = New Label()
        SuspendLayout()
        ' 
        ' transacIdLbl
        ' 
        transacIdLbl.AutoSize = True
        transacIdLbl.Cursor = Cursors.Hand
        transacIdLbl.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        transacIdLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        transacIdLbl.Location = New Point(55, 10)
        transacIdLbl.Name = "transacIdLbl"
        transacIdLbl.Size = New Size(89, 16)
        transacIdLbl.TabIndex = 0
        transacIdLbl.Text = "Transaction ID"
        ' 
        ' dateLbl
        ' 
        dateLbl.AutoSize = True
        dateLbl.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        dateLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        dateLbl.Location = New Point(265, 10)
        dateLbl.Name = "dateLbl"
        dateLbl.Size = New Size(34, 16)
        dateLbl.TabIndex = 1
        dateLbl.Text = "Date"
        ' 
        ' amountLbl
        ' 
        amountLbl.AutoSize = True
        amountLbl.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        amountLbl.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        amountLbl.Location = New Point(500, 10)
        amountLbl.Name = "amountLbl"
        amountLbl.Size = New Size(52, 16)
        amountLbl.TabIndex = 2
        amountLbl.Text = "Amount"
        ' 
        ' pharmaDashTransac
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        Controls.Add(amountLbl)
        Controls.Add(dateLbl)
        Controls.Add(transacIdLbl)
        Name = "pharmaDashTransac"
        Size = New Size(674, 35)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents transacIdLbl As Label
    Friend WithEvents dateLbl As Label
    Friend WithEvents amountLbl As Label

End Class
