<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class itemsToApprove
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
        Quantity = New Label()
        medNameLbl = New Label()
        SuspendLayout()
        ' 
        ' Quantity
        ' 
        Quantity.AutoSize = True
        Quantity.Location = New Point(242, 7)
        Quantity.Name = "Quantity"
        Quantity.Size = New Size(13, 15)
        Quantity.TabIndex = 4
        Quantity.Text = "0"
        ' 
        ' medNameLbl
        ' 
        medNameLbl.AutoSize = True
        medNameLbl.Location = New Point(24, 7)
        medNameLbl.Name = "medNameLbl"
        medNameLbl.Size = New Size(91, 15)
        medNameLbl.TabIndex = 3
        medNameLbl.Text = "Medicine Name"
        ' 
        ' itemsToApprove
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Quantity)
        Controls.Add(medNameLbl)
        Name = "itemsToApprove"
        Size = New Size(278, 31)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Quantity As Label
    Friend WithEvents medNameLbl As Label

End Class
