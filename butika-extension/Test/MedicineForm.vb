Public Class MedicineForm
    Private ReadOnly repo As New RepositoryTest()
    Private Sub MedicineForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMedicines()
    End Sub

    Public Sub LoadMedicines()
        Try
            layoutTest.Controls.Clear()

            Dim medicines = repo.GetMedicines()
            For Each medicine In medicines
                Dim card = New Card()
                card.Initialize(medicine)
                layoutTest.Controls.Add(card)
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class