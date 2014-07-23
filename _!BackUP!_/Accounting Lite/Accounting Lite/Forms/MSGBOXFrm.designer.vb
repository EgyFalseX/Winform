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
        Me.BigPnl = New System.Windows.Forms.Panel
        Me.LBLMSG = New System.Windows.Forms.Label
        Me.BtnOk = New System.Windows.Forms.Button
        Me.SmallPnl = New System.Windows.Forms.Panel
        Me.PBox = New System.Windows.Forms.PictureBox
        Me.LblMail = New System.Windows.Forms.Label
        Me.LblMob = New System.Windows.Forms.Label
        Me.BigPnl.SuspendLayout()
        Me.SmallPnl.SuspendLayout()
        CType(Me.PBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BigPnl
        '
        Me.BigPnl.BackColor = System.Drawing.Color.Transparent
        Me.BigPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BigPnl.Controls.Add(Me.LBLMSG)
        Me.BigPnl.ForeColor = System.Drawing.Color.Lime
        Me.BigPnl.Location = New System.Drawing.Point(18, 52)
        Me.BigPnl.Name = "BigPnl"
        Me.BigPnl.Size = New System.Drawing.Size(434, 110)
        Me.BigPnl.TabIndex = 1
        Me.BigPnl.TabStop = True
        '
        'LBLMSG
        '
        Me.LBLMSG.AutoSize = True
        Me.LBLMSG.BackColor = System.Drawing.Color.Black
        Me.LBLMSG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLMSG.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLMSG.ForeColor = System.Drawing.Color.Lime
        Me.LBLMSG.Location = New System.Drawing.Point(133, 43)
        Me.LBLMSG.Name = "LBLMSG"
        Me.LBLMSG.Size = New System.Drawing.Size(164, 20)
        Me.LBLMSG.TabIndex = 2
        Me.LBLMSG.Text = "Unrecognized PC Config"
        Me.LBLMSG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnOk
        '
        Me.BtnOk.BackColor = System.Drawing.Color.Blue
        Me.BtnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnOk.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOk.ForeColor = System.Drawing.Color.Black
        Me.BtnOk.Location = New System.Drawing.Point(304, 219)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(148, 24)
        Me.BtnOk.TabIndex = 0
        Me.BtnOk.Text = "Ok"
        Me.BtnOk.UseVisualStyleBackColor = False
        '
        'SmallPnl
        '
        Me.SmallPnl.BackColor = System.Drawing.Color.Transparent
        Me.SmallPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SmallPnl.Controls.Add(Me.PBox)
        Me.SmallPnl.Location = New System.Drawing.Point(18, 171)
        Me.SmallPnl.Name = "SmallPnl"
        Me.SmallPnl.Size = New System.Drawing.Size(148, 72)
        Me.SmallPnl.TabIndex = 4
        '
        'PBox
        '
        Me.PBox.BackgroundImage = Global.Accounting_Lite.My.Resources.Resources.logo
        Me.PBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBox.ErrorImage = Nothing
        Me.PBox.InitialImage = Nothing
        Me.PBox.Location = New System.Drawing.Point(48, 10)
        Me.PBox.Name = "PBox"
        Me.PBox.Size = New System.Drawing.Size(51, 50)
        Me.PBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBox.TabIndex = 2
        Me.PBox.TabStop = False
        '
        'LblMail
        '
        Me.LblMail.AutoSize = True
        Me.LblMail.BackColor = System.Drawing.Color.Black
        Me.LblMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblMail.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMail.ForeColor = System.Drawing.Color.Lime
        Me.LblMail.Location = New System.Drawing.Point(172, 171)
        Me.LblMail.Name = "LblMail"
        Me.LblMail.Size = New System.Drawing.Size(249, 18)
        Me.LblMail.TabIndex = 2
        Me.LblMail.Text = "EMail :    Mohamed.Aly.Omer@gmail.com"
        Me.LblMail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblMob
        '
        Me.LblMob.AutoSize = True
        Me.LblMob.BackColor = System.Drawing.Color.Black
        Me.LblMob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblMob.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMob.ForeColor = System.Drawing.Color.Lime
        Me.LblMob.Location = New System.Drawing.Point(172, 191)
        Me.LblMob.Name = "LblMob"
        Me.LblMob.Size = New System.Drawing.Size(133, 18)
        Me.LblMob.TabIndex = 2
        Me.LblMob.Text = "Mob  :    0104558638"
        Me.LblMob.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MSGBOXFrm
        '
        Me.AcceptButton = Me.BtnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Accounting_Lite.My.Resources.Resources.MSGBOXFrm
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.BtnOk
        Me.ClientSize = New System.Drawing.Size(471, 255)
        Me.Controls.Add(Me.LblMob)
        Me.Controls.Add(Me.LblMail)
        Me.Controls.Add(Me.SmallPnl)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.BigPnl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MSGBOXFrm"
        Me.Opacity = 0
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WearHouse - Error Message!!"
        Me.BigPnl.ResumeLayout(False)
        Me.BigPnl.PerformLayout()
        Me.SmallPnl.ResumeLayout(False)
        CType(Me.PBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BigPnl As System.Windows.Forms.Panel
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents LBLMSG As System.Windows.Forms.Label
    Friend WithEvents SmallPnl As System.Windows.Forms.Panel
    Friend WithEvents PBox As System.Windows.Forms.PictureBox
    Friend WithEvents LblMail As System.Windows.Forms.Label
    Friend WithEvents LblMob As System.Windows.Forms.Label
End Class
