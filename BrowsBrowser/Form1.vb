Imports System.IO
Imports System.Text
Imports System

Public Class Form1
    Private Sub back_button_Click(sender As Object, e As EventArgs) Handles back_button.Click
        back_button.Image = BrowsBrowser.My.Resources.backbuttoninteract
        Sandboxed_process1.GoBack()
    End Sub

    Private Sub back_button_MouseHover(sender As Object, e As EventArgs) Handles back_button.MouseHover
        back_button.Image = BrowsBrowser.My.Resources.backbuttontarget
    End Sub

    Private Sub back_button_MouseLeave(sender As Object, e As EventArgs) Handles back_button.MouseLeave
        If (Sandboxed_process1.CanGoBack = True) Then
            back_button.Image = BrowsBrowser.My.Resources.backbuttonidle
        Else
            back_button.Image = BrowsBrowser.My.Resources.backbuttontarget
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If (e.KeyData = Keys.Enter) Then
            If TextBox1.Text.Contains(".") And Not TextBox1.Text.Contains(" ") Or TextBox1.Text.Contains(":") Then
                Sandboxed_process1.Navigate(TextBox1.Text)
            Else
                Sandboxed_process1.Navigate(File.ReadAllText("C:\Documents and Settings\All Users\Documents\STREAM\Brows\Settings\searchengine.txt") + TextBox1.Text)
            End If
            If TextBox1.Text = "brows:settings" Then
                Dim sForm As settingsform
                sForm = New settingsform()
                sForm.Show()
                sForm = Nothing
            End If
            webProgress.Show()
            webProgress.Value = 5
            webProgress.PerformStep()
            Status.Show()
            status_bar.Show()
            Status.Text = "Requesting..."
        End If
    End Sub

    Private Sub WebBrowser1_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles Sandboxed_process1.Navigating
        reload_button.Image = BrowsBrowser.My.Resources.loadreloadidle
        TextBox1.Text = Convert.ToString(Sandboxed_process1.Url)
        If (Sandboxed_process1.CanGoForward = True) Then
            forward_button.Image = BrowsBrowser.My.Resources.forwardbuttonidle
        Else
            forward_button.Image = BrowsBrowser.My.Resources.forwardbuttontarget
        End If
        If (Sandboxed_process1.CanGoBack = True) Then
            back_button.Image = BrowsBrowser.My.Resources.backbuttonidle
        Else
            back_button.Image = BrowsBrowser.My.Resources.backbuttontarget
        End If
        Me.Text = TextBox1.Text + " - Brows Browser"
        webProgress.Show()
        webProgress.Value = 60
        webProgress.PerformStep()
        Status.Show()
        status_bar.Show()
        Status.Text = "Waiting for " + TextBox1.Text
    End Sub

    Private Sub WebBrowser1_Navigated(sender As Object, e As WebBrowserNavigatedEventArgs) Handles Sandboxed_process1.Navigated
        TextBox1.Text = Convert.ToString(Sandboxed_process1.Url)
        If (Sandboxed_process1.CanGoForward = True) Then
            forward_button.Image = BrowsBrowser.My.Resources.forwardbuttonidle
        Else
            forward_button.Image = BrowsBrowser.My.Resources.forwardbuttontarget
        End If
        If (Sandboxed_process1.CanGoBack = True) Then
            back_button.Image = BrowsBrowser.My.Resources.backbuttonidle
        Else
            back_button.Image = BrowsBrowser.My.Resources.backbuttontarget
        End If
        Me.Text = TextBox1.Text + " - Brows Browser"
        webProgress.Value = 100
        webProgress.PerformStep()
        webProgress.Hide()
        Status.Show()
        status_bar.Show()
        Status.Text = "Complete"
        Status.Hide()
        status_bar.Hide()
        reload_button.Image = BrowsBrowser.My.Resources.reloadbuttonidle
    End Sub

    Private Sub forward_button_Click(sender As Object, e As EventArgs) Handles forward_button.Click
    End Sub

    Private Sub forward_button_MouseHover(sender As Object, e As EventArgs) Handles forward_button.MouseEnter
        forward_button.Image = BrowsBrowser.My.Resources.forwardbuttontarget
    End Sub

    Private Sub forward_button_MouseLeave(sender As Object, e As EventArgs) Handles forward_button.MouseLeave
        If (Sandboxed_process1.CanGoForward = True) Then
            forward_button.Image = BrowsBrowser.My.Resources.forwardbuttonidle
        Else
            forward_button.Image = BrowsBrowser.My.Resources.forwardbuttontarget
        End If
    End Sub

    Private Sub reload_button_Click(sender As Object, e As EventArgs) Handles reload_button.Click
    End Sub

    Private Sub reload_button_MouseEnter(sender As Object, e As EventArgs) Handles reload_button.MouseEnter
        If Not (Sandboxed_process1.IsBusy = True) Then
            reload_button.Image = BrowsBrowser.My.Resources.reloadbuttontarget
        Else
            reload_button.Image = BrowsBrowser.My.Resources.loadreloadtarget
        End If
    End Sub

    Private Sub reload_button_MouseMove(sender As Object, e As MouseEventArgs) Handles reload_button.MouseMove
        If Not (Sandboxed_process1.IsBusy = True) Then
            reload_button.Image = BrowsBrowser.My.Resources.reloadbuttonidle
        Else
            reload_button.Image = BrowsBrowser.My.Resources.loadreloadidle
        End If
    End Sub

    Private Sub reload_button_MouseHover(sender As Object, e As EventArgs) Handles reload_button.MouseHover
        If Not (Sandboxed_process1.IsBusy = True) Then
            reload_button.Image = BrowsBrowser.My.Resources.reloadbuttontarget
        Else
            reload_button.Image = BrowsBrowser.My.Resources.loadreloadtarget
        End If
    End Sub

    Private Sub WebBrowser1_NewWindow(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Sandboxed_process1.NewWindow
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oForm As Form2
        oForm = New Form2()
        oForm.Show()
        oForm = Nothing
        If Not Directory.Exists("C:\Documents and Settings\All Users\Documents\STREAM\Brows") Then
            My.Computer.FileSystem.CreateDirectory(
  "C:\Documents and Settings\All Users\Documents\STREAM\Brows")
            My.Computer.FileSystem.CreateDirectory(
"C:\Documents and Settings\All Users\Documents\STREAM\Brows\Sessions")
            My.Computer.FileSystem.CreateDirectory(
"C:\Documents and Settings\All Users\Documents\STREAM\Brows\Settings")
            Dim Settingsfile As System.IO.StreamWriter
            Settingsfile = My.Computer.FileSystem.OpenTextFileWriter("C:/Documents and Settings/All Users/Documents/STREAM/Brows/Settings/searchengine.txt", True)
            Settingsfile.WriteLine("https://streamcompany.github.io/search/gbr?q=")
            Settingsfile = My.Computer.FileSystem.OpenTextFileWriter("C:/Documents and Settings/All Users/Documents/STREAM/Brows/Settings/startup.txt", True)
            Settingsfile.WriteLine("https://streamcompany.github.io/")
            Settingsfile.Close()
        End If
        Sandboxed_process1.Stop()
        Sandboxed_process1.Navigate(File.ReadAllText("C:\Documents and Settings\All Users\Documents\STREAM\Brows\Settings\startup.txt"))
    End Sub

    Private Sub newtab_button_Click(sender As Object, e As EventArgs) Handles newtab_button.Click
        newtab_button.Image = BrowsBrowser.My.Resources.newtabinteract
        Dim nForm As Form1
        nForm = New Form1()
        nForm.Show()
        nForm = Nothing
    End Sub

    Private Sub newtab_button_MouseEnter(sender As Object, e As EventArgs) Handles newtab_button.MouseEnter
        newtab_button.Image = BrowsBrowser.My.Resources.newtabtarget
    End Sub

    Private Sub newtab_button_MouseLeave(sender As Object, e As EventArgs) Handles newtab_button.MouseLeave
        newtab_button.Image = BrowsBrowser.My.Resources.newtabidle
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub Forward_button_MouseDown(sender As Object, e As MouseEventArgs) Handles forward_button.MouseDown
        forward_button.Image = BrowsBrowser.My.Resources.forwardbuttoninteract
    End Sub

    Private Sub Forward_button_MouseUp(sender As Object, e As MouseEventArgs) Handles forward_button.MouseUp
        forward_button.Image = BrowsBrowser.My.Resources.forwardbuttontarget
        Sandboxed_process1.GoForward()
    End Sub

    Private Sub Back_button_MouseDown(sender As Object, e As MouseEventArgs) Handles back_button.MouseDown
        back_button.Image = BrowsBrowser.My.Resources.backbuttoninteract
    End Sub

    Private Sub Back_button_MouseUp(sender As Object, e As MouseEventArgs) Handles back_button.MouseUp
        back_button.Image = BrowsBrowser.My.Resources.backbuttontarget
        Sandboxed_process1.GoBack()
    End Sub

    Private Sub Reload_button_MouseDown(sender As Object, e As MouseEventArgs) Handles reload_button.MouseDown
        If Not (Sandboxed_process1.IsBusy = True) Then
            reload_button.Image = BrowsBrowser.My.Resources.reloadbuttoninteract
        Else
            reload_button.Image = BrowsBrowser.My.Resources.loadreloadinteract
        End If
    End Sub

    Private Sub Reload_button_MouseUp(sender As Object, e As MouseEventArgs) Handles reload_button.MouseUp
        If Not (Sandboxed_process1.IsBusy = True) Then
            reload_button.Image = BrowsBrowser.My.Resources.loadreloadidle
            Sandboxed_process1.Refresh()
        Else
            Sandboxed_process1.Stop()
            reload_button.Image = BrowsBrowser.My.Resources.reloadbuttonidle
        End If
    End Sub
End Class