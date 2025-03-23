Imports System.Globalization

Namespace Helpers
    ' Lahat ng may kinalaman sa user input na changes, dito ilagay
    Public Module HelperMethod

        Public Function CapitalizeEachFirstWord(input As String) As String
            Dim textInfo As TextInfo = CultureInfo.CurrentCulture.TextInfo
            Return textInfo.ToTitleCase(input)
        End Function

        Public Function RemoveComma(input As String) As String
            Dim commaExist As String = If(input.Contains(","), input.Substring(0, input.IndexOf(",")), input)
            Return commaExist
        End Function

        Public Function RemoveCommaAndCapitalizeWords(input As String) As String
            Return CapitalizeEachFirstWord(RemoveComma(input))
        End Function

        ' Pantawag sa KeyPress
        Public Sub KeyCode(e As KeyEventArgs, control As Control)
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                control.Focus()
            End If
        End Sub

        ' Pantawag sa ErrorProviders
        Public Sub Errors([error] As ErrorProvider, control As Control, button As Button, padding As Integer, message As String)
            [error].SetError(control, message)
            [error].SetIconPadding(control, padding)
            button.Enabled = True
        End Sub

        ' Turns the whole middle name into initials
        Public Function TurnMiddleNameToInitials(value As String) As String
            Return String.Concat(value.
                Split(New Char() {" "c, "."c}, StringSplitOptions.RemoveEmptyEntries).
                Where(Function(x) x.Length >= 1 AndAlso Char.IsLetter(x(0))).
                Select(Function(x) Char.ToUpper(x(0)) & "."))
        End Function

    End Module
End Namespace