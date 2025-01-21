<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBlackBowls
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBlackBowls))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlueBowlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChineseBowlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedBowlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhiteBowlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TheSpecialBowlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowHideCartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstShoppingCart = New System.Windows.Forms.ListBox()
        Me.picBlackBowl1 = New System.Windows.Forms.PictureBox()
        Me.picBlackBowl2 = New System.Windows.Forms.PictureBox()
        Me.picBlackBowl3 = New System.Windows.Forms.PictureBox()
        Me.picBlackBowl4 = New System.Windows.Forms.PictureBox()
        Me.lblBlackBowl = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picBlackBowl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBlackBowl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBlackBowl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBlackBowl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ExitToolStripMenuItem, Me.ShowHideCartToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BlueBowlsToolStripMenuItem, Me.ChineseBowlsToolStripMenuItem, Me.RedBowlsToolStripMenuItem, Me.WhiteBowlsToolStripMenuItem, Me.TheSpecialBowlToolStripMenuItem, Me.CheckoutToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'BlueBowlsToolStripMenuItem
        '
        Me.BlueBowlsToolStripMenuItem.Name = "BlueBowlsToolStripMenuItem"
        Me.BlueBowlsToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.BlueBowlsToolStripMenuItem.Text = "Blue Bowls"
        '
        'ChineseBowlsToolStripMenuItem
        '
        Me.ChineseBowlsToolStripMenuItem.Name = "ChineseBowlsToolStripMenuItem"
        Me.ChineseBowlsToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ChineseBowlsToolStripMenuItem.Text = "Chinese Bowls"
        '
        'RedBowlsToolStripMenuItem
        '
        Me.RedBowlsToolStripMenuItem.Name = "RedBowlsToolStripMenuItem"
        Me.RedBowlsToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.RedBowlsToolStripMenuItem.Text = "Red Bowls"
        '
        'WhiteBowlsToolStripMenuItem
        '
        Me.WhiteBowlsToolStripMenuItem.Name = "WhiteBowlsToolStripMenuItem"
        Me.WhiteBowlsToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.WhiteBowlsToolStripMenuItem.Text = "White Bowls"
        '
        'TheSpecialBowlToolStripMenuItem
        '
        Me.TheSpecialBowlToolStripMenuItem.Name = "TheSpecialBowlToolStripMenuItem"
        Me.TheSpecialBowlToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.TheSpecialBowlToolStripMenuItem.Text = "The Special Bowl"
        '
        'CheckoutToolStripMenuItem
        '
        Me.CheckoutToolStripMenuItem.Name = "CheckoutToolStripMenuItem"
        Me.CheckoutToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.CheckoutToolStripMenuItem.Text = "Checkout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ShowHideCartToolStripMenuItem
        '
        Me.ShowHideCartToolStripMenuItem.Name = "ShowHideCartToolStripMenuItem"
        Me.ShowHideCartToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
        Me.ShowHideCartToolStripMenuItem.Text = "Show/Hide Cart"
        '
        'lstShoppingCart
        '
        Me.lstShoppingCart.FormattingEnabled = True
        Me.lstShoppingCart.Location = New System.Drawing.Point(631, 0)
        Me.lstShoppingCart.Name = "lstShoppingCart"
        Me.lstShoppingCart.Size = New System.Drawing.Size(169, 459)
        Me.lstShoppingCart.TabIndex = 1
        Me.lstShoppingCart.Visible = False
        '
        'picBlackBowl1
        '
        Me.picBlackBowl1.Image = CType(resources.GetObject("picBlackBowl1.Image"), System.Drawing.Image)
        Me.picBlackBowl1.Location = New System.Drawing.Point(48, 160)
        Me.picBlackBowl1.Name = "picBlackBowl1"
        Me.picBlackBowl1.Size = New System.Drawing.Size(128, 128)
        Me.picBlackBowl1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBlackBowl1.TabIndex = 2
        Me.picBlackBowl1.TabStop = False
        '
        'picBlackBowl2
        '
        Me.picBlackBowl2.Image = CType(resources.GetObject("picBlackBowl2.Image"), System.Drawing.Image)
        Me.picBlackBowl2.Location = New System.Drawing.Point(183, 160)
        Me.picBlackBowl2.Name = "picBlackBowl2"
        Me.picBlackBowl2.Size = New System.Drawing.Size(128, 128)
        Me.picBlackBowl2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBlackBowl2.TabIndex = 3
        Me.picBlackBowl2.TabStop = False
        '
        'picBlackBowl3
        '
        Me.picBlackBowl3.Image = CType(resources.GetObject("picBlackBowl3.Image"), System.Drawing.Image)
        Me.picBlackBowl3.Location = New System.Drawing.Point(317, 160)
        Me.picBlackBowl3.Name = "picBlackBowl3"
        Me.picBlackBowl3.Size = New System.Drawing.Size(128, 128)
        Me.picBlackBowl3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBlackBowl3.TabIndex = 4
        Me.picBlackBowl3.TabStop = False
        '
        'picBlackBowl4
        '
        Me.picBlackBowl4.Image = CType(resources.GetObject("picBlackBowl4.Image"), System.Drawing.Image)
        Me.picBlackBowl4.Location = New System.Drawing.Point(451, 160)
        Me.picBlackBowl4.Name = "picBlackBowl4"
        Me.picBlackBowl4.Size = New System.Drawing.Size(128, 128)
        Me.picBlackBowl4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBlackBowl4.TabIndex = 5
        Me.picBlackBowl4.TabStop = False
        '
        'lblBlackBowl
        '
        Me.lblBlackBowl.AutoSize = True
        Me.lblBlackBowl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.lblBlackBowl.ForeColor = System.Drawing.Color.White
        Me.lblBlackBowl.Location = New System.Drawing.Point(158, 91)
        Me.lblBlackBowl.Name = "lblBlackBowl"
        Me.lblBlackBowl.Size = New System.Drawing.Size(321, 29)
        Me.lblBlackBowl.TabIndex = 6
        Me.lblBlackBowl.Text = "Shop for Black Bowls Here!"
        '
        'frmBlackBowls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblBlackBowl)
        Me.Controls.Add(Me.picBlackBowl4)
        Me.Controls.Add(Me.picBlackBowl3)
        Me.Controls.Add(Me.picBlackBowl2)
        Me.Controls.Add(Me.picBlackBowl1)
        Me.Controls.Add(Me.lstShoppingCart)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmBlackBowls"
        Me.Text = "frmBlackBowl"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picBlackBowl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBlackBowl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBlackBowl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBlackBowl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lstShoppingCart As ListBox
    Friend WithEvents picBlackBowl1 As PictureBox
    Friend WithEvents picBlackBowl2 As PictureBox
    Friend WithEvents picBlackBowl3 As PictureBox
    Friend WithEvents picBlackBowl4 As PictureBox
    Friend WithEvents lblBlackBowl As Label
    Friend WithEvents BlueBowlsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChineseBowlsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedBowlsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WhiteBowlsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TheSpecialBowlToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowHideCartToolStripMenuItem As ToolStripMenuItem
End Class
