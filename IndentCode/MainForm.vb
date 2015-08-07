Imports System.Runtime.CompilerServices
Imports UsefulFunctions.Extensions

Public Class MainForm

    Dim Alinea As String = "    "

    Private Sub Indent_Click(sender As Object, e As EventArgs) Handles Indent.Click
        Try
            Dim Output As String = Nothing
            Dim Split() As String = TextToIndent.Lines
            For i = 0 To Split.Length.ZeroBased
                Output = String.Concat(Output, Split(i).Insert(0, Alinea), If(Not i = Split.Length - 1, vbNewLine, Nothing))
            Next
            TextToIndent.Text = Output
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DeIndent_Click(sender As Object, e As EventArgs) Handles DeIndent.Click
        Try
            Dim Output As String = Nothing
            Dim Split() As String = TextToIndent.Lines
            For i = 0 To Split.Length.ZeroBased
                Output = String.Concat(Output, If(Split(i).Contains(Alinea), Split(i).ReplaceFirst(Alinea, Nothing), Split(i)), If(Not i = Split.Length - 1, vbNewLine, Nothing))
            Next
            TextToIndent.Text = Output
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextToIndent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextToIndent.KeyPress
        If AscW(e.KeyChar) = 22 Then
            If Clipboard.ContainsText(TextDataFormat.Rtf) Then
                e.Handled = True
                TextToIndent.Undo()
                TextToIndent.SelectedText = Clipboard.GetText
            End If
        End If
    End Sub

    Private Sub Copy_Click(sender As Object, e As EventArgs) Handles Copy.Click
        Clipboard.SetText(TextToIndent.Text)
    End Sub

    Private Sub ClearTextBox_Click(sender As Object, e As EventArgs) Handles ClearTextBox.Click
        TextToIndent.Clear()
        TextToIndent.Focus()
    End Sub

    Private Sub CloseForm_Click(sender As Object, e As EventArgs) Handles CloseForm.Click
        Me.Close()
    End Sub

    Private Sub MainForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Buttons.Location = New Point((ClientSize.Width - Buttons.Width) \ 2, Buttons.Location.Y)
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextToIndent.Text = Clipboard.GetText()
    End Sub

End Class
