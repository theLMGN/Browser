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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Location = New System.Drawing.Point(-8, -5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1332, 24)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1278, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "X"
        Me.ToolTip1.SetToolTip(Me.Label1, "Close")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1258, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "--"
        Me.ToolTip1.SetToolTip(Me.Label2, "Minimise")
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 68)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(1293, 680)
        Me.WebBrowser1.TabIndex = 4
        Me.WebBrowser1.Url = New System.Uri("http://google.co.uk", System.UriKind.Absolute)
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(12, 25)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1229, 20)
        Me.TextBox1.TabIndex = 5
        '
        'SearchButton
        '
        Me.SearchButton.BackColor = System.Drawing.Color.Black
        Me.SearchButton.ForeColor = System.Drawing.Color.White
        Me.SearchButton.Location = New System.Drawing.Point(1251, 25)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(36, 20)
        Me.SearchButton.TabIndex = 6
        Me.SearchButton.Text = "➡️"
        Me.ToolTip1.SetToolTip(Me.SearchButton, "Search")
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'HomeButton
        '
        Me.HomeButton.BackColor = System.Drawing.Color.Black
        Me.HomeButton.ForeColor = System.Drawing.Color.White
        Me.HomeButton.Location = New System.Drawing.Point(12, 42)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(104, 20)
        Me.HomeButton.TabIndex = 7
        Me.HomeButton.Text = "🏠"
        Me.ToolTip1.SetToolTip(Me.HomeButton, "Home")
        Me.HomeButton.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.Black
        Me.BackButton.ForeColor = System.Drawing.Color.White
        Me.BackButton.Location = New System.Drawing.Point(122, 42)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(104, 20)
        Me.BackButton.TabIndex = 8
        Me.BackButton.Text = "⬅️"
        Me.ToolTip1.SetToolTip(Me.BackButton, "Back")
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'ForwardButton
        '
        Me.ForwardButton.BackColor = System.Drawing.Color.Black
        Me.ForwardButton.ForeColor = System.Drawing.Color.White
        Me.ForwardButton.Location = New System.Drawing.Point(1027, 42)
        Me.ForwardButton.Name = "ForwardButton"
        Me.ForwardButton.Size = New System.Drawing.Size(104, 20)
        Me.ForwardButton.TabIndex = 9
        Me.ForwardButton.Text = "➡️"
        Me.ToolTip1.SetToolTip(Me.ForwardButton, "Forward")
        Me.ForwardButton.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Black
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(1137, 42)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(104, 20)
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
        Me.SettingsButton.Location = New System.Drawing.Point(232, 42)
        Me.SettingsButton.Name = "SettingsButton"
        Me.SettingsButton.Size = New System.Drawing.Size(40, 20)
        Me.SettingsButton.TabIndex = 11
        Me.SettingsButton.Text = "🔧🏠"
        Me.ToolTip1.SetToolTip(Me.SettingsButton, "Settings")
        Me.SettingsButton.UseVisualStyleBackColor = False
        '
        'ContactButton
        '
        Me.ContactButton.BackColor = System.Drawing.Color.Black
        Me.ContactButton.ForeColor = System.Drawing.Color.White
        Me.ContactButton.Location = New System.Drawing.Point(981, 42)
        Me.ContactButton.Name = "ContactButton"
        Me.ContactButton.Size = New System.Drawing.Size(40, 20)
        Me.ContactButton.TabIndex = 12
        Me.ContactButton.Text = "💬"
        Me.ToolTip1.SetToolTip(Me.ContactButton, "Contact")
        Me.ContactButton.UseVisualStyleBackColor = False
        '
        'Browser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1299, 751)
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
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Browser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eclipse"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
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

End Class
