<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDriversLicense
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
        Me.picCars = New System.Windows.Forms.PictureBox()
        Me.btnPressMe = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.lblOutputText = New System.Windows.Forms.Label()
        CType(Me.picCars, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCars
        '
        Me.picCars.Location = New System.Drawing.Point(567, 123)
        Me.picCars.Name = "picCars"
        Me.picCars.Size = New System.Drawing.Size(100, 50)
        Me.picCars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picCars.TabIndex = 0
        Me.picCars.TabStop = False
        '
        'btnPressMe
        '
        Me.btnPressMe.AutoSize = True
        Me.btnPressMe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnPressMe.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPressMe.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.25!)
        Me.btnPressMe.Location = New System.Drawing.Point(551, 63)
        Me.btnPressMe.Name = "btnPressMe"
        Me.btnPressMe.Size = New System.Drawing.Size(334, 54)
        Me.btnPressMe.TabIndex = 1
        Me.btnPressMe.Text = "Press Me to Start!"
        Me.btnPressMe.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Lime
        Me.btnReset.Location = New System.Drawing.Point(1390, 591)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnEnd
        '
        Me.btnEnd.BackColor = System.Drawing.Color.Red
        Me.btnEnd.Location = New System.Drawing.Point(1458, -2)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(21, 23)
        Me.btnEnd.TabIndex = 3
        Me.btnEnd.Text = "X"
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'lblOutputText
        '
        Me.lblOutputText.AutoSize = True
        Me.lblOutputText.BackColor = System.Drawing.Color.DodgerBlue
        Me.lblOutputText.Location = New System.Drawing.Point(621, 311)
        Me.lblOutputText.Name = "lblOutputText"
        Me.lblOutputText.Size = New System.Drawing.Size(0, 13)
        Me.lblOutputText.TabIndex = 4
        '
        'frmDriversLicense
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1477, 626)
        Me.Controls.Add(Me.lblOutputText)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnPressMe)
        Me.Controls.Add(Me.picCars)
        Me.Name = "frmDriversLicense"
        Me.Text = "Form1"
        CType(Me.picCars, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picCars As PictureBox
    Friend WithEvents btnPressMe As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnEnd As Button
    Friend WithEvents lblOutputText As Label
End Class
