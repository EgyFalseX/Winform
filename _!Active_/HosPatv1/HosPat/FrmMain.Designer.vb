<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.BtnPat = New System.Windows.Forms.Button()
        Me.BtnJobs = New System.Windows.Forms.Button()
        Me.BtnDrugs = New System.Windows.Forms.Button()
        Me.BtnVis = New System.Windows.Forms.Button()
        Me.BtnQ2 = New System.Windows.Forms.Button()
        Me.BtnQ1 = New System.Windows.Forms.Button()
        Me.BtnRep = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnPat
        '
        Me.BtnPat.Location = New System.Drawing.Point(30, 10)
        Me.BtnPat.Name = "BtnPat"
        Me.BtnPat.Size = New System.Drawing.Size(75, 23)
        Me.BtnPat.TabIndex = 2
        Me.BtnPat.Text = "المرضي"
        Me.BtnPat.UseVisualStyleBackColor = True
        '
        'BtnJobs
        '
        Me.BtnJobs.Location = New System.Drawing.Point(111, 10)
        Me.BtnJobs.Name = "BtnJobs"
        Me.BtnJobs.Size = New System.Drawing.Size(75, 23)
        Me.BtnJobs.TabIndex = 1
        Me.BtnJobs.Text = "الوظائف"
        Me.BtnJobs.UseVisualStyleBackColor = True
        '
        'BtnDrugs
        '
        Me.BtnDrugs.Location = New System.Drawing.Point(192, 10)
        Me.BtnDrugs.Name = "BtnDrugs"
        Me.BtnDrugs.Size = New System.Drawing.Size(75, 23)
        Me.BtnDrugs.TabIndex = 0
        Me.BtnDrugs.Text = "الادويه"
        Me.BtnDrugs.UseVisualStyleBackColor = True
        '
        'BtnVis
        '
        Me.BtnVis.Location = New System.Drawing.Point(76, 39)
        Me.BtnVis.Name = "BtnVis"
        Me.BtnVis.Size = New System.Drawing.Size(145, 23)
        Me.BtnVis.TabIndex = 3
        Me.BtnVis.Text = "الزيارات"
        Me.BtnVis.UseVisualStyleBackColor = True
        '
        'BtnQ2
        '
        Me.BtnQ2.Location = New System.Drawing.Point(49, 68)
        Me.BtnQ2.Name = "BtnQ2"
        Me.BtnQ2.Size = New System.Drawing.Size(96, 23)
        Me.BtnQ2.TabIndex = 5
        Me.BtnQ2.Text = "استعلام بالاسم"
        Me.BtnQ2.UseVisualStyleBackColor = True
        '
        'BtnQ1
        '
        Me.BtnQ1.Location = New System.Drawing.Point(151, 68)
        Me.BtnQ1.Name = "BtnQ1"
        Me.BtnQ1.Size = New System.Drawing.Size(96, 23)
        Me.BtnQ1.TabIndex = 4
        Me.BtnQ1.Text = "استعلام بالرقم"
        Me.BtnQ1.UseVisualStyleBackColor = True
        '
        'BtnRep
        '
        Me.BtnRep.Location = New System.Drawing.Point(76, 96)
        Me.BtnRep.Name = "BtnRep"
        Me.BtnRep.Size = New System.Drawing.Size(145, 23)
        Me.BtnRep.TabIndex = 6
        Me.BtnRep.Text = "التقارير"
        Me.BtnRep.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(111, 125)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 7
        Me.BtnExit.Text = "خروج"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AcceptButton = Me.BtnExit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 159)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnQ1)
        Me.Controls.Add(Me.BtnDrugs)
        Me.Controls.Add(Me.BtnQ2)
        Me.Controls.Add(Me.BtnJobs)
        Me.Controls.Add(Me.BtnRep)
        Me.Controls.Add(Me.BtnVis)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnPat)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(313, 197)
        Me.MinimumSize = New System.Drawing.Size(313, 197)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "الرئيسيه"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnPat As System.Windows.Forms.Button
    Friend WithEvents BtnJobs As System.Windows.Forms.Button
    Friend WithEvents BtnDrugs As System.Windows.Forms.Button
    Friend WithEvents BtnVis As System.Windows.Forms.Button
    Friend WithEvents BtnQ2 As System.Windows.Forms.Button
    Friend WithEvents BtnQ1 As System.Windows.Forms.Button
    Friend WithEvents BtnRep As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button

End Class
