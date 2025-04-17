Imports Org.BouncyCastle.Asn1.Cmp

Public Class adminStock
    Private Async Sub adminStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadStockTableAsync()
    End Sub

    Private Async Function LoadStockTableAsync() As Task
        stockTable.DataSource = Await AdminRepository.GetStockReportDataAsync()
    End Function

    Private Async Sub stockTable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles stockTable.CellClick
        If e.RowIndex >= 0 Then
            Dim row = stockTable.Rows(e.RowIndex)
            Dim medicineId As Integer = Convert.ToInt32(row.Cells("Medicine_ID").Value)

            ' Load drug info
            Dim drugInfo As DataRow = Await AdminRepository.GetDrugInfoByIDAsync(medicineId)
            If drugInfo IsNot Nothing Then
                ' Update labels with drug info
                id.Text = drugInfo("drug_id").ToString()
                namedata.Text = drugInfo("drug_name").ToString()
                branddata.Text = drugInfo("drug_manufacturer").ToString()
                pricedata.Text = "₱" & FormatNumber(drugInfo("drug_price"), 2)
                expirydata.Text = drugInfo("expiration_date").ToString()
                stockdata.Text = drugInfo("drug_stocks").ToString()
            End If

            ' Update labels with stock report info
            reqstock.Text = row.Cells("Requested_Quantity").Value.ToString()
            reqdate.Text = Convert.ToDateTime(row.Cells("Request_Date").Value).ToShortDateString()
            reqstatus.Text = row.Cells("Request_Status").Value.ToString()
        End If
    End Sub



End Class