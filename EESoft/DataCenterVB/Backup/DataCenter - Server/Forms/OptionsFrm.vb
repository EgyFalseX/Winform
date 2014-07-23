Public Class OptionsFrm
    Private OFD As New FolderBrowserDialog
    Private ErrorProvider As String = Nothing
    Private Sub OptionsFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FrmOptions.TxtPassword.Text = DefaultUserPassword
        FrmOptions.TxtProjectPath.Text = ProjectsPath
        FrmOptions.TxtRelatedFiles.Text = RelatedFiles
        FrmOptions.TxtServerPort.Text = ServerPort
        FrmOptions.TxtServerIP.Text = ServerIP
        FrmOptions.TxtDeletedFiles.Text = DeletedFilesPath
    End Sub
    Private Sub TxtServerOptions_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPassword.TextChanged, TxtProjectPath.TextChanged, TxtRelatedFiles.TextChanged, TxtDeletedFiles.TextChanged
        If TxtPassword.Text.Trim.Length < 1 Or TxtProjectPath.Text.Trim.Length < 1 Or TxtRelatedFiles.Text.Trim.Length < 1 Or TxtDeletedFiles.Text.Trim.Length < 1 Then
            BtnSaveServerOptions.Enabled = False
        Else
            BtnSaveServerOptions.Enabled = True
        End If
    End Sub
    Private Sub BtnBrowseProjectPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBrowseProjectPath.Click
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            TxtProjectPath.Text = OFD.SelectedPath
            If TxtProjectPath.Text.Chars(TxtProjectPath.Text.Length - 1) <> "\" Then
                TxtProjectPath.Text &= "\"
            End If
        End If
    End Sub
    Private Sub BtnBrowseRelatedFiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBrowseRelatedFiles.Click
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            TxtRelatedFiles.Text = OFD.SelectedPath
            If TxtRelatedFiles.Text.Chars(TxtRelatedFiles.Text.Length - 1) <> "\" Then
                TxtRelatedFiles.Text &= "\"
            End If
        End If
    End Sub
    Private Sub BtnBrowseDeletedFiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBrowseDeletedFiles.Click
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            TxtDeletedFiles.Text = OFD.SelectedPath
            If TxtDeletedFiles.Text.Chars(TxtDeletedFiles.Text.Length - 1) <> "\" Then
                TxtDeletedFiles.Text &= "\"
            End If
        End If
    End Sub
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose1.Click, BtnClose2.Click
        Me.Close()
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveServerOptions.Click
        If MsgBox("Are you sure ?", MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.No Then
            Exit Sub
        End If
        ErrorProvider = Nothing
        ErrorProvider = FunLib.SaveServerOptions(TxtPassword.Text.Trim, TxtProjectPath.Text.Trim, TxtRelatedFiles.Text.Trim, TxtDeletedFiles.Text.Trim)
        If ErrorProvider = Nothing Then
            FunLib.SetRegValue(TxtDeletedFiles.Text.Trim, FunctionLib.DataCenterServerLib.RegKeyValues.DeletedFilesPath)
            DefaultUserPassword = TxtPassword.Text.Trim
            ProjectsPath = TxtProjectPath.Text.Trim
            RelatedFiles = TxtRelatedFiles.Text.Trim
            DeletedFilesPath = TxtDeletedFiles.Text.Trim
            MsgBox_("Option saved - Restart application to take effect", 25, 23, True, Me)
        Else
            MsgBox_("Option didn't saved", 119, 23, False, Me)
        End If
    End Sub
    Private Sub TxtClientOptions_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtServerIP.TextChanged, TxtServerPort.TextChanged
        If TxtServerIP.Text.Trim.Length < 1 Or TxtServerPort.Text.Trim.Length < 1 Then
            BtnSaveClientOptions.Enabled = False
        Else
            BtnSaveClientOptions.Enabled = True
        End If
    End Sub
    Private Sub BtnSaveClientOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveClientOptions.Click
        If MsgBox("Are you sure ?", MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.No Then
            Exit Sub
        End If
        ErrorProvider = Nothing
        ErrorProvider = FunLib.SaveClientOptions(TxtServerIP.Text.Trim, TxtServerPort.Text.Trim)
        If ErrorProvider = Nothing Then
            FunLib.SetRegValue(TxtServerPort.Text.Trim, FunctionLib.DataCenterServerLib.RegKeyValues.GeneralPort)
            FunLib.SetRegValue(TxtServerIP.Text.Trim, FunctionLib.DataCenterServerLib.RegKeyValues.ServerIP)
            ServerIP = TxtServerIP.Text.Trim
            ServerPort = TxtServerPort.Text.Trim
            MsgBox_("Option saved - Restart the service to take effect", 25, 23, True, Me)
        Else
            MsgBox_("Option didn't saved", 119, 23, False, Me)
        End If
    End Sub
    Private Sub BtnExitApp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExitApp.Click
        Process.GetCurrentProcess.Kill()
    End Sub
End Class