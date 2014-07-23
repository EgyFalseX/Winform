Public Class FrmDrugs

    Dim con As OleDb.OleDbConnection = New OleDb.OleDbConnection(HosPat.My.MySettings.Default.DatabaseConnectionString)
    Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand("", con)
    Private Sub FrmDrugs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DrugsTableAdapter.Fill(DatabaseDataSet.Drugs)
    End Sub
    Public Sub BtnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDel.Click
        If MsgBox("هل انت متأكد؟", MsgBoxStyle.YesNo, "تحزير") = MsgBoxResult.No Then
            Return
        End If
        con.Open()
        cmd.CommandText = "Delete From Drugs Where DrugID = " + CBDrugs.SelectedValue.ToString()
        cmd.ExecuteNonQuery()
        con.Close()
        DrugsTableAdapter.Fill(DatabaseDataSet.Drugs)
        MsgBox("تم الحذف")
    End Sub
    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        con.Open()
        cmd.CommandText = "INSERT INTO Drugs (DrugName) VALUES ('" + TxtAdd.Text + "')"
        cmd.ExecuteNonQuery()
        con.Close()
        DrugsTableAdapter.Fill(DatabaseDataSet.Drugs)
        MsgBox("تم الاضافه")
    End Sub
    Private Sub CBDrugs_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBDrugs.SelectedIndexChanged
        If CBDrugs.SelectedIndex = -1 Then
            BtnEdit.Enabled = False
            Return
        End If
        TxtEdit.Text = CBDrugs.Text
        BtnEdit.Enabled = True
    End Sub
    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        con.Open()
        cmd.CommandText = "UPDATE Drugs Set DrugName = '" + TxtEdit.Text + "' Where DrugID = " + CBDrugs.SelectedValue.ToString()
        cmd.ExecuteNonQuery()
        con.Close()
        DrugsTableAdapter.Fill(DatabaseDataSet.Drugs)
        MsgBox("تم التعديل")
    End Sub
End Class