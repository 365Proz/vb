''----------------------------------------365PROZ-----------------------------------------------------
''SUBSCRIBE to 365Proz: https://www.youtube.com/channel/UCFmrn9A48KM7p74nnsJlSPA?sub_confirmation=1
''----------------------------------------------------------------------------------------------------
Public Class UserControl1
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub changeColour_Click(sender As Object, e As EventArgs) Handles changeColour.Click
        Me.BackColor = Color.Aquamarine

    End Sub

    Private Sub UserControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub titleLablel_Click(sender As Object, e As EventArgs) Handles titleLablel.Click

    End Sub

    Private Sub changeText_Click(sender As Object, e As EventArgs) Handles changeText.Click
        titleLablel.Text = "This is Great!"
    End Sub
End Class
