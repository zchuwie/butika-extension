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

    Dim account As New Account()

    Public Sub New(account As Account)
        InitializeComponent()
        Me.account = account
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles SettingsPanel.Paint

    End Sub

    Private Sub AccountSubtext_Click(sender As Object, e As EventArgs) Handles AccountSubtext.Click, AccountBtn.Click, AccountLbl.Click
        OpenFormInPanel(AccountSettings)

        BtnColorChange(AccountBtn, Color.FromArgb(22, 66, 60), My.Resources.editProfilePressed, AccountLbl, Color.FromArgb(220, 229, 219), AccountSubtext, Color.FromArgb(220, 229, 219), Color.FromArgb(22, 66, 60))
        BtnColorChange(SecurityBtn, Color.FromArgb(220, 229, 219), My.Resources.EditSecurityUnpressed, SecurityLbl, Color.FromArgb(22, 66, 60), SecuritySubtext, Color.FromArgb(22, 66, 60), Color.FromArgb(220, 229, 219))

    End Sub

    Private Sub SecuritySubtext_Click(sender As Object, e As EventArgs) Handles SecuritySubtext.Click, SecurityLbl.Click, SecurityBtn.Click
        OpenFormInPanel(SecuritySettings)

        BtnColorChange(SecurityBtn, Color.FromArgb(22, 66, 60), My.Resources.EditSecurityPressed, SecurityLbl, Color.FromArgb(220, 229, 219), SecuritySubtext, Color.FromArgb(220, 229, 219), Color.FromArgb(22, 66, 60))
        BtnColorChange(AccountBtn, Color.FromArgb(220, 229, 219), My.Resources.editProfileUnpressed, AccountLbl, Color.FromArgb(22, 66, 60), AccountSubtext, Color.FromArgb(22, 66, 60), Color.FromArgb(220, 229, 219))
    End Sub
    Private Sub AccountBtn_MouseHover(sender As Object, e As EventArgs) Handles AccountSubtext.MouseHover, AccountBtn.MouseHover, AccountLbl.MouseHover
        AccountLbl.BackColor = Color.FromArgb(22, 66, 60)
        AccountSubtext.BackColor = Color.FromArgb(22, 66, 60)

        AccountLbl.ForeColor = Color.White
        AccountSubtext.ForeColor = Color.White

        BtnColorChange(AccountBtn, Color.FromArgb(22, 66, 60), My.Resources.editProfilePressed, AccountLbl, Color.FromArgb(220, 229, 219), AccountSubtext, Color.FromArgb(220, 229, 219), Color.FromArgb(22, 66, 60))
        BtnColorChange(SecurityBtn, Color.FromArgb(220, 229, 219), My.Resources.EditSecurityUnpressed, SecurityLbl, Color.FromArgb(22, 66, 60), SecuritySubtext, Color.FromArgb(22, 66, 60), Color.FromArgb(220, 229, 219))
    End Sub

    Private Sub SecurityLbl_MouseHover_1(sender As Object, e As EventArgs) Handles SecuritySubtext.MouseHover, SecurityLbl.MouseHover, SecurityBtn.MouseHover
        SecurityLbl.BackColor = Color.FromArgb(22, 66, 60)
        SecuritySubtext.BackColor = Color.FromArgb(22, 66, 60)

        SecurityLbl.ForeColor = Color.White
        SecuritySubtext.ForeColor = Color.White

        BtnColorChange(SecurityBtn, Color.FromArgb(22, 66, 60), My.Resources.EditSecurityPressed, SecurityLbl, Color.FromArgb(220, 229, 219), SecuritySubtext, Color.FromArgb(220, 229, 219), Color.FromArgb(22, 66, 60))
        BtnColorChange(AccountBtn, Color.FromArgb(220, 229, 219), My.Resources.editProfileUnpressed, AccountLbl, Color.FromArgb(22, 66, 60), AccountSubtext, Color.FromArgb(22, 66, 60), Color.FromArgb(220, 229, 219))
    End Sub

    Private Sub AccountLbl_MouseLeave(sender As Object, e As EventArgs) Handles AccountSubtext.MouseLeave, AccountBtn.MouseLeave, AccountLbl.MouseLeave
        AccountLbl.BackColor = Color.FromArgb(220, 229, 219)
        AccountSubtext.BackColor = Color.FromArgb(220, 229, 219)

        AccountLbl.ForeColor = Color.FromArgb(22, 66, 60)
        AccountSubtext.ForeColor = Color.FromArgb(22, 66, 60)

        BtnColorChange(AccountBtn, Color.FromArgb(220, 229, 219), My.Resources.editProfileUnpressed, AccountLbl, Color.FromArgb(22, 66, 60), AccountSubtext, Color.FromArgb(22, 66, 60), Color.FromArgb(220, 229, 219))
    End Sub

    Private Sub SecurityBtn_MouseLeave(sender As Object, e As EventArgs) Handles SecuritySubtext.MouseLeave, SecurityLbl.MouseLeave, SecurityBtn.MouseLeave
        SecurityLbl.BackColor = Color.FromArgb(220, 229, 219)
        SecuritySubtext.BackColor = Color.FromArgb(220, 229, 219)

        SecurityLbl.ForeColor = Color.FromArgb(22, 66, 60)
        SecuritySubtext.ForeColor = Color.FromArgb(22, 66, 60)

        BtnColorChange(SecurityBtn, Color.FromArgb(220, 229, 219), My.Resources.EditSecurityUnpressed, SecurityLbl, Color.FromArgb(22, 66, 60), SecuritySubtext, Color.FromArgb(22, 66, 60), Color.FromArgb(220, 229, 219))
    End Sub
End Class