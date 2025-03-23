<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MedicineForm
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
        layoutTest = New FlowLayoutPanel()
        SuspendLayout()
        ' 
        ' layoutTest
        ' 
        layoutTest.AutoScroll = True
        layoutTest.Location = New Point(12, 12)
        layoutTest.Name = "layoutTest"
        layoutTest.Padding = New Padding(2, 0, 0, 0)
        layoutTest.Size = New Size(776, 426)
        layoutTest.TabIndex = 0
        ' 
        ' MedicineForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(800, 450)
        Controls.Add(layoutTest)
        Name = "MedicineForm"
        Text = "MedicineForm"
        ResumeLayout(False)
    End Sub

    Friend WithEvents layoutTest As FlowLayoutPanel
End Class
