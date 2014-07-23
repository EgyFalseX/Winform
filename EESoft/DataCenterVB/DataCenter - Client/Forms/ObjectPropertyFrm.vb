Imports System.IO
Public Class ObjectPropertyFrm
    Private Int1 As Int16
    Private Int2 As Int16
    Private NewFolderErrorResult As String = ""
    Private ErrorProvider As String = Nothing
    Private Add(0) As String
    Private Sub BtnNewFolderSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewFolderSave.Click
        If MsgBox("Â· «‰  „ √ﬂœ?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If
        'Try to Create the folder on the hard disk
        ErrorProvider = Nothing
        ErrorProvider = NWLib.CreateFolder(ServerIP, REQPort, AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).FolderPath & "\" & TxtNewFolderName.Text.Trim)
        If ErrorProvider IsNot Nothing Then
            MsgBox_(ErrorProvider, 0, 23, False, Me)
            Exit Sub
        End If
        'Adding Folder to the database
        NewFolderErrorResult = FunLib.InsertNewFolder(TxtNewFolderName.Text.Trim, LblNewFolderPath.Text.Substring(ProjectsPath.Length), Now.Date, FunLib.CUser.UID, TxtNewFolderDesc.Text.Trim, AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).ProID, AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).FolderID)
        If Not NewFolderErrorResult Is Nothing Then
            'adding the new folder to the AllFoldersWithPrv.FolderInfo array
            ReDim Preserve AllFoldersWithPrv.FolderInfo(AllFoldersWithPrv.FolderInfo.Length)
            AllFoldersWithPrv.FolderInfo(AllFoldersWithPrv.FolderInfo.Length - 1).FolderID = NewFolderErrorResult
            AllFoldersWithPrv.FolderInfo(AllFoldersWithPrv.FolderInfo.Length - 1).CreatedIn = Now.Date
            AllFoldersWithPrv.FolderInfo(AllFoldersWithPrv.FolderInfo.Length - 1).Disc = TxtNewFolderDesc.Text.Trim
            AllFoldersWithPrv.FolderInfo(AllFoldersWithPrv.FolderInfo.Length - 1).FolderName = TxtNewFolderName.Text.Trim
            AllFoldersWithPrv.FolderInfo(AllFoldersWithPrv.FolderInfo.Length - 1).FolderPath = LblNewFolderPath.Text
            AllFoldersWithPrv.FolderInfo(AllFoldersWithPrv.FolderInfo.Length - 1).ParentID = AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).FolderID
            AllFoldersWithPrv.FolderInfo(AllFoldersWithPrv.FolderInfo.Length - 1).ProID = AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).ProID
            AllFoldersWithPrv.FolderInfo(AllFoldersWithPrv.FolderInfo.Length - 1).UserID = AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).UserID
            ReDim Preserve AllFoldersWithPrv.PrvOperationsType(AllFoldersWithPrv.PrvOperationsType.Length)
            AllFoldersWithPrv.PrvOperationsType(AllFoldersWithPrv.PrvOperationsType.Length - 1).RullID = AllFoldersWithPrv.PrvOperationsType(PropertyObjectInfo.FolderIndex).RullID
            AllFoldersWithPrv.PrvOperationsType(AllFoldersWithPrv.PrvOperationsType.Length - 1).CanWrite = True
            AllFoldersWithPrv.PrvOperationsType(AllFoldersWithPrv.PrvOperationsType.Length - 1).CanDelete = True
            'Set Privilages
            ReDim Add(0)
            For Int1 = 0 To FunLib.CUser.UsrPrv.Length - 1
                Add(Add.Length - 1) = FunLib.CUser.UsrPrv(Int1).privilegeID
                ReDim Preserve Add(Add.Length)
            Next
            ReDim Preserve Add(Add.Length - 2)
            ErrorProvider = Nothing
            ErrorProvider = FunLib.SaveFolderprivileges(NewFolderErrorResult, Add, True, True, True)
            'adding the new folder to the treeview in main form
            Dim NewTreeNode As New TreeNode(TxtNewFolderName.Text.Trim)
            NewTreeNode.Name = NewFolderErrorResult
            NewTreeNode.Tag = AllFoldersWithPrv.FolderInfo.Length - 1
            FrmMainWindow.TVFolders.SelectedNode.Nodes.Add(NewTreeNode)
            'Prepare the complate MSG
            'MsgBox_("Folder created successfully", 94, 23, True, Me)
            MsgBox_(" „ «·Õ›Ÿ", 106, 23, True, Me)
        Else
            'Remove the created folder
            MsgBox_("·„ Ì „ «‰‘«¡ «·„Ã·œ", 89, 23, False, Me)
        End If
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
    Private Sub BtnEditFolderName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditFolderName.Click
        If BtnEditFolderName.Text = " ⁄œÌ·" Then
            BtnEditFolderName.Text = "«·€«¡"
            TxtFolderName.Enabled = True
        Else
            BtnEditFolderName.Text = " ⁄œÌ·"
            TxtFolderName.Text = AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).FolderName
            TxtFolderName.Enabled = False
        End If
    End Sub
    Private Sub BtnSaveNewFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveNewFile.Click
        If MsgBox("Â· «‰  „ √ﬂœ?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If
        Me.Enabled = False
        Dim FileType As String = "MDC"
        If FileTypeCB.SelectedIndex <> -1 Then
            FileType = FunLib.AllFilesType(FileTypeCB.SelectedIndex).TypeExt
        End If
        'Creating Filename to save the Phy file
        Dim FilePathFolders() As String = LblNewFilePath.Text.Split("\")
        Dim NewFileName As String = ""
        NewFileProgressBar.Visible = True
        ErrorProvider = Nothing
        ErrorProvider = CreateFile(ServerIP, REQPort, LblNewFilePath.Text.Trim, AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).FolderPath & "\", FilePathFolders(FilePathFolders.Length - 1), FileType, NewFileName)
        If ErrorProvider <> Nothing Then
            NewFileProgressBar.Value = 0
            NewFileProgressBar.Maximum = 0
            FrmObjectProperty.Text = "„·› ÃœÌœ"
            MsgBox_(ErrorProvider, 0, 23, False, Me)
            Exit Sub
        End If
        'MsgBox(NewFileName)
        'Exit Sub
        Dim TypeID As String = ""
        Dim TheResultID As String = "no"
        If FileTypeCB.SelectedIndex = -1 Then
            TypeID = "9999"
        Else
            TypeID = FunLib.AllFilesType(FileTypeCB.SelectedIndex).TypeID
        End If
        FunLib.InsertNewFile(TxtNewFileName.Text.Trim, NewFileName.Substring(ProjectsPath.Length), Now.Date, FunLib.CUser.UID, TxtNewFileDesc.Text.Trim, AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).ProID, AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).FolderID, TypeID, TheResultID)
        Me.Enabled = True
        If TheResultID <> "no" Then
            'Add new file to the selected folders's files array
            If AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files Is Nothing Then
                ReDim AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files(0)
            Else
                ReDim Preserve AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files(AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files.Length)
            End If
            AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files(AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files.Length - 1).FileID = TheResultID
            AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files(AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files.Length - 1).FileName = TxtNewFileName.Text.Trim
            AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files(AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files.Length - 1).FilePath = NewFileName
            AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files(AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files.Length - 1).CreatedIn = Now.Date
            AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files(AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files.Length - 1).Dis = TxtNewFileDesc.Text.Trim
            AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files(AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files.Length - 1).FolderID = AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).FolderID
            AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files(AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files.Length - 1).ProID = AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).ProID
            AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files(AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files.Length - 1).TypeID = TypeID
            If FileTypeCB.SelectedIndex = -1 Then
                TypeID = "9999"
                AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files(AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files.Length - 1).TypeName = "Default"
            Else
                AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files(AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files.Length - 1).TypeName = FunLib.AllFilesType(FileTypeCB.SelectedIndex).TypeName
            End If
            AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files(AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files.Length - 1).UserName = FunLib.CUser.UName
            AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files(AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files.Length - 1).UsrID = FunLib.CUser.UID
            'Reload files in LV in main form
            'FrmMainWindow.RelaodFilesInListView()
            Dim LVI As New ListViewItem
            LVI.Text = AllFoldersWithPrv.FolderInfo(FrmMainWindow.TVFolders.SelectedNode.Tag).Files(AllFoldersWithPrv.FolderInfo(FrmMainWindow.TVFolders.SelectedNode.Tag).Files.Length - 1).FileName
            LVI.SubItems.Add(CDate(AllFoldersWithPrv.FolderInfo(FrmMainWindow.TVFolders.SelectedNode.Tag).Files(AllFoldersWithPrv.FolderInfo(FrmMainWindow.TVFolders.SelectedNode.Tag).Files.Length - 1).CreatedIn).Date)
            LVI.SubItems.Add(AllFoldersWithPrv.FolderInfo(FrmMainWindow.TVFolders.SelectedNode.Tag).Files(AllFoldersWithPrv.FolderInfo(FrmMainWindow.TVFolders.SelectedNode.Tag).Files.Length - 1).UserName)
            LVI.SubItems.Add(AllFoldersWithPrv.FolderInfo(FrmMainWindow.TVFolders.SelectedNode.Tag).Files(AllFoldersWithPrv.FolderInfo(FrmMainWindow.TVFolders.SelectedNode.Tag).Files.Length - 1).TypeName)
            LVI.ImageKey = AllFoldersWithPrv.FolderInfo(FrmMainWindow.TVFolders.SelectedNode.Tag).Files(AllFoldersWithPrv.FolderInfo(FrmMainWindow.TVFolders.SelectedNode.Tag).Files.Length - 1).TypeID
            FrmMainWindow.LVFiles.Items.Add(LVI)
            'Perpare Complate MSG
            'MsgBox_("File transfer done - File successfully saved", 45, 23, True, Me)
            MsgBox_(" „ «·Õ›Ÿ", 106, 23, True, Me)
            BtnCancel.Focus()
        Else
            GoTo ErrorS
        End If
        Me.Enabled = True
        Exit Sub
