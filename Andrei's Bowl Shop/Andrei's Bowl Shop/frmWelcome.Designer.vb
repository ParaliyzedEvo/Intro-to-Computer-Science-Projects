<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWelcome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWelcome))
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedBowlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YellowBowlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlackBowlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhiteBwolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpecialBowlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TheSpecialBowlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("MV Boli", 29.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(94, 181)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(609, 50)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome to Andrei's Bowl Shop"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RedBowlsToolStripMenuItem, Me.YellowBowlsToolStripMenuItem, Me.BlackBowlsToolStripMenuItem, Me.WhiteBwolsToolStripMenuItem, Me.SpecialBowlsToolStripMenuItem, Me.TheSpecialBowlToolStripMenuItem, Me.CheckoutToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'RedBowlsToolStripMenuItem
        '
        Me.RedBowlsToolStripMenuItem.Name = "RedBowlsToolStripMenuItem"
        Me.RedBowlsToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.RedBowlsToolStripMenuItem.Text = "Black Bowls"
        '
        'YellowBowlsToolStripMenuItem
        '
        Me.YellowBowlsToolStripMenuItem.Name = "YellowBowlsToolStripMenuItem"
        Me.YellowBowlsToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.YellowBowlsToolStripMenuItem.Text = "Blue Bowls"
        '
        'BlackBowlsToolStripMenuItem
        '
        Me.BlackBowlsToolStripMenuItem.Name = "BlackBowlsToolStripMenuItem"
        Me.BlackBowlsToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.BlackBowlsToolStripMenuItem.Text = "Chinese Bowls"
        '
        'WhiteBwolsToolStripMenuItem
        '
        Me.WhiteBwolsToolStripMenuItem.Name = "WhiteBwolsToolStripMenuItem"
        Me.WhiteBwolsToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.WhiteBwolsToolStripMenuItem.Text = "Red Bowls"
        '
        'SpecialBowlsToolStripMenuItem
        '
        Me.SpecialBowlsToolStripMenuItem.Name = "SpecialBowlsToolStripMenuItem"
        Me.SpecialBowlsToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.SpecialBowlsToolStripMenuItem.Text = "White Bowls"
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
        'frmWelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmWelcome"
        Me.Text = "frmWelcome"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedBowlsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YellowBowlsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlackBowlsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WhiteBwolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SpecialBowlsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TheSpecialBowlToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckoutToolStripMenuItem As ToolStripMenuItem
End Class
