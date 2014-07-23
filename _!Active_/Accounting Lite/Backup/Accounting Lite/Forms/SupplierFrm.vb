Public Class SupplierFrm
    Private Tmr As New Timer
    Private ScnHeight As Int32 = Val(Screen.PrimaryScreen.WorkingArea.Height)
    Private _To As Int32 = 0
    Public Reset_Falg As Boolean
    Private Sub Frm_Supplier_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LbRight.Text = Today.Day & "/  " & Today.Month & "/  " & Today.Year
        Me.TopMost = False
        Me.Location = New Point(Val(Screen.PrimaryScreen.WorkingArea.Width) - Val(Me.Width), Val(Screen.PrimaryScreen.WorkingArea.Height))
        Tmr.Interval = 10
        AddHandler Tmr.Tick, AddressOf Tmr_Tick
        Tmr.Start()
    End Sub
    Private Sub Tmr_Tick(ByVal sender As Object, ByVal e As EventArgs)
        _To += Tmr.Interval
        If _To < Val(Me.Height) Then
            Me.Location = New Point(Me.Location.X, ScnHeight - _To)
        Else
            Me.Location = New Point(Val(Screen.PrimaryScreen.WorkingArea.Width) - Val(Me.Width), Val(Screen.PrimaryScreen.WorkingArea.Height) - Val(Me.Height))
            Me.TopMost = True
            Tmr.Stop()
        End If
    End Sub
    Private Sub SupplierFrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Reset_Falg = False Then
            e.Cancel = True
        End If
    End Sub
    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Process.GetProcessById(Process.GetCurrentProcess.Id).Kill()
    End Sub
    Private Sub Btnmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnmin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub BtnModels_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModels.CheckedChanged, BtnModels.Click
        If BtnModels.Checked = True And FrmTypesInsertion.Visible = False Then
            CloseWindows()
            FrmTypesInsertion = New TypesInsertionFrm
            FrmTypesInsertion.Show()
        End If
    End Sub
    Private Sub BtnIncoming_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIncoming.Click, BtnIncoming.CheckedChanged
        If BtnIncoming.Checked = True And FrmIncomingInsertion.Visible = False Then
            CloseWindows()
            FrmIncomingInsertion = New IncomingInsertionFrm
            FrmIncomingInsertion.Show()
        End If
    End Sub
    Private Sub BtnBills_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBills.CheckedChanged, BtnBills.Click
        If BtnBills.Checked = True And FrmBills.Visible = False Then
            CloseWindows()
            FrmBills = New BillsFrm
            FrmBills.Show()
        End If
    End Sub
    Private Sub BtnEditor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditor.CheckedChanged, BtnEditor.Click
        If BtnEditor.Checked = True And FrmEditor.Visible = False Then
            CloseWindows()
            FrmEditor = New EditorFrm
            FrmEditor.Show()
        End If
    End Sub
    Private Sub BtnQueries_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQueries.Click, BtnQueries.CheckedChanged
        If BtnQueries.Checked = True And FrmQueries.Visible = False Then
            CloseWindows()
            FrmQueries = New QueriesFrm
            FrmQueries.Show()
        End If
    End Sub
    Private Sub BtnOptions_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOptions.CheckedChanged, BtnOptions.Click
        If BtnOptions.Checked = True And FrmOptions.Visible = False Then
            CloseWindows()
            FrmOptions = New OptionsFrm
            FrmOptions.Show()
        End If
    End Sub
#Region "/  Form Moves    /"
    Public x As Int16
    Public y As Int16
    Public fla As Boolean
    Private Sub Frm_Main_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LblTitle.MouseDown
        x = e.X
        y = e.Y
        fla = True
    End Sub
    Private Sub Frm_Main_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LblTitle.MouseUp
        fla = False
    End Sub
    Private Sub Frm_Main_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LblTitle.MouseMove
        If fla = True Then
            Me.Location = New Point(Me.Location.X + (e.X - x), Me.Location.Y + (e.Y - y))
        Else
            Me.Visible = True
        End If

    End Sub
#End Region
End Class