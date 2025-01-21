Public Class frmLooping
    Private Sub btn1to10_Click(sender As Object, e As EventArgs) Handles btn1to10.Click
        'Clear the contents of the listbox
        lstNumbers.Items.Clear()
        'Create a variable for looping
        Dim intCounting As Integer
        'Create a loop that counts to 10
        For intCounting = 1 To 10
            'Add numbers to the listbox
            lstNumbers.Items.Add(intCounting)
        Next
    End Sub

    Private Sub btn1to100_Click(sender As Object, e As EventArgs) Handles btn1to100.Click
        'Clear the contents of the listbox
        lstNumbers.Items.Clear()
        'Create a variable for looping
        Dim intCounting As Integer
        'Create a variable for looping
        For intCounting = 1 To 100
            'Add numbers to the listbox
            lstNumbers.Items.Add(intCounting)
        Next
    End Sub

    Private Sub btnEvensto100_Click(sender As Object, e As EventArgs) Handles btnEvensto100.Click
        'Clear the contents of the listbox
        lstNumbers.Items.Clear()
        'Create a variable for looping
        Dim intCounting As Integer
        'Create a loop that counts evens to 100
        For intCounting = 2 To 100 Step 2
            'Add numbers to listbox
            lstNumbers.Items.Add(intCounting)
        Next
    End Sub

    Private Sub btn100to1_Click(sender As Object, e As EventArgs) Handles btn100to1.Click
        'Clear the contents of the listbox
        lstNumbers.Items.Clear()
        'Create a variable for looping
        Dim intCounting As Integer
        For intCounting = 100 To 1 Step -1
            'Add numbers to listbox
            lstNumbers.Items.Add(intCounting)
        Next
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear the contents of the listbox
        lstNumbers.Items.Clear()
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        End
    End Sub
End Class
