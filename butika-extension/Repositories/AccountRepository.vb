Imports butika.Configurations
Imports Guna.Charts.WinForms
Imports butika.Helpers
Imports Dapper
Imports butika.Models
Imports System.Data.SqlClient
Imports System.Security.Policy
Imports Microsoft.VisualBasic.ApplicationServices

Public Class AccountRepository

    ' returns the userID of the user  when logged in
    Public Async Function Login(username As String, password As String) As Task(Of (Integer, Integer))
        Using conn = DatabaseConnection.GetConnection()
            Try
                Await conn.OpenAsync()

                Dim hash As New PasswordHashing(password)
                Dim query As String = "SELECT user_id, userType FROM userAccount WHERE username = @username AND password = @password"

                ' Use Dapper to execute the query with parameters and return both user_id and userType
                Dim result = Await conn.QuerySingleOrDefaultAsync(Of (Integer, Integer))(query, New With {
                Key .username = username,
                Key .password = hash.hashCombinedDisplay
            })

                If result.Equals((0, 0)) Then
                    ' Return default values if no result found
                    Return (0, 0)
                End If

                ' Return the user_id and userType
                Return result
            Catch ex As Exception
                MessageBox.Show("Username or password incorrect. Try again.")
                Console.WriteLine("Login error: " & ex.Message)
                Return (0, 0) ' Return default tuple on error
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

    ' checks if the email is already taken
    Public Async Function CheckDuplicateEmail(email As String) As Task(Of Boolean)
        Using conn = DatabaseConnection.GetConnection()
            Try
                Await conn.OpenAsync()

                Dim query As String = "SELECT email FROM userAccount WHERE email = @email AND status = @status"

                Dim result As String = Await conn.ExecuteScalarAsync(Of String)(query, New With {
                .email = email,
                .status = "active"
            })

                Return result IsNot Nothing

            Catch ex As Exception
                Console.WriteLine("Check email duplication error: " & ex.Message)
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
                Dim query As String = "SELECT *, last_name As LastName, first_name As FirstName, middle_initial As MiddleInitial, user_id As UserID FROM userAccount WHERE user_id = @user_id"
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

    Public Async Function UpdateProfileInfo(acc As Account) As Task(Of Boolean)
        If acc Is Nothing Then
            Return False
        End If

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

                Dim result As Integer = Await conn.ExecuteScalarAsync(Of Integer)(query, New With {
                .fullname = acc.FirstName + "" + acc.MiddleInitial + "" + acc.LastName,
                .first_name = acc.FirstName,
                .middle_initial = acc.MiddleInitial,
                .last_name = acc.LastName,
                .username = acc.UserName,
                .birthdate = acc.BirthDate,
                .user_id = acc.UserID
            })
                If result <> 0 Then
                    'Return Await InsertHashingData(Hash, userID)
                    MessageBox.Show("Success.")
                End If

            Catch ex As Exception
                MessageBox.Show("Error updating info: " & ex.Message)
            End Try
        End Using
    End Function

    Public Async Function UpdateContactInfo(acc As Account) As Task(Of Boolean)
        If acc Is Nothing Then
            Return False
        End If

        Using conn = DatabaseConnection.GetConnection()
            Try
                Await conn.OpenAsync()

                Dim query As String = "
                 UPDATE userAccount 
                 SET 
                     email = @email, 
                     contact = @contact
                 WHERE user_id = @user_id;
                 "

                Debug.WriteLine("userid: " + acc.UserID.ToString())

                Dim result As Boolean = Await conn.ExecuteAsync(query, New With {
                     .email = acc.Email,
                     .contact = acc.Contact,
                     .user_id = acc.UserID
                 })

                If Not result Then
                    MessageBox.Show("An error occured. Try again.")
                    Return False
                End If


            Catch ex As Exception
                MessageBox.Show("Error updating contact: " & ex.Message)
            End Try
        End Using
    End Function

    Public Async Function UpdatePassword(acc As Account) As Task(Of Boolean)
        If acc Is Nothing Then
            Return False
        End If

        Using conn = DatabaseConnection.GetConnection()
            Try
                Await conn.OpenAsync()

                Dim query As String = "
                 UPDATE userAccount 
                 SET
                     password = @password
                 WHERE user_id = @user_id;
                 "

                Debug.WriteLine("userid: " + acc.UserID.ToString())

                Dim result As Boolean = Await conn.ExecuteAsync(query, New With {
                     .password = acc.Password,
                     .user_id = acc.UserID
                 })

                If Not result Then
                    MessageBox.Show("An error occured. Try again.")
                    Return False
                End If


            Catch ex As Exception
                MessageBox.Show("Error updating contact: " & ex.Message)
            End Try
        End Using
    End Function

End Class


