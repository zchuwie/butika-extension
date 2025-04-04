Imports butika.Configurations
Imports Guna.Charts.WinForms
Imports butika.Helpers
Imports Dapper
Imports butika.Models
Imports System.Data.SqlClient

Public Class AccountRepository
    Public Async Function Login(username As String, password As String) As Task(Of Integer)
        Using conn = DatabaseConnection.GetConnection()
            Try
                Await conn.OpenAsync()

                Dim hash As New PasswordHashing(password)
                Dim query As String = "SELECT user_id FROM userAccount WHERE username = @username AND password = @password"

                ' Use Dapper to execute the query with parameters
                Dim result As Integer? = Await conn.ExecuteScalarAsync(Of Integer?)(query, New With {
                Key .username = username,
                Key .password = hash.hashCombinedDisplay
            })

                Return If(result.HasValue, result.Value, 0)
            Catch ex As Exception
                MessageBox.Show("Username or password incorrect. Try again.")
                Console.WriteLine("Login error: " & ex.Message)
                Return 0
            End Try
        End Using
    End Function

    Public Async Function populateDataThroughUserID(userID As Integer) As Task(Of Account)
        Dim populateData As New Account()

        Try
            Using conn = DatabaseConnection.GetConnection()
                Await conn.OpenAsync()
                Dim query As String = "SELECT * FROM userAccount WHERE user_id = @user_id"
                Dim result = Await conn.QueryFirstOrDefaultAsync(Of Account)(query, New With {.user_id = userID})

                ' If result is not nothing, populate the Account object
                If result IsNot Nothing Then
                    populateData = result
                End If
            End Using

        Catch ex As Exception
            Debug.WriteLine("Error populating user data: " & ex.Message)
            Return Nothing
        End Try

        Return populateData
    End Function

End Class
