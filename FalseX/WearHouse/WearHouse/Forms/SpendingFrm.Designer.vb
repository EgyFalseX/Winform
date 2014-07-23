<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpendingFrm
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
        Me.Label5 = New System.Windows.Forms.Label
        Me.DTP = New System.Windows.Forms.DateTimePicker
        Me.CBName = New System.Windows.Forms.ComboBox
        Me.BtnClose = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.TxtCount = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtInfo = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(214, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "نوع المدفوعات"
        '
        'DTP
        '
        Me.DTP.CustomFormat = "dd/MM/yyyy"
        Me.DTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP.Location = New System.Drawing.Point(13, 39)
        Me.DTP.Name = "DTP"
        Me.DTP.Size = New System.Drawing.Size(192, 20)
        Me.DTP.TabIndex = 1
        '
        'CBName
        '
        Me.CBName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBName.FormattingEnabled = True
        Me.CBName.Location = New System.Drawing.Point(12, 12)
        Me.CBName.MaxLength = 50
        Me.CBName.Name = "CBName"
        Me.CBName.Size = New System.Drawing.Size(193, 21)
        Me.CBName.TabIndex = 0
        '
        'BtnClose
        '
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Location = New System.Drawing.Point(221, 169)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(61, 23)
        Me.BtnClose.TabIndex = 5
        Me.BtnClose.Text = "أغـلاق"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(12, 169)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(193, 23)
        Me.BtnSave.TabIndex = 4
        Me.BtnSave.Text = "حفــظ"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'TxtCount
        '
        Me.TxtCount.Location = New System.Drawing.Point(116, 65)
        Me.TxtCount.MaxLength = 10
        Me.TxtCount.Name = "TxtCount"
        Me.TxtCount.Size = New System.Drawing.Size(89, 20)
        Me.TxtCount.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(239, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "التــاريـخ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(237, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "القيـــمه"
        '
        'TxtInfo
        '
        Me.TxtInfo.Location = New System.Drawing.Point(13, 91)
        Me.TxtInfo.MaxLength = 50
        Me.TxtInfo.Multiline = True
        Me.TxtInfo.Name = "TxtInfo"
        Me.TxtInfo.Size = New System.Drawing.Size(192, 72)
        Me.TxtInfo.TabIndex = 3
        '
        'SpendingFrm
        '
        Me.AcceptButton = Me.BtnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(292, 198)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DTP)
        Me.Controls.Add(Me.CBName)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.TxtInfo)
        Me.Controls.Add(Me.TxtCount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "SpendingFrm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "مصـــروفـات"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents CBName As System.Windows.Forms.ComboBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents TxtCount As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtInfo As System.Windows.Forms.TextBox
End Class
