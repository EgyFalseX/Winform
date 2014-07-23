Public Class FrmMain
    Private Sub FrmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub BtnDrugs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDrugs.Click
        Dim DrugsFrm As FrmDrugs = New FrmDrugs
        DrugsFrm.ShowDialog()
    End Sub
    Private Sub BtnJobs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnJobs.Click
        Dim JobsFrm As FrmJob = New FrmJob
        JobsFrm.ShowDialog()
    End Sub
    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        End
    End Sub
    Private Sub BtnPat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPat.Click
        Dim PatientFrm As FrmPatient = New FrmPatient
        PatientFrm.ShowDialog()
    End Sub

    Private Sub BtnVis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVis.Click
        Dim VisitFrm As FrmVisit = New FrmVisit
        VisitFrm.ShowDialog()
    End Sub
End Class
