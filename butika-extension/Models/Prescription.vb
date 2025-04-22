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
        Public Property PrescriptionDate As DateTime?
        Public Property PrescriptionRemarks As String
        Public Property PrescriptReviewDate As DateTime?
        Public Property PrescriptionStatus As Integer
        Public Property Account As Account
        Public Property Medicine As Medicine
        Public Property Cart As Cart

        Public ReadOnly Property PresciptImagePath As String
            Get
                Return GetImagePath.PrescriptionPathName + "\\" + PrescriptionImageName
            End Get
        End Property
    End Class

End Namespace
