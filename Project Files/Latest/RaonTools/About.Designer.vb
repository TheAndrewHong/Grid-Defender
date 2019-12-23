<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.lblVer = New System.Windows.Forms.Label()
        Me.lblWebsite = New System.Windows.Forms.Label()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.lblLastUpdated = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblVer
        '
        Me.lblVer.AutoSize = True
        Me.lblVer.Location = New System.Drawing.Point(7, 12)
        Me.lblVer.Name = "lblVer"
        Me.lblVer.Size = New System.Drawing.Size(127, 12)
        Me.lblVer.TabIndex = 0
        Me.lblVer.Text = "그리드 디펜더 v1.3.3.0"
        '
        'lblWebsite
        '
        Me.lblWebsite.AutoSize = True
        Me.lblWebsite.Location = New System.Drawing.Point(7, 54)
        Me.lblWebsite.Name = "lblWebsite"
        Me.lblWebsite.Size = New System.Drawing.Size(199, 12)
        Me.lblWebsite.TabIndex = 1
        Me.lblWebsite.Text = "combix.tistory.com / raonpia.com" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblCopyright
        '
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.Location = New System.Drawing.Point(7, 75)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(273, 12)
        Me.lblCopyright.TabIndex = 2
        Me.lblCopyright.Text = "Copyright © 2014 Raonpia. All Rights Reserved."
        '
        'lblLastUpdated
        '
        Me.lblLastUpdated.AutoSize = True
        Me.lblLastUpdated.Location = New System.Drawing.Point(7, 33)
        Me.lblLastUpdated.Name = "lblLastUpdated"
        Me.lblLastUpdated.Size = New System.Drawing.Size(147, 12)
        Me.lblLastUpdated.TabIndex = 3
        Me.lblLastUpdated.Text = "Last Updated: 2013/12/30"
        '
        'btnReset
        '
        Me.btnReset.Image = Global.GridDefender.My.Resources.Resources.list
        Me.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReset.Location = New System.Drawing.Point(70, 96)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(146, 24)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "프로그램 설정 초기화"
        Me.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 125)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblLastUpdated)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.lblWebsite)
        Me.Controls.Add(Me.lblVer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbout"
        Me.Padding = New System.Windows.Forms.Padding(10, 8, 10, 8)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblVer As System.Windows.Forms.Label
    Friend WithEvents lblWebsite As System.Windows.Forms.Label
    Friend WithEvents lblCopyright As System.Windows.Forms.Label
    Friend WithEvents lblLastUpdated As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button

End Class
