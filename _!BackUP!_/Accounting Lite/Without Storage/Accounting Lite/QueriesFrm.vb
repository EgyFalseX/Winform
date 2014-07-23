Public Class QueriesFrm
    Private Sub QueriesFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Loading Gain tab
        Return1Value("SELECT SUM(ConCount * ConCost) AS FalseX FROM ContainZ", TxtIncoming.Text)
        Return1Value("SELECT SUM(TypeCount * TypeCost) AS FalseX FROM Types", TxtOutComing.Text)
        TxtLastGain.Text = Val(TxtIncoming.Text) - Val(TxtOutComing.Text)
    End Sub
    Private Sub BtnAllItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAllItems.Click
        TxtTotal.Text = 0
        DGVItems.DataSource = CreateOLETable("SELECT Types.TypeName, Types.Information, Types.TypeCount - (Select IIF(Isnull(Sum(ConCount)),'0',Sum(ConCount)) From ContainZ Where ContainZ.TypeID = Types.TypeID) AS FalseX, FalseX * Types.TypeCost As MoneyZ FROM Types")
        TxtTotal.Text = Val(DGVItems.DataSource.Compute("Sum(MoneyZ)", "").ToString)

    End Sub
    Private Sub BtnItemSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnItemSearch.Click
        TxtTotal.Text = 0
        If CBItemsSearch.SelectedIndex > -1 And TxtItemSearch.Text.Trim.Length > 0 Then
            Select Case CBItemsSearch.SelectedIndex
                Case 0
                    DGVItems.DataSource = CreateOLETable("SELECT Types.TypeName, Types.Information, Types.TypeCount - (Select IIF(Isnull(Sum(ConCount)),'0',Sum(ConCount)) From ContainZ Where ContainZ.TypeID = Types.TypeID) AS FalseX, FalseX * Types.TypeCost As MoneyZ FROM Types Where TypeName like '%" & TxtItemSearch.Text.Trim & "%'")
                    TxtTotal.Text = Val(DGVItems.DataSource.Compute("Sum(MoneyZ)", "").ToString)
                Case 1
                    DGVItems.DataSource = CreateOLETable("SELECT Types.TypeName, Types.Information, Types.TypeCount - (Select IIF(Isnull(Sum(ConCount)),'0',Sum(ConCount)) From ContainZ Where ContainZ.TypeID = Types.TypeID) AS FalseX, FalseX * Types.TypeCost As MoneyZ FROM Types Where Information like '%" & TxtItemSearch.Text.Trim & "%'")
                    TxtTotal.Text = Val(DGVItems.DataSource.Compute("Sum(MoneyZ)", "").ToString)
            End Select
        End If
    End Sub
    Private Sub BtnBillSearchAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBillSearchAll.Click
        DGVBills.DataSource = CreateOLETable("SELECT Bills.BillID, Bills.CusName, Bills.BillDate, Bills.Information, Bills.Discount, SUM(ContainZ.ConCount * ContainZ.ConCost) - Bills.Discount AS FalseX FROM (Bills INNER JOIN ContainZ ON Bills.BillID = ContainZ.BillID) GROUP BY Bills.BillID, Bills.CusName, Bills.BillDate, Bills.Information, Bills.Discount")
    End Sub
    Private Sub CBBillsearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBBillsearch.SelectedIndexChanged
        Select Case CBBillsearch.SelectedIndex
            Case -1
                Exit Sub
            Case 2
                TxtSearchBill.Visible = False
                DTPSearchBill.Visible = True
            Case Else
                TxtSearchBill.Visible = True
                DTPSearchBill.Visible = False
        End Select
    End Sub
    Private Sub BtnSearchBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearchBill.Click
        If TxtSearchBill.Text.Trim.Length = 0 Then
            Exit Sub
        End If
        Select Case CBBillsearch.SelectedIndex
            Case 0 'رقم الفاتوره
                DGVBills.DataSource = CreateOLETable("SELECT Bills.BillID, Bills.CusName, Bills.BillDate, Bills.Information, Bills.Discount, SUM(ContainZ.ConCount * ContainZ.ConCost) - Bills.Discount AS FalseX FROM (Bills INNER JOIN ContainZ ON Bills.BillID = ContainZ.BillID) Where Bills.BillID = " & TxtSearchBill.Text.Trim & " GROUP BY Bills.BillID, Bills.CusName, Bills.BillDate, Bills.Information, Bills.Discount")
            Case 1 'اسم العميل
                DGVBills.DataSource = CreateOLETable("SELECT Bills.BillID, Bills.CusName, Bills.BillDate, Bills.Information, Bills.Discount, SUM(ContainZ.ConCount * ContainZ.ConCost) - Bills.Discount AS FalseX FROM (Bills INNER JOIN ContainZ ON Bills.BillID = ContainZ.BillID) Where Bills.CusName Like '%" & TxtSearchBill.Text.Trim & "%' GROUP BY Bills.BillID, Bills.CusName, Bills.BillDate, Bills.Information, Bills.Discount")
            Case 2 'التاريخ
                DGVBills.DataSource = CreateOLETable("SELECT Bills.BillID, Bills.CusName, Bills.BillDate, Bills.Information, Bills.Discount, SUM(ContainZ.ConCount * ContainZ.ConCost) - Bills.Discount AS FalseX FROM (Bills INNER JOIN ContainZ ON Bills.BillID = ContainZ.BillID) Where Bills.BillDate = #" & DTPSearchBill.Value.ToShortDateString & "# GROUP BY Bills.BillID, Bills.CusName, Bills.BillDate, Bills.Information, Bills.Discount")
            Case 3 'معلومات
                DGVBills.DataSource = CreateOLETable("SELECT Bills.BillID, Bills.CusName, Bills.BillDate, Bills.Information, Bills.Discount, SUM(ContainZ.ConCount * ContainZ.ConCost) - Bills.Discount AS FalseX FROM (Bills INNER JOIN ContainZ ON Bills.BillID = ContainZ.BillID) Where Bills.Information Like '%" & TxtSearchBill.Text.Trim & "%' GROUP BY Bills.BillID, Bills.CusName, Bills.BillDate, Bills.Information, Bills.Discount")
        End Select
    End Sub
End Class