<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRandomNumber
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
        Me.lblRndFunction = New System.Windows.Forms.Label()
        Me.lblShift = New System.Windows.Forms.Label()
        Me.txtRandomNumber = New System.Windows.Forms.TextBox()
        Me.txtShift = New System.Windows.Forms.TextBox()
        Me.btn1to10 = New System.Windows.Forms.Button()
        Me.btn1to100 = New System.Windows.Forms.Button()
        Me.btn3to7 = New System.Windows.Forms.Button()
        Me.btn15to30 = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblRndFunction
        '
        Me.lblRndFunction.AutoSize = True
        Me.lblRndFunction.Location = New System.Drawing.Point(97, 113)
        Me.lblRndFunction.Name = "lblRndFunction"
        Me.lblRndFunction.Size = New System.Drawing.Size(71, 13)
        Me.lblRndFunction.TabIndex = 0
        Me.lblRndFunction.Text = "Rnd Function"
        '
        'lblShift
        '
        Me.lblShift.AutoSize = True
        Me.lblShift.Location = New System.Drawing.Point(97, 203)
        Me.lblShift.Name = "lblShift"
        Me.lblShift.Size = New System.Drawing.Size(28, 13)
        Me.lblShift.TabIndex = 1
        Me.lblShift.Text = "Shift"
        '
        'txtRandomNumber
        '
        Me.txtRandomNumber.Location = New System.Drawing.Point(243, 106)
        Me.txtRandomNumber.Name = "txtRandomNumber"
        Me.txtRandomNumber.Size = New System.Drawing.Size(198, 20)
        Me.txtRandomNumber.TabIndex = 2
        '
        'txtShift
        '
        Me.txtShift.Location = New System.Drawing.Point(243, 203)
        Me.txtShift.Name = "txtShift"
        Me.txtShift.Size = New System.Drawing.Size(198, 20)
        Me.txtShift.TabIndex = 3
        '
        'btn1to10
        '
        Me.btn1to10.Location = New System.Drawing.Point(50, 401)
        Me.btn1to10.Name = "btn1to10"
        Me.btn1to10.Size = New System.Drawing.Size(75, 23)
        Me.btn1to10.TabIndex = 4
        Me.btn1to10.Text = "1 to 10"
        Me.btn1to10.UseVisualStyleBackColor = True
        '
        'btn1to100
        '
        Me.btn1to100.Location = New System.Drawing.Point(179, 401)
        Me.btn1to100.Name = "btn1to100"
        Me.btn1to100.Size = New System.Drawing.Size(75, 23)
        Me.btn1to100.TabIndex = 5
        Me.btn1to100.Text = "1 to 100"
        Me.btn1to100.UseVisualStyleBackColor = True
        '
        'btn3to7
        '
        Me.btn3to7.Location = New System.Drawing.Point(305, 401)
        Me.btn3to7.Name = "btn3to7"
        Me.btn3to7.Size = New System.Drawing.Size(75, 23)
        Me.btn3to7.TabIndex = 6
        Me.btn3to7.Text = "3 to 7"
        Me.btn3to7.UseVisualStyleBackColor = True
        '
        'btn15to30
        '
        Me.btn15to30.Location = New System.Drawing.Point(436, 401)
        Me.btn15to30.Name = "btn15to30"
        Me.btn15to30.Size = New System.Drawing.Size(75, 23)
        Me.btn15to30.TabIndex = 7
        Me.btn15to30.Text = "15 to 30"
        Me.btn15to30.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.BackColor = System.Drawing.Color.Red
        Me.btnEnd.Location = New System.Drawing.Point(713, 415)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 8
        Me.btnEnd.Text = "End"
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'frmRandomNumber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btn15to30)
        Me.Controls.Add(Me.btn3to7)
        Me.Controls.Add(Me.btn1to100)
        Me.Controls.Add(Me.btn1to10)
        Me.Controls.Add(Me.txtShift)
        Me.Controls.Add(Me.txtRandomNumber)
        Me.Controls.Add(Me.lblShift)
        Me.Controls.Add(Me.lblRndFunction)
        Me.Name = "frmRandomNumber"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRndFunction As Label
    Friend WithEvents lblShift As Label
    Friend WithEvents txtRandomNumber As TextBox
    Friend WithEvents txtShift As TextBox
    Friend WithEvents btn1to10 As Button
    Friend WithEvents btn1to100 As Button
    Friend WithEvents btn3to7 As Button
    Friend WithEvents btn15to30 As Button
    Friend WithEvents btnEnd As Button
End Class
