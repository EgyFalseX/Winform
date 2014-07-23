Public NotInheritable Class SplashScreenFrm
    Private TMR As New Timer
    Private FadTmr As New Timer
    Private Sub SplashScreenFrm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TMR.Interval = 4000
        AddHandler TMR.Tick, AddressOf Tmr_Tick
        TMR.Enabled = True
        FadTmr.Interval = 10
        AddHandler FadTmr.Tick, AddressOf FadTmr_tick
        FadTmr.Enabled = True
    End Sub
    Private Sub Tmr_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Click, MainLayoutPanel.Click
        TMR.Enabled = False
        FadTmr.Enabled = False
        FrmSupplier = New SupplierFrm
        FrmSupplier.Show()
        Me.Close()
    End Sub
    Private Sub FadTmr_tick(ByVal sender As Object, ByVal e As EventArgs)
        If Me.Opacity < 1 Then
            Me.Opacity += 0.009
        Else
            Me.Opacity = 1
            FadTmr.Enabled = False
        End If
    End Sub
End Class
