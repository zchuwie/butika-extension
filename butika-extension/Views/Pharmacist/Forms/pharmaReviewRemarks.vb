Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports butika.Models
Imports Guna.UI2.WinForms

Public Class pharmaReviewRemarks
    Dim prescription As New Prescription()
    Dim pharmarepo As New PharmaRepository()
    Dim viewPrescript As Form

    Dim agp As String = "Against Pharmacy Policies"
    Dim idi As String = "Invalid Doctor's Information"
    Dim piv As String = "Prescription Invalid"
    Dim naa As String = "Not Age Appropriate"
    Public Sub New(prescript As Prescription, parent As Form)
        Me.prescription = prescript
        Me.viewPrescript = parent

        InitializeComponent()
    End Sub
    Private Sub ClickedOptionColor(btn As Guna2Button, forecolor As Color, fillcolor As Color)
        btn.FillColor = fillcolor
        btn.ForeColor = forecolor
    End Sub
    Private Sub RefreshButtons(btn1 As Guna2Button, btn2 As Guna2Button, btn3 As Guna2Button, btn4 As Guna2Button, enable As Boolean)
        ClickedOptionColor(btn1, Color.FromArgb(22, 66, 60), Color.FromArgb(220, 229, 219))
        ClickedOptionColor(btn2, Color.FromArgb(22, 66, 60), Color.FromArgb(220, 229, 219))
        ClickedOptionColor(btn3, Color.FromArgb(22, 66, 60), Color.FromArgb(220, 229, 219))
        ClickedOptionColor(btn4, Color.FromArgb(22, 66, 60), Color.FromArgb(220, 229, 219))
        otherTxt.Enabled = enable
    End Sub
    Private Sub otherBtn_Click(sender As Object, e As EventArgs) Handles otherBtn.Click
        RefreshButtons(invaliddoctorBtn, prescriptinvalidBtn, ageinvalidBtn, againstBtn, True)
        ClickedOptionColor(otherBtn, Color.FromArgb(220, 229, 219), Color.FromArgb(22, 66, 60))
    End Sub

    Private Sub againstBtn_Click(sender As Object, e As EventArgs) Handles againstBtn.Click
        prescription.PrescriptionRemarks = agp
        RefreshButtons(invaliddoctorBtn, prescriptinvalidBtn, ageinvalidBtn, otherBtn, False)
        ClickedOptionColor(againstBtn, Color.FromArgb(220, 229, 219), Color.FromArgb(22, 66, 60))
    End Sub

    Private Sub invaliddoctorBtn_Click(sender As Object, e As EventArgs) Handles invaliddoctorBtn.Click
        prescription.PrescriptionRemarks = idi
        RefreshButtons(againstBtn, prescriptinvalidBtn, ageinvalidBtn, otherBtn, False)
        ClickedOptionColor(invaliddoctorBtn, Color.FromArgb(220, 229, 219), Color.FromArgb(22, 66, 60))
    End Sub

    Private Sub prescriptinvalidBtn_Click(sender As Object, e As EventArgs) Handles prescriptinvalidBtn.Click
        prescription.PrescriptionRemarks = piv
        RefreshButtons(invaliddoctorBtn, againstBtn, ageinvalidBtn, otherBtn, False)
        ClickedOptionColor(prescriptinvalidBtn, Color.FromArgb(220, 229, 219), Color.FromArgb(22, 66, 60))
    End Sub

    Private Sub ageinvalidBtn_Click(sender As Object, e As EventArgs) Handles ageinvalidBtn.Click
        prescription.PrescriptionRemarks = naa
        RefreshButtons(invaliddoctorBtn, prescriptinvalidBtn, againstBtn, otherBtn, False)
        ClickedOptionColor(ageinvalidBtn, Color.FromArgb(220, 229, 219), Color.FromArgb(22, 66, 60))
    End Sub

    Private Async Sub finishBtn_Click(sender As Object, e As EventArgs) Handles finishBtn.Click
        Dim stats As Integer = 2
        Dim isapproved As Integer = 2
        Dim dateReview As DateTime = DateTime.Now

        If otherTxt.Enabled AndAlso Not String.IsNullOrWhiteSpace(otherTxt.Text) Then
            prescription.PrescriptionRemarks = otherTxt.Text
        End If

        usernameLbl.Text = prescription.Account.UserName
        prescription.PrescriptReviewDate = dateReview
        prescription.PrescriptionStatus = stats
        If prescription.Cart Is Nothing Then
            prescription.Cart = New Cart()
        End If
        prescription.Cart.isApproved = isapproved

        Dim isFormSuccess As Boolean = Await pharmarepo.PharmaAction(prescription)
        viewPrescript.Close()
        Me.Close()
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Me.Close()
    End Sub
End Class