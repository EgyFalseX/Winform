Public Class FrmQueries
    Dim con As OleDb.OleDbConnection = New OleDb.OleDbConnection(HosPat.My.MySettings.Default.DatabaseConnectionString)
    Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand("", con)
    Dim dr As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter("", con)

    Private Sub FrmQueries_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As DataTable = New DataTable
        dr.SelectCommand.CommandText = "SELECT Visits.VisitID, Visits.VisitDate, Visits.A3rad, Visits.Fa7sSarere, Visits.Estegwab, Visits.T7aleel, Visits.Tash5ees, Visits.Egra2, Visits.S3rEgra2, Visits.Kashfya, Visits.Takreer, Patient.PatientName, Patient.PatientAge, Patient.PatientTelephone, Jobs.JobName, MaritalStatus.MaritalStatusName, Gender.GenderName FROM ((((Visits INNER JOIN Patient ON Visits.PatientID = Patient.PatientID) INNER JOIN Jobs ON Patient.JobID = Jobs.JobID) INNER JOIN MaritalStatus ON Patient.MaritalStatusID = MaritalStatus.MaritalStatusID) INNER JOIN Gender ON Patient.GenderID = Gender.GenderID)"
        dr.Fill(dt)
        DataGridViewMain.DataSource = dt

    End Sub
End Class