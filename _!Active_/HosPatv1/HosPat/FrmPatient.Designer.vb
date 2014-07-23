<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPatient
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
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtPatientName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPatientAddress = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPatientAge = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPatientTelephone = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CBGenderID = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CBJobID = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CBMaritalStatusID = New System.Windows.Forms.ComboBox()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CBPatient = New System.Windows.Forms.ComboBox()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(134, 223)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(88, 23)
        Me.BtnAdd.TabIndex = 0
        Me.BtnAdd.Text = "اضافه"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(253, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "الاسم"
        '
        'TxtPatientName
        '
        Me.TxtPatientName.Location = New System.Drawing.Point(55, 38)
        Me.TxtPatientName.Name = "TxtPatientName"
        Me.TxtPatientName.Size = New System.Drawing.Size(145, 20)
        Me.TxtPatientName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(251, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "العنوان"
        '
        'TxtPatientAddress
        '
        Me.TxtPatientAddress.Location = New System.Drawing.Point(55, 64)
        Me.TxtPatientAddress.Name = "TxtPatientAddress"
        Me.TxtPatientAddress.Size = New System.Drawing.Size(145, 20)
        Me.TxtPatientAddress.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(258, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "العمر"
        '
        'TxtPatientAge
        '
        Me.TxtPatientAge.Location = New System.Drawing.Point(55, 90)
        Me.TxtPatientAge.Name = "TxtPatientAge"
        Me.TxtPatientAge.Size = New System.Drawing.Size(145, 20)
        Me.TxtPatientAge.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(246, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "التليفون"
        '
        'TxtPatientTelephone
        '
        Me.TxtPatientTelephone.Location = New System.Drawing.Point(55, 116)
        Me.TxtPatientTelephone.Name = "TxtPatientTelephone"
        Me.TxtPatientTelephone.Size = New System.Drawing.Size(145, 20)
        Me.TxtPatientTelephone.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(260, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "النوع"
        '
        'CBGenderID
        '
        Me.CBGenderID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBGenderID.FormattingEnabled = True
        Me.CBGenderID.Location = New System.Drawing.Point(55, 142)
        Me.CBGenderID.Name = "CBGenderID"
        Me.CBGenderID.Size = New System.Drawing.Size(145, 21)
        Me.CBGenderID.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(248, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "الوظيفه"
        '
        'CBJobID
        '
        Me.CBJobID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBJobID.FormattingEnabled = True
        Me.CBJobID.Location = New System.Drawing.Point(55, 169)
        Me.CBJobID.Name = "CBJobID"
        Me.CBJobID.Size = New System.Drawing.Size(145, 21)
        Me.CBJobID.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(206, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "الحاله الاجتماعيه"
        '
        'CBMaritalStatusID
        '
        Me.CBMaritalStatusID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBMaritalStatusID.FormattingEnabled = True
        Me.CBMaritalStatusID.Location = New System.Drawing.Point(55, 196)
        Me.CBMaritalStatusID.Name = "CBMaritalStatusID"
        Me.CBMaritalStatusID.Size = New System.Drawing.Size(145, 21)
        Me.CBMaritalStatusID.TabIndex = 3
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(40, 223)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(88, 23)
        Me.BtnUpdate.TabIndex = 0
        Me.BtnUpdate.Text = "تعديل"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(244, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "المرضي"
        '
        'CBPatient
        '
        Me.CBPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBPatient.FormattingEnabled = True
        Me.CBPatient.Location = New System.Drawing.Point(55, 12)
        Me.CBPatient.Name = "CBPatient"
        Me.CBPatient.Size = New System.Drawing.Size(145, 21)
        Me.CBPatient.TabIndex = 3
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(3, 10)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(46, 23)
        Me.BtnDelete.TabIndex = 0
        Me.BtnDelete.Text = "حذف"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnNew
        '
        Me.BtnNew.Location = New System.Drawing.Point(228, 223)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(48, 23)
        Me.BtnNew.TabIndex = 0
        Me.BtnNew.Text = "جديد"
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'FrmPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 260)
        Me.Controls.Add(Me.CBPatient)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CBMaritalStatusID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CBJobID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CBGenderID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtPatientTelephone)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtPatientAge)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtPatientAddress)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtPatientName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnNew)
        Me.Controls.Add(Me.BtnAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmPatient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "المرضي"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtPatientName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtPatientAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtPatientAge As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtPatientTelephone As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CBGenderID As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CBJobID As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CBMaritalStatusID As System.Windows.Forms.ComboBox
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CBPatient As System.Windows.Forms.ComboBox
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnNew As System.Windows.Forms.Button
End Class
