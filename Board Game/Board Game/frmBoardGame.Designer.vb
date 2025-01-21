<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBoardGame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBoardGame))
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnRisk = New System.Windows.Forms.Button()
        Me.btnCaption = New System.Windows.Forms.Button()
        Me.picRisk1 = New System.Windows.Forms.PictureBox()
        Me.picRisk2 = New System.Windows.Forms.PictureBox()
        Me.picRisk3 = New System.Windows.Forms.PictureBox()
        Me.lblRisk = New System.Windows.Forms.Label()
        Me.lblCaption = New System.Windows.Forms.Label()
        CType(Me.picRisk1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRisk2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRisk3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEnd
        '
        Me.btnEnd.BackColor = System.Drawing.Color.Red
        Me.btnEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.btnEnd.Location = New System.Drawing.Point(776, 0)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(24, 27)
        Me.btnEnd.TabIndex = 0
        Me.btnEnd.Text = "X"
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Lime
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btnReset.Location = New System.Drawing.Point(-1, -1)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 28)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnRisk
        '
        Me.btnRisk.BackColor = System.Drawing.Color.Red
        Me.btnRisk.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.25!)
        Me.btnRisk.ForeColor = System.Drawing.Color.Black
        Me.btnRisk.Location = New System.Drawing.Point(277, 12)
        Me.btnRisk.Name = "btnRisk"
        Me.btnRisk.Size = New System.Drawing.Size(284, 98)
        Me.btnRisk.TabIndex = 2
        Me.btnRisk.Text = "Risk"
        Me.btnRisk.UseVisualStyleBackColor = False
        '
        'btnCaption
        '
        Me.btnCaption.BackColor = System.Drawing.Color.Lime
        Me.btnCaption.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCaption.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.25!)
        Me.btnCaption.Location = New System.Drawing.Point(298, 380)
        Me.btnCaption.Name = "btnCaption"
        Me.btnCaption.Size = New System.Drawing.Size(213, 58)
        Me.btnCaption.TabIndex = 3
        Me.btnCaption.Text = "Caption"
        Me.btnCaption.UseVisualStyleBackColor = False
        Me.btnCaption.Visible = False
        '
        'picRisk1
        '
        Me.picRisk1.Image = CType(resources.GetObject("picRisk1.Image"), System.Drawing.Image)
        Me.picRisk1.Location = New System.Drawing.Point(28, 152)
        Me.picRisk1.Name = "picRisk1"
        Me.picRisk1.Size = New System.Drawing.Size(225, 225)
        Me.picRisk1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picRisk1.TabIndex = 4
        Me.picRisk1.TabStop = False
        Me.picRisk1.Visible = False
        '
        'picRisk2
        '
        Me.picRisk2.Image = CType(resources.GetObject("picRisk2.Image"), System.Drawing.Image)
        Me.picRisk2.Location = New System.Drawing.Point(289, 179)
        Me.picRisk2.Name = "picRisk2"
        Me.picRisk2.Size = New System.Drawing.Size(203, 154)
        Me.picRisk2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRisk2.TabIndex = 5
        Me.picRisk2.TabStop = False
        Me.picRisk2.Visible = False
        '
        'picRisk3
        '
        Me.picRisk3.Image = CType(resources.GetObject("picRisk3.Image"), System.Drawing.Image)
        Me.picRisk3.Location = New System.Drawing.Point(507, 179)
        Me.picRisk3.Name = "picRisk3"
        Me.picRisk3.Size = New System.Drawing.Size(283, 178)
        Me.picRisk3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picRisk3.TabIndex = 6
        Me.picRisk3.TabStop = False
        Me.picRisk3.Visible = False
        '
        'lblRisk
        '
        Me.lblRisk.AutoSize = True
        Me.lblRisk.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblRisk.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.25!)
        Me.lblRisk.ForeColor = System.Drawing.Color.Red
        Me.lblRisk.Location = New System.Drawing.Point(366, 113)
        Me.lblRisk.Name = "lblRisk"
        Me.lblRisk.Size = New System.Drawing.Size(94, 44)
        Me.lblRisk.TabIndex = 7
        Me.lblRisk.Text = "Risk"
        Me.lblRisk.Visible = False
        '
        'lblCaption
        '
        Me.lblCaption.AutoSize = True
        Me.lblCaption.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!)
        Me.lblCaption.Location = New System.Drawing.Point(259, 370)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(292, 7)
        Me.lblCaption.TabIndex = 8
        Me.lblCaption.Text = "Risk is a strategy board game of diplomacy, conflict and conquest for two to six " &
    "players. "
        Me.lblCaption.Visible = False
        '
        'frmBoardGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblCaption)
        Me.Controls.Add(Me.lblRisk)
        Me.Controls.Add(Me.picRisk3)
        Me.Controls.Add(Me.picRisk2)
        Me.Controls.Add(Me.picRisk1)
        Me.Controls.Add(Me.btnCaption)
        Me.Controls.Add(Me.btnRisk)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnd)
        Me.Name = "frmBoardGame"
        Me.Text = "Form1"
        CType(Me.picRisk1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRisk2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRisk3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnd As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnRisk As Button
    Friend WithEvents btnCaption As Button
    Friend WithEvents picRisk1 As PictureBox
    Friend WithEvents picRisk2 As PictureBox
    Friend WithEvents picRisk3 As PictureBox
    Friend WithEvents lblRisk As Label
    Friend WithEvents lblCaption As Label
End Class
