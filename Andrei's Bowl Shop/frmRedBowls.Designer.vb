<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRedBowls
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRedBowls))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlackBowlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlueBowlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChineseBowlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhiteBowlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpecialBowlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowHideCartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstShoppingCart = New System.Windows.Forms.ListBox()
        Me.picRedBowl1 = New System.Windows.Forms.PictureBox()
        Me.picRedBowl2 = New System.Windows.Forms.PictureBox()
        Me.picRedBowl3 = New System.Windows.Forms.PictureBox()
        Me.picRedBowl4 = New System.Windows.Forms.PictureBox()
        Me.lblRedBowls = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picRedBowl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRedBowl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRedBowl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRedBowl4, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BlackBowlsToolStripMenuItem, Me.BlueBowlsToolStripMenuItem, Me.ChineseBowlsToolStripMenuItem, Me.WhiteBowlsToolStripMenuItem, Me.SpecialBowlsToolStripMenuItem, Me.CheckoutToolStripMenuItem})
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
        'ChineseBowlsToolStripMenuItem
        '
        Me.ChineseBowlsToolStripMenuItem.Name = "ChineseBowlsToolStripMenuItem"
        Me.ChineseBowlsToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ChineseBowlsToolStripMenuItem.Text = "Chinese Bowls"
        '
        'WhiteBowlsToolStripMenuItem
        '
        Me.WhiteBowlsToolStripMenuItem.Name = "WhiteBowlsToolStripMenuItem"
        Me.WhiteBowlsToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.WhiteBowlsToolStripMenuItem.Text = "White Bowls"
        '
        'SpecialBowlsToolStripMenuItem
        '
        Me.SpecialBowlsToolStripMenuItem.Name = "SpecialBowlsToolStripMenuItem"
        Me.SpecialBowlsToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.SpecialBowlsToolStripMenuItem.Text = "The Special Bowl"
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
        'picRedBowl1
        '
        Me.picRedBowl1.Image = CType(resources.GetObject("picRedBowl1.Image"), System.Drawing.Image)
        Me.picRedBowl1.Location = New System.Drawing.Point(48, 160)
        Me.picRedBowl1.Name = "picRedBowl1"
        Me.picRedBowl1.Size = New System.Drawing.Size(128, 128)
        Me.picRedBowl1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRedBowl1.TabIndex = 2
        Me.picRedBowl1.TabStop = False
        '
        'picRedBowl2
        '
        Me.picRedBowl2.Image = CType(resources.GetObject("picRedBowl2.Image"), System.Drawing.Image)
        Me.picRedBowl2.Location = New System.Drawing.Point(183, 160)
        Me.picRedBowl2.Name = "picRedBowl2"
        Me.picRedBowl2.Size = New System.Drawing.Size(128, 128)
        Me.picRedBowl2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRedBowl2.TabIndex = 3
        Me.picRedBowl2.TabStop = False
        '
        'picRedBowl3
        '
        Me.picRedBowl3.Image = CType(resources.GetObject("picRedBowl3.Image"), System.Drawing.Image)
        Me.picRedBowl3.Location = New System.Drawing.Point(317, 160)
        Me.picRedBowl3.Name = "picRedBowl3"
        Me.picRedBowl3.Size = New System.Drawing.Size(128, 128)
        Me.picRedBowl3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRedBowl3.TabIndex = 4
        Me.picRedBowl3.TabStop = False
        '
        'picRedBowl4
        '
        Me.picRedBowl4.Image = CType(resources.GetObject("picRedBowl4.Image"), System.Drawing.Image)
        Me.picRedBowl4.Location = New System.Drawing.Point(451, 160)
        Me.picRedBowl4.Name = "picRedBowl4"
        Me.picRedBowl4.Size = New System.Drawing.Size(128, 128)
        Me.picRedBowl4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRedBowl4.TabIndex = 5
        Me.picRedBowl4.TabStop = False
        '
        'lblRedBowls
        '
        Me.lblRedBowls.AutoSize = True
        Me.lblRedBowls.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.lblRedBowls.Location = New System.Drawing.Point(161, 100)
        Me.lblRedBowls.Name = "lblRedBowls"
        Me.lblRedBowls.Size = New System.Drawing.Size(304, 29)
        Me.lblRedBowls.TabIndex = 6
        Me.lblRedBowls.Text = "Shop for Red Bowls Here!"
        '
        'frmRedBowls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblRedBowls)
        Me.Controls.Add(Me.picRedBowl4)
        Me.Controls.Add(Me.picRedBowl3)
        Me.Controls.Add(Me.picRedBowl2)
        Me.Controls.Add(Me.picRedBowl1)
        Me.Controls.Add(Me.lstShoppingCart)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmRedBowls"
        Me.Text = "frmRedBowl"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picRedBowl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRedBowl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRedBowl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRedBowl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lstShoppingCart As ListBox
    Friend WithEvents picRedBowl1 As PictureBox
    Friend WithEvents picRedBowl2 As PictureBox
    Friend WithEvents picRedBowl3 As PictureBox
    Friend WithEvents picRedBowl4 As PictureBox
    Friend WithEvents BlackBowlsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlueBowlsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChineseBowlsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WhiteBowlsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SpecialBowlsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowHideCartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblRedBowls As Label
End Class
