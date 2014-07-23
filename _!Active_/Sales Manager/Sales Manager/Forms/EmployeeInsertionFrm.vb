Public Class EmployeeInsertionFrm
    Private Sub EmployeeInsertionFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CBEmp.DataSource = CreateOLETable("SELECT EmpID, EmpName FROM Employees")
        CBEmp.ValueMember = "EmpID"
        CBEmp.DisplayMember = "EmpName"
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Insertion_Updateing_Deleting("INSERT INTO Employees (EmpName, EmpPhone, EmpAddress, EmpSalary) VALUES ('" & TxtName.Text.Trim & "','" & TxtPhone.Text.Trim & "','" & TxtAddress.Text.Trim & "','" & Val(TxtSalary.Text.Trim) & "')")
        EmployeeInsertionFrm_Load(sender, e)
        MsgBox("تمت الاضــافه", MsgBoxStyle.Information)
        TxtName.Clear()
        TxtAddress.Clear()
        TxtPhone.Clear()
        TxtName.Focus()
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
End Class