Imports butika.Models
Imports Microsoft.VisualBasic.ApplicationServices

Public Class pharmaTransactions
    Dim pharmarepo As New PharmaRepository()
    Dim allTransactions As List(Of Transaction)
    Private Async Sub pharmaTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadAllTransactions()
    End Sub
    Public Async Function LoadAllTransactions() As Task
        flpTransaction.Controls.Clear()

        allTransactions = Await pharmarepo.GetAllTransactions()

        Dim batchSize As Integer = 5

        For i As Integer = 0 To allTransactions.Count - 1 Step batchSize
            Dim batch = allTransactions.Skip(i).Take(batchSize).ToList()

            DisplayTransactions(allTransactions)

            Await Task.Delay(50)
        Next

    End Function

    Private Async Sub transacidSearch_TextChanged(sender As Object, e As EventArgs) Handles transacidSearch.TextChanged
        Dim transacSearch As String = transacidSearch.Text

        If String.IsNullOrWhiteSpace(transacSearch) Then
            allTransactions = Await pharmarepo.GetAllTransactions()
        Else
            allTransactions = Await pharmarepo.SearchTransaction(transacSearch)
        End If
        If allTransactions IsNot Nothing Then
            DisplayTransactions(allTransactions)
        End If

    End Sub
    Private Sub DisplayTransactions(transactions As List(Of Transaction))
        flpTransaction.Controls.Clear()
        For Each indivTransac In transactions
            Dim usc As New pharmaTransacItem()
            usc.Initialize(indivTransac)
            flpTransaction.Controls.Add(usc)
        Next
    End Sub

    Private Async Sub sortBtn_Click(sender As Object, e As EventArgs) Handles sortBtn.Click
        If sortBtn.Text = "Ascending Date" Then
            sortBtn.Text = "Descending Date"
            allTransactions = Await pharmarepo.SortAscendingDate()
        ElseIf sortBtn.Text = "Descending Date" Then
            sortBtn.Text = "Ascending Date"
            allTransactions = Await pharmarepo.SortDescendingDate()
        End If
        DisplayTransactions(allTransactions)
    End Sub

End Class