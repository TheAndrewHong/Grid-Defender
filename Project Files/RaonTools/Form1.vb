Imports System.IO
Imports System.Environment
Imports System.Text

Public Class frmMain
    Public AppData As String = GetFolderPath(SpecialFolder.ApplicationData) & "\DB.bat"

    Private Sub btnDelGrid_Click(sender As Object, e As EventArgs) Handles btnDelGrid.Click
        MessageBox.Show("*** 필 독 ***" & vbCrLf & _
                        "악성 프로그램의 언인스톨 경로를 모아둔 단순 배치 파일입니다. " & vbCrLf & _
                        "                                            " & vbCrLf & _
                        "목록에 포함되어 있는 것이 있다면 언인스톨이 실행될 것이고 " & vbCrLf & _
                        "아무것도 없다면 도스 창은 자동 종료됩니다. " & vbCrLf, _
                        "시작시 주의점", _
                        MessageBoxButtons.OK, _
                        MessageBoxIcon.Information)

        File.WriteAllText(AppData, My.Resources.DB, Encoding.Default())
        Process.Start(AppData)

    End Sub

    Private Function InternetConnection() As Boolean
        Dim reqInternet As System.Net.WebRequest = System.Net.WebRequest.Create("http://www.google.com/")
        Dim respInternet As System.Net.WebResponse
        Try
            respInternet = reqInternet.GetResponse()
            respInternet.Close()
            reqInternet = Nothing
            Return True
        Catch ex As Exception
            reqInternet = Nothing
            Return False
        End Try
    End Function

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        System.Threading.Thread.Sleep(3000)

        Timer1.Start()



        If InternetConnection() = False Then
            ' 인터넷에 연결 안되어 있을시 아래 코드 실행.

            'MessageBox.Show("Internet is NOT Connected!", "인터넷 연결 상태 확인", MessageBoxButtons.OK, MessageBoxIcon.Information)

            If GetSetting("One Time MessageBox", "Settings", "Notice Shown", "0") = "0" Then
                If MessageBox.Show("*** 필 독 ***" & vbCrLf & _
            "악성으로 분류한 기준은 아래 같습니다. " & vbCrLf & _
            "(그리드 딜리버리, 툴바, 멀웨어, 애드온, 스폰서, 바로가기, 기타 등등..)" & vbCrLf & _
            "                                            " & vbCrLf & _
            "삭제여부는 본인이 선택할 수 있습니다. " & vbCrLf & _
            "(일부 프로그램은 삭제 동의없이 바로 진행되는 것도 있습니다.) " & vbCrLf & _
            "제거가 제대로 되지 않으면 관리자 권한으로 실행해 주세요.  " & vbCrLf & _
            "                                            " & vbCrLf & _
            "설치된 악성 프로그램의 검사 또는 제거를 원하십니까?" & vbCrLf & _
            "                                            " & vbCrLf & _
            "**** 이 메시지는 프로그램 처음 실행 시 딱 한번만 실행됩니다. ****" & vbCrLf, _
            "**** 필 독 ****", _
            MessageBoxButtons.YesNo, _
            MessageBoxIcon.Question) _
            = DialogResult.Yes Then
                    SaveSetting("One Time MessageBox", "Settings", "Notice Shown", "1")
                    Me.Show()
                Else
                    Application.Exit()
                End If
            Else
                Me.Text = My.Settings.Ver_Info
                Me.Show()
            End If

        Else
            ' 인터넷에 연결 되어 있을시 아래 코드 실행.

            'MessageBox.Show("인터넷에 연결되어 있습니다." & vbCrLf & _
            '                "업데이트를 확인합니다.", "인터넷 연결 상태 확인", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' 업데이트 확인
            Dim requestMain As System.Net.HttpWebRequest = _
    System.Net.HttpWebRequest.Create("https://dl.dropboxusercontent.com/u/43474426/version.txt")
            Dim responseMain As System.Net.HttpWebResponse = requestMain.GetResponse()
            Dim srMain As System.IO.StreamReader = New System.IO.StreamReader(responseMain.GetResponseStream())
            Dim newestversionMain As String = srMain.ReadToEnd()
            Dim CurentVersionMain As String = Application.ProductVersion

            ' 만약 프로그램이 최신 버전시 실행, 아닐시 프로그램 닫고 업데이트창 실행.
            If newestversionMain.Contains(CurentVersionMain) Then

                ' Check For Alert Messages
                Dim GetAlertURL As System.Net.HttpWebRequest = _
                    System.Net.HttpWebRequest.Create("https://dl.dropboxusercontent.com/u/43474426/AlertMessageStatus.txt")
                Dim GetAlert As System.Net.HttpWebResponse = GetAlertURL.GetResponse()
                Dim AlertMessageStatusRead As System.IO.StreamReader = New System.IO.StreamReader(GetAlert.GetResponseStream())
                Dim AlertMessageStatus As String = AlertMessageStatusRead.ReadToEnd()

                Dim Normal As String = My.Settings.StrNormal
                Dim Alert As String = My.Settings.StrAlert

                ' 프로그램에 아무 이상 없을시, 필독 메시지 표시
                If AlertMessageStatus.Contains(Normal) Then
                    If GetSetting("One Time MessageBox", "Settings", "Notice Shown", "0") = "0" Then
                        Dim MainMessageResult = MessageBox.Show("*** 필 독 ***" & vbCrLf & _
                        "악성으로 분류한 기준은 아래 같습니다. " & vbCrLf & _
                        "(그리드 딜리버리, 툴바, 멀웨어, 애드온, 스폰서, 바로가기, 기타 등등..)" & vbCrLf & _
                        "                                            " & vbCrLf & _
                        "삭제여부는 본인이 선택할 수 있습니다. " & vbCrLf & _
                        "(일부 프로그램은 삭제 동의없이 바로 진행되는 것도 있습니다.) " & vbCrLf & _
                        "제거가 제대로 되지 않으면 관리자 권한으로 실행해 주세요.  " & vbCrLf & _
                        "                                            " & vbCrLf & _
                        "설치된 악성 프로그램의 검사 또는 제거를 원하십니까?" & vbCrLf & _
                        "                                            " & vbCrLf & _
                        "**** 이 메시지는 프로그램 처음 실행 시 딱 한번만 실행됩니다. ****" & vbCrLf, _
                        "**** 필 독 ****", _
                        MessageBoxButtons.YesNo, _
                        MessageBoxIcon.Question)

                        If MainMessageResult = DialogResult.Yes Then
                            SaveSetting("One Time MessageBox", "Settings", "Notice Shown", "1")
                            Me.Show()

                        Else
                            Application.Exit()
                        End If

                    Else
                        Me.Show()
                    End If


                    ' 프로그램에 버그 또는 기타문제가 있을시, 경고 메세지 표시하고 프로그램 종료
                ElseIf AlertMessageStatus.Contains(Alert) Then
                    MessageBox.Show("Alert!!!" & vbCrLf & _
                           "버그가 발견되었습니다. 프로그램을 종료합니다." & vbCrLf & _
                           "실행을 보류해 주세요." & vbCrLf & _
                           "                                            " & vbCrLf & _
                           "자세한 사항은 개발자에게 문의해 주시기 바랍니다." & vbCrLf & _
                           "이메일: sjhong0918@gmail.com" & vbCrLf, _
                           " 버그가 발견되었습니다. ", _
                           MessageBoxButtons.OK, _
                           MessageBoxIcon.Exclamation)

                    Application.Exit()
                End If

            Else
                ' 만약 프로그램이 최신 버전이 아닌경우 프로그램 닫고 업데이트창 실행.
                frmUpdateCheck.ShowDialog()

            End If

        End If

        Me.Text = My.Settings.Ver_Info

        ' 세팅 삭제: 테스트용!!!!!!!!!!!    ***** !!!!!!!!!!!!!!!!!!!!!!!!! *****
        ' DeleteSetting("One Time MessageBox")

    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        MessageBox.Show("네트워크에 접속되어 있는 사용자 컴퓨터 간에 " & vbCrLf & _
                        "데이터를 주고받게 함으로써 하나의 콘텐츠를 " & vbCrLf & _
                        "다수의 사용자가 효율적으로 이용할 수 있는 기술." & vbCrLf & _
                        "                                            " & vbCrLf & _
                        "동영상을 본 사용자 컴퓨터에 데이터를 저장시키고 " & vbCrLf & _
                        "다른 사람들이 같은 동영상을 볼 때 그 자료를 활용하는 방식이다. " & vbCrLf & _
                        "                                            " & vbCrLf & _
                        "따라서 회사 측에서는 동영상을 분산 저장할 수 있기 때문에 " & vbCrLf & _
                        "데이터를 빠른 속도로 보낼 수 있지만 사용자는 " & vbCrLf & _
                        "컴퓨터 용량을 그만큼 손실하여 컴퓨터 속도가 느려지는 단점이 있다. " & vbCrLf & _
                        "                                            " & vbCrLf & _
                        "- 네이버 지식사전 인용 -" & vbCrLf, _
                        "그리드 딜리버리(Grid Delivery)란??", _
                        MessageBoxButtons.OK, _
                        MessageBoxIcon.Information)
    End Sub

    Private Sub btnGoToWebsite_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://www.raonpia.com")
    End Sub

    Private Sub btnGoToBlog_Click(sender As Object, e As EventArgs) Handles btnGoToBlog.Click
        System.Diagnostics.Process.Start("http://combix.tistory.com/")
    End Sub

    Private Sub btnShutdown_Click(sender As Object, e As EventArgs) Handles btnShutdown.Click
        Application.Exit()
    End Sub

    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub btnCheckUpdate_Click(sender As Object, e As EventArgs) Handles btnCheckUpdate.Click
        frmUpdateCheck.ShowDialog()
    End Sub
End Class