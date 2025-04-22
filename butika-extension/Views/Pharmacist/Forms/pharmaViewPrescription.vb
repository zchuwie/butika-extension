Imports System.Threading
Imports butika.Models

Public Class pharmaViewPrescription
    Dim prescription As New Prescription()
    Dim cart As New Cart()
    Dim pharmarepo As New PharmaRepository()
    Public Sub New(prescript As Prescription)
        Me.prescription = prescript

        InitializeComponent()
    End Sub
    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub
    Private Sub LoadAllInformation(prescript As Prescription)
        usernameLbl.Text = prescript.Account.UserName
        prescriptNumLbl.Text = prescript.PrescriptionId
        patientnameTxt.Text = prescript.PatientName
        patientageTxt.Text = prescript.PatientAge
        dateLbl.Text = prescript.PrescriptionDate
        doctornameTxt.Text = prescript.DoctorName
        contactTxt.Text = prescript.DoctorContact
        clinicTxt.Text = prescript.DoctorPlace
        briefinfoTxt.Text = prescript.PatientConcern
        remarksLbl.Text = If(prescript.PrescriptionRemarks, "Pending")
        reviewdateLbl.Text = If(prescript.PrescriptReviewDate, "Pending")
        prescriptImage.Image = Image.FromFile(prescript.PresciptImagePath)

        If prescript.PrescriptionStatus = 0 Then
            statusLbl.Text = "Pending"
        ElseIf prescript.PrescriptionStatus = 1 Then
            statusLbl.Text = "Approved"
        ElseIf prescript.PrescriptionStatus = 2 Then
            statusLbl.Text = "Declined"
        End If
        If prescript.PrescriptionStatus = 0 Then
            declineBtn.Visible = True
            approveBtn.Visible = True
        Else
            declineBtn.Visible = False
            approveBtn.Visible = False
        End If
    End Sub

    Private Async Sub pharmaViewPrescription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAllInformation(prescription)
        Dim medicines As List(Of Medicine) = Await pharmarepo.GetItemIntoListBox(prescription.PrescriptionId, prescription.Account.UserID)
        displayToApproved.Items.Clear()

        For Each med In medicines
            displayToApproved.Items.Add($"{med.MedicineName} | {med.MedicineBrand} | {med.MedicineDosage}")
        Next
    End Sub

    Private Sub declineBtn_Click(sender As Object, e As EventArgs) Handles declineBtn.Click
        Dim viewRemarks As New pharmaReviewRemarks(prescription, Me)
        viewRemarks.ShowDialog()
    End Sub

    Private Async Sub approveBtn_Click(sender As Object, e As EventArgs) Handles approveBtn.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to approve the prescription?", "Confirmation",
                                                     MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim dateReview As DateTime = DateTime.Now
            Dim stats As Integer = 1
            Dim isapproved As Integer = 1
            Dim remark As String = "Approved"

            prescription.PrescriptReviewDate = dateReview
            prescription.PrescriptionStatus = stats
            prescription.PrescriptionRemarks = remark
            If prescription.Cart Is Nothing Then
                prescription.Cart = New Cart()
            End If
            prescription.Cart.isApproved = isapproved


            Dim isFormSuccess As Boolean = Await pharmarepo.PharmaAction(prescription)

            If Not isFormSuccess Then
                MessageBox.Show("Execution error.")
            End If
        Else
            MessageBox.Show("Changes were not saved.")
        End If
        Me.Close()
    End Sub
End Class