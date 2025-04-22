Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports butika.Configurations
Imports butika.Models
Imports Dapper
Imports Microsoft.Data.SqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Public Class PharmaRepository

    ' pangdisplay ng lahat ng transaction
    Public Async Function GetAllTransactions() As Task(Of List(Of Transaction))
        Using conn = DatabaseConnection.GetConnection()
            Await conn.OpenAsync()
            Dim query = "
                SELECT 
                    ut.transaction_id AS TransactionID,
                    ut.transaction_date AS TransactionDate,
                    ua.username AS UserName,
                    ua.user_id AS UserID
                FROM usertransaction ut
                LEFT JOIN useraccount ua ON ut.user_id = ua.user_id"

            Dim result = Await conn.QueryAsync(Of Transaction, Account, Transaction)(
                query,
                Function(tran, acc)
                    tran.Account = acc
                    Return tran
                End Function,
                splitOn:="UserName"
            )
            Return If(result?.ToList(), New List(Of Transaction)())
        End Using
    End Function

    ' pangdisplay ng meds sa order
    Public Async Function GetAllOrderMeds(transactionid As String) As Task(Of List(Of Transaction))
        Using conn = DatabaseConnection.GetConnection()
            Await conn.OpenAsync()
            Dim query = "
            SELECT 
                uc.transaction_id AS TransactionID,
                med.drug_id AS MedicineID,
                med.drug_name AS MedicineName,
                med.drug_manufacturer AS MedicineManufacturer,
                med.drug_price AS MedicinePrice,
                uc.quantity AS Quantity
            FROM userscheckout uc
            LEFT JOIN drug_inventory med ON uc.drug_id = med.drug_id
            WHERE uc.transaction_id = @TransactionID
            "

            Dim result = Await conn.QueryAsync(Of Transaction, Medicine, Cart, Transaction)(
            query,
            Function(tran, med, cart)
                tran.Medicine = med
                tran.Cart = cart
                Return tran
            End Function,
            param:=New With {.TransactionID = transactionid},
            splitOn:="MedicineID,Quantity"
            )

            Return result.ToList()
        End Using
    End Function

    ' pang display sa mga prescriptions
    Public Async Function GetAllPrescriptions() As Task(Of List(Of Prescription))
        Using conn = DatabaseConnection.GetConnection()
            Await conn.OpenAsync()
            Dim query = "
            SELECT 
                up.prescription_id AS PrescriptionId,
                up.patient_name AS PatientName,
                up.patient_age AS PatientAge,
                up.user_concern AS PatientConcern,
                up.doc_name AS DoctorName,
                up.doc_contact AS DoctorContact,
                up.clinic AS DoctorPlace,
                up.prescription_image AS PrescriptionImageName,
                up.remarks AS PrescriptionRemarks,
                up.status AS PrescriptionStatus,
                up.review_date AS PrescriptReviewDate,
                up.prescription_date AS PrescriptionDate,
                ua.username AS UserName,
                ua.user_id AS UserID
            FROM userprescriptionform up
            LEFT JOIN useraccount ua ON up.user_id = ua.user_id
            "

            Dim result = Await conn.QueryAsync(Of Prescription, Account, Prescription)(
            query,
            Function(pres, acc)
                pres.Account = acc
                Return pres
            End Function,
            splitOn:="UserName"
        )

            Return result.ToList()
        End Using
    End Function


    ' pangapprove sa prescription
    Public Async Function UpdateRemarks(prescription As Prescription) As Task(Of Boolean)
        Using conn = DatabaseConnection.GetConnection()
            Await conn.OpenAsync()

            Dim query As String = "
            UPDATE userprescriptionform
            SET remarks = @remarks,
                review_date = @review_date,
                status = @status
            WHERE user_id = @user_id AND prescription_id = @prescription_id"

            Dim param = New With {
                .remarks = prescription.PrescriptionRemarks,
                .status = prescription.PrescriptionStatus,
                .review_date = DateTime.Now,
                .user_id = prescription.Account.UserID,
                .prescription_id = prescription.PrescriptionId
                }

            Dim result As Integer = Await conn.ExecuteAsync(query, param)
            Return result > 0
        End Using
    End Function

    ' para sa sortings sa transactions
    Public Async Function SortAscendingDate() As Task(Of List(Of Transaction))
        Using conn = DatabaseConnection.GetConnection()
            Await conn.OpenAsync()

            Dim query As String = "
                SELECT 
                    ut.transaction_id AS TransactionID,
                    ut.transaction_date AS TransactionDate,
                    ut.user_id AS UserID,
                    ua.username AS UserName,
                    ua.user_id AS UserID
                FROM usertransaction ut
                LEFT JOIN useraccount ua ON ut.user_id = ua.user_id
                ORDER BY ut.transaction_date ASC
            "

            Dim result = Await conn.QueryAsync(Of Transaction, Account, Transaction)(
                query,
                Function(tran, acc)
                    tran.Account = acc
                    Return tran
                End Function,
                splitOn:="UserName"
            )
            Return If(result?.ToList(), New List(Of Transaction)())
        End Using
    End Function
    Public Async Function SortDescendingDate() As Task(Of List(Of Transaction))
        Using conn = DatabaseConnection.GetConnection()
            Await conn.OpenAsync()

            Dim query As String = "
                SELECT 
                    ut.transaction_id AS TransactionID,
                    ut.transaction_date AS TransactionDate,
                    ut.user_id AS UserID,
                    ua.username AS UserName,
                    ua.user_id AS UserID
                FROM usertransaction ut
                LEFT JOIN useraccount ua ON ut.user_id = ua.user_id
                ORDER BY ut.transaction_date DESC
            "

            Dim result = Await conn.QueryAsync(Of Transaction, Account, Transaction)(
                query,
                Function(tran, acc)
                    tran.Account = acc
                    Return tran
                End Function,
                splitOn:="UserName"
            )
            Return If(result?.ToList(), New List(Of Transaction)())
        End Using
    End Function

    ' pangsort sa prescriptions
    Public Async Function SortPrescriptionAsc() As Task(Of List(Of Prescription))
        Using conn = DatabaseConnection.GetConnection()
            Await conn.OpenAsync()
            Dim query = "
                SELECT 
                    up.prescription_id AS PrescriptionId,
                    up.user_id AS UserID,
                    up.user_id AS UserID,
                    up.patient_name AS PatientName,
                    up.patient_age AS PatientAge,
                    up.user_concern AS PatientConcern,
                    up.doc_name AS DoctorName,
                    up.doc_contact AS DoctorContact,
                    up.clinic AS DoctorPlace,
                    up.prescription_image AS PrescriptionImageName,
                    up.remarks AS PrescriptionRemarks,
                    up.status AS PrescriptionStatus,
                    up.review_date AS PrescriptReviewDate,
                    up.prescription_date AS PrescriptionDate,
                    ua.username AS UserName
                FROM userprescriptionform up
                LEFT JOIN useraccount ua ON up.user_id = ua.user_id
                ORDER BY up.prescription_date ASC"
            Dim result = Await conn.QueryAsync(Of Prescription, Account, Prescription)(
                query,
                Function(pres, acc)
                    pres.Account = acc
                    Return pres
                End Function,
                splitOn:="UserName"
            )
            Return result.ToList()
        End Using
    End Function
    Public Async Function SortPrescriptionDesc() As Task(Of List(Of Prescription))
        Using conn = DatabaseConnection.GetConnection()
            Await conn.OpenAsync()
            Dim query = "
                SELECT 
                    up.prescription_id AS PrescriptionId,
                    up.user_id AS UserID,
                    up.user_id AS UserID,
                    up.patient_name AS PatientName,
                    up.patient_age AS PatientAge,
                    up.user_concern AS PatientConcern,
                    up.doc_name AS DoctorName,
                    up.doc_contact AS DoctorContact,
                    up.clinic AS DoctorPlace,
                    up.prescription_image AS PrescriptionImageName,
                    up.remarks AS PrescriptionRemarks,
                    up.status AS PrescriptionStatus,
                    up.review_date AS PrescriptReviewDate,
                    up.prescription_date AS PrescriptionDate,
                    ua.username AS UserName
                FROM userprescriptionform up
                LEFT JOIN useraccount ua ON up.user_id = ua.user_id
                ORDER BY up.prescription_date DESC"
            Dim result = Await conn.QueryAsync(Of Prescription, Account, Prescription)(
                query,
                Function(pres, acc)
                    pres.Account = acc
                    Return pres
                End Function,
                splitOn:="UserName"
            )
            Return result.ToList()
        End Using
    End Function

    ' para sa searching
    Public Async Function SearchTransaction(transac As String) As Task(Of List(Of Transaction))
        Using conn = DatabaseConnection.GetConnection()
            Await conn.OpenAsync()

            Dim query As String = "
                SELECT 
                    ut.transaction_id AS TransactionID,
                    ut.transaction_date AS TransactionDate,
                    ut.user_id AS UserID,
                    ua.username AS UserName,
                    ua.user_id AS AccountUserID
                FROM usertransaction ut
                LEFT JOIN useraccount ua ON ut.user_id = ua.user_id
                WHERE ut.transaction_id LIKE @transaction_id
            "


            Dim result = conn.Query(Of Transaction, Account, Transaction)(
                query,
                Function(t, a)
                    t.Account = a
                    Return t
                End Function,
                New With {.transaction_id = $"%{transac}%"},
                splitOn:="username"
                )
            Return If(result?.ToList(), New List(Of Transaction)())
        End Using
    End Function
    Public Async Function SearchMedicine(medicine As String) As Task(Of List(Of Medicine))
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
                WHERE drug_name LIKE @drug_name"
            Dim result = Await conn.QueryAsync(Of Medicine)(
                query,
                New With {.drug_name = $"%{medicine}%"}
            )
            Return result.ToList()
        End Using
    End Function
    ' para sa druglist lang
    Public Async Function GetItemIntoListBox(prescription_id As Integer, userID As Integer) As Task(Of List(Of Medicine))
        Using conn = DatabaseConnection.GetConnection()
            Await conn.OpenAsync()

            Dim query As String = "
            SELECT 
                med.drug_name AS MedicineName,
                med.drug_brand AS MedicineBrand,
                med.drug_dosage AS MedicineDosage
            FROM usersCart uc
            LEFT JOIN drug_inventory med ON med.drug_id = uc.drug_id
            WHERE uc.user_id = @user_id AND uc.prescription_id = @prescription_id
        "

            Dim parameters = New With {
                .user_id = userID,
                .prescription_id = prescription_id
            }

            Dim result = Await conn.QueryAsync(Of Medicine)(query, parameters)
            Debug.WriteLine("Rows returned from DB: " & result.Count())

            Return result.ToList()
        End Using
    End Function
End Class
