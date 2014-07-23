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
        Me.ClientOptionTabPage = New System.Windows.Forms.TabPage
        Me.BtnClose2 = New System.Windows.Forms.Button
        Me.BtnSaveClientOptions = New System.Windows.Forms.Button
        Me.TxtPasswordCon = New System.Windows.Forms.TextBox
        Me.TxtPassword = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.ClientOptionTabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.ClientOptionTabPage)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(444, 204)
        Me.TabControl1.TabIndex = 0
        '
        'ClientOptionTabPage
        '
        Me.ClientOptionTabPage.Controls.Add(Me.BtnClose2)
        Me.ClientOptionTabPage.Controls.Add(Me.BtnSaveClientOptions)
        Me.ClientOptionTabPage.Controls.Add(Me.TxtPasswordCon)
        Me.ClientOptionTabPage.Controls.Add(Me.TxtPassword)
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
        Me.BtnSaveClientOptions.Location = New System.Drawing.Point(109, 89)
        Me.BtnSaveClientOptions.Name = "BtnSaveClientOptions"
        Me.BtnSaveClientOptions.Size = New System.Drawing.Size(159, 23)
        Me.BtnSaveClientOptions.TabIndex = 3
        Me.BtnSaveClientOptions.Text = "Save"
        Me.BtnSaveClientOptions.UseVisualStyleBackColor = True
        '
        'TxtPasswordCon
        '
        Me.TxtPasswordCon.Location = New System.Drawing.Point(189, 63)
        Me.TxtPasswordCon.MaxLength = 8
        Me.TxtPasswordCon.Name = "TxtPasswordCon"
        Me.TxtPasswordCon.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPasswordCon.Size = New System.Drawing.Size(134, 20)
        Me.TxtPasswordCon.TabIndex = 2
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(189, 33)
        Me.TxtPassword.MaxLength = 15
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(134, 20)
        Me.TxtPassword.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(114, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Confirmation :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(114, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Password :"
        '
        'OptionsFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DataCenter_Client.My.Resources.Resources.OptionsFrm
        Me.ClientSize = New System.Drawing.Size(468, 238)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "OptionsFrm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "   Options"
        Me.TabControl1.ResumeLayout(False)
        Me.ClientOptionTabPage.ResumeLayout(False)
        Me.ClientOptionTabPage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents ClientOptionTabPage As System.Windows.Forms.TabPage
    Friend WithEvents TxtPasswordCon As System.Windows.Forms.TextBox
    Friend WithEvents TxtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnClose2 As System.Windows.Forms.Button
    Friend WithEvents BtnSaveClientOptions As System.Windows.Forms.Button
End Class
