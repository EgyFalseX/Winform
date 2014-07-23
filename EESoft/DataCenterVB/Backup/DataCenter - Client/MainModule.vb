Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Module MainModule
    'Dll Defenation
    Public NWLib As New FunctionLib.NetworkFunction
    Public FunLib As New FunctionLib.DataCenterClientLib
    'Forms Defenation
    Public FrmMSG As MSGBOXFrm
    Public FrmSQLConnection As New SQLConnectionFrm
    Public SC As New SplashScreen
    Public FrmLogin As New LoginForm
    Public FrmMainWindow As New MainWindowFrm
    Public FrmObjectProperty As New ObjectPropertyFrm
    Public FrmTransfer As New TransferFrm
    Public FrmLockedFiles As New LockedFilesFrm
    Public FrmOptions As New OptionsFrm
    'Options
    Public ProjectsPath As String
    Public RelatedFiles As String
    Public IconPath As String = Application.StartupPath & "\Temp\Icons\"
    Public REQPort As String
    Public ServerIP As String
    Public DefaultFileSize As Integer = 50 'I didnt call it
    Public DeletedFilesPath As String 'With the \
    'Vars
    Private ErrorProvider As String = Nothing
    Public AllFoldersWithPrv As FunctionLib.DataCenterClientLib.PrivateFoldersPrvType
    'Structures
    Enum ObjectType
        Project
        File
        NewFolder
        ExistedFolder
    End Enum
    Public Structure ObjectProperty
        Dim FileIndex As Int16
        Dim FolderIndex As Integer
        Dim ObjecyType As ObjectType
    End Structure
    Public PropertyObjectInfo As New ObjectProperty

    'Functions
    Public Sub MsgBox_(ByVal MSG As String, ByVal x As Int16, ByVal y As Int16, ByVal Complate As Boolean, ByVal SenderForm As Form)
        If Complate = True Then
            SenderForm.Opacity = 0.3
            FrmMSG = New MSGBOXFrm(MSG)
            FrmMSG.LBLMSG.Location = New Point(x, y)
            FrmMSG.BtnOk.BackColor = Color.GreenYellow
            FrmMSG.Panel.BackColor = Color.Green
            'FrmMSG.BackgroundImage = Global.DataCenter_Client.My.Resources.Resources.Complated
            FrmMSG.ShowDialog(SenderForm)
            SenderForm.Opacity = 1
        Else
            SenderForm.Opacity = 0.3
            FrmMSG = New MSGBOXFrm(MSG)
            FrmMSG.LBLMSG.Location = New Point(y, y)
            FrmMSG.BtnOk.BackColor = Color.Red
            FrmMSG.Panel.BackColor = Color.Red
            'FrmMSG.BackgroundImage = Global.DataCenter_Client.My.Resources.Resources.Error_
            FrmMSG.ShowDialog(SenderForm)
            SenderForm.Opacity = 1
        End If
    End Sub
    Sub main()
        Dim RegExist As Boolean = False
        'Get Connection string from reg
        Dim Str As String = ""
        If FunLib.GetRegValue(Str, FunctionLib.DataCenterServerLib.RegKeyValues.SQLString) = True Then
            FunLib.SQLCon.ConnectionString = Str
            FunLib.SqlStr = Str
            'GetPassword
            Dim PW As String = ""
            If FunLib.GetRegValue(PW, FunctionLib.DataCenterServerLib.RegKeyValues.PW) = False Then
                GoTo StartNewConnection
            End If
            FunLib.SQLCon.ConnectionString &= ";password=" & FunLib.Binarytochar(PW)
            FunLib.SqlStr &= ";password=" & FunLib.Binarytochar(PW)
            'Get option vars
            ErrorProvider = Nothing
            ErrorProvider = FunLib.GetServerOption(ProjectsPath, RelatedFiles, DeletedFilesPath, ServerIP, REQPort) 'Loading Options
            If ErrorProvider <> Nothing Then
                MsgBox_("Can't start the application ' option error '", 20, 23, False, StartUpFrm)
                If MsgBox("Maybe its error in connection" & vbNewLine & "(Reset connection)Are you sure ?", MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.Yes Then
                    FunLib.ResetConnection()
                End If
                Process.GetCurrentProcess.Kill()
            End If
            If ProjectsPath = "" Or RelatedFiles = "" Or REQPort = "" Or ServerIP = "" Or DeletedFilesPath = "" Then
                MsgBox_("Server Option didn't set yet,Client isn't ready to use", 0, 23, False, New Form)
                Process.GetCurrentProcess.Kill()
            End If
            FrmLogin.ShowDialog()
        Else
StartNewConnection:
            FrmSQLConnection.Show()
        End If
    End Sub
    Public Function CreateFile(ByVal IP_Address As String, ByVal RPort As Int32, ByVal OrgFilePath As String, ByVal ServerPath As String, ByVal FileName As String, ByVal FileType As String, ByRef NewFilePath As String) As String
        Dim FullString As String
        Dim Buffers(4096) As Byte
        Dim Sok As New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
        Dim Created As Integer
        Try
            Dim FileSRM As New FileStream(OrgFilePath, FileMode.Open, FileAccess.Read)
            FullString = FunctionLib.NetworkFunction.Commands.CreateFile & ServerPath & "/" & FileName & "/" & FileType & "/" & FileSRM.Length

            FrmObjectProperty.NewFileProgressBar.Value = 0
            FrmObjectProperty.NewFileProgressBar.Maximum = FileSRM.Length
            Buffers = Encoding.Default.GetBytes(FullString)
            Sok.Connect(IP_Address, RPort)
            If Sok.Connected = True Then
                Sok.Send(Buffers, FullString.Length, SocketFlags.None)
                Sok.Receive(Buffers, 1, SocketFlags.None)
                Created = Val(Buffers(0))
                If Created = 1 Then
                    ReDim Buffers(4096)
                    Do
                        Created = FileSRM.Read(Buffers, 0, 4096)
                        If Created > 0 Then
                            Sok.Send(Buffers, Created, SocketFlags.None)
                            FrmObjectProperty.NewFileProgressBar.Value += Created
                            FrmObjectProperty.Text = "New File Properties  " & CInt((FrmObjectProperty.NewFileProgressBar.Value / FrmObjectProperty.NewFileProgressBar.Maximum) * 100) & " %"
                        Else
                            Exit Do
                        End If
                        Application.DoEvents()
                    Loop
                    Created = Sok.Receive(Buffers, 4096, SocketFlags.None)
                    NewFilePath = Encoding.Default.GetString(Buffers, 0, Created)
                    FrmObjectProperty.Text = "New File Properties"
                    FrmObjectProperty.NewFileProgressBar.Value = 0
                    FrmObjectProperty.NewFileProgressBar.Maximum = 0
                Else : Sok.Close() : Sok = Nothing : Return "Can't create file or sever is out of space"
                End If
            Else
                Return "No Connection available"
            End If
        Catch ex As Exception
            Try : Sok.Close() : Catch : End Try
            Return ex.Message
        End Try
        Try : Sok.Close() : Catch : End Try
        Return Nothing
    End Function

End Module