Public Class btnEnd
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lblFact1.Visible = False
        picFact1.Visible = False
        lblFact2.Visible = False
        picFact2.Visible = False
        lblFact3.Visible = False
        picFact3.Visible = False
        lblFact4.Visible = False
        picFact4.Visible = False
        lblFact5.Visible = False
        picFact5.Visible = False
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btnFact1.Click
        lblFact1.Visible = True
        picFact1.Visible = True
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btnFact2.Click
        lblFact2.Visible = True
        picFact2.Visible = True
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btnFact3.Click
        lblFact3.Visible = True
        picFact3.Visible = True
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btnFact4.Click
        lblFact4.Visible = True
        picFact4.Visible = True
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btnFact5.Click
        lblFact5.Visible = True
        picFact5.Visible = True
    End Sub
End Class
