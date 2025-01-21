<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEasy
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.pic2 = New System.Windows.Forms.PictureBox()
        Me.pic7 = New System.Windows.Forms.PictureBox()
        Me.pic5 = New System.Windows.Forms.PictureBox()
        Me.pic8 = New System.Windows.Forms.PictureBox()
        Me.pic6 = New System.Windows.Forms.PictureBox()
        Me.pic4 = New System.Windows.Forms.PictureBox()
        Me.pic3 = New System.Windows.Forms.PictureBox()
        Me.btnNewGame = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblTimeCount = New System.Windows.Forms.Label()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.tmrCoverPictures = New System.Windows.Forms.Timer(Me.components)
        Me.tmrTimer = New System.Windows.Forms.Timer(Me.components)
        Me.btnNextLevel = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lstLeaderboard = New System.Windows.Forms.ListBox()
        Me.lblLeaderboard = New System.Windows.Forms.Label()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic1
        '
        Me.pic1.Location = New System.Drawing.Point(133, 51)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(125, 125)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic1.TabIndex = 0
        Me.pic1.TabStop = False
        '
        'pic2
        '
        Me.pic2.Location = New System.Drawing.Point(264, 51)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(125, 125)
        Me.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic2.TabIndex = 1
        Me.pic2.TabStop = False
        '
        'pic7
        '
        Me.pic7.Location = New System.Drawing.Point(395, 208)
        Me.pic7.Name = "pic7"
        Me.pic7.Size = New System.Drawing.Size(125, 125)
        Me.pic7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic7.TabIndex = 2
        Me.pic7.TabStop = False
        '
        'pic5
        '
        Me.pic5.Location = New System.Drawing.Point(133, 208)
        Me.pic5.Name = "pic5"
        Me.pic5.Size = New System.Drawing.Size(125, 125)
        Me.pic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic5.TabIndex = 3
        Me.pic5.TabStop = False
        '
        'pic8
        '
        Me.pic8.Location = New System.Drawing.Point(526, 208)
        Me.pic8.Name = "pic8"
        Me.pic8.Size = New System.Drawing.Size(125, 125)
        Me.pic8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic8.TabIndex = 4
        Me.pic8.TabStop = False
        '
        'pic6
        '
        Me.pic6.Location = New System.Drawing.Point(264, 208)
        Me.pic6.Name = "pic6"
        Me.pic6.Size = New System.Drawing.Size(125, 125)
        Me.pic6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic6.TabIndex = 5
        Me.pic6.TabStop = False
        '
        'pic4
        '
        Me.pic4.Location = New System.Drawing.Point(526, 51)
        Me.pic4.Name = "pic4"
        Me.pic4.Size = New System.Drawing.Size(125, 125)
        Me.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic4.TabIndex = 6
        Me.pic4.TabStop = False
        '
        'pic3
        '
        Me.pic3.Location = New System.Drawing.Point(395, 51)
        Me.pic3.Name = "pic3"
        Me.pic3.Size = New System.Drawing.Size(125, 125)
        Me.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic3.TabIndex = 7
        Me.pic3.TabStop = False
        '
        'btnNewGame
        '
        Me.btnNewGame.BackColor = System.Drawing.Color.Lime
        Me.btnNewGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.btnNewGame.Location = New System.Drawing.Point(309, 360)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(165, 46)
        Me.btnNewGame.TabIndex = 8
        Me.btnNewGame.Text = "New Game"
        Me.btnNewGame.UseVisualStyleBackColor = False
        '
        'btnEnd
        '
        Me.btnEnd.BackColor = System.Drawing.Color.Red
        Me.btnEnd.Location = New System.Drawing.Point(713, 415)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 9
        Me.btnEnd.Text = "End"
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(51, 393)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(33, 13)
        Me.lblTime.TabIndex = 10
        Me.lblTime.Text = "Time:"
        '
        'lblTimeCount
        '
        Me.lblTimeCount.AutoSize = True
        Me.lblTimeCount.Location = New System.Drawing.Point(90, 393)
        Me.lblTimeCount.Name = "lblTimeCount"
        Me.lblTimeCount.Size = New System.Drawing.Size(0, 13)
        Me.lblTimeCount.TabIndex = 11
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(133, 51)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(125, 125)
        Me.btn1.TabIndex = 12
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(264, 51)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(125, 125)
        Me.btn2.TabIndex = 13
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Location = New System.Drawing.Point(526, 208)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(125, 125)
        Me.btn8.TabIndex = 14
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(133, 208)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(125, 125)
        Me.btn5.TabIndex = 15
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(395, 51)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(125, 125)
        Me.btn3.TabIndex = 16
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Location = New System.Drawing.Point(395, 208)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(125, 125)
        Me.btn7.TabIndex = 17
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Location = New System.Drawing.Point(264, 208)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(125, 125)
        Me.btn6.TabIndex = 18
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(526, 51)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(125, 125)
        Me.btn4.TabIndex = 19
        Me.btn4.UseVisualStyleBackColor = True
        '
        'tmrCoverPictures
        '
        '
        'tmrTimer
        '
        Me.tmrTimer.Interval = 1000
        '
        'btnNextLevel
        '
        Me.btnNextLevel.BackColor = System.Drawing.Color.Yellow
        Me.btnNextLevel.Location = New System.Drawing.Point(713, 386)
        Me.btnNextLevel.Name = "btnNextLevel"
        Me.btnNextLevel.Size = New System.Drawing.Size(75, 23)
        Me.btnNextLevel.TabIndex = 20
        Me.btnNextLevel.Text = "Next Level"
        Me.btnNextLevel.UseVisualStyleBackColor = False
        Me.btnNextLevel.Visible = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Aqua
        Me.btnBack.Location = New System.Drawing.Point(349, 415)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 21
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lstLeaderboard
        '
        Me.lstLeaderboard.FormattingEnabled = True
        Me.lstLeaderboard.Location = New System.Drawing.Point(668, 51)
        Me.lstLeaderboard.Name = "lstLeaderboard"
        Me.lstLeaderboard.Size = New System.Drawing.Size(120, 316)
        Me.lstLeaderboard.TabIndex = 22
        '
        'lblLeaderboard
        '
        Me.lblLeaderboard.AutoSize = True
        Me.lblLeaderboard.Location = New System.Drawing.Point(696, 28)
        Me.lblLeaderboard.Name = "lblLeaderboard"
        Me.lblLeaderboard.Size = New System.Drawing.Size(67, 13)
        Me.lblLeaderboard.TabIndex = 23
        Me.lblLeaderboard.Text = "Leaderboard"
        '
        'frmEasy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblLeaderboard)
        Me.Controls.Add(Me.lstLeaderboard)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnNextLevel)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.lblTimeCount)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnNewGame)
        Me.Controls.Add(Me.pic3)
        Me.Controls.Add(Me.pic4)
        Me.Controls.Add(Me.pic6)
        Me.Controls.Add(Me.pic8)
        Me.Controls.Add(Me.pic5)
        Me.Controls.Add(Me.pic7)
        Me.Controls.Add(Me.pic2)
        Me.Controls.Add(Me.pic1)
        Me.Name = "frmEasy"
        Me.Text = "Form1"
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pic1 As PictureBox
    Friend WithEvents pic2 As PictureBox
    Friend WithEvents pic7 As PictureBox
    Friend WithEvents pic5 As PictureBox
    Friend WithEvents pic8 As PictureBox
    Friend WithEvents pic6 As PictureBox
    Friend WithEvents pic4 As PictureBox
    Friend WithEvents pic3 As PictureBox
    Friend WithEvents btnNewGame As Button
    Friend WithEvents btnEnd As Button
    Friend WithEvents lblTime As Label
    Friend WithEvents lblTimeCount As Label
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents tmrCoverPictures As Timer
    Friend WithEvents tmrTimer As Timer
    Friend WithEvents btnNextLevel As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents lstLeaderboard As ListBox
    Friend WithEvents lblLeaderboard As Label
End Class
