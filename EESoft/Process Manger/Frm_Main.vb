Imports System.IO
Imports System.Text.Encoding
Public Class Frm_Main
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
        Process.GetCurrentProcess.PriorityClass = ProcessPriorityClass.AboveNormal
        Application.EnableVisualStyles()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents RefreshList As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents exitprogram As System.Windows.Forms.Button
    Friend WithEvents runprogram As System.Windows.Forms.Button
    Friend WithEvents totalmem As System.Windows.Forms.Label
    Friend WithEvents programtitle As System.Windows.Forms.Label
    Friend WithEvents totallabel As System.Windows.Forms.Label
    Friend WithEvents Terminate As System.Windows.Forms.Button
    Friend WithEvents runtxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents priorityBox As System.Windows.Forms.ComboBox
    Friend WithEvents BtnAddToKillingList As System.Windows.Forms.Button
    Friend WithEvents LstKilling As System.Windows.Forms.ListView
    Friend WithEvents ColName As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColID As System.Windows.Forms.ColumnHeader
    Friend WithEvents BtnsStartKillingList As System.Windows.Forms.Button
    Friend WithEvents TmrKill As System.Windows.Forms.Timer
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents BtnToTray As System.Windows.Forms.Button
    Friend WithEvents TrayIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents CM As System.Windows.Forms.ContextMenu
    Friend WithEvents MIShow As System.Windows.Forms.MenuItem
    Friend WithEvents MIExit As System.Windows.Forms.MenuItem
    Friend WithEvents MIAbout As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Main))
        Me.RefreshList = New System.Windows.Forms.Button
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.exitprogram = New System.Windows.Forms.Button
        Me.runtxt = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.totalmem = New System.Windows.Forms.Label
        Me.runprogram = New System.Windows.Forms.Button
        Me.totallabel = New System.Windows.Forms.Label
        Me.BtnToTray = New System.Windows.Forms.Button
        Me.Terminate = New System.Windows.Forms.Button
        Me.programtitle = New System.Windows.Forms.Label
        Me.priorityBox = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnAddToKillingList = New System.Windows.Forms.Button
        Me.LstKilling = New System.Windows.Forms.ListView
        Me.ColName = New System.Windows.Forms.ColumnHeader
        Me.ColID = New System.Windows.Forms.ColumnHeader
        Me.BtnsStartKillingList = New System.Windows.Forms.Button
        Me.TmrKill = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.CM = New System.Windows.Forms.ContextMenu
        Me.MIShow = New System.Windows.Forms.MenuItem
        Me.MIAbout = New System.Windows.Forms.MenuItem
        Me.MIExit = New System.Windows.Forms.MenuItem
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RefreshList
        '
        Me.RefreshList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RefreshList.BackColor = System.Drawing.SystemColors.Control
        Me.RefreshList.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RefreshList.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RefreshList.Location = New System.Drawing.Point(704, 72)
        Me.RefreshList.Name = "RefreshList"
        Me.RefreshList.Size = New System.Drawing.Size(64, 20)
        Me.RefreshList.TabIndex = 0
        Me.RefreshList.Text = "Refresh"
        Me.ToolTip1.SetToolTip(Me.RefreshList, "Refresh the process list")
        Me.RefreshList.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.AutoArrange = False
        Me.ListView1.BackColor = System.Drawing.SystemColors.Info
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.ListView1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(0, 96)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(776, 216)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Process Name"
        Me.ColumnHeader1.Width = 130
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Mem Usage"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Main Window Title"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Status"
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Priority"
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "ID"
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Startup Time"
        Me.ColumnHeader7.Width = 100
        '
        'exitprogram
        '
        Me.exitprogram.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.exitprogram.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exitprogram.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.exitprogram.Location = New System.Drawing.Point(736, 0)
        Me.exitprogram.Name = "exitprogram"
        Me.exitprogram.Size = New System.Drawing.Size(32, 30)
        Me.exitprogram.TabIndex = 0
        Me.exitprogram.Text = "X"
        Me.ToolTip1.SetToolTip(Me.exitprogram, "Close the application")
        Me.exitprogram.UseVisualStyleBackColor = False
        '
        'runtxt
        '
        Me.runtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.runtxt.Location = New System.Drawing.Point(0, 4)
        Me.runtxt.Name = "runtxt"
        Me.runtxt.Size = New System.Drawing.Size(208, 20)
        Me.runtxt.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.totalmem)
        Me.Panel1.Controls.Add(Me.runtxt)
        Me.Panel1.Controls.Add(Me.exitprogram)
        Me.Panel1.Controls.Add(Me.runprogram)
        Me.Panel1.Controls.Add(Me.totallabel)
        Me.Panel1.Controls.Add(Me.BtnToTray)
        Me.Panel1.Location = New System.Drawing.Point(8, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(768, 30)
        Me.Panel1.TabIndex = 5
        '
        'totalmem
        '
        Me.totalmem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalmem.Location = New System.Drawing.Point(544, 4)
        Me.totalmem.Name = "totalmem"
        Me.totalmem.Size = New System.Drawing.Size(80, 20)
        Me.totalmem.TabIndex = 5
        Me.totalmem.Text = "0"
        Me.totalmem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.totalmem, "Acount of all the memory that the  process usage")
        '
        'runprogram
        '
        Me.runprogram.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.runprogram.BackColor = System.Drawing.SystemColors.Control
        Me.runprogram.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.runprogram.ForeColor = System.Drawing.SystemColors.ControlText
        Me.runprogram.Location = New System.Drawing.Point(208, 5)
        Me.runprogram.Name = "runprogram"
        Me.runprogram.Size = New System.Drawing.Size(75, 20)
        Me.runprogram.TabIndex = 0
        Me.runprogram.Text = "Run"
        Me.ToolTip1.SetToolTip(Me.runprogram, "Ckick here to select an file to start it with selected priority")
        Me.runprogram.UseVisualStyleBackColor = False
        '
        'totallabel
        '
        Me.totallabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totallabel.Location = New System.Drawing.Point(448, 4)
        Me.totallabel.Name = "totallabel"
        Me.totallabel.Size = New System.Drawing.Size(102, 20)
        Me.totallabel.TabIndex = 5
        Me.totallabel.Text = "Total Usage mem :"
        Me.totallabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnToTray
        '
        Me.BtnToTray.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnToTray.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnToTray.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnToTray.Location = New System.Drawing.Point(704, 0)
        Me.BtnToTray.Name = "BtnToTray"
        Me.BtnToTray.Size = New System.Drawing.Size(32, 30)
        Me.BtnToTray.TabIndex = 0
        Me.BtnToTray.Text = "-"
        Me.ToolTip1.SetToolTip(Me.BtnToTray, "To system tray")
        Me.BtnToTray.UseVisualStyleBackColor = False
        '
        'Terminate
        '
        Me.Terminate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Terminate.BackColor = System.Drawing.SystemColors.Control
        Me.Terminate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Terminate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Terminate.Location = New System.Drawing.Point(640, 72)
        Me.Terminate.Name = "Terminate"
        Me.Terminate.Size = New System.Drawing.Size(64, 20)
        Me.Terminate.TabIndex = 0
        Me.Terminate.Text = "Terminate"
        Me.ToolTip1.SetToolTip(Me.Terminate, "Terminate the selected process(s)")
        Me.Terminate.UseVisualStyleBackColor = False
        '
        'programtitle
        '
        Me.programtitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.programtitle.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.programtitle.ForeColor = System.Drawing.Color.Gray
        Me.programtitle.Location = New System.Drawing.Point(283, 11)
        Me.programtitle.Name = "programtitle"
        Me.programtitle.Size = New System.Drawing.Size(210, 24)
        Me.programtitle.TabIndex = 6
        Me.programtitle.Text = "Process Information"
        Me.programtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'priorityBox
        '
        Me.priorityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.priorityBox.Items.AddRange(New Object() {"RealTime", "High", "AboveNormal", "Normal", "BelowNormal", "Low"})
        Me.priorityBox.Location = New System.Drawing.Point(108, 72)
        Me.priorityBox.Name = "priorityBox"
        Me.priorityBox.Size = New System.Drawing.Size(182, 21)
        Me.priorityBox.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.priorityBox, "when you click the run button the file will start with this priority")
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(8, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Priority :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnAddToKillingList
        '
        Me.BtnAddToKillingList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAddToKillingList.BackColor = System.Drawing.SystemColors.Control
        Me.BtnAddToKillingList.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnAddToKillingList.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnAddToKillingList.Location = New System.Drawing.Point(552, 72)
        Me.BtnAddToKillingList.Name = "BtnAddToKillingList"
        Me.BtnAddToKillingList.Size = New System.Drawing.Size(88, 20)
        Me.BtnAddToKillingList.TabIndex = 0
        Me.BtnAddToKillingList.Text = "Add to killing list"
        Me.ToolTip1.SetToolTip(Me.BtnAddToKillingList, "Add the selected process to the killing list ")
        Me.BtnAddToKillingList.UseVisualStyleBackColor = False
        '
        'LstKilling
        '
        Me.LstKilling.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LstKilling.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColName, Me.ColID})
        Me.LstKilling.FullRowSelect = True
        Me.LstKilling.GridLines = True
        Me.LstKilling.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LstKilling.Location = New System.Drawing.Point(8, 0)
        Me.LstKilling.Name = "LstKilling"
        Me.LstKilling.Size = New System.Drawing.Size(208, 40)
        Me.LstKilling.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.LstKilling, "this is the killing list you can remove any process by pressing delete button on " & _
                "your keyboard")
        Me.LstKilling.UseCompatibleStateImageBehavior = False
        Me.LstKilling.View = System.Windows.Forms.View.Details
        '
        'ColName
        '
        Me.ColName.Text = "Name"
        Me.ColName.Width = 128
        '
        'ColID
        '
        Me.ColID.Text = "ID"
        Me.ColID.Width = 48
        '
        'BtnsStartKillingList
        '
        Me.BtnsStartKillingList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnsStartKillingList.BackColor = System.Drawing.SystemColors.Control
        Me.BtnsStartKillingList.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnsStartKillingList.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnsStartKillingList.Location = New System.Drawing.Point(456, 72)
        Me.BtnsStartKillingList.Name = "BtnsStartKillingList"
        Me.BtnsStartKillingList.Size = New System.Drawing.Size(96, 20)
        Me.BtnsStartKillingList.TabIndex = 0
        Me.BtnsStartKillingList.Text = "Start killing the list"
        Me.ToolTip1.SetToolTip(Me.BtnsStartKillingList, "Start killing all process that added to the killing list")
        Me.BtnsStartKillingList.UseVisualStyleBackColor = False
        '
        'TmrKill
        '
        Me.TmrKill.Interval = 500
        '
        'TrayIcon
        '
        Me.TrayIcon.ContextMenu = Me.CM
        Me.TrayIcon.Icon = CType(resources.GetObject("TrayIcon.Icon"), System.Drawing.Icon)
        Me.TrayIcon.Text = "Process Manger"
        '
        'CM
        '
        Me.CM.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MIShow, Me.MIAbout, Me.MIExit})
        '
        'MIShow
        '
        Me.MIShow.Index = 0
        Me.MIShow.Text = "Show"
        '
        'MIAbout
        '
        Me.MIAbout.Index = 1
        Me.MIAbout.ShowShortcut = False
        Me.MIAbout.Text = "About"
        '
        'MIExit
        '
        Me.MIExit.Index = 2
        Me.MIExit.Text = "Exit"
        '
        'Frm_Main
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(776, 328)
        Me.Controls.Add(Me.LstKilling)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.programtitle)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.priorityBox)
        Me.Controls.Add(Me.Terminate)
        Me.Controls.Add(Me.RefreshList)
        Me.Controls.Add(Me.BtnAddToKillingList)
        Me.Controls.Add(Me.BtnsStartKillingList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Process Manger"
        Me.ToolTip1.SetToolTip(Me, "What's Up")
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public x As Int16
    Public y As Int16
    Public fla As Boolean
    Public Function GetSelectedList() As Array
        Try
            Dim i As Int16
            Dim arr(0) As Int16
            For i = 0 To ListView1.Items.Count - 1
                If ListView1.Items(i).Selected = True Then
                    arr(arr.Length - 1) = i
                    ReDim Preserve arr(arr.Length)
                End If
            Next
            Return arr
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
        Return Nothing
    End Function
    Public Sub GetAllProcess()
        ListView1.Items.Clear()
        totalmem.Text = ""
        Dim arr() As Process
        Dim i As Int16
        arr = Process.GetProcesses
        For i = 0 To arr.Length - 1
            Dim lvi As New ListViewItem
            lvi.SubItems.Add(arr(i).WorkingSet64 / 1024 & "   K")
            lvi.SubItems.Add(arr(i).MainWindowTitle)
            If arr(i).Responding Then
                lvi.SubItems.Add("Running")
            Else
                lvi.SubItems.Add("Not Responding")
            End If
            Select Case arr(i).BasePriority
                Case Is <= 4
                    lvi.SubItems.Add("Low")
                Case Is <= 6
                    lvi.SubItems.Add("Below Normal")
                Case Is <= 8
                    lvi.SubItems.Add("Normal")
                Case Is <= 10
                    lvi.SubItems.Add("Above Normal")
                Case Is <= 13
                    lvi.SubItems.Add("High")
                Case Is > 13
                    lvi.SubItems.Add("Real Time")
            End Select
            lvi.SubItems.Add(arr(i).Id)
            Try : lvi.SubItems.Add(arr(i).StartTime.ToShortTimeString) : Catch : End Try
            totalmem.Text = Val(totalmem.Text) + Val(arr(i).WorkingSet64 / 1024)
            ListView1.Items.Add(lvi).Text = arr(i).ProcessName
        Next
        ReDim arr(0)
        Array.Clear(arr, 0, arr.Length - 1)
        totalmem.Text = totalmem.Text & "  K"

    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetAllProcess()
        LoadFromFile(LstKilling)
    End Sub
    Private Sub refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshList.Click
        GetAllProcess()
    End Sub
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown, ListView1.MouseDown, Panel1.MouseDown, programtitle.MouseDown, totalmem.MouseDown, totallabel.MouseDown
        x = e.X
        y = e.Y
        fla = True
    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp, ListView1.MouseUp, Panel1.MouseUp, programtitle.MouseUp, totalmem.MouseUp, totallabel.MouseUp
        fla = False
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove, ListView1.MouseMove, Panel1.MouseMove, programtitle.MouseMove, totalmem.MouseMove, totallabel.MouseMove
        If fla = True Then
            Me.Location = New Point(Me.Location.X + (e.X - x), Me.Location.Y + (e.Y - y))
        Else
            Me.Visible = True
        End If

    End Sub
    Private Sub exitprogram_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitprogram.Click
        Application.Exit()
    End Sub
    Private Sub Terminate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Terminate.Click
        Try
            Dim i As Int16
            Dim arr() As Int16
            arr = GetSelectedList()
            For i = 0 To arr.Length - 2
                Process.GetProcessById(ListView1.Items(arr(i)).SubItems(5).Text).Refresh()
                Process.GetProcessById(ListView1.Items(arr(i)).SubItems(5).Text).Close()
                Process.GetProcessById(ListView1.Items(arr(i)).SubItems(5).Text).Dispose()
                Process.GetProcessById(ListView1.Items(arr(i)).SubItems(5).Text).Kill()
            Next
            For i = 0 To arr.Length - 2
                ListView1.Items(arr(i)).Remove()
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Error")
        End Try
        GetAllProcess()
    End Sub
    Private Sub runprogram_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles runprogram.Click
        Try
            Dim x As New OpenFileDialog
            x.Filter = "All Files(*.*)|*.*"
            x.CheckFileExists = True
            x.CheckPathExists = True
            x.Title = "Select File To Open"
            x.ShowDialog()
            runtxt.Text = x.FileName
            runtxt.Enabled = False
            runtxt.Enabled = True
            Select Case priorityBox.Text
                Case "RealTime"
                    Process.Start(runtxt.Text.Trim).PriorityClass = ProcessPriorityClass.RealTime
                Case "High"
                    Process.Start(runtxt.Text.Trim).PriorityClass = ProcessPriorityClass.High
                Case "AboveNormal"
                    Process.Start(runtxt.Text.Trim).PriorityClass = ProcessPriorityClass.AboveNormal
                Case "Normal"
                    Process.Start(runtxt.Text.Trim).PriorityClass = ProcessPriorityClass.Normal
                Case "BelowNormal"
                    Process.Start(runtxt.Text.Trim).PriorityClass = ProcessPriorityClass.BelowNormal
                Case "Low"
                    Process.Start(runtxt.Text.Trim).PriorityClass = ProcessPriorityClass.Idle
                Case Else
                    Process.Start(runtxt.Text.Trim).PriorityClass = ProcessPriorityClass.Normal
            End Select
            Form1_Load(sender, e)
        Catch ex As Exception
            runtxt.Clear()
            runtxt.Enabled = True
        End Try
    End Sub
    Private Sub LstKilling_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstKilling.MouseEnter
        LstKilling.Height = 140
        '91
    End Sub
    Private Sub LstKilling_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstKilling.MouseLeave
        LstKilling.Height = 40
    End Sub
    Private Sub LstKilling_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LstKilling.KeyDown
        If e.KeyData = Keys.Delete Then
            Dim i As Int16
            For i = 0 To LstKilling.SelectedItems.Count - 1
                LstKilling.Items.Remove(LstKilling.SelectedItems.Item(0))
            Next
        End If
    End Sub
    Private Sub BtnAddToKillingList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddToKillingList.Click
        Dim i As Int16
        Dim int As Int16
        Dim Flg As Boolean = False
        Dim arr() As Int16
        arr = GetSelectedList()
        For i = 0 To arr.Length - 2
            For int = 0 To LstKilling.Items.Count - 1
                If LstKilling.Items(int).SubItems(1).Text = ListView1.Items(arr(i)).SubItems(5).Text Then
                    fla = True
                    Exit For
                End If
            Next
            If fla = True Then
                fla = False
            Else
                LstKilling.Items.Add(ListView1.Items(arr(i)).Text).SubItems.Add(ListView1.Items(arr(i)).SubItems(5).Text)
            End If
        Next
    End Sub
    Private Sub ListView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ListView1.KeyDown
        If e.KeyData = Keys.Delete Then
            Terminate_Click(sender, e)
        End If
    End Sub
    Private Sub BtnsStartKillingList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnsStartKillingList.Click
        If BtnsStartKillingList.Text = "Start killing the list" Then
            TmrKill.Enabled = True
            BtnsStartKillingList.Text = "End killing the list"
        ElseIf BtnsStartKillingList.Text = "End killing the list" Then
            TmrKill.Enabled = False
            BtnsStartKillingList.Text = "Start killing the list"
        End If
    End Sub
    Private Sub TmrKill_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrKill.Tick
        Try
            Dim i As Int16
            Dim int As Int16
            Dim arr() As Process
            arr = Process.GetProcesses
            For i = 0 To LstKilling.Items.Count - 1
                For int = 0 To arr.Length - 1
                    If arr(int).ProcessName = LstKilling.Items(i).Text Then
                        arr(int).Kill()
                        GetAllProcess()
                        Exit For
                    End If
                Next
            Next
        Catch ex As Exception

        End Try

    End Sub
    Private Sub BtnToTray_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnToTray.Click
        Me.Visible = False
        TrayIcon.Visible = True
    End Sub
    Private Sub MIShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIShow.Click, TrayIcon.DoubleClick
        GetAllProcess()
        Me.Visible = True
        TrayIcon.Visible = False
    End Sub
    Private Sub MIAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIAbout.Click
        MessageBox.Show("Process Manager Unleashed by .Net [VB.NET 2003]" & vbNewLine & "Created By Mohamed Aly Omer" & vbNewLine & "Mohamed.Aly.Omer@gmail.com", "»”„ «··Â «·—Õ„‰ «·—ÕÌ„", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    End Sub
    Private Sub MIExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIExit.Click
        TrayIcon.Visible = False
        Me.Visible = False
        Application.Exit()
    End Sub
    Private Sub Frm_Main_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        SaveToFile(LstKilling)
    End Sub
    Public Sub SaveToFile(ByRef LV As ListView)
        If File.Exists(Application.StartupPath & "\KillingList.txt") Then
            File.Delete(Application.StartupPath & "\KillingList.txt")
        End If
        Dim Save As New StreamWriter(Application.StartupPath & "\KillingList.txt", False)
        For i As Integer = 0 To LV.Items.Count - 1
            Save.WriteLine(LV.Items.Item(i).Text)
        Next
        Save.Close()
    End Sub
    Public Sub LoadFromFile(ByRef LV As ListView)
        If Not File.Exists(Application.StartupPath & "\KillingList.txt") Then
            Exit Sub
        End If
        Dim Load As New StreamReader(Application.StartupPath & "\KillingList.txt", False)
        Do Until Load.EndOfStream = True
            LV.Items.Add(Load.ReadLine())
        Loop
        Load.Close()
    End Sub

End Class
