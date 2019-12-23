Public NotInheritable Class frmAbout
    Private Sub frmAbout_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblVer.Text = My.Settings.Ver_Info
        lblLastUpdated.Text = My.Settings.Last_Updated
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        If GetSetting("One Time MessageBox", "Settings", "Notice Shown", "0") = "0" Then
            Me.Close()
        Else
            DeleteSetting("One Time MessageBox")
            MessageBox.Show("프로그램 설정이 초기화되었습니다.", _
                               " 프로그램 설정 초기화 ", _
                               MessageBoxButtons.OK, _
                               MessageBoxIcon.Asterisk)
            Me.Close()
        End If
    End Sub
End Class
