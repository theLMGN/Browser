<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Browser
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Browser))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CloseLabel = New System.Windows.Forms.Label()
        Me.MinimiseLabel = New System.Windows.Forms.Label()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ForwardButton = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.SettingsButton = New System.Windows.Forms.Button()
        Me.ContactButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MaximiseLabel = New System.Windows.Forms.Label()
        Me.RestoreLabel = New System.Windows.Forms.Label()
        Me.MenuButton = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Location = New System.Drawing.Point(-7, -5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1312, 24)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'CloseLabel
        '
        Me.CloseLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseLabel.AutoSize = True
        Me.CloseLabel.BackColor = System.Drawing.Color.Black
        Me.CloseLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloseLabel.ForeColor = System.Drawing.Color.White
        Me.CloseLabel.Location = New System.Drawing.Point(1278, 3)
        Me.CloseLabel.Name = "CloseLabel"
        Me.CloseLabel.Size = New System.Drawing.Size(13, 13)
        Me.CloseLabel.TabIndex = 1
        Me.CloseLabel.Text = "X"
        Me.ToolTip1.SetToolTip(Me.CloseLabel, "Close")
        '
        'MinimiseLabel
        '
        Me.MinimiseLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MinimiseLabel.AutoSize = True
        Me.MinimiseLabel.BackColor = System.Drawing.Color.Black
        Me.MinimiseLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MinimiseLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimiseLabel.ForeColor = System.Drawing.Color.White
        Me.MinimiseLabel.Location = New System.Drawing.Point(1237, 1)
        Me.MinimiseLabel.Name = "MinimiseLabel"
        Me.MinimiseLabel.Size = New System.Drawing.Size(16, 16)
        Me.MinimiseLabel.TabIndex = 2
        Me.MinimiseLabel.Text = "_"
        Me.ToolTip1.SetToolTip(Me.MinimiseLabel, "Minimise")
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 53)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(1293, 695)
        Me.WebBrowser1.TabIndex = 4
        Me.WebBrowser1.Url = New System.Uri("http://google.co.uk", System.UriKind.Absolute)
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(284, 25)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(915, 22)
        Me.TextBox1.TabIndex = 5
        '
        'SearchButton
        '
        Me.SearchButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchButton.BackColor = System.Drawing.Color.Black
        Me.SearchButton.ForeColor = System.Drawing.Color.White
        Me.SearchButton.Location = New System.Drawing.Point(1205, 27)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(40, 20)
        Me.SearchButton.TabIndex = 6
        Me.SearchButton.Text = "➡️"
        Me.ToolTip1.SetToolTip(Me.SearchButton, "Search")
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'HomeButton
        '
        Me.HomeButton.BackColor = System.Drawing.Color.Black
        Me.HomeButton.ForeColor = System.Drawing.Color.White
        Me.HomeButton.Location = New System.Drawing.Point(147, 27)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(39, 20)
        Me.HomeButton.TabIndex = 7
        Me.HomeButton.Text = "🏠"
        Me.ToolTip1.SetToolTip(Me.HomeButton, "Home")
        Me.HomeButton.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.Black
        Me.BackButton.ForeColor = System.Drawing.Color.White
        Me.BackButton.Location = New System.Drawing.Point(12, 27)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(39, 20)
        Me.BackButton.TabIndex = 8
        Me.BackButton.Text = "⬅️"
        Me.ToolTip1.SetToolTip(Me.BackButton, "Back")
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'ForwardButton
        '
        Me.ForwardButton.BackColor = System.Drawing.Color.Black
        Me.ForwardButton.ForeColor = System.Drawing.Color.White
        Me.ForwardButton.Location = New System.Drawing.Point(57, 27)
        Me.ForwardButton.Name = "ForwardButton"
        Me.ForwardButton.Size = New System.Drawing.Size(39, 20)
        Me.ForwardButton.TabIndex = 9
        Me.ForwardButton.Text = "➡️"
        Me.ToolTip1.SetToolTip(Me.ForwardButton, "Forward")
        Me.ForwardButton.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Black
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(102, 27)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(39, 20)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "🔄"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(39, 16)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'SettingsButton
        '
        Me.SettingsButton.BackColor = System.Drawing.Color.Black
        Me.SettingsButton.ForeColor = System.Drawing.Color.White
        Me.SettingsButton.Location = New System.Drawing.Point(192, 27)
        Me.SettingsButton.Name = "SettingsButton"
        Me.SettingsButton.Size = New System.Drawing.Size(40, 20)
        Me.SettingsButton.TabIndex = 11
        Me.SettingsButton.Text = "🔧"
        Me.ToolTip1.SetToolTip(Me.SettingsButton, "Settings")
        Me.SettingsButton.UseVisualStyleBackColor = False
        '
        'ContactButton
        '
        Me.ContactButton.BackColor = System.Drawing.Color.Black
        Me.ContactButton.ForeColor = System.Drawing.Color.White
        Me.ContactButton.Location = New System.Drawing.Point(238, 27)
        Me.ContactButton.Name = "ContactButton"
        Me.ContactButton.Size = New System.Drawing.Size(40, 20)
        Me.ContactButton.TabIndex = 12
        Me.ContactButton.Text = "💬"
        Me.ToolTip1.SetToolTip(Me.ContactButton, "Contact")
        Me.ContactButton.UseVisualStyleBackColor = False
        '
        'MaximiseLabel
        '
        Me.MaximiseLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaximiseLabel.AutoSize = True
        Me.MaximiseLabel.BackColor = System.Drawing.Color.Black
        Me.MaximiseLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaximiseLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximiseLabel.ForeColor = System.Drawing.Color.White
        Me.MaximiseLabel.Location = New System.Drawing.Point(1259, 1)
        Me.MaximiseLabel.Name = "MaximiseLabel"
        Me.MaximiseLabel.Size = New System.Drawing.Size(16, 16)
        Me.MaximiseLabel.TabIndex = 13
        Me.MaximiseLabel.Text = "+"
        Me.ToolTip1.SetToolTip(Me.MaximiseLabel, "Maximise")
        '
        'RestoreLabel
        '
        Me.RestoreLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RestoreLabel.AutoSize = True
        Me.RestoreLabel.BackColor = System.Drawing.Color.Black
        Me.RestoreLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RestoreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RestoreLabel.ForeColor = System.Drawing.Color.White
        Me.RestoreLabel.Location = New System.Drawing.Point(1260, 1)
        Me.RestoreLabel.Name = "RestoreLabel"
        Me.RestoreLabel.Size = New System.Drawing.Size(13, 16)
        Me.RestoreLabel.TabIndex = 14
        Me.RestoreLabel.Text = "-"
        Me.ToolTip1.SetToolTip(Me.RestoreLabel, "Restore")
        Me.RestoreLabel.Visible = False
        '
        'MenuButton
        '
        Me.MenuButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuButton.BackColor = System.Drawing.Color.Black
        Me.MenuButton.ForeColor = System.Drawing.Color.White
        Me.MenuButton.Location = New System.Drawing.Point(1251, 27)
        Me.MenuButton.Name = "MenuButton"
        Me.MenuButton.Size = New System.Drawing.Size(40, 20)
        Me.MenuButton.TabIndex = 15
        Me.MenuButton.Text = "≡"
        Me.ToolTip1.SetToolTip(Me.MenuButton, "Menu (BETA)")
        Me.MenuButton.UseVisualStyleBackColor = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewTabToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 48)
        '
        'NewTabToolStripMenuItem
        '
        Me.NewTabToolStripMenuItem.Name = "NewTabToolStripMenuItem"
        Me.NewTabToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewTabToolStripMenuItem.Text = "About"
        '
        'Browser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1299, 751)
        Me.Controls.Add(Me.MenuButton)
        Me.Controls.Add(Me.RestoreLabel)
        Me.Controls.Add(Me.MaximiseLabel)
        Me.Controls.Add(Me.ContactButton)
        Me.Controls.Add(Me.SettingsButton)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.ForwardButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.MinimiseLabel)
        Me.Controls.Add(Me.CloseLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Browser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eclipse"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CloseLabel As System.Windows.Forms.Label
    Friend WithEvents MinimiseLabel As System.Windows.Forms.Label
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents SearchButton As System.Windows.Forms.Button
    Friend WithEvents HomeButton As System.Windows.Forms.Button
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents ForwardButton As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents SettingsButton As System.Windows.Forms.Button
    Friend WithEvents ContactButton As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents MaximiseLabel As System.Windows.Forms.Label
    Friend WithEvents RestoreLabel As System.Windows.Forms.Label
    Friend WithEvents MenuButton As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewTabToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
