Imports butika.Models

Public Class pharmaMedicines
    Private Async Sub pharmaMedicines_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        infoManagerIcon.SetToolTip(infoIcon, "Browse the available medicines in stock. Click on an item to view its description, expiration date, manufacturer, and stock quantity.")
        infoManagerIcon.ShowAlways = True

        Await LoadAllMedicine()
    End Sub
    Public Async Function LoadAllMedicine() As Task
        flpMedicine.Controls.Clear()

        Dim medicineRepo As New MedicineRepository()
        Dim allMedicines As List(Of Medicine) = Await medicineRepo.allMedicines()

        Dim batchSize As Integer = 5

        For i As Integer = 0 To allMedicines.Count - 1 Step batchSize
            Dim batch = allMedicines.Skip(i).Take(batchSize).ToList()

            For Each individualMedicine In batch
                Dim usc As New pharmaMedItem()
                usc.Initialize(individualMedicine)
                flpMedicine.Controls.Add(usc)
            Next

            Await Task.Delay(50)
        Next

    End Function

End Class