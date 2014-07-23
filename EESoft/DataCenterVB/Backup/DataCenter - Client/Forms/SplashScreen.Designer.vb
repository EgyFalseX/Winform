<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents ApplicationTitle As System.Windows.Forms.Label
    Friend WithEvents Version As System.Windows.Forms.Label
    Friend WithEvents Copyright As System.Windows.Forms.Label
    Friend WithEvents MainLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DetailsLayoutPanel As System.Windows.Forms.TableLayoutPanel

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen))
        Me.MainLayoutPanel = New System.Windows.Forms.TableLayoutPanel
        Me.DetailsLayoutPanel = New System.Windows.Forms.TableLayoutPanel
        Me.Version = New System.Windows.Forms.Label
        Me.Copyright = New System.Windows.Forms.Label
        Me.ApplicationTitle = New System.Windows.Forms.Label
        Me.Lbl = New System.Windows.Forms.Label
        Me.ProgressBarLoading = New System.Windows.Forms.ProgressBar
        Me.LblPercent = New System.Windows.Forms.Label
        Me.MainLayoutPanel.SuspendLayout()
        Me.DetailsLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainLayoutPanel
        '
        Me.MainLayoutPanel.BackgroundImage = Global.DataCenter_Client.My.Resources.Resources.SplashScreen_
        Me.MainLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainLayoutPanel.ColumnCount = 3
        Me.MainLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220.0!))
        Me.MainLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240.0!))
        Me.MainLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.MainLayoutPanel.Controls.Add(Me.DetailsLayoutPanel, 1, 1)
        Me.MainLayoutPanel.Controls.Add(Me.ApplicationTitle, 1, 0)
        Me.MainLayoutPanel.Controls.Add(Me.Lbl, 0, 2)
        Me.MainLayoutPanel.Controls.Add(Me.ProgressBarLoading, 1, 2)
        Me.MainLayoutPanel.Controls.Add(Me.LblPercent, 2, 2)
        Me.MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainLayoutPanel.Name = "MainLayoutPanel"
        Me.MainLayoutPanel.RowCount = 3
        Me.MainLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 222.0!))
        Me.MainLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73.0!))
        Me.MainLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.MainLayoutPanel.Size = New System.Drawing.Size(496, 314)
        Me.MainLayoutPanel.TabIndex = 0
        '
        'DetailsLayoutPanel
        '
        Me.DetailsLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DetailsLayoutPanel.BackColor = System.Drawing.Color.Transparent
        Me.DetailsLayoutPanel.ColumnCount = 1
        Me.DetailsLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 247.0!))
        Me.DetailsLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142.0!))
        Me.DetailsLayoutPanel.Controls.Add(Me.Version, 0, 0)
        Me.DetailsLayoutPanel.Controls.Add(Me.Copyright, 0, 1)
        Me.DetailsLayoutPanel.Location = New System.Drawing.Point(223, 225)
        Me.DetailsLayoutPanel.Name = "DetailsLayoutPanel"
        Me.DetailsLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.DetailsLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.DetailsLayoutPanel.Size = New System.Drawing.Size(234, 67)
        Me.DetailsLayoutPanel.TabIndex = 1
        '
        'Version
        '
        Me.Version.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Version.BackColor = System.Drawing.Color.Transparent
        Me.Version.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version.Location = New System.Drawing.Point(3, 6)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(241, 20)
        Me.Version.TabIndex = 1
        Me.Version.Text = "Version {1}.{0:00}"
        '
        'Copyright
        '
        Me.Copyright.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Copyright.BackColor = System.Drawing.Color.Transparent
        Me.Copyright.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Copyright.Location = New System.Drawing.Point(3, 33)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(241, 34)
        Me.Copyright.TabIndex = 2
        Me.Copyright.Text = "Copyright "
        '
        'ApplicationTitle
        '
        Me.ApplicationTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ApplicationTitle.BackColor = System.Drawing.Color.Transparent
        Me.ApplicationTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApplicationTitle.Location = New System.Drawing.Point(223, 5)
        Me.ApplicationTitle.Name = "ApplicationTitle"
        Me.ApplicationTitle.Size = New System.Drawing.Size(234, 212)
        Me.ApplicationTitle.TabIndex = 0
        Me.ApplicationTitle.Text = "DataCenter - Client"
        Me.ApplicationTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Lbl
        '
        Me.Lbl.BackColor = System.Drawing.Color.Transparent
        Me.Lbl.Location = New System.Drawing.Point(3, 295)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.Size = New System.Drawing.Size(59, 13)
        Me.Lbl.TabIndex = 1
        Me.Lbl.Text = "Loading ..."
        '
        'ProgressBarLoading
        '
        Me.ProgressBarLoading.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressBarLoading.Location = New System.Drawing.Point(223, 298)
        Me.ProgressBarLoading.MarqueeAnimationSpeed = 40
        Me.ProgressBarLoading.Name = "ProgressBarLoading"
        Me.ProgressBarLoading.Size = New System.Drawing.Size(234, 13)
        Me.ProgressBarLoading.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBarLoading.TabIndex = 2
        '
        'LblPercent
        '
        Me.LblPercent.AutoSize = True
        Me.LblPercent.BackColor = System.Drawing.Color.Transparent
        Me.LblPercent.Location = New System.Drawing.Point(463, 295)
        Me.LblPercent.Name = "LblPercent"
        Me.LblPercent.Size = New System.Drawing.Size(24, 13)
        Me.LblPercent.TabIndex = 3
        Me.LblPercent.Text = "0%"
        Me.LblPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 314)
        Me.ControlBox = False
        Me.Controls.Add(Me.MainLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SplashScreen"
        Me.Opacity = 0
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.White
        Me.MainLayoutPanel.ResumeLayout(False)
        Me.MainLayoutPanel.PerformLayout()
        Me.DetailsLayoutPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lbl As System.Windows.Forms.Label
    Friend WithEvents ProgressBarLoading As System.Windows.Forms.ProgressBar
    Friend WithEvents LblPercent As System.Windows.Forms.Label

End Class
