<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLeisureGames
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
        Me.cboActivity = New System.Windows.Forms.ComboBox()
        Me.cboMinutesPlayed = New System.Windows.Forms.ComboBox()
        Me.picActivityType = New System.Windows.Forms.PictureBox()
        Me.btnCalculateCalories = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.lblActivityType = New System.Windows.Forms.Label()
        Me.lblTotalCaloriesBurned = New System.Windows.Forms.Label()
        CType(Me.picActivityType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboActivity
        '
        Me.cboActivity.FormattingEnabled = True
        Me.cboActivity.Location = New System.Drawing.Point(70, 110)
        Me.cboActivity.Name = "cboActivity"
        Me.cboActivity.Size = New System.Drawing.Size(338, 21)
        Me.cboActivity.TabIndex = 0
        '
        'cboMinutesPlayed
        '
        Me.cboMinutesPlayed.FormattingEnabled = True
        Me.cboMinutesPlayed.Location = New System.Drawing.Point(70, 232)
        Me.cboMinutesPlayed.Name = "cboMinutesPlayed"
        Me.cboMinutesPlayed.Size = New System.Drawing.Size(338, 21)
        Me.cboMinutesPlayed.TabIndex = 1
        '
        'picActivityType
        '
        Me.picActivityType.Location = New System.Drawing.Point(555, 82)
        Me.picActivityType.Name = "picActivityType"
        Me.picActivityType.Size = New System.Drawing.Size(174, 171)
        Me.picActivityType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picActivityType.TabIndex = 2
        Me.picActivityType.TabStop = False
        '
        'btnCalculateCalories
        '
        Me.btnCalculateCalories.Location = New System.Drawing.Point(583, 274)
        Me.btnCalculateCalories.Name = "btnCalculateCalories"
        Me.btnCalculateCalories.Size = New System.Drawing.Size(122, 23)
        Me.btnCalculateCalories.TabIndex = 3
        Me.btnCalculateCalories.Text = "Calculate Calories"
        Me.btnCalculateCalories.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.BackColor = System.Drawing.Color.Red
        Me.btnEnd.Location = New System.Drawing.Point(782, -4)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(21, 23)
        Me.btnEnd.TabIndex = 4
        Me.btnEnd.Text = "X"
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'lblActivityType
        '
        Me.lblActivityType.AutoSize = True
        Me.lblActivityType.Location = New System.Drawing.Point(628, 51)
        Me.lblActivityType.Name = "lblActivityType"
        Me.lblActivityType.Size = New System.Drawing.Size(0, 13)
        Me.lblActivityType.TabIndex = 5
        '
        'lblTotalCaloriesBurned
        '
        Me.lblTotalCaloriesBurned.AutoSize = True
        Me.lblTotalCaloriesBurned.Location = New System.Drawing.Point(216, 274)
        Me.lblTotalCaloriesBurned.Name = "lblTotalCaloriesBurned"
        Me.lblTotalCaloriesBurned.Size = New System.Drawing.Size(0, 13)
        Me.lblTotalCaloriesBurned.TabIndex = 6
        '
        'frmLeisureGames
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aquamarine
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblTotalCaloriesBurned)
        Me.Controls.Add(Me.lblActivityType)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnCalculateCalories)
        Me.Controls.Add(Me.picActivityType)
        Me.Controls.Add(Me.cboMinutesPlayed)
        Me.Controls.Add(Me.cboActivity)
        Me.Name = "frmLeisureGames"
        Me.Text = "Form1"
        CType(Me.picActivityType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboActivity As ComboBox
    Friend WithEvents cboMinutesPlayed As ComboBox
    Friend WithEvents picActivityType As PictureBox
    Friend WithEvents btnCalculateCalories As Button
    Friend WithEvents btnEnd As Button
    Friend WithEvents lblActivityType As Label
    Friend WithEvents lblTotalCaloriesBurned As Label
End Class
