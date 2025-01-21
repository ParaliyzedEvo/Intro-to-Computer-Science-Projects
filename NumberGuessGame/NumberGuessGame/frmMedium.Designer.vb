<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMedium
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMedium))
        Me.lblTitle1 = New System.Windows.Forms.Label()
        Me.picHead = New System.Windows.Forms.PictureBox()
        Me.picArmLeft = New System.Windows.Forms.PictureBox()
        Me.picArmRight = New System.Windows.Forms.PictureBox()
        Me.picLegLeft = New System.Windows.Forms.PictureBox()
        Me.picLegRight = New System.Windows.Forms.PictureBox()
        Me.picBody = New System.Windows.Forms.PictureBox()
        Me.txtGuess = New System.Windows.Forms.TextBox()
        Me.btnGuess = New System.Windows.Forms.Button()
        Me.btnShowNumber = New System.Windows.Forms.Button()
        Me.txtShowNumber = New System.Windows.Forms.TextBox()
        Me.lstPreviousGuesses = New System.Windows.Forms.ListBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.pbGuessesleft = New System.Windows.Forms.ProgressBar()
        Me.lblGuessesLft = New System.Windows.Forms.Label()
        Me.btnDirections = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.lblYouHave = New System.Windows.Forms.Label()
        Me.lblGuessesLeft2 = New System.Windows.Forms.Label()
        Me.lblIdk = New System.Windows.Forms.Label()
        Me.lblDirections = New System.Windows.Forms.Label()
        Me.tmrHideDirections = New System.Windows.Forms.Timer(Me.components)
        Me.tmrShowDirections = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picHead, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picArmLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picArmRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBody, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle1
        '
        Me.lblTitle1.AutoSize = True
        Me.lblTitle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.lblTitle1.Location = New System.Drawing.Point(36, 41)
        Me.lblTitle1.Name = "lblTitle1"
        Me.lblTitle1.Size = New System.Drawing.Size(373, 29)
        Me.lblTitle1.TabIndex = 0
        Me.lblTitle1.Text = "Number Guess Game (Medium)"
        '
        'picHead
        '
        Me.picHead.BackColor = System.Drawing.Color.Transparent
        Me.picHead.Image = CType(resources.GetObject("picHead.Image"), System.Drawing.Image)
        Me.picHead.Location = New System.Drawing.Point(99, 73)
        Me.picHead.Name = "picHead"
        Me.picHead.Size = New System.Drawing.Size(87, 78)
        Me.picHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHead.TabIndex = 1
        Me.picHead.TabStop = False
        '
        'picArmLeft
        '
        Me.picArmLeft.BackColor = System.Drawing.Color.Transparent
        Me.picArmLeft.Image = CType(resources.GetObject("picArmLeft.Image"), System.Drawing.Image)
        Me.picArmLeft.Location = New System.Drawing.Point(14, 151)
        Me.picArmLeft.Name = "picArmLeft"
        Me.picArmLeft.Size = New System.Drawing.Size(87, 24)
        Me.picArmLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picArmLeft.TabIndex = 2
        Me.picArmLeft.TabStop = False
        '
        'picArmRight
        '
        Me.picArmRight.BackColor = System.Drawing.Color.Transparent
        Me.picArmRight.Image = CType(resources.GetObject("picArmRight.Image"), System.Drawing.Image)
        Me.picArmRight.Location = New System.Drawing.Point(186, 151)
        Me.picArmRight.Name = "picArmRight"
        Me.picArmRight.Size = New System.Drawing.Size(87, 24)
        Me.picArmRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picArmRight.TabIndex = 3
        Me.picArmRight.TabStop = False
        '
        'picLegLeft
        '
        Me.picLegLeft.BackColor = System.Drawing.Color.Transparent
        Me.picLegLeft.Image = CType(resources.GetObject("picLegLeft.Image"), System.Drawing.Image)
        Me.picLegLeft.Location = New System.Drawing.Point(99, 241)
        Me.picLegLeft.Name = "picLegLeft"
        Me.picLegLeft.Size = New System.Drawing.Size(46, 83)
        Me.picLegLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLegLeft.TabIndex = 4
        Me.picLegLeft.TabStop = False
        '
        'picLegRight
        '
        Me.picLegRight.BackColor = System.Drawing.Color.Transparent
        Me.picLegRight.Image = CType(resources.GetObject("picLegRight.Image"), System.Drawing.Image)
        Me.picLegRight.Location = New System.Drawing.Point(142, 241)
        Me.picLegRight.Name = "picLegRight"
        Me.picLegRight.Size = New System.Drawing.Size(44, 83)
        Me.picLegRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLegRight.TabIndex = 5
        Me.picLegRight.TabStop = False
        '
        'picBody
        '
        Me.picBody.BackColor = System.Drawing.Color.Transparent
        Me.picBody.Image = CType(resources.GetObject("picBody.Image"), System.Drawing.Image)
        Me.picBody.Location = New System.Drawing.Point(99, 151)
        Me.picBody.Name = "picBody"
        Me.picBody.Size = New System.Drawing.Size(87, 90)
        Me.picBody.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBody.TabIndex = 6
        Me.picBody.TabStop = False
        '
        'txtGuess
        '
        Me.txtGuess.Location = New System.Drawing.Point(410, 105)
        Me.txtGuess.Name = "txtGuess"
        Me.txtGuess.Size = New System.Drawing.Size(100, 20)
        Me.txtGuess.TabIndex = 7
        '
        'btnGuess
        '
        Me.btnGuess.Location = New System.Drawing.Point(410, 136)
        Me.btnGuess.Name = "btnGuess"
        Me.btnGuess.Size = New System.Drawing.Size(100, 23)
        Me.btnGuess.TabIndex = 8
        Me.btnGuess.Text = "Guess"
        Me.btnGuess.UseVisualStyleBackColor = True
        '
        'btnShowNumber
        '
        Me.btnShowNumber.Location = New System.Drawing.Point(364, 195)
        Me.btnShowNumber.Name = "btnShowNumber"
        Me.btnShowNumber.Size = New System.Drawing.Size(73, 70)
        Me.btnShowNumber.TabIndex = 9
        Me.btnShowNumber.Text = "Show Number"
        Me.btnShowNumber.UseVisualStyleBackColor = True
        '
        'txtShowNumber
        '
        Me.txtShowNumber.Location = New System.Drawing.Point(460, 221)
        Me.txtShowNumber.Name = "txtShowNumber"
        Me.txtShowNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtShowNumber.TabIndex = 10
        '
        'lstPreviousGuesses
        '
        Me.lstPreviousGuesses.FormattingEnabled = True
        Me.lstPreviousGuesses.Location = New System.Drawing.Point(647, 94)
        Me.lstPreviousGuesses.Name = "lstPreviousGuesses"
        Me.lstPreviousGuesses.Size = New System.Drawing.Size(120, 199)
        Me.lstPreviousGuesses.TabIndex = 11
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(671, 13)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(96, 65)
        Me.btnReturn.TabIndex = 12
        Me.btnReturn.Text = "Return to Welcome Page"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'pbGuessesleft
        '
        Me.pbGuessesleft.Location = New System.Drawing.Point(364, 342)
        Me.pbGuessesleft.Name = "pbGuessesleft"
        Me.pbGuessesleft.Size = New System.Drawing.Size(403, 23)
        Me.pbGuessesleft.TabIndex = 13
        '
        'lblGuessesLft
        '
        Me.lblGuessesLft.AutoSize = True
        Me.lblGuessesLft.Location = New System.Drawing.Point(364, 323)
        Me.lblGuessesLft.Name = "lblGuessesLft"
        Me.lblGuessesLft.Size = New System.Drawing.Size(69, 13)
        Me.lblGuessesLft.TabIndex = 14
        Me.lblGuessesLft.Text = "Guesses Left"
        '
        'btnDirections
        '
        Me.btnDirections.Location = New System.Drawing.Point(364, 390)
        Me.btnDirections.Name = "btnDirections"
        Me.btnDirections.Size = New System.Drawing.Size(75, 23)
        Me.btnDirections.TabIndex = 15
        Me.btnDirections.Text = "Directions"
        Me.btnDirections.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(529, 390)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 16
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(692, 390)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 17
        Me.btnEnd.Text = "End"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'lblYouHave
        '
        Me.lblYouHave.AutoSize = True
        Me.lblYouHave.Location = New System.Drawing.Point(29, 378)
        Me.lblYouHave.Name = "lblYouHave"
        Me.lblYouHave.Size = New System.Drawing.Size(53, 13)
        Me.lblYouHave.TabIndex = 18
        Me.lblYouHave.Text = "You have"
        '
        'lblGuessesLeft2
        '
        Me.lblGuessesLeft2.AutoSize = True
        Me.lblGuessesLeft2.Location = New System.Drawing.Point(119, 378)
        Me.lblGuessesLeft2.Name = "lblGuessesLeft2"
        Me.lblGuessesLeft2.Size = New System.Drawing.Size(0, 13)
        Me.lblGuessesLeft2.TabIndex = 19
        '
        'lblIdk
        '
        Me.lblIdk.AutoSize = True
        Me.lblIdk.Location = New System.Drawing.Point(205, 378)
        Me.lblIdk.Name = "lblIdk"
        Me.lblIdk.Size = New System.Drawing.Size(63, 13)
        Me.lblIdk.TabIndex = 20
        Me.lblIdk.Text = "guesses left"
        '
        'lblDirections
        '
        Me.lblDirections.AutoSize = True
        Me.lblDirections.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.25!)
        Me.lblDirections.Location = New System.Drawing.Point(268, 472)
        Me.lblDirections.Name = "lblDirections"
        Me.lblDirections.Size = New System.Drawing.Size(289, 44)
        Me.lblDirections.TabIndex = 21
        Me.lblDirections.Text = "I no no wanna :("
        '
        'tmrHideDirections
        '
        '
        'tmrShowDirections
        '
        '
        'frmMedium
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(800, 459)
        Me.Controls.Add(Me.lblDirections)
        Me.Controls.Add(Me.lblIdk)
        Me.Controls.Add(Me.lblGuessesLeft2)
        Me.Controls.Add(Me.lblYouHave)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnDirections)
        Me.Controls.Add(Me.lblGuessesLft)
        Me.Controls.Add(Me.pbGuessesleft)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.lstPreviousGuesses)
        Me.Controls.Add(Me.txtShowNumber)
        Me.Controls.Add(Me.btnShowNumber)
        Me.Controls.Add(Me.btnGuess)
        Me.Controls.Add(Me.txtGuess)
        Me.Controls.Add(Me.picBody)
        Me.Controls.Add(Me.picLegRight)
        Me.Controls.Add(Me.picLegLeft)
        Me.Controls.Add(Me.picArmRight)
        Me.Controls.Add(Me.picArmLeft)
        Me.Controls.Add(Me.picHead)
        Me.Controls.Add(Me.lblTitle1)
        Me.Name = "frmMedium"
        Me.Text = "frmMedium"
        CType(Me.picHead, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picArmLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picArmRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBody, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle1 As Label
    Friend WithEvents picHead As PictureBox
    Friend WithEvents picArmLeft As PictureBox
    Friend WithEvents picArmRight As PictureBox
    Friend WithEvents picLegLeft As PictureBox
    Friend WithEvents picLegRight As PictureBox
    Friend WithEvents picBody As PictureBox
    Friend WithEvents txtGuess As TextBox
    Friend WithEvents btnGuess As Button
    Friend WithEvents btnShowNumber As Button
    Friend WithEvents txtShowNumber As TextBox
    Friend WithEvents lstPreviousGuesses As ListBox
    Friend WithEvents btnReturn As Button
    Friend WithEvents pbGuessesleft As ProgressBar
    Friend WithEvents lblGuessesLft As Label
    Friend WithEvents btnDirections As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnEnd As Button
    Friend WithEvents lblYouHave As Label
    Friend WithEvents lblGuessesLeft2 As Label
    Friend WithEvents lblIdk As Label
    Friend WithEvents lblDirections As Label
    Friend WithEvents tmrHideDirections As Timer
    Friend WithEvents tmrShowDirections As Timer
End Class
