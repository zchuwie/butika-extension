Imports Microsoft.Data.SqlClient

Namespace Configurations
    Public Class DatabaseConnection
        Private Shared server As String = ".\SQLEXPRESS10"
        Private Shared database As String = "butika"
        Public Shared connectionString As String =
            $"Server={server};Database={database};Trusted_Connection=True;TrustServerCertificate=True;"

        Public Shared Function GetConnection() As SqlConnection
            Return New SqlConnection(connectionString)
        End Function
    End Class
End Namespace
