Imports System.Data
Imports Microsoft.Data.SqlClient
Imports Dapper
Imports Guna.Charts.WinForms
Imports butika.Configurations
Imports System.Windows.Forms

Public Class AdminRepository

#Region "Admin Dashboard"
    ' === Utility: Generic Dapper COUNT query ===
    Public Shared Async Function GetCountAsync(query As String) As Task(Of Integer)
        Try
            Using conn As SqlConnection = DatabaseConnection.GetConnection()
                Await conn.OpenAsync()
                Dim result = Await conn.ExecuteScalarAsync(Of Integer?)(query)
                Return If(result.HasValue, result.Value, 0)
            End Using
        Catch ex As Exception
            Console.WriteLine("Database Error: " & ex.Message)
            Return -1
        End Try
    End Function

    ' === Utility: Generic Dapper Query ===
    Public Shared Async Function QueryAsync(Of T)(sql As String, Optional param As Object = Nothing) As Task(Of List(Of T))
        Try
            Using conn As SqlConnection = DatabaseConnection.GetConnection()
                Await conn.OpenAsync()
                Dim result = Await conn.QueryAsync(Of T)(sql, param)
                Return result.ToList()
            End Using
        Catch ex As Exception
            Console.WriteLine("QueryAsync Error: " & ex.Message)
            Return New List(Of T)
        End Try
    End Function

    ' === User Data Counts ===
    Public Shared Async Function GetUserCountAsync() As Task(Of Integer)
        Return Await GetCountAsync("SELECT COUNT(user_id) FROM useraccount where usertype NOT IN (1, 2, 3)")
    End Function

    Public Shared Async Function GetActiveUserCountAsync() As Task(Of Integer)
        Return Await GetCountAsync("SELECT COUNT(report_id) FROM stockReport WHERE stockRequestStatus = 0")
    End Function

    Public Shared Async Function GetPendingDiscountCountAsync() As Task(Of Integer)
        Return Await GetCountAsync("SELECT COUNT(user_id) FROM useraccount WHERE isVerified = 1")
    End Function

    Public Shared Async Function GetNewSignupCountAsync() As Task(Of Integer)
        Return Await GetCountAsync("SELECT COUNT(user_id) FROM useraccount WHERE date_joined >= DATEADD(DAY, -14, GETDATE()) AND usertype NOT IN (1, 2, 3)")
    End Function

    ' === User DataTable ===
    Public Shared Async Function GetUserDataAsync() As Task(Of DataTable)
        Dim dt As New DataTable()
        dt.Columns.Add("ID", GetType(Integer))
        dt.Columns.Add("username", GetType(String))
        dt.Columns.Add("Email", GetType(String))

        Dim query As String = "SELECT user_id AS ID, username AS username, email AS Email FROM useraccount"
        Try
            Using conn As SqlConnection = DatabaseConnection.GetConnection(),
                  cmd As New SqlCommand(query, conn)
                Await conn.OpenAsync()
                Using reader As SqlDataReader = Await cmd.ExecuteReaderAsync()
                    While Await reader.ReadAsync()
                        If reader("Email") IsNot DBNull.Value Then
                            dt.Rows.Add(reader("ID"), reader("username"), reader("Email"))
                        End If
                    End While
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("Database Error: " & ex.Message)
        End Try
        Return dt
    End Function

    ' === Add column for user activity ===
    Public Shared Async Function AddActivityLogAsync(userID As Integer, userType As Integer, Optional customMessage As String = "") As Task(Of Boolean)
        Try
            Dim activityMessage As String = customMessage

            If String.IsNullOrEmpty(activityMessage) Then
                Select Case userType
                    Case 1
                        activityMessage = "admin logged in"
                    Case 2
                        activityMessage = "pharmacist logged in"
                    Case 3
                        activityMessage = "inventory Custodian logged in"
                    Case Else
                        activityMessage = "user logged in"
                End Select
            End If

            Dim query As String = "INSERT INTO activity_log (activity, user_id, _datetime) VALUES (@Activity, @UserID, @DateTime)"

            Using conn As SqlConnection = DatabaseConnection.GetConnection(),
              cmd As New SqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@Activity", activityMessage)
                cmd.Parameters.AddWithValue("@UserID", userID)
                cmd.Parameters.AddWithValue("@DateTime", DateTime.Now)

                Await conn.OpenAsync()

                Debug.WriteLine("Executing query: " & cmd.CommandText)

                Dim rowsAffected As Integer = Await cmd.ExecuteNonQueryAsync()

                If rowsAffected > 0 Then
                    Debug.WriteLine("Activity log inserted successfully.")
                    Return True
                Else
                    Debug.WriteLine("No rows affected.")
                    Return False
                End If
            End Using
        Catch ex As Exception
            Debug.WriteLine("Error while adding activity log: " & ex.Message)
            Return False
        End Try
    End Function

    Public Shared Async Function AddSignupLogAsync(userID As Integer) As Task(Of Boolean)
        Try
            Dim activityMessage As String = "Customer signed up"

            Dim query As String = "INSERT INTO activity_log (activity, user_id, _datetime) 
                               VALUES (@Activity, @UserID, @DateTime)"

            Dim parameters As New With {
            Key .Activity = activityMessage,
            Key .UserID = userID,
            Key .DateTime = DateTime.Now
        }

            Using conn As SqlConnection = DatabaseConnection.GetConnection()
                Await conn.OpenAsync()
                Dim rowsAffected = Await conn.ExecuteAsync(query, parameters)

                If rowsAffected = 1 Then
                    Return True
                Else
                    Return False
                End If
            End Using
        Catch ex As Exception
            Console.WriteLine("Error while adding signup log: " & ex.Message)
            Return False
        End Try
    End Function

    Public Shared Async Function GetLastInsertedUserID() As Task(Of Integer)
        Try
            Dim query As String = "SELECT TOP 1 user_id FROM userAccount ORDER BY user_id DESC"

            Using conn As SqlConnection = DatabaseConnection.GetConnection()
                Await conn.OpenAsync()
                Dim userID As Integer = Await conn.ExecuteScalarAsync(Of Integer)(query)
                Return userID
            End Using
        Catch ex As Exception
            Console.WriteLine("Error while getting last inserted userID: " & ex.Message)
            Return 0
        End Try
    End Function

    Public Shared Async Function AddMedicineAsync(medicineName As String, medicinePrice As Decimal) As Task(Of Boolean)
        Try
            Dim query As String = "INSERT INTO drug_inventory (drug_name, drug_price) VALUES (@medicineName, @medicinePrice)"

            Using conn As SqlConnection = DatabaseConnection.GetConnection(),
              cmd As New SqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@medicineName", medicineName)
                cmd.Parameters.AddWithValue("@medicinePrice", medicinePrice)

                Await conn.OpenAsync()
                Dim rowsAffected As Integer = Await cmd.ExecuteNonQueryAsync()

                If rowsAffected > 0 Then
                    Return True
                Else
                    Return False
                End If
            End Using
        Catch ex As Exception
            Console.WriteLine("Error adding medicine: " & ex.Message)
            Return False
        End Try
    End Function

    Public Shared Async Function LogStockRequestActivity(userID As Integer, userType As Integer, stockRequestDetails As String) As Task(Of Boolean)
        Try
            Dim activityMessage As String = $"requested stock | {stockRequestDetails}"

            Dim query As String = "INSERT INTO activity_log (activity, user_id, _datetime) VALUES (@Activity, @UserID, @DateTime)"

            Using conn As SqlConnection = DatabaseConnection.GetConnection(),
              cmd As New SqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@Activity", activityMessage)
                cmd.Parameters.AddWithValue("@UserID", userID)
                cmd.Parameters.AddWithValue("@DateTime", DateTime.Now)

                Await conn.OpenAsync()

                Dim rowsAffected As Integer = Await cmd.ExecuteNonQueryAsync()

                If rowsAffected > 0 Then
                    Return True
                Else
                    Return False
                End If
            End Using
        Catch ex As Exception
            Debug.WriteLine("Error while logging stock request activity: " & ex.Message)
            Return False
        End Try
    End Function


    Public Shared Async Function LogMedicineArchiveActivity(userID As Integer, userType As Integer, medicineName As String) As Task(Of Boolean)
        Try
            Dim activityMessage As String = $"archived medicine | ID:{medicineName}"

            Dim query As String = "INSERT INTO activity_log (activity, user_id, _datetime) VALUES (@Activity, @UserID, @DateTime)"

            Using conn As SqlConnection = DatabaseConnection.GetConnection(),
              cmd As New SqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@Activity", activityMessage)
                cmd.Parameters.AddWithValue("@UserID", userID)
                cmd.Parameters.AddWithValue("@DateTime", DateTime.Now)

                Await conn.OpenAsync()

                Dim rowsAffected As Integer = Await cmd.ExecuteNonQueryAsync()

                If rowsAffected > 0 Then
                    Return True
                Else
                    Return False
                End If
            End Using
        Catch ex As Exception
            Debug.WriteLine("Error while logging medicine archive activity: " & ex.Message)
            Return False
        End Try
    End Function

    Public Shared Async Function LogMedicineUpdateActivity(userID As Integer, userType As Integer, medicineName As String) As Task(Of Boolean)
        Try
            Dim activityMessage As String = $"updated medicine | ID:{medicineName}"

            Dim query As String = "INSERT INTO activity_log (activity, user_id, _datetime) VALUES (@Activity, @UserID, @DateTime)"

            Using conn As SqlConnection = DatabaseConnection.GetConnection(),
              cmd As New SqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@Activity", activityMessage)
                cmd.Parameters.AddWithValue("@UserID", userID)
                cmd.Parameters.AddWithValue("@DateTime", DateTime.Now)

                Await conn.OpenAsync()
                Dim rowsAffected As Integer = Await cmd.ExecuteNonQueryAsync()
                Return rowsAffected > 0
            End Using
        Catch ex As Exception
            Debug.WriteLine("Error while logging update activity: " & ex.Message)
            Return False
        End Try
    End Function

    Public Shared Async Function LogLogoutActivity(userID As Integer, userType As Integer) As Task(Of Boolean)
        Try
            Dim activityMessage As String = String.Empty

            Select Case userType
                Case 1 : activityMessage = "admin logged out"
                Case 2 : activityMessage = "pharmacist logged out"
                Case 3 : activityMessage = "inventory Custodian logged out"
                Case Else : activityMessage = "user logged out"
            End Select

            Dim query As String = "INSERT INTO activity_log (activity, user_id, _datetime) VALUES (@Activity, @UserID, @DateTime)"

            Using conn As SqlConnection = DatabaseConnection.GetConnection(),
              cmd As New SqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@Activity", activityMessage)
                cmd.Parameters.AddWithValue("@UserID", userID)
                cmd.Parameters.AddWithValue("@DateTime", DateTime.Now)

                Await conn.OpenAsync()
                Dim rowsAffected = Await cmd.ExecuteNonQueryAsync()
                Return rowsAffected > 0
            End Using
        Catch ex As Exception
            Debug.WriteLine("Error logging logout activity: " & ex.Message)
            Return False
        End Try
    End Function

    Public Async Sub ApprovePrescription(prescriptionID As Integer)
        Try
            Dim query As String = "UPDATE prescriptions SET status = 'Approved' WHERE prescription_id = @ID"
            Using conn As SqlConnection = DatabaseConnection.GetConnection(),
              cmd As New SqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@ID", prescriptionID)
                Await conn.OpenAsync()
                Await cmd.ExecuteNonQueryAsync()
            End Using

            Await AdminRepository.AddActivityLogAsync(SessionInfo.CurrentUserID, SessionInfo.CurrentUserType, "Pharmacist approved a prescription")

            MessageBox.Show("Prescription approved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error approving prescription: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Async Sub ProcessCheckout()
        Try
            Await AdminRepository.AddActivityLogAsync(SessionInfo.CurrentUserID, SessionInfo.CurrentUserType, "checked out medicine")

            MessageBox.Show("Checkout completed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Checkout failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Async Sub SubmitForm()
        Try
            Await AdminRepository.AddActivityLogAsync(SessionInfo.CurrentUserID, SessionInfo.CurrentUserType, "Customer submitted a form")

            MessageBox.Show("Form submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Failed to submit form: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' === Activity Log DataTable ===
    Public Shared Async Function GetUserActivityDataAsync() As Task(Of DataTable)
        Dim dt As New DataTable()
        dt.Columns.Add("ID", GetType(Integer))
        dt.Columns.Add("Username", GetType(String))
        dt.Columns.Add("Action", GetType(String))
        dt.Columns.Add("Date", GetType(DateTime))

        Dim query As String = "
            SELECT ua.user_id AS ID, 
                   ua.username AS Username, 
                   al.activity AS Action, 
                   al._datetime AS Date 
            FROM useraccount ua
            INNER JOIN activity_log al ON ua.user_id = al.user_id
            ORDER BY al._datetime DESC"

        Try
            Using conn As SqlConnection = DatabaseConnection.GetConnection(),
                  cmd As New SqlCommand(query, conn)
                Await conn.OpenAsync()
                Using reader As SqlDataReader = Await cmd.ExecuteReaderAsync()
                    While Await reader.ReadAsync()
                        If reader("Action") IsNot DBNull.Value AndAlso reader("Date") IsNot DBNull.Value AndAlso reader("ID") <> 1 Then
                            dt.Rows.Add(reader("ID"), reader("Username"), reader("Action"), reader("Date"))
                        End If
                    End While
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("Database Error: " & ex.Message)
        End Try
        Return dt
    End Function

    ' === Growth Chart Data ===
    Public Shared Async Function GetUserGrowthAsync(period As String) As Task(Of GunaLineDataset)
        Dim dataset As New GunaLineDataset With {.Label = "User Logins"}
        Dim query As String = ""

        Select Case period.ToLower()
            Case "week"
                query = "SELECT FORMAT(date_joined, 'yyyy-MM-dd') AS Period, COUNT(*) AS Total 
                     FROM useraccount 
                     WHERE date_joined >= DATEADD(WEEK, -1, GETDATE())
                     GROUP BY FORMAT(date_joined, 'yyyy-MM-dd') 
                     ORDER BY Period"

            Case "month"
                query = "SELECT FORMAT(date_joined, 'yyyy-MM') AS Period, COUNT(*) AS Total 
                     FROM useraccount 
                     WHERE date_joined >= DATEADD(MONTH, -6, GETDATE())
                     GROUP BY FORMAT(date_joined, 'yyyy-MM') 
                     ORDER BY Period"

            Case "year"
                query = "SELECT FORMAT(date_joined, 'yyyy') AS Period, COUNT(*) AS Total 
                     FROM useraccount 
                     GROUP BY FORMAT(date_joined, 'yyyy') 
                     ORDER BY Period"
        End Select

        Try
            Dim results = Await QueryAsync(Of GrowthResult)(query)

            For Each row In results
                If Not String.IsNullOrEmpty(row.Period) Then
                    dataset.DataPoints.Add(row.Period, row.Total)
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Error loading growth data: " & ex.Message)
        End Try

        Return dataset
    End Function

    ' === Discount Status Pie Data ===
    Public Shared Async Function GetDiscountStatusAsync() As Task(Of (verifiedCount As Integer, notVerifiedCount As Integer))
        Dim query = "
            SELECT 
                COUNT(CASE WHEN isVerified = 1 THEN 1 ELSE NULL END) AS Verified,
                COUNT(CASE WHEN isVerified = 0 THEN 1 ELSE NULL END) AS NotVerified
            FROM useraccount"

        Try
            Using conn As SqlConnection = DatabaseConnection.GetConnection()
                Await conn.OpenAsync()
                Dim result = Await conn.QueryFirstOrDefaultAsync(Of DiscountStatus)(query)
                Return (result.Verified, result.NotVerified)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading discount status: " & ex.Message)
            Return (0, 0)
        End Try
    End Function

    Public Shared Async Function GetStockRequestStatusCountAsync() As Task(Of (pendingCount As Integer, approvedCount As Integer, declinedCount As Integer))
        Dim query As String = "
    SELECT 
        COUNT(CASE WHEN stockRequestStatus = 0 THEN 1 ELSE NULL END) AS Pending,
        COUNT(CASE WHEN stockRequestStatus = 1 THEN 1 ELSE NULL END) AS Approved,
        COUNT(CASE WHEN stockRequestStatus = 2 THEN 1 ELSE NULL END) AS Declined
    FROM stockReport"

        Try
            Using conn As SqlConnection = DatabaseConnection.GetConnection(),
              cmd As New SqlCommand(query, conn)
                Await conn.OpenAsync()

                ' Using ExecuteReaderAsync to retrieve multiple columns of results
                Using reader As SqlDataReader = Await cmd.ExecuteReaderAsync()
                    If Await reader.ReadAsync() Then
                        ' Assuming the columns are returned in order: Pending, Approved, Declined
                        Dim pendingCount As Integer = If(IsDBNull(reader("Pending")), 0, Convert.ToInt32(reader("Pending")))
                        Dim approvedCount As Integer = If(IsDBNull(reader("Approved")), 0, Convert.ToInt32(reader("Approved")))
                        Dim declinedCount As Integer = If(IsDBNull(reader("Declined")), 0, Convert.ToInt32(reader("Declined")))

                        ' Return the counts as a tuple
                        Return (pendingCount, approvedCount, declinedCount)
                    End If
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("Error fetching stock request status: " & ex.Message)
        End Try

        Return (0, 0, 0)
    End Function



    ' === Result Mapping Classes ===
    Private Class GrowthResult
        Public Property Period As String
        Public Property Total As Integer
    End Class

    Private Class DiscountStatus
        Public Property Verified As Integer
        Public Property NotVerified As Integer
    End Class

    Public Class UserStatus
        Public Property Active As Integer
        Public Property Inactive As Integer
    End Class
#End Region

#Region "User Account"
    Public Shared Async Function GetActiveUsers() As Task(Of Integer)
        Return Await GetCountAsync("SELECT COUNT(user_id) FROM useraccount where status='active'")
    End Function

    Public Shared Async Function GetInactiveUsers() As Task(Of Integer)
        Return Await GetCountAsync("SELECT COUNT(user_id) FROM useraccount where status='inactive'")
    End Function

    Public Shared Async Function GetUserFullData(Optional statusFilter As String = "") As Task(Of DataTable)
        Dim dt As New DataTable()

        dt.Columns.Add("ID", GetType(Integer))
        dt.Columns.Add("Username", GetType(String))
        dt.Columns.Add("Email", GetType(String))
        dt.Columns.Add("Birth_Date", GetType(DateTime))
        dt.Columns.Add("Contact", GetType(String))
        dt.Columns.Add("Date_Joined", GetType(DateTime))
        dt.Columns.Add("Type", GetType(Integer))

        Dim baseQuery As String = "SELECT user_id AS ID, username AS Username, email AS Email, birthdate AS Birth_Date, contact AS Contact, date_joined as Date_Joined, userType as Type FROM useraccount"

        If Not String.IsNullOrWhiteSpace(statusFilter) Then
            baseQuery &= " WHERE usertype = @usertype"
        End If

        Try
            Using conn As SqlConnection = DatabaseConnection.GetConnection(),
              cmd As New SqlCommand(baseQuery, conn)

                If Not String.IsNullOrWhiteSpace(statusFilter) Then
                    cmd.Parameters.AddWithValue("@usertype", statusFilter)
                End If

                Await conn.OpenAsync()
                Using reader As SqlDataReader = Await cmd.ExecuteReaderAsync()
                    While Await reader.ReadAsync()
                        dt.Rows.Add(reader("ID"), reader("Username"), reader("Email"), reader("Birth_Date"), reader("Contact"), reader("Date_Joined"), reader("Type"))
                    End While
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("Database Error: " & ex.Message)
        End Try

        Return dt
    End Function

    Public Shared Async Function GetCustomerCount() As Task(Of Integer)
        Return Await GetCountAsync("SELECT COUNT(user_id) FROM useraccount WHERE usertype = 0")
    End Function

    Public Shared Async Function GetAdminCount() As Task(Of Integer)
        Return Await GetCountAsync("SELECT COUNT(user_id) FROM useraccount WHERE usertype = 1")
    End Function

    Public Shared Async Function GetPharmacistCount() As Task(Of Integer)
        Return Await GetCountAsync("SELECT COUNT(user_id) FROM useraccount WHERE usertype = 2")
    End Function

    Public Shared Async Function GetCustodianCount() As Task(Of Integer)
        Return Await GetCountAsync("SELECT COUNT(user_id) FROM useraccount WHERE usertype = 3")
    End Function

    Public Shared Async Function GetUserDetailsById(userId As Integer) As Task(Of DataRow)
        Dim dt As New DataTable()
        Dim query As String = "SELECT user_id AS ID, username, email, birthdate, contact, date_joined, userType, fullname, first_name, last_name, middle_initial FROM useraccount WHERE user_id = @userId"

        Try
            Using conn As SqlConnection = DatabaseConnection.GetConnection(),
              cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@userId", userId)
                Await conn.OpenAsync()

                Using reader As SqlDataReader = Await cmd.ExecuteReaderAsync()
                    dt.Load(reader)
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("Error retrieving user details: " & ex.Message)
        End Try

        If dt.Rows.Count > 0 Then
            Return dt.Rows(0)
        Else
            Return Nothing
        End If
    End Function

    Public Shared Async Function UpdateUserDetails(userId As Integer, updatedEmail As String, updatedPhone As String) As Task
        Dim query As String = "UPDATE useraccount SET email = @Email, contact = @Contact WHERE user_id = @UserId"

        Try
            Using conn As SqlConnection = DatabaseConnection.GetConnection(),
              cmd As New SqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@Email", updatedEmail)
                cmd.Parameters.AddWithValue("@Contact", updatedPhone)
                cmd.Parameters.AddWithValue("@UserId", userId)

                Await conn.OpenAsync()
                Await cmd.ExecuteNonQueryAsync()
            End Using
        Catch ex As Exception
            Console.WriteLine("Database Error: " & ex.Message)
        End Try
    End Function

    Public Shared Async Function AddNewAccount(username As String, usertype As Integer, user_pw As String) As Task(Of Boolean)
        Try
            Dim query As String = "INSERT INTO useraccount (username, password, usertype) 
                               VALUES (@Username, @Password, @UserType)"

            Dim parameters As New With {
            Key .Username = username,
            Key .Password = user_pw,
            Key .UserType = usertype
        }

            Using conn As SqlConnection = DatabaseConnection.GetConnection()
                Await conn.OpenAsync()
                Dim rowsAffected = Await conn.ExecuteAsync(query, parameters)

                Return rowsAffected = 1
            End Using
        Catch ex As Exception
            Console.WriteLine("Error while adding new account: " & ex.Message)
            Return False
        End Try
    End Function
#End Region

#Region "User Logs"
    Public Shared Async Function GetAllUserActivityDataAsync() As Task(Of DataTable)
        Dim dt As New DataTable()
        dt.Columns.Add("ID", GetType(Integer))
        dt.Columns.Add("Username", GetType(String))
        dt.Columns.Add("UserType", GetType(Integer))
        dt.Columns.Add("Action", GetType(String))
        dt.Columns.Add("Date", GetType(DateTime))

        Dim query As String = "
        SELECT ua.user_id AS ID, 
               ua.username AS Username, 
               ua.userType AS UserType,
               al.activity AS Action, 
               al._datetime AS Date 
        FROM useraccount ua
        INNER JOIN activity_log al ON ua.user_id = al.user_id
        ORDER BY al._datetime DESC"

        Try
            Using conn As SqlConnection = DatabaseConnection.GetConnection(),
                  cmd As New SqlCommand(query, conn)
                Await conn.OpenAsync()
                Using reader As SqlDataReader = Await cmd.ExecuteReaderAsync()
                    While Await reader.ReadAsync()
                        If reader("Action") IsNot DBNull.Value AndAlso reader("Date") IsNot DBNull.Value Then
                            dt.Rows.Add(reader("ID"), reader("Username"), reader("UserType"), reader("Action"), reader("Date"))
                        End If
                    End While
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("Database Error: " & ex.Message)
        End Try
        Return dt
    End Function
#End Region

#Region "Discount"
    Public Shared Async Function GetCustomerUserFullData(Optional statusFilter As Boolean? = Nothing) As Task(Of DataTable)
        Dim dt As New DataTable()

        dt.Columns.Add("ID", GetType(Integer))
        dt.Columns.Add("Username", GetType(String))
        dt.Columns.Add("Fullname", GetType(String))
        dt.Columns.Add("Email", GetType(String))
        dt.Columns.Add("Birth_Date", GetType(DateTime))
        dt.Columns.Add("Contact", GetType(String))
        dt.Columns.Add("Date_Joined", GetType(DateTime))
        dt.Columns.Add("Status", GetType(Boolean))
        dt.Columns.Add("Verified_Date", GetType(DateTime))

        Dim baseQuery As String = "
    SELECT ua.user_id AS ID, 
           ua.username AS Username, 
           ua.fullname AS Fullname, 
           ua.email AS Email, 
           ua.birthdate AS Birth_Date, 
           ua.contact AS Contact, 
           ua.date_joined AS Date_Joined, 
           ua.isVerified AS Status,
           ua.verifiedDate AS Verified_Date
    FROM useraccount ua
    WHERE ua.userType = 0"

        If statusFilter.HasValue Then
            baseQuery &= " AND ua.isVerified = @isVerified"
        End If

        Try
            Using conn As SqlConnection = DatabaseConnection.GetConnection(),
              cmd As New SqlCommand(baseQuery, conn)

                If statusFilter.HasValue Then
                    cmd.Parameters.AddWithValue("@isVerified", statusFilter.Value)
                End If

                Await conn.OpenAsync()
                Using reader As SqlDataReader = Await cmd.ExecuteReaderAsync()
                    While Await reader.ReadAsync()
                        dt.Rows.Add(reader("ID"), reader("Username"), reader("Fullname"), reader("Email"),
                                reader("Birth_Date"), reader("Contact"), reader("Date_Joined"),
                                Convert.ToBoolean(reader("Status")),
                                If(IsDBNull(reader("Verified_Date")), DBNull.Value, reader("Verified_Date")))
                    End While
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("Database Error: " & ex.Message)
        End Try

        Return dt
    End Function

    Public Shared Async Function UpdateUserVerificationStatusWithDateAsync(userId As Integer, isVerified As Boolean, Optional verifiedDate As DateTime? = Nothing) As Task
        Try
            Using conn As SqlConnection = DatabaseConnection.GetConnection()
                Await conn.OpenAsync()

                Dim updateQuery As String = "
                UPDATE useraccount 
                SET isVerified = @isVerified, verifiedDate = @verifiedDate 
                WHERE user_id = @userId"

                Using cmd As New SqlCommand(updateQuery, conn)
                    cmd.Parameters.AddWithValue("@isVerified", isVerified)
                    cmd.Parameters.AddWithValue("@verifiedDate", If(verifiedDate.HasValue, verifiedDate.Value, DBNull.Value))
                    cmd.Parameters.AddWithValue("@userId", userId)

                    Await cmd.ExecuteNonQueryAsync()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating verification: " & ex.Message)
        End Try
    End Function



    Public Shared Async Function UpdateUserVerificationStatusAsync(userId As Integer, isVerified As Boolean) As Task
        Dim query As String = "UPDATE useraccount SET isVerified = @isVerified WHERE user_id = @userId"

        Try
            Using conn As SqlConnection = DatabaseConnection.GetConnection(),
              cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@userId", userId)
                cmd.Parameters.AddWithValue("@isVerified", isVerified)

                Await conn.OpenAsync()
                Await cmd.ExecuteNonQueryAsync()
            End Using
        Catch ex As Exception
            Console.WriteLine("Database Error: " & ex.Message)
        End Try
    End Function

    Public Shared Async Function GetUserVerificationStatusAsync(userId As Integer) As Task(Of Boolean)
        Dim query As String = "SELECT isVerified FROM useraccount WHERE user_id = @userId"

        Try
            Using conn As SqlConnection = DatabaseConnection.GetConnection(),
              cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@userId", userId)

                Await conn.OpenAsync()

                Dim result As Object = Await cmd.ExecuteScalarAsync()
                If result IsNot DBNull.Value Then
                    Return Convert.ToBoolean(result)
                End If
            End Using
        Catch ex As Exception
            Console.WriteLine("Database Error: " & ex.Message)
        End Try

        Return False
    End Function


#End Region

#Region "Stock"
    Public Shared Async Function GetStockReportDataAsync(Optional status As Integer? = Nothing) As Task(Of DataTable)
        Dim dt As New DataTable()

        ' Define the columns
        dt.Columns.Add("Report_ID", GetType(Integer))
        dt.Columns.Add("Medicine_ID", GetType(Integer))
        dt.Columns.Add("Request_Status", GetType(String))
        dt.Columns.Add("Requested_Quantity", GetType(Integer))
        dt.Columns.Add("Request_Date", GetType(DateTime))
        dt.Columns.Add("Date_Updated", GetType(DateTime))

        Dim query As String = "
    SELECT report_id, medicine_id, stockRequestStatus, stockQuantityRequest, stockDateRequested, stockDateUpdated
    FROM stockReport
    "

        If status.HasValue Then
            query &= " WHERE stockRequestStatus = @status"
        End If

        Try
            Using conn As SqlConnection = DatabaseConnection.GetConnection(),
              cmd As New SqlCommand(query, conn)
                If status.HasValue Then
                    cmd.Parameters.AddWithValue("@status", status.Value)
                End If

                Await conn.OpenAsync()
                Using reader As SqlDataReader = Await cmd.ExecuteReaderAsync()
                    While Await reader.ReadAsync()
                        Dim reportId As Integer = If(IsDBNull(reader("report_id")), 0, Convert.ToInt32(reader("report_id")))
                        Dim medicineId As Integer = If(IsDBNull(reader("medicine_id")), 0, Convert.ToInt32(reader("medicine_id")))
                        Dim statusValue As String = If(IsDBNull(reader("stockRequestStatus")), "", Convert.ToInt32(reader("stockRequestStatus")).ToString())
                        Dim quantity As Integer = If(IsDBNull(reader("stockQuantityRequest")), 0, Convert.ToInt32(reader("stockQuantityRequest")))
                        Dim requestDate As DateTime = If(IsDBNull(reader("stockDateRequested")), DateTime.MinValue, Convert.ToDateTime(reader("stockDateRequested")))
                        Dim updatedDate As DateTime = If(IsDBNull(reader("stockDateUpdated")), DateTime.MinValue, Convert.ToDateTime(reader("stockDateUpdated")))

                        dt.Rows.Add(reportId, medicineId, statusValue, quantity, requestDate, updatedDate)
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading stock report: " & ex.Message)
        End Try

        Return dt
    End Function




    Public Shared Async Function GetDrugInfoByIDAsync(drugId As Integer) As Task(Of DataRow)
        Dim dt As New DataTable()

        Dim query As String = "
SELECT 
    drug_id, 
    drug_name, 
    drug_price, 
    drug_manufacturer, 
    drug_stocks, 
    CAST(expiration_date AS DATE) AS expiration_date,
    drug_image  -- Added drug_image column to query
FROM drug_inventory
WHERE drug_id = @drugId
"

        Try
            Using conn As SqlConnection = DatabaseConnection.GetConnection(),
              cmd As New SqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@drugId", drugId)

                Await conn.OpenAsync()
                Using reader As SqlDataReader = Await cmd.ExecuteReaderAsync()
                    dt.Load(reader)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading drug info: " & ex.Message)
        End Try

        If dt.Rows.Count > 0 Then
            Return dt.Rows(0)
        Else
            Return Nothing
        End If
    End Function


    Public Shared Async Function UpdateRequestStatusInDatabase(status As Integer, medicineId As Integer) As Task
        Dim query As String = "UPDATE stockReport SET stockRequestStatus = @status, stockDateUpdated = @date WHERE medicine_id = @medicineId"

        Using conn As SqlConnection = DatabaseConnection.GetConnection(),
              cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@status", status)
            cmd.Parameters.AddWithValue("@date", DateTime.Now)
            cmd.Parameters.AddWithValue("@medicineId", medicineId)

            Await conn.OpenAsync()
            Await cmd.ExecuteNonQueryAsync()
        End Using
    End Function
#End Region

    Public Function GetVerificationImagePath(ID As String) As String
        Dim imagePath As String = Nothing
        Dim query As String = "SELECT image_verification FROM useraccount WHERE user_id = @ID"

        Using conn As SqlConnection = DatabaseConnection.GetConnection()
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ID", ID)
                conn.Open()

                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    imagePath = result.ToString()
                End If
            End Using
        End Using

        Return imagePath
    End Function

End Class

' === Session Module to store logged-in user info ===
Module SessionInfo
    Public Property CurrentUserID As Integer
    Public Property CurrentUserType As Integer
End Module
