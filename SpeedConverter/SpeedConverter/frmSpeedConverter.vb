Public Class frmSpeedConverter
    Dim intMPH As Integer
    Dim intKPH As Integer

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        End
    End Sub

    Private Sub hsbSpeedConverter_Scroll(sender As Object, e As ScrollEventArgs) Handles hsbSpeedConverter.Scroll
        'Store the scroll bar value into intMPH
        intMPH = hsbSpeedConverter.Value
        'Display the value of intMPH to lblOutputMPH
        lblOutputMPH.Text = intMPH
        'Find the conversion for KPH
        intKPH = intMPH * 1.6093
        'Display the value of intKPH to lblOutputKPH
        lblOutputKPH.Text = intKPH
        'Display picture based on the range of intMPH
        Select Case intMPH
            Case 0 To 30
                picSnail.Load(Application.StartupPath + "\Pictures\Snail.jpg")
                picKangaroo.Image = Nothing
                picCheetah.Image = Nothing
            Case 31 To 60
                picKangaroo.Load(Application.StartupPath + "\Pictures\Kangaroo.jpg")
                picSnail.Image = Nothing
                picCheetah.Image = Nothing
            Case 61 To 100
                picCheetah.Load(Application.StartupPath + "\Pictures\Cheetah.jpg")
                picSnail.Image = Nothing
                picKangaroo.Image = Nothing
        End Select
    End Sub
End Class
