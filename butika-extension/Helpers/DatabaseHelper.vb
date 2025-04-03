Imports butika.Configurations
Imports Microsoft.Data.SqlClient

Public Class DatabaseHelper
    ' Generic function to execute COUNT queries
    Public Shared Function GetCount(query As String) As Integer
        Try
            Using conn As SqlConnection = DatabaseConnection.GetConnection(),
                  cmd As New SqlCommand(query, conn)
                conn.Open()
                Dim result = cmd.ExecuteScalar()

                ' Convert result to integer safely
                Return If(result IsNot Nothing AndAlso Not IsDBNull(result), Convert.ToInt32(result), 0)
            End Using
        Catch ex As Exception
            Console.WriteLine("Database Error: " & ex.Message)
            Return -1 ' Return -1 to indicate an error
        End Try
    End Function
End Class
