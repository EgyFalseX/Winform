<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDlgFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminDlgFrm))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.AdminOKBtn = New System.Windows.Forms.Button
        Me.AdminCancelBtn = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.AdminPasswordRB = New System.Windows.Forms.RadioButton
        Me.AdminUserNameRB = New System.Windows.Forms.RadioButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.AdminPassword2Txt = New System.Windows.Forms.TextBox
        Me.AdminPassword1Txt = New System.Windows.Forms.TextBox
        Me.AdminUserNameTxt = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.UserPrivilegeCB = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.UserOKBtn = New System.Windows.Forms.Button
        Me.UserCancelBtn = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.UserPassword2Txt = New System.Windows.Forms.TextBox
        Me.UserPassword1Txt = New System.Windows.Forms.TextBox
        Me.UserUserNameTxt = New System.Windows.Forms.TextBox
        Me.OptionCloseBtn = New System.Windows.Forms.Button
        Me.HistoryBtn = New System.Windows.Forms.Button
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.AdminOKBtn, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.AdminCancelBtn, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(103, 140)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'AdminOKBtn
        '
        Me.AdminOKBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AdminOKBtn.Enabled = False
        Me.AdminOKBtn.Location = New System.Drawing.Point(76, 3)
        Me.AdminOKBtn.Name = "AdminOKBtn"
        Me.AdminOKBtn.Size = New System.Drawing.Size(67, 23)
        Me.AdminOKBtn.TabIndex = 8
        Me.AdminOKBtn.Text = "„Ê«›ﬁ"
        '
        'AdminCancelBtn
        '
        Me.AdminCancelBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AdminCancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.AdminCancelBtn.Location = New System.Drawing.Point(3, 3)
        Me.AdminCancelBtn.Name = "AdminCancelBtn"
        Me.AdminCancelBtn.Size = New System.Drawing.Size(67, 23)
        Me.AdminCancelBtn.TabIndex = 7
        Me.AdminCancelBtn.Text = "«·‹€‹«¡"
        Me.AdminCancelBtn.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.AdminPassword2Txt)
        Me.GroupBox1.Controls.Add(Me.AdminPassword1Txt)
        Me.GroupBox1.Controls.Add(Me.AdminUserNameTxt)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(261, 176)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "  €ÌÌ— «·«”„ Êﬂ·„… «·„—Ê— : "
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.AdminPasswordRB)
        Me.Panel1.Controls.Add(Me.AdminUserNameRB)
        Me.Panel1.Location = New System.Drawing.Point(6, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(243, 26)
        Me.Panel1.TabIndex = 6
        '
        'AdminPasswordRB
        '
        Me.AdminPasswordRB.AutoSize = True
        Me.AdminPasswordRB.Location = New System.Drawing.Point(10, 5)
        Me.AdminPasswordRB.Name = "AdminPasswordRB"
        Me.AdminPasswordRB.Size = New System.Drawing.Size(102, 17)
        Me.AdminPasswordRB.TabIndex = 2
        Me.AdminPasswordRB.TabStop = True
        Me.AdminPasswordRB.Text = " €ÌÌ— ﬂ·„… «·„—Ê—"
        Me.AdminPasswordRB.UseVisualStyleBackColor = True
        '
        'AdminUserNameRB
        '
        Me.AdminUserNameRB.AutoSize = True
        Me.AdminUserNameRB.Location = New System.Drawing.Point(134, 5)
        Me.AdminUserNameRB.Name = "AdminUserNameRB"
        Me.AdminUserNameRB.Size = New System.Drawing.Size(98, 17)
        Me.AdminUserNameRB.TabIndex = 1
        Me.AdminUserNameRB.TabStop = True
        Me.AdminUserNameRB.Text = " €Ì— «”„ «·„œÌ—"
        Me.AdminUserNameRB.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(167, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "≈⁄«œ… ﬂ·„… «·„—Ê—"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(194, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ﬂ·„… «·„—Ê—"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(216, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "«·«”„"
        '
        'AdminPassword2Txt
        '
        Me.AdminPassword2Txt.Enabled = False
        Me.AdminPassword2Txt.Location = New System.Drawing.Point(6, 114)
        Me.AdminPassword2Txt.Name = "AdminPassword2Txt"
        Me.AdminPassword2Txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.AdminPassword2Txt.Size = New System.Drawing.Size(159, 20)
        Me.AdminPassword2Txt.TabIndex = 5
        '
        'AdminPassword1Txt
        '
        Me.AdminPassword1Txt.Enabled = False
        Me.AdminPassword1Txt.Location = New System.Drawing.Point(6, 88)
        Me.AdminPassword1Txt.Name = "AdminPassword1Txt"
        Me.AdminPassword1Txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.AdminPassword1Txt.Size = New System.Drawing.Size(159, 20)
        Me.AdminPassword1Txt.TabIndex = 4
        '
        'AdminUserNameTxt
        '
        Me.AdminUserNameTxt.Enabled = False
        Me.AdminUserNameTxt.Location = New System.Drawing.Point(6, 62)
        Me.AdminUserNameTxt.Name = "AdminUserNameTxt"
        Me.AdminUserNameTxt.Size = New System.Drawing.Size(159, 20)
        Me.AdminUserNameTxt.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.UserPrivilegeCB)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.UserPassword2Txt)
        Me.GroupBox2.Controls.Add(Me.UserPassword1Txt)
        Me.GroupBox2.Controls.Add(Me.UserUserNameTxt)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 192)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(261, 193)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = " «÷«›… „” Œœ„ ÃœÌœ : "
        '
        'UserPrivilegeCB
        '
        Me.UserPrivilegeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UserPrivilegeCB.FormattingEnabled = True
        Me.UserPrivilegeCB.Items.AddRange(New Object() {"Ì÷Ì› ›ﬁÿ", "Ì⁄—÷ ›ﬁÿ", "„œÌ—"})
        Me.UserPrivilegeCB.Location = New System.Drawing.Point(6, 127)
        Me.UserPrivilegeCB.Name = "UserPrivilegeCB"
        Me.UserPrivilegeCB.Size = New System.Drawing.Size(159, 21)
        Me.UserPrivilegeCB.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(175, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "‰Ê⁄ «·„” Œœ„"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(167, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "≈⁄«œ… ﬂ·„… «·„—Ê—"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.UserOKBtn, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.UserCancelBtn, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(103, 158)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel2.TabIndex = 14
        '
        'UserOKBtn
        '
        Me.UserOKBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.UserOKBtn.Enabled = False
        Me.UserOKBtn.Location = New System.Drawing.Point(76, 3)
        Me.UserOKBtn.Name = "UserOKBtn"
        Me.UserOKBtn.Size = New System.Drawing.Size(67, 23)
        Me.UserOKBtn.TabIndex = 16
        Me.UserOKBtn.Text = "„Ê«›ﬁ"
        '
        'UserCancelBtn
        '
        Me.UserCancelBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.UserCancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.UserCancelBtn.Location = New System.Drawing.Point(3, 3)
        Me.UserCancelBtn.Name = "UserCancelBtn"
        Me.UserCancelBtn.Size = New System.Drawing.Size(67, 23)
        Me.UserCancelBtn.TabIndex = 15
        Me.UserCancelBtn.Text = "«·‹€‹«¡"
        Me.UserCancelBtn.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(194, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "ﬂ·„… «·„—Ê—"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(216, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "«·«”„"
        '
        'UserPassword2Txt
        '
        Me.UserPassword2Txt.Location = New System.Drawing.Point(6, 87)
        Me.UserPassword2Txt.Name = "UserPassword2Txt"
        Me.UserPassword2Txt.Size = New System.Drawing.Size(159, 20)
        Me.UserPassword2Txt.TabIndex = 12
        '
        'UserPassword1Txt
        '
        Me.UserPassword1Txt.Location = New System.Drawing.Point(6, 61)
        Me.UserPassword1Txt.Name = "UserPassword1Txt"
        Me.UserPassword1Txt.Size = New System.Drawing.Size(159, 20)
        Me.UserPassword1Txt.TabIndex = 11
        '
        'UserUserNameTxt
        '
        Me.UserUserNameTxt.Location = New System.Drawing.Point(6, 19)
        Me.UserUserNameTxt.Name = "UserUserNameTxt"
        Me.UserUserNameTxt.Size = New System.Drawing.Size(159, 20)
        Me.UserUserNameTxt.TabIndex = 10
        '
        'OptionCloseBtn
        '
        Me.OptionCloseBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OptionCloseBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OptionCloseBtn.Location = New System.Drawing.Point(143, 387)
        Me.OptionCloseBtn.Name = "OptionCloseBtn"
        Me.OptionCloseBtn.Size = New System.Drawing.Size(135, 23)
        Me.OptionCloseBtn.TabIndex = 18
        Me.OptionCloseBtn.Text = "«€·«ﬁ"
        '
        'HistoryBtn
        '
        Me.HistoryBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.HistoryBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.HistoryBtn.Location = New System.Drawing.Point(2, 387)
        Me.HistoryBtn.Name = "HistoryBtn"
        Me.HistoryBtn.Size = New System.Drawing.Size(135, 23)
        Me.HistoryBtn.TabIndex = 17
        Me.HistoryBtn.Text = " Ê«—ÌŒ œŒÊ· «·„” Œœ„Ì‰"
        Me.HistoryBtn.Visible = False
        '
        'AdminDlgFrm
        '
        Me.AcceptButton = Me.AdminOKBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.OptionCloseBtn
        Me.ClientSize = New System.Drawing.Size(280, 414)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.HistoryBtn)
        Me.Controls.Add(Me.OptionCloseBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AdminDlgFrm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "  «Œ Ì«—«  «·„œÌ—"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents AdminOKBtn As System.Windows.Forms.Button
    Friend WithEvents AdminCancelBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AdminPassword2Txt As System.Windows.Forms.TextBox
    Friend WithEvents AdminPassword1Txt As System.Windows.Forms.TextBox
    Friend WithEvents AdminUserNameTxt As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents UserPrivilegeCB As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents UserOKBtn As System.Windows.Forms.Button
    Friend WithEvents UserCancelBtn As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents UserPassword2Txt As System.Windows.Forms.TextBox
    Friend WithEvents UserPassword1Txt As System.Windows.Forms.TextBox
    Friend WithEvents UserUserNameTxt As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents AdminPasswordRB As System.Windows.Forms.RadioButton
    Friend WithEvents AdminUserNameRB As System.Windows.Forms.RadioButton
    Friend WithEvents OptionCloseBtn As System.Windows.Forms.Button
    Friend WithEvents HistoryBtn As System.Windows.Forms.Button

End Class
