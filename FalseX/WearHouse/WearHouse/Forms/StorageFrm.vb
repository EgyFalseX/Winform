Public Class StorageFrm
    Private ModDS As DataSet
    Private Sub StorageFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ModDS = CreateOLEDS("SELECT TypeID, TypeCode FROM Types")
        CBName.DataSource = ModDS.Tables(0)
        CBName.ValueMember = "TypeID"
        CBName.DisplayMember = "TypeCode"
        If CBName.Items.Count > 0 Then
            CBName.SelectedIndex = 0
        Else
            BtnSave.Enabled = False
        End If
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Dim IdX As Int16 = CBName.SelectedIndex
        If Val(TxtCount.Text.Trim) > 0 Then
            Insertion_Updateing_Deleting("INSERT INTO Adding (TypeID, AddDate, AddingCount) VALUES (" & CBName.SelectedValue & ",#" & DTP.Value.ToShortDateString & "#," & Val(TxtCount.Text.Trim) & ")")
            StorageFrm_Load(sender, e)
            TxtCount.Clear()
            CBName.SelectedIndex = IdX
            CBName.Focus()
            MsgBox("تمت الاضــافه", MsgBoxStyle.Information)
        Else
            MsgBox("خطــــاء", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class