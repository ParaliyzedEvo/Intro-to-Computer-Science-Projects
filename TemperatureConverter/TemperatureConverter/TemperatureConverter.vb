Public Class TemperatureConverter
    Dim intC As Integer
    Dim intF As Integer
    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        End
    End Sub

    Private Sub hsbTemperatureConverter_Scroll(sender As Object, e As ScrollEventArgs) Handles hsbTemperatureConverter.Scroll
        'Store the scroll bar value into intF
        intF = hsbTemperatureConverter.Value
        'Display the value of intF to lblOutputF
        lblOutputF.Text = intF
        'Find the conversion for C
        intC = (intF - 32) * 5 / 9
        'Display the value of intC to lblOutputC
        lblOutputC.Text = intC
        'Display picture based on the range of intK
        Select Case intF
            Case 0 To 32
                picWinter.Load(Application.StartupPath + "\Pictures\Winter.jpg")
                picBackgroundImage.Load(Application.StartupPath + "\Pictures\WisconsinWinter.jpg")
                picFall.Image = Nothing
                picSpring.Image = Nothing
                picSummer.Image = Nothing
            Case 33 To 50
                picFall.Load(Application.StartupPath + "\Pictures\Fall.jpg")
                picBackgroundImage.Load(Application.StartupPath + "\Pictures\WisconsinFall.jpg")
                picWinter.Image = Nothing
                picSpring.Image = Nothing
                picSummer.Image = Nothing
            Case 51 To 70
                picSpring.Load(Application.StartupPath + "\Pictures\Spring.jpg")
                picBackgroundImage.Load(Application.StartupPath + "\Pictures\WisconsinSpring.jpg")
                picFall.Image = Nothing
                picWinter.Image = Nothing
                picSummer.Image = Nothing
            Case 71 To 134
                picSummer.Load(Application.StartupPath + "\Pictures\Summer.jpg")
                picBackgroundImage.Load(Application.StartupPath + "\Pictures\WisconsinSummer.jpg")
                picFall.Image = Nothing
                picWinter.Image = Nothing
                picSpring.Image = Nothing
        End Select
    End Sub
End Class
