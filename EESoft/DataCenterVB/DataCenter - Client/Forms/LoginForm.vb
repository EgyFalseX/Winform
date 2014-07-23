Public Class LoginForm
    Private CExit As Boolean = False
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If FunLib.ULogin(UsernameTextBox.Text.Trim, PasswordTextBox.Text.Trim) = True Then
            'Loading User privilagesIDs
            FunLib.GetUserPrivilages()
            'MsgBox("Login sccuessfull")
            SC.Show()
            CExit = True
            Me.Close()
        Else
            MsgBox_("«”„ «·„” Œœ„ «Ê ﬂ·„… «·„—Ê— Œÿ‹‹√", 84, 23, False, Me)
        End If
    End Sub
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Application.Exit()
    End Sub
    Private Sub LoginForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If CExit = False Then
            Application.Exit()
        End If
    End Sub
    Private Sub Btnresetconnection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnresetconnection.Click
        If MsgBox("«‰  ⁄· Ê‘ﬂ «·€«¡ «·« ’«· »ﬁ«⁄œ… «·»Ì«‰« " & vbNewLine & "Â· «‰  „ √ﬂœ?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If
        FunLib.ResetConnection()
        Application.Restart()
        Process.GetCurrentProcess.Kill()
    End Sub
End Class