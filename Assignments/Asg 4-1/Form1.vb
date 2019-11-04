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
        y = y + 1
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
    Dim charactersAllowed As String = "1234567890"
    Private Sub Textbox4NumOnly(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Dim theText As String = TextBox4.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = TextBox4.SelectionStart
        Dim Change As Integer
        For x As Integer = 0 To TextBox4.Text.Length - 1
            Letter = TextBox4.Text.Substring(x, 1)
            If charactersAllowed.Contains(Letter) = False Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next
        TextBox4.Text = theText
        TextBox4.Select(SelectionIndex - Change, 0)
    End Sub
    Private Sub Textbox5NumOnly(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

        Dim theText As String = TextBox5.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = TextBox5.SelectionStart
        Dim Change As Integer
        For x As Integer = 0 To TextBox5.Text.Length - 1
            Letter = TextBox5.Text.Substring(x, 1)
            If charactersAllowed.Contains(Letter) = False Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next
        TextBox5.Text = theText
        TextBox5.Select(SelectionIndex - Change, 0)
    End Sub

    Private Sub TextBox6NumOnly(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        Dim theText As String = TextBox6.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = TextBox6.SelectionStart
        Dim Change As Integer
        For x As Integer = 0 To TextBox6.Text.Length - 1
            Letter = TextBox6.Text.Substring(x, 1)
            If charactersAllowed.Contains(Letter) = False Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next
        TextBox6.Text = theText
        TextBox6.Select(SelectionIndex - Change, 0)
    End Sub
End Class
