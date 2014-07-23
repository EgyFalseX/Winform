<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainFrm))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtnStart = New System.Windows.Forms.Button
        Me.BtnStop = New System.Windows.Forms.Button
        Me.BtnOptions = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.LblBackground = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.ServiceNotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NetS_CMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowMainWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TimerZ = New System.Windows.Forms.Timer(Me.components)
        Me.NetS_CMS.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(56, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Start network service"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(56, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Stop network service"
        '
        'BtnStart
        '
        Me.BtnStart.BackgroundImage = Global.DataCenterNetworkService.My.Resources.Resources.bt_Start
        Me.BtnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnStart.Location = New System.Drawing.Point(12, 7)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(38, 38)
        Me.BtnStart.TabIndex = 0
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'BtnStop
        '
        Me.BtnStop.BackgroundImage = Global.DataCenterNetworkService.My.Resources.Resources.bt_Stop
        Me.BtnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnStop.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnStop.Enabled = False
        Me.BtnStop.Location = New System.Drawing.Point(12, 51)
        Me.BtnStop.Name = "BtnStop"
        Me.BtnStop.Size = New System.Drawing.Size(38, 38)
        Me.BtnStop.TabIndex = 1
        Me.BtnStop.UseVisualStyleBackColor = True
        '
        'BtnOptions
        '
        Me.BtnOptions.BackgroundImage = Global.DataCenterNetworkService.My.Resources.Resources.bt_Settings
        Me.BtnOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnOptions.Location = New System.Drawing.Point(12, 95)
        Me.BtnOptions.Name = "BtnOptions"
        Me.BtnOptions.Size = New System.Drawing.Size(38, 38)
        Me.BtnOptions.TabIndex = 2
        Me.BtnOptions.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(56, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Network service options"
        '
        'LblBackground
        '
        Me.LblBackground.Image = Global.DataCenterNetworkService.My.Resources.Resources.Background
        Me.LblBackground.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.LblBackground.Location = New System.Drawing.Point(87, 3)
        Me.LblBackground.Name = "LblBackground"
        Me.LblBackground.Size = New System.Drawing.Size(209, 148)
        Me.LblBackground.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(6, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 135)
        Me.Label4.TabIndex = 4
        '
        'ServiceNotifyIcon
        '
        Me.ServiceNotifyIcon.ContextMenuStrip = Me.NetS_CMS
        Me.ServiceNotifyIcon.Icon = CType(resources.GetObject("ServiceNotifyIcon.Icon"), System.Drawing.Icon)
        Me.ServiceNotifyIcon.Text = "Data Center-Network Service"
        '
        'NetS_CMS
        '
        Me.NetS_CMS.BackColor = System.Drawing.Color.White
        Me.NetS_CMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowMainWindowToolStripMenuItem, Me.StartToolStripMenuItem, Me.StopToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.NetS_CMS.Name = "NetS_CMS"
        Me.NetS_CMS.Size = New System.Drawing.Size(167, 114)
        '
        'ShowMainWindowToolStripMenuItem
        '
        Me.ShowMainWindowToolStripMenuItem.Image = Global.DataCenterNetworkService.My.Resources.Resources.Background
        Me.ShowMainWindowToolStripMenuItem.Name = "ShowMainWindowToolStripMenuItem"
        Me.ShowMainWindowToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.ShowMainWindowToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ShowMainWindowToolStripMenuItem.Text = "Show Main Window"
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.Image = Global.DataCenterNetworkService.My.Resources.Resources.bt_Start
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.StartToolStripMenuItem.Text = "&Start"
        '
        'StopToolStripMenuItem
        '
        Me.StopToolStripMenuItem.Image = Global.DataCenterNetworkService.My.Resources.Resources.bt_Stop
        Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        Me.StopToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.StopToolStripMenuItem.Text = "S&top"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Image = Global.DataCenterNetworkService.My.Resources.Resources.bt_Settings
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'TimerZ
        '
        Me.TimerZ.Interval = 1
        '
        'MainFrm
        '
        Me.AcceptButton = Me.BtnStart
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(269, 141)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnOptions)
        Me.Controls.Add(Me.BtnStop)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.LblBackground)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DataCenter Service Manager"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.NetS_CMS.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnStart As System.Windows.Forms.Button
    Friend WithEvents BtnStop As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnOptions As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblBackground As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ServiceNotifyIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents NetS_CMS As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents StartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowMainWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimerZ As System.Windows.Forms.Timer

End Class
