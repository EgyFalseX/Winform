Public Class UsersPrivilegesFrm
    Private ErrorResult As String
    Private Int1 As Int16
    Private Int2 As Int16
    Private Sub UsersPrivilegesFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CBProjects.Items.Clear()
        CBUsers.Items.Clear()
        ErrorResult = FunLib.GetAllProjectsPrivileges()
        If ErrorResult = Nothing Then
            ErrorResult = Nothing
            ErrorResult = FunLib.GetAllUsers(AdminID, True)
            If ErrorResult Is Nothing And FunLib.AllProjectWithPrivileges IsNot Nothing Then
                For Int1 = 0 To FunLib.AllProjectWithPrivileges.Length - 1
                    CBProjects.Items.Add(FunLib.AllProjectWithPrivileges(Int1).ProjectName)
                Next
                For Int1 = 0 To FunLib.AllUsers.Length - 1
                    CBUsers.Items.Add(FunLib.AllUsers(Int1).UserName)
                Next
                'All Data is OKAY
                Exit Sub
            Else
                Exit Sub
            End If
        End If
        MsgBox("Critical Error" & vbNewLine & ErrorResult)
        Me.Close()
    End Sub
    Private Sub ReloadSelectedUserPrivilege()
        LBAllprivileges.Items.Clear()
        LBSelectedprivileges.Items.Clear()
        If CBProjects.SelectedIndex <> -1 And CBUsers.SelectedIndex <> -1 Then
            ErrorResult = Nothing
            Dim arr() As String = Nothing
            ErrorResult = FunLib.GetUserPrivilege(FunLib.AllUsers(CBUsers.SelectedIndex).UsrID, FunLib.AllProjectWithPrivileges(CBProjects.SelectedIndex).ProjectID, arr)
            If ErrorResult Is Nothing Then
                'Clear Old Selected priv
                If FunLib.AllProjectWithPrivileges(CBProjects.SelectedIndex).InternalPrivileges IsNot Nothing Then
                    For Int1 = 0 To FunLib.AllProjectWithPrivileges(CBProjects.SelectedIndex).InternalPrivileges.Length - 1
                        FunLib.AllProjectWithPrivileges(CBProjects.SelectedIndex).InternalPrivileges(Int1).privilegeSelected = False
                    Next
                    'Select new user priv
                    For Int1 = 0 To FunLib.AllProjectWithPrivileges(CBProjects.SelectedIndex).InternalPrivileges.Length - 1
                        If Not arr Is Nothing Then
                            For Int2 = 0 To arr.Length - 1
                                If arr(Int2) = FunLib.AllProjectWithPrivileges(CBProjects.SelectedIndex).InternalPrivileges(Int1).privilegeID Then
                                    FunLib.AllProjectWithPrivileges(CBProjects.SelectedIndex).InternalPrivileges(Int1).privilegeSelected = True
                                    LBSelectedprivileges.Items.Add(FunLib.AllProjectWithPrivileges(CBProjects.SelectedIndex).InternalPrivileges(Int1).privilegeName)
                                    GoTo NextPriv
                                End If
                            Next
                        End If
                        FunLib.AllProjectWithPrivileges(CBProjects.SelectedIndex).InternalPrivileges(Int1).privilegeSelected = False
                        LBAllprivileges.Items.Add(FunLib.AllProjectWithPrivileges(CBProjects.SelectedIndex).InternalPrivileges(Int1).privilegeName)
NextPriv:
                    Next
                End If
            Else
                MsgBox("Error", MsgBoxStyle.Critical)
                Me.Close()
            End If
        End If

    End Sub
    Private Sub CBUsers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBUsers.SelectedIndexChanged
        ReloadSelectedUserPrivilege()
    End Sub
    Private Sub CBProjects_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBProjects.SelectedIndexChanged
        ReloadSelectedUserPrivilege()
    End Sub
    Private Sub BtnAddSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddSelected.Click
        For Int1 = 0 To FunLib.AllProjectWithPrivileges(CBProjects.SelectedIndex).InternalPrivileges.Length - 1
            If LBAllprivileges.SelectedItem = FunLib.AllProjectWithPrivileges(CBProjects.SelectedIndex).InternalPrivileges(Int1).privilegeName Then
                ErrorResult = Nothing
                ErrorResult = FunLib.AddUserPrivilege(FunLib.AllUsers(CBUsers.SelectedIndex).UsrID, FunLib.AllProjectWithPrivileges(CBProjects.SelectedIndex).ProjectID, FunLib.AllProjectWithPrivileges(CBProjects.SelectedIndex).InternalPrivileges(Int1).privilegeID)
                If ErrorResult Is Nothing Then
                    LBSelectedprivileges.Items.Add(LBAllprivileges.SelectedItem.ToString)
                    LBAllprivileges.Items.Remove(LBAllprivileges.SelectedItem)
                End If
                Exit For
            End If
        Next
    End Sub
    Private Sub BtnRemoveSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemoveSelected.Click
        If MsgBox("Â· «‰  „ √ﬂœ ?", MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.No Then
            Exit Sub
        End If
        For Int1 = 0 To FunLib.AllProjectWithPrivileges(CBProjects.SelectedIndex).InternalPrivileges.Length - 1
            If LBSelectedprivileges.SelectedItem = FunLib.AllProjectWithPrivileges(CBProjects.SelectedIndex).InternalPrivileges(Int1).privilegeName Then
                ErrorResult = Nothing
                ErrorResult = FunLib.RemoveUserPrivilege(FunLib.AllUsers(CBUsers.SelectedIndex).UsrID, FunLib.AllProjectWithPrivileges(CBProjects.SelectedIndex).ProjectID, FunLib.AllProjectWithPrivileges(CBProjects.SelectedIndex).InternalPrivileges(Int1).privilegeID)
                If ErrorResult Is Nothing Then
                    LBAllprivileges.Items.Add(LBSelectedprivileges.SelectedItem.ToString)
                    LBSelectedprivileges.Items.Remove(LBSelectedprivileges.SelectedItem)
                End If
                Exit For
            End If
        Next
    End Sub
    Private Sub LBAllprivileges_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LBAllprivileges.DoubleClick
        If LBAllprivileges.SelectedIndex <> -1 Then
            BtnAddSelected_Click(sender, e)
        End If
    End Sub
    Private Sub LBSelectedprivileges_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LBSelectedprivileges.DoubleClick
        If LBSelectedprivileges.SelectedIndex <> -1 Then
            BtnRemoveSelected_Click(sender, e)
        End If
    End Sub
    Private Sub LBAllprivileges_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBAllprivileges.SelectedIndexChanged
        If LBAllprivileges.SelectedIndex <> -1 Then
            BtnAddSelected.Enabled = True
        Else
            BtnAddSelected.Enabled = False
        End If
    End Sub
    Private Sub LBSelectedprivileges_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBSelectedprivileges.SelectedIndexChanged
        If LBSelectedprivileges.SelectedIndex <> -1 Then
            BtnRemoveSelected.Enabled = True
        Else
            BtnRemoveSelected.Enabled = False
        End If
    End Sub
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class