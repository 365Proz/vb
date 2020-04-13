''----------------------------------------365PROZ-----------------------------------------------------
''SUBSCRIBE to 365Proz: https://www.youtube.com/channel/UCFmrn9A48KM7p74nnsJlSPA?sub_confirmation=1
''----------------------------------------------------------------------------------------------------
Public Class Form1
    Dim generateNumber As Integer = 0
    Dim x1 As Integer = 0
    Dim d As Integer = 0
    Dim t As Integer = 0
    Private Sub generateButton_Click(sender As Object, e As EventArgs) Handles generateButton.Click
        ''Dim i As Integer
        Dim n As Integer
        x1 = fvTextBox.Text
        d = cdTextBox.Text
        t = termTextBox.Text
        ''For i = 1 To 41
        ''numberList.Items.Add(generateNumber)
        ''generateNumber += 1
        ''Next
        For n = 1 To t
            generateNumber = x1 + d * (n - 1)
            numberList.Items.Add(generateNumber)
        Next
    End Sub
End Class
