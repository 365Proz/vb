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
        Label1.Text = tempS
    End Sub


End Class
