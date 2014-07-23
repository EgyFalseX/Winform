Public Class ReturnedFrm
    Private Sub ReturnedFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CBSerial.DataSource = CreateOLETable("SELECT ItemSN FROM Storage Where Status=1")
        CBSerial.ValueMember = "ItemSN"
        CBSerial.DisplayMember = "ItemSN"
        If CBSerial.Items.Count > 0 Then
            CBSerial.SelectedIndex = 0
            BtnSave.Enabled = True
        End If
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If Insertion_Updateing_Deleting("Update Storage Set Status=2 , ReturnedDate=#" & DTP.Value.ToShortDateString & "# , ReturnInfo='" & TxtInfo.Text.Trim & "' Where ItemSN='" & CBSerial.SelectedValue.ToString & "'") = Nothing Then
            Insertion_Updateing_Deleting("Delete From BillContain Where FItemSN='" & CBSerial.SelectedValue.ToString & "'")
            BtnSave.Enabled = False
            ReturnedFrm_Load(sender, e)
            TxtInfo.Clear()
            CBSerial.Focus()
            MsgBox("تمت التعــديل", MsgBoxStyle.Information)
        End If
        
    End Sub
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class