Public Class Form2
    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        If WebBrowser1.Url IsNot "https://iplogger.org/2uPuu5" Then
            Me.Close()
        End If
    End Sub
End Class