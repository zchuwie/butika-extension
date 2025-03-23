' RoundedUserControl.vb
Imports System.Drawing.Drawing2D
Imports System.ComponentModel

Public Class RoundedUserControl
    Inherits UserControl

    Private _cornerRadius As Integer = 20

    <Category("Appearance")>
    Public Property CornerRadius As Integer
        Get
            Return _cornerRadius
        End Get
        Set(value As Integer)
            _cornerRadius = value
            UpdateRegion()
            Me.Invalidate()
        End Set
    End Property

    Public Sub New()
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.BackColor = Color.WhiteSmoke
        Me.Size = New Size(300, 180)
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        UpdateRegion()
    End Sub

    Private Sub UpdateRegion()
        Dim path As New GraphicsPath()
        path.StartFigure()
        path.AddArc(0, 0, _cornerRadius, _cornerRadius, 180, 90)
        path.AddArc(Me.Width - _cornerRadius, 0, _cornerRadius, _cornerRadius, 270, 90)
        path.AddArc(Me.Width - _cornerRadius, Me.Height - _cornerRadius, _cornerRadius, _cornerRadius, 0, 90)
        path.AddArc(0, Me.Height - _cornerRadius, _cornerRadius, _cornerRadius, 90, 90)
        path.CloseFigure()
        Me.Region = New Region(path)
    End Sub
End Class
