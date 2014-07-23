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

    Private Sub BtnVisit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVisit.Click
        Dim VisitFrm As FrmVisit = New FrmVisit
        VisitFrm.ShowDialog()
    End Sub

    Private Sub BtnPat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPat.Click
        Dim PatientFrm As FrmPatient = New FrmPatient
        PatientFrm.ShowDialog()
    End Sub

    Private Sub BtnDrugs_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDrugs.Click
        Dim DrugsFrm As FrmDrugs = New FrmDrugs
        DrugsFrm.ShowDialog()
    End Sub

    Private Sub BtnJobs_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnJobs.Click
        Dim JobsFrm As FrmJob = New FrmJob
        JobsFrm.ShowDialog()
    End Sub

    Private Sub BtnQueries_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQueries.Click
        Dim QueriesFrm As FrmQueries = New FrmQueries
        QueriesFrm.ShowDialog()
    End Sub
End Class