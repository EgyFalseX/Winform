Public Class DeactivateProjectFrm
    Private Int1 As Int16
    Private ErrorProvider As String = Nothing
    Private Sub LBProjects_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBProjects.SelectedIndexChanged
        If LBProjects.SelectedIndex <> -1 Then
            BtnDelete.Enabled = True
        Else
            BtnDelete.Enabled = False
        End If
    End Sub
    Private Sub DeactivateProjectFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'relaod all projects
        LBProjects.Items.Clear()
        ErrorProvider = Nothing
        ErrorProvider = FunLib.GetAllProjectsPrivileges()
        If ErrorProvider <> Nothing Then
            MsgBox_(ErrorProvider, 127, 23, False, Me)
            Me.Close()
        ElseIf FunLib.AllProjectWithPrivileges IsNot Nothing Then
            For Int1 = 0 To FunLib.AllProjectWithPrivileges.Length - 1
                LBProjects.Items.Add(FunLib.AllProjectWithPrivileges(Int1).ProjectName)
            Next
        End If
        If LBProjects.Items.Count = 0 Then
            MsgBox_("·« ÌÊÃœ „‘«—Ì⁄", 127, 23, False, Me)
            Exit Sub
        End If
    End Sub
    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If MsgBox("Â· «‰  „ √ﬂœ ?", MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
            ErrorProvider = Nothing
            ErrorProvider = FunLib.RemoveProject(FunLib.AllProjectWithPrivileges(LBProjects.SelectedIndex).ProjectID, ProjectsPath, DeletedFilesPath)
            If ErrorProvider Is Nothing Then
                MsgBox_(" „ «·Õ–›", 120, 23, True, Me)
                DeactivateProjectFrm_Load(sender, e)
                FrmMainForm.Enabled = False
                FrmMainForm.FillFolders()
                FrmMainForm.LoadAllIcons()
                FrmMainForm.Enabled = True
            Else
                MsgBox_(ErrorProvider, 0, 23, False, Me)
            End If
        End If
    End Sub
End Class