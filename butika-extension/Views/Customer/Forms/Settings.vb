Imports butika.Models
Imports Guna.UI2.WinForms

Public Class Settings
#Region "Functions"
    Private Sub BtnColorChange(button As Guna2Button, fillcolor As Color, image As Image, label As Label, labelColor As Color, subLabel As Label, subColor As Color, backColor As Color)
        button.FillColor = fillcolor
        button.Image = image

        label.ForeColor = labelColor
        label.BackColor = backColor
        subLabel.ForeColor = subColor
        subLabel.BackColor = backColor
    End Sub

    Private Sub OpenFormInPanel(ByVal form As Form)
        form.TopLevel = False
        form.Dock = DockStyle.Fill

        SettingsPanel.Controls.Clear()
        SettingsPanel.Controls.Add(form)
        form.Show()
    End Sub

#End Region
    Private accountState As Boolean, securityState As Boolean
    Private userID As Integer
    Private accountRepo As New AccountRepository()
    Dim account As New Account()

    Public Sub New(account As Account)
        InitializeComponent()
        Me.account = account
    End Sub

    Private Async Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If account IsNot Nothing Then
            Debug.WriteLine("SettingsLoad LOADED:")
            Debug.WriteLine("SettingsLoad First Name: " & account.FirstName)
            Debug.WriteLine("SettingsLoad User ID: " & account.UserID)
        Else
            Debug.WriteLine("Account is null or empty.")
        End If
    End Sub

    Private Async Sub AccountBtn_Click(sender As Object, e As EventArgs) Handles AccountBtn.Click, AccountLbl.Click, AccountSubtext.Click
        account = Await accountRepo.populateDataThroughUserID(account.UserID)
        OpenFormInPanel(New AccountSettings(account))

        'For debugging
        If account IsNot Nothing Then
            Debug.WriteLine("AccountLoad LOADED:")
            Debug.WriteLine("AccountLoad First Name: " & account.FirstName)
            Debug.WriteLine("AccountLoad User ID: " & account.UserID)
        Else
            Debug.WriteLine("Account is null or empty.")
        End If

        BtnColorChange(AccountBtn, Color.FromArgb(22, 66, 60), My.Resources.editProfilePressed, AccountLbl, Color.FromArgb(220, 229, 219), AccountSubtext, Color.FromArgb(220, 229, 219), Color.FromArgb(22, 66, 60))
        BtnColorChange(SecurityBtn, Color.FromArgb(220, 229, 219), My.Resources.EditSecurityUnpressed, SecurityLbl, Color.FromArgb(22, 66, 60), SecuritySubtext, Color.FromArgb(22, 66, 60), Color.FromArgb(220, 229, 219))

        accountState = True
        securityState = False
    End Sub

    Private Sub AccountBtn_MouseHover_1(sender As Object, e As EventArgs) Handles AccountBtn.MouseHover, AccountLbl.MouseHover, AccountSubtext.MouseHover
        AccountLbl.BackColor = Color.FromArgb(56, 94, 89)
        AccountSubtext.BackColor = Color.FromArgb(56, 94, 89)

        AccountLbl.ForeColor = Color.White
        AccountSubtext.ForeColor = Color.White

        BtnColorChange(AccountBtn, Color.FromArgb(56, 94, 89), My.Resources.editProfilePressed, AccountLbl, Color.FromArgb(220, 229, 219), AccountSubtext, Color.FromArgb(220, 229, 219), Color.FromArgb(56, 94, 89))

        If accountState Then
            BtnColorChange(SecurityBtn, Color.FromArgb(220, 229, 219), My.Resources.EditSecurityUnpressed, SecurityLbl, Color.FromArgb(22, 66, 60), SecuritySubtext, Color.FromArgb(22, 66, 60), Color.FromArgb(220, 229, 219))
        End If
        AccountBtn.FillColor = Color.FromArgb(56, 94, 89)
    End Sub

    Private Sub AccountBtn_MouseLeave(sender As Object, e As EventArgs) Handles AccountBtn.MouseLeave, AccountLbl.MouseLeave, AccountSubtext.MouseLeave
        If Not accountState Then
            AccountLbl.BackColor = Color.FromArgb(220, 229, 219)
            AccountSubtext.BackColor = Color.FromArgb(220, 229, 219)

            AccountLbl.ForeColor = Color.FromArgb(22, 66, 60)
            AccountSubtext.ForeColor = Color.FromArgb(22, 66, 60)

            BtnColorChange(AccountBtn, Color.FromArgb(220, 229, 219), My.Resources.editProfileUnpressed, AccountLbl, Color.FromArgb(22, 66, 60), AccountSubtext, Color.FromArgb(22, 66, 60), Color.FromArgb(220, 229, 219))

            AccountBtn.FillColor = Color.FromArgb(220, 229, 219)
        End If
    End Sub

    Private Async Sub SecurityLbl_Click(sender As Object, e As EventArgs) Handles SecurityLbl.Click, SecuritySubtext.Click, SecurityBtn.Click
        account = Await accountRepo.populateDataThroughUserID(account.UserID)
        OpenFormInPanel(New SecuritySettings(account))

        'For debugging
        If account IsNot Nothing Then
            Debug.WriteLine("SecurityLoad LOADED:")
            Debug.WriteLine("SecurityLoad First Name: " & account.FirstName)
            Debug.WriteLine("SecurityLoad User ID: " & account.UserID)
        Else
            Debug.WriteLine("Account is null or empty.")
        End If

        BtnColorChange(SecurityBtn, Color.FromArgb(22, 66, 60), My.Resources.EditSecurityPressed, SecurityLbl, Color.FromArgb(220, 229, 219), SecuritySubtext, Color.FromArgb(220, 229, 219), Color.FromArgb(22, 66, 60))
        BtnColorChange(AccountBtn, Color.FromArgb(220, 229, 219), My.Resources.editProfileUnpressed, AccountLbl, Color.FromArgb(22, 66, 60), AccountSubtext, Color.FromArgb(22, 66, 60), Color.FromArgb(220, 229, 219))

        accountState = False
        securityState = True
    End Sub

    Private Sub SecurityLbl_MouseHover(sender As Object, e As EventArgs) Handles SecurityLbl.MouseHover, SecuritySubtext.MouseHover, SecurityBtn.MouseHover
        SecurityLbl.BackColor = Color.FromArgb(56, 94, 89)
        SecuritySubtext.BackColor = Color.FromArgb(56, 94, 89)

        SecurityLbl.ForeColor = Color.White
        SecuritySubtext.ForeColor = Color.White

        BtnColorChange(SecurityBtn, Color.FromArgb(56, 94, 89), My.Resources.EditSecurityPressed, SecurityLbl, Color.FromArgb(220, 229, 219), SecuritySubtext, Color.FromArgb(220, 229, 219), Color.FromArgb(56, 94, 89))

        If securityState Then
            BtnColorChange(AccountBtn, Color.FromArgb(220, 229, 219), My.Resources.editProfileUnpressed, AccountLbl, Color.FromArgb(22, 66, 60), AccountSubtext, Color.FromArgb(22, 66, 60), Color.FromArgb(220, 229, 219))
        End If
        SecurityBtn.FillColor = Color.FromArgb(56, 94, 89)
    End Sub

    Private Sub SecurityLbl_MouseLeave(sender As Object, e As EventArgs) Handles SecurityLbl.MouseLeave, SecuritySubtext.MouseLeave, SecurityBtn.MouseLeave
        If Not securityState Then
            SecurityLbl.BackColor = Color.FromArgb(220, 229, 219)
            SecuritySubtext.BackColor = Color.FromArgb(220, 229, 219)

            SecurityLbl.ForeColor = Color.FromArgb(22, 66, 60)
            SecuritySubtext.ForeColor = Color.FromArgb(22, 66, 60)

            BtnColorChange(SecurityBtn, Color.FromArgb(220, 229, 219), My.Resources.EditSecurityUnpressed, SecurityLbl, Color.FromArgb(22, 66, 60), SecuritySubtext, Color.FromArgb(22, 66, 60), Color.FromArgb(220, 229, 219))

            SecurityBtn.FillColor = Color.FromArgb(220, 229, 219)
        End If
    End Sub
End Class