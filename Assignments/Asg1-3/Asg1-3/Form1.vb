'Assignment: Asg1-3
'RCET0265
'Dylan Slack
'Wisdom Program


Public Class Form1
    Dim curWis As String
    Dim wisFour As String = "I Smell Like Beef"
    Dim wisThree As String = "In Case of Emergency, Break Glass"
    Dim wisTwo As String = "I am Beyonce, Always"
    Dim wisOne As String = "The Mitochondria is the powerhouse of the cell"

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles WisText.Click

    End Sub

    Private Sub WisBut_Click(sender As Object, e As EventArgs) Handles WisBut.Click

        WisText.Text = curWis

        If curWis = wisFour Then
            curWis = wisOne
        ElseIf curWis = wisOne Then
            curWis = wisTwo
        ElseIf curWis = wisTwo Then
            curWis = wisThree
        ElseIf curWis = wisThree Then
            curWis = wisFour
        Else
            curWis = wisOne
        End If




    End Sub

    Private Sub ExitButt_Click(sender As Object, e As EventArgs) Handles ExitButt.Click
        End

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
