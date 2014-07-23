Public Class DisactivatedUsersFrm
    Dim Int1 As Int16
    Dim ErrorProvider As String = Nothing
    Private Sub RefreshList()
        BtnActivate.Enabled = False
        BtnDelete.Enabled = False
        LBUsers.Items.Clear()
        ErrorProvider = Nothing
        ErrorProvider = FunLib.GetAllUsers(AdminID, False)
        If ErrorProvider = Nothing Then
            If FunLib.AllUsers Is Nothing Then
                MsgBox_("·« ÌÊÃœ ⁄„·«¡ €Ì— „›⁄·Ì‰", 90, 23, False, Me)
                Me.Close()
            Else
                For Int1 = 0 To FunLib.AllUsers.Length - 1
                    LBUsers.Items.Add(FunLib.AllUsers(Int1).UserName)
                Next
            End If
        Else
            MsgBox_(ErrorProvider, 0, 20, False, Me)
            Me.Close()
        End If
    End Sub
    Private Sub DisactivatedUsersFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshList()
    End Sub
    Private Sub BtnActivate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActivate.Click
        If MsgBox("Â· «‰  „ √ﬂœ?", MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
            If LBUsers.SelectedIndex <> -1 Then
                FunLib.UserActivation(FunLib.AllUsers(LBUsers.SelectedIndex).UsrID, True)
                RefreshList()
                MsgBox_(" „ «· ›⁄Ì·", 134, 23, True, Me)
            End If
        End If
    End Sub
    Private Sub LBUsers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBUsers.SelectedIndexChanged
        If LBUsers.SelectedIndex <> -1 Then
            BtnActivate.Enabled = True
            BtnDelete.Enabled = True
        End If
    End Sub
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If MsgBox("Â· «‰  „ √ﬂœ?", MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
            If LBUsers.SelectedIndex <> -1 Then
                ErrorProvider = FunLib.DeleteUser(FunLib.AllUsers(LBUsers.SelectedIndex).UsrID)
                Select Case ErrorProvider
                    Case Nothing
                        'cant delete this user
                        MsgBox_("·« Ì„ﬂ‰ «·Õ–›", 126, 23, False, Me)
                    Case "1"
                        'User deleted
                        MsgBox_(" „ «·Õ–›", 133, 23, True, Me)
                        RefreshList()
                    Case Else
                        'Sql error
                        MsgBox_(ErrorProvider, 0, 20, False, Me)
                End Select
            End If
        End If
    End Sub
End Class