Public Class frmIdk
    'Create an array to hold games
    Dim intTemps(7) As Integer
    'Create a variable for the search term
    Dim strSearchTerm As String

    Private Sub btnEnterGames_Click(sender As Object, e As EventArgs) Handles btnEnterTemps.Click
        'Prompt user for games to be added
        For x = 0 To 6
            'Fill array
            intTemps(x) = InputBox("Enter temperature for day #" & (x + 1) & ":")
            lstTemperatures.Items.Add("Day: " & (x + 1) & "                Temp: " & intTemps(x) & " degree(s)")
        Next
    End Sub
    Private Sub btnBubbleSort_Click(sender As Object, e As EventArgs) Handles btnSortTemps.Click
        'Variable as temporary storage
        Dim strTempTemps As String
        For x = 0 To 6
            For y = 0 To 5
                If intTemps(y) > intTemps(y + 1) Then
                    'Game move to temp
                    strTempTemps = intTemps(y)
                    'Game replaces previous game
                    intTemps(y) = intTemps(y + 1)
                    'Move game into temp to spot in the array
                    intTemps(y + 1) = strTempTemps
                End If
            Next
        Next
        'Display the shorted array into the listbox
        lstSorted.Items.Add("Temperatures in Order:")
        For x = 0 To 6
            lstSorted.Items.Add(intTemps(x) & " degree(s)")
        Next
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear the list boxes
        lstTemperatures.Items.Clear()
        lstResults.Items.Clear()
        lstSorted.Items.Clear()
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        'End
        End
    End Sub

    Private Sub btnAverage_Click(sender As Object, e As EventArgs) Handles btnAverage.Click
        'Check if there are at 7 numbers in lstTemperatures
        If lstTemperatures.Items.Count <> 7 Then
            MessageBox.Show("Please enter 7 numbers before calculating the average temperature.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        'Transfer valid numbers from lstSorted to intTemps array
        Dim intValidCount As Integer = 0
        For i As Integer = 0 To 7
            Dim strItem As String = lstSorted.Items(i).ToString()
            'Extract the numbers only and check if the numbers are valid
            If Integer.TryParse(strItem, intTemps(intValidCount)) Then
                intValidCount += 1
            End If
        Next
        'Calculate the average
        Dim Average As Double = intTemps.Average()
        'Show results
        lstResults.Items.Add($"Temperature Average: {Average:F2} degrees")
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'Ask user to enter a game to search for
        strSearchTerm = InputBox("What temperature on what day are you looking for?")
        'Create a loop to check for matching games
        For x = 0 To 6
            If LCase(intTemps(x)) = LCase(strSearchTerm) Then
                lstResults.Items.Add("The temperature on day " & (x + 1) & " was " & strSearchTerm & " degree(s)")
            End If
        Next
    End Sub
End Class
