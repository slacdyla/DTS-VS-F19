Public Class Form1
    Dim cst As Integer
    Dim gva As Integer
    Dim geb As Integer
    Dim dne As Integer
    Dim nrut As Integer


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Cost.Text = ""
        Avg.Text = ""
        Beg.Text = ""
        nd.Text = ""
        Turn.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        cst = CInt(Cost.Text)
        geb = CInt(Beg.Text)
        dne = CInt(nd.Text)
        Avg.Text = CStr((geb + dne) / 2)
        gva = CInt(Avg.Text)
        Turn.Text = CStr(cst / gva)
        nrut = CInt(Turn.Text)
    End Sub
End Class
