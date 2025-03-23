Imports butika.Models

Namespace Model
    Public Class Cart
        Public Property Medicine As Medicine
        Public Property CartID As Integer
        Public Property UserID As Integer
        Public Property Quantity As Integer
        Public Property CartDate As DateTime?
        Public Property CartStatus As String
    End Class
End Namespace