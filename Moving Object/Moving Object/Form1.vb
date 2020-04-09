Public Class Form1

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Right
                frogPicture.Left += 5
            Case Keys.Left
                frogPicture.Left -= 5
            Case Keys.Up
                frogPicture.Top -= 5
            Case Keys.Down
                frogPicture.Top += 5
        End Select
    End Sub
End Class
