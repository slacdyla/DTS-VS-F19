'Dylan Slack
'RCET 0265
'Asg 7-1
'Stock Calculator
'https://github.com/slacdyla/DTS-VS-F19
Public Class Form1
    Dim monday, tuesday, wednesday, x, y, z As Decimal
    Dim charactersAllowed As String = "1234567890"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox4.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then

            Try
                monday = CDec(TextBox2.Text)
                tuesday = CDec(TextBox3.Text)
                wednesday = CDec(TextBox4.Text)
            Catch ex As Exception
                MessageBox.Show("Please input the proper data to the form")
                z = z - 1
            End Try
        Else
            monday = CDec(TextBox2.Text)
            tuesday = CDec(TextBox3.Text)
            wednesday = CDec(TextBox4.Text)
        End If
        If TextBox2.Text = "" Then
            TextBox2.Select()
        ElseIf TextBox3.Text = "" Then
            TextBox3.Select()
        ElseIf TextBox4.Text = "" Then
            TextBox4.Select()
        End If
        If monday > tuesday And tuesday > wednesday And wednesday - tuesday < tuesday - monday Then
            Label5.Text = "Sell"
            x = x + 1
        ElseIf monday < tuesday And tuesday < wednesday And wednesday - tuesday > tuesday - monday Then
            Label5.Text = "Buy"
            y = y + 1
        Else
            Label5.Text = "Hold"
            z = z + 1
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        Label5.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("Hello, Justine" & vbNewLine & "stock sold: " & x & vbNewLine & "stock bought: " & y & vbNewLine & "stock held: " & z)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub CalculateToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CalculateToolStripMenuItem1.Click
        Button1.PerformClick()
    End Sub

    Private Sub ClearToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem1.Click
        Button2.PerformClick()
    End Sub

    Private Sub SummaryToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SummaryToolStripMenuItem1.Click
        Button3.PerformClick()
    End Sub

    Private Sub CalculateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculateToolStripMenuItem.Click
        Button1.PerformClick()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        Button2.PerformClick()
    End Sub

    Private Sub SummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryToolStripMenuItem.Click
        Button3.PerformClick()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Stock Desiscion Maker Program" & vbNewLine & "Made By Dylan Slack")
    End Sub



    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Textbox2NumOnly(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

        Dim theText As String = TextBox2.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = TextBox2.SelectionStart
        Dim Change As Integer
        For x As Integer = 0 To TextBox2.Text.Length - 1
            Letter = TextBox2.Text.Substring(x, 1)
            If charactersAllowed.Contains(Letter) = False Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next
        TextBox2.Text = theText
        TextBox2.Select(SelectionIndex - Change, 0)
    End Sub

    Private Sub Textbox3NumOnly(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

        Dim theText As String = TextBox3.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = TextBox3.SelectionStart
        Dim Change As Integer
        For x As Integer = 0 To TextBox3.Text.Length - 1
            Letter = TextBox3.Text.Substring(x, 1)
            If charactersAllowed.Contains(Letter) = False Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next
        TextBox3.Text = theText
        TextBox3.Select(SelectionIndex - Change, 0)
    End Sub
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
    Private Sub StockName_MouseHover(sender As Object, e As EventArgs) Handles TextBox1.MouseHover
        Me.ToolTip1.ShowAlways = True
        Me.ToolTip1.SetToolTip(TextBox1, "Enter Stock Name")
    End Sub
    Private Sub PriceMon_MouseHover(sender As Object, e As EventArgs) Handles TextBox2.MouseHover
        Me.ToolTip2.ShowAlways = True
        Me.ToolTip2.SetToolTip(TextBox2, "Enter Price on Monday")
    End Sub
    Private Sub PriceTues_MouseHover(sender As Object, e As EventArgs) Handles TextBox3.MouseHover
        Me.ToolTip3.ShowAlways = True
        Me.ToolTip3.SetToolTip(TextBox3, "Enter Price Tuesday")
    End Sub
    Private Sub PriceWed_MouseHover(sender As Object, e As EventArgs) Handles TextBox4.MouseHover
        Me.ToolTip4.ShowAlways = True
        Me.ToolTip4.SetToolTip(TextBox4, "Enter Price Wednesday")
    End Sub
    Private Sub Calculate_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover, TextBox1.MouseHover
        Me.ToolTip5.ShowAlways = True
        Me.ToolTip5.SetToolTip(Button1, "Click Me to Calculate")
    End Sub
    Private Sub FormClear_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        Me.ToolTip6.ShowAlways = True
        Me.ToolTip6.SetToolTip(Button2, "Click Me to Clear the Form!")
    End Sub
    Private Sub Summary_MouseHover(sender As Object, e As EventArgs) Handles Button3.MouseHover
        Me.ToolTip7.ShowAlways = True
        Me.ToolTip7.SetToolTip(Button3, "Click Me for a Summary of Your Transactions!")
    End Sub
    Private Sub Exit_MouseHover(sender As Object, e As EventArgs) Handles Button4.MouseHover
        Me.ToolTip8.ShowAlways = True
        Me.ToolTip8.SetToolTip(CancelButton, "Click Me to Close This Form!")
    End Sub
End Class
