Public Class OptionsFrm
    Private Sub BtnBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBackup.Click
        Dim FBD As New FolderBrowserDialog
        If FBD.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try : IO.File.Copy(Application.StartupPath & "\DataBase\WearHouseDB.mdb", FBD.SelectedPath & "\WearHouseDB.mdb", True)
            Catch ex As Exception : MsgBox(ex.Message, MsgBoxStyle.Critical) : Exit Sub
            End Try
            MsgBox("���� �������� ������", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub BtnNewDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewDB.Click
        If MessageBox.Show("���� ���� ����� ����� �������� ������� � ����� ����� �����" & vbNewLine & "���� ��� ����� �", " �������", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Try : IO.File.Copy(Application.StartupPath & "\Default\WearHouseDB.mdb", Application.StartupPath & "\DataBase\WearHouseDB.mdb", True)
            Catch ex As Exception : MsgBox(ex.Message) : Exit Sub : End Try
            MsgBox("���� �������� ������", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub BtnLoadDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLoadDB.Click
        If MessageBox.Show("���� ���� ����� ����� �������� ������� � ������ ����� �����" & vbNewLine & "���� ��� ����� �", " �������", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Dim OFD As New OpenFileDialog
            OFD.Title = "����� ������ �����"
            OFD.Filter = "����� ������ �����(mdb)|*.mdb"
            OFD.FileName = ""
            OFD.CheckFileExists = True
            OFD.CheckPathExists = True
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                Try : IO.File.Copy(OFD.FileName, Application.StartupPath & "\DataBase\WearHouseDB.mdb", True)
                Catch ex As Exception : MsgBox(ex.Message, MsgBoxStyle.Critical) : Exit Sub : End Try
                MsgBox("���� �������� ������", MsgBoxStyle.Information)
            End If
        End If
    End Sub
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class