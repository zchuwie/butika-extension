
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

#Region "Inventory Custodian"

    Public Async Function medicineBars() As Task(Of List(Of Medicine))
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
                    expiration_date AS MedicineExpirationDate
                FROM drug_inventory"
            Dim result = Await conn.QueryAsync(Of Medicine)(query)
            Return result.ToList()
        End Using
    End Function

    Public Async Function UpdateMedicine(medicine As Medicine) As Task(Of Boolean)
        Dim query As String = "
        UPDATE drug_inventory
        SET 
            drug_name = @MedicineName,
            drug_brand = @MedicineBrand,
            drug_dosage = @MedicineDosage,
            drug_manufacturer = @MedicineManufacturer,
            drug_description = @MedicineDescription,
            drug_price = @MedicinePrice,
            drug_piece = @MedicinePiece,
            drug_image = @MedicineImageName,
            drug_type = @MedicineType,
            prescription_needed = @MedicinePrescription, 
            expiration_date = @MedicineExpirationDate,
            isSelected = @MedicineTickBox,
            date_updated = @MedicineLastUpdated
        WHERE drug_id = @MedicineID
    "

        Using conn = DatabaseConnection.GetConnection()
            Await conn.OpenAsync()
            Dim affectedRows = Await conn.ExecuteAsync(query, New With {
            medicine.MedicineName,
            medicine.MedicineBrand,
            medicine.MedicineDosage,
            medicine.MedicineManufacturer,
            medicine.MedicineDescription,
            medicine.MedicinePrice,
            .MedicinePiece = 1, ' or set based on form
            medicine.MedicineImageName,
            medicine.MedicineType,
            medicine.MedicinePrescription,
            medicine.MedicineExpirationDate,
            medicine.MedicineTickBox,
            medicine.MedicineLastUpdated,
            medicine.MedicineID
        })
            Return affectedRows > 0
        End Using
    End Function

    Public Async Function AddMedicine(medicine As Medicine) As Task
        Using conn = DatabaseConnection.GetConnection()
            ' Updated SQL query with the correct column names from your table
            Dim query As String = "
                INSERT INTO drug_inventory (drug_name, drug_brand, drug_dosage, drug_manufacturer, drug_description, drug_price, drug_type, prescription_needed, drug_stocks, expiration_date, drug_image)
                VALUES (@MedicineName, @Brand, @Dosage, @Manufacturer, @Description, @Price, @MedicineType, @PrescriptionNeeded, @Stock, @ExpirationDate, @ImageName)"

            ' Ensure the anonymous object has matching parameter names
            Await conn.ExecuteAsync(query, New With {
                    .MedicineName = medicine.MedicineName,
                    .Brand = medicine.MedicineBrand,
                    .Dosage = medicine.MedicineDosage,
                    .Manufacturer = medicine.MedicineManufacturer,
                    .Description = medicine.MedicineDescription,
                    .Price = medicine.MedicinePrice,
                    .MedicineType = medicine.MedicineType,
                    .PrescriptionNeeded = medicine.MedicinePrescription,
                    .Stock = medicine.MedicineStock,
                    .ExpirationDate = medicine.MedicineExpirationDate,
                    .ImageName = medicine.MedicineImageName
                })

            MessageBox.Show("Medicine added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Using


    End Function

    Public Async Function SubmitStockRequest(medicine As Medicine) As Task
        Using conn = DatabaseConnection.GetConnection
            Await conn.OpenAsync()

            Dim query As String = "
            INSERT INTO stockReport (
                stockRequestStatus, 
                stockQuantityRequest, 
                medicine_id, 
                stockDateRequested
            )
            VALUES (
                @Status, 
                @Quantity, 
                @MedicineID, 
                @DateRequested
            );"

            Dim parameters = New With {
                .Status = 0,
                .Quantity = medicine.StockQuantityRequest,
                .MedicineID = medicine.MedicineID,
                .DateRequested = DateTime.Now
            }

            Await conn.ExecuteAsync(query, parameters)
        End Using
    End Function

    Public Async Function IsDuplicateStockRequest(medicineId As Integer) As Task(Of Boolean)
        Using conn = DatabaseConnection.GetConnection()
            Await conn.OpenAsync()

            Dim query As String = "
            SELECT COUNT(*) 
            FROM stockReport 
            WHERE medicine_id = @MedicineID AND stockRequestStatus = 0"

            Dim count As Integer = Await conn.ExecuteScalarAsync(Of Integer)(query, New With {.MedicineID = medicineId})

            Return count > 0
        End Using
    End Function

    Public Async Function IsStockRequestApproved(medicineId As Integer) As Task(Of Boolean)
        Using conn = DatabaseConnection.GetConnection()
            Await conn.OpenAsync()

            Dim query As String = "
            SELECT COUNT(*) 
            FROM stockReport 
            WHERE medicine_id = @MedicineID AND stockRequestStatus = 0"

            Dim count As Integer = Await conn.ExecuteScalarAsync(Of Integer)(query, New With {.MedicineID = medicineId})

            Return count > 0
        End Using
    End Function

#End Region

End Class
