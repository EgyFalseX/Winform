<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsersPrivilegesFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsersPrivilegesFrm))
        Me.Label1 = New System.Windows.Forms.Label
        Me.CBUsers = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.CBProjects = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.BtnRemoveSelected = New System.Windows.Forms.Button
        Me.BtnAddSelected = New System.Windows.Forms.Button
        Me.LBSelectedprivileges = New System.Windows.Forms.ListBox
        Me.LBAllprivileges = New System.Windows.Forms.ListBox
        Me.BtnClose = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(10, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Users List :"
        '
        'CBUsers
        '
        Me.CBUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBUsers.FormattingEnabled = True
        Me.CBUsers.Location = New System.Drawing.Point(13, 25)
        Me.CBUsers.Name = "CBUsers"
        Me.CBUsers.Size = New System.Drawing.Size(135, 21)
        Me.CBUsers.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(186, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Projects List :"
        '
        'CBProjects
        '
        Me.CBProjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBProjects.FormattingEnabled = True
        Me.CBProjects.Location = New System.Drawing.Point(189, 25)
        Me.CBProjects.Name = "CBProjects"
        Me.CBProjects.Size = New System.Drawing.Size(135, 21)
        Me.CBProjects.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(186, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Selected privileges"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "All privileges"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnRemoveSelected
        '
        Me.BtnRemoveSelected.Enabled = False
        Me.BtnRemoveSelected.Location = New System.Drawing.Point(150, 180)
        Me.BtnRemoveSelected.Name = "BtnRemoveSelected"
        Me.BtnRemoveSelected.Size = New System.Drawing.Size(37, 23)
        Me.BtnRemoveSelected.TabIndex = 4
        Me.BtnRemoveSelected.Text = "<"
        Me.BtnRemoveSelected.UseVisualStyleBackColor = True
        '
        'BtnAddSelected
        '
        Me.BtnAddSelected.Enabled = False
        Me.BtnAddSelected.Location = New System.Drawing.Point(150, 148)
        Me.BtnAddSelected.Name = "BtnAddSelected"
        Me.BtnAddSelected.Size = New System.Drawing.Size(37, 23)
        Me.BtnAddSelected.TabIndex = 3
        Me.BtnAddSelected.Text = ">"
        Me.BtnAddSelected.UseVisualStyleBackColor = True
        '
        'LBSelectedprivileges
        '
        Me.LBSelectedprivileges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBSelectedprivileges.FormattingEnabled = True
        Me.LBSelectedprivileges.Location = New System.Drawing.Point(189, 75)
        Me.LBSelectedprivileges.Name = "LBSelectedprivileges"
        Me.LBSelectedprivileges.Size = New System.Drawing.Size(135, 197)
        Me.LBSelectedprivileges.TabIndex = 5
        '
        'LBAllprivileges
        '
        Me.LBAllprivileges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBAllprivileges.FormattingEnabled = True
        Me.LBAllprivileges.Location = New System.Drawing.Point(13, 75)
        Me.LBAllprivileges.Name = "LBAllprivileges"
        Me.LBAllprivileges.Size = New System.Drawing.Size(135, 197)
        Me.LBAllprivileges.TabIndex = 2
        '
        'BtnClose
        '
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Location = New System.Drawing.Point(13, 272)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(311, 23)
        Me.BtnClose.TabIndex = 6
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'UsersPrivilegesFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DataCenter_Server.My.Resources.Resources.UsersPrivilegesFrm
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(334, 298)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnRemoveSelected)
        Me.Controls.Add(Me.BtnAddSelected)
        Me.Controls.Add(Me.LBSelectedprivileges)
        Me.Controls.Add(Me.LBAllprivileges)
        Me.Controls.Add(Me.CBProjects)
        Me.Controls.Add(Me.CBUsers)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UsersPrivilegesFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "   Users Privilege"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CBUsers As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CBProjects As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnRemoveSelected As System.Windows.Forms.Button
    Friend WithEvents BtnAddSelected As System.Windows.Forms.Button
    Friend WithEvents LBSelectedprivileges As System.Windows.Forms.ListBox
    Friend WithEvents LBAllprivileges As System.Windows.Forms.ListBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
End Class