ErrorS:
        'If System.IO.File.Exists(AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).FolderPath & "\" & NewFileName) Then
        '    System.IO.File.Delete(AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).FolderPath & "\" & NewFileName)
        'End If
        'Perpare Error MSG
        MsgBox_("·„ ‰ „ﬂ‰ „‰ «·Õ›Ÿ „‰ ›÷·ﬂ «⁄œ  ‘€Ì· «·»—‰«„Ã", 43, 23, False, Me)
        Me.Enabled = True
        BtnCancel.Focus()
    End Sub
    Private Sub TxtFolderName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtFolderName.TextChanged, TxtNewFolderName.TextChanged
        For Int1 = 0 To sender.Text.Trim.Length - 1
            If Char.IsLetterOrDigit(sender.Text.Chars(Int1)) = False And sender.Text.Chars(Int1) <> "_" And sender.Text.Chars(Int1) <> " " Then
                sender.text = AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).FolderName
                'Prepare the Error MSG
                MsgBox_("„‰ ›÷·ﬂ «œŒ· Õ—Ê› Ê «—ﬁ«„", 98, 23, False, Me)
                Exit For
            End If
        Next
        If PropertyObjectInfo.ObjecyType = ObjectType.ExistedFolder Then
            If TxtNewFolderName.Text.Trim.Length > 0 Then
                LblNewFolderPath.Text = AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).FolderPath & "\" & TxtNewFolderName.Text.Trim
                BtnNewFolderSave.Enabled = True
            Else
                BtnNewFolderSave.Enabled = False
                LblNewFolderPath.Text = AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).FolderPath
            End If
        End If
    End Sub
    Private Sub TxtNewFileName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNewFileName.TextChanged, LblNewFilePath.TextChanged
        If TxtNewFileName.Text.Trim.Length > 0 And LblNewFilePath.Text.Trim.Length > 0 Then
            BtnSaveNewFile.Enabled = True
        Else
            BtnSaveNewFile.Enabled = False
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
            If CInt(FileInf.Length / 1048576) > DefaultFileSize Then
                MsgBox("«·„·› ÌÃ» «‰ ÌﬂÊ‰ «÷€— „‰  " & DefaultFileSize & "  „ÌÃ« ", MsgBoxStyle.Information)
            Else
                LblNewFilePath.Text = OFD.FileName
            End If
        Else
            LblNewFilePath.Text = ""
        End If
    End Sub
    Private Sub BtnEditFileName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditFileName.Click
        If BtnEditFileName.Text = " ⁄œ»·" Then
            BtnEditFileName.Text = "«·€«¡"
            TxtFileName.Enabled = True
        Else
            BtnEditFileName.Text = " ⁄œÌ·"
            TxtFileName.Text = AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files(PropertyObjectInfo.FileIndex).FileName
            TxtFileName.Enabled = False
        End If
    End Sub
    Private Sub BtnSaveFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveFile.Click
        Dim ErrorResult As String = ""
        If TxtFileName.Text.Trim <> AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files(PropertyObjectInfo.FileIndex).FileName Or TxtDisc.Text.Trim <> AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files(PropertyObjectInfo.FileIndex).Dis Then
            If MsgBox("Â· «‰  „ √ﬂœ?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Sub
            End If
            ErrorResult = FunLib.EditFileInfo(AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files(PropertyObjectInfo.FileIndex).FileID, TxtFileName.Text.Trim, TxtDisc.Text.Trim)
            'Prepare MSG form
            If ErrorResult Is Nothing Then
                'MsgBox_("Update complate", 126, 23, True, Me)
                MsgBox_(" „ «·Õ›Ÿ", 106, 23, True, Me)
                AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files(PropertyObjectInfo.FileIndex).FileName = TxtFileName.Text.Trim
                AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files(PropertyObjectInfo.FileIndex).Dis = TxtDisc.Text.Trim
                FrmMainWindow.RelaodFilesInListView()
            Else
                MsgBox_(ErrorResult, 0, 23, False, Me)
            End If
        End If
    End Sub
    Private Sub BtnSaveFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveFolder.Click
        If MsgBox("Â· «‰  „ √ﬂœ?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim DoneFlag As Boolean = False
        ErrorProvider = Nothing
        If TxtFolderName.Enabled = True And TxtFolderName.Text.Trim.Length > 0 And TxtFolderName.Text.Trim.ToLower <> AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).FolderName.ToLower Then
            Me.Enabled = False
            Dim arr() As String = AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).FolderPath.Split("\")
            Dim NewPath As String = ""
            Dim i As Int16
            For i = 0 To arr.Length - 2
                NewPath &= arr(i) & "\"
            Next
            NewPath &= TxtFolderName.Text.Trim
            DoneFlag = FunLib.ChagneFolderName(PropertyObjectInfo.FolderIndex, TxtFolderName.Text.Trim, NewPath, ProjectsPath, AllFoldersWithPrv, ServerIP, REQPort)
            If DoneFlag = True Then
                'FrmMainWindow.LVFiles.Items.Clear()
                'FrmMainWindow.FillFolders()
                FrmMainWindow.TVFolders.SelectedNode.Text = TxtFolderName.Text.Trim
                AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).FolderName = TxtFolderName.Text.Trim
                BtnEditFolderName.Text = " ⁄œÌ·"
                TxtFolderName.Enabled = False
                MsgBox_(" „ «· ⁄œÌ·", 106, 23, True, Me)
            Else
                MsgBox_("·„ Ì „ «· ⁄œÌ·", 13, 23, False, Me)
                Exit Sub
            End If
        Else
        End If
        If TxtFolderDisc.Text.Trim.ToLower <> AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Disc.ToLower Then
            ErrorProvider = FunLib.SaveFolderDesc(AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).FolderID, TxtFolderDisc.Text.Trim)
            AllFoldersWithPrv.FolderInfo(FrmMainWindow.TVFolders.SelectedNode.Tag).Disc = TxtFolderDisc.Text.Trim
            If DoneFlag = False Then
                MsgBox_(" „ «·Õ›Ÿ", 106, 23, True, Me)
            End If
        End If
        Me.Enabled = True
    End Sub

End Class