<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditUsersFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditUsersFrm))
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LBUsers = New System.Windows.Forms.ListBox()
        Me.TxtUpdate = New System.Windows.Forms.TextBox()
        Me.TxtNewUser = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnClose
        '
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Location = New System.Drawing.Point(12, 174)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(78, 23)
        Me.BtnClose.TabIndex = 7
        Me.BtnClose.Text = "«€·«ﬁ"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnRemove
        '
        Me.BtnRemove.Enabled = False
        Me.BtnRemove.Location = New System.Drawing.Point(12, 76)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(78, 23)
        Me.BtnRemove.TabIndex = 3
        Me.BtnRemove.Text = " ⁄ÿÌ·"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Enabled = False
        Me.BtnUpdate.Location = New System.Drawing.Point(104, 174)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(176, 23)
        Me.BtnUpdate.TabIndex = 6
        Me.BtnUpdate.Text = " ⁄œÌ·"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Enabled = False
        Me.BtnAdd.Location = New System.Drawing.Point(104, 31)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(176, 23)
        Me.BtnAdd.TabIndex = 1
        Me.BtnAdd.Text = "«÷«›Â"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(9, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "ﬁ«∆„… «·„” Œœ„Ì‰"
        '
        'LBUsers
        '
        Me.LBUsers.FormattingEnabled = True
        Me.LBUsers.Location = New System.Drawing.Point(104, 60)
        Me.LBUsers.Name = "LBUsers"
        Me.LBUsers.Size = New System.Drawing.Size(176, 82)
        Me.LBUsers.TabIndex = 2
        '
        'TxtUpdate
        '
        Me.TxtUpdate.Location = New System.Drawing.Point(104, 148)
        Me.TxtUpdate.MaxLength = 20
        Me.TxtUpdate.Name = "TxtUpdate"
        Me.TxtUpdate.ReadOnly = True
        Me.TxtUpdate.Size = New System.Drawing.Size(176, 20)
        Me.TxtUpdate.TabIndex = 5
        '
        'TxtNewUser
        '
        Me.TxtNewUser.Location = New System.Drawing.Point(107, 5)
        Me.TxtNewUser.MaxLength = 20
        Me.TxtNewUser.Name = "TxtNewUser"
        Me.TxtNewUser.Size = New System.Drawing.Size(176, 20)
        Me.TxtNewUser.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "„” Œœ„ ÃœÌœ"
        '
        'BtnReset
        '
        Me.BtnReset.Enabled = False
        Me.BtnReset.Location = New System.Drawing.Point(12, 105)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(78, 23)
        Me.BtnReset.TabIndex = 4
        Me.BtnReset.Text = "«·€«¡ «·»«”Ê—œ"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'EditUsersFrm
        '
        Me.AcceptButton = Me.BtnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DataCenter_Server.My.Resources.Resources.EditUsersFrm
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(292, 203)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LBUsers)
        Me.Controls.Add(Me.TxtUpdate)
        Me.Controls.Add(Me.TxtNewUser)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditUsersFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "«·„” Œœ„Ì‰"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnRemove As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LBUsers As System.Windows.Forms.ListBox
    Friend WithEvents TxtUpdate As System.Windows.Forms.TextBox
    Friend WithEvents TxtNewUser As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnReset As System.Windows.Forms.Button
End Class
