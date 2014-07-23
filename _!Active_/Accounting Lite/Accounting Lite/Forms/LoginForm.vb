Public Class LoginForm
    Private UserInfo As String
    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ArrArg() As String = Environment.GetCommandLineArgs
        If ArrArg.Length > 1 Then
            If ArrArg(1).ToLower.Trim = "uninstall" Then
                Process.Start(Environment.SystemDirectory & "\MsiExec.exe", "/I{74763A38-DB69-4039-AF57-23EE9A6E1A7C}")
                Process.GetCurrentProcess.Kill()
            End If
        End If
    End Sub
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        'If SecSTR <> CharToBinary(GetProcessorId) Then
        '    MsgBox_("Unrecognized PC Config", False, Me)
        '    Process.GetCurrentProcess.Kill()
        'End If
        Try ' Trial Version
            OLECon.Open()
            OLECmd.CommandText = "SELECT COUNT(BillID) AS BillZ FROM Bills"
            If Val(OLECmd.ExecuteScalar.ToString) > 500 Then
                MsgBox_("Can't connect to database", False, Me)
                Process.GetCurrentProcess.Kill()
            End If
        Catch
            Process.GetCurrentProcess.Kill()
        End Try
        OLECon.Close()
        '________________________________________________________________________________________________________
        OptionsFrm.BtnClose.Visible = False
        Try
            UserInfo = Nothing
            UserInfo = verifyLoginInfo(UsernameTextBox.Text, PasswordTextBox.Text)
            If UserInfo = Nothing Then
                MsgBox("ÎØÇÁ Ýí ÇÓã ÇáãÓÊÎÏã Çæ ßáãÉ ÇáãÑæÑ ãä ÝÖáß ÇÚÏ ÇáãÍÇæáå !!", MsgBoxStyle.Critical)
                Exit Sub
            End If
            Select Case UserInfo
                Case "SA" 'Super Admin
                    UserLoginInfo.UserType = UserTypes.SA
                Case "1" ' Viewer
                    UserLoginInfo.UserType = UserTypes.Viewer
                    'Setup Permissions for Supplier Form
                    FrmSupplier.BtnModels.Enabled = False
                    FrmSupplier.BtnModels.Text = "ãÛÜÜÜÜáÞ"
                    FrmSupplier.BtnIncoming.Enabled = False
                    FrmSupplier.BtnIncoming.Text = "ãÛÜÜÜÜáÞ"
                    FrmSupplier.BtnEditor.Enabled = False
                    FrmSupplier.BtnEditor.Text = "ãÛÜÜÜÜáÞ"
                    FrmSupplier.BtnQueries.Enabled = False
                    FrmSupplier.BtnQueries.Text = "ãÛÜÜÜÜáÞ"
                    FrmSupplier.BtnOptions.Enabled = False
                    FrmSupplier.BtnOptions.Text = "ãÛÜÜÜÜáÞ"
                Case "2" 'Entering
                    UserLoginInfo.UserType = UserTypes.Entering
                Case "3" ''Admin
                    UserLoginInfo.UserType = UserTypes.Admin
            End Select
            UserLoginInfo.ID = UsernameTextBox.Text
            UserLoginInfo.Pass = PasswordTextBox.Text
            FrmSupplier.Show()
            Me.Hide()
            UsernameTextBox.Clear()
            PasswordTextBox.Clear()
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
        Application.Exit()
    End Sub
    Private Sub UsernameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsernameTextBox.TextChanged
        If PasswordTextBox.TextLength > 0 And UsernameTextBox.TextLength > 0 Then
            OK.Enabled = True
        Else
            OK.Enabled = False
        End If
    End Sub
    Private Sub PasswordTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasswordTextBox.TextChanged
        If PasswordTextBox.TextLength > 0 And UsernameTextBox.TextLength > 0 Then
            OK.Enabled = True
        Else
            OK.Enabled = False
        End If
    End Sub
End Class
