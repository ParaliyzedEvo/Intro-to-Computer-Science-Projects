<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnimationProject
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnimationProject))
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnNextLevel = New System.Windows.Forms.Button()
        Me.btnBackgroundRight = New System.Windows.Forms.Button()
        Me.btnBackgroundLeft = New System.Windows.Forms.Button()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.btnJump = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.picBackground = New System.Windows.Forms.PictureBox()
        Me.picMario = New System.Windows.Forms.PictureBox()
        Me.btnPreviousLevel = New System.Windows.Forms.Button()
        Me.tmrIdk = New System.Windows.Forms.Timer(Me.components)
        Me.btnFly = New System.Windows.Forms.Button()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEnd
        '
        Me.btnEnd.BackColor = System.Drawing.Color.Red
        Me.btnEnd.Location = New System.Drawing.Point(1462, -4)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(21, 23)
        Me.btnEnd.TabIndex = 0
        Me.btnEnd.Text = "X"
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Lime
        Me.btnReset.Location = New System.Drawing.Point(1392, 589)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnNextLevel
        '
        Me.btnNextLevel.BackColor = System.Drawing.Color.Lime
        Me.btnNextLevel.Location = New System.Drawing.Point(1392, 496)
        Me.btnNextLevel.Name = "btnNextLevel"
        Me.btnNextLevel.Size = New System.Drawing.Size(75, 23)
        Me.btnNextLevel.TabIndex = 2
        Me.btnNextLevel.Text = "Next Level"
        Me.btnNextLevel.UseVisualStyleBackColor = False
        '
        'btnBackgroundRight
        '
        Me.btnBackgroundRight.BackColor = System.Drawing.Color.Lime
        Me.btnBackgroundRight.Location = New System.Drawing.Point(1392, 294)
        Me.btnBackgroundRight.Name = "btnBackgroundRight"
        Me.btnBackgroundRight.Size = New System.Drawing.Size(75, 36)
        Me.btnBackgroundRight.TabIndex = 3
        Me.btnBackgroundRight.Text = "Move Background"
        Me.btnBackgroundRight.UseVisualStyleBackColor = False
        '
        'btnBackgroundLeft
        '
        Me.btnBackgroundLeft.BackColor = System.Drawing.Color.Lime
        Me.btnBackgroundLeft.Location = New System.Drawing.Point(12, 294)
        Me.btnBackgroundLeft.Name = "btnBackgroundLeft"
        Me.btnBackgroundLeft.Size = New System.Drawing.Size(75, 36)
        Me.btnBackgroundLeft.TabIndex = 4
        Me.btnBackgroundLeft.Text = "Move Background"
        Me.btnBackgroundLeft.UseVisualStyleBackColor = False
        '
        'btnLeft
        '
        Me.btnLeft.BackColor = System.Drawing.Color.Lime
        Me.btnLeft.Location = New System.Drawing.Point(620, 589)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(75, 23)
        Me.btnLeft.TabIndex = 5
        Me.btnLeft.Text = "Left"
        Me.btnLeft.UseVisualStyleBackColor = False
        '
        'btnJump
        '
        Me.btnJump.BackColor = System.Drawing.Color.Lime
        Me.btnJump.Location = New System.Drawing.Point(701, 589)
        Me.btnJump.Name = "btnJump"
        Me.btnJump.Size = New System.Drawing.Size(75, 23)
        Me.btnJump.TabIndex = 6
        Me.btnJump.Text = "Jump"
        Me.btnJump.UseVisualStyleBackColor = False
        '
        'btnRight
        '
        Me.btnRight.BackColor = System.Drawing.Color.Lime
        Me.btnRight.Location = New System.Drawing.Point(782, 589)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(75, 23)
        Me.btnRight.TabIndex = 7
        Me.btnRight.Text = "Right"
        Me.btnRight.UseVisualStyleBackColor = False
        '
        'picBackground
        '
        Me.picBackground.Image = CType(resources.GetObject("picBackground.Image"), System.Drawing.Image)
        Me.picBackground.Location = New System.Drawing.Point(0, -382)
        Me.picBackground.Name = "picBackground"
        Me.picBackground.Size = New System.Drawing.Size(1920, 1080)
        Me.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picBackground.TabIndex = 8
        Me.picBackground.TabStop = False
        '
        'picMario
        '
        Me.picMario.BackColor = System.Drawing.Color.Transparent
        Me.picMario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picMario.Image = CType(resources.GetObject("picMario.Image"), System.Drawing.Image)
        Me.picMario.Location = New System.Drawing.Point(67, 423)
        Me.picMario.Name = "picMario"
        Me.picMario.Size = New System.Drawing.Size(100, 129)
        Me.picMario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMario.TabIndex = 9
        Me.picMario.TabStop = False
        '
        'btnPreviousLevel
        '
        Me.btnPreviousLevel.BackColor = System.Drawing.Color.Lime
        Me.btnPreviousLevel.Location = New System.Drawing.Point(1392, 535)
        Me.btnPreviousLevel.Name = "btnPreviousLevel"
        Me.btnPreviousLevel.Size = New System.Drawing.Size(75, 39)
        Me.btnPreviousLevel.TabIndex = 10
        Me.btnPreviousLevel.Text = "Previous Level"
        Me.btnPreviousLevel.UseVisualStyleBackColor = False
        '
        'tmrIdk
        '
        Me.tmrIdk.Interval = 30
        '
        'btnFly
        '
        Me.btnFly.BackColor = System.Drawing.Color.Lime
        Me.btnFly.Location = New System.Drawing.Point(701, 560)
        Me.btnFly.Name = "btnFly"
        Me.btnFly.Size = New System.Drawing.Size(75, 23)
        Me.btnFly.TabIndex = 11
        Me.btnFly.Text = "Fly"
        Me.btnFly.UseVisualStyleBackColor = False
        '
        'frmAnimationProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1479, 626)
        Me.Controls.Add(Me.btnFly)
        Me.Controls.Add(Me.btnPreviousLevel)
        Me.Controls.Add(Me.picMario)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnJump)
        Me.Controls.Add(Me.btnLeft)
        Me.Controls.Add(Me.btnBackgroundLeft)
        Me.Controls.Add(Me.btnBackgroundRight)
        Me.Controls.Add(Me.btnNextLevel)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.picBackground)
        Me.KeyPreview = True
        Me.Name = "frmAnimationProject"
        Me.Text = "Form1"
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnd As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnNextLevel As Button
    Friend WithEvents btnBackgroundRight As Button
    Friend WithEvents btnBackgroundLeft As Button
    Friend WithEvents btnLeft As Button
    Friend WithEvents btnJump As Button
    Friend WithEvents btnRight As Button
    Friend WithEvents picBackground As PictureBox
    Friend WithEvents picMario As PictureBox
    Friend WithEvents btnPreviousLevel As Button
    Friend WithEvents tmrIdk As Timer
    Friend WithEvents btnFly As Button
End Class
