Public Class adminLogs
    Private Async Function LoadUserActivityAsync(Optional userType As Integer? = Nothing) As Task
        Dim dt = Await AdminRepository.GetAllUserActivityDataAsync()

        If userType.HasValue Then
            Dim filteredRows = dt.Select($"UserType = {userType.Value}")
            If filteredRows.Length > 0 Then
                dt = filteredRows.CopyToDataTable()
            Else
                dt = dt.Clone() ' Return an empty but structured DataTable
            End If
        End If

        userLogsTable.DataSource = dt
    End Function


    Private Async Sub adminLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadUserActivityAsync()
    End Sub

    Private Async Sub showAll_Logs_Click(sender As Object, e As EventArgs) Handles showAll_Logs.Click
        Await LoadUserActivityAsync() ' No filter
    End Sub

    Private Async Sub customer_Logs_Click(sender As Object, e As EventArgs) Handles customer_Logs.Click
        Await LoadUserActivityAsync(0) ' Example: 0 = Customer
    End Sub

    Private Async Sub admin_Logs_Click(sender As Object, e As EventArgs) Handles admin_Logs.Click
        Await LoadUserActivityAsync(1) ' Example: 1 = Admin
    End Sub

    Private Async Sub pharmacist_Logs_Click(sender As Object, e As EventArgs) Handles pharmacist_Logs.Click
        Await LoadUserActivityAsync(2) ' Example: 2 = Pharmacist
    End Sub

    Private Async Sub inventory_Logs_Click(sender As Object, e As EventArgs) Handles inventory_Logs.Click
        Await LoadUserActivityAsync(3) ' Example: 3 = Inventory
    End Sub

    Private Sub SortingBtn_Click(sender As Object, e As EventArgs) Handles SortingBtn.Click
        If userLogsTable.DataSource Is Nothing Then Exit Sub

        Dim dv As DataView = CType(userLogsTable.DataSource, DataTable).DefaultView
        dv.Sort = $"Date {(If(isAscending, "ASC", "DESC"))}"
        userLogsTable.DataSource = dv.ToTable()

        ' Toggle for next click
        isAscending = Not isAscending
    End Sub

    Private isAscending As Boolean = True

End Class