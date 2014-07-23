Imports System.IO
Public Class FilesCheckerFrm
    Public LVI(0) As ListViewItem
    Public ForInt As Int16
    Public AppCantExit As Boolean = False
    Private Sub CBFilter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBFilter.SelectedIndexChanged
        If CBFilter.SelectedIndex = 0 Then
            Dim i As Integer = LVFolderFile.CheckedItems.Count
            For i = LVFolderFile.CheckedItems.Count - 1 To 0 Step -1
                LVFolderFile.CheckedItems.Item(i).Remove()
            Next
        End If
    End Sub
    Private Sub Btnscan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnscan.Click
        Me.Btnscan.Enabled = False
        ReDim LVI(0)
        FunLib.GetAllFolderFile(ProjectsPath)
        PBData.Maximum = FunLib.FolderFileList.Length - 1
        LblTotal.Text = FunLib.FolderFileList.Length
        PBData.Value = 0
        For ForInt = 0 To FunLib.FolderFileList.Length - 1
            Application.DoEvents()
            LVI(ForInt) = New ListViewItem
            PBData.Value = ForInt
            Lblpercent.Text = CInt((ForInt / Val(FunLib.FolderFileList.Length - 1)) * 100)
            If FunLib.FolderFileList(ForInt).ID.Length > 0 Then
                If FunLib.FolderFileList(ForInt).type = FunctionLib.DataCenterServerLib.FolderAndFile.Folder Then
                    If Directory.Exists(FunLib.FolderFileList(ForInt).FilePath) Then
                        FunLib.FolderFileList(ForInt).Found = True
                        LVI(ForInt).ForeColor = Color.Green
                        LVI(ForInt).Checked = True
                        Lblfound.Text = Val(Lblfound.Text) + 1
                    Else
                        FunLib.FolderFileList(ForInt).Found = False
                        LVI(ForInt).ForeColor = Color.Red
                        LblNotFound.Text = Val(LblNotFound.Text) + 1
                    End If
                    LVI(ForInt).Text = FunLib.FolderFileList(ForInt).type.ToString
                    LVI(ForInt).SubItems.Add(FunLib.FolderFileList(ForInt).FilePath)
                    LVI(ForInt).SubItems.Add(FunLib.FolderFileList(ForInt).FileName)
                Else
                    If File.Exists(FunLib.FolderFileList(ForInt).FilePath) Then
                        FunLib.FolderFileList(ForInt).Found = True
                        LVI(ForInt).ForeColor = Color.Green
                        LVI(ForInt).Checked = True
                        Lblfound.Text = Val(Lblfound.Text) + 1
                    Else
                        FunLib.FolderFileList(ForInt).Found = False
                        LVI(ForInt).ForeColor = Color.Red
                        LblNotFound.Text = Val(LblNotFound.Text) + 1
                    End If
                    LVI(ForInt).Text = FunLib.FolderFileList(ForInt).type.ToString
                    LVI(ForInt).SubItems.Add(FunLib.FolderFileList(ForInt).FilePath)
                    LVI(ForInt).SubItems.Add(FunLib.FolderFileList(ForInt).FileName)
                End If
                ReDim Preserve LVI(LVI.Length)
            End If
        Next
        ReDim Preserve LVI(LVI.Length - 2)
        LVFolderFile.Items.AddRange(LVI)
        Btnscan.Enabled = False
        BtnStart.Enabled = True
    End Sub
    Private Sub BtnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStart.Click
        FunLib.SetRegValue("Done", FunctionLib.DataCenterServerLib.RegKeyValues.DataChacked)
        FrmMainForm = New MainForm
        FrmMainForm.Show()
        Me.Hide()
    End Sub
    Private Sub FilesCheckerFrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If AppCantExit = False Then
            Application.Exit()
        End If
    End Sub
End Class