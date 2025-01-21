<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFavorites
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFavorites))
        Me.lblLabel = New System.Windows.Forms.Label()
        Me.lblFood = New System.Windows.Forms.Label()
        Me.lblAnimal = New System.Windows.Forms.Label()
        Me.btnFood = New System.Windows.Forms.Button()
        Me.btnAnimal = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.picFood = New System.Windows.Forms.PictureBox()
        Me.picAnimal = New System.Windows.Forms.PictureBox()
        CType(Me.picFood, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAnimal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLabel
        '
        Me.lblLabel.AutoSize = True
        Me.lblLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.25!)
        Me.lblLabel.ForeColor = System.Drawing.Color.Blue
        Me.lblLabel.Location = New System.Drawing.Point(317, 48)
        Me.lblLabel.Name = "lblLabel"
        Me.lblLabel.Size = New System.Drawing.Size(130, 44)
        Me.lblLabel.TabIndex = 0
        Me.lblLabel.Text = "Andrei"
        '
        'lblFood
        '
        Me.lblFood.AutoSize = True
        Me.lblFood.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.lblFood.Location = New System.Drawing.Point(162, 369)
        Me.lblFood.Name = "lblFood"
        Me.lblFood.Size = New System.Drawing.Size(81, 31)
        Me.lblFood.TabIndex = 1
        Me.lblFood.Text = "Pizza"
        Me.lblFood.Visible = False
        '
        'lblAnimal
        '
        Me.lblAnimal.AutoSize = True
        Me.lblAnimal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.lblAnimal.Location = New System.Drawing.Point(557, 369)
        Me.lblAnimal.Name = "lblAnimal"
        Me.lblAnimal.Size = New System.Drawing.Size(85, 31)
        Me.lblAnimal.TabIndex = 2
        Me.lblAnimal.Text = "Shark"
        Me.lblAnimal.Visible = False
        '
        'btnFood
        '
        Me.btnFood.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnFood.ForeColor = System.Drawing.Color.Lime
        Me.btnFood.Location = New System.Drawing.Point(168, 108)
        Me.btnFood.Name = "btnFood"
        Me.btnFood.Size = New System.Drawing.Size(75, 42)
        Me.btnFood.TabIndex = 3
        Me.btnFood.Text = "Favorite Food"
        Me.btnFood.UseVisualStyleBackColor = False
        '
        'btnAnimal
        '
        Me.btnAnimal.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnAnimal.ForeColor = System.Drawing.Color.Lime
        Me.btnAnimal.Location = New System.Drawing.Point(563, 108)
        Me.btnAnimal.Name = "btnAnimal"
        Me.btnAnimal.Size = New System.Drawing.Size(75, 42)
        Me.btnAnimal.TabIndex = 4
        Me.btnAnimal.Text = "Favorite Animal"
        Me.btnAnimal.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Red
        Me.btnReset.Location = New System.Drawing.Point(12, 415)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnEnd
        '
        Me.btnEnd.BackColor = System.Drawing.Color.Red
        Me.btnEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.btnEnd.Location = New System.Drawing.Point(772, 415)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(30, 34)
        Me.btnEnd.TabIndex = 6
        Me.btnEnd.Text = "X"
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'picFood
        '
        Me.picFood.Image = CType(resources.GetObject("picFood.Image"), System.Drawing.Image)
        Me.picFood.Location = New System.Drawing.Point(81, 156)
        Me.picFood.Name = "picFood"
        Me.picFood.Size = New System.Drawing.Size(259, 194)
        Me.picFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFood.TabIndex = 7
        Me.picFood.TabStop = False
        Me.picFood.Visible = False
        '
        'picAnimal
        '
        Me.picAnimal.Image = CType(resources.GetObject("picAnimal.Image"), System.Drawing.Image)
        Me.picAnimal.Location = New System.Drawing.Point(451, 172)
        Me.picAnimal.Name = "picAnimal"
        Me.picAnimal.Size = New System.Drawing.Size(310, 163)
        Me.picAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAnimal.TabIndex = 8
        Me.picAnimal.TabStop = False
        Me.picAnimal.Visible = False
        '
        'FrmFavorites
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.picAnimal)
        Me.Controls.Add(Me.picFood)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnAnimal)
        Me.Controls.Add(Me.btnFood)
        Me.Controls.Add(Me.lblAnimal)
        Me.Controls.Add(Me.lblFood)
        Me.Controls.Add(Me.lblLabel)
        Me.Name = "FrmFavorites"
        Me.Text = "z"
        CType(Me.picFood, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAnimal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLabel As Label
    Friend WithEvents lblFood As Label
    Friend WithEvents lblAnimal As Label
    Friend WithEvents btnFood As Button
    Friend WithEvents btnAnimal As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnEnd As Button
    Friend WithEvents picFood As PictureBox
    Friend WithEvents picAnimal As PictureBox
End Class
