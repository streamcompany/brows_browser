Imports System.IO
Public Class settingsform
    Private Sub settingsform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        searchenginebox.Text = "Waiting..."
        searchenginebox.Text = (File.ReadAllText("C:\Documents and Settings\All Users\Documents\STREAM\Brows\Settings\searchengine.txt"))
        Startuppage.Text = "Waiting..."
        Startuppage.Text = (File.ReadAllText("C:\Documents and Settings\All Users\Documents\STREAM\Brows\Settings\startup.txt"))
    End Sub

    Private Sub searchenginebox_Click(sender As Object, e As EventArgs) Handles searchenginebox.Click
        If searchenginebox.Text = "STREAM" Then
            searchenginebox.Text = "http://results.streamsearch.cf/?q="
        End If
        If searchenginebox.Text = "Simpl." Then
            searchenginebox.Text = "https://streamcompany.github.io/simpl/gbr/?q="
        End If
        If searchenginebox.Text = "DuckDuckGo" Then
            searchenginebox.Text = "https://duckduckgo.com/?q="
        End If
        If searchenginebox.Text = "Bing" Then
            searchenginebox.Text = "https://www.bing.com/search?q="
        End If
        If searchenginebox.Text = "Startpage" Then
            searchenginebox.Text = "https://www.startpage.com/do/search?q="
        End If
        If searchenginebox.Text = "Qwant" Then
            searchenginebox.Text = "https://www.qwant.com/?q="
        End If
        If searchenginebox.Text = "Yandex" Then
            searchenginebox.Text = "https://yandex.com/search/?text="
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Text = "Saving..."
        Dim Settingsdebug As String
        Settingsdebug = "C:/Documents and Settings/All Users/Documents/STREAM/Brows/Settings/searchengine.txt"
        File.Delete(Settingsdebug)
        Settingsdebug = "C:/Documents and Settings/All Users/Documents/STREAM/Brows/Settings/startup.txt"
        File.Delete(Settingsdebug)
        System.Threading.Thread.Sleep(1000)
        Dim searchsave As System.IO.StreamWriter
        searchsave = My.Computer.FileSystem.OpenTextFileWriter("C:/Documents and Settings/All Users/Documents/STREAM/Brows/Settings/searchengine.txt", True)
        searchsave.Write(searchenginebox.Text)
        Dim startupsave As System.IO.StreamWriter
        startupsave = My.Computer.FileSystem.OpenTextFileWriter("C:/Documents and Settings/All Users/Documents/STREAM/Brows/Settings/startup.txt", True)
        startupsave.Write(Startuppage.Text)
        startupsave.Close()
        searchsave.Close()
        Me.Close()
    End Sub

    Private Sub searchenginebox_SelectedValueChanged(sender As Object, e As EventArgs) Handles searchenginebox.SelectedValueChanged
        If searchenginebox.Text = "STREAM" Then
            searchenginebox.Text = "http://results.streamsearch.cf/?q="
        End If
        If searchenginebox.Text = "Simpl." Then
            searchenginebox.Text = "https://streamcompany.github.io/simpl/gbr/?q="
        End If
        If searchenginebox.Text = "DuckDuckGo" Then
            searchenginebox.Text = "https://duckduckgo.com/?q="
        End If
        If searchenginebox.Text = "Bing" Then
            searchenginebox.Text = "https://www.bing.com/search?q="
        End If
        If searchenginebox.Text = "Startpage" Then
            searchenginebox.Text = "https://www.startpage.com/do/search?q="
        End If
        If searchenginebox.Text = "Qwant" Then
            searchenginebox.Text = "https://www.qwant.com/?q="
        End If
        If searchenginebox.Text = "Yandex" Then
            searchenginebox.Text = "https://yandex.com/search/?text="
        End If
    End Sub
End Class