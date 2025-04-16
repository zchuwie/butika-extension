Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports butika.Models

Public Class PrescriptionPage
    Private account As New Account()
    Dim accountRep As New AccountRepository()
    Public Sub New(account As Account)
        InitializeComponent()
        Me.account = account
    End Sub

    Private Async Function displayAllPrescriptionOfUser() As Task
        prescriptionListPanel.Controls.Clear()

        Dim prescriptList As New List(Of Prescription)
        Dim prescriptRepo As New PrescriptionRepository(account)
        prescriptList = Await prescriptRepo.GetAllPrescriptions()
        For Each item In prescriptList
            Dim prescriptItem As New prescItem(account)
            prescriptItem.Initialize(item)
            prescriptionListPanel.Controls.Add(prescriptItem)
        Next
    End Function

    Private Async Sub PrescriptionPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await displayAllPrescriptionOfUser()
    End Sub

    Public Sub AddPrescriptionUserToPanel(form As PrescriptionForm)
        If PrescInfoPanel.Controls.Count > 0 Then
            PrescInfoPanel.Controls.Clear()
        End If

        If Not PrescInfoPanel.Controls.Contains(form) Then
            PrescInfoPanel.Controls.Add(form)
            PrescInfoPanel.Visible = True
        End If
    End Sub

    Private Sub prescriptionListPanel_Paint(sender As Object, e As PaintEventArgs) Handles prescriptionListPanel.Paint

    End Sub
End Class