Public Class frmRandomSequence
    'Create two textbox arrays
    Dim txtOriginal(7) As TextBox
    Dim txtMixed(7) As TextBox
    Private Sub frmRandomSequence_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Define both textbox arrays
        txtOriginal = {txtOriginal1, txtOriginal2, txtOriginal3, txtOriginal4, txtOriginal5, txtOriginal6, txtOriginal7, txtOriginal8}
        txtMixed = {txtMixed1, txtMixed2, txtMixed3, txtMixed4, txtMixed5, txtMixed6, txtMixed7, txtMixed8}
    End Sub

    Private Sub btnFillOriginalArray_Click(sender As Object, e As EventArgs) Handles btnFillOriginalArray.Click
        'Create a loop that populates EACH textbox in order
        For x = 0 To 7
            txtOriginal(x).Text = x + 1
        Next
    End Sub

    Private Sub btnMixedArray_Click(sender As Object, e As EventArgs) Handles btnMixedArray.Click
        'Create a new array of integers that correlates to our array of textboxes
        Dim intOriginal(7) As Integer
        Dim intMixed(7) As Integer
        'Use a loop to fill intOriginal array with #1-8
        For x = 0 To 7
            intOriginal(x) = x + 1
            intMixed(x) = -1
        Next
        'Begin code for randomizing numbers
        Dim intRandomSlot As Integer = -1
        For x = 0 To 7
            Randomize()
            Dim isSlotAvailable As Boolean = False
            While isSlotAvailable = False
                intRandomSlot = Int(Rnd() * 8)
                If intMixed(intRandomSlot) = -1 Then
                    isSlotAvailable = True
                End If
            End While
            intMixed(intRandomSlot) = intOriginal(x)
        Next
        'Need to populate the text boxes with the random numbers stored in the intMixed array
        For x = 0 To 7
            txtMixed(x).Text = intMixed(x)
        Next
    End Sub
End Class
