Public Class Form1
    Dim dice(1, 9999) As Integer
    Dim x As Integer
    Dim y As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        While x < 10000
            dice(0, x) = CInt(Math.Floor((6 - 1 + 1) * Rnd())) + 1

        dice(1, y) = CInt(Math.Floor((6 - 1 + 1) * Rnd())) + 1
        Rolls.Items.Add(dice(0, x) + dice(1, y))
        x += 1
            y += 1
        End While
        x = 0
        y = 0
    End Sub
End Class
