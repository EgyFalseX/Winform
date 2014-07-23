Public Class DialyPrintingFrm

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        If MsgBox("هـل انـت متـأكد ؟", MsgBoxStyle.YesNo, "حـــذف") = MsgBoxResult.No Then
            Exit Sub
        End If
        Try
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            BtnPrint.Visible = False : BtnSearch.Visible = False
            Application.DoEvents()
            GetFormImage(Me)
            pd = New Printing.PrintDocument
            pd.Print()
            BtnPrint.Visible = True : BtnSearch.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        TxtValue.Text = "0" : TxtAbsolute.Text = "0" : TxtDiscount.Text = "0"
        DGV.DataSource = CreateOLETable("SELECT Types.TypeName, SUM(ContainZ.ConCount) AS CountZ, SUM(ContainZ.ConCount * ContainZ.ConCost) AS FalseX FROM ((ContainZ INNER JOIN Types ON ContainZ.TypeID = Types.TypeID) INNER JOIN Bills ON ContainZ.BillID = Bills.BillID) WHERE (Bills.BillDate = #" & DTP.Value.ToShortDateString & "#) GROUP BY Types.TypeName")
        TxtValue.Text = Val(DGV.DataSource.Compute("Sum(FalseX)", "").ToString)
        Return1Value("SELECT SUM(Discount) AS FalseX FROM Bills WHERE (BillDate = #" & DTP.Value.ToShortDateString & "#)", TxtDiscount.Text)
        TxtAbsolute.Text = Val(TxtValue.Text) - Val(TxtDiscount.Text)
    End Sub
End Class