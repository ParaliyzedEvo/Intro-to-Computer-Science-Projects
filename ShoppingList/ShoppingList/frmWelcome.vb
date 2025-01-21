Public Class frmWelcome
    Private Sub GToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GToolStripMenuItem.Click
        'Close the welcome form
        Me.Visible = False
        'Load the groceries form
        frmGroceries.Visible = True

    End Sub
    Private Sub CheckoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckoutToolStripMenuItem.Click
        'Close the welcome form
        Me.Visible = False
        'Load the checkout form
        frmCheckout.Visible = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
End Class
