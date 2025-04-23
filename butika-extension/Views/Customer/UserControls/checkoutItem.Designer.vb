<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class checkoutItem
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
        medNameLbl = New Label()
        Quantity = New Label()
        FinalPrice = New Label()
        SuspendLayout()
        ' 
        ' medNameLbl
        ' 
        medNameLbl.AutoSize = True
        medNameLbl.Location = New Point(17, 16)
        medNameLbl.Name = "medNameLbl"
        medNameLbl.Size = New Size(91, 15)
        medNameLbl.TabIndex = 0
        medNameLbl.Text = "Medicine Name"
        ' 
        ' Quantity
        ' 
        Quantity.AutoSize = True
        Quantity.Location = New Point(173, 16)
        Quantity.Name = "Quantity"
        Quantity.Size = New Size(13, 15)
        Quantity.TabIndex = 1
        Quantity.Text = "0"
        ' 
        ' FinalPrice
        ' 
        FinalPrice.AutoSize = True
        FinalPrice.Location = New Point(220, 16)
        FinalPrice.Name = "FinalPrice"
        FinalPrice.Size = New Size(13, 15)
        FinalPrice.TabIndex = 2
        FinalPrice.Text = "0"
        ' 
        ' checkoutItem
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(220), CByte(229), CByte(219))
        Controls.Add(FinalPrice)
        Controls.Add(Quantity)
        Controls.Add(medNameLbl)
        Name = "checkoutItem"
        Size = New Size(278, 46)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents medNameLbl As Label
    Friend WithEvents Quantity As Label
    Friend WithEvents FinalPrice As Label

End Class
