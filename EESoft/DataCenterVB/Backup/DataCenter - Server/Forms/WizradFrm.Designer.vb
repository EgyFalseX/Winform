<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WizradFrm
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Photos")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("AutoCAD")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Jpg")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Maps", New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode3})
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Reports")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Photos")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Maps")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Drawings")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Reports")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Survey", New System.Windows.Forms.TreeNode() {TreeNode6, TreeNode7, TreeNode8, TreeNode9})
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Site View", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode4, TreeNode5, TreeNode10})
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Development")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("AutoCAD")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Jpg")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Drawings", New System.Windows.Forms.TreeNode() {TreeNode13, TreeNode14})
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Files")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Jpg")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Papers", New System.Windows.Forms.TreeNode() {TreeNode16, TreeNode17})
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Licences", New System.Windows.Forms.TreeNode() {TreeNode15, TreeNode18})
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Concept")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Working Drawings")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Reports")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("IN")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("OUT")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consultant correspondence", New System.Windows.Forms.TreeNode() {TreeNode23, TreeNode24})
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Design", New System.Windows.Forms.TreeNode() {TreeNode20, TreeNode21, TreeNode22, TreeNode25})
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("IN")
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("OUT")
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consultant correspondence", New System.Windows.Forms.TreeNode() {TreeNode27, TreeNode28})
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Contracts")
        Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Autocade")
        Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Jpg")
        Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Drawings", New System.Windows.Forms.TreeNode() {TreeNode31, TreeNode32})
        Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Clients", New System.Windows.Forms.TreeNode() {TreeNode30, TreeNode33})
        Dim TreeNode35 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Invoice")
        Dim TreeNode36 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Planning")
        Dim TreeNode37 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cost control")
        Dim TreeNode38 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("As build drawings")
        Dim TreeNode39 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Construction Document", New System.Windows.Forms.TreeNode() {TreeNode35, TreeNode36, TreeNode37, TreeNode38})
        Dim TreeNode40 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Implementation", New System.Windows.Forms.TreeNode() {TreeNode29, TreeNode34, TreeNode39})
        Dim TreeNode41 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("...", New System.Windows.Forms.TreeNode() {TreeNode11, TreeNode12, TreeNode19, TreeNode26, TreeNode40})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WizradFrm))
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.MainTreeView = New System.Windows.Forms.TreeView
        Me.NewProjectImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.TxtLocation = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.MCEnd = New System.Windows.Forms.MonthCalendar
        Me.MCStart = New System.Windows.Forms.MonthCalendar
        Me.MainProgressBar = New System.Windows.Forms.ProgressBar
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(12, 276)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(656, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(78, 302)
        Me.TxtName.MaxLength = 20
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(428, 20)
        Me.TxtName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(9, 302)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Name  :-"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnAdd
        '
        Me.BtnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnAdd.Enabled = False
        Me.BtnAdd.Location = New System.Drawing.Point(512, 302)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdd.TabIndex = 3
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Location = New System.Drawing.Point(593, 302)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 4
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(9, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Templates :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MainTreeView
        '
        Me.MainTreeView.BackColor = System.Drawing.Color.DimGray
        Me.MainTreeView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTreeView.ForeColor = System.Drawing.Color.Lime
        Me.MainTreeView.ImageIndex = 0
        Me.MainTreeView.ImageList = Me.NewProjectImageList
        Me.MainTreeView.LabelEdit = True
        Me.MainTreeView.Location = New System.Drawing.Point(0, 0)
        Me.MainTreeView.Name = "MainTreeView"
        TreeNode1.Name = "Node0"
        TreeNode1.Text = "Photos"
        TreeNode2.Name = "Node16"
        TreeNode2.Text = "AutoCAD"
        TreeNode3.Name = "Node17"
        TreeNode3.Text = "Jpg"
        TreeNode4.Name = "Node3"
        TreeNode4.Text = "Maps"
        TreeNode5.Name = "Node4"
        TreeNode5.Text = "Reports"
        TreeNode6.Name = "Node7"
        TreeNode6.Text = "Photos"
        TreeNode7.Name = "Node8"
        TreeNode7.Text = "Maps"
        TreeNode8.Name = "Node9"
        TreeNode8.Text = "Drawings"
        TreeNode9.Name = "Node10"
        TreeNode9.Text = "Reports"
        TreeNode10.Name = "Node5"
        TreeNode10.Text = "Survey"
        TreeNode11.Name = "NodeSite"
        TreeNode11.Text = "Site View"
        TreeNode12.Name = "Node11"
        TreeNode12.Text = "Development"
        TreeNode13.Name = "Node18"
        TreeNode13.Text = "AutoCAD"
        TreeNode14.Name = "Node19"
        TreeNode14.Text = "Jpg"
        TreeNode15.Name = "NodeDesign"
        TreeNode15.Text = "Drawings"
        TreeNode16.Name = "Node20"
        TreeNode16.Text = "Files"
        TreeNode17.Name = "Node21"
        TreeNode17.Text = "Jpg"
        TreeNode18.Name = "Node15"
        TreeNode18.Text = "Papers"
        TreeNode19.Name = "Node13"
        TreeNode19.Text = "Licences"
        TreeNode20.Name = "Node23"
        TreeNode20.Text = "Concept"
        TreeNode21.Name = "Node24"
        TreeNode21.Text = "Working Drawings"
        TreeNode22.Name = "Node25"
        TreeNode22.Text = "Reports"
        TreeNode23.Name = "Node0"
        TreeNode23.Text = "IN"
        TreeNode24.Name = "Node1"
        TreeNode24.Text = "OUT"
        TreeNode25.Name = "Node26"
        TreeNode25.Text = "Consultant correspondence"
        TreeNode26.Name = "Node22"
        TreeNode26.Text = "Design"
        TreeNode27.Name = "Node3"
        TreeNode27.Text = "IN"
        TreeNode28.Name = "Node4"
        TreeNode28.Text = "OUT"
        TreeNode29.Name = "Node2"
        TreeNode29.Text = "Consultant correspondence"
        TreeNode30.Name = "Node31"
        TreeNode30.Text = "Contracts"
        TreeNode31.Name = "Node33"
        TreeNode31.Text = "Autocade"
        TreeNode32.Name = "Node34"
        TreeNode32.Text = "Jpg"
        TreeNode33.Name = "Node32"
        TreeNode33.Text = "Drawings"
        TreeNode34.Name = "Node28"
        TreeNode34.Text = "Clients"
        TreeNode35.Name = "Node35"
        TreeNode35.Text = "Invoice"
        TreeNode36.Name = "Node36"
        TreeNode36.Text = "Planning"
        TreeNode37.Name = "Node37"
        TreeNode37.Text = "Cost control"
        TreeNode38.Name = "Node38"
        TreeNode38.Text = "As build drawings"
        TreeNode39.Name = "Node29"
        TreeNode39.Text = "Construction Document"
        TreeNode40.Name = "NodeImp"
        TreeNode40.Text = "Implementation"
        TreeNode41.Name = "NodePro"
        TreeNode41.Text = "..."
        Me.MainTreeView.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode41})
        Me.MainTreeView.SelectedImageIndex = 0
        Me.MainTreeView.Size = New System.Drawing.Size(218, 233)
        Me.MainTreeView.TabIndex = 0
        '
        'NewProjectImageList
        '
        Me.NewProjectImageList.ImageStream = CType(resources.GetObject("NewProjectImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.NewProjectImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.NewProjectImageList.Images.SetKeyName(0, "FoldersIcon.ico")
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 40)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.MainTreeView)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.Panel2.BackgroundImage = Global.DataCenter_Server.My.Resources.Resources.WizradFrm
        Me.SplitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SplitContainer1.Panel2.Controls.Add(Me.TxtLocation)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.MCEnd)
        Me.SplitContainer1.Panel2.Controls.Add(Me.MCStart)
        Me.SplitContainer1.Size = New System.Drawing.Size(656, 233)
        Me.SplitContainer1.SplitterDistance = 218
        Me.SplitContainer1.TabIndex = 0
        '
        'TxtLocation
        '
        Me.TxtLocation.Location = New System.Drawing.Point(141, 202)
        Me.TxtLocation.MaxLength = 100
        Me.TxtLocation.Name = "TxtLocation"
        Me.TxtLocation.Size = New System.Drawing.Size(210, 20)
        Me.TxtLocation.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(253, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "End AT :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(83, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Location :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Start IN :"
        '
        'MCEnd
        '
        Me.MCEnd.Location = New System.Drawing.Point(256, 32)
        Me.MCEnd.MaxSelectionCount = 1
        Me.MCEnd.Name = "MCEnd"
        Me.MCEnd.TabIndex = 0
        '
        'MCStart
        '
        Me.MCStart.Location = New System.Drawing.Point(11, 32)
        Me.MCStart.MaxSelectionCount = 1
        Me.MCStart.Name = "MCStart"
        Me.MCStart.TabIndex = 0
        '
        'MainProgressBar
        '
        Me.MainProgressBar.Location = New System.Drawing.Point(16, 279)
        Me.MainProgressBar.Maximum = 41
        Me.MainProgressBar.Name = "MainProgressBar"
        Me.MainProgressBar.Size = New System.Drawing.Size(649, 18)
        Me.MainProgressBar.TabIndex = 2
        Me.MainProgressBar.Visible = False
        '
        'WizradFrm
        '
        Me.AcceptButton = Me.BtnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DataCenter_Server.My.Resources.Resources.WizradFrm
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(680, 334)
        Me.Controls.Add(Me.MainProgressBar)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "WizradFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "   Add New Project"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MainTreeView As System.Windows.Forms.TreeView
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents NewProjectImageList As System.Windows.Forms.ImageList
    Friend WithEvents TxtLocation As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MCEnd As System.Windows.Forms.MonthCalendar
    Friend WithEvents MCStart As System.Windows.Forms.MonthCalendar
    Friend WithEvents MainProgressBar As System.Windows.Forms.ProgressBar
End Class
