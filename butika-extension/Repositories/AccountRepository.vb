Imports butika.Configurations
Imports Guna.Charts.WinForms
Imports butika.Helpers
Imports Dapper
Imports butika.Models
Imports System.Data.SqlClient
Imports System.Security.Policy

Public Class AccountRepository

    ' returns the userID of the user  when logged in
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

    ' this function is used to register a new user
    Public Async Function Signup(acc As Account) As Task(Of Boolean)
        If acc Is Nothing Then
            Return False
        End If

        Using conn = DatabaseConnection.GetConnection()
            Try
                Await conn.OpenAsync()

                Dim hash As New PasswordHashing(acc.Password)

                Dim query As String = "
                INSERT INTO userAccount (username, email, password, status, date_joined) 
                VALUES (@username, @email, @password, @status, @date_joined);
                SELECT CAST(SCOPE_IDENTITY() AS INT);
                "

                Dim userID As Integer = Await conn.ExecuteScalarAsync(Of Integer)(query, New With {
                .username = acc.UserName,
                .email = acc.Email,
                .password = hash.hashCombinedDisplay,
                .status = "active",
                .date_joined = acc.DateJoined()
            })
                If userID <> 0 Then
                    Return Await InsertHashingData(hash, userID)
                End If

            Catch ex As Exception
                MessageBox.Show("Error signing up: " & ex.Message)
                Return False
            End Try
        End Using
    End Function

    ' inserts hashed in the table
    Private Async Function InsertHashingData(hash As PasswordHashing, userID As Integer) As Task(Of Boolean)
        Using conn = DatabaseConnection.GetConnection()
            Dim query As String = "INSERT INTO hashing (hashSalt, hashPass, isPasswordChanged, user_id) " &
                          "VALUES (@hashSalt, @hashPass, 0, @userID)"
            Dim rows As Integer = Await conn.ExecuteAsync(query, New With {
                    .hashSalt = hash.hashSaltDisplay,
                    .hashPass = hash.hashPasswordDisplay,
                    .userID = userID
                    })

            Return rows > 0
        End Using
    End Function

    ' checks if the username is already taken
    Public Async Function CheckDuplicate(username As String) As Task(Of Boolean)
        Using conn = DatabaseConnection.GetConnection()
            Try
                Await conn.OpenAsync()

                Dim query As String = "SELECT username FROM userAccount WHERE username = @username AND status = @status"

                Dim result As String = Await conn.ExecuteScalarAsync(Of String)(query, New With {
                .username = username,
                .status = "active"
            })

                Return result IsNot Nothing

            Catch ex As Exception
                Console.WriteLine("Check duplication error: " & ex.Message)
                Return False
            End Try
        End Using
    End Function

    ' since we only use userID, we need to fill up their information
    Public Async Function populateDataThroughUserID(userID As Integer) As Task(Of Account)
        Dim populateData As New Account()

        Try
            Using conn = DatabaseConnection.GetConnection()
                Await conn.OpenAsync()
                Dim query As String = "SELECT *, user_id As UserID FROM userAccount WHERE user_id = @user_id"
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

    ' this function is used to update profile info from settings
    Public Async Function UpdateProfileInfo(acc As Account) As Task(Of Boolean)

        If acc Is Nothing Then
            Return False
        End If
        Debug.WriteLine("firstname: " + acc.FirstName)
        Using conn = DatabaseConnection.GetConnection()
            Try
                Await conn.OpenAsync()

                Dim query As String = "
                UPDATE userAccount 
                SET 
                    fullname = @fullname, 
                    first_name = @first_name, 
                    middle_initial = @middle_initial, 
                    last_name = @last_name, 
                    username = @username, 
                    birthdate = @birthdate
                WHERE user_id = @user_id;
                "

                Dim userID As Integer = Await conn.ExecuteScalarAsync(Of Integer)(query, New With {
                .fullname = acc.FirstName,
                .first_name = acc.FirstName,
                .middle_initial = acc.MiddleInitial,
                .last_name = acc.LastName,
                .username = acc.UserName,
                .birthdate = acc.BirthDate,
                .user_id = acc.UserID
            })
                If userID <> 0 Then
                    Return True
                End If

            Catch ex As Exception
                MessageBox.Show("Error updating info: " & ex.Message)
                Return False
            End Try
        End Using
    End Function

End Class


