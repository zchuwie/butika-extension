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
        Return Await GetCountAsync("SELECT COUNT(user_id) FROM useraccount")
    End Function

    Public Shared Async Function GetActiveUserCountAsync() As Task(Of Integer)
        Return Await GetCountAsync("SELECT COUNT(user_id) FROM useraccount WHERE status = 'active'")
    End Function

    Public Shared Async Function GetPendingDiscountCountAsync() As Task(Of Integer)
        Return Await GetCountAsync("SELECT COUNT(user_id) FROM useraccount WHERE isVerified = 1")
    End Function

    Public Shared Async Function GetNewSignupCountAsync() As Task(Of Integer)
        Return Await GetCountAsync("SELECT COUNT(user_id) FROM useraccount WHERE date_joined >= DATEADD(DAY, -14, GETDATE())")
    End Function

    ' === User DataTable ===
    Public Shared Async Function GetUserDataAsync() As Task(Of DataTable)
        Dim dt As New DataTable()
        dt.Columns.Add("ID", GetType(Integer))
        dt.Columns.Add("username", GetType(String))
        dt.Columns.Add("Email", GetType(String))
        dt.Columns.Add("Status", GetType(String))

        Dim query As String = "SELECT user_id AS ID, username AS username, email AS Email, status AS Status FROM useraccount"
        Try
            Using conn As SqlConnection = DatabaseConnection.GetConnection(),
                  cmd As New SqlCommand(query, conn)
                Await conn.OpenAsync()
                Using reader As SqlDataReader = Await cmd.ExecuteReaderAsync()
                    While Await reader.ReadAsync()
                        If reader("Email") IsNot DBNull.Value Then
                            ' Only add rows if no column is null
                            dt.Rows.Add(reader("ID"), reader("username"), reader("Email"), reader("Status"))
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
    Public Shared Async Function AddActivityLogAsync(userID As Integer, userType As Integer) As Task(Of Boolean)
        Try
            ' Construct the activity message based on userType
            Dim activityMessage As String = String.Empty

            Select Case userType
                Case 1
                    activityMessage = "Admin logged in"
                Case 2
                    activityMessage = "Pharmacist logged in"
                Case 3
                    activityMessage = "Inventory Custodian logged in"
                Case Else
                    activityMessage = "User logged in"
            End Select

            ' Construct SQL query to insert new log
            Dim query As String = "INSERT INTO activity_log (activity, user_id, _datetime) 
                               VALUES (@Activity, @UserID, @DateTime)"

            ' Prepare parameters
            Dim parameters As New With {
            Key .Activity = activityMessage,
            Key .UserID = userID,
            Key .DateTime = DateTime.Now
        }

            ' Execute the query using Dapper
            Using conn As SqlConnection = DatabaseConnection.GetConnection()
                Await conn.OpenAsync()
                Dim rowsAffected = Await conn.ExecuteAsync(query, parameters)

                ' If one row is affected, return true (success)
                If rowsAffected = 1 Then
                    Return True
                Else
                    Return False
                End If
            End Using
        Catch ex As Exception
            Console.WriteLine("Error while adding activity log: " & ex.Message)
            Return False
        End Try
    End Function

    Public Shared Async Function AddSignupLogAsync(userID As Integer) As Task(Of Boolean)
        Try
            ' Construct the activity message for customer signup
            Dim activityMessage As String = "Customer signed up"

            ' Construct SQL query to insert new log
            Dim query As String = "INSERT INTO activity_log (activity, user_id, _datetime) 
                               VALUES (@Activity, @UserID, @DateTime)"

            ' Prepare parameters
            Dim parameters As New With {
            Key .Activity = activityMessage,
            Key .UserID = userID,
            Key .DateTime = DateTime.Now
        }

            ' Execute the query using Dapper
            Using conn As SqlConnection = DatabaseConnection.GetConnection()
                Await conn.OpenAsync()
                Dim rowsAffected = Await conn.ExecuteAsync(query, parameters)

                ' If one row is affected, return true (success)
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
            ' SQL query to get the last inserted userID (assuming user_id is auto-incremented)
            Dim query As String = "SELECT TOP 1 user_id FROM userAccount ORDER BY user_id DESC"

            ' Execute the query and return the last inserted userID
            Using conn As SqlConnection = DatabaseConnection.GetConnection()
                Await conn.OpenAsync()
                Dim userID As Integer = Await conn.ExecuteScalarAsync(Of Integer)(query)
                Return userID
            End Using
        Catch ex As Exception
            Console.WriteLine("Error while getting last inserted userID: " & ex.Message)
            Return 0 ' Return 0 if there was an error
        End Try
    End Function

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
                            ' Only add rows if no column is null
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
            ' Fetch results using the QueryAsync function
            Dim results = Await QueryAsync(Of GrowthResult)(query)

            ' Loop through the results and add valid data points to the dataset
            For Each row In results
                ' Ensure that both Period and Total are not null
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

    ' === User Status Pie Data ===
    Public Shared Async Function GetActiveInactiveUserStatusAsync() As Task(Of (activeCount As Integer, inactiveCount As Integer))
        Dim query = "
        SELECT 
            COUNT(CASE WHEN status = 'active' THEN 1 ELSE NULL END) AS Active,
            COUNT(CASE WHEN status = 'inactive' THEN 1 ELSE NULL END) AS Inactive
        FROM useraccount"

        Try
            ' Using Dapper for async execution
            Using conn As SqlConnection = DatabaseConnection.GetConnection()
                Await conn.OpenAsync()
                Dim result = Await conn.QueryFirstOrDefaultAsync(Of UserStatus)(query)
                ' Return active and inactive counts as a tuple
                Return (result.Active, result.Inactive)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading user status: " & ex.Message)
            Return (0, 0) ' Return default values if an error occurs
        End Try
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

    Public Shared Async Function GetActiveUsers() As Task(Of Integer)
        Return Await GetCountAsync("SELECT COUNT(user_id) FROM useraccount where status='active'")
    End Function

    Public Shared Async Function GetInactiveUsers() As Task(Of Integer)
        Return Await GetCountAsync("SELECT COUNT(user_id) FROM useraccount where status='inactive'")
    End Function

    Public Shared Async Function GetUserFullData(Optional statusFilter As String = "") As Task(Of DataTable)
        Dim dt As New DataTable()

        ' Only add the columns that should appear in the DataGridView
        dt.Columns.Add("ID", GetType(Integer))
        dt.Columns.Add("Username", GetType(String))
        dt.Columns.Add("Email", GetType(String))
        dt.Columns.Add("Status", GetType(String))
        dt.Columns.Add("Birth_Date", GetType(DateTime))
        dt.Columns.Add("Contact", GetType(String))
        dt.Columns.Add("Date_Joined", GetType(DateTime))
        dt.Columns.Add("Type", GetType(Integer))

        ' Include the extra columns in the query for data collection, but not in the DataTable shown.
        Dim baseQuery As String = "SELECT user_id AS ID, username AS Username, email AS Email, status AS Status, birthdate AS Birth_Date, contact AS Contact, date_joined as Date_Joined, userType as Type FROM useraccount"

        If Not String.IsNullOrWhiteSpace(statusFilter) Then
            baseQuery &= " WHERE status = @status"
        End If

        Try
            Using conn As SqlConnection = DatabaseConnection.GetConnection(),
              cmd As New SqlCommand(baseQuery, conn)

                If Not String.IsNullOrWhiteSpace(statusFilter) Then
                    cmd.Parameters.AddWithValue("@status", statusFilter)
                End If

                Await conn.OpenAsync()
                Using reader As SqlDataReader = Await cmd.ExecuteReaderAsync()
                    While Await reader.ReadAsync()
                        dt.Rows.Add(reader("ID"), reader("Username"), reader("Email"), reader("Status"), reader("Birth_Date"), reader("Contact"), reader("Date_Joined"), reader("Type"))
                    End While
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("Database Error: " & ex.Message)
        End Try

        Return dt
    End Function

    Public Shared Async Function GetUserDetailsById(userId As Integer) As Task(Of DataRow)
        Dim dt As New DataTable()
        Dim query As String = "SELECT user_id AS ID, username, email, status, birthdate, contact, date_joined, userType, fullname, first_name, last_name, middle_initial FROM useraccount WHERE user_id = @userId"

        Try
            Using conn As SqlConnection = DatabaseConnection.GetConnection(),
              cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@userId", userId)
                Await conn.OpenAsync()

                Using reader As SqlDataReader = Await cmd.ExecuteReaderAsync()
                    dt.Load(reader) ' Load all the data from reader into DataTable
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("Error retrieving user details: " & ex.Message)
        End Try

        ' If DataTable has rows, return the first row (you can customize this based on your needs)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0)
        Else
            Return Nothing ' Return nothing if no data found
        End If
    End Function

    Public Shared Async Function UpdateUserStatus(userId As Integer, newStatus As String) As Task
        Dim query As String = "UPDATE useraccount SET status = @status WHERE user_id = @userId"

        Try
            Using conn As SqlConnection = DatabaseConnection.GetConnection(),
                  cmd As New SqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@status", newStatus)
                cmd.Parameters.AddWithValue("@userId", userId)

                Await conn.OpenAsync()
                Await cmd.ExecuteNonQueryAsync()
            End Using
        Catch ex As Exception
            Console.WriteLine("Error updating user status: " & ex.Message)
        End Try
    End Function

    Public Shared Async Function UpdateUserDetails(userId As Integer, updatedEmail As String, updatedPhone As String) As Task
        Dim query As String = "UPDATE useraccount SET email = @Email, contact = @Contact WHERE user_id = @UserId"

        Try
            Using conn As SqlConnection = DatabaseConnection.GetConnection(),
              cmd As New SqlCommand(query, conn)

                ' Add parameters to prevent SQL injection
                cmd.Parameters.AddWithValue("@Email", updatedEmail)
                cmd.Parameters.AddWithValue("@Contact", updatedPhone)
                cmd.Parameters.AddWithValue("@UserId", userId)

                ' Open the connection and execute the query
                Await conn.OpenAsync()
                Await cmd.ExecuteNonQueryAsync()
            End Using
        Catch ex As Exception
            Console.WriteLine("Database Error: " & ex.Message)
        End Try
    End Function





End Class
