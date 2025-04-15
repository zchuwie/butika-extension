Imports System.Threading
Imports butika.Helpers
Imports butika.Models


Public Class MedicineBars

    Public Property MedicineInfo As Medicine

    Public Sub New(med As Medicine)
        InitializeComponent()
        LoadData(med)
    End Sub

    Private Sub LoadData(med As Medicine)
        medicineName.Text = med.FormattedMedicineName
        manufacturerName.Text = HelperMethod.CapitalizeEachFirstWord(med.MedicineManufacturer)
        stockQuantity.Text = med.MedicineStock.ToString()
        expirationDate.Text = med.MedicineExpirationDate.ToString()

        Me.MedicineInfo = med

        Dim today As Date = Date.Today
        Dim oneMonthFromNow As Date = today.AddMonths(1)

        If MedicineInfo.MedicineStock <= 10 AndAlso MedicineInfo.MedicineExpirationDate <= today Then
            ' Expired + Low stock
            medicinebar_bg.FillColor = Color.FromArgb(24, 36, 36)
            medicinebar_bg.FillColor2 = Color.FromArgb(24, 36, 36)
            medicinebar_bg.FillColor3 = Color.FromArgb(24, 36, 36)
            medicinebar_bg.FillColor4 = Color.FromArgb(24, 36, 36)
            medicineName.ForeColor = Color.White
            manufacturerName.ForeColor = Color.White
            stockQuantity.ForeColor = Color.White
            expirationDate.ForeColor = Color.White

        ElseIf MedicineInfo.MedicineStock <= 30 AndAlso MedicineInfo.MedicineExpirationDate <= oneMonthFromNow Then
            ' Expiring soon + Medium stock
            medicinebar_bg.FillColor = Color.FromArgb(184, 129, 184)
            medicinebar_bg.FillColor2 = Color.FromArgb(184, 129, 184)
            medicinebar_bg.FillColor3 = Color.FromArgb(184, 129, 184)
            medicinebar_bg.FillColor4 = Color.FromArgb(184, 129, 184)
            medicineName.ForeColor = Color.White
            manufacturerName.ForeColor = Color.White
            stockQuantity.ForeColor = Color.White
            expirationDate.ForeColor = Color.White

        ElseIf MedicineInfo.MedicineStock <= 10 AndAlso MedicineInfo.MedicineExpirationDate > oneMonthFromNow Then
            ' Good expiry + Critically low stock
            medicinebar_bg.FillColor = Color.FromArgb(194, 139, 62)
            medicinebar_bg.FillColor2 = Color.FromArgb(194, 139, 62)
            medicinebar_bg.FillColor3 = Color.FromArgb(194, 139, 62)
            medicinebar_bg.FillColor4 = Color.FromArgb(194, 139, 62)
            medicineName.ForeColor = Color.White
            manufacturerName.ForeColor = Color.White
            stockQuantity.ForeColor = Color.White
            expirationDate.ForeColor = Color.White

        ElseIf MedicineInfo.MedicineStock <= 30 AndAlso MedicineInfo.MedicineExpirationDate > oneMonthFromNow Then
            ' Good expiry + Medium stock
            medicinebar_bg.FillColor = Color.FromArgb(255, 153, 102)
            medicinebar_bg.FillColor2 = Color.FromArgb(255, 153, 102)
            medicinebar_bg.FillColor3 = Color.FromArgb(255, 153, 102)
            medicinebar_bg.FillColor4 = Color.FromArgb(255, 153, 102)
            medicineName.ForeColor = Color.FromArgb(22, 66, 60)
            manufacturerName.ForeColor = Color.FromArgb(22, 66, 60)
            stockQuantity.ForeColor = Color.FromArgb(22, 66, 60)
            expirationDate.ForeColor = Color.FromArgb(22, 66, 60)

        ElseIf MedicineInfo.MedicineStock > 30 AndAlso MedicineInfo.MedicineExpirationDate <= today Then
            ' Expired + High stock
            medicinebar_bg.FillColor = Color.FromArgb(229, 65, 65)
            medicinebar_bg.FillColor2 = Color.FromArgb(229, 65, 65)
            medicinebar_bg.FillColor3 = Color.FromArgb(229, 65, 65)
            medicinebar_bg.FillColor4 = Color.FromArgb(229, 65, 65)
            medicineName.ForeColor = Color.White
            manufacturerName.ForeColor = Color.White
            stockQuantity.ForeColor = Color.White
            expirationDate.ForeColor = Color.White

        ElseIf MedicineInfo.MedicineStock > 30 AndAlso MedicineInfo.MedicineExpirationDate <= oneMonthFromNow Then
            ' Expiring soon + High stock
            medicinebar_bg.FillColor = Color.FromArgb(239, 239, 141)
            medicinebar_bg.FillColor2 = Color.FromArgb(239, 239, 141)
            medicinebar_bg.FillColor3 = Color.FromArgb(239, 239, 141)
            medicinebar_bg.FillColor4 = Color.FromArgb(239, 239, 141)
            medicineName.ForeColor = Color.FromArgb(22, 66, 60)
            manufacturerName.ForeColor = Color.FromArgb(22, 66, 60)
            stockQuantity.ForeColor = Color.FromArgb(22, 66, 60)
            expirationDate.ForeColor = Color.FromArgb(22, 66, 60)
        End If

    End Sub

    Private Sub UserControl_Click(sender As Object, e As EventArgs) Handles Me.Click
        Dim viewForm As New ViewMedicineBar()
        viewForm.MedicineInfo = MedicineInfo

        viewForm.ShowDialog()
    End Sub

End Class