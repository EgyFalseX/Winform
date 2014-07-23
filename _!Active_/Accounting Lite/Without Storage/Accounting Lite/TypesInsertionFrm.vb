Public Class TypesInsertionFrm
    Private ModTable As DataTable
    Private Sub TypesInsertionFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ModTable = CreateOLETable("SELECT TypeID, TypeName FROM Types")
        CBName.DataSource = ModTable
        CBName.ValueMember = "TypeID"
        CBName.DisplayMember = "TypeName"
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If TxtName.TextLength > 0 Then
            Insertion_Updateing_Deleting("INSERT INTO Types (TypeName, Information, TypeCount, TypeCost) VALUES ('" & TxtName.Text.Trim & "','" & TxtInfo.Text.Trim & "','" & Val(TxtCount.Text.Trim) & "','" & Val(TxtCost.Text.Trim) & "')")
            TypesInsertionFrm_Load(sender, e)
            MsgBox("تمت الاضــافه", MsgBoxStyle.Information)
            TxtCount.Clear()
            TxtName.Clear()
            TxtInfo.Clear()
            TxtName.Focus()
        Else
            MsgBox("خطــــاء", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class