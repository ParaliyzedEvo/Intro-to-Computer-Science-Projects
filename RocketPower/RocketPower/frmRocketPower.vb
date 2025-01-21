Public Class frmRocketPower
    Private Sub frmRocketPower_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DoubleBuffered = True
    End Sub
    Private Sub btnStartEngines_Click(sender As Object, e As EventArgs) Handles btnStartEngines.Click
        picFire.Visible = True
        picFire.Load(Application.StartupPath + "./Pictures/Fire.gif")
    End Sub

    Private Sub btnTakeOff_Click(sender As Object, e As EventArgs) Handles btnTakeOff.Click
        tmrTakeOff.Enabled = True
    End Sub

    Private Sub tmrTakeOff_Tick(sender As Object, e As EventArgs) Handles tmrTakeOff.Tick
        picFire.Load(Application.StartupPath + "./Pictures/Smoke.gif")
        'Lets make this rocket fly
        If picRocket.Top > 0 Then
            picRocket.Top = picRocket.Top - 10
            picFire.Top = picFire.Top - 17

            'Make the rocket appear like its flying away and getting smaller
            picRocket.Height = picRocket.Height - 10
            picRocket.Width = picRocket.Width - 10
            picFire.Height = picFire.Height - 7
            picFire.Width = picFire.Width - 7
        Else
            tmrTakeOff.Enabled = False
        End If
        If picRocket.Left < Me.Width - picRocket.Width - 50 Then
            picRocket.Left = picRocket.Left + 19
            picFire.Left = picFire.Left + 17
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        tmrTakeOff.Enabled = False
        picRocket.Location = New Point(12, 230)
        picFire.Location = New Point(43, 381)
        picRocket.Size = New Point(166, 187)
        picFire.Size = New Point(100, 101)
        picFire.Load(Application.StartupPath + "./Pictures/Fire.gif")
    End Sub
End Class
