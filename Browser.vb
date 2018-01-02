Public Class Browser
    Dim modalHTML As String = "about:<style>body{background: #2d2d2d; margin: 0;color: #fff; font-family: ""Segoe UI Symbol"", ""Segoe UI""; position: absolute; padding-left: 1em;}</style><div id=""content""><h1>{title}</h1>{content}</div><script>document.title = ""{title}""</script>"
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseLabel.Click
        Me.Close()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinimiseLabel.Click
        Dim oldSize = Me.Size
        While True
            Me.Size = New Size(Me.Size.Width * 0.75, Me.Size.Height * 0.75)
            Me.Refresh()
            If Me.Size.Height < 10 And Me.Size.Width < 10 Then
                Exit While
            End If
        End While

        Me.WindowState = FormWindowState.Minimized
        Me.Size = oldSize
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchButton.Click
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeButton.Click
        WebBrowser1.Navigate(My.Settings.Home)
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForwardButton.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        WebBrowser1.Refresh()
    End Sub

    Dim oldSize = New Size()
    Dim oldPosition = New Point
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaximiseLabel.Click
        If MaximiseLabel.Text = "+" Then
            oldSize = Me.Size
            oldPosition = Me.Location
            Me.Location = My.Computer.Screen.WorkingArea.Location 'Won't work with multimonitors though.
            Me.Size = My.Computer.Screen.WorkingArea.Size
            MaximiseLabel.Text = "-"
        Else
            Me.Location = oldPosition
            Me.Size = oldSize
            MaximiseLabel.Text = "+"
        End If

    End Sub

#Region "Move Form"
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown, PictureBox1.MouseDown

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove, PictureBox1.MouseMove

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp, PictureBox1.MouseUp

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub

#End Region

    Private Sub MenuButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuButton.Click
        ContextMenuStrip1.Show(MenuButton, 0, MenuButton.Height)
    End Sub

    Private Sub NewTabToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewTabToolStripMenuItem.Click
        WebBrowser1.Url = New Uri(modalHTML.Replace("{title}", "About Eclipse Browser").Replace("{content}", "<h2>Lead Developer: 9002</h2>Other Developers: WindowsLogic Productions and theLMGN"))
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted


        If Not TextBox1.Focused Then
            Try
                TextBox1.Text = WebBrowser1.Url.AbsoluteUri
            Catch
            End Try
        End If
    End Sub

    Private Sub update_Tick(sender As Object, e As EventArgs) Handles update.Tick
        Try
            Label1.Text = "eclipse - " & WebBrowser1.DocumentTitle
            Me.Text = "Eclipse - " & WebBrowser1.DocumentTitle
        Catch
        End Try
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        settings.Show()
    End Sub

    Private Sub ReportAnIssueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportAnIssueToolStripMenuItem.Click
        WebBrowser1.Url = New Uri("https://github.com/eclipseuk/browser/issues")
    End Sub
End Class
