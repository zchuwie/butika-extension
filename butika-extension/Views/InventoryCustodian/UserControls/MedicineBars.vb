Public Class MedicineBars
    Private Sub LoadSelectedMedicine()
        Dim frm As New ViewMedicineBar()
        frm.Show()
    End Sub

    Private Sub Guna2CustomGradientPanel1_MouseLeave(sender As Object, e As EventArgs) Handles Guna2CustomGradientPanel1.MouseLeave, Guna2CustomGradientPanel1.Click, MyBase.Click
        LoadSelectedMedicine()
    End Sub
End Class
