Module MainModule
    'Dll Defenation
    Public FunLib As New FunctionLib.DataCenterServerLib
    'Forms Defenation
    Public FrmSQLConnection As New SQLConnectionFrm
    Public SC As New SplashScreen
    Public FrmLogin As New LoginForm
    Public FrmMSG As MSGBOXFrm
    Public FrmFilesChecker As New FilesCheckerFrm
    Public FrmMainForm As New MainForm
    Public FrmObjectProperty As New ObjectPropertyFrm
    Public FrmNewClient As New NewClientFrm
    Public FrmNewConsultants As New NewConsultantsFrm
    Public FrmNewContractors As New NewContractorsFrm
    Public FrmPrivileges As New PrivilegesFrm
    Public FrmUsersPrivileges As New UsersPrivilegesFrm
    Public FrmUsers As New EditUsersFrm
    Public FrmDisactivatedUsers As New DisactivatedUsersFrm
    Public FrmEditConsultants As New EditConsultantsFrm
    Public FrmEditContractors As New EditContractorsFrm
    Public FrmEditClients As New EditClientsFrm
    Public FrmDisactivatedContractors As New DisactivatedContractorsFrm
    Public FrmDisactivatedConsultants As New DisactivatedConsultantsFrm
    Public FrmDisactivatedClients As New DisactivatedClientsFrm
    Public FrmDeactivateProject As New DeactivateProjectFrm
    Public FrmWizrad As New WizradFrm
    Public FrmOptions As New OptionsFrm
    Public FrmNewFileTypes As New NewFileTypesFrm
    Public FrmEditFileTypes As New EditFileTypesFrm
    Public FrmLockedFiles As New LockedFilesFrm

    'Options
    Public AdminID As String = "0001"
    Public DefaultUserPassword As String '= "123456"
    Public ProjectsPath As String '= "D:\MDC\Projects\"
    Public RelatedFiles As String '= "D:\MDC\Related Files\"
    Public ServerPort As String
    Public ServerIP As String
    Public DeletedFilesPath As String
    'Vars
    Private ErrorProvider As String = Nothing
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
    Public ProjectInfoSTR As FunctionLib.DataCenterServerLib.ProjectInfo
    Sub main()
        Dim RegExist As Boolean = False
        'Get Connection string from reg
        If FunLib.GetRegValue(FunLib.SQLCon.ConnectionString, FunctionLib.DataCenterServerLib.RegKeyValues.SQLString) = True Then
            Dim Str As String = ""
            'GetPassword
            Dim PW As String = ""
            If FunLib.GetRegValue(PW, FunctionLib.DataCenterServerLib.RegKeyValues.PW) = False Then
                GoTo StartNewConnection
            End If
            FunLib.SQLCon.ConnectionString &= ";password=" & FunLib.Binarytochar(PW)
            'Get option vars
            ErrorProvider = Nothing
            ErrorProvider = FunLib.GetServerOption(DefaultUserPassword, ProjectsPath, RelatedFiles, DeletedFilesPath, ServerIP, ServerPort)
            If ErrorProvider <> Nothing Then
                MsgBox_("Can't start the application ' option error '", 20, 23, False, StartUpFrm)
                If MsgBox("Maybe its error in connection" & vbNewLine & "(Reset connection)Are you sure ?", MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.Yes Then
                    FunLib.ResetConnection()
                End If
                Process.GetCurrentProcess.Kill()
            End If
            SC.ShowDialog()
            If FrmLogin.ShowDialog = DialogResult.OK Then
                If FunLib.GetRegValue(Str, FunctionLib.DataCenterServerLib.RegKeyValues.DataChacked) = True Then
                Else
                    FrmFilesChecker.Show()
                End If
            End If
        Else
StartNewConnection:
            FrmSQLConnection.Show()
        End If
    End Sub
    Public Sub MsgBox_(ByVal MSG As String, ByVal x As Int16, ByVal y As Int16, ByVal Complate As Boolean, ByVal SenderForm As Form)
        If Complate = True Then
            SenderForm.Opacity = 0.3
            FrmMSG = New MSGBOXFrm(MSG)
            FrmMSG.LBLMSG.Location = New Point(x, y)
            FrmMSG.BtnOk.BackColor = Color.GreenYellow
            FrmMSG.Panel.BackColor = Color.Green
            'FrmMSG.BackgroundImage = Global.DataCenter_Server.My.Resources.Resources.Complated
            FrmMSG.ShowDialog(SenderForm)
            SenderForm.Opacity = 1
        Else
            SenderForm.Opacity = 0.3
            FrmMSG = New MSGBOXFrm(MSG)
            FrmMSG.LBLMSG.Location = New Point(y, y)
            FrmMSG.BtnOk.BackColor = Color.Red
            FrmMSG.Panel.BackColor = Color.Red
            'FrmMSG.BackgroundImage = Global.DataCenter_Server.My.Resources.Resources._Error
            FrmMSG.ShowDialog(SenderForm)
            SenderForm.Opacity = 1
        End If
    End Sub

End Module