'Dylan Slack
'RCET 0265
'ASG 4-6
'Car Rental Service Form
'https://github.com/slacdyla/DTS-VS-F19


Public Class rentalForm
    Dim x As Integer
    Dim city As String
    Dim state As String
    Dim customer As String
    Dim address As String
    Dim total, discount1, discount2, charge, dayCharge, days, milecharge, totalMiles, endOdo, begOdo As Decimal



    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        x = x + 1
        summaryButton.Show()
        Thens()
        begOdo = CDec(beginOdometerTextBox.Text)
        endOdo = CDec(endOdometerTextBox.Text)
        totalMiles = endOdo - begOdo
        milesDrivenLabel.Text = CStr(totalMiles)
        days = CDec(daysTextBox.Text)
        city = cityTextBox.Text
        state = stateTextBox.Text
        customer = nameTextBox.Text
        milecharge = totalMiles * charge
        dayCharge = days * 15.0
        dayChargeLabel.Text = CStr(dayCharge)
        mileChargeLabel.Text = CStr(milecharge)
        If seniorCheckBox.Checked = True Then
            discount1 = 0.03
        ElseIf aaaCheckBox.Checked = True Then
            discount2 = 0.05
        Else
            discount1 = 0
            discount2 = 0
        End If
        discountLabel.Text = CStr((dayCharge + milecharge) * (discount1 + discount2))
        youOweLabel.Text = CStr((dayCharge + milecharge) - CDbl(discountLabel.Text))
    End Sub
    Sub Thens()
        If beginOdometerTextBox.Text = "" Or endOdometerTextBox.Text = "" Or daysTextBox.Text = "" Or cityTextBox.Text = "" Or stateTextBox.Text = "" Or nameTextBox.Text = "" Or addressTextBox.Text = "" Or zipCodeTextBox.Text = "" Then
            MessageBox.Show("All Fields Are Required!")
            beginOdometerTextBox.Text = "0"
            endOdometerTextBox.Text = "0"
            daysTextBox.Text = "0"
        End If
        If days > 45 Then
            MessageBox.Show("You Cannot Input any amount greater than 45 days!")
        End If
        If (totalMiles - 200) < 300 Then
            charge = 0.12
        ElseIf (totalMiles - 200) > 300 Then
            charge = 0.1
        End If
    End Sub
    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        nameTextBox.Clear()
        addressTextBox.Clear()
        cityTextBox.Clear()
        stateTextBox.Clear()
        zipCodeTextBox.Clear()
        beginOdometerTextBox.Clear()
        endOdometerTextBox.Clear()
        daysTextBox.Clear()
        dayChargeLabel.Text = ""
        youOweLabel.Text = ""
        discountLabel.Text = ""
        milesDrivenLabel.Text = ""
        mileChargeLabel.Text = ""
    End Sub

    Private Sub summaryButton_Click(sender As Object, e As EventArgs) Handles summaryButton.Click
        MessageBox.Show("Hello, " & customer & " you drove " & totalMiles & " miles in " & days & " days. " & (dayCharge + milecharge).ToString("C") & " will be charged to your credit card." &
" You are the " & x & " customer we've helped so far!")
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
    Dim charactersAllowed As String = "1234567890"

    Private Sub beginodometerNumOnly(sender As Object, e As EventArgs) Handles beginOdometerTextBox.TextChanged
        'Sets beginning odometer to Numeric Input Only
        Dim theText As String = beginOdometerTextBox.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = beginOdometerTextBox.SelectionStart
        Dim Change As Integer

        For x As Integer = 0 To beginOdometerTextBox.Text.Length - 1
            Letter = beginOdometerTextBox.Text.Substring(x, 1)
            If charactersAllowed.Contains(Letter) = False Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next

        beginOdometerTextBox.Text = theText
        beginOdometerTextBox.Select(SelectionIndex - Change, 0)
    End Sub

    Private Sub endodometerNumOnly(sender As Object, e As EventArgs) Handles endOdometerTextBox.TextChanged
        'Sets end odometer to Numeric Input Only
        Dim theText As String = endOdometerTextBox.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = endOdometerTextBox.SelectionStart
        Dim Change As Integer

        For x As Integer = 0 To endOdometerTextBox.Text.Length - 1
            Letter = endOdometerTextBox.Text.Substring(x, 1)
            If charactersAllowed.Contains(Letter) = False Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next

        endOdometerTextBox.Text = theText
        endOdometerTextBox.Select(SelectionIndex - Change, 0)
    End Sub


    Private Sub daysNumOnly(sender As Object, e As EventArgs) Handles daysTextBox.TextChanged
        'Sets beg to Numeric Input Only
        Dim theText As String = daysTextBox.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = daysTextBox.SelectionStart
        Dim Change As Integer

        For x As Integer = 0 To daysTextBox.Text.Length - 1
            Letter = daysTextBox.Text.Substring(x, 1)
            If charactersAllowed.Contains(Letter) = False Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next

        daysTextBox.Text = theText
        daysTextBox.Select(SelectionIndex - Change, 0)
    End Sub


End Class
