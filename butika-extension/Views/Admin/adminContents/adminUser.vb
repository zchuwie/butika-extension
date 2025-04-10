Public Class adminUser


    ' Timer event to hide the indicators
    Private Sub copyTimer_Tick(sender As Object, e As EventArgs) Handles copyTimer.Tick
        ' Hide the text copy indicators after 1 second
        textCopyIndicator.Visible = False
        textCopyIndicator2.Visible = False

        ' Stop the timer
        copyTimer.Stop()
    End Sub

    Private Sub accountIdTxt_Click(sender As Object, e As EventArgs) Handles accountIdTxt.Click
        ' Copy the Account ID text to clipboard
        Clipboard.SetText(accountIdTxt.Text)

        ' Show the text copy indicator for Account ID
        textCopyIndicator.Visible = True

        ' Set a timer to hide the indicator after 1 second (1000 milliseconds)
        copyTimer.Interval = 1000  ' 1 second
        copyTimer.Start()
    End Sub

    Private Sub usernameTxt_Click(sender As Object, e As EventArgs) Handles usernameTxt.Click
        ' Copy the Username text to clipboard
        Clipboard.SetText(usernameTxt.Text)

        ' Show the text copy indicator for Username
        textCopyIndicator2.Visible = True

        ' Set a timer to hide the indicator after 1 second (1000 milliseconds)
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


            ' Set the account ID in the text field
            accountIdTxt.Text = selectedId.ToString()

            ' Fetch the full details of the user by ID
            Dim userDetails As DataRow = Await AdminRepository.GetUserDetailsById(selectedId)
            If userDetails IsNot Nothing Then
                ' Populate the textboxes or labels with the data
                usernameTxt.Text = userDetails("username").ToString()

                ' Check for DBNull before converting to DateTime
                If userDetails("date_joined") IsNot DBNull.Value Then
                    data1.Text = Convert.ToDateTime(userDetails("date_joined")).ToString("yyyy-MM-dd")
                Else
                    data1.Text = "N/A" ' Default value for missing date
                End If

                ' Check for DBNull before assigning full name
                If userDetails("fullname") IsNot DBNull.Value Then
                    data2.Text = userDetails("fullname").ToString()
                Else
                    data2.Text = "N/A" ' Default value for missing full name
                End If

                ' Check for DBNull before assigning first name
                If userDetails("first_name") IsNot DBNull.Value Then
                    data3.Text = userDetails("first_name").ToString()
                Else
                    data3.Text = "N/A" ' Default value for missing first name
                End If

                ' Check for DBNull before assigning middle initial
                If userDetails("middle_initial") IsNot DBNull.Value Then
                    data4.Text = userDetails("middle_initial").ToString()
                Else
                    data4.Text = "N/A" ' Default value for missing middle initial
                End If

                ' Check for DBNull before assigning last name
                If userDetails("last_name") IsNot DBNull.Value Then
                    data5.Text = userDetails("last_name").ToString()
                Else
                    data5.Text = "N/A" ' Default value for missing last name
                End If

                ' Check for DBNull before converting to DateTime
                If userDetails("birthdate") IsNot DBNull.Value Then
                    data6.Text = Convert.ToDateTime(userDetails("birthdate")).ToString("yyyy-MM-dd")
                Else
                    data6.Text = "N/A" ' Default value for missing birthdate
                End If

                ' Check for DBNull before assigning Address and Mobile Number
                If selectedRow.Cells("Email").Value IsNot DBNull.Value Then
                    AddressText.Text = selectedRow.Cells("Email").Value.ToString()
                Else
                    AddressText.Text = "N/A" ' Default value for missing email/address
                End If

                If selectedRow.Cells("Contact").Value IsNot DBNull.Value Then
                    NumberText.Text = selectedRow.Cells("Contact").Value.ToString()
                Else
                    NumberText.Text = "N/A" ' Default value for missing mobile number
                End If

                If userDetails IsNot Nothing Then
                    ' Populate the textboxes or labels with the data
                    usernameTxt.Text = userDetails("username").ToString()

                    ' Check for DBNull or Nothing in 'status' column and set default value
                    Dim status As String = If(userDetails("status") Is DBNull.Value, "-", userDetails("status").ToString())

                    ' Set the statusBtn text
                    statusBtn.Text = status

                    ' Set FillColor and disable the button if status is "-"
                    If status = "-" Then
                        statusBtn.FillColor = ColorTranslator.FromHtml("#666666") ' Gray color
                        statusBtn.Enabled = False ' Disable the button if status is "-"
                    ElseIf status.ToLower() = "active" Then
                        statusBtn.FillColor = ColorTranslator.FromHtml("#6B9C89") ' Active color
                        statusBtn.Enabled = True ' Enable the button if status is active
                    Else
                        statusBtn.FillColor = ColorTranslator.FromHtml("#E44040") ' Inactive color
                        statusBtn.Enabled = True ' Enable the button if status is inactive
                    End If
                End If

            End If
        End If


    End Sub

    Private Async Sub statusBtn_Click(sender As Object, e As EventArgs) Handles statusBtn.Click
        If statusBtn.Text = "-" Then
            ' If statusBtn.Text is "-", prevent any status change
            MessageBox.Show("Cannot update status as it's not available.")
            Return
        End If

        ' Toggle the status based on current statusBtn.Text
        Dim newStatus As String
        Dim newColor As String

        If statusBtn.Text.ToLower() = "active" Then
            newStatus = "inactive"
            newColor = "#E44040" ' Inactive color
        Else
            newStatus = "active"
            newColor = "#6B9C89" ' Active color
        End If

        ' Update the status in the database for the selected user
        Dim userId As Integer = Convert.ToInt32(accountIdTxt.Text) ' Use the account ID from accountIdTxt.Text
        Await AdminRepository.UpdateUserStatus(userId, newStatus)

        ' Update the statusBtn's text and color
        statusBtn.Text = newStatus
        statusBtn.FillColor = ColorTranslator.FromHtml(newColor)

        ' Reload the userAccTable to show the updated status
        Await LoadAllUsers() ' This will reload the entire table with updated data
        Await LoadUserSummaryAsync()
    End Sub


    Private Async Function LoadAllUsers() As Task
        ' Fetch and reload the data into the userAccTable
        Dim dt = Await AdminRepository.GetUserFullData() ' Make sure this function fetches the latest data
        userAccTable.DataSource = dt
    End Function

    Private Async Sub searchBtn_Click(sender As Object, e As EventArgs)

    End Sub

    Private Async Sub searchText_TextChanged(sender As Object, e As EventArgs) Handles searchText.TextChanged
        ' Get the search text entered by the user
        Dim searchTerm As String = searchText.Text.Trim()

        ' Check if searchTerm is not empty
        If Not String.IsNullOrEmpty(searchTerm) Then
            ' Assuming you have a DataTable as the DataSource of userAccTable
            Dim dt As DataTable = CType(userAccTable.DataSource, DataTable)

            ' Create a DataView for filtering
            Dim dv As New DataView(dt)

            ' Check if the search term can be parsed to an integer (for ID column)
            Dim isNumeric As Boolean = Integer.TryParse(searchTerm, New Integer())

            If isNumeric Then
                ' If searchTerm is numeric, filter by ID
                dv.RowFilter = String.Format("ID = {0} OR Username LIKE '%{1}%' OR Email LIKE '%{1}%' OR Status LIKE '%{1}%'", searchTerm, searchTerm)
            Else
                ' If searchTerm is not numeric, filter by Username, FullName, Email, and Status
                dv.RowFilter = String.Format("Username LIKE '%{0}%' OR Email LIKE '%{0}%' OR Status LIKE '%{0}%'", searchTerm)
            End If

            ' Set the filtered data as the new DataSource, using the DataView's Table property
            userAccTable.DataSource = dv.ToTable()
        Else
            ' If searchTerm is empty, reload all data
            Dim dt As DataTable = Await AdminRepository.GetUserFullData() ' Assuming this fetches the full data
            userAccTable.DataSource = dt
        End If
    End Sub

    Private Sub AddressText_TextChanged(sender As Object, e As EventArgs) Handles AddressText.TextChanged

    End Sub

    Private Sub NumberText_TextChanged(sender As Object, e As EventArgs) Handles NumberText.TextChanged

    End Sub

    Private Async Sub AddressText_KeyDown(sender As Object, e As KeyEventArgs) Handles AddressText.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Update the database when Enter is pressed
            UpdateUserDetails()

            Await LoadAllUsers()
        End If
    End Sub

    Private Async Sub NumberText_KeyDown(sender As Object, e As KeyEventArgs) Handles NumberText.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Update the database when Enter is pressed
            UpdateUserDetails()

            Await LoadAllUsers()
        End If
    End Sub

    Private Async Sub UpdateUserDetails()
        ' Retrieve the current ID from accountIdTxt (assuming this is the identifier for the user)
        Dim userId As Integer = Convert.ToInt32(accountIdTxt.Text)

        ' Retrieve the updated values from the text boxes
        Dim updatedEmail As String = AddressText.Text
        Dim updatedPhone As String = NumberText.Text

        ' Call a method in the AdminRepository to update the database with the new values
        Await AdminRepository.UpdateUserDetails(userId, updatedEmail, updatedPhone)
    End Sub
End Class