Public Class frmSearchSort
    'Create an array to hold games
    Dim strGames(5) As String
    'Create a variable for the search term
    Dim strSearchTerm As String

    Private Sub btnEnterGames_Click(sender As Object, e As EventArgs) Handles btnEnterGames.Click
        'Prompt user for games to be added
        For x = 0 To 4
            'Fill array
            strGames(x) = InputBox("Enter a Game #" & (x + 1) & ":")
            lstGames.Items.Add(strGames(x))
        Next
    End Sub

    Private Sub btnLinearSearch_Click(sender As Object, e As EventArgs) Handles btnLinearSearch.Click
        'Ask user to enter a game to search for
        strSearchTerm = InputBox("What game are you searching for?")
        'Create a loop to check for matching games
        For x = 0 To 4
            If LCase(strGames(x)) = LCase(strSearchTerm) Then
                lstResults.Items.Add(strSearchTerm & " is game " & (x + 1))
            End If
        Next
    End Sub

    Private Sub btnBubbleSort_Click(sender As Object, e As EventArgs) Handles btnBubbleSort.Click
        'Variable as temporary storage
        Dim strTempGames As String
        For x = 0 To 4
            For y = 0 To 3
                If strGames(y) > strGames(y + 1) Then
                    'Game move to temp
                    strTempGames = strGames(y)
                    'Game replaces previous game
                    strGames(y) = strGames(y + 1)
                    'Move game into temp to spot in the array
                    strGames(y + 1) = strTempGames
                End If
            Next
        Next
        'Display the shorted array into the listbox
        For x = 0 To 4
            lstSorted.Items.Add(strGames(x))
        Next
    End Sub

    Private Sub btnBinarySearch_Click(sender As Object, e As EventArgs) Handles btnBinarySearch.Click
        'Declare 4 new variables
        Dim intTopList As Integer
        Dim intBottomList As Integer
        Dim intGuess As Integer
        Dim intGameNumberFound As Integer
        'Define top and bottom range values
        intTopList = 0
        intBottomList = 4
        strSearchTerm = InputBox("What game are you looking for?")
        'Do while the top range is less than the bottom range
        Do While intTopList <= intBottomList
            'First guess
            intGuess = (intTopList + intBottomList) / 2
            'Check for accuracy of guess
            If strSearchTerm = strGames(intGuess) Then
                intGameNumberFound = intGuess + 1
                'End the loop by making intBottomList smaller than the top
                intTopList = intBottomList + 1
            Else
                'If the game is less than the guess
                If strSearchTerm < strGames(intGuess) Then
                    'Change the bottom range
                    intBottomList = intGuess - 1
                Else
                    If strSearchTerm > strGames(intGuess) Then
                        intTopList = intGuess + 1
                    End If
                End If
            End If
        Loop
        'Display the results of the binary search
        lstResults.Items.Add(strSearchTerm & " is game number " & intGameNumberFound)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstGames.Items.Clear()
        lstResults.Items.Clear()
        lstSorted.Items.Clear()
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        End
    End Sub
End Class
