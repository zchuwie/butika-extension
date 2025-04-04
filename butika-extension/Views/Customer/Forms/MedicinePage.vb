Imports Guna.UI2.WinForms

Public Class MedicinePage

#Region "Functions"
    Private Sub underlineFilter(ByVal med As Boolean, ByVal otc As Boolean, ByVal presc As Boolean)
        AllMedsUnderline.Visible = med
        OTCUnderline.Visible = otc
        PrescUnderline.Visible = presc
    End Sub

#End Region

    Private Sub MedicinePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MedicineBindingSource_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub AllMeds_Click(sender As Object, e As EventArgs) Handles AllMeds.Click
        underlineFilter(True, False, False)
    End Sub

    Private Sub OverTheCounter_Click(sender As Object, e As EventArgs) Handles OverTheCounter.Click
        underlineFilter(False, True, False)
    End Sub

    Private Sub NeedsPrescription_Click(sender As Object, e As EventArgs) Handles NeedsPrescription.Click
        underlineFilter(False, False, True)
    End Sub
End Class