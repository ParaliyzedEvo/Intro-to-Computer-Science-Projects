Public Class frmGroceries
    Private Sub CheckoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckoutToolStripMenuItem.Click
        'Close the groceries form
        Me.Visible = False
        'Load the checkout form
        frmCheckout.Visible = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub picEggs_Click(sender As Object, e As EventArgs) Handles picEggs.Click
        'Add eggs to cart
        lstShoppingCart.Items.Add("1 carton of eggs for $1.99")
        'Add eggs to checkout shopping list
        frmCheckout.lstCheckoutShoppingList.Items.Add("1 carton of eggs for $1.99")
        'Get subtotal (total before tax)
        dblPreTaxCost = dblPreTaxCost + 1.99
    End Sub

    Private Sub picMilk_Click(sender As Object, e As EventArgs) Handles picMilk.Click
        'Add milk to cart
        lstShoppingCart.Items.Add("1 gallon of milk for $3.49")
        'Add milk to checkout shopping list
        frmCheckout.lstCheckoutShoppingList.Items.Add("1 gallon of milk for $3.49")
        'Get subtotal (total before tax)
        dblPreTaxCost = dblPreTaxCost + 3.49
    End Sub
End Class