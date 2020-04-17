Public Class Form1
    Dim itemName(3) As String
    Dim itemPrice(3) As Single

    Private Sub inputButton_Click(sender As Object, e As EventArgs) Handles inputButton.Click
        Dim i As Integer = 1
        For i = 1 To 3
            itemName(i) = InputBox("Item" & i & "Name", "Item Info", "")
            itemPrice(i) = InputBox("Item" & i & "Price", "Item Price", "")
            ListBox1.Items.Add(itemName(i) & ": $" & itemPrice(i))
        Next
    End Sub

    Private Sub increatePriceButton_Click(sender As Object, e As EventArgs) Handles increatePriceButton.Click
        ListBox1.Items.Clear()
        For i = 1 To 3
            itemPrice(i) = Math.Round(itemPrice(i) * 1.1, 2)
            ListBox1.Items.Add(itemName(i) & ": $" & itemPrice(i))
        Next
    End Sub
End Class
