Public Class FrmFavorites
    Private Sub btnFood_Click(sender As Object, e As EventArgs) Handles btnFood.Click
        picFood.Visible = True
        lblFood.Visible = True
    End Sub

    Private Sub btnAnimal_Click(sender As Object, e As EventArgs) Handles btnAnimal.Click
        picAnimal.Visible = True
        lblAnimal.Visible = True
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        picFood.Visible = False
        lblFood.Visible = False
        picAnimal.Visible = False
        lblAnimal.Visible = False
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        End
    End Sub
End Class