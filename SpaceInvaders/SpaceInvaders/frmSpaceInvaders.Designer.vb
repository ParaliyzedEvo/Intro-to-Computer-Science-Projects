<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSpaceInvaders
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSpaceInvaders))
        Me.lblNumberOfPoints = New System.Windows.Forms.Label()
        Me.lblPoints = New System.Windows.Forms.Label()
        Me.tmrLeft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRight = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBullet = New System.Windows.Forms.Timer(Me.components)
        Me.picTarget1 = New System.Windows.Forms.PictureBox()
        Me.picTarget2 = New System.Windows.Forms.PictureBox()
        Me.picBullet = New System.Windows.Forms.PictureBox()
        Me.picShooter = New System.Windows.Forms.PictureBox()
        Me.picTarget4 = New System.Windows.Forms.PictureBox()
        Me.picTarget3 = New System.Windows.Forms.PictureBox()
        Me.picTarget7 = New System.Windows.Forms.PictureBox()
        Me.picTarget8 = New System.Windows.Forms.PictureBox()
        Me.picTarget6 = New System.Windows.Forms.PictureBox()
        Me.picTarget5 = New System.Windows.Forms.PictureBox()
        Me.tmrResetTarget = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picTarget1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTarget2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBullet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShooter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTarget4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTarget3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTarget7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTarget8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTarget6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTarget5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNumberOfPoints
        '
        Me.lblNumberOfPoints.AutoSize = True
        Me.lblNumberOfPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.lblNumberOfPoints.ForeColor = System.Drawing.Color.White
        Me.lblNumberOfPoints.Location = New System.Drawing.Point(103, 9)
        Me.lblNumberOfPoints.Name = "lblNumberOfPoints"
        Me.lblNumberOfPoints.Size = New System.Drawing.Size(0, 29)
        Me.lblNumberOfPoints.TabIndex = 6
        '
        'lblPoints
        '
        Me.lblPoints.AutoSize = True
        Me.lblPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.lblPoints.ForeColor = System.Drawing.Color.White
        Me.lblPoints.Location = New System.Drawing.Point(12, 9)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(91, 29)
        Me.lblPoints.TabIndex = 5
        Me.lblPoints.Text = "Points:"
        '
        'tmrLeft
        '
        '
        'tmrRight
        '
        '
        'tmrBullet
        '
        '
        'picTarget1
        '
        Me.picTarget1.Image = CType(resources.GetObject("picTarget1.Image"), System.Drawing.Image)
        Me.picTarget1.Location = New System.Drawing.Point(208, 33)
        Me.picTarget1.Name = "picTarget1"
        Me.picTarget1.Size = New System.Drawing.Size(74, 68)
        Me.picTarget1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTarget1.TabIndex = 7
        Me.picTarget1.TabStop = False
        '
        'picTarget2
        '
        Me.picTarget2.Image = CType(resources.GetObject("picTarget2.Image"), System.Drawing.Image)
        Me.picTarget2.Location = New System.Drawing.Point(288, 29)
        Me.picTarget2.Name = "picTarget2"
        Me.picTarget2.Size = New System.Drawing.Size(90, 72)
        Me.picTarget2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTarget2.TabIndex = 8
        Me.picTarget2.TabStop = False
        '
        'picBullet
        '
        Me.picBullet.Image = CType(resources.GetObject("picBullet.Image"), System.Drawing.Image)
        Me.picBullet.Location = New System.Drawing.Point(363, 340)
        Me.picBullet.Name = "picBullet"
        Me.picBullet.Size = New System.Drawing.Size(24, 36)
        Me.picBullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBullet.TabIndex = 10
        Me.picBullet.TabStop = False
        '
        'picShooter
        '
        Me.picShooter.Image = CType(resources.GetObject("picShooter.Image"), System.Drawing.Image)
        Me.picShooter.Location = New System.Drawing.Point(321, 376)
        Me.picShooter.Name = "picShooter"
        Me.picShooter.Size = New System.Drawing.Size(108, 72)
        Me.picShooter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShooter.TabIndex = 11
        Me.picShooter.TabStop = False
        '
        'picTarget4
        '
        Me.picTarget4.Image = CType(resources.GetObject("picTarget4.Image"), System.Drawing.Image)
        Me.picTarget4.Location = New System.Drawing.Point(468, 29)
        Me.picTarget4.Name = "picTarget4"
        Me.picTarget4.Size = New System.Drawing.Size(116, 72)
        Me.picTarget4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTarget4.TabIndex = 12
        Me.picTarget4.TabStop = False
        '
        'picTarget3
        '
        Me.picTarget3.Image = CType(resources.GetObject("picTarget3.Image"), System.Drawing.Image)
        Me.picTarget3.Location = New System.Drawing.Point(384, 31)
        Me.picTarget3.Name = "picTarget3"
        Me.picTarget3.Size = New System.Drawing.Size(78, 70)
        Me.picTarget3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTarget3.TabIndex = 13
        Me.picTarget3.TabStop = False
        '
        'picTarget7
        '
        Me.picTarget7.Image = CType(resources.GetObject("picTarget7.Image"), System.Drawing.Image)
        Me.picTarget7.Location = New System.Drawing.Point(384, 109)
        Me.picTarget7.Name = "picTarget7"
        Me.picTarget7.Size = New System.Drawing.Size(78, 70)
        Me.picTarget7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTarget7.TabIndex = 17
        Me.picTarget7.TabStop = False
        '
        'picTarget8
        '
        Me.picTarget8.Image = CType(resources.GetObject("picTarget8.Image"), System.Drawing.Image)
        Me.picTarget8.Location = New System.Drawing.Point(468, 107)
        Me.picTarget8.Name = "picTarget8"
        Me.picTarget8.Size = New System.Drawing.Size(116, 72)
        Me.picTarget8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTarget8.TabIndex = 16
        Me.picTarget8.TabStop = False
        '
        'picTarget6
        '
        Me.picTarget6.Image = CType(resources.GetObject("picTarget6.Image"), System.Drawing.Image)
        Me.picTarget6.Location = New System.Drawing.Point(288, 107)
        Me.picTarget6.Name = "picTarget6"
        Me.picTarget6.Size = New System.Drawing.Size(90, 72)
        Me.picTarget6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTarget6.TabIndex = 15
        Me.picTarget6.TabStop = False
        '
        'picTarget5
        '
        Me.picTarget5.Image = CType(resources.GetObject("picTarget5.Image"), System.Drawing.Image)
        Me.picTarget5.Location = New System.Drawing.Point(208, 111)
        Me.picTarget5.Name = "picTarget5"
        Me.picTarget5.Size = New System.Drawing.Size(74, 68)
        Me.picTarget5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTarget5.TabIndex = 14
        Me.picTarget5.TabStop = False
        '
        'frmSpaceInvaders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.picTarget7)
        Me.Controls.Add(Me.picTarget8)
        Me.Controls.Add(Me.picTarget6)
        Me.Controls.Add(Me.picTarget5)
        Me.Controls.Add(Me.picTarget3)
        Me.Controls.Add(Me.picTarget4)
        Me.Controls.Add(Me.picShooter)
        Me.Controls.Add(Me.picBullet)
        Me.Controls.Add(Me.picTarget2)
        Me.Controls.Add(Me.picTarget1)
        Me.Controls.Add(Me.lblNumberOfPoints)
        Me.Controls.Add(Me.lblPoints)
        Me.Name = "frmSpaceInvaders"
        Me.Text = "Form1"
        CType(Me.picTarget1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTarget2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBullet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShooter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTarget4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTarget3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTarget7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTarget8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTarget6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTarget5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumberOfPoints As Label
    Friend WithEvents lblPoints As Label
    Friend WithEvents tmrLeft As Timer
    Friend WithEvents tmrRight As Timer
    Friend WithEvents tmrBullet As Timer
    Friend WithEvents picTarget1 As PictureBox
    Friend WithEvents picTarget2 As PictureBox
    Friend WithEvents picBullet As PictureBox
    Friend WithEvents picShooter As PictureBox
    Friend WithEvents picTarget4 As PictureBox
    Friend WithEvents picTarget3 As PictureBox
    Friend WithEvents picTarget7 As PictureBox
    Friend WithEvents picTarget8 As PictureBox
    Friend WithEvents picTarget6 As PictureBox
    Friend WithEvents picTarget5 As PictureBox
    Friend WithEvents tmrResetTarget As Timer
End Class
