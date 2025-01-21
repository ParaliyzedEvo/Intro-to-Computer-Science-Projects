Public Class frmBirdFly
    Private Sub frmBirdFly_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Make image less choppy
        DoubleBuffered = True
    End Sub

    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        'Move the bird up
        picBird.Top = picBird.Top - 69
    End Sub

    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click
        'Move the bird down
        picBird.Top = picBird.Top + 69
    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        'Move the bird right
        picBird.Left = picBird.Left + 69
    End Sub

    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click
        'Move the bird left
        picBird.Left = picBird.Left - 69
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Reset the birds location
        picBird.Location = New Point(40, 358)
        'Reset the bird to its original size
        picBird.Size = New Size(200, 140)
    End Sub

    Private Sub tmrAutoFly_Tick(sender As Object, e As EventArgs) Handles tmrAutoFly.Tick
        If picBird.Top > 0 Then
            picBird.Top = picBird.Top - 10
            'Make the bird appear to be flying away
            picBird.Height = picBird.Height - 4
            picBird.Width = picBird.Width - 4
        End If
        If picBird.Left < Me.Width - picBird.Width - 30 Then
            picBird.Left = picBird.Left + 33
        Else
            tmrAutoFly.Enabled = False
        End If
    End Sub

    Private Sub btnAutoFly_Click(sender As Object, e As EventArgs) Handles btnAutoFly.Click
        tmrAutoFly.Enabled = True
    End Sub
End Class