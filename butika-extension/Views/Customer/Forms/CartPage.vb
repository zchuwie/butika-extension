Public Class CartPage

#Region "Functions"
    Private Sub underlineFilter(ByVal all As Boolean, ByVal pending As Boolean, ByVal ready As Boolean, ByVal declined As Boolean)
        AllItemsUnderline.Visible = all
        PendingUnderline.Visible = pending
        ReadyUnderline.Visible = ready
        DeclinedUnderline.Visible = declined
    End Sub

#End Region
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CartPage_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Pending_Click(sender As Object, e As EventArgs) Handles Pending.Click
        underlineFilter(False, True, False, False)
    End Sub

    Private Sub AllItems_Click(sender As Object, e As EventArgs) Handles AllItems.Click
        underlineFilter(True, False, False, False)
    End Sub

    Private Sub Ready_Click(sender As Object, e As EventArgs) Handles Ready.Click
        underlineFilter(False, False, True, False)
    End Sub

    Private Sub Declined_Click(sender As Object, e As EventArgs) Handles Declined.Click
        underlineFilter(False, False, False, True)
    End Sub
End Class