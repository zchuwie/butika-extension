Public Class MainPage



#Region "Functions"

    Private Sub OpenFormInPanel(ByVal form As Form)
        form.TopLevel = False
        form.Dock = DockStyle.Fill

        MainPanel.Controls.Clear()
        MainPanel.Controls.Add(form)
        form.Show()
    End Sub

#End Region

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles sidebar.Paint

    End Sub

    Private Sub MainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenFormInPanel(New HomePage(Me))
    End Sub

    'Home Page here
    Private Sub HomePageBtn_Click(sender As Object, e As EventArgs)
        'Dim f As New Form()
        'f.TopLevel = False
        'f.WindowState = FormWindowState.Maximized
        'f.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        'f.Visible = True
        'Panel1.Controls.Add(f)

    End Sub

    Private Sub MedPageBtn_Click(sender As Object, e As EventArgs)
        MainPanel.Controls.Clear()

        Dim f As New MedicinePage
        f.TopLevel = False
        f.WindowState = FormWindowState.Maximized
        f.Visible = True
        MainPanel.Controls.Add(f)

    End Sub

    Private Sub CartPageBtn_Click(sender As Object, e As EventArgs)
        MainPanel.Controls.Clear()

        Dim f As New CartPage
        f.TopLevel = False
        f.WindowState = FormWindowState.Maximized
        f.Visible = True
        MainPanel.Controls.Add(f)

    End Sub

    Private Sub PrescPageBtn_Click(sender As Object, e As EventArgs)
        MainPanel.Controls.Clear()

        Dim f As New PrescriptionPage
        f.TopLevel = False
        f.WindowState = FormWindowState.Maximized
        f.Visible = True
        MainPanel.Controls.Add(f)

    End Sub

    Private Sub SettingsBtn_Click(sender As Object, e As EventArgs)
        MainPanel.Controls.Clear()

        Dim f As New Settings
        f.TopLevel = False
        f.WindowState = FormWindowState.Maximized
        f.Visible = True
        MainPanel.Controls.Add(f)

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        MainPanel.Controls.Clear()

        Dim f As New MedicinePage()
        f.TopLevel = False
        f.WindowState = FormWindowState.Maximized
        f.Visible = True
        MainPanel.Controls.Add(f)

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        MainPanel.Controls.Clear()

        Dim f As New CartPage()
        f.TopLevel = False
        f.WindowState = FormWindowState.Maximized
        f.Visible = True
        MainPanel.Controls.Add(f)

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        MainPanel.Controls.Clear()

        Dim f As New PrescriptionPage()
        f.TopLevel = False
        f.WindowState = FormWindowState.Maximized
        f.Visible = True
        MainPanel.Controls.Add(f)

    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        'logout here
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        MainPanel.Controls.Clear()

        Dim f As New Settings()
        f.TopLevel = False
        f.WindowState = FormWindowState.Maximized
        f.Visible = True
        MainPanel.Controls.Add(f)

    End Sub

End Class