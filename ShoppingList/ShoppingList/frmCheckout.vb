Public Class frmCheckout
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub GroceriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GroceriesToolStripMenuItem.Click
        'Close the checkout form
        Me.Visible = False
        'Load the groceries form
        frmGroceries.Visible = True
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        'Calculate the tax and display the final cost on the form
        dblTax = dblPreTaxCost * 0.1
        dblFinalCost = dblPreTaxCost + dblTax
        lblTotalCost.Text = "The total amount owed today is " & FormatCurrency(dblFinalCost, NumDigitsAfterDecimal:=2)
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        'Check if milk is selected to be removed
        If lstCheckoutShoppingList.SelectedItem = "1 gallon of milk for $3.49" Then
            'Remove from frmGroceries first
            frmGroceries.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            'Deduct from the subtotal
            dblPreTaxCost = dblPreTaxCost - 3.49
            'Next remove from frmCheckout
            lstCheckoutShoppingList.Items.Remove(lstCheckoutShoppingList.SelectedItem)
        End If
        If lstCheckoutShoppingList.SelectedItem = "1 carton of eggs for $1.99" Then
            'Remove from frmGroceries first
            frmGroceries.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            'Deduct from the subtotal
            dblPreTaxCost = dblPreTaxCost - 1.99
            'Next remove from frmCheckout
            lstCheckoutShoppingList.Items.Remove(lstCheckoutShoppingList.SelectedItem)
        End If
    End Sub
End Class