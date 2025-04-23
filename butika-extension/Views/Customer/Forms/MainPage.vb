Imports butika.Models
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
    Private userID As Integer
    Private accountRepo As New AccountRepository()
    Dim account As New Account()

    Public Sub New(userID As Integer)
        Me.userID = userID
        InitializeComponent()
    End Sub

    Private Async Sub MainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        account = Await accountRepo.populateDataThroughUserID(userID)
        OpenFormInPanel(New HomePage(account))

        BtnColorChange(HomeBtn, Color.FromArgb(220, 229, 219), My.Resources.pressedHome)
        BtnColorChange(MedicineBtn, Color.FromArgb(22, 66, 60), My.Resources.pills)
        BtnColorChange(CartBtn, Color.FromArgb(22, 66, 60), My.Resources.cart1)
        BtnColorChange(PrescBtn, Color.FromArgb(22, 66, 60), My.Resources.notif)

        BtnColorChange(LogoutBtn, Color.FromArgb(22, 66, 60), My.Resources.logout1)
        BtnColorChange(SettingsBtn, Color.FromArgb(22, 66, 60), My.Resources.settings)
    End Sub

    Private Async Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        account = Await accountRepo.populateDataThroughUserID(userID)
        OpenFormInPanel(New HomePage(account))

        BtnColorChange(HomeBtn, Color.FromArgb(220, 229, 219), My.Resources.pressedHome)
        BtnColorChange(MedicineBtn, Color.FromArgb(22, 66, 60), My.Resources.pills)
        BtnColorChange(CartBtn, Color.FromArgb(22, 66, 60), My.Resources.cart1)
        BtnColorChange(PrescBtn, Color.FromArgb(22, 66, 60), My.Resources.notif)

        BtnColorChange(LogoutBtn, Color.FromArgb(22, 66, 60), My.Resources.logout1)
        BtnColorChange(SettingsBtn, Color.FromArgb(22, 66, 60), My.Resources.settings)
    End Sub

    Private Async Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles MedicineBtn.Click
        account = Await accountRepo.populateDataThroughUserID(userID)
        OpenFormInPanel(New MedicinePage(account))

        BtnColorChange(HomeBtn, Color.FromArgb(22, 66, 60), My.Resources.home)
        BtnColorChange(MedicineBtn, Color.FromArgb(220, 229, 219), My.Resources.pressedPills)
        BtnColorChange(CartBtn, Color.FromArgb(22, 66, 60), My.Resources.cart1)
        BtnColorChange(PrescBtn, Color.FromArgb(22, 66, 60), My.Resources.notif)

        BtnColorChange(LogoutBtn, Color.FromArgb(22, 66, 60), My.Resources.logout1)
        BtnColorChange(SettingsBtn, Color.FromArgb(22, 66, 60), My.Resources.settings)
    End Sub

    Private Async Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles CartBtn.Click
        account = Await accountRepo.populateDataThroughUserID(userID)
        OpenFormInPanel(New CartPage(account))

        BtnColorChange(HomeBtn, Color.FromArgb(22, 66, 60), My.Resources.home)
        BtnColorChange(MedicineBtn, Color.FromArgb(22, 66, 60), My.Resources.pills)
        BtnColorChange(CartBtn, Color.FromArgb(220, 229, 219), My.Resources.pressedCart)
        BtnColorChange(PrescBtn, Color.FromArgb(22, 66, 60), My.Resources.notif)

        BtnColorChange(LogoutBtn, Color.FromArgb(22, 66, 60), My.Resources.logout1)
        BtnColorChange(SettingsBtn, Color.FromArgb(22, 66, 60), My.Resources.settings)
    End Sub

    Private Async Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles PrescBtn.Click
        account = Await accountRepo.populateDataThroughUserID(userID)
        OpenFormInPanel(New PrescriptionPage(account))

        BtnColorChange(HomeBtn, Color.FromArgb(22, 66, 60), My.Resources.home)
        BtnColorChange(MedicineBtn, Color.FromArgb(22, 66, 60), My.Resources.pills)
        BtnColorChange(CartBtn, Color.FromArgb(22, 66, 60), My.Resources.cart1)
        BtnColorChange(PrescBtn, Color.FromArgb(220, 229, 219), My.Resources.pressedNotif)

        BtnColorChange(LogoutBtn, Color.FromArgb(22, 66, 60), My.Resources.logout1)
        BtnColorChange(SettingsBtn, Color.FromArgb(22, 66, 60), My.Resources.settings)
    End Sub

    Private Async Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        'logout here
        Dim loginForm As New Login()
        Dim userID As Integer = SessionInfo.CurrentUserID
        Dim userType As Integer = SessionInfo.CurrentUserType

        Await AdminRepository.LogLogoutActivity(userID, userType)
        loginForm.Show()
        Me.Close()

        BtnColorChange(HomeBtn, Color.FromArgb(22, 66, 60), My.Resources.home)
        BtnColorChange(MedicineBtn, Color.FromArgb(22, 66, 60), My.Resources.pills)
        BtnColorChange(CartBtn, Color.FromArgb(22, 66, 60), My.Resources.cart1)
        BtnColorChange(PrescBtn, Color.FromArgb(22, 66, 60), My.Resources.notif)
        BtnColorChange(LogoutBtn, Color.FromArgb(220, 229, 219), My.Resources.pressedLogout1)
        BtnColorChange(SettingsBtn, Color.FromArgb(22, 66, 60), My.Resources.settings)
    End Sub

    Private Async Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles SettingsBtn.Click
        account = Await accountRepo.populateDataThroughUserID(userID)
        OpenFormInPanel(New Settings(account))

        'debugging
        If account IsNot Nothing Then
            Debug.WriteLine("MAIN ACCOUNT LOADED:")
            Debug.WriteLine("MAIN First Name: " & account.FirstName)
            Debug.WriteLine("MAIN User ID: " & account.UserID)
        Else
            Debug.WriteLine("MAIN Account is null or empty.")
        End If

        BtnColorChange(HomeBtn, Color.FromArgb(22, 66, 60), My.Resources.home)
        BtnColorChange(MedicineBtn, Color.FromArgb(22, 66, 60), My.Resources.pills)
        BtnColorChange(CartBtn, Color.FromArgb(22, 66, 60), My.Resources.cart1)
        BtnColorChange(PrescBtn, Color.FromArgb(22, 66, 60), My.Resources.notif)

        BtnColorChange(LogoutBtn, Color.FromArgb(22, 66, 60), My.Resources.logout1)
        BtnColorChange(SettingsBtn, Color.FromArgb(220, 229, 219), My.Resources.pressedSettings)
    End Sub
End Class