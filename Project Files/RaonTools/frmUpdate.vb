Imports System.Net
Imports System.IO
Imports System.Environment

Imports System.Text

Public Class frmUpdateCheck
    Public link As String = "https://dl.dropboxusercontent.com/u/43474426/Grid_Defender.exe"
    Public UserDesktop As String = GetFolderPath(SpecialFolder.Desktop) & "\RaonTools.exe"
    Public OpenDesktop As String = GetFolderPath(SpecialFolder.Desktop)
    Public UpdateAlert As String

    Private Sub frmUpdateCheck_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Control.CheckForIllegalCrossThreadCalls = False

        Dim request As System.Net.HttpWebRequest = _
            System.Net.HttpWebRequest.Create("https://dl.dropboxusercontent.com/u/43474426/version.txt")
        Dim response As System.Net.HttpWebResponse = request.GetResponse()
        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
        Dim newestversion As String = sr.ReadToEnd()
        Dim CurentVersion As String = Application.ProductVersion

        lblCurrentVersion.Text = "현재 버전: " & CurentVersion
        lblLatestVersion.Text = "최신 버전: " & newestversion

        If newestversion.Contains(CurentVersion) Then
            btnUpdate.Enabled = False
            lblVersion.Text = ("최신 버전입니다.")

            lblTotalSize.Visible = False
            lblDownloadedFile.Visible = False
            ProgressBar1.Visible = False
            Me.Size = New System.Drawing.Size(380, 138)

        Else
            lblVersion.Text = ("그리드 디펜더 새 버전이 나왔습니다!")
            UpdateAlert = MessageBox.Show("그리드 디펜더 새 버전이 나왔습니다!" & vbCrLf & "지금 업데이트를 다운로드 하시겠습니까?", _
                               "그리드 디펜더 업데이트", _
                               MessageBoxButtons.YesNo, _
                               MessageBoxIcon.Question)
            If UpdateAlert = DialogResult.Yes Then
                Me.Show()
            Else
                Me.Close()
            End If

        End If

    End Sub

    Private Sub Downloader_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles Downloader.DoWork
        File.Delete(UserDesktop)
        Dim size As Integer
        Dim wr As WebRequest
        wr = WebRequest.Create(link)
        Dim webr As WebResponse = wr.GetResponse
        size = webr.ContentLength
        size = size / 1024 ' Convert Bytes to KiloBytes
        ProgressBar1.Maximum = size
        lblTotalSize.Text = "전체 파일 크기: " & size
        Dim wc As New WebClient
        wc.DownloadFile(link, UserDesktop)
        Exit Sub

        MsgBox("ERROR", vbCritical, "ERROR")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim amount As Integer
        If System.IO.File.Exists(UserDesktop) Then
            Dim o As New System.IO.FileInfo(UserDesktop)
            amount = o.Length
            amount = amount / 1024 ' Convert Bytes to KiloBytes 
            lblDownloadedFile.Text = "다운받은 파일 크기: " & amount
            ProgressBar1.Value = amount
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Timer1.Start()
        Downloader.RunWorkerAsync()
    End Sub

    Private Sub Downloader_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles Downloader.RunWorkerCompleted

        Dim LatestVersionFileName As System.Net.HttpWebRequest = _
            System.Net.HttpWebRequest.Create("https://dl.dropboxusercontent.com/u/43474426/RenameFileName.txt")
        Dim GetLatestVersionFileName As System.Net.HttpWebResponse = LatestVersionFileName.GetResponse()
        Dim FileName As System.IO.StreamReader = New System.IO.StreamReader(GetLatestVersionFileName.GetResponseStream())
        Dim ShowLatestVersionFileName As String = FileName.ReadToEnd()

        Dim OldFileName As String = UserDesktop
        'Dim NewFileName As String = GetFolderPath(SpecialFolder.Desktop) & ShowLatestVersionFileName

        If File.Exists(OldFileName) Then
            My.Computer.FileSystem.RenameFile(OldFileName, ShowLatestVersionFileName) ' 파일 이름 변경 1
            'File.Move(OldFileName, NewFileName) 파일 이름 변경 2

        End If

        MessageBox.Show("다운로드가 완료되었습니다." & vbCrLf & "최신버전을 실행해주세요.", _
                               "그리드 디펜더 업데이트", _
                               MessageBoxButtons.OK, _
                               MessageBoxIcon.Information)

        Process.Start("explorer.exe", OpenDesktop)
        Application.Exit()

    End Sub
End Class