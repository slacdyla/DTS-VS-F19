Public Class Form1
    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup
        ToolTip1.SetToolTip(Button2, "I Mean It. Don't Click Me.")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Text = "I Said No Click"
        Me.Text = "Hehehehehe"
        Me.BackColor = Color.Red
        Me.BackgroundImage = Image.FromFile( As String)
    End Sub
End Class