Public Class frmHawks
    Private Sub btnDisplayPicture_Click(sender As Object, e As EventArgs) Handles btnDisplayPicture.Click
        picDisplay.Visible = True
    End Sub

    Private Sub btnClearPicture_Click(sender As Object, e As EventArgs) Handles btnClearPicture.Click
        picDisplay.Visible = False
    End Sub

    Private Sub btnClearText_Click(sender As Object, e As EventArgs) Handles btnClearText.Click
        txtFullName.Text = " "
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        End
    End Sub
End Class
