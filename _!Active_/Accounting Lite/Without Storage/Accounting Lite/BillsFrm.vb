Public Class BillsFrm
    Private Sub BillsFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If TxtBillNumber.TextLength > 0 Then
            PrepareToFill()
            Dim TempTable As New DataTable
            TempTable = CreateOLETable("SELECT Types.TypeName, ContainZ.ConCount, ContainZ.ConCost, ContainZ.ContainID FROM (ContainZ INNER JOIN Types ON ContainZ.TypeID = Types.TypeID) WHERE (ContainZ.BillID = " & TxtBillNumber.Text.Trim & ")")
            For i = 0 To TempTable.Rows.Count - 1
                Dim Lvi As New ListViewItem
                Lvi.SubItems.Add(TempTable.Rows(i).Item(1).ToString)
                Lvi.SubItems.Add(TempTable.Rows(i).Item(2).ToString)
                Lvi.SubItems.Add(TempTable.Rows(i).Item(3).ToString)
                LVItems.Items.Add(Lvi).Text = TempTable.Rows(i).Item(0).ToString
                TxtBillValue.Text = Val(TxtBillValue.Text) + (Val(TempTable.Rows(i).Item(1).ToString) * TempTable.Rows(i).Item(2).ToString)
                BtnSaveDiscount.Enabled = True
            Next
            TxtBillValueAfterDiscount.Text = Val(TxtBillValue.Text) - Val(TxtDiscount.Text)
        End If
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
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If Insertion_Updateing_Deleting("INSERT INTO Bills (BillDate,CusName,Information) Values (#" & DTP.Value.ToShortDateString & "#,'" & TxtName.Text.Trim & "','" & TxtInfo.Text.Trim & "')", TxtBillNumber.Text) = Nothing Then
            BtnSaveDiscount.Enabled = True
            PrepareToFill()
        End If
    End Sub
    Public Sub PrepareToFill()
        CBTypesName.DataSource = CreateOLETable("SELECT TypeID, TypeName, Information FROM Types")
        CBTypesName.ValueMember = "TypeID" : CBTypesName.DisplayMember = "TypeName"
        If CBTypesName.Items.Count > 0 Then
            CBTypesName.Enabled = True : CBTypesName.SelectedIndex = 0
            PNL.Enabled = False
            GBInformation.Visible = True
            TxtNotes.Text = CBTypesName.DataSource.rows(CBTypesName.SelectedIndex).item(2).ToString
        Else
            BtnAdd.Enabled = False
        End If
    End Sub
    Private Sub CBTypesName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBTypesName.SelectedIndexChanged
        If CBTypesName.SelectedIndex > -1 Then
            TxtNotes.Text = CBTypesName.DataSource.rows(CBTypesName.SelectedIndex).item(2).ToString
            Return1Value("SELECT TypeCount - (Select Sum(ConCount) From ContainZ Where TypeID=" & CBTypesName.DataSource.rows(CBTypesName.SelectedIndex).item(0).ToString & ") as FalseX FROM Types Where TypeID=" & CBTypesName.DataSource.rows(CBTypesName.SelectedIndex).item(0).ToString, TxtContainCount.Text)
            TxtCount.Text = "0"
            BtnAdd.Enabled = True
        Else
            BtnAdd.Enabled = False
        End If
    End Sub
  
    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        If Val(TxtCount.Text.Trim) <> 0 And Val(TxtCount.Text.Trim) <= Val(TxtContainCount.Text.Trim) Then
            Dim EffectedID As String = ""
            If Insertion_Updateing_Deleting("INSERT INTO ContainZ (BillID, TypeID, ConCount, ConCost) VALUES ('" & TxtBillNumber.Text.Trim & "'," & CBTypesName.SelectedValue.ToString & ",'" & Val(TxtCount.Text.Trim) & "','" & Val(TxtCost.Text.Trim) & "')", EffectedID) = Nothing Then
                Dim lvi As New ListViewItem
                lvi.SubItems.Add(Val(TxtCount.Text.Trim)) : lvi.SubItems.Add(Val(TxtCost.Text.Trim).ToString) : lvi.SubItems.Add(EffectedID)
                LVItems.Items.Add(lvi).Text = CBTypesName.DataSource.Rows(CBTypesName.SelectedIndex).Item(1).ToString
                CBTypesName_SelectedIndexChanged(sender, e)
                CalCBillValue()
                MsgBox("تم الاضــافه", MsgBoxStyle.Information)
                CBTypesName.Focus()
            End If
        Else
            MsgBox("خطــــاء", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub BtnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemove.Click
        If Insertion_Updateing_Deleting("Delete From ContainZ Where ContainID=" & LVItems.Items(LVItems.SelectedIndices(0)).SubItems(3).Text) = Nothing Then
            'I must Reload the items so i can c the removed 1
            LVItems.Items.RemoveAt(LVItems.SelectedIndices(0))
            CalCBillValue()
            MsgBox("تم التعــديل", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub LVItems_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LVItems.SelectedIndexChanged
        If LVItems.SelectedIndices.Count > 0 Then
            BtnRemove.Enabled = True
        Else
            BtnRemove.Enabled = False
        End If
    End Sub
    Private Sub CalCBillValue()
        TxtBillValue.Text = "0"
        For i = 0 To LVItems.Items.Count - 1
            TxtBillValue.Text = Val(TxtBillValue.Text) + (Val(LVItems.Items(i).SubItems(1).Text) * Val(LVItems.Items(i).SubItems(2).Text))
        Next
        TxtBillValueAfterDiscount.Text = Val(TxtBillValue.Text) - Val(TxtDiscount.Text)
    End Sub
    Private Sub BtnSaveDiscount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveDiscount.Click
        If Val(TxtDiscount.Text) >= 0 Then
            If Insertion_Updateing_Deleting("Update Bills Set Discount='" & Val(TxtDiscount.Text) & "' Where BillID=" & TxtBillNumber.Text) = Nothing Then
                CalCBillValue()
                MsgBox("تم التعديل", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("خطــــاء", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        If TxtBillNumber.Text = "" Then
            MsgBox("لا يوجد رقم للفاتوره", MsgBoxStyle.Critical)
            Exit Sub
        End If
        FrmPrinting = New PrintingFrm
        FrmPrinting.DGV.DataSource = CreateOLETable("SELECT Types.TypeName, ContainZ.ConCount, ContainZ.ConCost, ContainZ.ConCount * ContainZ.ConCost AS FalseX FROM (ContainZ INNER JOIN Types ON ContainZ.TypeID = Types.TypeID) WHERE (ContainZ.BillID = " & TxtBillNumber.Text & ")")
        FrmPrinting.TxtBillNumber.Text = Val(TxtBillNumber.Text)
        FrmPrinting.TxtBillValue.Text = Val(TxtBillValue.Text)
        FrmPrinting.TxtDiscount.Text = Val(TxtDiscount.Text)
        FrmPrinting.TxtBillValueAfterDiscount.Text = Val(TxtBillValueAfterDiscount.Text)
        FrmPrinting.TxtInfo.Text = TxtInfo.Text
        FrmPrinting.TxtName.Text = TxtName.Text
        FrmPrinting.LblDate.Text = DTP.Value.ToShortDateString
        FrmPrinting.Show()
    End Sub
    Private Sub HideControlsForPrinting(ByVal Hide As Boolean)
        'Delete Me
        If Hide = True Then
            BtnSave.Visible = False
            PnlTypes.Visible = False
            GBInformation.Visible = False
            BtnSaveDiscount.Visible = False
            BtnRemove.Visible = False
            BtnClose.Visible = False
            BtnPrint.Visible = False
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Me.BackColor = Color.White
        Else
            BtnSave.Visible = True
            PnlTypes.Visible = True
            GBInformation.Visible = True
            BtnSaveDiscount.Visible = True
            BtnRemove.Visible = True
            BtnClose.Visible = True
            BtnPrint.Visible = True
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            Me.BackColor = Windows.Forms.Form.DefaultBackColor
        End If

    End Sub
    Private Sub BtnNewBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewBill.Click
        Me.Close()
        FrmBills = New BillsFrm
        FrmBills.Show()
    End Sub
End Class