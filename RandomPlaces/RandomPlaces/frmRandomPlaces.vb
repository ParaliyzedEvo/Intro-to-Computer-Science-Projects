Public Class frmRandomPlaces
    'Create an array of picture boxes
    Dim picArray(3) As PictureBox
    Private Sub frmRandomPlaces_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Define the picture boxes in the array
        picArray = {pic1, pic2, pic3, pic4}
    End Sub

    Private Sub btnRandomPlaces_Click(sender As Object, e As EventArgs) Handles btnRandomPlaces.Click
        'Clear all picture boxes using a loop and array
        Dim x As Integer
        For x = 0 To 3
            picArray(x).Visible = False
        Next
        'Randomly place a picture in the array and on the screen
        Dim intRandomPick1, intRandomPick2 As Integer
        Randomize()
        'Randomly choose a number between 0 and 3
        intRandomPick1 = Int(Rnd() * 4)
        intRandomPick2 = Int(Rnd() * 4)
        'Place pictures randomly on form
        picArray(intRandomPick1).Visible = True
        picArray(intRandomPick2).Visible = True
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        End
    End Sub
End Class
