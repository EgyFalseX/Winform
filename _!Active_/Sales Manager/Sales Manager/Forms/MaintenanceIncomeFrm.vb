Public Class MaintenanceIncomeFrm
    Private Sub MaintPaymentFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CBEmp.DataSource = CreateOLETable("SELECT EmpID, EmpName FROM Employees")
        CBEmp.ValueMember = "EmpID"
        CBEmp.DisplayMember = "EmpName"
        If CBEmp.Items.Count > 0 Then
            CBEmp.SelectedIndex = 0
        Else
            TxtCount.Enabled = False
        End If
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Dim IdX As Int16 = CBEmp.SelectedIndex
        Insertion_Updateing_Deleting("INSERT INTO Maintenance (FEmpID, MaintDate, Income, MaintInfo) VALUES ('" & CBEmp.SelectedValue.ToString & "',#" & DTP.Value.ToShortDateString & "#,'" & Val(TxtCount.Text.Trim) & "','" & TxtInfo.Text.Trim & "')")
        MaintPaymentFrm_Load(sender, e)
        TxtCount.Clear()
        CBEmp.SelectedIndex = IdX
        CBEmp.Focus()
        MsgBox("تمت الاضــافه", MsgBoxStyle.Information)
        'MsgBox("خطــــاء", MsgBoxStyle.Critical)
    End Sub
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
    Private Sub TxtCount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCount.TextChanged, TxtInfo.TextChanged
        If sender.Text.Trim.Length = 0 Then
            BtnSave.Enabled = False
        Else
            BtnSave.Enabled = True
        End If
    End Sub
End Class