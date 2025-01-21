Public Class frmWelcome
    'Stuff to set before the forms load
    Private Sub btnEasy_Click(sender As Object, e As EventArgs) Handles btnEasy.Click
        Me.Visible = False
        frmEasy.Visible = True
        Randomize()
        dblNumber = Rnd()
        intRandomNumber = Int(dblNumber * 10 + 1)
    End Sub

    Private Sub btnHard_Click(sender As Object, e As EventArgs) Handles btnHard.Click
        Me.Visible = False
        frmHard.Visible = True
        Randomize()
        dblNumber = Rnd()
        intRandomNumber = Int(dblNumber * 100 + 1)
    End Sub

    Private Sub btnMedium_Click(sender As Object, e As EventArgs) Handles btnMedium.Click
        Me.Visible = False
        frmMedium.Visible = True
        Randomize()
        dblNumber = Rnd()
        intRandomNumber = Int(dblNumber * 50 + 1)
    End Sub
    'End
    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        End
    End Sub
End Class