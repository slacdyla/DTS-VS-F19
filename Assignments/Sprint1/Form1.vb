Public Class Form1


    Private Sub TestValidateAndConvert() Handles Me.Load
        Dim count As Integer = 0
        Dim result As Integer = 0
        Dim pad As Integer = 15
        Dim report As String = ""
        Dim temp As String = ""
        Dim testData = New String(4, 4) {
{"5", "2", "17", "8", "42"},
{"6.7", "3.14", "5.4", "5.5", "0.125"},
{"-21", "-32.1", "-4", "-4.5", "-4.4"},
{"", "", "", "", ""},
{"True", "False", "lOOlO", "9O2lO", "dog"}}
        For row = 0 To 4
            For column = 0 To 4
                result = 0
                temp = ValidateAndConvert(testData(row, column), result)
                report &= ("Trying: " & testData(row, column)).PadRight(pad)
                If row < 3 Then
                    If CStr(CInt(testData(row, column))) <> CStr(result) Or temp <> "" Then
                        report &= " TEST FAIL" & vbNewLine
                        report &= ("Result is: " & CStr(result)).PadRight(pad) & " : " & temp & vbNewLine
                        report &= ("Should be: " & CStr(CInt(testData(row, column)))).PadRight(pad) & " : " _
& "<Empty>" & vbNewLine
                    Else
                        report &= " TEST PASS" & vbNewLine
                        count += 1
                    End If
                ElseIf temp <> "is empty" And row = 3 Then
                    report &= " TEST FAIL" & vbNewLine
                    report &= ("Result is: " & CStr(result)).PadRight(pad) & " : " & temp & vbNewLine
                    report &= ("Should be: " & CStr(0)).PadRight(pad) & " : " & "is empty" & vbNewLine
                ElseIf temp <> "Must contain a number" And row > 3 Then
                    report &= " TEST FAIL" & vbNewLine
                    report &= ("Result is: " & CStr(result)).PadRight(pad) & " : " & temp & vbNewLine
                    report &= ("Should be: " & CStr(0)).PadRight(pad) & " : " & "Must contain a number" _
& vbNewLine
                Else
                    report &= " TEST PASS" & vbNewLine
                    count += 1
                End If
            Next
        Next
        Console.WriteLine(report & "Passed " & CStr(count) & " of 25 tests. Score: " _
& CStr((count / 25) * 100) & "%")
        MessageBox.Show("Passed " & CStr(count) & " of 25 tests. Score: " _
& CStr((count / 25) * 100) & "%")
    End Sub

    Private Function ValidateAndConvert(ByVal convertThisString As String, ByRef toThisInteger As Integer) As String

        If convertThisString = "" Then
            Try
                toThisInteger = Integer.Parse(convertThisString)
            Catch ex As Exception
                Console.WriteLine("Invalid Input. Input A String")
                Return False
            End Try
        ElseIf convertThisString = True Then

            Integer.TryParse(convertThisString, toThisInteger)
            Return True
        ElseIf convertThisString = False Then

            Integer.TryParse(convertThisString, toThisInteger)
            Return True
            '  ElseIf TypeOf convertThisString Is Byte Then
            '     Integer.TryParse(convertThisString, toThisInteger)
        Else
            toThisInteger = Integer.Parse(convertThisString)
            Return True
        End If
    End Function




End Class
