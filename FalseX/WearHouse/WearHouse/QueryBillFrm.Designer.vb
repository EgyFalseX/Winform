<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QueryBillFrm
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
        Me.GridControlMain = New DevExpress.XtraGrid.GridControl()
        Me.GridViewMain = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.GridControlMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControlMain
        '
        Me.GridControlMain.Location = New System.Drawing.Point(12, 12)
        Me.GridControlMain.MainView = Me.GridViewMain
        Me.GridControlMain.Name = "GridControlMain"
        Me.GridControlMain.Size = New System.Drawing.Size(613, 332)
        Me.GridControlMain.TabIndex = 0
        Me.GridControlMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewMain})
        '
        'GridViewMain
        '
        Me.GridViewMain.GridControl = Me.GridControlMain
        Me.GridViewMain.Name = "GridViewMain"
        '
        'QueryBillFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 356)
        Me.Controls.Add(Me.GridControlMain)
        Me.Name = "QueryBillFrm"
        Me.Text = "الفواتير"
        CType(Me.GridControlMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControlMain As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewMain As DevExpress.XtraGrid.Views.Grid.GridView
End Class
