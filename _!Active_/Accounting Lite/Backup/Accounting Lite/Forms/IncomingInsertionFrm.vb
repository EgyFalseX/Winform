Public Class IncomingInsertionFrm
    Private SpTable As DataTable
    Private Sub SpendTypeFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SpTable = CreateOLETable("SELECT TypeID, TypeName FROM Types")
        CBName.DataSource = SpTable
        CBName.ValueMember = "TypeID"
        CBName.DisplayMember = "TypeName"
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If TxtCount.TextLength > 0 And CBName.SelectedIndex > -1 Then
            Insertion_Updateing_Deleting("INSERT INTO Incoming (TypeID,InDate,InCount,InValue) VALUES (" & CBName.SelectedValue.ToString.Trim & ",#" & DTP.Value.ToShortDateString & "#,'" & TxtCount.Text.Trim & "','" & TxtValue.Text.Trim & "')")
            SpendTypeFrm_Load(sender, e)
            MsgBox("تمت الاضــافه", MsgBoxStyle.Information)
            TxtCount.Clear()
            TxtValue.Clear()
            TxtCount.Focus()
        Else
            MsgBox("خطــــاء", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class