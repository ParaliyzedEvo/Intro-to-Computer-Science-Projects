<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSnowballFight
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSnowballFight))
        Me.picTarget = New System.Windows.Forms.PictureBox()
        Me.picSnowball = New System.Windows.Forms.PictureBox()
        Me.picPenguin = New System.Windows.Forms.PictureBox()
        Me.tmrTargetUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrTargetDown = New System.Windows.Forms.Timer(Me.components)
        Me.tmrSnowball = New System.Windows.Forms.Timer(Me.components)
        Me.tmrResetTarget = New System.Windows.Forms.Timer(Me.components)
        Me.lblHits = New System.Windows.Forms.Label()
        Me.lblNumberOfHits = New System.Windows.Forms.Label()
        Me.lblMisses = New System.Windows.Forms.Label()
        Me.lblNumberOfMisses = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.picTarget, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSnowball, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPenguin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picTarget
        '
        Me.picTarget.Image = CType(resources.GetObject("picTarget.Image"), System.Drawing.Image)
        Me.picTarget.Location = New System.Drawing.Point(46, 35)
        Me.picTarget.Name = "picTarget"
        Me.picTarget.Size = New System.Drawing.Size(100, 100)
        Me.picTarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTarget.TabIndex = 0
        Me.picTarget.TabStop = False
        '
        'picSnowball
        '
        Me.picSnowball.Image = CType(resources.GetObject("picSnowball.Image"), System.Drawing.Image)
        Me.picSnowball.Location = New System.Drawing.Point(656, 35)
        Me.picSnowball.Name = "picSnowball"
        Me.picSnowball.Size = New System.Drawing.Size(100, 50)
        Me.picSnowball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSnowball.TabIndex = 1
        Me.picSnowball.TabStop = False
        '
        'picPenguin
        '
        Me.picPenguin.Image = CType(resources.GetObject("picPenguin.Image"), System.Drawing.Image)
        Me.picPenguin.Location = New System.Drawing.Point(656, 107)
        Me.picPenguin.Name = "picPenguin"
        Me.picPenguin.Size = New System.Drawing.Size(100, 115)
        Me.picPenguin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPenguin.TabIndex = 2
        Me.picPenguin.TabStop = False
        '
        'tmrTargetUp
        '
        '
        'tmrTargetDown
        '
        '
        'tmrSnowball
        '
        Me.tmrSnowball.Interval = 50
        '
        'tmrResetTarget
        '
        '
        'lblHits
        '
        Me.lblHits.AutoSize = True
        Me.lblHits.Location = New System.Drawing.Point(338, 401)
        Me.lblHits.Name = "lblHits"
        Me.lblHits.Size = New System.Drawing.Size(28, 13)
        Me.lblHits.TabIndex = 3
        Me.lblHits.Text = "Hits:"
        '
        'lblNumberOfHits
        '
        Me.lblNumberOfHits.AutoSize = True
        Me.lblNumberOfHits.Location = New System.Drawing.Point(366, 401)
        Me.lblNumberOfHits.Name = "lblNumberOfHits"
        Me.lblNumberOfHits.Size = New System.Drawing.Size(0, 13)
        Me.lblNumberOfHits.TabIndex = 4
        '
        'lblMisses
        '
        Me.lblMisses.AutoSize = True
        Me.lblMisses.Location = New System.Drawing.Point(418, 401)
        Me.lblMisses.Name = "lblMisses"
        Me.lblMisses.Size = New System.Drawing.Size(42, 13)
        Me.lblMisses.TabIndex = 5
        Me.lblMisses.Text = "Misses:"
        '
        'lblNumberOfMisses
        '
        Me.lblNumberOfMisses.AutoSize = True
        Me.lblNumberOfMisses.Location = New System.Drawing.Point(460, 401)
        Me.lblNumberOfMisses.Name = "lblNumberOfMisses"
        Me.lblNumberOfMisses.Size = New System.Drawing.Size(0, 13)
        Me.lblNumberOfMisses.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(179, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'frmSnowballFight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblNumberOfMisses)
        Me.Controls.Add(Me.lblMisses)
        Me.Controls.Add(Me.lblNumberOfHits)
        Me.Controls.Add(Me.lblHits)
        Me.Controls.Add(Me.picPenguin)
        Me.Controls.Add(Me.picSnowball)
        Me.Controls.Add(Me.picTarget)
        Me.Name = "frmSnowballFight"
        Me.Text = "Form1"
        CType(Me.picTarget, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSnowball, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPenguin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picTarget As PictureBox
    Friend WithEvents picSnowball As PictureBox
    Friend WithEvents picPenguin As PictureBox
    Friend WithEvents tmrTargetUp As Timer
    Friend WithEvents tmrTargetDown As Timer
    Friend WithEvents tmrSnowball As Timer
    Friend WithEvents tmrResetTarget As Timer
    Friend WithEvents lblHits As Label
    Friend WithEvents lblNumberOfHits As Label
    Friend WithEvents lblMisses As Label
    Friend WithEvents lblNumberOfMisses As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
