Public Class Form1

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' 電腦和應用程式資訊
        txtOutput.Text = "電腦名稱: " & My.Computer.Name & vbNewLine
        txtOutput.Text &= "系統時間: " & My.Computer.Clock.LocalTime & vbNewLine
        txtOutput.Text &= "程式名稱: " & My.Application.Info.AssemblyName & vbNewLine
        txtOutput.Text &= "程式標題: " & My.Application.Info.Title & vbNewLine
        txtOutput.Text &= "程式路徑: " & My.Application.Info.DirectoryPath & vbNewLine
        ' 文字檔案處理
        Dim str As String
        My.Computer.FileSystem.WriteAllText("Test.txt", "Visual Basic程式設計", False)
        str = My.Computer.FileSystem.ReadAllText("Test.txt")
        txtOutput.Text &= "Test.txt檔案內容: " & str & vbNewLine
        ' 測試網路連線
        If My.Computer.Network.IsAvailable Then
            txtOutput.Text &= "電腦現在有網路連線..." & vbNewLine
        End If
        ' 播放音效
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
        txtOutput.SelectionStart = 0
    End Sub
End Class
