Imports butika.Models

Public Class pharmaDashPrescript
    Dim prescription As New Prescription()
    Public Sub Initialize(prescript As Prescription)
        Me.prescription = prescript

        usernameLbl.Text = prescript.Account.UserName
        If prescript.PrescriptionStatus = 0 Then
            statusLbl.Text = "Pending"
        ElseIf prescript.PrescriptionStatus = 1 Then
            statusLbl.Text = "Approved"
        ElseIf prescript.PrescriptionStatus = 2 Then
            statusLbl.Text = "Declined"
        End If
    End Sub
End Class
