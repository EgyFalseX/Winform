Public Class SQLConnectionFrm
    Public OFD As New OpenFileDialog
    Private Sub SQLConnectionFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OFD.CheckFileExists = True
        OFD.CheckPathExists = True
        OFD.DereferenceLinks = True
        OFD.Filter = "SQL Server Database (*.MDF)|*.MDF|All files (*.*)|*.*"
    End Sub
    Private Sub btnstart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstart.Click
        FunLib.SQLCon.ConnectionString &= ";Initial Catalog=" & CBDBName.SelectedItem.ToString
        FunLib.SetRegValue(FunLib.SQLCon.ConnectionString, FunctionLib.DataCenterServerLib.RegKeyValues.SQLString)
        FunLib.SetRegValue(FunLib.CharToBinary(TxtPW.Text.Trim), FunctionLib.DataCenterServerLib.RegKeyValues.PW)
        FunLib.SQLCon.ConnectionString &= ";password=" & TxtPW.Text.Trim
        'MsgBox("Plz put the start form here", MsgBoxStyle.Information)
        'FrmLogin.ShowDialog()
        Application.Restart()
        Process.GetCurrentProcess.Kill()
        Me.Hide()
    End Sub
    Private Sub BtnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTest.Click
        Dim Done As Boolean = False
        FunLib.ServerTest(txtserver.Text.Trim, TxtID.Text.Trim, TxtPW.Text.Trim, Done)
        If Done = True Then
            txtserver.Enabled = False
            BtnTest.Enabled = False
            TxtID.Enabled = False
            TxtPW.Enabled = False
            'Open the other tesxt
            CBDBName.Enabled = True
            MessageBox.Show("Connction stablished", "Login Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CBDBName.Items.Clear()
            Dim AllDatabaseNames() As String = FunLib.GetAllDatabase
            Dim Int1 As Int16
            If AllDatabaseNames IsNot Nothing Then
                For Int1 = 0 To AllDatabaseNames.Length - 1
                    CBDBName.Items.Add(AllDatabaseNames(Int1))
                Next
                CBDBName.Focus()
            End If
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
    Private Sub CBDBName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBDBName.SelectedIndexChanged
        If CBDBName.SelectedIndex <> -1 Then
            btnstart.Enabled = True
        Else
            btnstart.Enabled = False
        End If
    End Sub
End Class