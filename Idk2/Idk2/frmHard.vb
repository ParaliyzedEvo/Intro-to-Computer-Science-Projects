Public Class frmHard
    Private Sub frmHard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Establist the arrays
        pic = {pic1, pic2, pic3, pic4, pic5, pic6, pic7, pic8, pic9, pic10, pic11, pic12, pic13, pic14, pic15, pic16, pic17, pic18, pic19, pic20, pic21, pic22, pic23, pic24, pic25, pic26, pic27, pic28, pic29, pic30}
        btn = {btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10, btn11, btn12, btn13, btn14, btn15, btn16, btn17, btn18, btn19, btn20, btn21, btn22, btn23, btn24, btn25, btn26, btn27, btn28, btn29, btn30}
    End Sub

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        lblTimeCount.Text = ""
        'Make sure all buttons are visible
        For x = 0 To 29
            btn(x).Visible = True
        Next
        Call TotallyAwesomeNewGame()
        'Enable all buttons
        For x = 0 To 29
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
        If (btn1.Visible = False And btn2.Visible = False And btn3.Visible = False And btn4.Visible = False And btn5.Visible = False And btn6.Visible = False And btn7.Visible = False And btn8.Visible = False And btn9.Visible = False And btn10.Visible = False And btn11.Visible = False And btn12.Visible = False And btn13.Visible = False And btn14.Visible = False And btn15.Visible = False And btn16.Visible = False And btn17.Visible = False And btn18.Visible = False And btn19.Visible = False And btn20.Visible = False And btn21.Visible = False And btn22.Visible = False And btn23.Visible = False And btn24.Visible = False And btn25.Visible = False And btn26.Visible = False And btn27.Visible = False And btn28.Visible = False And btn29.Visible = False And btn30.Visible = False) Then
            tmrTimer.Enabled = False
            MsgBox("Congratulations! You won!")
            'Next level button only shows when win
            btnNextLevel.Visible = True
            'Add time to leaderboard
            lstLeaderboard.Items.Add("Time: " & lblTimeCount.Text)
        ElseIf lblTimeCount.Text = 40 Then
            tmrTimer.Enabled = False
            MsgBox("Game over!!!")
            'If person fails
            lstLeaderboard.Items.Add("Time: DNF")
            'Show all pictures
            For x = 0 To 29
                btn(x).Visible = False
            Next
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
    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        'On click, make the button invisible
        btn9.Visible = False
        'Logic for 2nd click and check for match
        If bolSecondClick = False Then
            intGuess1 = 8
            bolSecondClick = True
        Else
            intGuess2 = 8
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
    Private Sub btn10_Click(sender As Object, e As EventArgs) Handles btn10.Click
        'On click, make the button invisible
        btn10.Visible = False
        'Logic for 2nd click and check for match
        If bolSecondClick = False Then
            intGuess1 = 9
            bolSecondClick = True
        Else
            intGuess2 = 9
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
    Private Sub btn11_Click(sender As Object, e As EventArgs) Handles btn11.Click
        'On click, make the button invisible
        btn11.Visible = False
        'Logic for 2nd click and check for match
        If bolSecondClick = False Then
            intGuess1 = 10
            bolSecondClick = True
        Else
            intGuess2 = 10
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
    Private Sub btn12_Click(sender As Object, e As EventArgs) Handles btn12.Click
        'On click, make the button invisible
        btn12.Visible = False
        'Logic for 2nd click and check for match
        If bolSecondClick = False Then
            intGuess1 = 11
            bolSecondClick = True
        Else
            intGuess2 = 11
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
    Private Sub btn13_Click(sender As Object, e As EventArgs) Handles btn13.Click
        'On click, make the button invisible
        btn13.Visible = False
        'Logic for 2nd click and check for match
        If bolSecondClick = False Then
            intGuess1 = 12
            bolSecondClick = True
        Else
            intGuess2 = 12
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
    Private Sub btn14_Click(sender As Object, e As EventArgs) Handles btn14.Click
        'On click, make the button invisible
        btn14.Visible = False
        'Logic for 2nd click and check for match
        If bolSecondClick = False Then
            intGuess1 = 13
            bolSecondClick = True
        Else
            intGuess2 = 13
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
    Private Sub btn15_Click(sender As Object, e As EventArgs) Handles btn15.Click
        'On click, make the button invisible
        btn15.Visible = False
        'Logic for 2nd click and check for match
        If bolSecondClick = False Then
            intGuess1 = 14
            bolSecondClick = True
        Else
            intGuess2 = 14
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
    Private Sub btn16_Click(sender As Object, e As EventArgs) Handles btn16.Click
        'On click, make the button invisible
        btn16.Visible = False
        'Logic for 2nd click and check for match
        If bolSecondClick = False Then
            intGuess1 = 15
            bolSecondClick = True
        Else
            intGuess2 = 15
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
    Private Sub btn17_Click(sender As Object, e As EventArgs) Handles btn17.Click
        'On click, make the button invisible
        btn17.Visible = False
        'Logic for 2nd click and check for match
        If bolSecondClick = False Then
            intGuess1 = 16
            bolSecondClick = True
        Else
            intGuess2 = 16
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
    Private Sub btn18_Click(sender As Object, e As EventArgs) Handles btn18.Click
        'On click, make the button invisible
        btn18.Visible = False
        'Logic for 2nd click and check for match
        If bolSecondClick = False Then
            intGuess1 = 17
            bolSecondClick = True
        Else
            intGuess2 = 17
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
    Private Sub btn19_Click(sender As Object, e As EventArgs) Handles btn19.Click
        'On click, make the button invisible
        btn19.Visible = False
        'Logic for 2nd click and check for match
        If bolSecondClick = False Then
            intGuess1 = 18
            bolSecondClick = True
        Else
            intGuess2 = 18
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
    Private Sub btn20_Click(sender As Object, e As EventArgs) Handles btn20.Click
        'On click, make the button invisible
        btn20.Visible = False
        'Logic for 2nd click and check for match
        If bolSecondClick = False Then
            intGuess1 = 19
            bolSecondClick = True
        Else
            intGuess2 = 19
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
    Private Sub btn21_Click(sender As Object, e As EventArgs) Handles btn21.Click
        'On click, make the button invisible
        btn21.Visible = False
        'Logic for 2nd click and check for match
        If bolSecondClick = False Then
            intGuess1 = 20
            bolSecondClick = True
        Else
            intGuess2 = 20
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
    Private Sub btn22_Click(sender As Object, e As EventArgs) Handles btn22.Click
        'On click, make the button invisible
        btn22.Visible = False
        'Logic for 2nd click and check for match
        If bolSecondClick = False Then
            intGuess1 = 21
            bolSecondClick = True
        Else
            intGuess2 = 21
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
    Private Sub btn23_Click(sender As Object, e As EventArgs) Handles btn23.Click
        'On click, make the button invisible
        btn23.Visible = False
        'Logic for 2nd click and check for match
        If bolSecondClick = False Then
            intGuess1 = 22
            bolSecondClick = True
        Else
            intGuess2 = 22
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
    Private Sub btn24_Click(sender As Object, e As EventArgs) Handles btn24.Click
        'On click, make the button invisible
        btn24.Visible = False
        'Logic for 2nd click and check for match
        If bolSecondClick = False Then
            intGuess1 = 23
            bolSecondClick = True
        Else
            intGuess2 = 23
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
    Private Sub btn25_Click(sender As Object, e As EventArgs) Handles btn25.Click
        'On click, make the button invisible
        btn25.Visible = False
        'Logic for 2nd click and check for match
        If bolSecondClick = False Then
            intGuess1 = 24
            bolSecondClick = True
        Else
            intGuess2 = 24
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
    Private Sub btn26_Click(sender As Object, e As EventArgs) Handles btn26.Click
        'On click, make the button invisible
        btn26.Visible = False
        'Logic for 2nd click and check for match
        If bolSecondClick = False Then
            intGuess1 = 25
            bolSecondClick = True
        Else
            intGuess2 = 25
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
    Private Sub btn27_Click(sender As Object, e As EventArgs) Handles btn27.Click
        'On click, make the button invisible
        btn27.Visible = False
        'Logic for 2nd click and check for match
        If bolSecondClick = False Then
            intGuess1 = 26
            bolSecondClick = True
        Else
            intGuess2 = 26
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
    Private Sub btn28_Click(sender As Object, e As EventArgs) Handles btn28.Click
        'On click, make the button invisible
        btn28.Visible = False
        'Logic for 2nd click and check for match
        If bolSecondClick = False Then
            intGuess1 = 27
            bolSecondClick = True
        Else
            intGuess2 = 27
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
    Private Sub btn29_Click(sender As Object, e As EventArgs) Handles btn29.Click
        'On click, make the button invisible
        btn29.Visible = False
        'Logic for 2nd click and check for match
        If bolSecondClick = False Then
            intGuess1 = 28
            bolSecondClick = True
        Else
            intGuess2 = 28
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
    Private Sub btn30_Click(sender As Object, e As EventArgs) Handles btn30.Click
        'On click, make the button invisible
        btn30.Visible = False
        'Logic for 2nd click and check for match
        If bolSecondClick = False Then
            intGuess1 = 29
            bolSecondClick = True
        Else
            intGuess2 = 29
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
    Public intOriginal(29) As Integer
    Public intMixed(29) As Integer
    'Create object arrays for the game board
    Public pic(29) As PictureBox
    Public btn(29) As Button
    Public Sub TotallyAwesomeNewGame()
        'Mix up the pictures
        Call MixedPictures()
        'Display pictures
        pic(intMixed(0)).Image = Image.FromFile(Application.StartupPath & "\Pictures\Hard\Mrekk.jpg")
        pic(intMixed(1)).Image = Image.FromFile(Application.StartupPath & "\Pictures\Hard\Mrekk.jpg")
        pic(intMixed(2)).Image = Image.FromFile(Application.StartupPath & "\Pictures\Hard\Whitecat.jpg")
        pic(intMixed(3)).Image = Image.FromFile(Application.StartupPath & "\Pictures\Hard\Whitecat.jpg")
        pic(intMixed(4)).Image = Image.FromFile(Application.StartupPath & "\Pictures\Hard\BTMC.png")
        pic(intMixed(5)).Image = Image.FromFile(Application.StartupPath & "\Pictures\Hard\BTMC.png")
        pic(intMixed(6)).Image = Image.FromFile(Application.StartupPath & "\Pictures\Hard\Cookiezi.jpg")
        pic(intMixed(7)).Image = Image.FromFile(Application.StartupPath & "\Pictures\Hard\Cookiezi.jpg")
        pic(intMixed(8)).Image = Image.FromFile(Application.StartupPath & "\Pictures\Hard\Chicony.png")
        pic(intMixed(9)).Image = Image.FromFile(Application.StartupPath & "\Pictures\Hard\Chicony.png")
        pic(intMixed(10)).Image = Image.FromFile(Application.StartupPath & "\Pictures\Hard\Lifeline.png")
        pic(intMixed(11)).Image = Image.FromFile(Application.StartupPath & "\Pictures\Hard\Lifeline.png")
        pic(intMixed(12)).Image = Image.FromFile(Application.StartupPath & "\Pictures\Hard\Ryuk.jpg")
        pic(intMixed(13)).Image = Image.FromFile(Application.StartupPath & "\Pictures\Hard\Ryuk.jpg")
        pic(intMixed(14)).Image = Image.FromFile(Application.StartupPath & "\Pictures\Hard\Sytho.jpg")
        pic(intMixed(15)).Image = Image.FromFile(Application.StartupPath & "\Pictures\Hard\Sytho.jpg")
        pic(intMixed(16)).Image = Image.FromFile(Application.StartupPath & "\Pictures\Hard\Hugofrost.jpg")
        pic(intMixed(17)).Image = Image.FromFile(Application.StartupPath & "\Pictures\Hard\Hugofrost.jpg")
        pic(intMixed(18)).Image = Image.FromFile(Application.StartupPath & "\Pictures\Hard\Maliszewski.jpg")
        pic(intMixed(19)).Image = Image.FromFile(Application.StartupPath & "\Pictures\Hard\Maliszewski.jpg")
        pic(intMixed(20)).Image = Image.FromFile(Application.StartupPath & "\Pictures\Hard\Peppy.jpg")
        pic(intMixed(21)).Image = Image.FromFile(Application.StartupPath & "\Pictures\Hard\Peppy.jpg")
        pic(intMixed(22)).Image = Image.FromFile(Application.StartupPath & "\Pictures\Hard\Rafis.jpg")
        pic(intMixed(23)).Image = Image.FromFile(Application.StartupPath & "\Pictures\Hard\Rafis.jpg")
        pic(intMixed(24)).Image = Image.FromFile(Application.StartupPath & "\Pictures\Hard\Utami.jpg")
        pic(intMixed(25)).Image = Image.FromFile(Application.StartupPath & "\Pictures\Hard\Utami.jpg")
        pic(intMixed(26)).Image = Image.FromFile(Application.StartupPath & "\Pictures\Hard\Xootynator.jpg")
        pic(intMixed(27)).Image = Image.FromFile(Application.StartupPath & "\Pictures\Hard\Xootynator.jpg")
        pic(intMixed(28)).Image = Image.FromFile(Application.StartupPath & "\Pictures\Hard\Zylice.jpg")
        pic(intMixed(29)).Image = Image.FromFile(Application.StartupPath & "\Pictures\Hard\Zylice.jpg")
    End Sub
    Public Sub MixedPictures()
        For i = 0 To 29
            intMixed(i) = -1
            intOriginal(i) = i
        Next
        For i = 0 To 29
            CalcRandomSlot()
            intMixed(intRandomSlot) = intOriginal(i)
        Next
    End Sub
    Private Sub CalcRandomSlot()
        Randomize()
        Dim isSlotAvailable As Boolean = False
        intRandomSlot = -1
        While isSlotAvailable = False
            intRandomSlot = Int(Rnd() * 30)
            If intMixed(intRandomSlot) = -1 Then
                isSlotAvailable = True
            End If
        End While
    End Sub
    'Create a sub-routine to check if there is a match
    Public Sub CheckForMatch()
        For x = 0 To 28 Step 2
            If intGuess1 = intMixed(x) And intGuess2 = intMixed(x + 1) Or intGuess1 = intMixed(x + 1) And intGuess2 = intMixed(x) Then
                bolMatch = True
            End If
        Next
    End Sub
    'Onto next level
    Private Sub btnNextLevel_Click(sender As Object, e As EventArgs) Handles btnNextLevel.Click
        Me.Visible = False
        frmEasy.Visible = True
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
