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
        Me.BtnApply = New System.Windows.Forms.Button
        Me.CBAutoStart = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'BtnApply
        '
        Me.BtnApply.Location = New System.Drawing.Point(59, 40)
        Me.BtnApply.Name = "BtnApply"
        Me.BtnApply.Size = New System.Drawing.Size(73, 23)
        Me.BtnApply.TabIndex = 0
        Me.BtnApply.Text = "Apply"
        Me.BtnApply.UseVisualStyleBackColor = True
        '
        'CBAutoStart
        '
        Me.CBAutoStart.AutoSize = True
        Me.CBAutoStart.Location = New System.Drawing.Point(59, 14)
        Me.CBAutoStart.Name = "CBAutoStart"
        Me.CBAutoStart.Size = New System.Drawing.Size(73, 17)
        Me.CBAutoStart.TabIndex = 1
        Me.CBAutoStart.Text = "AutoStart"
        Me.CBAutoStart.UseVisualStyleBackColor = True
        '
        'OptionsFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(190, 77)
        Me.Controls.Add(Me.CBAutoStart)
        Me.Controls.Add(Me.BtnApply)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "OptionsFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "  Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnApply As System.Windows.Forms.Button
    Friend WithEvents CBAutoStart As System.Windows.Forms.CheckBox
End Class
