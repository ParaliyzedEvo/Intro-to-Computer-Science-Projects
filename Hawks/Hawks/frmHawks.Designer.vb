<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHawks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHawks))
        Me.btnDisplayPicture = New System.Windows.Forms.Button()
        Me.picDisplay = New System.Windows.Forms.PictureBox()
        Me.btnClearPicture = New System.Windows.Forms.Button()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.btnClearText = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        CType(Me.picDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDisplayPicture
        '
        Me.btnDisplayPicture.BackColor = System.Drawing.Color.Lime
        Me.btnDisplayPicture.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.btnDisplayPicture.Location = New System.Drawing.Point(295, 192)
        Me.btnDisplayPicture.Name = "btnDisplayPicture"
        Me.btnDisplayPicture.Size = New System.Drawing.Size(204, 73)
        Me.btnDisplayPicture.TabIndex = 0
        Me.btnDisplayPicture.Text = "Display Picture"
        Me.btnDisplayPicture.UseVisualStyleBackColor = False
        '
        'picDisplay
        '
        Me.picDisplay.Image = CType(resources.GetObject("picDisplay.Image"), System.Drawing.Image)
        Me.picDisplay.Location = New System.Drawing.Point(307, 10)
        Me.picDisplay.Name = "picDisplay"
        Me.picDisplay.Size = New System.Drawing.Size(183, 176)
        Me.picDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDisplay.TabIndex = 1
        Me.picDisplay.TabStop = False
        Me.picDisplay.Visible = False
        '
        'btnClearPicture
        '
        Me.btnClearPicture.BackColor = System.Drawing.Color.Red
        Me.btnClearPicture.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.btnClearPicture.Location = New System.Drawing.Point(295, 271)
        Me.btnClearPicture.Name = "btnClearPicture"
        Me.btnClearPicture.Size = New System.Drawing.Size(204, 73)
        Me.btnClearPicture.TabIndex = 2
        Me.btnClearPicture.Text = "Clear Picture"
        Me.btnClearPicture.UseVisualStyleBackColor = False
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(81, 166)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(100, 20)
        Me.txtFullName.TabIndex = 3
        '
        'btnClearText
        '
        Me.btnClearText.BackColor = System.Drawing.Color.Red
        Me.btnClearText.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.btnClearText.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClearText.Location = New System.Drawing.Point(81, 192)
        Me.btnClearText.Name = "btnClearText"
        Me.btnClearText.Size = New System.Drawing.Size(100, 41)
        Me.btnClearText.TabIndex = 4
        Me.btnClearText.Text = "Clear Text"
        Me.btnClearText.UseVisualStyleBackColor = False
        '
        'btnEnd
        '
        Me.btnEnd.BackColor = System.Drawing.Color.Red
        Me.btnEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.btnEnd.Location = New System.Drawing.Point(777, 427)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(22, 24)
        Me.btnEnd.TabIndex = 5
        Me.btnEnd.Text = "X"
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'frmHawks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnClearText)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.btnClearPicture)
        Me.Controls.Add(Me.picDisplay)
        Me.Controls.Add(Me.btnDisplayPicture)
        Me.Name = "frmHawks"
        Me.Text = "Form1"
        CType(Me.picDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDisplayPicture As Button
    Friend WithEvents picDisplay As PictureBox
    Friend WithEvents btnClearPicture As Button
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents btnClearText As Button
    Friend WithEvents btnEnd As Button
End Class
