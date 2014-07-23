Imports System.IO
Public Class ObjectPropertyFrm
    Private Int1 As Int16
    Private Int2 As Int16
    Private NewFolderErrorResult As String = ""
    Private ErrorProvider As String = Nothing
    Public SelectedPrv() As FunctionLib.DataCenterServerLib.privilegeType
    Public UnSelectedPrv() As FunctionLib.DataCenterServerLib.privilegeType
    Private TempPrv() As FunctionLib.DataCenterServerLib.privilegeType
    Public SelConsID() As String
    Public NotSelConsID() As String
    Public SelContID() As String
    Public NotSelContID() As String

    Private Sub ObjectPropertyFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If PropertyObjectInfo.ObjecyType = ObjectType.Project Then
            '1- Loading Project Consultants Tab Information
            If FunLib.GetAllConsultants(RelatedFiles, True) <> Nothing Then
                Exit Sub
            End If
            FunLib.GetProjectConsultants(ProjectInfoSTR.ProjectID) 'Need result Debuging
            If FunLib.AllConsultanats Is Nothing Then
                Exit Sub
            End If
            For Int1 = 0 To FunLib.AllConsultanats.Length - 1
                If FunLib.AllConsultanats(Int1).Selected = 1 Then
                    SelConsLB.Items.Add(FunLib.AllConsultanats(Int1).ConsName)
                    If SelConsID Is Nothing Then
                        ReDim SelConsID(0)
                    Else
                        ReDim Preserve SelConsID(SelConsID.Length)
                    End If
                    SelConsID(SelConsID.Length - 1) = FunLib.AllConsultanats(Int1).ConsID
                Else
                    AllConsLB.Items.Add(FunLib.AllConsultanats(Int1).ConsName)
                    If NotSelConsID Is Nothing Then
                        ReDim NotSelConsID(0)
                    Else
                        ReDim Preserve NotSelConsID(NotSelConsID.Length)
                    End If
                    NotSelConsID(NotSelConsID.Length - 1) = FunLib.AllConsultanats(Int1).ConsID
                End If
            Next
            '2- Loading Project Contractors Tab Information
            If FunLib.GetAllContractors(True) <> Nothing Then
                Exit Sub
            End If
            FunLib.GetProjectContractors(ProjectInfoSTR.ProjectID) 'Need result Debuging
            If FunLib.AllContractors Is Nothing Then
                Exit Sub
            End If
            For Int1 = 0 To FunLib.AllContractors.Length - 1
                If FunLib.AllContractors(Int1).Selected = 1 Then
                    SelContLB.Items.Add(FunLib.AllContractors(Int1).ContName)
                    If SelContID Is Nothing Then
                        ReDim SelContID(0)
                    Else
                        ReDim Preserve SelContID(SelContID.Length)
                    End If
                    SelContID(SelContID.Length - 1) = FunLib.AllContractors(Int1).ContID
                Else
                    AllContLB.Items.Add(FunLib.AllContractors(Int1).ContName)
                    If NotSelContID Is Nothing Then
                        ReDim NotSelContID(0)
                    Else
                        ReDim Preserve NotSelContID(NotSelContID.Length)
                    End If
                    NotSelContID(NotSelContID.Length - 1) = FunLib.AllContractors(Int1).ContID
                End If
            Next
        End If
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
    Private Sub LBAllprivileges_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LBAllprivileges.DoubleClick
        If LBAllprivileges.SelectedIndex <> -1 Then
            BtnAddSelected_Click(sender, e)
        End If
    End Sub
    Private Sub LBAllprivileges_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBAllprivileges.SelectedIndexChanged
        If LBAllprivileges.SelectedIndex <> -1 Then
            BtnAddSelected.Enabled = True
        Else
            BtnAddSelected.Enabled = False
        End If

        BtnSavePriv.Enabled = True
    End Sub
    Private Sub BtnAddSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddSelected.Click
        If SelectedPrv Is Nothing Then
            ReDim SelectedPrv(0)
        Else
            ReDim Preserve SelectedPrv(SelectedPrv.Length)
        End If
        SelectedPrv(SelectedPrv.Length - 1) = UnSelectedPrv(LBAllprivileges.SelectedIndex)
        If UnSelectedPrv.Length > 1 Then
            Dim TempPrv(UnSelectedPrv.Length - 1) As FunctionLib.DataCenterServerLib.privilegeType
            Array.Copy(UnSelectedPrv, TempPrv, UnSelectedPrv.Length)
            ReDim UnSelectedPrv(0)
            For Int1 = 0 To TempPrv.Length - 1
                If Int1 <> LBAllprivileges.SelectedIndex Then
                    UnSelectedPrv(UnSelectedPrv.Length - 1) = TempPrv(Int1)
                    ReDim Preserve UnSelectedPrv(UnSelectedPrv.Length)
                End If
            Next
            ReDim Preserve UnSelectedPrv(UnSelectedPrv.Length - 2)
        Else
            ReDim UnSelectedPrv(-1)
            'UnSelectedPrv = Nothing
        End If
        LBSelectedprivileges.Items.Add(LBAllprivileges.SelectedItem.ToString)
        LBAllprivileges.Items.Remove(LBAllprivileges.SelectedItem)
    End Sub
    Private Sub LBSelectedprivileges_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LBSelectedprivileges.DoubleClick
        If LBSelectedprivileges.SelectedIndex <> -1 Then
            BtnRemoveSelected_Click(sender, e)
        End If
    End Sub
    Private Sub LBSelectedprivileges_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles LBSelectedprivileges.GotFocus
        If LBSelectedprivileges.SelectedIndex <> -1 Then
            CBDelete.Enabled = True
            CBWrite.Enabled = True
        Else
            CBDelete.Enabled = False
            CBWrite.Enabled = False
        End If
    End Sub
    Private Sub LBSelectedprivileges_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBSelectedprivileges.SelectedIndexChanged
        If LBSelectedprivileges.SelectedIndex <> -1 Then
            BtnRemoveSelected.Enabled = True
            CBDelete.Enabled = True
            CBWrite.Enabled = True
            If SelectedPrv(LBSelectedprivileges.SelectedIndex).CanWrite = 0 Then
                CBWrite.Checked = False
            Else
                CBWrite.Checked = True
            End If
            If SelectedPrv(LBSelectedprivileges.SelectedIndex).CanDelete = 0 Then
                CBDelete.Checked = False
            Else
                CBDelete.Checked = True
            End If
        Else
            CBDelete.Enabled = False
            CBWrite.Enabled = False
            CBDelete.Checked = False
            CBWrite.Checked = False
            BtnRemoveSelected.Enabled = False
        End If
    End Sub
    Private Sub BtnRemoveSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemoveSelected.Click
        If UnSelectedPrv Is Nothing Then
            ReDim UnSelectedPrv(0)
        Else
            ReDim Preserve UnSelectedPrv(UnSelectedPrv.Length)
        End If
        UnSelectedPrv(UnSelectedPrv.Length - 1) = SelectedPrv(LBSelectedprivileges.SelectedIndex)
        If SelectedPrv.Length > 1 Then
            Dim TempPrv(SelectedPrv.Length - 1) As FunctionLib.DataCenterServerLib.privilegeType
            Array.Copy(SelectedPrv, TempPrv, SelectedPrv.Length)
            ReDim SelectedPrv(0)
            For Int1 = 0 To TempPrv.Length - 1
                If Int1 <> LBSelectedprivileges.SelectedIndex Then
                    SelectedPrv(SelectedPrv.Length - 1) = TempPrv(Int1)
                    ReDim Preserve SelectedPrv(SelectedPrv.Length)
                End If
            Next
            ReDim Preserve SelectedPrv(SelectedPrv.Length - 2)
        Else
            ReDim SelectedPrv(-1)
            'SelectedPrv = Nothing
        End If
        LBAllprivileges.Items.Add(LBSelectedprivileges.SelectedItem.ToString)
        LBSelectedprivileges.Items.Remove(LBSelectedprivileges.SelectedItem)
    End Sub
    Private Sub BtnAddAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddAll.Click
        For Int1 = 0 To LBAllprivileges.Items.Count - 1
            If SelectedPrv Is Nothing Then
                ReDim SelectedPrv(0)
            Else
                ReDim Preserve SelectedPrv(SelectedPrv.Length)
            End If
            SelectedPrv(SelectedPrv.Length - 1) = UnSelectedPrv(Int1)
            LBSelectedprivileges.Items.Add(LBAllprivileges.Items.Item(Int1))
        Next
        ReDim UnSelectedPrv(-1)
        'UnSelectedPrv = Nothing
        LBAllprivileges.Items.Clear()
    End Sub
    Private Sub BtnBtnRemoveAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBtnRemoveAll.Click
        For Int1 = 0 To LBSelectedprivileges.Items.Count - 1
            If UnSelectedPrv Is Nothing Then
                ReDim UnSelectedPrv(0)
            Else
                ReDim Preserve UnSelectedPrv(UnSelectedPrv.Length)
            End If
            UnSelectedPrv(UnSelectedPrv.Length - 1) = SelectedPrv(Int1)
            LBAllprivileges.Items.Add(LBSelectedprivileges.Items.Item(Int1))
        Next
        ReDim SelectedPrv(-1)
        'UnSelectedPrv = Nothing
        LBSelectedprivileges.Items.Clear()
    End Sub
    Private Sub BtnEditFolderName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditFolderName.Click
        If BtnEditFolderName.Text = "Edit" Then
            BtnEditFolderName.Text = "Cancel"
            TxtFolderName.Enabled = True
        Else
            BtnEditFolderName.Text = "Edit"
            TxtFolderName.Text = FunLib.Folders(PropertyObjectInfo.FolderIndex).FolderName
            TxtFolderName.Enabled = False
        End If
    End Sub
    Private Sub BtnSavePriv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSavePriv.Click
        If MsgBox("Are you sure ?", MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.No Then
            Exit Sub
        End If
        If PropertyObjectInfo.ObjecyType = ObjectType.ExistedFolder Then 'If the folder existed in the array
            If UnSelectedPrv IsNot Nothing Then
                FunLib.SaveFolderprivileges(FunLib.Folders(PropertyObjectInfo.FolderIndex).FolderID, UnSelectedPrv, False)
            End If
            If SelectedPrv IsNot Nothing Then
                FunLib.SaveFolderprivileges(FunLib.Folders(PropertyObjectInfo.FolderIndex).FolderID, SelectedPrv, True)
            End If
            FunLib.GetSelectedFolderprivilege(FunLib.Folders(PropertyObjectInfo.FolderIndex).ProID, FunLib.Folders(PropertyObjectInfo.FolderIndex).FolderID)
            MsgBox_("Privilages saved...", 123, 23, True, Me)
        ElseIf PropertyObjectInfo.ObjecyType = ObjectType.NewFolder Then
            'If the folder doesn't existed in the array
            If UnSelectedPrv IsNot Nothing Then
                FunLib.SaveFolderprivileges(NewFolderErrorResult, SelectedPrv, True)
            End If
            If SelectedPrv IsNot Nothing Then
                FunLib.SaveFolderprivileges(NewFolderErrorResult, UnSelectedPrv, False)
            End If
            FunLib.GetSelectedFolderprivilege(FunLib.Folders(PropertyObjectInfo.FolderIndex).ProID, NewFolderErrorResult)
            MsgBox_("Privilages saved...", 123, 23, True, Me)
        End If
    End Sub
    Private Sub BtnSaveFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveFolder.Click
        ErrorProvider = Nothing
        If TxtFolderName.Enabled = True And TxtFolderName.Text.Trim.Length > 0 And TxtFolderName.Text.Trim.ToLower <> FunLib.Folders(PropertyObjectInfo.FolderIndex).FolderName.ToLower Then
            Dim arr() As String = FunLib.Folders(PropertyObjectInfo.FolderIndex).FolderPath.Split("\")
            Dim NewPath As String = ""
            Dim i As Int16
            For i = 0 To arr.Length - 2
                NewPath &= arr(i) & "\"
            Next
            NewPath &= TxtFolderName.Text.Trim
            Dim DoneFalg As Boolean = False
            DoneFalg = FunLib.ChagneFolderName(PropertyObjectInfo.FolderIndex, TxtFolderName.Text.Trim, NewPath, ProjectsPath)
            If DoneFalg = True Then
                FrmMainForm.LVFiles.Items.Clear()
                FrmMainForm.FillFolders()
                BtnEditFolderName.Text = "Edit"
                TxtFolderName.Enabled = False
                MsgBox_("Folder remaned complate - Data saved successfully", 10, 23, True, Me)
            Else
                MsgBox_("Sorry cant change the folder name", 13, 23, False, Me)
            End If
        Else
        End If
        If TxtFolderDisc.Text.Trim.ToLower <> FunLib.Folders(PropertyObjectInfo.FolderIndex).Disc.ToLower Then
            ErrorProvider = FunLib.SaveFolderDesc(FunLib.Folders(PropertyObjectInfo.FolderIndex).FolderID, TxtFolderDisc.Text.Trim)
            FunLib.Folders(PropertyObjectInfo.FolderIndex).Disc = TxtFolderDisc.Text.Trim
            MsgBox_("Folder description updated", 96, 23, True, Me)
        End If
    End Sub
    Private Sub BtnEditFileName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditFileName.Click
        If BtnEditFileName.Text = "Edit" Then
            BtnEditFileName.Text = "Cancel"
            TxtFileName.Enabled = True
        Else
            BtnEditFileName.Text = "Edit"
            TxtFileName.Text = FunLib.Folders(PropertyObjectInfo.FolderIndex).Files(PropertyObjectInfo.FileIndex).FileName
            TxtFileName.Enabled = False
        End If
    End Sub
    Private Sub BtnBrowseNewFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBrowseNewFile.Click
        Dim OFD As New OpenFileDialog
        Dim FileInf As System.IO.FileInfo
        OFD.Filter = "All Files (*.*)|*.*"
        OFD.CheckFileExists = True
        OFD.CheckPathExists = True
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            FileInf = New System.IO.FileInfo(OFD.FileName)
            If CInt(FileInf.Length / 1048576) > 50 Then
                MsgBox("File must be less than 50M   ", MsgBoxStyle.Information)
            Else
                LblNewFilePath.Text = OFD.FileName
            End If
        Else
            LblNewFilePath.Text = ""
        End If
    End Sub
    Private Sub TxtNewFileName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNewFileName.TextChanged, LblNewFilePath.TextChanged
        If TxtNewFileName.Text.Trim.Length > 0 And LblNewFilePath.Text.Trim.Length > 0 Then
            BtnSaveNewFile.Enabled = True
        Else
            BtnSaveNewFile.Enabled = False
        End If
    End Sub
    Private Sub BtnSaveNewFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveNewFile.Click
        Dim FileType As String = "MDC"
        If FileTypeCB.SelectedIndex <> -1 Then
            FileType = FunLib.AllFilesType(FileTypeCB.SelectedIndex).TypeExt
        End If
        Dim FilePathFolders() As String = LblNewFilePath.Text.Split("\")
        Dim NewFileName As String = FilePathFolders(FilePathFolders.Length - 1)
        For Int1 = 0 To 10000
            NewFileName = FilePathFolders(FilePathFolders.Length - 1) & "_" & Int1 & "." & FileType
            If Not System.IO.File.Exists(FunLib.Folders(PropertyObjectInfo.FolderIndex).FolderPath & "\" & NewFileName) Then
                'Copying File
                Try
                    Dim FSR As New FileStream(LblNewFilePath.Text, FileMode.Open, FileAccess.Read, FileShare.Read, 4096)
                    Dim FSW As New FileStream(FunLib.Folders(PropertyObjectInfo.FolderIndex).FolderPath & "\" & NewFileName, FileMode.Create, FileAccess.Write, FileShare.Write, 4096)
                    Dim Byt(4096) As Byte
                    Dim FSRLen As Long = FSR.Length
                    NewFileProgressBar.Visible = True
                    NewFileProgressBar.Value = 0
                    NewFileProgressBar.Maximum = FSR.Length / 4096
                    Me.Enabled = False
                    For Int2 = 0 To FSR.Length / 4096
                        Application.DoEvents()
                        NewFileProgressBar.Value = Int2
                        If (FSRLen - FSW.Length) > 4096 Then
                            FSR.Read(Byt, 0, 4096)
                            FSW.Write(Byt, 0, 4096)
                        Else
                            FSR.Read(Byt, 0, FSRLen - FSW.Length)
                            FSW.Write(Byt, 0, FSR.Length - FSW.Length)
                        End If
                    Next
                    NewFileProgressBar.Value = 0
                    NewFileProgressBar.Visible = False
                    FSR.Close()
                    FSW.Close()
                Catch ex As Exception
                    'Perpare Error MSG
                    MsgBox_(ex.Message, 0, 20, False, Me)
                    Exit Sub
                End Try

                Dim TypeID As String = ""
                Dim TheResultID As String = "no"
                If FileTypeCB.SelectedIndex = -1 Then
                    TypeID = "0001"
                Else
                    TypeID = FunLib.AllFilesType(FileTypeCB.SelectedIndex).TypeID
                End If
                FunLib.InsertNewFile(TxtNewFileName.Text.Trim, FunLib.Folders(PropertyObjectInfo.FolderIndex).FolderPath.Substring(ProjectsPath.Length) & "\" & NewFileName, Now.Date, "0001", TxtNewFileDesc.Text.Trim, FunLib.Folders(PropertyObjectInfo.FolderIndex).ProID, FunLib.Folders(PropertyObjectInfo.FolderIndex).FolderID, TypeID, TheResultID)
                Me.Enabled = True
                If TheResultID <> "no" Then
                    'Add new file to the selected folders's files array
                    If FunLib.Folders(PropertyObjectInfo.FolderIndex).Files Is Nothing Then
                        ReDim FunLib.Folders(PropertyObjectInfo.FolderIndex).Files(0)
                    Else
                        ReDim Preserve FunLib.Folders(PropertyObjectInfo.FolderIndex).Files(FunLib.Folders(PropertyObjectInfo.FolderIndex).Files.Length)
                    End If
                    FunLib.Folders(PropertyObjectInfo.FolderIndex).Files(FunLib.Folders(PropertyObjectInfo.FolderIndex).Files.Length - 1).FileID = TheResultID
                    FunLib.Folders(PropertyObjectInfo.FolderIndex).Files(FunLib.Folders(PropertyObjectInfo.FolderIndex).Files.Length - 1).FileName = TxtNewFileName.Text.Trim
                    FunLib.Folders(PropertyObjectInfo.FolderIndex).Files(FunLib.Folders(PropertyObjectInfo.FolderIndex).Files.Length - 1).FilePath = FunLib.Folders(PropertyObjectInfo.FolderIndex).FolderPath & "\" & NewFileName
                    FunLib.Folders(PropertyObjectInfo.FolderIndex).Files(FunLib.Folders(PropertyObjectInfo.FolderIndex).Files.Length - 1).CreatedIn = Now.Date
                    FunLib.Folders(PropertyObjectInfo.FolderIndex).Files(FunLib.Folders(PropertyObjectInfo.FolderIndex).Files.Length - 1).Dis = TxtNewFileDesc.Text.Trim
                    FunLib.Folders(PropertyObjectInfo.FolderIndex).Files(FunLib.Folders(PropertyObjectInfo.FolderIndex).Files.Length - 1).FolderID = FunLib.Folders(PropertyObjectInfo.FolderIndex).FolderID
                    FunLib.Folders(PropertyObjectInfo.FolderIndex).Files(FunLib.Folders(PropertyObjectInfo.FolderIndex).Files.Length - 1).ProID = FunLib.Folders(PropertyObjectInfo.FolderIndex).ProID
                    FunLib.Folders(PropertyObjectInfo.FolderIndex).Files(FunLib.Folders(PropertyObjectInfo.FolderIndex).Files.Length - 1).TypeID = TypeID
                    If FileTypeCB.SelectedIndex = -1 Then
                        TypeID = "9999"
                        FunLib.Folders(PropertyObjectInfo.FolderIndex).Files(FunLib.Folders(PropertyObjectInfo.FolderIndex).Files.Length - 1).TypeName = "Default"
                    Else
                        FunLib.Folders(PropertyObjectInfo.FolderIndex).Files(FunLib.Folders(PropertyObjectInfo.FolderIndex).Files.Length - 1).TypeName = FunLib.AllFilesType(FileTypeCB.SelectedIndex).TypeName
                    End If
                    FunLib.Folders(PropertyObjectInfo.FolderIndex).Files(FunLib.Folders(PropertyObjectInfo.FolderIndex).Files.Length - 1).UserName = "Administrator"
                    FunLib.Folders(PropertyObjectInfo.FolderIndex).Files(FunLib.Folders(PropertyObjectInfo.FolderIndex).Files.Length - 1).UsrID = "0001"
                    'Reload files in LV in main form
                    FrmMainForm.RelaodFilesInListView()
                    'Perpare Complate MSG
                    MsgBox_("File transfer done - File successfully saved", 45, 23, True, Me)
                    BtnCancel.Focus()
                Else
                    GoTo ErrorS
                End If
                Exit Sub
            End If
        Next
ErrorS:
        If System.IO.File.Exists(FunLib.Folders(PropertyObjectInfo.FolderIndex).FolderPath & "\" & NewFileName) Then
            System.IO.File.Delete(FunLib.Folders(PropertyObjectInfo.FolderIndex).FolderPath & "\" & NewFileName)
        End If
        'Perpare Error MSG
        MsgBox_("Cant Save File please restart the program", 43, 23, False, Me)
        BtnCancel.Focus()
    End Sub
    Private Sub BtnSaveFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveFile.Click
        Dim ErrorResult As String = ""
        If TxtFileName.Text.Trim <> FunLib.Folders(PropertyObjectInfo.FolderIndex).Files(PropertyObjectInfo.FileIndex).FileName Or TxtDisc.Text.Trim <> FunLib.Folders(PropertyObjectInfo.FolderIndex).Files(PropertyObjectInfo.FileIndex).Dis Then
            ErrorResult = FunLib.EditFileInfo(FunLib.Folders(PropertyObjectInfo.FolderIndex).Files(PropertyObjectInfo.FileIndex).FileID, TxtFileName.Text.Trim, TxtDisc.Text.Trim)
            'Prepare MSG form
            If ErrorResult Is Nothing Then
                MsgBox_("File transfer done - File successfully saved", 45, 23, True, Me)
                FunLib.Folders(PropertyObjectInfo.FolderIndex).Files(PropertyObjectInfo.FileIndex).FileName = TxtFileName.Text.Trim
                FunLib.Folders(PropertyObjectInfo.FolderIndex).Files(PropertyObjectInfo.FileIndex).Dis = TxtDisc.Text.Trim
                FrmMainForm.RelaodFilesInListView()
            Else
                MsgBox_(ErrorResult, 0, 23, False, Me)
            End If
        End If
    End Sub
    Private Sub TxtNewFolderName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNewFolderName.TextChanged
        For Int1 = 0 To sender.Text.Trim.Length - 1
            If Char.IsLetterOrDigit(sender.Text.Chars(Int1)) = False And sender.Text.Chars(Int1) <> "_" And sender.Text.Chars(Int1) <> " " Then
                sender.Clear()
                'Prepare the Error MSG
                MsgBox_("Please enter letter or digit", 98, 23, False, Me)
                Exit For
            End If
        Next
        If TxtNewFolderName.Text.Trim.Length > 0 Then
            LblNewFolderPath.Text = FunLib.Folders(PropertyObjectInfo.FolderIndex).FolderPath & "\" & TxtNewFolderName.Text.Trim
            BtnNewFolderSave.Enabled = True
        Else
            BtnNewFolderSave.Enabled = False
            LblNewFolderPath.Text = FunLib.Folders(PropertyObjectInfo.FolderIndex).FolderPath
        End If

    End Sub
    Private Sub BtnNewFolderSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewFolderSave.Click
        'Try to Create the folder on the hard disk
        If Not System.IO.Directory.Exists(LblNewFolderPath.Text) Then
            Try
                System.IO.Directory.CreateDirectory(LblNewFolderPath.Text)
            Catch ex As Exception
                'Folder FAILED to create, sub will exit
                'Prepare the Error MSG
                MsgBox_(ex.Message, 0, 23, False, Me)
                Exit Sub
            End Try
        End If
        'Adding Folder to the database
        NewFolderErrorResult = FunLib.InsertNewFolder(TxtNewFolderName.Text.Trim, LblNewFolderPath.Text.Substring(ProjectsPath.Length), Now.Date, AdminID, TxtNewFolderDesc.Text.Trim, FunLib.Folders(PropertyObjectInfo.FolderIndex).ProID, FunLib.Folders(PropertyObjectInfo.FolderIndex).FolderID)
        If Not NewFolderErrorResult Is Nothing Then
            'adding the new folder to the funlib.folders array
            ReDim Preserve FunLib.Folders(FunLib.Folders.Length)
            FunLib.Folders(FunLib.Folders.Length - 1).FolderID = NewFolderErrorResult
            FunLib.Folders(FunLib.Folders.Length - 1).CreatedIn = Now.Date
            FunLib.Folders(FunLib.Folders.Length - 1).Disc = TxtNewFolderDesc.Text.Trim
            FunLib.Folders(FunLib.Folders.Length - 1).FolderName = TxtNewFolderName.Text.Trim
            FunLib.Folders(FunLib.Folders.Length - 1).FolderPath = LblNewFolderPath.Text
            FunLib.Folders(FunLib.Folders.Length - 1).ParentID = FunLib.Folders(PropertyObjectInfo.FolderIndex).FolderID
            FunLib.Folders(FunLib.Folders.Length - 1).ProID = FunLib.Folders(PropertyObjectInfo.FolderIndex).ProID
            FunLib.Folders(FunLib.Folders.Length - 1).UserID = FunLib.Folders(PropertyObjectInfo.FolderIndex).UserID
            'Set Privilages
            FunLib.SaveFolderprivileges(NewFolderErrorResult, UnSelectedPrv, False)
            FunLib.SaveFolderprivileges(NewFolderErrorResult, SelectedPrv, True)
            FunLib.GetSelectedFolderprivilege(FunLib.Folders(PropertyObjectInfo.FolderIndex).ProID, NewFolderErrorResult)
            'adding the new folder to the treeview in main form
            Dim NewTreeNode As New TreeNode(TxtNewFolderName.Text.Trim)
            NewTreeNode.Name = NewFolderErrorResult
            NewTreeNode.Tag = FunLib.Folders.Length - 1
            FrmMainForm.TVFolders.SelectedNode.Nodes.Add(NewTreeNode)
            'Prepare the complate MSG
            MsgBox_("Folder created successfully", 94, 23, True, Me)
        Else
            'Remove the created folder
            If System.IO.Directory.Exists(LblNewFolderPath.Text) Then
                Dim ArrFiles(), ArrFolders() As String
                ArrFiles = System.IO.Directory.GetFiles(LblNewFolderPath.Text)
                ArrFolders = System.IO.Directory.GetDirectories(LblNewFolderPath.Text)
                If ArrFiles.Length = 0 And ArrFolders.Length = 0 Then
                    Try
                        System.IO.Directory.Delete(LblNewFolderPath.Text)
                    Catch
                    End Try
                    MsgBox_("Sorry can't create this folder", 89, 23, False, Me)
                End If
            End If
        End If
    End Sub
    Private Sub TxtFolderName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtFolderName.TextChanged
        For Int1 = 0 To sender.Text.Trim.Length - 1
            If Char.IsLetterOrDigit(sender.Text.Chars(Int1)) = False And sender.Text.Chars(Int1) <> "_" And sender.Text.Chars(Int1) <> " " Then
                sender.text = FunLib.Folders(PropertyObjectInfo.FolderIndex).FolderName
                'Prepare the Error MSG
                MsgBox_("Please enter letter or digit", 98, 23, False, Me)
                Exit For
            End If
        Next
    End Sub
    Private Sub CBWrite_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBWrite.CheckedChanged
        If LBSelectedprivileges.SelectedIndex <> -1 Then
            If CBWrite.Checked = True Then
                SelectedPrv(LBSelectedprivileges.SelectedIndex).CanWrite = 1
            Else
                SelectedPrv(LBSelectedprivileges.SelectedIndex).CanWrite = 0
            End If
        End If
    End Sub
    Private Sub CBDelete_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBDelete.CheckedChanged
        If LBSelectedprivileges.SelectedIndex <> -1 Then
            If CBDelete.Checked = True Then
                SelectedPrv(LBSelectedprivileges.SelectedIndex).CanDelete = 1
            Else
                SelectedPrv(LBSelectedprivileges.SelectedIndex).CanDelete = 0
            End If
        End If
    End Sub
    Private Sub CBStart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBStart.CheckedChanged
        If CBStart.Checked = True Then
            PPStartDTP.Enabled = True
        Else
            PPStartDTP.Enabled = False
        End If
    End Sub
    Private Sub CBExp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBExp.CheckedChanged
        If CBExp.Checked = True Then
            PPExpDTP.Enabled = True
        Else
            PPExpDTP.Enabled = False
        End If
    End Sub
    Private Sub CBEnd_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBEnd.CheckedChanged
        If CBEnd.Checked = True Then
            PPEndDTP.Enabled = True
        Else
            PPEndDTP.Enabled = False
        End If
    End Sub
    Private Sub SavePPBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SavePPBtn.Click
        If MsgBox("Are you sure ?", MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.No Then
            Exit Sub
        End If
        'Dim Steps As Int16 = 0
        Dim NewPath As String = FunLib.Folders(PropertyObjectInfo.FolderIndex).FolderPath.Substring(0, FunLib.Folders(PropertyObjectInfo.FolderIndex).FolderPath.IndexOf(FunLib.Folders(PropertyObjectInfo.FolderIndex).FolderName)) & PPProjectNameTxt.Text.Trim
        Dim ProjectInfoSTR2 As New FunctionLib.DataCenterServerLib.ProjectInfo
        ProjectInfoSTR2.ProjectID = ProjectInfoSTR.ProjectID
        ProjectInfoSTR2.PrjectName = PPProjectNameTxt.Text.Trim
        If CBStart.Checked = True Then
            ProjectInfoSTR2.ProjectStart = "'" & PPStartDTP.Value.ToShortDateString & "'"
        Else
            ProjectInfoSTR2.ProjectStart = "NULL"
        End If
        If CBExp.Checked = True Then
            ProjectInfoSTR2.projectExp = "'" & PPExpDTP.Value.ToShortDateString & "'"
        Else
            ProjectInfoSTR2.projectExp = "NULL"
        End If
        If CBEnd.Checked = True Then
            ProjectInfoSTR2.ProjectEnd = "'" & PPEndDTP.Value.ToShortDateString & "'"
        Else
            ProjectInfoSTR2.ProjectEnd = "NULL"
        End If
        ProjectInfoSTR2.ProjectBudget = PPBudget.Text.Trim
        ProjectInfoSTR2.ProjectLocation = LocationPPTxt.Text.Trim
        ErrorProvider = Nothing
        ErrorProvider = FunLib.SaveProjectInfo(ProjectInfoSTR2)
        If ErrorProvider = Nothing Then
            Dim DoneFalg As Boolean = False
            DoneFalg = FunLib.ChagneFolderName(PropertyObjectInfo.FolderIndex, PPProjectNameTxt.Text.Trim, NewPath, ProjectsPath)
            If DoneFalg = True Then
                ProjectInfoSTR = ProjectInfoSTR2
                FrmMainForm.LVFiles.Items.Clear()
                FrmMainForm.FillFolders()
                MsgBox_("Project information updated", 91, 23, True, Me)
            Else
                MsgBox_("Project information didnt updated", 80, 23, False, Me)
            End If
        Else
            MsgBox_(ErrorProvider, 0, 23, False, Me)
        End If

    End Sub
    Private Sub PPBudget_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PPBudget.TextChanged
        If IsNumeric(PPBudget.Text) = False Or Val(PPBudget.Text) < 0 Then
            PPBudget.Text = 0
        End If
    End Sub
    Private Sub PPProjectNameTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PPProjectNameTxt.TextChanged
        If PPProjectNameTxt.Text.Trim.Length < 1 Then
            PPProjectNameTxt.Text = ProjectInfoSTR.PrjectName
        End If
        For Int1 = 0 To sender.Text.Trim.Length - 1
            If Char.IsLetterOrDigit(sender.Text.Chars(Int1)) = False And sender.Text.Chars(Int1) <> "_" And sender.Text.Chars(Int1) <> " " Then
                sender.text = ProjectInfoSTR.PrjectName
                'Prepare the Error MSG
                MsgBox_("Please enter letter or digit", 98, 23, False, Me)
                Exit For
            End If
        Next
    End Sub
    Private Sub AllConsLB_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles AllConsLB.DoubleClick
        If AllConsLB.SelectedItems.Count > 0 Then
            ConsAddBtn_Click(sender, e)
        End If
    End Sub
    Private Sub AllConsLB_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllConsLB.SelectedIndexChanged
        If AllConsLB.SelectedItems.Count > 0 Then
            ConsAddBtn.Enabled = True
        Else
            ConsAddBtn.Enabled = False
        End If
    End Sub
    Private Sub SelConsLB_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles SelConsLB.DoubleClick
        If SelConsLB.SelectedItems.Count > 0 Then
            ConsRemBtn_Click(sender, e)
        End If
    End Sub
    Private Sub SelConsLB_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelConsLB.SelectedIndexChanged
        If SelConsLB.SelectedItems.Count > 0 Then
            ConsRemBtn.Enabled = True
        Else
            ConsRemBtn.Enabled = False
        End If
    End Sub
    Private Sub ConsAddBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsAddBtn.Click
        FunLib.AddConsultantToProject(ProjectInfoSTR.ProjectID, NotSelConsID(AllConsLB.SelectedIndex))
        'Redim Cons Arr
        Dim Indx As Int16 = AllConsLB.SelectedIndex
        Dim NewArr() As String = NotSelConsID
        NotSelConsID = Nothing
        For Int1 = 0 To NewArr.Length - 1
            If Int1 <> Indx Then
                If NotSelConsID Is Nothing Then
                    ReDim NotSelConsID(0)
                Else
                    ReDim Preserve NotSelConsID(NotSelConsID.Length)
                End If
                NotSelConsID(NotSelConsID.Length - 1) = NewArr(Int1)
            End If
        Next
        If SelConsID Is Nothing Then
            ReDim SelConsID(0)
        Else
            ReDim Preserve SelConsID(SelConsID.Length)
        End If
        SelConsID(SelConsID.Length - 1) = NewArr(Indx)
        NewArr = Nothing
        SelConsLB.Items.Add(AllConsLB.SelectedItem.ToString)
        AllConsLB.Items.RemoveAt(AllConsLB.SelectedIndex)
    End Sub
    Private Sub ConsRemBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsRemBtn.Click
        FunLib.RemoveConsultantFromProject(ProjectInfoSTR.ProjectID, SelConsID(SelConsLB.SelectedIndex))
        'Redim Cons Arr
        Dim Indx As Int16 = SelConsLB.SelectedIndex
        Dim NewArr() As String = SelConsID
        'ReDim SelConsID(-1)
        SelConsID = Nothing
        For Int1 = 0 To NewArr.Length - 1
            If Int1 <> Indx Then
                If SelConsID Is Nothing Then
                    ReDim SelConsID(0)
                Else
                    ReDim Preserve SelConsID(SelConsID.Length)
                End If
                SelConsID(SelConsID.Length - 1) = NewArr(Int1)
            End If
        Next
        If NotSelConsID Is Nothing Then
            ReDim NotSelConsID(0)
        Else
            ReDim Preserve NotSelConsID(NotSelConsID.Length)
        End If
        NotSelConsID(NotSelConsID.Length - 1) = NewArr(Indx)
        NewArr = Nothing
        AllConsLB.Items.Add(SelConsLB.SelectedItem.ToString)
        SelConsLB.Items.RemoveAt(SelConsLB.SelectedIndex)
    End Sub
    Private Sub AllContLB_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles AllContLB.DoubleClick
        If AllContLB.SelectedItems.Count > 0 Then
            ContAddBtn_Click(sender, e)
        End If
    End Sub
    Private Sub AllContLB_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllContLB.SelectedIndexChanged
        If AllContLB.SelectedItems.Count > 0 Then
            ContAddBtn.Enabled = True
        Else
            ContAddBtn.Enabled = False
        End If
    End Sub
    Private Sub SelContLB_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles SelContLB.DoubleClick
        If SelContLB.SelectedItems.Count > 0 Then
            ContRemBtn_Click(sender, e)
        End If
    End Sub
    Private Sub SelContLB_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelContLB.SelectedIndexChanged
        If SelContLB.SelectedItems.Count > 0 Then
            ContRemBtn.Enabled = True
        Else
            ContRemBtn.Enabled = False
        End If
    End Sub
    Private Sub ContAddBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContAddBtn.Click
        FunLib.AddContractorToProject(ProjectInfoSTR.ProjectID, NotSelContID(AllContLB.SelectedIndex))
        'Redim Cons Arr
        Dim Indx As Int16 = AllContLB.SelectedIndex
        Dim NewArr() As String = NotSelContID
        NotSelContID = Nothing
        For Int1 = 0 To NewArr.Length - 1
            If Int1 <> Indx Then
                If NotSelContID Is Nothing Then
                    ReDim NotSelContID(0)
                Else
                    ReDim Preserve NotSelContID(NotSelContID.Length)
                End If
                NotSelContID(NotSelContID.Length - 1) = NewArr(Int1)
            End If
        Next
        If SelContID Is Nothing Then
            ReDim SelContID(0)
        Else
            ReDim Preserve SelContID(SelContID.Length)
        End If
        SelContID(SelContID.Length - 1) = NewArr(Indx)
        NewArr = Nothing
        SelContLB.Items.Add(AllContLB.SelectedItem.ToString)
        AllContLB.Items.RemoveAt(AllContLB.SelectedIndex)
    End Sub
    Private Sub ContRemBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContRemBtn.Click
        FunLib.RemoveContractorFromProject(ProjectInfoSTR.ProjectID, SelContID(SelContLB.SelectedIndex))
        'Redim Cons Arr
        Dim Indx As Int16 = SelContLB.SelectedIndex
        Dim NewArr() As String = SelContID
        SelContID = Nothing
        For Int1 = 0 To NewArr.Length - 1
            If Int1 <> Indx Then
                If SelContID Is Nothing Then
                    ReDim SelContID(0)
                Else
                    ReDim Preserve SelContID(SelContID.Length)
                End If
                SelContID(SelContID.Length - 1) = NewArr(Int1)
            End If
        Next
        If NotSelContID Is Nothing Then
            ReDim NotSelContID(0)
        Else
            ReDim Preserve NotSelContID(NotSelContID.Length)
        End If
        NotSelContID(NotSelContID.Length - 1) = NewArr(Indx)
        NewArr = Nothing
        AllContLB.Items.Add(SelContLB.SelectedItem.ToString)
        SelContLB.Items.RemoveAt(SelContLB.SelectedIndex)
    End Sub

End Class