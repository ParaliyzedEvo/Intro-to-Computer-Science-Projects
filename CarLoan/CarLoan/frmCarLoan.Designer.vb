<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarLoan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnMonthlyPayment = New System.Windows.Forms.Button()
        Me.cboPayments = New System.Windows.Forms.ComboBox()
        Me.cboCarSelect = New System.Windows.Forms.ComboBox()
        Me.picCars = New System.Windows.Forms.PictureBox()
        Me.txtDownPayment = New System.Windows.Forms.TextBox()
        Me.lblCarPrice = New System.Windows.Forms.Label()
        Me.lblCarSelect = New System.Windows.Forms.Label()
        Me.lblDownPayment = New System.Windows.Forms.Label()
        Me.lblLoan = New System.Windows.Forms.Label()
        Me.lblCars = New System.Windows.Forms.Label()
        Me.lblPriceOfCars = New System.Windows.Forms.Label()
        Me.txtMonthlyPayment = New System.Windows.Forms.TextBox()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        CType(Me.picCars, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMonthlyPayment
        '
        Me.btnMonthlyPayment.BackColor = System.Drawing.Color.Lime
        Me.btnMonthlyPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btnMonthlyPayment.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnMonthlyPayment.Location = New System.Drawing.Point(218, 373)
        Me.btnMonthlyPayment.Name = "btnMonthlyPayment"
        Me.btnMonthlyPayment.Size = New System.Drawing.Size(146, 30)
        Me.btnMonthlyPayment.TabIndex = 0
        Me.btnMonthlyPayment.Text = "Monthly Payment"
        Me.btnMonthlyPayment.UseVisualStyleBackColor = False
        '
        'cboPayments
        '
        Me.cboPayments.FormattingEnabled = True
        Me.cboPayments.Location = New System.Drawing.Point(182, 335)
        Me.cboPayments.Name = "cboPayments"
        Me.cboPayments.Size = New System.Drawing.Size(214, 21)
        Me.cboPayments.TabIndex = 1
        '
        'cboCarSelect
        '
        Me.cboCarSelect.FormattingEnabled = True
        Me.cboCarSelect.Location = New System.Drawing.Point(182, 173)
        Me.cboCarSelect.Name = "cboCarSelect"
        Me.cboCarSelect.Size = New System.Drawing.Size(214, 21)
        Me.cboCarSelect.TabIndex = 2
        '
        'picCars
        '
        Me.picCars.Location = New System.Drawing.Point(653, 72)
        Me.picCars.Name = "picCars"
        Me.picCars.Size = New System.Drawing.Size(716, 366)
        Me.picCars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCars.TabIndex = 3
        Me.picCars.TabStop = False
        '
        'txtDownPayment
        '
        Me.txtDownPayment.Location = New System.Drawing.Point(182, 252)
        Me.txtDownPayment.Name = "txtDownPayment"
        Me.txtDownPayment.Size = New System.Drawing.Size(214, 20)
        Me.txtDownPayment.TabIndex = 4
        '
        'lblCarPrice
        '
        Me.lblCarPrice.AutoSize = True
        Me.lblCarPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.lblCarPrice.Location = New System.Drawing.Point(965, 451)
        Me.lblCarPrice.Name = "lblCarPrice"
        Me.lblCarPrice.Size = New System.Drawing.Size(135, 31)
        Me.lblCarPrice.TabIndex = 5
        Me.lblCarPrice.Text = "Car Price:"
        '
        'lblCarSelect
        '
        Me.lblCarSelect.AutoSize = True
        Me.lblCarSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.lblCarSelect.Location = New System.Drawing.Point(225, 136)
        Me.lblCarSelect.Name = "lblCarSelect"
        Me.lblCarSelect.Size = New System.Drawing.Size(132, 25)
        Me.lblCarSelect.TabIndex = 6
        Me.lblCarSelect.Text = "Select A Car"
        '
        'lblDownPayment
        '
        Me.lblDownPayment.AutoSize = True
        Me.lblDownPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.lblDownPayment.Location = New System.Drawing.Point(213, 215)
        Me.lblDownPayment.Name = "lblDownPayment"
        Me.lblDownPayment.Size = New System.Drawing.Size(156, 25)
        Me.lblDownPayment.TabIndex = 7
        Me.lblDownPayment.Text = "Down Payment"
        '
        'lblLoan
        '
        Me.lblLoan.AutoSize = True
        Me.lblLoan.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.lblLoan.Location = New System.Drawing.Point(233, 294)
        Me.lblLoan.Name = "lblLoan"
        Me.lblLoan.Size = New System.Drawing.Size(119, 25)
        Me.lblLoan.TabIndex = 8
        Me.lblLoan.Text = "Loan is 6%"
        '
        'lblCars
        '
        Me.lblCars.AutoSize = True
        Me.lblCars.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.25!)
        Me.lblCars.Location = New System.Drawing.Point(831, 9)
        Me.lblCars.Name = "lblCars"
        Me.lblCars.Size = New System.Drawing.Size(0, 44)
        Me.lblCars.TabIndex = 9
        '
        'lblPriceOfCars
        '
        Me.lblPriceOfCars.AutoSize = True
        Me.lblPriceOfCars.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblPriceOfCars.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.lblPriceOfCars.Location = New System.Drawing.Point(985, 482)
        Me.lblPriceOfCars.Name = "lblPriceOfCars"
        Me.lblPriceOfCars.Size = New System.Drawing.Size(0, 29)
        Me.lblPriceOfCars.TabIndex = 10
        '
        'txtMonthlyPayment
        '
        Me.txtMonthlyPayment.Location = New System.Drawing.Point(182, 418)
        Me.txtMonthlyPayment.Name = "txtMonthlyPayment"
        Me.txtMonthlyPayment.ReadOnly = True
        Me.txtMonthlyPayment.Size = New System.Drawing.Size(214, 20)
        Me.txtMonthlyPayment.TabIndex = 11
        Me.txtMonthlyPayment.Text = "$0.00"
        Me.txtMonthlyPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnEnd
        '
        Me.btnEnd.BackColor = System.Drawing.Color.Red
        Me.btnEnd.Location = New System.Drawing.Point(1456, -4)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(24, 23)
        Me.btnEnd.TabIndex = 12
        Me.btnEnd.Text = "X"
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.Location = New System.Drawing.Point(1260, 444)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(175, 164)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 13
        Me.picLogo.TabStop = False
        '
        'frmCarLoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(1476, 626)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.txtMonthlyPayment)
        Me.Controls.Add(Me.lblPriceOfCars)
        Me.Controls.Add(Me.lblCars)
        Me.Controls.Add(Me.lblLoan)
        Me.Controls.Add(Me.lblDownPayment)
        Me.Controls.Add(Me.lblCarSelect)
        Me.Controls.Add(Me.lblCarPrice)
        Me.Controls.Add(Me.txtDownPayment)
        Me.Controls.Add(Me.picCars)
        Me.Controls.Add(Me.cboCarSelect)
        Me.Controls.Add(Me.cboPayments)
        Me.Controls.Add(Me.btnMonthlyPayment)
        Me.Name = "frmCarLoan"
        Me.Text = "Form1"
        CType(Me.picCars, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMonthlyPayment As Button
    Friend WithEvents cboPayments As ComboBox
    Friend WithEvents cboCarSelect As ComboBox
    Friend WithEvents picCars As PictureBox
    Friend WithEvents txtDownPayment As TextBox
    Friend WithEvents lblCarPrice As Label
    Friend WithEvents lblCarSelect As Label
    Friend WithEvents lblDownPayment As Label
    Friend WithEvents lblLoan As Label
    Friend WithEvents lblCars As Label
    Friend WithEvents lblPriceOfCars As Label
    Friend WithEvents txtMonthlyPayment As TextBox
    Friend WithEvents btnEnd As Button
    Friend WithEvents picLogo As PictureBox
End Class
