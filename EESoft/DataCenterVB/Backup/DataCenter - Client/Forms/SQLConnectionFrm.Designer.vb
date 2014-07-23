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
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtID = New System.Windows.Forms.TextBox
        Me.TxtPW = New System.Windows.Forms.TextBox
        Me.BtnEnd = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.BtnTest = New System.Windows.Forms.Button
        Me.CBDBName = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'btnstart
        '
        Me.btnstart.Enabled = False
        Me.btnstart.Location = New System.Drawing.Point(18, 110)
        Me.btnstart.Name = "btnstart"
        Me.btnstart.Size = New System.Drawing.Size(200, 23)
        Me.btnstart.TabIndex = 5
        Me.btnstart.Text = "Save and Start"
        Me.btnstart.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
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
        Me.Label2.Location = New System.Drawing.Point(15, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Database Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
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
        'BtnEnd
        '
        Me.BtnEnd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnEnd.Location = New System.Drawing.Point(224, 110)
        Me.BtnEnd.Name = "BtnEnd"
        Me.BtnEnd.Size = New System.Drawing.Size(75, 23)
        Me.BtnEnd.TabIndex = 6
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
        Me.CBDBName.FormattingEnabled = True
        Me.CBDBName.Location = New System.Drawing.Point(118, 83)
        Me.CBDBName.Name = "CBDBName"
        Me.CBDBName.Size = New System.Drawing.Size(139, 21)
        Me.CBDBName.TabIndex = 51
        '
        'SQLConnectionFrm
        '
        Me.AcceptButton = Me.btnstart
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DataCenter_Client.My.Resources.Resources.SQLConnectionFrm
        Me.CancelButton = Me.BtnEnd
        Me.ClientSize = New System.Drawing.Size(315, 142)
        Me.ControlBox = False
        Me.Controls.Add(Me.CBDBName)
        Me.Controls.Add(Me.TxtPW)
        Me.Controls.Add(Me.TxtID)
        Me.Controls.Add(Me.txtserver)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnstart As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtserver As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtID As System.Windows.Forms.TextBox
    Friend WithEvents TxtPW As System.Windows.Forms.TextBox
    Friend WithEvents BtnEnd As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BtnTest As System.Windows.Forms.Button
    Friend WithEvents CBDBName As System.Windows.Forms.ComboBox
End Class
