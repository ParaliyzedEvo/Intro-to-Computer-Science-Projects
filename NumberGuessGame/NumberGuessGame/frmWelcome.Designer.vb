<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWelcome
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
        Me.btnEasy = New System.Windows.Forms.Button()
        Me.btnMedium = New System.Windows.Forms.Button()
        Me.btnHard = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnEasy
        '
        Me.btnEasy.BackColor = System.Drawing.Color.Lime
        Me.btnEasy.Location = New System.Drawing.Point(101, 355)
        Me.btnEasy.Name = "btnEasy"
        Me.btnEasy.Size = New System.Drawing.Size(75, 23)
        Me.btnEasy.TabIndex = 0
        Me.btnEasy.Text = "Easy"
        Me.btnEasy.UseVisualStyleBackColor = False
        '
        'btnMedium
        '
        Me.btnMedium.BackColor = System.Drawing.Color.Yellow
        Me.btnMedium.Location = New System.Drawing.Point(362, 355)
        Me.btnMedium.Name = "btnMedium"
        Me.btnMedium.Size = New System.Drawing.Size(75, 23)
        Me.btnMedium.TabIndex = 1
        Me.btnMedium.Text = "Medium"
        Me.btnMedium.UseVisualStyleBackColor = False
        '
        'btnHard
        '
        Me.btnHard.BackColor = System.Drawing.Color.Red
        Me.btnHard.Location = New System.Drawing.Point(623, 355)
        Me.btnHard.Name = "btnHard"
        Me.btnHard.Size = New System.Drawing.Size(75, 23)
        Me.btnHard.TabIndex = 2
        Me.btnHard.Text = "Hard"
        Me.btnHard.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.25!)
        Me.lblTitle.Location = New System.Drawing.Point(138, 97)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(507, 36)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "Welcome to the Number Guess game"
        '
        'btnEnd
        '
        Me.btnEnd.BackColor = System.Drawing.Color.Red
        Me.btnEnd.Location = New System.Drawing.Point(783, -4)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(21, 23)
        Me.btnEnd.TabIndex = 4
        Me.btnEnd.Text = "X"
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'frmWelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnHard)
        Me.Controls.Add(Me.btnMedium)
        Me.Controls.Add(Me.btnEasy)
        Me.Name = "frmWelcome"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEasy As Button
    Friend WithEvents btnMedium As Button
    Friend WithEvents btnHard As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnEnd As Button
End Class
