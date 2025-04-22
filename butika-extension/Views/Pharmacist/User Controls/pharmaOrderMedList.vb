Imports butika.Models

Public Class pharmaOrderMedList
    Dim transactions As New Transaction()

    Public Sub Initialize(transac As Transaction)
        Me.transactions = transac

        Dim medName As String = transac.Medicine.FormattedMedicineName
        Dim manufacturer As String = transac.Medicine.MedicineManufacturer
        If medName.Length > 24 Then
            medName = medName.Substring(0, 24) & "..."
        End If

        If manufacturer.Length > 15 Then
            manufacturer = manufacturer.Substring(0, 15) & "..."
        End If

        mednameLbl.Text = medName
        manufacturerLbl.Text = manufacturer
        quantityLbl.Text = transac.Cart.Quantity.ToString()

        If transac.Account?.IsVerified = True Then
            priceLbl.Text = transac.Medicine.DiscountedPrice
        Else
            priceLbl.Text = transac.Medicine.MedicinePrice
        End If
    End Sub
End Class
