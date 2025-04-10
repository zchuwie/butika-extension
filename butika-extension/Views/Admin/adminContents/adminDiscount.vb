Imports System.Xml
Imports butika.Configurations
Imports Org.BouncyCastle.Crypto

Public Class adminDiscounts
    Private Async Sub adminDiscount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadUserDataAsync()
    End Sub

    Private Async Function LoadUserDataAsync() As Task
        Dim dt = Await AdminRepository.GetCustomerUserFullData()

        discountTable.DataSource = dt
    End Function

    Private Sub discountTable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles discountTable.CellClick
        If e.RowIndex >= 0 Then

            Dim selectedRow As DataGridViewRow = discountTable.Rows(e.RowIndex)
            Dim fullName As String = If(selectedRow.Cells("Fullname").Value IsNot DBNull.Value, selectedRow.Cells("Fullname").Value.ToString(), "N/A")
            Dim birthDate As DateTime
            Dim selectedId As Integer = Convert.ToInt32(selectedRow.Cells("ID").Value)
            Dim isVerified As Object = selectedRow.Cells("IsVerified").Value

            If selectedRow.Cells("Birth_Date").Value IsNot DBNull.Value Then
                birthDate = Convert.ToDateTime(selectedRow.Cells("Birth_Date").Value)
            Else
                birthDate = DateTime.MinValue
            End If

            id.Text = selectedId.ToString()
            namedata.Text = fullName

            If birthDate <> DateTime.MinValue Then
                Dim userage As Integer = CalculateAge(birthDate)
                age.Text = userage.ToString()
            Else
                age.Text = "N/A"
            End If

            If isVerified Is DBNull.Value OrElse isVerified Is Nothing Then
                statusBtn.Text = "Unknown"
                statusBtn.FillColor = ColorTranslator.FromHtml("#666666")
                statusBtn.Enabled = False
            Else
                If Convert.ToBoolean(isVerified) Then
                    statusBtn.Text = "Verified"
                    statusBtn.FillColor = ColorTranslator.FromHtml("#6B9C89")
                    statusBtn.Enabled = True
                Else
                    statusBtn.Text = "Not Verified"
                    statusBtn.FillColor = ColorTranslator.FromHtml("#E44040")
                    statusBtn.Enabled = True
                End If
            End If
        End If
    End Sub


    Private Function CalculateAge(birthDate As DateTime) As Integer
        Dim today As DateTime = DateTime.Now
        Dim userage As Integer = today.Year - birthDate.Year

        If today.Month < birthDate.Month OrElse (today.Month = birthDate.Month AndAlso today.Day < birthDate.Day) Then
            userage -= 1
        End If

        Return userage
    End Function

    Private Async Sub showAllBtn_Click(sender As Object, e As EventArgs) Handles allBtn.Click
        Dim dt = Await AdminRepository.GetCustomerUserFullData()

        If dt.Rows.Count > 0 Then
            discountTable.DataSource = dt
        Else
            MessageBox.Show("No data found.")
        End If
    End Sub

    Private Async Sub showVerifiedBtn_Click(sender As Object, e As EventArgs) Handles verifiedBtn.Click
        Dim dt = Await AdminRepository.GetCustomerUserFullData(True)
        discountTable.DataSource = dt
    End Sub

    Private Async Sub showNotVerifiedBtn_Click(sender As Object, e As EventArgs) Handles NotverifiedBtn.Click

        Dim dt = Await AdminRepository.GetCustomerUserFullData(False)
        discountTable.DataSource = dt
    End Sub

    Private Async Sub statusBtn_Click(sender As Object, e As EventArgs) Handles statusBtn.Click

        Dim userId As Integer = Convert.ToInt32(id.Text)

        Dim currentStatus As Boolean = Await AdminRepository.GetUserVerificationStatusAsync(userId)

        Dim newStatus As Boolean = Not currentStatus

        Await AdminRepository.UpdateUserVerificationStatusAsync(userId, newStatus)

        If newStatus Then
            statusBtn.Text = "Verified"
            statusBtn.FillColor = ColorTranslator.FromHtml("#6B9C89")
        Else
            statusBtn.Text = "Not Verified"
            statusBtn.FillColor = ColorTranslator.FromHtml("#E44040")
        End If

        Await ReloadCustomerDataAsync()
    End Sub

    Private Async Function ReloadCustomerDataAsync() As Task

        Dim dt = Await AdminRepository.GetCustomerUserFullData()
        discountTable.DataSource = dt
    End Function


End Class