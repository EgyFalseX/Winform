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
        Me.CBTypesName = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GB = New System.Windows.Forms.GroupBox
        Me.PnlTypes = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtCost = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtCount = New System.Windows.Forms.TextBox
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.TxtContainCount = New System.Windows.Forms.TextBox
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.BtnSaveDiscount = New System.Windows.Forms.Button
        Me.TxtDiscount = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.GBInformation = New System.Windows.Forms.GroupBox
        Me.TxtNotes = New System.Windows.Forms.TextBox
        Me.LVItems = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.BtnRemove = New System.Windows.Forms.Button
        Me.TxtBillValueAfterDiscount = New System.Windows.Forms.TextBox
        Me.TxtBillValue = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.BtnClose = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.PNL = New System.Windows.Forms.Panel
        Me.TxtInfo = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtName = New System.Windows.Forms.TextBox
        Me.TxtBillNumber = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.BtnNewBill = New System.Windows.Forms.Button
        Me.GB.SuspendLayout()
        Me.PnlTypes.SuspendLayout()
        Me.GBInformation.SuspendLayout()
        Me.PNL.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'CBTypesName
        '
        Me.CBTypesName.BackColor = System.Drawing.Color.White
        Me.CBTypesName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBTypesName.Enabled = False
        Me.CBTypesName.FormattingEnabled = True
        Me.CBTypesName.Location = New System.Drawing.Point(7, 6)
        Me.CBTypesName.Name = "CBTypesName"
        Me.CBTypesName.Size = New System.Drawing.Size(189, 21)
        Me.CBTypesName.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(204, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "اسم  الصنف"
        '
        'GB
        '
        Me.GB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB.Controls.Add(Me.PnlTypes)
        Me.GB.Controls.Add(Me.BtnPrint)
        Me.GB.Controls.Add(Me.BtnSaveDiscount)
        Me.GB.Controls.Add(Me.TxtDiscount)
        Me.GB.Controls.Add(Me.Label10)
        Me.GB.Controls.Add(Me.GBInformation)
        Me.GB.Controls.Add(Me.LVItems)
        Me.GB.Controls.Add(Me.BtnRemove)
        Me.GB.Controls.Add(Me.TxtBillValueAfterDiscount)
        Me.GB.Controls.Add(Me.TxtBillValue)
        Me.GB.Controls.Add(Me.Label11)
        Me.GB.Controls.Add(Me.Label9)
        Me.GB.Location = New System.Drawing.Point(12, 178)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(497, 300)
        Me.GB.TabIndex = 4
        Me.GB.TabStop = False
        Me.GB.Text = " - الموديلات - "
        '
        'PnlTypes
        '
        Me.PnlTypes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlTypes.Controls.Add(Me.CBTypesName)
        Me.PnlTypes.Controls.Add(Me.Label2)
        Me.PnlTypes.Controls.Add(Me.Label1)
        Me.PnlTypes.Controls.Add(Me.TxtCost)
        Me.PnlTypes.Controls.Add(Me.Label4)
        Me.PnlTypes.Controls.Add(Me.TxtCount)
        Me.PnlTypes.Controls.Add(Me.BtnAdd)
        Me.PnlTypes.Controls.Add(Me.TxtContainCount)
        Me.PnlTypes.Location = New System.Drawing.Point(6, 16)
        Me.PnlTypes.Name = "PnlTypes"
        Me.PnlTypes.Size = New System.Drawing.Size(274, 112)
        Me.PnlTypes.TabIndex = 105
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(226, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "الكميه"
        '
        'TxtCost
        '
        Me.TxtCost.BackColor = System.Drawing.Color.White
        Me.TxtCost.Location = New System.Drawing.Point(102, 59)
        Me.TxtCost.MaxLength = 10
        Me.TxtCost.Name = "TxtCost"
        Me.TxtCost.Size = New System.Drawing.Size(99, 20)
        Me.TxtCost.TabIndex = 8
        Me.TxtCost.Text = "0"
        Me.TxtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(220, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "السعــر"
        '
        'TxtCount
        '
        Me.TxtCount.BackColor = System.Drawing.Color.White
        Me.TxtCount.Location = New System.Drawing.Point(102, 33)
        Me.TxtCount.MaxLength = 10
        Me.TxtCount.Name = "TxtCount"
        Me.TxtCount.Size = New System.Drawing.Size(99, 20)
        Me.TxtCount.TabIndex = 7
        Me.TxtCount.Text = "0"
        Me.TxtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnAdd
        '
        Me.BtnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnAdd.Enabled = False
        Me.BtnAdd.Location = New System.Drawing.Point(7, 56)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(89, 46)
        Me.BtnAdd.TabIndex = 9
        Me.BtnAdd.Text = "اضـافه"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'TxtContainCount
        '
        Me.TxtContainCount.BackColor = System.Drawing.Color.White
        Me.TxtContainCount.Location = New System.Drawing.Point(7, 33)
        Me.TxtContainCount.Name = "TxtContainCount"
        Me.TxtContainCount.ReadOnly = True
        Me.TxtContainCount.Size = New System.Drawing.Size(89, 20)
        Me.TxtContainCount.TabIndex = 100
        Me.TxtContainCount.TabStop = False
        Me.TxtContainCount.Text = "0"
        Me.TxtContainCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnPrint
        '
        Me.BtnPrint.Location = New System.Drawing.Point(6, 268)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(75, 23)
        Me.BtnPrint.TabIndex = 14
        Me.BtnPrint.Text = "طبــاعه"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'BtnSaveDiscount
        '
        Me.BtnSaveDiscount.Enabled = False
        Me.BtnSaveDiscount.Location = New System.Drawing.Point(6, 242)
        Me.BtnSaveDiscount.Name = "BtnSaveDiscount"
        Me.BtnSaveDiscount.Size = New System.Drawing.Size(75, 23)
        Me.BtnSaveDiscount.TabIndex = 13
        Me.BtnSaveDiscount.Text = "حفظ"
        Me.BtnSaveDiscount.UseVisualStyleBackColor = True
        '
        'TxtDiscount
        '
        Me.TxtDiscount.Location = New System.Drawing.Point(87, 244)
        Me.TxtDiscount.MaxLength = 10
        Me.TxtDiscount.Name = "TxtDiscount"
        Me.TxtDiscount.Size = New System.Drawing.Size(88, 20)
        Me.TxtDiscount.TabIndex = 12
        Me.TxtDiscount.Text = "0"
        Me.TxtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(237, 248)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 103
        Me.Label10.Text = "الخصم"
        '
        'GBInformation
        '
        Me.GBInformation.Controls.Add(Me.TxtNotes)
        Me.GBInformation.Location = New System.Drawing.Point(6, 131)
        Me.GBInformation.Name = "GBInformation"
        Me.GBInformation.Size = New System.Drawing.Size(261, 89)
        Me.GBInformation.TabIndex = 101
        Me.GBInformation.TabStop = False
        Me.GBInformation.Text = " - معلومات - "
        Me.GBInformation.Visible = False
        '
        'TxtNotes
        '
        Me.TxtNotes.AcceptsReturn = True
        Me.TxtNotes.BackColor = System.Drawing.Color.White
        Me.TxtNotes.Location = New System.Drawing.Point(6, 19)
        Me.TxtNotes.MaxLength = 10
        Me.TxtNotes.Multiline = True
        Me.TxtNotes.Name = "TxtNotes"
        Me.TxtNotes.ReadOnly = True
        Me.TxtNotes.Size = New System.Drawing.Size(249, 61)
        Me.TxtNotes.TabIndex = 100
        Me.TxtNotes.TabStop = False
        Me.TxtNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.LVItems.MultiSelect = False
        Me.LVItems.Name = "LVItems"
        Me.LVItems.Size = New System.Drawing.Size(197, 246)
        Me.LVItems.TabIndex = 10
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
        Me.ColumnHeader2.Text = "الكميه"
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
        Me.BtnRemove.Location = New System.Drawing.Point(294, 271)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(197, 23)
        Me.BtnRemove.TabIndex = 11
        Me.BtnRemove.Text = "حـذف"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'TxtBillValueAfterDiscount
        '
        Me.TxtBillValueAfterDiscount.BackColor = System.Drawing.Color.White
        Me.TxtBillValueAfterDiscount.Location = New System.Drawing.Point(87, 270)
        Me.TxtBillValueAfterDiscount.MaxLength = 10
        Me.TxtBillValueAfterDiscount.Name = "TxtBillValueAfterDiscount"
        Me.TxtBillValueAfterDiscount.ReadOnly = True
        Me.TxtBillValueAfterDiscount.Size = New System.Drawing.Size(88, 20)
        Me.TxtBillValueAfterDiscount.TabIndex = 6
        Me.TxtBillValueAfterDiscount.Text = "0"
        Me.TxtBillValueAfterDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtBillValue
        '
        Me.TxtBillValue.BackColor = System.Drawing.Color.White
        Me.TxtBillValue.Location = New System.Drawing.Point(87, 220)
        Me.TxtBillValue.MaxLength = 10
        Me.TxtBillValue.Name = "TxtBillValue"
        Me.TxtBillValue.ReadOnly = True
        Me.TxtBillValue.Size = New System.Drawing.Size(88, 20)
        Me.TxtBillValue.TabIndex = 6
        Me.TxtBillValue.Text = "0"
        Me.TxtBillValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(184, 273)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 13)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "الفاتوره بعد الخصم"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(198, 223)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "اجمالي الفاتوره"
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Location = New System.Drawing.Point(442, 487)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(61, 23)
        Me.BtnClose.TabIndex = 16
        Me.BtnClose.Text = "أغـلاق"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Enabled = False
        Me.BtnSave.Location = New System.Drawing.Point(13, 145)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(192, 23)
        Me.BtnSave.TabIndex = 4
        Me.BtnSave.Text = "حفــظ"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'PNL
        '
        Me.PNL.Controls.Add(Me.TxtInfo)
        Me.PNL.Controls.Add(Me.Label8)
        Me.PNL.Controls.Add(Me.TxtName)
        Me.PNL.Controls.Add(Me.TxtBillNumber)
        Me.PNL.Controls.Add(Me.Label3)
        Me.PNL.Controls.Add(Me.BtnSave)
        Me.PNL.Controls.Add(Me.DTP)
        Me.PNL.Controls.Add(Me.Label5)
        Me.PNL.Controls.Add(Me.Label6)
        Me.PNL.Location = New System.Drawing.Point(9, 6)
        Me.PNL.Name = "PNL"
        Me.PNL.Size = New System.Drawing.Size(295, 173)
        Me.PNL.TabIndex = 0
        '
        'TxtInfo
        '
        Me.TxtInfo.AcceptsReturn = True
        Me.TxtInfo.BackColor = System.Drawing.Color.White
        Me.TxtInfo.Location = New System.Drawing.Point(13, 86)
        Me.TxtInfo.MaxLength = 49
        Me.TxtInfo.Multiline = True
        Me.TxtInfo.Name = "TxtInfo"
        Me.TxtInfo.Size = New System.Drawing.Size(192, 55)
        Me.TxtInfo.TabIndex = 3
        Me.TxtInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(237, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "معلومات"
        '
        'TxtName
        '
        Me.TxtName.BackColor = System.Drawing.Color.White
        Me.TxtName.Location = New System.Drawing.Point(13, 8)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(189, 20)
        Me.TxtName.TabIndex = 0
        Me.TxtName.Text = "نقــــــــــدا"
        Me.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtBillNumber
        '
        Me.TxtBillNumber.BackColor = System.Drawing.Color.White
        Me.TxtBillNumber.Location = New System.Drawing.Point(103, 60)
        Me.TxtBillNumber.Name = "TxtBillNumber"
        Me.TxtBillNumber.ReadOnly = True
        Me.TxtBillNumber.Size = New System.Drawing.Size(102, 20)
        Me.TxtBillNumber.TabIndex = 2
        Me.TxtBillNumber.TabStop = False
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
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Accounting_Lite.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(310, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(201, 174)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'BtnNewBill
        '
        Me.BtnNewBill.Location = New System.Drawing.Point(12, 487)
        Me.BtnNewBill.Name = "BtnNewBill"
        Me.BtnNewBill.Size = New System.Drawing.Size(75, 23)
        Me.BtnNewBill.TabIndex = 15
        Me.BtnNewBill.Text = "جــديد"
        Me.BtnNewBill.UseVisualStyleBackColor = True
        '
        'BillsFrm
        '
        Me.AcceptButton = Me.BtnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(521, 514)
        Me.Controls.Add(Me.BtnNewBill)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PNL)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.GB)
        Me.Name = "BillsFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "الــفاتــوره"
        Me.GB.ResumeLayout(False)
        Me.GB.PerformLayout()
        Me.PnlTypes.ResumeLayout(False)
        Me.PnlTypes.PerformLayout()
        Me.GBInformation.ResumeLayout(False)
        Me.GBInformation.PerformLayout()
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CBTypesName As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GB As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnRemove As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents PNL As System.Windows.Forms.Panel
    Friend WithEvents TxtBillNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LVItems As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TxtName As System.Windows.Forms.TextBox
    Friend WithEvents GBInformation As System.Windows.Forms.GroupBox
    Friend WithEvents TxtNotes As System.Windows.Forms.TextBox
    Friend WithEvents TxtInfo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtContainCount As System.Windows.Forms.TextBox
    Friend WithEvents TxtCount As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtCost As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtBillValueAfterDiscount As System.Windows.Forms.TextBox
    Friend WithEvents TxtBillValue As System.Windows.Forms.TextBox
    Friend WithEvents BtnSaveDiscount As System.Windows.Forms.Button
    Friend WithEvents TxtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PnlTypes As System.Windows.Forms.Panel
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BtnNewBill As System.Windows.Forms.Button
End Class
