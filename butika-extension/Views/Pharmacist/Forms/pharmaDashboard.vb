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

    Private Sub pharmaDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        infoManagerIcon.SetToolTip(infoIcon, "This is where you can see the pharmacy's progress, including transaction status, pharmaceutical stocks, and pending and approved prescriptions.")
        infoManagerIcon.ShowAlways = True
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
End Class