Public Class frmCalculator

    'I am going to declare intValue1 and intValue2 as integer variables
    Dim intValue1 As Integer
    Dim intValue2 As Integer

    Private Sub txtValue1_TextChanged(sender As Object, e As EventArgs) Handles txtValue1.TextChanged
        intValue1 = Val(txtValue1.Text)
    End Sub

    Private Sub txtValue2_TextChanged(sender As Object, e As EventArgs) Handles txtValue2.TextChanged
        intValue2 = Val(txtValue2.Text)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        txtOutputNumber.Text = intValue1 + intValue2
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        txtOutputNumber.Text = intValue1 - intValue2
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        txtOutputNumber.Text = intValue1 * intValue2
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        If intValue2 = 0 Then
            MsgBox("Cannot divide by 0", MsgBoxStyle.Critical)
            txtValue2.BackColor = Color.Red
        Else
            txtValue2.BackColor = Color.White
            txtOutputNumber.Text = intValue1 / intValue2
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If txtValue2.BackColor = Color.Red Then
            txtValue1.Clear()
            txtValue2.Clear()
            txtOutputNumber.Clear()
            txtValue2.BackColor = Color.White
        Else
            txtValue1.Clear()
            txtValue2.Clear()
            txtOutputNumber.Clear()
        End If
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        End
    End Sub
End Class
