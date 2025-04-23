Imports System.Xml
Imports butika.Configurations
Imports Org.BouncyCastle.Crypto
Imports System.IO

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
            Dim Status As Object = selectedRow.Cells("Status").Value
            Dim verifiedDateValue As Object = selectedRow.Cells("Verified_Date").Value

            Dim userId As String = discountTable.Rows(e.RowIndex).Cells("ID").Value.ToString()

            ' Load image logic
            Dim repo As New AdminRepository()
            Dim relativePath As String = repo.GetVerificationImagePath(userId)

            If Not String.IsNullOrEmpty(relativePath) Then
                ' Get the base path to the "Resources" folder dynamically
                Dim resourcesPath As String = Path.Combine(Directory.GetCurrentDirectory(), "Resources")
                Dim fullPath As String = Path.Combine(resourcesPath, relativePath)

                If File.Exists(fullPath) Then
                    Dim img As Image = Image.FromFile(fullPath)

                    Dim aspectRatio As Double = img.Height / img.Width
                    Dim targetWidth As Integer = 243
                    Dim targetHeight As Integer = CInt(targetWidth * aspectRatio)

                    verificationImage.SizeMode = PictureBoxSizeMode.Zoom
                    verificationImage.Width = targetWidth
                    verificationImage.Height = targetHeight
                    verificationImage.Image = New Bitmap(img)
                    verificationImage.Visible = True

                    img.Dispose()
                Else
                    verificationImage.Image = Nothing
                    verificationImage.Visible = False
                End If
            Else
                verificationImage.Image = Nothing
                verificationImage.Visible = False
            End If

            ' Set UI labels
            id.Text = selectedId.ToString()
            namedata.Text = fullName

            If selectedRow.Cells("Birth_Date").Value IsNot DBNull.Value Then
                birthDate = Convert.ToDateTime(selectedRow.Cells("Birth_Date").Value)
            Else
                birthDate = DateTime.MinValue
            End If

            If birthDate <> DateTime.MinValue Then
                Dim userage As Integer = CalculateAge(birthDate)
                age.Text = userage.ToString()
            Else
                age.Text = "N/A"
            End If

            ' Status + verified date visibility
            If Status Is DBNull.Value OrElse Status Is Nothing Then
                statusBtn.Text = "Unknown"
                statusBtn.FillColor = ColorTranslator.FromHtml("#666666")
                statusBtn.Enabled = False
                verifiedText.Visible = False
                verifiedDate.Visible = False
            Else
                If Convert.ToBoolean(Status) Then
                    statusBtn.Text = "Verified"
                    statusBtn.FillColor = ColorTranslator.FromHtml("#6B9C89")
                    statusBtn.Enabled = True

                    ' Set verified date if available
                    If verifiedDateValue IsNot DBNull.Value Then
                        verifiedText.Visible = True
                        verifiedDate.Visible = True
                        verifiedDate.Text = Convert.ToDateTime(verifiedDateValue).ToString("MMMM dd, yyyy")
                    Else
                        verifiedText.Visible = False
                        verifiedDate.Visible = False
                    End If
                Else
                    statusBtn.Text = "Not Verified"
                    statusBtn.FillColor = ColorTranslator.FromHtml("#E44040")
                    statusBtn.Enabled = True
                    verifiedText.Visible = False
                    verifiedDate.Visible = False
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

        If Not currentStatus Then
            Dim result As DialogResult = MessageBox.Show("Do you want to verify this customer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim currentDate As DateTime = DateTime.Now

                Await AdminRepository.UpdateUserVerificationStatusWithDateAsync(userId, True, currentDate)
                Await AdminRepository.AddActivityLogAsync(SessionInfo.CurrentUserID, SessionInfo.CurrentUserType, $"verified user | ID:{userId}")

                ' UI updates
                statusBtn.Enabled = False
                statusBtn.Text = "Verified"
                statusBtn.FillColor = ColorTranslator.FromHtml("#6B9C89")
                verifiedText.Visible = True
                verifiedDate.Visible = True
                verifiedDate.Text = currentDate.ToString("MMMM dd, yyyy")

                Await ReloadCustomerDataAsync()
            End If
        End If
    End Sub


    Private Async Function ReloadCustomerDataAsync() As Task

        Dim dt = Await AdminRepository.GetCustomerUserFullData()
        discountTable.DataSource = dt
    End Function

    Private Sub verificationImage_Click(sender As Object, e As EventArgs) Handles verificationImage.Click
        If verificationImage.Image IsNot Nothing Then
            UIHelper.ShowCenteredImagePreview(verificationImage.Image, Me)
        End If
    End Sub

End Class