Imports butika.Configurations
Imports butika.Models
Imports Dapper

Public Class PrescriptionRepository
    Dim account As New Account()
    Public Sub New(account As Account)
        Me.account = account
    End Sub

    Public Async Function InsertPrescriptionDetails(prescription As Prescription) As Task(Of Boolean)
        Using conn = DatabaseConnection.GetConnection()
            Try
                Await conn.OpenAsync()

                Dim sql As String = "
                INSERT INTO userPrescriptionForm (
                    prescription_id, patient_name, patient_age,
                    doc_name, clinic, doc_contact,
                    user_concern, prescription_image,
                    prescription_date, user_id
                )
                VALUES (
                    @prescription_id, @patient_name, @patient_age,
                    @doc_name, @clinic, @doc_contact,
                    @user_concern, @prescription_image,
                    @prescription_date, @user_id
                )"

                Dim prescriptionID As Integer = Await CountPrescriptionOfUser()

                Dim parameters = New With {
                .prescription_id = prescriptionID,
                .patient_name = prescription.PatientName,
                .patient_age = prescription.PatientAge,
                .doc_name = prescription.DoctorName,
                .clinic = prescription.DoctorPlace,
                .doc_contact = prescription.DoctorContact,
                .user_concern = prescription.PatientConcern,
                .prescription_image = prescription.PrescriptionImageName,
                .prescription_date = DateTime.Parse(prescription.PrescriptionDate),
                .user_id = account.UserID
            }

                Dim result As Integer = Await conn.ExecuteAsync(sql, parameters)

                Return result > 0

            Catch ex As Exception
                Debug.WriteLine("Error inserting prescription details: " & ex.Message)
                Return False
            End Try
        End Using
    End Function

    Public Async Function countPrescriptionOfUser() As Task(Of Integer)
        Using conn = DatabaseConnection.GetConnection()
            Try
                Await conn.OpenAsync()

                Dim query As String = "SELECT COUNT(*) FROM userPrescriptionForm WHERE user_id = @user_id"

                Dim result As Object = Await conn.ExecuteScalarAsync(query, New With {.user_id = account.UserID})

                Return Convert.ToInt32(result) + 1

            Catch ex As Exception
                MessageBox.Show("Error while getting the prescription: " & ex.Message)
                Return 0
            End Try
        End Using
    End Function

    Public Async Function getPrescriptionID() As Task(Of Integer)
        Using conn = DatabaseConnection.GetConnection()
            Try
                Await conn.OpenAsync()

                Dim query As String = "SELECT TOP 1 prescription_id FROM userPrescriptionForm WHERE user_id = @user_id ORDER BY prescription_id DESC"


                Dim result As Object = Await conn.ExecuteScalarAsync(query, New With {.user_id = account.UserID})

                Return Convert.ToInt32(result)

            Catch ex As Exception
                MessageBox.Show("Error while getting the prescription: " & ex.Message)
                Return 0
            End Try
        End Using
    End Function



End Class
