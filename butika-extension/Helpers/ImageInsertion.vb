Imports System.IO

Public Class ImageInsertion

    Public Shared Function SaveImageToFolder(selectedImagePath As String, imageName As String, destinationFolder As String) As Boolean
        Try
            If String.IsNullOrEmpty(selectedImagePath) Then
                Console.WriteLine("No image selected.")
                Return False
            End If

            If Not File.Exists(selectedImagePath) Then
                Console.WriteLine("Image file does not exist.")
                Return False
            End If

            If Not Directory.Exists(destinationFolder) Then
                Directory.CreateDirectory(destinationFolder)
            End If

            Dim destinationPath As String = Path.Combine(destinationFolder, imageName)
            File.Copy(selectedImagePath, destinationPath, True)

            Console.WriteLine($"Image saved successfully to {destinationPath}!")
            Return True
        Catch ex As Exception
            Console.WriteLine("Error inserting image into the folder: " & ex.Message)
            Return False
        End Try
    End Function
End Class
