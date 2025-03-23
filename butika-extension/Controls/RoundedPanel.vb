Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Namespace Controls

    Public Class RoundedPanel
        Inherits Panel

        ' Property to set the radius of the corners
        Private _cornerRadius As Integer = 20
        Public Property CornerRadius() As Integer
            Get
                Return _cornerRadius
            End Get
            Set(ByVal value As Integer)
                _cornerRadius = value
                Me.Invalidate() ' Redraw when value changes
            End Set
        End Property

        ' Constructor
        Public Sub New()
            Me.BackColor = Color.White ' Default background color
            Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint, True)
        End Sub

        ' Create a rounded rectangle path
        Private Function GetRoundedRectanglePath(bounds As Rectangle, radius As Integer) As GraphicsPath
            Dim path As New GraphicsPath()
            Dim d As Integer = radius * 2

            ' Top-left arc
            path.AddArc(bounds.X, bounds.Y, d, d, 180, 90)
            ' Top-right arc
            path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90)
            ' Bottom-right arc
            path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90)
            ' Bottom-left arc
            path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90)
            path.CloseFigure()

            Return path
        End Function

        ' Override OnPaint to draw rounded corners
        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            MyBase.OnPaint(e)

            Dim graphics As Graphics = e.Graphics
            graphics.SmoothingMode = SmoothingMode.AntiAlias

            Dim rect As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
            Dim path As GraphicsPath = GetRoundedRectanglePath(rect, _cornerRadius)

            ' Fill the panel background with rounded corners
            Using brush As New SolidBrush(Me.BackColor)
                graphics.FillPath(brush, path)
            End Using

            ' Draw border if needed
            Using pen As New Pen(Me.ForeColor, 1)
                graphics.DrawPath(pen, path)
            End Using

            ' Apply the rounded region to the panel
            Me.Region = New Region(path)
        End Sub
    End Class

End Namespace