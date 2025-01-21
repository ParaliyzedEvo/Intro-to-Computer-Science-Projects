Public Class frmWelcome
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub RedBowlsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedBowlsToolStripMenuItem.Click
        Me.Visible = False
        frmBlackBowls.Visible = True
    End Sub

    Private Sub YellowBowlsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YellowBowlsToolStripMenuItem.Click
        Me.Visible = False
        frmBlueBowls.Visible = True
    End Sub

    Private Sub BlackBowlsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlackBowlsToolStripMenuItem.Click
        Me.Visible = False
        frmChineseBowls.Visible = True
    End Sub

    Private Sub WhiteBwolsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteBwolsToolStripMenuItem.Click
        Me.Visible = False
        frmRedBowls.Visible = True
    End Sub

    Private Sub SpecialBowlsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpecialBowlsToolStripMenuItem.Click
        Me.Visible = False
        frmWhiteBowls.Visible = True
    End Sub

    Private Sub TheSpecialBowlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TheSpecialBowlToolStripMenuItem.Click
        Me.Visible = False
        frmSpecialBowl.Visible = True
    End Sub

    Private Sub CheckoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckoutToolStripMenuItem.Click
        Me.Visible = False
        frmCheckout.Visible = True
    End Sub
End Class