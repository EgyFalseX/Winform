<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DisactivatedUsersFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DisactivatedUsersFrm))
        Me.BtnActivate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBUsers = New System.Windows.Forms.ListBox()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnActivate
        '
        Me.BtnActivate.Location = New System.Drawing.Point(11, 44)
        Me.BtnActivate.Name = "BtnActivate"
        Me.BtnActivate.Size = New System.Drawing.Size(110, 23)
        Me.BtnActivate.TabIndex = 1
        Me.BtnActivate.Text = " ›⁄Ì·"
        Me.BtnActivate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ﬁ«∆„… «·„” Œœ„Ì‰"
        '
        'LBUsers
        '
        Me.LBUsers.FormattingEnabled = True
        Me.LBUsers.Location = New System.Drawing.Point(137, 8)
        Me.LBUsers.Name = "LBUsers"
        Me.LBUsers.Size = New System.Drawing.Size(139, 251)
        Me.LBUsers.TabIndex = 0
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(11, 73)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(110, 23)
        Me.BtnDelete.TabIndex = 2
        Me.BtnDelete.Text = "„Õ«Ê·… «·Õ–›"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Location = New System.Drawing.Point(11, 236)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(110, 23)
        Me.BtnClose.TabIndex = 3
        Me.BtnClose.Text = "«€·«ﬁ"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'DisactivatedUsersFrm
        '
        Me.AcceptButton = Me.BtnActivate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DataCenter_Server.My.Resources.Resources.DisactivatedUsersFrm
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(284, 266)
        Me.Controls.Add(Me.LBUsers)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnActivate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DisactivatedUsersFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "«·„” Œœ„Ì‰ «·„⁄ÿ·Ì‰"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnActivate As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LBUsers As System.Windows.Forms.ListBox
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
End Class
