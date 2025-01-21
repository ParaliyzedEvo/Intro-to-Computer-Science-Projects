Public Class frmRedBowls
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub picRedBowl1_Click(sender As Object, e As EventArgs) Handles picRedBowl1.Click
        'Add bowl to all carts
        lstShoppingCart.Items.Add("1 Red Bowl Option 1 for $13.99")
        frmSpecialBowl.lstShoppingCart.Items.Add("1 Red Bowl Option 1 for $13.99")
        frmBlueBowls.lstShoppingCart.Items.Add("1 Red Bowl Option 1 for $13.99")
        frmChineseBowls.lstShoppingCart.Items.Add("1 Red Bowl Option 1 for $13.99")
        frmBlackBowls.lstShoppingCart.Items.Add("1 Red Bowl Option 1 for $13.99")
        frmWhiteBowls.lstShoppingCart.Items.Add("1 Red Bowl Option 1 for $13.99")
        'Add Bowl to Checkout
        frmCheckout.lstCheckoutShoppingList.Items.Add("1 Red Bowl Option 1 for $13.99")
        'Get subtotal (total before tax)
        dblPreTaxCost = dblPreTaxCost + 13.99
    End Sub

    Private Sub picRedBowl2_Click(sender As Object, e As EventArgs) Handles picRedBowl2.Click
        'Add bowl to all carts
        lstShoppingCart.Items.Add("1 Red Bowl Option 2 for $6.24")
        frmSpecialBowl.lstShoppingCart.Items.Add("1 Red Bowl Option 2 for $6.24")
        frmBlueBowls.lstShoppingCart.Items.Add("1 Red Bowl Option 2 for $6.24")
        frmChineseBowls.lstShoppingCart.Items.Add("1 Red Bowl Option 2 for $6.24")
        frmBlackBowls.lstShoppingCart.Items.Add("1 Red Bowl Option 2 for $6.24")
        frmWhiteBowls.lstShoppingCart.Items.Add("1 Red Bowl Option 2 for $6.24")
        'Add Bowl to Checkout
        frmCheckout.lstCheckoutShoppingList.Items.Add("1 Red Bowl Option 2 for $6.24")
        'Get subtotal (total before tax)
        dblPreTaxCost = dblPreTaxCost + 6.24
    End Sub

    Private Sub picRedBowl3_Click(sender As Object, e As EventArgs) Handles picRedBowl3.Click
        'Add bowl to all carts
        lstShoppingCart.Items.Add("1 Red Bowl Option 3 for $13.29")
        frmSpecialBowl.lstShoppingCart.Items.Add("1 Red Bowl Option 3 for $13.29")
        frmBlueBowls.lstShoppingCart.Items.Add("1 Red Bowl Option 3 for $13.29")
        frmChineseBowls.lstShoppingCart.Items.Add("1 Red Bowl Option 3 for $13.29")
        frmBlackBowls.lstShoppingCart.Items.Add("1 Red Bowl Option 3 for $13.29")
        frmWhiteBowls.lstShoppingCart.Items.Add("1 Red Bowl Option 3 for $13.29")
        'Add Bowl to Checkout
        frmCheckout.lstCheckoutShoppingList.Items.Add("1 Red Bowl Option 3 for $13.29")
        'Get subtotal (total before tax)
        dblPreTaxCost = dblPreTaxCost + 13.89
    End Sub

    Private Sub picRedBowl4_Click(sender As Object, e As EventArgs) Handles picRedBowl4.Click
        'Add bowl to all carts
        lstShoppingCart.Items.Add("1 Red Bowl Option 4 for $5.00")
        frmSpecialBowl.lstShoppingCart.Items.Add("1 Red Bowl Option 4 for $5.00")
        frmBlueBowls.lstShoppingCart.Items.Add("1 Red Bowl Option 4 for $5.00")
        frmChineseBowls.lstShoppingCart.Items.Add("1 Red Bowl Option 4 for $5.00")
        frmBlackBowls.lstShoppingCart.Items.Add("1 Red Bowl Option 4 for $5.00")
        frmWhiteBowls.lstShoppingCart.Items.Add("1 Red Bowl Option 4 for $5.00")
        'Add Bowl to Checkout
        frmCheckout.lstCheckoutShoppingList.Items.Add("1 Red Bowl Option 3 for $13.29")
        'Get subtotal (total before tax)
        dblPreTaxCost = dblPreTaxCost + 5.0
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

    Private Sub WhiteBowlsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteBowlsToolStripMenuItem.Click
        Me.Visible = False
        frmWhiteBowls.Visible = True
    End Sub

    Private Sub SpecialBowlsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpecialBowlsToolStripMenuItem.Click
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