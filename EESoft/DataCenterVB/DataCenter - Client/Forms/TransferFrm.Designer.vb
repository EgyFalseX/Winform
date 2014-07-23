<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransferFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransferFrm))
        Me.Lbl = New System.Windows.Forms.Label()
        Me.BtnDownload = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnUpload = New System.Windows.Forms.Button()
        Me.BtnBrowse = New System.Windows.Forms.Button()
        Me.LblPath = New System.Windows.Forms.Label()
        Me.PBUpload = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblBytes = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lbl
        '
        Me.Lbl.AutoSize = True
        Me.Lbl.Location = New System.Drawing.Point(12, 244)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.Size = New System.Drawing.Size(59, 13)
        Me.Lbl.TabIndex = 0
        Me.Lbl.Text = "Loading ..."
        '
        'BtnDownload
        '
        Me.BtnDownload.Location = New System.Drawing.Point(331, 10)
        Me.BtnDownload.Name = "BtnDownload"
        Me.BtnDownload.Size = New System.Drawing.Size(97, 23)
        Me.BtnDownload.TabIndex = 1
        Me.BtnDownload.Text = " Õ„Ì· «·„·›"
        Me.BtnDownload.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkGray
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(440, 5)
        Me.Label1.TabIndex = 2
        '
        'BtnUpload
        '
        Me.BtnUpload.Enabled = False
        Me.BtnUpload.Location = New System.Drawing.Point(333, 75)
        Me.BtnUpload.Name = "BtnUpload"
        Me.BtnUpload.Size = New System.Drawing.Size(97, 23)
        Me.BtnUpload.TabIndex = 1
        Me.BtnUpload.Text = "—›⁄ «·„·›"
        Me.BtnUpload.UseVisualStyleBackColor = True
        '
        'BtnBrowse
        '
        Me.BtnBrowse.Location = New System.Drawing.Point(333, 46)
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.BtnBrowse.Size = New System.Drawing.Size(97, 23)
        Me.BtnBrowse.TabIndex = 1
        Me.BtnBrowse.Text = "..."
        Me.BtnBrowse.UseVisualStyleBackColor = True
        '
        'LblPath
        '
        Me.LblPath.AutoSize = True
        Me.LblPath.BackColor = System.Drawing.Color.Transparent
        Me.LblPath.Location = New System.Drawing.Point(21, 51)
        Me.LblPath.Name = "LblPath"
        Me.LblPath.Size = New System.Drawing.Size(137, 13)
        Me.LblPath.TabIndex = 3
        Me.LblPath.Text = "„‰ ›÷·ﬂ «Œ «— „·› ··«—”«·"
        Me.LblPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PBUpload
        '
        Me.PBUpload.Location = New System.Drawing.Point(24, 77)
        Me.PBUpload.Name = "PBUpload"
        Me.PBUpload.Size = New System.Drawing.Size(303, 20)
        Me.PBUpload.TabIndex = 4
        Me.PBUpload.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(21, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "⁄œœ «·»«Ì ”"
        '
        'LblBytes
        '
        Me.LblBytes.AutoSize = True
        Me.LblBytes.BackColor = System.Drawing.Color.Transparent
        Me.LblBytes.Location = New System.Drawing.Point(124, 15)
        Me.LblBytes.Name = "LblBytes"
        Me.LblBytes.Size = New System.Drawing.Size(13, 13)
        Me.LblBytes.TabIndex = 5
        Me.LblBytes.Text = "0"
        '
        'TransferFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DataCenter_Client.My.Resources.Resources.TransferFrm
        Me.ClientSize = New System.Drawing.Size(450, 108)
        Me.Controls.Add(Me.LblBytes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PBUpload)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnBrowse)
        Me.Controls.Add(Me.BtnUpload)
        Me.Controls.Add(Me.BtnDownload)
        Me.Controls.Add(Me.Lbl)
        Me.Controls.Add(Me.LblPath)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TransferFrm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "«· Õ„Ì·"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl As System.Windows.Forms.Label
    Friend WithEvents BtnDownload As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnUpload As System.Windows.Forms.Button
    Friend WithEvents BtnBrowse As System.Windows.Forms.Button
    Friend WithEvents LblPath As System.Windows.Forms.Label
    Friend WithEvents PBUpload As System.Windows.Forms.ProgressBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LblBytes As System.Windows.Forms.Label
End Class
