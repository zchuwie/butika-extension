Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class RoundedPanel
    Inherits Panel

    ' Individual corner radius properties with property attributes
    Private _topLeftRadius As Integer = 20
    Private _topRightRadius As Integer = 20
    Private _bottomLeftRadius As Integer = 20
    Private _bottomRightRadius As Integer = 20

    <Browsable(True), Category("Appearance"), Description("Top-left corner radius")>
    Public Property TopLeftRadius() As Integer
        Get
            Return _topLeftRadius
        End Get
        Set(value As Integer)
            _topLeftRadius = Math.Max(0, value) ' Prevent negative values
            Me.Invalidate()
        End Set
    End Property

    <Browsable(True), Category("Appearance"), Description("Top-right corner radius")>
    Public Property TopRightRadius() As Integer
        Get
            Return _topRightRadius
        End Get
        Set(value As Integer)
            _topRightRadius = Math.Max(0, value)
            Me.Invalidate()
        End Set
    End Property

    <Browsable(True), Category("Appearance"), Description("Bottom-left corner radius")>
    Public Property BottomLeftRadius() As Integer
        Get
            Return _bottomLeftRadius
        End Get
        Set(value As Integer)
            _bottomLeftRadius = Math.Max(0, value)
            Me.Invalidate()
        End Set
    End Property

    <Browsable(True), Category("Appearance"), Description("Bottom-right corner radius")>
    Public Property BottomRightRadius() As Integer
        Get
            Return _bottomRightRadius
        End Get
        Set(value As Integer)
            _bottomRightRadius = Math.Max(0, value)
            Me.Invalidate()
        End Set
    End Property

    ' Constructor
    Public Sub New()
        Me.BackColor = Color.White ' Default background color
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint, True)
    End Sub

    ' Create a rounded rectangle path with different corner radius values
    Private Function GetRoundedRectanglePath(bounds As Rectangle) As GraphicsPath
        Dim path As New GraphicsPath()

        Dim tl As Integer = _topLeftRadius * 2
        Dim tr As Integer = _topRightRadius * 2
        Dim bl As Integer = _bottomLeftRadius * 2
        Dim br As Integer = _bottomRightRadius * 2

        ' Top-left arc
        If tl > 0 Then
            path.AddArc(bounds.X, bounds.Y, tl, tl, 180, 90)
        Else
            path.AddLine(bounds.X, bounds.Y, bounds.X, bounds.Y)
        End If

        ' Top-right arc
        If tr > 0 Then
            path.AddArc(bounds.Right - tr, bounds.Y, tr, tr, 270, 90)
        Else
            path.AddLine(bounds.Right, bounds.Y, bounds.Right, bounds.Y)
        End If

        ' Bottom-right arc
        If br > 0 Then
            path.AddArc(bounds.Right - br, bounds.Bottom - br, br, br, 0, 90)
        Else
            path.AddLine(bounds.Right, bounds.Bottom, bounds.Right, bounds.Bottom)
        End If

        ' Bottom-left arc
        If bl > 0 Then
            path.AddArc(bounds.X, bounds.Bottom - bl, bl, bl, 90, 90)
        Else
            path.AddLine(bounds.X, bounds.Bottom, bounds.X, bounds.Bottom)
        End If

        path.CloseFigure()

        Return path
    End Function

    ' Override OnPaint to draw rounded corners
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim graphics As Graphics = e.Graphics
        graphics.SmoothingMode = SmoothingMode.AntiAlias

        Dim rect As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim path As GraphicsPath = GetRoundedRectanglePath(rect)

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
