Module Module1
    'Create variables to shuffle numbers
    Public intOriginal(7) As Integer
    Public intMixed(7) As Integer
    'Create object arrays for the game board
    Public pic(7) As PictureBox
    Public btn(7) As Button
    'Create variables to check for match
    Public intGuess1 As Integer
    Public intGuess2 As Integer
    Public bolMatch As Boolean
    Public bolSecondClick As Boolean
    Public intMatchCount As Integer
    Public intRandomSlot As Integer
    Public Sub TotallyAwesomeNewGame()
        'Mix up the pictures
        Call MixedPictures()
        'Display pictures
        pic(intMixed(0)).Image = Image.FromFile(Application.StartupPath & "\Pictures\Mrekk.jpg")
        pic(intMixed(1)).Image = Image.FromFile(Application.StartupPath & "\Pictures\Mrekk.jpg")
        pic(intMixed(2)).Image = Image.FromFile(Application.StartupPath & "\Pictures\Whitecat.jpg")
        pic(intMixed(3)).Image = Image.FromFile(Application.StartupPath & "\Pictures\Whitecat.jpg")
        pic(intMixed(4)).Image = Image.FromFile(Application.StartupPath & "\Pictures\BTMC.png")
        pic(intMixed(5)).Image = Image.FromFile(Application.StartupPath & "\Pictures\BTMC.png")
        pic(intMixed(6)).Image = Image.FromFile(Application.StartupPath & "\Pictures\Cookiezi.jpg")
        pic(intMixed(7)).Image = Image.FromFile(Application.StartupPath & "\Pictures\Cookiezi.jpg")
    End Sub
    Public Sub MixedPictures()
        For i = 0 To 7
            intMixed(i) = -1
            intOriginal(i) = i
        Next
        For i = 0 To 7
            CalcRandomSlot()
            intMixed(intRandomSlot) = intOriginal(i)
        Next
    End Sub
    Private Sub CalcRandomSlot()
        Randomize()
        Dim isSlotAvailable As Boolean = False
        intRandomSlot = -1
        While isSlotAvailable = False
            intRandomSlot = Int(Rnd() * 8)
            If intMixed(intRandomSlot) = -1 Then
                isSlotAvailable = True
            End If
        End While
    End Sub
    'Create a sub-routine to check if there is a match
    Public Sub CheckForMatch()
        For x = 0 To 6 Step 2
            If intGuess1 = intMixed(x) And intGuess2 = intMixed(x + 1) Or intGuess1 = intMixed(x + 1) And intGuess2 = intmixed(x) Then
                bolMatch = True
            End If
        Next
    End Sub
End Module
