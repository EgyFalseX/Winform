<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DisactivatedContractorsFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DisactivatedContractorsFrm))
        Me.LBCon = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnClose = New System.Windows.Forms.Button
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnActivate = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'LBCon
        '
        Me.LBCon.FormattingEnabled = True
        Me.LBCon.Location = New System.Drawing.Point(137, 21)
        Me.LBCon.Name = "LBCon"
        Me.LBCon.Size = New System.Drawing.Size(139, 238)
        Me.LBCon.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Disactivated Contractors list :"
        '
        'BtnClose
        '
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Location = New System.Drawing.Point(11, 236)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(110, 23)
        Me.BtnClose.TabIndex = 3
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(11, 73)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(110, 23)
        Me.BtnDelete.TabIndex = 2
        Me.BtnDelete.Text = "Try to delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnActivate
        '
        Me.BtnActivate.Location = New System.Drawing.Point(11, 44)
        Me.BtnActivate.Name = "BtnActivate"
        Me.BtnActivate.Size = New System.Drawing.Size(110, 23)
        Me.BtnActivate.TabIndex = 1
        Me.BtnActivate.Text = "Activate"
        Me.BtnActivate.UseVisualStyleBackColor = True
        '
        'DisactivatedContractorsFrm
        '
        Me.AcceptButton = Me.BtnActivate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DataCenter_Server.My.Resources.Resources.DisactivatedContractorsFrm
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(284, 266)
        Me.Controls.Add(Me.LBCon)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnActivate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DisactivatedContractorsFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "   Disactivated Contractors"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBCon As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnActivate As System.Windows.Forms.Button
End Class
