Public Class adminUser

    Private Sub copyTimer_Tick(sender As Object, e As EventArgs) Handles copyTimer.Tick
        textCopyIndicator.Visible = False
        textCopyIndicator2.Visible = False

        copyTimer.Stop()
    End Sub

    Private Sub accountIdTxt_Click(sender As Object, e As EventArgs) Handles accountIdTxt.Click
        Clipboard.SetText(accountIdTxt.Text)

        textCopyIndicator.Visible = True

        copyTimer.Interval = 1000
        copyTimer.Start()
    End Sub

    Private Sub usernameTxt_Click(sender As Object, e As EventArgs) Handles usernameTxt.Click

        Clipboard.SetText(usernameTxt.Text)

        textCopyIndicator2.Visible = True

        copyTimer.Interval = 1000  ' 1 second
        copyTimer.Start()
    End Sub

    Private Async Function LoadUserSummaryAsync() As Task
        activeNum.Text = (Await AdminRepository.GetActiveUsers()).ToString()
        inactiveNum.Text = (Await AdminRepository.GetInactiveUsers()).ToString()
    End Function

    Private Async Sub adminUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadUserSummaryAsync()
        Await LoadAllUserDataAsync()

        UIHelper.CenterLabelsInPanels(activeNum, inactiveNum)
    End Sub

    Private Async Function LoadAllUserDataAsync() As Task
        Dim dt = Await AdminRepository.GetUserFullData()
        userAccTable.DataSource = dt
    End Function

    Private Async Function LoadAllActiveUsers() As Task
        Dim dt = Await AdminRepository.GetUserFullData("active")
        userAccTable.DataSource = dt
    End Function

    Private Async Function LoadAllInactiveUsers() As Task
        Dim dt = Await AdminRepository.GetUserFullData("inactive")
        userAccTable.DataSource = dt
    End Function

    Private Async Sub activeShow_Click(sender As Object, e As EventArgs) Handles activeShow.Click
        Await LoadAllActiveUsers()
    End Sub

    Private Async Sub inactiveShow_Click(sender As Object, e As EventArgs) Handles inactiveShow.Click
        Await LoadAllInactiveUsers()
    End Sub

    Private Async Sub showAllBtn_Click(sender As Object, e As EventArgs) Handles showAllBtn.Click
        Await LoadAllUserDataAsync()
    End Sub

    Private Async Sub userAccTable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles userAccTable.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = userAccTable.Rows(e.RowIndex)
            Dim selectedId As Integer = Convert.ToInt32(selectedRow.Cells("ID").Value)

            accountIdTxt.Text = selectedId.ToString()

            Dim userDetails As DataRow = Await AdminRepository.GetUserDetailsById(selectedId)
            If userDetails IsNot Nothing Then

                usernameTxt.Text = userDetails("username").ToString()

                If userDetails("date_joined") IsNot DBNull.Value Then
                    data1.Text = Convert.ToDateTime(userDetails("date_joined")).ToString("yyyy-MM-dd")
                Else
                    data1.Text = "N/A"
                End If

                If userDetails("fullname") IsNot DBNull.Value Then
                    data2.Text = userDetails("fullname").ToString()
                Else
                    data2.Text = "N/A"
                End If

                If userDetails("first_name") IsNot DBNull.Value Then
                    data3.Text = userDetails("first_name").ToString()
                Else
                    data3.Text = "N/A"
                End If

                If userDetails("middle_initial") IsNot DBNull.Value Then
                    data4.Text = userDetails("middle_initial").ToString()
                Else
                    data4.Text = "N/A"
                End If

                If userDetails("last_name") IsNot DBNull.Value Then
                    data5.Text = userDetails("last_name").ToString()
                Else
                    data5.Text = "N/A"
                End If

                If userDetails("birthdate") IsNot DBNull.Value Then
                    data6.Text = Convert.ToDateTime(userDetails("birthdate")).ToString("yyyy-MM-dd")
                Else
                    data6.Text = "N/A"
                End If

                If selectedRow.Cells("Email").Value IsNot DBNull.Value Then
                    AddressText.Text = selectedRow.Cells("Email").Value.ToString()
                Else
                    AddressText.Text = "N/A"
                End If

                If selectedRow.Cells("Contact").Value IsNot DBNull.Value Then
                    NumberText.Text = selectedRow.Cells("Contact").Value.ToString()
                Else
                    NumberText.Text = "N/A"
                End If

                If userDetails IsNot Nothing Then

                    usernameTxt.Text = userDetails("username").ToString()

                    Dim status As String = If(userDetails("status") Is DBNull.Value, "-", userDetails("status").ToString())

                    statusBtn.Text = status

                    If status = "-" Then
                        statusBtn.FillColor = ColorTranslator.FromHtml("#666666")
                        statusBtn.Enabled = False
                    ElseIf status.ToLower() = "active" Then
                        statusBtn.FillColor = ColorTranslator.FromHtml("#6B9C89")
                        statusBtn.Enabled = True
                    Else
                        statusBtn.FillColor = ColorTranslator.FromHtml("#E44040")
                        statusBtn.Enabled = True
                    End If
                End If

            End If
        End If


    End Sub

    Private Async Sub statusBtn_Click(sender As Object, e As EventArgs) Handles statusBtn.Click
        If statusBtn.Text = "-" Then
            MessageBox.Show("Cannot update status as it's not available.")
            Return
        End If

        Dim newStatus As String
        Dim newColor As String

        If statusBtn.Text.ToLower() = "active" Then
            newStatus = "inactive"
            newColor = "#E44040"
        Else
            newStatus = "active"
            newColor = "#6B9C89"
        End If

        Dim userId As Integer = Convert.ToInt32(accountIdTxt.Text)
        Await AdminRepository.UpdateUserStatus(userId, newStatus)

        statusBtn.Text = newStatus
        statusBtn.FillColor = ColorTranslator.FromHtml(newColor)

        Await LoadAllUsers()
        Await LoadUserSummaryAsync()
    End Sub


    Private Async Function LoadAllUsers() As Task
        Dim dt = Await AdminRepository.GetUserFullData()
        userAccTable.DataSource = dt
    End Function

    Private Async Sub searchBtn_Click(sender As Object, e As EventArgs)

    End Sub

    Private Async Sub searchText_TextChanged(sender As Object, e As EventArgs) Handles searchText.TextChanged
        Dim searchTerm As String = searchText.Text.Trim()

        If Not String.IsNullOrEmpty(searchTerm) Then
            Dim dt As DataTable = CType(userAccTable.DataSource, DataTable)

            Dim dv As New DataView(dt)

            Dim isNumeric As Boolean = Integer.TryParse(searchTerm, New Integer())

            If isNumeric Then
                dv.RowFilter = String.Format("ID = {0} OR Username LIKE '%{1}%' OR Email LIKE '%{1}%' OR Status LIKE '%{1}%'", searchTerm, searchTerm)
            Else
                dv.RowFilter = String.Format("Username LIKE '%{0}%' OR Email LIKE '%{0}%' OR Status LIKE '%{0}%'", searchTerm)
            End If

            userAccTable.DataSource = dv.ToTable()
        Else
            Dim dt As DataTable = Await AdminRepository.GetUserFullData()
            userAccTable.DataSource = dt
        End If
    End Sub

    Private Sub AddressText_TextChanged(sender As Object, e As EventArgs) Handles AddressText.TextChanged

    End Sub

    Private Sub NumberText_TextChanged(sender As Object, e As EventArgs) Handles NumberText.TextChanged

    End Sub

    Private Async Sub AddressText_KeyDown(sender As Object, e As KeyEventArgs) Handles AddressText.KeyDown
        If e.KeyCode = Keys.Enter Then

            UpdateUserDetails()

            Await LoadAllUsers()
        End If
    End Sub

    Private Async Sub NumberText_KeyDown(sender As Object, e As KeyEventArgs) Handles NumberText.KeyDown
        If e.KeyCode = Keys.Enter Then

            UpdateUserDetails()

            Await LoadAllUsers()
        End If
    End Sub

    Private Async Sub UpdateUserDetails()

        Dim userId As Integer = Convert.ToInt32(accountIdTxt.Text)

        Dim updatedEmail As String = AddressText.Text
        Dim updatedPhone As String = NumberText.Text

        Await AdminRepository.UpdateUserDetails(userId, updatedEmail, updatedPhone)
    End Sub
End Class