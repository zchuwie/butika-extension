Imports Guna.UI2.WinForms

Public Class pharmaMainPage

    Private Sub OpenFormInPanel(ByVal form As Form)
        form.TopLevel = False
        form.Dock = DockStyle.Fill

        mainPanel.Controls.Clear()
        mainPanel.Controls.Add(form)
        form.Show()
    End Sub
    Private Sub BtnColorChange(button As Guna2Button, forecolor As Color, fillcolor As Color, image As Image)
        button.ForeColor = forecolor
        button.FillColor = fillcolor
        button.Image = image
    End Sub

    Private Sub pharmaMainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenFormInPanel(New pharmaDashboard(Me))
    End Sub

    Private Sub dashboardBtn_Click(sender As Object, e As EventArgs) Handles dashboardBtn.Click
        BtnColorChange(dashboardBtn, Color.FromArgb(22, 66, 60), Color.FromArgb(220, 229, 219), My.Resources.ddashboard_icon)
        BtnColorChange(transactionBtn, Color.FromArgb(220, 229, 219), Color.FromArgb(22, 66, 60), My.Resources.ltransaction_icon)
        BtnColorChange(medicineBtn, Color.FromArgb(220, 229, 219), Color.FromArgb(22, 66, 60), My.Resources.lmedicines_icon)
        BtnColorChange(prescriptionBtn, Color.FromArgb(220, 229, 219), Color.FromArgb(22, 66, 60), My.Resources.lprescription_icon)
        OpenFormInPanel(New pharmaDashboard(Me))
    End Sub

    Private Sub transactionBtn_Click(sender As Object, e As EventArgs) Handles transactionBtn.Click
        BtnColorChange(dashboardBtn, Color.FromArgb(220, 229, 219), Color.FromArgb(22, 66, 60), My.Resources.ldashboard_icon)
        BtnColorChange(transactionBtn, Color.FromArgb(22, 66, 60), Color.FromArgb(220, 229, 219), My.Resources.dtransactions_icon)
        BtnColorChange(medicineBtn, Color.FromArgb(220, 229, 219), Color.FromArgb(22, 66, 60), My.Resources.lmedicines_icon)
        BtnColorChange(prescriptionBtn, Color.FromArgb(220, 229, 219), Color.FromArgb(22, 66, 60), My.Resources.lprescription_icon)
        OpenFormInPanel(New pharmaTransactions())
    End Sub

    Private Sub medicineBtn_Click(sender As Object, e As EventArgs) Handles medicineBtn.Click
        BtnColorChange(dashboardBtn, Color.FromArgb(220, 229, 219), Color.FromArgb(22, 66, 60), My.Resources.ldashboard_icon)
        BtnColorChange(transactionBtn, Color.FromArgb(220, 229, 219), Color.FromArgb(22, 66, 60), My.Resources.ltransaction_icon)
        BtnColorChange(medicineBtn, Color.FromArgb(22, 66, 60), Color.FromArgb(220, 229, 219), My.Resources.dmedicine_icon)
        BtnColorChange(prescriptionBtn, Color.FromArgb(220, 229, 219), Color.FromArgb(22, 66, 60), My.Resources.lprescription_icon)
        OpenFormInPanel(New pharmaMedicines())
    End Sub

    Private Sub prescriptionBtn_Click(sender As Object, e As EventArgs) Handles prescriptionBtn.Click
        BtnColorChange(dashboardBtn, Color.FromArgb(220, 229, 219), Color.FromArgb(22, 66, 60), My.Resources.ldashboard_icon)
        BtnColorChange(transactionBtn, Color.FromArgb(220, 229, 219), Color.FromArgb(22, 66, 60), My.Resources.ltransaction_icon)
        BtnColorChange(medicineBtn, Color.FromArgb(220, 229, 219), Color.FromArgb(22, 66, 60), My.Resources.lmedicines_icon)
        BtnColorChange(prescriptionBtn, Color.FromArgb(22, 66, 60), Color.FromArgb(220, 229, 219), My.Resources.dprescription_icon)
        OpenFormInPanel(New pharmaPrescriptions())
    End Sub

    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click

    End Sub
End Class