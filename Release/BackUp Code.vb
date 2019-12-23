
        ' Check For Alert Messages
        Dim GetAlertURL As System.Net.HttpWebRequest = _
            System.Net.HttpWebRequest.Create("https://dl.dropboxusercontent.com/u/43474426/AlertMessageStatus.txt")
        Dim GetAlert As System.Net.HttpWebResponse = GetAlertURL.GetResponse()
        Dim AlertMessageStatusRead As System.IO.StreamReader = New System.IO.StreamReader(GetAlert.GetResponseStream())
        Dim AlertMessageStatus As String = AlertMessageStatusRead.ReadToEnd()

        Dim Normal As String = My.Settings.StrNormal
        Dim Message As String = My.Settings.StrMessage
        Dim Alert As String = My.Settings.StrAlert
        Dim UpdateAvailable As String = My.Settings.StrUpdateAvailable

        ' 프로그램에 아무 이상 없을시... 필독 메시지 표시
        If AlertMessageStatus.Contains(Normal) Then
            Dim MainMessageResult = MessageBox.Show("*** 필 독 ***" & vbCrLf & _
                    "악성으로 분류한 기준은 아래 같습니다. " & vbCrLf & _
                    "(그리드 딜리버리, 툴바, 멀웨어, 애드온, 스폰서, 바로가기, 기타 등등..)" & vbCrLf & _
                    "                                            " & vbCrLf & _
                    "삭제여부는 본인이 선택할 수 있습니다. " & vbCrLf & _
                    "(일부 프로그램은 삭제 동의없이 바로 진행되는 것도 있습니다.) " & vbCrLf & _
                    "제거가 제대로 되지 않으면 관리자 권한으로 실행해 주세요.  " & vbCrLf & _
                    "                                            " & vbCrLf & _
                    "설치된 악성 프로그램의 검사 또는 제거를 원하십니까?" & vbCrLf, _
                    "**** 필 독 ****", _
                    MessageBoxButtons.YesNo, _
                    MessageBoxIcon.Question)

            If MainMessageResult = DialogResult.Yes Then
                Me.Show()

            Else
                Application.Exit()

            End If

            ' 업데이트 있을시...
        ElseIf AlertMessageStatus.Contains(UpdateAvailable) Then


            ' 프로그램에 버그 또는 기타문제가 있을시... 경고 메세지 표시하고 프로그램 종료
        ElseIf AlertMessageStatus.Contains(Message) Or AlertMessageStatus.Contains(Alert) Then

            MessageBox.Show("Alert!!! OR Message!!!" & vbCrLf & _
                   "버그가 발견되었습니다. 프로그램을 종료합니다." & vbCrLf & _
                   "실행을 보류해 주세요. " & vbCrLf, _
                   " 버그가 발견되었습니다. ", _
                   MessageBoxButtons.OK, _
                   MessageBoxIcon.Exclamation)

            Application.Exit()

        Else

            Me.Show()

        End If
