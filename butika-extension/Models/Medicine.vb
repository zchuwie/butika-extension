Imports butika.Helpers

Namespace Models

    Public Class Medicine
        Public Property MedicineID As Integer
        Public Property MedicineName As String
        Public Property MedicineBrand As String
        Public Property MedicineDosage As String
        Public Property MedicineManufacturer As String
        Public Property MedicineDescription As String
        Public Property MedicinePrice As Decimal
        Public Property MedicineImageName As String
        Public Property MedicineType As String
        Public Property MedicinePrescription As Integer
        Public Property MedicineStock As Integer
        Public Property MedicineExpirationDate As DateTime?
        Public Property MedicineDateAdded As DateTime?
        Public Property MedicineLastUpdated As DateTime?
        Public Property MedicineFullName As String
        Public Property MedicineTickBox As Boolean


        Public ReadOnly Property MedicineImagePath As String
            Get
                Return GetImagePath.DrugPathName + "\\" + MedicineImageName
            End Get
        End Property

        Public ReadOnly Property FormattedMedicineName As String
            Get
                Return HelperMethod.RemoveCommaAndCapitalizeWords(MedicineName)
            End Get
        End Property

        Public ReadOnly Property DiscountedPrice As Decimal
            Get
                Return MedicinePrice - (MedicinePrice * 0.2)
            End Get
        End Property


        Public Property StockRequestStatus As String
        Public Property StockRequestedDate As DateTime?
        Public Property StockQuantityRequest As Integer
        Public Property StockReportID As Integer
        Public Property StockLastUpdated As DateTime?


    End Class
End Namespace
