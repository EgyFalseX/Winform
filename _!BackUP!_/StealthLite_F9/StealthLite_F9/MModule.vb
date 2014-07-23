Module MModule
    Private WithEvents TrayIcon As New NotifyIcon
    Private MyContainer As New System.ComponentModel.Container
    Private WithEvents Tmr As New Timer

    Public Sub main()
        TrayIcon = New System.Windows.Forms.NotifyIcon(MyContainer)
        TrayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        TrayIcon.BalloonTipTitle = "StealthLite Checker"
        TrayIcon.Text = "StealthLite F9 by False"
        TrayIcon.Icon = My.Resources.Stealthlite
        TrayIcon.Visible = True
        Tmr.Interval = 20 * 1000
        Tmr.Start()
        Application.Run()
    End Sub
    Private Sub Tmr_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Tmr.Tick
        My.Computer.Keyboard.SendKeys("{F9}", False)
        Threading.Thread.Sleep(1000)
        My.Computer.Keyboard.SendKeys("{F9}", False)
    End Sub
    Private Sub TrayIcon_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles TrayIcon.DoubleClick
        TrayIcon.Icon = Nothing
        TrayIcon.Visible = False
        Application.Exit()
    End Sub
End Module
