''----------------------------------------365PROZ-----------------------------------------------------
''SUBSCRIBE to 365Proz: https://www.youtube.com/channel/UCFmrn9A48KM7p74nnsJlSPA?sub_confirmation=1
''----------------------------------------------------------------------------------------------------
Public Class Form1
    Dim total As Integer = 0
    Dim rollNumber As Integer = 0
    Dim diceNumber As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles rollDice.Click
        diceNumber = Int(Rnd() * 6) + 1
        Do While diceNumber <> 2
            randomList.Items.Add(diceNumber)
            total = total + diceNumber
            diceNumber = Int(Rnd() * 6) + 1
            rollNumber += 1
        Loop
        rollNumber += 1
        ''randomList.Items.Add(diceNumber)
        diceRollLabel.Text = rollNumber
        totalScoreLabel.Text = total
    End Sub
End Class
