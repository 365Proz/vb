''----------------------------------------365PROZ-----------------------------------------------------
''SUBSCRIBE to 365Proz: https://www.youtube.com/channel/UCFmrn9A48KM7p74nnsJlSPA?sub_confirmation=1
''----------------------------------------------------------------------------------------------------
Public Class readLabel
    Private Sub readFromFileButton_Click(sender As Object, e As EventArgs) Handles readFromFileButton.Click
        Dim fileNum As Integer = FreeFile()
        Dim tempS As String = ""
        Dim tempL As String
        FileOpen(fileNum, "365Proz.txt", OpenMode.Input)
        Do Until EOF(fileNum)
            tempL = LineInput(fileNum)
            tempS += tempL + vbCrLf
        Loop
        FileClose(fileNum)
        TextBox1.Text = tempS
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        TextBox1.Clear()
    End Sub

    Private Sub writeToFileButton_Click(sender As Object, e As EventArgs) Handles writeToFileButton.Click
        Dim fileNum As Integer = FreeFile()
        FileOpen(fileNum, "365Proz.txt", OpenMode.Output)
        PrintLine(fileNum, TextBox1.Text)
        FileClose(fileNum)
    End Sub
End Class
