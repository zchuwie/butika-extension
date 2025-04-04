Imports Guna.UI2.WinForms

Public Class MainPage



#Region "Functions"

    Private Sub OpenFormInPanel(ByVal form As Form)
        form.TopLevel = False
        form.Dock = DockStyle.Fill

        MainPanel.Controls.Clear()
        MainPanel.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub BtnColorChange(button As Guna2Button, fillcolor As Color, image As Image)
        button.FillColor = fillcolor
        button.Image = image
    End Sub

#End Region

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles sidebar.Paint

    End Sub

    Private Sub MainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenFormInPanel(New HomePage(Me))

        BtnColorChange(HomeBtn, Color.FromArgb(220, 229, 219), My.Resources.pressedHome)
        BtnColorChange(MedicineBtn, Color.FromArgb(22, 66, 60), My.Resources.pills)
        BtnColorChange(CartBtn, Color.FromArgb(22, 66, 60), My.Resources.cart1)
        BtnColorChange(PrescBtn, Color.FromArgb(22, 66, 60), My.Resources.notif)

        BtnColorChange(LogoutBtn, Color.FromArgb(22, 66, 60), My.Resources.logout1)
        BtnColorChange(SettingsBtn, Color.FromArgb(22, 66, 60), My.Resources.settings)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        OpenFormInPanel(New HomePage(Me))

        BtnColorChange(HomeBtn, Color.FromArgb(220, 229, 219), My.Resources.pressedHome)
        BtnColorChange(MedicineBtn, Color.FromArgb(22, 66, 60), My.Resources.pills)
        BtnColorChange(CartBtn, Color.FromArgb(22, 66, 60), My.Resources.cart1)
        BtnColorChange(PrescBtn, Color.FromArgb(22, 66, 60), My.Resources.notif)

        BtnColorChange(LogoutBtn, Color.FromArgb(22, 66, 60), My.Resources.logout1)
        BtnColorChange(SettingsBtn, Color.FromArgb(22, 66, 60), My.Resources.settings)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles MedicineBtn.Click
        OpenFormInPanel(New MedicinePage())

        BtnColorChange(HomeBtn, Color.FromArgb(22, 66, 60), My.Resources.home)
        BtnColorChange(MedicineBtn, Color.FromArgb(220, 229, 219), My.Resources.pressedPills)
        BtnColorChange(CartBtn, Color.FromArgb(22, 66, 60), My.Resources.cart1)
        BtnColorChange(PrescBtn, Color.FromArgb(22, 66, 60), My.Resources.notif)

        BtnColorChange(LogoutBtn, Color.FromArgb(22, 66, 60), My.Resources.logout1)
        BtnColorChange(SettingsBtn, Color.FromArgb(22, 66, 60), My.Resources.settings)
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles CartBtn.Click
        OpenFormInPanel(New CartPage())

        BtnColorChange(HomeBtn, Color.FromArgb(22, 66, 60), My.Resources.home)
        BtnColorChange(MedicineBtn, Color.FromArgb(22, 66, 60), My.Resources.pills)
        BtnColorChange(CartBtn, Color.FromArgb(220, 229, 219), My.Resources.pressedCart)
        BtnColorChange(PrescBtn, Color.FromArgb(22, 66, 60), My.Resources.notif)

        BtnColorChange(LogoutBtn, Color.FromArgb(22, 66, 60), My.Resources.logout1)
        BtnColorChange(SettingsBtn, Color.FromArgb(22, 66, 60), My.Resources.settings)
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles PrescBtn.Click
        OpenFormInPanel(New PrescriptionPage())

        BtnColorChange(HomeBtn, Color.FromArgb(22, 66, 60), My.Resources.home)
        BtnColorChange(MedicineBtn, Color.FromArgb(22, 66, 60), My.Resources.pills)
        BtnColorChange(CartBtn, Color.FromArgb(22, 66, 60), My.Resources.cart1)
        BtnColorChange(PrescBtn, Color.FromArgb(220, 229, 219), My.Resources.pressedNotif)

        BtnColorChange(LogoutBtn, Color.FromArgb(22, 66, 60), My.Resources.logout1)
        BtnColorChange(SettingsBtn, Color.FromArgb(22, 66, 60), My.Resources.settings)
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        'logout here

        BtnColorChange(HomeBtn, Color.FromArgb(22, 66, 60), My.Resources.home)
        BtnColorChange(MedicineBtn, Color.FromArgb(22, 66, 60), My.Resources.pills)
        BtnColorChange(CartBtn, Color.FromArgb(22, 66, 60), My.Resources.cart1)
        BtnColorChange(PrescBtn, Color.FromArgb(22, 66, 60), My.Resources.notif)

        BtnColorChange(LogoutBtn, Color.FromArgb(220, 229, 219), My.Resources.pressedLogout1)
        BtnColorChange(SettingsBtn, Color.FromArgb(22, 66, 60), My.Resources.settings)
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles SettingsBtn.Click
        OpenFormInPanel(New Settings())

        BtnColorChange(HomeBtn, Color.FromArgb(22, 66, 60), My.Resources.home)
        BtnColorChange(MedicineBtn, Color.FromArgb(22, 66, 60), My.Resources.pills)
        BtnColorChange(CartBtn, Color.FromArgb(22, 66, 60), My.Resources.cart1)
        BtnColorChange(PrescBtn, Color.FromArgb(22, 66, 60), My.Resources.notif)

        BtnColorChange(LogoutBtn, Color.FromArgb(22, 66, 60), My.Resources.logout1)
        BtnColorChange(SettingsBtn, Color.FromArgb(220, 229, 219), My.Resources.pressedSettings)
    End Sub

    Private Sub MainPanel_Paint(sender As Object, e As PaintEventArgs) Handles MainPanel.Paint

    End Sub
End Class