<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQueries
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
        Me.DataGridViewMain = New System.Windows.Forms.DataGridView()
        Me.VisitDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientTelephone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JobName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaritalStatusName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientAge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.A3rad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fa7sSarere = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estegwab = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.T7aleel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tash5ees = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Egra2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S3rEgra2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kashfya = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Takreer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VisitID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridViewMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewMain
        '
        Me.DataGridViewMain.AllowUserToAddRows = False
        Me.DataGridViewMain.AllowUserToDeleteRows = False
        Me.DataGridViewMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VisitDate, Me.PatientName, Me.PatientTelephone, Me.JobName, Me.GenderName, Me.MaritalStatusName, Me.PatientAge, Me.A3rad, Me.Fa7sSarere, Me.Estegwab, Me.T7aleel, Me.Tash5ees, Me.Egra2, Me.S3rEgra2, Me.Kashfya, Me.Takreer, Me.VisitID})
        Me.DataGridViewMain.Location = New System.Drawing.Point(12, 12)
        Me.DataGridViewMain.Name = "DataGridViewMain"
        Me.DataGridViewMain.ReadOnly = True
        Me.DataGridViewMain.Size = New System.Drawing.Size(960, 438)
        Me.DataGridViewMain.TabIndex = 0
        '
        'VisitDate
        '
        Me.VisitDate.DataPropertyName = "VisitDate"
        Me.VisitDate.HeaderText = "تاريخ الزياره"
        Me.VisitDate.Name = "VisitDate"
        Me.VisitDate.ReadOnly = True
        '
        'PatientName
        '
        Me.PatientName.DataPropertyName = "PatientName"
        Me.PatientName.HeaderText = "اسم المريض"
        Me.PatientName.Name = "PatientName"
        Me.PatientName.ReadOnly = True
        '
        'PatientTelephone
        '
        Me.PatientTelephone.DataPropertyName = "PatientTelephone"
        Me.PatientTelephone.HeaderText = "التليفون"
        Me.PatientTelephone.Name = "PatientTelephone"
        Me.PatientTelephone.ReadOnly = True
        '
        'JobName
        '
        Me.JobName.DataPropertyName = "JobName"
        Me.JobName.HeaderText = "الوظيفه"
        Me.JobName.Name = "JobName"
        Me.JobName.ReadOnly = True
        '
        'GenderName
        '
        Me.GenderName.DataPropertyName = "GenderName"
        Me.GenderName.HeaderText = "النوع"
        Me.GenderName.Name = "GenderName"
        Me.GenderName.ReadOnly = True
        '
        'MaritalStatusName
        '
        Me.MaritalStatusName.DataPropertyName = "MaritalStatusName"
        Me.MaritalStatusName.HeaderText = "الحاله"
        Me.MaritalStatusName.Name = "MaritalStatusName"
        Me.MaritalStatusName.ReadOnly = True
        '
        'PatientAge
        '
        Me.PatientAge.DataPropertyName = "PatientAge"
        Me.PatientAge.HeaderText = "عمر المريض"
        Me.PatientAge.Name = "PatientAge"
        Me.PatientAge.ReadOnly = True
        '
        'A3rad
        '
        Me.A3rad.DataPropertyName = "A3rad"
        Me.A3rad.HeaderText = "الاعراض"
        Me.A3rad.Name = "A3rad"
        Me.A3rad.ReadOnly = True
        '
        'Fa7sSarere
        '
        Me.Fa7sSarere.DataPropertyName = "Fa7sSarere"
        Me.Fa7sSarere.HeaderText = "فحص سريري"
        Me.Fa7sSarere.Name = "Fa7sSarere"
        Me.Fa7sSarere.ReadOnly = True
        '
        'Estegwab
        '
        Me.Estegwab.DataPropertyName = "Estegwab"
        Me.Estegwab.HeaderText = "استجواب"
        Me.Estegwab.Name = "Estegwab"
        Me.Estegwab.ReadOnly = True
        '
        'T7aleel
        '
        Me.T7aleel.DataPropertyName = "T7aleel"
        Me.T7aleel.HeaderText = "تحاليل"
        Me.T7aleel.Name = "T7aleel"
        Me.T7aleel.ReadOnly = True
        '
        'Tash5ees
        '
        Me.Tash5ees.DataPropertyName = "Tash5ees"
        Me.Tash5ees.HeaderText = "تشخيص"
        Me.Tash5ees.Name = "Tash5ees"
        Me.Tash5ees.ReadOnly = True
        '
        'Egra2
        '
        Me.Egra2.DataPropertyName = "Egra2"
        Me.Egra2.HeaderText = "اجراء"
        Me.Egra2.Name = "Egra2"
        Me.Egra2.ReadOnly = True
        '
        'S3rEgra2
        '
        Me.S3rEgra2.DataPropertyName = "S3rEgra2"
        Me.S3rEgra2.HeaderText = "سعر الاجراء"
        Me.S3rEgra2.Name = "S3rEgra2"
        Me.S3rEgra2.ReadOnly = True
        '
        'Kashfya
        '
        Me.Kashfya.DataPropertyName = "Kashfya"
        Me.Kashfya.HeaderText = "كشفيه"
        Me.Kashfya.Name = "Kashfya"
        Me.Kashfya.ReadOnly = True
        '
        'Takreer
        '
        Me.Takreer.DataPropertyName = "Takreer"
        Me.Takreer.HeaderText = "تقرير"
        Me.Takreer.Name = "Takreer"
        Me.Takreer.ReadOnly = True
        '
        'VisitID
        '
        Me.VisitID.DataPropertyName = "VisitID"
        Me.VisitID.HeaderText = "VisitID"
        Me.VisitID.Name = "VisitID"
        Me.VisitID.ReadOnly = True
        Me.VisitID.Visible = False
        '
        'FrmQueries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 462)
        Me.Controls.Add(Me.DataGridViewMain)
        Me.Name = "FrmQueries"
        Me.Text = "استعلامات"
        CType(Me.DataGridViewMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewMain As System.Windows.Forms.DataGridView
    Friend WithEvents VisitDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PatientName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PatientTelephone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JobName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaritalStatusName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PatientAge As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents A3rad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fa7sSarere As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estegwab As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T7aleel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tash5ees As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Egra2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S3rEgra2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kashfya As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Takreer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VisitID As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
