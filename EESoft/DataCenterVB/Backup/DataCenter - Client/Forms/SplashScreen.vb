Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Text

Public NotInheritable Class SplashScreen
    Private TIMR As New Timer 'this timer start the operations
    Private FadTmr As New Timer 'this is the fading timer
    Private ErrorProvider As String 'this is an intermediate variable between the function and the sender
    Private Int1 As Integer 'Free int for any loop
    Delegate Sub SetTextCallback(ByVal Args As String) 'its intermediate variable help me to send string between threads
    Private Sub SplashScreen_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Tmr_Tick(sender, e)
        End If
    End Sub
    Private Sub SplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TIMR.Interval = 2000
        AddHandler TIMR.Tick, AddressOf Tmr_Tick
        TIMR.Enabled = True
        FadTmr.Interval = 10
        AddHandler FadTmr.Tick, AddressOf FadTmr_tick
        FadTmr.Enabled = True
        ProgressBarLoading.Maximum = 2
        ProgressBarLoading.Value = 1
        'Application title
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)
        Copyright.Text = My.Application.Info.Copyright
    End Sub
    Private Sub Tmr_Tick(ByVal sender As Object, ByVal e As EventArgs)
        TIMR.Enabled = False
        FadTmr.Enabled = False
        ErrorProvider = Nothing
        ErrorProvider = FunLib.GetAllFilesType(RelatedFiles)
        If ErrorProvider <> Nothing Then
            MsgBox_(ErrorProvider, 0, 23, False, Me)
            Application.Exit()
        End If
        If FunLib.AllFilesType Is Nothing = False Then
            If FunLib.AllFilesType.Length <> 0 Then
                GetIcons()
            End If
            FrmMainWindow = New MainWindowFrm
            FrmMainWindow.Show()
            Me.Close()
        Else
            FrmMainWindow = New MainWindowFrm
            FrmMainWindow.Show()
            Me.Close()
        End If
    End Sub
    Public Function GetIcons() As String
        Dim DataB() As Byte = Nothing
        Dim Readed As Int16
        Dim FileSTM As FileStream
        Dim Sok As Socket
        Try
            ProgressBarLoading.Value = 0
            ProgressBarLoading.Maximum = FunLib.AllFilesType.Length - 1
            For Int1 = 0 To FunLib.AllFilesType.Length - 1
                ProgressBarLoading.Value = Int1
                LblPercent.Text = (ProgressBarLoading.Value / ProgressBarLoading.Maximum) * 100 & "%"
                If FunLib.AllFilesType(Int1).TypeIcon = "" Then
                    GoTo EscapeToNext
                End If
                Sok = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
                Dim FullString As String = FunctionLib.NetworkFunction.Commands.ReciveFile & FunLib.AllFilesType(Int1).TypeIcon
                DataB = Encoding.Default.GetBytes(FullString)
                Sok.Connect(ServerIP, REQPort)
                If Sok.Connected = True Then
                    Sok.Send(DataB, DataB.Length, SocketFlags.None) 'Sending Header
                    ReDim DataB(4096)
                    Dim FileNameArr() As String = FunLib.AllFilesType(Int1).TypeIcon.Split("\")
                    Dim FileName As String = IconPath & FileNameArr(FileNameArr.Length - 1)
                    FileSTM = File.Create(FileName.Trim)
                    SetValue(FileNameArr(FileNameArr.Length - 1))
                    Do
                        Readed = Sok.Receive(DataB, 0, 4096, SocketFlags.None)
                        If Readed > 0 Then
                            FileSTM.Write(DataB, 0, Readed)
                        Else
                            Exit Do
                        End If
                    Loop
                    FileSTM.Close()
                Else
                    Return "No Connection available"
                End If
                Sok.Close()
                Sok = Nothing
EscapeToNext:
                Application.DoEvents()
            Next
            SetValue("Loading complated starting DataCeter ...") 'All icons have been saved
        Catch ex As Exception
            If ex.TargetSite.Name = "Connect" Then
                MsgBox_("Sorry Data Center network service is not running", 23, 23, False, Me)
                Process.GetCurrentProcess.Kill()
            Else
                MsgBox_(ex.Message, 0, 23, False, Me)
            End If
            Return ex.Message
        End Try
        Return Nothing
    End Function
    Private Sub FadTmr_tick(ByVal sender As Object, ByVal e As EventArgs)
        If Me.Opacity < 1 Then
            Me.Opacity += 0.009
            'Me.Opacity = 1
        Else
            Me.Opacity = 1
            FadTmr.Enabled = False
        End If
    End Sub
    Private Sub SetValue(ByVal Args As String)
        If Me.Lbl.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf SetValue)
            Me.Invoke(d, New Object() {Args})
        Else
            Me.Lbl.Text = Args
        End If
    End Sub
End Class