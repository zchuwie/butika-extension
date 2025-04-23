Imports Guna.UI2.WinForms
Imports System.IO

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

    Public Shared Sub CenterLabelsHorizontallyInPanels(ParamArray ctrls() As Control)
        For Each ctrl As Control In ctrls
            If ctrl.Parent IsNot Nothing AndAlso TypeOf ctrl.Parent Is Panel Then
                ' Horizontal centering only
                ctrl.Left = (ctrl.Parent.ClientSize.Width - ctrl.Width) \ 2
            End If
        Next
    End Sub


    ' change button color and assets
    Public Shared Sub BtnColorChange(btn As Guna2Button, forecolor As Color, fillcolor As Color, image As Image)
        btn.FillColor = fillcolor
        btn.ForeColor = forecolor
        btn.Image = image
    End Sub

    Public Shared Sub ShowCenteredImagePreview(originalImage As Image, parentForm As Form)
        If originalImage Is Nothing Then Return

        ' Get image's original dimensions
        Dim imgWidth As Integer = originalImage.Width
        Dim imgHeight As Integer = originalImage.Height

        ' Max allowed size (e.g., 70% of form)
        Dim maxWidth As Integer = CInt(parentForm.Width * 0.7)
        Dim maxHeight As Integer = CInt(parentForm.Height * 0.7)

        ' Calculate scale to fit in form while keeping aspect ratio
        Dim widthScale As Double = maxWidth / imgWidth
        Dim heightScale As Double = maxHeight / imgHeight
        Dim scale As Double = Math.Min(widthScale, heightScale)

        ' Final dimensions after scaling
        Dim finalWidth As Integer = CInt(imgWidth * scale)
        Dim finalHeight As Integer = CInt(imgHeight * scale)

        ' Create a temporary preview form
        Dim previewForm As New Form With {
            .FormBorderStyle = FormBorderStyle.None,
            .StartPosition = FormStartPosition.CenterParent,
            .BackColor = Color.Black,
            .Opacity = 0.92,
            .Size = New Size(finalWidth, finalHeight),
            .TopMost = True
        }

        ' Add image in PictureBox
        Dim previewBox As New PictureBox With {
            .Image = New Bitmap(originalImage),
            .SizeMode = PictureBoxSizeMode.Zoom,
            .Dock = DockStyle.Fill,
            .Cursor = Cursors.Hand
        }

        ' [Click to close]
        AddHandler previewBox.Click, Sub(sender, e) previewForm.Close()

        previewForm.Controls.Add(previewBox)
        previewForm.ShowDialog(parentForm)
    End Sub
End Class
