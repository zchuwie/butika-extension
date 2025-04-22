Imports butika.Helpers
Imports butika.Models

Public Class StockRequestBar
    Public Property MedicineInfo As Medicine

    Public Sub New(med As Medicine)
        InitializeComponent()
        MedicineInfo = med
        LoadData(med)
    End Sub

    Private Sub LoadData(med As Medicine)
        medicineID.Text = MedicineInfo.MedicineID.ToString
        medicineName.Text = MedicineInfo.MedicineName
        currentStockQuantity.Text = MedicineInfo.MedicineStock.ToString
        requestedStockQuantity.Text = MedicineInfo.StockQuantityRequest.ToString
        requestedDate.Text = MedicineInfo.StockRequestedDate

        If MedicineInfo.StockRequestedDate.HasValue Then
            requestedDate.Text = MedicineInfo.StockRequestedDate.Value.ToString("yyyy-MM-dd")
        Else
            requestedDate.Text = "N/A"
        End If

        If MedicineInfo.StockRequestStatus = 0 Then
            requestStatus.Text = "Pending"
        ElseIf MedicineInfo.StockRequestStatus = 1 Then
            requestStatus.Text = "Approved"
        ElseIf MedicineInfo.StockRequestStatus = 2 Then
            requestStatus.Text = "Declined"
        Else
            requestStatus.Text = "Unknown"
        End If

        If MedicineInfo.StockReviewdDate.HasValue Then
            reviewedDate.Text = MedicineInfo.StockReviewdDate.Value.ToString("yyyy-MM-dd")
        Else
            reviewedDate.Text = "N/A"
        End If

    End Sub
End Class
