Imports butika.Models

Public Class pharmaOrderMedList
    Dim transactions As New Transaction()

    Public Sub Initialize(transac As Transaction)
        Me.transactions = transac

        mednameLbl.Text = transac.Medicine.FormattedMedicineName
        quantityLbl.Text = transac.Cart.Quantity.ToString()
    End Sub
End Class
