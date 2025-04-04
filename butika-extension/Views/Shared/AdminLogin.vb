Public Class AdminLogin
    Private Sub adminBtn_Click(sender As Object, e As EventArgs) Handles adminBtn.Click
        Dim admin As New adminPage()
        admin.Show()
        Me.Close()

    End Sub

    Private Sub inveBtn_Click(sender As Object, e As EventArgs) Handles inveBtn.Click
        Dim custodian As New InventoryCustodian_MainPanel()
        custodian.Show()
        Me.Close()
    End Sub

    Private Sub pharmaBtn_Click(sender As Object, e As EventArgs) Handles pharmaBtn.Click
        Dim pharmacist As New pharmaMainPage()
        pharmacist.Show()
        Me.Close()
    End Sub

End Class