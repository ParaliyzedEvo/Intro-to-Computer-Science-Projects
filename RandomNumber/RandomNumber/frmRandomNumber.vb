Public Class frmRandomNumber
    Dim dblNumber As Double
    Private Sub btn1to10_Click(sender As Object, e As EventArgs) Handles btn1to10.Click
        'Turn on Random Number
        Randomize()
        'Put a randomly generated number in dbl between {0,1}
        dblNumber = Rnd()
        'Display the results in the textbox
        txtRandomNumber.Text = dblNumber
        'Multiply/truncate/shift our random number to get a mumber between 1 and 10
        txtShift.Text = Int(dblNumber * 10) + 1
    End Sub

    Private Sub btn1to100_Click(sender As Object, e As EventArgs) Handles btn1to100.Click
        'Turn on Random Number
        Randomize()
        'Put a randomly generated number in dbl between {0,1}
        dblNumber = Rnd()
        'Display the results in the textbox
        txtRandomNumber.Text = dblNumber
        'Multiply/truncate/shift our random number to get a mumber between 1 and 10
        txtShift.Text = Int(dblNumber * 100) + 1
    End Sub

    Private Sub btn3to7_Click(sender As Object, e As EventArgs) Handles btn3to7.Click
        'Turn on Random Number
        Randomize()
        'Put a randomly generated number in dbl between {0,1}
        dblNumber = Rnd()
        'Display the results in the textbox
        txtRandomNumber.Text = dblNumber
        'Multiply/truncate/shift our random number to get a mumber between 3 and 7
        txtShift.Text = Int(dblNumber * 5) + 3
    End Sub

    Private Sub btn15to30_Click(sender As Object, e As EventArgs) Handles btn15to30.Click
        'Turn on Random Number
        Randomize()
        'Put a randomly generated number in dbl between {0,1}
        dblNumber = Rnd()
        'Display the results in the textbox
        txtRandomNumber.Text = dblNumber
        'Multiply/truncate/shift our random number to get a mumber between 15 and 30
        txtShift.Text = Int(dblNumber * 16) + 15
        'Inside number is how many possible answers you can get (counting from 15 to 30 gives you 16 possible numbers)
        'Outside number by addition is your starting or lowest number
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        End
    End Sub
End Class
