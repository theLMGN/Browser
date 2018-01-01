Public Class About

    Private Sub About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = "Eclipse Browser " & My.Application.Info.Version.ToString & vbNewLine & vbNewLine & "Eclipse Browser is open source software which uses" & vbNewLine & "technologies from WindowsLogic Productions Vivian."
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Browser.WebBrowser1.Navigate("https://github.com/EclipseUK/Browser")
        Me.Close()
    End Sub
End Class