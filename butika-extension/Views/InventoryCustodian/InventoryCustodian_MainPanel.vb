Public Class InventoryCustodian_MainPanel
    Private Sub LoadMedicines(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAllMedicines()
    End Sub

    Private Sub LoadAllMedicines()
        Dim frm As New MedicinePanel_InventoryCustodian()

        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        DisplayPanel_InventoryCustodian.Controls.Clear()
        DisplayPanel_InventoryCustodian.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Async Sub dashboard_logout_btn_Click(sender As Object, e As EventArgs) Handles dashboard_logout_btn.Click
        Me.Close()
        Dim userID As Integer = SessionInfo.CurrentUserID
        Dim userType As Integer = SessionInfo.CurrentUserType

        Await AdminRepository.LogLogoutActivity(userID, userType)

        SessionInfo.CurrentUserID = 0
        SessionInfo.CurrentUserType = 0

        Dim frm As New Login
        frm.Show()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Guna2Button2.ForeColor = Color.White

        Dim frm As New StockRequestPanel_InventoryCustodian()

        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        DisplayPanel_InventoryCustodian.Controls.Clear()
        DisplayPanel_InventoryCustodian.Controls.Add(frm)

        frm.Show()
    End Sub

    Private Sub dashboard_medicine_btn_Click(sender As Object, e As EventArgs) Handles dashboard_medicine_btn.Click
        dashboard_medicine_btn.ForeColor = Color.White
        LoadAllMedicines()
    End Sub
End Class