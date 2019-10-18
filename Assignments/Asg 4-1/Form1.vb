Public Class Form1
    'Dylan Slack
    'RCET 0265
    'Asg 4-1
    'Calculator Program
    Dim user As String
    Dim age As String
    Dim grade As String
    Dim numOne As Decimal
    Dim numTwo As Decimal
    Dim result As Decimal
    Dim x As Integer
    Dim y As Integer

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox4.Text = "" Then
            TextBox4.Text = "0"
        End If
        If TextBox5.Text = "" Then
            TextBox5.Text = "0"
        End If
        If TextBox6.Text = "" Then
            TextBox6.Text = "0"
        End If

        numOne = CDec(TextBox4.Text)
        numTwo = CDec(TextBox5.Text)
        If RadioButton1.Checked Then
            result = (numOne + numTwo)
        End If
        If RadioButton2.Checked Then
            result = (numOne - numTwo)
        End If
        If RadioButton3.Checked Then
            result = (numOne * numTwo)
        End If
        If RadioButton4.Checked Then
            result = (numOne / numTwo)
        End If
        If result = CDec(TextBox6.Text) Then
            x = x + 1
        End If
        TextBox7.Text = CStr(x)
        y = y + 1

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        user = TextBox1.Text
        age = TextBox2.Text
        grade = TextBox3.Text
        MessageBox.Show(user & ", age " & age & ", grade " & grade & " has scored " & CStr(x) & " out of " & CStr(y) & " points.")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
    End Sub
End Class
