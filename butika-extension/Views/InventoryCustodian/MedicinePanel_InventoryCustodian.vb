Public Class MedicinePanel_InventoryCustodian


    Private Sub MedicinePanel_InventoryCustodian_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub selectMedicineBtn_Click(sender As Object, e As EventArgs) Handles selectMedicineBtn.Click
        selectMedicineBtn.Visible = False
        selectMedicineBtn.Enabled = False

        addMedicineBtn.Visible = False
        addMedicineBtn.Enabled = False

        cancelBtn.Enabled = True
        cancelBtn.Visible = True

        selectAllBtn.Visible = True
        selectAllBtn.Enabled = True

        archiveBtn.Visible = True
        archiveBtn.Enabled = True
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        selectMedicineBtn.Visible = True
        selectMedicineBtn.Enabled = True

        addMedicineBtn.Visible = True
        addMedicineBtn.Enabled = True

        cancelBtn.Enabled = False
        cancelBtn.Visible = False

        selectAllBtn.Visible = False
        selectAllBtn.Enabled = False

        archiveBtn.Visible = False
        archiveBtn.Enabled = False
    End Sub

    Private Sub addMedicineBtn_Click(sender As Object, e As EventArgs) Handles addMedicineBtn.Click
        Dim frm As New AddMedicinePanel_InventoryCustodian()
        frm.Show()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim frm As New MedicineIndicators()
        frm.Show()
    End Sub
End Class