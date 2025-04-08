Imports butika.Models


Public Class MedicinePage

#Region "Functions"
    Private Sub underlineFilter(ByVal med As Boolean, ByVal otc As Boolean, ByVal presc As Boolean)
        AllMedsUnderline.Visible = med
        OTCUnderline.Visible = otc
        PrescUnderline.Visible = presc
    End Sub

#End Region
    Dim account As New Account()

    Public Sub New(account As Account)
        InitializeComponent()
        Me.account = account
    End Sub

    Private Async Sub MedicinePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        underlineFilter(True, False, False)
        Await LoadAllMedicine()
    End Sub

    Private Async Sub AllMeds_Click(sender As Object, e As EventArgs) Handles AllMeds.Click
        underlineFilter(True, False, False)
        Await LoadAllMedicine()
    End Sub

    Private Async Sub OverTheCounter_Click(sender As Object, e As EventArgs) Handles OverTheCounter.Click
        underlineFilter(False, True, False)
        Await LoadOtcMedicine()
    End Sub

    Private Async Sub NeedsPrescription_Click(sender As Object, e As EventArgs) Handles NeedsPrescription.Click
        underlineFilter(False, False, True)
        Await LoadPrescriptionMedicine()
    End Sub

    Public Async Function LoadAllMedicine() As Task
        MedicineDisplayPanel.Controls.Clear()

        Dim medicineRepo As New MedicineRepository()
        Dim allMedicines As List(Of Medicine) = Await medicineRepo.allMedicines()

        Dim batchSize As Integer = 5

        For i As Integer = 0 To allMedicines.Count - 1 Step batchSize
            Dim batch = allMedicines.Skip(i).Take(batchSize).ToList()

            For Each individualMedicine In batch
                Dim card As New medItem(account)
                card.Initialize(individualMedicine)

                If individualMedicine.MedicinePrescription = 0 Then
                    card.itemIdentifier.BackColor = System.Drawing.Color.Green
                ElseIf individualMedicine.MedicinePrescription = 1 Then
                    card.itemIdentifier.BackColor = System.Drawing.Color.Yellow
                End If

                MedicineDisplayPanel.Controls.Add(card)
            Next

            Await Task.Delay(50)
        Next

    End Function

    Public Async Function LoadOtcMedicine() As Task
        MedicineDisplayPanel.Controls.Clear()

        Dim medicineRepo As New MedicineRepository()
        Dim allMedicines As List(Of Medicine) = Await medicineRepo.otcMedicines()

        Dim batchSize As Integer = 5

        For i As Integer = 0 To allMedicines.Count - 1 Step batchSize
            Dim batch = allMedicines.Skip(i).Take(batchSize).ToList()

            For Each individualMedicine In batch
                Dim card As New medItem(account)
                card.Initialize(individualMedicine)

                If individualMedicine.MedicinePrescription = 0 Then
                    card.itemIdentifier.BackColor = System.Drawing.Color.Green
                ElseIf individualMedicine.MedicinePrescription = 1 Then
                    card.itemIdentifier.BackColor = System.Drawing.Color.Yellow
                End If

                MedicineDisplayPanel.Controls.Add(card)
            Next

            Await Task.Delay(50)
        Next

    End Function

    Public Async Function LoadPrescriptionMedicine() As Task
        MedicineDisplayPanel.Controls.Clear()

        Dim medicineRepo As New MedicineRepository()
        Dim allMedicines As List(Of Medicine) = Await medicineRepo.prescriptionMedicines()

        Dim batchSize As Integer = 5

        For i As Integer = 0 To allMedicines.Count - 1 Step batchSize
            Dim batch = allMedicines.Skip(i).Take(batchSize).ToList()

            For Each individualMedicine In batch
                Dim card As New medItem(account)
                card.Initialize(individualMedicine)

                If individualMedicine.MedicinePrescription = 0 Then
                    card.itemIdentifier.BackColor = System.Drawing.Color.Green
                ElseIf individualMedicine.MedicinePrescription = 1 Then
                    card.itemIdentifier.BackColor = System.Drawing.Color.Yellow
                End If

                MedicineDisplayPanel.Controls.Add(card)
            Next

            Await Task.Delay(50)
        Next

    End Function
End Class