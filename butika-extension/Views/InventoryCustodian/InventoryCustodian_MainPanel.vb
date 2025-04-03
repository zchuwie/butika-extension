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
End Class