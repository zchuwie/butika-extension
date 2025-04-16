Imports butika.Models

Public Class MedicinePanel_InventoryCustodian


    Private Async Sub MedicinePanel_InventoryCustodian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await loadMedicineBars()
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
        frm.ShowDialog()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim frm As New MedicineIndicators()
        frm.ShowDialog()
    End Sub


    Public Async Function loadMedicineBars() As Task
        MedicineBarsDisplay.Controls.Clear()

        Dim medicineRepo As New MedicineRepository()
        Dim medicines As List(Of Medicine) = Await medicineRepo.medicineBars()

        Dim batchSize As Integer = 5

        For i As Integer = 0 To medicines.Count - 1 Step batchSize
            Dim batch = medicines.Skip(i).Take(batchSize).ToList()

            For Each med In batch
                Dim control As New MedicineBars(med)
                MedicineBarsDisplay.Controls.Add(control)
            Next

            Await Task.Delay(50)
        Next
    End Function

End Class