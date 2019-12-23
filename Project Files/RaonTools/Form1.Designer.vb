<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnDelGrid = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnShutdown = New System.Windows.Forms.Button()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnGoToBlog = New System.Windows.Forms.Button()
        Me.btnCheckUpdate = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimer = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDelGrid
        '
        Me.btnDelGrid.Font = New System.Drawing.Font("Gulim", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnDelGrid.Location = New System.Drawing.Point(93, 146)
        Me.btnDelGrid.Name = "btnDelGrid"
        Me.btnDelGrid.Size = New System.Drawing.Size(289, 38)
        Me.btnDelGrid.TabIndex = 0
        Me.btnDelGrid.Text = "그리드 && 악성 프로그램 제거"
        Me.btnDelGrid.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gulim", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "원클릭 그리드 && 악성 프로그램 제거"
        '
        'btnAbout
        '
        Me.btnAbout.Image = Global.GridDefender.My.Resources.Resources.Version
        Me.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbout.Location = New System.Drawing.Point(338, 114)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(64, 24)
        Me.btnAbout.TabIndex = 6
        Me.btnAbout.Text = "About"
        Me.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'btnShutdown
        '
        Me.btnShutdown.Image = Global.GridDefender.My.Resources.Resources.Shutdown
        Me.btnShutdown.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnShutdown.Location = New System.Drawing.Point(283, 250)
        Me.btnShutdown.Name = "btnShutdown"
        Me.btnShutdown.Size = New System.Drawing.Size(80, 24)
        Me.btnShutdown.TabIndex = 5
        Me.btnShutdown.Text = "종료"
        Me.btnShutdown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnShutdown.UseVisualStyleBackColor = True
        '
        'btnInfo
        '
        Me.btnInfo.Image = Global.GridDefender.My.Resources.Resources.Info
        Me.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnInfo.Location = New System.Drawing.Point(111, 250)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(80, 24)
        Me.btnInfo.TabIndex = 2
        Me.btnInfo.Text = "그리드??"
        Me.btnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GridDefender.My.Resources.Resources.GridDefender_Logo
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(472, 118)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'btnGoToBlog
        '
        Me.btnGoToBlog.Image = Global.GridDefender.My.Resources.Resources.Website
        Me.btnGoToBlog.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGoToBlog.Location = New System.Drawing.Point(197, 250)
        Me.btnGoToBlog.Name = "btnGoToBlog"
        Me.btnGoToBlog.Size = New System.Drawing.Size(80, 24)
        Me.btnGoToBlog.TabIndex = 3
        Me.btnGoToBlog.Text = "블로그"
        Me.btnGoToBlog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGoToBlog.UseVisualStyleBackColor = True
        '
        'btnCheckUpdate
        '
        Me.btnCheckUpdate.Font = New System.Drawing.Font("Gulim", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnCheckUpdate.Location = New System.Drawing.Point(93, 198)
        Me.btnCheckUpdate.Name = "btnCheckUpdate"
        Me.btnCheckUpdate.Size = New System.Drawing.Size(289, 38)
        Me.btnCheckUpdate.TabIndex = 11
        Me.btnCheckUpdate.Text = "새로운 업데이트 확인"
        Me.btnCheckUpdate.UseVisualStyleBackColor = True
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Location = New System.Drawing.Point(402, 185)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(42, 12)
        Me.lblTimer.TabIndex = 12
        Me.lblTimer.Text = "Label2"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 282)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.btnCheckUpdate)
        Me.Controls.Add(Me.btnGoToBlog)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnShutdown)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDelGrid)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDelGrid As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnInfo As System.Windows.Forms.Button
    Friend WithEvents btnShutdown As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents btnGoToBlog As System.Windows.Forms.Button
    Friend WithEvents btnCheckUpdate As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblTimer As System.Windows.Forms.Label

End Class
