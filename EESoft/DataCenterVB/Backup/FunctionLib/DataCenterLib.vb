Imports System.Math
Imports Microsoft.Win32
Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Public Class DataCenterServerLib
    'Vars SQLClient
    Public SQLCon As New SqlClient.SqlConnection("")
    Private SQLDR As SqlClient.SqlDataReader
    Private SQLTrn As SqlClient.SqlTransaction
    Private SQLCmd As New SqlClient.SqlCommand("", SQLCon, SQLTrn)

    'Var Structure
    Public Structure FolderFileInfo
        Dim ID As String
        Dim Found As Boolean
        Dim FileName As String
        Dim FilePath As String
        Dim type As FolderAndFile
    End Structure
    Public FolderFileList(0) As FolderFileInfo
    Public Structure FolderInfo
        Dim FolderID As String
        Dim FolderName As String
        Dim FolderPath As String
        Dim UserID As String
        Dim CreatedIn As String
        Dim Disc As String
        Dim ProID As String
        Dim ParentID As String
        Public Files() As FileInfo
    End Structure
    Public Folders(0) As FolderInfo
    Public Structure FileInfo
        Dim FileID As String
        Dim FileName As String
        Dim FilePath As String
        Dim CreatedIn As String
        Dim UsrID As String
        Dim Dis As String
        Dim ProID As String
        Dim FolderID As String
        Dim TypeID As String
        Dim UserName As String
        Dim TypeName As String
        Dim TypePath As String
    End Structure
    Public Enum FolderAndFile
        Folder
        File
    End Enum
    Public FolderFileType As FolderAndFile
    Public Enum RegKeyValues
        SQLString
        PW
        DataChacked
        ServerIP
        GeneralPort
        DeletedFilesPath
    End Enum
    Public Structure privilegeType
        Dim privilegeName As String
        Dim privilegeID As String
        Dim privilegeSelected As Boolean
        Dim CanWrite As Integer
        Dim CanDelete As Integer
    End Structure
    Public Allprivilege(0) As privilegeType
    Private Structure ListOfFoldersPathType
        Dim FolderID As String
        Dim FolderPath As String
    End Structure
    Private ListOfFoldersPathToChage(0) As ListOfFoldersPathType
    Private Structure ListOfFilesPathType
        Dim FileID As String
        Dim FilePath As String
    End Structure
    Private ListOfFilesPathToChage(0) As ListOfFilesPathType
    Public Structure UsersInfo
        'This type have all information about users
        Dim UserID As String
        Dim UserName As String
        Dim UserPassword As String
    End Structure
    Public Structure FilesType
        Dim TypeID As String
        Dim TypeName As String
        Dim TypeIcon As String
        Dim TypeExt As String
        Dim TypeDesc As String
    End Structure
    Public AllFilesType() As FilesType
    Public Structure ProjectWithprivilegesType
        Dim ProjectID As String
        Dim ProjectName As String
        Dim InternalPrivileges() As privilegeType
    End Structure
    Public AllProjectWithPrivileges() As ProjectWithprivilegesType
    Public Structure UserInfoType
        Dim UsrID As String
        Dim UserName As String
    End Structure
    Public AllUsers() As UserInfoType
    Public Structure ConsultantType
        Dim ConsID As String
        Dim ConsName As String
        Dim ConsAddress As String
        Dim ConsMob1 As String
        Dim ConsMob2 As String
        Dim ConsPho1 As String
        Dim ConsPho2 As String
        Dim ConsEmail1 As String
        Dim ConsEmail2 As String
        Dim ConsCVPath As String
        Dim Selected As String
    End Structure
    Public AllConsultanats() As ConsultantType
    Public Structure ContractorType
        Dim ContID As String
        Dim ContName As String
        Dim ContAddress As String
        Dim ContMob1 As String
        Dim ContMob2 As String
        Dim ContPho1 As String
        Dim ContPho2 As String
        Dim ContEmail1 As String
        Dim ContEmail2 As String
        Dim Selected As String
    End Structure
    Public AllContractors() As ContractorType
    Public Structure ClientType
        Dim ClientID As String
        Dim ClientName As String
        Dim ClientAddress As String
        Dim ClientMob1 As String
        Dim ClientMob2 As String
        Dim ClientPho1 As String
        Dim ClientPho2 As String
        Dim ClientMail1 As String
        Dim ClientMail2 As String
    End Structure
    Public AllClients() As ClientType
    Public Structure LockedFilesSTR
        Dim FileID As String
        Dim FileName As String
        Dim FilePath As String
        Dim ProjectName As String
        Dim UsrID As String
        Dim UsrName As String
    End Structure
    Public Structure ProjectInfo
        Dim ProjectID As String
        Dim PrjectName As String
        Dim ProjectLocation As String
        Dim ProjectStart As String
        Dim projectExp As String
        Dim ProjectEnd As String
        Dim ProjectBudget As String
    End Structure

    'Functions and subs
    Public Sub ServerTest(ByVal ServerName As String, ByVal UserID As String, ByVal UserPW As String, ByRef Done As Boolean)
        Try
            SQLCon.ConnectionString = "Data Source=" & ServerName & ";User ID=" & UserID & ";Password=" & UserPW
            SQLCon.Open()
            Done = True
        Catch ex As Exception
            Done = False
        End Try
        SQLCon.Close()
    End Sub
    Public Overloads Sub AttachDB(ByVal DataPath As String, ByRef Done As Boolean)
        Try
            SQLCmd.CommandText = "EXEC sp_attach_single_file_db @dbname = 'DataCenter', @physname = '" & DataPath & "'"
            SQLCon.Open()
            SQLCmd.ExecuteNonQuery()
            Done = True
        Catch ex As Exception
            Done = False
        End Try
        SQLCon.Close()
    End Sub
    Public Overloads Sub AttachDB(ByVal DataPath As String, ByVal LogPath As String, ByRef Done As Boolean)
        Try
            SQLCmd.CommandText = "EXEC sp_attach_db @dbname = N'DataCenter', @filename1 = N'" & DataPath & "',@filename2 = N'" & LogPath & "'"
            SQLCon.Open()
            SQLCmd.ExecuteNonQuery()
            Done = True
        Catch ex As Exception
            Done = False
        End Try
        SQLCon.Close()
    End Sub
    Public Function GetAllDatabase() As String()
        Dim DatBaseNames(-1) As String
        Try
            SQLCmd.CommandText = "SELECT * FROM master.dbo.sysdatabases"
            SQLCon.Open()
            SQLDR = SQLCmd.ExecuteReader
            Do While SQLDR.Read
                If DatBaseNames.Length = 0 Then
                    ReDim DatBaseNames(0)
                Else
                    ReDim Preserve DatBaseNames(DatBaseNames.Length)
                End If
                DatBaseNames(DatBaseNames.Length - 1) = SQLDR.GetString(0).Trim
            Loop
        Catch ex As Exception
            SQLDR.Close()
            SQLCon.Close()
            Return Nothing
        End Try
        SQLDR.Close()
        SQLCon.Close()
        Return DatBaseNames
    End Function
    Public Function SALogin(ByVal SAName As String, ByVal SAPassword As String) As Boolean
        Try
            SQLCmd.CommandText = "select SAName,SAPassword from SA where SAName='" & SAName & "' and SAPassword='" & SAPassword & "'"
            SQLCon.Open()
            SQLDR = SQLCmd.ExecuteReader
            If SQLDR.HasRows = True Then
                SQLDR.Close()
                SQLCon.Close()
                Return True
            Else
                SQLDR.Close()
                SQLCon.Close()
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        SQLDR.Close()
        SQLCon.Close()
    End Function
    Public Function GetServerOption(ByRef DefaultUserPassword As String, ByRef ProjectsPath As String, ByRef RelatedFiles As String, ByRef DeletedFilesPath As String, ByRef serverIP As String, ByRef serverPort As String) As String
        Try
            SQLCmd.CommandText = "SELECT ProjectsPath,RelatedFiles,DeletedFilesPath,ServerIP,ServerPort,DefaultUserPassword FROM dbo.ServerOption"
            SQLCon.Open()
            SQLDR = SQLCmd.ExecuteReader
            Do While SQLDR.Read
                If SQLDR.IsDBNull(0) = False Then
                    ProjectsPath = SQLDR.GetValue(0).ToString.Trim
                End If
                If SQLDR.IsDBNull(1) = False Then
                    RelatedFiles = SQLDR.GetValue(1).ToString.Trim
                End If
                If SQLDR.IsDBNull(2) = False Then
                    DeletedFilesPath = SQLDR.GetValue(2).ToString.Trim
                End If
                If SQLDR.IsDBNull(3) = False Then
                    serverIP = SQLDR.GetValue(3).ToString.Trim
                End If
                If SQLDR.IsDBNull(4) = False Then
                    serverPort = SQLDR.GetValue(4).ToString.Trim
                End If
                If SQLDR.IsDBNull(5) = False Then
                    DefaultUserPassword = SQLDR.GetValue(5).ToString.Trim
                End If
            Loop
        Catch ex As SqlClient.SqlException
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLDR.Close()
        SQLCon.Close()
        Return Nothing
    End Function
    Public Function SaveServerOptions(ByVal DefaultUserPassword As String, ByVal ProjectsPath As String, ByVal RelatedFiles As String, ByVal DeletedFilesPath As String) As String
        Try
            SQLCmd.CommandText = "UPDATE dbo.ServerOption SET DefaultUserPassword='" & DefaultUserPassword & "',ProjectsPath='" & ProjectsPath & "',RelatedFiles='" & RelatedFiles & "',DeletedFilesPath='" & DeletedFilesPath & "'"
            SQLCon.Open()
            SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLCon.Close()
        Return Nothing
    End Function
    Public Function SaveClientOptions(ByVal ServerIP As String, ByVal ServerPort As String) As String
        Try
            SQLCmd.CommandText = "UPDATE dbo.ServerOption SET ServerIP='" & ServerIP & "',ServerPort='" & ServerPort & "'"
            SQLCon.Open()
            SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLCon.Close()
        Return Nothing
    End Function
    Public Sub GetAllFolderFile(ByVal ProjectPath As String)
        ReDim FolderFileList(0)
        Try
            SQLCmd.CommandText = "select FolderID,FolderName,FolderPath from FolderInfo"
            SQLCon.Open()
            SQLDR = SQLCmd.ExecuteReader
            Do While SQLDR.Read
                FolderFileList(FolderFileList.Length - 1).ID = SQLDR.GetValue(0).ToString.Trim
                FolderFileList(FolderFileList.Length - 1).FileName = SQLDR.GetValue(1).ToString.Trim
                FolderFileList(FolderFileList.Length - 1).FilePath = ProjectPath & SQLDR.GetValue(2).ToString.Trim
                FolderFileList(FolderFileList.Length - 1).type = FolderAndFile.Folder
                ReDim Preserve FolderFileList(FolderFileList.Length)
            Loop
            ReDim Preserve FolderFileList(FolderFileList.Length - 2)
            SQLDR.Close()
            SQLCmd.CommandText = "select FileID,FileName,FilePath from FileInfo"
            SQLDR = SQLCmd.ExecuteReader
            Do While SQLDR.Read
                FolderFileList(FolderFileList.Length - 1).ID = SQLDR.GetValue(0).ToString.Trim
                FolderFileList(FolderFileList.Length - 1).FileName = SQLDR.GetValue(1).ToString.Trim
                FolderFileList(FolderFileList.Length - 1).FilePath = ProjectPath & SQLDR.GetValue(2).ToString.Trim
                FolderFileList(FolderFileList.Length - 1).type = FolderAndFile.File
                ReDim Preserve FolderFileList(FolderFileList.Length)
            Loop
            ReDim Preserve FolderFileList(FolderFileList.Length - 2)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        SQLDR.Close()
        SQLCon.Close()
    End Sub
    Public Sub GetFoldersOrdered_ThenGetFiles(ByVal DataPath As String)
        ReDim Folders(0)
        Try
            SQLCmd.CommandText = "select FolderID,FolderName,FolderPath,UserID,CreatedIn,Disc,ProID,ParentID from dbo.FolderInfo order by FolderPath"
            SQLCon.Open()
            SQLDR = SQLCmd.ExecuteReader
            Do While SQLDR.Read
                Folders(Folders.Length - 1).FolderID = SQLDR.GetValue(0).ToString.Trim
                Folders(Folders.Length - 1).FolderName = SQLDR.GetValue(1).ToString.Trim
                Folders(Folders.Length - 1).FolderPath = DataPath & SQLDR.GetValue(2).ToString.Trim
                Folders(Folders.Length - 1).UserID = SQLDR.GetValue(3).ToString.Trim
                Folders(Folders.Length - 1).CreatedIn = SQLDR.GetValue(4).ToString.Trim
                Folders(Folders.Length - 1).Disc = SQLDR.GetValue(5).ToString.Trim
                Folders(Folders.Length - 1).ProID = SQLDR.GetValue(6).ToString.Trim
                Folders(Folders.Length - 1).ParentID = SQLDR.GetValue(7).ToString.Trim
                ReDim Preserve Folders(Folders.Length)
            Loop
            ReDim Preserve Folders(Folders.Length - 2)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        SQLDR.Close()
        SQLCon.Close()
        GetAllFiles(DataPath)
    End Sub
    Private Sub GetAllFiles(ByVal DataPath As String)
        Try
            SQLCmd.CommandText = "SP_GetAllFiles"
            SQLCon.Open()
            SQLDR = SQLCmd.ExecuteReader
            Dim Int1 As Int16 = 0
            Do While SQLDR.Read
                For Int1 = 0 To Folders.Length - 1
                    If SQLDR.GetValue(7).ToString.Trim = Folders(Int1).FolderID Then
                        If Folders(Int1).Files Is Nothing Then
                            ReDim Folders(Int1).Files(0)
                        Else
                            ReDim Preserve Folders(Int1).Files(Folders(Int1).Files.Length)
                        End If
                        Folders(Int1).Files(Folders(Int1).Files.Length - 1).FileID = SQLDR.GetValue(0).ToString.Trim
                        Folders(Int1).Files(Folders(Int1).Files.Length - 1).FileName = SQLDR.GetValue(1).ToString.Trim
                        'The File Path = DataPath & the Database File Path :)
                        Folders(Int1).Files(Folders(Int1).Files.Length - 1).FilePath = DataPath & SQLDR.GetValue(2).ToString.Trim
                        Folders(Int1).Files(Folders(Int1).Files.Length - 1).CreatedIn = SQLDR.GetValue(3).ToString.Trim
                        Folders(Int1).Files(Folders(Int1).Files.Length - 1).UsrID = SQLDR.GetValue(4).ToString.Trim
                        Folders(Int1).Files(Folders(Int1).Files.Length - 1).Dis = SQLDR.GetValue(5).ToString.Trim
                        Folders(Int1).Files(Folders(Int1).Files.Length - 1).ProID = SQLDR.GetValue(6).ToString.Trim
                        Folders(Int1).Files(Folders(Int1).Files.Length - 1).FolderID = SQLDR.GetValue(7).ToString.Trim
                        Folders(Int1).Files(Folders(Int1).Files.Length - 1).TypeID = SQLDR.GetValue(8).ToString.Trim
                        Folders(Int1).Files(Folders(Int1).Files.Length - 1).UserName = SQLDR.GetValue(9).ToString.Trim
                        Folders(Int1).Files(Folders(Int1).Files.Length - 1).TypeName = SQLDR.GetValue(10).ToString.Trim
                        Folders(Int1).Files(Folders(Int1).Files.Length - 1).TypePath = SQLDR.GetValue(11).ToString.Trim
                        Exit For
                    End If
                Next
                If SQLDR.NextResult() = True Then
                End If
            Loop
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        SQLDR.Close()
        SQLCon.Close()
    End Sub
    Public Sub GetWhoCreateit(ByVal UserID As String, ByRef UserName As String)
        Try
            SQLCmd.CommandText = "select UserName from dbo.Users where UsrID='" & UserID & "'"
            SQLCon.Open()
            UserName = SQLCmd.ExecuteScalar
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            UserName = "Unknow"
        End Try
        SQLCon.Close()
    End Sub
    Public Sub GetProjectName(ByVal ProID As String, ByRef ProjectName As String)
        Try
            SQLCmd.CommandText = "select ProName from dbo.Projects where ProID='" & ProID & "'"
            SQLCon.Open()
            ProjectName = SQLCmd.ExecuteScalar
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            ProjectName = "Unknow"
        End Try
        SQLCon.Close()
    End Sub
    Public Sub GetAllprivilege(ByVal ProjectID As String)
        Try
            ReDim Allprivilege(0)
            SQLCmd.CommandText = "select RullID,RullName from dbo.Rulls where ProID='" & ProjectID & "'"
            SQLCon.Open()
            SQLDR = SQLCmd.ExecuteReader
            Do While SQLDR.Read
                Allprivilege(Allprivilege.Length - 1).privilegeID = SQLDR.GetValue(0).ToString.Trim
                Allprivilege(Allprivilege.Length - 1).privilegeName = SQLDR.GetValue(1).ToString.Trim
                Allprivilege(Allprivilege.Length - 1).privilegeSelected = False
                Allprivilege(Allprivilege.Length - 1).CanDelete = 0
                Allprivilege(Allprivilege.Length - 1).CanWrite = 0
                ReDim Preserve Allprivilege(Allprivilege.Length)
            Loop
            ReDim Preserve Allprivilege(Allprivilege.Length - 2)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        SQLDR.Close()
        SQLCon.Close()
    End Sub
    Public Sub GetSelectedFolderprivilege(ByVal ProjectID As String, ByVal FolderID As String)
        Try
            GetAllprivilege(ProjectID)
            SQLCmd.CommandText = "select RullID,CanWrite,CanDelete from dbo.Folder_Rull where FolderID='" & FolderID & "'"
            SQLCon.Open()
            SQLDR = SQLCmd.ExecuteReader
            Dim RullID As String = ""
            Do While SQLDR.Read
                RullID = SQLDR.GetValue(0).ToString.Trim
                Dim i As Integer = 0
                For i = 0 To Allprivilege.Length - 1
                    If RullID = Allprivilege(i).privilegeID Then
                        Allprivilege(i).privilegeSelected = True
                        Allprivilege(i).CanWrite = SQLDR.GetValue(1).ToString.Trim
                        Allprivilege(i).CanDelete = SQLDR.GetValue(2).ToString.Trim
                        Exit For
                    End If
                Next
            Loop
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        SQLDR.Close()
        SQLCon.Close()
    End Sub
    Public Sub SaveFolderprivileges(ByVal FolderID As String, ByVal privilegesID() As privilegeType, ByVal AddOrRemove As Boolean)
        Try
            SQLCon.Open()
            SQLTrn = SQLCon.BeginTransaction("[Egy]FalseX")
            SQLCmd.Transaction = SQLTrn
            Dim Int1 As Int16
            If AddOrRemove = True Then
                For Int1 = 0 To privilegesID.Length - 1
                    SQLCmd.CommandText = "SP_InsertNewFolderPrivilege @FolderID='" & FolderID & "', @RullID='" & privilegesID(Int1).privilegeID & "', @CanWrite='" & privilegesID(Int1).CanWrite & "', @CanDelete='" & privilegesID(Int1).CanDelete & "'"
                    SQLCmd.ExecuteNonQuery()
                    SQLCmd.CommandText = "SP_InsertNewFolderParentPrivilege @FolderID='" & FolderID & "', @RullID='" & privilegesID(Int1).privilegeID & "'"
                    SQLCmd.ExecuteNonQuery()
                Next
            Else
                For Int1 = 0 To privilegesID.Length - 1
                    'SQLCmd.CommandText = "Delete from dbo.Folder_Rull where FolderID='" & FolderID & "' and RullID='" & privilegesID(Int1).privilegeID & "'"
                    SQLCmd.CommandText = "SP_DeleteFolderPrivilege @FolderID='" & FolderID & "', @RullID='" & privilegesID(Int1).privilegeID & "'"
                    SQLCmd.ExecuteNonQuery()
                Next
            End If
            SQLTrn.Commit()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            SQLTrn.Rollback()
        End Try
        SQLDR.Close()
        SQLCon.Close()
    End Sub
    Public Function SaveFolderDesc(ByVal FolderID As String, ByVal Desc As String) As String
        Try
            SQLCmd.CommandText = "update dbo.FolderInfo set Disc='" & Desc & "' where FolderID='" & FolderID & "'"
            SQLCon.Open()
            SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Return ex.Message
        End Try
        SQLCon.Close()
        Return Nothing
    End Function
    Public Function ChagneFolderName(ByVal FolderIDInStr As String, ByVal FolderName As String, ByVal NewPath As String, ByVal ProjectPath As String) As Boolean
        Dim steps As Int16 = 0
        Try
            ReDim ListOfFoldersPathToChage(0)
            ReDim ListOfFilesPathToChage(0)
            'Get all folders that inside the selected folder to rename therer pathes
            SQLCmd.CommandText = "select FolderID,FolderPath from dbo.FolderInfo where ProID='" & Folders(FolderIDInStr).ProID & "'"
            SQLCon.Open()
            SQLDR = SQLCmd.ExecuteReader
            Dim FullPath As String = Folders(FolderIDInStr).FolderPath
            Dim TwoParts As String = ""
            Do While SQLDR.Read
                TwoParts = ProjectPath & SQLDR.GetValue(1).ToString.Trim
                If TwoParts.Contains(FullPath) Then
                    ListOfFoldersPathToChage(ListOfFoldersPathToChage.Length - 1).FolderID = SQLDR.GetValue(0).ToString.Trim
                    ListOfFoldersPathToChage(ListOfFoldersPathToChage.Length - 1).FolderPath = ProjectPath & SQLDR.GetValue(1).ToString.Trim
                    ReDim Preserve ListOfFoldersPathToChage(ListOfFoldersPathToChage.Length)
                End If
            Loop
            ReDim Preserve ListOfFoldersPathToChage(ListOfFoldersPathToChage.Length - 2)
            SQLDR.Close()
            'Get all files that inside the selected folder to rename therer pathes
            SQLCmd.CommandText = "select FileID,FilePath from dbo.FileInfo where ProID='" & Folders(FolderIDInStr).ProID & "'"
            SQLDR = SQLCmd.ExecuteReader
            Do While SQLDR.Read
                TwoParts = ProjectPath & SQLDR.GetValue(1).ToString.Trim
                If TwoParts.Contains(FullPath) Then
                    ListOfFilesPathToChage(ListOfFilesPathToChage.Length - 1).FileID = SQLDR.GetValue(0).ToString.Trim
                    ListOfFilesPathToChage(ListOfFilesPathToChage.Length - 1).FilePath = ProjectPath & SQLDR.GetValue(1).ToString.Trim
                    ReDim Preserve ListOfFilesPathToChage(ListOfFilesPathToChage.Length)
                End If
            Loop
            ReDim Preserve ListOfFilesPathToChage(ListOfFilesPathToChage.Length - 2)
            SQLDR.Close()
            'Renaming folders
            Dim SqlCmd2 As New SqlClient.SqlCommand("", SQLCon, SQLTrn)
            SQLTrn = SQLCon.BeginTransaction("Eshta ya rgala")
            SqlCmd2.Transaction = SQLTrn
            Dim i As Int16 = 0
            Dim NewPath2 As String
            For i = 0 To ListOfFoldersPathToChage.Length - 1
                NewPath2 = NewPath & ListOfFoldersPathToChage(i).FolderPath.Substring(Folders(FolderIDInStr).FolderPath.Length)
                'MsgBox(NewPath2.Substring(ProjectPath.Length))
                SqlCmd2.CommandText = "Update dbo.FolderInfo set FolderPath='" & NewPath2.Substring(ProjectPath.Length) & "' where FolderID='" & ListOfFoldersPathToChage(i).FolderID & "'"
                SqlCmd2.ExecuteNonQuery()
            Next
            SqlCmd2.CommandText = "update dbo.FolderInfo set FolderName='" & FolderName & "' where FolderID='" & Folders(FolderIDInStr).FolderID & "'"
            SqlCmd2.ExecuteNonQuery()
            'Renaming files
            '''''''''''''''''''''''''''''''''''
            For i = 0 To ListOfFilesPathToChage.Length - 1
                NewPath2 = NewPath & ListOfFilesPathToChage(i).FilePath.Substring(Folders(FolderIDInStr).FolderPath.Length)
                SqlCmd2.CommandText = "Update dbo.FileInfo set FilePath='" & NewPath2.Substring(ProjectPath.Length) & "' where FileID='" & ListOfFilesPathToChage(i).FileID & "'"
                SqlCmd2.ExecuteNonQuery()
            Next
            'Renaming the Phy folder inside the hard disk
            If System.IO.Directory.Exists(Folders(FolderIDInStr).FolderPath) Then
                If Folders(FolderIDInStr).FolderPath <> NewPath Then
                    System.IO.Directory.Move(Folders(FolderIDInStr).FolderPath, NewPath)
                    steps = 1
                End If
                SQLTrn.Commit()
                SQLDR.Close()
                SQLCon.Close()
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            If steps = 1 Then
                Try
                    System.IO.Directory.Move(NewPath, Folders(FolderIDInStr).FolderPath)
                    SQLDR.Close()
                    SQLCon.Close()
                Catch ex2 As Exception
                    MsgBox("Critical problem" & vbNewLine & ex2.Message & "Cant rename\move folder'" & NewPath & "' to folder'" & Folders(FolderIDInStr).FolderPath)
                    SQLTrn.Rollback()
                    SQLDR.Close()
                    SQLCon.Close()
                    Return False
                End Try
            End If
            SQLTrn.Rollback()
            SQLDR.Close()
            SQLCon.Close()
            Return False
        End Try
    End Function
    Public Function AddNewConsultants(ByVal TxtName As String, ByVal TxtAddress As String, ByVal Txtpho1 As String, ByVal TxtPho2 As String, ByVal TxtMob1 As String, ByVal TxtMob2 As String, ByVal TxtMail1 As String, ByVal Txtmail2 As String, ByVal CVPath As String) As String
        Try
            Dim Result As String = ""
            SQLCmd.CommandText = "SP_InsertNewConsultants @ConsName='" & TxtName & "',@ConsAddress='" & TxtAddress & "',@ConsMob1='" & TxtMob1 & "',@ConsMob2='" & TxtMob2 & "',@ConsPho1='" & Txtpho1 & "',@ConsPho2='" & TxtPho2 & "',@ConsEmail1='" & TxtMail1 & "',@ConsEmail2='" & Txtmail2 & "',@ConsCVPath='" & CVPath & "',@Anyway='0'"
            SQLCon.Open()
            Result = SQLCmd.ExecuteScalar
            If Result.Trim = "no" Then
                Dim i As Int16
                i = MsgBox("Consultants Name: " & TxtName & " Already exist" & vbNewLine & "Do you need to save it anyway?", MsgBoxStyle.YesNo, "Same Name...")
                If i = 6 Then
                    SQLCmd.CommandText = "SP_InsertNewConsultants @ConsName='" & TxtName & "',@ConsAddress='" & TxtAddress & "',@ConsMob1='" & TxtMob1 & "',@ConsMob2='" & TxtMob2 & "',@ConsPho1='" & Txtpho1 & "',@ConsPho2='" & TxtPho2 & "',@ConsEmail1='" & TxtMail1 & "',@ConsEmail2='" & Txtmail2 & "',@ConsCVPath='" & CVPath & "',@Anyway='1'"
                    SQLCmd.ExecuteScalar()
                Else
                    SQLDR.Close()
                    SQLCon.Close()
                    Return "no"
                End If
            End If
        Catch ex As Exception
            SQLDR.Close()
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLDR.Close()
        SQLCon.Close()
        Return "yes"
    End Function
    Public Function GetAllFilesType(ByVal RelatedFiles As String) As String
        ReDim AllFilesType(0)
        Try
            SQLCmd.CommandText = "select TypeID,TypeName,TypeIconPath,TypeDic,TypeExt from dbo.FileType"
            SQLCon.Open()
            SQLDR = SQLCmd.ExecuteReader
            Do While SQLDR.Read
                AllFilesType(AllFilesType.Length - 1).TypeID = SQLDR.GetValue(0).ToString.Trim
                AllFilesType(AllFilesType.Length - 1).TypeName = SQLDR.GetValue(1).ToString.Trim
                If SQLDR.GetValue(2).ToString.Trim = "" Then
                    AllFilesType(AllFilesType.Length - 1).TypeIcon = ""
                Else
                    AllFilesType(AllFilesType.Length - 1).TypeIcon = RelatedFiles & SQLDR.GetValue(2).ToString.Trim
                End If
                AllFilesType(AllFilesType.Length - 1).TypeDesc = SQLDR.GetValue(3).ToString.Trim
                AllFilesType(AllFilesType.Length - 1).TypeExt = SQLDR.GetValue(4).ToString.Trim
                ReDim Preserve AllFilesType(AllFilesType.Length)
            Loop
            ReDim Preserve AllFilesType(AllFilesType.Length - 2)
        Catch ex As Exception
            Return ex.Message
        End Try
        SQLDR.Close()
        SQLCon.Close()
        Return Nothing
    End Function
    Public Sub InsertNewFile(ByVal FileName As String, ByVal FilePath As String, ByVal CreatedIn As String, ByVal UsrID As String, ByVal Dis As String, ByVal ProID As String, ByVal FolderID As String, ByVal TypeID As String, ByRef Result As String)
        Try
            SQLCmd.CommandText = "SP_InsertNewFile @FileName='" & FileName & "',@FilePath='" & FilePath & "',@CreatedIn='" & CreatedIn & "',@UsrID='" & UsrID & "',@Dis='" & Dis & "',@ProID='" & ProID & "',@FolderID='" & FolderID & "',@TypeID='" & TypeID & "'"
            SQLCon.Open()
            Result = SQLCmd.ExecuteScalar
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        SQLDR.Close()
        SQLCon.Close()
    End Sub
    Public Function Small_File_Transfer(ByVal SourcePath As String, ByVal TargetPath As String, ByVal Extension As String) As String
        Try
            Dim Int1 As Int16 = 0
            Dim Int2 As Int16 = 0
            Dim FilePathFolders() As String = SourcePath.Split("\")
            Dim NewFileName As String = FilePathFolders(FilePathFolders.Length - 1)
            For Int1 = 0 To 10000
                NewFileName = TargetPath & "\" & FilePathFolders(FilePathFolders.Length - 1) & "_" & Int1 & "." & Extension
                If Not System.IO.File.Exists(NewFileName) Then
                    'Copying File
                    System.IO.File.Copy(SourcePath, NewFileName, True)
                    Return NewFileName
                End If
            Next
        Catch ex As Exception
            Return "Error"
        End Try
        Return ""
    End Function
    Public Function EditFileInfo(ByVal FileID As String, ByVal NewFileName As String, ByVal NewDescription As String) As String
        Try
            SQLCmd.CommandText = "Update dbo.FileInfo set FileName='" & NewFileName & "' , Dis='" & NewDescription & "' where FileID='" & FileID & "'"
            SQLCon.Open()
            SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLCon.Close()
        Return Nothing
    End Function
    Public Function RemoveFile(ByVal FileID As String) As String
        Try
            SQLCmd.CommandText = "delete from FileInfo where FileID='" & FileID & "'"
            SQLCon.Open()
            SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            SQLCon.Close()
            Return (ex.Message)
        End Try
        SQLCon.Close()
        Return Nothing
    End Function
    Public Function InsertNewFolder(ByVal FolderName As String, ByVal FolderPath As String, ByVal CreatedIn As String, ByVal UserID As String, ByVal Disc As String, ByVal ProID As String, ByVal ParentID As String) As String
        Dim ErrorResult As String = Nothing
        Try
            SQLCmd.CommandText = "SP_InsertNewFolder @FolderName='" & FolderName & "',@FolderPath='" & FolderPath & "',@CreatedIn='" & CreatedIn & "',@UserID='" & UserID & "',@Disc='" & Disc & "',@ProID='" & ProID & "',@ParentID='" & ParentID & "'"
            SQLCon.Open()
            ErrorResult = SQLCmd.ExecuteScalar
        Catch
            SQLCon.Close()
            Return Nothing
        End Try
        SQLCon.Close()
        Return ErrorResult
    End Function
    Public Function RemoveFolder(ByVal FolderID As String) As String
        Try
            SQLCon.Open()
            SQLTrn = SQLCon.BeginTransaction("Eshta ya rgala")
            SQLCmd.Transaction = SQLTrn
            SQLCmd.CommandText = "delete from Folder_Rull where FolderID='" & FolderID & "'"
            SQLCmd.ExecuteNonQuery()
            SQLCmd.CommandText = "delete from dbo.folderinfo where folderid='" & FolderID & "'"
            SQLCmd.ExecuteNonQuery()
            SQLTrn.Commit()
        Catch ex As Exception
            SQLTrn.Rollback()
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLCon.Close()
        Return Nothing
    End Function
    Public Function GetAllProjectsPrivileges() As String
        Try
            AllProjectWithPrivileges = Nothing
            SQLCmd.CommandText = "Select ProID,ProName from dbo.Projects Select RullID,RullName,ProID from dbo.Rulls"
            SQLCon.Open()
            SQLDR = SQLCmd.ExecuteReader
            Do While SQLDR.Read
                If AllProjectWithPrivileges Is Nothing Then
                    ReDim AllProjectWithPrivileges(0)
                ElseIf Not AllProjectWithPrivileges(AllProjectWithPrivileges.Length - 1).ProjectID Is Nothing Then
                    ReDim Preserve AllProjectWithPrivileges(AllProjectWithPrivileges.Length)
                End If
                AllProjectWithPrivileges(AllProjectWithPrivileges.Length - 1).ProjectID = SQLDR.GetValue(0).ToString.Trim
                AllProjectWithPrivileges(AllProjectWithPrivileges.Length - 1).ProjectName = SQLDR.GetValue(1).ToString.Trim
            Loop
            Dim Int1 As Int16 = 0
            If SQLDR.NextResult Then
                Do While SQLDR.Read
                    For Int1 = 0 To AllProjectWithPrivileges.Length - 1
                        If SQLDR.GetValue(2).ToString.Trim = AllProjectWithPrivileges(Int1).ProjectID Then
                            If AllProjectWithPrivileges(Int1).InternalPrivileges Is Nothing Then
                                ReDim AllProjectWithPrivileges(Int1).InternalPrivileges(0)
                            ElseIf Not AllProjectWithPrivileges(Int1).InternalPrivileges(AllProjectWithPrivileges(Int1).InternalPrivileges.Length - 1).privilegeID Is Nothing Then
                                ReDim Preserve AllProjectWithPrivileges(Int1).InternalPrivileges(AllProjectWithPrivileges(Int1).InternalPrivileges.Length)
                            End If
                            AllProjectWithPrivileges(Int1).InternalPrivileges(AllProjectWithPrivileges(Int1).InternalPrivileges.Length - 1).privilegeID = SQLDR.GetValue(0).ToString.Trim
                            AllProjectWithPrivileges(Int1).InternalPrivileges(AllProjectWithPrivileges(Int1).InternalPrivileges.Length - 1).privilegeName = SQLDR.GetValue(1).ToString.Trim
                            Exit For
                        End If
                    Next
                Loop
            End If

        Catch ex As Exception
            SQLDR.Close()
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLDR.Close()
        SQLCon.Close()
        Return Nothing
    End Function
    Public Function DeletePrivilege(ByVal PrivID As String) As String
        Try
            SQLCmd.CommandText = "delete from dbo.Rulls where RullID='" & PrivID & "'"
            SQLCon.Open()
            SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLCon.Close()
        Return Nothing
    End Function
    Public Function InsertNewPrivilege(ByVal PrivName As String, ByVal ProID As String) As String
        Dim NewPriID As String = Nothing
        Try
            SQLCmd.CommandText = "SP_InsertNewPrivilege @RullName='" & PrivName & "',@ProID='" & ProID & "'"
            SQLCon.Open()
            NewPriID = SQLCmd.ExecuteScalar
        Catch ex As Exception
            SQLCon.Close()
            Return Nothing
        End Try
        SQLCon.Close()
        Return NewPriID
    End Function
    Public Function UpdatePrivilegeName(ByVal PrivID As String, ByVal PrivNewName As String) As String
        Try
            SQLCmd.CommandText = "Update dbo.Rulls set RullName='" & PrivNewName & "' where RullID='" & PrivID & "'"
            SQLCon.Open()
            SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLCon.Close()
        Return Nothing
    End Function
    Public Function AddUserPrivilege(ByVal UserID As String, ByVal ProID As String, ByVal RullID As String) As String
        Try
            SQLCmd.CommandText = "SP_AddNewPrivilegeToUser @UserID='" & UserID & "' ,@ProID='" & ProID & "' ,@RullID='" & RullID & "'"
            SQLCon.Open()
            SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLCon.Close()
        Return Nothing
    End Function
    Public Function RemoveUserPrivilege(ByVal UserID As String, ByVal ProID As String, ByVal RullID As String) As String
        Try
            SQLCmd.CommandText = "delete from dbo.Users_Rulls where RullID='" & RullID & "' and UsrID='" & UserID & "' and ProID='" & ProID & "'"
            SQLCon.Open()
            SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLCon.Close()
        Return Nothing
    End Function
    Public Function GetAllUsers(ByVal AdminID As String, ByVal Status As Boolean) As String
        AllUsers = Nothing
        Try
            If Status = True Then
                SQLCmd.CommandText = "Select UsrID,UserName,Password from dbo.Users where UsrID <> '" & AdminID & "' and Status='0'"
            Else
                SQLCmd.CommandText = "Select UsrID,UserName,Password from dbo.Users where UsrID <> '" & AdminID & "' and Status='1'"
            End If

            SQLCon.Open()
            SQLDR = SQLCmd.ExecuteReader
            Do While SQLDR.Read
                If AllUsers Is Nothing Then
                    ReDim AllUsers(0)
                Else
                    ReDim Preserve AllUsers(AllUsers.Length)
                End If
                AllUsers(AllUsers.Length - 1).UsrID = SQLDR.GetValue(0).ToString.Trim
                AllUsers(AllUsers.Length - 1).UserName = SQLDR.GetValue(1).ToString.Trim
            Loop
        Catch ex As Exception
            SQLDR.Close()
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLDR.Close()
        SQLCon.Close()
        Return Nothing
    End Function
    Public Function GetUserPrivilege(ByVal UsrID As String, ByVal ProID As String, ByRef PriIDArr() As String) As String
        Try
            SQLCmd.CommandText = "select RullID from dbo.Users_Rulls where ProID='" & ProID & "' and UsrID='" & UsrID & "'"
            SQLCon.Open()
            SQLDR = SQLCmd.ExecuteReader
            Do While SQLDR.Read
                If PriIDArr Is Nothing Then
                    ReDim PriIDArr(0)
                Else
                    ReDim Preserve PriIDArr(PriIDArr.Length)
                End If
                PriIDArr(PriIDArr.Length - 1) = SQLDR.GetValue(0).ToString.Trim
            Loop
        Catch ex As Exception
            SQLDR.Close()
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLDR.Close()
        SQLCon.Close()
        Return Nothing
    End Function
    Public Function AddUser(ByVal Username As String) As String
        Dim ErrorProvider As String
        Try
            SQLCmd.CommandText = "SP_InsertNewUser @UserName='" & Username & "'"
            SQLCon.Open()
            ErrorProvider = SQLCmd.ExecuteScalar()
        Catch ex As Exception
            SQLCon.Close()
            Return "UserName In Used"
        End Try
        SQLCon.Close()
        Return ErrorProvider
    End Function
    Public Function UpdateUserameOrPassword(ByVal UsrID As String, ByVal NewText As String, ByVal Username_True_Password_False As Boolean) As String
        Try
            If Username_True_Password_False = True Then
                'Upate UserName
                SQLCmd.CommandText = "Update dbo.Users set UserName='" & NewText & "' where UsrID='" & UsrID & "'"
            Else
                'Upate Password
                SQLCmd.CommandText = "Update dbo.Users set Password='" & NewText & "' where UsrID='" & UsrID & "'"
            End If
            SQLCon.Open()
            SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLCon.Close()
        Return Nothing
    End Function
    Public Function UserActivation(ByVal UsrID As String, ByVal Status As Boolean)
        Try
            If Status = True Then
                SQLCmd.CommandText = "Update dbo.Users set Status='0' where UsrID='" & UsrID & "'"
            Else
                SQLCmd.CommandText = "Update dbo.Users set Status='1' where UsrID='" & UsrID & "'"
            End If
            SQLCon.Open()
            SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLCon.Close()
        Return Nothing
    End Function
    Public Function GetAllConsultants(ByVal RelatedFiles As String, ByVal Status As Boolean) As String
        AllConsultanats = Nothing
        Try
            If Status = True Then
                SQLCmd.CommandText = "Select ConsID,ConsName,ConsAddress,ConsMob1,ConsMob2,ConsPho1,ConsPho2,ConsEmail1,ConsEmail2,ConsCVPath from dbo.Consultants where Deleted='0'"
            Else
                SQLCmd.CommandText = "Select ConsID,ConsName,ConsAddress,ConsMob1,ConsMob2,ConsPho1,ConsPho2,ConsEmail1,ConsEmail2,ConsCVPath from dbo.Consultants where Deleted='1'"
            End If
            SQLCon.Open()
            SQLDR = SQLCmd.ExecuteReader
            Do While SQLDR.Read
                If AllConsultanats Is Nothing Then
                    ReDim AllConsultanats(0)
                Else
                    ReDim Preserve AllConsultanats(AllConsultanats.Length)
                End If
                AllConsultanats(AllConsultanats.Length - 1).ConsID = SQLDR.GetValue(0).ToString.Trim
                AllConsultanats(AllConsultanats.Length - 1).ConsName = SQLDR.GetValue(1).ToString.Trim
                AllConsultanats(AllConsultanats.Length - 1).ConsAddress = SQLDR.GetValue(2).ToString.Trim
                AllConsultanats(AllConsultanats.Length - 1).ConsMob1 = SQLDR.GetValue(3).ToString.Trim
                AllConsultanats(AllConsultanats.Length - 1).ConsMob2 = SQLDR.GetValue(4).ToString.Trim
                AllConsultanats(AllConsultanats.Length - 1).ConsPho1 = SQLDR.GetValue(5).ToString.Trim
                AllConsultanats(AllConsultanats.Length - 1).ConsPho2 = SQLDR.GetValue(6).ToString.Trim
                AllConsultanats(AllConsultanats.Length - 1).ConsEmail1 = SQLDR.GetValue(7).ToString.Trim
                AllConsultanats(AllConsultanats.Length - 1).ConsEmail2 = SQLDR.GetValue(8).ToString.Trim
                If SQLDR.IsDBNull(9) Or SQLDR.GetValue(9).ToString.Trim = "" Then
                    AllConsultanats(AllConsultanats.Length - 1).ConsCVPath = ""
                Else
                    AllConsultanats(AllConsultanats.Length - 1).ConsCVPath = RelatedFiles & SQLDR.GetValue(9).ToString.Trim
                End If
            Loop
        Catch ex As Exception
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLCon.Close()
        Return Nothing
    End Function
    Public Sub GetProjectConsultants(ByVal ProjectID As String)
        Dim CosID(0) As String
        Try
            SQLCmd.CommandText = "Select PrCo,ConsID from dbo.Project_Consultants where ProID='" & ProjectID & "'"
            SQLCon.Open()
            SQLDR = SQLCmd.ExecuteReader
            Dim int1 As Int16
            Do While SQLDR.Read
                CosID(CosID.Length - 1) = SQLDR.GetString(0).Trim
                ReDim Preserve CosID(CosID.Length)
                For int1 = 0 To AllConsultanats.Length - 1
                    If SQLDR.GetString(1).Trim = AllConsultanats(int1).ConsID Then
                        AllConsultanats(int1).Selected = 1
                        Exit For
                    End If
                Next
            Loop
            ReDim Preserve CosID(CosID.Length - 2)
        Catch : End Try
        SQLDR.Close()
        SQLCon.Close()
    End Sub
    Public Sub GetProjectContractors(ByVal ProjectID As String)
        Dim CosID(0) As String
        Try
            SQLCmd.CommandText = "Select PrCo,ContID from dbo.Project_Contractors where ProID='" & ProjectID & "'"
            SQLCon.Open()
            SQLDR = SQLCmd.ExecuteReader
            Dim int1 As Int16
            Do While SQLDR.Read
                CosID(CosID.Length - 1) = SQLDR.GetString(0).Trim
                ReDim Preserve CosID(CosID.Length)
                For int1 = 0 To AllContractors.Length - 1
                    If SQLDR.GetString(1).Trim = AllContractors(int1).ContID Then
                        AllContractors(int1).Selected = 1
                        Exit For
                    End If
                Next
            Loop
            ReDim Preserve CosID(CosID.Length - 2)
        Catch : End Try
        SQLDR.Close()
        SQLCon.Close()
    End Sub
    Public Function AddConsultantToProject(ByVal ProjectID As String, ByVal ConsultantID As String) As String
        Try
            SQLCmd.CommandText = "SP_AddNewConsultantsToProject @ProID='" & ProjectID & "',@ConsID='" & ConsultantID & "'"
            SQLCon.Open()
            SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLCon.Close()
        Return Nothing
    End Function
    Public Function RemoveConsultantFromProject(ByVal ProjectID As String, ByVal ConsultantID As String) As String
        Try
            SQLCmd.CommandText = "Delete from dbo.Project_Consultants where ProID='" & ProjectID & "' and ConsID='" & ConsultantID & "'"
            SQLCon.Open()
            SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLCon.Close()
        Return Nothing
    End Function
    Public Function AddContractorToProject(ByVal ProjectID As String, ByVal ConsultantID As String) As String
        Try
            SQLCmd.CommandText = "SP_AddNewContractorsToProject @ProID='" & ProjectID & "',@ContID='" & ConsultantID & "'"
            SQLCon.Open()
            SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLCon.Close()
        Return Nothing
    End Function
    Public Function RemoveContractorFromProject(ByVal ProjectID As String, ByVal ContractorID As String) As String
        Try
            SQLCmd.CommandText = "Delete from dbo.Project_Contractors where ProID='" & ProjectID & "' and ContID='" & ContractorID & "'"
            SQLCon.Open()
            SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLCon.Close()
        Return Nothing
    End Function
    Public Function GetAllContractors(ByVal Status As Boolean) As String
        AllContractors = Nothing
        Try
            If Status = True Then
                SQLCmd.CommandText = "Select ContID,ContName,ContAddress,ContMob1,ContMob2,ContPho1,ContPho2,ContMail1,ContMail2 from dbo.Contractors Where Deleted='0'"
            Else
                SQLCmd.CommandText = "Select ContID,ContName,ContAddress,ContMob1,ContMob2,ContPho1,ContPho2,ContMail1,ContMail2 from dbo.Contractors Where Deleted='1'"
            End If
            SQLCon.Open()
            SQLDR = SQLCmd.ExecuteReader
            Do While SQLDR.Read
                If AllContractors Is Nothing Then
                    ReDim AllContractors(0)
                Else
                    ReDim Preserve AllContractors(AllContractors.Length)
                End If
                AllContractors(AllContractors.Length - 1).ContID = SQLDR.GetValue(0).ToString.Trim
                AllContractors(AllContractors.Length - 1).ContName = SQLDR.GetValue(1).ToString.Trim
                AllContractors(AllContractors.Length - 1).ContAddress = SQLDR.GetValue(2).ToString.Trim
                AllContractors(AllContractors.Length - 1).ContMob1 = SQLDR.GetValue(3).ToString.Trim
                AllContractors(AllContractors.Length - 1).ContMob2 = SQLDR.GetValue(4).ToString.Trim
                AllContractors(AllContractors.Length - 1).ContPho1 = SQLDR.GetValue(5).ToString.Trim
                AllContractors(AllContractors.Length - 1).ContPho2 = SQLDR.GetValue(6).ToString.Trim
                AllContractors(AllContractors.Length - 1).ContEmail1 = SQLDR.GetValue(7).ToString.Trim
                AllContractors(AllContractors.Length - 1).ContEmail2 = SQLDR.GetValue(8).ToString.Trim
            Loop
        Catch ex As Exception
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLCon.Close()
        Return Nothing
    End Function
    Public Function GetAllClients(ByVal Status As Boolean) As String
        AllClients = Nothing
        Try
            If Status = True Then
                SQLCmd.CommandText = "Select ClientID,ClientName,ClientAddress,ClientMob1,ClientMob2,ClientPho1,ClientPho2,ClientMail1,ClientMail2 from dbo.Client Where Deleted='0'"
            Else
                SQLCmd.CommandText = "Select ClientID,ClientName,ClientAddress,ClientMob1,ClientMob2,ClientPho1,ClientPho2,ClientMail1,ClientMail2 from dbo.Client Where Deleted='1'"
            End If
            SQLCon.Open()
            SQLDR = SQLCmd.ExecuteReader
            Do While SQLDR.Read
                If AllClients Is Nothing Then
                    ReDim AllClients(0)
                Else
                    ReDim Preserve AllClients(AllClients.Length)
                End If
                AllClients(AllClients.Length - 1).ClientID = SQLDR.GetValue(0).ToString.Trim
                AllClients(AllClients.Length - 1).ClientName = SQLDR.GetValue(1).ToString.Trim
                AllClients(AllClients.Length - 1).ClientAddress = SQLDR.GetValue(2).ToString.Trim
                AllClients(AllClients.Length - 1).ClientMob1 = SQLDR.GetValue(3).ToString.Trim
                AllClients(AllClients.Length - 1).ClientMob2 = SQLDR.GetValue(4).ToString.Trim
                AllClients(AllClients.Length - 1).ClientPho1 = SQLDR.GetValue(5).ToString.Trim
                AllClients(AllClients.Length - 1).ClientPho2 = SQLDR.GetValue(6).ToString.Trim
                AllClients(AllClients.Length - 1).ClientMail1 = SQLDR.GetValue(7).ToString.Trim
                AllClients(AllClients.Length - 1).ClientMail2 = SQLDR.GetValue(8).ToString.Trim
            Loop
        Catch ex As Exception
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLCon.Close()
        Return Nothing
    End Function
    Public Function UpdateConsultants(ByVal RelatedFiles As String, ByVal ID As String, ByVal Name As String, ByVal Address As String, ByVal Mob1 As String, ByVal Mob2 As String, ByVal Phon1 As String, ByVal Phon2 As String, ByVal Mail1 As String, ByVal Mail2 As String, ByVal CV As String) As String
        Try
            If RelatedFiles = Nothing Then
                SQLCmd.CommandText = "Update dbo.Consultants Set ConsName='" & Name & "',ConsAddress='" & Address & "',ConsMob1='" & Mob1 & "',ConsMob2='" & Mob2 & "',ConsPho1='" & Phon1 & "',ConsPho2='" & Phon2 & "',ConsEmail1='" & Mail1 & "',ConsEmail2='" & Mail2 & "',ConsCVPath='' where ConsID='" & ID & "'"
            Else
                SQLCmd.CommandText = "Update dbo.Consultants Set ConsName='" & Name & "',ConsAddress='" & Address & "',ConsMob1='" & Mob1 & "',ConsMob2='" & Mob2 & "',ConsPho1='" & Phon1 & "',ConsPho2='" & Phon2 & "',ConsEmail1='" & Mail1 & "',ConsEmail2='" & Mail2 & "',ConsCVPath='" & CV.Substring(RelatedFiles.Length) & "' where ConsID='" & ID & "'"
            End If
            SQLCon.Open()
            SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLCon.Close()
        Return Nothing
    End Function
    Public Function UpdateContractors(ByVal ID As String, ByVal Name As String, ByVal Address As String, ByVal Mob1 As String, ByVal Mob2 As String, ByVal Phon1 As String, ByVal Phon2 As String, ByVal Mail1 As String, ByVal Mail2 As String) As String
        Try
            SQLCmd.CommandText = "Update dbo.Contractors Set ContName='" & Name & "',ContAddress='" & Address & "',ContMob1='" & Mob1 & "',ContMob2='" & Mob2 & "',ContPho1='" & Phon1 & "',ContPho2='" & Phon2 & "',ContMail1='" & Mail1 & "',ContMail2='" & Mail2 & "' where ContID='" & ID & "'"
            SQLCon.Open()
            SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLCon.Close()
        Return Nothing
    End Function
    Public Function UpdateClients(ByVal ID As String, ByVal Name As String, ByVal Address As String, ByVal Mob1 As String, ByVal Mob2 As String, ByVal Phon1 As String, ByVal Phon2 As String, ByVal Mail1 As String, ByVal Mail2 As String) As String
        Try
            SQLCmd.CommandText = "Update dbo.Client Set ClientName='" & Name & "',ClientAddress='" & Address & "',ClientMob1='" & Mob1 & "',ClientMob2='" & Mob2 & "',ClientPho1='" & Phon1 & "',ClientPho2='" & Phon2 & "',ClientMail1='" & Mail1 & "',ClientMail2='" & Mail2 & "' where ClientID='" & ID & "'"
            SQLCon.Open()
            SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLCon.Close()
        Return Nothing
    End Function
    Public Function DisactivateConsultants(ByVal ID As String, ByVal Status As Boolean) As String
        Try
            If Status = False Then
                SQLCmd.CommandText = "Update dbo.Consultants Set Deleted='1' where ConsID='" & ID & "'"
            Else
                SQLCmd.CommandText = "Update dbo.Consultants Set Deleted='0' where ConsID='" & ID & "'"
            End If
            SQLCon.Open()
            SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLCon.Close()
        Return Nothing
    End Function
    Public Function DisactivateContractors(ByVal ID As String, ByVal Status As Boolean) As String
        Try
            If Status = False Then
                SQLCmd.CommandText = "Update dbo.Contractors Set Deleted='1' where ContID='" & ID & "'"
            Else
                SQLCmd.CommandText = "Update dbo.Contractors Set Deleted='0' where ContID='" & ID & "'"
            End If
            SQLCon.Open()
            SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLCon.Close()
        Return Nothing
    End Function
    Public Function DisactivateClients(ByVal ID As String, ByVal Status As Boolean) As String
        Try
            If Status = False Then
                SQLCmd.CommandText = "Update dbo.Client Set Deleted='1' where ClientID='" & ID & "'"
            Else
                SQLCmd.CommandText = "Update dbo.Client Set Deleted='0' where ClientID='" & ID & "'"
            End If
            SQLCon.Open()
            SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLCon.Close()
        Return Nothing
    End Function
    Public Function DeleteUser(ByVal UsrID As String) As String
        Dim ErrorProvider As String = Nothing
        Try
            SQLCmd.CommandText = "SP_DeleteUser @USRID='" & UsrID & "'"
            SQLCon.Open()
            ErrorProvider = SQLCmd.ExecuteScalar
        Catch ex As Exception
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLCon.Close()
        Return ErrorProvider
    End Function
    Public Function DeleteContractors(ByVal ContID As String) As String
        Dim ErrorProvider As String = Nothing
        Try
            SQLCmd.CommandText = "SP_DeleteContractor @ContID='" & ContID & "'"
            SQLCon.Open()
            ErrorProvider = SQLCmd.ExecuteScalar
        Catch ex As Exception
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLCon.Close()
        Return ErrorProvider
    End Function
    Public Function DeleteConsultants(ByVal ConsID As String) As String
        Dim ErrorProvider As String = Nothing
        Try
            SQLCmd.CommandText = "SP_DeleteConsultant @ConsID='" & ConsID & "'"
            SQLCon.Open()
            ErrorProvider = SQLCmd.ExecuteScalar
        Catch ex As Exception
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLCon.Close()
        Return ErrorProvider
    End Function
    Public Function DeleteClients(ByVal ClientID As String) As String
        Dim ErrorProvider As String = Nothing
        Try
            SQLCmd.CommandText = "SP_DeleteClient @ClientID='" & ClientID & "'"
            SQLCon.Open()
            ErrorProvider = SQLCmd.ExecuteScalar
        Catch ex As Exception
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLCon.Close()
        Return ErrorProvider
    End Function
    Public Function AddNewClient(ByVal ClientName As String, ByVal ClientAddress As String, ByVal ClientMob1 As String, ByVal ClientMob2 As String, ByVal ClientPho1 As String, ByVal ClientPho2 As String, ByVal ClientMail1 As String, ByVal ClientMail2 As String) As String
        Dim ErrorProvider As String = Nothing
        Try
            SQLCmd.CommandText = "SP_InsertNewClient @ClientName='" & ClientName & "',@ClientAddress='" & ClientAddress & "',@ClientMob1='" & ClientMob1 & "',@ClientMob2='" & ClientMob2 & "',@ClientPho1='" & ClientPho1 & "',@ClientPho2='" & ClientPho2 & "',@ClientMail1='" & ClientMail1 & "',@ClientMail2='" & ClientMail2 & "'"
            SQLCon.Open()
            ErrorProvider = SQLCmd.ExecuteScalar
        Catch ex As Exception
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLCon.Close()
        Return ErrorProvider
    End Function
    Public Function AddNewContractor(ByVal ContName As String, ByVal ContAddress As String, ByVal ContMob1 As String, ByVal ContMob2 As String, ByVal ContPho1 As String, ByVal ContPho2 As String, ByVal ContMail1 As String, ByVal ContMail2 As String) As String
        Dim ErrorProvider As String = Nothing
        Try
            SQLCmd.CommandText = "SP_InsertNewContractor @ContName='" & ContName & "',@ContAddress='" & ContAddress & "',@ContMob1='" & ContMob1 & "',@ContMob2='" & ContMob2 & "',@ContPho1='" & ContPho1 & "',@ContPho2='" & ContPho2 & "',@ContMail1='" & ContMail1 & "',@ContMail2='" & ContMail2 & "'"
            SQLCon.Open()
            ErrorProvider = SQLCmd.ExecuteScalar
        Catch ex As Exception
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLCon.Close()
        Return ErrorProvider
    End Function
    Public Function AddNewProject(ByVal ProName As String, ByVal ProLocation As String, ByVal Startat As String, ByVal ExpEndat As String, ByVal AdminID As String, ByVal ProjectsPath As String, ByRef PogressBarValue As Int16) As String
        '543 Line for this sutpid funtion :(
        Dim NewFID As String = Nothing
        Dim LVL1 As String = Nothing
        Dim LVL2 As String = Nothing
        Dim LVL3 As String = Nothing
        Dim LVL4 As String = Nothing
        Dim ProID As String = Nothing
        Try
            SQLCon.Open()
            PogressBarValue += 1
            'Add Project
            SQLCmd.CommandText = "SP_AddNewProject @ProName='" & ProName & "',@ProLocation='" & ProLocation & "',@Startat='" & Startat & "',@ExpEndat='" & ExpEndat & "'"
            ProID = SQLCmd.ExecuteScalar
            If ProID = "NO" Then
                SQLCon.Close()
                Return "Can't Add New Project"
            End If
            NewFID = FindNewFolderID()
            If NewFID = "NO" Then
                SQLCon.Close()
                Return "Can't Add Site View"
            End If
            SQLCmd.CommandText = "INSERT INTO dbo.FolderInfo (FolderID,FolderName,FolderPath,CreatedIn,UserID,ProID,ParentID) VALUES ('" & NewFID & "','" & ProName & "','" & ProName & "','" & Now.Date & "','" & AdminID & "','" & ProID & "','0')"
            SQLCmd.ExecuteNonQuery()
            If Not Directory.Exists(ProjectsPath & ProName) Then
                Directory.CreateDirectory(ProjectsPath & ProName)
            End If
            LVL1 = NewFID
            PogressBarValue += 1
            'Site View
            NewFID = FindNewFolderID()
            If NewFID = "NO" Then
                SQLCon.Close()
                Return "Can't Add Site View"
            End If
            SQLCmd.CommandText = "INSERT INTO dbo.FolderInfo (FolderID,FolderName,FolderPath,CreatedIn,UserID,ProID,ParentID) VALUES ('" & NewFID & "','Site View','" & ProName & "\Site View" & "','" & Now.Date & "','" & AdminID & "','" & ProID & "','" & LVL1 & "')"
            SQLCmd.ExecuteNonQuery()
            If Not Directory.Exists(ProjectsPath & ProName & "\Site View") Then
                Directory.CreateDirectory(ProjectsPath & ProName & "\Site View")
            End If
            LVL2 = NewFID
            PogressBarValue += 1
            'Photos
            NewFID = FindNewFolderID()
            If NewFID = "NO" Then
                SQLCon.Close()
                Return "Can't Add Photos"
            End If
            SQLCmd.CommandText = "INSERT INTO dbo.FolderInfo (FolderID,FolderName,FolderPath,CreatedIn,UserID,ProID,ParentID) VALUES ('" & NewFID & "','Photos','" & ProName & "\Site View\Photos" & "','" & Now.Date & "','" & AdminID & "','" & ProID & "','" & LVL2 & "')"
            SQLCmd.ExecuteNonQuery()
            If Not Directory.Exists(ProjectsPath & ProName & "\Site View\Photos") Then
                Directory.CreateDirectory(ProjectsPath & ProName & "\Site View\Photos")
            End If
            PogressBarValue += 1
            'Maps
            NewFID = FindNewFolderID()
            If NewFID = "NO" Then
                SQLCon.Close()
                Return "Can't Add Maps"
            End If
            SQLCmd.CommandText = "INSERT INTO dbo.FolderInfo (FolderID,FolderName,FolderPath,CreatedIn,UserID,ProID,ParentID) VALUES ('" & NewFID & "','Maps','" & ProName & "\Site View\Maps" & "','" & Now.Date & "','" & AdminID & "','" & ProID & "','" & LVL2 & "')"
            SQLCmd.ExecuteNonQuery()
            If Not Directory.Exists(ProjectsPath & ProName & "\Site View\Maps") Then
                Directory.CreateDirectory(ProjectsPath & ProName & "\Site View\Maps")
            End If
            LVL3 = NewFID
            PogressBarValue += 1
            'AutoCAD
            NewFID = FindNewFolderID()
            If NewFID = "NO" Then
                SQLCon.Close()
                Return "Can't Add AutoCAD"
            End If
            SQLCmd.CommandText = "INSERT INTO dbo.FolderInfo (FolderID,FolderName,FolderPath,CreatedIn,UserID,ProID,ParentID) VALUES ('" & NewFID & "','AutoCAD','" & ProName & "\Site View\Maps\AutoCAD" & "','" & Now.Date & "','" & AdminID & "','" & ProID & "','" & LVL3 & "')"
            SQLCmd.ExecuteNonQuery()
            If Not Directory.Exists(ProjectsPath & ProName & "\Site View\Maps\AutoCAD") Then
                Directory.CreateDirectory(ProjectsPath & ProName & "\Site View\Maps\AutoCAD")
            End If
            PogressBarValue += 1
            'JPG
            NewFID = FindNewFolderID()
            If NewFID = "NO" Then
                SQLCon.Close()
                Return "Can't Add JPG"
            End If
            SQLCmd.CommandText = "INSERT INTO dbo.FolderInfo (FolderID,FolderName,FolderPath,CreatedIn,UserID,ProID,ParentID) VALUES ('" & NewFID & "','JPG','" & ProName & "\Site View\Maps\JPG" & "','" & Now.Date & "','" & AdminID & "','" & ProID & "','" & LVL3 & "')"
            SQLCmd.ExecuteNonQuery()
            If Not Directory.Exists(ProjectsPath & ProName & "\Site View\Maps\JPG") Then
                Directory.CreateDirectory(ProjectsPath & ProName & "\Site View\Maps\JPG")
            End If
            PogressBarValue += 1
            'Reports
            NewFID = FindNewFolderID()
            If NewFID = "NO" Then
                SQLCon.Close()
                Return "Can't Add Reports"
            End If
            SQLCmd.CommandText = "INSERT INTO dbo.FolderInfo (FolderID,FolderName,FolderPath,CreatedIn,UserID,ProID,ParentID) VALUES ('" & NewFID & "','Reports','" & ProName & "\Site View\Reports" & "','" & Now.Date & "','" & AdminID & "','" & ProID & "','" & LVL2 & "')"
            SQLCmd.ExecuteNonQuery()
            If Not Directory.Exists(ProjectsPath & ProName & "\Site View\Reports") Then
                Directory.CreateDirectory(ProjectsPath & ProName & "\Site View\Reports")
            End If
            PogressBarValue += 1
            'Survey
            NewFID = FindNewFolderID()
            If NewFID = "NO" Then
                SQLCon.Close()
                Return "Can't Add Survey"
            End If
            SQLCmd.CommandText = "INSERT INTO dbo.FolderInfo (FolderID,FolderName,FolderPath,CreatedIn,UserID,ProID,ParentID) VALUES ('" & NewFID & "','Survey','" & ProName & "\Site View\Survey" & "','" & Now.Date & "','" & AdminID & "','" & ProID & "','" & LVL2 & "')"
            SQLCmd.ExecuteNonQuery()
            If Not Directory.Exists(ProjectsPath & ProName & "\Site View\Survey") Then
                Directory.CreateDirectory(ProjectsPath & ProName & "\Site View\Survey")
            End If
            LVL3 = NewFID
            PogressBarValue += 1
            'Photos
            NewFID = FindNewFolderID()
            If NewFID = "NO" Then
                SQLCon.Close()
                Return "Can't Add Photos"
            End If
            SQLCmd.CommandText = "INSERT INTO dbo.FolderInfo (FolderID,FolderName,FolderPath,CreatedIn,UserID,ProID,ParentID) VALUES ('" & NewFID & "','Photos','" & ProName & "\Site View\Survey\Photos" & "','" & Now.Date & "','" & AdminID & "','" & ProID & "','" & LVL3 & "')"
            SQLCmd.ExecuteNonQuery()
            If Not Directory.Exists(ProjectsPath & ProName & "\Site View\Survey\Photos") Then
                Directory.CreateDirectory(ProjectsPath & ProName & "\Site View\Survey\Photos")
            End If
            PogressBarValue += 1
            'Maps
            NewFID = FindNewFolderID()
            If NewFID = "NO" Then
                SQLCon.Close()
                Return "Can't Add Maps"
            End If
            SQLCmd.CommandText = "INSERT INTO dbo.FolderInfo (FolderID,FolderName,FolderPath,CreatedIn,UserID,ProID,ParentID) VALUES ('" & NewFID & "','Maps','" & ProName & "\Site View\Survey\Maps" & "','" & Now.Date & "','" & AdminID & "','" & ProID & "','" & LVL3 & "')"
            SQLCmd.ExecuteNonQuery()
            If Not Directory.Exists(ProjectsPath & ProName & "\Site View\Survey\Maps") Then
                Directory.CreateDirectory(ProjectsPath & ProName & "\Site View\Survey\Maps")
            End If
            PogressBarValue += 1
            'Drawings
            NewFID = FindNewFolderID()
            If NewFID = "NO" Then
                SQLCon.Close()
                Return "Can't Add Drawings"
            End If
            SQLCmd.CommandText = "INSERT INTO dbo.FolderInfo (FolderID,FolderName,FolderPath,CreatedIn,UserID,ProID,ParentID) VALUES ('" & NewFID & "','Drawings','" & ProName & "\Site View\Survey\Drawings" & "','" & Now.Date & "','" & AdminID & "','" & ProID & "','" & LVL3 & "')"
            SQLCmd.ExecuteNonQuery()
            If Not Directory.Exists(ProjectsPath & ProName & "\Site View\Survey\Drawings") Then
                Directory.CreateDirectory(ProjectsPath & ProName & "\Site View\Survey\Drawings")
            End If
            PogressBarValue += 1
            'Reports
            NewFID = FindNewFolderID()
            If NewFID = "NO" Then
                SQLCon.Close()
                Return "Can't Add Reports"
            End If
            SQLCmd.CommandText = "INSERT INTO dbo.FolderInfo (FolderID,FolderName,FolderPath,CreatedIn,UserID,ProID,ParentID) VALUES ('" & NewFID & "','Reports','" & ProName & "\Site View\Survey\Reports" & "','" & Now.Date & "','" & AdminID & "','" & ProID & "','" & LVL3 & "')"
            SQLCmd.ExecuteNonQuery()
            If Not Directory.Exists(ProjectsPath & ProName & "\Site View\Survey\Reports") Then
                Directory.CreateDirectory(ProjectsPath & ProName & "\Site View\Survey\Reports")
            End If
            PogressBarValue += 1
            'Development
            NewFID = FindNewFolderID()
            If NewFID = "NO" Then
                SQLCon.Close()
                Return "Can't Add Development"
            End If
            SQLCmd.CommandText = "INSERT INTO dbo.FolderInfo (FolderID,FolderName,FolderPath,CreatedIn,UserID,ProID,ParentID) VALUES ('" & NewFID & "','Development','" & ProName & "\Development" & "','" & Now.Date & "','" & AdminID & "','" & ProID & "','" & LVL1 & "')"
            SQLCmd.ExecuteNonQuery()
            If Not Directory.Exists(ProjectsPath & ProName & "\Development") Then
                Directory.CreateDirectory(ProjectsPath & ProName & "\Development")
            End If
            PogressBarValue += 1
            'Lisences
            NewFID = FindNewFolderID()
            If NewFID = "NO" Then
                SQLCon.Close()
                Return "Can't Add Lisences"
            End If
            SQLCmd.CommandText = "INSERT INTO dbo.FolderInfo (FolderID,FolderName,FolderPath,CreatedIn,UserID,ProID,ParentID) VALUES ('" & NewFID & "','Lisences','" & ProName & "\Lisences" & "','" & Now.Date & "','" & AdminID & "','" & ProID & "','" & LVL1 & "')"
            SQLCmd.ExecuteNonQuery()
            If Not Directory.Exists(ProjectsPath & ProName & "\Lisences") Then
                Directory.CreateDirectory(ProjectsPath & ProName & "\Lisences")
            End If
            LVL2 = NewFID
            PogressBarValue += 1
            'Drawings
            NewFID = FindNewFolderID()
            If NewFID = "NO" Then
                SQLCon.Close()
                Return "Can't Add Drawings"
            End If
            SQLCmd.CommandText = "INSERT INTO dbo.FolderInfo (FolderID,FolderName,FolderPath,CreatedIn,UserID,ProID,ParentID) VALUES ('" & NewFID & "','Drawings','" & ProName & "\Lisences\Drawings" & "','" & Now.Date & "','" & AdminID & "','" & ProID & "','" & LVL2 & "')"
            SQLCmd.ExecuteNonQuery()
            If Not Directory.Exists(ProjectsPath & ProName & "\Lisences\Drawings") Then
                Directory.CreateDirectory(ProjectsPath & ProName & "\Lisences\Drawings")
            End If
            LVL3 = NewFID
            PogressBarValue += 1
            'AutoCAD
            NewFID = FindNewFolderID()
            If NewFID = "NO" Then
                SQLCon.Close()
                Return "Can't Add AutoCAD"
            End If
            SQLCmd.CommandText = "INSERT INTO dbo.FolderInfo (FolderID,FolderName,FolderPath,CreatedIn,UserID,ProID,ParentID) VALUES ('" & NewFID & "','AutoCAD','" & ProName & "\Lisences\Drawings\AutoCAD" & "','" & Now.Date & "','" & AdminID & "','" & ProID & "','" & LVL3 & "')"
            SQLCmd.ExecuteNonQuery()
            If Not Directory.Exists(ProjectsPath & ProName & "\Lisences\Drawings\AutoCAD") Then
                Directory.CreateDirectory(ProjectsPath & ProName & "\Lisences\Drawings\AutoCAD")
            End If
            PogressBarValue += 1
            'JPG
            NewFID = FindNewFolderID()
            If NewFID = "NO" Then
                SQLCon.Close()
                Return "Can't Add JPG"
            End If
            SQLCmd.CommandText = "INSERT INTO dbo.FolderInfo (FolderID,FolderName,FolderPath,CreatedIn,UserID,ProID,ParentID) VALUES ('" & NewFID & "','JPG','" & ProName & "\Lisences\Drawings\JPG" & "','" & Now.Date & "','" & AdminID & "','" & ProID & "','" & LVL3 & "')"
            SQLCmd.ExecuteNonQuery()
            If Not Directory.Exists(ProjectsPath & ProName & "\Lisences\Drawings\JPG") Then
                Directory.CreateDirectory(ProjectsPath & ProName & "\Lisences\Drawings\JPG")
            End If
            PogressBarValue += 1
            'Papers
            NewFID = FindNewFolderID()
            If NewFID = "NO" Then
                SQLCon.Close()
                Return "Can't Add Papers"
            End If
            SQLCmd.CommandText = "INSERT INTO dbo.FolderInfo (FolderID,FolderName,FolderPath,CreatedIn,UserID,ProID,ParentID) VALUES ('" & NewFID & "','Papers','" & ProName & "\Lisences\Papers" & "','" & Now.Date & "','" & AdminID & "','" & ProID & "','" & LVL2 & "')"
            SQLCmd.ExecuteNonQuery()
            If Not Directory.Exists(ProjectsPath & ProName & "\Lisences\Papers") Then
                Directory.CreateDirectory(ProjectsPath & ProName & "\Lisences\Papers")
            End If
            LVL3 = NewFID
            PogressBarValue += 1
            'Files
            NewFID = FindNewFolderID()
            If NewFID = "NO" Then
                SQLCon.Close()
                Return "Can't Add Files"
            End If
            SQLCmd.CommandText = "INSERT INTO dbo.FolderInfo (FolderID,FolderName,FolderPath,CreatedIn,UserID,ProID,ParentID) VALUES ('" & NewFID & "','Files','" & ProName & "\Lisences\Papers\Files" & "','" & Now.Date & "','" & AdminID & "','" & ProID & "','" & LVL3 & "')"
            SQLCmd.ExecuteNonQuery()
            If Not Directory.Exists(ProjectsPath & ProName & "\Lisences\Papers\Files") Then
                Directory.CreateDirectory(ProjectsPath & ProName & "\Lisences\Papers\Files")
            End If
            PogressBarValue += 1
            'JPG
            NewFID = FindNewFolderID()
            If NewFID = "NO" Then
                SQLCon.Close()
                Return "Can't Add JPG"
            End If
            SQLCmd.CommandText = "INSERT INTO dbo.FolderInfo (FolderID,FolderName,FolderPath,CreatedIn,UserID,ProID,ParentID) VALUES ('" & NewFID & "','JPG','" & ProName & "\Lisences\Papers\JPG" & "','" & Now.Date & "','" & AdminID & "','" & ProID & "','" & LVL3 & "')"
            SQLCmd.ExecuteNonQuery()
            If Not Directory.Exists(ProjectsPath & ProName & "\Lisences\Papers\JPG") Then
                Directory.CreateDirectory(ProjectsPath & ProName & "\Lisences\Papers\JPG")
            End If
            PogressBarValue += 1
            'Design
            NewFID = FindNewFolderID()
            If NewFID = "NO" Then
                SQLCon.Close()
                Return "Can't Add Design"
            End If
            SQLCmd.CommandText = "INSERT INTO dbo.FolderInfo (FolderID,FolderName,FolderPath,CreatedIn,UserID,ProID,ParentID) VALUES ('" & NewFID & "','Design','" & ProName & "\Design" & "','" & Now.Date & "','" & AdminID & "','" & ProID & "','" & LVL1 & "')"
            SQLCmd.ExecuteNonQuery()
            If Not Directory.Exists(ProjectsPath & ProName & "\Design") Then
                Directory.CreateDirectory(ProjectsPath & ProName & "\Design")
            End If
            LVL2 = NewFID
            PogressBarValue += 1
            'Concept
            NewFID = FindNewFolderID()
            If NewFID = "NO" Then
                SQLCon.Close()
                Return "Can't Add Concept"
            End If
            SQLCmd.CommandText = "INSERT INTO dbo.FolderInfo (FolderID,FolderName,FolderPath,CreatedIn,UserID,ProID,ParentID) VALUES ('" & NewFID & "','Concept','" & ProName & "\Design\Concept" & "','" & Now.Date & "','" & AdminID & "','" & ProID & "','" & LVL2 & "')"
            SQLCmd.ExecuteNonQuery()
            If Not Directory.Exists(ProjectsPath & ProName & "\Design\Concept") Then
                Directory.CreateDirectory(ProjectsPath & ProName & "\Design\Concept")
            End If
            PogressBarValue += 1
            'Working Drawings
            NewFID = FindNewFolderID()
            If NewFID = "NO" Then
                SQLCon.Close()
                Return "Can't Add Working Drawings"
            End If
            SQLCmd.CommandText = "INSERT INTO dbo.FolderInfo (FolderID,FolderName,FolderPath,CreatedIn,UserID,ProID,ParentID) VALUES ('" & NewFID & "','Working Drawings','" & ProName & "\Design\Working Drawings" & "','" & Now.Date & "','" & AdminID & "','" & ProID & "','" & LVL2 & "')"
            SQLCmd.ExecuteNonQuery()
            If Not Directory.Exists(ProjectsPath & ProName & "\Design\Working Drawings") Then
                Directory.CreateDirectory(ProjectsPath & ProName & "\Design\Working Drawings")
            End If
            PogressBarValue += 1
            'Reports
            NewFID = FindNewFolderID()
            If NewFID = "NO" Then
                SQLCon.Close()
                Return "Can't Add Reports"
            End If
            SQLCmd.CommandText = "INSERT INTO dbo.FolderInfo (FolderID,FolderName,FolderPath,CreatedIn,UserID,ProID,ParentID) VALUES ('" & NewFID & "','Reports','" & ProName & "\Design\Reports" & "','" & Now.Date & "','" & AdminID & "','" & ProID & "','" & LVL2 & "')"
            SQLCmd.ExecuteNonQuery()
            If Not Directory.Exists(ProjectsPath & ProName & "\Design\Reports") Then
                Directory.CreateDirectory(ProjectsPath & ProName & "\Design\Reports")
            End If
            PogressBarValue += 1
            'Consultant Correspondence
            NewFID = FindNewFolderID()
            If NewFID = "NO" Then
                SQLCon.Close()
                Return "Can't Add Consultant Correspondence"
            End If
            SQLCmd.CommandText = "INSERT INTO dbo.FolderInfo (FolderID,FolderName,FolderPath,CreatedIn,UserID,ProID,ParentID) VALUES ('" & NewFID & "','Consultant Correspondence','" & ProName & "\Design\Consultant Correspondence" & "','" & Now.Date & "','" & AdminID & "','" & ProID & "','" & LVL2 & "')"
            SQLCmd.ExecuteNonQuery()
            If Not Directory.Exists(ProjectsPath & ProName & "\Design\Consultant Correspondence") Then
                Directory.CreateDirectory(ProjectsPath & ProName & "\Design\Consultant Correspondence")
            End If
            LVL3 = NewFID
            PogressBarValue += 1
            'IN
            NewFID = FindNewFolderID()
            If NewFID = "NO" Then
                SQLCon.Close()
                Return "Can't Add IN"
            End If
            SQLCmd.CommandText = "INSERT INTO dbo.FolderInfo (FolderID,FolderName,FolderPath,CreatedIn,UserID,ProID,ParentID) VALUES ('" & NewFID & "','IN','" & ProName & "\Design\Consultant Correspondence\IN" & "','" & Now.Date & "','" & AdminID & "','" & ProID & "','" & LVL2 & "')"
            SQLCmd.ExecuteNonQuery()
            If Not Directory.Exists(ProjectsPath & ProName & "\Design\Consultant Correspondence\IN") Then
                Directory.CreateDirectory(ProjectsPath & ProName & "\Design\Consultant Correspondence\IN")
            End If
            LVL3 = NewFID
            PogressBarValue += 1
            'OUT
            NewFID = FindNewFolderID()
            If NewFID = "NO" Then
                SQLCon.Close()
                Return "Can't Add OUT"
            End If
            SQLCmd.CommandText = "INSERT INTO dbo.FolderInfo (FolderID,FolderName,FolderPath,CreatedIn,UserID,ProID,ParentID) VALUES ('" & NewFID & "','OUT','" & ProName & "\Design\Consultant Correspondence\OUT" & "','" & Now.Date & "','" & AdminID & "','" & ProID & "','" & LVL2 & "')"
            SQLCmd.ExecuteNonQuery()
            If Not Directory.Exists(ProjectsPath & ProName & "\Design\Consultant Correspondence\OUT") Then
                Directory.CreateDirectory(ProjectsPath & ProName & "\Design\Consultant Correspondence\OUT")
            End If
            LVL3 = NewFID
            PogressBarValue += 1
            'Implementation
            NewFID = FindNewFolderID()
            If NewFID = "NO" Then
                SQLCon.Close()
                Return "Can't Add Implementation"
            End If
            SQLCmd.CommandText = "INSERT INTO dbo.FolderInfo (FolderID,FolderName,FolderPath,CreatedIn,UserID,ProID,ParentID) VALUES ('" & NewFID & "','Implementation','" & ProName & "\Implementation" & "','" & Now.Date & "','" & AdminID & "','" & ProID & "','" & LVL1 & "')"
            SQLCmd.ExecuteNonQuery()
            If Not Directory.Exists(ProjectsPath & ProName & "\Implementation") Then
                Directory.CreateDirectory(ProjectsPath & ProName & "\Implementation")
            End If
            LVL2 = NewFID
            PogressBarValue += 1
            'Consultant Correspondence
            NewFID = FindNewFolderID()
            If NewFID = "NO" Then
                SQLCon.Close()
                Return "Can't Add Consultant Correspondence"
            End If
            SQLCmd.CommandText = "INSERT INTO dbo.FolderInfo (FolderID,FolderName,FolderPath,CreatedIn,UserID,ProID,ParentID) VALUES ('" & NewFID & "','Consultant Correspondence','" & ProName & "\Implementation\Consultant Correspondence" & "','" & Now.Date & "','" & AdminID & "','" & ProID & "','" & LVL2 & "')"
            SQLCmd.ExecuteNonQuery()
            If Not Directory.Exists(ProjectsPath & ProName & "\Implementation\Consultant Correspondence") Then
                Directory.CreateDirectory(ProjectsPath & ProName & "\Implementation\Consultant Correspondence")
            End If
            LVL3 = NewFID
            PogressBarValue += 1
            ' IN
            NewFID = FindNewFolderID()
            If NewFID = "NO" Then
                SQLCon.Close()
                Return "Can't Add IN"
            End If
            SQLCmd.CommandText = "INSERT INTO dbo.FolderInfo (FolderID,FolderName,FolderPath,CreatedIn,UserID,ProID,ParentID) VALUES ('" & NewFID & "','IN','" & ProName & "\Implementation\Consultant Correspondence\IN" & "','" & Now.Date & "','" & AdminID & "','" & ProID & "','" & LVL3 & "')"
            SQLCmd.ExecuteNonQuery()
            If Not Directory.Exists(ProjectsPath & ProName & "\Implementation\Consultant Correspondence\IN") Then
                Directory.CreateDirectory(ProjectsPath & ProName & "\Implementation\Consultant Correspondence\IN")
            End If
            PogressBarValue += 1
            ' OUT
            NewFID = FindNewFolderID()
            If NewFID = "NO" Then
                SQLCon.Close()
                Return "Can't Add OUT"
            End If
            SQLCmd.CommandText = "INSERT INTO dbo.FolderInfo (FolderID,FolderName,FolderPath,CreatedIn,UserID,ProID,ParentID) VALUES ('" & NewFID & "','OUT','" & ProName & "\Implementation\Consultant Correspondence\OUT" & "','" & Now.Date & "','" & AdminID & "','" & ProID & "','" & LVL3 & "')"
            SQLCmd.ExecuteNonQuery()
            If Not Directory.Exists(ProjectsPath & ProName & "\Implementation\Consultant Correspondence\OUT") Then
                Directory.CreateDirectory(ProjectsPath & ProName & "\Implementation\Consultant Correspondence\OUT")
            End If
            PogressBarValue += 1
            'Clients
            NewFID = FindNewFolderID()
            If NewFID = "NO" Then
                SQLCon.Close()
                Return "Can't Add Clients"
            End If
            SQLCmd.CommandText = "INSERT INTO dbo.FolderInfo (FolderID,FolderName,FolderPath,CreatedIn,UserID,ProID,ParentID) VALUES ('" & NewFID & "','Clients','" & ProName & "\Implementation\Clients" & "','" & Now.Date & "','" & AdminID & "','" & ProID & "','" & LVL2 & "')"
            SQLCmd.ExecuteNonQuery()
            If Not Directory.Exists(ProjectsPath & ProName & "\Implementation\Clients") Then
                Directory.CreateDirectory(ProjectsPath & ProName & "\Implementation\Clients")
            End If
            LVL3 = NewFID
            PogressBarValue += 1
            ' Contracts
            NewFID = FindNewFolderID()
            If NewFID = "NO" Then
                SQLCon.Close()
                Return "Can't Add Contracts"
            End If
            SQLCmd.CommandText = "INSERT INTO dbo.FolderInfo (FolderID,FolderName,FolderPath,CreatedIn,UserID,ProID,ParentID) VALUES ('" & NewFID & "','Contracts','" & ProName & "\Implementation\Clients\Contracts" & "','" & Now.Date & "','" & AdminID & "','" & ProID & "','" & LVL3 & "')"
            SQLCmd.ExecuteNonQuery()
            If Not Directory.Exists(ProjectsPath & ProName & "\Implementation\Clients\Contracts") Then
                Directory.CreateDirectory(ProjectsPath & ProName & "\Implementation\Clients\Contracts")
            End If
            PogressBarValue += 1
            ' Drawings
            NewFID = FindNewFolderID()
            If NewFID = "NO" Then
                SQLCon.Close()
                Return "Can't Add Drawings"
            End If
            SQLCmd.CommandText = "INSERT INTO dbo.FolderInfo (FolderID,FolderName,FolderPath,CreatedIn,UserID,ProID,ParentID) VALUES ('" & NewFID & "','Drawings','" & ProName & "\Implementation\Clients\Drawings" & "','" & Now.Date & "','" & AdminID & "','" & ProID & "','" & LVL3 & "')"
            SQLCmd.ExecuteNonQuery()
            If Not Directory.Exists(ProjectsPath & ProName & "\Implementation\Clients\Drawings") Then
                Directory.CreateDirectory(ProjectsPath & ProName & "\Implementation\Clients\Drawings")
            End If
            LVL4 = NewFID
            PogressBarValue += 1
            '  AutoCAD
            NewFID = FindNewFolderID()
            If NewFID = "NO" Then
                SQLCon.Close()
                Return "Can't Add AutoCAD"
            End If
            SQLCmd.CommandText = "INSERT INTO dbo.FolderInfo (FolderID,FolderName,FolderPath,CreatedIn,UserID,ProID,ParentID) VALUES ('" & NewFID & "','AutoCAD','" & ProName & "\Implementation\Clients\Drawings\AutoCAD" & "','" & Now.Date & "','" & AdminID & "','" & ProID & "','" & LVL4 & "')"
            SQLCmd.ExecuteNonQuery()
            If Not Directory.Exists(ProjectsPath & ProName & "\Implementation\Clients\Drawings\AutoCAD") Then
                Directory.CreateDirectory(ProjectsPath & ProName & "\Implementation\Clients\Drawings\AutoCAD")
            End If
            PogressBarValue += 1
            '  JPG
            NewFID = FindNewFolderID()
            If NewFID = "NO" Then
                SQLCon.Close()
                Return "Can't Add JPG"
            End If
            SQLCmd.CommandText = "INSERT INTO dbo.FolderInfo (FolderID,FolderName,FolderPath,CreatedIn,UserID,ProID,ParentID) VALUES ('" & NewFID & "','JPG','" & ProName & "\Implementation\Clients\Drawings\JPG" & "','" & Now.Date & "','" & AdminID & "','" & ProID & "','" & LVL4 & "')"
            SQLCmd.ExecuteNonQuery()
            If Not Directory.Exists(ProjectsPath & ProName & "\Implementation\Clients\Drawings\JPG") Then
                Directory.CreateDirectory(ProjectsPath & ProName & "\Implementation\Clients\Drawings\JPG")
            End If
            PogressBarValue += 1
            'Construction Documents
            NewFID = FindNewFolderID()
            If NewFID = "NO" Then
                SQLCon.Close()
                Return "Can't Add Construction Documents"
            End If
            SQLCmd.CommandText = "INSERT INTO dbo.FolderInfo (FolderID,FolderName,FolderPath,CreatedIn,UserID,ProID,ParentID) VALUES ('" & NewFID & "','Construction Documents','" & ProName & "\Implementation\Construction Documents" & "','" & Now.Date & "','" & AdminID & "','" & ProID & "','" & LVL2 & "')"
            SQLCmd.ExecuteNonQuery()
            If Not Directory.Exists(ProjectsPath & ProName & "\Implementation\Construction Documents") Then
                Directory.CreateDirectory(ProjectsPath & ProName & "\Implementation\Construction Documents")
            End If
            LVL3 = NewFID
            PogressBarValue += 1
            ' Invoice
            NewFID = FindNewFolderID()
            If NewFID = "NO" Then
                SQLCon.Close()
                Return "Can't Add Invoice"
            End If
            SQLCmd.CommandText = "INSERT INTO dbo.FolderInfo (FolderID,FolderName,FolderPath,CreatedIn,UserID,ProID,ParentID) VALUES ('" & NewFID & "','Invoice','" & ProName & "\Implementation\Construction Documents\Invoice" & "','" & Now.Date & "','" & AdminID & "','" & ProID & "','" & LVL3 & "')"
            SQLCmd.ExecuteNonQuery()
            If Not Directory.Exists(ProjectsPath & ProName & "\Implementation\Construction Documents\Invoice") Then
                Directory.CreateDirectory(ProjectsPath & ProName & "\Implementation\Construction Documents\Invoice")
            End If
            PogressBarValue += 1
            ' Planning
            NewFID = FindNewFolderID()
            If NewFID = "NO" Then
                SQLCon.Close()
                Return "Can't Add Planning"
            End If
            SQLCmd.CommandText = "INSERT INTO dbo.FolderInfo (FolderID,FolderName,FolderPath,CreatedIn,UserID,ProID,ParentID) VALUES ('" & NewFID & "','Planning','" & ProName & "\Implementation\Construction Documents\Planning" & "','" & Now.Date & "','" & AdminID & "','" & ProID & "','" & LVL3 & "')"
            SQLCmd.ExecuteNonQuery()
            If Not Directory.Exists(ProjectsPath & ProName & "\Implementation\Construction Documents\Planning") Then
                Directory.CreateDirectory(ProjectsPath & ProName & "\Implementation\Construction Documents\Planning")
            End If
            PogressBarValue += 1
            ' Cost Control
            NewFID = FindNewFolderID()
            If NewFID = "NO" Then
                SQLCon.Close()
                Return "Can't Add Cost Control"
            End If
            SQLCmd.CommandText = "INSERT INTO dbo.FolderInfo (FolderID,FolderName,FolderPath,CreatedIn,UserID,ProID,ParentID) VALUES ('" & NewFID & "','Cost Control','" & ProName & "\Implementation\Construction Documents\Cost Control" & "','" & Now.Date & "','" & AdminID & "','" & ProID & "','" & LVL3 & "')"
            SQLCmd.ExecuteNonQuery()
            If Not Directory.Exists(ProjectsPath & ProName & "\Implementation\Construction Documents\Cost Control") Then
                Directory.CreateDirectory(ProjectsPath & ProName & "\Implementation\Construction Documents\Cost Control")
            End If
            PogressBarValue += 1
            ' As build drawings
            NewFID = FindNewFolderID()
            If NewFID = "NO" Then
                SQLCon.Close()
                Return "Can't Add As build drawings"
            End If
            SQLCmd.CommandText = "INSERT INTO dbo.FolderInfo (FolderID,FolderName,FolderPath,CreatedIn,UserID,ProID,ParentID) VALUES ('" & NewFID & "','As build drawings','" & ProName & "\Implementation\Construction Documents\As build drawings" & "','" & Now.Date & "','" & AdminID & "','" & ProID & "','" & LVL3 & "')"
            SQLCmd.ExecuteNonQuery()
            If Not Directory.Exists(ProjectsPath & ProName & "\Implementation\Construction Documents\As build drawings") Then
                Directory.CreateDirectory(ProjectsPath & ProName & "\Implementation\Construction Documents\As build drawings")
            End If
        Catch ex As Exception
            Try
                If ProID <> Nothing Or ProID <> "NO" Then
                    SQLCmd.CommandText = "DELETE FROM dbo.FolderInfo where ProID='" & ProID & "'"
                    SQLCmd.ExecuteNonQuery()
                    SQLCmd.CommandText = "DELETE FROM dbo.Projects WHERE ProID='" & ProID & "'"
                    SQLCmd.ExecuteNonQuery()
                End If
                If Not Directory.Exists(ProjectsPath & ProName) Then
                    Directory.CreateDirectory(ProjectsPath & ProName)
                End If
            Catch
            End Try
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLDR.Close()
        SQLCon.Close()
        Return Nothing
    End Function
    Private Function FindNewFolderID() As String
        Dim NewID As String
        Try
            SQLCmd.CommandText = "SP_FindNewFolderID"
            NewID = SQLCmd.ExecuteScalar
            If NewID = "NO" Then
                Return "NO"
            End If
        Catch ex As Exception
            Return "NO"
        End Try
        Return NewID
    End Function
    Public Function RemoveProject(ByVal ProID As String, ByVal ProjectsPath As String, ByVal DeletedFilesPath As String) As String
        Try
            Dim NewCMD As New SqlClient.SqlCommand("", SQLCon)
            Dim ProPath As String = Nothing
            SQLCon.Open()
            NewCMD.CommandText = "select FolderPath from dbo.FolderInfo where ProID='" & ProID & "' and ParentID='0'"
            ProPath = NewCMD.ExecuteScalar.ToString.Trim
            If ProPath <> Nothing Then
                ProPath = ProjectsPath & ProPath
            End If
            SQLTrn = SQLCon.BeginTransaction
            SQLCmd.Transaction = SQLTrn
            SQLCmd.CommandText = "Delete from rulls where proid='" & ProID & "'"
            SQLCmd.ExecuteNonQuery()
            SQLCmd.CommandText = "Delete from dbo.FileInfo where ProID='" & ProID & "'"
            SQLCmd.ExecuteNonQuery()
            SQLCmd.CommandText = "Delete from dbo.FolderInfo where ProID='" & ProID & "'"
            SQLCmd.ExecuteNonQuery()
            SQLCmd.CommandText = "Delete from projects where proid='" & ProID & "'"
            SQLCmd.ExecuteNonQuery()
            SQLTrn.Commit()
            Try
                If ProPath <> Nothing Then
                    If Directory.Exists(ProPath) Then
                        If Not System.IO.Directory.Exists(DeletedFilesPath & Now.Year & "-" & Now.Month & "-" & Now.Day) Then
                            System.IO.Directory.CreateDirectory(DeletedFilesPath & Now.Year & "-" & Now.Month & "-" & Now.Day)
                        End If
                        Dim Int1 As Int16
                        Dim ProjectPaths() As String = ProPath.Split("\")
                        Dim NewPath As String
                        For Int1 = 0 To 10000
                            NewPath = DeletedFilesPath & Now.Year & "-" & Now.Month & "-" & Now.Day & "\" & ProjectPaths(ProjectPaths.Length - 1) & "_" & Int1
                            If System.IO.Directory.Exists(NewPath) = False Then
                                Directory.Move(ProPath, NewPath)
                                Exit For
                            End If
                        Next
                    End If
                End If
            Catch
            End Try
        Catch ex As Exception
            SQLTrn.Rollback()
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLCon.Close()
        Return Nothing
    End Function
    Public Function AddNewFileType(ByVal TypeName As String, ByVal TypeIconPath As String, ByVal TypeDic As String, ByVal TypeExt As String) As String
        Dim ErrorProvider As String = Nothing
        Try
            SQLCmd.CommandText = "SP_InsertNewFileType @TypeName='" & TypeName & "',@TypeIconPath='" & TypeIconPath & "',@TypeDic='" & TypeDic & "',@TypeExt='" & TypeExt & "'"
            SQLCon.Open()
            ErrorProvider = SQLCmd.ExecuteScalar()
        Catch ex As Exception
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLCon.Close()
        Return ErrorProvider
        'TypeName In Used
    End Function
    Public Function UpdateFileType(ByVal TypeID As String, ByVal TypeName As String, ByVal TypeIconPath As String, ByVal TypeDic As String, ByVal TypeExt As String) As String
        Try
            SQLCmd.CommandText = "Update dbo.FileType set TypeName='" & TypeName & "' , TypeIconPath='" & TypeIconPath & "' , TypeDic='" & TypeDic & "' , TypeExt='" & TypeExt & "' where TypeID=" & TypeID
            SQLCon.Open()
            SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLCon.Close()
        Return Nothing
    End Function
    Public Function DeleteFileType(ByVal TypeID As String) As String
        Try
            SQLCon.Open()
            SQLCmd.CommandText = "Update dbo.FileInfo set TypeID=null where TypeID=" & TypeID
            SQLCmd.ExecuteNonQuery()
            SQLCmd.CommandText = "Delete From dbo.FileType where TypeID=" & TypeID
            SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLCon.Close()
        Return Nothing
    End Function
    Public Function GetAllLockedFile(ByRef LockedFileZ() As LockedFilesSTR) As String
        ReDim LockedFileZ(-1)
        Try
            SQLCmd.CommandText = "SP_GetAllLockFiles"
            SQLCon.Open()
            SQLDR = SQLCmd.ExecuteReader
            Do While SQLDR.Read
                If LockedFileZ.Length = 0 Then
                    ReDim LockedFileZ(0)
                Else
                    ReDim Preserve LockedFileZ(LockedFileZ.Length)
                End If
                LockedFileZ(LockedFileZ.Length - 1).FileID = SQLDR.GetString(0).Trim
                LockedFileZ(LockedFileZ.Length - 1).FileName = SQLDR.GetString(1).Trim
                LockedFileZ(LockedFileZ.Length - 1).FilePath = SQLDR.GetString(2).Trim
                LockedFileZ(LockedFileZ.Length - 1).ProjectName = SQLDR.GetString(3).Trim
                LockedFileZ(LockedFileZ.Length - 1).UsrID = SQLDR.GetString(4).Trim
                LockedFileZ(LockedFileZ.Length - 1).UsrName = SQLDR.GetString(5).Trim
                If SQLDR.NextResult Then : End If
            Loop
        Catch ex As Exception
            SQLDR.Close()
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLDR.Close()
        SQLCon.Close()
        Return Nothing
    End Function
    Public Function UnLockFile(ByVal FileID As String) As String
        Try
            SQLCmd.CommandText = "Update dbo.FileInfo Set InUseUserID=NULL,InUse=0 Where FileID='" & FileID & "'"
            SQLCon.Open()
            SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLCon.Close()
        Return Nothing
    End Function
    Public Function GetProjectInfo(ByVal ProjectID As String, ByRef ProjectInfoSTR As ProjectInfo) As String
        Try
            SQLCmd.CommandText = "Select ProName,ProLocation,Startat,ExpEndat,Endedat,Budget from dbo.Projects where ProID='" & ProjectID & "'"
            SQLCon.Open()
            SQLDR = SQLCmd.ExecuteReader
            SQLDR.Read()
            ProjectInfoSTR.ProjectID = ProjectID
            ProjectInfoSTR.PrjectName = SQLDR.GetValue(0).ToString.Trim
            ProjectInfoSTR.ProjectLocation = SQLDR.GetValue(1).ToString.Trim
            If SQLDR.IsDBNull(2) = False Then
                'MsgBox(SQLDR.GetDateTime(2).ToShortDateString)
                ProjectInfoSTR.ProjectStart = SQLDR.GetDateTime(2).ToShortDateString
            Else
                ProjectInfoSTR.ProjectStart = ""
            End If
            If SQLDR.IsDBNull(3) = False Then
                'MsgBox(SQLDR.GetDateTime(3).ToShortDateString)
                ProjectInfoSTR.projectExp = SQLDR.GetDateTime(3).ToShortDateString
            Else
                ProjectInfoSTR.projectExp = ""
            End If
            If SQLDR.IsDBNull(4) = False Then
                'MsgBox(SQLDR.GetDateTime(4).ToShortDateString)
                ProjectInfoSTR.ProjectEnd = SQLDR.GetDateTime(4).ToShortDateString
            Else
                ProjectInfoSTR.ProjectEnd = ""
            End If
            ProjectInfoSTR.ProjectBudget = SQLDR.GetValue(5).ToString.Trim
        Catch ex As Exception
            SQLDR.Close()
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLDR.Close()
        SQLCon.Close()
        Return Nothing
    End Function
    Public Function SaveProjectInfo(ByVal ProjectInfoSTR As ProjectInfo) As String
        Try
            SQLCmd.CommandText = "Update dbo.Projects Set ProName='" & ProjectInfoSTR.PrjectName & "',ProLocation='" & ProjectInfoSTR.ProjectLocation & "',Startat=" & ProjectInfoSTR.ProjectStart & ",ExpEndat=" & ProjectInfoSTR.projectExp & ",Endedat=" & ProjectInfoSTR.ProjectEnd & ",Budget=" & ProjectInfoSTR.ProjectBudget & " Where ProID='" & ProjectInfoSTR.ProjectID & "'"
            SQLCon.Open()
            'MsgBox(SQLCmd.CommandText)
            SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLCon.Close()
        Return Nothing
    End Function



    'Registry Functions
    Public Sub PrepareReg()
        Dim RegKey As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE", True)
        Dim arr() As String
        Dim ForInt As Integer = 0
        arr = Registry.LocalMachine.OpenSubKey("SOFTWARE").GetSubKeyNames
        For ForInt = 0 To arr.Length - 1
            If arr(ForInt) = "Mena Data Center" Then
            End If
        Next
        RegKey.CreateSubKey("Mena Data Center")
    End Sub
    Public Sub SetRegValue(ByVal KeyValue As String, ByVal ValueName As RegKeyValues)
        '"SQLString"
        PrepareReg()
        Registry.LocalMachine.OpenSubKey("SOFTWARE\Mena Data Center", True).SetValue(ValueName.ToString, KeyValue)
    End Sub
    Public Function GetRegValue(ByRef ConStr As String, ByVal ValueName As RegKeyValues) As Boolean
        PrepareReg()
        Dim arr() As String = Registry.LocalMachine.OpenSubKey("SOFTWARE\Mena Data Center", False).GetValueNames
        Dim ForInt As Integer = 0
        For ForInt = 0 To arr.Length - 1
            If arr(ForInt) = ValueName.ToString Then
                ConStr = Registry.LocalMachine.OpenSubKey("SOFTWARE\Mena Data Center", False).GetValue(ValueName.ToString)
                Return True
            End If
        Next
        Return False
    End Function
    Public Sub ResetConnection()
        Registry.LocalMachine.DeleteSubKey("SOFTWARE\Mena Data Center")
        'Registry.LocalMachine.OpenSubKey("SOFTWARE\Mena Data Center", True).DeleteValue(RegKeyValues.PW)
    End Sub
    'Binary Function
    Public Overloads Function CharToBinary(ByVal Strings As String) As String
        Dim int As Int16
        Dim fout As String = ""
        Dim out As String = ""
        For int = 0 To Strings.Length - 1
            Dim str2 As Int64 = Asc(Strings.Chars(int))
            str2 = (str2 * 9) / 8
            Dim mydiv As Int64
            Do While str2 <> 0
                str2 = DivRem(str2, 2, mydiv)
                If mydiv > 0 Then
                    out = 1 & out
                Else
                    out = 0 & out
                End If
            Loop
            out = New String("0", 8 - out.Length) & out
            fout &= out
            out = ""
        Next
        Return fout
    End Function
    Public Function Binarytochar(ByVal Binarystring As String) As String
        Dim fout As String = ""
        Dim back_to_normal As Int64
        Dim arr((Binarystring.Length / 8) - 1) As String
        Dim i As Int16
        For i = 0 To (Binarystring.Length / 8) - 1
            arr(i) = Binarystring.Substring(i * 8, 8)
        Next i
        For i = 0 To arr.Length - 1
            Dim str1 As String = arr(i).Substring(0, 4)
            Dim str2 As String = arr(i).Substring(4)
            Dim int As New Int16
            Dim out1 As New Int16
            Dim out2 As New Int16
            If str1.Chars(0) = "1" Then
                out1 += 8
            End If
            If str1.Chars(1) = "1" Then
                out1 += 4
            End If
            If str1.Chars(2) = "1" Then
                out1 += 2
            End If
            If str1.Chars(3) = "1" Then
                out1 += 1
            End If
            If str2.Chars(0) = "1" Then
                out2 += 8
            End If
            If str2.Chars(1) = "1" Then
                out2 += 4
            End If
            If str2.Chars(2) = "1" Then
                out2 += 2
            End If
            If str2.Chars(3) = "1" Then
                out2 += 1
            End If
            out2 = out2 * 1
            out1 = out1 * 16
            back_to_normal = out1 + out2
            back_to_normal = (back_to_normal * 8) / 9
            fout &= Chr(back_to_normal)
        Next
        Return fout
    End Function

End Class
Public Class DataCenterClientLib
    'Vars SQLClient
    Public SQLCon As New SqlClient.SqlConnection("")
    Private SQLDR As SqlClient.SqlDataReader
    Private SQLTrn As SqlClient.SqlTransaction
    Private SQLCmd As New SqlClient.SqlCommand("", SQLCon, SQLTrn)
    Public SqlStr As String
    'Structure
    Public Structure PrvOperationsType
        Dim RullID As String
        Dim RullName As String
        'Dim CanRead As Boolean
        Dim CanWrite As Boolean
        Dim CanDelete As Boolean
    End Structure
    Public Structure PrivateFoldersPrvType
        Dim FolderInfo() As FolderInfo
        Dim PrvOperationsType() As PrvOperationsType
    End Structure
    Public Structure FileInfo
        Dim FileID As String
        Dim FileName As String
        Dim FilePath As String
        Dim CreatedIn As String
        Dim UsrID As String
        Dim Dis As String
        Dim ProID As String
        Dim FolderID As String
        Dim TypeID As String
        Dim UserName As String
        Dim TypeName As String
        Dim TypePath As String
        Dim InUseUserID As String
        Dim InUseUserName As String
        Dim InUse As String
    End Structure
    Public Structure FolderInfo
        Dim FolderID As String
        Dim FolderName As String
        Dim FolderPath As String
        Dim UserID As String
        Dim UserName As String
        Dim CreatedIn As String
        Dim Disc As String
        Dim ProID As String
        Dim ProName As String
        Dim ParentID As String
        Public Files() As FileInfo
    End Structure
    Public Structure FilesType
        Dim TypeID As String
        Dim TypeName As String
        Dim TypeIcon As String
        Dim TypeExt As String
        Dim TypeDesc As String
    End Structure
    Public Structure CUserIfo
        Dim UID As String
        Dim UName As String
        Dim UPass As String
        Dim UsrPrv() As privilegeType
    End Structure
    Public CUser As CUserIfo
    Public Structure privilegeType
        Dim privilegeName As String
        Dim privilegeID As String
        Dim privilegeSelected As Boolean
    End Structure
    Public Structure ProjectWithprivilegesType
        Dim ProjectID As String
        Dim ProjectName As String
        Dim InternalPrivileges() As privilegeType
    End Structure
    Private Structure ListOfFilesPathType
        Dim FileID As String
        Dim FilePath As String
    End Structure
    Private Structure ListOfFoldersPathType
        Dim FolderID As String
        Dim FolderPath As String
    End Structure
    Public Structure LockedFilesSTR
        Dim FileID As String
        Dim FileName As String
        Dim FilePath As String
        Dim ProjectName As String
        Dim UsrID As String
        Dim UsrName As String
    End Structure
    'Vars
    'Public AllFoldersWithPrv As PrivateFoldersPrvType "Obsolated"
    'Public Folders(0) As FolderInfo "Obsolated"
    Private ErrorProvider As String = Nothing
    Public AllFilesType() As FilesType
    Public Allprivilege(0) As privilegeType
    Public AllProjectWithPrivileges() As ProjectWithprivilegesType
    Private ListOfFilesPathToChage(0) As ListOfFilesPathType
    Private ListOfFoldersPathToChange(0) As ListOfFoldersPathType
    Private NWLib As New FunctionLib.NetworkFunction
    'Enums
    Public Enum RegKeyValues
        SQLString
        PW
        DataChacked

    End Enum
    'Functions
    Public Sub ServerTest(ByVal ServerName As String, ByVal UserID As String, ByVal UserPW As String, ByRef Done As Boolean)
        Try
            SQLCon.ConnectionString = "Data Source=" & ServerName & ";User ID=" & UserID & ";Password=" & UserPW
            SQLCon.Open()
            Done = True
        Catch ex As Exception
            Done = False
        End Try
        SQLCon.Close()
    End Sub
    Public Overloads Sub AttachDB(ByVal DataPath As String, ByRef Done As Boolean)
        Try
            SQLCmd.CommandText = "EXEC sp_attach_single_file_db @dbname = 'DataCenter', @physname = '" & DataPath & "'"
            SQLCon.Open()
            SQLCmd.ExecuteNonQuery()
            Done = True
        Catch ex As Exception
            Done = False
        End Try
        SQLCon.Close()
    End Sub
    Public Overloads Sub AttachDB(ByVal DataPath As String, ByVal LogPath As String, ByRef Done As Boolean)
        Try
            SQLCmd.CommandText = "EXEC sp_attach_db @dbname = N'DataCenter', @filename1 = N'" & DataPath & "',@filename2 = N'" & LogPath & "'"
            SQLCon.Open()
            SQLCmd.ExecuteNonQuery()
            Done = True
        Catch ex As Exception
            Done = False
        End Try
        SQLCon.Close()
    End Sub
    Public Function GetAllDatabase() As String()
        Dim DatBaseNames(-1) As String
        Try
            SQLCmd.CommandText = "SELECT * FROM master.dbo.sysdatabases"
            SQLCon.Open()
            SQLDR = SQLCmd.ExecuteReader
            Do While SQLDR.Read
                If DatBaseNames.Length = 0 Then
                    ReDim DatBaseNames(0)
                Else
                    ReDim Preserve DatBaseNames(DatBaseNames.Length)
                End If
                DatBaseNames(DatBaseNames.Length - 1) = SQLDR.GetString(0).Trim
            Loop
        Catch ex As Exception
            SQLDR.Close()
            SQLCon.Close()
            Return Nothing
        End Try
        SQLDR.Close()
        SQLCon.Close()
        Return DatBaseNames
    End Function
    Public Function ULogin(ByVal UName As String, ByVal UPassword As String) As Boolean
        Try
            CUser = New CUserIfo
            SQLCmd.CommandText = "Select UsrID from dbo.Users where UserName='" & UName & "' and [Password]='" & UPassword & "' and Status=0 and UserName<>'Administrator'"
            SQLCon.Open()
            SQLDR = SQLCmd.ExecuteReader
            SQLDR.Read()
            If SQLDR.HasRows = True Then
                CUser.UID = SQLDR.GetValue(0).ToString.Trim
                CUser.UName = UName
                CUser.UPass = UPassword
                SQLDR.Close()
                SQLCon.Close()
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        SQLDR.Close()
        SQLCon.Close()
        Return False
    End Function
    Public Function GetServerOption(ByRef ProjectsPath As String, ByRef RelatedFiles As String, ByRef DeletedFilesPath As String, ByRef ServerIP As String, ByRef ServerPort As String) As String
        Try
            SQLCmd.CommandText = "SELECT ProjectsPath,RelatedFiles,DeletedFilesPath,ServerIP,ServerPort FROM dbo.ServerOption"
            SQLCon.Open()
            SQLDR = SQLCmd.ExecuteReader
            Do While SQLDR.Read
                If SQLDR.IsDBNull(0) = False Then
                    ProjectsPath = SQLDR.GetValue(0).ToString.Trim
                End If
                If SQLDR.IsDBNull(1) = False Then
                    RelatedFiles = SQLDR.GetValue(1).ToString.Trim
                End If
                If SQLDR.IsDBNull(2) = False Then
                    DeletedFilesPath = SQLDR.GetValue(2).ToString.Trim
                End If
                If SQLDR.IsDBNull(3) = False Then
                    ServerIP = SQLDR.GetValue(3).ToString.Trim
                End If
                If SQLDR.IsDBNull(4) = False Then
                    ServerPort = SQLDR.GetValue(4).ToString.Trim
                End If
            Loop
        Catch ex As Exception
            If MsgBox("Can't Load Option, Do you want to rest connction" & vbNewLine & "Are you sure?", MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
                ResetConnection()
                MsgBox("Application terminated", MsgBoxStyle.Information, "WARNING")
                Process.GetCurrentProcess.Kill()
            End If
            SQLDR.Close()
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLDR.Close()
        SQLCon.Close()
        Return Nothing
    End Function
    Public Function ChangePasswrod(ByVal UserID As String, ByVal UsrPassword As String) As String
        Try
            SQLCmd.CommandText = "Update dbo.Users Set [Password]='" & UsrPassword & "' where UsrID='" & UserID & "'"
            SQLCon.Open()
            SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLCon.Close()
        Return Nothing
    End Function
    Public Sub GetAllFoldersWithFilesOrdered(ByVal DataPath As String, ByVal UsrID As String, ByRef AllFoldersWithPrv2 As PrivateFoldersPrvType, ByRef Max As Integer, ByRef Values As Integer)
        'ReDim AllFoldersWithPrv.FolderInfo(0)
        AllFoldersWithPrv2 = New PrivateFoldersPrvType
        Dim AllFoldersWithPrv As New PrivateFoldersPrvType
        Dim Int1 As New Integer
        'Connection No#2
        Dim SqlCon2 As New SqlClient.SqlConnection(SqlStr)
        Dim SqlCmd2 As New SqlClient.SqlCommand("", SqlCon2)
        Dim SqlDR2 As SqlClient.SqlDataReader
        'Connection No#3
        Dim SqlCon3 As New SqlClient.SqlConnection(SqlStr)
        Dim SqlCmd3 As New SqlClient.SqlCommand("", SqlCon3)
        Dim SqlDR3 As SqlClient.SqlDataReader
        'Connection No#3
        Dim SqlCon4 As New SqlClient.SqlConnection(SqlStr)
        Dim SqlCmd4 As New SqlClient.SqlCommand("", SqlCon4)
        Dim i As Int16
        Try
            '1- Get User's Rulls
            SQLCmd.CommandText = "select RullID from dbo.Users_Rulls where UsrID='" & UsrID & "'"
            SQLCon.Open()
            SqlCon2.Open()
            SqlCon3.Open()
            SqlCon4.Open()
            SQLDR = SQLCmd.ExecuteReader
            Do While SQLDR.Read
                Max = SQLDR.VisibleFieldCount
                Values = SQLDR.VisibleFieldCount
                '2- Geting The FolderID,Write,Delete for this Rull
                SqlCmd2.CommandText = "Select FolderID,CanWrite,CanDelete from dbo.Folder_Rull where RullID='" & SQLDR.GetString(0).Trim & "'"
                SqlDR2 = SqlCmd2.ExecuteReader
                Do While SqlDR2.Read
                    If AllFoldersWithPrv.FolderInfo IsNot Nothing Then 'check for if i already add this folder or not
                        For Int1 = 0 To AllFoldersWithPrv.FolderInfo.Length - 1
                            If AllFoldersWithPrv.FolderInfo(Int1).FolderID = SqlDR2.GetString(0).Trim Then
                                If SqlDR2.GetValue(1).ToString.Trim = "1" Then 'Fill CanWrite
                                    AllFoldersWithPrv.PrvOperationsType(Int1).CanWrite = True
                                End If
                                If SqlDR2.GetValue(2).ToString.Trim = "1" Then 'Fill CanDelete
                                    AllFoldersWithPrv.PrvOperationsType(Int1).CanDelete = True
                                End If
                                GoTo NextLoop
                            End If
                        Next
                    End If
                    If AllFoldersWithPrv.PrvOperationsType Is Nothing Then
                        ReDim AllFoldersWithPrv.PrvOperationsType(0)
                    Else
                        ReDim Preserve AllFoldersWithPrv.PrvOperationsType(AllFoldersWithPrv.PrvOperationsType.Length)
                    End If
                    AllFoldersWithPrv.PrvOperationsType(AllFoldersWithPrv.PrvOperationsType.Length - 1).RullID = SQLDR.GetString(0).Trim 'Fill RullID
                    If AllFoldersWithPrv.FolderInfo Is Nothing Then
                        ReDim AllFoldersWithPrv.FolderInfo(0)
                    Else
                        ReDim Preserve AllFoldersWithPrv.FolderInfo(AllFoldersWithPrv.FolderInfo.Length)
                    End If
                    AllFoldersWithPrv.FolderInfo(AllFoldersWithPrv.FolderInfo.Length - 1).FolderID = SqlDR2.GetString(0).Trim 'Fill FolderID
                    If SqlDR2.GetValue(1).ToString.Trim = "1" Then 'Fill CanWrite
                        AllFoldersWithPrv.PrvOperationsType(AllFoldersWithPrv.PrvOperationsType.Length - 1).CanWrite = True
                    End If
                    If SqlDR2.GetValue(2).ToString.Trim = "1" Then 'Fill CanDelete
                        AllFoldersWithPrv.PrvOperationsType(AllFoldersWithPrv.PrvOperationsType.Length - 1).CanDelete = True
                    End If
                    'SqlDR2.Close()
                    '3- Get Folder Options
                    SqlCmd3.CommandText = "SELECT FolderName,FolderPath,UserID,CreatedIn,Disc,ProID,ParentID from dbo.FolderInfo where FolderID='" & AllFoldersWithPrv.FolderInfo(AllFoldersWithPrv.FolderInfo.Length - 1).FolderID & "' order by FolderPath"
                    SqlDR3 = SqlCmd3.ExecuteReader
                    SqlDR3.Read()
                    With AllFoldersWithPrv.FolderInfo(AllFoldersWithPrv.FolderInfo.Length - 1)
                        .FolderName = SqlDR3.GetValue(0).ToString.Trim
                        .FolderPath = SqlDR3.GetValue(1).ToString.Trim
                        .UserID = SqlDR3.GetValue(2).ToString.Trim
                        .CreatedIn = SqlDR3.GetValue(3).ToString.Trim
                        .Disc = SqlDR3.GetValue(4).ToString.Trim
                        .ProID = SqlDR3.GetValue(5).ToString.Trim
                        .ParentID = SqlDR3.GetValue(6).ToString.Trim
                    End With
                    SqlDR3.Close()
                    '4- Get the user name who create this folder
                    SqlCmd3.CommandText = "Select UserName from dbo.Users where UsrID=" & AllFoldersWithPrv.FolderInfo(AllFoldersWithPrv.FolderInfo.Length - 1).UserID
                    AllFoldersWithPrv.FolderInfo(AllFoldersWithPrv.FolderInfo.Length - 1).UserName = SqlCmd3.ExecuteScalar
                    '5- Get Project name of this folder
                    SqlCmd3.CommandText = "Select ProName from dbo.Projects where ProID=" & AllFoldersWithPrv.FolderInfo(AllFoldersWithPrv.FolderInfo.Length - 1).ProID
                    AllFoldersWithPrv.FolderInfo(AllFoldersWithPrv.FolderInfo.Length - 1).ProName = SqlCmd3.ExecuteScalar
                    'SqlDR2.Close()
                    '6- Get Rull Name
                    SqlCmd3.CommandText = "Select RullName from dbo.Rulls where RullID='" & AllFoldersWithPrv.PrvOperationsType(AllFoldersWithPrv.PrvOperationsType.Length - 1).RullID & "'"
                    AllFoldersWithPrv.PrvOperationsType(AllFoldersWithPrv.PrvOperationsType.Length - 1).RullName = SqlCmd3.ExecuteScalar
                    '7- Get All Files Withen This Folder
                    SqlCmd3.CommandText = "Select FileID,[FileName],FilePath,CreatedIn,UsrID,Dis,ProID,TypeID,InUseUserID,InUse from dbo.FileInfo where FolderID='" & AllFoldersWithPrv.FolderInfo(AllFoldersWithPrv.FolderInfo.Length - 1).FolderID & "' and  Active=1"
                    SqlDR3 = SqlCmd3.ExecuteReader
                    Do While SqlDR3.Read
                        If AllFoldersWithPrv.FolderInfo(AllFoldersWithPrv.FolderInfo.Length - 1).Files Is Nothing Then
                            ReDim AllFoldersWithPrv.FolderInfo(AllFoldersWithPrv.FolderInfo.Length - 1).Files(0)
                        Else
                            ReDim Preserve AllFoldersWithPrv.FolderInfo(AllFoldersWithPrv.FolderInfo.Length - 1).Files(AllFoldersWithPrv.FolderInfo(AllFoldersWithPrv.FolderInfo.Length - 1).Files.Length)
                        End If
                        With AllFoldersWithPrv.FolderInfo(AllFoldersWithPrv.FolderInfo.Length - 1).Files(AllFoldersWithPrv.FolderInfo(AllFoldersWithPrv.FolderInfo.Length - 1).Files.Length - 1)
                            .FolderID = AllFoldersWithPrv.FolderInfo(AllFoldersWithPrv.FolderInfo.Length - 1).FolderID
                            .FileID = SqlDR3.GetString(0).Trim
                            .FileName = SqlDR3.GetString(1).Trim
                            .FilePath = DataPath & SqlDR3.GetString(2).Trim
                            .CreatedIn = SqlDR3.GetValue(3).ToString.Trim
                            .UsrID = SqlDR3.GetString(4).Trim
                            .Dis = SqlDR3.GetValue(5).ToString.Trim
                            .ProID = SqlDR3.GetString(6).Trim
                            .TypeID = SqlDR3.GetValue(7).ToString.Trim
                            .InUseUserID = SqlDR3.GetValue(8).ToString.Trim
                            .InUse = SqlDR3.GetValue(9).ToString.Trim
                        End With
                        '8- Get User name that create this file
                        SqlCmd4.CommandText = "select UserName from dbo.Users where UsrID=" & AllFoldersWithPrv.FolderInfo(AllFoldersWithPrv.FolderInfo.Length - 1).Files(AllFoldersWithPrv.FolderInfo(AllFoldersWithPrv.FolderInfo.Length - 1).Files.Length - 1).UsrID
                        AllFoldersWithPrv.FolderInfo(AllFoldersWithPrv.FolderInfo.Length - 1).Files(AllFoldersWithPrv.FolderInfo(AllFoldersWithPrv.FolderInfo.Length - 1).Files.Length - 1).UserName = SqlCmd4.ExecuteScalar
                        '9- Get User who lock this file
                        If SqlDR3.IsDBNull(8) = False Then
                            SqlCmd4.CommandText = "select UserName from dbo.Users where UsrID=" & SqlDR3.GetString(8).Trim
                            AllFoldersWithPrv.FolderInfo(AllFoldersWithPrv.FolderInfo.Length - 1).Files(AllFoldersWithPrv.FolderInfo(AllFoldersWithPrv.FolderInfo.Length - 1).Files.Length - 1).InUseUserName = SqlCmd4.ExecuteScalar.ToString.Trim
                        End If
                        '10- Get TypeName of this file
                        For i = 0 To AllFilesType.Length - 1
                            If AllFilesType(i).TypeID = AllFoldersWithPrv.FolderInfo(AllFoldersWithPrv.FolderInfo.Length - 1).Files(AllFoldersWithPrv.FolderInfo(AllFoldersWithPrv.FolderInfo.Length - 1).Files.Length - 1).TypeID Then
                                AllFoldersWithPrv.FolderInfo(AllFoldersWithPrv.FolderInfo.Length - 1).Files(AllFoldersWithPrv.FolderInfo(AllFoldersWithPrv.FolderInfo.Length - 1).Files.Length - 1).TypeName = AllFilesType(i).TypeName
                                Exit For
                            End If
                        Next
                    Loop
                    SqlDR3.Close()
NextLoop:
                Loop
                SqlDR2.Close()
            Loop
            SQLDR.Close()
        Catch ex As Exception
            MsgBox(ex.StackTrace, MsgBoxStyle.Information)
        End Try
ExitPoint:
        SQLDR.Close()
        SQLCon.Close()
        SqlCon2.Close()
        SqlCon3.Close()
        'Ordering
        Dim Int2 As Integer
        If AllFoldersWithPrv.FolderInfo IsNot Nothing Then
            For Int1 = 1 To 5
                For Int2 = 0 To AllFoldersWithPrv.FolderInfo.Length - 1
                    If AllFoldersWithPrv.FolderInfo(Int2).FolderPath.Split("\").Length = Int1 Then
                        If AllFoldersWithPrv2.FolderInfo Is Nothing Then
                            ReDim AllFoldersWithPrv2.FolderInfo(0)
                            ReDim AllFoldersWithPrv2.PrvOperationsType(0)
                        Else
                            ReDim Preserve AllFoldersWithPrv2.FolderInfo(AllFoldersWithPrv2.FolderInfo.Length)
                            ReDim Preserve AllFoldersWithPrv2.PrvOperationsType(AllFoldersWithPrv2.PrvOperationsType.Length)
                        End If
                        AllFoldersWithPrv2.FolderInfo(AllFoldersWithPrv2.FolderInfo.Length - 1) = AllFoldersWithPrv.FolderInfo(Int2)
                        AllFoldersWithPrv2.FolderInfo(AllFoldersWithPrv2.FolderInfo.Length - 1) = AllFoldersWithPrv.FolderInfo(Int2)
                        AllFoldersWithPrv2.FolderInfo(AllFoldersWithPrv2.FolderInfo.Length - 1).FolderPath = DataPath & AllFoldersWithPrv2.FolderInfo(AllFoldersWithPrv2.FolderInfo.Length - 1).FolderPath
                        AllFoldersWithPrv2.PrvOperationsType(AllFoldersWithPrv2.PrvOperationsType.Length - 1) = AllFoldersWithPrv.PrvOperationsType(Int2)
                    End If
                Next
            Next
        End If
    End Sub
    Public Function GetAllFilesType(ByVal IconsPath As String) As String
        ReDim AllFilesType(0)
        Try
            SQLCmd.CommandText = "select TypeID,TypeName,TypeIconPath,TypeDic,TypeExt from dbo.FileType"
            SQLCon.Open()
            SQLDR = SQLCmd.ExecuteReader
            Do While SQLDR.Read
                AllFilesType(AllFilesType.Length - 1).TypeID = SQLDR.GetValue(0).ToString.Trim
                AllFilesType(AllFilesType.Length - 1).TypeName = SQLDR.GetValue(1).ToString.Trim
                If SQLDR.GetValue(2).ToString.Trim = "" Then
                    AllFilesType(AllFilesType.Length - 1).TypeIcon = ""
                Else
                    AllFilesType(AllFilesType.Length - 1).TypeIcon = IconsPath & SQLDR.GetValue(2).ToString.Trim.Substring(0)
                End If
                AllFilesType(AllFilesType.Length - 1).TypeDesc = SQLDR.GetValue(3).ToString.Trim
                AllFilesType(AllFilesType.Length - 1).TypeExt = SQLDR.GetValue(4).ToString.Trim
                ReDim Preserve AllFilesType(AllFilesType.Length)
            Loop
            ReDim Preserve AllFilesType(AllFilesType.Length - 2)
        Catch ex As Exception
            Return ex.Message
        End Try
        SQLDR.Close()
        SQLCon.Close()
        Return Nothing
    End Function
    Public Sub GetAllprivilege(ByVal ProjectID As String)
        Try
            ReDim Allprivilege(0)
            SQLCmd.CommandText = "select RullID,RullName from dbo.Rulls where ProID='" & ProjectID & "'"
            SQLCon.Open()
            SQLDR = SQLCmd.ExecuteReader
            Do While SQLDR.Read
                Allprivilege(Allprivilege.Length - 1).privilegeID = SQLDR.GetValue(0).ToString.Trim
                Allprivilege(Allprivilege.Length - 1).privilegeName = SQLDR.GetValue(1).ToString.Trim
                Allprivilege(Allprivilege.Length - 1).privilegeSelected = False
                ReDim Preserve Allprivilege(Allprivilege.Length)
            Loop
            ReDim Preserve Allprivilege(Allprivilege.Length - 2)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        SQLDR.Close()
        SQLCon.Close()
    End Sub
    Public Function GetUserPrivilages() As String
        Try
            SQLCmd.CommandText = "Select RullID from dbo.Users_Rulls where UsrID='" & CUser.UID & "'"
            SQLCon.Open()
            SQLDR = SQLCmd.ExecuteReader
            Do While SQLDR.Read
                If CUser.UsrPrv Is Nothing Then
                    ReDim CUser.UsrPrv(0)
                Else
                    ReDim Preserve CUser.UsrPrv(CUser.UsrPrv.Length)
                End If
                CUser.UsrPrv(CUser.UsrPrv.Length - 1).privilegeID = SQLDR.GetString(0).Trim
            Loop
        Catch ex As Exception
            SQLDR.Close()
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLDR.Close()
        SQLCon.Close()
        Return Nothing
    End Function
    Public Sub GetSelectedFolderprivilege(ByVal ProjectID As String, ByVal FolderID As String)
        Try
            GetAllprivilege(ProjectID)
            SQLCmd.CommandText = "select RullID from dbo.Folder_Rull where FolderID='" & FolderID & "'"
            SQLCon.Open()
            SQLDR = SQLCmd.ExecuteReader
            Dim RullID As String = ""
            Do While SQLDR.Read
                RullID = SQLDR.GetValue(0).ToString.Trim
                Dim i As Integer = 0
                For i = 0 To Allprivilege.Length - 1
                    If RullID = Allprivilege(i).privilegeID Then
                        Allprivilege(i).privilegeSelected = True
                        Exit For
                    End If
                Next
            Loop
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        SQLDR.Close()
        SQLCon.Close()
    End Sub
    Public Function SaveFolderprivileges(ByVal FolderID As String, ByVal privilegesID() As String, ByVal CanWrite As Boolean, ByVal CanDelete As Boolean, ByVal AddOrRemove As Boolean) As String
        Try
            SQLCon.Open()
            Dim Write As Int16 : If CanWrite = True Then Write = 1 Else Write = 0
            Dim Delete As Int16 : If CanWrite = True Then Delete = 1 Else Delete = 0
            SQLTrn = SQLCon.BeginTransaction("[Egy]FalseX")
            SQLCmd.Transaction = SQLTrn
            Dim Int1 As Int16
            If AddOrRemove = True Then
                For Int1 = 0 To privilegesID.Length - 1
                    SQLCmd.CommandText = "SP_InsertNewFolderPrivilege @FolderID='" & FolderID & "', @RullID='" & privilegesID(Int1) & "', @CanWrite=" & Write & ", @CanDelete=" & Delete
                    SQLCmd.ExecuteNonQuery()
                    SQLCmd.CommandText = "SP_InsertNewFolderParentPrivilege @FolderID='" & FolderID & "', @RullID='" & privilegesID(Int1) & "'"
                    SQLCmd.ExecuteNonQuery()

                Next
            Else
                For Int1 = 0 To privilegesID.Length - 1
                    SQLCmd.CommandText = "Delete from dbo.Folder_Rull where FolderID='" & FolderID & "' and RullID='" & privilegesID(Int1) & "'"
                    SQLCmd.ExecuteNonQuery()
                Next
            End If
            SQLTrn.Commit()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            SQLTrn.Rollback()
            SQLDR.Close()
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLDR.Close()
        SQLCon.Close()
        Return Nothing
    End Function
    Public Function RemoveFile(ByVal FileID As String) As String
        Try
            SQLCmd.CommandText = "delete from FileInfo where FileID='" & FileID & "'"
            SQLCon.Open()
            SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            SQLCon.Close()
            Return (ex.Message)
        End Try
        SQLCon.Close()
        Return Nothing
    End Function
    Public Function InsertNewFolder(ByVal FolderName As String, ByVal FolderPath As String, ByVal CreatedIn As String, ByVal UserID As String, ByVal Disc As String, ByVal ProID As String, ByVal ParentID As String) As String
        Dim ErrorResult As String = Nothing
        Try
            SQLCmd.CommandText = "SP_InsertNewFolder @FolderName='" & FolderName & "',@FolderPath='" & FolderPath & "',@CreatedIn='" & CreatedIn & "',@UserID='" & UserID & "',@Disc='" & Disc & "',@ProID='" & ProID & "',@ParentID='" & ParentID & "'"
            SQLCon.Open()
            ErrorResult = SQLCmd.ExecuteScalar
        Catch
            SQLCon.Close()
            Return Nothing
        End Try
        SQLCon.Close()
        Return ErrorResult
    End Function
    Public Function RemoveFolder(ByVal FolderID As String) As String
        Try
            SQLCon.Open()
            SQLTrn = SQLCon.BeginTransaction("Eshta ya rgala")
            SQLCmd.Transaction = SQLTrn
            SQLCmd.CommandText = "delete from Folder_Rull where FolderID='" & FolderID & "'"
            SQLCmd.ExecuteNonQuery()
            SQLCmd.CommandText = "delete from dbo.folderinfo where folderid='" & FolderID & "'"
            SQLCmd.ExecuteNonQuery()
            SQLTrn.Commit()
        Catch ex As Exception
            SQLTrn.Rollback()
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLCon.Close()
        Return Nothing
    End Function
    Public Function GetAllProjectsPrivileges() As String
        Try
            AllProjectWithPrivileges = Nothing
            SQLCmd.CommandText = "Select ProID,ProName from dbo.Projects Select RullID,RullName,ProID from dbo.Rulls"
            SQLCon.Open()
            SQLDR = SQLCmd.ExecuteReader
            Do While SQLDR.Read
                If AllProjectWithPrivileges Is Nothing Then
                    ReDim AllProjectWithPrivileges(0)
                ElseIf Not AllProjectWithPrivileges(AllProjectWithPrivileges.Length - 1).ProjectID Is Nothing Then
                    ReDim Preserve AllProjectWithPrivileges(AllProjectWithPrivileges.Length)
                End If
                AllProjectWithPrivileges(AllProjectWithPrivileges.Length - 1).ProjectID = SQLDR.GetValue(0).ToString.Trim
                AllProjectWithPrivileges(AllProjectWithPrivileges.Length - 1).ProjectName = SQLDR.GetValue(1).ToString.Trim
            Loop
            Dim Int1 As Int16 = 0
            If SQLDR.NextResult Then
                Do While SQLDR.Read
                    For Int1 = 0 To AllProjectWithPrivileges.Length - 1
                        If SQLDR.GetValue(2).ToString.Trim = AllProjectWithPrivileges(Int1).ProjectID Then
                            If AllProjectWithPrivileges(Int1).InternalPrivileges Is Nothing Then
                                ReDim AllProjectWithPrivileges(Int1).InternalPrivileges(0)
                            ElseIf Not AllProjectWithPrivileges(Int1).InternalPrivileges(AllProjectWithPrivileges(Int1).InternalPrivileges.Length - 1).privilegeID Is Nothing Then
                                ReDim Preserve AllProjectWithPrivileges(Int1).InternalPrivileges(AllProjectWithPrivileges(Int1).InternalPrivileges.Length)
                            End If
                            AllProjectWithPrivileges(Int1).InternalPrivileges(AllProjectWithPrivileges(Int1).InternalPrivileges.Length - 1).privilegeID = SQLDR.GetValue(0).ToString.Trim
                            AllProjectWithPrivileges(Int1).InternalPrivileges(AllProjectWithPrivileges(Int1).InternalPrivileges.Length - 1).privilegeName = SQLDR.GetValue(1).ToString.Trim
                            Exit For
                        End If
                    Next
                Loop
            End If

        Catch ex As Exception
            SQLDR.Close()
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLDR.Close()
        SQLCon.Close()
        Return Nothing
    End Function
    Public Function SaveFolderDesc(ByVal FolderID As String, ByVal Desc As String) As String
        Try
            SQLCmd.CommandText = "update dbo.FolderInfo set Disc='" & Desc & "' where FolderID='" & FolderID & "'"
            SQLCon.Open()
            SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Return ex.Message
        End Try
        SQLCon.Close()
        Return Nothing
    End Function
    Public Function ChagneFolderName(ByVal FolderIDInStr As String, ByVal FolderName As String, ByVal NewPath As String, ByVal ProjectPath As String, ByRef AllFoldersWithPrv As PrivateFoldersPrvType, ByVal IP_Address As String, ByVal RPort As Int32) As Boolean
        Dim steps As Int16 = 0
        Try
            ReDim ListOfFoldersPathToChange(0)
            ReDim ListOfFilesPathToChage(0)
            '1- Get all folders that inside the selected folder to rename there pathes
            SQLCmd.CommandText = "select FolderID,FolderPath from dbo.FolderInfo where ProID='" & AllFoldersWithPrv.FolderInfo(FolderIDInStr).ProID & "'"
            SQLCon.Open()
            SQLDR = SQLCmd.ExecuteReader
            Dim FullPath As String = AllFoldersWithPrv.FolderInfo(FolderIDInStr).FolderPath
            Dim TwoParts As String = ""
            Do While SQLDR.Read
                TwoParts = ProjectPath & SQLDR.GetValue(1).ToString.Trim
                If TwoParts.Contains(FullPath) Then
                    ListOfFoldersPathToChange(ListOfFoldersPathToChange.Length - 1).FolderID = SQLDR.GetValue(0).ToString.Trim
                    ListOfFoldersPathToChange(ListOfFoldersPathToChange.Length - 1).FolderPath = ProjectPath & SQLDR.GetValue(1).ToString.Trim
                    ReDim Preserve ListOfFoldersPathToChange(ListOfFoldersPathToChange.Length)
                End If
            Loop
            ReDim Preserve ListOfFoldersPathToChange(ListOfFoldersPathToChange.Length - 2)
            SQLDR.Close()
            '2- Get all files that inside the selected folder to rename there pathes
            SQLCmd.CommandText = "select FileID,FilePath,Inuse from dbo.FileInfo where ProID='" & AllFoldersWithPrv.FolderInfo(FolderIDInStr).ProID & "'"
            SQLDR = SQLCmd.ExecuteReader
            Do While SQLDR.Read
                TwoParts = ProjectPath & SQLDR.GetValue(1).ToString.Trim
                If TwoParts.Contains(FullPath) Then
                    If SQLDR.GetValue(2).ToString.Trim = "1" Then 'Check if file in use(1) or not(0)
                        SQLDR.Close() : SQLCon.Close() : Return False
                    End If
                    ListOfFilesPathToChage(ListOfFilesPathToChage.Length - 1).FileID = SQLDR.GetString(0).Trim
                    ListOfFilesPathToChage(ListOfFilesPathToChage.Length - 1).FilePath = ProjectPath & SQLDR.GetString(1).Trim
                    ReDim Preserve ListOfFilesPathToChage(ListOfFilesPathToChage.Length)
                End If
            Loop
            ReDim Preserve ListOfFilesPathToChage(ListOfFilesPathToChage.Length - 2)
            SQLDR.Close()
            '3- Renaming folders
            Dim SqlCmd2 As New SqlClient.SqlCommand("", SQLCon, SQLTrn)
            SQLTrn = SQLCon.BeginTransaction("Eshta ya rgala")
            SqlCmd2.Transaction = SQLTrn
            Dim i As Int16 = 0
            Dim NewPath2 As String
            For i = 0 To ListOfFoldersPathToChange.Length - 1
                NewPath2 = NewPath & ListOfFoldersPathToChange(i).FolderPath.Substring(AllFoldersWithPrv.FolderInfo(FolderIDInStr).FolderPath.Length)
                'MsgBox(NewPath2.Substring(ProjectPath.Length))
                SqlCmd2.CommandText = "Update dbo.FolderInfo set FolderPath='" & NewPath2.Substring(ProjectPath.Length) & "' where FolderID='" & ListOfFoldersPathToChange(i).FolderID & "'"
                SqlCmd2.ExecuteNonQuery()
            Next
            SqlCmd2.CommandText = "update dbo.FolderInfo set FolderName='" & FolderName & "' where FolderID='" & AllFoldersWithPrv.FolderInfo(FolderIDInStr).FolderID & "'"
            SqlCmd2.ExecuteNonQuery()
            '4- Renaming files
            For i = 0 To ListOfFilesPathToChage.Length - 1
                NewPath2 = NewPath & ListOfFilesPathToChage(i).FilePath.Substring(AllFoldersWithPrv.FolderInfo(FolderIDInStr).FolderPath.Length)
                SqlCmd2.CommandText = "Update dbo.FileInfo set FilePath='" & NewPath2.Substring(ProjectPath.Length) & "' where FileID='" & ListOfFilesPathToChage(i).FileID & "'"
                SqlCmd2.ExecuteNonQuery()
            Next
            '5- Renaming the Phy folder inside the hard disk
            ErrorProvider = Nothing
            ErrorProvider = NWLib.MoveFolder(IP_Address, RPort, AllFoldersWithPrv.FolderInfo(FolderIDInStr).FolderPath, NewPath)
            If ErrorProvider <> Nothing Then
                GoTo ExitPoint
            End If
            steps = 1
            SQLTrn.Commit() : SQLDR.Close() : SQLCon.Close() : Return True
        Catch ex As Exception
            If steps = 1 Then
                'Make rollback for the above step 1 statment
                SQLTrn.Rollback()
            End If
        End Try
ExitPoint:
        SQLDR.Close() : SQLCon.Close() : Return False
    End Function
    Public Sub InsertNewFile(ByVal FileName As String, ByVal FilePath As String, ByVal CreatedIn As String, ByVal UsrID As String, ByVal Dis As String, ByVal ProID As String, ByVal FolderID As String, ByVal TypeID As String, ByRef Result As String)
        Try
            SQLCmd.CommandText = "SP_InsertNewFile @FileName='" & FileName & "',@FilePath='" & FilePath & "',@CreatedIn='" & CreatedIn & "',@UsrID='" & UsrID & "',@Dis='" & Dis & "',@ProID='" & ProID & "',@FolderID='" & FolderID & "',@TypeID='" & TypeID & "'"
            SQLCon.Open()
            Result = SQLCmd.ExecuteScalar
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        SQLDR.Close()
        SQLCon.Close()
    End Sub
    Public Function EditFileInfo(ByVal FileID As String, ByVal NewFileName As String, ByVal NewDescription As String) As String
        Try
            SQLCmd.CommandText = "Update dbo.FileInfo set FileName='" & NewFileName & "' , Dis='" & NewDescription & "' where FileID='" & FileID & "'"
            SQLCon.Open()
            SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLCon.Close()
        Return Nothing
    End Function
    Public Function LockFile(ByVal FileID As String, ByVal UserID As String) As String
        Try
            SQLCmd.CommandText = "Update dbo.FileInfo Set InUseUserID='" & UserID & "',InUse=1 Where FileID='" & FileID & "'"
            SQLCon.Open()
            SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLCon.Close()
        Return Nothing
    End Function
    Public Function UnLockFile(ByVal FileID As String) As String
        Try
            SQLCmd.CommandText = "Update dbo.FileInfo Set InUseUserID=NULL,InUse=0 Where FileID='" & FileID & "'"
            SQLCon.Open()
            SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLCon.Close()
        Return Nothing
    End Function
    Public Function GetAllLockedFileByUser(ByVal UsrID As String, ByRef LockedFiles() As LockedFilesSTR) As String
        ReDim LockedFiles(-1)
        Try
            SQLCmd.CommandText = "SP_GetAllLockFilesByUser @UsrID='" & UsrID & "'"
            SQLCon.Open()
            SQLDR = SQLCmd.ExecuteReader
            Do While SQLDR.Read
                If LockedFiles.Length = 0 Then
                    ReDim LockedFiles(0)
                Else
                    ReDim Preserve LockedFiles(LockedFiles.Length)
                End If
                LockedFiles(LockedFiles.Length - 1).FileID = SQLDR.GetString(0).Trim
                LockedFiles(LockedFiles.Length - 1).FileName = SQLDR.GetString(1).Trim
                LockedFiles(LockedFiles.Length - 1).FilePath = SQLDR.GetString(2).Trim
                LockedFiles(LockedFiles.Length - 1).ProjectName = SQLDR.GetString(3).Trim
                If SQLDR.NextResult Then : End If
            Loop
        Catch ex As Exception
            SQLDR.Close()
            SQLCon.Close()
            Return ex.Message
        End Try
        SQLDR.Close()
        SQLCon.Close()
        Return Nothing
    End Function
    
    'Registry Functions
    Public Sub PrepareReg()
        Dim RegKey As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE", True)
        Dim arr() As String
        Dim ForInt As Integer = 0
        arr = Registry.LocalMachine.OpenSubKey("SOFTWARE").GetSubKeyNames
        For ForInt = 0 To arr.Length - 1
            If arr(ForInt) = "Mena Data Center" Then
            End If
        Next
        RegKey.CreateSubKey("Mena Data Center")
    End Sub
    Public Sub SetRegValue(ByVal KeyValue As String, ByVal ValueName As RegKeyValues)
        '"SQLString"
        PrepareReg()
        Registry.LocalMachine.OpenSubKey("SOFTWARE\Mena Data Center", True).SetValue(ValueName.ToString, KeyValue)
    End Sub
    Public Function GetRegValue(ByRef ConStr As String, ByVal ValueName As RegKeyValues) As Boolean
        PrepareReg()
        Dim arr() As String = Registry.LocalMachine.OpenSubKey("SOFTWARE\Mena Data Center", False).GetValueNames
        Dim ForInt As Integer = 0
        For ForInt = 0 To arr.Length - 1
            If arr(ForInt) = ValueName.ToString Then
                ConStr = Registry.LocalMachine.OpenSubKey("SOFTWARE\Mena Data Center", False).GetValue(ValueName.ToString)
                Return True
            End If
        Next
        Return False
    End Function
    Public Sub ResetConnection()
        Registry.LocalMachine.DeleteSubKey("SOFTWARE\Mena Data Center")
        'Registry.LocalMachine.OpenSubKey("SOFTWARE\Mena Data Center", True).DeleteValue(RegKeyValues.PW)
    End Sub
    'Binary Function
    Public Overloads Function CharToBinary(ByVal Strings As String) As String
        Dim int As Int16
        Dim fout As String = ""
        Dim out As String = ""
        For int = 0 To Strings.Length - 1
            Dim str2 As Int64 = Asc(Strings.Chars(int))
            str2 = (str2 * 9) / 8
            Dim mydiv As Int64
            Do While str2 <> 0
                str2 = DivRem(str2, 2, mydiv)
                If mydiv > 0 Then
                    out = 1 & out
                Else
                    out = 0 & out
                End If
            Loop
            out = New String("0", 8 - out.Length) & out
            fout &= out
            out = ""
        Next
        Return fout
    End Function
    Public Function Binarytochar(ByVal Binarystring As String) As String
        Dim fout As String = ""
        Dim back_to_normal As Int64
        Dim arr((Binarystring.Length / 8) - 1) As String
        Dim i As Int16
        For i = 0 To (Binarystring.Length / 8) - 1
            arr(i) = Binarystring.Substring(i * 8, 8)
        Next i
        For i = 0 To arr.Length - 1
            Dim str1 As String = arr(i).Substring(0, 4)
            Dim str2 As String = arr(i).Substring(4)
            Dim int As New Int16
            Dim out1 As New Int16
            Dim out2 As New Int16
            If str1.Chars(0) = "1" Then
                out1 += 8
            End If
            If str1.Chars(1) = "1" Then
                out1 += 4
            End If
            If str1.Chars(2) = "1" Then
                out1 += 2
            End If
            If str1.Chars(3) = "1" Then
                out1 += 1
            End If
            If str2.Chars(0) = "1" Then
                out2 += 8
            End If
            If str2.Chars(1) = "1" Then
                out2 += 4
            End If
            If str2.Chars(2) = "1" Then
                out2 += 2
            End If
            If str2.Chars(3) = "1" Then
                out2 += 1
            End If
            out2 = out2 * 1
            out1 = out1 * 16
            back_to_normal = out1 + out2
            back_to_normal = (back_to_normal * 8) / 9
            fout &= Chr(back_to_normal)
        Next
        Return fout
    End Function
End Class
Public Class NetworkFunction
    Public Enum Commands 'this is the commands between the server and the client
        Ping ' command 0
        ReciveFile 'command 1
        SendFile 'command 2
        CreateFile 'command 3
        CreateFolder 'command 4
        RemoveFolder 'Command 5
        RemoveFile 'Command 6
        MoveFolder 'Command 7
    End Enum
    Public Function CreateFolder(ByVal IP_Address As String, ByVal RPort As Int32, ByVal FolderPath As String) As String
        Dim FullString As String = Commands.CreateFolder & FolderPath
        Dim Buffers(4096) As Byte
        Dim Sok As New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
        Dim Created As Int16
        Try
            Buffers = Encoding.Default.GetBytes(FullString)
            Sok.Connect(IP_Address, RPort)
            If Sok.Connected = True Then
                Sok.Send(Buffers, FullString.Length, SocketFlags.None)
                Sok.Receive(Buffers, 1, SocketFlags.None)
                Created = Val(Buffers(0))
                If Created = 0 Then
                    Sok.Close()
                    Sok = Nothing
                    Return "Can't create folder or folder already existed"
                End If
            Else
                Return "No Connection available"
            End If
        Catch ex As Exception
            Try : Sok.Close() : Sok = Nothing : Catch : End Try
            Return ex.Message
        End Try
        Try : Sok.Close() : Sok = Nothing : Catch : End Try
        Return Nothing
    End Function
    Public Function MoveFolder(ByVal IP_Address As String, ByVal RPort As Int32, ByVal TFolder As String, ByVal DFolder As String) As String
        Dim FullString As String = Commands.MoveFolder & TFolder & "/" & DFolder
        Dim Buffers(4096) As Byte
        Dim Sok As New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
        Dim Created As Int16
        Try
            Buffers = Encoding.Default.GetBytes(FullString)
            Sok.Connect(IP_Address, RPort)
            If Sok.Connected = True Then
                Sok.Send(Buffers, FullString.Length, SocketFlags.None)
                Sok.Receive(Buffers, 1, SocketFlags.None)
                Created = Val(Buffers(0))
                If Created = 0 Then
                    Sok.Close()
                    Sok = Nothing
                    Return "Can't create folder or folder already existed"
                End If
            Else
                Return "No Connection available"
            End If
        Catch ex As Exception
            Try : Sok.Close() : Sok = Nothing : Catch : End Try
            Return ex.Message
        End Try
        Try : Sok.Close() : Sok = Nothing : Catch : End Try
        Return Nothing
    End Function
    Public Function RemoveFile(ByVal IP_Address As String, ByVal RPort As Int32, ByVal FilePath As String, ByVal TrashFolder As String) As String
        Dim FullString As String = Commands.RemoveFile & FilePath & "/" & TrashFolder & Now.Year & "-" & Now.Month & "-" & Now.Day & "\"
        Dim Buffers(4096) As Byte
        Dim Sok As New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
        Dim Created As Int16
        Try
            Buffers = Encoding.Default.GetBytes(FullString)
            Sok.Connect(IP_Address, RPort)
            If Sok.Connected = True Then
                Sok.Send(Buffers, FullString.Length, SocketFlags.None)
                Sok.Receive(Buffers, 1, SocketFlags.None)
                Created = Val(Buffers(0))
                If Created = 0 Then
                    Sok.Close()
                    Sok = Nothing
                    Return "Can't remove file or file in use"
                End If
            Else
                Return "No Connection available"
            End If
        Catch ex As Exception
            Try : Sok.Close() : Sok = Nothing : Catch : End Try
            Return ex.Message
        End Try
        Try : Sok.Close() : Sok = Nothing : Catch : End Try
        Return Nothing
    End Function
    Public Function RemoveFolder(ByVal IP_Address As String, ByVal RPort As Int32, ByVal FolderPath As String, ByVal TrashFolder As String)
        Dim FullString As String = Commands.RemoveFolder & FolderPath & "/" & TrashFolder & Now.Year & "-" & Now.Month & "-" & Now.Day & "\"
        Dim Buffers(4096) As Byte
        Dim Sok As New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
        Dim Created As Int16
        Try
            Buffers = Encoding.Default.GetBytes(FullString)
            Sok.Connect(IP_Address, RPort)
            If Sok.Connected = True Then
                Sok.Send(Buffers, FullString.Length, SocketFlags.None)
                Sok.Receive(Buffers, 1, SocketFlags.None)
                Created = Val(Buffers(0))
                If Created = 0 Then
                    Sok.Close()
                    Sok = Nothing
                    Return "Can't remove file or file in use"
                End If
            Else
                Return "No Connection available"
            End If
        Catch ex As Exception
            Try : Sok.Close() : Sok = Nothing : Catch : End Try
            Return ex.Message
        End Try
        Try : Sok.Close() : Sok = Nothing : Catch : End Try
        Return Nothing
    End Function
End Class