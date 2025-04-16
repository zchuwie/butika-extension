Imports butika.Models

Public Class HomePage
    Dim account As New Account()

    Public Sub New(account As Account)
        InitializeComponent()
        Me.account = account
    End Sub

    Private Sub carousel2_Click(sender As Object, e As EventArgs) Handles carousel2.Click
        dashboardPctBx.Image = My.Resources.monthly
        carousel2.FillColor = Color.FromArgb(22, 66, 60)
        carousel1.FillColor = Color.Silver
    End Sub

    Private Sub carousel1_Click(sender As Object, e As EventArgs) Handles carousel1.Click
        dashboardPctBx.Image = My.Resources.welcomehere
        carousel1.FillColor = Color.FromArgb(22, 66, 60)
        carousel2.FillColor = Color.Silver
    End Sub

End Class