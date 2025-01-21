<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCalculator))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblInputerNumber1 = New System.Windows.Forms.Label()
        Me.lblInputNumber2 = New System.Windows.Forms.Label()
        Me.lblOutputNumber = New System.Windows.Forms.Label()
        Me.txtValue1 = New System.Windows.Forms.TextBox()
        Me.txtValue2 = New System.Windows.Forms.TextBox()
        Me.txtOutputNumber = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSubtract = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.lblTitle.Location = New System.Drawing.Point(39, 49)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(103, 29)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Integers"
        '
        'lblInputerNumber1
        '
        Me.lblInputerNumber1.AutoSize = True
        Me.lblInputerNumber1.Location = New System.Drawing.Point(83, 116)
        Me.lblInputerNumber1.Name = "lblInputerNumber1"
        Me.lblInputerNumber1.Size = New System.Drawing.Size(80, 13)
        Me.lblInputerNumber1.TabIndex = 1
        Me.lblInputerNumber1.Text = "Input Number 1"
        '
        'lblInputNumber2
        '
        Me.lblInputNumber2.AutoSize = True
        Me.lblInputNumber2.Location = New System.Drawing.Point(629, 116)
        Me.lblInputNumber2.Name = "lblInputNumber2"
        Me.lblInputNumber2.Size = New System.Drawing.Size(80, 13)
        Me.lblInputNumber2.TabIndex = 2
        Me.lblInputNumber2.Text = "Input Number 2"
        '
        'lblOutputNumber
        '
        Me.lblOutputNumber.AutoSize = True
        Me.lblOutputNumber.Location = New System.Drawing.Point(559, 263)
        Me.lblOutputNumber.Name = "lblOutputNumber"
        Me.lblOutputNumber.Size = New System.Drawing.Size(79, 13)
        Me.lblOutputNumber.TabIndex = 3
        Me.lblOutputNumber.Text = "Output Number"
        '
        'txtValue1
        '
        Me.txtValue1.Location = New System.Drawing.Point(74, 132)
        Me.txtValue1.Name = "txtValue1"
        Me.txtValue1.Size = New System.Drawing.Size(100, 20)
        Me.txtValue1.TabIndex = 4
        '
        'txtValue2
        '
        Me.txtValue2.Location = New System.Drawing.Point(621, 132)
        Me.txtValue2.Name = "txtValue2"
        Me.txtValue2.Size = New System.Drawing.Size(100, 20)
        Me.txtValue2.TabIndex = 5
        '
        'txtOutputNumber
        '
        Me.txtOutputNumber.Location = New System.Drawing.Point(549, 279)
        Me.txtOutputNumber.Name = "txtOutputNumber"
        Me.txtOutputNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtOutputNumber.TabIndex = 6
        '
        'btnAdd
        '
        Me.btnAdd.BackgroundImage = CType(resources.GetObject("btnAdd.BackgroundImage"), System.Drawing.Image)
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdd.Location = New System.Drawing.Point(232, 87)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 71)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSubtract
        '
        Me.btnSubtract.BackgroundImage = CType(resources.GetObject("btnSubtract.BackgroundImage"), System.Drawing.Image)
        Me.btnSubtract.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSubtract.Location = New System.Drawing.Point(313, 87)
        Me.btnSubtract.Name = "btnSubtract"
        Me.btnSubtract.Size = New System.Drawing.Size(75, 71)
        Me.btnSubtract.TabIndex = 8
        Me.btnSubtract.UseVisualStyleBackColor = True
        '
        'btnMultiply
        '
        Me.btnMultiply.BackgroundImage = CType(resources.GetObject("btnMultiply.BackgroundImage"), System.Drawing.Image)
        Me.btnMultiply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMultiply.Location = New System.Drawing.Point(394, 87)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(75, 71)
        Me.btnMultiply.TabIndex = 9
        Me.btnMultiply.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.BackgroundImage = CType(resources.GetObject("btnDivide.BackgroundImage"), System.Drawing.Image)
        Me.btnDivide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDivide.Location = New System.Drawing.Point(475, 87)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(75, 71)
        Me.btnDivide.TabIndex = 10
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(211, 297)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.BackColor = System.Drawing.Color.Red
        Me.btnEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btnEnd.Location = New System.Drawing.Point(776, -2)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(25, 28)
        Me.btnEnd.TabIndex = 12
        Me.btnEnd.Text = "X"
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'frmCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnMultiply)
        Me.Controls.Add(Me.btnSubtract)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtOutputNumber)
        Me.Controls.Add(Me.txtValue2)
        Me.Controls.Add(Me.txtValue1)
        Me.Controls.Add(Me.lblOutputNumber)
        Me.Controls.Add(Me.lblInputNumber2)
        Me.Controls.Add(Me.lblInputerNumber1)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmCalculator"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblInputerNumber1 As Label
    Friend WithEvents lblInputNumber2 As Label
    Friend WithEvents lblOutputNumber As Label
    Friend WithEvents txtValue1 As TextBox
    Friend WithEvents txtValue2 As TextBox
    Friend WithEvents txtOutputNumber As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSubtract As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnEnd As Button
End Class
