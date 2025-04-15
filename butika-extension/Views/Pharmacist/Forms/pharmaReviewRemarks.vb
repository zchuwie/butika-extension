Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports butika.Models

Public Class pharmaReviewRemarks
    Dim prescription As New Prescription()
    Dim pharmarepo As New PharmaRepository()

    Dim agp As String = "Against Pharmacy Policies"
    Dim idi As String = "Invalid Doctor's Information"
    Dim piv As String = "Prescription Invalid"
    Dim naa As String = "Not Age Appropriate"
    Public Sub New(prescript As Prescription)
        Me.prescription = prescript
        InitializeComponent()
    End Sub

    Private Sub otherBtn_Click(sender As Object, e As EventArgs) Handles otherBtn.Click
        otherTxt.Enabled = True
    End Sub

    Private Sub againstBtn_Click(sender As Object, e As EventArgs) Handles againstBtn.Click
        prescription.PrescriptionRemarks = agp
    End Sub

    Private Sub invaliddoctorBtn_Click(sender As Object, e As EventArgs) Handles invaliddoctorBtn.Click
        prescription.PrescriptionRemarks = idi
    End Sub

    Private Sub prescriptinvalidBtn_Click(sender As Object, e As EventArgs) Handles prescriptinvalidBtn.Click
        prescription.PrescriptionRemarks = piv
    End Sub

    Private Sub ageinvalidBtn_Click(sender As Object, e As EventArgs) Handles ageinvalidBtn.Click
        prescription.PrescriptionRemarks = naa
    End Sub

    Private Async Sub finishBtn_Click(sender As Object, e As EventArgs) Handles finishBtn.Click
        Dim stats As Integer = 2
        Dim dateReview As DateTime = DateTime.Now

        If otherTxt.Enabled AndAlso Not String.IsNullOrWhiteSpace(otherTxt.Text) Then
            prescription.PrescriptionRemarks = otherTxt.Text
        End If

        usernameLbl.Text = prescription.Account.UserName
        prescription.PrescriptReviewDate = dateReview
        prescription.PrescriptionStatus = stats
        prescription.PrescriptionRemarks = prescription.PrescriptionRemarks

        Dim isFormSuccess As Boolean = Await pharmarepo.UpdateRemarks(prescription)
        Me.Close()
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Me.Close()
    End Sub
End Class