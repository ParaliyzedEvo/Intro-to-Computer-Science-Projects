<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TemperatureConverter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TemperatureConverter))
        Me.hsbTemperatureConverter = New System.Windows.Forms.HScrollBar()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.picWisconsinState = New System.Windows.Forms.PictureBox()
        Me.picWinter = New System.Windows.Forms.PictureBox()
        Me.picFall = New System.Windows.Forms.PictureBox()
        Me.picSpring = New System.Windows.Forms.PictureBox()
        Me.picSummer = New System.Windows.Forms.PictureBox()
        Me.lblF = New System.Windows.Forms.Label()
        Me.lblC = New System.Windows.Forms.Label()
        Me.lblOutputF = New System.Windows.Forms.Label()
        Me.lblOutputC = New System.Windows.Forms.Label()
        Me.picBackgroundImage = New System.Windows.Forms.PictureBox()
        CType(Me.picWisconsinState, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWinter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSpring, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSummer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBackgroundImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'hsbTemperatureConverter
        '
        Me.hsbTemperatureConverter.Location = New System.Drawing.Point(467, 298)
        Me.hsbTemperatureConverter.Name = "hsbTemperatureConverter"
        Me.hsbTemperatureConverter.Size = New System.Drawing.Size(612, 15)
        Me.hsbTemperatureConverter.TabIndex = 0
        '
        'btnEnd
        '
        Me.btnEnd.BackColor = System.Drawing.Color.Red
        Me.btnEnd.Location = New System.Drawing.Point(1466, -2)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(19, 23)
        Me.btnEnd.TabIndex = 1
        Me.btnEnd.Text = "X"
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'picWisconsinState
        '
        Me.picWisconsinState.Image = CType(resources.GetObject("picWisconsinState.Image"), System.Drawing.Image)
        Me.picWisconsinState.Location = New System.Drawing.Point(467, 2)
        Me.picWisconsinState.Name = "picWisconsinState"
        Me.picWisconsinState.Size = New System.Drawing.Size(612, 612)
        Me.picWisconsinState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picWisconsinState.TabIndex = 2
        Me.picWisconsinState.TabStop = False
        '
        'picWinter
        '
        Me.picWinter.BackColor = System.Drawing.Color.Transparent
        Me.picWinter.Location = New System.Drawing.Point(12, 12)
        Me.picWinter.Name = "picWinter"
        Me.picWinter.Size = New System.Drawing.Size(416, 191)
        Me.picWinter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWinter.TabIndex = 3
        Me.picWinter.TabStop = False
        '
        'picFall
        '
        Me.picFall.BackColor = System.Drawing.Color.Transparent
        Me.picFall.Location = New System.Drawing.Point(1120, 12)
        Me.picFall.Name = "picFall"
        Me.picFall.Size = New System.Drawing.Size(340, 205)
        Me.picFall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFall.TabIndex = 4
        Me.picFall.TabStop = False
        '
        'picSpring
        '
        Me.picSpring.BackColor = System.Drawing.Color.Transparent
        Me.picSpring.Location = New System.Drawing.Point(12, 477)
        Me.picSpring.Name = "picSpring"
        Me.picSpring.Size = New System.Drawing.Size(428, 138)
        Me.picSpring.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSpring.TabIndex = 5
        Me.picSpring.TabStop = False
        '
        'picSummer
        '
        Me.picSummer.BackColor = System.Drawing.Color.Transparent
        Me.picSummer.Location = New System.Drawing.Point(1103, 407)
        Me.picSummer.Name = "picSummer"
        Me.picSummer.Size = New System.Drawing.Size(357, 207)
        Me.picSummer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSummer.TabIndex = 6
        Me.picSummer.TabStop = False
        '
        'lblF
        '
        Me.lblF.AutoSize = True
        Me.lblF.BackColor = System.Drawing.Color.Transparent
        Me.lblF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.lblF.Location = New System.Drawing.Point(817, 72)
        Me.lblF.Name = "lblF"
        Me.lblF.Size = New System.Drawing.Size(88, 20)
        Me.lblF.TabIndex = 7
        Me.lblF.Text = "Fahrenheit"
        '
        'lblC
        '
        Me.lblC.AutoSize = True
        Me.lblC.BackColor = System.Drawing.Color.Transparent
        Me.lblC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.lblC.Location = New System.Drawing.Point(818, 109)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(65, 20)
        Me.lblC.TabIndex = 8
        Me.lblC.Text = "Celsius"
        '
        'lblOutputF
        '
        Me.lblOutputF.AutoSize = True
        Me.lblOutputF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.lblOutputF.Location = New System.Drawing.Point(951, 72)
        Me.lblOutputF.Name = "lblOutputF"
        Me.lblOutputF.Size = New System.Drawing.Size(0, 20)
        Me.lblOutputF.TabIndex = 9
        '
        'lblOutputC
        '
        Me.lblOutputC.AutoSize = True
        Me.lblOutputC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.lblOutputC.Location = New System.Drawing.Point(951, 109)
        Me.lblOutputC.Name = "lblOutputC"
        Me.lblOutputC.Size = New System.Drawing.Size(0, 20)
        Me.lblOutputC.TabIndex = 10
        '
        'picBackgroundImage
        '
        Me.picBackgroundImage.BackColor = System.Drawing.Color.Transparent
        Me.picBackgroundImage.Location = New System.Drawing.Point(-3, -2)
        Me.picBackgroundImage.Name = "picBackgroundImage"
        Me.picBackgroundImage.Size = New System.Drawing.Size(1488, 629)
        Me.picBackgroundImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBackgroundImage.TabIndex = 11
        Me.picBackgroundImage.TabStop = False
        '
        'TemperatureConverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1481, 626)
        Me.Controls.Add(Me.picWinter)
        Me.Controls.Add(Me.picSpring)
        Me.Controls.Add(Me.picSummer)
        Me.Controls.Add(Me.picFall)
        Me.Controls.Add(Me.lblOutputC)
        Me.Controls.Add(Me.lblOutputF)
        Me.Controls.Add(Me.lblC)
        Me.Controls.Add(Me.lblF)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.hsbTemperatureConverter)
        Me.Controls.Add(Me.picWisconsinState)
        Me.Controls.Add(Me.picBackgroundImage)
        Me.Name = "TemperatureConverter"
        Me.Text = "Form1"
        CType(Me.picWisconsinState, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWinter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSpring, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSummer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBackgroundImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents hsbTemperatureConverter As HScrollBar
    Friend WithEvents btnEnd As Button
    Friend WithEvents picWisconsinState As PictureBox
    Friend WithEvents picWinter As PictureBox
    Friend WithEvents picFall As PictureBox
    Friend WithEvents picSpring As PictureBox
    Friend WithEvents picSummer As PictureBox
    Friend WithEvents lblF As Label
    Friend WithEvents lblC As Label
    Friend WithEvents lblOutputF As Label
    Friend WithEvents lblOutputC As Label
    Friend WithEvents picBackgroundImage As PictureBox
End Class
