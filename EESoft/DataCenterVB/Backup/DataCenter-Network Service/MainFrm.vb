Imports System.Net
Imports System.IO
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading
Public Class MainFrm
    Private Structure Alsockets
        Dim MySocket As Socket
        Dim Cmd As Commands
        Dim RelatedFile As String
    End Structure
    Private SokNfo() As Alsockets
    Public LSok As Socket
    Public IPEndP As IPEndPoint
    Public ThD As Thread
    Private Sub BtnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStart.Click
        IPEndP = New IPEndPoint(IPAddress.Any, GeneralPort)
        BtnStart.Enabled = False
        BtnStop.Enabled = True
        Me.AcceptButton = BtnStop
        BtnStop.Focus()
        ThD = New Thread(AddressOf OnStart)
        ThD.Start()
    End Sub
    Private Sub OnStart()
        Try
            Dim handlerSocket As Socket
            Dim thdRecHandler As Thread
            'tcpListener.Start()
            'MsgBox("MSG 1" & vbNewLine & "server is waiting the incoming Req")
            LSok = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
            LSok.Bind(IPEndP)
            LSok.Listen(-1)
            Do
                handlerSocket = LSok.Accept()
                If handlerSocket.Connected Then
                    'SyncLock (Me) 'Redim SokNfo and start new thread
                    thdRecHandler = New Thread(AddressOf SystemAnalyser)
                    thdRecHandler.Start(handlerSocket)
                    'End SyncLock
                End If
            Loop
        Catch ex As Exception
            If ex.TargetSite.Name <> "Accept" Then
                MsgBox(ex.Message)
            End If
        End Try
    End Sub
    Private Sub SystemAnalyser(ByVal Ojct As Object)
        Dim Sok As Socket = Ojct
        Dim Readed As Int16
        Dim Buffers(4096) As Byte
        Dim FileSTM As FileStream
        Dim CMD As New Commands
        Try
            Sok.Receive(Buffers, 1, SocketFlags.None)
            CMD = Val(Encoding.Default.GetString(Buffers, 0, 1))
            Select Case CMD

                Case Commands.Ping ' command 0

                Case Commands.SendFile 'Command 1
                    Readed = Sok.Receive(Buffers, 4096, SocketFlags.None)
                    Dim FileName As String = Encoding.Default.GetString(Buffers, 0, Readed).Trim
                    If Not File.Exists(FileName) Then
                        Sok.Close()
                        Sok = Nothing
                        Exit Sub
                    Else
                        FileSTM = New FileStream(FileName, FileMode.Open, FileAccess.Read)
                        Do
                            Readed = FileSTM.Read(Buffers, 0, 4096)
                            If Readed > 0 Then Sok.Send(Buffers, Readed, SocketFlags.None) Else Exit Do
                        Loop
                        FileSTM.Close()
                    End If

                Case Commands.ReciveFile 'command 2
                    Readed = Sok.Receive(Buffers, 4096, SocketFlags.None)
                    '0-ServerFilePath 1-DeletedFilesPath 2-FileSize
                    Dim FileNames() As String = Encoding.Default.GetString(Buffers, 0, Readed).Trim.Split("/")
                    'MsgBox(FileNames(0) & vbNewLine & FileNames(1) & vbNewLine & FileNames(2))
                    Dim FileName() As String = FileNames(0).Split("\")
                    Dim TargetFile As String = FileNames(1) & FileName(FileName.Length - 1)
                    If System.IO.Directory.Exists(FileNames(1)) = False Then
                        System.IO.Directory.CreateDirectory(FileNames(1))
                    End If
                    If System.IO.File.Exists(FileNames(0)) = False Then
                        GoTo BeginCopy
                    End If
                    Dim int As Integer
                    Dim NewFileName As String
                    For int = 0 To 10000
                        NewFileName = TargetFile & "_" & int
                        If System.IO.File.Exists(NewFileName) = False Then
                            System.IO.File.Move(FileNames(0), NewFileName)
                            GoTo BeginCopy
                        End If
                    Next
BeginCopy:
                    Dim FileSize As Integer
                    FileSTM = New FileStream(FileNames(0), FileMode.Create, FileAccess.Write, FileShare.Write)
                    Buffers(0) = CByte("1")
                    Sok.Send(Buffers, 1, SocketFlags.None)
                    Do
                        Readed = Sok.Receive(Buffers, 4096, SocketFlags.None)
                        FileSTM.Write(Buffers, 0, Readed)
                        FileSize += Readed
                        If FileSize = FileNames(2) Then : Exit Do : End If
                    Loop
                    FileSTM.Close()
                Case Commands.CreateFile 'command 3
                    Readed = Sok.Receive(Buffers, 4096, SocketFlags.None)
                    '0-ServerPath 1-FileName 2-FileType 3-FileSize
                    Dim FileNames() As String = Encoding.Default.GetString(Buffers, 0, Readed).Trim.Split("/")
                    'MsgBox(FileNames(0) & vbNewLine & FileNames(1) & vbNewLine & FileNames(2))
                    Dim NewFileName As String
                    Dim FileSize As Integer
                    Dim int As Integer
                    For int = 0 To 10000
                        NewFileName = FileNames(0) & FileNames(1) & "_" & int & "." & FileNames(2)
                        If System.IO.File.Exists(NewFileName) = False Then
                            FileSTM = New FileStream(NewFileName, FileMode.Create, FileAccess.Write, FileShare.Write)
                            Buffers(0) = CByte("1")
                            Sok.Send(Buffers, 1, SocketFlags.None)
                            Do
                                Readed = Sok.Receive(Buffers, 4096, SocketFlags.None)
                                FileSTM.Write(Buffers, 0, Readed)
                                FileSize += Readed
                                If FileSize = FileNames(3) Then : Exit Do : End If
                            Loop
                            FileSTM.Close()
                            Buffers = Encoding.Default.GetBytes(NewFileName)
                            Sok.Send(Buffers, NewFileName.Length, SocketFlags.None)
                            Exit For
                        End If
                    Next

                Case Commands.CreateFolder 'command 4
                    Readed = Sok.Receive(Buffers, 4096, SocketFlags.None)
                    Dim FolderPath As String = Encoding.Default.GetString(Buffers, 0, Readed).Trim
                    If Directory.Exists(FolderPath) = True Then
                        Buffers(0) = CByte("0")
                    Else
                        If Directory.CreateDirectory(FolderPath).Exists = False Then
                            Buffers(0) = CByte("0")
                        Else
                            Buffers(0) = CByte("1")
                        End If
                    End If
                    Sok.Send(Buffers, 1, SocketFlags.None)

                Case Commands.RemoveFolder 'Command 5
                    Readed = Sok.Receive(Buffers, 4096, SocketFlags.None)
                    Dim FolderPath() As String = Encoding.Default.GetString(Buffers, 0, Readed).Trim.Split("/")
                    If Directory.Exists(FolderPath(0)) = True Then
                        If Directory.Exists(FolderPath(1)) = False Then
                            Directory.CreateDirectory(FolderPath(1))
                        End If
                        Dim i1 As Integer
                        Dim FileName() As String = FolderPath(0).Split("\")
                        For i1 = 0 To Integer.MaxValue - 1
                            If Directory.Exists(FolderPath(1) & FileName(FileName.Length - 1) & "_" & i1) = False Then
                                Directory.Move(FolderPath(0), FolderPath(1) & FileName(FileName.Length - 1) & "_" & i1)
                                Buffers(0) = CByte("1")
                                Exit For
                            End If
                        Next
                    Else
                        Buffers(0) = CByte("0")
                    End If
                    Sok.Send(Buffers, 1, SocketFlags.None)

                Case Commands.RemoveFile 'Command 6
                    Readed = Sok.Receive(Buffers, 4096, SocketFlags.None)
                    Dim FilePath() As String = Encoding.Default.GetString(Buffers, 0, Readed).Trim.Split("/")
                    If File.Exists(FilePath(0)) = True Then
                        If Directory.Exists(FilePath(1)) = False Then
                            Directory.CreateDirectory(FilePath(1))
                        End If
                        Dim i1 As Integer
                        Dim FileName() As String = FilePath(0).Split("\")
                        For i1 = 0 To Integer.MaxValue - 1
                            If Not File.Exists(FilePath(1) & FileName(FileName.Length - 1) & "_" & i1) Then
                                File.Move(FilePath(0), FilePath(1) & FileName(FileName.Length - 1) & "_" & i1)
                                Buffers(0) = CByte("1")
                                Sok.Send(Buffers, 1, SocketFlags.None)
                                Exit Select
                            End If
                        Next
                        Buffers(0) = CByte("0")
                    Else
                        Buffers(0) = CByte("0")
                    End If
                    Sok.Send(Buffers, 1, SocketFlags.None)

                Case Commands.MoveFolder 'Command 7
                    Readed = Sok.Receive(Buffers, 4096, SocketFlags.None)
                    Dim FolderPath() As String = Encoding.Default.GetString(Buffers, 0, Readed).Trim.Split("/")
                    'TFolder(0) , DFolder(1)
                    If Directory.Exists(FolderPath(1)) = True Then
                        Buffers(0) = CByte("0")
                    Else
                        Try
                            Directory.Move(FolderPath(0), FolderPath(1))
                            Buffers(0) = CByte("1")
                        Catch
                            Buffers(0) = CByte("0")
                        End Try
                    End If
                    Sok.Send(Buffers, 1, SocketFlags.None)
            End Select
        Catch ex As Exception
        End Try
        FileSTM = Nothing
        Sok.Close()
        Sok = Nothing
    End Sub
    Private Sub BtnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStop.Click
        'tcpListener.Stop()
        If LSok IsNot Nothing Then
            LSok.Close()
            LSok = Nothing
        End If
        BtnStart.Enabled = True
        BtnStop.Enabled = False
        Me.AcceptButton = BtnStart
        BtnStart.Focus()
    End Sub
    Private Sub MainFrm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ServiceNotifyIcon.Visible = False
        Process.GetCurrentProcess.Kill()
    End Sub
    Private Sub MainFrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Hide()
    End Sub
    Private Sub MainFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ServiceNotifyIcon.Visible = True
        TimerZ.Start()
        'Loading Options from registry
        If GetRegValue(GeneralPort, RegKeyValues.GeneralPort) = False Then
            BtnStart.Visible = False
            MsgBox("Can't start service" & vbNewLine & " Options is missing", MsgBoxStyle.Information)
            Exit Sub
        End If
        If GetRegValue(DeletedFilesPath, RegKeyValues.DeletedFilesPath) = False Then
            BtnStart.Visible = False
            MsgBox("Can't start service" & vbNewLine & " Options is missing", MsgBoxStyle.Information)
            Exit Sub
        End If
        BtnStart_Click(sender, e)
        EnableCommand = True
    End Sub
    Private Sub BtnOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOptions.Click
        If FrmOptions.Visible = False Then
            FrmOptions = New OptionsFrm
            FrmOptions.ShowDialog()
        Else
            FrmOptions.Focus()
        End If
    End Sub
    Private Sub TimerZ_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerZ.Tick
        Me.Hide()
        TimerZ.Stop()
    End Sub
#Region "   '   Safe-Thread     '   "
    Delegate Sub SetTextCallback(ByVal Args As String)
    'Private Sub SetValue(ByVal Args As String)
    ' InvokeRequired required compares the thread ID of the
    ' calling thread to the thread ID of the creating thread.
    ' If these threads are different, it returns true.
    'If Me.LB.InvokeRequired Then
    '    Dim d As New SetTextCallback(AddressOf SetValue)
    '    Me.Invoke(d, New Object() {Args})
    'Else
    '    Me.LB.Items.Add(Args)
    'End If
    'End Sub
#End Region
#Region "   '   Menus Commands     '   "
    Private Sub NetS_CMS_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles NetS_CMS.Opening
        If EnableCommand = False Then 'Cant start service stop all commands
            StartToolStripMenuItem.Enabled = False
            StopToolStripMenuItem.Enabled = False
        Else
            If BtnStart.Enabled = True Then 'Service Stoped
                StopToolStripMenuItem.Enabled = False
                StartToolStripMenuItem.Enabled = True
            Else 'Service Start
                StopToolStripMenuItem.Enabled = True
                StartToolStripMenuItem.Enabled = False
            End If
        End If
        If Me.Visible = True Then
            ShowMainWindowToolStripMenuItem.Enabled = False
        Else
            ShowMainWindowToolStripMenuItem.Enabled = True
        End If
    End Sub
    Private Sub ServiceNotifyIcon_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ServiceNotifyIcon.MouseClick

    End Sub
    Private Sub ShowMainWindowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowMainWindowToolStripMenuItem.Click
        If Me.Visible = False Then
            Me.Visible = True
            Me.WindowState = FormWindowState.Normal
        Else
            Me.Visible = True
        End If
    End Sub
    Private Sub StartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartToolStripMenuItem.Click
        BtnStart_Click(sender, e)
    End Sub
    Private Sub StopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopToolStripMenuItem.Click
        BtnStop_Click(sender, e)
    End Sub
    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        If FrmOptions.Visible = False Then
            FrmOptions = New OptionsFrm
            FrmOptions.StartPosition = FormStartPosition.CenterScreen
            FrmOptions.ShowDialog()
        Else
            FrmOptions.Focus()
        End If
    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        ServiceNotifyIcon.Visible = False
        Process.GetCurrentProcess.Kill()
    End Sub
#End Region
End Class