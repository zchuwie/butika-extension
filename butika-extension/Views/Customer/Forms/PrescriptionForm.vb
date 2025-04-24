Imports System.IO
Imports System.Transactions
Imports butika.Configurations
Imports butika.Models
Imports Dapper

Public Class PrescriptionForm

    Dim account As New Account()
    Dim prescript As New Prescription()
    Dim prescribedMedicine As New List(Of Cart)

    Public Sub New(account As Account, prescript As Prescription)
        Me.account = account
        Me.prescript = prescript
        InitializeComponent()
    End Sub

    Private Sub displayDetails()
        PrescNo.Text = "Prescription No. " + prescript.PrescriptionId.ToString()
        PatientName.Text = prescript.PatientName
        Age.Text = prescript.PatientAge
        DoctorName.Text = prescript.DoctorName
        Clinic.Text = prescript.DoctorPlace
        Contact.Text = prescript.DoctorContact
        briefInfo.Text = prescript.PatientConcern
        DateSubmitted.Text = prescript.PrescriptionDate
        PrescDigiCopy.Image = Image.FromFile(prescript.PresciptImagePath)

        ReviewDate.Text = If(prescript.PrescriptReviewDate, "Under Review")
        If prescript.PrescriptionStatus = 1 Then
            Remark.Text = "Approved"
            Status.Text = "Approved"
        ElseIf prescript.PrescriptionStatus = 2 Then
            Remark.Text = prescript.PrescriptionRemarks
            Status.Text = "Declined"
        End If

    End Sub

    Public Async Function getPrescribedMedicine() As Task(Of List(Of Cart))
        Using conn = DatabaseConnection.GetConnection()
            Try
                Await conn.OpenAsync()
                Dim query = "
            SELECT 
                uc.quantity As Quantity,
                med.drug_id AS MedicineID,
                med.drug_name AS MedicineName,
                med.drug_manufacturer AS MedicineManufacturer,
                med.drug_brand AS MedicineBrand
            FROM usersCart uc
            LEFT JOIN drug_inventory med ON uc.drug_id = med.drug_id
            WHERE uc.prescription_id = @prescriptID AND user_id = @userID
            "

                Dim result = Await conn.QueryAsync(Of Cart, Medicine, Cart)(
                query,
                Function(cart, med)
                    cart.Medicine = med
                    Return cart
                End Function,
                param:=New With {.prescriptID = prescript.PrescriptionId, .userID = account.UserID},
                splitOn:="MedicineID"
                )

                Return result.ToList()
            Catch ex As Exception
                Debug.WriteLine("Fetching display preapproved medicine error. " + ex.Message)
                Return Nothing
            End Try
        End Using
    End Function

    Private Async Function displayListOfMed() As Task
        itemsToApproved.Controls.Clear()

        prescribedMedicine = Await getPrescribedMedicine()
        For Each item In prescribedMedicine
            Dim prescriptItem As New itemsToApprove(account)
            prescriptItem.Initialize(item)
            itemsToApproved.Controls.Add(prescriptItem)
        Next
    End Function

    Private Async Sub PrescriptionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayDetails()
        Await displayListOfMed()
    End Sub
End Class