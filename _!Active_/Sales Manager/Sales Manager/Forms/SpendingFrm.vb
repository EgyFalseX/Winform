Public Class SpendingFrm
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If Insertion_Updateing_Deleting("INSERT INTO Spends (SpendValue, SpendDate,SpendInfo) VALUES ('" & Val(TxtCount.Text.Trim) & "',#" & DTP.Value.ToShortDateString & "#,'" & TxtInfo.Text.Trim & "')") = Nothing Then
            TxtCount.Clear() : TxtInfo.Clear()
            DTP.Focus()
            MsgBox("تمت الاضــافه", MsgBoxStyle.Information)
        Else
            MsgBox("خطــــاء", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
    Private Sub TxtCount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCount.TextChanged
        If Val(TxtCount.Text.Trim) > 0 Then
            BtnSave.Enabled = True
        Else
            BtnSave.Enabled = False
        End If
    End Sub
End Class