Public NotInheritable Class SplashScreen
    Private TMR As New Timer
    Private FadTmr As New Timer
    Private Sub SplashScreen_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Tmr_Tick(sender, e)
        End If
    End Sub
    Private Sub SplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Set up the dialog text at runtime according to the application's assembly information.  
        TMR.Interval = 4000
        AddHandler TMR.Tick, AddressOf Tmr_Tick
        TMR.Enabled = True
        FadTmr.Interval = 10
        AddHandler FadTmr.Tick, AddressOf FadTmr_tick
        FadTmr.Enabled = True
        '  properties dialog (under the "Project" menu).

        'Application title
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            'If the application title is missing, use the application name, without the extension
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        'Format the version information using the text set into the Version control at design time as the
        '  formatting string.  This allows for effective localization if desired.
        '  Build and revision information could be included by using the following code and changing the 
        '  Version control's designtime text to "Version {0}.{1:00}.{2}.{3}" or something similar.  See
        '  String.Format() in Help for more information.
        '
        '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        'Copyright info
        Copyright.Text = My.Application.Info.Copyright
        'Copyright.Text &= vbNewLine & "Mostafa Nouh Abdo" & vbNewLine & "Mohamed Aly Omer"
    End Sub
    Private Sub Tmr_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Copyright.Click, ApplicationTitle.Click, Version.Click, MainLayoutPanel.Click
        'FrmLogin.Show()
        'FrmMainForm.Show()
        TMR.Enabled = False
        FadTmr.Enabled = False
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
