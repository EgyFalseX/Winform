Public Class EditorFrm
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
#Region "         - Items -        "
    Private Sub ChBItems_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChBItems.CheckedChanged
        If ChBItems.Checked = True Then
            CBItems.DataSource = CreateOLETable("SELECT ItemID, ItemName FROM Items")
            CBItems.ValueMember = "ItemID"
            CBItems.DisplayMember = "ItemName"
            If CBItems.Items.Count > 0 Then
                CBItems.SelectedIndex = 0
                GBItems.Enabled = True
            Else
                GBItems.Enabled = False
            End If
        Else
            GBItems.Enabled = False
        End If
    End Sub
    Private Sub CBItems_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBItems.SelectedIndexChanged
        If CBItems.SelectedIndex > -1 Then
            TxtItemName.Text = CBItems.DataSource.rows(CBItems.SelectedIndex).item(1).ToString
        Else
            TxtItemName.Clear()
        End If
    End Sub
    Private Sub BtnItemsUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnItemsUpdate.Click
        If Insertion_Updateing_Deleting("Update Items Set ItemName='" & TxtItemName.Text.Trim & "' Where ItemID=" & CBItems.DataSource.rows(CBItems.SelectedIndex).item(0).ToString) = Nothing Then
            TxtItemName.Clear()
            MsgBox(" „  «· ⁄‹‹‹œÌ·", MsgBoxStyle.Information)
            ChBItems_CheckedChanged(sender, e)
        Else
            MsgBox("Œÿ‹‹‹‹«¡", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub TxtItemName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtItemName.TextChanged
        If sender.Text.Trim.Length > 0 Then
            BtnItemsUpdate.Enabled = True
        Else
            BtnItemsUpdate.Enabled = False
        End If
    End Sub
    Private Sub BtnDelItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelItem.Click
        If MsgBox("Â‹‹· «‰  „ √ﬂ‹‹‹‹œ", MsgBoxStyle.YesNo, "Õ‹‹‹–›") = MsgBoxResult.No Then
            Exit Sub
        End If
        If Insertion_Updateing_Deleting("Delete From Items Where ItemID=" & CBItems.DataSource.rows(CBItems.SelectedIndex).item(0).ToString) = Nothing Then
            ChBItems_CheckedChanged(sender, e)
            MsgBox(" „  «· ⁄‹‹‹œÌ·", MsgBoxStyle.Information)
        Else
            MsgBox("Œÿ‹‹‹‹«¡", MsgBoxStyle.Critical)
        End If
    End Sub
#End Region
#Region "         - Suppliers -        "
    Private Sub ChBSup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChBSup.CheckedChanged
        If ChBSup.Checked = True Then
            CBSup.DataSource = CreateOLETable("SELECT SupID, SupName, SupAddress, SupPhone, SupInfo FROM supplier")
            CBSup.ValueMember = "SupID"
            CBSup.DisplayMember = "SupName"
            If CBSup.Items.Count > 0 Then
                CBSup.SelectedIndex = 0
                GBSup.Enabled = True
            Else
                GBSup.Enabled = False
            End If
        Else
            GBSup.Enabled = False
        End If
    End Sub
    Private Sub CBSup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBSup.SelectedIndexChanged
        If CBSup.SelectedIndex > -1 Then
            TxtSupName.Text = CBSup.DataSource.rows(CBSup.SelectedIndex).item(1).ToString
            TxtSupAddress.Text = CBSup.DataSource.rows(CBSup.SelectedIndex).item(2).ToString
            TxtSupPhone.Text = CBSup.DataSource.rows(CBSup.SelectedIndex).item(3).ToString
            TxtSupInfo.Text = CBSup.DataSource.rows(CBSup.SelectedIndex).item(4).ToString
        Else
            TxtSupName.Clear() : TxtSupAddress.Clear() : TxtSupPhone.Clear() : TxtSupInfo.Clear()
        End If
    End Sub
    Private Sub BtnSupUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSupUpdate.Click
        If Insertion_Updateing_Deleting("Update supplier Set SupName='" & TxtSupName.Text.Trim & "' , SupAddress='" & TxtSupAddress.Text.Trim & "' , SupPhone='" & TxtSupPhone.Text.Trim & "' , SupInfo='" & TxtSupInfo.Text.Trim & "' Where SupID=" & CBSup.DataSource.rows(CBSup.SelectedIndex).item(0).ToString) = Nothing Then
            TxtSupName.Clear()
            MsgBox(" „  «· ⁄‹‹‹œÌ·", MsgBoxStyle.Information)
            ChBSup_CheckedChanged(sender, e)
        Else
            MsgBox("Œÿ‹‹‹‹«¡", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub TxtSupName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSupName.TextChanged
        If sender.Text.Trim.Length > 0 Then
            BtnSupUpdate.Enabled = True
        Else
            BtnSupUpdate.Enabled = False
        End If
    End Sub
    Private Sub BtnDelSup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelSup.Click
        If MsgBox("Â‹‹· «‰  „ √ﬂ‹‹‹‹œ", MsgBoxStyle.YesNo, "Õ‹‹‹–›") = MsgBoxResult.No Then
            Exit Sub
        End If
        If Insertion_Updateing_Deleting("Delete From supplier Where SupID=" & CBSup.DataSource.rows(CBSup.SelectedIndex).item(0).ToString) = Nothing Then
            ChBSup_CheckedChanged(sender, e)
            MsgBox(" „  «· ⁄‹‹‹œÌ·", MsgBoxStyle.Information)
        Else
            MsgBox("Œÿ‹‹‹‹«¡", MsgBoxStyle.Critical)
        End If
    End Sub
#End Region
#Region "         - Employees -        "
    Private Sub ChBEmps_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChBEmps.CheckedChanged
        If ChBEmps.Checked = True Then
            CBEmps.DataSource = CreateOLETable("SELECT EmpID, EmpName, EmpAddress, EmpPhone, EmpSalary FROM Employees")
            CBEmps.ValueMember = "EmpID"
            CBEmps.DisplayMember = "EmpName"
            If CBEmps.Items.Count > 0 Then
                CBEmps.SelectedIndex = 0
                GBEmps.Enabled = True
            Else
                GBEmps.Enabled = False
            End If
        Else
            GBEmps.Enabled = False
        End If
    End Sub
    Private Sub CBEmps_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBEmps.SelectedIndexChanged
        If CBEmps.SelectedIndex > -1 Then
            TxtEmpName.Text = CBEmps.DataSource.rows(CBEmps.SelectedIndex).item(1).ToString
            TxtEmpAddress.Text = CBEmps.DataSource.rows(CBEmps.SelectedIndex).item(2).ToString
            TxtEmpPhone.Text = CBEmps.DataSource.rows(CBEmps.SelectedIndex).item(3).ToString
            TxtEmpSalary.Text = CBEmps.DataSource.rows(CBEmps.SelectedIndex).item(4).ToString
        Else
            TxtEmpName.Clear() : TxtEmpAddress.Clear() : TxtEmpPhone.Clear() : TxtEmpSalary.Clear()
        End If
    End Sub
    Private Sub BtnEmpUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEmpUpdate.Click
        If Insertion_Updateing_Deleting("Update Employees Set EmpName='" & TxtEmpName.Text.Trim & "' , EmpAddress='" & TxtEmpAddress.Text.Trim & "' , EmpPhone='" & TxtEmpPhone.Text.Trim & "' , EmpSalary='" & TxtEmpSalary.Text.Trim & "' Where EmpID=" & CBEmps.DataSource.rows(CBEmps.SelectedIndex).item(0).ToString) = Nothing Then
            TxtEmpName.Clear()
            MsgBox(" „  «· ⁄‹‹‹œÌ·", MsgBoxStyle.Information)
            ChBEmps_CheckedChanged(sender, e)
        Else
            MsgBox("Œÿ‹‹‹‹«¡", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub TxtEmpName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtEmpName.TextChanged
        If sender.Text.Trim.Length > 0 Then
            BtnEmpUpdate.Enabled = True
        Else
            BtnEmpUpdate.Enabled = False
        End If
    End Sub
    Private Sub BtnDelEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelEmp.Click
        If MsgBox("Â‹‹· «‰  „ √ﬂ‹‹‹‹œ", MsgBoxStyle.YesNo, "Õ‹‹‹–›") = MsgBoxResult.No Then
            Exit Sub
        End If
        If Insertion_Updateing_Deleting("Delete From Employees Where EmpID=" & CBEmps.DataSource.rows(CBEmps.SelectedIndex).item(0).ToString) = Nothing Then
            ChBEmps_CheckedChanged(sender, e)
            MsgBox(" „  «· ⁄‹‹‹œÌ·", MsgBoxStyle.Information)
        Else
            MsgBox("Œÿ‹‹‹‹«¡", MsgBoxStyle.Critical)
        End If
    End Sub
#End Region
#Region "         - Adds -        "
    Private Sub ChBAdds_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChBAdds.CheckedChanged
        If ChBAdds.Checked = True Then
            CBAdds.DataSource = CreateOLETable("SELECT Adds.AddID, Adds.AddID &'     ' &  Adds.AddDate &'     ' &  supplier.SupName AS FalseX, Adds.AddDate, supplier.SupName, Adds.FSupID FROM (Adds INNER JOIN supplier ON Adds.FSupID = supplier.SupID)")
            CBAdds.ValueMember = "AddID"
            CBAdds.DisplayMember = "FalseX"
            CBAddSups.DataSource = CreateOLETable("SELECT SupID, SupName FROM supplier")
            CBAddSups.ValueMember = "SupID"
            CBAddSups.DisplayMember = "SupName"
            If CBAdds.Items.Count > 0 Then
                CBAdds.SelectedIndex = 0
                GBAdds.Enabled = True
            Else
                GBAdds.Enabled = False
            End If
            SelectingAddDetails()
        Else
            GBAdds.Enabled = False
        End If
    End Sub
    Private Sub CBCusPay_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBAdds.SelectedIndexChanged
        SelectingAddDetails()
    End Sub
    Private Sub BtnAddUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddUpdate.Click
        If Insertion_Updateing_Deleting("Update Adds Set FSupID=" & CBAddSups.DataSource.rows(CBAddSups.SelectedIndex).item(0).ToString & " , AddDate=#" & DTPAdds.Value.ToShortDateString & "# Where AddID=" & CBAdds.DataSource.rows(CBAdds.SelectedIndex).item(0).ToString) = Nothing Then
            MsgBox(" „  «· ⁄‹‹‹œÌ·", MsgBoxStyle.Information)
            ChBAdds_CheckedChanged(sender, e)
        Else
            MsgBox("Œÿ‹‹‹‹«¡", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub BtnAddContainEditor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddContainEditor.Click
        If FrmAddsContains.Visible = True Then
            FrmAddsContains.Focus()
            Exit Sub
        End If
        FrmAddsContains = New AddsContainsFrm
        FrmAddsContains.TxtAddNumber.Text = CBAdds.DataSource.rows(CBAdds.SelectedIndex).item(0).ToString
        Dim DT As New DataTable
        DT = CreateOLETable("SELECT Items.ItemName, Storage.ItemSN, Storage.ItemPrice FROM ((Storage INNER JOIN Adds ON Storage.AddID = Adds.AddID) INNER JOIN Items ON Storage.FItemID = Items.ItemID) WHERE Storage.AddID = " & CBAdds.DataSource.rows(CBAdds.SelectedIndex).item(0).ToString)
        For i = 0 To DT.Rows.Count - 1
            Dim lvi As New ListViewItem
            lvi.SubItems.Add(DT.Rows(i).Item(1).ToString) : lvi.SubItems.Add(Val(DT.Rows(i).Item(2).ToString).ToString)
            FrmAddsContains.LVItems.Items.Add(lvi).Text = DT.Rows(i).Item(0).ToString
        Next
        FrmAddsContains.PrepareToFill()
        FrmAddsContains.PNL.Enabled = False
        FrmAddsContains.CBSup.Visible = False
        FrmAddsContains.DTP.Visible = False
        FrmAddsContains.Show()
    End Sub
    Private Sub BtnDelAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelAdd.Click
        If MsgBox("Â‹‹· «‰  „ √ﬂ‹‹‹‹œ", MsgBoxStyle.YesNo, "Õ‹‹‹–›") = MsgBoxResult.No Then
            Exit Sub
        End If
        If Insertion_Updateing_Deleting("Delete From Adds Where AddID=" & CBAdds.DataSource.rows(CBAdds.SelectedIndex).item(0).ToString) = Nothing Then
            ChBAdds_CheckedChanged(sender, e)
            MsgBox(" „  «· ⁄‹‹‹œÌ·", MsgBoxStyle.Information)
        Else
            MsgBox("Œÿ‹‹‹‹«¡", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub SelectingAddDetails()
        DTPAdds.Value = CDate(CBAdds.DataSource.rows(CBAdds.SelectedIndex).item(2)).ToShortDateString
        If CBAddSups.Items.Count > 0 Then
            For i = 0 To CBAddSups.Items.Count - 1
                If CBAddSups.DataSource.rows(i).item(0).ToString = CBAdds.DataSource.rows(CBAdds.SelectedIndex).item(4).ToString Then
                    CBAddSups.SelectedIndex = i
                    Exit For
                End If
            Next
        Else
            GBAdds.Enabled = False
        End If
    End Sub
#End Region
#Region "         - Returners -        "
    Private Sub ChBReturners_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChBReturners.CheckedChanged
        If ChBReturners.Checked = True Then
            CBReturners.DataSource = CreateOLETable("SELECT ItemSN, ReturnedDate, ReturnInfo FROM Storage Where Status=2")
            CBReturners.ValueMember = "ItemSN"
            CBReturners.DisplayMember = "ItemSN"
            If CBReturners.Items.Count > 0 Then
                CBReturners.SelectedIndex = 0
                GBReturners.Enabled = True
            Else
                GBReturners.Enabled = False
            End If
        Else
            GBReturners.Enabled = False
        End If
    End Sub
    Private Sub CBReturners_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBReturners.SelectedIndexChanged
        DTPRet.Value = CDate(CBReturners.DataSource.rows(CBReturners.SelectedIndex).item(1).ToString).ToShortDateString
        TxtRetInfo.Text = CBReturners.DataSource.rows(CBReturners.SelectedIndex).item(2).ToString
    End Sub
    Private Sub BtnRetUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRetUpdate.Click
        If Insertion_Updateing_Deleting("Update Storage Set ReturnedDate=#" & DTPRet.Value.ToShortDateString & "# ,ReturnInfo='" & TxtRetInfo.Text.Trim & "' Where ItemSN='" & CBReturners.DataSource.rows(CBReturners.SelectedIndex).item(0).ToString & "'") = Nothing Then
            MsgBox(" „  «· ⁄‹‹‹œÌ·", MsgBoxStyle.Information)
            ChBReturners_CheckedChanged(sender, e)
        Else
            MsgBox("Œÿ‹‹‹‹«¡", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub BtnRetDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRetDel.Click
        If MsgBox("Â‹‹· «‰  „ √ﬂ‹‹‹‹œ", MsgBoxStyle.YesNo, "Õ‹‹‹–›") = MsgBoxResult.No Then
            Exit Sub
        End If
        If Insertion_Updateing_Deleting("Update Storage Set Status=0 ,ReturnedDate=NULL ,ReturnInfo='' Where ItemSN='" & CBReturners.DataSource.rows(CBReturners.SelectedIndex).item(0).ToString & "'") = Nothing Then
            MsgBox(" „  «· ⁄‹‹‹œÌ·", MsgBoxStyle.Information)
            ChBReturners_CheckedChanged(sender, e)
        Else
            MsgBox("Œÿ‹‹‹‹«¡", MsgBoxStyle.Critical)
        End If
    End Sub
#End Region
#Region "         - Bills -        "
    Private Sub ChBBills_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChBBills.CheckedChanged
        If ChBBills.Checked = True Then
            CBBills.DataSource = CreateOLETable("SELECT Bill.BillID, Bill.BillID & '     ' & Bill.BillDate As FalseX, Bill.BillDate, Bill.BillName FROM Bill")
            CBBills.ValueMember = "BillID"
            CBBills.DisplayMember = "FalseX"
            If CBBills.Items.Count > 0 Then
                CBBills.SelectedIndex = 0
                GBBills.Enabled = True
            Else
                GBBills.Enabled = False
            End If
            CBEmptyBills.DataSource = CreateOLETable("SELECT Bill.BillID, Bill.BillID & '     ' & Bill.BillDate As FalseX FROM Bill WHERE (NOT EXISTS (SELECT ContainID FROM BillContain WHERE (Bill.BillID = BillContain.FBillID)))")
            CBEmptyBills.ValueMember = "BillID"
            CBEmptyBills.DisplayMember = "FalseX"
            If CBEmptyBills.Items.Count > 0 Then
                CBEmptyBills.SelectedIndex = 0
                BtnDelEmptyBill.Enabled = True
            Else
                BtnDelEmptyBill.Enabled = False
            End If
        Else
            GBBills.Enabled = False
        End If
    End Sub
    Private Sub CBBills_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBBills.SelectedIndexChanged
        DTPBill.Value = CDate(CBBills.DataSource.rows(CBBills.SelectedIndex).item(2).ToString).ToShortDateString
        TxtBillID.Text = CBBills.DataSource.rows(CBBills.SelectedIndex).item(0).ToString
        TxtBillName.Text = CBBills.DataSource.rows(CBBills.SelectedIndex).item(3).ToString
    End Sub
    Private Sub TxtBillID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBillID.TextChanged
        If sender.Text.Trim.Length > 0 Then
            BtnBillUpdate.Enabled = True
        Else
            BtnBillUpdate.Enabled = False
        End If
    End Sub
    Private Sub BtnBillUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBillUpdate.Click
        If Insertion_Updateing_Deleting("Update Bill Set BillID='" & TxtBillID.Text.Trim & "' , BillDate=#" & DTPBill.Value.ToShortDateString & "# , BillName='" & TxtBillName.Text.Trim & "' Where BillID='" & CBBills.DataSource.rows(CBBills.SelectedIndex).item(0).ToString & "'") = Nothing Then
            MsgBox(" „  «· ⁄‹‹‹œÌ·", MsgBoxStyle.Information)
            ChBBills_CheckedChanged(sender, e)
        Else
            MsgBox("Œÿ‹‹‹‹«¡", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub BtnDelBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelBill.Click
        If MsgBox("Â‹‹· «‰  „ √ﬂ‹‹‹‹œ", MsgBoxStyle.YesNo, "Õ‹‹‹–›") = MsgBoxResult.No Then
            Exit Sub
        End If
        If Insertion_Updateing_Deleting("Delete From Bill Where BillID=" & CBBills.DataSource.rows(CBBills.SelectedIndex).item(0).ToString) = Nothing Then
            ChBBills_CheckedChanged(sender, e)
            MsgBox(" „  «· ⁄‹‹‹œÌ·", MsgBoxStyle.Information)
        Else
            MsgBox("Œÿ‹‹‹‹«¡", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub BtnDelEmptyBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelEmptyBill.Click
        If MsgBox("Â‹‹· «‰  „ √ﬂ‹‹‹‹œ", MsgBoxStyle.YesNo, "Õ‹‹‹–›") = MsgBoxResult.No Then
            Exit Sub
        End If
        If Insertion_Updateing_Deleting("Delete From Bill Where BillID=" & CBEmptyBills.DataSource.rows(CBEmptyBills.SelectedIndex).item(0).ToString) = Nothing Then
            ChBBills_CheckedChanged(sender, e)
            MsgBox(" „  «· ⁄‹‹‹œÌ·", MsgBoxStyle.Information)
        Else
            MsgBox("Œÿ‹‹‹‹«¡", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub BtnBillContainEditor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBillContainEditor.Click
        If FrmBills.Visible = True Then
            FrmBills.Focus()
            Exit Sub
        End If
        FrmBills = New BillsFrm
        FrmBills.TxtBillNumber.Text = CBBills.DataSource.rows(CBBills.SelectedIndex).item(0).ToString
        Dim DT As New DataTable
        DT = CreateOLETable("SELECT Items.ItemName, BillContain.FItemSN, BillContain.Price FROM (BillContain INNER JOIN Items ON BillContain.FItemID = Items.ItemID) WHERE (BillContain.FBillID = '" & CBBills.DataSource.rows(CBBills.SelectedIndex).item(0).ToString & "')")
        For i = 0 To DT.Rows.Count - 1
            Dim lvi As New ListViewItem
            lvi.SubItems.Add(DT.Rows(i).Item(1).ToString) : lvi.SubItems.Add(Val(DT.Rows(i).Item(2).ToString).ToString)
            FrmBills.LVItems.Items.Add(lvi).Text = DT.Rows(i).Item(0).ToString
        Next
        FrmBills.PrepareToFill()
        FrmBills.PNL.Enabled = False
        FrmBills.TxtName.Visible = False
        FrmBills.DTP.Visible = False
        FrmBills.Show()
        ChBBills.Checked = False
    End Sub
#End Region
#Region "         - Maintenace -        "
    Private Sub ChbMaint_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChbMaint.CheckedChanged
        If ChbMaint.Checked = True Then
            CBMaints.DataSource = CreateOLETable("SELECT Maintenance.MaintID, Maintenance.MaintDate & '     ' & Employees.EmpName As FalseX, Maintenance.Income, Maintenance.MaintInfo, Maintenance.MaintDate, Employees.EmpName, Maintenance.FEmpID FROM (Maintenance INNER JOIN Employees ON Maintenance.FEmpID = Employees.EmpID) Order By  Maintenance.MaintDate")
            CBMaints.ValueMember = "MaintID"
            CBMaints.DisplayMember = "FalseX"
            CBMaintEmps.DataSource = CreateOLETable("SELECT EmpID, EmpName FROM Employees")
            CBMaintEmps.ValueMember = "EmpID"
            CBMaintEmps.DisplayMember = "EmpName"
            If CBMaints.Items.Count > 0 Then
                CBMaints.SelectedIndex = 0
                GBMaint.Enabled = True
            Else
                GBMaint.Enabled = False
            End If
        Else
            GBMaint.Enabled = False
        End If
    End Sub
    Private Sub CBMaints_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBMaints.SelectedIndexChanged
        DTPMaint.Value = CDate(CBMaints.DataSource.rows(CBMaints.SelectedIndex).item(4).ToString).ToShortDateString
        TxtMaintValue.Text = CBMaints.DataSource.rows(CBMaints.SelectedIndex).item(2).ToString
        TxtMaintInfo.Text = CBMaints.DataSource.rows(CBMaints.SelectedIndex).item(3).ToString
        If CBMaintEmps.Items.Count > 0 Then
            For i = 0 To CBMaintEmps.Items.Count - 1
                If CBMaintEmps.DataSource.rows(i).item(0).ToString = CBMaints.DataSource.rows(CBMaints.SelectedIndex).item(6).ToString Then
                    CBMaintEmps.SelectedIndex = i
                    Exit For
                End If
            Next
        Else
            GBMaint.Enabled = False
        End If
    End Sub
    Private Sub BtnMaintUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMaintUpdate.Click
        If Insertion_Updateing_Deleting("Update Maintenance Set FEmpID=" & CBMaintEmps.DataSource.rows(CBMaintEmps.SelectedIndex).item(0).ToString & ", Income='" & Val(TxtMaintValue.Text.Trim) & "', MaintInfo='" & TxtMaintInfo.Text.Trim & "', MaintDate=#" & DTPMaint.Value.ToShortDateString & "# Where MaintID=" & CBMaints.DataSource.rows(CBMaints.SelectedIndex).item(0).ToString) = Nothing Then
            MsgBox(" „  «· ⁄‹‹‹œÌ·", MsgBoxStyle.Information)
            ChbMaint_CheckedChanged(sender, e)
        Else
            MsgBox("Œÿ‹‹‹‹«¡", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub BtnMaintDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMaintDel.Click
        If MsgBox("Â‹‹· «‰  „ √ﬂ‹‹‹‹œ", MsgBoxStyle.YesNo, "Õ‹‹‹–›") = MsgBoxResult.No Then
            Exit Sub
        End If
        If Insertion_Updateing_Deleting("Delete From Maintenance Where MaintID=" & CBMaints.DataSource.rows(CBMaints.SelectedIndex).item(0).ToString) = Nothing Then
            ChbMaint_CheckedChanged(sender, e)
            MsgBox(" „  «· ⁄‹‹‹œÌ·", MsgBoxStyle.Information)
        Else
            MsgBox("Œÿ‹‹‹‹«¡", MsgBoxStyle.Critical)
        End If
    End Sub
#End Region
#Region "         - Spending -        "
    Private Sub ChBSpends_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChBSpends.CheckedChanged
        If ChBSpends.Checked = True Then
            CBSpends.DataSource = CreateOLETable("SELECT SpendID, SpendValue, SpendDate, SpendInfo FROM Spends Order By SpendDate")
            CBSpends.ValueMember = "SpendID"
            CBSpends.DisplayMember = "SpendDate"

            If CBSpends.Items.Count > 0 Then
                CBSpends.SelectedIndex = 0
                GBSpends.Enabled = True
            Else
                GBSpends.Enabled = False
            End If
        Else
            GBSpends.Enabled = False
        End If
    End Sub
    Private Sub CBSpends_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBSpends.SelectedIndexChanged
        If CBSpends.SelectedIndex > -1 Then
            DTPSpend.Value = CDate(CBSpends.DataSource.rows(CBSpends.SelectedIndex).item(2).ToString).ToShortDateString
            TxtSpendValue.Text = CBSpends.DataSource.rows(CBSpends.SelectedIndex).item(1).ToString
            TxtSpendInfo.Text = CBSpends.DataSource.rows(CBSpends.SelectedIndex).item(3).ToString
        Else
            GBSpends.Enabled = False
        End If
    End Sub
    Private Sub TxtSpendValue_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSpendValue.TextChanged
        If Val(TxtSpendValue.Text.Trim) > 0 Then
            BtnSpendUpdate.Enabled = True
        Else
            BtnSpendUpdate.Enabled = False
        End If
    End Sub
    Private Sub BtnSpendUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSpendUpdate.Click
        If Insertion_Updateing_Deleting("Update Spends Set SpendValue='" & Val(TxtSpendValue.Text.Trim) & "', SpendDate=#" & DTPSpend.Value.ToShortDateString & "# ,SpendInfo='" & TxtSpendInfo.Text.Trim & "' Where SpendID=" & CBSpends.DataSource.rows(CBSpends.SelectedIndex).item(0).ToString) = Nothing Then
            MsgBox(" „  «· ⁄‹‹‹œÌ·", MsgBoxStyle.Information)
            ChBSpends_CheckedChanged(sender, e)
        Else
            MsgBox("Œÿ‹‹‹‹«¡", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub BtnDelSpend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelSpend.Click
        If MsgBox("Â‹‹· «‰  „ √ﬂ‹‹‹‹œ", MsgBoxStyle.YesNo, "Õ‹‹‹–›") = MsgBoxResult.No Then
            Exit Sub
        End If
        If Insertion_Updateing_Deleting("Delete From Spends Where SpendID=" & CBSpends.DataSource.rows(CBSpends.SelectedIndex).item(0).ToString) = Nothing Then
            ChBSpends_CheckedChanged(sender, e)
            MsgBox(" „  «· ⁄‹‹‹œÌ·", MsgBoxStyle.Information)
        Else
            MsgBox("Œÿ‹‹‹‹«¡", MsgBoxStyle.Critical)
        End If
    End Sub
#End Region
End Class