''----------------------------------------365PROZ-----------------------------------------------------
''SUBSCRIBE to 365Proz: https://www.youtube.com/channel/UCFmrn9A48KM7p74nnsJlSPA?sub_confirmation=1
''----------------------------------------------------------------------------------------------------
Public Class textManagementForm
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim fileNum As Integer = FreeFile()
        Dim tempS As String = ""
        Dim tempL As String
        ofd1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        ofd1.Filter = "(*txt)|*.txt"
        ofd1.FilterIndex = 1
        ofd1.RestoreDirectory = True
        If (ofd1.ShowDialog() = DialogResult.OK) Then
            browse1.Text = ofd1.FileName
            FileOpen(fileNum, browse1.Text, OpenMode.Input)
            Do Until EOF(fileNum)
                tempL = LineInput(fileNum)
                tempS += tempL + vbCrLf
            Loop
            FileClose(fileNum)
            read2.Text = tempS
        Else
            browse1.Clear()
        End If

    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim fileNum As Integer = FreeFile()
        Dim tempS As String = ""
        Dim tempL As String
        ofd2.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        ofd2.Filter = "(*txt)|*.txt"
        ofd2.RestoreDirectory = True
        ofd2.FilterIndex = 1
        If (ofd2.ShowDialog() = DialogResult.OK) Then
            browse2.Text = ofd2.FileName
            FileOpen(fileNum, browse2.Text, OpenMode.Input)
            Do Until EOF(fileNum)
                tempL = LineInput(fileNum)
                tempS += tempL + vbCrLf
            Loop
            FileClose(fileNum)
            textBox2.Text = tempS
        Else
            browse2.Clear()
        End If
    End Sub

    Private Sub clear1_Click(sender As Object, e As EventArgs) Handles clear1.Click
        read2.Clear()
    End Sub

    Private Sub clear2_Click(sender As Object, e As EventArgs) Handles clear2.Click
        textBox2.Clear()
    End Sub

    Private Sub save1_Click(sender As Object, e As EventArgs) Handles save1.Click
        Dim fileNum As Integer = FreeFile()
        FileOpen(fileNum, browse1.Text, OpenMode.Output)
        PrintLine(fileNum, read2.Text)
        FileClose(fileNum)
    End Sub

    Private Sub save2_Click(sender As Object, e As EventArgs) Handles save2.Click
        Dim fileNum As Integer = FreeFile()
        FileOpen(fileNum, browse2.Text, OpenMode.Output)
        PrintLine(fileNum, textBox2.Text)
        FileClose(fileNum)
    End Sub

    Private Sub copy1_Click(sender As Object, e As EventArgs) Handles copy1.Click
        If read2.Text <> String.Empty Then
            Clipboard.SetText(read2.Text)
        Else
            Clipboard.Clear()
        End If
    End Sub

    Private Sub copy2_Click(sender As Object, e As EventArgs) Handles copy2.Click
        If textBox2.Text <> String.Empty Then
            Clipboard.SetText(textBox2.Text)
        Else
            Clipboard.Clear()
        End If
    End Sub

    Private Sub read1_Click(sender As Object, e As EventArgs) Handles read1.Click
        Dim fileNum As Integer = FreeFile()
        Dim tempS As String = ""
        Dim tempL As String
        FileOpen(fileNum, browse1.Text, OpenMode.Input)
        Do Until EOF(fileNum)
            tempL = LineInput(fileNum)
            tempS += tempL + vbCrLf
        Loop
        FileClose(fileNum)
        read2.Text = tempS
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim fileNum As Integer = FreeFile()
        Dim tempS As String = ""
        Dim tempL As String
        FileOpen(fileNum, browse2.Text, OpenMode.Input)
        Do Until EOF(fileNum)
            tempL = LineInput(fileNum)
            tempS += tempL + vbCrLf
        Loop
        FileClose(fileNum)
        textBox2.Text = tempS
    End Sub
End Class
