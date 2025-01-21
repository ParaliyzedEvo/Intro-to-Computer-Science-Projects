Public Class frmEasy
    'I want to preload all pictures as not visible
    Private Sub frmEasy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblGuessesLeft2.Text = "6"
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

    Private Sub btnGuess_Click(sender As Object, e As EventArgs) Handles btnGuess.Click
        If txtGuess.Text = intRandomNumber Then
            MsgBox("Correct!")
        ElseIf txtGuess.Text > 10 Or txtGuess.Text < 1 Then
            MsgBox("Out of Range! Choose a number between 1 and 10!")
            txtGuess.Text = " "
        ElseIf txtGuess.Text > intRandomNumber Then
            lstPreviousGuesses.Items.Add(txtGuess.Text & " is too high")
            intNumberBodyParts = intNumberBodyParts + 1
            Select Case intNumberBodyParts
                Case 1
                    picHead.Visible = True
                    pbGuessesleft.Value = pbGuessesleft.Value - 17
                    lblGuessesLeft2.Text = 5
                    txtGuess.Text = ""
                Case 2
                    picBody.Visible = True
                    pbGuessesleft.Value = pbGuessesleft.Value - 17
                    lblGuessesLeft2.Text = 4
                    txtGuess.Text = ""
                Case 3
                    picArmLeft.Visible = True
                    pbGuessesleft.Value = pbGuessesleft.Value - 17
                    lblGuessesLeft2.Text = 3
                    txtGuess.Text = ""
                Case 4
                    picArmRight.Visible = True
                    pbGuessesleft.Value = pbGuessesleft.Value - 17
                    lblGuessesLeft2.Text = 2
                    txtGuess.Text = ""
                Case 5
                    picLegLeft.Visible = True
                    pbGuessesleft.Value = pbGuessesleft.Value - 17
                    lblGuessesLeft2.Text = 1
                    txtGuess.Text = ""
                Case 6
                    picLegRight.Visible = True
                    pbGuessesleft.Value = 0
                    lblGuessesLeft2.Text = 0
                    txtGuess.Text = ""
                    MsgBox("You Lose! The answer was " & intRandomNumber & ".")
            End Select
        ElseIf txtGuess.Text < intRandomNumber Then
            lstPreviousGuesses.Items.Add(txtGuess.Text & " is too low!")
            intNumberBodyParts = intNumberBodyParts + 1
            Select Case intNumberBodyParts
                Case 1
                    picHead.Visible = True
                    pbGuessesleft.Value = pbGuessesleft.Value - 17
                    lblGuessesLeft2.Text = 5
                    txtGuess.Text = ""
                Case 2
                    picBody.Visible = True
                    pbGuessesleft.Value = pbGuessesleft.Value - 17
                    lblGuessesLeft2.Text = 4
                    txtGuess.Text = ""
                Case 3
                    picArmLeft.Visible = True
                    pbGuessesleft.Value = pbGuessesleft.Value - 17
                    lblGuessesLeft2.Text = 3
                    txtGuess.Text = " "
                Case 4
                    picArmRight.Visible = True
                    pbGuessesleft.Value = pbGuessesleft.Value - 17
                    lblGuessesLeft2.Text = 2
                    txtGuess.Text = " "
                Case 5
                    picLegLeft.Visible = True
                    pbGuessesleft.Value = pbGuessesleft.Value - 17
                    lblGuessesLeft2.Text = 1
                    txtGuess.Text = " "
                Case 6
                    picLegRight.Visible = True
                    pbGuessesleft.Value = 0
                    lblGuessesLeft2.Text = 0
                    txtGuess.Text = ""
                    MsgBox("You Lose! The answer was " & intRandomNumber & ".")
            End Select
        End If
    End Sub

    Private Sub btnDirections_Click(sender As Object, e As EventArgs) Handles btnDirections.Click
        If bolShowDirections = False Then
            tmrShowDirections.Enabled = True
        Else
            tmrHideDirections.Enabled = True
        End If
    End Sub

    Private Sub tmrShowDirections_Tick(sender As Object, e As EventArgs) Handles tmrShowDirections.Tick
        If Me.Height < 572 Then
            Me.Height = Me.Height + 15
        Else
            tmrShowDirections.Enabled = False
            bolShowDirections = True
        End If
    End Sub

    Private Sub tmrHideDirections_Tick(sender As Object, e As EventArgs) Handles tmrHideDirections.Tick
        If Me.Height > 498 Then
            Me.Height = Me.Height - 15
        Else
            tmrHideDirections.Enabled = False
            bolShowDirections = False
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Randomize()
        dblNumber = Rnd()
        intRandomNumber = Int(dblNumber * 10) + 1
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
        lblGuessesLeft2.Text = 6
        intNumberBodyParts = 0
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Application.Restart()
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        End
    End Sub
End Class