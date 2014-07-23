Public Class EditorFrm
    Private DS As DataSet
    Private Sub CheckBoxes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChBBill.CheckedChanged, ChBCus.CheckedChanged, ChBMod.CheckedChanged, ChBMoney.CheckedChanged, ChBSto.CheckedChanged, ChBSpend.CheckedChanged, ChBRet.CheckedChanged, ChBDis.CheckedChanged
        Select Case sender.Name.ToString
            Case "ChBMod"
                If sender.Checked = True Then
                    CBMob.DataSource = CreateOLEDS("SELECT TypeID, TypeCode, Cost FROM Types").Tables(0)
                    CBMob.ValueMember = "TypeID" : CBMob.DisplayMember = "TypeCode"
                    If CBMob.Items.Count > 0 Then : GBMod.Enabled = True : CBMob.SelectedIndex = 0 : Else : GBMod.Enabled = False : End If
                Else
                    GBMod.Enabled = False
                End If
            Case "ChBCus"
                If sender.Checked = True Then
                    CBCus.DataSource = CreateOLEDS("SELECT CusID, CusName, CusAddress, CusPhone FROM Customers").Tables(0)
                    CBCus.ValueMember = "CusID" : CBCus.DisplayMember = "CusName"
                    If CBCus.Items.Count > 0 Then : GBCus.Enabled = True : CBCus.SelectedIndex = 0 : Else : GBCus.Enabled = False : End If
                Else
                    GBCus.Enabled = False
                End If
            Case "ChBSto"
                If sender.Checked = True Then
                    CBSto.DataSource = CreateOLEDS("SELECT Adding.AddDate &'     ' & Types.TypeCode &'     ' &  Adding.AddingCount AS FalseX, Adding.AddingID FROM (Adding LEFT OUTER JOIN Types ON Adding.TypeID = Types.TypeID) Order by AddDate").Tables(0)
                    CBSto.ValueMember = "AddingID" : CBSto.DisplayMember = "FalseX"
                    If CBSto.Items.Count > 0 Then : GBSto.Enabled = True : CBSto.SelectedIndex = 0 : Else : GBSto.Enabled = False : End If
                Else
                    GBSto.Enabled = False
                End If
            Case "ChBMoney"
                If sender.Checked = True Then
                    CBCusPay.DataSource = CreateOLEDS("SELECT CusPays.CusPayID, (CusPays.CusDate  & '     ' & Customers.CusName & '     ' & CusPays.Amount) As FalseX FROM  (CusPays LEFT OUTER JOIN Customers ON CusPays.CusID = Customers.CusID) ORDER BY CusPays.CusDate").Tables(0)
                    CBCusPay.ValueMember = "CusPayID" : CBCusPay.DisplayMember = "FalseX"
                    If CBCusPay.Items.Count > 0 Then : GBCusPay.Enabled = True : CBCusPay.SelectedIndex = 0 : Else : GBCusPay.Enabled = False : End If
                Else
                    GBCusPay.Enabled = False
                End If
            Case "ChBBill"
                If sender.Checked = True Then
                    CBBill.DataSource = CreateOLEDS("SELECT     Bills.BillsID, (Bills.BillsID & '     ' & Customers.CusName & '     ' & Bills.BillDate) As FalseX FROM  (Bills LEFT OUTER JOIN  Customers ON Bills.CusID = Customers.CusID) ORDER BY Bills.BillDate").Tables(0)
                    CBBill.ValueMember = "BillsID" : CBBill.DisplayMember = "FalseX"
                    If CBBill.Items.Count > 0 Then
                        GBBills.Enabled = True : CBBill.SelectedIndex = 0
                        CBEmptyBill.DataSource = CreateOLEDS("SELECT Bills.BillsID, (Bills.BillsID & '     ' & Customers.CusName & '     ' & Bills.BillDate) As FalseX FROM  (Bills LEFT OUTER JOIN  Customers ON Bills.CusID = Customers.CusID) WHERE (NOT EXISTS (SELECT BillTypeID FROM BillTypes WHERE (Bills.BillsID = BillID)))").Tables(0)
                        CBEmptyBill.ValueMember = "BillsID" : CBEmptyBill.DisplayMember = "FalseX"
                        If CBEmptyBill.Items.Count > 0 Then : BtnDelEmptyBill.Enabled = True
                        Else : BtnDelEmptyBill.Enabled = False : End If
                    Else : GBBills.Enabled = False : End If
                Else
                    GBBills.Enabled = False
                End If
            Case "ChBRet"
                If sender.Checked = True Then
                    CBRet.DataSource = CreateOLEDS("SELECT Returners.ReturnerID, Returners.ReturnerID & '     ' & Customers.CusName & '     ' & Returners.ReturnerDate AS FalseX FROM (Returners LEFT OUTER JOIN Customers ON Returners.CusID = Customers.CusID) ORDER BY Returners.ReturnerDate").Tables(0)
                    CBRet.ValueMember = "ReturnerID" : CBRet.DisplayMember = "FalseX"
                    If CBRet.Items.Count > 0 Then
                        GBRet.Enabled = True : CBRet.SelectedIndex = 0
                        CBEmpRet.DataSource = CreateOLEDS("SELECT Returners.ReturnerID, Returners.ReturnerID & '     ' & Customers.CusName & '     ' & Returners.ReturnerDate AS FalseX FROM (Returners LEFT OUTER JOIN Customers ON Returners.CusID = Customers.CusID) WHERE (NOT EXISTS (SELECT RetTypeID FROM RetType WHERE (Returners.ReturnerID = ReturnerID)))").Tables(0)

                        CBEmpRet.ValueMember = "ReturnerID" : CBEmpRet.DisplayMember = "FalseX"
                        If CBEmpRet.Items.Count > 0 Then : BtnDelEmpRet.Enabled = True
                        Else : BtnDelEmpRet.Enabled = False : End If
                    Else : GBRet.Enabled = False : End If
                Else
                    GBRet.Enabled = False
                End If
            Case "ChBSpend"
                If sender.Checked = True Then
                    GBSpend.Enabled = True
                    CBSpendType.DataSource = CreateOLEDS("SELECT SpendTypeID, SpendInfo FROM SpendingTypes").Tables(0)
                    CBSpendType.ValueMember = "SpendTypeID" : CBSpendType.DisplayMember = "SpendInfo"
                    If CBSpendType.Items.Count > 0 Then : BtnDelSpendType.Enabled = True : CBSpendType.SelectedIndex = 0 : Else : BtnDelSpendType.Enabled = False : End If
                    CBSpend.DataSource = CreateOLEDS("SELECT Spending.SpendID, Spending.SpendDate & '     ' & Spending.SpendInfo & '          ' & Spending.SpendCount & '          ' & SpendingTypes.SpendInfo AS FalseX, Spending.SpendCount FROM (Spending INNER JOIN SpendingTypes ON Spending.SpendypeID = SpendingTypes.SpendTypeID) ORDER BY Spending.SpendDate").Tables(0)
                    CBSpend.ValueMember = "SpendID" : CBSpend.DisplayMember = "FalseX"
                    If CBSpend.Items.Count > 0 Then : CBSpend.SelectedIndex = 0 : BtnDelSpend.Enabled = True : Else : BtnDelSpend.Enabled = False : End If
                Else
                    GBSpend.Enabled = False
                End If
            Case "ChBDis"
                If sender.Checked = True Then
                    GBDis.Enabled = True
                    CBCusDis.DataSource = CreateOLEDS("SELECT (Discounts.DisDate & '     ' & Customers.CusName & '     ' & Discounts.DisCount) As FalseX, Discounts.DisID FROM (Discounts LEFT OUTER JOIN  Customers ON Discounts.CusID = Customers.CusID)").Tables(0)
                    CBCusDis.ValueMember = "DisID" : CBCusDis.DisplayMember = "FalseX"
                    If CBCusDis.Items.Count > 0 Then : BtnDelDis.Enabled = True : CBCusDis.SelectedIndex = 0 : Else : BtnDelDis.Enabled = False : End If
                Else
                    GBDis.Enabled = False
                End If
        End Select
    End Sub
    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelMod.Click, BtnDelCus.Click, BtnDelSto.Click, BtnDelCusPay.Click, BtnDelBill.Click, BtnDelSpend.Click, BtnDelSpendType.Click, BtnDelEmptyBill.Click, BtnDelRet.Click, BtnDelEmpRet.Click, BtnDelDis.Click
        If MsgBox("Â‹· «‰‹  „ ‹√ﬂœ ø", MsgBoxStyle.YesNo, "Õ‹‹‹–›") = MsgBoxResult.No Then
            Exit Sub
        End If
        Select Case sender.Name.ToString
            Case "BtnDelMod" 'Types
                Insertion_Updateing_Deleting("Delete From [Types] Where [TypeID]=" & CBMob.SelectedValue.ToString)
                CheckBoxes_CheckedChanged(ChBMod, e)
            Case "BtnDelCus" 'Customers
                Insertion_Updateing_Deleting("Delete From [Customers] Where [CusID]=" & CBCus.SelectedValue.ToString)
                CheckBoxes_CheckedChanged(ChBCus, e)
            Case "BtnDelSto" 'Adding
                Insertion_Updateing_Deleting("Delete From [Adding] Where [AddingID]=" & CBSto.SelectedValue.ToString)
                CheckBoxes_CheckedChanged(ChBSto, e)
            Case "BtnDelCusPay" 'CusPays
                Insertion_Updateing_Deleting("Delete From [CusPays] Where [CusPayID]=" & CBCusPay.SelectedValue.ToString)
                CheckBoxes_CheckedChanged(ChBMoney, e)
            Case "BtnDelBill" 'Bills and BillTypes
                Insertion_Updateing_Deleting("Delete From [Bills] Where [BillsID]=" & CBBill.SelectedValue.ToString)
                CheckBoxes_CheckedChanged(ChBBill, e)
            Case "BtnDelRet" 'Ret and RetTypes
                Insertion_Updateing_Deleting("Delete From [Returners] Where [ReturnerID]='" & CBRet.SelectedValue.ToString & "'")
                CheckBoxes_CheckedChanged(ChBRet, e)
            Case "BtnDelSpendType" 'Spend Type'
                Insertion_Updateing_Deleting("Delete From [SpendingTypes] Where [SpendTypeID]=" & CBSpendType.SelectedValue.ToString)
                CheckBoxes_CheckedChanged(ChBSpend, e)
            Case "BtnDelSpend" 'Spending'
                Insertion_Updateing_Deleting("Delete From [Spending] Where [SpendID]=" & CBSpend.SelectedValue.ToString)
                CheckBoxes_CheckedChanged(ChBSpend, e)
            Case "BtnDelEmptyBill" 'Empty Bills
                Insertion_Updateing_Deleting("Delete From [Bills] Where [BillsID]='" & CBEmptyBill.SelectedValue.ToString & "'")
                CheckBoxes_CheckedChanged(ChBBill, e)
            Case "BtnDelEmpRet" 'Empty Ret
                Insertion_Updateing_Deleting("Delete From [Returners] Where [ReturnerID]='" & CBEmpRet.SelectedValue.ToString & "'")
                CheckBoxes_CheckedChanged(ChBRet, e)
            Case "BtnDelDis" 'Discount
                Insertion_Updateing_Deleting("Delete From [Discounts] Where [DisID]=" & CBCusDis.SelectedValue.ToString)
                CheckBoxes_CheckedChanged(ChBDis, e)
        End Select
    End Sub
    Private Sub CB_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBMob.SelectedIndexChanged, CBCus.SelectedIndexChanged, CBSto.SelectedIndexChanged, CBCusPay.SelectedIndexChanged, CBBill.SelectedIndexChanged, CBSpend.SelectedIndexChanged, CBSpendType.SelectedIndexChanged, CBEmptyBill.SelectedIndexChanged
        Select Case sender.Name
            Case "CBMob"
                If CBMob.SelectedIndex > -1 And Val(CBMob.SelectedValue.ToString) > 0 Then
                    TxtModPrice.Text = CBMob.DataSource.Rows(CBMob.SelectedIndex).Item(2).ToString
                Else
                    TxtModPrice.Clear()
                End If
            Case "CBCus"
                If CBCus.SelectedIndex > -1 And Val(CBCus.SelectedValue.ToString) > 0 Then
                    TxtCusAddress.Text = CBCus.DataSource.Rows(CBCus.SelectedIndex).Item(2).ToString
                    TxtCusPhone.Text = CBCus.DataSource.Rows(CBCus.SelectedIndex).Item(3).ToString
                Else
                    TxtCusAddress.Clear()
                    TxtCusPhone.Clear()
                End If
                'Case "CBSto"
                'Case "CBCusPay"
                'Case "CBBill"
        End Select
    End Sub
    Private Sub Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModUpdate.Click, BtnCusUpdate.Click
        Select Case sender.Name
            Case "BtnModUpdate"
                If Val(TxtModPrice.Text.Trim) > 0 Then
                    If MsgBox("Â‹· «‰‹  „ ‹√ﬂœ ø", MsgBoxStyle.YesNo, " ⁄‹œÌ‹‹·") = MsgBoxResult.No Then
                        Exit Sub
                    End If
                    Insertion_Updateing_Deleting("UPDATE Types SET Cost =" & Val(TxtModPrice.Text.Trim) & " Where TypeID=" & CBMob.SelectedValue.ToString)
                    CheckBoxes_CheckedChanged(ChBMod, e)
                    MsgBox(" „ «· ⁄‹‹œÌ‹·", MsgBoxStyle.Information)
                Else
                    MsgBox("Œÿ‹‹‹‹«¡", MsgBoxStyle.Critical)
                End If
            Case "BtnCusUpdate"
                If MsgBox("Â‹· «‰‹  „ ‹√ﬂœ ø", MsgBoxStyle.YesNo, " ⁄‹œÌ‹‹·") = MsgBoxResult.No Then
                    Exit Sub
                End If
                Insertion_Updateing_Deleting("UPDATE Customers SET CusAddress ='" & TxtCusAddress.Text.Trim & "' , CusPhone='" & TxtCusPhone.Text.Trim & "' Where CusID=" & CBCus.SelectedValue.ToString)
                CheckBoxes_CheckedChanged(ChBCus, e)
                MsgBox(" „ «· ⁄‹‹œÌ‹·", MsgBoxStyle.Information)
        End Select
    End Sub
    Private Sub BtnEditBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditBill.Click
        If CBBill.SelectedIndex <> -1 Then
            Dim FrmBills4Editor As New BillsFrm
            FrmBills4Editor.BillID = CBBill.SelectedValue.ToString
            FrmBills4Editor.ShowDialog()
        End If
    End Sub
    Private Sub BtnEditRet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditRet.Click
        If CBRet.SelectedIndex <> -1 Then
            Dim FrmRet4Editor As New ReturnersFrm
            FrmRet4Editor.ReturnerID = CBRet.SelectedValue.ToString
            FrmRet4Editor.ShowDialog()
        End If
    End Sub
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class