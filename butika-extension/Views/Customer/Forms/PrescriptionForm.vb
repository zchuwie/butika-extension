Imports System.IO
Imports butika.Models

Public Class PrescriptionForm

    Dim account As New Account()
    Dim prescript As New Prescription()

    Public Sub New(account As Account, prescript As Prescription)
        Me.account = account
        Me.prescript = prescript
        InitializeComponent()
    End Sub

    Private Sub displayDetails()
        PrescNo.Text = "Prescription No. " + prescript.PrescriptionId.ToString()
        PatientName.Text = prescript.PatientName
        Age.Text = prescript.PatientAge
        DoctorName.Text = prescript.DoctorName
        Clinic.Text = prescript.DoctorPlace
        Contact.Text = prescript.DoctorContact
        BriefInfo.Text = prescript.PatientConcern
        DateSubmitted.Text = prescript.PrescriptionDate
        PrescDigiCopy.Image = Image.FromFile(prescript.PresciptImagePath)

        ReviewDate.Text = If(prescript.PrescriptReviewDate, "Under Review")
        If prescript.PrescriptionStatus = 1 Then
            Remark.Text = "Approved"
        ElseIf prescript.PrescriptionStatus = 2 Then
            Remark.Text = prescript.PrescriptionRemarks
        End If

    End Sub

    Private Sub PrescriptionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayDetails()
    End Sub
End Class