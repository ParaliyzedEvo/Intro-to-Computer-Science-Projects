Public Class frmMedium
    'I want to preload all pictures as not visible
    Private Sub frmMedium_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblGuessesLeft2.Text = "3"
        picHead.Visible = False
        picBody.Visible = False
        picArmLeft.Visible = False
        picArmRight.Visible = False
        picLegLeft.Visible = False
        picLegRight.Visible = False
        pbGuessesleft.Value = 100
    End Sub

    Private Sub btnShowNumber_Click(sender As Object, e As EventArgs) Handles btnShowNumber.Click
        txtShowNumber.Text = intRandomNumber
    End Sub
    'When the number is too high
    Private Sub btnGuess_Click(sender As Object, e As EventArgs) Handles btnGuess.Click
        If txtGuess.Text = intRandomNumber Then
            MsgBox("Correct!")
        ElseIf txtGuess.Text > 50 Or txtGuess.Text < 1 Then
            MsgBox("Out of Range! Choose a number between 1 and 50!")
            txtGuess.Text = ""
        ElseIf txtGuess.Text > intRandomNumber Then
            lstPreviousGuesses.Items.Add(txtGuess.Text & " is too high")
            intNumberBodyParts = intNumberBodyParts + 1
            Select Case intNumberBodyParts
                Case 1
                    picHead.Visible = True
                    picBody.Visible = True
                    pbGuessesleft.Value = pbGuessesleft.Value - 33
                    lblGuessesLeft2.Text = 2
                    txtGuess.Text = ""
                Case 2
                    picArmLeft.Visible = True
                    picArmRight.Visible = True
                    pbGuessesleft.Value = pbGuessesleft.Value - 33
                    lblGuessesLeft2.Text = 1
                    txtGuess.Text = ""
                Case 3
                    picLegLeft.Visible = True
                    picLegRight.Visible = True
                    pbGuessesleft.Value = 0
                    lblGuessesLeft2.Text = 0
                    txtGuess.Text = ""
                    MsgBox("You Lose! The answer was " & intRandomNumber & ".")
            End Select
            'When the number is too low
        ElseIf txtGuess.Text < intRandomNumber Then
            lstPreviousGuesses.Items.Add(txtGuess.Text & " is too low!")
            intNumberBodyParts = intNumberBodyParts + 1
            Select Case intNumberBodyParts
                Case 1
                    picHead.Visible = True
                    picBody.Visible = True
                    pbGuessesleft.Value = pbGuessesleft.Value - 33
                    lblGuessesLeft2.Text = 2
                    txtGuess.Text = ""
                Case 2
                    picArmLeft.Visible = True
                    picArmRight.Visible = True
                    pbGuessesleft.Value = pbGuessesleft.Value - 33
                    lblGuessesLeft2.Text = 1
                    txtGuess.Text = ""
                Case 3
                    picLegLeft.Visible = True
                    picLegRight.Visible = True
                    pbGuessesleft.Value = 0
                    lblGuessesLeft2.Text = 0
                    txtGuess.Text = ""
                    MsgBox("You Lose! The answer was " & intRandomNumber & ".")
            End Select
        End If
    End Sub
    'When you press the directions button
    Private Sub btnDirections_Click(sender As Object, e As EventArgs) Handles btnDirections.Click
        If bolShowDirections = False Then
            tmrShowDirections.Enabled = True
        Else
            tmrHideDirections.Enabled = True
        End If
    End Sub
    'Show directions
    Private Sub tmrShowDirections_Tick(sender As Object, e As EventArgs) Handles tmrShowDirections.Tick
        If Me.Height < 572 Then
            Me.Height = Me.Height + 15
        Else
            tmrShowDirections.Enabled = False
            bolShowDirections = True
        End If
    End Sub
    'Hide directions
    Private Sub tmrHideDirections_Tick(sender As Object, e As EventArgs) Handles tmrHideDirections.Tick
        If Me.Height > 498 Then
            Me.Height = Me.Height - 15
        Else
            tmrHideDirections.Enabled = False
            bolShowDirections = False
        End If
    End Sub
    'Reset everything on the form
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Randomize()
        dblNumber = Rnd()
        intRandomNumber = Int(dblNumber * 50) + 1
        tmrHideDirections.Enabled = True
        txtGuess.Text = ""
        txtShowNumber.Text = ""
        lstPreviousGuesses.Items.Clear()
        picHead.Visible = False
        picBody.Visible = False
        picArmLeft.Visible = False
        picArmRight.Visible = False
        picLegLeft.Visible = False
        picLegRight.Visible = False
        pbGuessesleft.Value = 100
        lblGuessesLeft2.Text = 3
        intNumberBodyParts = 0
    End Sub
    'Go back to welcome page
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Application.Restart()
    End Sub
    'End
    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        End
    End Sub
End Class