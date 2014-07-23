Public Class ItemsInsertionFrm
    Private Sub ItemsInsertionFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CBName.DataSource = CreateOLETable("SELECT ItemID, ItemName FROM Items")
        CBName.ValueMember = "ItemID"
        CBName.DisplayMember = "ItemName"
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Insertion_Updateing_Deleting("INSERT INTO Items (ItemName) VALUES ('" & TxtName.Text.Trim & "')")
        ItemsInsertionFrm_Load(sender, e)
        MsgBox("تمت الاضــافه", MsgBoxStyle.Information)
        TxtName.Clear()
        TxtName.Focus()
        'MsgBox("خطــــاء", MsgBoxStyle.Critical)
    End Sub
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
    Private Sub TxtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtName.TextChanged
        If sender.Text.Trim.Length = 0 Then
            BtnSave.Enabled = False
        Else
            BtnSave.Enabled = True
        End If
    End Sub
End Class