Public Class frmSpaceInvaders
    Dim intPoints As Integer
    Private Sub frmSpaceInvaders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrLeft.Enabled = True
    End Sub

    Private Sub tmrLeft_Tick(sender As Object, e As EventArgs) Handles tmrLeft.Tick
        If picTarget1.Left > 10 Then
            picTarget1.Left = picTarget1.Left - 10
            picTarget2.Left = picTarget2.Left - 10
            picTarget3.Left = picTarget3.Left - 10
            picTarget4.Left = picTarget4.Left - 10
            picTarget5.Left = picTarget5.Left - 10
            picTarget6.Left = picTarget6.Left - 10
            picTarget7.Left = picTarget7.Left - 10
            picTarget8.Left = picTarget8.Left - 10
        Else
            tmrLeft.Enabled = False
            picTarget1.Top = picTarget1.Top + 10
            picTarget2.Top = picTarget2.Top + 10
            picTarget3.Top = picTarget3.Top + 10
            picTarget4.Top = picTarget4.Top + 10
            picTarget5.Top = picTarget5.Top + 10
            picTarget6.Top = picTarget6.Top + 10
            picTarget7.Top = picTarget7.Top + 10
            picTarget8.Top = picTarget8.Top + 10
            tmrRight.Enabled = True
        End If
        If picTarget5.Bounds.IntersectsWith(picShooter.Bounds) Or picTarget8.Bounds.IntersectsWith(picShooter.Bounds) Then
            MsgBox("You lose!")
            tmrLeft.Enabled = False
            tmrRight.Enabled = False
        End If
    End Sub

    Private Sub tmrRight_Tick(sender As Object, e As EventArgs) Handles tmrRight.Tick
        If picTarget4.Left + picTarget4.Width < Me.Width - 30 Then
            picTarget1.Left = picTarget1.Left + 10
            picTarget2.Left = picTarget2.Left + 10
            picTarget3.Left = picTarget3.Left + 10
            picTarget4.Left = picTarget4.Left + 10
            picTarget5.Left = picTarget5.Left + 10
            picTarget6.Left = picTarget6.Left + 10
            picTarget7.Left = picTarget7.Left + 10
            picTarget8.Left = picTarget8.Left + 10
        Else
            tmrRight.Enabled = False
            picTarget1.Top = picTarget1.Top + 10
            picTarget2.Top = picTarget2.Top + 10
            picTarget3.Top = picTarget3.Top + 10
            picTarget4.Top = picTarget4.Top + 10
            picTarget5.Top = picTarget5.Top + 10
            picTarget6.Top = picTarget6.Top + 10
            picTarget7.Top = picTarget7.Top + 10
            picTarget8.Top = picTarget8.Top + 10
            tmrLeft.Enabled = True
        End If
        If picTarget5.Bounds.IntersectsWith(picShooter.Bounds) Or picTarget8.Bounds.IntersectsWith(picShooter.Bounds) Or picTarget6.Bounds.IntersectsWith(picShooter.Bounds) Or picTarget7.Bounds.IntersectsWith(picShooter.Bounds) Then
            MsgBox("You lose!")
            tmrLeft.Enabled = False
            tmrRight.Enabled = False
        End If
    End Sub
    Private Sub frmSpaceInvaders_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Left
                If picShooter.Left > 10 Then
                    picShooter.Left = picShooter.Left - 5
                    picBullet.Left = picBullet.Left - 5
                End If
            Case Keys.Right
                If picShooter.Left + picShooter.Width < Me.Width - 50 Then
                    picShooter.Left = picShooter.Left + 5
                    picBullet.Left = picBullet.Left + 5
                End If
            Case Keys.Space
                tmrBullet.Enabled = True
        End Select
    End Sub

    Private Sub tmrBullet_Tick(sender As Object, e As EventArgs) Handles tmrBullet.Tick
        If picBullet.Top > 15 Then
            picBullet.Top = picBullet.Top - 50
            picBullet.Left = picBullet.Left + 0
        Else
            tmrBullet.Enabled = False
            picBullet.Top = picShooter.Top
            picBullet.Top = picShooter.Top - 50
        End If
        If picBullet.Bounds.IntersectsWith(picTarget1.Bounds) Then
            picTarget1.Top = -73
            intPoints = intPoints + 10
            lblNumberOfPoints.Text = intPoints
            tmrBullet.Enabled = False
            tmrResetTarget.Enabled = True
            'Bring snowball back
            picBullet.Top = picShooter.Top
            picBullet.Top = picShooter.Top - 50
            picTarget1.Visible = False
            If picTarget1.Visible = False And picTarget2.Visible = False And picTarget3.Visible = False And picTarget4.Visible = False And picTarget5.Visible = False And picTarget6.Visible = False And picTarget7.Visible = False And picTarget8.Visible = False Then
                MsgBox("Congratulations! You won!")
            End If
        End If
        If picBullet.Bounds.IntersectsWith(picTarget2.Bounds) Then
            picTarget2.Top = -73
            intPoints = intPoints + 20
            lblNumberOfPoints.Text = intPoints
            tmrBullet.Enabled = False
            tmrResetTarget.Enabled = True
            'Bring snowball back
            picBullet.Top = picShooter.Top
            picBullet.Top = picShooter.Top - 50
            picTarget2.Visible = False
            If picTarget1.Visible = False And picTarget2.Visible = False And picTarget3.Visible = False And picTarget4.Visible = False And picTarget5.Visible = False And picTarget6.Visible = False And picTarget7.Visible = False And picTarget8.Visible = False Then
                MsgBox("Congratulations! You won!")
            End If
        End If
        If picBullet.Bounds.IntersectsWith(picTarget3.Bounds) Then
            picTarget3.Top = -73
            intPoints = intPoints + 40
            lblNumberOfPoints.Text = intPoints
            tmrBullet.Enabled = False
            tmrResetTarget.Enabled = True
            'Bring snowball back
            picBullet.Top = picShooter.Top
            picBullet.Top = picShooter.Top - 50
            picTarget3.Visible = False
            If picTarget1.Visible = False And picTarget2.Visible = False And picTarget3.Visible = False And picTarget4.Visible = False And picTarget5.Visible = False And picTarget6.Visible = False And picTarget7.Visible = False And picTarget8.Visible = False Then
                MsgBox("Congratulations! You won!")
            End If
        End If
        If picBullet.Bounds.IntersectsWith(picTarget4.Bounds) Then
            picTarget4.Top = -73
            intPoints = intPoints + 100
            lblNumberOfPoints.Text = intPoints
            tmrBullet.Enabled = False
            tmrResetTarget.Enabled = True
            'Bring snowball back
            picBullet.Top = picShooter.Top
            picBullet.Top = picShooter.Top - 50
            picTarget4.Visible = False
            If picTarget1.Visible = False And picTarget2.Visible = False And picTarget3.Visible = False And picTarget4.Visible = False And picTarget5.Visible = False And picTarget6.Visible = False And picTarget7.Visible = False And picTarget8.Visible = False Then
                MsgBox("Congratulations! You won!")
            End If
        End If
        If picBullet.Bounds.IntersectsWith(picTarget5.Bounds) Then
            picTarget5.Top = -73
            intPoints = intPoints + 10
            lblNumberOfPoints.Text = intPoints
            tmrBullet.Enabled = False
            tmrResetTarget.Enabled = True
            'Bring snowball back
            picBullet.Top = picShooter.Top
            picBullet.Top = picShooter.Top - 50
            picTarget5.Visible = False
            If picTarget1.Visible = False And picTarget2.Visible = False And picTarget3.Visible = False And picTarget4.Visible = False And picTarget5.Visible = False And picTarget6.Visible = False And picTarget7.Visible = False And picTarget8.Visible = False Then
                MsgBox("Congratulations! You won!")
            End If
        End If
        If picBullet.Bounds.IntersectsWith(picTarget6.Bounds) Then
            picTarget6.Top = -73
            intPoints = intPoints + 20
            lblNumberOfPoints.Text = intPoints
            tmrBullet.Enabled = False
            tmrResetTarget.Enabled = True
            'Bring snowball back
            picBullet.Top = picShooter.Top
            picBullet.Top = picShooter.Top - 50
            picTarget6.Visible = False
            If picTarget1.Visible = False And picTarget2.Visible = False And picTarget3.Visible = False And picTarget4.Visible = False And picTarget5.Visible = False And picTarget6.Visible = False And picTarget7.Visible = False And picTarget8.Visible = False Then
                MsgBox("Congratulations! You won!")
            End If
        End If
        If picBullet.Bounds.IntersectsWith(picTarget7.Bounds) Then
            picTarget7.Top = -73
            intPoints = intPoints + 40
            lblNumberOfPoints.Text = intPoints
            tmrBullet.Enabled = False
            tmrResetTarget.Enabled = True
            'Bring snowball back
            picBullet.Top = picShooter.Top
            picBullet.Top = picShooter.Top - 50
            picTarget7.Visible = False
            If picTarget1.Visible = False And picTarget2.Visible = False And picTarget3.Visible = False And picTarget4.Visible = False And picTarget5.Visible = False And picTarget6.Visible = False And picTarget7.Visible = False And picTarget8.Visible = False Then
                MsgBox("Congratulations! You won!")
            End If
        End If
        If picBullet.Bounds.IntersectsWith(picTarget8.Bounds) Then
            picTarget8.Top = -73
            intPoints = intPoints + 100
            lblNumberOfPoints.Text = intPoints
            tmrBullet.Enabled = False
            tmrResetTarget.Enabled = True
            'Bring snowball back
            picBullet.Top = picShooter.Top
            picBullet.Top = picShooter.Top - 50
            picTarget8.Visible = False
            If picTarget1.Visible = False And picTarget2.Visible = False And picTarget3.Visible = False And picTarget4.Visible = False And picTarget5.Visible = False And picTarget6.Visible = False And picTarget7.Visible = False And picTarget8.Visible = False Then
                MsgBox("Congratulations! You won!")
            End If
        End If
    End Sub
End Class
