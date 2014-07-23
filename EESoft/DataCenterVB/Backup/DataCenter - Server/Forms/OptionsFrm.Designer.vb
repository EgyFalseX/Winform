<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionsFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OptionsFrm))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.ServerOptionTabPage = New System.Windows.Forms.TabPage
        Me.BtnClose1 = New System.Windows.Forms.Button
        Me.BtnSaveServerOptions = New System.Windows.Forms.Button
        Me.BtnBrowseDeletedFiles = New System.Windows.Forms.Button
        Me.BtnBrowseRelatedFiles = New System.Windows.Forms.Button
        Me.BtnBrowseProjectPath = New System.Windows.Forms.Button
        Me.TxtDeletedFiles = New System.Windows.Forms.TextBox
        Me.TxtRelatedFiles = New System.Windows.Forms.TextBox
        Me.TxtProjectPath = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtPassword = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ClientOptionTabPage = New System.Windows.Forms.TabPage
        Me.BtnClose2 = New System.Windows.Forms.Button
        Me.BtnSaveClientOptions = New System.Windows.Forms.Button
        Me.TxtServerPort = New System.Windows.Forms.TextBox
        Me.TxtServerIP = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.BtnExitApp = New System.Windows.Forms.Button
        Me.Lblwarning = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.ServerOptionTabPage.SuspendLayout()
        Me.ClientOptionTabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.ServerOptionTabPage)
        Me.TabControl1.Controls.Add(Me.ClientOptionTabPage)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(444, 204)
        Me.TabControl1.TabIndex = 0
        '
        'ServerOptionTabPage
        '
        Me.ServerOptionTabPage.Controls.Add(Me.BtnClose1)
        Me.ServerOptionTabPage.Controls.Add(Me.BtnSaveServerOptions)
        Me.ServerOptionTabPage.Controls.Add(Me.BtnBrowseDeletedFiles)
        Me.ServerOptionTabPage.Controls.Add(Me.BtnBrowseRelatedFiles)
        Me.ServerOptionTabPage.Controls.Add(Me.BtnBrowseProjectPath)
        Me.ServerOptionTabPage.Controls.Add(Me.TxtDeletedFiles)
        Me.ServerOptionTabPage.Controls.Add(Me.TxtRelatedFiles)
        Me.ServerOptionTabPage.Controls.Add(Me.TxtProjectPath)
        Me.ServerOptionTabPage.Controls.Add(Me.Lblwarning)
        Me.ServerOptionTabPage.Controls.Add(Me.Label6)
        Me.ServerOptionTabPage.Controls.Add(Me.TxtPassword)
        Me.ServerOptionTabPage.Controls.Add(Me.Label3)
        Me.ServerOptionTabPage.Controls.Add(Me.Label2)
        Me.ServerOptionTabPage.Controls.Add(Me.Label1)
        Me.ServerOptionTabPage.Location = New System.Drawing.Point(4, 22)
        Me.ServerOptionTabPage.Name = "ServerOptionTabPage"
        Me.ServerOptionTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.ServerOptionTabPage.Size = New System.Drawing.Size(436, 178)
        Me.ServerOptionTabPage.TabIndex = 0
        Me.ServerOptionTabPage.Text = "Server Option"
        Me.ServerOptionTabPage.UseVisualStyleBackColor = True
        '
        'BtnClose1
        '
        Me.BtnClose1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose1.Location = New System.Drawing.Point(276, 131)
        Me.BtnClose1.Name = "BtnClose1"
        Me.BtnClose1.Size = New System.Drawing.Size(53, 23)
        Me.BtnClose1.TabIndex = 6
        Me.BtnClose1.Text = "Close"
        Me.BtnClose1.UseVisualStyleBackColor = True
        '
        'BtnSaveServerOptions
        '
        Me.BtnSaveServerOptions.Enabled = False
        Me.BtnSaveServerOptions.Location = New System.Drawing.Point(111, 131)
        Me.BtnSaveServerOptions.Name = "BtnSaveServerOptions"
        Me.BtnSaveServerOptions.Size = New System.Drawing.Size(159, 23)
        Me.BtnSaveServerOptions.TabIndex = 5
        Me.BtnSaveServerOptions.Text = "Save"
        Me.BtnSaveServerOptions.UseVisualStyleBackColor = True
        '
        'BtnBrowseDeletedFiles
        '
        Me.BtnBrowseDeletedFiles.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnBrowseDeletedFiles.Location = New System.Drawing.Point(324, 102)
        Me.BtnBrowseDeletedFiles.Name = "BtnBrowseDeletedFiles"
        Me.BtnBrowseDeletedFiles.Size = New System.Drawing.Size(62, 23)
        Me.BtnBrowseDeletedFiles.TabIndex = 4
        Me.BtnBrowseDeletedFiles.Text = "Browse"
        Me.BtnBrowseDeletedFiles.UseVisualStyleBackColor = True
        '
        'BtnBrowseRelatedFiles
        '
        Me.BtnBrowseRelatedFiles.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnBrowseRelatedFiles.Location = New System.Drawing.Point(324, 76)
        Me.BtnBrowseRelatedFiles.Name = "BtnBrowseRelatedFiles"
        Me.BtnBrowseRelatedFiles.Size = New System.Drawing.Size(62, 23)
        Me.BtnBrowseRelatedFiles.TabIndex = 3
        Me.BtnBrowseRelatedFiles.Text = "Browse"
        Me.BtnBrowseRelatedFiles.UseVisualStyleBackColor = True
        '
        'BtnBrowseProjectPath
        '
        Me.BtnBrowseProjectPath.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnBrowseProjectPath.Location = New System.Drawing.Point(324, 46)
        Me.BtnBrowseProjectPath.Name = "BtnBrowseProjectPath"
        Me.BtnBrowseProjectPath.Size = New System.Drawing.Size(62, 23)
        Me.BtnBrowseProjectPath.TabIndex = 2
        Me.BtnBrowseProjectPath.Text = "Browse"
        Me.BtnBrowseProjectPath.UseVisualStyleBackColor = True
        '
        'TxtDeletedFiles
        '
        Me.TxtDeletedFiles.Location = New System.Drawing.Point(184, 102)
        Me.TxtDeletedFiles.Name = "TxtDeletedFiles"
        Me.TxtDeletedFiles.ReadOnly = True
        Me.TxtDeletedFiles.Size = New System.Drawing.Size(134, 20)
        Me.TxtDeletedFiles.TabIndex = 19
        Me.TxtDeletedFiles.TabStop = False
        '
        'TxtRelatedFiles
        '
        Me.TxtRelatedFiles.Location = New System.Drawing.Point(184, 76)
        Me.TxtRelatedFiles.Name = "TxtRelatedFiles"
        Me.TxtRelatedFiles.ReadOnly = True
        Me.TxtRelatedFiles.Size = New System.Drawing.Size(134, 20)
        Me.TxtRelatedFiles.TabIndex = 19
        Me.TxtRelatedFiles.TabStop = False
        '
        'TxtProjectPath
        '
        Me.TxtProjectPath.Location = New System.Drawing.Point(184, 46)
        Me.TxtProjectPath.Name = "TxtProjectPath"
        Me.TxtProjectPath.ReadOnly = True
        Me.TxtProjectPath.Size = New System.Drawing.Size(134, 20)
        Me.TxtProjectPath.TabIndex = 20
        Me.TxtProjectPath.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(50, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Deleted Files :"
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(184, 16)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(134, 20)
        Me.TxtPassword.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Related Files :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Projects Path :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Default Users Password :"
        '
        'ClientOptionTabPage
        '
        Me.ClientOptionTabPage.Controls.Add(Me.BtnClose2)
        Me.ClientOptionTabPage.Controls.Add(Me.BtnSaveClientOptions)
        Me.ClientOptionTabPage.Controls.Add(Me.TxtServerPort)
        Me.ClientOptionTabPage.Controls.Add(Me.TxtServerIP)
        Me.ClientOptionTabPage.Controls.Add(Me.Label5)
        Me.ClientOptionTabPage.Controls.Add(Me.Label4)
        Me.ClientOptionTabPage.Location = New System.Drawing.Point(4, 22)
        Me.ClientOptionTabPage.Name = "ClientOptionTabPage"
        Me.ClientOptionTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.ClientOptionTabPage.Size = New System.Drawing.Size(436, 178)
        Me.ClientOptionTabPage.TabIndex = 1
        Me.ClientOptionTabPage.Text = "Client Option"
        Me.ClientOptionTabPage.UseVisualStyleBackColor = True
        '
        'BtnClose2
        '
        Me.BtnClose2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose2.Location = New System.Drawing.Point(274, 89)
        Me.BtnClose2.Name = "BtnClose2"
        Me.BtnClose2.Size = New System.Drawing.Size(53, 23)
        Me.BtnClose2.TabIndex = 4
        Me.BtnClose2.Text = "Close"
        Me.BtnClose2.UseVisualStyleBackColor = True
        '
        'BtnSaveClientOptions
        '
        Me.BtnSaveClientOptions.Enabled = False
        Me.BtnSaveClientOptions.Location = New System.Drawing.Point(109, 89)
        Me.BtnSaveClientOptions.Name = "BtnSaveClientOptions"
        Me.BtnSaveClientOptions.Size = New System.Drawing.Size(159, 23)
        Me.BtnSaveClientOptions.TabIndex = 3
        Me.BtnSaveClientOptions.Text = "Save"
        Me.BtnSaveClientOptions.UseVisualStyleBackColor = True
        '
        'TxtServerPort
        '
        Me.TxtServerPort.Location = New System.Drawing.Point(189, 63)
        Me.TxtServerPort.MaxLength = 8
        Me.TxtServerPort.Name = "TxtServerPort"
        Me.TxtServerPort.Size = New System.Drawing.Size(134, 20)
        Me.TxtServerPort.TabIndex = 2
        '
        'TxtServerIP
        '
        Me.TxtServerIP.Location = New System.Drawing.Point(189, 33)
        Me.TxtServerIP.MaxLength = 15
        Me.TxtServerIP.Name = "TxtServerIP"
        Me.TxtServerIP.Size = New System.Drawing.Size(134, 20)
        Me.TxtServerIP.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(114, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Server Port :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(114, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Server IP :"
        '
        'BtnExitApp
        '
        Me.BtnExitApp.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnExitApp.Location = New System.Drawing.Point(321, 5)
        Me.BtnExitApp.Name = "BtnExitApp"
        Me.BtnExitApp.Size = New System.Drawing.Size(134, 23)
        Me.BtnExitApp.TabIndex = 7
        Me.BtnExitApp.Text = "Exit application"
        Me.BtnExitApp.UseVisualStyleBackColor = True
        Me.BtnExitApp.Visible = False
        '
        'Lblwarning
        '
        Me.Lblwarning.AutoSize = True
        Me.Lblwarning.ForeColor = System.Drawing.Color.Red
        Me.Lblwarning.Location = New System.Drawing.Point(20, 157)
        Me.Lblwarning.Name = "Lblwarning"
        Me.Lblwarning.Size = New System.Drawing.Size(396, 13)
        Me.Lblwarning.TabIndex = 11
        Me.Lblwarning.Text = "Default Users Password , Projects Path , Related Files , Deleted Files  are requi" & _
            "re"
        Me.Lblwarning.Visible = False
        '
        'OptionsFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DataCenter_Server.My.Resources.Resources.OptionsFrm
        Me.ClientSize = New System.Drawing.Size(468, 238)
        Me.Controls.Add(Me.BtnExitApp)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "OptionsFrm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "   Options"
        Me.TabControl1.ResumeLayout(False)
        Me.ServerOptionTabPage.ResumeLayout(False)
        Me.ServerOptionTabPage.PerformLayout()
        Me.ClientOptionTabPage.ResumeLayout(False)
        Me.ClientOptionTabPage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents ServerOptionTabPage As System.Windows.Forms.TabPage
    Friend WithEvents BtnClose1 As System.Windows.Forms.Button
    Friend WithEvents BtnSaveServerOptions As System.Windows.Forms.Button
    Friend WithEvents BtnBrowseRelatedFiles As System.Windows.Forms.Button
    Friend WithEvents BtnBrowseProjectPath As System.Windows.Forms.Button
    Friend WithEvents TxtRelatedFiles As System.Windows.Forms.TextBox
    Friend WithEvents TxtProjectPath As System.Windows.Forms.TextBox
    Friend WithEvents TxtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ClientOptionTabPage As System.Windows.Forms.TabPage
    Friend WithEvents TxtServerPort As System.Windows.Forms.TextBox
    Friend WithEvents TxtServerIP As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnClose2 As System.Windows.Forms.Button
    Friend WithEvents BtnSaveClientOptions As System.Windows.Forms.Button
    Friend WithEvents BtnBrowseDeletedFiles As System.Windows.Forms.Button
    Friend WithEvents TxtDeletedFiles As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnExitApp As System.Windows.Forms.Button
    Friend WithEvents Lblwarning As System.Windows.Forms.Label
End Class
