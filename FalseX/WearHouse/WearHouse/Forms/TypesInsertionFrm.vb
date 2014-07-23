Public Class TypesInsertionFrm
    Private ModDS As DataSet
    Private Sub TypesInsertionFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ModDS = CreateOLEDS("SELECT TypeID, TypeCode FROM Types")
        CBName.DataSource = ModDS.Tables(0)
        CBName.ValueMember = "TypeID"
        CBName.DisplayMember = "TypeCode"
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If TxtName.TextLength > 0 And Val(TxtPrice.Text.Trim) > 0 Then
            Insertion_Updateing_Deleting("INSERT INTO Types (TypeCode, Cost) VALUES ('" & TxtName.Text.Trim & "'," & Val(TxtPrice.Text.Trim) & ")")
            TypesInsertionFrm_Load(sender, e)
            MsgBox("تمت الاضــافه", MsgBoxStyle.Information)
            TxtName.Clear()
            TxtPrice.Clear()
            TxtName.Focus()
        Else
            MsgBox("خطــــاء", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class