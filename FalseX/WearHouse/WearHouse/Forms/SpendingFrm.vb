Public Class SpendingFrm
    Private SpDS As DataSet
    Private Sub SpendingFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SpDS = CreateOLEDS("SELECT SpendTypeID, SpendInfo FROM SpendingTypes")
        CBName.DataSource = SpDS.Tables(0)
        CBName.ValueMember = "SpendTypeID"
        CBName.DisplayMember = "SpendInfo"
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Dim IdX As Int16 = CBName.SelectedIndex
        If Val(TxtCount.Text.Trim) > 0 Then
            Insertion_Updateing_Deleting("INSERT INTO Spending (SpendypeID, SpendDate,SpendCount, SpendInfo) VALUES (" & CBName.SelectedValue.ToString & ",#" & DTP.Value.ToShortDateString & "#," & Val(TxtCount.Text.Trim) & ",'" & TxtInfo.Text.Trim & "')")
            SpendingFrm_Load(sender, e)
            TxtCount.Clear() : TxtInfo.Clear()
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