Public Class SpendTypeFrm
    Private SpDS As DataSet
    Private Sub SpendTypeFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SpDS = CreateOLEDS("SELECT SpendTypeID, SpendInfo FROM SpendingTypes")
        CBName.DataSource = SpDS.Tables(0)
        CBName.ValueMember = "SpendTypeID"
        CBName.DisplayMember = "SpendInfo"
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If TxtName.TextLength > 0 Then
            Insertion_Updateing_Deleting("INSERT INTO SpendingTypes (SpendInfo) VALUES (' " & TxtName.Text.Trim & " ')")
            SpendTypeFrm_Load(sender, e)
            MsgBox("تمت الاضــافه", MsgBoxStyle.Information)
            TxtName.Clear()
            TxtName.Focus()
        Else
            MsgBox("خطــــاء", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class