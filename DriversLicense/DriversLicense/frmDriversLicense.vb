Public Class frmDriversLicense
    Private Sub btnPressMe_Click(sender As Object, e As EventArgs) Handles btnPressMe.Click

        'Im going to declare the variables like str and int
        Dim strFirstName As String
        Dim intAgeResult As Integer
        Dim intAge As Integer
        Dim strPromptOne = "Hello, what is your name?"

        'Open input box
        strFirstName = InputBox(strPromptOne)
        'If there is no name
        If strFirstName = "" Then
            MsgBox("Please enter your name", MsgBoxStyle.Critical)
            strFirstName = InputBox(strPromptOne)
        End If

        Dim strPromptTwo = "Hello " & strFirstName & ". How old are you?"
        intAge = InputBox(strPromptTwo)


        'If age is over or under 16
        If intAge < 16 Then
            intAgeResult = 16 - intAge
            picCars.Load(Application.StartupPath + "\Dodge Hellcat.jpg")
            lblOutputText.Text = strFirstName & ", you can drive this car in " & intAgeResult & " year(s)."
        Else
            intAgeResult = intAge - 16
            picCars.Load(Application.StartupPath + "\Evo 8.jpg")
            lblOutputText.Text = strFirstName & ", you've been driving this car for " & intAgeResult & " year(s)."
        End If
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        End
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lblOutputText.Text = ""
        picCars.Image = Nothing
    End Sub


End Class
