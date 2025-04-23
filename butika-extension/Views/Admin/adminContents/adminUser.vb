Imports butika.Helpers

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
        customerNum.Text = (Await AdminRepository.GetCustomerCount()).ToString()
        adminNum.Text = (Await AdminRepository.GetAdminCount()).ToString()
        pharmacistNum.Text = (Await AdminRepository.GetPharmacistCount()).ToString()
        custodianNum.Text = (Await AdminRepository.GetCustodianCount()).ToString()
    End Function

    Private Async Sub adminUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadUserSummaryAsync()
        Await LoadAllUserDataAsync()

        UIHelper.CenterLabelsInPanels(customerNum, adminNum, pharmacistNum, custodianNum)
    End Sub

    Private Async Function LoadAllUserDataAsync() As Task
        Dim dt = Await AdminRepository.GetUserFullData()
        userAccTable.DataSource = dt
    End Function

    Private Async Function LoadUserType(num As Integer) As Task
        Dim dt = Await AdminRepository.GetUserFullData(num)
        userAccTable.DataSource = dt
    End Function

    Private Async Sub customerShow_Click(sender As Object, e As EventArgs) Handles customerShow.Click
        Await LoadUserType(0)
    End Sub

    Private Async Sub adminShow_Click(sender As Object, e As EventArgs) Handles adminShow.Click
        Await LoadUserType(1)
    End Sub

    Private Async Sub pharmacistShow_Click(sender As Object, e As EventArgs) Handles pharmacistShow.Click
        Await LoadUserType(2)
    End Sub

    Private Async Sub custodianShow_Click(sender As Object, e As EventArgs) Handles custodianShow.Click
        Await LoadUserType(3)
    End Sub

    Private Async Sub showAllBtn_Click(sender As Object, e As EventArgs) Handles showAllBtn.Click
        Await LoadAllUserDataAsync()
    End Sub

    Private Async Sub userAccTable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles userAccTable.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow = userAccTable.Rows(e.RowIndex)
            Dim selectedId = Convert.ToInt32(selectedRow.Cells("ID").Value)

            accountIdTxt.Text = selectedId.ToString

            Dim userDetails = Await AdminRepository.GetUserDetailsById(selectedId)
            If userDetails IsNot Nothing Then

                usernameTxt.Text = userDetails("username").ToString

                If userDetails("date_joined") IsNot DBNull.Value Then
                    data1.Text = Convert.ToDateTime(userDetails("date_joined")).ToString("yyyy-MM-dd")
                Else
                    data1.Text = "N/A"
                End If

                If userDetails("fullname") IsNot DBNull.Value Then
                    data2.Text = userDetails("fullname").ToString
                Else
                    data2.Text = "N/A"
                End If

                If userDetails("first_name") IsNot DBNull.Value Then
                    data3.Text = userDetails("first_name").ToString
                Else
                    data3.Text = "N/A"
                End If

                If userDetails("middle_initial") IsNot DBNull.Value Then
                    data4.Text = userDetails("middle_initial").ToString
                Else
                    data4.Text = "N/A"
                End If

                If userDetails("last_name") IsNot DBNull.Value Then
                    data5.Text = userDetails("last_name").ToString
                Else
                    data5.Text = "N/A"
                End If

                If userDetails("birthdate") IsNot DBNull.Value Then
                    data6.Text = Convert.ToDateTime(userDetails("birthdate")).ToString("yyyy-MM-dd")
                Else
                    data6.Text = "N/A"
                End If

                If selectedRow.Cells("Email").Value IsNot DBNull.Value Then
                    AddressText.Text = selectedRow.Cells("Email").Value.ToString
                Else
                    AddressText.Text = "N/A"
                End If

                If selectedRow.Cells("Contact").Value IsNot DBNull.Value Then
                    NumberText.Text = selectedRow.Cells("Contact").Value.ToString
                Else
                    NumberText.Text = "N/A"
                End If
            End If
        End If
    End Sub

    Private Async Function LoadAllUsers() As Task
        Dim dt = Await AdminRepository.GetUserFullData()
        userAccTable.DataSource = dt
    End Function

    Private Async Sub searchText_TextChanged(sender As Object, e As EventArgs) Handles searchText.TextChanged
        Await resetLabel("-")
        AddressText.Text = ""
        NumberText.Text = ""

        Dim searchTerm As String = searchText.Text.Trim()
        If searchText.Text <> "Search" Then
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
        Else
        End If
    End Sub

    Private Async Function resetLabel(labelChange As String) As Task
        accountIdTxt.Text = labelChange
        usernameTxt.Text = labelChange
        data1.Text = labelChange
        data2.Text = labelChange
        data3.Text = labelChange
        data4.Text = labelChange
        data5.Text = labelChange
        data6.Text = labelChange
    End Function

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

    Private Sub searchText_Enter(sender As Object, e As EventArgs) Handles searchText.Enter
        searchText.Text = ""
    End Sub

    Private Sub searchText_Leave(sender As Object, e As EventArgs) Handles searchText.Leave
        searchText.Text = "Search"
    End Sub

    Private Async Function userTypeIndicator(type As String) As Task
        Dim dt = Await AdminRepository.GetUserFullData(type)
        userAccTable.DataSource = dt
    End Function

    Private Async Function loadCreate() As Task


        Await AdminRepository.AddNewAccount(9, 6, "green")
    End Function

    Dim createType As String
    Dim createUserType As Integer

    Private Sub adminAdd_Click(sender As Object, e As EventArgs) Handles adminAdd.Click
        createType = "admin"
        createLabel.Text = "Create " & createType & " account"
        createUserType = 1
        createPanel.Visible = True
    End Sub

    Private Sub pharmacistAdd_Click(sender As Object, e As EventArgs) Handles pharmacistAdd.Click
        createType = "pharmacist"
        createLabel.Text = "Create " & createType & " account"
        createUserType = 2
        createPanel.Visible = True
    End Sub

    Private Sub custodianAdd_Click(sender As Object, e As EventArgs) Handles custodianAdd.Click
        createType = "custodian"
        createLabel.Text = "Create " & createType & " account"
        createUserType = 3
        createPanel.Visible = True
    End Sub

    Private Async Sub createAccount_Click(sender As Object, e As EventArgs) Handles createAccount.Click
        Dim accountRepo As New AccountRepository()

        Dim username As String = createUsername.Text
        Dim password As String = createPassword.Text

        If String.IsNullOrWhiteSpace(username) Or String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Username and Password cannot be empty.", "Validation Error")
            Return
        End If

        Dim hash As New PasswordHashing(password)

        Dim isUsernameExists As Boolean = Await accountRepo.CheckDuplicate(username)

        If isUsernameExists Then
            MessageBox.Show("Username already exists.")
            Return
        End If

        Dim hashedPassword As String = hash.hashCombinedDisplay

        Await AdminRepository.AddNewAccount(username, createUserType, hashedPassword)

        Dim uTyp As String
        Select Case createUserType
            Case 1
                uTyp = "admin"
            Case 2
                uTyp = "pharmacist"
            Case 3
                uTyp = "inventory custodian"
            Case Else
                uTyp = "customer"
        End Select

        Dim activityMessage As String = $"created {uTyp} account"
        Await AdminRepository.AddActivityLogAsync(SessionInfo.CurrentUserID, SessionInfo.CurrentUserType, activityMessage)

        createUsername.Clear()
        createPassword.Clear()

        createPanel.Visible = False
        MessageBox.Show("Successfully created an account", "Confirmation")
    End Sub

    Private Sub cancelAccount_Click(sender As Object, e As EventArgs) Handles cancelAccount.Click
        createUsername.Clear()
        createPassword.Clear()

        createPanel.Visible = False
    End Sub

End Class