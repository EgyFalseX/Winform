Public Class BillsFrm
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
    Private Sub BillsFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'SELECT Adds.AddID FROM (Adds INNER JOIN Storage ON Adds.AddID = Storage.AddID) WHERE (Storage.FItemID = 2) And (Status=0 or Status=2) GROUP BY Adds.AddID
    End Sub
    Private Sub TxtBillNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBillNumber.TextChanged
        If sender.Text.Trim.Length = 0 Then
            BtnSave.Enabled = False
        Else
            BtnSave.Enabled = True
        End If
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If Insertion_Updateing_Deleting("INSERT INTO Bill (BillID,BillDate,BillName) Values ('" & TxtBillNumber.Text.Trim & "',#" & DTP.Value.ToShortDateString & "#,'" & TxtName.Text.Trim & "')") = Nothing Then
            PrepareToFill()
        End If
    End Sub
    Public Sub PrepareToFill()
        CBItemsName.DataSource = CreateOLETable("SELECT ItemID, ItemName FROM Items")
        CBItemsName.ValueMember = "ItemID" : CBItemsName.DisplayMember = "ItemName"
        If CBItemsName.Items.Count > 0 Then
            CBItemsName.Enabled = True : CBItemsName.SelectedIndex = 0
            PNL.Enabled = False
        Else
            BtnAdd.Enabled = False
        End If
    End Sub

    Private Sub CBItemsName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBItemsName.SelectedIndexChanged
        If CBItemsName.SelectedIndex > -1 Then
            CBAdds.DataSource = CreateOLETable("SELECT Adds.AddID FROM (Adds INNER JOIN Storage ON Adds.AddID = Storage.AddID) WHERE (Storage.FItemID = " & CBItemsName.DataSource.rows(CBItemsName.SelectedIndex).item(0).ToString & ") And (Status=0 or Status=2) GROUP BY Adds.AddID")
            CBAdds.ValueMember = "AddID" : CBAdds.DisplayMember = "AddID"
            If CBAdds.Items.Count > 0 Then
                CBAdds.Enabled = True : CBAdds.SelectedIndex = 0
            End If
        End If
    End Sub
    Private Sub CBAdds_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBAdds.SelectedIndexChanged
        If CBAdds.SelectedIndex > -1 Then
            CBSerial.DataSource = CreateOLETable("SELECT ItemSN, ItemPrice, ReturnedDate, ReturnInfo FROM Storage WHERE (FItemID = " & CBItemsName.DataSource.rows(CBItemsName.SelectedIndex).item(0).ToString & ") AND (Status = 0 OR Status = 2) AND (AddID = " & CBAdds.DataSource.rows(CBAdds.SelectedIndex).item(0).ToString & ")")
            CBSerial.ValueMember = "ItemPrice" : CBSerial.DisplayMember = "ItemSN"
            If CBSerial.Items.Count > 0 Then
                CBSerial.Enabled = True : CBSerial.SelectedIndex = 0
            End If
        End If
    End Sub
    Private Sub CBSerial_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBSerial.SelectedIndexChanged
        If CBSerial.SelectedIndex > -1 Then
            BtnAdd.Enabled = True
            TxtCost.Text = CBSerial.DataSource.rows(CBSerial.SelectedIndex).item(1).ToString
            If CBSerial.DataSource.Rows(CBSerial.SelectedIndex).Item(2).ToString <> Nothing Then
                LblDate.Text = CBSerial.DataSource.Rows(CBSerial.SelectedIndex).Item(2).ToString
                If CBSerial.DataSource.Rows(CBSerial.SelectedIndex).Item(3).ToString <> Nothing Then
                    TxtInfo.Text = CBSerial.DataSource.Rows(CBSerial.SelectedIndex).Item(3).ToString
                End If
                GBReturned.Visible = True
            Else
                GBReturned.Visible = False
            End If
        Else
            BtnAdd.Enabled = False
        End If
    End Sub
    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        If Insertion_Updateing_Deleting("INSERT INTO BillContain (FBillID, FItemID, FItemSN, Price) VALUES ('" & TxtBillNumber.Text.Trim & "'," & CBItemsName.SelectedValue.ToString & ",'" & CBSerial.DataSource.rows(CBSerial.SelectedIndex).item(0).ToString & "','" & Val(TxtCost.Text.Trim) & "')") = Nothing Then
            Insertion_Updateing_Deleting("UpDate Storage Set Status=1 Where ItemSN='" & CBSerial.DataSource.rows(CBSerial.SelectedIndex).item(0).ToString & "'")
            Dim lvi As New ListViewItem
            lvi.SubItems.Add(CBSerial.DataSource.rows(CBSerial.SelectedIndex).item(0).ToString) : lvi.SubItems.Add(Val(TxtCost.Text.Trim).ToString)
            LVItems.Items.Add(lvi).Text = CBItemsName.DataSource.Rows(CBItemsName.SelectedIndex).Item(1).ToString
            CBSerial.DataSource = Nothing
            CBAdds.DataSource = Nothing
            CBItemsName_SelectedIndexChanged(sender, e)
            MsgBox("تمت الاضــافه", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub BtnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemove.Click
        If Insertion_Updateing_Deleting("Delete From BillContain Where FBillID='" & TxtBillNumber.Text.Trim & "' And FItemSN='" & LVItems.Items(LVItems.SelectedIndices(0)).SubItems(1).Text.Trim & "'") = Nothing Then
            Insertion_Updateing_Deleting("UpDate Storage Set Status=0 Where ItemSN='" & LVItems.Items(LVItems.SelectedIndices(0)).SubItems(1).Text.Trim & "'")
            'I must Reload the items so i can c the removed 1
            LVItems.Items.RemoveAt(LVItems.SelectedIndices(0))
            MsgBox("تمت التعــديل", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub LVItems_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LVItems.SelectedIndexChanged
        If LVItems.SelectedIndices.Count > 0 Then
            BtnRemove.Enabled = True
        Else
            BtnRemove.Enabled = False
        End If
    End Sub
End Class