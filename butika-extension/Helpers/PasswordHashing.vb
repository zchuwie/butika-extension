Imports System.Security.Cryptography
Imports System.Text

Namespace Helpers
    Public Class PasswordHashing
        Public Property Password As String

        Public ReadOnly Property hashSaltDisplay As String
            Get
                Return stringHashSalt()
            End Get
        End Property

        Public ReadOnly Property hashPasswordDisplay As String
            Get
                Return stringHashPassword()
            End Get
        End Property

        Public ReadOnly Property hashCombinedDisplay As String
            Get
                Return hashedPassword()
            End Get
        End Property

        Public Sub New(ByVal password As String)
            Me.Password = password
        End Sub

        ' Generates a salt based on the user input. It takes half of the password and turns it into bytes.
        Public Function generateSalt() As Byte()
            Dim halfLength As Integer = Password.Length \ 2
            Dim setSalt As String = Password.Substring(halfLength, halfLength)
            Dim newSalt As Byte() = Encoding.UTF8.GetBytes(setSalt)
            Return newSalt
        End Function

        ' Turns the user input into bytes and hashes it.
        Public Function hashPassword() As Byte()
            Using hash As SHA256 = SHA256.Create()
                Dim newPassword As Byte() = Encoding.UTF8.GetBytes(Password)
                Return hash.ComputeHash(newPassword)
            End Using
        End Function

        ' Turns the salt into hashed bytes.
        Public Function hashSalt() As Byte()
            Dim salt As Byte() = generateSalt()
            Using hash As SHA256 = SHA256.Create()
                Return hash.ComputeHash(salt)
            End Using
        End Function

        ' Gets the combined salt and password hashed and returns it as a string.
        Public Function hashedPassword() As String
            Dim _hashSalt As Byte() = hashSalt()
            Dim _hashPassword As Byte() = hashPassword()
            Dim saltedPassword(_hashSalt.Length + _hashPassword.Length - 1) As Byte

            Buffer.BlockCopy(_hashPassword, 0, saltedPassword, 0, _hashPassword.Length)
            Buffer.BlockCopy(_hashSalt, 0, saltedPassword, _hashPassword.Length, _hashSalt.Length)

            Return BitConverter.ToString(saltedPassword).Replace("-", "").ToLower()
        End Function

        ' Turns the password hash into a string.
        Public Function stringHashPassword() As String
            Dim _hashPassword As Byte() = hashPassword()
            Return BitConverter.ToString(_hashPassword).Replace("-", "").ToLower()
        End Function

        ' Turns the salt hash into a string.
        Public Function stringHashSalt() As String
            Dim _hashSalt As Byte() = hashSalt()
            Return BitConverter.ToString(_hashSalt).Replace("-", "").ToLower()
        End Function
    End Class
End Namespace
