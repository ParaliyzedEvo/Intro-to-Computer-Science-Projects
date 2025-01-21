Imports System.Threading
Public Class frmAnimationProject

    Private Sub frmBirdFly_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Make image less choppy
        DoubleBuffered = True
    End Sub

    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click
        'Move Mario left
        picMario.Left = picMario.Left - 10
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        End
    End Sub

    Private Sub btnNextLevel_Click(sender As Object, e As EventArgs) Handles btnNextLevel.Click
        picBackground.Load(Application.StartupPath + "./Pictures/Background 2.png")
        'Reset Marios location
        picMario.Location = New Point(67, 423)
        'Reset Mario to its original size
        picMario.Size = New Size(100, 129)
        'Reset Background location
        picBackground.Location = New Point(-1, -382)
        tmrIdk.Enabled = False
    End Sub

    Private Sub btnPreviousLevel_Click(sender As Object, e As EventArgs) Handles btnPreviousLevel.Click
        picBackground.Load(Application.StartupPath + "./Pictures/Background 1.jpg")
        'Reset Marios location
        picMario.Location = New Point(67, 423)
        'Reset Mario to its original size
        picMario.Size = New Size(100, 129)
        'Reset Background location
        picBackground.Location = New Point(-1, -382)
        tmrIdk.Enabled = False
    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        'Move Mario right
        picMario.Left = picMario.Left + 10
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Reset Marios location
        picMario.Location = New Point(67, 423)
        'Reset Mario to its original size
        picMario.Size = New Size(100, 129)
        'Reset Background location
        picBackground.Location = New Point(-1, -382)
        tmrIdk.Enabled = False
    End Sub

    Private Sub btnBackgroundRight_Click(sender As Object, e As EventArgs) Handles btnBackgroundRight.Click
        'Move Background right
        picBackground.Left = picBackground.Left - 10
        'Make it so the background doesn't go off bounds
        If picBackground.Left <= -441 Then
            picBackground.Left = picBackground.Left + 10
        End If
    End Sub

    Private Sub btnBackgroundLeft_Click(sender As Object, e As EventArgs) Handles btnBackgroundLeft.Click
        'Move Background left
        picBackground.Left = picBackground.Left + 10
        'Make it so the background doesn't go off bounds
        If picBackground.Left >= 0 Then
            picBackground.Left = picBackground.Left - 10
        End If
    End Sub

    Private Sub btnJump_Click(sender As Object, e As EventArgs) Handles btnJump.Click
        'Mario Jump
        MarioJump()
    End Sub

    Private Sub btnFly_Click(sender As Object, e As EventArgs) Handles btnFly.Click
        tmrIdk.Enabled = True
    End Sub
    'Using keyboard to move Mario and Background
    Private Sub frmAnimationProject_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.D Then
            picMario.Left = picMario.Left + 10
        ElseIf e.KeyCode = Keys.A Then
            picMario.Left = picMario.Left - 10
        ElseIf e.KeyCode = Keys.Space Then
                'So the keyboard doesn't close the code
                e.Handled = True
                'Mario Jump
                MarioJump()
            ElseIf e.KeyCode = Keys.J Then
                e.Handled = True
                picBackground.Left = picBackground.Left + 10
                'Make it so the background doesn't go off bounds
                If picBackground.Left >= 0 Then
                    picBackground.Left = picBackground.Left - 10
                End If
            ElseIf e.KeyCode = Keys.L Then
                e.Handled = True
            picBackground.Left = picBackground.Left - 10
            'Make it so the background doesn't go off bounds
            If picBackground.Left <= -441 Then
                picBackground.Left = picBackground.Left + 10
            End If
        End If
    End Sub

    Private Sub MarioJump()
        Dim jumpHeight As Integer = 50
        Dim jumpStep As Integer = 5
        For i As Integer = 1 To jumpHeight Step jumpStep
            picMario.Top -= jumpStep
            'Refresh the form to update the UI
            Me.Refresh()
            Threading.Thread.Sleep(10)
        Next
        For i As Integer = 1 To jumpHeight Step jumpStep
            picMario.Top += jumpStep
            'Refresh the form to update the UI
            Me.Refresh()
            Threading.Thread.Sleep(10)
        Next
    End Sub

    Private Sub tmrIdk_Tick(sender As Object, e As EventArgs) Handles tmrIdk.Tick
        If picMario.Top > 0 Then
            picMario.Top = picMario.Top - 13
            picMario.Height = picMario.Height - 4
            picMario.Width = picMario.Width - 4
        Else
            tmrIdk.Enabled = False
        End If
        If picMario.Left < Me.Width - picMario.Width - 0 Then
            picMario.Left = picMario.Left + 50
        End If
    End Sub
End Class
