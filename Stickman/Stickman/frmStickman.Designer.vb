<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStickman
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStickman))
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.btnDrawBodyPart = New System.Windows.Forms.Button()
        Me.btnExpandContract = New System.Windows.Forms.Button()
        Me.picHead = New System.Windows.Forms.PictureBox()
        Me.picLegRight = New System.Windows.Forms.PictureBox()
        Me.picArmRight = New System.Windows.Forms.PictureBox()
        Me.picBody = New System.Windows.Forms.PictureBox()
        Me.picLegLeft = New System.Windows.Forms.PictureBox()
        Me.picArmLeft = New System.Windows.Forms.PictureBox()
        Me.tmrHideBar = New System.Windows.Forms.Timer(Me.components)
        Me.tmrShowBar = New System.Windows.Forms.Timer(Me.components)
        Me.pbGuessesLeft = New System.Windows.Forms.ProgressBar()
        Me.lblGuessesLeft = New System.Windows.Forms.Label()
        CType(Me.picHead, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picArmRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBody, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picArmLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEnd
        '
        Me.btnEnd.BackColor = System.Drawing.Color.Red
        Me.btnEnd.Location = New System.Drawing.Point(729, 12)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 0
        Me.btnEnd.Text = "End"
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'btnDrawBodyPart
        '
        Me.btnDrawBodyPart.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.btnDrawBodyPart.Location = New System.Drawing.Point(80, 65)
        Me.btnDrawBodyPart.Name = "btnDrawBodyPart"
        Me.btnDrawBodyPart.Size = New System.Drawing.Size(170, 100)
        Me.btnDrawBodyPart.TabIndex = 1
        Me.btnDrawBodyPart.Text = "Draw Body Part"
        Me.btnDrawBodyPart.UseVisualStyleBackColor = True
        '
        'btnExpandContract
        '
        Me.btnExpandContract.Location = New System.Drawing.Point(113, 366)
        Me.btnExpandContract.Name = "btnExpandContract"
        Me.btnExpandContract.Size = New System.Drawing.Size(105, 23)
        Me.btnExpandContract.TabIndex = 2
        Me.btnExpandContract.Text = "Expand/Contract"
        Me.btnExpandContract.UseVisualStyleBackColor = True
        '
        'picHead
        '
        Me.picHead.Image = CType(resources.GetObject("picHead.Image"), System.Drawing.Image)
        Me.picHead.Location = New System.Drawing.Point(533, 36)
        Me.picHead.Name = "picHead"
        Me.picHead.Size = New System.Drawing.Size(120, 98)
        Me.picHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHead.TabIndex = 7
        Me.picHead.TabStop = False
        Me.picHead.Visible = False
        '
        'picLegRight
        '
        Me.picLegRight.Image = CType(resources.GetObject("picLegRight.Image"), System.Drawing.Image)
        Me.picLegRight.Location = New System.Drawing.Point(591, 311)
        Me.picLegRight.Name = "picLegRight"
        Me.picLegRight.Size = New System.Drawing.Size(84, 127)
        Me.picLegRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLegRight.TabIndex = 8
        Me.picLegRight.TabStop = False
        Me.picLegRight.Visible = False
        '
        'picArmRight
        '
        Me.picArmRight.Image = CType(resources.GetObject("picArmRight.Image"), System.Drawing.Image)
        Me.picArmRight.Location = New System.Drawing.Point(653, 134)
        Me.picArmRight.Name = "picArmRight"
        Me.picArmRight.Size = New System.Drawing.Size(135, 78)
        Me.picArmRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picArmRight.TabIndex = 9
        Me.picArmRight.TabStop = False
        Me.picArmRight.Visible = False
        '
        'picBody
        '
        Me.picBody.Image = CType(resources.GetObject("picBody.Image"), System.Drawing.Image)
        Me.picBody.Location = New System.Drawing.Point(533, 134)
        Me.picBody.Name = "picBody"
        Me.picBody.Size = New System.Drawing.Size(120, 179)
        Me.picBody.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBody.TabIndex = 11
        Me.picBody.TabStop = False
        Me.picBody.Visible = False
        '
        'picLegLeft
        '
        Me.picLegLeft.Image = CType(resources.GetObject("picLegLeft.Image"), System.Drawing.Image)
        Me.picLegLeft.Location = New System.Drawing.Point(512, 311)
        Me.picLegLeft.Name = "picLegLeft"
        Me.picLegLeft.Size = New System.Drawing.Size(81, 127)
        Me.picLegLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLegLeft.TabIndex = 12
        Me.picLegLeft.TabStop = False
        Me.picLegLeft.Visible = False
        '
        'picArmLeft
        '
        Me.picArmLeft.Image = CType(resources.GetObject("picArmLeft.Image"), System.Drawing.Image)
        Me.picArmLeft.Location = New System.Drawing.Point(398, 136)
        Me.picArmLeft.Name = "picArmLeft"
        Me.picArmLeft.Size = New System.Drawing.Size(135, 78)
        Me.picArmLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picArmLeft.TabIndex = 13
        Me.picArmLeft.TabStop = False
        Me.picArmLeft.Visible = False
        '
        'tmrHideBar
        '
        '
        'tmrShowBar
        '
        '
        'pbGuessesLeft
        '
        Me.pbGuessesLeft.Location = New System.Drawing.Point(168, 520)
        Me.pbGuessesLeft.Name = "pbGuessesLeft"
        Me.pbGuessesLeft.Size = New System.Drawing.Size(482, 23)
        Me.pbGuessesLeft.TabIndex = 14
        '
        'lblGuessesLeft
        '
        Me.lblGuessesLeft.AutoSize = True
        Me.lblGuessesLeft.Location = New System.Drawing.Point(168, 489)
        Me.lblGuessesLeft.Name = "lblGuessesLeft"
        Me.lblGuessesLeft.Size = New System.Drawing.Size(69, 13)
        Me.lblGuessesLeft.TabIndex = 15
        Me.lblGuessesLeft.Text = "Guesses Left"
        '
        'frmStickman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 471)
        Me.Controls.Add(Me.lblGuessesLeft)
        Me.Controls.Add(Me.pbGuessesLeft)
        Me.Controls.Add(Me.picArmLeft)
        Me.Controls.Add(Me.picLegLeft)
        Me.Controls.Add(Me.picBody)
        Me.Controls.Add(Me.picArmRight)
        Me.Controls.Add(Me.picLegRight)
        Me.Controls.Add(Me.picHead)
        Me.Controls.Add(Me.btnExpandContract)
        Me.Controls.Add(Me.btnDrawBodyPart)
        Me.Controls.Add(Me.btnEnd)
        Me.Name = "frmStickman"
        Me.Text = "Form1"
        CType(Me.picHead, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picArmRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBody, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picArmLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnd As Button
    Friend WithEvents btnDrawBodyPart As Button
    Friend WithEvents btnExpandContract As Button
    Friend WithEvents picHead As PictureBox
    Friend WithEvents picLegRight As PictureBox
    Friend WithEvents picArmRight As PictureBox
    Friend WithEvents picBody As PictureBox
    Friend WithEvents picLegLeft As PictureBox
    Friend WithEvents picArmLeft As PictureBox
    Friend WithEvents tmrHideBar As Timer
    Friend WithEvents tmrShowBar As Timer
    Friend WithEvents pbGuessesLeft As ProgressBar
    Friend WithEvents lblGuessesLeft As Label
End Class
