Namespace Models

    Public Class Prescription
        Public Property PrescriptionId As Integer
        Public Property PatientName As String
        Public Property PatientConcern As String
        Public Property PatientAge As String
        Public Property PatientGender As String
        Public Property DoctorName As String
        Public Property DoctorPlace As String
        Public Property DoctorContact As String
        Public Property PrescriptionImageName As String
        Public Property PrescriptionDate As String
        Public Property PrescriptionRemarks As String

        Public ReadOnly Property PresciptImagePath As String
            Get
                Return GetImagePath.PrescriptionPathName + "\\" + PrescriptionImageName
            End Get
        End Property
    End Class

End Namespace
