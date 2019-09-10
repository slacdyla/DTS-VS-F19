'Assignment: Asg1-3
'RCET0265
'Dylan Slack
'Today's Specials
Public Class Form1
    Dim soup As String = "Ramen Noodle Water"
    Dim fish As String = "Bastoncini di Pesce"
    Dim chef As String = "Pizza Bagels"


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ChefButt.Click
        Specials.Text = chef


    End Sub

    Private Sub FishButt_Click(sender As Object, e As EventArgs) Handles FishButt.Click
        Specials.Text = fish
    End Sub

    Private Sub SoupButt_Click(sender As Object, e As EventArgs) Handles SoupButt.Click
        Specials.Text = soup
    End Sub

    Private Sub Specials_Click(sender As Object, e As EventArgs) Handles Specials.Click
        End
    End Sub
End Class
