Imports butika.Configurations
Imports butika.Models
Imports Dapper

Public Class MedicineRepository
    Public Async Function allMedicines() As Task(Of List(Of Medicine))
        Using conn = DatabaseConnection.GetConnection()
            Await conn.OpenAsync()
            Dim query = "
                SELECT 
                    drug_id AS MedicineID,
                    drug_name AS MedicineName,
                    drug_brand AS MedicineBrand,
                    drug_dosage AS MedicineDosage,
                    drug_manufacturer AS MedicineManufacturer,
                    drug_description AS MedicineDescription,
                    drug_price AS MedicinePrice,
                    drug_image AS MedicineImageName,
                    drug_type AS MedicineType,
                    prescription_needed AS MedicinePrescription,
                    drug_stocks AS MedicineStock,
                    expiration_date AS MedicineExpirationDate,
                    isSelected AS MedicineTickBox
                FROM drug_inventory"
            Dim result = Await conn.QueryAsync(Of Medicine)(query)
            Return result.ToList()
        End Using
    End Function

    Public Async Function otcMedicines() As Task(Of List(Of Medicine))
        Using conn = DatabaseConnection.GetConnection()
            Await conn.OpenAsync()
            Dim query = "
                SELECT 
                    drug_id AS MedicineID,
                    drug_name AS MedicineName,
                    drug_brand AS MedicineBrand,
                    drug_dosage AS MedicineDosage,
                    drug_manufacturer AS MedicineManufacturer,
                    drug_description AS MedicineDescription,
                    drug_price AS MedicinePrice,
                    drug_image AS MedicineImageName,
                    drug_type AS MedicineType,
                    prescription_needed AS MedicinePrescription,
                    drug_stocks AS MedicineStock,
                    expiration_date AS MedicineExpirationDate,
                    isSelected AS MedicineTickBox
                FROM drug_inventory
                WHERE prescription_needed = 0"
            Dim result = Await conn.QueryAsync(Of Medicine)(query)
            Return result.ToList()
        End Using
    End Function

    Public Async Function prescriptionMedicines() As Task(Of List(Of Medicine))
        Using conn = DatabaseConnection.GetConnection()
            Await conn.OpenAsync()
            Dim query = "
                SELECT 
                    drug_id AS MedicineID,
                    drug_name AS MedicineName,
                    drug_brand AS MedicineBrand,
                    drug_dosage AS MedicineDosage,
                    drug_manufacturer AS MedicineManufacturer,
                    drug_description AS MedicineDescription,
                    drug_price AS MedicinePrice,
                    drug_image AS MedicineImageName,
                    drug_type AS MedicineType,
                    prescription_needed AS MedicinePrescription,
                    drug_stocks AS MedicineStock,
                    expiration_date AS MedicineExpirationDate,
                    isSelected AS MedicineTickBox
                FROM drug_inventory
                WHERE prescription_needed = 1"
            Dim result = Await conn.QueryAsync(Of Medicine)(query)
            Return result.ToList()
        End Using
    End Function

End Class
