Public Class frmWhiteBowls
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub picWhiteBowl1_Click(sender As Object, e As EventArgs) Handles picWhiteBowl1.Click
        'Add bowl to all carts
        lstShoppingCart.Items.Add("1 White Bowl Option 1 for $19.96")
        frmSpecialBowl.lstShoppingCart.Items.Add("1 White Bowl Option 1 for $19.96")
        frmBlueBowls.lstShoppingCart.Items.Add("1 White Bowl Option 1 for $19.96")
        frmChineseBowls.lstShoppingCart.Items.Add("1 White Bowl Option 1 for $19.96")
        frmRedBowls.lstShoppingCart.Items.Add("1 White Bowl Option 1 for $19.96")
        frmBlackBowls.lstShoppingCart.Items.Add("1 White Bowl Option 1 for $19.96")
        'Add Bowl to Checkout
        frmCheckout.lstCheckoutShoppingList.Items.Add("1 White Bowl Option 1 for $19.96")
        'Get subtotal (total before tax)
        dblPreTaxCost = dblPreTaxCost + 19.96
    End Sub

    Private Sub picWhiteBowl2_Click(sender As Object, e As EventArgs) Handles picWhiteBowl2.Click
        'Add bowl to all carts
        lstShoppingCart.Items.Add("1 White Bowl Option 2 for $2.00")
        frmSpecialBowl.lstShoppingCart.Items.Add("1 White Bowl Option 2 for $2.00")
        frmBlueBowls.lstShoppingCart.Items.Add("1 White Bowl Option 2 for $2.00")
        frmChineseBowls.lstShoppingCart.Items.Add("1 White Bowl Option 2 for $2.00")
        frmRedBowls.lstShoppingCart.Items.Add("1 White Bowl Option 2 for $2.00")
        frmBlackBowls.lstShoppingCart.Items.Add("1 White Bowl Option 2 for $2.00")
        'Add Bowl to Checkout
        frmCheckout.lstCheckoutShoppingList.Items.Add("1 White Bowl Option 2 for $2.00")
        'Get subtotal (total before tax)
        dblPreTaxCost = dblPreTaxCost + 2.0
    End Sub

    Private Sub picWhiteBowl3_Click(sender As Object, e As EventArgs) Handles picWhiteBowl3.Click
        'Add bowl to all carts
        lstShoppingCart.Items.Add("1 White Bowl Option 3 for $6.36")
        frmSpecialBowl.lstShoppingCart.Items.Add("1 White Bowl Option 3 for $6.36")
        frmBlueBowls.lstShoppingCart.Items.Add("1 White Bowl Option 3 for $6.36")
        frmChineseBowls.lstShoppingCart.Items.Add("1 White Bowl Option 3 for $6.36")
        frmRedBowls.lstShoppingCart.Items.Add("1 White Bowl Option 3 for $6.36")
        frmBlackBowls.lstShoppingCart.Items.Add("1 White Bowl Option 3 for $6.36")
        'Add Bowl to Checkout
        frmCheckout.lstCheckoutShoppingList.Items.Add("1 White Bowl Option 3 for $6.36")
        'Get subtotal (total before tax)
        dblPreTaxCost = dblPreTaxCost + 6.36
    End Sub

    Private Sub picWhiteBowl4_Click(sender As Object, e As EventArgs) Handles picWhiteBowl4.Click
        'Add bowl to all carts
        lstShoppingCart.Items.Add("1 White Bowl Option 4 for $3.10")
        frmSpecialBowl.lstShoppingCart.Items.Add("1 White Bowl Option 4 for $3.10")
        frmBlueBowls.lstShoppingCart.Items.Add("1 White Bowl Option 4 for $3.10")
        frmChineseBowls.lstShoppingCart.Items.Add("1 White Bowl Option 4 for $3.10")
        frmRedBowls.lstShoppingCart.Items.Add("1 White Bowl Option 4 for $3.10")
        frmBlackBowls.lstShoppingCart.Items.Add("1 White Bowl Option 4 for $3.10")
        'Add Bowl to Checkout
        frmCheckout.lstCheckoutShoppingList.Items.Add("1 White Bowl Option 4 for $3.10")
        'Get subtotal (total before tax)
        dblPreTaxCost = dblPreTaxCost + 3.1
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