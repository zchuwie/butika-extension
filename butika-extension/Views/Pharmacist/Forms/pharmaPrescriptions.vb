Public Class pharmaPrescriptions
    Private Sub pharmaPrescriptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        infoManagerIcon.SetToolTip(infoIcon, "Access all pending, declined, and approved prescriptions. Click on a pending prescription to review and determine whether to approve or decline it.")
        infoManagerIcon.ShowAlways = True

        allprescriptPnl.Visible = True
        pendingPnl.Visible = False
        declinedPnl.Visible = False
    End Sub

    Private Sub allprescriptLbl_Click(sender As Object, e As EventArgs) Handles allprescriptLbl.Click
        allprescriptPnl.Visible = True
        pendingPnl.Visible = False
        declinedPnl.Visible = False
    End Sub

    Private Sub pendingLbl_Click(sender As Object, e As EventArgs) Handles pendingLbl.Click
        allprescriptPnl.Visible = False
        pendingPnl.Visible = True
        declinedPnl.Visible = False
    End Sub

    Private Sub declineLbl_Click(sender As Object, e As EventArgs) Handles declineLbl.Click
        allprescriptPnl.Visible = False
        pendingPnl.Visible = False
        declinedPnl.Visible = True
    End Sub
End Class