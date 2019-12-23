<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateCheck
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdateCheck))
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblCurrentVersion = New System.Windows.Forms.Label()
        Me.lblLatestVersion = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblDownloadedFile = New System.Windows.Forms.Label()
        Me.lblTotalSize = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Downloader = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(89, 72)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(187, 23)
        Me.btnUpdate.TabIndex = 0
        Me.btnUpdate.Text = "업데이트"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(103, 50)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(106, 12)
        Me.lblVersion.TabIndex = 5
        Me.lblVersion.Text = "최신 버전입니다."
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCurrentVersion
        '
        Me.lblCurrentVersion.AutoSize = True
        Me.lblCurrentVersion.Location = New System.Drawing.Point(103, 17)
        Me.lblCurrentVersion.Name = "lblCurrentVersion"
        Me.lblCurrentVersion.Size = New System.Drawing.Size(65, 12)
        Me.lblCurrentVersion.TabIndex = 6
        Me.lblCurrentVersion.Text = "현재 버전: "
        '
        'lblLatestVersion
        '
        Me.lblLatestVersion.AutoSize = True
        Me.lblLatestVersion.Location = New System.Drawing.Point(103, 30)
        Me.lblLatestVersion.Name = "lblLatestVersion"
        Me.lblLatestVersion.Size = New System.Drawing.Size(65, 12)
        Me.lblLatestVersion.TabIndex = 7
        Me.lblLatestVersion.Text = "최신 버전: "
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 101)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(340, 23)
        Me.ProgressBar1.TabIndex = 8
        '
        'lblDownloadedFile
        '
        Me.lblDownloadedFile.AutoSize = True
        Me.lblDownloadedFile.Location = New System.Drawing.Point(171, 148)
        Me.lblDownloadedFile.Name = "lblDownloadedFile"
        Me.lblDownloadedFile.Size = New System.Drawing.Size(117, 12)
        Me.lblDownloadedFile.TabIndex = 10
        Me.lblDownloadedFile.Text = "다운받은 파일 크기: "
        Me.lblDownloadedFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalSize
        '
        Me.lblTotalSize.AutoSize = True
        Me.lblTotalSize.Location = New System.Drawing.Point(195, 136)
        Me.lblTotalSize.Name = "lblTotalSize"
        Me.lblTotalSize.Size = New System.Drawing.Size(93, 12)
        Me.lblTotalSize.TabIndex = 9
        Me.lblTotalSize.Text = "전체 파일 크기: "
        Me.lblTotalSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Timer1
        '
        '
        'Downloader
        '
        '
        'frmUpdateCheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 165)
        Me.Controls.Add(Me.lblDownloadedFile)
        Me.Controls.Add(Me.lblTotalSize)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.lblLatestVersion)
        Me.Controls.Add(Me.lblCurrentVersion)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.btnUpdate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUpdateCheck"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "그리드 디펜더 업데이트"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents lblCurrentVersion As System.Windows.Forms.Label
    Friend WithEvents lblLatestVersion As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblDownloadedFile As System.Windows.Forms.Label
    Friend WithEvents lblTotalSize As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Downloader As System.ComponentModel.BackgroundWorker
End Class
