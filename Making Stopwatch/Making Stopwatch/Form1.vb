''----------------------------------------365PROZ-----------------------------------------------------
''SUBSCRIBE to 365Proz: https://www.youtube.com/channel/UCFmrn9A48KM7p74nnsJlSPA?sub_confirmation=1
''----------------------------------------------------------------------------------------------------
Public Class Form1
    Dim numberOfSeconds As Integer = 0
    Dim numberOfWords As Integer = 0
    Dim typingSpeed As Double = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timerLabel.Text = numberOfSeconds
    End Sub

    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        Timer1.Start()
        TextBox1.Focus()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        numberOfSeconds += 1
        timerLabel.Text = numberOfSeconds
    End Sub

    Private Sub stopButton_Click(sender As Object, e As EventArgs) Handles stopButton.Click
        Timer1.Stop()
    End Sub

    Private Sub resetButton_Click(sender As Object, e As EventArgs) Handles resetButton.Click
        numberOfSeconds = 0
        typingSpeed = 0
        numberOfWords = 0
        timerLabel.Text = numberOfSeconds
        wordLabel.Text = numberOfWords
        speedLablel.Text = typingSpeed

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyValue
            Case Keys.Space
                numberOfWords += 1
                wordLabel.Text = numberOfWords
                typingSpeed = numberOfWords / numberOfSeconds * 60
                speedLablel.Text = typingSpeed
        End Select
    End Sub
End Class
