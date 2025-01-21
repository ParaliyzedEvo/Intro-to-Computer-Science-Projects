<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckout
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroceriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlueBowlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChineseBowlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedBowlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhiteBowlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TheSpecialBowlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblShoppingCart = New System.Windows.Forms.Label()
        Me.lstCheckoutShoppingList = New System.Windows.Forms.ListBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GroceriesToolStripMenuItem, Me.BlueBowlsToolStripMenuItem, Me.ChineseBowlsToolStripMenuItem, Me.RedBowlsToolStripMenuItem, Me.WhiteBowlsToolStripMenuItem, Me.TheSpecialBowlsToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'GroceriesToolStripMenuItem
        '
        Me.GroceriesToolStripMenuItem.Name = "GroceriesToolStripMenuItem"
        Me.GroceriesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GroceriesToolStripMenuItem.Text = "Black Bowls"
        '
        'BlueBowlsToolStripMenuItem
        '
        Me.BlueBowlsToolStripMenuItem.Name = "BlueBowlsToolStripMenuItem"
        Me.BlueBowlsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BlueBowlsToolStripMenuItem.Text = "Blue Bowls"
        '
        'ChineseBowlsToolStripMenuItem
        '
        Me.ChineseBowlsToolStripMenuItem.Name = "ChineseBowlsToolStripMenuItem"
        Me.ChineseBowlsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ChineseBowlsToolStripMenuItem.Text = "Chinese Bowls"
        '
        'RedBowlsToolStripMenuItem
        '
        Me.RedBowlsToolStripMenuItem.Name = "RedBowlsToolStripMenuItem"
        Me.RedBowlsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RedBowlsToolStripMenuItem.Text = "Red Bowls"
        '
        'WhiteBowlsToolStripMenuItem
        '
        Me.WhiteBowlsToolStripMenuItem.Name = "WhiteBowlsToolStripMenuItem"
        Me.WhiteBowlsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.WhiteBowlsToolStripMenuItem.Text = "White Bowls"
        '
        'TheSpecialBowlsToolStripMenuItem
        '
        Me.TheSpecialBowlsToolStripMenuItem.Name = "TheSpecialBowlsToolStripMenuItem"
        Me.TheSpecialBowlsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TheSpecialBowlsToolStripMenuItem.Text = "The Special Bowl"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'lblShoppingCart
        '
        Me.lblShoppingCart.AutoSize = True
        Me.lblShoppingCart.Location = New System.Drawing.Point(367, 108)
        Me.lblShoppingCart.Name = "lblShoppingCart"
        Me.lblShoppingCart.Size = New System.Drawing.Size(74, 13)
        Me.lblShoppingCart.TabIndex = 1
        Me.lblShoppingCart.Text = "Shopping Cart"
        '
        'lstCheckoutShoppingList
        '
        Me.lstCheckoutShoppingList.FormattingEnabled = True
        Me.lstCheckoutShoppingList.Location = New System.Drawing.Point(168, 133)
        Me.lstCheckoutShoppingList.Name = "lstCheckoutShoppingList"
        Me.lstCheckoutShoppingList.Size = New System.Drawing.Size(469, 199)
        Me.lstCheckoutShoppingList.TabIndex = 2
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(343, 348)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(126, 23)
        Me.btnRemove.TabIndex = 3
        Me.btnRemove.Text = "Remove Selected Item"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnCheckout
        '
        Me.btnCheckout.Location = New System.Drawing.Point(370, 381)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(75, 23)
        Me.btnCheckout.TabIndex = 4
        Me.btnCheckout.Text = "Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = True
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Location = New System.Drawing.Point(298, 416)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(0, 13)
        Me.lblTotalCost.TabIndex = 5
        '
        'frmCheckout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.btnCheckout)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.lstCheckoutShoppingList)
        Me.Controls.Add(Me.lblShoppingCart)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmCheckout"
        Me.Text = "frmCheckout"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroceriesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblShoppingCart As Label
    Friend WithEvents lstCheckoutShoppingList As ListBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnCheckout As Button
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents BlueBowlsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChineseBowlsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedBowlsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WhiteBowlsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TheSpecialBowlsToolStripMenuItem As ToolStripMenuItem
End Class
