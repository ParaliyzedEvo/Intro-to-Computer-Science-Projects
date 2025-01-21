Public Class frmCheckout
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        'Calculate the tax and display the final cost on the form
        dblTax = dblPreTaxCost * 0.1
        dblFinalCost = dblPreTaxCost + dblTax
        lblTotalCost.Text = "The total amount owed today is " & FormatCurrency(dblFinalCost, NumDigitsAfterDecimal:=2)
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        'Remove item from all forms
        'Black Bowls
        If lstCheckoutShoppingList.SelectedItem = "1 Black Bowl Option 1 for $7.95" Then
            'Remove from bowl forms first
            frmBlackBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmBlueBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmChineseBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmRedBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmSpecialBowl.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmWhiteBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            'Deduct from the subtotal
            dblPreTaxCost = dblPreTaxCost - 7.95
            'Next remove from frmCheckout
            lstCheckoutShoppingList.Items.Remove(lstCheckoutShoppingList.SelectedItem)
        End If
        If lstCheckoutShoppingList.SelectedItem = "1 Black Bowl Option 2 for $10.95" Then
            'Remove from frmGroceries first
            frmBlackBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmBlueBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmChineseBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmRedBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmSpecialBowl.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmWhiteBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            'Deduct from the subtotal
            dblPreTaxCost = dblPreTaxCost - 10.95
            'Next remove from frmCheckout
            lstCheckoutShoppingList.Items.Remove(lstCheckoutShoppingList.SelectedItem)
        End If
        If lstCheckoutShoppingList.SelectedItem = "1 Black Bowl Option 3 for $0.50" Then
            'Remove from frmGroceries first
            frmBlackBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmBlueBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmChineseBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmRedBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmSpecialBowl.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmWhiteBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            'Deduct from the subtotal
            dblPreTaxCost = dblPreTaxCost - 0.5
            'Next remove from frmCheckout
            lstCheckoutShoppingList.Items.Remove(lstCheckoutShoppingList.SelectedItem)
        End If
        If lstCheckoutShoppingList.SelectedItem = "1 Black Bowl Option 4 for $29.95" Then
            'Remove from frmGroceries first
            frmBlackBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmBlueBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmChineseBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmRedBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmSpecialBowl.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmWhiteBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            'Deduct from the subtotal
            dblPreTaxCost = dblPreTaxCost - 29.95
            'Next remove from frmCheckout
            lstCheckoutShoppingList.Items.Remove(lstCheckoutShoppingList.SelectedItem)
        End If
        'Blue Bowls
        If lstCheckoutShoppingList.SelectedItem = "1 Blue Bowl Option 1 for $3.75" Then
            'Remove from frmGroceries first
            frmBlackBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmBlueBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmChineseBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmRedBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmSpecialBowl.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmWhiteBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            'Deduct from the subtotal
            dblPreTaxCost = dblPreTaxCost - 3.75
            'Next remove from frmCheckout
            lstCheckoutShoppingList.Items.Remove(lstCheckoutShoppingList.SelectedItem)
        End If
        If lstCheckoutShoppingList.SelectedItem = "1 Blue Bowl Option 2 for $3.00" Then
            'Remove from frmGroceries first
            frmBlackBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmBlueBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmChineseBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmRedBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmSpecialBowl.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmWhiteBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            'Deduct from the subtotal
            dblPreTaxCost = dblPreTaxCost - 3.0
            'Next remove from frmCheckout
            lstCheckoutShoppingList.Items.Remove(lstCheckoutShoppingList.SelectedItem)
        End If
        If lstCheckoutShoppingList.SelectedItem = "1 Blue Bowl Option 3 for $16.99" Then
            'Remove from frmGroceries first
            frmBlackBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmBlueBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmChineseBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmRedBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmSpecialBowl.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmWhiteBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            'Deduct from the subtotal
            dblPreTaxCost = dblPreTaxCost - 16.99
            'Next remove from frmCheckout
            lstCheckoutShoppingList.Items.Remove(lstCheckoutShoppingList.SelectedItem)
        End If
        If lstCheckoutShoppingList.SelectedItem = "1 Blue Bowl Option 4 for $7.99" Then
            'Remove from frmGroceries first
            frmBlackBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmBlueBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmChineseBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmRedBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmSpecialBowl.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmWhiteBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            'Deduct from the subtotal
            dblPreTaxCost = dblPreTaxCost - 7.99
            'Next remove from frmCheckout
            lstCheckoutShoppingList.Items.Remove(lstCheckoutShoppingList.SelectedItem)
        End If
        'Chinese Bowls
        If lstCheckoutShoppingList.SelectedItem = "1 Chinese Bowl Option 1 for $25.49" Then
            'Remove from frmGroceries first
            frmBlackBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmBlueBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmChineseBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmRedBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmSpecialBowl.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmWhiteBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            'Deduct from the subtotal
            dblPreTaxCost = dblPreTaxCost - 25.49
            'Next remove from frmCheckout
            lstCheckoutShoppingList.Items.Remove(lstCheckoutShoppingList.SelectedItem)
        End If
        If lstCheckoutShoppingList.SelectedItem = "1 Chinese Bowl Option 2 for $39.00" Then
            'Remove from frmGroceries first
            frmBlackBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmBlueBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmChineseBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmRedBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmSpecialBowl.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmWhiteBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            'Deduct from the subtotal
            dblPreTaxCost = dblPreTaxCost - 39.0
            'Next remove from frmCheckout
            lstCheckoutShoppingList.Items.Remove(lstCheckoutShoppingList.SelectedItem)
        End If
        If lstCheckoutShoppingList.SelectedItem = "1 Chinese Bowl Option 3 for $59.00" Then
            'Remove from frmGroceries first
            frmBlackBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmBlueBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmChineseBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmRedBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmSpecialBowl.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmWhiteBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            'Deduct from the subtotal
            dblPreTaxCost = dblPreTaxCost - 59.0
            'Next remove from frmCheckout
            lstCheckoutShoppingList.Items.Remove(lstCheckoutShoppingList.SelectedItem)
        End If
        If lstCheckoutShoppingList.SelectedItem = "1 Chinese Bowl Option 4 for $36.92" Then
            'Remove from frmGroceries first
            frmBlackBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmBlueBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmChineseBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmRedBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmSpecialBowl.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmWhiteBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            'Deduct from the subtotal
            dblPreTaxCost = dblPreTaxCost - 36.92
            'Next remove from frmCheckout
            lstCheckoutShoppingList.Items.Remove(lstCheckoutShoppingList.SelectedItem)
        End If
        'Red Bowls
        If lstCheckoutShoppingList.SelectedItem = "1 Red Bowl Option 1 for $13.99" Then
            'Remove from frmGroceries first
            frmBlackBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmBlueBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmChineseBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmRedBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmSpecialBowl.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmWhiteBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            'Deduct from the subtotal
            dblPreTaxCost = dblPreTaxCost - 13.99
            'Next remove from frmCheckout
            lstCheckoutShoppingList.Items.Remove(lstCheckoutShoppingList.SelectedItem)
        End If
        If lstCheckoutShoppingList.SelectedItem = "1 Red Bowl Option 2 for $6.24" Then
            'Remove from frmGroceries first
            frmBlackBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmBlueBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmChineseBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmRedBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmSpecialBowl.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmWhiteBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            'Deduct from the subtotal
            dblPreTaxCost = dblPreTaxCost - 6.24
            'Next remove from frmCheckout
            lstCheckoutShoppingList.Items.Remove(lstCheckoutShoppingList.SelectedItem)
        End If
        If lstCheckoutShoppingList.SelectedItem = "1 Red Bowl Option 3 for $13.29" Then
            'Remove from frmGroceries first
            frmBlackBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmBlueBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmChineseBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmRedBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmSpecialBowl.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmWhiteBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            'Deduct from the subtotal
            dblPreTaxCost = dblPreTaxCost - 13.29
            'Next remove from frmCheckout
            lstCheckoutShoppingList.Items.Remove(lstCheckoutShoppingList.SelectedItem)
        End If
        If lstCheckoutShoppingList.SelectedItem = "1 Red Bowl Option 4 for $5.00" Then
            'Remove from frmGroceries first
            frmBlackBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmBlueBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmChineseBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmRedBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmSpecialBowl.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmWhiteBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            'Deduct from the subtotal
            dblPreTaxCost = dblPreTaxCost - 5.0
            'Next remove from frmCheckout
            lstCheckoutShoppingList.Items.Remove(lstCheckoutShoppingList.SelectedItem)
        End If
        'Special Bowl
        If lstCheckoutShoppingList.SelectedItem = "1 Special Bowl for $43.50" Then
            'Remove from frmGroceries first
            frmBlackBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmBlueBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmChineseBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmRedBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmSpecialBowl.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmWhiteBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            'Deduct from the subtotal
            dblPreTaxCost = dblPreTaxCost - 43.5
            'Next remove from frmCheckout
            lstCheckoutShoppingList.Items.Remove(lstCheckoutShoppingList.SelectedItem)
        End If
        'White Bowls
        If lstCheckoutShoppingList.SelectedItem = "1 White Bowl Option 1 for $19.96" Then
            'Remove from frmGroceries first
            frmBlackBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmBlueBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmChineseBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmRedBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmSpecialBowl.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmWhiteBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            'Deduct from the subtotal
            dblPreTaxCost = dblPreTaxCost - 19.96
            'Next remove from frmCheckout
            lstCheckoutShoppingList.Items.Remove(lstCheckoutShoppingList.SelectedItem)
        End If
        If lstCheckoutShoppingList.SelectedItem = "1 White Bowl Option 2 for $2.00" Then
            'Remove from frmGroceries first
            frmBlackBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmBlueBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmChineseBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmRedBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmSpecialBowl.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmWhiteBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            'Deduct from the subtotal
            dblPreTaxCost = dblPreTaxCost - 2.0
            'Next remove from frmCheckout
            lstCheckoutShoppingList.Items.Remove(lstCheckoutShoppingList.SelectedItem)
        End If
        If lstCheckoutShoppingList.SelectedItem = "1 White Bowl Option 3 for $6.36" Then
            'Remove from frmGroceries first
            frmBlackBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmBlueBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmChineseBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmRedBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmSpecialBowl.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmWhiteBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            'Deduct from the subtotal
            dblPreTaxCost = dblPreTaxCost - 6.36
            'Next remove from frmCheckout
            lstCheckoutShoppingList.Items.Remove(lstCheckoutShoppingList.SelectedItem)
        End If
        If lstCheckoutShoppingList.SelectedItem = "1 White Bowl Option 4 for $3.10" Then
            'Remove from frmGroceries first
            frmBlackBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmBlueBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmChineseBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmRedBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmSpecialBowl.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            frmWhiteBowls.lstShoppingCart.Items.Remove(lstCheckoutShoppingList.SelectedItem)
            'Deduct from the subtotal
            dblPreTaxCost = dblPreTaxCost - 3.1
            'Next remove from frmCheckout
            lstCheckoutShoppingList.Items.Remove(lstCheckoutShoppingList.SelectedItem)
        End If
    End Sub
    'Going to different forms/tabs
    Private Sub GroceriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GroceriesToolStripMenuItem.Click
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

    Private Sub TheSpecialBowlsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TheSpecialBowlsToolStripMenuItem.Click
        Me.Visible = False
        frmSpecialBowl.Visible = True
    End Sub
End Class