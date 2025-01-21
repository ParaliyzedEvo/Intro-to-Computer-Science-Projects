Public Class frmChineseBowls
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub picChineseBowl1_Click(sender As Object, e As EventArgs) Handles picChineseBowl1.Click
        'Add bowl to all carts
        lstShoppingCart.Items.Add("1 Chinese Bowl Option 1 for $25.49")
        frmSpecialBowl.lstShoppingCart.Items.Add("1 Chinese Bowl Option 1 for $25.49")
        frmBlueBowls.lstShoppingCart.Items.Add("1 Chinese Bowl Option 1 for $25.49")
        frmBlackBowls.lstShoppingCart.Items.Add("1 Chinese Bowl Option 1 for $25.49")
        frmRedBowls.lstShoppingCart.Items.Add("1 Chinese Bowl Option 1 for $25.49")
        frmWhiteBowls.lstShoppingCart.Items.Add("1 Chinese Bowl Option 1 for $25.49")
        'Add Bowl to Checkout
        frmCheckout.lstCheckoutShoppingList.Items.Add("1 Chinese Bowl Option 1 for $25.49")
        'Get subtotal (total before tax)
        dblPreTaxCost = dblPreTaxCost + 25.49
    End Sub

    Private Sub picChineseBowl2_Click(sender As Object, e As EventArgs) Handles picChineseBowl2.Click
        'Add bowl to all carts
        lstShoppingCart.Items.Add("1 Chinese Bowl Option 2 for $39.00")
        frmSpecialBowl.lstShoppingCart.Items.Add("1 Chinese Bowl Option 2 for $39.00")
        frmBlueBowls.lstShoppingCart.Items.Add("1 Chinese Bowl Option 2 for $39.00")
        frmBlackBowls.lstShoppingCart.Items.Add("1 Chinese Bowl Option 2 for $39.00")
        frmRedBowls.lstShoppingCart.Items.Add("1 Chinese Bowl Option 2 for $39.00")
        frmWhiteBowls.lstShoppingCart.Items.Add("1 Chinese Bowl Option 2 for $39.00")
        'Add Bowl to Checkout
        frmCheckout.lstCheckoutShoppingList.Items.Add("1 Chinese Bowl Option 2 for $39.00")
        'Get subtotal (total before tax)
        dblPreTaxCost = dblPreTaxCost + 39.0
    End Sub

    Private Sub picChineseBowl3_Click(sender As Object, e As EventArgs) Handles picChineseBowl3.Click
        'Add bowl to all carts
        lstShoppingCart.Items.Add("1 Chinese Bowl Option 3 for $59.00")
        frmSpecialBowl.lstShoppingCart.Items.Add("1 Chinese Bowl Option 3 for $59.00")
        frmBlueBowls.lstShoppingCart.Items.Add("1 Chinese Bowl Option 3 for $59.00")
        frmBlackBowls.lstShoppingCart.Items.Add("1 Chinese Bowl Option 3 for $59.00")
        frmRedBowls.lstShoppingCart.Items.Add("1 Chinese Bowl Option 3 for $59.00")
        frmWhiteBowls.lstShoppingCart.Items.Add("1 Chinese Bowl Option 3 for $59.00")
        'Add Bowl to Checkout
        frmCheckout.lstCheckoutShoppingList.Items.Add("1 Chinese Bowl Option 3 for $59.00")
        'Get subtotal (total before tax)
        dblPreTaxCost = dblPreTaxCost + 59.0
    End Sub

    Private Sub picChineseBowl4_Click(sender As Object, e As EventArgs) Handles picChineseBowl4.Click
        'Add bowl to all carts
        lstShoppingCart.Items.Add("1 Chinese Bowl Option 4 for $36.92")
        frmSpecialBowl.lstShoppingCart.Items.Add("1 Chinese Bowl Option 4 for $36.92")
        frmBlueBowls.lstShoppingCart.Items.Add("1 Chinese Bowl Option 4 for $36.92")
        frmBlackBowls.lstShoppingCart.Items.Add("1 Chinese Bowl Option 4 for $36.92")
        frmRedBowls.lstShoppingCart.Items.Add("1 Chinese Bowl Option 4 for $36.92")
        frmWhiteBowls.lstShoppingCart.Items.Add("1 Chinese Bowl Option 4 for $36.92")
        'Add Bowl to Checkout
        frmCheckout.lstCheckoutShoppingList.Items.Add("1 Chinese Bowl Option 4 for $36.92")
        'Get subtotal (total before tax)
        dblPreTaxCost = dblPreTaxCost + 36.92
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