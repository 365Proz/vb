''----------------------------------------365PROZ-----------------------------------------------------
''SUBSCRIBE to 365Proz: https://www.youtube.com/channel/UCFmrn9A48KM7p74nnsJlSPA?sub_confirmation=1
''----------------------------------------------------------------------------------------------------
Public Class Form1
    Private Function fnWordCounter(ByVal Text As String) As Integer
        Dim letter As Char
        ''Dim tempString As String = ""
        Dim wordCount As Integer = 0
        Dim i As Integer

        If Text.Length > 0 Then
            For i = 0 To Text.Length - 1
                letter = Text.Chars(i)
                If letter = " " Then
                    wordCount += 1
                End If
            Next
            Return wordCount + 1
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(fnWordCounter(inputTextBox.Text))
    End Sub
End Class
