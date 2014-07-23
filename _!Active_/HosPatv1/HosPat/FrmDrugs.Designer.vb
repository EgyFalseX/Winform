<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDrugs
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
        Me.CBDrugs = New System.Windows.Forms.ComboBox()
        Me.DrugsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet = New HosPat.DatabaseDataSet()
        Me.BtnDel = New System.Windows.Forms.Button()
        Me.TxtEdit = New System.Windows.Forms.TextBox()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.TxtAdd = New System.Windows.Forms.TextBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.DrugsTableAdapter = New HosPat.DatabaseDataSetTableAdapters.DrugsTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.DrugsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CBDrugs
        '
        Me.CBDrugs.DataSource = Me.DrugsBindingSource
        Me.CBDrugs.DisplayMember = "DrugName"
        Me.CBDrugs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBDrugs.FormattingEnabled = True
        Me.CBDrugs.Location = New System.Drawing.Point(89, 12)
        Me.CBDrugs.Name = "CBDrugs"
        Me.CBDrugs.Size = New System.Drawing.Size(246, 21)
        Me.CBDrugs.TabIndex = 0
        Me.CBDrugs.ValueMember = "DrugID"
        '
        'DrugsBindingSource
        '
        Me.DrugsBindingSource.DataMember = "Drugs"
        Me.DrugsBindingSource.DataSource = Me.DatabaseDataSet
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnDel
        '
        Me.BtnDel.Location = New System.Drawing.Point(8, 10)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(75, 23)
        Me.BtnDel.TabIndex = 1
        Me.BtnDel.Text = "حذف"
        Me.BtnDel.UseVisualStyleBackColor = True
        '
        'TxtEdit
        '
        Me.TxtEdit.Location = New System.Drawing.Point(103, 22)
        Me.TxtEdit.Name = "TxtEdit"
        Me.TxtEdit.Size = New System.Drawing.Size(121, 20)
        Me.TxtEdit.TabIndex = 2
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(22, 19)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(75, 23)
        Me.BtnEdit.TabIndex = 3
        Me.BtnEdit.Text = "تعديل"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'TxtAdd
        '
        Me.TxtAdd.Location = New System.Drawing.Point(103, 22)
        Me.TxtAdd.Name = "TxtAdd"
        Me.TxtAdd.Size = New System.Drawing.Size(121, 20)
        Me.TxtAdd.TabIndex = 2
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(22, 19)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdd.TabIndex = 3
        Me.BtnAdd.Text = "اضافه"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'DrugsTableAdapter
        '
        Me.DrugsTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnEdit)
        Me.GroupBox1.Controls.Add(Me.TxtEdit)
        Me.GroupBox1.Location = New System.Drawing.Point(89, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(246, 60)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "التعديل"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtAdd)
        Me.GroupBox2.Controls.Add(Me.BtnAdd)
        Me.GroupBox2.Location = New System.Drawing.Point(89, 105)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(246, 60)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "الاضافه"
        '
        'FrmDrugs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 179)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnDel)
        Me.Controls.Add(Me.CBDrugs)
        Me.Name = "FrmDrugs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "الادويه"
        CType(Me.DrugsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CBDrugs As System.Windows.Forms.ComboBox
    Friend WithEvents BtnDel As System.Windows.Forms.Button
    Friend WithEvents TxtEdit As System.Windows.Forms.TextBox
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents TxtAdd As System.Windows.Forms.TextBox
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents DatabaseDataSet As HosPat.DatabaseDataSet
    Friend WithEvents DrugsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DrugsTableAdapter As HosPat.DatabaseDataSetTableAdapters.DrugsTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
