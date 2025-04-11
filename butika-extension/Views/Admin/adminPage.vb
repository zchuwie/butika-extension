Imports Guna.UI2.AnimatorNS

Partial Public Class adminPage
    Inherits Form

    Public Sub New()
        InitializeComponent()
        ShowFormInPanel(New adminDashboard(Me))
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
        ShowFormInPanel(New adminDashboard(Me))
    End Sub

    ' Event handler for adminDashboard button click
    Private Sub adminDashboard_Click(sender As Object, e As EventArgs) Handles adminDashboard.Click
        ShowFormInPanel(New adminDashboard(Me))
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
        ShowFormInPanel(New adminDiscounts)
    End Sub

    ' Event handler for adminExit button click
    Private Sub adminExit_Click(sender As Object, e As EventArgs) Handles adminExit.Click
        Dim loginForm As New Login()
        loginForm.Show()
        Me.Close()
    End Sub

    Private Sub ToggleLabelVisibilityByName(labelName As String, visible As Boolean)
        For Each ctrl As Control In adminViewPanel.Controls
            Dim form As Form = TryCast(ctrl, Form)
            If form IsNot Nothing Then
                Dim labelControl As Control = form.Controls(labelName)
                If labelControl IsNot Nothing Then
                    labelControl.Visible = visible
                    labelControl.BringToFront()
                End If
            End If
        Next
    End Sub

    Private Sub adminDashboard_MouseEnter(sender As Object, e As EventArgs) Handles adminDashboard.MouseEnter
        ToggleLabelVisibilityByName("adminDashboardText", True)
    End Sub

    Private Sub adminDashboard_MouseLeave(sender As Object, e As EventArgs) Handles adminDashboard.MouseLeave
        ToggleLabelVisibilityByName("adminDashboardText", False)
    End Sub

    Private Sub adminUser_MouseEnter(sender As Object, e As EventArgs) Handles adminUser.MouseEnter
        ToggleLabelVisibilityByName("adminUserText", True)
    End Sub

    Private Sub adminUser_MouseLeave(sender As Object, e As EventArgs) Handles adminUser.MouseLeave
        ToggleLabelVisibilityByName("adminUserText", False)
    End Sub

    Private Sub adminLogs_MouseEnter(sender As Object, e As EventArgs) Handles adminLogs.MouseEnter
        ToggleLabelVisibilityByName("adminLogsText", True)
    End Sub

    Private Sub adminLogs_MouseLeave(sender As Object, e As EventArgs) Handles adminLogs.MouseLeave
        ToggleLabelVisibilityByName("adminLogsText", False)
    End Sub

    Private Sub adminDiscount_MouseEnter(sender As Object, e As EventArgs) Handles adminDiscount.MouseEnter
        ToggleLabelVisibilityByName("adminDiscountText", True)
    End Sub

    Private Sub adminDiscount_MouseLeave(sender As Object, e As EventArgs) Handles adminDiscount.MouseLeave
        ToggleLabelVisibilityByName("adminDiscountText", False)
    End Sub


End Class
