<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddsContainsFrm
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
        Me.CBSup = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.CBItemsName = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GB = New System.Windows.Forms.GroupBox
        Me.LVItems = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.BtnRemove = New System.Windows.Forms.Button
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.TxtCost = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtSerial = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnClose = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.PNL = New System.Windows.Forms.Panel
        Me.TxtAddNumber = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GB.SuspendLayout()
        Me.PNL.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(224, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "أسم المورد"
        '
        'DTP
        '
        Me.DTP.Checked = False
        Me.DTP.CustomFormat = "dd/MM/yyyy"
        Me.DTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP.Location = New System.Drawing.Point(13, 34)
        Me.DTP.Name = "DTP"
        Me.DTP.Size = New System.Drawing.Size(192, 20)
        Me.DTP.TabIndex = 1
        '
        'CBSup
        '
        Me.CBSup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBSup.FormattingEnabled = True
        Me.CBSup.Location = New System.Drawing.Point(12, 7)
        Me.CBSup.Name = "CBSup"
        Me.CBSup.Size = New System.Drawing.Size(193, 21)
        Me.CBSup.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(239, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "التــاريـخ"
        '
        'CBItemsName
        '
        Me.CBItemsName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBItemsName.FormattingEnabled = True
        Me.CBItemsName.Location = New System.Drawing.Point(7, 19)
        Me.CBItemsName.Name = "CBItemsName"
        Me.CBItemsName.Size = New System.Drawing.Size(170, 21)
        Me.CBItemsName.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(193, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "أسم النــوع"
        '
        'GB
        '
        Me.GB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB.Controls.Add(Me.LVItems)
        Me.GB.Controls.Add(Me.BtnRemove)
        Me.GB.Controls.Add(Me.BtnAdd)
        Me.GB.Controls.Add(Me.TxtCost)
        Me.GB.Controls.Add(Me.Label4)
        Me.GB.Controls.Add(Me.TxtSerial)
        Me.GB.Controls.Add(Me.Label1)
        Me.GB.Controls.Add(Me.CBItemsName)
        Me.GB.Controls.Add(Me.Label2)
        Me.GB.Location = New System.Drawing.Point(12, 123)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(463, 164)
        Me.GB.TabIndex = 4
        Me.GB.TabStop = False
        Me.GB.Text = " - الانـــواع - "
        '
        'LVItems
        '
        Me.LVItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LVItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.LVItems.FullRowSelect = True
        Me.LVItems.GridLines = True
        Me.LVItems.Location = New System.Drawing.Point(259, 19)
        Me.LVItems.Name = "LVItems"
        Me.LVItems.Size = New System.Drawing.Size(197, 112)
        Me.LVItems.TabIndex = 23
        Me.LVItems.UseCompatibleStateImageBehavior = False
        Me.LVItems.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "أسم"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "الكود"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "السعر"
        '
        'BtnRemove
        '
        Me.BtnRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRemove.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnRemove.Enabled = False
        Me.BtnRemove.Location = New System.Drawing.Point(259, 137)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(197, 23)
        Me.BtnRemove.TabIndex = 9
        Me.BtnRemove.Text = "حـذف"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnAdd.Enabled = False
        Me.BtnAdd.Location = New System.Drawing.Point(7, 46)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(95, 46)
        Me.BtnAdd.TabIndex = 7
        Me.BtnAdd.Text = "اضـافه"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'TxtCost
        '
        Me.TxtCost.Location = New System.Drawing.Point(108, 72)
        Me.TxtCost.MaxLength = 10
        Me.TxtCost.Name = "TxtCost"
        Me.TxtCost.Size = New System.Drawing.Size(69, 20)
        Me.TxtCost.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(192, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "سعر الوحده"
        '
        'TxtSerial
        '
        Me.TxtSerial.Enabled = False
        Me.TxtSerial.Location = New System.Drawing.Point(108, 46)
        Me.TxtSerial.MaxLength = 10
        Me.TxtSerial.Name = "TxtSerial"
        Me.TxtSerial.Size = New System.Drawing.Size(69, 20)
        Me.TxtSerial.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(224, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "الكود"
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Location = New System.Drawing.Point(414, 293)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(61, 23)
        Me.BtnClose.TabIndex = 10
        Me.BtnClose.Text = "أغـلاق"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Enabled = False
        Me.BtnSave.Location = New System.Drawing.Point(51, 86)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(192, 23)
        Me.BtnSave.TabIndex = 3
        Me.BtnSave.Text = "حفــظ"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'PNL
        '
        Me.PNL.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PNL.Controls.Add(Me.TxtAddNumber)
        Me.PNL.Controls.Add(Me.CBSup)
        Me.PNL.Controls.Add(Me.Label3)
        Me.PNL.Controls.Add(Me.BtnSave)
        Me.PNL.Controls.Add(Me.DTP)
        Me.PNL.Controls.Add(Me.Label5)
        Me.PNL.Controls.Add(Me.Label6)
        Me.PNL.Location = New System.Drawing.Point(96, 4)
        Me.PNL.Name = "PNL"
        Me.PNL.Size = New System.Drawing.Size(295, 113)
        Me.PNL.TabIndex = 22
        '
        'TxtAddNumber
        '
        Me.TxtAddNumber.Location = New System.Drawing.Point(103, 60)
        Me.TxtAddNumber.Name = "TxtAddNumber"
        Me.TxtAddNumber.ReadOnly = True
        Me.TxtAddNumber.Size = New System.Drawing.Size(102, 20)
        Me.TxtAddNumber.TabIndex = 2
        Me.TxtAddNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(223, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "رقم التوريده"
        '
        'AddsContainsFrm
        '
        Me.AcceptButton = Me.BtnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(487, 317)
        Me.Controls.Add(Me.PNL)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.GB)
        Me.Name = "AddsContainsFrm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "محتـويات الصفـقات"
        Me.GB.ResumeLayout(False)
        Me.GB.PerformLayout()
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents CBSup As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CBItemsName As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GB As System.Windows.Forms.GroupBox
    Friend WithEvents TxtSerial As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnRemove As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents TxtCost As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PNL As System.Windows.Forms.Panel
    Friend WithEvents TxtAddNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LVItems As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
End Class
