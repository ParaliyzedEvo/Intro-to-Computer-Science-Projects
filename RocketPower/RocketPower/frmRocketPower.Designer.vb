<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRocketPower
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRocketPower))
        Me.picRocket = New System.Windows.Forms.PictureBox()
        Me.btnStartEngines = New System.Windows.Forms.Button()
        Me.btnTakeOff = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.tmrTakeOff = New System.Windows.Forms.Timer(Me.components)
        Me.picFire = New System.Windows.Forms.PictureBox()
        CType(Me.picRocket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFire, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picRocket
        '
        Me.picRocket.BackColor = System.Drawing.Color.Transparent
        Me.picRocket.Image = CType(resources.GetObject("picRocket.Image"), System.Drawing.Image)
        Me.picRocket.Location = New System.Drawing.Point(12, 230)
        Me.picRocket.Name = "picRocket"
        Me.picRocket.Size = New System.Drawing.Size(166, 187)
        Me.picRocket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRocket.TabIndex = 0
        Me.picRocket.TabStop = False
        '
        'btnStartEngines
        '
        Me.btnStartEngines.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnStartEngines.Location = New System.Drawing.Point(711, 323)
        Me.btnStartEngines.Name = "btnStartEngines"
        Me.btnStartEngines.Size = New System.Drawing.Size(106, 44)
        Me.btnStartEngines.TabIndex = 1
        Me.btnStartEngines.Text = "Start Engines"
        Me.btnStartEngines.UseVisualStyleBackColor = False
        '
        'btnTakeOff
        '
        Me.btnTakeOff.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnTakeOff.Location = New System.Drawing.Point(711, 373)
        Me.btnTakeOff.Name = "btnTakeOff"
        Me.btnTakeOff.Size = New System.Drawing.Size(106, 44)
        Me.btnTakeOff.TabIndex = 2
        Me.btnTakeOff.Text = "Take Off"
        Me.btnTakeOff.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnReset.Location = New System.Drawing.Point(711, 423)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(106, 44)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'tmrTakeOff
        '
        '
        'picFire
        '
        Me.picFire.BackColor = System.Drawing.Color.Transparent
        Me.picFire.Image = CType(resources.GetObject("picFire.Image"), System.Drawing.Image)
        Me.picFire.Location = New System.Drawing.Point(43, 381)
        Me.picFire.Name = "picFire"
        Me.picFire.Size = New System.Drawing.Size(100, 101)
        Me.picFire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFire.TabIndex = 4
        Me.picFire.TabStop = False
        Me.picFire.Visible = False
        '
        'frmRocketPower
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(842, 494)
        Me.Controls.Add(Me.picFire)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnTakeOff)
        Me.Controls.Add(Me.btnStartEngines)
        Me.Controls.Add(Me.picRocket)
        Me.Name = "frmRocketPower"
        Me.Text = "Form1"
        CType(Me.picRocket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFire, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picRocket As PictureBox
    Friend WithEvents btnStartEngines As Button
    Friend WithEvents btnTakeOff As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents tmrTakeOff As Timer
    Friend WithEvents picFire As PictureBox
End Class
