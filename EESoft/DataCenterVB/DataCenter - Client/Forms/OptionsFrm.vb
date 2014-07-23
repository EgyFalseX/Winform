Public Class OptionsFrm
    Private ErrorProvider As String = Nothing
    

    Private Sub TxtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPassword.TextChanged, TxtPasswordCon.TextChanged
        If TxtPassword.TextLength > 0 Or TxtPasswordCon.TextLength > 0 Or TxtPassword.Text.Trim <> TxtPasswordCon.Text.Trim Then
            BtnSaveClientOptions.Enabled = True
        Else
            BtnSaveClientOptions.Enabled = False
        End If
    End Sub

    Private Sub BtnSaveClientOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveClientOptions.Click
        If MsgBox("Â· «‰  „ √ﬂœ ?", MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.No Then
            Exit Sub
        End If
        ErrorProvider = Nothing
        ErrorProvider = FunLib.ChangePasswrod(FunLib.CUser.UID, TxtPassword.Text.Trim)
        If ErrorProvider = Nothing Then
            FunLib.CUser.UPass = TxtPassword.Text.Trim
            MsgBox_(" „ «·Õ›Ÿ", 122, 23, True, Me)
        Else
            MsgBox_(" „ —›÷ ﬂ·„… «·„—Ê—", 137, 20, False, Me)
        End If
    End Sub
End Class