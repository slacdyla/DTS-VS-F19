'Dylan Slack
'RCET 0265
'Asg 3-3
'Inventory Calculator Assignment

Public Class Form1
    Dim cost As Integer
    Dim average As Integer
    Dim beginning As Integer
    Dim endInventory As Integer



    Public Sub Clear(sender As Object, e As EventArgs) Handles Button2.Click

        costOfGoods.Text = ""
        Avg.Text = ""
        Beg.Text = ""
        nd.Text = ""
        Turn.Text = ""
    End Sub

    Private Sub closeform(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub Calculate(sender As Object, e As EventArgs) Handles Button1.Click
        If costOfGoods.Text = "" Then
            Try

            Catch ex As Exception
                cost = CInt(costOfGoods.Text)
            End Try
            MessageBox.Show("Invalid Input. Input Numeric Value")
            costOfGoods.Select()
            cost = 0
        Else cost = CInt(costOfGoods.Text)
        End If

        If nd.Text = "" Then
            Try

            Catch ex As Exception
                endInventory = CInt(nd.Text)

            End Try
            MessageBox.Show("Invalid Input. Input Numeric Value")
            nd.Select()
            endInventory = 0
        Else
            endInventory = CInt(nd.Text)
        End If
        If Beg.Text = "" Then

            Try

            Catch ex As Exception
                beginning = CInt(Beg.Text)
            End Try
            MessageBox.Show("Invalid Input. Input Numeric Value")
            Beg.Select()
            beginning = 0
        Else
            beginning = CInt(Beg.Text)
        End If

        Avg.Text = CStr((beginning + endInventory) / 2)
        average = CInt(Avg.Text)
        Turn.Text = CStr(CDbl(cost / average))
    End Sub
    Dim charactersAllowed As String = "1234567890"

    Private Sub begNumOnly(sender As Object, e As EventArgs) Handles Beg.TextChanged
        'Sets beg to Numeric Input Only
        Dim theText As String = Beg.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = Beg.SelectionStart
        Dim Change As Integer

        For x As Integer = 0 To Beg.Text.Length - 1
            Letter = Beg.Text.Substring(x, 1)
            If charactersAllowed.Contains(Letter) = False Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next

        Beg.Text = theText
        Beg.Select(SelectionIndex - Change, 0)
    End Sub

    Private Sub ndNumOnly(sender As Object, e As EventArgs) Handles nd.TextChanged
        'sets nd to numeric input only
        Dim theText As String = nd.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = nd.SelectionStart
        Dim Change As Integer

        For x As Integer = 0 To nd.Text.Length - 1
            Letter = nd.Text.Substring(x, 1)
            If charactersAllowed.Contains(Letter) = False Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next

        nd.Text = theText
        nd.Select(SelectionIndex - Change, 0)
    End Sub

    Private Sub costOfGoods_TextChanged(sender As Object, e As EventArgs) Handles costOfGoods.TextChanged
        'sets cost of goods to numeric input only
        Dim theText As String = costOfGoods.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = costOfGoods.SelectionStart
        Dim Change As Integer

        For x As Integer = 0 To costOfGoods.Text.Length - 1
            Letter = costOfGoods.Text.Substring(x, 1)
            If charactersAllowed.Contains(Letter) = False Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next

        costOfGoods.Text = theText
        costOfGoods.Select(SelectionIndex - Change, 0)
    End Sub
    Private Sub Beg_MouseHover(sender As Object, e As EventArgs) Handles Beg.MouseHover
        Me.BeginningTip.ShowAlways = True
        Me.BeginningTip.SetToolTip(Beg, "Enter Beginning Inventory")
    End Sub
    Private Sub End_MouseHover(sender As Object, e As EventArgs) Handles nd.MouseHover
        Me.EndingTip.ShowAlways = True
        Me.EndingTip.SetToolTip(nd, "Enter Ending Inventory")
    End Sub
    Private Sub CostOfGoods_MouseHover(sender As Object, e As EventArgs) Handles costOfGoods.MouseHover
        Me.CostTip.ShowAlways = True
        Me.CostTip.SetToolTip(costOfGoods, "Enter Cost Of Goods Sold")
    End Sub
    Private Sub Calculate_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Me.CalculateTip.ShowAlways = True
        Me.CalculateTip.SetToolTip(Button1, "Click Me to Calculate")
    End Sub
    Private Sub FormClear_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        Me.ClearTip.ShowAlways = True
        Me.ClearTip.SetToolTip(Button2, "Click Me to Clear the Form!")
    End Sub
    Private Sub Exit_MouseHover(sender As Object, e As EventArgs) Handles CancelButton.MouseHover
        Me.ExitTip.ShowAlways = True
        Me.ExitTip.SetToolTip(CancelButton, "Click Me to Close This Form!")
    End Sub
End Class