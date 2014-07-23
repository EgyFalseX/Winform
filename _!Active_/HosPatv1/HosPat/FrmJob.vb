Public Class FrmJob

    Dim con As OleDb.OleDbConnection = New OleDb.OleDbConnection(HosPat.My.MySettings.Default.DatabaseConnectionString)
    Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand("", con)
    Private Sub FrmJob_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet1.Jobs' table. You can move, or remove it, as needed.
        Me.JobsTableAdapter.Fill(Me.DatabaseDataSet1.Jobs)
    End Sub
    Private Sub CBJobs_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBJobs.SelectedIndexChanged
        If CBJobs.SelectedIndex = -1 Then
            BtnEdit.Enabled = False
            Return
        End If
        TxtEdit.Text = CBJobs.Text
        BtnEdit.Enabled = True
    End Sub
    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        con.Open()
        cmd.CommandText = "UPDATE Jobs Set JobName = '" + TxtEdit.Text + "' Where JobID = " + CBJobs.SelectedValue.ToString()
        cmd.ExecuteNonQuery()
        con.Close()
        JobsTableAdapter.Fill(DatabaseDataSet1.Jobs)
        MsgBox("تم التعديل")
    End Sub
    Private Sub BtnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDel.Click
        If MsgBox("هل انت متأكد؟", MsgBoxStyle.YesNo, "تحزير") = MsgBoxResult.No Then
            Return
        End If
        con.Open()
        cmd.CommandText = "Delete From Jobs Where JobID = " + CBJobs.SelectedValue.ToString()
        cmd.ExecuteNonQuery()
        con.Close()
        JobsTableAdapter.Fill(DatabaseDataSet1.Jobs)
        MsgBox("تم الحذف")
    End Sub
    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        con.Open()
        cmd.CommandText = "INSERT INTO Jobs (JobName) VALUES ('" + TxtAdd.Text + "')"
        cmd.ExecuteNonQuery()
        con.Close()
        JobsTableAdapter.Fill(DatabaseDataSet1.Jobs)
        MsgBox("تم الاضافه")
    End Sub
End Class