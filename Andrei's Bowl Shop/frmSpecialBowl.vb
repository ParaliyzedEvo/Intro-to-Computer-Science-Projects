Public Class frmSpecialBowl
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub picSpecialBowl_Click(sender As Object, e As EventArgs) Handles picSpecialBowl.Click
        'Add bowl to all carts
        lstShoppingCart.Items.Add("1 Special Bowl for $43.50")
        frmBlackBowls.lstShoppingCart.Items.Add("1 Special Bowl for $43.50")
        frmBlueBowls.lstShoppingCart.Items.Add("1 Special Bowl for $43.50")
        frmChineseBowls.lstShoppingCart.Items.Add("1 Special Bowl for $43.50")
        frmRedBowls.lstShoppingCart.Items.Add("1 Special Bowl for $43.50")
        frmWhiteBowls.lstShoppingCart.Items.Add("1 Special Bowl for $43.50")
        'Add Bowl to Checkout
        frmCheckout.lstCheckoutShoppingList.Items.Add("1 Special Bowl for $43.50")
        'Get subtotal (total before tax)
        dblPreTaxCost = dblPreTaxCost + 43.5
    End Sub
    'Going to different forms/tabs
    Private Sub BlackBowlsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlackBowlsToolStripMenuItem.Click
        Me.Visible = False
        frmBlackBowls.Visible = True
    End Sub

    Private Sub BlueBowlsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlueBowlsToolStripMenuItem.Click
        Me.Visible = False
        frmBlueBowls.Visible = True
    End Sub

    Private Sub ChineseBowlsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChineseBowlsToolStripMenuItem.Click
        Me.Visible = False
        frmChineseBowls.Visible = True
    End Sub

    Private Sub RedBowlsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedBowlsToolStripMenuItem.Click
        Me.Visible = False
        frmRedBowls.Visible = True
    End Sub

    Private Sub WhiteBowlsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteBowlsToolStripMenuItem.Click
        Me.Visible = False
        frmWhiteBowls.Visible = True
    End Sub

    Private Sub CheckoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckoutToolStripMenuItem.Click
        Me.Visible = False
        frmCheckout.Visible = True
    End Sub

    Private Sub ShowHideCartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowHideCartToolStripMenuItem.Click
        If lstShoppingCart.Visible = True Then
            lstShoppingCart.Visible = False
        Else
            lstShoppingCart.Visible = True
        End If
    End Sub
End Class