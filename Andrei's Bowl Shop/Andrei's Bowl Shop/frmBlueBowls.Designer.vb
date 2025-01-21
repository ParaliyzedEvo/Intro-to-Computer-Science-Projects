<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBlueBowls
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBlueBowls))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlackBwolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChineseBowlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedBowlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhiteBowlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TheSpecialBowlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowHideCartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstShoppingCart = New System.Windows.Forms.ListBox()
        Me.picBlueBowl1 = New System.Windows.Forms.PictureBox()
        Me.picBlueBowl2 = New System.Windows.Forms.PictureBox()
        Me.picBlueBowl3 = New System.Windows.Forms.PictureBox()
        Me.picBlueBowl4 = New System.Windows.Forms.PictureBox()
        Me.lblBlueBowl = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picBlueBowl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBlueBowl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBlueBowl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBlueBowl4, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BlackBwolsToolStripMenuItem, Me.ChineseBowlsToolStripMenuItem, Me.RedBowlsToolStripMenuItem, Me.WhiteBowlsToolStripMenuItem, Me.TheSpecialBowlToolStripMenuItem, Me.CheckoutToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'BlackBwolsToolStripMenuItem
        '
        Me.BlackBwolsToolStripMenuItem.Name = "BlackBwolsToolStripMenuItem"
        Me.BlackBwolsToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.BlackBwolsToolStripMenuItem.Text = "Black Bowls"
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
        'picBlueBowl1
        '
        Me.picBlueBowl1.Image = CType(resources.GetObject("picBlueBowl1.Image"), System.Drawing.Image)
        Me.picBlueBowl1.Location = New System.Drawing.Point(48, 160)
        Me.picBlueBowl1.Name = "picBlueBowl1"
        Me.picBlueBowl1.Size = New System.Drawing.Size(128, 128)
        Me.picBlueBowl1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBlueBowl1.TabIndex = 2
        Me.picBlueBowl1.TabStop = False
        '
        'picBlueBowl2
        '
        Me.picBlueBowl2.Image = CType(resources.GetObject("picBlueBowl2.Image"), System.Drawing.Image)
        Me.picBlueBowl2.Location = New System.Drawing.Point(183, 160)
        Me.picBlueBowl2.Name = "picBlueBowl2"
        Me.picBlueBowl2.Size = New System.Drawing.Size(128, 128)
        Me.picBlueBowl2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBlueBowl2.TabIndex = 3
        Me.picBlueBowl2.TabStop = False
        '
        'picBlueBowl3
        '
        Me.picBlueBowl3.Image = CType(resources.GetObject("picBlueBowl3.Image"), System.Drawing.Image)
        Me.picBlueBowl3.Location = New System.Drawing.Point(317, 160)
        Me.picBlueBowl3.Name = "picBlueBowl3"
        Me.picBlueBowl3.Size = New System.Drawing.Size(128, 128)
        Me.picBlueBowl3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBlueBowl3.TabIndex = 4
        Me.picBlueBowl3.TabStop = False
        '
        'picBlueBowl4
        '
        Me.picBlueBowl4.Image = CType(resources.GetObject("picBlueBowl4.Image"), System.Drawing.Image)
        Me.picBlueBowl4.Location = New System.Drawing.Point(451, 160)
        Me.picBlueBowl4.Name = "picBlueBowl4"
        Me.picBlueBowl4.Size = New System.Drawing.Size(128, 128)
        Me.picBlueBowl4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBlueBowl4.TabIndex = 5
        Me.picBlueBowl4.TabStop = False
        '
        'lblBlueBowl
        '
        Me.lblBlueBowl.AutoSize = True
        Me.lblBlueBowl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.lblBlueBowl.ForeColor = System.Drawing.Color.White
        Me.lblBlueBowl.Location = New System.Drawing.Point(166, 91)
        Me.lblBlueBowl.Name = "lblBlueBowl"
        Me.lblBlueBowl.Size = New System.Drawing.Size(309, 29)
        Me.lblBlueBowl.TabIndex = 6
        Me.lblBlueBowl.Text = "Shop for Blue Bowls Here!"
        '
        'frmBlueBowls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblBlueBowl)
        Me.Controls.Add(Me.picBlueBowl4)
        Me.Controls.Add(Me.picBlueBowl3)
        Me.Controls.Add(Me.picBlueBowl2)
        Me.Controls.Add(Me.picBlueBowl1)
        Me.Controls.Add(Me.lstShoppingCart)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmBlueBowls"
        Me.Text = "frmBlueBowl"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picBlueBowl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBlueBowl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBlueBowl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBlueBowl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lstShoppingCart As ListBox
    Friend WithEvents picBlueBowl1 As PictureBox
    Friend WithEvents picBlueBowl2 As PictureBox
    Friend WithEvents picBlueBowl3 As PictureBox
    Friend WithEvents picBlueBowl4 As PictureBox
    Friend WithEvents BlackBwolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChineseBowlsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedBowlsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WhiteBowlsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TheSpecialBowlToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblBlueBowl As Label
    Friend WithEvents ShowHideCartToolStripMenuItem As ToolStripMenuItem
End Class
