Imports butika.Models

Public Class StockRequestPanel_InventoryCustodian
    Public Async Function loadStockRequests() As Task
        StockRequestStatusDisplay.Controls.Clear()

        Dim medicineRepo As New MedicineRepository()
        Dim medicines As List(Of Medicine) = Await medicineRepo.GetAllStockReportsAsync()

        Dim batchSize As Integer = 5

        For i As Integer = 0 To medicines.Count - 1 Step batchSize
            Dim batch = medicines.Skip(i).Take(batchSize).ToList()

            For Each med In batch
                Dim control As New StockRequestBar(med)
                StockRequestStatusDisplay.Controls.Add(control)
            Next

            Await Task.Delay(50)
        Next
    End Function

    Private Async Sub StockRequestPanel_InventoryCustodian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await loadStockRequests()
    End Sub

End Class