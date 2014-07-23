Public Class FrmVisit
    Dim con As OleDb.OleDbConnection = New OleDb.OleDbConnection(HosPat.My.MySettings.Default.DatabaseConnectionString)
    Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand("", con)
    Dim dr As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter("", con)
    Private Sub LoadVisits()
        'Load Genders
        Dim dt As DataTable = New DataTable
        dr.SelectCommand.CommandText = "SELECT VisitID, PatientID, VisitDate, A3rad, Fa7sSarere, Estegwab, T7aleel, Tash5ees, Egra2, S3rEgra2, Kashfya, Takreer, (Select PatientName From Patient Where PatientID = Visits.PatientID) + '   /   ' + Cstr(VisitDate) AS PatientName FROM Visits"
        dr.Fill(dt)
        CBVisits.DataSource = dt
        CBVisits.DisplayMember = "PatientName"
        CBVisits.ValueMember = "VisitID"
    End Sub
    Private Sub ClearFrm()
        CBPatientID.SelectedIndex = -1
        TxtA3rad.Text = String.Empty
        TxtFa7sSarere.Text = String.Empty
        TxtEstegwab.Text = String.Empty
        TxtT7aleel.Text = String.Empty
        TxtTash5ees.Text = String.Empty
        TxtEgra2.Text = String.Empty
        txtS3rEgra2.Text = String.Empty
        TxtKashfya.Text = String.Empty
        TxtTakreer.Text = String.Empty
        BtnUpdate.Enabled = False
    End Sub
    Private Sub FrmVisit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As DataTable = New DataTable
        dr.SelectCommand.CommandText = "Select PatientID, PatientName From Patient"
        dr.Fill(dt)
        CBPatientID.DataSource = dt
        CBPatientID.DisplayMember = "PatientName"
        CBPatientID.ValueMember = "PatientID"
        LoadVisits()
    End Sub
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        ClearFrm()
    End Sub
    Private Sub CBVisits_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBVisits.SelectedIndexChanged
        If CBVisits.SelectedIndex = -1 Then
            ClearFrm()
            Return
        End If
        Dim R As DataRow = CType(CBVisits.DataSource, DataTable).Rows(CBVisits.SelectedIndex)
        CBPatientID.SelectedValue = R("PatientID").ToString()
        DTPVisitDate.Value = R("VisitDate").ToString()
        TxtA3rad.Text = R("A3rad").ToString()
        TxtFa7sSarere.Text = R("Fa7sSarere").ToString()
        TxtEstegwab.Text = R("Estegwab").ToString()
        TxtT7aleel.Text = R("T7aleel").ToString()
        TxtTash5ees.Text = R("Tash5ees").ToString()
        TxtEgra2.Text = R("Egra2").ToString()
        txtS3rEgra2.Text = R("S3rEgra2").ToString()
        TxtKashfya.Text = R("Kashfya").ToString()
        TxtTakreer.Text = R("Takreer").ToString()
        BtnUpdate.Enabled = True
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If CBPatientID.SelectedIndex = -1 Or DTPVisitDate.Value = Nothing Then
            MsgBox("من فضلك ادخل تاريخ و اختار مريض")
            Return
        End If
        cmd.CommandText = "INSERT INTO Visits (PatientID, VisitDate, A3rad, Fa7sSarere, Estegwab, T7aleel, Tash5ees, Egra2, S3rEgra2, Kashfya, Takreer)"
        cmd.CommandText &= String.Format("VALUES ({0}, #{1}#, '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}')", CBPatientID.SelectedValue, DTPVisitDate.Value, TxtA3rad.Text, TxtFa7sSarere.Text, TxtEstegwab.Text, TxtT7aleel.Text, TxtTash5ees.Text, TxtEgra2.Text, txtS3rEgra2.Text, TxtKashfya.Text, TxtTakreer.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("تم الاضافه", MsgBoxStyle.Information)
        LoadVisits()
        ClearFrm()
    End Sub
    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        If CBPatientID.SelectedIndex = -1 Or DTPVisitDate.Value = Nothing Or CBVisits.SelectedIndex = -1 Then
            MsgBox("من فضلك ادخل تاريخ و اختار مريض")
            Return
        End If
        cmd.CommandText = String.Format("UPDATE Visits SET PatientID = {0}, VisitDate = #{1}#, A3rad = '{2}', Fa7sSarere = '{3}', Estegwab = '{4}', T7aleel = '{5}', Tash5ees = '{6}', Egra2 = '{7}', S3rEgra2 = '{8}', Kashfya = '{9}',  Takreer = '{10}' WHERE Visits.VisitID = {11}", CBPatientID.SelectedValue, DTPVisitDate.Value, TxtA3rad.Text, TxtFa7sSarere.Text, TxtEstegwab.Text, TxtT7aleel.Text, TxtTash5ees.Text, TxtEgra2.Text, txtS3rEgra2.Text, TxtKashfya.Text, TxtTakreer.Text, CBVisits.SelectedValue)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("تم التعديل", MsgBoxStyle.Information)
        LoadVisits()
        ClearFrm()
    End Sub
    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If CBVisits.SelectedIndex = -1 Then
            MsgBox("من فضلك اختار زياره")
            Return
        End If
        If MsgBox("هل انت متأكد؟", MsgBoxStyle.YesNo, "تحزير") = MsgBoxResult.No Then
            Return
        End If
        cmd.CommandText = "Delete From Visits Where VisitID = " & CBVisits.SelectedValue
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("تم الحذف", MsgBoxStyle.Information)
        LoadVisits()
        ClearFrm()
    End Sub
End Class