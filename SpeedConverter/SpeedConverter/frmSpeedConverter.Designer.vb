<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSpeedConverter
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
        Me.lblSpeedConverter = New System.Windows.Forms.Label()
        Me.lblMPH = New System.Windows.Forms.Label()
        Me.lblOutputMPH = New System.Windows.Forms.Label()
        Me.lblKPH = New System.Windows.Forms.Label()
        Me.lblOutputKPH = New System.Windows.Forms.Label()
        Me.picSnail = New System.Windows.Forms.PictureBox()
        Me.picKangaroo = New System.Windows.Forms.PictureBox()
        Me.picCheetah = New System.Windows.Forms.PictureBox()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.hsbSpeedConverter = New System.Windows.Forms.HScrollBar()
        CType(Me.picSnail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKangaroo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCheetah, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSpeedConverter
        '
        Me.lblSpeedConverter.AutoSize = True
        Me.lblSpeedConverter.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.lblSpeedConverter.Location = New System.Drawing.Point(31, 43)
        Me.lblSpeedConverter.Name = "lblSpeedConverter"
        Me.lblSpeedConverter.Size = New System.Drawing.Size(203, 29)
        Me.lblSpeedConverter.TabIndex = 0
        Me.lblSpeedConverter.Text = "Speed Converter"
        '
        'lblMPH
        '
        Me.lblMPH.AutoSize = True
        Me.lblMPH.Location = New System.Drawing.Point(45, 162)
        Me.lblMPH.Name = "lblMPH"
        Me.lblMPH.Size = New System.Drawing.Size(76, 13)
        Me.lblMPH.TabIndex = 1
        Me.lblMPH.Text = "Miles Per Hour"
        '
        'lblOutputMPH
        '
        Me.lblOutputMPH.AutoSize = True
        Me.lblOutputMPH.Location = New System.Drawing.Point(183, 162)
        Me.lblOutputMPH.Name = "lblOutputMPH"
        Me.lblOutputMPH.Size = New System.Drawing.Size(0, 13)
        Me.lblOutputMPH.TabIndex = 2
        '
        'lblKPH
        '
        Me.lblKPH.AutoSize = True
        Me.lblKPH.Location = New System.Drawing.Point(45, 366)
        Me.lblKPH.Name = "lblKPH"
        Me.lblKPH.Size = New System.Drawing.Size(100, 13)
        Me.lblKPH.TabIndex = 3
        Me.lblKPH.Text = "Kilometers Per Hour"
        '
        'lblOutputKPH
        '
        Me.lblOutputKPH.AutoSize = True
        Me.lblOutputKPH.Location = New System.Drawing.Point(183, 366)
        Me.lblOutputKPH.Name = "lblOutputKPH"
        Me.lblOutputKPH.Size = New System.Drawing.Size(0, 13)
        Me.lblOutputKPH.TabIndex = 4
        '
        'picSnail
        '
        Me.picSnail.Location = New System.Drawing.Point(268, 22)
        Me.picSnail.Name = "picSnail"
        Me.picSnail.Size = New System.Drawing.Size(134, 73)
        Me.picSnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSnail.TabIndex = 5
        Me.picSnail.TabStop = False
        '
        'picKangaroo
        '
        Me.picKangaroo.Location = New System.Drawing.Point(440, 22)
        Me.picKangaroo.Name = "picKangaroo"
        Me.picKangaroo.Size = New System.Drawing.Size(118, 153)
        Me.picKangaroo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picKangaroo.TabIndex = 6
        Me.picKangaroo.TabStop = False
        '
        'picCheetah
        '
        Me.picCheetah.Location = New System.Drawing.Point(594, 22)
        Me.picCheetah.Name = "picCheetah"
        Me.picCheetah.Size = New System.Drawing.Size(182, 108)
        Me.picCheetah.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCheetah.TabIndex = 7
        Me.picCheetah.TabStop = False
        '
        'btnEnd
        '
        Me.btnEnd.BackColor = System.Drawing.Color.Red
        Me.btnEnd.Location = New System.Drawing.Point(782, -2)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(20, 23)
        Me.btnEnd.TabIndex = 8
        Me.btnEnd.Text = "X"
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'hsbSpeedConverter
        '
        Me.hsbSpeedConverter.Location = New System.Drawing.Point(48, 247)
        Me.hsbSpeedConverter.Name = "hsbSpeedConverter"
        Me.hsbSpeedConverter.Size = New System.Drawing.Size(696, 22)
        Me.hsbSpeedConverter.TabIndex = 9
        '
        'frmSpeedConverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.hsbSpeedConverter)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.picCheetah)
        Me.Controls.Add(Me.picKangaroo)
        Me.Controls.Add(Me.picSnail)
        Me.Controls.Add(Me.lblOutputKPH)
        Me.Controls.Add(Me.lblKPH)
        Me.Controls.Add(Me.lblOutputMPH)
        Me.Controls.Add(Me.lblMPH)
        Me.Controls.Add(Me.lblSpeedConverter)
        Me.Name = "frmSpeedConverter"
        Me.Text = "Form1"
        CType(Me.picSnail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKangaroo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCheetah, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSpeedConverter As Label
    Friend WithEvents lblMPH As Label
    Friend WithEvents lblOutputMPH As Label
    Friend WithEvents lblKPH As Label
    Friend WithEvents lblOutputKPH As Label
    Friend WithEvents picSnail As PictureBox
    Friend WithEvents picKangaroo As PictureBox
    Friend WithEvents picCheetah As PictureBox
    Friend WithEvents btnEnd As Button
    Friend WithEvents hsbSpeedConverter As HScrollBar
End Class
