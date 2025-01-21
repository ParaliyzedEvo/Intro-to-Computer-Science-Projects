Public Class frmCarLoan
    'Variables
    Dim strCars As String
    Dim dblCarPrice As Double
    Dim dblDownPayment As Double
    Dim dblRemainingPayment As Double
    Dim dblMonthlyPayment As Double
    Dim dblMonthsPaying As Double
    'Loading in cbo choices
    Private Sub frmCarLoan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cboCarSelect.Text = "Choose a car!"
        cboCarSelect.Items.Add("2023 Dodge Hellcat")
        cboCarSelect.Items.Add("2003 Mitsubishi Evo 8")
        cboCarSelect.Items.Add("2009 Toyota Supra")
        cboCarSelect.Items.Add("2023 Lamborghini Aventador")
        cboCarSelect.Items.Add("2011 Pagani Huayra")
        cboPayments.Text = "Choose how many payments you want to pay per month!"
        cboPayments.Items.Add("1 year")
        cboPayments.Items.Add("2 years")
        cboPayments.Items.Add("3 years")
        cboPayments.Items.Add("4 years")
        cboPayments.Items.Add("5 years")
    End Sub
    'Cases for Car Select
    Private Sub cboCarSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCarSelect.SelectedIndexChanged
        strCars = cboCarSelect.Text
        cboCarSelect.BackColor = Color.White
        Select Case strCars
            Case "2023 Dodge Hellcat"
                picCars.Load(Application.StartupPath + "\Pictures\Dodge Hellcat.jpg")
                picLogo.Load(Application.StartupPath + "\Pictures\Dodge Logo.jpg")
                lblCars.Text = "Dodge Hellcat"
                lblPriceOfCars.Text = "$85,250"
                dblCarPrice = 85250
                cboCarSelect.BackColor = Color.White
            Case "2003 Mitsubishi Evo 8"
                picCars.Load(Application.StartupPath + "\Pictures\Evo 8.jpg")
                picLogo.Load(Application.StartupPath + "\Pictures\Mitsubishi Logo.jpg")
                lblCars.Text = "Mitsubishi Evo 8"
                lblPriceOfCars.Text = "$28,589"
                dblCarPrice = 28589
                cboCarSelect.BackColor = Color.White
            Case "2009 Toyota Supra"
                picCars.Load(Application.StartupPath + "\Pictures\Supra.jpg")
                picLogo.Load(Application.StartupPath + "\Pictures\Supra Logo.jpg")
                lblCars.Text = "Toyota Supra"
                lblPriceOfCars.Text = "$144,995"
                dblCarPrice = 144995
                cboCarSelect.BackColor = Color.White
            Case "2023 Lamborghini Aventador"
                picCars.Load(Application.StartupPath + "\Pictures\Lamborghini.jpg")
                picLogo.Load(Application.StartupPath + "\Pictures\Lamborghini Logo.jpg")
                lblCars.Text = "Lamborghini Aventador"
                lblPriceOfCars.Text = "$825,914"
                dblCarPrice = 825914
                cboCarSelect.BackColor = Color.White
            Case "2011 Pagani Huayra"
                picCars.Load(Application.StartupPath + "\Pictures\Pagani.jpg")
                picLogo.Load(Application.StartupPath + "\Pictures\Pagani Logo.jpg")
                lblCars.Text = "Pagani Huayra"
                lblPriceOfCars.Text = "$2.6 Million"
                dblCarPrice = 2600000
                cboCarSelect.BackColor = Color.White
        End Select
    End Sub
    'Cases for car payments
    Private Sub cboPayments_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPayments.SelectedIndexChanged
        Select Case cboPayments.Text
            Case "1 year"
                dblMonthsPaying = 12
                cboPayments.BackColor = Color.White
            Case "2 years"
                dblMonthsPaying = 24
                cboPayments.BackColor = Color.White
            Case "3 years"
                dblMonthsPaying = 36
                cboPayments.BackColor = Color.White
            Case "4 years"
                dblMonthsPaying = 48
                cboPayments.BackColor = Color.White
            Case "5 years"
                dblMonthsPaying = 60
                cboPayments.BackColor = Color.White
        End Select
    End Sub
    'The math and error codes for the thingy
    Private Sub btnMonthlyPayment_Click(sender As Object, e As EventArgs) Handles btnMonthlyPayment.Click
        txtDownPayment.BackColor = Color.White
        If cboCarSelect.Text = "Choose a car!" Then
            MsgBox("Please choose a car.", MsgBoxStyle.Critical)
            cboCarSelect.BackColor = Color.Red
            Exit Sub
        End If
        If txtDownPayment.Text = "" Then
            MsgBox("Please put in a down payment.", MsgBoxStyle.Critical)
            txtDownPayment.BackColor = Color.Red
            Exit Sub
        End If
        dblDownPayment = txtDownPayment.Text
        If cboPayments.Text = "Choose how many payments you want to pay per month!" Then
            MsgBox("Please choose how many payments you want to pay.", MsgBoxStyle.Critical)
            cboPayments.BackColor = Color.Red
            Exit Sub
        End If
        dblRemainingPayment = dblCarPrice - dblDownPayment
        dblMonthlyPayment = dblRemainingPayment * (0.06 / 12) / (1 - (1 + (0.06 / 12)) ^ (-dblMonthsPaying))
        txtMonthlyPayment.Text = "Your monthly payment is " & FormatCurrency(dblMonthlyPayment, NumDigitsAfterDecimal:=2)
    End Sub
    'End
    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        End
    End Sub
End Class
