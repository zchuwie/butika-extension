Public Class adminUser
    Private Sub copyID_Click(sender As Object, e As EventArgs) Handles copyID.Click
        ' Copy the Account ID text to clipboard
        Clipboard.SetText(accountIdTxt.Text)

        ' Show the text copy indicator for Account ID
        textCopyIndicator.Visible = True

        ' Set a timer to hide the indicator after 1 second (1000 milliseconds)
        copyTimer.Interval = 1000  ' 1 second
        copyTimer.Start()
    End Sub

    Private Sub copyUsername_Click(sender As Object, e As EventArgs) Handles copyUsername.Click
        ' Copy the Username text to clipboard
        Clipboard.SetText(usernameTxt.Text)

        ' Show the text copy indicator for Username
        textCopyIndicator2.Visible = True

        ' Set a timer to hide the indicator after 1 second (1000 milliseconds)
        copyTimer.Interval = 1000  ' 1 second
        copyTimer.Start()
    End Sub

    ' Timer event to hide the indicators
    Private Sub copyTimer_Tick(sender As Object, e As EventArgs) Handles copyTimer.Tick
        ' Hide the text copy indicators after 1 second
        textCopyIndicator.Visible = False
        textCopyIndicator2.Visible = False

        ' Stop the timer
        copyTimer.Stop()
    End Sub

End Class