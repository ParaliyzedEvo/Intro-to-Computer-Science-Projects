Public Class frmBoardGame
    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        End
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        picRisk1.Visible = False
        picRisk2.Visible = False
        picRisk3.Visible = False
        lblRisk.Visible = False
        lblCaption.Visible = False
        btnCaption.Visible = False
    End Sub

    Private Sub btnRisk_Click(sender As Object, e As EventArgs) Handles btnRisk.Click
        picRisk1.Visible = True
        picRisk2.Visible = True
        picRisk3.Visible = True
        lblRisk.Visible = True
        btnCaption.Visible = True
    End Sub

    Private Sub btnCaption_Click(sender As Object, e As EventArgs) Handles btnCaption.Click
        lblCaption.Visible = True
    End Sub
End Class
