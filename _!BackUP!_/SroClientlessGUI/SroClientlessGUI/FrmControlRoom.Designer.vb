<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmControlRoom
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TxtOutput = New System.Windows.Forms.TextBox
        Me.BtnCLose = New System.Windows.Forms.Button
        Me.CBAccounts = New System.Windows.Forms.ComboBox
        Me.BtnLogin = New System.Windows.Forms.Button
        Me.CBServers = New System.Windows.Forms.ComboBox
        Me.PicBox = New System.Windows.Forms.PictureBox
        Me.TxtImageCode = New System.Windows.Forms.TextBox
        Me.BtnSendImageCode = New System.Windows.Forms.Button
        Me.PnlImageCode = New System.Windows.Forms.Panel
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlImageCode.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtOutput
        '
        Me.TxtOutput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtOutput.Location = New System.Drawing.Point(12, 211)
        Me.TxtOutput.Multiline = True
        Me.TxtOutput.Name = "TxtOutput"
        Me.TxtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtOutput.Size = New System.Drawing.Size(485, 363)
        Me.TxtOutput.TabIndex = 7
        '
        'BtnCLose
        '
        Me.BtnCLose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCLose.Enabled = False
        Me.BtnCLose.Location = New System.Drawing.Point(411, 182)
        Me.BtnCLose.Name = "BtnCLose"
        Me.BtnCLose.Size = New System.Drawing.Size(86, 23)
        Me.BtnCLose.TabIndex = 6
        Me.BtnCLose.Text = "Close Account"
        Me.BtnCLose.UseVisualStyleBackColor = True
        '
        'CBAccounts
        '
        Me.CBAccounts.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBAccounts.FormattingEnabled = True
        Me.CBAccounts.Location = New System.Drawing.Point(366, 12)
        Me.CBAccounts.Name = "CBAccounts"
        Me.CBAccounts.Size = New System.Drawing.Size(131, 21)
        Me.CBAccounts.TabIndex = 0
        '
        'BtnLogin
        '
        Me.BtnLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLogin.Location = New System.Drawing.Point(286, 39)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(211, 23)
        Me.BtnLogin.TabIndex = 2
        Me.BtnLogin.Text = "Log Me in"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'CBServers
        '
        Me.CBServers.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBServers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBServers.FormattingEnabled = True
        Me.CBServers.Location = New System.Drawing.Point(286, 12)
        Me.CBServers.Name = "CBServers"
        Me.CBServers.Size = New System.Drawing.Size(74, 21)
        Me.CBServers.TabIndex = 1
        '
        'PicBox
        '
        Me.PicBox.Location = New System.Drawing.Point(7, 7)
        Me.PicBox.Name = "PicBox"
        Me.PicBox.Size = New System.Drawing.Size(197, 50)
        Me.PicBox.TabIndex = 8
        Me.PicBox.TabStop = False
        '
        'TxtImageCode
        '
        Me.TxtImageCode.Location = New System.Drawing.Point(7, 63)
        Me.TxtImageCode.MaxLength = 6
        Me.TxtImageCode.Name = "TxtImageCode"
        Me.TxtImageCode.Size = New System.Drawing.Size(129, 20)
        Me.TxtImageCode.TabIndex = 4
        '
        'BtnSendImageCode
        '
        Me.BtnSendImageCode.Location = New System.Drawing.Point(141, 63)
        Me.BtnSendImageCode.Name = "BtnSendImageCode"
        Me.BtnSendImageCode.Size = New System.Drawing.Size(63, 23)
        Me.BtnSendImageCode.TabIndex = 5
        Me.BtnSendImageCode.Text = "Send"
        Me.BtnSendImageCode.UseVisualStyleBackColor = True
        '
        'PnlImageCode
        '
        Me.PnlImageCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlImageCode.Controls.Add(Me.PicBox)
        Me.PnlImageCode.Controls.Add(Me.BtnSendImageCode)
        Me.PnlImageCode.Controls.Add(Me.TxtImageCode)
        Me.PnlImageCode.Location = New System.Drawing.Point(286, 68)
        Me.PnlImageCode.Name = "PnlImageCode"
        Me.PnlImageCode.Size = New System.Drawing.Size(211, 92)
        Me.PnlImageCode.TabIndex = 3
        '
        'FrmControlRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 586)
        Me.Controls.Add(Me.PnlImageCode)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.CBServers)
        Me.Controls.Add(Me.CBAccounts)
        Me.Controls.Add(Me.BtnCLose)
        Me.Controls.Add(Me.TxtOutput)
        Me.Name = "FrmControlRoom"
        Me.Text = "Sro ClientLess GUI"
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlImageCode.ResumeLayout(False)
        Me.PnlImageCode.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtOutput As System.Windows.Forms.TextBox
    Friend WithEvents BtnCLose As System.Windows.Forms.Button
    Friend WithEvents CBAccounts As System.Windows.Forms.ComboBox
    Friend WithEvents BtnLogin As System.Windows.Forms.Button
    Friend WithEvents CBServers As System.Windows.Forms.ComboBox
    Friend WithEvents PicBox As System.Windows.Forms.PictureBox
    Friend WithEvents TxtImageCode As System.Windows.Forms.TextBox
    Friend WithEvents BtnSendImageCode As System.Windows.Forms.Button
    Friend WithEvents PnlImageCode As System.Windows.Forms.Panel

End Class
