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
                t.transaction_date AS TransactionDate,
                uc.transaction_id AS TransactionID,
                med.drug_id AS MedicineID,
                med.drug_name AS MedicineName,
                med.drug_manufacturer AS MedicineManufacturer,
                med.drug_price AS MedicinePrice,
                uc.quantity AS Quantity,
                ua.user_id AS UserID,
                ua.isVerified AS IsVerified,
                ua.verifiedDate AS VerifiedDate
            FROM userscheckout uc
            LEFT JOIN drug_inventory med ON uc.drug_id = med.drug_id
            LEFT JOIN usertransaction t ON uc.transaction_id = t.transaction_id
            LEFT JOIN useraccount ua ON t.user_id = ua.user_id
            WHERE uc.transaction_id = @TransactionID
            "

            Dim result = Await conn.QueryAsync(Of Transaction, Medicine, Cart, Account, Transaction)(
                query,
                Function(tran, med, cart, acc)
                    tran.Medicine = med
                    tran.Cart = cart
                    tran.Account = acc
                    Return tran
                End Function,
                param:=New With {.TransactionID = transactionid},
                splitOn:="MedicineID,Quantity,UserID"
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
    Public Async Function PharmaAction(prescription As Prescription) As Task(Of Boolean)
        Using conn = DatabaseConnection.GetConnection()
            Await conn.OpenAsync()

            Dim queryRemarks As String = "
            UPDATE userprescriptionform
            SET remarks = @remarks,
                review_date = @review_date,
                status = @status
            WHERE user_id = @user_id AND prescription_id = @prescription_id"

            Dim queryCart As String = "
            UPDATE userscart
            SET isApproved = @isApproved
            WHERE user_id = @user_id AND prescription_id = @prescription_id"
            If prescription Is Nothing Then
                Debug.WriteLine("prescription is Nothing")
            Else
                If prescription.Account Is Nothing Then
                    Debug.WriteLine("prescription.Account is Nothing")
                Else
                    Debug.WriteLine("UserID: " & prescription.Account.UserID)
                End If

                If prescription.Cart Is Nothing Then
                    Debug.WriteLine("prescription.Cart is Nothing")
                Else
                    Debug.WriteLine("isApproved: " & prescription.Cart.isApproved)
                End If

                Debug.WriteLine("Remarks: " & prescription.PrescriptionRemarks)
                Debug.WriteLine("Status: " & prescription.PrescriptionStatus)
                Debug.WriteLine("PrescriptionID: " & prescription.PrescriptionId)
            End If

            Dim param = New With {
                .remarks = prescription.PrescriptionRemarks,
                .status = prescription.PrescriptionStatus,
                .review_date = DateTime.Now,
                .user_id = prescription.Account.UserID,
                .prescription_id = prescription.PrescriptionId,
                .isApproved = prescription.Cart.isApproved
            }

            Dim result1 As Integer = Await conn.ExecuteAsync(queryRemarks, param)
            Dim result2 As Integer = Await conn.ExecuteAsync(queryCart, param)

            Return result1 > 0 AndAlso result2 > 0
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

#Region "Dashboard Pharmacy"

    Public Async Function totalTransaction() As Task(Of Integer)
        Using conn = DatabaseConnection.GetConnection()
            Try
                Await conn.OpenAsync()

                Dim query As String = "select COUNT(*) from usertransaction"
                Dim result As Object = Await conn.ExecuteScalarAsync(query)

                Return Convert.ToInt32(result)

            Catch ex As Exception
                MessageBox.Show("Error while getting the prescription: " & ex.Message)
                Return 0
            End Try
        End Using
    End Function

#End Region
End Class
