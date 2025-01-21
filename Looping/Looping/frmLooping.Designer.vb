<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLooping
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
        Me.btn1to10 = New System.Windows.Forms.Button()
        Me.btn1to100 = New System.Windows.Forms.Button()
        Me.btnEvensto100 = New System.Windows.Forms.Button()
        Me.btn100to1 = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lstNumbers = New System.Windows.Forms.ListBox()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn1to10
        '
        Me.btn1to10.Location = New System.Drawing.Point(132, 68)
        Me.btn1to10.Name = "btn1to10"
        Me.btn1to10.Size = New System.Drawing.Size(90, 32)
        Me.btn1to10.TabIndex = 0
        Me.btn1to10.Text = "1 to 10"
        Me.btn1to10.UseVisualStyleBackColor = True
        '
        'btn1to100
        '
        Me.btn1to100.Location = New System.Drawing.Point(132, 119)
        Me.btn1to100.Name = "btn1to100"
        Me.btn1to100.Size = New System.Drawing.Size(90, 32)
        Me.btn1to100.TabIndex = 1
        Me.btn1to100.Text = "1 to 100"
        Me.btn1to100.UseVisualStyleBackColor = True
        '
        'btnEvensto100
        '
        Me.btnEvensto100.Location = New System.Drawing.Point(132, 168)
        Me.btnEvensto100.Name = "btnEvensto100"
        Me.btnEvensto100.Size = New System.Drawing.Size(90, 32)
        Me.btnEvensto100.TabIndex = 2
        Me.btnEvensto100.Text = "Evens to 100"
        Me.btnEvensto100.UseVisualStyleBackColor = True
        '
        'btn100to1
        '
        Me.btn100to1.Location = New System.Drawing.Point(132, 217)
        Me.btn100to1.Name = "btn100to1"
        Me.btn100to1.Size = New System.Drawing.Size(90, 32)
        Me.btn100to1.TabIndex = 3
        Me.btn100to1.Text = "100 to 1"
        Me.btn100to1.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(132, 379)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 24)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lstNumbers
        '
        Me.lstNumbers.FormattingEnabled = True
        Me.lstNumbers.Location = New System.Drawing.Point(583, 68)
        Me.lstNumbers.Name = "lstNumbers"
        Me.lstNumbers.Size = New System.Drawing.Size(147, 264)
        Me.lstNumbers.TabIndex = 5
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(609, 379)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(90, 24)
        Me.btnEnd.TabIndex = 6
        Me.btnEnd.Text = "End"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'frmLooping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.lstNumbers)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btn100to1)
        Me.Controls.Add(Me.btnEvensto100)
        Me.Controls.Add(Me.btn1to100)
        Me.Controls.Add(Me.btn1to10)
        Me.Name = "frmLooping"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn1to10 As Button
    Friend WithEvents btn1to100 As Button
    Friend WithEvents btnEvensto100 As Button
    Friend WithEvents btn100to1 As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lstNumbers As ListBox
    Friend WithEvents btnEnd As Button
End Class
