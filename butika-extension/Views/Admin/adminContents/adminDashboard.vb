Imports System.Globalization
Imports System.Windows.Forms.DataVisualization.Charting
Imports butika.Models
Imports Guna.Charts.WinForms

Public Class adminDashboard
    Private currentPeriod As String = "week" ' Start with week

    Public Sub UpdateLabels()
        ' Create an instance of adminMockData to get the mock user accounts
        Dim mockData As New adminMockData()
        Dim users As List(Of Account) = mockData.GetMockAccounts()

        ' Count total users
        customerNum.Text = users.Count.ToString()

        ' Count active users
        Dim activeUsers = users.Where(Function(u) u.Status = "Active").Count()
        activeNum.Text = activeUsers.ToString()

        ' Count inactive users (pending)
        Dim inactiveUsers = users.Where(Function(u) u.Status = "Inactive").Count()
        pendingNum.Text = inactiveUsers.ToString()

        ' Count users who joined this year
        Dim thisYear = DateTime.Now.Year
        Dim usersThisYear = users.Where(Function(u) DateTime.Parse(u.DateJoined).Year = thisYear).Count()
        signupNum.Text = usersThisYear.ToString()
    End Sub

    Public Sub UpdateDataGridView()
        ' Create an instance of adminMockData to get the mock user accounts
        Dim mockData As New adminMockData()
        Dim users As List(Of Account) = mockData.GetMockAccounts()

        ' Bind the first 5 users to the DataGridView
        userAccTable.DataSource = users.Take(5).Select(Function(u) New With {
                                                        u.UserID,
                                                        u.FullName,
                                                        u.Email,
                                                        u.Status
                                                    }).ToList()
    End Sub

    Public Sub UpdateUserGrowthChart()
        ' Create an instance of adminMockData to get the mock user accounts
        Dim mockData As New adminMockData()
        Dim users As List(Of Account) = mockData.GetMockAccounts()

        ' Dictionary to store grouped data
        Dim groupedData As New Dictionary(Of String, Integer)

        ' Get current date and year
        Dim currentDate As DateTime = DateTime.Now
        Dim currentYear As Integer = currentDate.Year
        Dim currentMonth As Integer = currentDate.Month
        Dim currentWeek As Integer = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(currentDate, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday)

        ' Determine grouping based on growthBtn text
        Select Case growthBtn.Text
            Case "Week"
                ' Group by current week of the current month
                For Each user In users
                    Dim dt As DateTime = DateTime.Parse(user.DateJoined)
                    ' Check if the user joined in the current year and current month
                    If dt.Year = currentYear AndAlso dt.Month = currentMonth Then
                        Dim weekKey As String = "Week " & CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(dt, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday).ToString()
                        If groupedData.ContainsKey(weekKey) Then
                            groupedData(weekKey) += 1
                        Else
                            groupedData.Add(weekKey, 1)
                        End If
                    End If
                Next

            Case "Month"
                ' Group by months in the current year
                For Each user In users
                    Dim dt As DateTime = DateTime.Parse(user.DateJoined)
                    ' Check if the user joined in the current year
                    If dt.Year = currentYear Then
                        ' Use numeric month for sorting (January = 1, February = 2, etc.)
                        Dim monthKey As String = dt.Month.ToString("D2") ' Ensures correct sorting (01 for January, 02 for February)
                        If groupedData.ContainsKey(monthKey) Then
                            groupedData(monthKey) += 1
                        Else
                            groupedData.Add(monthKey, 1)
                        End If
                    End If
                Next

            Case "Year"
                ' Group by years
                For Each user In users
                    Dim dt As DateTime = DateTime.Parse(user.DateJoined)
                    Dim yearKey As String = dt.Year.ToString()
                    If groupedData.ContainsKey(yearKey) Then
                        groupedData(yearKey) += 1
                    Else
                        groupedData.Add(yearKey, 1)
                    End If
                Next
        End Select

        ' Clear existing chart data
        userGrowthChart.Datasets.Clear()

        ' Create a new dataset for the chart (Line chart for User Growth)
        Dim dataset As New Guna.Charts.WinForms.GunaLineDataset()
        dataset.Label = "User Growth"

        ' Define an array to map month numbers to month names
        Dim monthNames As String() = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}

        ' Sort the grouped data by the key (month/year/weekday)
        Dim sortedGroupedData As IOrderedEnumerable(Of KeyValuePair(Of String, Integer)) = groupedData.OrderBy(Function(kvp) kvp.Key)

        ' Add new data to the dataset
        For Each entry In sortedGroupedData
            Dim label As String = ""
            If growthBtn.Text = "Month" Then
                ' Convert numeric month to month name
                Dim monthIndex As Integer = Integer.Parse(entry.Key) - 1 ' Convert "01" to index 0
                label = monthNames(monthIndex)
            ElseIf growthBtn.Text = "Year" OrElse growthBtn.Text = "Week" Then
                label = entry.Key
            End If
            dataset.DataPoints.Add(label, entry.Value)
        Next

        ' Add dataset to the chart
        userGrowthChart.Datasets.Add(dataset)

        ' Refresh the chart
        userGrowthChart.Update()
    End Sub

    Private Sub adminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserData()
        LoadUserActivity()
        LoadDiscountChart()
        customerNum.Text = adminData.GetUserCount().ToString()
        activeNum.Text = adminData.GetActiveUserCount().ToString()
        pendingNum.Text = adminData.GetPendingDiscountCount().ToString()
        signupNum.Text = adminData.GetNewSignupCount().ToString()
        UIHelper.CenterLabelsInPanels(customerNum, activeNum, pendingNum, signupNum)

        ' Update all elements on form load
        UpdateDataGridView() ' Updates user growth chart
        UpdateLabels() ' Updates labels
        UpdateUserGrowthChart() ' Updates DataGridView
    End Sub

    Private Sub LoadUserData()
        userAccTable.DataSource = adminData.GetUserData() ' Bind data to Guna2DataGridView
    End Sub

    Private Sub LoadUserActivity()
        userActTable.DataSource = adminData.GetUserActivityData() ' Bind data to Guna2DataGridView
    End Sub

    Private Sub LoadUserGrowth(period As String)
        ' Clear existing datasets
        userGrowthChart.Datasets.Clear()

        ' Get dataset from adminData class
        Dim dataset As GunaLineDataset = adminData.GetUserGrowth(period)

        ' Add dataset to chart
        userGrowthChart.Datasets.Add(dataset)
        userGrowthChart.Update()
    End Sub

    Private Sub growthBtn_Click(sender As Object, e As EventArgs) Handles growthBtn.Click
        'cycle through week → month → year → back to week

        'Select Case currentPeriod
        '    Case "week"
        '        currentPeriod = "month"
        '        growthBtn.Text = "month"
        '    Case "month"
        '        currentPeriod = "year"
        '        growthBtn.Text = "year"
        '    Case "year"
        '        currentPeriod = "week"
        '        growthBtn.Text = "week"
        'End Select

        ' load the chart with the selected period
        LoadUserGrowth(currentPeriod)

        Select Case growthBtn.Text
            Case "Week"
                growthBtn.Text = "Month"
            Case "Month"
                growthBtn.Text = "Year"
            Case "Year"
                growthBtn.Text = "Week"
        End Select
        UpdateUserGrowthChart()
    End Sub

    Private Sub LoadDiscountChart()
        ' Clear any previous data in the pie chart
        discountStatusPie.Series.Clear()

        ' Fetch the discount status data from adminData
        Dim data = adminData.GetDiscountStatus()

        ' Add a new series for the pie chart
        Dim series As New Series("Discount Status")
        series.ChartType = SeriesChartType.Pie  ' Set chart type to Pie
        series.IsValueShownAsLabel = True      ' Show values on the pie slices
        series.Label = "#PERCENT"              ' Show percentage on each slice

        ' Add data points to the series
        series.Points.AddXY("Verified Users", data.verifiedCount)
        series.Points.AddXY("Not Verified Users", data.notVerifiedCount)

        ' Add the series to the chart
        discountStatusPie.Series.Add(series)

        ' Refresh the chart to display the changes
        discountStatusPie.Update()
    End Sub

    Private Sub alluserShow_Click(sender As Object, e As EventArgs) Handles alluserShow.Click

    End Sub

    Private Sub activeShow_Click(sender As Object, e As EventArgs) Handles activeShow.Click

    End Sub

    Private Sub discountShow_Click(sender As Object, e As EventArgs) Handles discountShow.Click

    End Sub

    Private Sub signupShow_Click(sender As Object, e As EventArgs)

    End Sub


End Class