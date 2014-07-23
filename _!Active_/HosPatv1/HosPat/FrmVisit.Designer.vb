<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVisit
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
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtA3rad = New System.Windows.Forms.TextBox()
        Me.CBPatientID = New System.Windows.Forms.ComboBox()
        Me.DTPVisitDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtFa7sSarere = New System.Windows.Forms.TextBox()
        Me.TxtEstegwab = New System.Windows.Forms.TextBox()
        Me.TxtT7aleel = New System.Windows.Forms.TextBox()
        Me.TxtTash5ees = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtEgra2 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtS3rEgra2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtKashfya = New System.Windows.Forms.TextBox()
        Me.TxtTakreer = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CBVisits = New System.Windows.Forms.ComboBox()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(126, 526)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(98, 23)
        Me.BtnSave.TabIndex = 0
        Me.BtnSave.Text = "حفـــــــــــظ"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(297, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "اعراض"
        '
        'TxtA3rad
        '
        Me.TxtA3rad.Location = New System.Drawing.Point(12, 129)
        Me.TxtA3rad.Multiline = True
        Me.TxtA3rad.Name = "TxtA3rad"
        Me.TxtA3rad.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtA3rad.Size = New System.Drawing.Size(248, 40)
        Me.TxtA3rad.TabIndex = 2
        '
        'CBPatientID
        '
        Me.CBPatientID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBPatientID.FormattingEnabled = True
        Me.CBPatientID.Location = New System.Drawing.Point(12, 76)
        Me.CBPatientID.Name = "CBPatientID"
        Me.CBPatientID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CBPatientID.Size = New System.Drawing.Size(248, 21)
        Me.CBPatientID.TabIndex = 3
        '
        'DTPVisitDate
        '
        Me.DTPVisitDate.Location = New System.Drawing.Point(12, 103)
        Me.DTPVisitDate.Name = "DTPVisitDate"
        Me.DTPVisitDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DTPVisitDate.Size = New System.Drawing.Size(248, 20)
        Me.DTPVisitDate.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(278, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "تاريخ الزياره"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(294, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "المريض"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(266, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "فحص سريري"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(286, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "استجواب"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(300, 270)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "تحاليل"
        '
        'TxtFa7sSarere
        '
        Me.TxtFa7sSarere.Location = New System.Drawing.Point(12, 175)
        Me.TxtFa7sSarere.Multiline = True
        Me.TxtFa7sSarere.Name = "TxtFa7sSarere"
        Me.TxtFa7sSarere.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtFa7sSarere.Size = New System.Drawing.Size(248, 40)
        Me.TxtFa7sSarere.TabIndex = 2
        '
        'TxtEstegwab
        '
        Me.TxtEstegwab.Location = New System.Drawing.Point(12, 221)
        Me.TxtEstegwab.Multiline = True
        Me.TxtEstegwab.Name = "TxtEstegwab"
        Me.TxtEstegwab.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtEstegwab.Size = New System.Drawing.Size(248, 40)
        Me.TxtEstegwab.TabIndex = 2
        '
        'TxtT7aleel
        '
        Me.TxtT7aleel.Location = New System.Drawing.Point(12, 267)
        Me.TxtT7aleel.Multiline = True
        Me.TxtT7aleel.Name = "TxtT7aleel"
        Me.TxtT7aleel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtT7aleel.Size = New System.Drawing.Size(248, 40)
        Me.TxtT7aleel.TabIndex = 2
        '
        'TxtTash5ees
        '
        Me.TxtTash5ees.Location = New System.Drawing.Point(12, 313)
        Me.TxtTash5ees.Multiline = True
        Me.TxtTash5ees.Name = "TxtTash5ees"
        Me.TxtTash5ees.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtTash5ees.Size = New System.Drawing.Size(248, 40)
        Me.TxtTash5ees.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(289, 316)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "تشخيص"
        '
        'TxtEgra2
        '
        Me.TxtEgra2.Location = New System.Drawing.Point(12, 359)
        Me.TxtEgra2.Multiline = True
        Me.TxtEgra2.Name = "TxtEgra2"
        Me.TxtEgra2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtEgra2.Size = New System.Drawing.Size(248, 40)
        Me.TxtEgra2.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(306, 362)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "اجراء"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(281, 408)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "سعر اجراء"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(299, 463)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "التقرير"
        '
        'txtS3rEgra2
        '
        Me.txtS3rEgra2.Location = New System.Drawing.Point(12, 408)
        Me.txtS3rEgra2.Name = "txtS3rEgra2"
        Me.txtS3rEgra2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtS3rEgra2.Size = New System.Drawing.Size(248, 20)
        Me.txtS3rEgra2.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(295, 434)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "كشفيه"
        '
        'TxtKashfya
        '
        Me.TxtKashfya.Location = New System.Drawing.Point(12, 434)
        Me.TxtKashfya.Name = "TxtKashfya"
        Me.TxtKashfya.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtKashfya.Size = New System.Drawing.Size(248, 20)
        Me.TxtKashfya.TabIndex = 2
        '
        'TxtTakreer
        '
        Me.TxtTakreer.Location = New System.Drawing.Point(12, 460)
        Me.TxtTakreer.Multiline = True
        Me.TxtTakreer.Name = "TxtTakreer"
        Me.TxtTakreer.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtTakreer.Size = New System.Drawing.Size(248, 60)
        Me.TxtTakreer.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(295, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "الزيارات"
        '
        'CBVisits
        '
        Me.CBVisits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBVisits.FormattingEnabled = True
        Me.CBVisits.Location = New System.Drawing.Point(12, 12)
        Me.CBVisits.Name = "CBVisits"
        Me.CBVisits.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CBVisits.Size = New System.Drawing.Size(248, 21)
        Me.CBVisits.TabIndex = 3
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(22, 526)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(98, 23)
        Me.BtnUpdate.TabIndex = 0
        Me.BtnUpdate.Text = "تعديل"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(158, 39)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(102, 23)
        Me.BtnDelete.TabIndex = 0
        Me.BtnDelete.Text = "حذف"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(230, 526)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(98, 23)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "جديد"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'FrmVisit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 561)
        Me.Controls.Add(Me.DTPVisitDate)
        Me.Controls.Add(Me.CBVisits)
        Me.Controls.Add(Me.CBPatientID)
        Me.Controls.Add(Me.TxtKashfya)
        Me.Controls.Add(Me.txtS3rEgra2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtTakreer)
        Me.Controls.Add(Me.TxtEgra2)
        Me.Controls.Add(Me.TxtTash5ees)
        Me.Controls.Add(Me.TxtT7aleel)
        Me.Controls.Add(Me.TxtEstegwab)
        Me.Controls.Add(Me.TxtFa7sSarere)
        Me.Controls.Add(Me.TxtA3rad)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.BtnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmVisit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "الزياره"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtA3rad As System.Windows.Forms.TextBox
    Friend WithEvents CBPatientID As System.Windows.Forms.ComboBox
    Friend WithEvents DTPVisitDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtFa7sSarere As System.Windows.Forms.TextBox
    Friend WithEvents TxtEstegwab As System.Windows.Forms.TextBox
    Friend WithEvents TxtT7aleel As System.Windows.Forms.TextBox
    Friend WithEvents TxtTash5ees As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtEgra2 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtS3rEgra2 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtKashfya As System.Windows.Forms.TextBox
    Friend WithEvents TxtTakreer As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CBVisits As System.Windows.Forms.ComboBox
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
End Class
