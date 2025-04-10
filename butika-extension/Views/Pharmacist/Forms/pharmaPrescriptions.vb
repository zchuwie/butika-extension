Public Class pharmaPrescriptions
    Private Sub changeFilter(allprescript As Boolean, pending As Boolean, declined As Boolean)
        allprescriptPnl.Visible = allprescript
        pendingPnl.Visible = pending
        declinedPnl.Visible = declined
    End Sub
    Private Sub pharmaPrescriptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        infoManagerIcon.SetToolTip(infoIcon, "Access all pending, declined, and approved prescriptions. Click on a pending prescription to review and determine whether to approve or decline it.")
        infoManagerIcon.ShowAlways = True

        changeFilter(True, False, False)
    End Sub

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