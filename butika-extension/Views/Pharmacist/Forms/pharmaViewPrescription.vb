Imports butika.Models

Public Class pharmaViewPrescription
    Dim prescription As New Prescription()
    Public Sub New(prescript As Prescription)
        Me.prescription = prescript

        InitializeComponent()
    End Sub
    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub
    Private Sub LoadAllInformation(prescript As Prescription)
        patientnameTxt.Text = prescript.PatientName
        patientageTxt.Text = prescript.PatientAge
        dateLbl.Text = prescript.PrescriptionDate
        doctornameTxt.Text = prescript.DoctorName
        contactTxt.Text = prescript.DoctorContact
        clinicTxt.Text = prescript.DoctorPlace
        briefinfoTxt.Text = prescript.PatientConcern
        prescriptImage.Image = Image.FromFile(prescript.PresciptImagePath)
    End Sub

    Private Sub pharmaViewPrescription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAllInformation(prescription)
    End Sub
End Class