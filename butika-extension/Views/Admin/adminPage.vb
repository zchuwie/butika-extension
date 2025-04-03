Partial Public Class adminPage
    Inherits Form

    Public Sub New()
        InitializeComponent()
        ShowFormInPanel(New adminDashboard())
    End Sub

    Public Sub ShowFormInPanel(form As Form)
        ' Clear existing controls in the panel
        adminViewPanel.Controls.Clear()

        ' Configure the new form
        form.TopLevel = False
        form.Dock = DockStyle.Fill
        adminViewPanel.Controls.Add(form)
        form.BringToFront()
        form.Show()
    End Sub

    Private Sub AdminPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowFormInPanel(New adminDashboard())
    End Sub

    ' Event handler for adminDashboard button click
    Private Sub adminDashboard_Click(sender As Object, e As EventArgs) Handles adminDashboard.Click
        ShowFormInPanel(New adminDashboard)
    End Sub

    ' Event handler for adminUser button click
    Private Sub adminUser_Click(sender As Object, e As EventArgs) Handles adminUser.Click
        ShowFormInPanel(New adminUser)
    End Sub

    ' Event handler for adminLogs button click
    Private Sub adminLogs_Click(sender As Object, e As EventArgs) Handles adminLogs.Click
        ShowFormInPanel(New adminLogs)
    End Sub

    ' Event handler for adminDiscount button click
    Private Sub adminDiscount_Click(sender As Object, e As EventArgs) Handles adminDiscount.Click
        ShowFormInPanel(New adminDiscount)
    End Sub

    ' Event handler for adminExit button click
    Private Sub adminExit_Click(sender As Object, e As EventArgs) Handles adminExit.Click
        Close()
    End Sub

    Private Sub adminSidePanel_Paint_1(sender As Object, e As PaintEventArgs)

    End Sub
End Class
