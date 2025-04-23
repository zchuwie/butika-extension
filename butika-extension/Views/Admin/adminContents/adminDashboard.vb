Imports System.Globalization
Imports System.Windows.Forms.DataVisualization.Charting
Imports butika.Models
Imports Guna.Charts.WinForms

Public Class adminDashboard
    Inherits Form
    Private adminPage As adminPage
    Public Sub New(adminPage As adminPage)
        InitializeComponent()
        Me.adminPage = adminPage
    End Sub

    Private currentPeriod As String = "week"

    Private Async Sub adminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadUserGrowthAsync(currentPeriod)
        Await LoadUserDataAsync()
        Await LoadUserActivityAsync()
        Await LoadDiscountChartAsync()
        Await LoadStockRequestStatusChartAsync()
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

    Private Async Function LoadStockRequestStatusChartAsync() As Task
        stockRequestStatusPie.Series.Clear()

        ' Fetch stock request status counts
        Dim data = Await AdminRepository.GetStockRequestStatusCountAsync()

        ' Create a new series for the Pie chart
        Dim series As New Series("Stock Request Status") With {
        .ChartType = SeriesChartType.Pie,
        .IsValueShownAsLabel = True
    }

        ' Add points based on the query result
        series.Points.AddXY("Pending", data.pendingCount)
        series.Points.AddXY("Approved", data.approvedCount)
        series.Points.AddXY("Declined", data.declinedCount)

        ' Add the series to the chart and update it
        stockRequestStatusPie.Series.Add(series)
        stockRequestStatusPie.Update()
    End Function

    Public Sub ShowFormInPanel(form As Form)
        adminPage.ShowFormInPanel(form)
    End Sub

    Private Sub alluserShow_Click(sender As Object, e As EventArgs) Handles alluserShow.Click
        ShowFormInPanel(New adminUser())
    End Sub

    Private Sub activeShow_Click(sender As Object, e As EventArgs) Handles activeShow.Click
        ShowFormInPanel(New adminStock())
    End Sub

    Private Sub discountShow_Click(sender As Object, e As EventArgs) Handles discountShow.Click
        ShowFormInPanel(New adminDiscounts())
    End Sub

    Private Sub signupShow_Click(sender As Object, e As EventArgs) Handles signupShow.Click
        ShowFormInPanel(New adminLogs())
    End Sub

End Class