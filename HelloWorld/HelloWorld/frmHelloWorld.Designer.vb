<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelloWorld
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHelloWorld))
        Me.picDogCat = New System.Windows.Forms.PictureBox()
        Me.picYesNo = New System.Windows.Forms.PictureBox()
        Me.btnPressMe = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.lblOutputText = New System.Windows.Forms.Label()
        CType(Me.picDogCat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picYesNo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picDogCat
        '
        Me.picDogCat.Image = CType(resources.GetObject("picDogCat.Image"), System.Drawing.Image)
        Me.picDogCat.Location = New System.Drawing.Point(62, 47)
        Me.picDogCat.Name = "picDogCat"
        Me.picDogCat.Size = New System.Drawing.Size(212, 226)
        Me.picDogCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDogCat.TabIndex = 0
        Me.picDogCat.TabStop = False
        '
        'picYesNo
        '
        Me.picYesNo.Location = New System.Drawing.Point(1181, 47)
        Me.picYesNo.Name = "picYesNo"
        Me.picYesNo.Size = New System.Drawing.Size(224, 226)
        Me.picYesNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picYesNo.TabIndex = 1
        Me.picYesNo.TabStop = False
        '
        'btnPressMe
        '
        Me.btnPressMe.BackColor = System.Drawing.Color.Aqua
        Me.btnPressMe.Location = New System.Drawing.Point(701, 201)
        Me.btnPressMe.Name = "btnPressMe"
        Me.btnPressMe.Size = New System.Drawing.Size(75, 23)
        Me.btnPressMe.TabIndex = 2
        Me.btnPressMe.Text = "Press Me"
        Me.btnPressMe.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Lime
        Me.btnReset.Location = New System.Drawing.Point(1364, 537)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnEnd
        '
        Me.btnEnd.BackColor = System.Drawing.Color.Red
        Me.btnEnd.Location = New System.Drawing.Point(1364, 579)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 4
        Me.btnEnd.Text = "End"
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'lblOutputText
        '
        Me.lblOutputText.AutoSize = True
        Me.lblOutputText.Location = New System.Drawing.Point(1253, 286)
        Me.lblOutputText.Name = "lblOutputText"
        Me.lblOutputText.Size = New System.Drawing.Size(0, 13)
        Me.lblOutputText.TabIndex = 5
        '
        'frmHelloWorld
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1479, 629)
        Me.Controls.Add(Me.lblOutputText)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnPressMe)
        Me.Controls.Add(Me.picYesNo)
        Me.Controls.Add(Me.picDogCat)
        Me.Name = "frmHelloWorld"
        Me.Text = "Form1"
        CType(Me.picDogCat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picYesNo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picDogCat As PictureBox
    Friend WithEvents picYesNo As PictureBox
    Friend WithEvents btnPressMe As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnEnd As Button
    Friend WithEvents lblOutputText As Label
End Class
