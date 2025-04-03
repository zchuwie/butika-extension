Imports System.Text.RegularExpressions

Namespace Helpers
    Public Module InputValidation
        Public Function isEmailValid(ByVal email As String) As Boolean
            Dim regex As New Regex("^[\w\.-]+@[a-zA-Z\d-]+\.[a-zA-Z]{2,}$")
            Return regex.IsMatch(email)
        End Function

        Public Function isPasswordValid(ByVal password As String) As Boolean
            Dim regex As New Regex("^(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_\-+=<>?{}~])[A-Za-z\d!@#$%^&*()_\-+=<>?{}~]{8,}$")
            Return regex.IsMatch(password)
        End Function

        Public Function isContactValid(ByVal contact As String) As Boolean
            Dim regex As New Regex("^(09\d{9}|\+639\d{9})$")
            Return regex.IsMatch(contact)
        End Function

        Public Function isNameValid(ByVal name As String) As Boolean
            Dim regex As New Regex("^[a-zA-Z]+(?: [a-zA-Z]+(?:\.?)*)*$")
            Return regex.IsMatch(name) AndAlso Not String.IsNullOrEmpty(name)
        End Function
    End Module
End Namespace