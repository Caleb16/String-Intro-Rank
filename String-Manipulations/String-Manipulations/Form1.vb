Public Class Form1

    Private Sub btnLetters_Click(sender As Object, e As EventArgs) Handles btnLetters.Click
        Dim strInput As String = Me.txtInput.Text

        If strInput.Length Mod 2 = 1 Then
            For intC As Integer = 0 To strInput.Length - 1
                If intC = 0 Then
                    Me.lblFirstLetter.Text = "First Letter: " & strInput.Chars(0)
                ElseIf intC = (strInput.Length - 1) / 2 Then
                    Me.lblMiddleLetter.Text = "Middle Letter: " & strInput.Chars(((strInput.Length - 1) / 2) + 0.5)
                ElseIf intC = strInput.Length - 1 Then
                    Me.lblLastLetter.Text = "Last Letter: " & strInput.Chars(strInput.Length - 1)
                End If
            Next intC

        ElseIf strInput.Length Mod 2 = 0 Then
            For intC As Integer = 0 To strInput.Length - 1
                If intC = 0 Then
                    Me.lblFirstLetter.Text = "First Letter: " & strInput.Chars(0)
                ElseIf intC = (strInput.Length) / 2 Then
                    Me.lblMiddleLetter.Text = "Middle Letter: " & strInput.Chars(((strInput.Length) / 2) - 1) & " and " & strInput.Chars((strInput.Length) / 2)
                ElseIf intC = strInput.Length - 1 Then
                    Me.lblLastLetter.Text = "Last Letter: " & strInput.Chars(strInput.Length - 1)
                End If
            Next intC
        End If
    End Sub

    Private Sub btnVandC_Click(sender As Object, e As EventArgs) Handles btnVandC.Click
        Dim strInput As String = Me.txtInput.Text
        Dim intVowelCounter As Integer = 0
        Dim intConsonantCounter As Integer = 0

        For intC As Integer = 0 To strInput.Length - 1
            Select Case strInput.Chars(intC)
                Case "A", "E", "I", "O", "U", "a", "e", "i", "o", "u"
                    intVowelCounter += 1
                Case Else
                    intConsonantCounter += 1
            End Select
        Next intC

        Me.lblResult.Text = "Consonant Vs. Vowel Count: " & vbCrLf & "Consonant Count: " & intConsonantCounter & vbCrLf & "Vowel Count: " & intVowelCounter
    End Sub
End Class
