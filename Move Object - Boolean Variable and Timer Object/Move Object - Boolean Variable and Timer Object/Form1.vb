''----------------------------------------365PROZ-----------------------------------------------------
''SUBSCRIBE to 365Proz: https://www.youtube.com/channel/UCFmrn9A48KM7p74nnsJlSPA?sub_confirmation=1
''----------------------------------------------------------------------------------------------------
Public Class Form1
    Dim moveRight As Boolean

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Right
                moveRight = True
            Case Keys.Left
                moveRight = False
        End Select
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If moveRight = True Then
            frogPicture.Left += 1
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class
