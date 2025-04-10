Imports System.Globalization
Imports System.Windows.Forms.DataVisualization.Charting
Imports butika.Models
Imports Guna.Charts.WinForms

Public Class adminDashboard
    Inherits Form
    Private adminPage As adminPage
    Public Sub New(adminPage As adminPage)
        InitializeComponent()
        Me.adminPage = adminPage ' Store the reference to the parent form
    End Sub

    Private currentPeriod As String = "week" ' Start with week

    Private Async Sub adminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadUserGrowthAsync(currentPeriod)
        Await LoadUserDataAsync()
        Await LoadUserActivityAsync()
        Await LoadDiscountChartAsync()
        Await LoadUserStatusChartAsync()
        Await LoadUserSummaryAsync()


        UIHelper.CenterLabelsInPanels(customerNum, activeNum, pendingNum, signupNum)
    End Sub

    Private Async Function LoadUserDataAsync() As Task
        Dim dt = Await AdminRepository.GetUserDataAsync()
        userAccTable.DataSource = dt
    End Function

    Private Async Function LoadUserActivityAsync() As Task
        Dim dt = Await AdminRepository.GetUserActivityDataAsync()
        userActTable.DataSource = dt
    End Function

    Private Async Function LoadUserSummaryAsync() As Task
        customerNum.Text = (Await AdminRepository.GetUserCountAsync()).ToString()
        activeNum.Text = (Await AdminRepository.GetActiveUserCountAsync()).ToString()
        pendingNum.Text = (Await AdminRepository.GetPendingDiscountCountAsync()).ToString()
        signupNum.Text = (Await AdminRepository.GetNewSignupCountAsync()).ToString()
    End Function

    Private Async Function LoadUserGrowthAsync(period As String) As Task
        userGrowthChart.Datasets.Clear()

        Dim dataset = Await AdminRepository.GetUserGrowthAsync(period)

        userGrowthChart.Datasets.Add(dataset)
        userGrowthChart.Update()
    End Function

    Private Async Sub growthBtn_Click(sender As Object, e As EventArgs) Handles growthBtn.Click
        Select Case currentPeriod
            Case "week"
                currentPeriod = "month"
                growthBtn.Text = "Month"
            Case "month"
                currentPeriod = "year"
                growthBtn.Text = "Year"
            Case "year"
                currentPeriod = "week"
                growthBtn.Text = "Week"
        End Select

        Await LoadUserGrowthAsync(currentPeriod)
    End Sub

    Private Async Function LoadDiscountChartAsync() As Task
        discountStatusPie.Series.Clear()

        Dim data = Await AdminRepository.GetDiscountStatusAsync()

        Dim series As New Series("Discount Status") With {
        .ChartType = SeriesChartType.Pie,
        .IsValueShownAsLabel = True
    }

        series.Points.AddXY("Verified", data.verifiedCount)
        series.Points.AddXY("Not Verified", data.notVerifiedCount)

        discountStatusPie.Series.Add(series)
        discountStatusPie.Update()
    End Function

    Private Async Function LoadUserStatusChartAsync() As Task
        userStatusPie.Series.Clear()

        ' Fetch active/inactive user status data asynchronously
        Dim data = Await AdminRepository.GetActiveInactiveUserStatusAsync()

        ' Create a new series for the user status pie chart
        Dim series As New Series("User Status") With {
        .ChartType = SeriesChartType.Pie,
        .IsValueShownAsLabel = True
    }

        ' Add data points for active and inactive users
        series.Points.AddXY("Active", data.activeCount)
        series.Points.AddXY("Inactive", data.inactiveCount)

        ' Add the series to the pie chart and update
        userStatusPie.Series.Add(series)
        userStatusPie.Update()
    End Function


    Public Sub ShowFormInPanel(form As Form)
        adminPage.ShowFormInPanel(form) ' Call the ShowFormInPanel method from AdminPage
    End Sub

    ' Event handler for alluserShow button click
    Private Sub alluserShow_Click(sender As Object, e As EventArgs) Handles alluserShow.Click
        ShowFormInPanel(New adminUser()) ' Replace with your form for showing all users
    End Sub

    ' Event handler for activeShow button click
    Private Sub activeShow_Click(sender As Object, e As EventArgs) Handles activeShow.Click
        ShowFormInPanel(New adminUser()) ' Replace with your form for showing active users
    End Sub

    ' Event handler for discountShow button click
    Private Sub discountShow_Click(sender As Object, e As EventArgs) Handles discountShow.Click
        ShowFormInPanel(New adminDiscount()) ' Replace with your form for showing discounted users
    End Sub

    ' Event handler for signupShow button click
    Private Sub signupShow_Click(sender As Object, e As EventArgs) Handles signupShow.Click
        ShowFormInPanel(New adminLogs()) ' Replace with your form for showing signup data
    End Sub


End Class