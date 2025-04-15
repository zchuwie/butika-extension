Imports butika.Models

Public Class pharmaPrescriptItem
    Dim prescription As New Prescription()
    Public Sub Initialize(prescript As Prescription)
        Me.prescription = prescript

        prescriptIdLbl.Text = prescript.PrescriptionId.ToString()
        patientLbl.Text = prescript.PatientName
        dateLbl.Text = prescript.PrescriptionDate
    End Sub
    Private Sub morePicture_Click(sender As Object, e As EventArgs) Handles morePicture.Click
        Dim viewPrescript As New pharmaViewPrescription(prescription)
        viewPrescript.ShowDialog()
    End Sub
End Class
