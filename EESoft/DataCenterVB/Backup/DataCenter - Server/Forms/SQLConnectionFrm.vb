Public Class SQLConnectionFrm
    Private OFD As New OpenFileDialog
    Private DBPath As String = ""
    Private DBLogPath As String = ""
    Private ErrorProvider As String = Nothing
    Private Sub SQLConnectionFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OFD.CheckFileExists = True
        OFD.CheckPathExists = True
        OFD.DereferenceLinks = True
        OFD.Filter = "SQL Server Database (*.MDF)|*.MDF|All files (*.*)|*.*"
    End Sub
    Private Sub btnstart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstart.Click
        Dim done As Boolean = False
        If RBNotAttached.Checked = True Then
            If DBPath <> "" And DBLogPath <> "" Then 'With Log
                FunLib.AttachDB(OFD.FileName.Trim, OFD.FileName.Substring(0, OFD.FileName.Length - 8) & "Log.LDF", done)
                If done = True Then
                    FunLib.SQLCon.ConnectionString &= ";Initial Catalog=DataCenter" 'Set ConSTR in SQLCON and Registry
                Else
                    MessageBox.Show("Error while trying to access the server with your information", "Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

            ElseIf DBPath <> "" And DBLogPath = "" Then 'Without Log
                FunLib.AttachDB(OFD.FileName.Trim, done)
                If done = True Then
                    FunLib.SQLCon.ConnectionString &= ";Initial Catalog=DataCenter" 'Set ConSTR in SQLCON and Registry
                Else
                    MessageBox.Show("Error while trying to access the server with your information", "Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

            Else 'No db or log selected
                MsgBox_("Select Database path", 112, 23, False, Me)
                Exit Sub
            End If
        Else
            FunLib.SQLCon.ConnectionString &= ";Initial Catalog=" & CBDBName.SelectedItem.ToString
        End If
        FunLib.SetRegValue(FunLib.SQLCon.ConnectionString, FunctionLib.DataCenterServerLib.RegKeyValues.SQLString)
        FunLib.SetRegValue(FunLib.CharToBinary(TxtPW.Text.Trim), FunctionLib.DataCenterServerLib.RegKeyValues.PW)
        FunLib.SQLCon.ConnectionString &= ";password=" & TxtPW.Text.Trim
        ErrorProvider = Nothing
        ErrorProvider = FunLib.GetServerOption(DefaultUserPassword, ProjectsPath, RelatedFiles, DeletedFilesPath, ServerIP, ServerPort)
        If ErrorProvider <> Nothing Then
            MsgBox_("Can't start the application ' option error '", 20, 23, False, StartUpFrm)
            Application.Exit()
        End If
        FrmFilesChecker.Show()
        Me.Hide()
    End Sub
    Private Sub BtnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTest.Click
        Dim Done As Boolean = False
        FunLib.ServerTest(txtserver.Text.Trim, TxtID.Text.Trim, TxtPW.Text.Trim, Done)
        If Done = True Then
            GBDB.Visible = True
            RBAttached.Focus()
            txtserver.Enabled = False
            BtnTest.Enabled = False
            TxtID.Enabled = False
            TxtPW.Enabled = False
        Else
            MessageBox.Show("Error while trying to access the server with your information", "Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtserver.Focus()
        End If
    End Sub
    Private Sub txtserver_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtserver.TextChanged
        If txtserver.Text.Trim.Length > 0 And TxtID.Text.Trim.Length > 0 And TxtPW.Text.Trim.Length > 0 Then
            BtnTest.Enabled = True
        Else
            BtnTest.Enabled = False
        End If
    End Sub
    Private Sub BtnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEnd.Click
        Application.Exit()
    End Sub
    Private Sub TxtID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtID.TextChanged
        If txtserver.Text.Trim.Length > 0 And TxtID.Text.Trim.Length > 0 And TxtPW.Text.Trim.Length > 0 Then
            BtnTest.Enabled = True
        Else
            BtnTest.Enabled = False
        End If
    End Sub
    Private Sub TxtPW_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPW.TextChanged
        If txtserver.Text.Trim.Length > 0 And TxtID.Text.Trim.Length > 0 And TxtPW.Text.Trim.Length > 0 Then
            BtnTest.Enabled = True
        Else
            BtnTest.Enabled = False
        End If
    End Sub
    Private Sub BtnDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDB.Click
        Dim done As Boolean = False
        If OFD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If System.IO.File.Exists(OFD.FileName.Substring(0, OFD.FileName.Length - 8) & "Log.LDF") = True Then
                DBPath = OFD.FileName.Trim
                DBLogPath = OFD.FileName.Substring(0, OFD.FileName.Length - 8) & "Log.LDF"
            Else
                DBPath = OFD.FileName.Trim
                DBLogPath = ""
            End If
            btnstart.Enabled = True
            Dim arr() As String = OFD.FileName.Split("\")
            txtdatabase.Text = arr(arr.Length - 1)
        End If
    End Sub
    Private Sub RBAttached_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBAttached.CheckedChanged
        If RBAttached.Checked = True Then
            CBDBName.Enabled = True
            CBDBName.Items.Clear()
            Dim AllDatabaseNames() As String
            AllDatabaseNames = FunLib.GetAllDatabase()
            Dim Int1 As Int16
            If AllDatabaseNames IsNot Nothing Then
                For Int1 = 0 To AllDatabaseNames.Length - 1
                    CBDBName.Items.Add(AllDatabaseNames(Int1))
                Next
                CBDBName.Focus()
            End If
        Else
            CBDBName.Enabled = False
            CBDBName.Items.Clear()
        End If
    End Sub
    Private Sub RBNotAttached_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBNotAttached.CheckedChanged
        If RBNotAttached.Checked = True Then
            BtnDB.Enabled = True
        Else

        End If
    End Sub
    Private Sub CBDBName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBDBName.SelectedIndexChanged
        If CBDBName.SelectedIndex <> -1 Then
            btnstart.Enabled = True
        Else
            btnstart.Enabled = False
        End If
    End Sub
End Class