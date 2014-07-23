Imports System.Windows.Forms
Public Class MainForm
#Region "   --  Code not in used  --    "
    Sub NotUsedSub(ByVal Node As TreeNode)
        Dim thisNode As TreeNode
        Static IndentLevel As Integer
        Application.DoEvents()
        'ListBox1.Items.Add(Space(IndentLevel) & Node.Text)
        If Node.Nodes.Count > 0 Then
            IndentLevel += 5
            For Each thisNode In Node.Nodes
                NotUsedSub(thisNode)
            Next
            IndentLevel -= 5
        End If
    End Sub
#End Region

    Private Int1 As Int16 = 0
    Private Int2 As Int16 = 0
    Private TMR As New Timer
    Public AppCantExit As Boolean = False
    Private Sub TMR_Tick(ByVal sender As Object, ByVal e As EventArgs)
        Me.Enabled = True
        TMR.Enabled = False
        Do While DefaultUserPassword = "" Or ProjectsPath = "" Or RelatedFiles = "" Or DeletedFilesPath = ""
            FrmOptions = New OptionsFrm
            FrmOptions.BtnExitApp.Visible = True
            FrmOptions.Lblwarning.Visible = True
            FrmOptions.ShowDialog()
        Loop
        FillFolders()
        LoadAllIcons()
    End Sub
    Private Sub MainForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If AppCantExit = False Then
            Application.Exit()
        End If
    End Sub
    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Enabled = False
        TMR.Interval = 1
        AddHandler TMR.Tick, AddressOf TMR_Tick
        TMR.Enabled = True
    End Sub
    Public Sub FillFolders()
        FunLib.GetFoldersOrdered_ThenGetFiles(ProjectsPath)
        Dim MyTreeNod As New TreeNode
        TVFolders.Nodes.Clear()
        Dim i As Integer = 0
        FoldersToolStripProgressBar.Visible = True
        FoldersToolStripStatusLabel.Visible = True
        FoldersToolStripProgressBar.Value = 0
        FoldersToolStripProgressBar.Maximum = FunLib.Folders.Length
        For i = 0 To FunLib.Folders.Length - 1
            FoldersToolStripProgressBar.Value += 1
            Application.DoEvents()
            Dim InternalPath As String
            InternalPath = FunLib.Folders(i).FolderPath.Substring(ProjectsPath.Length)
            Dim arr() As String
            arr = InternalPath.Split("\")
            Select Case arr.Length
                Case 1
                    'Level 0
                    MyTreeNod = New TreeNode
                    MyTreeNod.Text = FunLib.Folders(i).FolderName
                    MyTreeNod.Name = FunLib.Folders(i).FolderID
                    MyTreeNod.Tag = i
                    TVFolders.Nodes.Add(MyTreeNod)
                Case 2
                    'Level 1
                    MyTreeNod = New TreeNode
                    Dim IntCase2 As Integer = 0
                    For IntCase2 = 0 To TVFolders.Nodes.Count - 1
                        If TVFolders.Nodes(IntCase2).Name = FunLib.Folders(i).ParentID Then
                            MyTreeNod.Text = FunLib.Folders(i).FolderName
                            MyTreeNod.Name = FunLib.Folders(i).FolderID
                            MyTreeNod.Tag = i
                            TVFolders.Nodes(IntCase2).Nodes.Add(MyTreeNod)
                            Exit Select
                        End If
                    Next
                Case 3
                    'Level 2
                    MyTreeNod = New TreeNode
                    Dim IntCase3 As Integer = 0
                    For IntCase3 = 0 To TVFolders.Nodes.Count - 1
                        If TVFolders.Nodes(IntCase3).Text = arr(0) Then
                            Dim IntCase3_1 As Integer = 0
                            For IntCase3_1 = 0 To TVFolders.Nodes(IntCase3).Nodes.Count - 1
                                If TVFolders.Nodes(IntCase3).Nodes(IntCase3_1).Name = FunLib.Folders(i).ParentID Then
                                    MyTreeNod.Text = FunLib.Folders(i).FolderName
                                    MyTreeNod.Name = FunLib.Folders(i).FolderID
                                    MyTreeNod.Tag = i
                                    TVFolders.Nodes(IntCase3).Nodes(IntCase3_1).Nodes.Add(MyTreeNod)
                                    Exit Select
                                End If
                            Next
                        End If
                    Next
                Case 4
                    MyTreeNod = New TreeNode
                    'Level 3
                    Dim IntCase4 As Integer = 0
                    For IntCase4 = 0 To TVFolders.Nodes.Count - 1
                        If TVFolders.Nodes(IntCase4).Text = arr(0) Then
                            Dim IntCase4_1 As Integer = 0
                            For IntCase4_1 = 0 To TVFolders.Nodes(IntCase4).Nodes.Count - 1
                                If TVFolders.Nodes(IntCase4).Nodes(IntCase4_1).Text = arr(1) Then
                                    Dim IntCase4_2 As Integer = 0
                                    For IntCase4_2 = 0 To TVFolders.Nodes(IntCase4).Nodes(IntCase4_1).Nodes.Count - 1
                                        If TVFolders.Nodes(IntCase4).Nodes(IntCase4_1).Nodes(IntCase4_2).Text = arr(2) Then
                                            MyTreeNod.Text = FunLib.Folders(i).FolderName
                                            MyTreeNod.Name = FunLib.Folders(i).FolderID
                                            MyTreeNod.Tag = i
                                            TVFolders.Nodes(IntCase4).Nodes(IntCase4_1).Nodes(IntCase4_2).Nodes.Add(MyTreeNod)
                                            Exit Select
                                        End If
                                    Next
                                End If
                            Next
                        End If
                    Next
                Case 5
                    'Level 4
                    MyTreeNod = New TreeNode
                    Dim IntCase4 As Integer = 0
                    For IntCase4 = 0 To TVFolders.Nodes.Count - 1
                        If TVFolders.Nodes(IntCase4).Text = arr(0) Then
                            Dim IntCase4_1 As Integer = 0
                            For IntCase4_1 = 0 To TVFolders.Nodes(IntCase4).Nodes.Count - 1
                                If TVFolders.Nodes(IntCase4).Nodes(IntCase4_1).Text = arr(1) Then
                                    Dim IntCase4_2 As Integer = 0
                                    For IntCase4_2 = 0 To TVFolders.Nodes(IntCase4).Nodes(IntCase4_1).Nodes.Count - 1
                                        If TVFolders.Nodes(IntCase4).Nodes(IntCase4_1).Nodes(IntCase4_2).Text = arr(2) Then
                                            Dim IntCase4_3 As Integer = 0
                                            For IntCase4_3 = 0 To TVFolders.Nodes(IntCase4).Nodes(IntCase4_1).Nodes(IntCase4_2).Nodes.Count - 1
                                                If TVFolders.Nodes(IntCase4).Nodes(IntCase4_1).Nodes(IntCase4_2).Nodes(IntCase4_3).Text = arr(3) Then
                                                    MyTreeNod.Text = FunLib.Folders(i).FolderName
                                                    MyTreeNod.Name = FunLib.Folders(i).FolderID
                                                    MyTreeNod.Tag = i
                                                    TVFolders.Nodes(IntCase4).Nodes(IntCase4_1).Nodes(IntCase4_2).Nodes(IntCase4_3).Nodes.Add(MyTreeNod)
                                                    Exit Select
                                                End If
                                            Next
                                        End If
                                    Next
                                End If
                            Next
                        End If
                    Next
            End Select
        Next
        FoldersToolStripProgressBar.Value = 0
        FoldersToolStripProgressBar.Visible = False
        FoldersToolStripStatusLabel.Visible = False
    End Sub

    Private Sub TVFolders_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TVFolders.AfterSelect
        RelaodFilesInListView()
    End Sub
    Public Sub RelaodFilesInListView()
        If TVFolders.SelectedNode.Text <> Nothing Then
            LVFiles.Items.Clear()
            Dim LVI As New ListViewItem
            For Int1 = 0 To FunLib.Folders.Length - 1
                If FunLib.Folders(Int1).FolderID = TVFolders.SelectedNode.Name And Not FunLib.Folders(Int1).Files Is Nothing Then
                    For Int2 = 0 To FunLib.Folders(Int1).Files.Length - 1
                        LVI = New ListViewItem
                        LVI.Tag = Int2
                        LVI.Name = FunLib.Folders(Int1).Files(Int2).FileID
                        LVI.Text = FunLib.Folders(Int1).Files(Int2).FileName
                        LVI.SubItems.Add(CDate(FunLib.Folders(Int1).Files(Int2).CreatedIn).Date)
                        LVI.SubItems.Add(FunLib.Folders(Int1).Files(Int2).UserName)
                        LVI.SubItems.Add(FunLib.Folders(Int1).Files(Int2).TypeName)
                        LVI.ImageKey = FunLib.Folders(Int1).Files(Int2).TypeID
                        LVFiles.Items.Add(LVI)
                    Next
                    Exit For
                End If
            Next
        End If
    End Sub
    Public Sub LoadAllIcons()
        Dim Icon As System.Drawing.Icon
        FunLib.GetAllFilesType(RelatedFiles)
        For Int1 = 0 To FunLib.AllFilesType.Length - 1
            If System.IO.File.Exists(FunLib.AllFilesType(Int1).TypeIcon) Then
                'Try to add the normal icon
                Icon = New Icon(FunLib.AllFilesType(Int1).TypeIcon)
                IconsList.Images.Add(FunLib.AllFilesType(Int1).TypeID, Icon)
            ElseIf System.IO.File.Exists(RelatedFiles & "Icons\Default.ico") Then
                'Try to add the the default icon
                Icon = New Icon(RelatedFiles & "Icons\Default.ico")
                IconsList.Images.Add(FunLib.AllFilesType(Int1).TypeID, Icon)
            Else
                'Try to add the Internal icon
                IconsList.Images.Add(FunLib.AllFilesType(Int1).TypeID, MainImageList.Images(1))
            End If
        Next
    End Sub
    Private Sub LVFiles_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles LVFiles.ColumnClick
        If LVFiles.Sorting = SortOrder.Ascending Then
            LVFiles.Sorting = SortOrder.Descending
        Else
            LVFiles.Sorting = SortOrder.Ascending
        End If
    End Sub
    Private Sub LVFiles_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LVFiles.KeyDown
        Select Case e.KeyData
            Case Keys.Delete
                FilesRemoveToolStripMenuItem_Click(sender, e)
            Case Keys.Enter
                FilesPropertiesToolStripMenuItem_Click(sender, e)
        End Select

    End Sub
    Private Sub LVFiles_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LVFiles.MouseDoubleClick
        If LVFiles.SelectedIndices.Count > 0 And e.Button = Windows.Forms.MouseButtons.Left Then
            FilesPropertiesToolStripMenuItem_Click(sender, e)
        Else
            AddFilesToolStripMenuItem_Click(sender, e)
        End If
    End Sub

    'Menus
    Private Sub AddNewConsultantsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewConsultantsToolStripMenuItem.Click
        FrmNewConsultants = New NewConsultantsFrm
        FrmNewConsultants.ShowDialog()
    End Sub
    Private Sub AddNewContractorsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewContractorsToolStripMenuItem.Click
        FrmNewContractors = New NewContractorsFrm
        FrmNewContractors.ShowDialog()
    End Sub
    Private Sub AddNewClientToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewClientToolStripMenuItem.Click
        FrmNewClient = New NewClientFrm
        FrmNewClient.ShowDialog()
    End Sub
    Private Sub RestartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestartToolStripMenuItem.Click
        Application.Restart()
    End Sub
    Private Sub CreateNewUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateNewUserToolStripMenuItem.Click
        FrmUsers = New EditUsersFrm
        FrmUsers.ShowDialog()
    End Sub
    Private Sub RemoveUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveUserToolStripMenuItem.Click
        FrmDisactivatedUsers = New DisactivatedUsersFrm
        FrmDisactivatedUsers.ShowDialog()
    End Sub
    Private Sub EditUserPriviligeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditUserPriviligeToolStripMenuItem.Click
        FrmUsersPrivileges = New UsersPrivilegesFrm
        FrmUsersPrivileges.ShowDialog()
    End Sub
    Private Sub ConsultantsEditorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultantsEditorToolStripMenuItem.Click
        FrmEditConsultants = New EditConsultantsFrm
        FrmEditConsultants.ShowDialog()
    End Sub
    Private Sub RemovedConsultantsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemovedConsultantsToolStripMenuItem.Click
        FrmDisactivatedConsultants = New DisactivatedConsultantsFrm
        FrmDisactivatedConsultants.ShowDialog()
    End Sub
    Private Sub ContractorsEditorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContractorsEditorToolStripMenuItem.Click
        FrmEditContractors = New EditContractorsFrm
        FrmEditContractors.ShowDialog()
    End Sub
    Private Sub RemovedContractorsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemovedContractorsToolStripMenuItem.Click
        FrmDisactivatedContractors = New DisactivatedContractorsFrm
        FrmDisactivatedContractors.ShowDialog()
    End Sub
    Private Sub ClientsEditorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientsEditorToolStripMenuItem.Click
        FrmEditClients = New EditClientsFrm
        FrmEditClients.ShowDialog()
    End Sub
    Private Sub RemovedClientsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemovedClientsToolStripMenuItem.Click
        FrmDisactivatedClients = New DisactivatedClientsFrm
        FrmDisactivatedClients.ShowDialog()
    End Sub
    Private Sub FileCheckerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileCheckerToolStripMenuItem.Click
        FrmFilesChecker = New FilesCheckerFrm
        FrmFilesChecker.AppCantExit = True
        FrmFilesChecker.MinimizeBox = False
        FrmFilesChecker.BtnStart.Visible = False
        FrmFilesChecker.ShowDialog()
    End Sub
    Private Sub NewProjectToolStripMenuItem_Clieck(ByVal sender As Object, ByVal e As EventArgs) Handles NewProjectToolStripMenuItem.Click, NewToolStripButton.Click
        FrmWizrad = New WizradFrm
        FrmWizrad.Show()
        AppCantExit = True
        Me.Close()
        'ChildForm.MdiParent = Me
    End Sub
    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        If FrmOptions.Visible = False Then
            FrmOptions = New OptionsFrm
            FrmOptions.Show()
        Else
            FrmOptions.Activate()
        End If
    End Sub
    Private Sub DeleteProjectsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteProjectsToolStripMenuItem.Click
        FrmDeactivateProject = New DeactivateProjectFrm
        FrmDeactivateProject.ShowDialog()
    End Sub
    Private Sub AddNewFileTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewFileTypeToolStripMenuItem.Click
        FrmNewFileTypes = New NewFileTypesFrm
        FrmNewFileTypes.ShowDialog()
    End Sub
    Private Sub FilesTypesEditorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilesTypesEditorToolStripMenuItem.Click
        FrmEditFileTypes = New EditFileTypesFrm
        FrmEditFileTypes.ShowDialog()
    End Sub
    Private Sub UnLockFilesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnLockFilesToolStripMenuItem.Click
        FrmLockedFiles = New LockedFilesFrm
        FrmLockedFiles.ShowDialog()
    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Process.GetCurrentProcess.Kill()
    End Sub

    'Context Menus
    Private Sub FilesRemoveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilesRemoveToolStripMenuItem.Click
        If Not TVFolders.SelectedNode Is Nothing And LVFiles.SelectedIndices.Count > 0 Then
            If MsgBox("You are about to remove this file" & vbNewLine & "Are you sure?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Sub
            End If
            PropertyObjectInfo.FolderIndex = TVFolders.SelectedNode.Tag
            PropertyObjectInfo.FileIndex = LVFiles.SelectedItems(0).Index
            Dim ErrorResult As String = ""
            ErrorResult = FunLib.RemoveFile(FunLib.Folders(PropertyObjectInfo.FolderIndex).Files(PropertyObjectInfo.FileIndex).FileID)
            If ErrorResult Is Nothing Then
                If System.IO.File.Exists(FunLib.Folders(PropertyObjectInfo.FolderIndex).Files(PropertyObjectInfo.FileIndex).FilePath) Then
                    If System.IO.Directory.Exists(DeletedFilesPath & Now.Year & "-" & Now.Month & "-" & Now.Day & "\") = False Then
                        System.IO.Directory.CreateDirectory(DeletedFilesPath & Now.Year & "-" & Now.Month & "-" & Now.Day & "\")
                    End If
                    Dim FilePaths() As String = FunLib.Folders(PropertyObjectInfo.FolderIndex).Files(PropertyObjectInfo.FileIndex).FilePath.Split("\")
                    Dim NewPath As String
                    For Int1 = 0 To 10000
                        NewPath = DeletedFilesPath & Now.Year & "-" & Now.Month & "-" & Now.Day & "\" & FilePaths(FilePaths.Length - 1) & "_" & Int1
                        If System.IO.File.Exists(NewPath) = False Then
                            System.IO.File.Move(FunLib.Folders(PropertyObjectInfo.FolderIndex).Files(PropertyObjectInfo.FileIndex).FilePath, NewPath)
                            Exit For
                        End If
                    Next
                End If
                MsgBox_("File successfully removed", 99, 23, True, Me)
                Me.Enabled = False
                'Remove element from array by creating new file array after the element is removed
                Dim NewArray(FunLib.Folders(PropertyObjectInfo.FolderIndex).Files.Length - 1) As FunctionLib.DataCenterServerLib.FileInfo
                Array.Copy(FunLib.Folders(PropertyObjectInfo.FolderIndex).Files, NewArray, FunLib.Folders(PropertyObjectInfo.FolderIndex).Files.Length)
                ReDim Preserve FunLib.Folders(PropertyObjectInfo.FolderIndex).Files(0)
                For Int1 = 0 To NewArray.Length - 1
                    If Int1 <> LVFiles.SelectedItems(0).Index Then
                        FunLib.Folders(PropertyObjectInfo.FolderIndex).Files(FunLib.Folders(PropertyObjectInfo.FolderIndex).Files.Length - 1) = NewArray(Int1)
                        ReDim Preserve FunLib.Folders(PropertyObjectInfo.FolderIndex).Files(FunLib.Folders(PropertyObjectInfo.FolderIndex).Files.Length)
                    Else
                    End If
                Next
                ReDim Preserve FunLib.Folders(PropertyObjectInfo.FolderIndex).Files(FunLib.Folders(PropertyObjectInfo.FolderIndex).Files.Length - 2)
                LVFiles.SelectedItems(0).Remove()
                'FrmMainForm.RelaodFilesInListView()
                Me.Enabled = True
            Else
                MsgBox_(ErrorResult, 0, 23, False, Me)
            End If
        End If
    End Sub
    Private Sub FilesPropertiesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilesPropertiesToolStripMenuItem.Click
        If LVFiles.SelectedIndices.Count > 0 Then
            FrmObjectProperty = New ObjectPropertyFrm
            PropertyObjectInfo.FolderIndex = TVFolders.SelectedNode.Tag
            PropertyObjectInfo.FileIndex = LVFiles.SelectedItems(0).Index
            FrmObjectProperty.TxtFileName.Text = FunLib.Folders(TVFolders.SelectedNode.Tag).Files(LVFiles.SelectedIndices.Item(0)).FileName
            FrmObjectProperty.LblFilePath.Text = FunLib.Folders(TVFolders.SelectedNode.Tag).Files(LVFiles.SelectedIndices.Item(0)).FilePath
            FrmObjectProperty.LblDate.Text = CDate(FunLib.Folders(TVFolders.SelectedNode.Tag).Files(LVFiles.SelectedIndices.Item(0)).CreatedIn).Date
            FrmObjectProperty.LblUser.Text = FunLib.Folders(TVFolders.SelectedNode.Tag).Files(LVFiles.SelectedIndices.Item(0)).UserName
            FunLib.GetProjectName(FunLib.Folders(TVFolders.SelectedNode.Tag).Files(LVFiles.SelectedIndices.Item(0)).ProID, FrmObjectProperty.LblProject.Text)
            FrmObjectProperty.LblFileType.Text = FunLib.Folders(TVFolders.SelectedNode.Tag).Files(LVFiles.SelectedIndices.Item(0)).TypeName
            FrmObjectProperty.TxtDisc.Text = FunLib.Folders(TVFolders.SelectedNode.Tag).Files(LVFiles.SelectedIndices.Item(0)).Dis
            FrmObjectProperty.FoldersFilesTabControl.Controls.Clear()
            FrmObjectProperty.FoldersFilesTabControl.Controls.Add(FrmObjectProperty.FilesTabPage)
            FrmObjectProperty.BtnSavePriv.Enabled = True
            FrmObjectProperty.Text = "File Properties"
            FrmObjectProperty.ShowDialog()
        End If
    End Sub
    Private Sub AddFilesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddFilesToolStripMenuItem.Click
        If Not TVFolders.SelectedNode Is Nothing Then
            FrmObjectProperty = New ObjectPropertyFrm
            FrmObjectProperty.FoldersFilesTabControl.Controls.Clear()
            FrmObjectProperty.FoldersFilesTabControl.Controls.Add(FrmObjectProperty.NewFileTabPage)
            FunLib.GetAllFilesType(RelatedFiles)
            FrmObjectProperty.LblNewFileDate.Text = Now.Date
            PropertyObjectInfo.FolderIndex = TVFolders.SelectedNode.Tag
            FunLib.GetProjectName(FunLib.Folders(TVFolders.SelectedNode.Tag).ProID, FrmObjectProperty.LblNewFileProjectName.Text)
            If FunLib.AllFilesType IsNot Nothing Then
                For Int1 = 0 To FunLib.AllFilesType.Length - 1
                    FrmObjectProperty.FileTypeCB.Items.Add(FunLib.AllFilesType(Int1).TypeName)
                Next
            End If
            FrmObjectProperty.Text = "New File Properties"
            FrmObjectProperty.ShowDialog()
        End If
    End Sub
    Private Sub FoldersPropertiesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FoldersPropertiesToolStripMenuItem.Click
        FrmObjectProperty = New ObjectPropertyFrm
        If Not TVFolders.SelectedNode Is Nothing Then
            Dim i As Integer = TVFolders.SelectedNode.Tag
            PropertyObjectInfo.FolderIndex = i
            If FunLib.Folders(i).ParentID = "0" Then 'Project case
                '1- Loading Project Genaral Tab Information
                Dim ErrorProvider As String = FunLib.GetProjectInfo(FunLib.Folders(i).ProID, ProjectInfoSTR)
                If ErrorProvider = Nothing Then
                    PropertyObjectInfo.ObjecyType = ObjectType.Project
                    FrmObjectProperty.PPProjectNameTxt.Text = ProjectInfoSTR.PrjectName
                    If ProjectInfoSTR.ProjectStart <> "" Then
                        FrmObjectProperty.CBStart.Checked = True
                        FrmObjectProperty.PPStartDTP.Enabled = True
                        FrmObjectProperty.PPStartDTP.Value = CDate(ProjectInfoSTR.ProjectStart).ToShortDateString
                    End If
                    If ProjectInfoSTR.projectExp <> "" Then
                        FrmObjectProperty.CBExp.Checked = True
                        FrmObjectProperty.PPExpDTP.Enabled = True
                        FrmObjectProperty.PPExpDTP.Value = CDate(ProjectInfoSTR.projectExp).ToShortDateString
                    End If
                    If ProjectInfoSTR.ProjectEnd <> "" Then
                        FrmObjectProperty.CBEnd.Checked = True
                        FrmObjectProperty.PPEndDTP.Enabled = True
                        FrmObjectProperty.PPEndDTP.Value = CDate(ProjectInfoSTR.ProjectEnd).ToShortDateString
                    End If
                    If ProjectInfoSTR.ProjectBudget = "" Then
                        FrmObjectProperty.PPBudget.Text = "0"
                    Else
                        FrmObjectProperty.PPBudget.Text = ProjectInfoSTR.ProjectBudget
                    End If
                    FrmObjectProperty.LocationPPTxt.Text = ProjectInfoSTR.ProjectLocation
                    '''''''''''''''''''''''''''''''''''
                    FrmObjectProperty.FoldersFilesTabControl.Controls.Clear()
                    FrmObjectProperty.FoldersFilesTabControl.Controls.Add(FrmObjectProperty.ProjectPropertiesTabPage)
                    FrmObjectProperty.Text = " Project Properties"
                    FrmObjectProperty.ShowDialog()
                Else
                    MsgBox_(ErrorProvider, 0, 23, False, Me)
                    Exit Sub
                End If
            Else 'Folder case
                PropertyObjectInfo.ObjecyType = ObjectType.ExistedFolder
                FrmObjectProperty.TxtFolderName.Text = FunLib.Folders(i).FolderName
                FrmObjectProperty.LblFolderPath.Text = FunLib.Folders(i).FolderPath
                FrmObjectProperty.LblFolderDate.Text = CDate(FunLib.Folders(i).CreatedIn).Date
                FunLib.GetWhoCreateit(FunLib.Folders(i).UserID, FrmObjectProperty.LblFolderUser.Text)
                FunLib.GetProjectName(FunLib.Folders(i).ProID, FrmObjectProperty.LblFolderProject.Text)
                FrmObjectProperty.TxtFolderDisc.Text = FunLib.Folders(i).Disc
                FrmObjectProperty.FoldersFilesTabControl.Controls.Clear()
                FrmObjectProperty.FoldersFilesTabControl.Controls.Add(FrmObjectProperty.FoldersTabPage)
                FrmObjectProperty.FoldersFilesTabControl.Controls.Add(FrmObjectProperty.FoldersprivilegesTabPage)
                FunLib.GetAllprivilege(FunLib.Folders(i).ProID)
                FunLib.GetSelectedFolderprivilege(FunLib.Folders(i).ProID, FunLib.Folders(i).FolderID)
                'Sort Privilege in list boxs
                Dim IntForLoop As Integer = 0
                For IntForLoop = 0 To FunLib.Allprivilege.Length - 1
                    If FunLib.Allprivilege(IntForLoop).privilegeSelected = True Then
                        FrmObjectProperty.LBSelectedprivileges.Items.Add(FunLib.Allprivilege(IntForLoop).privilegeName)
                        If FrmObjectProperty.SelectedPrv Is Nothing Then
                            ReDim FrmObjectProperty.SelectedPrv(0)
                        Else
                            ReDim Preserve FrmObjectProperty.SelectedPrv(FrmObjectProperty.SelectedPrv.Length)
                        End If
                        FrmObjectProperty.SelectedPrv(FrmObjectProperty.SelectedPrv.Length - 1) = FunLib.Allprivilege(IntForLoop)
                    Else
                        FrmObjectProperty.LBAllprivileges.Items.Add(FunLib.Allprivilege(IntForLoop).privilegeName)
                        If FrmObjectProperty.UnSelectedPrv Is Nothing Then
                            ReDim FrmObjectProperty.UnSelectedPrv(0)
                        Else
                            ReDim Preserve FrmObjectProperty.UnSelectedPrv(FrmObjectProperty.UnSelectedPrv.Length)
                        End If
                        FrmObjectProperty.UnSelectedPrv(FrmObjectProperty.UnSelectedPrv.Length - 1) = FunLib.Allprivilege(IntForLoop)
                    End If
                Next
                FrmObjectProperty.Text = " Folder Properties"
                FrmObjectProperty.ShowDialog()
            End If

        Else
            MsgBox_("No Object is selected", 112, 23, False, Me)
        End If
    End Sub
    Private Sub CreateFolderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateFolderToolStripMenuItem.Click
        FrmObjectProperty = New ObjectPropertyFrm
        If TVFolders.SelectedNode.Level >= 4 Then
            MsgBox_("You have reach the limit level" & vbNewLine & "You can't add more folders here", 85, 18, False, Me)
            Exit Sub
        End If
        If TVFolders.SelectedNode.IsSelected Then
            PropertyObjectInfo.FolderIndex = TVFolders.SelectedNode.Tag
            PropertyObjectInfo.ObjecyType = ObjectType.NewFolder
            FrmObjectProperty.LblNewFolderPath.Text = FunLib.Folders(PropertyObjectInfo.FolderIndex).FolderPath
            FrmObjectProperty.LblNewFolderDate.Text = Now.Date
            FunLib.GetProjectName(FunLib.Folders(PropertyObjectInfo.FolderIndex).ProID, FrmObjectProperty.LblNewFolderProjectName.Text)
            FunLib.GetAllprivilege(FunLib.Folders(PropertyObjectInfo.FolderIndex).ProID)
            For Int1 = 0 To FunLib.Allprivilege.Length - 1
                If FunLib.Allprivilege(Int1).privilegeName <> "Public" Then
                    FrmObjectProperty.LBAllprivileges.Items.Add(FunLib.Allprivilege(Int1).privilegeName)
                    If FrmObjectProperty.UnSelectedPrv Is Nothing Then
                        ReDim FrmObjectProperty.UnSelectedPrv(0)
                    Else
                        ReDim Preserve FrmObjectProperty.UnSelectedPrv(FrmObjectProperty.UnSelectedPrv.Length)
                    End If
                    FrmObjectProperty.UnSelectedPrv(FrmObjectProperty.UnSelectedPrv.Length - 1) = FunLib.Allprivilege(Int1)
                Else
                    FrmObjectProperty.LBSelectedprivileges.Items.Add(FunLib.Allprivilege(Int1).privilegeName)
                    If FrmObjectProperty.SelectedPrv Is Nothing Then
                        ReDim FrmObjectProperty.SelectedPrv(0)
                    Else
                        ReDim Preserve FrmObjectProperty.SelectedPrv(FrmObjectProperty.SelectedPrv.Length)
                    End If
                    FrmObjectProperty.SelectedPrv(FrmObjectProperty.SelectedPrv.Length - 1) = FunLib.Allprivilege(Int1)
                End If
            Next
            FrmObjectProperty.FoldersFilesTabControl.Controls.Clear()
            FrmObjectProperty.FoldersFilesTabControl.Controls.Add(FrmObjectProperty.NewFolderTabPage)
            FrmObjectProperty.FoldersFilesTabControl.Controls.Add(FrmObjectProperty.FoldersprivilegesTabPage)
            FrmObjectProperty.BtnSavePriv.Visible = False
            FrmObjectProperty.Text = " New Folder"
            FrmObjectProperty.ShowDialog()
        Else
            MsgBox_("No Object is selected", 112, 23, False, Me)
        End If

    End Sub
    Private Sub FoldersRemoveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FoldersRemoveToolStripMenuItem.Click
        If TVFolders.SelectedNode.IsSelected = False Then
            Exit Sub
        End If
        If MsgBox("Are you sure ?", MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.No Then
            Exit Sub
        End If
        'Check if the folder have files or folder
        If Not FunLib.Folders(TVFolders.SelectedNode.Tag).Files Is Nothing Then
            If FunLib.Folders(TVFolders.SelectedNode.Tag).Files.Length <> 0 Then
                GoTo Have_Files
            End If
        End If
        If TVFolders.SelectedNode.Nodes.Count = 0 Then
            Dim RemoveFolderErrorResult As String
            RemoveFolderErrorResult = FunLib.RemoveFolder(FunLib.Folders(TVFolders.SelectedNode.Tag).FolderID)
            If RemoveFolderErrorResult = Nothing Then
                'try to remove the Phy folder "Only if its empty"
                If System.IO.Directory.Exists(FunLib.Folders(TVFolders.SelectedNode.Tag).FolderPath) Then
                    Dim FileArr(), FolderArr() As String
                    FileArr = System.IO.Directory.GetFiles(FunLib.Folders(TVFolders.SelectedNode.Tag).FolderPath)
                    FolderArr = System.IO.Directory.GetDirectories(FunLib.Folders(TVFolders.SelectedNode.Tag).FolderPath)
                    If FileArr.Length = 0 And FolderArr.Length = 0 Then
                        Try
                            If Not System.IO.Directory.Exists(DeletedFilesPath & Now.Year & "-" & Now.Month & "-" & Now.Day) Then
                                System.IO.Directory.CreateDirectory(DeletedFilesPath & Now.Year & "-" & Now.Month & "-" & Now.Day)
                            End If
                            Dim NewPath As String
                            For Int1 = 0 To 10000
                                NewPath = DeletedFilesPath & Now.Year & "-" & Now.Month & "-" & Now.Day & "\" & FunLib.Folders(TVFolders.SelectedNode.Tag).FolderName & "_" & Int1
                                If System.IO.Directory.Exists(NewPath) = False Then
                                    System.IO.Directory.Move(FunLib.Folders(TVFolders.SelectedNode.Tag).FolderPath, NewPath)
                                    Exit For
                                End If
                            Next
                        Catch
                        End Try
                    End If
                    'Prepare Complate MSG
                    MsgBox_("Folder removed  - Data saved successfully", 42, 23, True, Me)
                    'Reload TreeView
                    Me.Enabled = False
                    FillFolders()
                    Me.Enabled = True
                End If
            End If
        Else
            GoTo Have_Files
        End If
        Exit Sub
Have_Files:
        'Prepare Error MSG
        MsgBox_("This folder is not empty", 104, 23, False, Me)
    End Sub
    Private Sub PrivilegesEditorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrivilegesEditorToolStripMenuItem.Click
        FrmPrivileges = New PrivilegesFrm
        FrmPrivileges.ShowDialog()
    End Sub

    'Status Bar
    Private Sub LargeIconListViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LargeIconListViewToolStripMenuItem.Click
        LVFiles.View = View.LargeIcon : LargeIconListViewToolStripMenuItem.Checked = True : DetailsListViewToolStripMenuItem.Checked = False : SmallIconListViewToolStripMenuItem.Checked = False : ListListViewToolStripMenuItem.Checked = False
    End Sub
    Private Sub DetailsListViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetailsListViewToolStripMenuItem.Click
        LVFiles.View = View.Details : LargeIconListViewToolStripMenuItem.Checked = False : DetailsListViewToolStripMenuItem.Checked = True : SmallIconListViewToolStripMenuItem.Checked = False : ListListViewToolStripMenuItem.Checked = False
    End Sub
    Private Sub SmallIconListViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SmallIconListViewToolStripMenuItem.Click
        LVFiles.View = View.SmallIcon : LargeIconListViewToolStripMenuItem.Checked = False : DetailsListViewToolStripMenuItem.Checked = False : SmallIconListViewToolStripMenuItem.Checked = True : ListListViewToolStripMenuItem.Checked = False
    End Sub
    Private Sub ListListViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListListViewToolStripMenuItem.Click
        LVFiles.View = View.List : LargeIconListViewToolStripMenuItem.Checked = False : DetailsListViewToolStripMenuItem.Checked = False : SmallIconListViewToolStripMenuItem.Checked = False : ListListViewToolStripMenuItem.Checked = True
    End Sub

    
End Class