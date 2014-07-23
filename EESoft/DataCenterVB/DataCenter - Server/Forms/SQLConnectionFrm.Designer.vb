<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SQLConnectionFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SQLConnectionFrm))
        Me.btnstart = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtserver = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtdatabase = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtID = New System.Windows.Forms.TextBox
        Me.TxtPW = New System.Windows.Forms.TextBox
        Me.BtnDB = New System.Windows.Forms.Button
        Me.BtnEnd = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.BtnTest = New System.Windows.Forms.Button
        Me.CBDBName = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GBDB = New System.Windows.Forms.GroupBox
        Me.RBAttached = New System.Windows.Forms.RadioButton
        Me.RBNotAttached = New System.Windows.Forms.RadioButton
        Me.GBDB.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnstart
        '
        Me.btnstart.Enabled = False
        Me.btnstart.Location = New System.Drawing.Point(17, 186)
        Me.btnstart.Name = "btnstart"
        Me.btnstart.Size = New System.Drawing.Size(200, 23)
        Me.btnstart.TabIndex = 9
        Me.btnstart.Text = "Save and Start"
        Me.btnstart.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(15, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Server Name or IP :"
        '
        'txtserver
        '
        Me.txtserver.Location = New System.Drawing.Point(118, 11)
        Me.txtserver.Name = "txtserver"
        Me.txtserver.Size = New System.Drawing.Size(139, 20)
        Me.txtserver.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Database Name :"
        '
        'txtdatabase
        '
        Me.txtdatabase.Location = New System.Drawing.Point(109, 65)
        Me.txtdatabase.Name = "txtdatabase"
        Me.txtdatabase.ReadOnly = True
        Me.txtdatabase.Size = New System.Drawing.Size(139, 20)
        Me.txtdatabase.TabIndex = 50
        Me.txtdatabase.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(15, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "User Name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(15, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Password :"
        '
        'TxtID
        '
        Me.TxtID.Location = New System.Drawing.Point(118, 34)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(139, 20)
        Me.TxtID.TabIndex = 1
        '
        'TxtPW
        '
        Me.TxtPW.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPW.Location = New System.Drawing.Point(118, 58)
        Me.TxtPW.Name = "TxtPW"
        Me.TxtPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(120)
        Me.TxtPW.Size = New System.Drawing.Size(139, 21)
        Me.TxtPW.TabIndex = 2
        '
        'BtnDB
        '
        Me.BtnDB.Enabled = False
        Me.BtnDB.Location = New System.Drawing.Point(249, 63)
        Me.BtnDB.Name = "BtnDB"
        Me.BtnDB.Size = New System.Drawing.Size(41, 23)
        Me.BtnDB.TabIndex = 8
        Me.BtnDB.Text = "..."
        Me.BtnDB.UseVisualStyleBackColor = True
        '
        'BtnEnd
        '
        Me.BtnEnd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnEnd.Location = New System.Drawing.Point(223, 186)
        Me.BtnEnd.Name = "BtnEnd"
        Me.BtnEnd.Size = New System.Drawing.Size(75, 23)
        Me.BtnEnd.TabIndex = 10
        Me.BtnEnd.Text = "End"
        Me.BtnEnd.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(258, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnTest
        '
        Me.BtnTest.Enabled = False
        Me.BtnTest.Location = New System.Drawing.Point(258, 9)
        Me.BtnTest.Name = "BtnTest"
        Me.BtnTest.Size = New System.Drawing.Size(41, 23)
        Me.BtnTest.TabIndex = 3
        Me.BtnTest.Text = "Test"
        Me.BtnTest.UseVisualStyleBackColor = True
        '
        'CBDBName
        '
        Me.CBDBName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBDBName.Enabled = False
        Me.CBDBName.FormattingEnabled = True
        Me.CBDBName.Location = New System.Drawing.Point(109, 39)
        Me.CBDBName.Name = "CBDBName"
        Me.CBDBName.Size = New System.Drawing.Size(139, 21)
        Me.CBDBName.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(6, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Database Name :"
        '
        'GBDB
        '
        Me.GBDB.BackColor = System.Drawing.Color.Transparent
        Me.GBDB.Controls.Add(Me.RBNotAttached)
        Me.GBDB.Controls.Add(Me.RBAttached)
        Me.GBDB.Controls.Add(Me.Label5)
        Me.GBDB.Controls.Add(Me.CBDBName)
        Me.GBDB.Controls.Add(Me.BtnDB)
        Me.GBDB.Controls.Add(Me.Label2)
        Me.GBDB.Controls.Add(Me.txtdatabase)
        Me.GBDB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GBDB.Location = New System.Drawing.Point(9, 85)
        Me.GBDB.Name = "GBDB"
        Me.GBDB.Size = New System.Drawing.Size(297, 95)
        Me.GBDB.TabIndex = 4
        Me.GBDB.TabStop = False
        Me.GBDB.Text = " - DataBase Attachment - "
        Me.GBDB.Visible = False
        '
        'RBAttached
        '
        Me.RBAttached.AutoSize = True
        Me.RBAttached.Location = New System.Drawing.Point(49, 15)
        Me.RBAttached.Name = "RBAttached"
        Me.RBAttached.Size = New System.Drawing.Size(84, 17)
        Me.RBAttached.TabIndex = 5
        Me.RBAttached.TabStop = True
        Me.RBAttached.Text = "DB attached"
        Me.RBAttached.UseVisualStyleBackColor = True
        '
        'RBNotAttached
        '
        Me.RBNotAttached.AutoSize = True
        Me.RBNotAttached.Location = New System.Drawing.Point(145, 15)
        Me.RBNotAttached.Name = "RBNotAttached"
        Me.RBNotAttached.Size = New System.Drawing.Size(103, 17)
        Me.RBNotAttached.TabIndex = 6
        Me.RBNotAttached.TabStop = True
        Me.RBNotAttached.Text = "DB not attached"
        Me.RBNotAttached.UseVisualStyleBackColor = True
        '
        'SQLConnectionFrm
        '
        Me.AcceptButton = Me.btnstart
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DataCenter_Server.My.Resources.Resources.SQLConnectionFrm
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.BtnEnd
        Me.ClientSize = New System.Drawing.Size(315, 217)
        Me.ControlBox = False
        Me.Controls.Add(Me.GBDB)
        Me.Controls.Add(Me.TxtPW)
        Me.Controls.Add(Me.TxtID)
        Me.Controls.Add(Me.txtserver)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnTest)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnEnd)
        Me.Controls.Add(Me.btnstart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SQLConnectionFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "   Database Connection - Mena Data Center"
        Me.GBDB.ResumeLayout(False)
        Me.GBDB.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnstart As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtserver As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtdatabase As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtID As System.Windows.Forms.TextBox
    Friend WithEvents TxtPW As System.Windows.Forms.TextBox
    Friend WithEvents BtnDB As System.Windows.Forms.Button
    Friend WithEvents BtnEnd As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BtnTest As System.Windows.Forms.Button
    Friend WithEvents CBDBName As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GBDB As System.Windows.Forms.GroupBox
    Friend WithEvents RBNotAttached As System.Windows.Forms.RadioButton
    Friend WithEvents RBAttached As System.Windows.Forms.RadioButton
End Class
