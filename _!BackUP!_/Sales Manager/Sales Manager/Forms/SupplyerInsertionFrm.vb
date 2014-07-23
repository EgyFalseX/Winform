Public Class SupplyerInsertionFrm
    Private Sub SupInsertionFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CBSup.DataSource = CreateOLETable("SELECT SupID, SupName FROM supplier")
        CBSup.ValueMember = "SupID"
        CBSup.DisplayMember = "SupName"
        If CBSup.Items.Count > 0 Then
            CBSup.SelectedIndex = 0
        Else
            TxtName.Enabled = False
        End If
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Insertion_Updateing_Deleting("INSERT INTO supplier (SupName, SupAddress, SupPhone, SupInfo) VALUES ('" & TxtName.Text.Trim & "','" & TxtAddress.Text.Trim & "','" & TxtPhone.Text.Trim & "','" & TxtInfo.Text.Trim & "')")
        SupInsertionFrm_Load(sender, e)
        MsgBox("تمت الاضــافه", MsgBoxStyle.Information)
        TxtName.Clear() : TxtAddress.Clear() : TxtPhone.Clear() : TxtInfo.Clear() : TxtName.Focus()
    End Sub
    Private Sub TxtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtName.TextChanged
        If sender.Text.Trim.Length = 0 Then
            BtnSave.Enabled = False
        Else
            BtnSave.Enabled = True
        End If
    End Sub
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class