Public Class pharmaTransactions
    Private Sub pharmaTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        infoManagerIcon.SetToolTip(infoIcon, "View recorded transactions and their Transaction IDs. Click on a transaction to see detailed order information and confirm the medicines listed in the receipt.")
        infoManagerIcon.ShowAlways = True
    End Sub
End Class