<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LockedFilesFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LockedFilesFrm))
        Me.LVFiles = New System.Windows.Forms.ListView
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.BtnApply = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.CBSelectNone = New System.Windows.Forms.CheckBox
        Me.CBSelectAll = New System.Windows.Forms.CheckBox
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LVFiles
        '
        Me.LVFiles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LVFiles.BackColor = System.Drawing.Color.White
        Me.LVFiles.CheckBoxes = True
        Me.LVFiles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader4})
        Me.LVFiles.FullRowSelect = True
        Me.LVFiles.Location = New System.Drawing.Point(12, 12)
        Me.LVFiles.Name = "LVFiles"
        Me.LVFiles.Size = New System.Drawing.Size(581, 395)
        Me.LVFiles.TabIndex = 0
        Me.LVFiles.UseCompatibleStateImageBehavior = False
        Me.LVFiles.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Filename"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "File Path"
        Me.ColumnHeader1.Width = 270
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Project Name"
        Me.ColumnHeader2.Width = 110
        '
        'BtnApply
        '
        Me.BtnApply.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnApply.Location = New System.Drawing.Point(188, 4)
        Me.BtnApply.Name = "BtnApply"
        Me.BtnApply.Size = New System.Drawing.Size(107, 23)
        Me.BtnApply.TabIndex = 3
        Me.BtnApply.Text = "Apply"
        Me.BtnApply.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CBSelectNone)
        Me.Panel1.Controls.Add(Me.BtnApply)
        Me.Panel1.Controls.Add(Me.CBSelectAll)
        Me.Panel1.Location = New System.Drawing.Point(60, 411)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(484, 32)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Check and apply"
        '
        'CBSelectNone
        '
        Me.CBSelectNone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBSelectNone.AutoSize = True
        Me.CBSelectNone.Location = New System.Drawing.Point(396, 7)
        Me.CBSelectNone.Name = "CBSelectNone"
        Me.CBSelectNone.Size = New System.Drawing.Size(81, 17)
        Me.CBSelectNone.TabIndex = 1
        Me.CBSelectNone.Text = "select none"
        Me.CBSelectNone.UseVisualStyleBackColor = True
        '
        'CBSelectAll
        '
        Me.CBSelectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBSelectAll.AutoSize = True
        Me.CBSelectAll.Location = New System.Drawing.Point(311, 7)
        Me.CBSelectAll.Name = "CBSelectAll"
        Me.CBSelectAll.Size = New System.Drawing.Size(68, 17)
        Me.CBSelectAll.TabIndex = 0
        Me.CBSelectAll.Text = "Select all"
        Me.CBSelectAll.UseVisualStyleBackColor = True
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "User Name"
        Me.ColumnHeader4.Width = 96
        '
        'LockedFilesFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DataCenter_Server.My.Resources.Resources.LockedFilesFrm
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(605, 448)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LVFiles)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LockedFilesFrm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "  Locked files list"
        Me.TransparencyKey = System.Drawing.Color.Lime
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LVFiles As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents BtnApply As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CBSelectNone As System.Windows.Forms.CheckBox
    Friend WithEvents CBSelectAll As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
End Class