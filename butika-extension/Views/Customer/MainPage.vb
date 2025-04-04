Imports butika.Models

Public Class MainPage

#Region "Functions"
    Function PressedPage(ByVal pHome As Boolean, pPills As Boolean, pCart As Boolean, pNotif As Boolean, pLogout As Boolean, pSettings As Boolean)
        pressedHomePanel.Visible = pHome
        pressedPillsPanel.Visible = pPills
        PressedCartPanel.Visible = pCart
        PressedNotifPanel.Visible = pNotif
        'pressedLogoutPanel.Visible = pLogout
        pressedSettingsPanel.Visible = pSettings
    End Function

#End Region

    Private userID As Integer
    Dim account As New Account()
    Dim accountRep As New AccountRepository()

    Public Sub New(userID As Integer)
        InitializeComponent()
        Me.userID = userID
    End Sub

    'Home Page here
    Private Sub HomePageBtn_Click(sender As Object, e As EventArgs) Handles pressedHome.Click
        'Dim f As New Form()
        'f.TopLevel = False
        'f.WindowState = FormWindowState.Maximized
        'f.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        'f.Visible = True
        'Panel1.Controls.Add(f)

        PressedPage(True, False, False, False, False, False)
    End Sub

    Private Async Sub MedPageBtn_Click(sender As Object, e As EventArgs) Handles MedPageBtn.Click, pressedPills.Click
        account = Await accountRep.populateDataThroughUserID(userID)
        MainPanel.Controls.Clear()

        Dim f As New MedicinePage(account)
        f.TopLevel = False
        f.WindowState = FormWindowState.Maximized
        f.Visible = True
        MainPanel.Controls.Add(f)

        PressedPage(False, True, False, False, False, False)
    End Sub

    Private Async Sub CartPageBtn_Click(sender As Object, e As EventArgs) Handles CartPageBtn.Click, PressedCart.Click
        account = Await accountRep.populateDataThroughUserID(userID)
        MainPanel.Controls.Clear()

        Dim f As New CartPage(account)
        f.TopLevel = False
        f.WindowState = FormWindowState.Maximized
        f.Visible = True
        MainPanel.Controls.Add(f)

        PressedPage(False, False, True, False, False, False)
    End Sub

    Private Async Sub PrescPageBtn_Click(sender As Object, e As EventArgs) Handles PrescPageBtn.Click, PressedNotif.Click
        account = Await accountRep.populateDataThroughUserID(userID)
        MainPanel.Controls.Clear()


        Dim f As New PrescriptionPage(account)
        f.TopLevel = False
        f.WindowState = FormWindowState.Maximized
        f.Visible = True
        MainPanel.Controls.Add(f)

        PressedPage(False, False, False, True, False, False)
    End Sub

    Private Async Sub SettingsBtn_Click(sender As Object, e As EventArgs) Handles SettingsBtn.Click, pressedSettings.Click
        account = Await accountRep.populateDataThroughUserID(userID)
        MainPanel.Controls.Clear()

        Dim f As New Settings(account)
        f.TopLevel = False
        f.WindowState = FormWindowState.Maximized
        f.Visible = True
        MainPanel.Controls.Add(f)

        PressedPage(False, False, False, False, False, True)
    End Sub
End Class