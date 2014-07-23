Public Class DiscountsFrm
    Private CusDS As DataSet
    Private Sub CustomerPaymentFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CusDS = CreateOLEDS("SELECT CusID, CusName FROM Customers")
        CBCus.DataSource = CusDS.Tables(0)
        CBCus.ValueMember = "CusID"
        CBCus.DisplayMember = "CusName"
        If CBCus.Items.Count > 0 Then
            CBCus.SelectedIndex = 0
        Else
            BtnSave.Enabled = False
        End If
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Dim IdX As Int16 = CBCus.SelectedIndex
        If Val(TxtCount.Text.Trim) > 0 Then
            Insertion_Updateing_Deleting("INSERT INTO Discounts (CusID, DisDate, DisCount) VALUES ('" & CBCus.SelectedValue.ToString & "',#" & DTP.Value.ToShortDateString & "#," & Val(TxtCount.Text.Trim) & ")")
            CustomerPaymentFrm_Load(sender, e)
            TxtCount.Clear()
            CBCus.SelectedIndex = IdX
            CBCus.Focus()
            MsgBox("تمت الاضــافه", MsgBoxStyle.Information)
        Else
            MsgBox("خطــــاء", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class