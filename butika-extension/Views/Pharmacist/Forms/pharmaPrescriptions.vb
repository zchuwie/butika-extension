Imports butika.Models

Public Class pharmaPrescriptions
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
    Private Sub pharmaPrescriptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        infoManagerIcon.SetToolTip(infoIcon, "Access all pending, declined, and approved prescriptions. Click on a pending prescription to review and determine whether to approve or decline it.")
        infoManagerIcon.ShowAlways = True

        changeFilter(True, False, False)
        LoadAllPrescriptions()
    End Sub
    Public Async Function LoadAllPrescriptions() As Task
        flpPrescript.Controls.Clear()

        Dim prescriptRepo As New PharmaRepository()
        Dim allPrescriptions As List(Of Prescription) = Await prescriptRepo.GetAllPrescriptions()

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

    Private Sub allprescriptLbl_Click(sender As Object, e As EventArgs) Handles allprescriptLbl.Click
        changeFilter(True, False, False)
    End Sub

    Private Sub pendingLbl_Click(sender As Object, e As EventArgs) Handles pendingLbl.Click
        changeFilter(False, True, False)
    End Sub

    Private Sub declineLbl_Click(sender As Object, e As EventArgs) Handles declineLbl.Click
        changeFilter(False, False, True)
    End Sub
End Class