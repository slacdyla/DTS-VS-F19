Public Class Form1
    Dim numbers(15) As String


    Private Sub AssignArrayValues()
        numbers(0) = "Zero"
        numbers(1) = "One"
        numbers(2) = "Two"
        numbers(3) = "Three"
        numbers(4) = "Four"
        numbers(5) = "Five"
        numbers(6) = "Six"
        numbers(7) = "Seven"
        numbers(8) = "Eight"
        numbers(9) = "Nine"
        numbers(10) = "Ten"
        numbers(11) = "Eleven"
        numbers(12) = "Twelve"
        numbers(13) = "Thirteen"
        numbers(14) = "Fourteen"
        numbers(15) = "Fifteen"
    End Sub
    Private Function ShortandSweet(ByRef numberFromZeroToFifteen As Integer) As String

        AssignArrayValues()
        If numberFromZeroToFifteen > 15 Then
            Return "Number Is Too Large"
        ElseIf numberFromZeroToFifteen < 0 Then
            Return "Number is too small"
        Else
            Return "Your number is: " & numbers(numberFromZeroToFifteen)
        End If
    End Function

    'This is the working code from Sprints 1 and 2
    Private Function ValidateAndConvert(ByVal convertThisString As String, ByRef toThisInteger As Integer) As String
        Dim message As String = ""
        Try
            toThisInteger = CInt(convertThisString)
        Catch ex As Exception
            message = "Must contain a number"
            If convertThisString = "" Then message = "is empty"
        End Try
        Return message
    End Function
    'Do Not change this code other that comment/uncomment the lines indicated
    Private Sub GetUserInput() Handles Me.Load
        Me.Hide()
        Dim tempNum As Integer = 0
        Dim userMessage As String = "Please Enter A Number Between 0 and 15" _
        & vbNewLine & "Type Q to Quit"
        Do
            userMessage = InputBox(userMessage, "Hello", "")
            If userMessage <> "Q" And userMessage <> "" Then
                userMessage = ValidateAndConvert(userMessage, tempNum)
                'If userMessage = "" Then userMessage = IsWayTooLong(tempNum) 'Replace this Line
                If userMessage = "" Then userMessage = ShortandSweet(tempNum) 'With this one
            End If
        Loop Until userMessage = "Q" Or userMessage = ""
        Me.Close()
    End Sub

End Class
