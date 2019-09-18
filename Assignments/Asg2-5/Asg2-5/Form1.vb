Public Class Form1
    Dim First As String

    Dim Address1 As String
    Dim Address2 As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        First = TextBox1.Text & " " & TextBox2.Text

        Address1 = TextBox3.Text
        Address2 = TextBox4.Text & ", " & TextBox5.Text & ", " & TextBox6.Text


        Name1.Text = First
        Ad1.Text = Address1
        Ad2.Text = Address2
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        First = " "

        Address1 = " "
        Address2 = " "


        Name1.Text = First

        Ad1.Text = Address1
        Ad2.Text = Address2
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
