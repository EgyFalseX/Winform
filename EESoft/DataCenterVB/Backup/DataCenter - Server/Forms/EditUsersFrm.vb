Public Class EditUsersFrm
    Private ErrorProvider As String = Nothing
    Dim Int1 As Integer

    Private Sub UsersFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ErrorProvider = FunLib.GetAllUsers(AdminID, True)
        ErrorProvider = Nothing
        If ErrorProvider Is Nothing And Not FunLib.AllUsers Is Nothing Then
            LBUsers.Items.Clear()
            If FunLib.AllUsers.Length <= 0 Then
                Exit Sub
            End If
            For Int1 = 0 To FunLib.AllUsers.Length - 1
                LBUsers.Items.Add(FunLib.AllUsers(Int1).UserName)
            Next
        Else
            'Prepare MSG
            MsgBox_(ErrorProvider, 0, 20, False, Me)
            Me.Close()
        End If
    End Sub
    Private Sub TxtNewUser_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNewUser.TextChanged
        If TxtNewUser.Text.Trim.Length > 0 Then
            BtnAdd.Enabled = True
        Else
            BtnAdd.Enabled = False
        End If
    End Sub
    Private Sub LBUsers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBUsers.SelectedIndexChanged
        If LBUsers.SelectedIndex <> -1 Then
            BtnRemove.Enabled = True
            BtnReset.Enabled = True
            TxtUpdate.ReadOnly = False
            TxtUpdate.Text = LBUsers.SelectedItem
        Else
            BtnRemove.Enabled = False
            BtnReset.Enabled = False
            TxtUpdate.Clear()
            TxtUpdate.ReadOnly = True
        End If
    End Sub
    Private Sub TxtUpdate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtUpdate.TextChanged
        If TxtUpdate.Text.Trim.Length > 0 Then
            BtnUpdate.Enabled = True
        Else
            BtnUpdate.Enabled = False
        End If
    End Sub
    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        ErrorProvider = ""
        ErrorProvider = FunLib.AddUser(TxtNewUser.Text.Trim)
        If ErrorProvider <> "UserName In Used" Then
            If FunLib.AllUsers Is Nothing Then
                ReDim FunLib.AllUsers(0)
            Else
                ReDim Preserve FunLib.AllUsers(FunLib.AllUsers.Length)
            End If
            FunLib.AllUsers(FunLib.AllUsers.Length - 1).UsrID = ErrorProvider
            FunLib.AllUsers(FunLib.AllUsers.Length - 1).UserName = TxtNewUser.Text.Trim
            LBUsers.Items.Add(TxtNewUser.Text.Trim)
            MsgBox_("New user added successfully", 88, 23, True, Me)
        Else
            MsgBox_(ErrorProvider, 0, 20, False, Me)
        End If
    End Sub
    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        If MsgBox("Are you sure ?", MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
            If LBUsers.SelectedIndex <> -1 And TxtUpdate.Text.Trim.Length > 0 Then
                ErrorProvider = Nothing
                ErrorProvider = FunLib.UpdateUserameOrPassword(FunLib.AllUsers(LBUsers.SelectedIndex).UsrID, TxtUpdate.Text.Trim, True)
                If ErrorProvider Is Nothing Then
                    FunLib.AllUsers(LBUsers.SelectedIndex).UserName = TxtUpdate.Text.Trim
                    LBUsers.Items.Item(LBUsers.SelectedIndex) = TxtUpdate.Text.Trim
                    MsgBox_("Username changed successfully", 77, 23, True, Me)
                Else
                    MsgBox_("Username didn't changed", 98, 23, False, Me)
                End If
            End If
        End If
    End Sub
    Private Sub BtnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReset.Click
        If MsgBox("Are you sure ?", MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
            If LBUsers.SelectedIndex <> -1 And TxtUpdate.Text.Trim.Length > 0 Then
                ErrorProvider = Nothing
                ErrorProvider = FunLib.UpdateUserameOrPassword(FunLib.AllUsers(LBUsers.SelectedIndex).UsrID, DefaultUserPassword, False)
                If ErrorProvider Is Nothing Then
                    FunLib.AllUsers(LBUsers.SelectedIndex).UserName = TxtUpdate.Text.Trim
                    MsgBox_("Password changed successfully", 77, 23, True, Me)
                Else
                    MsgBox_("Password didn't changed", 98, 23, False, Me)
                End If
            End If
        End If
    End Sub
    Private Sub BtnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemove.Click
        If MsgBox("Are you sure ?", MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
            If LBUsers.SelectedIndex <> -1 Then
                ErrorProvider = Nothing
                ErrorProvider = FunLib.UserActivation(FunLib.AllUsers(LBUsers.SelectedIndex).UsrID, False)
                If ErrorProvider = Nothing Then
                    UsersFrm_Load(sender, e)
                    BtnRemove.Enabled = False
                    TxtUpdate.ReadOnly = True
                    BtnUpdate.Enabled = False
                    MsgBox_("User Disactivated", 125, 23, True, Me)
                Else
                    MsgBox_("Can't Disactivate user", 111, 23, False, Me)
                End If
            End If
        End If
    End Sub
End Class