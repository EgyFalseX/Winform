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
        Me.BtnClose = New System.Windows.Forms.Button
        Me.BtnNewDB = New System.Windows.Forms.Button
        Me.BtnBackup = New System.Windows.Forms.Button
        Me.BtnLoadDB = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Location = New System.Drawing.Point(155, 41)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(137, 23)
        Me.BtnClose.TabIndex = 3
        Me.BtnClose.Text = "√€·«ﬁ"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnNewDB
        '
        Me.BtnNewDB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnNewDB.Location = New System.Drawing.Point(12, 12)
        Me.BtnNewDB.Name = "BtnNewDB"
        Me.BtnNewDB.Size = New System.Drawing.Size(137, 23)
        Me.BtnNewDB.TabIndex = 0
        Me.BtnNewDB.Text = "ﬁ«⁄œ… »Ì«‰«  ÃœÌœÂ"
        Me.BtnNewDB.UseVisualStyleBackColor = True
        '
        'BtnBackup
        '
        Me.BtnBackup.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnBackup.Location = New System.Drawing.Point(155, 12)
        Me.BtnBackup.Name = "BtnBackup"
        Me.BtnBackup.Size = New System.Drawing.Size(137, 23)
        Me.BtnBackup.TabIndex = 1
        Me.BtnBackup.Text = "Õ›Ÿ ‰”ŒÂ √Õ Ì«ÿÌÂ"
        Me.BtnBackup.UseVisualStyleBackColor = True
        '
        'BtnLoadDB
        '
        Me.BtnLoadDB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnLoadDB.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnLoadDB.Location = New System.Drawing.Point(12, 41)
        Me.BtnLoadDB.Name = "BtnLoadDB"
        Me.BtnLoadDB.Size = New System.Drawing.Size(137, 23)
        Me.BtnLoadDB.TabIndex = 2
        Me.BtnLoadDB.Text = " Õ„Ì· ﬁ«⁄œ… »Ì«‰«  ”«»ﬁÂ"
        Me.BtnLoadDB.UseVisualStyleBackColor = True
        '
        'OptionsFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(298, 76)
        Me.Controls.Add(Me.BtnLoadDB)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnBackup)
        Me.Controls.Add(Me.BtnNewDB)
        Me.Name = "OptionsFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "    ŒÌ«—« "
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnNewDB As System.Windows.Forms.Button
    Friend WithEvents BtnBackup As System.Windows.Forms.Button
    Friend WithEvents BtnLoadDB As System.Windows.Forms.Button
End Class
