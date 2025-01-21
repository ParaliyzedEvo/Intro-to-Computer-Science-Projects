Public Class frmBlueBowls
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub picBlueBowl1_Click(sender As Object, e As EventArgs) Handles picBlueBowl1.Click
        'Add bowl to all carts
        lstShoppingCart.Items.Add("1 Blue Bowl Option 1 for $3.75")
        frmSpecialBowl.lstShoppingCart.Items.Add("1 Blue Bowl Option 1 for $3.75")
        frmBlackBowls.lstShoppingCart.Items.Add("1 Blue Bowl Option 1 for $3.75")
        frmChineseBowls.lstShoppingCart.Items.Add("1 Blue Bowl Option 1 for $3.75")
        frmRedBowls.lstShoppingCart.Items.Add("1 Blue Bowl Option 1 for $3.75")
        frmWhiteBowls.lstShoppingCart.Items.Add("1 Blue Bowl Option 1 for $3.75")
        'Add Bowl to Checkout
        frmCheckout.lstCheckoutShoppingList.Items.Add("1 Blue Bowl 1 for $3.75")
        'Get subtotal (total before tax)
        dblPreTaxCost = dblPreTaxCost + 3.75
    End Sub

    Private Sub picBlueBowl2_Click(sender As Object, e As EventArgs) Handles picBlueBowl2.Click
        'Add bowl to all carts
        lstShoppingCart.Items.Add("1 Blue Bowl Option 2 for $3.00")
        frmSpecialBowl.lstShoppingCart.Items.Add("1 Blue Bowl Option 2 for $3.00")
        frmBlackBowls.lstShoppingCart.Items.Add("1 Blue Bowl Option 2 for $3.00")
        frmChineseBowls.lstShoppingCart.Items.Add("1 Blue Bowl Option 2 for $3.00")
        frmRedBowls.lstShoppingCart.Items.Add("1 Blue Bowl Option 2 for $3.00")
        frmWhiteBowls.lstShoppingCart.Items.Add("1 Blue Bowl Option 2 for $3.00")
        'Add Bowl to Checkout
        frmCheckout.lstCheckoutShoppingList.Items.Add("1 Blue Bowl Option 2 for $3.00")
        'Get subtotal (total before tax)
        dblPreTaxCost = dblPreTaxCost + 3.0
    End Sub

    Private Sub picBlueBowl3_Click(sender As Object, e As EventArgs) Handles picBlueBowl3.Click
        'Add bowl to all carts
        lstShoppingCart.Items.Add("1 Blue Bowl Option 3 for $16.99")
        frmSpecialBowl.lstShoppingCart.Items.Add("1 Blue Bowl Option 3 for $16.99")
        frmBlackBowls.lstShoppingCart.Items.Add("1 Blue Bowl Option 3 for $16.99")
        frmChineseBowls.lstShoppingCart.Items.Add("1 Blue Bowl Option 3 for $16.99")
        frmRedBowls.lstShoppingCart.Items.Add("1 Blue Bowl Option 3 for $16.99")
        frmWhiteBowls.lstShoppingCart.Items.Add("1 Blue Bowl Option 3 for $16.99")
        'Add Bowl to Checkout
        frmCheckout.lstCheckoutShoppingList.Items.Add("1 Blue Bowl Option 3 for $16.99")
        'Get subtotal (total before tax)
        dblPreTaxCost = dblPreTaxCost + 16.99
    End Sub

    Private Sub picBlueBowl4_Click(sender As Object, e As EventArgs) Handles picBlueBowl4.Click
        'Add bowl to all carts
        lstShoppingCart.Items.Add("1 Blue Bowl Option 4 for $7.99")
        frmSpecialBowl.lstShoppingCart.Items.Add("1 Blue Bowl Option 4 for $7.99")
        frmBlackBowls.lstShoppingCart.Items.Add("1 Blue Bowl Option 4 for $7.99")
        frmChineseBowls.lstShoppingCart.Items.Add("1 Blue Bowl Option 4 for $7.99")
        frmRedBowls.lstShoppingCart.Items.Add("1 Blue Bowl Option 4 for $7.99")
        frmWhiteBowls.lstShoppingCart.Items.Add("1 Blue Bowl Option 4 for $7.99")
        'Add Bowl to Checkout
        frmCheckout.lstCheckoutShoppingList.Items.Add("1 Blue Bowl Option 4 for $7.99")
        'Get subtotal (total before tax)
        dblPreTaxCost = dblPreTaxCost + 7.99
    End Sub
    'Going to different forms/tabs
    Private Sub BlackBwolsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlackBwolsToolStripMenuItem.Click
        Me.Visible = False
        frmBlackBowls.Visible = True
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

    Private Sub TheSpecialBowlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TheSpecialBowlToolStripMenuItem.Click
        Me.Visible = False
        frmSpecialBowl.Visible = True
    End Sub

    Private Sub CheckoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckoutToolStripMenuItem.Click
        Me.Visible = False
        frmCheckout.Visible = True
    End Sub
    'Show/Hide Cart
    Private Sub ShowHideCartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowHideCartToolStripMenuItem.Click
        If lstShoppingCart.Visible = True Then
            lstShoppingCart.Visible = False
        Else
            lstShoppingCart.Visible = True
        End If
    End Sub
End Class