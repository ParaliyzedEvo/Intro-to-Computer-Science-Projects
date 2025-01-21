Public Class frmBlackBowls
    Private Sub picBowl1_Click(sender As Object, e As EventArgs) Handles picBlackBowl1.Click
        'Add bowl to all carts
        lstShoppingCart.Items.Add("1 Black Bowl Option 1 for $7.95")
        frmSpecialBowl.lstShoppingCart.Items.Add("1 Black Bowl Option 1 for $7.95")
        frmBlueBowls.lstShoppingCart.Items.Add("1 Black Bowl Option 1 for $7.95")
        frmChineseBowls.lstShoppingCart.Items.Add("1 Black Bowl Option 1 for $7.95")
        frmRedBowls.lstShoppingCart.Items.Add("1 Black Bowl Option 1 for $7.95")
        frmWhiteBowls.lstShoppingCart.Items.Add("1 Black Bowl Option 1 for $7.95")
        'Add Bowl to Checkout
        frmCheckout.lstCheckoutShoppingList.Items.Add("1 Black Bowl Option 1 for $7.95")
        'Get subtotal (total before tax)
        dblPreTaxCost = dblPreTaxCost + 7.95
    End Sub

    Private Sub picBowl2_Click(sender As Object, e As EventArgs) Handles picBlackBowl2.Click
        'Add bowl to all carts
        lstShoppingCart.Items.Add("1 Black Bowl Option 2 for $10.95")
        frmSpecialBowl.lstShoppingCart.Items.Add("1 Black Bowl Option 2 for $10.95")
        frmBlueBowls.lstShoppingCart.Items.Add("1 Black Bowl Option 2 for $10.95")
        frmChineseBowls.lstShoppingCart.Items.Add("1 Black Bowl Option 2 for $10.95")
        frmRedBowls.lstShoppingCart.Items.Add("1 Black Bowl Option 2 for $10.95")
        frmWhiteBowls.lstShoppingCart.Items.Add("1 Black Bowl Option 2 for $10.95")
        'Add Bowl to Checkout
        frmCheckout.lstCheckoutShoppingList.Items.Add("1 Black Bowl Option 2 for $10.95")
        'Get subtotal (total before tax)
        dblPreTaxCost = dblPreTaxCost + 10.95
    End Sub

    Private Sub picBowl3_Click(sender As Object, e As EventArgs) Handles picBlackBowl3.Click
        'Add bowl to all carts
        lstShoppingCart.Items.Add("1 Black Bowl Option 3 for $0.50")
        frmSpecialBowl.lstShoppingCart.Items.Add("1 Black Bowl Option 3 for $0.50")
        frmBlueBowls.lstShoppingCart.Items.Add("1 Black Bowl Option 3 for $0.50")
        frmChineseBowls.lstShoppingCart.Items.Add("1 Black Bowl Option 3 for $0.50")
        frmRedBowls.lstShoppingCart.Items.Add("1 Black Bowl Option 3 for $0.50")
        frmWhiteBowls.lstShoppingCart.Items.Add("1 Black Bowl Option 3 for $0.50")
        'Add Bowl to Checkout
        frmCheckout.lstCheckoutShoppingList.Items.Add("1 Black Bowl Option 3 for $0.50")
        'Get subtotal (total before tax)
        dblPreTaxCost = dblPreTaxCost + 0.5
    End Sub

    Private Sub picBowl4_Click(sender As Object, e As EventArgs) Handles picBlackBowl4.Click
        'Add bowl to all carts
        lstShoppingCart.Items.Add("1 Black Bowl Option 4 for $29.95")
        frmSpecialBowl.lstShoppingCart.Items.Add("1 Black Bowl Option 4 for $29.95")
        frmBlueBowls.lstShoppingCart.Items.Add("1 Black Bowl Option 4 for $29.95")
        frmChineseBowls.lstShoppingCart.Items.Add("1 Black Bowl Option 4 for $29.95")
        frmRedBowls.lstShoppingCart.Items.Add("1 Black Bowl Option 4 for $29.95")
        frmWhiteBowls.lstShoppingCart.Items.Add("1 Black Bowl Option 4 for $29.95")
        'Add Bowl to Checkout
        frmCheckout.lstCheckoutShoppingList.Items.Add("1 Black Bowl Option 4 for $29.95")
        'Get subtotal (total before tax)
        dblPreTaxCost = dblPreTaxCost + 0.5
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
    'Going to different forms/tabs
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

    Private Sub TheSpecialBowlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TheSpecialBowlToolStripMenuItem.Click
        Me.Visible = False
        frmSpecialBowl.Visible = True
    End Sub

    Private Sub CheckoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckoutToolStripMenuItem.Click
        Me.Visible = False
        frmCheckout.Visible = True
    End Sub

    Private Sub frmBlackBowls_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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