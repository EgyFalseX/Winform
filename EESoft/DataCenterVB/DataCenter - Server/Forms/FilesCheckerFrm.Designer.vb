<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FilesCheckerFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FilesCheckerFrm))
        Me.LVFolderFile = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBFilter = New System.Windows.Forms.ComboBox()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblNotFound = New System.Windows.Forms.Label()
        Me.Lblfound = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btnscan = New System.Windows.Forms.Button()
        Me.PBData = New System.Windows.Forms.ProgressBar()
        Me.Lblpercent = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LVFolderFile
        '
        Me.LVFolderFile.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LVFolderFile.BackColor = System.Drawing.SystemColors.Info
        Me.LVFolderFile.CheckBoxes = True
        Me.LVFolderFile.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader1, Me.ColumnHeader2})
        Me.LVFolderFile.FullRowSelect = True
        Me.LVFolderFile.Location = New System.Drawing.Point(12, 26)
        Me.LVFolderFile.Name = "LVFolderFile"
        Me.LVFolderFile.Size = New System.Drawing.Size(484, 322)
        Me.LVFolderFile.TabIndex = 1
        Me.LVFolderFile.UseCompatibleStateImageBehavior = False
        Me.LVFolderFile.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "«Œ Ì«—"
        Me.ColumnHeader3.Width = 75
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "„”«— «·„·›"
        Me.ColumnHeader1.Width = 305
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "«”„ «·„·›"
        Me.ColumnHeader2.Width = 100
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(324, 367)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = " ‰ﬁÌÂ"
        '
        'CBFilter
        '
        Me.CBFilter.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CBFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBFilter.FormattingEnabled = True
        Me.CBFilter.Items.AddRange(New Object() {"Show Error"})
        Me.CBFilter.Location = New System.Drawing.Point(327, 383)
        Me.CBFilter.Name = "CBFilter"
        Me.CBFilter.Size = New System.Drawing.Size(121, 21)
        Me.CBFilter.TabIndex = 2
        '
        'BtnStart
        '
        Me.BtnStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnStart.Enabled = False
        Me.BtnStart.Location = New System.Drawing.Point(61, 386)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(107, 23)
        Me.BtnStart.TabIndex = 3
        Me.BtnStart.Text = "»œ¡ «·»—‰«„Ã"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.LblTotal)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.LblNotFound)
        Me.Panel1.Controls.Add(Me.Lblfound)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(178, 354)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(135, 57)
        Me.Panel1.TabIndex = 4
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Location = New System.Drawing.Point(95, 36)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(13, 13)
        Me.LblTotal.TabIndex = 0
        Me.LblTotal.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "«·„Ã„Ê⁄"
        '
        'LblNotFound
        '
        Me.LblNotFound.AutoSize = True
        Me.LblNotFound.Location = New System.Drawing.Point(95, 21)
        Me.LblNotFound.Name = "LblNotFound"
        Me.LblNotFound.Size = New System.Drawing.Size(13, 13)
        Me.LblNotFound.TabIndex = 0
        Me.LblNotFound.Text = "0"
        '
        'Lblfound
        '
        Me.Lblfound.AutoSize = True
        Me.Lblfound.Location = New System.Drawing.Point(95, 6)
        Me.Lblfound.Name = "Lblfound"
        Me.Lblfound.Size = New System.Drawing.Size(13, 13)
        Me.Lblfound.TabIndex = 0
        Me.Lblfound.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "€Ì— „ÊÃÊœ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "„ÊÃÊœ"
        '
        'Btnscan
        '
        Me.Btnscan.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Btnscan.Location = New System.Drawing.Point(61, 354)
        Me.Btnscan.Name = "Btnscan"
        Me.Btnscan.Size = New System.Drawing.Size(107, 23)
        Me.Btnscan.TabIndex = 0
        Me.Btnscan.Text = "»œ¡ «·›Õ’"
        Me.Btnscan.UseVisualStyleBackColor = True
        '
        'PBData
        '
        Me.PBData.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PBData.Location = New System.Drawing.Point(12, 5)
        Me.PBData.Name = "PBData"
        Me.PBData.Size = New System.Drawing.Size(442, 20)
        Me.PBData.TabIndex = 5
        '
        'Lblpercent
        '
        Me.Lblpercent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lblpercent.AutoSize = True
        Me.Lblpercent.BackColor = System.Drawing.Color.Transparent
        Me.Lblpercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lblpercent.Location = New System.Drawing.Point(457, 7)
        Me.Lblpercent.Name = "Lblpercent"
        Me.Lblpercent.Size = New System.Drawing.Size(19, 13)
        Me.Lblpercent.TabIndex = 0
        Me.Lblpercent.Text = "00"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Location = New System.Drawing.Point(481, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "%"
        '
        'FilesCheckerFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DataCenter_Server.My.Resources.Resources.FilesCheckerFrm
        Me.ClientSize = New System.Drawing.Size(508, 417)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Lblpercent)
        Me.Controls.Add(Me.PBData)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Btnscan)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.CBFilter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LVFolderFile)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FilesCheckerFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "›Õ’ «·„·›« "
        Me.TransparencyKey = System.Drawing.Color.Lime
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LVFolderFile As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CBFilter As System.Windows.Forms.ComboBox
    Friend WithEvents BtnStart As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LblTotal As System.Windows.Forms.Label
    Friend WithEvents LblNotFound As System.Windows.Forms.Label
    Friend WithEvents Lblfound As System.Windows.Forms.Label
    Friend WithEvents Btnscan As System.Windows.Forms.Button
    Friend WithEvents PBData As System.Windows.Forms.ProgressBar
    Friend WithEvents Lblpercent As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class