<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BillsFrm
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.CBItemsName = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GB = New System.Windows.Forms.GroupBox
        Me.GBReturned = New System.Windows.Forms.GroupBox
        Me.LblDate = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtInfo = New System.Windows.Forms.TextBox
        Me.LVItems = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.BtnRemove = New System.Windows.Forms.Button
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.TxtCost = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.CBAdds = New System.Windows.Forms.ComboBox
        Me.CBSerial = New System.Windows.Forms.ComboBox
        Me.BtnClose = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.PNL = New System.Windows.Forms.Panel
        Me.TxtName = New System.Windows.Forms.TextBox
        Me.TxtBillNumber = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GB.SuspendLayout()
        Me.GBReturned.SuspendLayout()
        Me.PNL.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(214, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "أسم العمــيل"
        '
        'DTP
        '
        Me.DTP.CustomFormat = "dd/MM/yyyy"
        Me.DTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP.Location = New System.Drawing.Point(13, 34)
        Me.DTP.Name = "DTP"
        Me.DTP.Size = New System.Drawing.Size(192, 20)
        Me.DTP.TabIndex = 1
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
        Me.CBItemsName.Enabled = False
        Me.CBItemsName.FormattingEnabled = True
        Me.CBItemsName.Location = New System.Drawing.Point(6, 19)
        Me.CBItemsName.Name = "CBItemsName"
        Me.CBItemsName.Size = New System.Drawing.Size(170, 21)
        Me.CBItemsName.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(207, 22)
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
        Me.GB.Controls.Add(Me.GBReturned)
        Me.GB.Controls.Add(Me.LVItems)
        Me.GB.Controls.Add(Me.BtnRemove)
        Me.GB.Controls.Add(Me.BtnAdd)
        Me.GB.Controls.Add(Me.TxtCost)
        Me.GB.Controls.Add(Me.Label4)
        Me.GB.Controls.Add(Me.Label7)
        Me.GB.Controls.Add(Me.Label1)
        Me.GB.Controls.Add(Me.CBAdds)
        Me.GB.Controls.Add(Me.CBSerial)
        Me.GB.Controls.Add(Me.CBItemsName)
        Me.GB.Controls.Add(Me.Label2)
        Me.GB.Location = New System.Drawing.Point(12, 123)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(497, 248)
        Me.GB.TabIndex = 4
        Me.GB.TabStop = False
        Me.GB.Text = " - الانـــواع - "
        '
        'GBReturned
        '
        Me.GBReturned.Controls.Add(Me.LblDate)
        Me.GBReturned.Controls.Add(Me.Label10)
        Me.GBReturned.Controls.Add(Me.Label8)
        Me.GBReturned.Controls.Add(Me.TxtInfo)
        Me.GBReturned.Location = New System.Drawing.Point(6, 124)
        Me.GBReturned.Name = "GBReturned"
        Me.GBReturned.Size = New System.Drawing.Size(261, 118)
        Me.GBReturned.TabIndex = 101
        Me.GBReturned.TabStop = False
        Me.GBReturned.Text = " - مرتــجع - "
        Me.GBReturned.Visible = False
        '
        'LblDate
        '
        Me.LblDate.AutoSize = True
        Me.LblDate.Location = New System.Drawing.Point(131, 16)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(63, 13)
        Me.LblDate.TabIndex = 25
        Me.LblDate.Text = "24/09/1983"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(198, 39)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "ملاحظــات"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(214, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "بتاريــخ"
        '
        'TxtInfo
        '
        Me.TxtInfo.AcceptsReturn = True
        Me.TxtInfo.Location = New System.Drawing.Point(6, 36)
        Me.TxtInfo.MaxLength = 10
        Me.TxtInfo.Multiline = True
        Me.TxtInfo.Name = "TxtInfo"
        Me.TxtInfo.ReadOnly = True
        Me.TxtInfo.Size = New System.Drawing.Size(186, 76)
        Me.TxtInfo.TabIndex = 6
        Me.TxtInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LVItems
        '
        Me.LVItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LVItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.LVItems.FullRowSelect = True
        Me.LVItems.GridLines = True
        Me.LVItems.Location = New System.Drawing.Point(294, 19)
        Me.LVItems.Name = "LVItems"
        Me.LVItems.Size = New System.Drawing.Size(197, 194)
        Me.LVItems.TabIndex = 100
        Me.LVItems.UseCompatibleStateImageBehavior = False
        Me.LVItems.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "أسم"
        Me.ColumnHeader1.Width = 87
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "الكود"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "السعر"
        Me.ColumnHeader3.Width = 46
        '
        'BtnRemove
        '
        Me.BtnRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRemove.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnRemove.Enabled = False
        Me.BtnRemove.Location = New System.Drawing.Point(294, 219)
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
        Me.BtnAdd.Location = New System.Drawing.Point(6, 46)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(95, 46)
        Me.BtnAdd.TabIndex = 7
        Me.BtnAdd.Text = "اضـافه"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'TxtCost
        '
        Me.TxtCost.Location = New System.Drawing.Point(107, 99)
        Me.TxtCost.MaxLength = 10
        Me.TxtCost.Name = "TxtCost"
        Me.TxtCost.Size = New System.Drawing.Size(69, 20)
        Me.TxtCost.TabIndex = 6
        Me.TxtCost.Text = "0"
        Me.TxtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(206, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "سعر الوحده"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(220, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "التوريدات"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(238, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "الكود"
        '
        'CBAdds
        '
        Me.CBAdds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBAdds.Enabled = False
        Me.CBAdds.FormattingEnabled = True
        Me.CBAdds.Location = New System.Drawing.Point(107, 46)
        Me.CBAdds.Name = "CBAdds"
        Me.CBAdds.Size = New System.Drawing.Size(99, 21)
        Me.CBAdds.TabIndex = 4
        '
        'CBSerial
        '
        Me.CBSerial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBSerial.Enabled = False
        Me.CBSerial.FormattingEnabled = True
        Me.CBSerial.Location = New System.Drawing.Point(107, 73)
        Me.CBSerial.Name = "CBSerial"
        Me.CBSerial.Size = New System.Drawing.Size(99, 21)
        Me.CBSerial.TabIndex = 4
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Location = New System.Drawing.Point(442, 377)
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
        Me.PNL.Controls.Add(Me.TxtName)
        Me.PNL.Controls.Add(Me.TxtBillNumber)
        Me.PNL.Controls.Add(Me.Label3)
        Me.PNL.Controls.Add(Me.BtnSave)
        Me.PNL.Controls.Add(Me.DTP)
        Me.PNL.Controls.Add(Me.Label5)
        Me.PNL.Controls.Add(Me.Label6)
        Me.PNL.Location = New System.Drawing.Point(113, 6)
        Me.PNL.Name = "PNL"
        Me.PNL.Size = New System.Drawing.Size(295, 113)
        Me.PNL.TabIndex = 22
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(13, 8)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(189, 20)
        Me.TxtName.TabIndex = 2
        Me.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtBillNumber
        '
        Me.TxtBillNumber.Location = New System.Drawing.Point(103, 60)
        Me.TxtBillNumber.Name = "TxtBillNumber"
        Me.TxtBillNumber.Size = New System.Drawing.Size(102, 20)
        Me.TxtBillNumber.TabIndex = 2
        Me.TxtBillNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(215, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "رقم الفاتـــوره"
        '
        'BillsFrm
        '
        Me.AcceptButton = Me.BtnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(521, 406)
        Me.Controls.Add(Me.PNL)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.GB)
        Me.Name = "BillsFrm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "الــفاتــوره"
        Me.GB.ResumeLayout(False)
        Me.GB.PerformLayout()
        Me.GBReturned.ResumeLayout(False)
        Me.GBReturned.PerformLayout()
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CBItemsName As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GB As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnRemove As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents TxtCost As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PNL As System.Windows.Forms.Panel
    Friend WithEvents TxtBillNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LVItems As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TxtName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CBAdds As System.Windows.Forms.ComboBox
    Friend WithEvents CBSerial As System.Windows.Forms.ComboBox
    Friend WithEvents GBReturned As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LblDate As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtInfo As System.Windows.Forms.TextBox
End Class
