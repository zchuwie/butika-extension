Imports butika.Models

Namespace Models
    Public Class Cart
        Public Property Medicine As Medicine
        Public Property CartID As Integer
        Public Property UserID As Integer
        Public Property Quantity As Integer
        Public Property isTicked As Boolean
        Public Property isApproved As Integer
        Public Property PrescriptionID As Integer
    End Class
End Namespace