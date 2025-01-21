<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBirdFly
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBirdFly))
        Me.picBird = New System.Windows.Forms.PictureBox()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnAutoFly = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.tmrAutoFly = New System.Windows.Forms.Timer(Me.components)
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnLeft = New System.Windows.Forms.Button()
        CType(Me.picBird, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBird
        '
        Me.picBird.BackColor = System.Drawing.Color.Transparent
        Me.picBird.Image = CType(resources.GetObject("picBird.Image"), System.Drawing.Image)
        Me.picBird.Location = New System.Drawing.Point(40, 358)
        Me.picBird.Name = "picBird"
        Me.picBird.Size = New System.Drawing.Size(200, 140)
        Me.picBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBird.TabIndex = 0
        Me.picBird.TabStop = False
        '
        'btnUp
        '
        Me.btnUp.Location = New System.Drawing.Point(263, 445)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(137, 53)
        Me.btnUp.TabIndex = 1
        Me.btnUp.Text = "Move Bird Up"
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'btnRight
        '
        Me.btnRight.Location = New System.Drawing.Point(577, 445)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(137, 53)
        Me.btnRight.TabIndex = 2
        Me.btnRight.Text = "Move Bird Right"
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'btnAutoFly
        '
        Me.btnAutoFly.Location = New System.Drawing.Point(884, 445)
        Me.btnAutoFly.Name = "btnAutoFly"
        Me.btnAutoFly.Size = New System.Drawing.Size(137, 53)
        Me.btnAutoFly.TabIndex = 3
        Me.btnAutoFly.Text = "Auto Fly"
        Me.btnAutoFly.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(1036, 445)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(137, 53)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'tmrAutoFly
        '
        Me.tmrAutoFly.Interval = 1
        '
        'btnDown
        '
        Me.btnDown.Location = New System.Drawing.Point(418, 445)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(137, 53)
        Me.btnDown.TabIndex = 5
        Me.btnDown.Text = "Move Bird Down"
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'btnLeft
        '
        Me.btnLeft.Location = New System.Drawing.Point(732, 445)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(137, 53)
        Me.btnLeft.TabIndex = 6
        Me.btnLeft.Text = "Move Bird Left"
        Me.btnLeft.UseVisualStyleBackColor = True
        '
        'frmBirdFly
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1223, 530)
        Me.Controls.Add(Me.btnLeft)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnAutoFly)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.picBird)
        Me.Name = "frmBirdFly"
        Me.Text = "Form1"
        CType(Me.picBird, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picBird As PictureBox
    Friend WithEvents btnUp As Button
    Friend WithEvents btnRight As Button
    Friend WithEvents btnAutoFly As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents tmrAutoFly As Timer
    Friend WithEvents btnDown As Button
    Friend WithEvents btnLeft As Button
End Class
