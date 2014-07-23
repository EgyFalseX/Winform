<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MSGBOXFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MSGBOXFrm))
        Me.Panel = New System.Windows.Forms.Panel
        Me.LBLMSG = New System.Windows.Forms.Label
        Me.BtnOk = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel
        '
        Me.Panel.BackColor = System.Drawing.Color.Transparent
        Me.Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel.Controls.Add(Me.LBLMSG)
        Me.Panel.ForeColor = System.Drawing.Color.Lime
        Me.Panel.Location = New System.Drawing.Point(12, 92)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(376, 70)
        Me.Panel.TabIndex = 1
        Me.Panel.TabStop = True
        '
        'LBLMSG
        '
        Me.LBLMSG.AutoSize = True
        Me.LBLMSG.BackColor = System.Drawing.Color.Black
        Me.LBLMSG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLMSG.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLMSG.ForeColor = System.Drawing.Color.Lime
        Me.LBLMSG.Location = New System.Drawing.Point(154, 23)
        Me.LBLMSG.Name = "LBLMSG"
        Me.LBLMSG.Size = New System.Drawing.Size(64, 20)
        Me.LBLMSG.TabIndex = 2
        Me.LBLMSG.Text = "No Data"
        Me.LBLMSG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnOk
        '
        Me.BtnOk.BackColor = System.Drawing.Color.Blue
        Me.BtnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnOk.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOk.ForeColor = System.Drawing.Color.Black
        Me.BtnOk.Location = New System.Drawing.Point(240, 205)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(148, 24)
        Me.BtnOk.TabIndex = 0
        Me.BtnOk.Text = "Ok"
        Me.BtnOk.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 171)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(148, 72)
        Me.Panel1.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.DataCenter_Server.My.Resources.Resources.Mena_Logo
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(23, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'MSGBOXFrm
        '
        Me.AcceptButton = Me.BtnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DataCenter_Server.My.Resources.Resources.MSGBOXFrm
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.BtnOk
        Me.ClientSize = New System.Drawing.Size(400, 255)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.Panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MSGBOXFrm"
        Me.Opacity = 0
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Login Error Message"
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel As System.Windows.Forms.Panel
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents LBLMSG As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
