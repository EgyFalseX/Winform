<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewFileTypesFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewFileTypesFrm))
        Me.BtnSave = New System.Windows.Forms.Button
        Me.TxtExt = New System.Windows.Forms.TextBox
        Me.TxtName = New System.Windows.Forms.TextBox
        Me.TxtDes = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnClose = New System.Windows.Forms.Button
        Me.BtnIcon = New System.Windows.Forms.Button
        Me.LblIconPath = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'BtnSave
        '
        Me.BtnSave.Enabled = False
        Me.BtnSave.Location = New System.Drawing.Point(254, 35)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(103, 23)
        Me.BtnSave.TabIndex = 4
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'TxtExt
        '
        Me.TxtExt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtExt.Location = New System.Drawing.Point(95, 38)
        Me.TxtExt.MaxLength = 3
        Me.TxtExt.Name = "TxtExt"
        Me.TxtExt.Size = New System.Drawing.Size(152, 20)
        Me.TxtExt.TabIndex = 1
        '
        'TxtName
        '
        Me.TxtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtName.Location = New System.Drawing.Point(95, 12)
        Me.TxtName.MaxLength = 100
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(152, 20)
        Me.TxtName.TabIndex = 0
        '
        'TxtDes
        '
        Me.TxtDes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDes.Location = New System.Drawing.Point(365, 12)
        Me.TxtDes.MaxLength = 50
        Me.TxtDes.Multiline = True
        Me.TxtDes.Name = "TxtDes"
        Me.TxtDes.Size = New System.Drawing.Size(172, 46)
        Me.TxtDes.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(19, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Extension :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(294, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Description :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(19, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Type Name :"
        '
        'BtnClose
        '
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Location = New System.Drawing.Point(477, 70)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(60, 23)
        Me.BtnClose.TabIndex = 5
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnIcon
        '
        Me.BtnIcon.Location = New System.Drawing.Point(19, 70)
        Me.BtnIcon.Name = "BtnIcon"
        Me.BtnIcon.Size = New System.Drawing.Size(90, 23)
        Me.BtnIcon.TabIndex = 3
        Me.BtnIcon.Text = "Load Icon (...)"
        Me.BtnIcon.UseVisualStyleBackColor = True
        '
        'LblIconPath
        '
        Me.LblIconPath.AutoSize = True
        Me.LblIconPath.BackColor = System.Drawing.Color.Transparent
        Me.LblIconPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblIconPath.ForeColor = System.Drawing.Color.Black
        Me.LblIconPath.Location = New System.Drawing.Point(115, 75)
        Me.LblIconPath.Name = "LblIconPath"
        Me.LblIconPath.Size = New System.Drawing.Size(94, 15)
        Me.LblIconPath.TabIndex = 21
        Me.LblIconPath.Text = "Icon Not Selected"
        Me.LblIconPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NewFileTypesFrm
        '
        Me.AcceptButton = Me.BtnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DataCenter_Server.My.Resources.Resources.NewFileTypesFrm
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(556, 104)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnIcon)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.TxtExt)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.TxtDes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblIconPath)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NewFileTypesFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "   New File Type"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents TxtExt As System.Windows.Forms.TextBox
    Friend WithEvents TxtName As System.Windows.Forms.TextBox
    Friend WithEvents TxtDes As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnIcon As System.Windows.Forms.Button
    Friend WithEvents LblIconPath As System.Windows.Forms.Label
End Class
