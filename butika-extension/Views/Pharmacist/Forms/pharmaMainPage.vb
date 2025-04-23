Imports Guna.UI2.WinForms

Public Class pharmaMainPage

    Private Sub OpenFormInPanel(ByVal form As Form)
        form.TopLevel = False
        form.Dock = DockStyle.Fill

        mainPanel.Controls.Clear()
        mainPanel.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub pharmaMainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenFormInPanel(New pharmaDashboard(Me))
    End Sub

    Private Sub dashboardBtn_Click(sender As Object, e As EventArgs) Handles dashboardBtn.Click
        UIHelper.BtnColorChange(dashboardBtn, Color.FromArgb(22, 66, 60), Color.FromArgb(220, 229, 219), My.Resources.ddashboard_icon)
        UIHelper.BtnColorChange(transactionBtn, Color.FromArgb(220, 229, 219), Color.FromArgb(22, 66, 60), My.Resources.ltransaction_icon)
        UIHelper.BtnColorChange(medicineBtn, Color.FromArgb(220, 229, 219), Color.FromArgb(22, 66, 60), My.Resources.lmedicines_icon)
        UIHelper.BtnColorChange(prescriptionBtn, Color.FromArgb(220, 229, 219), Color.FromArgb(22, 66, 60), My.Resources.lprescription_icon)
        OpenFormInPanel(New pharmaDashboard(Me))
    End Sub

    Private Sub transactionBtn_Click(sender As Object, e As EventArgs) Handles transactionBtn.Click
        UIHelper.BtnColorChange(dashboardBtn, Color.FromArgb(220, 229, 219), Color.FromArgb(22, 66, 60), My.Resources.ldashboard_icon)
        UIHelper.BtnColorChange(transactionBtn, Color.FromArgb(22, 66, 60), Color.FromArgb(220, 229, 219), My.Resources.dtransactions_icon)
        UIHelper.BtnColorChange(medicineBtn, Color.FromArgb(220, 229, 219), Color.FromArgb(22, 66, 60), My.Resources.lmedicines_icon)
        UIHelper.BtnColorChange(prescriptionBtn, Color.FromArgb(220, 229, 219), Color.FromArgb(22, 66, 60), My.Resources.lprescription_icon)
        OpenFormInPanel(New pharmaTransactions())
    End Sub

    Private Sub medicineBtn_Click(sender As Object, e As EventArgs) Handles medicineBtn.Click
        UIHelper.BtnColorChange(dashboardBtn, Color.FromArgb(220, 229, 219), Color.FromArgb(22, 66, 60), My.Resources.ldashboard_icon)
        UIHelper.BtnColorChange(transactionBtn, Color.FromArgb(220, 229, 219), Color.FromArgb(22, 66, 60), My.Resources.ltransaction_icon)
        UIHelper.BtnColorChange(medicineBtn, Color.FromArgb(22, 66, 60), Color.FromArgb(220, 229, 219), My.Resources.dmedicine_icon)
        UIHelper.BtnColorChange(prescriptionBtn, Color.FromArgb(220, 229, 219), Color.FromArgb(22, 66, 60), My.Resources.lprescription_icon)
        OpenFormInPanel(New pharmaMedicines())
    End Sub

    Private Sub prescriptionBtn_Click(sender As Object, e As EventArgs) Handles prescriptionBtn.Click
        UIHelper.BtnColorChange(dashboardBtn, Color.FromArgb(220, 229, 219), Color.FromArgb(22, 66, 60), My.Resources.ldashboard_icon)
        UIHelper.BtnColorChange(transactionBtn, Color.FromArgb(220, 229, 219), Color.FromArgb(22, 66, 60), My.Resources.ltransaction_icon)
        UIHelper.BtnColorChange(medicineBtn, Color.FromArgb(220, 229, 219), Color.FromArgb(22, 66, 60), My.Resources.lmedicines_icon)
        UIHelper.BtnColorChange(prescriptionBtn, Color.FromArgb(22, 66, 60), Color.FromArgb(220, 229, 219), My.Resources.dprescription_icon)
        OpenFormInPanel(New pharmaPrescriptions())
    End Sub

    Private Async Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Dim loginForm As New Login()
        Dim userID As Integer = SessionInfo.CurrentUserID
        Dim userType As Integer = SessionInfo.CurrentUserType

        ' Log the logout activity
        Await AdminRepository.LogLogoutActivity(userID, userType)

        loginForm.Show()
        Me.Close()
    End Sub
End Class