Imports butika.Models
Imports Guna.UI2.WinForms.Suite

Public Class pharmaPrescriptions
    Dim prescriptRepo As New PharmaRepository()
    Dim allPrescriptions As List(Of Prescription)

    Private currentFilter As String
    Private Sub changeFilter(allprescript As Boolean, pending As Boolean, declined As Boolean)
        allprescriptPnl.Visible = allprescript
        pendingPnl.Visible = pending
        declinedPnl.Visible = declined

        If allprescript = True Then
            allprescriptLbl.ForeColor = Color.FromArgb(22, 66, 60)
        Else
            allprescriptLbl.ForeColor = Color.Gray
        End If

        If pending = True Then
            pendingLbl.ForeColor = Color.FromArgb(22, 66, 60)
        Else
            pendingLbl.ForeColor = Color.Gray
        End If

        If declined = True Then
            declineLbl.ForeColor = Color.FromArgb(22, 66, 60)
        Else
            declineLbl.ForeColor = Color.Gray
        End If
    End Sub
    Private Async Sub pharmaPrescriptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        infoManagerIcon.SetToolTip(infoIcon, "Access all pending, declined, and approved prescriptions. Click on a pending prescription to review and determine whether to approve or decline it.")
        infoManagerIcon.ShowAlways = True

        changeFilter(True, False, False)
        Await LoadAllPrescriptions(True, False, False)
    End Sub
    Public Async Function LoadAllPrescriptions(all As Boolean, pending As Boolean, declined As Boolean) As Task
        If all = True Then
            allPrescriptions = Await prescriptRepo.GetAllPrescriptions()
        ElseIf pending = True Then
            allPrescriptions = Await prescriptRepo.GetAllPendingPRescriptions()
        ElseIf declined = True Then
            allPrescriptions = Await prescriptRepo.GetAllDeclinedPRescriptions()
        End If

        Dim batchSize As Integer = 5

        For i As Integer = 0 To allPrescriptions.Count - 1 Step batchSize
            Dim batch = allPrescriptions.Skip(i).Take(batchSize).ToList()
            For Each indivPrescript In batch
                Dim usc As New pharmaPrescriptItem()
                usc.Initialize(indivPrescript)
                flpPrescript.Controls.Add(usc)
            Next
            Await Task.Delay(50)
        Next
    End Function

    Private Async Sub allprescriptLbl_Click(sender As Object, e As EventArgs) Handles allprescriptLbl.Click
        currentFilter = "All"
        changeFilter(True, False, False)
        Await LoadAllPrescriptions(True, False, False)
    End Sub

    Private Async Sub pendingLbl_Click(sender As Object, e As EventArgs) Handles pendingLbl.Click
        currentFilter = "Pending"
        changeFilter(False, True, False)
        Await LoadAllPrescriptions(False, True, False)
    End Sub

    Private Async Sub declineLbl_Click(sender As Object, e As EventArgs) Handles declineLbl.Click
        currentFilter = "Declined"
        changeFilter(False, False, True)
        Await LoadAllPrescriptions(False, False, True)
    End Sub

    Private Async Sub sortBtn_Click(sender As Object, e As EventArgs) Handles sortBtn.Click
        Dim isAscending As Boolean = sortBtn.Text = "Ascending Date"

        Select Case currentFilter
            Case "All"
                allPrescriptions = If(isAscending, Await prescriptRepo.SortAllPrescriptionAsc(), Await prescriptRepo.SortAllPrescriptionDesc())
            Case "Pending"
                allPrescriptions = If(isAscending, Await prescriptRepo.SortPendingPrescriptionAsc(), Await prescriptRepo.SortPendingPrescriptionDesc())
            Case "Declined"
                allPrescriptions = If(isAscending, Await prescriptRepo.SortDeclinedPrescriptionAsc(), Await prescriptRepo.SortDeclinedPrescriptionDesc())
        End Select

        sortBtn.Text = If(isAscending, "Descending Date", "Ascending Date")
        DisplayTransactions(allPrescriptions)
    End Sub

    Private Sub DisplayTransactions(prescriptions As List(Of Prescription))
        flpPrescript.Controls.Clear()
        For Each indivPrescript In prescriptions
            Dim usc As New pharmaPrescriptItem()
            usc.Initialize(indivPrescript)
            flpPrescript.Controls.Add(usc)
        Next
    End Sub
End Class