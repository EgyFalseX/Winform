Public Class PrivilegesFrm
    Private ResultErrors As String = ""
    Private Int1 As Integer
    Private ActionTMR As New Timer

    Private Sub ActionTMR_Tick(ByVal sender As Object, ByVal e As EventArgs)
        LblAction.Text = "No Action"
        LblAction.ForeColor = Color.Black
    End Sub
    Private Sub PrivilegesFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CBAllProjects.Items.Clear()
        ResultErrors = FunLib.GetAllProjectsPrivileges
        If ResultErrors <> Nothing Then
            MsgBox_(ResultErrors, 0, 23, False, Me)
            Me.Close()
        ElseIf FunLib.AllProjectWithPrivileges IsNot Nothing Then
            For Int1 = 0 To FunLib.AllProjectWithPrivileges.Length - 1
                CBAllProjects.Items.Add(FunLib.AllProjectWithPrivileges(Int1).ProjectName)
            Next
            ActionTMR.Interval = 3000
            AddHandler ActionTMR.Tick, AddressOf ActionTMR_Tick
        Else
            MsgBox_("No Projects found", 123, 23, False, Me)
            Me.Close()
        End If
    End Sub
    Private Sub CBAllProjects_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBAllProjects.SelectedIndexChanged
        LBPrivileges.Items.Clear()
        If CBAllProjects.SelectedIndex <> -1 Then
            TxtNewPriv.Clear()
            TxtNewPriv.ReadOnly = False
            BtnRemove.Enabled = False
            TxtUpdate.Clear()
            TxtUpdate.ReadOnly = True
            If FunLib.AllProjectWithPrivileges(CBAllProjects.SelectedIndex).InternalPrivileges IsNot Nothing Then
                For Int1 = 0 To FunLib.AllProjectWithPrivileges(CBAllProjects.SelectedIndex).InternalPrivileges.Length - 1
                    LBPrivileges.Items.Add(FunLib.AllProjectWithPrivileges(CBAllProjects.SelectedIndex).InternalPrivileges(Int1).privilegeName)
                Next
            End If
            LblAction.Text = LBPrivileges.Items.Count
        Else
            LblAction.Text = "No project is selected"
            TxtNewPriv.Clear()
            TxtNewPriv.ReadOnly = True
        End If
    End Sub
    Private Sub TxtNewPriv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNewPriv.TextChanged
        If TxtNewPriv.Text.Trim.Length > 0 Then
            BtnAdd.Enabled = True
        Else
            BtnAdd.Enabled = False
        End If
    End Sub
    Private Sub LBPrivileges_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBPrivileges.SelectedIndexChanged
        If LBPrivileges.SelectedIndex <> -1 Then
            BtnRemove.Enabled = True
            TxtUpdate.ReadOnly = False
            TxtUpdate.Text = LBPrivileges.SelectedItem
        Else
            TxtUpdate.Clear()
            TxtUpdate.ReadOnly = True
            BtnRemove.Enabled = False
        End If
    End Sub
    Private Sub BtnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemove.Click
        If MsgBox("You are about to delete a privilege" & vbNewLine & "Are you sure?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If
        ResultErrors = Nothing
        ResultErrors = FunLib.DeletePrivilege(FunLib.AllProjectWithPrivileges(CBAllProjects.SelectedIndex).InternalPrivileges(LBPrivileges.SelectedIndex).privilegeID)
        If ResultErrors Is Nothing Then
            'input cose to remove the privilege from the list
            Dim Newarr(FunLib.AllProjectWithPrivileges(CBAllProjects.SelectedIndex).InternalPrivileges.Length - 1) As FunctionLib.DataCenterServerLib.privilegeType

            'Resort the privilageslist items
            Array.Copy(FunLib.AllProjectWithPrivileges(CBAllProjects.SelectedIndex).InternalPrivileges, Newarr, FunLib.AllProjectWithPrivileges(CBAllProjects.SelectedIndex).InternalPrivileges.Length)
            ReDim FunLib.AllProjectWithPrivileges(CBAllProjects.SelectedIndex).InternalPrivileges(-1)
            If Newarr.Length <> 0 Then
                For Int1 = 0 To Newarr.Length - 1
                    If Newarr(Int1).privilegeName <> LBPrivileges.SelectedItem Then
                        If FunLib.AllProjectWithPrivileges(CBAllProjects.SelectedIndex).InternalPrivileges Is Nothing Then
                            ReDim FunLib.AllProjectWithPrivileges(CBAllProjects.SelectedIndex).InternalPrivileges(0)
                        Else
                            ReDim Preserve FunLib.AllProjectWithPrivileges(CBAllProjects.SelectedIndex).InternalPrivileges(FunLib.AllProjectWithPrivileges(CBAllProjects.SelectedIndex).InternalPrivileges.Length)
                        End If
                        FunLib.AllProjectWithPrivileges(CBAllProjects.SelectedIndex).InternalPrivileges(FunLib.AllProjectWithPrivileges(CBAllProjects.SelectedIndex).InternalPrivileges.Length - 1).privilegeID = Newarr(Int1).privilegeID
                        FunLib.AllProjectWithPrivileges(CBAllProjects.SelectedIndex).InternalPrivileges(FunLib.AllProjectWithPrivileges(CBAllProjects.SelectedIndex).InternalPrivileges.Length - 1).privilegeName = Newarr(Int1).privilegeName
                    End If
                Next
            End If
            LBPrivileges.Items.RemoveAt(LBPrivileges.SelectedIndex)
            LblAction.Text = LBPrivileges.Items.Count
            MsgBox_("Privilege removed", 124, 23, True, Me)
        Else
            MsgBox_(ResultErrors & vbNewLine & "Privilege didn't removed", 0, 23, False, Me)
        End If
    End Sub
    Private Sub TxtUpdate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtUpdate.TextChanged
        If TxtUpdate.Text.Trim.Length > 0 Then
            BtnUpdate.Enabled = True
        Else
            BtnUpdate.Enabled = False
        End If
    End Sub
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        ResultErrors = Nothing
        If CBAllProjects.SelectedIndex <> -1 And TxtNewPriv.Text.Trim.Length > 0 Then
            ResultErrors = FunLib.InsertNewPrivilege(TxtNewPriv.Text.Trim, FunLib.AllProjectWithPrivileges(CBAllProjects.SelectedIndex).ProjectID)
        End If
        If ResultErrors Is Nothing = False Then
            If FunLib.AllProjectWithPrivileges(CBAllProjects.SelectedIndex).InternalPrivileges Is Nothing Then
                ReDim FunLib.AllProjectWithPrivileges(CBAllProjects.SelectedIndex).InternalPrivileges(0)
            Else
                ReDim Preserve FunLib.AllProjectWithPrivileges(CBAllProjects.SelectedIndex).InternalPrivileges(FunLib.AllProjectWithPrivileges(CBAllProjects.SelectedIndex).InternalPrivileges.Length)
            End If
            FunLib.AllProjectWithPrivileges(CBAllProjects.SelectedIndex).InternalPrivileges(FunLib.AllProjectWithPrivileges(CBAllProjects.SelectedIndex).InternalPrivileges.Length - 1).privilegeID = ResultErrors
            FunLib.AllProjectWithPrivileges(CBAllProjects.SelectedIndex).InternalPrivileges(FunLib.AllProjectWithPrivileges(CBAllProjects.SelectedIndex).InternalPrivileges.Length - 1).privilegeName = TxtNewPriv.Text.Trim
            LBPrivileges.Items.Add(TxtNewPriv.Text.Trim)
            LblAction.Text = LBPrivileges.Items.Count
            MsgBox_("New privilege added", 117, 23, True, Me)
        Else
            'Cant insert
            MsgBox_("Can't add privilege", 128, 20, False, Me)
        End If
    End Sub
    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        If MsgBox("Are you sure ?", MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
            ResultErrors = Nothing
            If CBAllProjects.SelectedIndex <> -1 And LBPrivileges.SelectedIndex <> -1 And TxtUpdate.Text.Trim.Length > 0 Then
                ResultErrors = FunLib.UpdatePrivilegeName(FunLib.AllProjectWithPrivileges(CBAllProjects.SelectedIndex).InternalPrivileges(LBPrivileges.SelectedIndex).privilegeID, TxtUpdate.Text.Trim)
                If ResultErrors Is Nothing Then
                    FunLib.AllProjectWithPrivileges(CBAllProjects.SelectedIndex).InternalPrivileges(LBPrivileges.SelectedIndex).privilegeName = TxtUpdate.Text.Trim
                    LBPrivileges.Items.Item(LBPrivileges.SelectedIndex) = TxtUpdate.Text.Trim
                    MsgBox_("Selected privilege updated", 97, 23, True, Me)
                Else
                    'cant update
                    MsgBox_("Selected privilege isn't updated", 82, 23, False, Me)
                End If
            End If
        End If
    End Sub
End Class