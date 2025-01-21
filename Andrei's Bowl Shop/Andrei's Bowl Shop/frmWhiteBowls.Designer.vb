<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWhiteBowls
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWhiteBowls))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlackBowlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlueBowlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChineseBowlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedBowlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TheSpecialBowlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowHideCartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstShoppingCart = New System.Windows.Forms.ListBox()
        Me.picWhiteBowl1 = New System.Windows.Forms.PictureBox()
        Me.picWhiteBowl2 = New System.Windows.Forms.PictureBox()
        Me.picWhiteBowl3 = New System.Windows.Forms.PictureBox()
        Me.picWhiteBowl4 = New System.Windows.Forms.PictureBox()
        Me.lblWhiteBowls = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picWhiteBowl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWhiteBowl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWhiteBowl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWhiteBowl4, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BlackBowlsToolStripMenuItem, Me.BlueBowlsToolStripMenuItem, Me.ChineseBowlsToolStripMenuItem, Me.RedBowlsToolStripMenuItem, Me.TheSpecialBowlToolStripMenuItem, Me.CheckoutToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'BlackBowlsToolStripMenuItem
        '
        Me.BlackBowlsToolStripMenuItem.Name = "BlackBowlsToolStripMenuItem"
        Me.BlackBowlsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BlackBowlsToolStripMenuItem.Text = "Black Bowls"
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
        'TheSpecialBowlToolStripMenuItem
        '
        Me.TheSpecialBowlToolStripMenuItem.Name = "TheSpecialBowlToolStripMenuItem"
        Me.TheSpecialBowlToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TheSpecialBowlToolStripMenuItem.Text = "The Special Bowl"
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
        'picWhiteBowl1
        '
        Me.picWhiteBowl1.Image = CType(resources.GetObject("picWhiteBowl1.Image"), System.Drawing.Image)
        Me.picWhiteBowl1.Location = New System.Drawing.Point(48, 160)
        Me.picWhiteBowl1.Name = "picWhiteBowl1"
        Me.picWhiteBowl1.Size = New System.Drawing.Size(128, 128)
        Me.picWhiteBowl1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWhiteBowl1.TabIndex = 2
        Me.picWhiteBowl1.TabStop = False
        '
        'picWhiteBowl2
        '
        Me.picWhiteBowl2.Image = CType(resources.GetObject("picWhiteBowl2.Image"), System.Drawing.Image)
        Me.picWhiteBowl2.Location = New System.Drawing.Point(183, 160)
        Me.picWhiteBowl2.Name = "picWhiteBowl2"
        Me.picWhiteBowl2.Size = New System.Drawing.Size(128, 128)
        Me.picWhiteBowl2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWhiteBowl2.TabIndex = 3
        Me.picWhiteBowl2.TabStop = False
        '
        'picWhiteBowl3
        '
        Me.picWhiteBowl3.Image = CType(resources.GetObject("picWhiteBowl3.Image"), System.Drawing.Image)
        Me.picWhiteBowl3.Location = New System.Drawing.Point(317, 160)
        Me.picWhiteBowl3.Name = "picWhiteBowl3"
        Me.picWhiteBowl3.Size = New System.Drawing.Size(128, 128)
        Me.picWhiteBowl3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWhiteBowl3.TabIndex = 4
        Me.picWhiteBowl3.TabStop = False
        '
        'picWhiteBowl4
        '
        Me.picWhiteBowl4.Image = CType(resources.GetObject("picWhiteBowl4.Image"), System.Drawing.Image)
        Me.picWhiteBowl4.Location = New System.Drawing.Point(451, 160)
        Me.picWhiteBowl4.Name = "picWhiteBowl4"
        Me.picWhiteBowl4.Size = New System.Drawing.Size(128, 128)
        Me.picWhiteBowl4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWhiteBowl4.TabIndex = 5
        Me.picWhiteBowl4.TabStop = False
        '
        'lblWhiteBowls
        '
        Me.lblWhiteBowls.AutoSize = True
        Me.lblWhiteBowls.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.lblWhiteBowls.ForeColor = System.Drawing.Color.Black
        Me.lblWhiteBowls.Location = New System.Drawing.Point(156, 98)
        Me.lblWhiteBowls.Name = "lblWhiteBowls"
        Me.lblWhiteBowls.Size = New System.Drawing.Size(323, 29)
        Me.lblWhiteBowls.TabIndex = 6
        Me.lblWhiteBowls.Text = "Shop for White Bowls Here!"
        '
        'frmWhiteBowls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblWhiteBowls)
        Me.Controls.Add(Me.picWhiteBowl4)
        Me.Controls.Add(Me.picWhiteBowl3)
        Me.Controls.Add(Me.picWhiteBowl2)
        Me.Controls.Add(Me.picWhiteBowl1)
        Me.Controls.Add(Me.lstShoppingCart)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmWhiteBowls"
        Me.Text = "frmWhiteBowl"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picWhiteBowl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWhiteBowl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWhiteBowl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWhiteBowl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lstShoppingCart As ListBox
    Friend WithEvents picWhiteBowl1 As PictureBox
    Friend WithEvents picWhiteBowl2 As PictureBox
    Friend WithEvents picWhiteBowl3 As PictureBox
    Friend WithEvents picWhiteBowl4 As PictureBox
    Friend WithEvents BlackBowlsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlueBowlsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChineseBowlsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedBowlsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TheSpecialBowlToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowHideCartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblWhiteBowls As Label
End Class
