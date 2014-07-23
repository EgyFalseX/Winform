Public Class FrmPatient
    Dim con As OleDb.OleDbConnection = New OleDb.OleDbConnection(HosPat.My.MySettings.Default.DatabaseConnectionString)
    Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand("", con)
    Dim dr As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter("", con)

    Private Sub LoadPatient()
        'Load Genders
        Dim dt As DataTable = New DataTable
        dr.SelectCommand.CommandText = "Select PatientID, PatientName, PatientAddress, PatientAge, PatientTelephone, GenderID, JobID, MaritalStatusID From Patient"
        dr.Fill(dt)
        CBPatient.DataSource = dt
        CBPatient.DisplayMember = "PatientName"
        CBPatient.ValueMember = "PatientID"
    End Sub
    Private Sub FrmPatient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load Genders
        Dim dt1 As DataTable = New DataTable
        dr.SelectCommand.CommandText = "Select GenderID, GenderName From Gender"
        dr.Fill(dt1)
        CBGenderID.DataSource = dt1
        CBGenderID.DisplayMember = "GenderName"
        CBGenderID.ValueMember = "GenderID"
        'Load Jobs
        Dim dt2 As DataTable = New DataTable
        dr.SelectCommand.CommandText = "Select JobID, JobName From Jobs"
        dr.Fill(dt2)
        CBJobID.DataSource = dt2
        CBJobID.DisplayMember = "JobName"
        CBJobID.ValueMember = "JobID"
        'Load MaritalStatus
        Dim dt3 As DataTable = New DataTable
        dr.SelectCommand.CommandText = "Select MaritalStatusID, MaritalStatusName From MaritalStatus"
        dr.Fill(dt3)
        CBMaritalStatusID.DataSource = dt3
        CBMaritalStatusID.DisplayMember = "MaritalStatusName"
        CBMaritalStatusID.ValueMember = "MaritalStatusID"
        'Load Patient
        LoadPatient()
    End Sub
    Private Sub CBPatient_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBPatient.SelectedIndexChanged

        If CBPatient.SelectedIndex = -1 Then
            TxtPatientName.Text = String.Empty
            TxtPatientAddress.Text = String.Empty
            TxtPatientAge.Text = String.Empty
            TxtPatientTelephone.Text = String.Empty
            CBGenderID.SelectedIndex = -1
            CBJobID.SelectedIndex = -1
            CBMaritalStatusID.SelectedIndex = -1
            BtnUpdate.Enabled = False
            Return
        End If
        Dim r As DataRow = CType(CBPatient.DataSource, DataTable).Rows(CBPatient.SelectedIndex)
        TxtPatientName.Text = r("PatientName").ToString()
        TxtPatientAddress.Text = r("PatientAddress").ToString()
        TxtPatientAge.Text = r("PatientAge").ToString()
        TxtPatientTelephone.Text = r("PatientTelephone").ToString()
        CBGenderID.SelectedValue = r("GenderID").ToString()
        CBJobID.SelectedValue = r("JobID").ToString()
        CBMaritalStatusID.SelectedValue = r("MaritalStatusID").ToString()
        BtnUpdate.Enabled = True
    End Sub
    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If CBPatient.SelectedIndex = -1 Then
            Return
        End If
        If MsgBox("هل انت متأكد؟", MsgBoxStyle.YesNo, "تحزير") = MsgBoxResult.No Then
            Return
        End If
        cmd.CommandText = "Delete From Patient Where PatientID = " & CBPatient.SelectedValue
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("تم الحذف", MsgBoxStyle.Information, "تمت العمليه")
        LoadPatient()
    End Sub
    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        Dim GenderID As String = ""
        Dim JobID As String = ""
        Dim MaritalStatusID As String = ""

        If CBGenderID.SelectedIndex <> -1 Then
            GenderID = CBGenderID.SelectedValue
        End If
        If CBJobID.SelectedIndex <> -1 Then
            JobID = CBJobID.SelectedValue
        End If
        If CBMaritalStatusID.SelectedIndex <> -1 Then
            MaritalStatusID = CBMaritalStatusID.SelectedValue
        End If
        cmd.CommandText = String.Format("Insert into Patient (PatientName, PatientAddress, PatientAge, PatientTelephone, GenderID, JobID, MaritalStatusID) VALUES ('{0}', '{1}', '{2}', '{3}', {4} , {5}, {6})", TxtPatientName.Text, TxtPatientAddress.Text, TxtPatientAge.Text, TxtPatientTelephone.Text, GenderID, JobID, MaritalStatusID)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("تم الاضافه", MsgBoxStyle.Information, "تمت العمليه")
        LoadPatient()

    End Sub
    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click

        If CBPatient.SelectedIndex = -1 Then
            Return
        End If

        Dim GenderID As String = ""
        Dim JobID As String = ""
        Dim MaritalStatusID As String = ""

        If CBGenderID.SelectedIndex <> -1 Then
            GenderID = CBGenderID.SelectedValue
        End If
        If CBJobID.SelectedIndex <> -1 Then
            JobID = CBJobID.SelectedValue
        End If
        If CBMaritalStatusID.SelectedIndex <> -1 Then
            MaritalStatusID = CBMaritalStatusID.SelectedValue
        End If
        cmd.CommandText = String.Format("Update Patient Set PatientName = '{0}', PatientAddress = '{1}', PatientAge = '{2}', PatientTelephone = '{3}', GenderID = {4}, JobID = {5}, MaritalStatusID = {6} Where PatientID = {7}", TxtPatientName.Text, TxtPatientAddress.Text, TxtPatientAge.Text, TxtPatientTelephone.Text, GenderID, JobID, MaritalStatusID, CBPatient.SelectedValue)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("تم التعديل", MsgBoxStyle.Information, "تمت العمليه")
        LoadPatient()
    End Sub
    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        TxtPatientName.Text = String.Empty
        TxtPatientAddress.Text = String.Empty
        TxtPatientAge.Text = String.Empty
        TxtPatientTelephone.Text = String.Empty
        CBGenderID.SelectedIndex = -1
        CBJobID.SelectedIndex = -1
        CBMaritalStatusID.SelectedIndex = -1
        CBPatient.SelectedIndex = -1
        BtnUpdate.Enabled = False
    End Sub

End Class