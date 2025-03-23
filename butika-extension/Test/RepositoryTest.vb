Imports butika.Configurations
Imports butika.Models
Imports Dapper

Public Class RepositoryTest
    Public Function GetMedicines() As List(Of Medicine)
        Using conn = DatabaseConnection.GetConnection()
            conn.Open()
            Dim query = "SELECT drug_name AS MedicineName, drug_price AS MedicinePrice, drug_stocks AS MedicineStock, drug_image AS MedicineImageName FROM drug_inventory"
            Dim result = conn.Query(Of Medicine)(query).ToList()
            Return result
        End Using
    End Function
End Class
