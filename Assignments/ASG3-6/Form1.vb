'Dylan Slack
'RCET 0265
'asg 3-6
'Shipping Cost Calculator Program
'https://github.com/slacdyla/DTS-VS-F19.git

Public Class Form1
    Dim lbs As Decimal
    Dim oz As Decimal
    Dim Cost As Decimal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            TextBox1.Text = "0"
        End If
        If TextBox2.Text = "" Then
            TextBox2.Text = "0"
        End If
        lbs = CDec(TextBox1.Text)
        oz = CDec(TextBox2.Text)
        Cost = ((lbs * 16) + oz) * 0.12
        TextBox4.Text = (Cost)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
