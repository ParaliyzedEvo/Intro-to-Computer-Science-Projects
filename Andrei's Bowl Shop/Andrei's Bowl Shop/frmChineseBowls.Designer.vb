<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmChineseBowls
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChineseBowls))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlackBowlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlueBowlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedBowlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhiteBowlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TheSpecialBowlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowHideCartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstShoppingCart = New System.Windows.Forms.ListBox()
        Me.picChineseBowl1 = New System.Windows.Forms.PictureBox()
        Me.picChineseBowl2 = New System.Windows.Forms.PictureBox()
        Me.picChineseBowl3 = New System.Windows.Forms.PictureBox()
        Me.picChineseBowl4 = New System.Windows.Forms.PictureBox()
        Me.lblChineseBowls = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picChineseBowl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChineseBowl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChineseBowl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChineseBowl4, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BlackBowlsToolStripMenuItem, Me.BlueBowlsToolStripMenuItem, Me.RedBowlsToolStripMenuItem, Me.WhiteBowlsToolStripMenuItem, Me.TheSpecialBowlToolStripMenuItem, Me.CheckoutToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'BlackBowlsToolStripMenuItem
        '
        Me.BlackBowlsToolStripMenuItem.Name = "BlackBowlsToolStripMenuItem"
        Me.BlackBowlsToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.BlackBowlsToolStripMenuItem.Text = "Black Bowls"
        '
        'BlueBowlsToolStripMenuItem
        '
        Me.BlueBowlsToolStripMenuItem.Name = "BlueBowlsToolStripMenuItem"
        Me.BlueBowlsToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.BlueBowlsToolStripMenuItem.Text = "Blue Bowls"
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
        'picChineseBowl1
        '
        Me.picChineseBowl1.BackColor = System.Drawing.Color.Transparent
        Me.picChineseBowl1.Image = CType(resources.GetObject("picChineseBowl1.Image"), System.Drawing.Image)
        Me.picChineseBowl1.Location = New System.Drawing.Point(48, 160)
        Me.picChineseBowl1.Name = "picChineseBowl1"
        Me.picChineseBowl1.Size = New System.Drawing.Size(128, 128)
        Me.picChineseBowl1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picChineseBowl1.TabIndex = 2
        Me.picChineseBowl1.TabStop = False
        '
        'picChineseBowl2
        '
        Me.picChineseBowl2.BackColor = System.Drawing.Color.Transparent
        Me.picChineseBowl2.Image = CType(resources.GetObject("picChineseBowl2.Image"), System.Drawing.Image)
        Me.picChineseBowl2.Location = New System.Drawing.Point(183, 160)
        Me.picChineseBowl2.Name = "picChineseBowl2"
        Me.picChineseBowl2.Size = New System.Drawing.Size(128, 128)
        Me.picChineseBowl2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picChineseBowl2.TabIndex = 3
        Me.picChineseBowl2.TabStop = False
        '
        'picChineseBowl3
        '
        Me.picChineseBowl3.BackColor = System.Drawing.Color.Transparent
        Me.picChineseBowl3.Image = CType(resources.GetObject("picChineseBowl3.Image"), System.Drawing.Image)
        Me.picChineseBowl3.Location = New System.Drawing.Point(317, 160)
        Me.picChineseBowl3.Name = "picChineseBowl3"
        Me.picChineseBowl3.Size = New System.Drawing.Size(128, 128)
        Me.picChineseBowl3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picChineseBowl3.TabIndex = 4
        Me.picChineseBowl3.TabStop = False
        '
        'picChineseBowl4
        '
        Me.picChineseBowl4.BackColor = System.Drawing.Color.Transparent
        Me.picChineseBowl4.Image = CType(resources.GetObject("picChineseBowl4.Image"), System.Drawing.Image)
        Me.picChineseBowl4.Location = New System.Drawing.Point(451, 160)
        Me.picChineseBowl4.Name = "picChineseBowl4"
        Me.picChineseBowl4.Size = New System.Drawing.Size(128, 128)
        Me.picChineseBowl4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picChineseBowl4.TabIndex = 5
        Me.picChineseBowl4.TabStop = False
        '
        'lblChineseBowls
        '
        Me.lblChineseBowls.AutoSize = True
        Me.lblChineseBowls.BackColor = System.Drawing.Color.Transparent
        Me.lblChineseBowls.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.lblChineseBowls.ForeColor = System.Drawing.Color.White
        Me.lblChineseBowls.Location = New System.Drawing.Point(138, 100)
        Me.lblChineseBowls.Name = "lblChineseBowls"
        Me.lblChineseBowls.Size = New System.Drawing.Size(351, 29)
        Me.lblChineseBowls.TabIndex = 6
        Me.lblChineseBowls.Text = "Shop for Chinese Bowls Here!"
        '
        'frmChineseBowls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblChineseBowls)
        Me.Controls.Add(Me.picChineseBowl4)
        Me.Controls.Add(Me.picChineseBowl3)
        Me.Controls.Add(Me.picChineseBowl2)
        Me.Controls.Add(Me.picChineseBowl1)
        Me.Controls.Add(Me.lstShoppingCart)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmChineseBowls"
        Me.Text = "frmChineseBowl"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picChineseBowl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChineseBowl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChineseBowl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChineseBowl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lstShoppingCart As ListBox
    Friend WithEvents picChineseBowl1 As PictureBox
    Friend WithEvents picChineseBowl2 As PictureBox
    Friend WithEvents picChineseBowl3 As PictureBox
    Friend WithEvents picChineseBowl4 As PictureBox
    Friend WithEvents BlackBowlsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlueBowlsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedBowlsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WhiteBowlsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TheSpecialBowlToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowHideCartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblChineseBowls As Label
End Class
