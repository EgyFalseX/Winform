<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrivilegesFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrivilegesFrm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBAllProjects = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNewPriv = New System.Windows.Forms.TextBox()
        Me.LBPrivileges = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.LblAction = New System.Windows.Forms.Label()
        Me.TxtUpdate = New System.Windows.Forms.TextBox()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "«·„‘«—Ì‹‹‹⁄"
        '
        'CBAllProjects
        '
        Me.CBAllProjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBAllProjects.FormattingEnabled = True
        Me.CBAllProjects.Location = New System.Drawing.Point(107, 8)
        Me.CBAllProjects.Name = "CBAllProjects"
        Me.CBAllProjects.Size = New System.Drawing.Size(176, 21)
        Me.CBAllProjects.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "’·«ÕÌÂ ÃœÌœÂ"
        '
        'TxtNewPriv
        '
        Me.TxtNewPriv.Location = New System.Drawing.Point(107, 35)
        Me.TxtNewPriv.MaxLength = 20
        Me.TxtNewPriv.Name = "TxtNewPriv"
        Me.TxtNewPriv.ReadOnly = True
        Me.TxtNewPriv.Size = New System.Drawing.Size(176, 20)
        Me.TxtNewPriv.TabIndex = 1
        '
        'LBPrivileges
        '
        Me.LBPrivileges.FormattingEnabled = True
        Me.LBPrivileges.Location = New System.Drawing.Point(107, 90)
        Me.LBPrivileges.Name = "LBPrivileges"
        Me.LBPrivileges.Size = New System.Drawing.Size(176, 82)
        Me.LBPrivileges.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ﬁ«∆„… «·’·«ÕÌ« "
        '
        'BtnAdd
        '
        Me.BtnAdd.Enabled = False
        Me.BtnAdd.Location = New System.Drawing.Point(107, 61)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(176, 23)
        Me.BtnAdd.TabIndex = 2
        Me.BtnAdd.Text = "«÷«›Â"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnRemove
        '
        Me.BtnRemove.Enabled = False
        Me.BtnRemove.Location = New System.Drawing.Point(15, 106)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(78, 23)
        Me.BtnRemove.TabIndex = 4
        Me.BtnRemove.Text = "Õ–›"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'LblAction
        '
        Me.LblAction.BackColor = System.Drawing.Color.Gainsboro
        Me.LblAction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblAction.Location = New System.Drawing.Point(15, 132)
        Me.LblAction.Name = "LblAction"
        Me.LblAction.Size = New System.Drawing.Size(78, 66)
        Me.LblAction.TabIndex = 8
        Me.LblAction.Text = "«Œ «— „‘—Ê⁄"
        Me.LblAction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtUpdate
        '
        Me.TxtUpdate.Location = New System.Drawing.Point(107, 178)
        Me.TxtUpdate.MaxLength = 20
        Me.TxtUpdate.Name = "TxtUpdate"
        Me.TxtUpdate.ReadOnly = True
        Me.TxtUpdate.Size = New System.Drawing.Size(176, 20)
        Me.TxtUpdate.TabIndex = 5
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Enabled = False
        Me.BtnUpdate.Location = New System.Drawing.Point(107, 204)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(176, 23)
        Me.BtnUpdate.TabIndex = 6
        Me.BtnUpdate.Text = " ⁄œÌ·"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Location = New System.Drawing.Point(15, 204)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(78, 23)
        Me.BtnClose.TabIndex = 7
        Me.BtnClose.Text = "«€·«ﬁ"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'PrivilegesFrm
        '
        Me.AcceptButton = Me.BtnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DataCenter_Server.My.Resources.Resources.PrivilegesFrm
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(295, 232)
        Me.Controls.Add(Me.LblAction)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LBPrivileges)
        Me.Controls.Add(Me.TxtUpdate)
        Me.Controls.Add(Me.TxtNewPriv)
        Me.Controls.Add(Me.CBAllProjects)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PrivilegesFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "«·’·«ÕÌ« "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CBAllProjects As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtNewPriv As System.Windows.Forms.TextBox
    Friend WithEvents LBPrivileges As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnRemove As System.Windows.Forms.Button
    Friend WithEvents LblAction As System.Windows.Forms.Label
    Friend WithEvents TxtUpdate As System.Windows.Forms.TextBox
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
End Class
