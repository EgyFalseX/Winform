Public Class AddsContainsFrm
    Private Sub AddsContainsFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CBSup.DataSource = CreateOLETable("SELECT SupID, SupName FROM supplier")
        CBSup.ValueMember = "SupID"
        CBSup.DisplayMember = "SupName"
        If CBSup.Items.Count > 0 Then
            CBSup.SelectedIndex = 0
            BtnSave.Enabled = True
        End If
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Insertion_Updateing_Deleting("INSERT INTO Adds (FSupID,AddDate) Values (" & CBSup.SelectedValue.ToString & ",#" & DTP.Value.ToShortDateString & "#)", TxtAddNumber.Text)
        If TxtAddNumber.Text.Trim.Length > 0 Then
            PrepareToFill()
        Else
            BtnSave.Enabled = False
            MsgBox("خطــــاء", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        If Insertion_Updateing_Deleting("INSERT INTO Storage (ItemSN, FItemID, AddID, ItemPrice) VALUES ('" & TxtSerial.Text.Trim & "'," & CBItemsName.SelectedValue.ToString & "," & TxtAddNumber.Text.Trim & ",'" & Val(TxtCost.Text.Trim) & "')") = Nothing Then
            Dim lvi As New ListViewItem
            lvi.SubItems.Add(TxtSerial.Text.Trim) : lvi.SubItems.Add(Val(TxtCost.Text.Trim).ToString)
            LVItems.Items.Add(lvi).Text = CBItemsName.DataSource.Rows(CBItemsName.SelectedIndex).Item(1).ToString
            TxtSerial.Clear() : TxtCost.Clear() : CBItemsName.Focus()
            MsgBox("تمت الاضــافه", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub BtnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemove.Click
        If Insertion_Updateing_Deleting("Delete From Storage Where ItemSN='" & LVItems.Items(LVItems.SelectedIndices(0)).SubItems(1).Text.Trim & "'") = Nothing Then
            LVItems.Items.RemoveAt(LVItems.SelectedIndices(0))
            MsgBox("تمت التعــديل", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub TxtSerial_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSerial.TextChanged
        If sender.Text.Trim.Length = 0 Then
            BtnAdd.Enabled = False
        Else
            BtnAdd.Enabled = True
        End If
    End Sub
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
    Private Sub LVItems_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LVItems.SelectedIndexChanged
        If LVItems.SelectedIndices.Count > 0 Then
            BtnRemove.Enabled = True
        Else
            BtnRemove.Enabled = False
        End If
    End Sub
    Public Sub PrepareToFill()
        CBItemsName.DataSource = CreateOLETable("SELECT ItemID, ItemName FROM Items")
        CBItemsName.ValueMember = "ItemID" : CBItemsName.DisplayMember = "ItemName"
        If CBItemsName.Items.Count > 0 Then
            CBItemsName.SelectedIndex = 0
            TxtSerial.Enabled = True
        Else
            BtnAdd.Enabled = False
        End If
    End Sub
End Class