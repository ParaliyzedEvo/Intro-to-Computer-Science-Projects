Public Class frmEasy
    Private Sub frmEasy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Establist the arrays
        pic = {pic1, pic2, pic3, pic4, pic5, pic6, pic7, pic8}
        btn = {btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8}
    End Sub

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        lblTimeCount.Text = ""
        'Make sure all buttons are visible
        For x = 0 To 7
            btn(x).Visible = True
        Next
        Call TotallyAwesomeNewGame()
        'Enable all buttons
        For x = 0 To 7
            btn(x).Enabled = True
        Next
        tmrTimer.Enabled = True
    End Sub

    Private Sub tmrCoverPictures_Tick(sender As Object, e As EventArgs) Handles tmrCoverPictures.Tick
        btn(intGuess1).Visible = True
        btn(intGuess2).Visible = True
        bolSecondClick = False
        tmrCoverPictures.Enabled = False
    End Sub

    Private Sub tmrTimer_Tick(sender As Object, e As EventArgs) Handles tmrTimer.Tick
        lblTimeCount.Text = Val(lblTimeCount.Text) + 1
        If (btn1.Visible = False And btn2.Visible = False And btn3.Visible = False And btn4.Visible = False And btn5.Visible = False And btn6.Visible = False And btn7.Visible = False And btn8.Visible = False) Then
            tmrTimer.Enabled = False
            MsgBox("Congratulations! You won!")
            'Next level button only shows when win
            btnNextLevel.Visible = True
            'Add time to leaderboard
            lstLeaderboard.Items.Add("Time: " & lblTimeCount.Text)
        ElseIf lblTimeCount.Text = 10 Then
            tmrTimer.Enabled = False
            MsgBox("Game over!!!")
            'If person fails
            lstLeaderboard.Items.Add("Time: DNF")
        End If
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        'On click, make the button invisible
        btn1.Visible = False
        'Logic for 2nd click and check for match
        If bolSecondClick = False Then
            intGuess1 = 0
            bolSecondClick = True
        Else
            intGuess2 = 0
            Call CheckForMatch()
            'Program comes back after checks for match
            If bolMatch = True Then
                'There is a match!
            Else
                'No match, and we should cover up pictures again
                tmrCoverPictures.Enabled = True
            End If
            bolSecondClick = False
            bolMatch = False
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        'On click, make the button invisible
        btn2.Visible = False
        'Logic for 2nd click and check for match
        If bolSecondClick = False Then
            intGuess1 = 1
            bolSecondClick = True
        Else
            intGuess2 = 1
            Call CheckForMatch()
            'Program comes back after checks for match
            If bolMatch = True Then
                'There is a match!
            Else
                'No match, and we should cover up pictures again
                tmrCoverPictures.Enabled = True
            End If
            bolSecondClick = False
            bolMatch = False
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        'On click, make the button invisible
        btn3.Visible = False
        'Logic for 2nd click and check for match
        If bolSecondClick = False Then
            intGuess1 = 2
            bolSecondClick = True
        Else
            intGuess2 = 2
            Call CheckForMatch()
            'Program comes back after checks for match
            If bolMatch = True Then
                'There is a match!
            Else
                'No match, and we should cover up pictures again
                tmrCoverPictures.Enabled = True
            End If
            bolSecondClick = False
            bolMatch = False
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        'On click, make the button invisible
        btn4.Visible = False
        'Logic for 2nd click and check for match
        If bolSecondClick = False Then
            intGuess1 = 3
            bolSecondClick = True
        Else
            intGuess2 = 3
            Call CheckForMatch()
            'Program comes back after checks for match
            If bolMatch = True Then
                'There is a match!
            Else
                'No match, and we should cover up pictures again
                tmrCoverPictures.Enabled = True
            End If
            bolSecondClick = False
            bolMatch = False
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        'On click, make the button invisible
        btn5.Visible = False
        'Logic for 2nd click and check for match
        If bolSecondClick = False Then
            intGuess1 = 4
            bolSecondClick = True
        Else
            intGuess2 = 4
            Call CheckForMatch()
            'Program comes back after checks for match
            If bolMatch = True Then
                'There is a match!
            Else
                'No match, and we should cover up pictures again
                tmrCoverPictures.Enabled = True
            End If
            bolSecondClick = False
            bolMatch = False
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        'On click, make the button invisible
        btn6.Visible = False
        'Logic for 2nd click and check for match
        If bolSecondClick = False Then
            intGuess1 = 5
            bolSecondClick = True
        Else
            intGuess2 = 5
            Call CheckForMatch()
            'Program comes back after checks for match
            If bolMatch = True Then
                'There is a match!
            Else
                'No match, and we should cover up pictures again
                tmrCoverPictures.Enabled = True
            End If
            bolSecondClick = False
            bolMatch = False
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        'On click, make the button invisible
        btn7.Visible = False
        'Logic for 2nd click and check for match
        If bolSecondClick = False Then
            intGuess1 = 6
            bolSecondClick = True
        Else
            intGuess2 = 6
            Call CheckForMatch()
            'Program comes back after checks for match
            If bolMatch = True Then
                'There is a match!
            Else
                'No match, and we should cover up pictures again
                tmrCoverPictures.Enabled = True
            End If
            bolSecondClick = False
            bolMatch = False
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        'On click, make the button invisible
        btn8.Visible = False
        'Logic for 2nd click and check for match
        If bolSecondClick = False Then
            intGuess1 = 7
            bolSecondClick = True
        Else
            intGuess2 = 7
            Call CheckForMatch()
            'Program comes back after checks for match
            If bolMatch = True Then
                'There is a match!
            Else
                'No match, and we should cover up pictures again
                tmrCoverPictures.Enabled = True
            End If
            bolSecondClick = False
            bolMatch = False
        End If
    End Sub
    Public intOriginal(7) As Integer
    Public intMixed(7) As Integer
    'Create object arrays for the game board
    Public pic(7) As PictureBox
    Public btn(7) As Button
    Public Sub TotallyAwesomeNewGame()
        'Mix up the pictures
        Call MixedPictures()
        'Display pictures
        pic(intMixed(0)).Image = Image.FromFile(Application.StartupPath & "\Pictures\Easy\Mrekk.jpg")
        pic(intMixed(1)).Image = Image.FromFile(Application.StartupPath & "\Pictures\Easy\Mrekk.jpg")
        pic(intMixed(2)).Image = Image.FromFile(Application.StartupPath & "\Pictures\Easy\Whitecat.jpg")
        pic(intMixed(3)).Image = Image.FromFile(Application.StartupPath & "\Pictures\Easy\Whitecat.jpg")
        pic(intMixed(4)).Image = Image.FromFile(Application.StartupPath & "\Pictures\Easy\BTMC.png")
        pic(intMixed(5)).Image = Image.FromFile(Application.StartupPath & "\Pictures\Easy\BTMC.png")
        pic(intMixed(6)).Image = Image.FromFile(Application.StartupPath & "\Pictures\Easy\Cookiezi.jpg")
        pic(intMixed(7)).Image = Image.FromFile(Application.StartupPath & "\Pictures\Easy\Cookiezi.jpg")
    End Sub
    Public Sub MixedPictures()
        For i = 0 To 7
            intMixed(i) = -1
            intOriginal(i) = i
        Next
        For i = 0 To 7
            CalcRandomSlot()
            intMixed(intRandomSlot) = intOriginal(i)
        Next
    End Sub
    Private Sub CalcRandomSlot()
        Randomize()
        Dim isSlotAvailable As Boolean = False
        intRandomSlot = -1
        While isSlotAvailable = False
            intRandomSlot = Int(Rnd() * 8)
            If intMixed(intRandomSlot) = -1 Then
                isSlotAvailable = True
            End If
        End While
    End Sub
    'Create a sub-routine to check if there is a match
    Public Sub CheckForMatch()
        For x = 0 To 6 Step 2
            If intGuess1 = intMixed(x) And intGuess2 = intMixed(x + 1) Or intGuess1 = intMixed(x + 1) And intGuess2 = intMixed(x) Then
                bolMatch = True
            End If
        Next
    End Sub
    'Onto next level
    Private Sub btnNextLevel_Click(sender As Object, e As EventArgs) Handles btnNextLevel.Click
        Me.Visible = False
        frmMedium.Visible = True
    End Sub
    'Go back to welcome page
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Visible = False
        frmWelcome.Visible = True
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        End
    End Sub
End Class
