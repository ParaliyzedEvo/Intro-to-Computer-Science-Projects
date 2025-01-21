Public Class frmLeisureGames
    'Declare Variables
    Dim strActivity As String
    Dim intCaloriesBurned As Integer
    Dim intMinutesPlayed As Integer
    Dim intTotalCaloriesBurned As Integer
    'I want to create items for the cboActivity dropdown
    'Remember cbo is ComboBox
    Private Sub frmLeisureGames_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cboActivity.Text = "Choose an activity!"
        cboActivity.Items.Add("Darts")
        cboActivity.Items.Add("Billards")
        cboActivity.Items.Add("Cards")
        cboActivity.Items.Add("Golf")
        cboMinutesPlayed.Text = "Choose the time played!"
        cboMinutesPlayed.Items.Add("30 Minutes")
        cboMinutesPlayed.Items.Add("1 hour")
        cboMinutesPlayed.Items.Add("2 hours")
    End Sub

    Private Sub cboActivity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboActivity.SelectedIndexChanged
        strActivity = cboActivity.Text
        cboActivity.BackColor = Color.White
        Select Case strActivity
            Case "Darts"
                picActivityType.Load(Application.StartupPath + "\Pictures\Darts.jpg")
                lblActivityType.Text = "Darts"
                intCaloriesBurned = 3
            Case "Billards"
                picActivityType.Load(Application.StartupPath + "\Pictures\Billards.jpg")
                lblActivityType.Text = "Billards"
                intCaloriesBurned = 5
            Case "Cards"
                picActivityType.Load(Application.StartupPath + "\Pictures\Cards.jpg")
                lblActivityType.Text = "Cards"
                intCaloriesBurned = 1
            Case "Golf"
                picActivityType.Load(Application.StartupPath + "\Pictures\Golf.jpg")
                lblActivityType.Text = "Golf"
                intCaloriesBurned = 8
        End Select
    End Sub

    Private Sub cboMinutesPlayed_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMinutesPlayed.SelectedIndexChanged
        cboMinutesPlayed.BackColor = Color.White
        'Create cases for 30 minutes, 1 hour, and 2 hours
        Select Case cboMinutesPlayed.Text
            Case "30 Minutes"
                intMinutesPlayed = 30
            Case "1 hour"
                intMinutesPlayed = 60
            Case "2 hours"
                intMinutesPlayed = 120
        End Select
    End Sub

    Private Sub btnCalculateCalories_Click(sender As Object, e As EventArgs) Handles btnCalculateCalories.Click
        If cboActivity.Text = "Choose an activity!" Then
            MsgBox("Please choose an activity", MsgBoxStyle.Critical)
            cboActivity.BackColor = Color.Red
            Exit Sub
        End If
        If cboMinutesPlayed.Text = "Choose the time played!" Then
            MsgBox("Please choose the time played", MsgBoxStyle.Critical)
            cboMinutesPlayed.BackColor = Color.Red
            Exit Sub
        End If
        intTotalCaloriesBurned = intCaloriesBurned * intMinutesPlayed
        lblTotalCaloriesBurned.Text = "You burned " & intTotalCaloriesBurned & " calories!"
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        End
    End Sub
End Class
