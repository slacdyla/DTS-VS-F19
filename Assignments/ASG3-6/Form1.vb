'Dylan Slack
'RCET 0265
'asg 3-6
'Shipping Cost Calculator Program
'https://github.com/slacdyla/DTS-VS-F19.git

Public Class Form1
    Dim lbs As Double
    Dim oz As Double
    Dim Cost As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox2.Text = "" Then
            MessageBox.Show("Invalid Input. Please Input a Number")
            TextBox2.Select()
        End If
        If TextBox1.Text = "" Then
            MessageBox.Show("Invalid Input. Please Input a Number")
        End If
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            Try
            Catch a As Exception
                Console.WriteLine(a.Message)
                lbs = CDec(TextBox1.Text)
                oz = CDec(TextBox2.Text)
            End Try
        Else
            lbs = CDbl(TextBox1.Text)
            oz = CDbl(TextBox2.Text)
        End If
        Cost = ((lbs * 16) + oz) * 0.12
        TextBox4.Text = Cost.ToString("C")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub


End Class
