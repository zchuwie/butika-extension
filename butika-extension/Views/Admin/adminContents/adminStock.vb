Imports butika.Configurations
Imports Org.BouncyCastle.Asn1.Cmp

Public Class adminStock
    Private Async Sub adminStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadStockTableAsync()
        Await UpdateRequestStatusLabelsAsync()
        UIHelper.CenterLabelsHorizontallyInPanels(approvedLabel, declinedLabel)
    End Sub

    Private Async Function LoadStockTableAsync() As Task
        stockTable.DataSource = Await AdminRepository.GetStockReportDataAsync()
    End Function

    Private Async Sub stockTable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles stockTable.CellClick
        If e.RowIndex >= 0 Then
            Dim row = stockTable.Rows(e.RowIndex)
            Dim medicineId As Integer = Convert.ToInt32(row.Cells("Medicine_ID").Value)
            Dim drugId As Integer = Convert.ToInt32(stockTable.Rows(e.RowIndex).Cells("medicine_id").Value)
            Dim drugInfos As DataRow = Await AdminRepository.GetDrugInfoByIDAsync(drugId)

            If drugInfos IsNot Nothing Then
                Dim drugImageFileName As String = drugInfos("drug_image").ToString()
                Dim imagePath As String = "C:\Visual Basic\butika-extension\butika-extension\Resources\drug_images\" & drugImageFileName

                If System.IO.File.Exists(imagePath) Then
                    verificationImage.Image = Image.FromFile(imagePath)
                    verificationImage.SizeMode = PictureBoxSizeMode.StretchImage
                    verificationImage.Width = 100
                    verificationImage.Height = 100
                Else
                    MessageBox.Show("Image file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
            Dim drugInfo As DataRow = Await AdminRepository.GetDrugInfoByIDAsync(medicineId)
            If drugInfo IsNot Nothing Then
                id.Text = drugInfo("drug_id").ToString()
                namedata.Text = drugInfo("drug_name").ToString()
                branddata.Text = drugInfo("drug_manufacturer").ToString()
                pricedata.Text = "₱" & FormatNumber(drugInfo("drug_price"), 2)
                expirydata.Text = CType(drugInfo("expiration_date"), DateTime).ToString("yyyy-MM-dd")
                stockdata.Text = drugInfo("drug_stocks").ToString()

                UIHelper.CenterLabelsHorizontallyInPanels(namedata, branddata)
            End If

            reqstock.Text = row.Cells("Requested_Quantity").Value.ToString()
            reqdate.Text = Convert.ToDateTime(row.Cells("Request_Date").Value).ToShortDateString()
            If row.Cells("Request_Status").Value IsNot Nothing Then
                Dim requestStatus As Integer = Convert.ToInt32(row.Cells("Request_Status").Value)
                Select Case requestStatus
                    Case 0
                        reqstatus.Text = "Pending"
                        approveBtn.Visible = True
                        declineBtn.Visible = True
                    Case 1
                        reqstatus.Text = "Approved"
                        approveBtn.Visible = False
                        declineBtn.Visible = False
                    Case 2
                        reqstatus.Text = "Declined"
                        approveBtn.Visible = False
                        declineBtn.Visible = False
                    Case Else
                        reqstatus.Text = "Unknown"
                End Select
            End If
        End If
    End Sub

    Private Async Sub approveBtn_Click(sender As Object, e As EventArgs) Handles approveBtn.Click
        If reqstatus.Text = "Approved" Or reqstatus.Text = "Declined" Then
            MessageBox.Show("This request has already been processed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to approve this request?", "Confirm Approval", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            reqstatus.Text = "Approved"

            Await AdminRepository.UpdateRequestStatusInDatabase(1, id.Text)

            Await ReloadStockReportDataAsync()

            approveBtn.Visible = False
            declineBtn.Visible = False

            Await UpdateRequestStatusLabelsAsync()

            MessageBox.Show("Request approved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Await AdminRepository.AddActivityLogAsync(SessionInfo.CurrentUserID, SessionInfo.CurrentUserType, $"approved stock request | ID:{id.Text}")
        End If
    End Sub

    Private Async Sub declineBtn_Click(sender As Object, e As EventArgs) Handles declineBtn.Click
        If reqstatus.Text = "Approved" Or reqstatus.Text = "Declined" Then
            MessageBox.Show("This request has already been processed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to decline this request?", "Confirm Decline", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            reqstatus.Text = "Declined"

            Await AdminRepository.UpdateRequestStatusInDatabase(2, id.Text)

            Await ReloadStockReportDataAsync()

            approveBtn.Visible = False
            declineBtn.Visible = False

            Await UpdateRequestStatusLabelsAsync()

            MessageBox.Show("Request declined successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Await AdminRepository.AddActivityLogAsync(SessionInfo.CurrentUserID, SessionInfo.CurrentUserType, $"declined stock request | ID:{id.Text}")
        End If
    End Sub


    Private Async Function ReloadStockReportDataAsync() As Task
        Dim dt As DataTable = Await AdminRepository.GetStockReportDataAsync()
        stockTable.DataSource = dt
    End Function

    Private Sub verificationImage_Click(sender As Object, e As EventArgs) Handles verificationImage.Click
        If verificationImage.Image IsNot Nothing Then
            UIHelper.ShowCenteredImagePreview(verificationImage.Image, Me)
        End If
    End Sub
    Private Async Sub pendingBtn_Click(sender As Object, e As EventArgs) Handles pendingBtn.Click
        Dim dt As DataTable = Await AdminRepository.GetStockReportDataAsync(0)
        stockTable.DataSource = dt
    End Sub

    Private Async Sub approvedShow_Click(sender As Object, e As EventArgs) Handles approvedShow.Click
        Dim dt As DataTable = Await AdminRepository.GetStockReportDataAsync(1)
        stockTable.DataSource = dt
    End Sub

    Private Async Sub declinedShow_Click(sender As Object, e As EventArgs) Handles declinedShow.Click
        Dim dt As DataTable = Await AdminRepository.GetStockReportDataAsync(2)
        stockTable.DataSource = dt
    End Sub

    Private Async Sub allBtn_Click(sender As Object, e As EventArgs) Handles allBtn.Click
        Dim dt As DataTable = Await AdminRepository.GetStockReportDataAsync()
        stockTable.DataSource = dt
    End Sub

    Private Async Function UpdateRequestStatusLabelsAsync() As Task
        Dim statusCounts = Await AdminRepository.GetStockRequestStatusCountAsync()

        approvedLabel.Text = statusCounts.approvedCount.ToString()
        declinedLabel.Text = statusCounts.declinedCount.ToString()
    End Function
End Class