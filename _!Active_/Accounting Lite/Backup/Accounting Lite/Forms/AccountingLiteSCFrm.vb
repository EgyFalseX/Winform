Public NotInheritable Class AccountingLiteSCFrm
    Public CloseTimer As New Timer
    Private Sub OfficeAppSplashScreenFRM_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        CloseTimer.Interval = 3000
        AddHandler CloseTimer.Tick, AddressOf CloseTimer_Tick
        CloseTimer.Start()
    End Sub
    Private Sub CloseTimer_Tick(ByVal sender As Object, ByVal e As EventArgs)
        'Me.Hide()
        'FrmLogin = New LoginForm
        'FrmLogin.Show()
        CloseTimer.Stop()
    End Sub
End Class
