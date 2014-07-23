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
        Me.CBCus = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.CBModName = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GB = New System.Windows.Forms.GroupBox
        Me.PnlSto = New System.Windows.Forms.Panel
        Me.LblCount = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.LBMob = New System.Windows.Forms.ListBox
        Me.BtnRemove = New System.Windows.Forms.Button
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.TxtCost = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtCount = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnClose = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.PNL = New System.Windows.Forms.Panel
        Me.TxtBillNumber = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GB.SuspendLayout()
        Me.PnlSto.SuspendLayout()
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
        'CBCus
        '
        Me.CBCus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCus.FormattingEnabled = True
        Me.CBCus.Location = New System.Drawing.Point(12, 7)
        Me.CBCus.Name = "CBCus"
        Me.CBCus.Size = New System.Drawing.Size(193, 21)
        Me.CBCus.TabIndex = 0
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
        'CBModName
        '
        Me.CBModName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBModName.FormattingEnabled = True
        Me.CBModName.Location = New System.Drawing.Point(5, 19)
        Me.CBModName.Name = "CBModName"
        Me.CBModName.Size = New System.Drawing.Size(170, 21)
        Me.CBModName.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(181, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "أسم المـوديـل"
        '
        'GB
        '
        Me.GB.Controls.Add(Me.PnlSto)
        Me.GB.Controls.Add(Me.LBMob)
        Me.GB.Controls.Add(Me.BtnRemove)
        Me.GB.Controls.Add(Me.BtnAdd)
        Me.GB.Controls.Add(Me.TxtCost)
        Me.GB.Controls.Add(Me.Label4)
        Me.GB.Controls.Add(Me.TxtCount)
        Me.GB.Controls.Add(Me.Label1)
        Me.GB.Controls.Add(Me.CBModName)
        Me.GB.Controls.Add(Me.Label2)
        Me.GB.Enabled = False
        Me.GB.Location = New System.Drawing.Point(10, 123)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(432, 164)
        Me.GB.TabIndex = 4
        Me.GB.TabStop = False
        Me.GB.Text = " - الموديـلات - "
        '
        'PnlSto
        '
        Me.PnlSto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlSto.Controls.Add(Me.LblCount)
        Me.PnlSto.Controls.Add(Me.Label7)
        Me.PnlSto.Location = New System.Drawing.Point(6, 128)
        Me.PnlSto.Name = "PnlSto"
        Me.PnlSto.Size = New System.Drawing.Size(102, 30)
        Me.PnlSto.TabIndex = 99
        Me.PnlSto.Visible = False
        '
        'LblCount
        '
        Me.LblCount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblCount.AutoSize = True
        Me.LblCount.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCount.Location = New System.Drawing.Point(5, 7)
        Me.LblCount.Name = "LblCount"
        Me.LblCount.Size = New System.Drawing.Size(15, 14)
        Me.LblCount.TabIndex = 99
        Me.LblCount.Text = "0"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(48, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 99
        Me.Label7.Text = "المخزن :"
        '
        'LBMob
        '
        Me.LBMob.FormattingEnabled = True
        Me.LBMob.HorizontalScrollbar = True
        Me.LBMob.Location = New System.Drawing.Point(260, 14)
        Me.LBMob.Name = "LBMob"
        Me.LBMob.Size = New System.Drawing.Size(167, 121)
        Me.LBMob.TabIndex = 8
        '
        'BtnRemove
        '
        Me.BtnRemove.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnRemove.Enabled = False
        Me.BtnRemove.Location = New System.Drawing.Point(260, 137)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(167, 23)
        Me.BtnRemove.TabIndex = 9
        Me.BtnRemove.Text = "حـذف"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnAdd.Location = New System.Drawing.Point(5, 46)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(95, 46)
        Me.BtnAdd.TabIndex = 7
        Me.BtnAdd.Text = "اضـافه"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'TxtCost
        '
        Me.TxtCost.Location = New System.Drawing.Point(106, 72)
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
        'TxtCount
        '
        Me.TxtCount.Location = New System.Drawing.Point(106, 46)
        Me.TxtCount.MaxLength = 10
        Me.TxtCount.Name = "TxtCount"
        Me.TxtCount.Size = New System.Drawing.Size(69, 20)
        Me.TxtCount.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(214, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "الكمـيه"
        '
        'BtnClose
        '
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Location = New System.Drawing.Point(379, 291)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(61, 23)
        Me.BtnClose.TabIndex = 10
        Me.BtnClose.Text = "أغـلاق"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(13, 86)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(192, 23)
        Me.BtnSave.TabIndex = 3
        Me.BtnSave.Text = "حفــظ"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'PNL
        '
        Me.PNL.Controls.Add(Me.TxtBillNumber)
        Me.PNL.Controls.Add(Me.CBCus)
        Me.PNL.Controls.Add(Me.Label3)
        Me.PNL.Controls.Add(Me.BtnSave)
        Me.PNL.Controls.Add(Me.DTP)
        Me.PNL.Controls.Add(Me.Label5)
        Me.PNL.Controls.Add(Me.Label6)
        Me.PNL.Location = New System.Drawing.Point(79, 4)
        Me.PNL.Name = "PNL"
        Me.PNL.Size = New System.Drawing.Size(295, 113)
        Me.PNL.TabIndex = 22
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
        Me.ClientSize = New System.Drawing.Size(452, 317)
        Me.Controls.Add(Me.PNL)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.GB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "BillsFrm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "الــفاتــوره"
        Me.GB.ResumeLayout(False)
        Me.GB.PerformLayout()
        Me.PnlSto.ResumeLayout(False)
        Me.PnlSto.PerformLayout()
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents CBCus As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CBModName As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GB As System.Windows.Forms.GroupBox
    Friend WithEvents TxtCount As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnRemove As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents LBMob As System.Windows.Forms.ListBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents TxtCost As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PnlSto As System.Windows.Forms.Panel
    Friend WithEvents LblCount As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PNL As System.Windows.Forms.Panel
    Friend WithEvents TxtBillNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
