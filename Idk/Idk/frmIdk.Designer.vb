<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmIdk
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblGames = New System.Windows.Forms.Label()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.lblSortedList = New System.Windows.Forms.Label()
        Me.lstTemperatures = New System.Windows.Forms.ListBox()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.lstSorted = New System.Windows.Forms.ListBox()
        Me.btnEnterTemps = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnSortTemps = New System.Windows.Forms.Button()
        Me.btnAverage = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblGames
        '
        Me.lblGames.AutoSize = True
        Me.lblGames.Location = New System.Drawing.Point(205, 50)
        Me.lblGames.Name = "lblGames"
        Me.lblGames.Size = New System.Drawing.Size(72, 13)
        Me.lblGames.TabIndex = 0
        Me.lblGames.Text = "Temperatures"
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Location = New System.Drawing.Point(719, 50)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(79, 13)
        Me.lblResults.TabIndex = 1
        Me.lblResults.Text = "Search Results"
        '
        'lblSortedList
        '
        Me.lblSortedList.AutoSize = True
        Me.lblSortedList.Location = New System.Drawing.Point(1240, 50)
        Me.lblSortedList.Name = "lblSortedList"
        Me.lblSortedList.Size = New System.Drawing.Size(57, 13)
        Me.lblSortedList.TabIndex = 2
        Me.lblSortedList.Text = "Sorted List"
        '
        'lstTemperatures
        '
        Me.lstTemperatures.FormattingEnabled = True
        Me.lstTemperatures.Location = New System.Drawing.Point(151, 76)
        Me.lstTemperatures.Name = "lstTemperatures"
        Me.lstTemperatures.Size = New System.Drawing.Size(182, 212)
        Me.lstTemperatures.TabIndex = 3
        '
        'lstResults
        '
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.Location = New System.Drawing.Point(636, 76)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(242, 212)
        Me.lstResults.TabIndex = 4
        '
        'lstSorted
        '
        Me.lstSorted.FormattingEnabled = True
        Me.lstSorted.Location = New System.Drawing.Point(1176, 76)
        Me.lstSorted.Name = "lstSorted"
        Me.lstSorted.Size = New System.Drawing.Size(182, 212)
        Me.lstSorted.TabIndex = 5
        '
        'btnEnterTemps
        '
        Me.btnEnterTemps.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnEnterTemps.Location = New System.Drawing.Point(198, 300)
        Me.btnEnterTemps.Name = "btnEnterTemps"
        Me.btnEnterTemps.Size = New System.Drawing.Size(76, 23)
        Me.btnEnterTemps.TabIndex = 6
        Me.btnEnterTemps.Text = "Enter Temps"
        Me.btnEnterTemps.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSearch.Location = New System.Drawing.Point(712, 300)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(85, 23)
        Me.btnSearch.TabIndex = 7
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnSortTemps
        '
        Me.btnSortTemps.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSortTemps.Location = New System.Drawing.Point(1231, 300)
        Me.btnSortTemps.Name = "btnSortTemps"
        Me.btnSortTemps.Size = New System.Drawing.Size(75, 23)
        Me.btnSortTemps.TabIndex = 8
        Me.btnSortTemps.Text = "Sort Temps"
        Me.btnSortTemps.UseVisualStyleBackColor = False
        '
        'btnAverage
        '
        Me.btnAverage.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnAverage.Location = New System.Drawing.Point(712, 341)
        Me.btnAverage.Name = "btnAverage"
        Me.btnAverage.Size = New System.Drawing.Size(84, 23)
        Me.btnAverage.TabIndex = 9
        Me.btnAverage.Text = "Average"
        Me.btnAverage.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnClear.Location = New System.Drawing.Point(722, 572)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnEnd
        '
        Me.btnEnd.BackColor = System.Drawing.Color.Red
        Me.btnEnd.Location = New System.Drawing.Point(1463, -4)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(21, 23)
        Me.btnEnd.TabIndex = 11
        Me.btnEnd.Text = "X"
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'frmIdk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(1480, 623)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAverage)
        Me.Controls.Add(Me.btnSortTemps)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnEnterTemps)
        Me.Controls.Add(Me.lstSorted)
        Me.Controls.Add(Me.lstResults)
        Me.Controls.Add(Me.lstTemperatures)
        Me.Controls.Add(Me.lblSortedList)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.lblGames)
        Me.Name = "frmIdk"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGames As Label
    Friend WithEvents lblResults As Label
    Friend WithEvents lblSortedList As Label
    Friend WithEvents lstTemperatures As ListBox
    Friend WithEvents lstResults As ListBox
    Friend WithEvents lstSorted As ListBox
    Friend WithEvents btnEnterTemps As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnSortTemps As Button
    Friend WithEvents btnAverage As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnEnd As Button
End Class
