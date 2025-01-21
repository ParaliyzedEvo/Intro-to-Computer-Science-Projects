<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFormatToMoney
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
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.txtOriginalNumber = New System.Windows.Forms.TextBox()
        Me.txtCurrencyFormat = New System.Windows.Forms.TextBox()
        Me.btnFormat = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.lblInstructions.Location = New System.Drawing.Point(290, 49)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(186, 20)
        Me.lblInstructions.TabIndex = 0
        Me.lblInstructions.Text = "Type a number in below"
        '
        'txtOriginalNumber
        '
        Me.txtOriginalNumber.Location = New System.Drawing.Point(261, 127)
        Me.txtOriginalNumber.Name = "txtOriginalNumber"
        Me.txtOriginalNumber.Size = New System.Drawing.Size(230, 20)
        Me.txtOriginalNumber.TabIndex = 1
        '
        'txtCurrencyFormat
        '
        Me.txtCurrencyFormat.Location = New System.Drawing.Point(261, 237)
        Me.txtCurrencyFormat.Name = "txtCurrencyFormat"
        Me.txtCurrencyFormat.Size = New System.Drawing.Size(230, 20)
        Me.txtCurrencyFormat.TabIndex = 2
        '
        'btnFormat
        '
        Me.btnFormat.Location = New System.Drawing.Point(310, 178)
        Me.btnFormat.Name = "btnFormat"
        Me.btnFormat.Size = New System.Drawing.Size(135, 23)
        Me.btnFormat.TabIndex = 3
        Me.btnFormat.Text = "Format number to money"
        Me.btnFormat.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.BackColor = System.Drawing.Color.Red
        Me.btnEnd.Location = New System.Drawing.Point(783, -4)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(22, 23)
        Me.btnEnd.TabIndex = 4
        Me.btnEnd.Text = "X"
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'frmFormatToMoney
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnFormat)
        Me.Controls.Add(Me.txtCurrencyFormat)
        Me.Controls.Add(Me.txtOriginalNumber)
        Me.Controls.Add(Me.lblInstructions)
        Me.Name = "frmFormatToMoney"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInstructions As Label
    Friend WithEvents txtOriginalNumber As TextBox
    Friend WithEvents txtCurrencyFormat As TextBox
    Friend WithEvents btnFormat As Button
    Friend WithEvents btnEnd As Button
End Class
