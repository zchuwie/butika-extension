<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockRequestBar
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        medicinebar_bg = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        requestStatus = New Guna.UI2.WinForms.Guna2HtmlLabel()
        reviewedDate = New Guna.UI2.WinForms.Guna2HtmlLabel()
        requestedStockQuantity = New Guna.UI2.WinForms.Guna2HtmlLabel()
        medicineID = New Guna.UI2.WinForms.Guna2HtmlLabel()
        requestedDate = New Guna.UI2.WinForms.Guna2HtmlLabel()
        currentStockQuantity = New Guna.UI2.WinForms.Guna2HtmlLabel()
        medicineName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        medicinebar_bg.SuspendLayout()
        SuspendLayout()
        ' 
        ' medicinebar_bg
        ' 
        medicinebar_bg.BorderColor = Color.FromArgb(CByte(22), CByte(66), CByte(50))
        medicinebar_bg.BorderRadius = 6
        medicinebar_bg.BorderThickness = 1
        medicinebar_bg.Controls.Add(requestStatus)
        medicinebar_bg.Controls.Add(reviewedDate)
        medicinebar_bg.Controls.Add(requestedStockQuantity)
        medicinebar_bg.Controls.Add(medicineID)
        medicinebar_bg.Controls.Add(requestedDate)
        medicinebar_bg.Controls.Add(currentStockQuantity)
        medicinebar_bg.Controls.Add(medicineName)
        medicinebar_bg.CustomizableEdges = CustomizableEdges1
        medicinebar_bg.Enabled = False
        medicinebar_bg.Location = New Point(1, 0)
        medicinebar_bg.Margin = New Padding(7, 6, 7, 6)
        medicinebar_bg.Name = "medicinebar_bg"
        medicinebar_bg.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        medicinebar_bg.Size = New Size(905, 58)
        medicinebar_bg.TabIndex = 1
        ' 
        ' requestStatus
        ' 
        requestStatus.AutoSize = False
        requestStatus.BackColor = Color.Transparent
        requestStatus.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        requestStatus.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        requestStatus.Location = New Point(632, 15)
        requestStatus.Margin = New Padding(3, 2, 3, 2)
        requestStatus.Name = "requestStatus"
        requestStatus.Size = New Size(108, 25)
        requestStatus.TabIndex = 7
        requestStatus.Text = "Status"
        requestStatus.TextAlignment = ContentAlignment.MiddleCenter
        ' 
        ' reviewedDate
        ' 
        reviewedDate.AutoSize = False
        reviewedDate.BackColor = Color.Transparent
        reviewedDate.Font = New Font("Century Gothic", 8.5F, FontStyle.Bold)
        reviewedDate.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        reviewedDate.Location = New Point(781, 20)
        reviewedDate.Margin = New Padding(3, 2, 3, 2)
        reviewedDate.Name = "reviewedDate"
        reviewedDate.Size = New Size(79, 20)
        reviewedDate.TabIndex = 6
        reviewedDate.Text = "2999/12/31"
        ' 
        ' requestedStockQuantity
        ' 
        requestedStockQuantity.AutoSize = False
        requestedStockQuantity.BackColor = Color.Transparent
        requestedStockQuantity.Font = New Font("Century Gothic", 8.5F, FontStyle.Bold)
        requestedStockQuantity.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        requestedStockQuantity.Location = New Point(432, 20)
        requestedStockQuantity.Margin = New Padding(3, 2, 3, 2)
        requestedStockQuantity.Name = "requestedStockQuantity"
        requestedStockQuantity.Size = New Size(42, 20)
        requestedStockQuantity.TabIndex = 5
        requestedStockQuantity.Text = "00"
        ' 
        ' medicineID
        ' 
        medicineID.AutoSize = False
        medicineID.BackColor = Color.Transparent
        medicineID.Font = New Font("Century Gothic", 8.5F, FontStyle.Bold)
        medicineID.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        medicineID.Location = New Point(19, 20)
        medicineID.Margin = New Padding(3, 2, 3, 2)
        medicineID.Name = "medicineID"
        medicineID.Size = New Size(42, 20)
        medicineID.TabIndex = 4
        medicineID.Text = "00"
        ' 
        ' requestedDate
        ' 
        requestedDate.AutoSize = False
        requestedDate.BackColor = Color.Transparent
        requestedDate.Font = New Font("Century Gothic", 8.5F, FontStyle.Bold)
        requestedDate.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        requestedDate.Location = New Point(531, 20)
        requestedDate.Margin = New Padding(3, 2, 3, 2)
        requestedDate.Name = "requestedDate"
        requestedDate.Size = New Size(79, 20)
        requestedDate.TabIndex = 3
        requestedDate.Text = "2999/12/31"
        ' 
        ' currentStockQuantity
        ' 
        currentStockQuantity.AutoSize = False
        currentStockQuantity.BackColor = Color.Transparent
        currentStockQuantity.Font = New Font("Century Gothic", 8.5F, FontStyle.Bold)
        currentStockQuantity.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        currentStockQuantity.Location = New Point(329, 20)
        currentStockQuantity.Margin = New Padding(3, 2, 3, 2)
        currentStockQuantity.Name = "currentStockQuantity"
        currentStockQuantity.Size = New Size(42, 20)
        currentStockQuantity.TabIndex = 2
        currentStockQuantity.Text = "00"
        ' 
        ' medicineName
        ' 
        medicineName.AutoSize = False
        medicineName.BackColor = Color.Transparent
        medicineName.Font = New Font("Century Gothic", 8.5F, FontStyle.Bold)
        medicineName.ForeColor = Color.FromArgb(CByte(22), CByte(66), CByte(60))
        medicineName.Location = New Point(70, 20)
        medicineName.Margin = New Padding(3, 2, 3, 2)
        medicineName.Name = "medicineName"
        medicineName.Size = New Size(238, 20)
        medicineName.TabIndex = 0
        medicineName.Text = "Medicine Name Here"
        ' 
        ' StockRequestBar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(medicinebar_bg)
        Name = "StockRequestBar"
        Size = New Size(907, 58)
        medicinebar_bg.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents medicinebar_bg As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents requestStatus As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents reviewedDate As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents requestedStockQuantity As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents medicineID As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents requestedDate As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents currentStockQuantity As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents medicineName As Guna.UI2.WinForms.Guna2HtmlLabel

End Class
