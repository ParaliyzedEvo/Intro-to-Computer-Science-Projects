Public Class frmStickman
    'Boolean variable for the progress bar
    Dim bolShowProgressBar As Boolean
    'Create integer variable to track the number of guesses
    Dim intGuessNumber As Integer

    Private Sub btnExpandContract_Click(sender As Object, e As EventArgs) Handles btnExpandContract.Click
        If bolShowProgressBar = False Then
            'Turn on tmtShowBar
            tmrShowBar.Enabled = True
            btnDrawBodyPart.Enabled = True
        Else
            tmrHideBar.Enabled = True
        End If
    End Sub

    Private Sub tmrShowBar_Tick(sender As Object, e As EventArgs) Handles tmrShowBar.Tick
        'The 585 is the expanded y-value
        If Me.Height < 585 Then
            Me.Height = Me.Height + 50
        Else
            tmrShowBar.Enabled = False
            bolShowProgressBar = True
            pbGuessesLeft.Value = 100
        End If
    End Sub

    Private Sub tmrHideBar_Tick(sender As Object, e As EventArgs) Handles tmrHideBar.Tick
        'The 498 is the contracted y-value
        If Me.Height > 498 Then
            Me.Height = Me.Height - 50
        Else
            tmrHideBar.Enabled = False
            bolShowProgressBar = False
        End If
    End Sub

    Private Sub btnDrawBodyPart_Click(sender As Object, e As EventArgs) Handles btnDrawBodyPart.Click
        intGuessNumber = intGuessNumber + 1
        'Depending on intGuessNumber, draw a body part
        Select Case intGuessNumber
            Case 1 'First time button is clicked
                picHead.Visible = True
                pbGuessesLeft.Value -= 17
            Case 2
                picBody.Visible = True
                pbGuessesLeft.Value -= 17
            Case 3
                picArmLeft.Visible = True
                pbGuessesLeft.Value -= 17
            Case 4
                picArmRight.Visible = True
                pbGuessesLeft.Value -= 17
            Case 5
                picLegLeft.Visible = True
                pbGuessesLeft.Value -= 17
            Case 6
                picLegRight.Visible = True
                pbGuessesLeft.Value = 0
                'Now that it's over make a popup box to tell you "You Lose!"
                Dim strPrompt1 As String
                strPrompt1 = "You Lose!"
                MsgBox(strPrompt1, MsgBoxStyle.Critical)
        End Select
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        End
    End Sub
End Class