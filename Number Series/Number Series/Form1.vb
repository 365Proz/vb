﻿Public Class Form1
    Dim generateNumber As Integer = 0

    Private Sub generateButton_Click(sender As Object, e As EventArgs) Handles generateButton.Click
        Dim i As Integer
        For i = 1 To 41 Step 8
            numberList.Items.Add(generateNumber)
            generateNumber += 1
        Next
    End Sub
End Class