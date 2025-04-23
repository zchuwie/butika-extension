Imports butika.Models
Imports Org.BouncyCastle.Math
Imports PdfSharp

Public Class prescItem
    Dim prescript As New Prescription()
    Dim account As New Account()

    Public Sub New(acc As Account)
        Me.account = acc

        InitializeComponent()
    End Sub

    Public Sub Initialize(prescript As Prescription)
        Me.prescript = prescript

        PrescNo.Text = "Prescription No: " + prescript.PrescriptionId.ToString()
        DateSub.Text = "Date submitted: " + prescript.PrescriptionDate.ToString()
        ClickAll()
        statusChecker()
    End Sub

    Public Sub statusChecker()
        If prescript.PrescriptionStatus = 0 Then
            Status.Text = "Pending"
            Status.ForeColor = Color.Olive
        ElseIf prescript.PrescriptionStatus = 1 Then
            Status.Text = "Approved"
            Status.ForeColor = Color.Green
        ElseIf prescript.PrescriptionStatus = 2 Then
            Status.Text = "Declined"
            Status.ForeColor = Color.Red
        End If
    End Sub

    Private Sub prescItem_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Dim mainForm As PrescriptionPage = TryCast(Me.Parent.FindForm(), PrescriptionPage)
        If mainForm IsNot Nothing Then
            Dim formDetails As New PrescriptionForm(account, prescript)
            mainForm.addPrescriptionUserToPanel(formDetails)
        End If
    End Sub
    Private Sub ClickAll()
        AddHandler PrescNo.Click, Sub(sender, e) Call prescItem_Click(sender, e)
        AddHandler DateSub.Click, Sub(sender, e) Call prescItem_Click(sender, e)
        AddHandler StatusLbl.Click, Sub(sender, e) Call prescItem_Click(sender, e)
        AddHandler Status.Click, Sub(sender, e) Call prescItem_Click(sender, e)
    End Sub
End Class
