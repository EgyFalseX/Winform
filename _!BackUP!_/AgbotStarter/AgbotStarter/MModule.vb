Module MModule
    Private WithEvents TrayIcon As New NotifyIcon
    Private MyContainer As New System.ComponentModel.Container
    Private WithEvents Tmr As New Timer
    Private ProS() As Process
    Private ExitLoop As Boolean = False
    Private AgbotPath As String = "F:\Remove me\Silkroad\Agbot\Agbot\agBot.exe"
    Private XYZ As New Form
    Public Sub main()
        XYZ.Text = "XYZ"
        TrayIcon = New System.Windows.Forms.NotifyIcon(MyContainer)
        TrayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        TrayIcon.BalloonTipTitle = "Agbot Checker"
        TrayIcon.Text = "AgbotStarter by False"
        TrayIcon.Icon = My.Resources.AgbotIcon
        TrayIcon.Visible = True
        Tmr.Interval = 5000
        Tmr.Start()
        TrayIcon.ShowBalloonTip(5000, "Agbot checker ..", "Agbot checker is now running ...", ToolTipIcon.Info)
        Application.Run()
    End Sub
    Private Sub Tmr_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Tmr.Tick
        ProS = Process.GetProcesses
        For Each Process In ProS
            If Process.ProcessName.ToString.ToLower = "agbot" Then
                Exit Sub
            End If
        Next
        Dim StartInformation As New Diagnostics.ProcessStartInfo(AgbotPath)
        My.Computer.Audio.Play("Agbot_Closed.wav")
        TrayIcon.ShowBalloonTip(5000, "Agbot not found !!", "Starting Agbot" & vbCr & " [" & AgbotPath & "]", ToolTipIcon.Warning)
        Process.Start(StartInformation).WaitForInputIdle()
        TrayIcon.ShowBalloonTip(5000, "Agbot checker ..", "Starting complated", ToolTipIcon.Info)
        Threading.Thread.Sleep(6000)
        My.Computer.Keyboard.SendKeys("{F10}")
        XYZ.Show()
        XYZ.Focus()
        Threading.Thread.Sleep(4000)
        My.Computer.Keyboard.SendKeys("{F5}", False)
        Threading.Thread.Sleep(500)
        My.Computer.Keyboard.SendKeys("{F5}", False)
        XYZ.Hide()
        TrayIcon.ShowBalloonTip(5000, "Agbot checker ..", "Sendkey complated", ToolTipIcon.Info)
    End Sub
    Private Sub TrayIcon_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles TrayIcon.DoubleClick
        TrayIcon.Icon = Nothing
        TrayIcon.Visible = False
        Application.Exit()
    End Sub
End Module
