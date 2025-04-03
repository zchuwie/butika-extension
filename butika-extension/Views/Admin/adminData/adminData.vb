Imports butika.Configurations
Imports Guna.Charts.WinForms
Imports Microsoft.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class adminData
    ' Function to count all users
    Public Shared Function GetUserCount() As Integer
        Return DatabaseHelper.GetCount("SELECT COUNT(user_id) FROM useraccount")
    End Function

    ' Function to count active users (status = 'active')
    Public Shared Function GetActiveUserCount() As Integer
        Return DatabaseHelper.GetCount("SELECT COUNT(user_id) FROM useraccount WHERE status = 'active'")
    End Function

    ' Function to count pending discounts (isVerified = true)
    Public Shared Function GetPendingDiscountCount() As Integer
        Return DatabaseHelper.GetCount("SELECT COUNT(user_id) FROM useraccount WHERE isVerified = 1")
    End Function

    ' Function to count new signups (date_joined in the last 2 weeks)
    Public Shared Function GetNewSignupCount() As Integer
        Return DatabaseHelper.GetCount("SELECT COUNT(user_id) FROM useraccount WHERE date_joined >= DATEADD(DAY, -14, GETDATE())")
    End Function

    Public Shared Function GetUserData() As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As SqlConnection = DatabaseConnection.GetConnection(),
                  cmd As New SqlCommand("SELECT user_id AS ID, fullName AS Name, email AS Email, status AS Status FROM useraccount", conn),
                  adapter As New SqlDataAdapter(cmd) ' Ensure this is correctly imported
                conn.Open()
                adapter.Fill(dt) ' Fill DataTable with query results
            End Using
        Catch ex As Exception
            Console.WriteLine("Database Error: " & ex.Message)
        End Try
        Return dt
    End Function

    Public Shared Function GetUserActivityData() As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As SqlConnection = DatabaseConnection.GetConnection(),
                  cmd As New SqlCommand("
                      SELECT ua.user_id AS ID, 
                             ua.username AS Username, 
                             al.activity AS Action, 
                             al._datetime AS Date 
                      FROM useraccount ua
                      INNER JOIN activity_log al ON ua.user_id = al.user_id
                      ORDER BY al._datetime DESC", conn),
                  adapter As New SqlDataAdapter(cmd)
                conn.Open()
                adapter.Fill(dt) ' Fill DataTable with query results
            End Using
        Catch ex As Exception
            Console.WriteLine("Database Error: " & ex.Message)
        End Try
        Return dt
    End Function

    ' Function to get user growth data
    Public Shared Function GetUserGrowth(period As String) As GunaLineDataset
        Dim dataset As New GunaLineDataset()
        dataset.Label = "User Logins"

        Try
            Using conn As SqlConnection = DatabaseConnection.GetConnection(),
                  cmd As New SqlCommand("", conn)

                conn.Open()

                ' Select query based on period
                Select Case period
                    Case "week"
                        cmd.CommandText = "SELECT FORMAT(date_joined, 'yyyy-MM-dd') AS Period, COUNT(*) AS Total 
                                       FROM useraccount 
                                       WHERE date_joined >= DATEADD(WEEK, -1, GETDATE())
                                       GROUP BY FORMAT(date_joined, 'yyyy-MM-dd') 
                                       ORDER BY Period"

                    Case "month"
                        cmd.CommandText = "SELECT FORMAT(date_joined, 'yyyy-MM') AS Period, COUNT(*) AS Total 
                                       FROM useraccount 
                                       WHERE date_joined >= DATEADD(MONTH, -6, GETDATE())
                                       GROUP BY FORMAT(date_joined, 'yyyy-MM') 
                                       ORDER BY Period"

                    Case "year"
                        cmd.CommandText = "SELECT FORMAT(date_joined, 'yyyy') AS Period, COUNT(*) AS Total 
                                       FROM useraccount 
                                       GROUP BY FORMAT(date_joined, 'yyyy') 
                                       ORDER BY Period"
                End Select

                ' Execute query
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        dataset.DataPoints.Add(reader("Period").ToString(), Convert.ToInt32(reader("Total")))
                    End While
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

        Return dataset
    End Function

    ' Function to fetch discount verification data
    Public Shared Function GetDiscountStatus() As (verifiedCount As Integer, notVerifiedCount As Integer)
        Dim verifiedCount As Integer = 0
        Dim notVerifiedCount As Integer = 0

        Try
            Using conn As SqlConnection = DatabaseConnection.GetConnection(),
                  cmd As New SqlCommand("SELECT 
                                            COUNT(CASE WHEN isVerified = 1 THEN 1 ELSE NULL END) AS Verified,
                                            COUNT(CASE WHEN isVerified = 0 THEN 1 ELSE NULL END) AS NotVerified
                                        FROM useraccount", conn)

                conn.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        verifiedCount = Convert.ToInt32(reader("Verified"))
                        notVerifiedCount = Convert.ToInt32(reader("NotVerified"))
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

        ' Return the counts for further use
        Return (verifiedCount, notVerifiedCount)
    End Function

End Class
