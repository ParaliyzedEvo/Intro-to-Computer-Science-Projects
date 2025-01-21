Public Class frmHelloWorld
    Private Sub btnPressMe_Click(sender As Object, e As EventArgs) Handles btnPressMe.Click

        'We are going to create three strings and declare them as variables
        'Dim mean to declare a variable
        'str is a STRING, and a string is a word or words!

        Dim strFirstName As String
        Dim strResponse As String
        Dim strPromptOne = "Hello, what is your name?"
        'Let's start the real coding!

        'Open input box
        strFirstName = InputBox(strPromptOne)

        Dim strPromptTwo = "Hi " & strFirstName & ", do you like dogs?"

        'Load the message box
        strResponse = MsgBox(strPromptTwo, MsgBoxStyle.YesNo)

        If strResponse = MsgBoxResult.Yes Then
            lblOutputText.Text = "Dogs are awesome!"
            picYesNo.Load(Application.StartupPath + "\Dog.jpg")
        Else
            lblOutputText.Text = "You must a cat person!"
            picYesNo.Load(Application.StartupPath + "\Cat.jpg")
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lblOutputText.Text = ""
        picYesNo.Image = Nothing
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        End
    End Sub
End Class
