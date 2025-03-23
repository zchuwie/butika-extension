Imports System.IO

Public Class GetImagePath
    Public Shared ReadOnly Property DrugPathName As String
        Get
            Return DrugPath()
        End Get
    End Property

    Public Shared ReadOnly Property PrescriptionPathName As String
        Get
            Return PrescriptionPath()
        End Get
    End Property

    Public Shared Function FindDrugImageFolder(ByVal startFolder As String) As String
        Dim currentFolder As String = startFolder

        While currentFolder IsNot Nothing
            Dim targetFolderPath As String = Path.Combine(currentFolder, "Resources", "drug_images")

            If Directory.Exists(targetFolderPath) Then
                Return targetFolderPath
            End If

            currentFolder = Directory.GetParent(currentFolder)?.FullName
        End While

        Return Nothing
    End Function

    Public Shared Function DrugPath() As String
        Try
            Dim currentDirectory As String = Directory.GetCurrentDirectory()
            Dim imageFolder As String = GetImagePath.FindDrugImageFolder(currentDirectory)

            If Not String.IsNullOrEmpty(imageFolder) Then
                Return imageFolder
            Else
                Return Nothing
            End If

        Catch ex As Exception
            Console.WriteLine("Cannot find the folder: " & ex.Message)
            Return Nothing
        End Try
    End Function

    Public Shared Function FindPrescriptionImageFolder(ByVal startFolder As String) As String
        Dim currentFolder As String = startFolder

        While currentFolder IsNot Nothing
            Dim targetFolderPath As String = Path.Combine(currentFolder, "Resources", "prescription_images")

            If Directory.Exists(targetFolderPath) Then
                Return targetFolderPath
            End If

            currentFolder = Directory.GetParent(currentFolder)?.FullName
        End While

        Return Nothing
    End Function

    Public Shared Function PrescriptionPath() As String
        Try
            Dim currentDirectory As String = Directory.GetCurrentDirectory()
            Dim imageFolder As String = GetImagePath.FindPrescriptionImageFolder(currentDirectory)

            If Not String.IsNullOrEmpty(imageFolder) Then
                Return imageFolder
            Else
                Return Nothing
            End If

        Catch ex As Exception
            Console.WriteLine("Cannot find the folder: " & ex.Message)
            Return Nothing
        End Try
    End Function

    Public Shared Function isImageExisting(ByVal imageName As String) As Boolean
        Try
            Dim filePath As String = DrugPath()
            Dim imageFilePath As String = filePath & "\" & imageName

            If File.Exists(imageFilePath) Then
                Return True
            End If

            Return False
        Catch ex As Exception
            Debug.WriteLine("There was error checking if the image already exists: " & ex.Message)
            Return False
        End Try
    End Function
End Class
