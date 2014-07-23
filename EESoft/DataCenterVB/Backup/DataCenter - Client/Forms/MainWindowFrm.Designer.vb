<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindowFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindowFrm))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LockedFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SplitContainer = New System.Windows.Forms.SplitContainer
        Me.TVFolders = New System.Windows.Forms.TreeView
        Me.FoldersCMenuTree = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CreateFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FoldersRemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FoldersPropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MainImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.LVFiles = New System.Windows.Forms.ListView
        Me.ColHDFileName = New System.Windows.Forms.ColumnHeader
        Me.ColHDCreatedIn = New System.Windows.Forms.ColumnHeader
        Me.ColHDCreatedBy = New System.Windows.Forms.ColumnHeader
        Me.ColHDFileType = New System.Windows.Forms.ColumnHeader
        Me.ColHDLockStatus = New System.Windows.Forms.ColumnHeader
        Me.ColHDLockedBy = New System.Windows.Forms.ColumnHeader
        Me.FilesCMenuTree = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.lockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TransferToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FilesRemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FilesPropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IconsList = New System.Windows.Forms.ImageList(Me.components)
        Me.FoldersToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.FoldersToolStripProgressBar = New System.Windows.Forms.ToolStripProgressBar
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLoadingLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripLoadingProgressBar = New System.Windows.Forms.ToolStripProgressBar
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.FileListViewToolStripDropDownButton = New System.Windows.Forms.ToolStripDropDownButton
        Me.LargeIconToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SmallIconToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.LockedfilesStripButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.OptionsToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.HelpToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.MenuStrip.SuspendLayout()
        Me.SplitContainer.Panel1.SuspendLayout()
        Me.SplitContainer.Panel2.SuspendLayout()
        Me.SplitContainer.SuspendLayout()
        Me.FoldersCMenuTree.SuspendLayout()
        Me.FilesCMenuTree.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.Black
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.ViewMenu, Me.ToolsToolStripMenuItem, Me.HelpMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(823, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.BackColor = System.Drawing.Color.Navy
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileMenu.ForeColor = System.Drawing.Color.White
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(35, 20)
        Me.FileMenu.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.BackColor = System.Drawing.Color.Navy
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.ExitToolStripMenuItem.Image = Global.DataCenter_Client.My.Resources.Resources.Exit_
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ViewMenu
        '
        Me.ViewMenu.BackColor = System.Drawing.Color.Navy
        Me.ViewMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolBarToolStripMenuItem, Me.StatusBarToolStripMenuItem})
        Me.ViewMenu.ForeColor = System.Drawing.Color.White
        Me.ViewMenu.Name = "ViewMenu"
        Me.ViewMenu.Size = New System.Drawing.Size(41, 20)
        Me.ViewMenu.Text = "&View"
        '
        'ToolBarToolStripMenuItem
        '
        Me.ToolBarToolStripMenuItem.BackColor = System.Drawing.Color.Navy
        Me.ToolBarToolStripMenuItem.Checked = True
        Me.ToolBarToolStripMenuItem.CheckOnClick = True
        Me.ToolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolBarToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.ToolBarToolStripMenuItem.Name = "ToolBarToolStripMenuItem"
        Me.ToolBarToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.ToolBarToolStripMenuItem.Text = "&Toolbar"
        '
        'StatusBarToolStripMenuItem
        '
        Me.StatusBarToolStripMenuItem.BackColor = System.Drawing.Color.Navy
        Me.StatusBarToolStripMenuItem.Checked = True
        Me.StatusBarToolStripMenuItem.CheckOnClick = True
        Me.StatusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.StatusBarToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
        Me.StatusBarToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.StatusBarToolStripMenuItem.Text = "&Status Bar"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.BackColor = System.Drawing.Color.Navy
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LockedFilesToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'LockedFilesToolStripMenuItem
        '
        Me.LockedFilesToolStripMenuItem.BackColor = System.Drawing.Color.Navy
        Me.LockedFilesToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.LockedFilesToolStripMenuItem.Image = Global.DataCenter_Client.My.Resources.Resources.Locked_Files
        Me.LockedFilesToolStripMenuItem.Name = "LockedFilesToolStripMenuItem"
        Me.LockedFilesToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.LockedFilesToolStripMenuItem.Text = "Locked files"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.BackColor = System.Drawing.Color.Navy
        Me.OptionsToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.OptionsToolStripMenuItem.Image = Global.DataCenter_Client.My.Resources.Resources.Options
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'HelpMenu
        '
        Me.HelpMenu.BackColor = System.Drawing.Color.Navy
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IndexToolStripMenuItem, Me.ToolStripSeparator8, Me.AboutToolStripMenuItem})
        Me.HelpMenu.ForeColor = System.Drawing.Color.White
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(40, 20)
        Me.HelpMenu.Text = "&Help"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.BackColor = System.Drawing.Color.Navy
        Me.IndexToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.IndexToolStripMenuItem.Image = CType(resources.GetObject("IndexToolStripMenuItem.Image"), System.Drawing.Image)
        Me.IndexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.IndexToolStripMenuItem.Text = "&Index"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.BackColor = System.Drawing.Color.DarkGray
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(115, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.BackColor = System.Drawing.Color.Navy
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.AboutToolStripMenuItem.Image = Global.DataCenter_Client.My.Resources.Resources.About
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.AboutToolStripMenuItem.Text = "&About ..."
        '
        'SplitContainer
        '
        Me.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer.Location = New System.Drawing.Point(0, 49)
        Me.SplitContainer.Name = "SplitContainer"
        '
        'SplitContainer.Panel1
        '
        Me.SplitContainer.Panel1.AccessibleDescription = "Folders Tree"
        Me.SplitContainer.Panel1.Controls.Add(Me.TVFolders)
        '
        'SplitContainer.Panel2
        '
        Me.SplitContainer.Panel2.Controls.Add(Me.LVFiles)
        Me.SplitContainer.Size = New System.Drawing.Size(823, 572)
        Me.SplitContainer.SplitterDistance = 175
        Me.SplitContainer.TabIndex = 1
        '
        'TVFolders
        '
        Me.TVFolders.BackColor = System.Drawing.Color.DimGray
        Me.TVFolders.ContextMenuStrip = Me.FoldersCMenuTree
        Me.TVFolders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TVFolders.ForeColor = System.Drawing.Color.Lime
        Me.TVFolders.FullRowSelect = True
        Me.TVFolders.HideSelection = False
        Me.TVFolders.ImageIndex = 0
        Me.TVFolders.ImageList = Me.MainImageList
        Me.TVFolders.Location = New System.Drawing.Point(0, 0)
        Me.TVFolders.Name = "TVFolders"
        Me.TVFolders.SelectedImageIndex = 0
        Me.TVFolders.Size = New System.Drawing.Size(175, 572)
        Me.TVFolders.TabIndex = 0
        '
        'FoldersCMenuTree
        '
        Me.FoldersCMenuTree.BackColor = System.Drawing.Color.LightGray
        Me.FoldersCMenuTree.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateFolderToolStripMenuItem, Me.FoldersRemoveToolStripMenuItem, Me.FoldersPropertiesToolStripMenuItem})
        Me.FoldersCMenuTree.Name = "CMenuTree"
        Me.FoldersCMenuTree.Size = New System.Drawing.Size(141, 70)
        '
        'CreateFolderToolStripMenuItem
        '
        Me.CreateFolderToolStripMenuItem.Image = Global.DataCenter_Client.My.Resources.Resources.Add_folder
        Me.CreateFolderToolStripMenuItem.Name = "CreateFolderToolStripMenuItem"
        Me.CreateFolderToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.CreateFolderToolStripMenuItem.Text = "&Create Folder"
        '
        'FoldersRemoveToolStripMenuItem
        '
        Me.FoldersRemoveToolStripMenuItem.Image = Global.DataCenter_Client.My.Resources.Resources.remove_folder
        Me.FoldersRemoveToolStripMenuItem.Name = "FoldersRemoveToolStripMenuItem"
        Me.FoldersRemoveToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.FoldersRemoveToolStripMenuItem.Text = "&Remove"
        '
        'FoldersPropertiesToolStripMenuItem
        '
        Me.FoldersPropertiesToolStripMenuItem.Image = Global.DataCenter_Client.My.Resources.Resources.folder_property
        Me.FoldersPropertiesToolStripMenuItem.Name = "FoldersPropertiesToolStripMenuItem"
        Me.FoldersPropertiesToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.FoldersPropertiesToolStripMenuItem.Text = "&Properties"
        '
        'MainImageList
        '
        Me.MainImageList.ImageStream = CType(resources.GetObject("MainImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.MainImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.MainImageList.Images.SetKeyName(0, "FoldersIcon.ico")
        Me.MainImageList.Images.SetKeyName(1, "Default.ico")
        '
        'LVFiles
        '
        Me.LVFiles.BackColor = System.Drawing.Color.Gainsboro
        Me.LVFiles.BackgroundImage = Global.DataCenter_Client.My.Resources.Resources.LVFiles
        Me.LVFiles.BackgroundImageTiled = True
        Me.LVFiles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColHDFileName, Me.ColHDCreatedIn, Me.ColHDCreatedBy, Me.ColHDFileType, Me.ColHDLockStatus, Me.ColHDLockedBy})
        Me.LVFiles.ContextMenuStrip = Me.FilesCMenuTree
        Me.LVFiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LVFiles.FullRowSelect = True
        Me.LVFiles.GridLines = True
        Me.LVFiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LVFiles.LargeImageList = Me.IconsList
        Me.LVFiles.Location = New System.Drawing.Point(0, 0)
        Me.LVFiles.MultiSelect = False
        Me.LVFiles.Name = "LVFiles"
        Me.LVFiles.Size = New System.Drawing.Size(644, 572)
        Me.LVFiles.SmallImageList = Me.IconsList
        Me.LVFiles.TabIndex = 2
        Me.LVFiles.UseCompatibleStateImageBehavior = False
        Me.LVFiles.View = System.Windows.Forms.View.Details
        '
        'ColHDFileName
        '
        Me.ColHDFileName.Text = "File Name"
        Me.ColHDFileName.Width = 159
        '
        'ColHDCreatedIn
        '
        Me.ColHDCreatedIn.Text = "Created In"
        Me.ColHDCreatedIn.Width = 100
        '
        'ColHDCreatedBy
        '
        Me.ColHDCreatedBy.Text = "Created By"
        Me.ColHDCreatedBy.Width = 100
        '
        'ColHDFileType
        '
        Me.ColHDFileType.Text = "File Type"
        Me.ColHDFileType.Width = 100
        '
        'ColHDLockStatus
        '
        Me.ColHDLockStatus.Text = "Lock Status"
        Me.ColHDLockStatus.Width = 80
        '
        'ColHDLockedBy
        '
        Me.ColHDLockedBy.Text = "Locked By"
        Me.ColHDLockedBy.Width = 100
        '
        'FilesCMenuTree
        '
        Me.FilesCMenuTree.BackColor = System.Drawing.Color.LightGray
        Me.FilesCMenuTree.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lockToolStripMenuItem, Me.TransferToolStripMenuItem, Me.AddFilesToolStripMenuItem, Me.FilesRemoveToolStripMenuItem, Me.FilesPropertiesToolStripMenuItem})
        Me.FilesCMenuTree.Name = "CMenuTree"
        Me.FilesCMenuTree.Size = New System.Drawing.Size(124, 114)
        '
        'lockToolStripMenuItem
        '
        Me.lockToolStripMenuItem.Enabled = False
        Me.lockToolStripMenuItem.Image = Global.DataCenter_Client.My.Resources.Resources.Lock_file
        Me.lockToolStripMenuItem.Name = "lockToolStripMenuItem"
        Me.lockToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.lockToolStripMenuItem.Text = "&Lock"
        '
        'TransferToolStripMenuItem
        '
        Me.TransferToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransferToolStripMenuItem.Image = Global.DataCenter_Client.My.Resources.Resources.Transfer
        Me.TransferToolStripMenuItem.Name = "TransferToolStripMenuItem"
        Me.TransferToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.TransferToolStripMenuItem.Text = "&Transfer"
        '
        'AddFilesToolStripMenuItem
        '
        Me.AddFilesToolStripMenuItem.Image = Global.DataCenter_Client.My.Resources.Resources.new_file
        Me.AddFilesToolStripMenuItem.Name = "AddFilesToolStripMenuItem"
        Me.AddFilesToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.AddFilesToolStripMenuItem.Text = "&Add File"
        '
        'FilesRemoveToolStripMenuItem
        '
        Me.FilesRemoveToolStripMenuItem.Image = Global.DataCenter_Client.My.Resources.Resources.DeleteObject
        Me.FilesRemoveToolStripMenuItem.Name = "FilesRemoveToolStripMenuItem"
        Me.FilesRemoveToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.FilesRemoveToolStripMenuItem.Text = "&Remove"
        '
        'FilesPropertiesToolStripMenuItem
        '
        Me.FilesPropertiesToolStripMenuItem.Image = Global.DataCenter_Client.My.Resources.Resources.file_property
        Me.FilesPropertiesToolStripMenuItem.Name = "FilesPropertiesToolStripMenuItem"
        Me.FilesPropertiesToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.FilesPropertiesToolStripMenuItem.Text = "&Properties"
        '
        'IconsList
        '
        Me.IconsList.ImageStream = CType(resources.GetObject("IconsList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IconsList.TransparentColor = System.Drawing.Color.Transparent
        Me.IconsList.Images.SetKeyName(0, "Locked.ico")
        Me.IconsList.Images.SetKeyName(1, "NotFound.ico")
        '
        'FoldersToolStripStatusLabel
        '
        Me.FoldersToolStripStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.FoldersToolStripStatusLabel.Name = "FoldersToolStripStatusLabel"
        Me.FoldersToolStripStatusLabel.Size = New System.Drawing.Size(94, 17)
        Me.FoldersToolStripStatusLabel.Text = "Loading Folders..."
        Me.FoldersToolStripStatusLabel.Visible = False
        '
        'FoldersToolStripProgressBar
        '
        Me.FoldersToolStripProgressBar.Name = "FoldersToolStripProgressBar"
        Me.FoldersToolStripProgressBar.Size = New System.Drawing.Size(150, 16)
        Me.FoldersToolStripProgressBar.ToolTipText = "Loading Folders"
        Me.FoldersToolStripProgressBar.Visible = False
        '
        'StatusStrip
        '
        Me.StatusStrip.BackColor = System.Drawing.Color.DarkGray
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLoadingLabel, Me.ToolStripLoadingProgressBar})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 599)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(823, 22)
        Me.StatusStrip.TabIndex = 15
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLoadingLabel
        '
        Me.ToolStripStatusLoadingLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.ToolStripStatusLoadingLabel.Name = "ToolStripStatusLoadingLabel"
        Me.ToolStripStatusLoadingLabel.Size = New System.Drawing.Size(94, 17)
        Me.ToolStripStatusLoadingLabel.Text = "Loading Folders..."
        Me.ToolStripStatusLoadingLabel.Visible = False
        '
        'ToolStripLoadingProgressBar
        '
        Me.ToolStripLoadingProgressBar.Name = "ToolStripLoadingProgressBar"
        Me.ToolStripLoadingProgressBar.Size = New System.Drawing.Size(150, 16)
        Me.ToolStripLoadingProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ToolStripLoadingProgressBar.ToolTipText = "Loading Folders"
        Me.ToolStripLoadingProgressBar.Visible = False
        '
        'ToolStrip
        '
        Me.ToolStrip.BackColor = System.Drawing.Color.DarkGray
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileListViewToolStripDropDownButton, Me.ToolStripSeparator1, Me.LockedfilesStripButton, Me.ToolStripSeparator2, Me.OptionsToolStripButton, Me.ToolStripSeparator3, Me.HelpToolStripButton})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(823, 25)
        Me.ToolStrip.TabIndex = 3
        Me.ToolStrip.Text = "ToolStrip"
        '
        'FileListViewToolStripDropDownButton
        '
        Me.FileListViewToolStripDropDownButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LargeIconToolStripMenuItem, Me.SmallIconToolStripMenuItem, Me.DetailsToolStripMenuItem, Me.ListToolStripMenuItem})
        Me.FileListViewToolStripDropDownButton.Image = Global.DataCenter_Client.My.Resources.Resources.FIle_List_Style
        Me.FileListViewToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FileListViewToolStripDropDownButton.Name = "FileListViewToolStripDropDownButton"
        Me.FileListViewToolStripDropDownButton.Size = New System.Drawing.Size(58, 22)
        Me.FileListViewToolStripDropDownButton.Text = "View"
        Me.FileListViewToolStripDropDownButton.ToolTipText = "Change file list style"
        '
        'LargeIconToolStripMenuItem
        '
        Me.LargeIconToolStripMenuItem.Name = "LargeIconToolStripMenuItem"
        Me.LargeIconToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.LargeIconToolStripMenuItem.Text = "Large icon"
        '
        'SmallIconToolStripMenuItem
        '
        Me.SmallIconToolStripMenuItem.Name = "SmallIconToolStripMenuItem"
        Me.SmallIconToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.SmallIconToolStripMenuItem.Text = "Small icon"
        '
        'DetailsToolStripMenuItem
        '
        Me.DetailsToolStripMenuItem.Name = "DetailsToolStripMenuItem"
        Me.DetailsToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.DetailsToolStripMenuItem.Text = "Details"
        '
        'ListToolStripMenuItem
        '
        Me.ListToolStripMenuItem.Name = "ListToolStripMenuItem"
        Me.ListToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.ListToolStripMenuItem.Text = "List"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'LockedfilesStripButton
        '
        Me.LockedfilesStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LockedfilesStripButton.Image = CType(resources.GetObject("LockedfilesStripButton.Image"), System.Drawing.Image)
        Me.LockedfilesStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LockedfilesStripButton.Name = "LockedfilesStripButton"
        Me.LockedfilesStripButton.Size = New System.Drawing.Size(23, 22)
        Me.LockedfilesStripButton.Text = "Locked files"
        Me.LockedfilesStripButton.ToolTipText = "Show locked files window"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'OptionsToolStripButton
        '
        Me.OptionsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OptionsToolStripButton.Image = Global.DataCenter_Client.My.Resources.Resources.Options
        Me.OptionsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OptionsToolStripButton.Name = "OptionsToolStripButton"
        Me.OptionsToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.OptionsToolStripButton.Text = "Options"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'HelpToolStripButton
        '
        Me.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HelpToolStripButton.Image = CType(resources.GetObject("HelpToolStripButton.Image"), System.Drawing.Image)
        Me.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HelpToolStripButton.Name = "HelpToolStripButton"
        Me.HelpToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.HelpToolStripButton.Text = "Help"
        '
        'MainWindowFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 621)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.SplitContainer)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MainWindowFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Center - Client Window"
        Me.ToolTip.SetToolTip(Me, "Mena data center client")
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.SplitContainer.Panel1.ResumeLayout(False)
        Me.SplitContainer.Panel2.ResumeLayout(False)
        Me.SplitContainer.ResumeLayout(False)
        Me.FoldersCMenuTree.ResumeLayout(False)
        Me.FilesCMenuTree.ResumeLayout(False)
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ViewMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents TVFolders As System.Windows.Forms.TreeView
    Friend WithEvents LVFiles As System.Windows.Forms.ListView
    Friend WithEvents ColHDFileName As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColHDCreatedIn As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColHDCreatedBy As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColHDFileType As System.Windows.Forms.ColumnHeader
    Friend WithEvents IconsList As System.Windows.Forms.ImageList
    Friend WithEvents MainImageList As System.Windows.Forms.ImageList
    Friend WithEvents FoldersToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents FoldersToolStripProgressBar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLoadingLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripLoadingProgressBar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents HelpToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FoldersCMenuTree As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CreateFolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FoldersRemoveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FoldersPropertiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FilesCMenuTree As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddFilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FilesRemoveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FilesPropertiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransferToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColHDLockStatus As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColHDLockedBy As System.Windows.Forms.ColumnHeader
    Friend WithEvents lockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LockedFilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LockedfilesStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileListViewToolStripDropDownButton As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents LargeIconToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SmallIconToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OptionsToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator

End Class
