<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditorFrm
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
        Me.GBItems = New System.Windows.Forms.GroupBox
        Me.BtnDelItem = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.CBItems = New System.Windows.Forms.ComboBox
        Me.BtnItemsUpdate = New System.Windows.Forms.Button
        Me.TxtItemName = New System.Windows.Forms.TextBox
        Me.GBBills = New System.Windows.Forms.GroupBox
        Me.BtnBillContainEditor = New System.Windows.Forms.Button
        Me.DTPBill = New System.Windows.Forms.DateTimePicker
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.TxtBillID = New System.Windows.Forms.TextBox
        Me.TxtBillName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnBillUpdate = New System.Windows.Forms.Button
        Me.BtnDelEmptyBill = New System.Windows.Forms.Button
        Me.BtnDelBill = New System.Windows.Forms.Button
        Me.CBEmptyBills = New System.Windows.Forms.ComboBox
        Me.CBBills = New System.Windows.Forms.ComboBox
        Me.GBAdds = New System.Windows.Forms.GroupBox
        Me.BtnAddContainEditor = New System.Windows.Forms.Button
        Me.BtnAddUpdate = New System.Windows.Forms.Button
        Me.DTPAdds = New System.Windows.Forms.DateTimePicker
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.BtnDelAdd = New System.Windows.Forms.Button
        Me.CBAddSups = New System.Windows.Forms.ComboBox
        Me.CBAdds = New System.Windows.Forms.ComboBox
        Me.ChBItems = New System.Windows.Forms.CheckBox
        Me.ChBBills = New System.Windows.Forms.CheckBox
        Me.ChBAdds = New System.Windows.Forms.CheckBox
        Me.BtnClose = New System.Windows.Forms.Button
        Me.GBSup = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtnDelSup = New System.Windows.Forms.Button
        Me.BtnSupUpdate = New System.Windows.Forms.Button
        Me.TxtSupInfo = New System.Windows.Forms.TextBox
        Me.TxtSupPhone = New System.Windows.Forms.TextBox
        Me.TxtSupName = New System.Windows.Forms.TextBox
        Me.TxtSupAddress = New System.Windows.Forms.TextBox
        Me.CBSup = New System.Windows.Forms.ComboBox
        Me.ChBSup = New System.Windows.Forms.CheckBox
        Me.GBSpends = New System.Windows.Forms.GroupBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.TxtSpendValue = New System.Windows.Forms.TextBox
        Me.DTPSpend = New System.Windows.Forms.DateTimePicker
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.BtnSpendUpdate = New System.Windows.Forms.Button
        Me.TxtSpendInfo = New System.Windows.Forms.TextBox
        Me.BtnDelSpend = New System.Windows.Forms.Button
        Me.CBSpends = New System.Windows.Forms.ComboBox
        Me.ChBSpends = New System.Windows.Forms.CheckBox
        Me.TabControlEditor = New System.Windows.Forms.TabControl
        Me.TabPageItems = New System.Windows.Forms.TabPage
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.TabPageSups = New System.Windows.Forms.TabPage
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.TabPageEmps = New System.Windows.Forms.TabPage
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.GBEmps = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.BtnDelEmp = New System.Windows.Forms.Button
        Me.BtnEmpUpdate = New System.Windows.Forms.Button
        Me.TxtEmpSalary = New System.Windows.Forms.TextBox
        Me.TxtEmpPhone = New System.Windows.Forms.TextBox
        Me.TxtEmpName = New System.Windows.Forms.TextBox
        Me.TxtEmpAddress = New System.Windows.Forms.TextBox
        Me.CBEmps = New System.Windows.Forms.ComboBox
        Me.ChBEmps = New System.Windows.Forms.CheckBox
        Me.TabPageAdds = New System.Windows.Forms.TabPage
        Me.TxtWarning = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.TabPageReturners = New System.Windows.Forms.TabPage
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.GBReturners = New System.Windows.Forms.GroupBox
        Me.DTPRet = New System.Windows.Forms.DateTimePicker
        Me.Label19 = New System.Windows.Forms.Label
        Me.BtnRetDel = New System.Windows.Forms.Button
        Me.Label18 = New System.Windows.Forms.Label
        Me.CBReturners = New System.Windows.Forms.ComboBox
        Me.BtnRetUpdate = New System.Windows.Forms.Button
        Me.TxtRetInfo = New System.Windows.Forms.TextBox
        Me.ChBReturners = New System.Windows.Forms.CheckBox
        Me.TabPageBills = New System.Windows.Forms.TabPage
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.TabPageMaintenances = New System.Windows.Forms.TabPage
        Me.GBMaint = New System.Windows.Forms.GroupBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.TxtMaintValue = New System.Windows.Forms.TextBox
        Me.DTPMaint = New System.Windows.Forms.DateTimePicker
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.BtnMaintDel = New System.Windows.Forms.Button
        Me.Label21 = New System.Windows.Forms.Label
        Me.CBMaintEmps = New System.Windows.Forms.ComboBox
        Me.CBMaints = New System.Windows.Forms.ComboBox
        Me.BtnMaintUpdate = New System.Windows.Forms.Button
        Me.TxtMaintInfo = New System.Windows.Forms.TextBox
        Me.ChbMaint = New System.Windows.Forms.CheckBox
        Me.TabPageSpends = New System.Windows.Forms.TabPage
        Me.GBItems.SuspendLayout()
        Me.GBBills.SuspendLayout()
        Me.GBAdds.SuspendLayout()
        Me.GBSup.SuspendLayout()
        Me.GBSpends.SuspendLayout()
        Me.TabControlEditor.SuspendLayout()
        Me.TabPageItems.SuspendLayout()
        Me.TabPageSups.SuspendLayout()
        Me.TabPageEmps.SuspendLayout()
        Me.GBEmps.SuspendLayout()
        Me.TabPageAdds.SuspendLayout()
        Me.TabPageReturners.SuspendLayout()
        Me.GBReturners.SuspendLayout()
        Me.TabPageBills.SuspendLayout()
        Me.TabPageMaintenances.SuspendLayout()
        Me.GBMaint.SuspendLayout()
        Me.TabPageSpends.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBItems
        '
        Me.GBItems.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GBItems.Controls.Add(Me.BtnDelItem)
        Me.GBItems.Controls.Add(Me.Label4)
        Me.GBItems.Controls.Add(Me.CBItems)
        Me.GBItems.Controls.Add(Me.BtnItemsUpdate)
        Me.GBItems.Controls.Add(Me.TxtItemName)
        Me.GBItems.Enabled = False
        Me.GBItems.Location = New System.Drawing.Point(15, 100)
        Me.GBItems.Name = "GBItems"
        Me.GBItems.Size = New System.Drawing.Size(447, 114)
        Me.GBItems.TabIndex = 0
        Me.GBItems.TabStop = False
        Me.GBItems.Text = "  - «·«‰‹‹‹Ê«⁄ -  "
        '
        'BtnDelItem
        '
        Me.BtnDelItem.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnDelItem.Location = New System.Drawing.Point(273, 18)
        Me.BtnDelItem.Name = "BtnDelItem"
        Me.BtnDelItem.Size = New System.Drawing.Size(98, 23)
        Me.BtnDelItem.TabIndex = 2
        Me.BtnDelItem.Text = "Õ‹‹‹–›"
        Me.BtnDelItem.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(286, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = " ⁄œÌ· «·«”„"
        '
        'CBItems
        '
        Me.CBItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBItems.FormattingEnabled = True
        Me.CBItems.Location = New System.Drawing.Point(75, 20)
        Me.CBItems.Name = "CBItems"
        Me.CBItems.Size = New System.Drawing.Size(192, 21)
        Me.CBItems.TabIndex = 1
        '
        'BtnItemsUpdate
        '
        Me.BtnItemsUpdate.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnItemsUpdate.Enabled = False
        Me.BtnItemsUpdate.Location = New System.Drawing.Point(75, 73)
        Me.BtnItemsUpdate.Name = "BtnItemsUpdate"
        Me.BtnItemsUpdate.Size = New System.Drawing.Size(192, 23)
        Me.BtnItemsUpdate.TabIndex = 4
        Me.BtnItemsUpdate.Text = "Õ›‹Ÿ «· ⁄‹œÌ‹·"
        Me.BtnItemsUpdate.UseVisualStyleBackColor = True
        '
        'TxtItemName
        '
        Me.TxtItemName.Location = New System.Drawing.Point(75, 47)
        Me.TxtItemName.MaxLength = 50
        Me.TxtItemName.Name = "TxtItemName"
        Me.TxtItemName.Size = New System.Drawing.Size(192, 20)
        Me.TxtItemName.TabIndex = 3
        Me.TxtItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GBBills
        '
        Me.GBBills.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GBBills.Controls.Add(Me.BtnBillContainEditor)
        Me.GBBills.Controls.Add(Me.DTPBill)
        Me.GBBills.Controls.Add(Me.Label16)
        Me.GBBills.Controls.Add(Me.Label17)
        Me.GBBills.Controls.Add(Me.Label15)
        Me.GBBills.Controls.Add(Me.TxtBillID)
        Me.GBBills.Controls.Add(Me.TxtBillName)
        Me.GBBills.Controls.Add(Me.Label1)
        Me.GBBills.Controls.Add(Me.BtnBillUpdate)
        Me.GBBills.Controls.Add(Me.BtnDelEmptyBill)
        Me.GBBills.Controls.Add(Me.BtnDelBill)
        Me.GBBills.Controls.Add(Me.CBEmptyBills)
        Me.GBBills.Controls.Add(Me.CBBills)
        Me.GBBills.Enabled = False
        Me.GBBills.Location = New System.Drawing.Point(16, 21)
        Me.GBBills.Name = "GBBills"
        Me.GBBills.Size = New System.Drawing.Size(447, 205)
        Me.GBBills.TabIndex = 30
        Me.GBBills.TabStop = False
        Me.GBBills.Text = "  - «·›‹Ê« Ì‹‹— -  "
        '
        'BtnBillContainEditor
        '
        Me.BtnBillContainEditor.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnBillContainEditor.Location = New System.Drawing.Point(19, 134)
        Me.BtnBillContainEditor.Name = "BtnBillContainEditor"
        Me.BtnBillContainEditor.Size = New System.Drawing.Size(94, 23)
        Me.BtnBillContainEditor.TabIndex = 36
        Me.BtnBillContainEditor.Text = " ⁄‹œÌ· «·„Õ ÊÏ"
        Me.BtnBillContainEditor.UseVisualStyleBackColor = True
        '
        'DTPBill
        '
        Me.DTPBill.CustomFormat = "dd/MM/yyyy"
        Me.DTPBill.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPBill.Location = New System.Drawing.Point(119, 82)
        Me.DTPBill.Name = "DTPBill"
        Me.DTPBill.Size = New System.Drawing.Size(209, 20)
        Me.DTPBill.TabIndex = 33
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(360, 86)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(44, 13)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "«· ‹‹«—Ì‹Œ"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(342, 111)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(62, 13)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "—ﬁ‹„ «·›« Ê—Â"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(362, 59)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(42, 13)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "«·«”‹‹„"
        '
        'TxtBillID
        '
        Me.TxtBillID.Location = New System.Drawing.Point(119, 108)
        Me.TxtBillID.MaxLength = 50
        Me.TxtBillID.Name = "TxtBillID"
        Me.TxtBillID.Size = New System.Drawing.Size(209, 20)
        Me.TxtBillID.TabIndex = 34
        Me.TxtBillID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtBillName
        '
        Me.TxtBillName.Location = New System.Drawing.Point(119, 56)
        Me.TxtBillName.MaxLength = 50
        Me.TxtBillName.Name = "TxtBillName"
        Me.TxtBillName.Size = New System.Drawing.Size(209, 20)
        Me.TxtBillName.TabIndex = 32
        Me.TxtBillName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(334, 181)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "›Ê« Ì‹‹— Œ«·Ì‹‹Â"
        '
        'BtnBillUpdate
        '
        Me.BtnBillUpdate.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnBillUpdate.Location = New System.Drawing.Point(119, 134)
        Me.BtnBillUpdate.Name = "BtnBillUpdate"
        Me.BtnBillUpdate.Size = New System.Drawing.Size(209, 23)
        Me.BtnBillUpdate.TabIndex = 35
        Me.BtnBillUpdate.Text = "Õ›‹Ÿ «· ⁄‹œÌ‹·"
        Me.BtnBillUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelEmptyBill
        '
        Me.BtnDelEmptyBill.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnDelEmptyBill.Location = New System.Drawing.Point(15, 176)
        Me.BtnDelEmptyBill.Name = "BtnDelEmptyBill"
        Me.BtnDelEmptyBill.Size = New System.Drawing.Size(98, 23)
        Me.BtnDelEmptyBill.TabIndex = 38
        Me.BtnDelEmptyBill.Text = "Õ‹‹‹–›"
        Me.BtnDelEmptyBill.UseVisualStyleBackColor = True
        '
        'BtnDelBill
        '
        Me.BtnDelBill.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnDelBill.Location = New System.Drawing.Point(334, 27)
        Me.BtnDelBill.Name = "BtnDelBill"
        Me.BtnDelBill.Size = New System.Drawing.Size(98, 23)
        Me.BtnDelBill.TabIndex = 31
        Me.BtnDelBill.Text = "Õ‹‹‹–›"
        Me.BtnDelBill.UseVisualStyleBackColor = True
        '
        'CBEmptyBills
        '
        Me.CBEmptyBills.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBEmptyBills.FormattingEnabled = True
        Me.CBEmptyBills.Location = New System.Drawing.Point(119, 178)
        Me.CBEmptyBills.Name = "CBEmptyBills"
        Me.CBEmptyBills.Size = New System.Drawing.Size(209, 21)
        Me.CBEmptyBills.TabIndex = 37
        '
        'CBBills
        '
        Me.CBBills.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBills.FormattingEnabled = True
        Me.CBBills.Location = New System.Drawing.Point(15, 29)
        Me.CBBills.Name = "CBBills"
        Me.CBBills.Size = New System.Drawing.Size(313, 21)
        Me.CBBills.TabIndex = 30
        '
        'GBAdds
        '
        Me.GBAdds.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GBAdds.Controls.Add(Me.BtnAddContainEditor)
        Me.GBAdds.Controls.Add(Me.BtnAddUpdate)
        Me.GBAdds.Controls.Add(Me.DTPAdds)
        Me.GBAdds.Controls.Add(Me.Label12)
        Me.GBAdds.Controls.Add(Me.Label11)
        Me.GBAdds.Controls.Add(Me.BtnDelAdd)
        Me.GBAdds.Controls.Add(Me.CBAddSups)
        Me.GBAdds.Controls.Add(Me.CBAdds)
        Me.GBAdds.Enabled = False
        Me.GBAdds.Location = New System.Drawing.Point(16, 77)
        Me.GBAdds.Name = "GBAdds"
        Me.GBAdds.Size = New System.Drawing.Size(447, 145)
        Me.GBAdds.TabIndex = 19
        Me.GBAdds.TabStop = False
        Me.GBAdds.Text = "  - œ›⁄‹‹‹‹‹«  «·„Ê—œÌ‰ -  "
        '
        'BtnAddContainEditor
        '
        Me.BtnAddContainEditor.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnAddContainEditor.Location = New System.Drawing.Point(8, 109)
        Me.BtnAddContainEditor.Name = "BtnAddContainEditor"
        Me.BtnAddContainEditor.Size = New System.Drawing.Size(94, 23)
        Me.BtnAddContainEditor.TabIndex = 24
        Me.BtnAddContainEditor.Text = " ⁄‹œÌ· «·„Õ ÊÏ"
        Me.BtnAddContainEditor.UseVisualStyleBackColor = True
        '
        'BtnAddUpdate
        '
        Me.BtnAddUpdate.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnAddUpdate.Location = New System.Drawing.Point(108, 109)
        Me.BtnAddUpdate.Name = "BtnAddUpdate"
        Me.BtnAddUpdate.Size = New System.Drawing.Size(220, 23)
        Me.BtnAddUpdate.TabIndex = 23
        Me.BtnAddUpdate.Text = "Õ›‹Ÿ «· ⁄‹œÌ‹·"
        Me.BtnAddUpdate.UseVisualStyleBackColor = True
        '
        'DTPAdds
        '
        Me.DTPAdds.CustomFormat = "dd/MM/yyyy"
        Me.DTPAdds.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPAdds.Location = New System.Drawing.Point(108, 83)
        Me.DTPAdds.Name = "DTPAdds"
        Me.DTPAdds.Size = New System.Drawing.Size(220, 20)
        Me.DTPAdds.TabIndex = 22
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(388, 87)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "«· ‹‹«—Ì‹Œ"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(367, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "«”‹‹„ «·„Ê—œ"
        '
        'BtnDelAdd
        '
        Me.BtnDelAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnDelAdd.Location = New System.Drawing.Point(334, 27)
        Me.BtnDelAdd.Name = "BtnDelAdd"
        Me.BtnDelAdd.Size = New System.Drawing.Size(98, 23)
        Me.BtnDelAdd.TabIndex = 20
        Me.BtnDelAdd.Text = "Õ‹‹‹–›"
        Me.BtnDelAdd.UseVisualStyleBackColor = True
        '
        'CBAddSups
        '
        Me.CBAddSups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBAddSups.FormattingEnabled = True
        Me.CBAddSups.Location = New System.Drawing.Point(108, 56)
        Me.CBAddSups.Name = "CBAddSups"
        Me.CBAddSups.Size = New System.Drawing.Size(220, 21)
        Me.CBAddSups.TabIndex = 21
        '
        'CBAdds
        '
        Me.CBAdds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBAdds.FormattingEnabled = True
        Me.CBAdds.Location = New System.Drawing.Point(15, 29)
        Me.CBAdds.Name = "CBAdds"
        Me.CBAdds.Size = New System.Drawing.Size(313, 21)
        Me.CBAdds.TabIndex = 19
        '
        'ChBItems
        '
        Me.ChBItems.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ChBItems.AutoSize = True
        Me.ChBItems.Location = New System.Drawing.Point(468, 117)
        Me.ChBItems.Name = "ChBItems"
        Me.ChBItems.Size = New System.Drawing.Size(57, 17)
        Me.ChBItems.TabIndex = 0
        Me.ChBItems.Text = "⁄‹‹—÷"
        Me.ChBItems.UseVisualStyleBackColor = True
        '
        'ChBBills
        '
        Me.ChBBills.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ChBBills.AutoSize = True
        Me.ChBBills.Location = New System.Drawing.Point(468, 37)
        Me.ChBBills.Name = "ChBBills"
        Me.ChBBills.Size = New System.Drawing.Size(57, 17)
        Me.ChBBills.TabIndex = 30
        Me.ChBBills.Text = "⁄‹‹—÷"
        Me.ChBBills.UseVisualStyleBackColor = True
        '
        'ChBAdds
        '
        Me.ChBAdds.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ChBAdds.AutoSize = True
        Me.ChBAdds.Location = New System.Drawing.Point(468, 89)
        Me.ChBAdds.Name = "ChBAdds"
        Me.ChBAdds.Size = New System.Drawing.Size(57, 17)
        Me.ChBAdds.TabIndex = 19
        Me.ChBAdds.Text = "⁄‹‹—÷"
        Me.ChBAdds.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Location = New System.Drawing.Point(481, 342)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 52
        Me.BtnClose.Text = "√€·«ﬁ"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'GBSup
        '
        Me.GBSup.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GBSup.Controls.Add(Me.Label5)
        Me.GBSup.Controls.Add(Me.Label3)
        Me.GBSup.Controls.Add(Me.Label9)
        Me.GBSup.Controls.Add(Me.Label2)
        Me.GBSup.Controls.Add(Me.BtnDelSup)
        Me.GBSup.Controls.Add(Me.BtnSupUpdate)
        Me.GBSup.Controls.Add(Me.TxtSupInfo)
        Me.GBSup.Controls.Add(Me.TxtSupPhone)
        Me.GBSup.Controls.Add(Me.TxtSupName)
        Me.GBSup.Controls.Add(Me.TxtSupAddress)
        Me.GBSup.Controls.Add(Me.CBSup)
        Me.GBSup.Enabled = False
        Me.GBSup.Location = New System.Drawing.Point(16, 11)
        Me.GBSup.Name = "GBSup"
        Me.GBSup.Size = New System.Drawing.Size(447, 223)
        Me.GBSup.TabIndex = 5
        Me.GBSup.TabStop = False
        Me.GBSup.Text = "  - «·„‹‹Ê—œÌ‰ -  "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(305, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "„·«ÕŸ‹« "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(307, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "«· ‹·Ì‹›Ê‰"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(315, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "«·«”‹‹„"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(315, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "«·⁄‹‰Ê«‰"
        '
        'BtnDelSup
        '
        Me.BtnDelSup.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnDelSup.Location = New System.Drawing.Point(273, 17)
        Me.BtnDelSup.Name = "BtnDelSup"
        Me.BtnDelSup.Size = New System.Drawing.Size(98, 23)
        Me.BtnDelSup.TabIndex = 6
        Me.BtnDelSup.Text = "Õ‹‹‹–›"
        Me.BtnDelSup.UseVisualStyleBackColor = True
        '
        'BtnSupUpdate
        '
        Me.BtnSupUpdate.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnSupUpdate.Enabled = False
        Me.BtnSupUpdate.Location = New System.Drawing.Point(75, 190)
        Me.BtnSupUpdate.Name = "BtnSupUpdate"
        Me.BtnSupUpdate.Size = New System.Drawing.Size(192, 23)
        Me.BtnSupUpdate.TabIndex = 11
        Me.BtnSupUpdate.Text = "Õ›‹Ÿ «· ⁄‹œÌ‹·"
        Me.BtnSupUpdate.UseVisualStyleBackColor = True
        '
        'TxtSupInfo
        '
        Me.TxtSupInfo.AcceptsReturn = True
        Me.TxtSupInfo.Location = New System.Drawing.Point(75, 124)
        Me.TxtSupInfo.MaxLength = 49
        Me.TxtSupInfo.Multiline = True
        Me.TxtSupInfo.Name = "TxtSupInfo"
        Me.TxtSupInfo.Size = New System.Drawing.Size(192, 60)
        Me.TxtSupInfo.TabIndex = 10
        Me.TxtSupInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtSupPhone
        '
        Me.TxtSupPhone.Location = New System.Drawing.Point(75, 98)
        Me.TxtSupPhone.MaxLength = 50
        Me.TxtSupPhone.Name = "TxtSupPhone"
        Me.TxtSupPhone.Size = New System.Drawing.Size(192, 20)
        Me.TxtSupPhone.TabIndex = 9
        Me.TxtSupPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtSupName
        '
        Me.TxtSupName.Location = New System.Drawing.Point(75, 46)
        Me.TxtSupName.MaxLength = 50
        Me.TxtSupName.Name = "TxtSupName"
        Me.TxtSupName.Size = New System.Drawing.Size(192, 20)
        Me.TxtSupName.TabIndex = 7
        Me.TxtSupName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtSupAddress
        '
        Me.TxtSupAddress.Location = New System.Drawing.Point(75, 72)
        Me.TxtSupAddress.MaxLength = 50
        Me.TxtSupAddress.Name = "TxtSupAddress"
        Me.TxtSupAddress.Size = New System.Drawing.Size(192, 20)
        Me.TxtSupAddress.TabIndex = 8
        Me.TxtSupAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CBSup
        '
        Me.CBSup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBSup.FormattingEnabled = True
        Me.CBSup.Location = New System.Drawing.Point(75, 19)
        Me.CBSup.Name = "CBSup"
        Me.CBSup.Size = New System.Drawing.Size(192, 21)
        Me.CBSup.TabIndex = 5
        '
        'ChBSup
        '
        Me.ChBSup.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ChBSup.AutoSize = True
        Me.ChBSup.Location = New System.Drawing.Point(468, 23)
        Me.ChBSup.Name = "ChBSup"
        Me.ChBSup.Size = New System.Drawing.Size(57, 17)
        Me.ChBSup.TabIndex = 5
        Me.ChBSup.Text = "⁄‹‹—÷"
        Me.ChBSup.UseVisualStyleBackColor = True
        '
        'GBSpends
        '
        Me.GBSpends.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GBSpends.Controls.Add(Me.Label24)
        Me.GBSpends.Controls.Add(Me.TxtSpendValue)
        Me.GBSpends.Controls.Add(Me.DTPSpend)
        Me.GBSpends.Controls.Add(Me.Label25)
        Me.GBSpends.Controls.Add(Me.Label26)
        Me.GBSpends.Controls.Add(Me.BtnSpendUpdate)
        Me.GBSpends.Controls.Add(Me.TxtSpendInfo)
        Me.GBSpends.Controls.Add(Me.BtnDelSpend)
        Me.GBSpends.Controls.Add(Me.CBSpends)
        Me.GBSpends.Enabled = False
        Me.GBSpends.Location = New System.Drawing.Point(16, 47)
        Me.GBSpends.Name = "GBSpends"
        Me.GBSpends.Size = New System.Drawing.Size(447, 205)
        Me.GBSpends.TabIndex = 46
        Me.GBSpends.TabStop = False
        Me.GBSpends.Text = "«·„’‹‹—Ê›‹‹« "
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(387, 78)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(45, 13)
        Me.Label24.TabIndex = 33
        Me.Label24.Text = "«·ﬁÌ„‹‹‹Â"
        '
        'TxtSpendValue
        '
        Me.TxtSpendValue.Location = New System.Drawing.Point(136, 75)
        Me.TxtSpendValue.MaxLength = 50
        Me.TxtSpendValue.Name = "TxtSpendValue"
        Me.TxtSpendValue.Size = New System.Drawing.Size(192, 20)
        Me.TxtSpendValue.TabIndex = 49
        Me.TxtSpendValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DTPSpend
        '
        Me.DTPSpend.CustomFormat = "dd/MM/yyyy"
        Me.DTPSpend.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPSpend.Location = New System.Drawing.Point(136, 49)
        Me.DTPSpend.Name = "DTPSpend"
        Me.DTPSpend.Size = New System.Drawing.Size(192, 20)
        Me.DTPSpend.TabIndex = 48
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(388, 53)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(44, 13)
        Me.Label25.TabIndex = 31
        Me.Label25.Text = "«· ‹‹«—Ì‹Œ"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(375, 101)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(57, 13)
        Me.Label26.TabIndex = 29
        Me.Label26.Text = "„·«ÕŸ‹‹‹« "
        '
        'BtnSpendUpdate
        '
        Me.BtnSpendUpdate.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnSpendUpdate.Location = New System.Drawing.Point(136, 170)
        Me.BtnSpendUpdate.Name = "BtnSpendUpdate"
        Me.BtnSpendUpdate.Size = New System.Drawing.Size(192, 23)
        Me.BtnSpendUpdate.TabIndex = 51
        Me.BtnSpendUpdate.Text = "Õ›‹Ÿ «· ⁄‹œÌ‹·"
        Me.BtnSpendUpdate.UseVisualStyleBackColor = True
        '
        'TxtSpendInfo
        '
        Me.TxtSpendInfo.AcceptsReturn = True
        Me.TxtSpendInfo.Location = New System.Drawing.Point(15, 101)
        Me.TxtSpendInfo.MaxLength = 99
        Me.TxtSpendInfo.Multiline = True
        Me.TxtSpendInfo.Name = "TxtSpendInfo"
        Me.TxtSpendInfo.Size = New System.Drawing.Size(313, 63)
        Me.TxtSpendInfo.TabIndex = 50
        Me.TxtSpendInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnDelSpend
        '
        Me.BtnDelSpend.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnDelSpend.Location = New System.Drawing.Point(334, 20)
        Me.BtnDelSpend.Name = "BtnDelSpend"
        Me.BtnDelSpend.Size = New System.Drawing.Size(98, 23)
        Me.BtnDelSpend.TabIndex = 47
        Me.BtnDelSpend.Text = "Õ‹‹‹–›"
        Me.BtnDelSpend.UseVisualStyleBackColor = True
        '
        'CBSpends
        '
        Me.CBSpends.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBSpends.FormattingEnabled = True
        Me.CBSpends.Location = New System.Drawing.Point(15, 22)
        Me.CBSpends.Name = "CBSpends"
        Me.CBSpends.Size = New System.Drawing.Size(313, 21)
        Me.CBSpends.TabIndex = 46
        '
        'ChBSpends
        '
        Me.ChBSpends.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ChBSpends.AutoSize = True
        Me.ChBSpends.Location = New System.Drawing.Point(468, 57)
        Me.ChBSpends.Name = "ChBSpends"
        Me.ChBSpends.Size = New System.Drawing.Size(57, 17)
        Me.ChBSpends.TabIndex = 46
        Me.ChBSpends.Text = "⁄‹‹—÷"
        Me.ChBSpends.UseVisualStyleBackColor = True
        '
        'TabControlEditor
        '
        Me.TabControlEditor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControlEditor.Controls.Add(Me.TabPageItems)
        Me.TabControlEditor.Controls.Add(Me.TabPageSups)
        Me.TabControlEditor.Controls.Add(Me.TabPageEmps)
        Me.TabControlEditor.Controls.Add(Me.TabPageAdds)
        Me.TabControlEditor.Controls.Add(Me.TabPageReturners)
        Me.TabControlEditor.Controls.Add(Me.TabPageBills)
        Me.TabControlEditor.Controls.Add(Me.TabPageMaintenances)
        Me.TabControlEditor.Controls.Add(Me.TabPageSpends)
        Me.TabControlEditor.Location = New System.Drawing.Point(12, 12)
        Me.TabControlEditor.Name = "TabControlEditor"
        Me.TabControlEditor.SelectedIndex = 0
        Me.TabControlEditor.Size = New System.Drawing.Size(548, 324)
        Me.TabControlEditor.TabIndex = 0
        '
        'TabPageItems
        '
        Me.TabPageItems.Controls.Add(Me.TextBox4)
        Me.TabPageItems.Controls.Add(Me.Label27)
        Me.TabPageItems.Controls.Add(Me.GBItems)
        Me.TabPageItems.Controls.Add(Me.ChBItems)
        Me.TabPageItems.Location = New System.Drawing.Point(4, 22)
        Me.TabPageItems.Name = "TabPageItems"
        Me.TabPageItems.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageItems.Size = New System.Drawing.Size(540, 298)
        Me.TabPageItems.TabIndex = 0
        Me.TabPageItems.Text = "  - «·«‰‹‹‹Ê«⁄ -  "
        Me.TabPageItems.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TextBox4.BackColor = System.Drawing.Color.Brown
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox4.ForeColor = System.Drawing.Color.White
        Me.TextBox4.Location = New System.Drawing.Point(34, 252)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(406, 40)
        Me.TextBox4.TabIndex = 25
        Me.TextBox4.TabStop = False
        Me.TextBox4.Text = "⁄·„« »√‰ «–«  „ Õ–› ‰Ê⁄ ”Ì „ Õ–› Â–« «·‰Ê⁄ „‰ ﬂ· «·œ›⁄«  Êﬂ· «·›Ê« Ì—"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label27
        '
        Me.Label27.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label27.BackColor = System.Drawing.Color.Brown
        Me.Label27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(441, 237)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(65, 18)
        Me.Label27.TabIndex = 24
        Me.Label27.Text = " Õ“Ì‹‹—"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TabPageSups
        '
        Me.TabPageSups.Controls.Add(Me.TextBox1)
        Me.TabPageSups.Controls.Add(Me.Label14)
        Me.TabPageSups.Controls.Add(Me.GBSup)
        Me.TabPageSups.Controls.Add(Me.ChBSup)
        Me.TabPageSups.Location = New System.Drawing.Point(4, 22)
        Me.TabPageSups.Name = "TabPageSups"
        Me.TabPageSups.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageSups.Size = New System.Drawing.Size(540, 298)
        Me.TabPageSups.TabIndex = 1
        Me.TabPageSups.Text = "  - «·„‹‹Ê—œÌ‰ -  "
        Me.TabPageSups.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TextBox1.BackColor = System.Drawing.Color.Brown
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(34, 252)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(406, 40)
        Me.TextBox1.TabIndex = 23
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "⁄·„« »√‰ «–«  „ Õ–› «·„Ê—œ ”Ì „ Õ–› Ã„Ì⁄ «·œ›⁄«  «·”«»ﬁÂ Ê Ã„Ì⁄ «·«‰Ê«⁄ «·„ÊÃÊœÂ " & _
            "œ«Œ· Â–Â «·œ›⁄«  ÊÃ„Ì⁄ «·›Ê« Ì— «·„ÊÃÊœ »Â« Â–Â «·«‰Ê«⁄"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label14.BackColor = System.Drawing.Color.Brown
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(441, 237)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 18)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = " Õ“Ì‹‹—"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TabPageEmps
        '
        Me.TabPageEmps.Controls.Add(Me.TextBox5)
        Me.TabPageEmps.Controls.Add(Me.Label28)
        Me.TabPageEmps.Controls.Add(Me.GBEmps)
        Me.TabPageEmps.Controls.Add(Me.ChBEmps)
        Me.TabPageEmps.Location = New System.Drawing.Point(4, 22)
        Me.TabPageEmps.Name = "TabPageEmps"
        Me.TabPageEmps.Size = New System.Drawing.Size(540, 298)
        Me.TabPageEmps.TabIndex = 6
        Me.TabPageEmps.Text = "  - «·„Â‰‹‹œ”Ì‰ -  "
        Me.TabPageEmps.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TextBox5.BackColor = System.Drawing.Color.Brown
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox5.ForeColor = System.Drawing.Color.White
        Me.TextBox5.Location = New System.Drawing.Point(34, 255)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(406, 40)
        Me.TextBox5.TabIndex = 27
        Me.TextBox5.TabStop = False
        Me.TextBox5.Text = "⁄·„« »√‰ «–«  „ Õ–› „Â‰œ” ”Ì „ Õ–› Ã„Ì⁄ «·’Ì«‰«  «·Œ«’Â »Â"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label28
        '
        Me.Label28.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label28.BackColor = System.Drawing.Color.Brown
        Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(441, 240)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(65, 18)
        Me.Label28.TabIndex = 26
        Me.Label28.Text = " Õ“Ì‹‹—"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GBEmps
        '
        Me.GBEmps.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GBEmps.Controls.Add(Me.Label6)
        Me.GBEmps.Controls.Add(Me.Label7)
        Me.GBEmps.Controls.Add(Me.Label8)
        Me.GBEmps.Controls.Add(Me.Label10)
        Me.GBEmps.Controls.Add(Me.BtnDelEmp)
        Me.GBEmps.Controls.Add(Me.BtnEmpUpdate)
        Me.GBEmps.Controls.Add(Me.TxtEmpSalary)
        Me.GBEmps.Controls.Add(Me.TxtEmpPhone)
        Me.GBEmps.Controls.Add(Me.TxtEmpName)
        Me.GBEmps.Controls.Add(Me.TxtEmpAddress)
        Me.GBEmps.Controls.Add(Me.CBEmps)
        Me.GBEmps.Enabled = False
        Me.GBEmps.Location = New System.Drawing.Point(16, 54)
        Me.GBEmps.Name = "GBEmps"
        Me.GBEmps.Size = New System.Drawing.Size(447, 182)
        Me.GBEmps.TabIndex = 12
        Me.GBEmps.TabStop = False
        Me.GBEmps.Text = "  - «·„‹‹Ê—œÌ‰ -  "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(315, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "«·„— ‹»"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(307, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "«· ‹·Ì‹›Ê‰"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(315, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "«·«”‹‹„"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(315, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "«·⁄‹‰Ê«‰"
        '
        'BtnDelEmp
        '
        Me.BtnDelEmp.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnDelEmp.Location = New System.Drawing.Point(273, 17)
        Me.BtnDelEmp.Name = "BtnDelEmp"
        Me.BtnDelEmp.Size = New System.Drawing.Size(98, 23)
        Me.BtnDelEmp.TabIndex = 13
        Me.BtnDelEmp.Text = "Õ‹‹‹–›"
        Me.BtnDelEmp.UseVisualStyleBackColor = True
        '
        'BtnEmpUpdate
        '
        Me.BtnEmpUpdate.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnEmpUpdate.Location = New System.Drawing.Point(75, 150)
        Me.BtnEmpUpdate.Name = "BtnEmpUpdate"
        Me.BtnEmpUpdate.Size = New System.Drawing.Size(192, 23)
        Me.BtnEmpUpdate.TabIndex = 18
        Me.BtnEmpUpdate.Text = "Õ›‹Ÿ «· ⁄‹œÌ‹·"
        Me.BtnEmpUpdate.UseVisualStyleBackColor = True
        '
        'TxtEmpSalary
        '
        Me.TxtEmpSalary.Location = New System.Drawing.Point(75, 124)
        Me.TxtEmpSalary.MaxLength = 50
        Me.TxtEmpSalary.Name = "TxtEmpSalary"
        Me.TxtEmpSalary.Size = New System.Drawing.Size(192, 20)
        Me.TxtEmpSalary.TabIndex = 17
        Me.TxtEmpSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtEmpPhone
        '
        Me.TxtEmpPhone.Location = New System.Drawing.Point(75, 98)
        Me.TxtEmpPhone.MaxLength = 50
        Me.TxtEmpPhone.Name = "TxtEmpPhone"
        Me.TxtEmpPhone.Size = New System.Drawing.Size(192, 20)
        Me.TxtEmpPhone.TabIndex = 16
        Me.TxtEmpPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtEmpName
        '
        Me.TxtEmpName.Location = New System.Drawing.Point(75, 46)
        Me.TxtEmpName.MaxLength = 50
        Me.TxtEmpName.Name = "TxtEmpName"
        Me.TxtEmpName.Size = New System.Drawing.Size(192, 20)
        Me.TxtEmpName.TabIndex = 14
        Me.TxtEmpName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtEmpAddress
        '
        Me.TxtEmpAddress.Location = New System.Drawing.Point(75, 72)
        Me.TxtEmpAddress.MaxLength = 50
        Me.TxtEmpAddress.Name = "TxtEmpAddress"
        Me.TxtEmpAddress.Size = New System.Drawing.Size(192, 20)
        Me.TxtEmpAddress.TabIndex = 15
        Me.TxtEmpAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CBEmps
        '
        Me.CBEmps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBEmps.FormattingEnabled = True
        Me.CBEmps.Location = New System.Drawing.Point(75, 19)
        Me.CBEmps.Name = "CBEmps"
        Me.CBEmps.Size = New System.Drawing.Size(192, 21)
        Me.CBEmps.TabIndex = 12
        '
        'ChBEmps
        '
        Me.ChBEmps.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ChBEmps.AutoSize = True
        Me.ChBEmps.Location = New System.Drawing.Point(468, 66)
        Me.ChBEmps.Name = "ChBEmps"
        Me.ChBEmps.Size = New System.Drawing.Size(57, 17)
        Me.ChBEmps.TabIndex = 12
        Me.ChBEmps.Text = "⁄‹‹—÷"
        Me.ChBEmps.UseVisualStyleBackColor = True
        '
        'TabPageAdds
        '
        Me.TabPageAdds.Controls.Add(Me.TxtWarning)
        Me.TabPageAdds.Controls.Add(Me.GBAdds)
        Me.TabPageAdds.Controls.Add(Me.ChBAdds)
        Me.TabPageAdds.Controls.Add(Me.Label13)
        Me.TabPageAdds.Location = New System.Drawing.Point(4, 22)
        Me.TabPageAdds.Name = "TabPageAdds"
        Me.TabPageAdds.Size = New System.Drawing.Size(540, 298)
        Me.TabPageAdds.TabIndex = 3
        Me.TabPageAdds.Text = "  - œ›⁄‹‹‹‹‹«  «·„Ê—œÌ‰ -  "
        Me.TabPageAdds.UseVisualStyleBackColor = True
        '
        'TxtWarning
        '
        Me.TxtWarning.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TxtWarning.BackColor = System.Drawing.Color.Brown
        Me.TxtWarning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtWarning.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.TxtWarning.ForeColor = System.Drawing.Color.White
        Me.TxtWarning.Location = New System.Drawing.Point(34, 251)
        Me.TxtWarning.Multiline = True
        Me.TxtWarning.Name = "TxtWarning"
        Me.TxtWarning.ReadOnly = True
        Me.TxtWarning.Size = New System.Drawing.Size(406, 40)
        Me.TxtWarning.TabIndex = 21
        Me.TxtWarning.TabStop = False
        Me.TxtWarning.Text = "⁄·„« »√‰ «–«  „ Õ–› œ›⁄Â ”Ì „ Õ–› Ã„Ì⁄ «·«‰Ê«⁄ «·„÷«›Â ⁄‰ ÿ—Ìﬁ Â–Â «·œ›⁄Â ”Ê«¡  „" & _
            " »Ì⁄Â« «Ê ·„ Ì „"
        Me.TxtWarning.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label13.BackColor = System.Drawing.Color.Brown
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(441, 236)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 18)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = " Õ“Ì‹‹—"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TabPageReturners
        '
        Me.TabPageReturners.Controls.Add(Me.TextBox6)
        Me.TabPageReturners.Controls.Add(Me.Label29)
        Me.TabPageReturners.Controls.Add(Me.GBReturners)
        Me.TabPageReturners.Controls.Add(Me.ChBReturners)
        Me.TabPageReturners.Location = New System.Drawing.Point(4, 22)
        Me.TabPageReturners.Name = "TabPageReturners"
        Me.TabPageReturners.Size = New System.Drawing.Size(540, 298)
        Me.TabPageReturners.TabIndex = 7
        Me.TabPageReturners.Text = "  - «·„— Ã⁄‹‹‹«  -  "
        Me.TabPageReturners.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TextBox6.BackColor = System.Drawing.Color.Brown
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox6.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox6.ForeColor = System.Drawing.Color.White
        Me.TextBox6.Location = New System.Drawing.Point(34, 255)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(406, 40)
        Me.TextBox6.TabIndex = 27
        Me.TextBox6.TabStop = False
        Me.TextBox6.Text = "⁄·„« »√‰ «–«  „ Õ–› „— Ã⁄ ”Ì „ Õ–›Â „‰ √Ì ›« Ê—Â Ê ”ÌŸÂ— „‰ ÃœÌœ ﬂ„‰ Ã ·„ Ì „ »Ì⁄" & _
            "Â"
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label29
        '
        Me.Label29.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label29.BackColor = System.Drawing.Color.Brown
        Me.Label29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(441, 240)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(65, 18)
        Me.Label29.TabIndex = 26
        Me.Label29.Text = " Õ“Ì‹‹—"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GBReturners
        '
        Me.GBReturners.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GBReturners.Controls.Add(Me.DTPRet)
        Me.GBReturners.Controls.Add(Me.Label19)
        Me.GBReturners.Controls.Add(Me.BtnRetDel)
        Me.GBReturners.Controls.Add(Me.Label18)
        Me.GBReturners.Controls.Add(Me.CBReturners)
        Me.GBReturners.Controls.Add(Me.BtnRetUpdate)
        Me.GBReturners.Controls.Add(Me.TxtRetInfo)
        Me.GBReturners.Enabled = False
        Me.GBReturners.Location = New System.Drawing.Point(15, 28)
        Me.GBReturners.Name = "GBReturners"
        Me.GBReturners.Size = New System.Drawing.Size(447, 194)
        Me.GBReturners.TabIndex = 25
        Me.GBReturners.TabStop = False
        Me.GBReturners.Text = "  - «·«‰‹‹‹Ê«⁄ -  "
        '
        'DTPRet
        '
        Me.DTPRet.CustomFormat = "dd/MM/yyyy"
        Me.DTPRet.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPRet.Location = New System.Drawing.Point(75, 45)
        Me.DTPRet.Name = "DTPRet"
        Me.DTPRet.Size = New System.Drawing.Size(192, 20)
        Me.DTPRet.TabIndex = 27
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(327, 49)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(44, 13)
        Me.Label19.TabIndex = 21
        Me.Label19.Text = "«· ‹‹«—Ì‹Œ"
        '
        'BtnRetDel
        '
        Me.BtnRetDel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnRetDel.Location = New System.Drawing.Point(273, 16)
        Me.BtnRetDel.Name = "BtnRetDel"
        Me.BtnRetDel.Size = New System.Drawing.Size(98, 23)
        Me.BtnRetDel.TabIndex = 26
        Me.BtnRetDel.Text = "Õ‹‹‹–›"
        Me.BtnRetDel.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(317, 74)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(54, 13)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "„·«ÕŸ‹‹« "
        '
        'CBReturners
        '
        Me.CBReturners.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBReturners.FormattingEnabled = True
        Me.CBReturners.Location = New System.Drawing.Point(75, 18)
        Me.CBReturners.Name = "CBReturners"
        Me.CBReturners.Size = New System.Drawing.Size(192, 21)
        Me.CBReturners.TabIndex = 25
        '
        'BtnRetUpdate
        '
        Me.BtnRetUpdate.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnRetUpdate.Location = New System.Drawing.Point(75, 160)
        Me.BtnRetUpdate.Name = "BtnRetUpdate"
        Me.BtnRetUpdate.Size = New System.Drawing.Size(192, 23)
        Me.BtnRetUpdate.TabIndex = 29
        Me.BtnRetUpdate.Text = "Õ›‹Ÿ «· ⁄‹œÌ‹·"
        Me.BtnRetUpdate.UseVisualStyleBackColor = True
        '
        'TxtRetInfo
        '
        Me.TxtRetInfo.AcceptsReturn = True
        Me.TxtRetInfo.Location = New System.Drawing.Point(75, 71)
        Me.TxtRetInfo.MaxLength = 49
        Me.TxtRetInfo.Multiline = True
        Me.TxtRetInfo.Name = "TxtRetInfo"
        Me.TxtRetInfo.Size = New System.Drawing.Size(192, 83)
        Me.TxtRetInfo.TabIndex = 28
        Me.TxtRetInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ChBReturners
        '
        Me.ChBReturners.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ChBReturners.AutoSize = True
        Me.ChBReturners.Location = New System.Drawing.Point(468, 45)
        Me.ChBReturners.Name = "ChBReturners"
        Me.ChBReturners.Size = New System.Drawing.Size(57, 17)
        Me.ChBReturners.TabIndex = 25
        Me.ChBReturners.Text = "⁄‹‹—÷"
        Me.ChBReturners.UseVisualStyleBackColor = True
        '
        'TabPageBills
        '
        Me.TabPageBills.Controls.Add(Me.TextBox7)
        Me.TabPageBills.Controls.Add(Me.Label30)
        Me.TabPageBills.Controls.Add(Me.GBBills)
        Me.TabPageBills.Controls.Add(Me.ChBBills)
        Me.TabPageBills.Location = New System.Drawing.Point(4, 22)
        Me.TabPageBills.Name = "TabPageBills"
        Me.TabPageBills.Size = New System.Drawing.Size(540, 298)
        Me.TabPageBills.TabIndex = 4
        Me.TabPageBills.Text = "  - «·›‹Ê« Ì‹‹— -  "
        Me.TabPageBills.UseVisualStyleBackColor = True
        '
        'TextBox7
        '
        Me.TextBox7.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TextBox7.BackColor = System.Drawing.Color.Brown
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox7.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox7.ForeColor = System.Drawing.Color.White
        Me.TextBox7.Location = New System.Drawing.Point(35, 255)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(406, 40)
        Me.TextBox7.TabIndex = 32
        Me.TextBox7.TabStop = False
        Me.TextBox7.Text = "⁄·„« »√‰ «–«  „ Õ–› ›« Ê—Â ”Ì „ »«· «·Ì Õ–› Ã„Ì⁄ «·«‰Ê«⁄ «·„ÊÃÊœÂ œ«Œ· Â–Â «·›« Ê" & _
            "—Â"
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label30
        '
        Me.Label30.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label30.BackColor = System.Drawing.Color.Brown
        Me.Label30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.White
        Me.Label30.Location = New System.Drawing.Point(442, 240)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(65, 18)
        Me.Label30.TabIndex = 31
        Me.Label30.Text = " Õ“Ì‹‹—"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TabPageMaintenances
        '
        Me.TabPageMaintenances.Controls.Add(Me.GBMaint)
        Me.TabPageMaintenances.Controls.Add(Me.ChbMaint)
        Me.TabPageMaintenances.Location = New System.Drawing.Point(4, 22)
        Me.TabPageMaintenances.Name = "TabPageMaintenances"
        Me.TabPageMaintenances.Size = New System.Drawing.Size(540, 298)
        Me.TabPageMaintenances.TabIndex = 8
        Me.TabPageMaintenances.Text = "  - «·’Ì‹‹‹«‰‹«  -  "
        Me.TabPageMaintenances.UseVisualStyleBackColor = True
        '
        'GBMaint
        '
        Me.GBMaint.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GBMaint.Controls.Add(Me.Label23)
        Me.GBMaint.Controls.Add(Me.TxtMaintValue)
        Me.GBMaint.Controls.Add(Me.DTPMaint)
        Me.GBMaint.Controls.Add(Me.Label22)
        Me.GBMaint.Controls.Add(Me.Label20)
        Me.GBMaint.Controls.Add(Me.BtnMaintDel)
        Me.GBMaint.Controls.Add(Me.Label21)
        Me.GBMaint.Controls.Add(Me.CBMaintEmps)
        Me.GBMaint.Controls.Add(Me.CBMaints)
        Me.GBMaint.Controls.Add(Me.BtnMaintUpdate)
        Me.GBMaint.Controls.Add(Me.TxtMaintInfo)
        Me.GBMaint.Enabled = False
        Me.GBMaint.Location = New System.Drawing.Point(15, 37)
        Me.GBMaint.Name = "GBMaint"
        Me.GBMaint.Size = New System.Drawing.Size(447, 225)
        Me.GBMaint.TabIndex = 39
        Me.GBMaint.TabStop = False
        Me.GBMaint.Text = "  - «·«‰‹‹‹Ê«⁄ -  "
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(347, 101)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(45, 13)
        Me.Label23.TabIndex = 26
        Me.Label23.Text = "«·ﬁÌ„‹‹‹Â"
        '
        'TxtMaintValue
        '
        Me.TxtMaintValue.Location = New System.Drawing.Point(55, 98)
        Me.TxtMaintValue.MaxLength = 50
        Me.TxtMaintValue.Name = "TxtMaintValue"
        Me.TxtMaintValue.Size = New System.Drawing.Size(233, 20)
        Me.TxtMaintValue.TabIndex = 43
        Me.TxtMaintValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DTPMaint
        '
        Me.DTPMaint.CustomFormat = "dd/MM/yyyy"
        Me.DTPMaint.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPMaint.Location = New System.Drawing.Point(55, 72)
        Me.DTPMaint.Name = "DTPMaint"
        Me.DTPMaint.Size = New System.Drawing.Size(233, 20)
        Me.DTPMaint.TabIndex = 42
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(312, 53)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(80, 13)
        Me.Label22.TabIndex = 21
        Me.Label22.Text = "√”‹‹„ «·„Â‰œ”"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(348, 76)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(44, 13)
        Me.Label20.TabIndex = 21
        Me.Label20.Text = "«· ‹‹«—Ì‹Œ"
        '
        'BtnMaintDel
        '
        Me.BtnMaintDel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnMaintDel.Location = New System.Drawing.Point(294, 16)
        Me.BtnMaintDel.Name = "BtnMaintDel"
        Me.BtnMaintDel.Size = New System.Drawing.Size(98, 23)
        Me.BtnMaintDel.TabIndex = 40
        Me.BtnMaintDel.Text = "Õ‹‹‹–›"
        Me.BtnMaintDel.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(338, 124)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(54, 13)
        Me.Label21.TabIndex = 9
        Me.Label21.Text = "„·«ÕŸ‹‹« "
        '
        'CBMaintEmps
        '
        Me.CBMaintEmps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBMaintEmps.FormattingEnabled = True
        Me.CBMaintEmps.Location = New System.Drawing.Point(55, 45)
        Me.CBMaintEmps.Name = "CBMaintEmps"
        Me.CBMaintEmps.Size = New System.Drawing.Size(233, 21)
        Me.CBMaintEmps.TabIndex = 41
        '
        'CBMaints
        '
        Me.CBMaints.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBMaints.FormattingEnabled = True
        Me.CBMaints.Location = New System.Drawing.Point(55, 18)
        Me.CBMaints.Name = "CBMaints"
        Me.CBMaints.Size = New System.Drawing.Size(233, 21)
        Me.CBMaints.TabIndex = 39
        '
        'BtnMaintUpdate
        '
        Me.BtnMaintUpdate.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnMaintUpdate.Location = New System.Drawing.Point(96, 193)
        Me.BtnMaintUpdate.Name = "BtnMaintUpdate"
        Me.BtnMaintUpdate.Size = New System.Drawing.Size(192, 23)
        Me.BtnMaintUpdate.TabIndex = 45
        Me.BtnMaintUpdate.Text = "Õ›‹Ÿ «· ⁄‹œÌ‹·"
        Me.BtnMaintUpdate.UseVisualStyleBackColor = True
        '
        'TxtMaintInfo
        '
        Me.TxtMaintInfo.AcceptsReturn = True
        Me.TxtMaintInfo.Location = New System.Drawing.Point(55, 124)
        Me.TxtMaintInfo.MaxLength = 49
        Me.TxtMaintInfo.Multiline = True
        Me.TxtMaintInfo.Name = "TxtMaintInfo"
        Me.TxtMaintInfo.Size = New System.Drawing.Size(233, 63)
        Me.TxtMaintInfo.TabIndex = 44
        Me.TxtMaintInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ChbMaint
        '
        Me.ChbMaint.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ChbMaint.AutoSize = True
        Me.ChbMaint.Location = New System.Drawing.Point(468, 54)
        Me.ChbMaint.Name = "ChbMaint"
        Me.ChbMaint.Size = New System.Drawing.Size(57, 17)
        Me.ChbMaint.TabIndex = 39
        Me.ChbMaint.Text = "⁄‹‹—÷"
        Me.ChbMaint.UseVisualStyleBackColor = True
        '
        'TabPageSpends
        '
        Me.TabPageSpends.Controls.Add(Me.GBSpends)
        Me.TabPageSpends.Controls.Add(Me.ChBSpends)
        Me.TabPageSpends.Location = New System.Drawing.Point(4, 22)
        Me.TabPageSpends.Name = "TabPageSpends"
        Me.TabPageSpends.Size = New System.Drawing.Size(540, 298)
        Me.TabPageSpends.TabIndex = 5
        Me.TabPageSpends.Text = "  - «·„’‹‹—Ê›‹‹«  -  "
        Me.TabPageSpends.UseVisualStyleBackColor = True
        '
        'EditorFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(565, 370)
        Me.Controls.Add(Me.TabControlEditor)
        Me.Controls.Add(Me.BtnClose)
        Me.Name = "EditorFrm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Õ‹‹–› Ê ⁄‹‹œÌ·"
        Me.GBItems.ResumeLayout(False)
        Me.GBItems.PerformLayout()
        Me.GBBills.ResumeLayout(False)
        Me.GBBills.PerformLayout()
        Me.GBAdds.ResumeLayout(False)
        Me.GBAdds.PerformLayout()
        Me.GBSup.ResumeLayout(False)
        Me.GBSup.PerformLayout()
        Me.GBSpends.ResumeLayout(False)
        Me.GBSpends.PerformLayout()
        Me.TabControlEditor.ResumeLayout(False)
        Me.TabPageItems.ResumeLayout(False)
        Me.TabPageItems.PerformLayout()
        Me.TabPageSups.ResumeLayout(False)
        Me.TabPageSups.PerformLayout()
        Me.TabPageEmps.ResumeLayout(False)
        Me.TabPageEmps.PerformLayout()
        Me.GBEmps.ResumeLayout(False)
        Me.GBEmps.PerformLayout()
        Me.TabPageAdds.ResumeLayout(False)
        Me.TabPageAdds.PerformLayout()
        Me.TabPageReturners.ResumeLayout(False)
        Me.TabPageReturners.PerformLayout()
        Me.GBReturners.ResumeLayout(False)
        Me.GBReturners.PerformLayout()
        Me.TabPageBills.ResumeLayout(False)
        Me.TabPageBills.PerformLayout()
        Me.TabPageMaintenances.ResumeLayout(False)
        Me.TabPageMaintenances.PerformLayout()
        Me.GBMaint.ResumeLayout(False)
        Me.GBMaint.PerformLayout()
        Me.TabPageSpends.ResumeLayout(False)
        Me.TabPageSpends.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GBItems As System.Windows.Forms.GroupBox
    Friend WithEvents CBItems As System.Windows.Forms.ComboBox
    Friend WithEvents BtnDelItem As System.Windows.Forms.Button
    Friend WithEvents GBBills As System.Windows.Forms.GroupBox
    Friend WithEvents BtnDelBill As System.Windows.Forms.Button
    Friend WithEvents CBBills As System.Windows.Forms.ComboBox
    Friend WithEvents GBAdds As System.Windows.Forms.GroupBox
    Friend WithEvents BtnDelAdd As System.Windows.Forms.Button
    Friend WithEvents CBAdds As System.Windows.Forms.ComboBox
    Friend WithEvents ChBItems As System.Windows.Forms.CheckBox
    Friend WithEvents ChBBills As System.Windows.Forms.CheckBox
    Friend WithEvents ChBAdds As System.Windows.Forms.CheckBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents GBSup As System.Windows.Forms.GroupBox
    Friend WithEvents BtnDelSup As System.Windows.Forms.Button
    Friend WithEvents CBSup As System.Windows.Forms.ComboBox
    Friend WithEvents ChBSup As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtSupAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnSupUpdate As System.Windows.Forms.Button
    Friend WithEvents TxtSupPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnItemsUpdate As System.Windows.Forms.Button
    Friend WithEvents TxtItemName As System.Windows.Forms.TextBox
    Friend WithEvents GBSpends As System.Windows.Forms.GroupBox
    Friend WithEvents BtnDelSpend As System.Windows.Forms.Button
    Friend WithEvents CBSpends As System.Windows.Forms.ComboBox
    Friend WithEvents ChBSpends As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnDelEmptyBill As System.Windows.Forms.Button
    Friend WithEvents CBEmptyBills As System.Windows.Forms.ComboBox
    Friend WithEvents TabControlEditor As System.Windows.Forms.TabControl
    Friend WithEvents TabPageItems As System.Windows.Forms.TabPage
    Friend WithEvents TabPageSups As System.Windows.Forms.TabPage
    Friend WithEvents TabPageAdds As System.Windows.Forms.TabPage
    Friend WithEvents TabPageBills As System.Windows.Forms.TabPage
    Friend WithEvents TabPageSpends As System.Windows.Forms.TabPage
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtSupInfo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtSupName As System.Windows.Forms.TextBox
    Friend WithEvents TabPageEmps As System.Windows.Forms.TabPage
    Friend WithEvents GBEmps As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BtnDelEmp As System.Windows.Forms.Button
    Friend WithEvents BtnEmpUpdate As System.Windows.Forms.Button
    Friend WithEvents TxtEmpSalary As System.Windows.Forms.TextBox
    Friend WithEvents TxtEmpPhone As System.Windows.Forms.TextBox
    Friend WithEvents TxtEmpName As System.Windows.Forms.TextBox
    Friend WithEvents TxtEmpAddress As System.Windows.Forms.TextBox
    Friend WithEvents CBEmps As System.Windows.Forms.ComboBox
    Friend WithEvents ChBEmps As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CBAddSups As System.Windows.Forms.ComboBox
    Friend WithEvents BtnAddUpdate As System.Windows.Forms.Button
    Friend WithEvents DTPAdds As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtWarning As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents BtnAddContainEditor As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxtBillName As System.Windows.Forms.TextBox
    Friend WithEvents BtnBillContainEditor As System.Windows.Forms.Button
    Friend WithEvents DTPBill As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TxtBillID As System.Windows.Forms.TextBox
    Friend WithEvents BtnBillUpdate As System.Windows.Forms.Button
    Friend WithEvents TabPageReturners As System.Windows.Forms.TabPage
    Friend WithEvents TabPageMaintenances As System.Windows.Forms.TabPage
    Friend WithEvents GBReturners As System.Windows.Forms.GroupBox
    Friend WithEvents BtnRetDel As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents CBReturners As System.Windows.Forms.ComboBox
    Friend WithEvents BtnRetUpdate As System.Windows.Forms.Button
    Friend WithEvents TxtRetInfo As System.Windows.Forms.TextBox
    Friend WithEvents ChBReturners As System.Windows.Forms.CheckBox
    Friend WithEvents DTPRet As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents GBMaint As System.Windows.Forms.GroupBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TxtMaintValue As System.Windows.Forms.TextBox
    Friend WithEvents DTPMaint As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents BtnMaintDel As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents CBMaintEmps As System.Windows.Forms.ComboBox
    Friend WithEvents CBMaints As System.Windows.Forms.ComboBox
    Friend WithEvents BtnMaintUpdate As System.Windows.Forms.Button
    Friend WithEvents TxtMaintInfo As System.Windows.Forms.TextBox
    Friend WithEvents ChbMaint As System.Windows.Forms.CheckBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TxtSpendValue As System.Windows.Forms.TextBox
    Friend WithEvents DTPSpend As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents BtnSpendUpdate As System.Windows.Forms.Button
    Friend WithEvents TxtSpendInfo As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
End Class
