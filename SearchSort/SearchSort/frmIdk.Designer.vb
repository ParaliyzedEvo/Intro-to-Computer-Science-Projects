<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchSort
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
        Me.lblGames = New System.Windows.Forms.Label()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.lblSortedList = New System.Windows.Forms.Label()
        Me.lstGames = New System.Windows.Forms.ListBox()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.lstSorted = New System.Windows.Forms.ListBox()
        Me.btnEnterGames = New System.Windows.Forms.Button()
        Me.btnLinearSearch = New System.Windows.Forms.Button()
        Me.btnBubbleSort = New System.Windows.Forms.Button()
        Me.btnBinarySearch = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblGames
        '
        Me.lblGames.AutoSize = True
        Me.lblGames.Location = New System.Drawing.Point(223, 50)
        Me.lblGames.Name = "lblGames"
        Me.lblGames.Size = New System.Drawing.Size(40, 13)
        Me.lblGames.TabIndex = 0
        Me.lblGames.Text = "Games"
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
        'lstGames
        '
        Me.lstGames.FormattingEnabled = True
        Me.lstGames.Location = New System.Drawing.Point(151, 76)
        Me.lstGames.Name = "lstGames"
        Me.lstGames.Size = New System.Drawing.Size(182, 212)
        Me.lstGames.TabIndex = 3
        '
        'lstResults
        '
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.Location = New System.Drawing.Point(666, 76)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(182, 212)
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
        'btnEnterGames
        '
        Me.btnEnterGames.Location = New System.Drawing.Point(198, 300)
        Me.btnEnterGames.Name = "btnEnterGames"
        Me.btnEnterGames.Size = New System.Drawing.Size(76, 23)
        Me.btnEnterGames.TabIndex = 6
        Me.btnEnterGames.Text = "Enter Games"
        Me.btnEnterGames.UseVisualStyleBackColor = True
        '
        'btnLinearSearch
        '
        Me.btnLinearSearch.Location = New System.Drawing.Point(712, 300)
        Me.btnLinearSearch.Name = "btnLinearSearch"
        Me.btnLinearSearch.Size = New System.Drawing.Size(85, 23)
        Me.btnLinearSearch.TabIndex = 7
        Me.btnLinearSearch.Text = "Linear Search"
        Me.btnLinearSearch.UseVisualStyleBackColor = True
        '
        'btnBubbleSort
        '
        Me.btnBubbleSort.Location = New System.Drawing.Point(1243, 300)
        Me.btnBubbleSort.Name = "btnBubbleSort"
        Me.btnBubbleSort.Size = New System.Drawing.Size(75, 23)
        Me.btnBubbleSort.TabIndex = 8
        Me.btnBubbleSort.Text = "Bubble Sort"
        Me.btnBubbleSort.UseVisualStyleBackColor = True
        '
        'btnBinarySearch
        '
        Me.btnBinarySearch.Location = New System.Drawing.Point(1239, 338)
        Me.btnBinarySearch.Name = "btnBinarySearch"
        Me.btnBinarySearch.Size = New System.Drawing.Size(84, 23)
        Me.btnBinarySearch.TabIndex = 9
        Me.btnBinarySearch.Text = "Binary Search"
        Me.btnBinarySearch.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(722, 572)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear Lists"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(1393, 588)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 11
        Me.btnEnd.Text = "End"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'frmSearchSort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1480, 623)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnBinarySearch)
        Me.Controls.Add(Me.btnBubbleSort)
        Me.Controls.Add(Me.btnLinearSearch)
        Me.Controls.Add(Me.btnEnterGames)
        Me.Controls.Add(Me.lstSorted)
        Me.Controls.Add(Me.lstResults)
        Me.Controls.Add(Me.lstGames)
        Me.Controls.Add(Me.lblSortedList)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.lblGames)
        Me.Name = "frmSearchSort"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGames As Label
    Friend WithEvents lblResults As Label
    Friend WithEvents lblSortedList As Label
    Friend WithEvents lstGames As ListBox
    Friend WithEvents lstResults As ListBox
    Friend WithEvents lstSorted As ListBox
    Friend WithEvents btnEnterGames As Button
    Friend WithEvents btnLinearSearch As Button
    Friend WithEvents btnBubbleSort As Button
    Friend WithEvents btnBinarySearch As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnEnd As Button
End Class
