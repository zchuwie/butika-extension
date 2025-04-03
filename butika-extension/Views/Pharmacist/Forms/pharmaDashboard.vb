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
        OpenFormInPanel(New pharmaTransactions())
    End Sub

    Private Sub goMedPage_Click(sender As Object, e As EventArgs) Handles goMedPage.Click
        OpenFormInPanel(New pharmaMedicines())
    End Sub

    Private Sub goPrescriptPage_Click(sender As Object, e As EventArgs) Handles goPrescriptPage.Click
        OpenFormInPanel(New pharmaPrescriptions())
    End Sub
End Class