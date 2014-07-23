Public Class EditorFrm
    Private DS As DataSet
    Private Sub CheckBoxes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChBBill.CheckedChanged, ChBMod.CheckedChanged, ChBSto.CheckedChanged
        Select Case sender.Name.ToString
            Case "ChBMod"
                If sender.Checked = True Then
                    CBMob.DataSource = CreateOLETable("SELECT TypeID, TypeName, Information FROM Types")
                    CBMob.ValueMember = "TypeID" : CBMob.DisplayMember = "TypeName"
                    If CBMob.Items.Count > 0 Then : GBMod.Enabled = True : CBMob.SelectedIndex = 0 : Else : GBMod.Enabled = False : End If
                Else
                    GBMod.Enabled = False
                End If
            Case "ChBSto"
                If sender.Checked = True Then
                    CBSto.DataSource = CreateOLETable("SELECT Incoming.InDate &'     ' & Types.TypeName &'     ' &  Incoming.InCount AS FalseX, Incoming.IncomingID, Incoming.InCount, Incoming.InValue FROM (Incoming LEFT OUTER JOIN Types ON Incoming.TypeID = Types.TypeID) Order by InDate")
                    CBSto.ValueMember = "IncomingID" : CBSto.DisplayMember = "FalseX"
                    If CBSto.Items.Count > 0 Then : GBSto.Enabled = True : CBSto.SelectedIndex = 0 : Else : GBSto.Enabled = False : End If
                Else
                    GBSto.Enabled = False
                End If
            Case "ChBBill"
                If sender.Checked = True Then
                    CBBill.DataSource = CreateOLETable("SELECT Bills.BillID, (Bills.BillID & '     ' & Bills.CusName & '     ' & Bills.BillDate) As FalseX,Bills.Discount,Bills.CusName,Bills.BillDate,Bills.Information FROM Bills ORDER BY Bills.BillDate")
                    CBBill.ValueMember = "BillID" : CBBill.DisplayMember = "FalseX"
                    If CBBill.Items.Count > 0 Then
                        GBBills.Enabled = True : CBBill.SelectedIndex = 0
                        CBEmptyBill.DataSource = CreateOLETable("SELECT Bills.BillID, (Bills.BillID & '     ' & Bills.CusName & '     ' & Bills.BillDate) As FalseX FROM Bills WHERE (NOT EXISTS (SELECT ContainID FROM ContainZ WHERE (Bills.BillID = BillID)))")
                        CBEmptyBill.ValueMember = "BillID" : CBEmptyBill.DisplayMember = "FalseX"
                        If CBEmptyBill.Items.Count > 0 Then : BtnDelEmptyBill.Enabled = True
                        Else : BtnDelEmptyBill.Enabled = False : End If
                    Else : GBBills.Enabled = False : End If
                Else
                    GBBills.Enabled = False
                End If
        End Select
    End Sub
    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelMod.Click, BtnDelSto.Click, BtnDelBill.Click, BtnDelEmptyBill.Click
        If MsgBox("Â‹· «‰‹  „ ‹√ﬂœ ø", MsgBoxStyle.YesNo, "Õ‹‹‹–›") = MsgBoxResult.No Then
            Exit Sub
        End If
        Select Case sender.Name.ToString
            Case "BtnDelMod" 'Types
                Insertion_Updateing_Deleting("Delete From [Types] Where [TypeID]=" & CBMob.SelectedValue.ToString)
                CheckBoxes_CheckedChanged(ChBMod, e)
            Case "BtnDelSto" 'Adding
                Insertion_Updateing_Deleting("Delete From [Incoming] Where [IncomingID]=" & CBSto.SelectedValue.ToString)
                CheckBoxes_CheckedChanged(ChBSto, e)
            Case "BtnDelBill" 'Bills and BillTypes
                Insertion_Updateing_Deleting("Delete From [Bills] Where [BillID]=" & CBBill.SelectedValue.ToString & "")
                CheckBoxes_CheckedChanged(ChBBill, e)
            Case "BtnDelEmptyBill" 'Empty Bills
                Insertion_Updateing_Deleting("Delete From [Bills] Where [BillID]=" & CBEmptyBill.SelectedValue.ToString)
                CheckBoxes_CheckedChanged(ChBBill, e)
        End Select
    End Sub
    Private Sub CB_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBMob.SelectedIndexChanged
        If CBMob.SelectedIndex > -1 Then
            TxtModName.Text = CBMob.DataSource.Rows(CBMob.SelectedIndex).Item(1).ToString
            TxtModInfo.Text = CBMob.DataSource.Rows(CBMob.SelectedIndex).Item(2).ToString
        Else
            TxtModName.Clear()
        End If
    End Sub
    Private Sub Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModUpdate.Click
        If TxtModName.TextLength > 0 Then
            If MsgBox("Â‹· «‰‹  „ ‹√ﬂœ ø", MsgBoxStyle.YesNo, " ⁄‹œÌ‹‹·") = MsgBoxResult.No Then
                Exit Sub
            End If
            Insertion_Updateing_Deleting("UPDATE Types SET TypeName = '" & TxtModName.Text.Trim & "' , Information= '" & TxtModInfo.Text.Trim & "' Where TypeID=" & CBMob.SelectedValue.ToString)
            CheckBoxes_CheckedChanged(ChBMod, e)
            MsgBox(" „ «· ⁄‹‹œÌ‹·", MsgBoxStyle.Information)
        Else
            MsgBox("Œÿ‹‹‹‹«¡", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub BtnEditBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditBill.Click
        If CBBill.SelectedIndex <> -1 Then
            Dim FrmBills4Editor As New BillsFrm
            FrmBills4Editor.TxtBillNumber.Text = CBBill.SelectedValue.ToString
            FrmBills4Editor.TxtDiscount.Text = CBBill.DataSource.Rows(CBBill.SelectedIndex).Item(2).ToString
            FrmBills4Editor.TxtName.Text = CBBill.DataSource.Rows(CBBill.SelectedIndex).Item(3).ToString
            FrmBills4Editor.DTP.Value = CDate(CBBill.DataSource.Rows(CBBill.SelectedIndex).Item(4).ToString).ToShortDateString
            FrmBills4Editor.TxtNotes.Text = CBBill.DataSource.Rows(CBBill.SelectedIndex).Item(5).ToString
            FrmBills4Editor.TxtBillValue.Text = ""
            FrmBills4Editor.ShowDialog()
            CheckBoxes_CheckedChanged(ChBBill, e)
        End If
    End Sub
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
    Private Sub CBSto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBSto.SelectedIndexChanged
        If CBSto.SelectedIndex = -1 Then
            Exit Sub
        End If
        TxtCountSto.Text = CBSto.DataSource.Rows(CBSto.SelectedIndex).item(2).ToString
        TxtCostSto.Text = CBSto.DataSource.Rows(CBSto.SelectedIndex).item(3).ToString
    End Sub
    Private Sub BtnEditSto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditSto.Click
        If MsgBox("Â‹· «‰‹  „ ‹√ﬂœ ø", MsgBoxStyle.YesNo, " ⁄‹œÌ‹‹·") = MsgBoxResult.No Then
            Exit Sub
        End If
        If Insertion_Updateing_Deleting("Update Incoming Set InCount='" & Val(TxtCountSto.Text) & "', InValue='" & Val(TxtCostSto.Text) & "' Where IncomingID=" & CBSto.SelectedValue.ToString) = Nothing Then
            MsgBox(" „ «· ⁄‹‹œÌ‹·", MsgBoxStyle.Information)
            CheckBoxes_CheckedChanged(ChBSto, e)
        Else
            MsgBox("Œÿ‹‹‹‹«¡", MsgBoxStyle.Critical)
        End If

    End Sub
End Class