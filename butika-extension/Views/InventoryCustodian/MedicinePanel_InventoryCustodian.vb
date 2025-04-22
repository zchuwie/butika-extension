Imports butika.Models

Public Class MedicinePanel_InventoryCustodian


    Private Async Sub MedicinePanel_InventoryCustodian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await loadMedicineBars()
    End Sub


    Private Sub addMedicineBtn_Click(sender As Object, e As EventArgs) Handles addMedicineBtn.Click
        Dim frm As New AddMedicinePanel_InventoryCustodian
        frm.ShowDialog()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim frm As New MedicineIndicators
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


    Private Async Sub search_textbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles search_textbox.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True ' Prevents ding sound and default behavior

            MedicineBarsDisplay.Controls.Clear() ' Optional: clear previous results

            Dim repo As New MedicineRepository()
            Dim results = Await repo.SearchMedicines(search_textbox.Text.Trim())

            Dim batchSize = 5

            For i = 0 To results.Count - 1 Step batchSize
                Dim batch = results.Skip(i).Take(batchSize).ToList()

                For Each med In batch
                    Dim control As New MedicineBars(med)
                    MedicineBarsDisplay.Controls.Add(control)
                Next

                Await Task.Delay(50)
            Next
        End If

    End Sub

    Private Sub archivedMedBtn_Click(sender As Object, e As EventArgs) Handles archivedMedBtn.Click
        Dim frm As New ArchivedMedicines
        frm.ShowDialog()
    End Sub

    Private Async Sub refresh_btn_Click(sender As Object, e As EventArgs) Handles refresh_btn.Click
        Await loadMedicineBars()
    End Sub
End Class