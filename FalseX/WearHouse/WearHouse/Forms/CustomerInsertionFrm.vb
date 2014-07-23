Public Class CustomerInsertionFrm
    Private CusDS As DataSet
    Private Sub CustomerInsertionFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CusDS = CreateOLEDS("SELECT CusID, CusName FROM Customers")
        CBCus.DataSource = CusDS.Tables(0)
        CBCus.ValueMember = "CusID"
        CBCus.DisplayMember = "CusName"
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If TxtName.TextLength > 0 And TxtAddress.TextLength > 0 And TxtPhone.TextLength > 0 Then
            Insertion_Updateing_Deleting("INSERT INTO Customers (CusName, CusAddress, CusPhone) VALUES ('" & TxtName.Text.Trim & "','" & TxtAddress.Text.Trim & "','" & TxtPhone.Text.Trim & "')")
            CustomerInsertionFrm_Load(sender, e)
            MsgBox("تمت الاضــافه", MsgBoxStyle.Information)
            TxtName.Clear()
            TxtAddress.Clear()
            TxtPhone.Clear()
            TxtName.Focus()
        Else
            MsgBox("خطــــاء", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class