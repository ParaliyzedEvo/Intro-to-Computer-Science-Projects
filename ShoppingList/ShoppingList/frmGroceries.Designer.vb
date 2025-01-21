<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGroceries
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGroceries))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblGroceriesTitle = New System.Windows.Forms.Label()
        Me.lblShoppingCart = New System.Windows.Forms.Label()
        Me.picEggs = New System.Windows.Forms.PictureBox()
        Me.picMilk = New System.Windows.Forms.PictureBox()
        Me.lstShoppingCart = New System.Windows.Forms.ListBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picEggs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMilk, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckoutToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'CheckoutToolStripMenuItem
        '
        Me.CheckoutToolStripMenuItem.Name = "CheckoutToolStripMenuItem"
        Me.CheckoutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CheckoutToolStripMenuItem.Text = "Checkout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'lblGroceriesTitle
        '
        Me.lblGroceriesTitle.AutoSize = True
        Me.lblGroceriesTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblGroceriesTitle.Location = New System.Drawing.Point(12, 169)
        Me.lblGroceriesTitle.Name = "lblGroceriesTitle"
        Me.lblGroceriesTitle.Size = New System.Drawing.Size(314, 18)
        Me.lblGroceriesTitle.TabIndex = 1
        Me.lblGroceriesTitle.Text = "Click on items you would like to add to the cart"
        '
        'lblShoppingCart
        '
        Me.lblShoppingCart.AutoSize = True
        Me.lblShoppingCart.Location = New System.Drawing.Point(607, 173)
        Me.lblShoppingCart.Name = "lblShoppingCart"
        Me.lblShoppingCart.Size = New System.Drawing.Size(74, 13)
        Me.lblShoppingCart.TabIndex = 2
        Me.lblShoppingCart.Text = "Shopping Cart"
        '
        'picEggs
        '
        Me.picEggs.Image = CType(resources.GetObject("picEggs.Image"), System.Drawing.Image)
        Me.picEggs.Location = New System.Drawing.Point(15, 210)
        Me.picEggs.Name = "picEggs"
        Me.picEggs.Size = New System.Drawing.Size(156, 159)
        Me.picEggs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEggs.TabIndex = 3
        Me.picEggs.TabStop = False
        '
        'picMilk
        '
        Me.picMilk.Image = CType(resources.GetObject("picMilk.Image"), System.Drawing.Image)
        Me.picMilk.Location = New System.Drawing.Point(177, 210)
        Me.picMilk.Name = "picMilk"
        Me.picMilk.Size = New System.Drawing.Size(159, 159)
        Me.picMilk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMilk.TabIndex = 4
        Me.picMilk.TabStop = False
        '
        'lstShoppingCart
        '
        Me.lstShoppingCart.FormattingEnabled = True
        Me.lstShoppingCart.Location = New System.Drawing.Point(567, 199)
        Me.lstShoppingCart.Name = "lstShoppingCart"
        Me.lstShoppingCart.Size = New System.Drawing.Size(165, 199)
        Me.lstShoppingCart.TabIndex = 5
        '
        'frmGroceries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstShoppingCart)
        Me.Controls.Add(Me.picMilk)
        Me.Controls.Add(Me.picEggs)
        Me.Controls.Add(Me.lblShoppingCart)
        Me.Controls.Add(Me.lblGroceriesTitle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmGroceries"
        Me.Text = "frmGroceries"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picEggs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMilk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblGroceriesTitle As Label
    Friend WithEvents lblShoppingCart As Label
    Friend WithEvents picEggs As PictureBox
    Friend WithEvents picMilk As PictureBox
    Friend WithEvents lstShoppingCart As ListBox
End Class
