Public Class MainPage
    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles sidebar.Paint

    End Sub

    Private Sub MainPage_Load(sender As Object, e As EventArgs)

    End Sub

    'Home Page here
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles HomePageBtn.Click
        'Dim f As New Form()
        'f.TopLevel = False
        'f.WindowState = FormWindowState.Maximized
        'f.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        'f.Visible = True
        'Panel1.Controls.Add(f)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles MedPageBtn.Click
        Dim f As New MedicinePage()
        f.TopLevel = False
        f.WindowState = FormWindowState.Maximized
        f.Visible = True
        MainPanel.Controls.Add(f)
    End Sub
End Class