<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmJob
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
        Me.components = New System.ComponentModel.Container()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.TxtAdd = New System.Windows.Forms.TextBox()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.TxtEdit = New System.Windows.Forms.TextBox()
        Me.BtnDel = New System.Windows.Forms.Button()
        Me.CBJobs = New System.Windows.Forms.ComboBox()
        Me.JobsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet1 = New HosPat.DatabaseDataSet1()
        Me.DatabaseDataSet = New HosPat.DatabaseDataSet()
        Me.DatabaseDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JobsTableAdapter = New HosPat.DatabaseDataSet1TableAdapters.JobsTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.JobsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(22, 19)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdd.TabIndex = 8
        Me.BtnAdd.Text = "اضافه"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'TxtAdd
        '
        Me.TxtAdd.Location = New System.Drawing.Point(103, 22)
        Me.TxtAdd.Name = "TxtAdd"
        Me.TxtAdd.Size = New System.Drawing.Size(121, 20)
        Me.TxtAdd.TabIndex = 7
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(22, 19)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(75, 23)
        Me.BtnEdit.TabIndex = 9
        Me.BtnEdit.Text = "تعديل"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'TxtEdit
        '
        Me.TxtEdit.Location = New System.Drawing.Point(103, 22)
        Me.TxtEdit.Name = "TxtEdit"
        Me.TxtEdit.Size = New System.Drawing.Size(121, 20)
        Me.TxtEdit.TabIndex = 6
        '
        'BtnDel
        '
        Me.BtnDel.Location = New System.Drawing.Point(14, 10)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(75, 23)
        Me.BtnDel.TabIndex = 5
        Me.BtnDel.Text = "حذف"
        Me.BtnDel.UseVisualStyleBackColor = True
        '
        'CBJobs
        '
        Me.CBJobs.DataSource = Me.JobsBindingSource
        Me.CBJobs.DisplayMember = "JobName"
        Me.CBJobs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBJobs.FormattingEnabled = True
        Me.CBJobs.Location = New System.Drawing.Point(95, 12)
        Me.CBJobs.Name = "CBJobs"
        Me.CBJobs.Size = New System.Drawing.Size(246, 21)
        Me.CBJobs.TabIndex = 4
        Me.CBJobs.ValueMember = "JobID"
        '
        'JobsBindingSource
        '
        Me.JobsBindingSource.DataMember = "Jobs"
        Me.JobsBindingSource.DataSource = Me.DatabaseDataSet1
        '
        'DatabaseDataSet1
        '
        Me.DatabaseDataSet1.DataSetName = "DatabaseDataSet1"
        Me.DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DatabaseDataSetBindingSource
        '
        Me.DatabaseDataSetBindingSource.DataSource = Me.DatabaseDataSet
        Me.DatabaseDataSetBindingSource.Position = 0
        '
        'JobsTableAdapter
        '
        Me.JobsTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnEdit)
        Me.GroupBox1.Controls.Add(Me.TxtEdit)
        Me.GroupBox1.Location = New System.Drawing.Point(95, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(246, 60)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "التعديل"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtAdd)
        Me.GroupBox2.Controls.Add(Me.BtnAdd)
        Me.GroupBox2.Location = New System.Drawing.Point(95, 105)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(246, 60)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "الاضافه"
        '
        'FrmJob
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 177)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnDel)
        Me.Controls.Add(Me.CBJobs)
        Me.Name = "FrmJob"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "الوظائف"
        CType(Me.JobsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents TxtAdd As System.Windows.Forms.TextBox
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents TxtEdit As System.Windows.Forms.TextBox
    Friend WithEvents BtnDel As System.Windows.Forms.Button
    Friend WithEvents CBJobs As System.Windows.Forms.ComboBox
    Friend WithEvents DatabaseDataSet As HosPat.DatabaseDataSet
    Friend WithEvents DatabaseDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DatabaseDataSet1 As HosPat.DatabaseDataSet1
    Friend WithEvents JobsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JobsTableAdapter As HosPat.DatabaseDataSet1TableAdapters.JobsTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
