Imports butika.Models

Public Class pharmaMedicines
    Dim medicineRepo As New MedicineRepository()
    Dim pharmarepo As New PharmaRepository()
    Dim allMedicines As List(Of Medicine)
    Private Async Sub pharmaMedicines_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadAllMedicine()
    End Sub
    Public Async Function LoadAllMedicine() As Task
        allMedicines = Await pharmarepo.AllMedicines()

        Dim batchSize As Integer = 5
        For i As Integer = 0 To allMedicines.Count - 1 Step batchSize
            Dim batch = allMedicines.Skip(i).Take(batchSize).ToList()

            DisplayMeds(allMedicines)

            Await Task.Delay(50)
        Next

    End Function

    Private Async Sub medicineSearch_TextChanged(sender As Object, e As EventArgs) Handles medicineSearch.TextChanged
        Dim medSearch As String = medicineSearch.Text

        If String.IsNullOrWhiteSpace(medSearch) Then
            allMedicines = Await pharmarepo.AllMedicines()
        Else
            allMedicines = Await pharmarepo.SearchMedicine(medSearch)
        End If
        If allMedicines IsNot Nothing Then
            DisplayMeds(allMedicines)
        End If

    End Sub
    Private Sub DisplayMeds(medicines As List(Of Medicine))
        flpMedicine.Controls.Clear()
        For Each individualMedicine In medicines
            Dim usc As New pharmaMedItem()
            usc.Initialize(individualMedicine)
            flpMedicine.Controls.Add(usc)
        Next
    End Sub
End Class