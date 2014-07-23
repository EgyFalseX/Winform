Public Class EditorFrm
    Private DS As DataSet
    Private Sub CheckBoxes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChBBill.CheckedChanged, ChBMod.CheckedChanged
        Select Case sender.Name.ToString
            Case "ChBMod"
                If sender.Checked = True Then
                    CBMob.DataSource = CreateOLETable("SELECT TypeID, TypeName, Information,TypeCount,TypeCost FROM Types")
                    CBMob.ValueMember = "TypeID" : CBMob.DisplayMember = "TypeName"
                    If CBMob.Items.Count > 0 Then : GBMod.Enabled = True : CBMob.SelectedIndex = 0 : Else : GBMod.Enabled = False : End If
                Else
                    GBMod.Enabled = False
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
    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelMod.Click, BtnDelBill.Click, BtnDelEmptyBill.Click
        If MsgBox("Â‹· «‰‹  „ ‹√ﬂœ ø", MsgBoxStyle.YesNo, "Õ‹‹‹–›") = MsgBoxResult.No Then
            Exit Sub
        End If
        Select Case sender.Name.ToString
            Case "BtnDelMod" 'Types
                Insertion_Updateing_Deleting("Delete From [Types] Where [TypeID]=" & CBMob.SelectedValue.ToString)
                CheckBoxes_CheckedChanged(ChBMod, e)
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
            TxtModCost.Text = CBMob.DataSource.Rows(CBMob.SelectedIndex).Item(4).ToString
            TxtModCount.Text = "0"
            Return1Value("SELECT TypeCount - (Select IIF(Isnull(Sum(ConCount)),'0', Sum(ConCount)) From ContainZ Where TypeID=" & CBMob.DataSource.Rows(CBMob.SelectedIndex).Item(0).ToString & ") as FalseX FROM Types Where TypeID=" & CBMob.DataSource.Rows(CBMob.SelectedIndex).Item(0).ToString, TxtModCount.Text)
        Else
            TxtModName.Clear()
        End If
    End Sub
    Private Sub Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModUpdate.Click
        If TxtModName.TextLength > 0 Then
            If MsgBox("Â‹· «‰‹  „ ‹√ﬂœ ø", MsgBoxStyle.YesNo, " ⁄‹œÌ‹‹·") = MsgBoxResult.No Then
                Exit Sub
            End If
            Insertion_Updateing_Deleting("UPDATE Types SET TypeName = '" & TxtModName.Text.Trim & "' , Information= '" & TxtModInfo.Text.Trim & "' , TypeCount='" & Val(CBMob.DataSource.Rows(CBMob.SelectedIndex).Item(3).ToString) + Val(TxtModAdd.Text) & "'  Where TypeID=" & CBMob.SelectedValue.ToString)
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
End Class