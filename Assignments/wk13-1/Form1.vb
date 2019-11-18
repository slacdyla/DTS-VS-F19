Public Class RandomNum
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Initialize the random-number generator.
        Randomize()
        ' Generate random value between -10 and 10.
        Dim value1 As Integer = CInt(Math.Floor((10 - -10 + 1) * Rnd())) + -10
        Dim Value2 As Integer = CInt(Math.Floor((10 - -10 + 1) * Rnd())) + -10
        Dim Value3 As Integer = CInt(Math.Floor((10 - -10 + 1) * Rnd())) + -10
        Dim Value4 As Integer = CInt(Math.Floor((10 - -10 + 1) * Rnd())) + -10
        Dim Value5 As Integer = CInt(Math.Floor((10 - -10 + 1) * Rnd())) + -10
        Dim Value6 As Integer = CInt(Math.Floor((10 - -10 + 1) * Rnd())) + -10
        Dim Value7 As Integer = CInt(Math.Floor((10 - -10 + 1) * Rnd())) + -10
        Dim Value8 As Integer = CInt(Math.Floor((10 - -10 + 1) * Rnd())) + -10
        Dim Value9 As Integer = CInt(Math.Floor((10 - -10 + 1) * Rnd())) + -10
        Dim Value10 As Integer = CInt(Math.Floor((10 - -10 + 1) * Rnd())) + -10

        Numbers.Items.Add(value1)
        Numbers.Items.Add(Value2)
        Numbers.Items.Add(Value3)
        Numbers.Items.Add(Value4)
        Numbers.Items.Add(Value5)
        Numbers.Items.Add(Value6)
        Numbers.Items.Add(Value7)
        Numbers.Items.Add(Value8)
        Numbers.Items.Add(Value9)
        Numbers.Items.Add(Value10)
    End Sub
End Class
