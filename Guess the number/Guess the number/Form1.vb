''----------------------------------------365PROZ-----------------------------------------------------
''SUBSCRIBE to 365Proz: https://www.youtube.com/channel/UCFmrn9A48KM7p74nnsJlSPA?sub_confirmation=1
''----------------------------------------------------------------------------------------------------
Public Class Form1
    Dim guessNo As Integer
    Dim correctNo As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        correctNo = Int(Rnd() * 100) + 1
    End Sub

    Private Sub showNoButton_Click(sender As Object, e As EventArgs) Handles showNoButton.Click
        messageLabel.Text = correctNo
    End Sub

    Private Sub guessNoButton_Click(sender As Object, e As EventArgs) Handles guessNoButton.Click
        guessNo = Int(guessNoText.Text)

        If guessNo = correctNo Then
            messageLabel.Text = "Congratulations! you have guessed the correct number."
        ElseIf guessNo > correctNo Then
            messageLabel.Text = "Your number is too big."
        Else
            messageLabel.Text = "Your number is too small."
        End If
    End Sub
End Class
