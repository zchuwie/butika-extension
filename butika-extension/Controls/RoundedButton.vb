Imports System.Drawing.Drawing2D

Public Class RoundedButton
    Inherits Button

    ' Property to set the corner radius
    Public Property CornerRadius As Integer = 20

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        ' Create a graphics path to draw the rounded rectangle
        Dim path As New GraphicsPath()
        Dim rect As New Rectangle(0, 0, Me.Width, Me.Height)

        ' Add rounded corners to the path
        path.AddArc(rect.X, rect.Y, CornerRadius, CornerRadius, 180, 90)
        path.AddArc(rect.X + rect.Width - CornerRadius, rect.Y, CornerRadius, CornerRadius, 270, 90)
        path.AddArc(rect.X + rect.Width - CornerRadius, rect.Y + rect.Height - CornerRadius, CornerRadius, CornerRadius, 0, 90)
        path.AddArc(rect.X, rect.Y + rect.Height - CornerRadius, CornerRadius, CornerRadius, 90, 90)
        path.CloseFigure()

        ' Set the region of the button to the rounded rectangle
        Me.Region = New Region(path)

        ' Draw the button background and text
        Dim brush As New SolidBrush(Me.BackColor)
        e.Graphics.FillPath(brush, path)
        Dim stringFormat As New StringFormat()
        stringFormat.Alignment = StringAlignment.Center
        stringFormat.LineAlignment = StringAlignment.Center
        e.Graphics.DrawString(Me.Text, Me.Font, New SolidBrush(Me.ForeColor), rect, stringFormat)
    End Sub
End Class