Imports butika.Models

Public Class MedicinePage
    Private account As New Account()
    Dim accountRep As New AccountRepository()
    Public Sub New(account As Account)

        InitializeComponent()
        Me.account = account

    End Sub
    Private Sub MedicinePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MedicineBindingSource_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub AllMeds_Click(sender As Object, e As EventArgs) Handles AllMeds.Click
        AllMedsUnderline.Visible = True
        OTCUnderline.Visible = False
        PrescUnderline.Visible = False
    End Sub

    Private Sub OverTheCounter_Click(sender As Object, e As EventArgs) Handles OverTheCounter.Click
        AllMedsUnderline.Visible = False
        OTCUnderline.Visible = True
        PrescUnderline.Visible = False
    End Sub

    Private Sub NeedsPrescription_Click(sender As Object, e As EventArgs) Handles NeedsPrescription.Click
        AllMedsUnderline.Visible = False
        OTCUnderline.Visible = False
        PrescUnderline.Visible = True
    End Sub
End Class