Imports butika.Models

Public Class pharmaDashboard
    Private mainPage As pharmaMainPage
    Public Sub New(mainForm As pharmaMainPage)
        InitializeComponent()
        Me.mainPage = mainForm
    End Sub
    Private Sub OpenFormInPanel(ByVal form As Form)

        form.TopLevel = False
        form.Dock = DockStyle.Fill

        mainPage.mainPanel.Controls.Clear()
        mainPage.mainPanel.Controls.Add(form)
        form.Show()
    End Sub

    Private Async Sub pharmaDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        infoManagerIcon.SetToolTip(infoIcon, "This is where you can see the pharmacy's progress, including transaction status, pharmaceutical stocks, and pending and approved prescriptions.")
        infoManagerIcon.ShowAlways = True

        Await LoadAllTransactions()
        Await LoadAllPrescriptions()
    End Sub

    Private Sub goTransacPage_Click(sender As Object, e As EventArgs) Handles goTransacPage.Click
        UIHelper.BtnColorChange(mainPage.dashboardBtn, Color.FromArgb(220, 229, 219), Color.FromArgb(22, 66, 60), My.Resources.ldashboard_icon)
        UIHelper.BtnColorChange(mainPage.transactionBtn, Color.FromArgb(22, 66, 60), Color.FromArgb(220, 229, 219), My.Resources.dtransactions_icon)
        OpenFormInPanel(New pharmaTransactions())
    End Sub

    Private Sub goMedPage_Click(sender As Object, e As EventArgs) Handles goMedPage.Click
        UIHelper.BtnColorChange(mainPage.dashboardBtn, Color.FromArgb(220, 229, 219), Color.FromArgb(22, 66, 60), My.Resources.ldashboard_icon)
        UIHelper.BtnColorChange(mainPage.medicineBtn, Color.FromArgb(22, 66, 60), Color.FromArgb(220, 229, 219), My.Resources.dmedicine_icon)
        OpenFormInPanel(New pharmaMedicines())
    End Sub

    Private Sub goPrescriptPage_Click(sender As Object, e As EventArgs) Handles goPrescriptPage.Click
        UIHelper.BtnColorChange(mainPage.dashboardBtn, Color.FromArgb(220, 229, 219), Color.FromArgb(22, 66, 60), My.Resources.ldashboard_icon)
        UIHelper.BtnColorChange(mainPage.prescriptionBtn, Color.FromArgb(22, 66, 60), Color.FromArgb(220, 229, 219), My.Resources.dprescription_icon)
        OpenFormInPanel(New pharmaPrescriptions())
    End Sub

    Public Async Function LoadAllPrescriptions() As Task
        flpPrescript.Controls.Clear()

        Dim prescriptRepo As New PharmaRepository()
        Dim allPrescriptions As List(Of Prescription) = Await prescriptRepo.GetAllPrescriptions()

        Dim batchSize As Integer = 5

        For i As Integer = 0 To allPrescriptions.Count - 1 Step batchSize
            Dim batch = allPrescriptions.Skip(i).Take(batchSize).ToList()

            For Each indivPrescript In batch
                Dim usc As New pharmaDashPrescript()
                usc.Initialize(indivPrescript)
                flpPrescript.Controls.Add(usc)
            Next

            Await Task.Delay(50)
        Next

    End Function
    Public Async Function LoadAllTransactions() As Task
        flpTransac.Controls.Clear()

        Dim transacRepo As New PharmaRepository()
        Dim allTransactions As List(Of Transaction) = Await transacRepo.GetAllTransactions()

        Dim batchSize As Integer = 5

        For i As Integer = 0 To allTransactions.Count - 1 Step batchSize
            Dim batch = allTransactions.Skip(i).Take(batchSize).ToList()

            For Each indivTransac In batch
                Dim usc As New pharmaDashTransac()
                usc.Initialize(indivTransac)
                flpTransac.Controls.Add(usc)
            Next

            Await Task.Delay(50)
        Next
    End Function
End Class