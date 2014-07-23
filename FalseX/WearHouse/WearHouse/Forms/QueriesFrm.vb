Public Class QueriesFrm
    Private Sub QueriesFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load All Cus
        CBCusTBCus.DataSource = CreateOLEDS("SELECT CusID, CusName FROM Customers").Tables(0)
        CBCusTBCus.ValueMember = "CusID" : CBCusTBCus.DisplayMember = "CusName"
        If CBCusTBCus.Items.Count > 0 Then
            BtnSearchTBCus.Enabled = True : Else : BtnSearchTBCus.Enabled = False
        End If
        'All SpendTypes
        CBSpendType.DataSource = CreateOLEDS("SELECT SpendTypeID, SpendInfo FROM SpendingTypes").Tables(0)
        CBSpendType.ValueMember = "SpendTypeID" : CBSpendType.DisplayMember = "SpendInfo"
        If CBSpendType.Items.Count < 0 Then
            PnlSpendInfo.Enabled = False
            PnlSpendType.Enabled = False
        End If
        'CalC Final Gain
        Try : OLECon.Open()
            OLECmd.CommandText = "SELECT SUM(Amount) AS FalseX FROM CusPays"
            TxtIncoming.Text = Val(OLECmd.ExecuteScalar.ToString)
            OLECmd.CommandText = "SELECT SUM(SpendCount) AS FalseX FROM Spending"
            TxtOutComing.Text = Val(OLECmd.ExecuteScalar.ToString)
            TxtLastGain.Text = Val(TxtIncoming.Text.Trim) - Val(TxtOutComing.Text.Trim)
        Catch : End Try
        OLECon.Close()
    End Sub
    Private Sub BtnSearchTBCus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearchTBCus.Click
        If CBCusTBCus.SelectedIndex > -1 Then
            Dim BillsT, RetT, PaysT, AllInOne, DisT As New DataTable
            BillsT = CreateOLEDS("SELECT Bills.BillDate AS [A], Bills.BillsID AS [B], SUM(BillTypes.[Count] * BillTypes.Cost) AS [C], '0' As [D], '0' As [E], '0' As [F] FROM (BillTypes RIGHT OUTER JOIN Bills ON BillTypes.BillID = Bills.BillsID) WHERE (Bills.CusID = " & CBCusTBCus.SelectedValue.ToString & ") GROUP BY Bills.BillsID, Bills.BillDate ORDER BY Bills.BillDate").Tables(0)
            RetT = CreateOLEDS("SELECT Returners.ReturnerDate AS [A], Returners.ReturnerID AS [B], '0' As [C] , '0' As [D], '0' As [E], SUM(RetType.[Count] * RetType.Cost) AS [F] FROM (Returners INNER JOIN RetType ON Returners.ReturnerID = RetType.ReturnerID) WHERE (Returners.CusID = " & CBCusTBCus.SelectedValue.ToString & ") GROUP BY Returners.ReturnerID, Returners.ReturnerDate ORDER BY Returners.ReturnerDate").Tables(0)
            PaysT = CreateOLEDS("SELECT CusDate AS [A], CusPayID As [B],'0' As [C], Amount AS [D],'0' As [E],'0' As [F] FROM CusPays WHERE (CusID = " & CBCusTBCus.SelectedValue.ToString & ") GROUP BY CusDate, CusPayID, Amount ORDER BY CusDate").Tables(0)
            DisT = CreateOLEDS("SELECT DisDate As [A], DisID As [B],'0' As [C],'0' As [D], DisCount As [E],'0' As [F] From Discounts Where CusID=" & CBCusTBCus.SelectedValue.ToString).Tables(0)
            AllInOne.Columns.Add("A")
            AllInOne.Columns.Add("B")
            AllInOne.Columns.Add("C")
            AllInOne.Columns.Add("D")
            AllInOne.Columns.Add("E")
            AllInOne.Columns.Add("F")
            For I = 0 To BillsT.Rows.Count - 1
                AllInOne.ImportRow(BillsT.Rows(I))
            Next
            For I = 0 To PaysT.Rows.Count - 1
                AllInOne.ImportRow(PaysT.Rows(I))
            Next
            For I = 0 To DisT.Rows.Count - 1
                AllInOne.ImportRow(DisT.Rows(I))
            Next
            For I = 0 To RetT.Rows.Count - 1
                AllInOne.ImportRow(RetT.Rows(I))
            Next
            DGVTBCus.DataSource = AllInOne
            TxtBillsTBCus.Text = Val(BillsT.Compute("Sum(C)", "").ToString)
            TxtRetTBCus.Text = Val(RetT.Compute("Sum(F)", "").ToString)
            TxtMoneyTBCus.Text = Val(PaysT.Compute("Sum(D)", "").ToString)
            TxtDiscountTBCus.Text = Val(DisT.Compute("Sum(E)", "").ToString)
            TxtResultTBCus.Text = Val(TxtBillsTBCus.Text) - (Val(TxtRetTBCus.Text) + Val(TxtMoneyTBCus.Text) + Val(TxtDiscountTBCus.Text))
        End If
    End Sub
    Private Sub BtnSearchTBSto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearchTBSto.Click
        Dim T1 As DataTable : Dim I As Int16
        TxtResultTBSto.Text = "0"
        T1 = CreateOLEDS("SELECT Types.TypeID,Types.TypeCode, SUM(Adding.AddingCount) AS AddingCount, Types.Cost, '' AS Total FROM (Adding INNER JOIN Types ON Adding.TypeID = Types.TypeID) GROUP BY Types.TypeCode, Types.Cost, Types.TypeID ORDER BY Types.TypeCode").Tables(0)
        Try : OLECon.Open()
            For I = 0 To T1.Rows.Count - 1
                OLECmd.CommandText = "SELECT Sum([Count]) FROM BillTypes WHERE TypeID = " & T1.Rows(I).Item(0).ToString.Trim
                T1.Rows(I).Item(2) -= Val(OLECmd.ExecuteScalar.ToString)
                T1.Rows(I).Item(4) = Val(T1.Rows(I).Item(2).ToString) * Val(T1.Rows(I).Item(3).ToString)
                TxtResultTBSto.Text += Val(T1.Rows(I).Item(4).ToString)
            Next
        Catch : End Try
        OLECon.Close()
        T1.Columns.RemoveAt(0)
        DGVTBSto.DataSource = T1
    End Sub
    Private Sub BtnSearchTBCol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearchTBCol.Click
        Dim IMainT, IDisT, IRetT, PayZ As Int16
        Dim TRet, TDis As New DataTable
        DGVTBCol1.DataSource = CreateOLEDS("SELECT Customers.CusID,Customers.CusName AS [اســـم العمـــيل], SUM(CusPays.Amount) AS [الدفعـــات] FROM (Customers INNER JOIN CusPays ON Customers.CusID = CusPays.CusID) GROUP BY Customers.CusName,Customers.CusID").Tables(0)
        DGVTBCol2.DataSource = CreateOLEDS("SELECT Customers.CusID, Customers.CusName As [اســـم العمـــيل], SUM(BillTypes.[Count] * BillTypes.Cost) AS [المتبقــي] FROM ((BillTypes RIGHT OUTER JOIN Bills ON BillTypes.BillID = Bills.BillsID) RIGHT OUTER JOIN Customers ON Bills.CusID = Customers.CusID) GROUP BY Customers.CusID, Customers.CusName").Tables(0)
        TRet = CreateOLEDS("SELECT Customers.CusID, SUM(RetType.[Count] * RetType.Cost) AS Retz FROM ((Customers INNER JOIN Returners ON Customers.CusID = Returners.CusID) INNER JOIN RetType ON Returners.ReturnerID = RetType.ReturnerID) GROUP BY Customers.CusID").Tables(0)
        TDis = CreateOLEDS("SELECT Customers.CusID, SUM(Discounts.DisCount) AS Dis FROM (Customers INNER JOIN Discounts ON Customers.CusID = Discounts.CusID) GROUP BY Customers.CusID").Tables(0)
        For IMainT = 0 To DGVTBCol2.DataSource.Rows.Count - 1
            For IDisT = 0 To TDis.Rows.Count - 1 'Subtract Discount from Main Table(Bills)
                If DGVTBCol2.DataSource.Rows(IMainT).Item(0).ToString.Trim = TDis.Rows(IDisT).Item(0).ToString.Trim Then
                    DGVTBCol2.DataSource.Rows(IMainT).Item(2) = Val(DGVTBCol2.DataSource.Rows(IMainT).Item(2).ToString) - Val(TDis.Rows(IDisT).Item(1).ToString)
                End If
            Next
            For IRetT = 0 To TRet.Rows.Count - 1 'Subtract Returners from Main Table(Bills)
                If DGVTBCol2.DataSource.Rows(IMainT).Item(0).ToString.Trim = TRet.Rows(IRetT).Item(0).ToString.Trim Then
                    DGVTBCol2.DataSource.Rows(IMainT).Item(2) = Val(DGVTBCol2.DataSource.Rows(IMainT).Item(2).ToString) - Val(TRet.Rows(IRetT).Item(1).ToString)
                End If
            Next
            For PayZ = 0 To DGVTBCol1.DataSource.Rows.Count - 1 'Subtract Payments from Main Table(Bills)
                If DGVTBCol2.DataSource.Rows(IMainT).Item(0).ToString.Trim = DGVTBCol1.DataSource.Rows(PayZ).Item(0).ToString.Trim Then
                    DGVTBCol2.DataSource.Rows(IMainT).Item(2) = Val(DGVTBCol2.DataSource.Rows(IMainT).Item(2).ToString) - Val(DGVTBCol1.DataSource.Rows(PayZ).Item(2).ToString)
                End If
            Next
        Next
        TxtResultTBCol2.Text = "0"
        TxtResultTBCol1.Text = DGVTBCol1.DataSource.Compute("Sum(الدفعـــات)", "")
        TxtResultTBCol2.Text = DGVTBCol2.DataSource.Compute("Sum(المتبقــي)", "")
        DGVTBCol1.DataSource.Columns.RemoveAt(0)
        DGVTBCol2.DataSource.Columns.RemoveAt(0)
    End Sub
    Private Sub BtnSearchSpendInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearchSpendInfo.Click
        If TxtSpendInfoSearch.Text.Trim.Length > 0 Then
            DGVSpend.DataSource = CreateOLEDS("SELECT Spending.SpendDate, SpendingTypes.SpendInfo, Spending.SpendCount, Spending.SpendInfo AS Information FROM (Spending LEFT OUTER JOIN SpendingTypes ON Spending.SpendypeID = SpendingTypes.SpendTypeID) WHERE (Spending.SpendInfo LIKE '%" & TxtSpendInfoSearch.Text.Trim & "%')").Tables(0)
            TxtSpendSearchResult.Text = Val(DGVSpend.DataSource.Compute("Sum(SpendCount)", "").ToString)
        End If
    End Sub
    Private Sub BtnSearchSpendType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearchSpendType.Click
        If CBSpendType.SelectedIndex > -1 Then
            DGVSpend.DataSource = CreateOLEDS("SELECT Spending.SpendDate, SpendingTypes.SpendInfo, Spending.SpendCount, Spending.SpendInfo AS Information FROM (Spending LEFT OUTER JOIN SpendingTypes ON Spending.SpendypeID = SpendingTypes.SpendTypeID) WHERE (Spending.SpendypeID = " & CBSpendType.SelectedValue.ToString & ")").Tables(0)
            TxtSpendSearchResult.Text = Val(DGVSpend.DataSource.Compute("Sum(SpendCount)", "").ToString)
        End If
    End Sub
    Private Sub ChBAllSpend_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChBAllSpend.CheckedChanged
        If ChBAllSpend.Checked = True Then
            DGVSpend.DataSource = CreateOLEDS("SELECT Spending.SpendDate, SpendingTypes.SpendInfo, Spending.SpendCount, Spending.SpendInfo AS Information FROM (Spending LEFT OUTER JOIN SpendingTypes ON Spending.SpendypeID = SpendingTypes.SpendTypeID)").Tables(0)
            TxtSpendSearchResult.Text = Val(DGVSpend.DataSource.Compute("Sum(SpendCount)", "").ToString)
            CBSpendType.Enabled = False
            BtnSearchSpendType.Enabled = False
        Else
            CBSpendType.Enabled = True
            BtnSearchSpendType.Enabled = True
            DGVSpend.DataSource.Rows.Clear()
        End If
    End Sub
    Private Sub BtnExcelSingleCus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExcelSingleCus.Click
        If DGVTBCus.DataSource IsNot Nothing Then
            DGVTBCus.DataSource.Columns(0).ColumnName = "نوع العمليـــه"
            DGVTBCus.DataSource.Columns(1).ColumnName = "التــاريـخ"
            DGVTBCus.DataSource.Columns(2).ColumnName = "رقـــم الفـاتـوره / رقم الايصـــال"
            DGVTBCus.DataSource.Columns(3).ColumnName = "القيمــــــــــه"
            ExportToExcel(DGVTBCus.DataSource, TxtBillsTBCus.Text, "حســـــــــــــاب عميل")
        End If
    End Sub
    Private Sub BtnExcelStorage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExcelStorage.Click
        If DGVTBSto.DataSource IsNot Nothing Then
            DGVTBSto.DataSource.Columns(0).ColumnName = "اســـم الموديــل"
            DGVTBSto.DataSource.Columns(1).ColumnName = "الكمـــيه"
            DGVTBSto.DataSource.Columns(2).ColumnName = "تكلفـة الوحــده"
            DGVTBSto.DataSource.Columns(3).ColumnName = "القيـــمه"
            ExportToExcel(DGVTBSto.DataSource, TxtResultTBSto.Text, "المـخـــــزن")
        End If
    End Sub
    Private Sub BtnExcelIncoming_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExcelIncoming.Click
        If DGVTBCol1.DataSource IsNot Nothing Then
            DGVTBCol1.DataSource.Columns(0).ColumnName = "رقم العمـــيل"
            ExportToExcel(DGVTBCol1.DataSource, TxtResultTBCol1.Text, "التحصــــــيل")
        End If
        If DGVTBCol2.DataSource IsNot Nothing Then
            DGVTBCol2.DataSource.Columns(0).ColumnName = "رقم العمـــيل"
            ExportToExcel(DGVTBCol2.DataSource, TxtResultTBCol2.Text, "التحصــــــيل")
        End If
    End Sub
    Private Sub BtnExcelOutComing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExcelOutComing.Click
        If DGVSpend.DataSource IsNot Nothing Then
            DGVSpend.DataSource.Columns(0).ColumnName = "التــاريخ"
            DGVSpend.DataSource.Columns(1).ColumnName = "نوع المدفوع"
            DGVSpend.DataSource.Columns(2).ColumnName = "القيـــــــمه"
            DGVSpend.DataSource.Columns(3).ColumnName = "البيـــــــان"
            ExportToExcel(DGVSpend.DataSource, TxtSpendSearchResult.Text, "المصــروفــــات")
        End If
    End Sub
    Private Sub BtnPrintCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintCustomer.Click
        GetFormImage(Me)
        pd = New Printing.PrintDocument
        pd.Print()
    End Sub
    Private Sub BtnPrintSto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintSto.Click
        GetFormImage(Me)
        pd = New Printing.PrintDocument
        pd.Print()
    End Sub
    Private Sub BtnPrintIncoming_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintIncoming.Click
        GetFormImage(Me)
        pd = New Printing.PrintDocument
        pd.Print()
    End Sub
    Private Sub BtnPrintSpending_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintSpending.Click
        GetFormImage(Me)
        pd = New Printing.PrintDocument
        pd.Print()
    End Sub
End Class