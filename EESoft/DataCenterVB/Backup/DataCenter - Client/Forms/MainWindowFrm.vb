Public Class MainWindowFrm
    Private TMR As New Timer
    Private Int1 As Int16 = 0
    Private Int2 As Int16 = 0
    Private ErrorProviderZ As String
    Private Sub MainWindowFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Enabled = False
        TMR.Interval = 1
        AddHandler TMR.Tick, AddressOf TMR_Tick
        TMR.Enabled = True
    End Sub
    Private Sub TMR_Tick(ByVal sender As Object, ByVal e As EventArgs)
        Me.Enabled = True
        TMR.Enabled = False
        FillFolders()
        LoadAllIcons()
    End Sub
    Public Sub LoadAllIcons()
        Dim Icon As System.Drawing.Icon
        FunLib.GetAllFilesType(IconPath)
        Dim IconName() As String
        If FunLib.AllFilesType Is Nothing Then
            Exit Sub
        End If
        For Int1 = 0 To FunLib.AllFilesType.Length - 1
            IconName = FunLib.AllFilesType(Int1).TypeIcon.Split("\") 'Change the icon path from the database path to internal path (IconPath & IconName)
            If System.IO.File.Exists(IconPath & IconName(IconName.Length - 1)) Then
                'Try to add the normal icon
                Icon = New Icon(IconPath & IconName(IconName.Length - 1))
                IconsList.Images.Add(FunLib.AllFilesType(Int1).TypeID, Icon)
            ElseIf System.IO.File.Exists(Application.StartupPath & "\Temp\Icons\Default.ico") Then
                'Try to add the the default icon
                Icon = New Icon(Application.StartupPath & "\Temp\Icons\Default.ico")
                IconsList.Images.Add(FunLib.AllFilesType(Int1).TypeID, Icon)
            Else
                'Try to add the Internal icon
                IconsList.Images.Add(FunLib.AllFilesType(Int1).TypeID, MainImageList.Images(1))
            End If
        Next
    End Sub
    Public Sub FillFolders()
        TVFolders.Nodes.Clear()
        'Starting progress bar
        ToolStripLoadingProgressBar.Visible = True
        ToolStripStatusLoadingLabel.Visible = True
        ToolStripLoadingProgressBar.Maximum = 10
        ToolStripLoadingProgressBar.Value = 1
        'Tree Node name = FolderID,Tree Node Test = FolderName,Tree Node Tag = Folder Index inside AllFoldersWithPrv.FolderInfo
        FunLib.GetAllFoldersWithFilesOrdered(ProjectsPath, FunLib.CUser.UID, AllFoldersWithPrv, ToolStripLoadingProgressBar.Maximum, ToolStripLoadingProgressBar.Value)
        Dim MyTreeNod As New TreeNode
        Dim i As Integer = 0
        ToolStripLoadingProgressBar.Value = 0
        If AllFoldersWithPrv.FolderInfo Is Nothing Then
            MsgBox_("No Projects found", 123, 23, False, Me)
            Process.GetCurrentProcess.Kill()
        End If
        ToolStripLoadingProgressBar.Maximum = AllFoldersWithPrv.FolderInfo.Length
        For i = 0 To AllFoldersWithPrv.FolderInfo.Length - 1
            ToolStripLoadingProgressBar.Value += 1
            Application.DoEvents()
            Dim InternalPath As String
            InternalPath = AllFoldersWithPrv.FolderInfo(i).FolderPath.Substring(ProjectsPath.Length)
            Dim arr() As String
            arr = InternalPath.Split("\")
            Select Case arr.Length
                Case 1
                    'Level 0
                    MyTreeNod = New TreeNode
                    MyTreeNod.Text = AllFoldersWithPrv.FolderInfo(i).FolderName
                    MyTreeNod.Name = AllFoldersWithPrv.FolderInfo(i).FolderID
                    MyTreeNod.Tag = i
                    TVFolders.Nodes.Add(MyTreeNod)
                Case 2
                    'Level 1
                    MyTreeNod = New TreeNode
                    Dim IntCase2 As Integer = 0
                    For IntCase2 = 0 To TVFolders.Nodes.Count - 1
                        If TVFolders.Nodes(IntCase2).Name = AllFoldersWithPrv.FolderInfo(i).ParentID Then
                            MyTreeNod.Text = AllFoldersWithPrv.FolderInfo(i).FolderName
                            MyTreeNod.Name = AllFoldersWithPrv.FolderInfo(i).FolderID
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
                                If TVFolders.Nodes(IntCase3).Nodes(IntCase3_1).Name = AllFoldersWithPrv.FolderInfo(i).ParentID Then
                                    MyTreeNod.Text = AllFoldersWithPrv.FolderInfo(i).FolderName
                                    MyTreeNod.Name = AllFoldersWithPrv.FolderInfo(i).FolderID
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
                                            MyTreeNod.Text = AllFoldersWithPrv.FolderInfo(i).FolderName
                                            MyTreeNod.Name = AllFoldersWithPrv.FolderInfo(i).FolderID
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
                                                    MyTreeNod.Text = AllFoldersWithPrv.FolderInfo(i).FolderName
                                                    MyTreeNod.Name = AllFoldersWithPrv.FolderInfo(i).FolderID
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
        ToolStripLoadingProgressBar.Value = 0
        ToolStripLoadingProgressBar.Visible = False
        ToolStripStatusLoadingLabel.Visible = False
    End Sub
    Private Sub TVFolders_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TVFolders.AfterSelect
        RelaodFilesInListView()
    End Sub
    Private Sub TVFolders_NodeMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TVFolders.NodeMouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            TVFolders.SelectedNode = e.Node
        End If
    End Sub
    Public Sub RelaodFilesInListView()
        If TVFolders.SelectedNode IsNot Nothing Then
            LVFiles.Items.Clear()
            Dim LVI As ListViewItem
            If AllFoldersWithPrv.FolderInfo(TVFolders.SelectedNode.Tag).Files IsNot Nothing Then
                For Int1 = 0 To AllFoldersWithPrv.FolderInfo(TVFolders.SelectedNode.Tag).Files.Length - 1
                    LVI = New ListViewItem
                    LVI.Text = AllFoldersWithPrv.FolderInfo(TVFolders.SelectedNode.Tag).Files(Int1).FileName
                    LVI.SubItems.Add(CDate(AllFoldersWithPrv.FolderInfo(TVFolders.SelectedNode.Tag).Files(Int1).CreatedIn).Date)
                    LVI.SubItems.Add(AllFoldersWithPrv.FolderInfo(TVFolders.SelectedNode.Tag).Files(Int1).UserName)
                    LVI.SubItems.Add(AllFoldersWithPrv.FolderInfo(TVFolders.SelectedNode.Tag).Files(Int1).TypeName)
                    If AllFoldersWithPrv.FolderInfo(TVFolders.SelectedNode.Tag).Files(Int1).InUse = "1" Then
                        LVI.ImageKey = "Locked.ico"
                        LVI.SubItems.Add("Locked")
                        LVI.SubItems.Add(AllFoldersWithPrv.FolderInfo(TVFolders.SelectedNode.Tag).Files(Int1).InUseUserName)
                        LVI.BackColor = Color.Blue
                        LVI.ForeColor = Color.Red
                        LVI.ToolTipText = "This file is locked by user :" & AllFoldersWithPrv.FolderInfo(TVFolders.SelectedNode.Tag).Files(Int1).InUseUserName
                    Else
                        LVI.ImageKey = AllFoldersWithPrv.FolderInfo(TVFolders.SelectedNode.Tag).Files(Int1).TypeID
                    End If
                    LVFiles.Items.Add(LVI)
                Next
            End If
        End If
    End Sub
    Private Sub MainWindowFrm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Process.GetCurrentProcess.Kill()
    End Sub
#Region "  -  Menu Commands  -  "
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Process.GetCurrentProcess.Kill()
    End Sub
    Private Sub LockedFilesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LockedFilesToolStripMenuItem.Click
        FrmLockedFiles = New LockedFilesFrm
        FrmLockedFiles.ShowDialog()
    End Sub
    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        FrmOptions = New OptionsFrm
        FrmOptions.TxtPassword.Text = FunLib.CUser.UPass
        FrmOptions.TxtPasswordCon.Text = FunLib.CUser.UPass
        FrmOptions.ShowDialog()
    End Sub
    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolBarToolStripMenuItem.Click
        If ToolBarToolStripMenuItem.Checked = False Then
            ToolStrip.Visible = False
        Else
            ToolStrip.Visible = True
        End If
    End Sub
    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatusBarToolStripMenuItem.Click
        If StatusBarToolStripMenuItem.Checked = False Then
            StatusStrip.Visible = False
        Else
            StatusStrip.Visible = True
        End If
    End Sub
#End Region
#Region "  -  Context Menus  -  "
    Private Sub FoldersCMenuTree_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles FoldersCMenuTree.Opening
        If TVFolders.SelectedNode Is Nothing Then
            e.Cancel = True
            Exit Sub
        End If
        If AllFoldersWithPrv.PrvOperationsType(TVFolders.SelectedNode.Tag).CanWrite = True Then 'Chech for Write privilage
            CreateFolderToolStripMenuItem.Enabled = True
        Else
            CreateFolderToolStripMenuItem.Enabled = False
        End If
        If AllFoldersWithPrv.PrvOperationsType(TVFolders.SelectedNode.Tag).CanDelete = True Then 'Chech for Delete privilage
            FoldersRemoveToolStripMenuItem.Enabled = True
        Else
            FoldersRemoveToolStripMenuItem.Enabled = False
        End If
    End Sub
    Private Sub FilesCMenuTree_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles FilesCMenuTree.Opening
        If TVFolders.SelectedNode Is Nothing Then 'if there is no active folder
            e.Cancel = True
            Exit Sub
        ElseIf LVFiles.SelectedIndices.Count = 0 Then 'If there is no selected file
            FilesRemoveToolStripMenuItem.Enabled = False
            FilesPropertiesToolStripMenuItem.Enabled = False
            TransferToolStripMenuItem.Enabled = False
            lockToolStripMenuItem.Enabled = False
            If AllFoldersWithPrv.PrvOperationsType(TVFolders.SelectedNode.Tag).CanWrite = True Then
                AddFilesToolStripMenuItem.Enabled = True
            Else
                AddFilesToolStripMenuItem.Enabled = False
            End If
            Exit Sub
        End If
        TransferToolStripMenuItem.Enabled = True
        If AllFoldersWithPrv.FolderInfo(TVFolders.SelectedNode.Tag).Files(LVFiles.SelectedIndices(0)).InUse = "1" Then 'if file is locked
            AddFilesToolStripMenuItem.Enabled = False
            FilesRemoveToolStripMenuItem.Enabled = False
            FilesPropertiesToolStripMenuItem.Enabled = False
            If FunLib.CUser.UID = AllFoldersWithPrv.FolderInfo(TVFolders.SelectedNode.Tag).Files(LVFiles.SelectedIndices(0)).InUseUserID Then
                lockToolStripMenuItem.Enabled = True
                lockToolStripMenuItem.Text = "&Unlock"
            Else
                lockToolStripMenuItem.Enabled = False
            End If
        ElseIf AllFoldersWithPrv.PrvOperationsType(TVFolders.SelectedNode.Tag).CanWrite = True Then ' if canwrite enabled and the file is unlocked
            lockToolStripMenuItem.Text = "&Lock"
            lockToolStripMenuItem.Enabled = True
            FilesPropertiesToolStripMenuItem.Enabled = True
        Else
            lockToolStripMenuItem.Enabled = False
            FilesPropertiesToolStripMenuItem.Enabled = True
        End If

        If AllFoldersWithPrv.PrvOperationsType(TVFolders.SelectedNode.Tag).CanWrite = True Then 'Chech for Write privilage
            AddFilesToolStripMenuItem.Enabled = True
            TransferToolStripMenuItem.Enabled = True
        Else
            AddFilesToolStripMenuItem.Enabled = False
            TransferToolStripMenuItem.Enabled = False
        End If
        If AllFoldersWithPrv.PrvOperationsType(TVFolders.SelectedNode.Tag).CanDelete = True Then 'Chech for Delete privilage
            FilesRemoveToolStripMenuItem.Enabled = True
        Else
            FilesRemoveToolStripMenuItem.Enabled = False
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
            FrmObjectProperty.LblNewFolderPath.Text = AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).FolderPath
            FrmObjectProperty.LblNewFolderDate.Text = Now.Date
            FrmObjectProperty.LblNewFolderOwner.Text = FunLib.CUser.UName
            FrmObjectProperty.LblNewFolderProjectName.Text = AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).ProName
            'privilage will remove cus the creation related 2 the user privilage only
            FrmObjectProperty.FoldersFilesTabControl.Controls.Clear()
            FrmObjectProperty.FoldersFilesTabControl.Controls.Add(FrmObjectProperty.NewFolderTabPage)
            FrmObjectProperty.Text = " New Folder"
            FrmObjectProperty.ShowDialog()
        Else
            MsgBox_("No Object is selected", 112, 23, False, Me)
        End If
    End Sub
    Private Sub AddFilesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddFilesToolStripMenuItem.Click
        If TVFolders.SelectedNode IsNot Nothing Then
            PropertyObjectInfo.FolderIndex = TVFolders.SelectedNode.Tag
            FrmObjectProperty = New ObjectPropertyFrm
            FrmObjectProperty.LblNewFileDate.Text = Now.Date
            FrmObjectProperty.LblNewFileProjectName.Text = AllFoldersWithPrv.FolderInfo(TVFolders.SelectedNode.Tag).ProName
            If FunLib.AllFilesType IsNot Nothing Then
                For Int1 = 0 To FunLib.AllFilesType.Length - 1
                    FrmObjectProperty.FileTypeCB.Items.Add(FunLib.AllFilesType(Int1).TypeName)
                Next
            End If
            FrmObjectProperty.FoldersFilesTabControl.Controls.Clear()
            FrmObjectProperty.FoldersFilesTabControl.Controls.Add(FrmObjectProperty.NewFileTabPage)
            FrmObjectProperty.Text = "New File Properties"
            FrmObjectProperty.ShowDialog()
        End If
    End Sub
    Private Sub FilesRemoveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilesRemoveToolStripMenuItem.Click
        If TVFolders.SelectedNode IsNot Nothing And LVFiles.SelectedIndices.Count > 0 Then
            If MsgBox("You are about to remove this file" & vbNewLine & "Are you sure?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Sub
            End If
            Me.Enabled = False
            PropertyObjectInfo.FolderIndex = TVFolders.SelectedNode.Tag
            PropertyObjectInfo.FileIndex = LVFiles.SelectedItems(0).Index
            Dim ErrorResult As String = ""
            ErrorResult = FunLib.RemoveFile(AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files(PropertyObjectInfo.FileIndex).FileID)
            If ErrorResult Is Nothing Then
                ErrorResult = Nothing
                ErrorResult = NWLib.RemoveFile(ServerIP, REQPort, AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files(PropertyObjectInfo.FileIndex).FilePath, DeletedFilesPath)
                If ErrorResult = Nothing Then
                    MsgBox_("Data saving successfull", 106, 23, True, Me)
                    'MsgBox_("File successfully removed", 99, 23, True, Me)
                Else
                    Me.Enabled = True
                    MsgBox_(ErrorResult, 0, 23, False, Me)
                    Exit Sub
                End If
                'Remove element from array by creating new file array after the element is removed
                Dim NewArray(AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files.Length - 1) As FunctionLib.DataCenterClientLib.FileInfo
                Array.Copy(AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files, NewArray, AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files.Length)
                ReDim Preserve AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files(0)
                For Int1 = 0 To NewArray.Length - 1
                    If Int1 <> LVFiles.SelectedItems(0).Index Then
                        AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files(AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files.Length - 1).CreatedIn = NewArray(Int1).CreatedIn
                        AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files(AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files.Length - 1).Dis = NewArray(Int1).Dis
                        AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files(AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files.Length - 1).FileID = NewArray(Int1).FileID
                        AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files(AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files.Length - 1).FileName = NewArray(Int1).FileName
                        AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files(AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files.Length - 1).FilePath = NewArray(Int1).FilePath
                        AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files(AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files.Length - 1).FolderID = NewArray(Int1).FolderID
                        AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files(AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files.Length - 1).ProID = NewArray(Int1).ProID
                        AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files(AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files.Length - 1).TypeID = NewArray(Int1).TypeID
                        AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files(AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files.Length - 1).TypeName = NewArray(Int1).TypeName
                        AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files(AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files.Length - 1).TypePath = NewArray(Int1).TypePath
                        AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files(AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files.Length - 1).TypePath = NewArray(Int1).TypePath
                        AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files(AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files.Length - 1).UserName = NewArray(Int1).UserName
                        AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files(AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files.Length - 1).UsrID = NewArray(Int1).UsrID
                        ReDim Preserve AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files(AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files.Length)
                    Else
                    End If
                Next
                ReDim Preserve AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files(AllFoldersWithPrv.FolderInfo(PropertyObjectInfo.FolderIndex).Files.Length - 2)
                LVFiles.SelectedItems(0).Remove()
                Me.Enabled = True
            Else
                MsgBox_(ErrorResult, 0, 23, False, Me)
            End If
        End If
    End Sub
    Private Sub FilesPropertiesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilesPropertiesToolStripMenuItem.Click
        'Must Edit to fit the client case
        If LVFiles.SelectedIndices.Count > 0 Then
            FrmObjectProperty = New ObjectPropertyFrm
            PropertyObjectInfo.FolderIndex = TVFolders.SelectedNode.Tag
            PropertyObjectInfo.FileIndex = LVFiles.SelectedItems(0).Index
            FrmObjectProperty.TxtFileName.Text = AllFoldersWithPrv.FolderInfo(TVFolders.SelectedNode.Tag).Files(LVFiles.SelectedIndices.Item(0)).FileName
            FrmObjectProperty.LblFilePath.Text = AllFoldersWithPrv.FolderInfo(TVFolders.SelectedNode.Tag).Files(LVFiles.SelectedIndices.Item(0)).FilePath
            FrmObjectProperty.LblDate.Text = CDate(AllFoldersWithPrv.FolderInfo(TVFolders.SelectedNode.Tag).Files(LVFiles.SelectedIndices.Item(0)).CreatedIn).Date
            FrmObjectProperty.LblUser.Text = AllFoldersWithPrv.FolderInfo(TVFolders.SelectedNode.Tag).Files(LVFiles.SelectedIndices.Item(0)).UserName
            FrmObjectProperty.LblProject.Text = AllFoldersWithPrv.FolderInfo(TVFolders.SelectedNode.Tag).ProName
            FrmObjectProperty.LblFileType.Text = AllFoldersWithPrv.FolderInfo(TVFolders.SelectedNode.Tag).Files(LVFiles.SelectedIndices.Item(0)).TypeName
            FrmObjectProperty.TxtDisc.Text = AllFoldersWithPrv.FolderInfo(TVFolders.SelectedNode.Tag).Files(LVFiles.SelectedIndices.Item(0)).Dis
            ''''''''''''''''' i Can Add Type Icon To This Window
            FrmObjectProperty.FoldersFilesTabControl.Controls.Clear()
            FrmObjectProperty.FoldersFilesTabControl.Controls.Add(FrmObjectProperty.FilesTabPage)
            FrmObjectProperty.Text = "File Properties"
            'Privilages Effect
            If AllFoldersWithPrv.PrvOperationsType(TVFolders.SelectedNode.Tag).CanWrite = False Then 'Chech for Write privilage
                FrmObjectProperty.BtnEditFileName.Enabled = False
                FrmObjectProperty.BtnSaveFile.Enabled = False
            End If
            FrmObjectProperty.ShowDialog()
        End If
    End Sub
    Private Sub FoldersPropertiesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FoldersPropertiesToolStripMenuItem.Click
        'Mist Edit to fit the client case
        FrmObjectProperty = New ObjectPropertyFrm
        If Not TVFolders.SelectedNode Is Nothing Then
            Dim i As Integer = TVFolders.SelectedNode.Tag
            PropertyObjectInfo.FolderIndex = i
            PropertyObjectInfo.ObjecyType = ObjectType.ExistedFolder
            FrmObjectProperty.TxtFolderName.Text = AllFoldersWithPrv.FolderInfo(i).FolderName
            FrmObjectProperty.LblFolderPath.Text = AllFoldersWithPrv.FolderInfo(i).FolderPath
            FrmObjectProperty.LblFolderDate.Text = CDate(AllFoldersWithPrv.FolderInfo(i).CreatedIn).Date
            FrmObjectProperty.LblFolderUser.Text = AllFoldersWithPrv.FolderInfo(i).UserName
            FrmObjectProperty.LblFolderProject.Text = AllFoldersWithPrv.FolderInfo(i).ProName
            FrmObjectProperty.TxtFolderDisc.Text = AllFoldersWithPrv.FolderInfo(i).Disc
            FunLib.GetAllprivilege(AllFoldersWithPrv.FolderInfo(i).ProID)
            FrmObjectProperty.FoldersFilesTabControl.Controls.Clear()
            FrmObjectProperty.FoldersFilesTabControl.Controls.Add(FrmObjectProperty.FoldersTabPage)
            FrmObjectProperty.Text = " Folder Properties"
            'Privilage Effect
            If AllFoldersWithPrv.PrvOperationsType(TVFolders.SelectedNode.Tag).CanWrite = False Then 'Chech for Write privilage
                FrmObjectProperty.BtnEditFolderName.Enabled = False
                FrmObjectProperty.BtnSaveFolder.Enabled = False
            End If
            FrmObjectProperty.ShowDialog()
        Else
            MsgBox_("Please Select a Folder", 112, 23, False, Me)
        End If
    End Sub
    Private Sub FoldersRemoveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FoldersRemoveToolStripMenuItem.Click
        Me.Enabled = False
        If TVFolders.SelectedNode.IsSelected = False Then
            Exit Sub
        End If
        'Check if the folder have files or folder
        If AllFoldersWithPrv.FolderInfo(TVFolders.SelectedNode.Tag).Files IsNot Nothing Then
            If AllFoldersWithPrv.FolderInfo(TVFolders.SelectedNode.Tag).Files.Length <> 0 Then
                MsgBox_("This folder is not empty", 104, 23, False, Me)
                Exit Sub
            End If
        End If
        If TVFolders.SelectedNode.Nodes.Count = 0 Then
            Dim RemoveFolderErrorResult As String
            If MsgBox("You are about to remove this folder" & vbNewLine & "Are you sure?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Sub
            End If
            RemoveFolderErrorResult = FunLib.RemoveFolder(AllFoldersWithPrv.FolderInfo(TVFolders.SelectedNode.Tag).FolderID)
            If RemoveFolderErrorResult = Nothing Then
                'try to remove the Phy folder
                NWLib.RemoveFolder(ServerIP, REQPort, AllFoldersWithPrv.FolderInfo(TVFolders.SelectedNode.Tag).FolderPath, DeletedFilesPath)
                MsgBox_("Data saving successfull", 106, 23, True, Me)
                'MsgBox_("Folder removed  - Data saved successfully", 42, 23, True, Me)
                'Reload TreeView
                FillFolders()
            End If
        Else
            MsgBox_("This folder is not empty", 104, 23, False, Me)
        End If
        Me.Enabled = True
    End Sub
    Private Sub lockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lockToolStripMenuItem.Click
        If lockToolStripMenuItem.Text = "&Lock" Then
            ErrorProviderZ = Nothing
            ErrorProviderZ = FunLib.LockFile(AllFoldersWithPrv.FolderInfo(TVFolders.SelectedNode.Tag).Files(LVFiles.SelectedIndices(0)).FileID, FunLib.CUser.UID)
            If ErrorProviderZ = Nothing Then
                AllFoldersWithPrv.FolderInfo(TVFolders.SelectedNode.Tag).Files(LVFiles.SelectedIndices(0)).InUseUserName = FunLib.CUser.UName
                AllFoldersWithPrv.FolderInfo(TVFolders.SelectedNode.Tag).Files(LVFiles.SelectedIndices(0)).InUse = "1"
                AllFoldersWithPrv.FolderInfo(TVFolders.SelectedNode.Tag).Files(LVFiles.SelectedIndices(0)).InUseUserID = FunLib.CUser.UID
                If LVFiles.SelectedItems(0).SubItems.Count > 4 Then
                    LVFiles.SelectedItems(0).SubItems(4).Text = "Locked"
                    LVFiles.SelectedItems(0).SubItems(5).Text = FunLib.CUser.UName
                Else
                    LVFiles.SelectedItems(0).SubItems.Add("Locked")
                    LVFiles.SelectedItems(0).SubItems.Add(FunLib.CUser.UName)
                End If
                'Locked files color
                LVFiles.SelectedItems(0).BackColor = Color.Blue
                LVFiles.SelectedItems(0).ForeColor = Color.Red
                lockToolStripMenuItem.Text = "&Unlock"
            End If
        Else
            ErrorProviderZ = Nothing
            ErrorProviderZ = FunLib.UnLockFile(AllFoldersWithPrv.FolderInfo(TVFolders.SelectedNode.Tag).Files(LVFiles.SelectedIndices(0)).FileID)
            If ErrorProviderZ = Nothing Then
                AllFoldersWithPrv.FolderInfo(TVFolders.SelectedNode.Tag).Files(LVFiles.SelectedIndices(0)).InUseUserName = ""
                AllFoldersWithPrv.FolderInfo(TVFolders.SelectedNode.Tag).Files(LVFiles.SelectedIndices(0)).InUse = "0"
                AllFoldersWithPrv.FolderInfo(TVFolders.SelectedNode.Tag).Files(LVFiles.SelectedIndices(0)).InUseUserID = ""
                LVFiles.SelectedItems(0).SubItems(4).Text = ""
                LVFiles.SelectedItems(0).SubItems(5).Text = ""
                LVFiles.SelectedItems(0).BackColor = Color.Empty
                LVFiles.SelectedItems(0).ForeColor = Color.Empty
                lockToolStripMenuItem.Text = "&Lock"
            End If
        End If
    End Sub
    Private Sub TransferToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransferToolStripMenuItem.Click
        FrmTransfer = New TransferFrm
        FrmTransfer.ShowDialog()
    End Sub
#End Region
#Region "  -  Tool bar menus  -  "
    Private Sub LargeIconToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LargeIconToolStripMenuItem.Click
        LVFiles.View = View.LargeIcon
    End Sub
    Private Sub SmallIconToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SmallIconToolStripMenuItem.Click
        LVFiles.View = View.SmallIcon
    End Sub
    Private Sub DetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetailsToolStripMenuItem.Click
        LVFiles.View = View.Details
    End Sub
    Private Sub ListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListToolStripMenuItem.Click
        LVFiles.View = View.List
    End Sub
    Private Sub LockedfilesStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LockedfilesStripButton.Click
        LockedFilesToolStripMenuItem_Click(sender, e)
    End Sub
    Private Sub OptionsToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripButton.Click
        OptionsToolStripMenuItem_Click(sender, e)
    End Sub
#End Region

    
End Class