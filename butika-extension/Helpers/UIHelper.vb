Imports Guna.UI2.WinForms

Public Class UIHelper
    ' This centers a single control inside a panel
    Public Shared Sub CenterControlInPanel(pnl As Panel, ctrl As Control)
        If pnl IsNot Nothing AndAlso ctrl IsNot Nothing Then
            ctrl.Left = (pnl.ClientSize.Width - ctrl.Width) \ 2
            ctrl.Top = (pnl.ClientSize.Height - ctrl.Height) \ 2
            ' Prevents label from going out of bounds
            If ctrl.Top < 0 Then ctrl.Top = 0
        End If
    End Sub

    ' This centers all labels inside their parent panels
    Public Shared Sub CenterLabelsInPanels(ParamArray ctrls() As Control)
        For Each ctrl As Control In ctrls
            If ctrl.Parent IsNot Nothing AndAlso TypeOf ctrl.Parent Is Panel Then
                CenterControlInPanel(CType(ctrl.Parent, Panel), ctrl)
            End If
        Next
    End Sub

    ' change button color and assets
    Public Shared Sub BtnColorChange(btn As Guna2Button, forecolor As Color, fillcolor As Color, image As Image)
        btn.FillColor = fillcolor
        btn.ForeColor = forecolor
        btn.Image = image
    End Sub
End Class
