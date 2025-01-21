Public Class pongMain
#Region "Globals"
    Dim speed As Single = 30 ' Ball Speed
    Dim rndInst As New Random() ' Random instance
    Dim xVel As Single = Math.Cos(rndInst.Next(1, 5)) * speed
    Dim yVel As Single = Math.Sin(rndInst.Next(1, 5)) * speed

    ' The player's scores and wins.
    Dim compScore As Integer = 0
    Dim plrScore As Integer = 0
#End Region
#Region "Main Timer"
    Private Sub gameTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gameTimer.Tick
        If (compScore = 99 Or plrScore = 99) Then
            gameTimer.Stop()
            PlayWin()
            Dim msg As String = ""
            If compScore = 99 Then
                msg &= "Player 1 won!"
            Else
                msg &= "Player 2 won!"
            End If
            Dim result As Integer = MsgBox("Do you want to keep playing?", MsgBoxStyle.YesNo, msg)
            If result = DialogResult.No Then
                End
            ElseIf result = DialogResult.Yes Then
                Application.Restart()
            End If
        Else
            ' Move the game ball.
            gameBall.Location = New Point(gameBall.Location.X + xVel, gameBall.Location.Y + yVel)
            ' Check for top wall.
            If gameBall.Location.Y < 0 Then
                gameBall.Location = New Point(gameBall.Location.X, 0)
                yVel = -yVel
            End If
            ' Check for bottom wall.
            If gameBall.Location.Y > Me.Height - gameBall.Size.Height - 45 Then
                gameBall.Location = New Point(gameBall.Location.X, Me.Height - gameBall.Size.Height - 45)
                yVel = -yVel
            End If
            ' Check for left wall. If passes the paddle, add +1 to player 1.
            If gameBall.Location.X < 0 Then
                plrScore += 1
                gameBall.Location = New Point(Me.Size.Width / 2, Me.Size.Height / 2)
                plrScoreDraw.Text = Convert.ToString(plrScore)
                If (plrScore < 10) Then
                    plrScoreDraw.Text = "0" & plrScoreDraw.Text
                End If
                PlayBallOut()
            End If
            ' Check for right wall. If passes the paddle, add +1 to player 2.
            If gameBall.Location.X > Me.Width - gameBall.Size.Width - paddlePlayer.Width Then
                compScore += 1
                gameBall.Location = New Point(Me.Size.Width / 2, Me.Size.Height / 2)
                compScoreDraw.Text = Convert.ToString(compScore)
                If (compScore < 10) Then
                    compScoreDraw.Text = "0" & compScoreDraw.Text
                End If
                PlayBallOut()
            End If
            ' Check for player paddle.
            If gameBall.Bounds.IntersectsWith(paddlePlayer.Bounds) Then
                gameBall.Location = New Point(paddlePlayer.Location.X - gameBall.Size.Width,
                gameBall.Location.Y)
                xVel = -xVel
                PlayBallPong()
            End If
            ' Check for computer paddle.
            If gameBall.Bounds.IntersectsWith(paddleComputer.Bounds) Then
                gameBall.Location = New Point(paddleComputer.Location.X + paddleComputer.Size.Width + 1,
                gameBall.Location.Y)
                xVel = -xVel
                PlayBallPong()
            End If
        End If
    End Sub
#End Region
#Region "Play Sounds"
    Private Sub pongMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Song,
            AudioPlayMode.Background)
    End Sub
    Public Sub PlayBallOut()
        My.Computer.Audio.Play(My.Resources.ballout,
            AudioPlayMode.Background)
    End Sub

    Public Sub PlayBallPong()
        My.Computer.Audio.Play(My.Resources.ballpong,
            AudioPlayMode.Background)
    End Sub

    Public Sub PlayWin()
        My.Computer.Audio.Play(My.Resources.wincheer,
            AudioPlayMode.Background)
    End Sub
#End Region
#Region "KeyCommands"
    Private Sub computeKey(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'For W press
        If e.KeyCode = Keys.W Then
            Dim newPos As Integer = paddleComputer.Location.Y - 30
            If newPos > 5 And newPos < Me.Height - 40 - paddleComputer.Height Then
                paddleComputer.Location = New Point(paddleComputer.Location.X, newPos)
            End If
        End If
        'For S press
        If e.KeyCode = Keys.S Then
            Dim newPos As Integer = paddleComputer.Location.Y + 30
            If newPos > 5 And newPos < Me.Height - 40 - paddleComputer.Height Then
                paddleComputer.Location = New Point(paddleComputer.Location.X, newPos)
            End If
        End If
        'For Up press
        If e.KeyCode = Keys.Up Then
            Dim newPos As Integer = paddlePlayer.Location.Y - 30
            If newPos > 5 And newPos < Me.Height - 40 - paddlePlayer.Height Then
                paddlePlayer.Location = New Point(paddlePlayer.Location.X, newPos)
            End If
        End If
        'For Down press
        If e.KeyCode = Keys.Down Then
            Dim newPos As Integer = paddlePlayer.Location.Y + 30
            If newPos > 5 And newPos < Me.Height - 40 - paddlePlayer.Height Then
                paddlePlayer.Location = New Point(paddlePlayer.Location.X, newPos)
            End If
        End If
    End Sub
#End Region
End Class
