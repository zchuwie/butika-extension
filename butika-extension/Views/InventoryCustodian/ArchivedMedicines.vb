Imports butika.Models

Public Class ArchivedMedicines
    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Me.Close()
    End Sub

    Public Async Function loadArchivedMedicineBars() As Task
        archivedMedicine_display.Controls.Clear()

        Dim medicineRepo As New MedicineRepository()
        Dim medicines As List(Of Medicine) = Await medicineRepo.archivedMedicineBars()

        Dim batchSize As Integer = 5

        For i As Integer = 0 To medicines.Count - 1 Step batchSize
            Dim batch = medicines.Skip(i).Take(batchSize).ToList()

            For Each med In batch
                Dim control As New ArchivedMedicineBars(med)
                archivedMedicine_display.Controls.Add(control)
            Next

            Await Task.Delay(50)
        Next
    End Function

    Private Async Sub ArchivedMedicines_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await loadArchivedMedicineBars()
    End Sub

    Private Async Sub refresh_btn_Click(sender As Object, e As EventArgs) Handles refresh_btn.Click
        Await loadArchivedMedicineBars()
    End Sub

End Class