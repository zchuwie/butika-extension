Public Class pharmaMedicines
    Private Sub pharmaMedicines_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        infoManagerIcon.SetToolTip(infoIcon, "Browse the available medicines in stock. Click on an item to view its description, expiration date, manufacturer, and stock quantity.")
        infoManagerIcon.ShowAlways = True
    End Sub
End Class