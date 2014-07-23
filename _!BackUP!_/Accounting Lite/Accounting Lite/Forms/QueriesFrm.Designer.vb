<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QueriesFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QueriesFrm))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.DGVItems = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtTotal = New System.Windows.Forms.TextBox
        Me.CBItemsSearch = New System.Windows.Forms.ComboBox
        Me.TxtItemSearch = New System.Windows.Forms.TextBox
        Me.BtnItemSearch = New System.Windows.Forms.Button
        Me.BtnAllItems = New System.Windows.Forms.Button
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.DGVBills = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DTPSearchBill = New System.Windows.Forms.DateTimePicker
        Me.CBBillsearch = New System.Windows.Forms.ComboBox
        Me.TxtSearchBill = New System.Windows.Forms.TextBox
        Me.BtnSearchBill = New System.Windows.Forms.Button
        Me.BtnBillSearchAll = New System.Windows.Forms.Button
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.PnlGainDate = New System.Windows.Forms.Panel
        Me.DTPEnd = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.DTPStart = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.CBGain = New System.Windows.Forms.CheckBox
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.Label17 = New System.Windows.Forms.Label
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.Label15 = New System.Windows.Forms.Label
        Me.TxtLastGain = New System.Windows.Forms.TextBox
        Me.TxtIncoming = New System.Windows.Forms.TextBox
        Me.TxtOutComing = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.btn2TypePrinting = New System.Windows.Forms.Button
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DGVItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DGVBills, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.PnlGainDate.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(603, 505)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DGVItems)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(595, 479)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "الاصنــاف"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DGVItems
        '
        Me.DGVItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DGVItems.Location = New System.Drawing.Point(4, 125)
        Me.DGVItems.Name = "DGVItems"
        Me.DGVItems.ReadOnly = True
        Me.DGVItems.Size = New System.Drawing.Size(586, 351)
        Me.DGVItems.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "TypeID"
        Me.Column1.HeaderText = "رقم الصنف"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "TypeName"
        Me.Column2.HeaderText = "أسم الصنف"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 120
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Information"
        Me.Column3.HeaderText = "معلومات"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 180
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "remaining"
        Me.Column4.HeaderText = "المتبقي في المخزن"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 140
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "Value"
        Me.Column5.HeaderText = "القيمه"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtTotal)
        Me.GroupBox1.Controls.Add(Me.CBItemsSearch)
        Me.GroupBox1.Controls.Add(Me.TxtItemSearch)
        Me.GroupBox1.Controls.Add(Me.BtnItemSearch)
        Me.GroupBox1.Controls.Add(Me.BtnAllItems)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(579, 113)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "  -  انواع البحث  -  "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(112, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "الاجمالـــي"
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(6, 79)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(100, 20)
        Me.TxtTotal.TabIndex = 3
        Me.TxtTotal.Text = "0"
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CBItemsSearch
        '
        Me.CBItemsSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBItemsSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBItemsSearch.FormattingEnabled = True
        Me.CBItemsSearch.Items.AddRange(New Object() {"الاسم", "معلومات"})
        Me.CBItemsSearch.Location = New System.Drawing.Point(327, 50)
        Me.CBItemsSearch.Name = "CBItemsSearch"
        Me.CBItemsSearch.Size = New System.Drawing.Size(142, 21)
        Me.CBItemsSearch.TabIndex = 2
        '
        'TxtItemSearch
        '
        Me.TxtItemSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtItemSearch.Location = New System.Drawing.Point(327, 79)
        Me.TxtItemSearch.Name = "TxtItemSearch"
        Me.TxtItemSearch.Size = New System.Drawing.Size(246, 20)
        Me.TxtItemSearch.TabIndex = 1
        '
        'BtnItemSearch
        '
        Me.BtnItemSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnItemSearch.Location = New System.Drawing.Point(475, 50)
        Me.BtnItemSearch.Name = "BtnItemSearch"
        Me.BtnItemSearch.Size = New System.Drawing.Size(98, 23)
        Me.BtnItemSearch.TabIndex = 0
        Me.BtnItemSearch.Text = "بحث عن "
        Me.BtnItemSearch.UseVisualStyleBackColor = True
        '
        'BtnAllItems
        '
        Me.BtnAllItems.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAllItems.Location = New System.Drawing.Point(475, 21)
        Me.BtnAllItems.Name = "BtnAllItems"
        Me.BtnAllItems.Size = New System.Drawing.Size(98, 23)
        Me.BtnAllItems.TabIndex = 0
        Me.BtnAllItems.Text = "جميع الاصناف"
        Me.BtnAllItems.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DGVBills)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(595, 479)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "الفواتيــر"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DGVBills
        '
        Me.DGVBills.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVBills.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.Column6, Me.DataGridViewTextBoxColumn5})
        Me.DGVBills.Location = New System.Drawing.Point(3, 125)
        Me.DGVBills.Name = "DGVBills"
        Me.DGVBills.ReadOnly = True
        Me.DGVBills.Size = New System.Drawing.Size(586, 351)
        Me.DGVBills.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "BillID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "رقم الفاتوره"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 90
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CusName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "أسم العميـــل"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "BillDate"
        Me.DataGridViewTextBoxColumn3.HeaderText = "التاريخ"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 80
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Information"
        Me.DataGridViewTextBoxColumn4.HeaderText = "معلومات"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 112
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "Discount"
        Me.Column6.HeaderText = "تخفيض"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 80
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "FalseX"
        Me.DataGridViewTextBoxColumn5.HeaderText = "القيمه"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 80
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.btn2TypePrinting)
        Me.GroupBox2.Controls.Add(Me.DTPSearchBill)
        Me.GroupBox2.Controls.Add(Me.CBBillsearch)
        Me.GroupBox2.Controls.Add(Me.TxtSearchBill)
        Me.GroupBox2.Controls.Add(Me.BtnSearchBill)
        Me.GroupBox2.Controls.Add(Me.BtnBillSearchAll)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(579, 113)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "  -  انواع البحث  -  "
        '
        'DTPSearchBill
        '
        Me.DTPSearchBill.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPSearchBill.Location = New System.Drawing.Point(327, 77)
        Me.DTPSearchBill.Name = "DTPSearchBill"
        Me.DTPSearchBill.Size = New System.Drawing.Size(142, 20)
        Me.DTPSearchBill.TabIndex = 3
        Me.DTPSearchBill.Visible = False
        '
        'CBBillsearch
        '
        Me.CBBillsearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBillsearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBillsearch.FormattingEnabled = True
        Me.CBBillsearch.Items.AddRange(New Object() {"رقم الفاتوره", "اسم العميل", "التاريخ", "معلومات"})
        Me.CBBillsearch.Location = New System.Drawing.Point(327, 50)
        Me.CBBillsearch.Name = "CBBillsearch"
        Me.CBBillsearch.Size = New System.Drawing.Size(142, 21)
        Me.CBBillsearch.TabIndex = 2
        '
        'TxtSearchBill
        '
        Me.TxtSearchBill.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSearchBill.Location = New System.Drawing.Point(327, 79)
        Me.TxtSearchBill.Name = "TxtSearchBill"
        Me.TxtSearchBill.Size = New System.Drawing.Size(246, 20)
        Me.TxtSearchBill.TabIndex = 1
        '
        'BtnSearchBill
        '
        Me.BtnSearchBill.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSearchBill.Location = New System.Drawing.Point(475, 50)
        Me.BtnSearchBill.Name = "BtnSearchBill"
        Me.BtnSearchBill.Size = New System.Drawing.Size(98, 23)
        Me.BtnSearchBill.TabIndex = 0
        Me.BtnSearchBill.Text = "بحث عن "
        Me.BtnSearchBill.UseVisualStyleBackColor = True
        '
        'BtnBillSearchAll
        '
        Me.BtnBillSearchAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBillSearchAll.Location = New System.Drawing.Point(475, 21)
        Me.BtnBillSearchAll.Name = "BtnBillSearchAll"
        Me.BtnBillSearchAll.Size = New System.Drawing.Size(98, 23)
        Me.BtnBillSearchAll.TabIndex = 0
        Me.BtnBillSearchAll.Text = "جميع الفواتيــر"
        Me.BtnBillSearchAll.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.PnlGainDate)
        Me.TabPage3.Controls.Add(Me.CBGain)
        Me.TabPage3.Controls.Add(Me.Panel10)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(595, 479)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "الاربـــاح"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'PnlGainDate
        '
        Me.PnlGainDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlGainDate.Controls.Add(Me.DTPEnd)
        Me.PnlGainDate.Controls.Add(Me.Label2)
        Me.PnlGainDate.Controls.Add(Me.DTPStart)
        Me.PnlGainDate.Controls.Add(Me.Label1)
        Me.PnlGainDate.Location = New System.Drawing.Point(51, 84)
        Me.PnlGainDate.Name = "PnlGainDate"
        Me.PnlGainDate.Size = New System.Drawing.Size(492, 38)
        Me.PnlGainDate.TabIndex = 19
        Me.PnlGainDate.Visible = False
        '
        'DTPEnd
        '
        Me.DTPEnd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DTPEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPEnd.Location = New System.Drawing.Point(5, 8)
        Me.DTPEnd.Name = "DTPEnd"
        Me.DTPEnd.Size = New System.Drawing.Size(200, 20)
        Me.DTPEnd.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(211, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "الـــي"
        '
        'DTPStart
        '
        Me.DTPStart.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DTPStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPStart.Location = New System.Drawing.Point(253, 8)
        Me.DTPStart.Name = "DTPStart"
        Me.DTPStart.Size = New System.Drawing.Size(200, 20)
        Me.DTPStart.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(459, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "مــن"
        '
        'CBGain
        '
        Me.CBGain.AutoSize = True
        Me.CBGain.Location = New System.Drawing.Point(466, 61)
        Me.CBGain.Name = "CBGain"
        Me.CBGain.Size = New System.Drawing.Size(77, 17)
        Me.CBGain.TabIndex = 17
        Me.CBGain.Text = "كل الوقـــت"
        Me.CBGain.UseVisualStyleBackColor = True
        '
        'Panel10
        '
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel10.Controls.Add(Me.Label17)
        Me.Panel10.Controls.Add(Me.Panel8)
        Me.Panel10.Controls.Add(Me.Panel7)
        Me.Panel10.Controls.Add(Me.Label15)
        Me.Panel10.Controls.Add(Me.TxtLastGain)
        Me.Panel10.Controls.Add(Me.TxtIncoming)
        Me.Panel10.Controls.Add(Me.TxtOutComing)
        Me.Panel10.Controls.Add(Me.Label16)
        Me.Panel10.Controls.Add(Me.Label18)
        Me.Panel10.Controls.Add(Me.Panel9)
        Me.Panel10.Controls.Add(Me.Label21)
        Me.Panel10.Controls.Add(Me.Label20)
        Me.Panel10.Controls.Add(Me.Label19)
        Me.Panel10.Controls.Add(Me.Panel6)
        Me.Panel10.Location = New System.Drawing.Point(51, 124)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(492, 325)
        Me.Panel10.TabIndex = 15
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Gainsboro
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(156, 107)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 24)
        Me.Label17.TabIndex = 11
        Me.Label17.Text = "-"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Location = New System.Drawing.Point(78, 224)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(167, 10)
        Me.Panel8.TabIndex = 13
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Location = New System.Drawing.Point(78, 114)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(95, 11)
        Me.Panel7.TabIndex = 13
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Blue
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(341, 83)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 23)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "الـدخــــــل"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtLastGain
        '
        Me.TxtLastGain.BackColor = System.Drawing.Color.Lime
        Me.TxtLastGain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtLastGain.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLastGain.ForeColor = System.Drawing.Color.Black
        Me.TxtLastGain.Location = New System.Drawing.Point(240, 217)
        Me.TxtLastGain.Name = "TxtLastGain"
        Me.TxtLastGain.ReadOnly = True
        Me.TxtLastGain.Size = New System.Drawing.Size(100, 23)
        Me.TxtLastGain.TabIndex = 10
        Me.TxtLastGain.Text = "0"
        Me.TxtLastGain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtIncoming
        '
        Me.TxtIncoming.BackColor = System.Drawing.Color.Lime
        Me.TxtIncoming.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIncoming.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIncoming.ForeColor = System.Drawing.Color.Black
        Me.TxtIncoming.Location = New System.Drawing.Point(240, 83)
        Me.TxtIncoming.Name = "TxtIncoming"
        Me.TxtIncoming.ReadOnly = True
        Me.TxtIncoming.Size = New System.Drawing.Size(100, 23)
        Me.TxtIncoming.TabIndex = 10
        Me.TxtIncoming.Text = "0"
        Me.TxtIncoming.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtOutComing
        '
        Me.TxtOutComing.BackColor = System.Drawing.Color.Lime
        Me.TxtOutComing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtOutComing.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOutComing.ForeColor = System.Drawing.Color.Black
        Me.TxtOutComing.Location = New System.Drawing.Point(240, 133)
        Me.TxtOutComing.Name = "TxtOutComing"
        Me.TxtOutComing.ReadOnly = True
        Me.TxtOutComing.Size = New System.Drawing.Size(100, 23)
        Me.TxtOutComing.TabIndex = 10
        Me.TxtOutComing.Text = "0"
        Me.TxtOutComing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Blue
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(341, 133)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 23)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "المصروفــات"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Blue
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(341, 217)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 23)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "الربـــح"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Location = New System.Drawing.Point(78, 121)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(10, 113)
        Me.Panel9.TabIndex = 13
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Silver
        Me.Label21.Location = New System.Drawing.Point(243, 221)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(175, 23)
        Me.Label21.TabIndex = 15
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Silver
        Me.Label20.Location = New System.Drawing.Point(243, 138)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(175, 23)
        Me.Label20.TabIndex = 15
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Silver
        Me.Label19.Location = New System.Drawing.Point(243, 87)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(175, 23)
        Me.Label19.TabIndex = 15
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Yellow
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Location = New System.Drawing.Point(187, 74)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(118, 175)
        Me.Panel6.TabIndex = 12
        '
        'btn2TypePrinting
        '
        Me.btn2TypePrinting.Location = New System.Drawing.Point(327, 19)
        Me.btn2TypePrinting.Name = "btn2TypePrinting"
        Me.btn2TypePrinting.Size = New System.Drawing.Size(142, 23)
        Me.btn2TypePrinting.TabIndex = 3
        Me.btn2TypePrinting.Text = "ترتيب حسب الاصناف"
        Me.btn2TypePrinting.UseVisualStyleBackColor = True
        '
        'QueriesFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 505)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "QueriesFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "الاستعــــــــلامات"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DGVItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DGVBills, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.PnlGainDate.ResumeLayout(False)
        Me.PnlGainDate.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtItemSearch As System.Windows.Forms.TextBox
    Friend WithEvents BtnItemSearch As System.Windows.Forms.Button
    Friend WithEvents BtnAllItems As System.Windows.Forms.Button
    Friend WithEvents CBItemsSearch As System.Windows.Forms.ComboBox
    Friend WithEvents DGVItems As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CBBillsearch As System.Windows.Forms.ComboBox
    Friend WithEvents TxtSearchBill As System.Windows.Forms.TextBox
    Friend WithEvents BtnSearchBill As System.Windows.Forms.Button
    Friend WithEvents BtnBillSearchAll As System.Windows.Forms.Button
    Friend WithEvents DTPSearchBill As System.Windows.Forms.DateTimePicker
    Friend WithEvents DGVBills As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxtLastGain As System.Windows.Forms.TextBox
    Friend WithEvents TxtIncoming As System.Windows.Forms.TextBox
    Friend WithEvents TxtOutComing As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents CBGain As System.Windows.Forms.CheckBox
    Friend WithEvents DTPStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PnlGainDate As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents btn2TypePrinting As System.Windows.Forms.Button
End Class
