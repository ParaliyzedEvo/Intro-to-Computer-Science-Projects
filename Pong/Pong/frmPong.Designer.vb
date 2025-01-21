<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPong
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPong))
        Me.picLeftBat = New System.Windows.Forms.PictureBox()
        Me.picBall = New System.Windows.Forms.PictureBox()
        Me.picRightBat = New System.Windows.Forms.PictureBox()
        Me.lblLeftScore = New System.Windows.Forms.Label()
        Me.lblRightScore = New System.Windows.Forms.Label()
        Me.lblLeftScoreNumber = New System.Windows.Forms.Label()
        Me.lblRightScoreNumber = New System.Windows.Forms.Label()
        CType(Me.picLeftBat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRightBat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picLeftBat
        '
        Me.picLeftBat.Image = CType(resources.GetObject("picLeftBat.Image"), System.Drawing.Image)
        Me.picLeftBat.Location = New System.Drawing.Point(12, 307)
        Me.picLeftBat.Name = "picLeftBat"
        Me.picLeftBat.Size = New System.Drawing.Size(14, 89)
        Me.picLeftBat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picLeftBat.TabIndex = 0
        Me.picLeftBat.TabStop = False
        '
        'picBall
        '
        Me.picBall.Image = CType(resources.GetObject("picBall.Image"), System.Drawing.Image)
        Me.picBall.Location = New System.Drawing.Point(637, 355)
        Me.picBall.Name = "picBall"
        Me.picBall.Size = New System.Drawing.Size(18, 18)
        Me.picBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picBall.TabIndex = 1
        Me.picBall.TabStop = False
        '
        'picRightBat
        '
        Me.picRightBat.Image = CType(resources.GetObject("picRightBat.Image"), System.Drawing.Image)
        Me.picRightBat.Location = New System.Drawing.Point(1238, 307)
        Me.picRightBat.Name = "picRightBat"
        Me.picRightBat.Size = New System.Drawing.Size(14, 89)
        Me.picRightBat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picRightBat.TabIndex = 2
        Me.picRightBat.TabStop = False
        '
        'lblLeftScore
        '
        Me.lblLeftScore.AutoSize = True
        Me.lblLeftScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.lblLeftScore.Location = New System.Drawing.Point(12, 9)
        Me.lblLeftScore.Name = "lblLeftScore"
        Me.lblLeftScore.Size = New System.Drawing.Size(106, 29)
        Me.lblLeftScore.TabIndex = 3
        Me.lblLeftScore.Text = "Team 1:"
        '
        'lblRightScore
        '
        Me.lblRightScore.AutoSize = True
        Me.lblRightScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.lblRightScore.Location = New System.Drawing.Point(12, 52)
        Me.lblRightScore.Name = "lblRightScore"
        Me.lblRightScore.Size = New System.Drawing.Size(106, 29)
        Me.lblRightScore.TabIndex = 4
        Me.lblRightScore.Text = "Team 2:"
        '
        'lblLeftScoreNumber
        '
        Me.lblLeftScoreNumber.AutoSize = True
        Me.lblLeftScoreNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.lblLeftScoreNumber.Location = New System.Drawing.Point(123, 9)
        Me.lblLeftScoreNumber.Name = "lblLeftScoreNumber"
        Me.lblLeftScoreNumber.Size = New System.Drawing.Size(0, 29)
        Me.lblLeftScoreNumber.TabIndex = 5
        '
        'lblRightScoreNumber
        '
        Me.lblRightScoreNumber.AutoSize = True
        Me.lblRightScoreNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.lblRightScoreNumber.Location = New System.Drawing.Point(123, 52)
        Me.lblRightScoreNumber.Name = "lblRightScoreNumber"
        Me.lblRightScoreNumber.Size = New System.Drawing.Size(0, 29)
        Me.lblRightScoreNumber.TabIndex = 6
        '
        'frmPong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.lblRightScoreNumber)
        Me.Controls.Add(Me.lblLeftScoreNumber)
        Me.Controls.Add(Me.lblRightScore)
        Me.Controls.Add(Me.lblLeftScore)
        Me.Controls.Add(Me.picRightBat)
        Me.Controls.Add(Me.picBall)
        Me.Controls.Add(Me.picLeftBat)
        Me.Name = "frmPong"
        Me.Text = "Form1"
        CType(Me.picLeftBat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRightBat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picLeftBat As PictureBox
    Friend WithEvents picBall As PictureBox
    Friend WithEvents picRightBat As PictureBox
    Friend WithEvents lblLeftScore As Label
    Friend WithEvents lblRightScore As Label
    Friend WithEvents lblLeftScoreNumber As Label
    Friend WithEvents lblRightScoreNumber As Label
End Class
