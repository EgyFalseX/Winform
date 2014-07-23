Public Class QueriesFrm
    Private Sub BtnAllItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAllItems.Click
        Dim T As DataTable
        Dim Int As Int16
        TxtTotal.Text = 0
        T = CreateOLETable("SELECT Types.TypeID, Types.TypeName, Types.Information,(Select IIF(Isnull(Sum(InCount)), '0', Sum(InCount)) As CCount1 from Incoming Where Incoming.TypeID = Types.TypeID) - (Select IIF(Isnull(SUM(ConCount)), '0', SUM(ConCount)) As CCount2 from ContainZ Where ContainZ.TypeID = Types.TypeID) As remaining FROM (Types LEFT OUTER JOIN Incoming ON Types.TypeID = Incoming.TypeID) GROUP BY Types.TypeName, Types.Information, Types.TypeID")
        T.Columns.Add("Value")
        Me.Enabled = False
        For i = 0 To T.Rows.Count - 1
            ItemsCostInStorage("SELECT (Incoming.InCount - IIF(Isnull(SUM(ContainZ.ConCount)), '0', SUM(ContainZ.ConCount))) * Incoming.InValue AS FalseX FROM (Incoming LEFT OUTER JOIN ContainZ ON Incoming.IncomingID = ContainZ.IncomingID) WHERE (Incoming.TypeID = " & T.Rows(i).Item(0).ToString.Trim & ") GROUP BY Incoming.InCount, Incoming.IncomingID, Incoming.InValue", Int)
            Application.DoEvents()
            T.Rows(i).Item(4) = Int
            TxtTotal.Text += Int
        Next
        Me.Enabled = True
        DGVItems.DataSource = T
    End Sub
    Private Sub BtnItemSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnItemSearch.Click
        TxtTotal.Text = 0
        If CBItemsSearch.SelectedIndex > -1 And TxtItemSearch.Text.Trim.Length > 0 Then
            Select Case CBItemsSearch.SelectedIndex
                Case 0
                    Dim T As DataTable
                    Dim Int As Int16
                    T = CreateOLETable("SELECT Types.TypeID, Types.TypeName, Types.Information,(Select IIF(Isnull(Sum(InCount)), '0', Sum(InCount)) As CCount1 from Incoming Where Incoming.TypeID = Types.TypeID) - (Select IIF(Isnull(SUM(ConCount)), '0', SUM(ConCount)) As CCount2 from ContainZ Where ContainZ.TypeID = Types.TypeID) As remaining FROM (Types LEFT OUTER JOIN Incoming ON Types.TypeID = Incoming.TypeID) Where TypeName like '%" & TxtItemSearch.Text.Trim & "%'  GROUP BY Types.TypeName, Types.Information, Types.TypeID")
                    T.Columns.Add("Value")
                    For i = 0 To T.Rows.Count - 1
                        ItemsCostInStorage("SELECT (Incoming.InCount - IIF(Isnull(SUM(ContainZ.ConCount)), '0', SUM(ContainZ.ConCount))) * Incoming.InValue AS FalseX FROM (Incoming LEFT OUTER JOIN ContainZ ON Incoming.IncomingID = ContainZ.IncomingID) WHERE (Incoming.TypeID = " & T.Rows(i).Item(0).ToString.Trim & ") GROUP BY Incoming.InCount, Incoming.IncomingID, Incoming.InValue", Int)
                        T.Rows(i).Item(4) = Int
                        TxtTotal.Text += Int
                    Next
                    DGVItems.DataSource = T
                Case 1
                    Dim T As DataTable
                    Dim Int As Int16
                    T = CreateOLETable("SELECT Types.TypeID, Types.TypeName, Types.Information,(Select IIF(Isnull(Sum(InCount)), '0', Sum(InCount)) As CCount1 from Incoming Where Incoming.TypeID = Types.TypeID) - (Select IIF(Isnull(SUM(ConCount)), '0', SUM(ConCount)) As CCount2 from ContainZ Where ContainZ.TypeID = Types.TypeID) As remaining FROM (Types LEFT OUTER JOIN Incoming ON Types.TypeID = Incoming.TypeID) Where Information like '%" & TxtItemSearch.Text.Trim & "%'  GROUP BY Types.TypeName, Types.Information, Types.TypeID")
                    T.Columns.Add("Value")
                    For i = 0 To T.Rows.Count - 1
                        ItemsCostInStorage("SELECT (Incoming.InCount - IIF(Isnull(SUM(ContainZ.ConCount)), '0', SUM(ContainZ.ConCount))) * Incoming.InValue AS FalseX FROM (Incoming LEFT OUTER JOIN ContainZ ON Incoming.IncomingID = ContainZ.IncomingID) WHERE (Incoming.TypeID = " & T.Rows(i).Item(0).ToString.Trim & ") GROUP BY Incoming.InCount, Incoming.IncomingID, Incoming.InValue", Int)
                        T.Rows(i).Item(4) = Int
                        TxtTotal.Text += Int
                    Next
                    DGVItems.DataSource = T
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
    Private Sub CBGain_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBGain.CheckedChanged
        If CBGain.Checked = True Then
            PnlGainDate.Enabled = False
            'Put code 2 Calc here
            '"SELECT Sum(InCount * InValue) As FalseX FROM Incoming WHERE (InDate BETWEEN '1/1/2000' AND '20/03/2009')"
            Return1Value("SELECT Sum(InCount * InValue) As FalseX FROM Incoming", TxtOutComing.Text)
            Return1Value("SELECT (SELECT SUM(ConCost * ConCount) AS FalseX2 FROM ContainZ) - SUM(Discount) AS FalseX1 FROM Bills", TxtIncoming.Text)
            TxtLastGain.Text = Val(TxtOutComing.Text) - Val(TxtIncoming.Text)
        Else
            PnlGainDate.Enabled = True
        End If
    End Sub
    Private Sub DTPGainDates_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTPStart.ValueChanged, DTPEnd.ValueChanged
        Return1Value("SELECT Sum(InCount * InValue) As FalseX FROM Incoming WHERE (InDate BETWEEN #" & DTPStart.Value.ToShortDateString & "# AND #" & DTPEnd.Value.ToShortDateString & "#)", TxtOutComing.Text)
        Return1Value("SELECT (SELECT SUM(ConCost * ConCount) AS FalseX2 FROM ContainZ) - SUM(Discount) AS FalseX1 FROM Bills WHERE (BillDate BETWEEN #" & DTPStart.Value.ToShortDateString & "# AND #" & DTPEnd.Value.ToShortDateString & "#)", TxtIncoming.Text)
        TxtLastGain.Text = Val(TxtOutComing.Text) - Val(TxtIncoming.Text)
    End Sub
    Private Sub btn2TypePrinting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2TypePrinting.Click
        CloseWindows()
        FrmDialyPrinting = New DialyPrintingFrm
        FrmDialyPrinting.ShowDialog()
    End Sub
End Class