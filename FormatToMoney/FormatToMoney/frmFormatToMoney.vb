Public Class frmFormatToMoney
    'Create a variable to store the original number
    Dim dblOriginalNumber As Double
    'Double is a number with decimal points
    Private Sub txtOriginalNumber_TextChanged(sender As Object, e As EventArgs) Handles txtOriginalNumber.TextChanged
        dblOriginalNumber = txtOriginalNumber.Text
    End Sub

    Private Sub btnFormat_Click(sender As Object, e As EventArgs) Handles btnFormat.Click
        txtCurrencyFormat.Text = FormatCurrency(dblOriginalNumber, NumDigitsAfterDecimal:=2)
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        End
    End Sub
End Class
