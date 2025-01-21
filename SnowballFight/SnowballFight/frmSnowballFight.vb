Public Class frmSnowballFight
    Dim intMissCounter As Integer
    Dim intHitCounter As Integer
    Private Sub frmSnowballFight_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrTargetUp.Enabled = True
    End Sub

    Private Sub tmrTargetUp_Tick(sender As Object, e As EventArgs) Handles tmrTargetUp.Tick
        If picTarget.Top > 10 Or PictureBox1.Top > 10 Then
            picTarget.Top = picTarget.Top - 10
            PictureBox1.Top = PictureBox1.Top - 10
        Else
            tmrTargetUp.Enabled = False
            tmrTargetDown.Enabled = True
        End If
    End Sub

    Private Sub tmrTargetDown_Tick(sender As Object, e As EventArgs) Handles tmrTargetDown.Tick
        If picTarget.Top + picTarget.Height < Me.Height - 50 Or PictureBox1.Top + PictureBox1.Height < Me.Height - 50 Then
            picTarget.Top = picTarget.Top + 10
            PictureBox1.Top = PictureBox1.Top + 10
        Else
            tmrTargetDown.Enabled = False
            tmrTargetUp.Enabled = True
        End If
    End Sub
    Private Sub frmSnowballFight_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                If picPenguin.Top > 10 Then
                    picPenguin.Top = picPenguin.Top - 5
                    picSnowball.Top = picSnowball.Top - 5
                End If
            Case Keys.Down
                If picPenguin.Top + picPenguin.Height < Me.Height - 50 Then
                    picPenguin.Top = picPenguin.Top + 5
                    picSnowball.Top = picSnowball.Top + 5
                End If
            Case Keys.Space
                tmrSnowball.Enabled = True
        End Select
    End Sub

    Private Sub tmrSnowball_Tick(sender As Object, e As EventArgs) Handles tmrSnowball.Tick
        If picSnowball.Left > 15 Then
            picSnowball.Left = picSnowball.Left - 50
            picSnowball.Top = picSnowball.Top + 5
        Else
            tmrSnowball.Enabled = False
            picSnowball.Left = picPenguin.Left
            picSnowball.Top = picPenguin.Top - 50
            intMissCounter = intMissCounter + 1
            lblNumberOfMisses.Text = intMissCounter
        End If
        If picSnowball.Bounds.IntersectsWith(picTarget.Bounds) Then
            'Target is hit
            picTarget.Image = Image.FromFile(Application.StartupPath & "\Pictures\Explosion.png")
            intHitCounter += 1
            lblNumberOfHits.Text = intHitCounter
            tmrSnowball.Enabled = False
            tmrResetTarget.Enabled = True
            'Bring snowball back
            picSnowball.Left = picPenguin.Left
            picSnowball.Top = picPenguin.Top
        End If
    End Sub

    Private Sub tmrResetTarget_Tick(sender As Object, e As EventArgs) Handles tmrResetTarget.Tick
        picTarget.Image = Image.FromFile(Application.StartupPath & "\Pictures\Target.jpg")
        tmrResetTarget.Enabled = False
    End Sub
End Class
