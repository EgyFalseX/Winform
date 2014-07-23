Imports System.IO
Public Class LockedFilesFrm
    Private LVI As ListViewItem
    Public ForInt As Int16
    Private LockedFiles(-1) As FunctionLib.DataCenterServerLib.LockedFilesSTR
    Private ErrorproviderZ As String = Nothing
    Dim ReloadFiles As Boolean = False
    Private Sub LockedFilesFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LVFiles.Items.Clear()
        ErrorproviderZ = FunLib.GetAllLockedFile(LockedFiles)
        If ErrorproviderZ = Nothing Then
            If LockedFiles.Length > 0 Then
                For ForInt = 0 To LockedFiles.Length - 1
                    LVI = New ListViewItem
                    LVI.Tag = LockedFiles(ForInt).FileID
                    LVI.Text = LockedFiles(ForInt).FileName
                    LVI.SubItems.Add(LockedFiles(ForInt).FilePath)
                    LVI.SubItems.Add(LockedFiles(ForInt).ProjectName)
                    LVI.SubItems.Add(LockedFiles(ForInt).UsrName)
                    LVFiles.Items.Add(LVI)
                Next
            Else
                MsgBox_("·« ÌÊÃœ „·›«  „€·ﬁÂ", 114, 23, False, Me)
                Me.Close()
            End If
        Else
            MsgBox_(ErrorproviderZ, 0, 23, False, Me)
            Me.Close()
        End If
    End Sub
    Private Sub BtnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnApply.Click
        If MsgBox("Â· «‰  „ √ﬂœ?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If
        For ForInt = 0 To LVFiles.CheckedItems.Count - 1
            ErrorproviderZ = Nothing
            ErrorproviderZ = FunLib.UnLockFile(LVFiles.CheckedItems(ForInt).Tag)
            If ErrorproviderZ <> Nothing Then
                MsgBox_(ErrorproviderZ, 0, 23, False, Me)
                Me.Close()
            End If
        Next
        MsgBox_(" „ «·› Õ", 131, 23, True, Me)
        ReDim LockedFiles(-1)
        ErrorproviderZ = Nothing
        LockedFilesFrm_Load(sender, e)
        ReloadFiles = True
    End Sub
    Private Sub LVFiles_ItemChecked(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles LVFiles.ItemChecked
        If LVFiles.CheckedItems.Count = 0 Then
            BtnApply.Enabled = False
        Else
            BtnApply.Enabled = True
        End If
    End Sub
    Private Sub CBSelectAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBSelectAll.CheckedChanged
        If CBSelectAll.Checked = True Then
            CBSelectNone.Checked = False
            For ForInt = 0 To LVFiles.Items.Count - 1
                LVFiles.Items(ForInt).Checked = True
            Next
        End If
    End Sub
    Private Sub CBSelectNone_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBSelectNone.CheckedChanged
        If CBSelectNone.Checked = True Then
            CBSelectAll.Checked = False
            For ForInt = 0 To LVFiles.Items.Count - 1
                LVFiles.Items(ForInt).Checked = False
            Next
        End If
    End Sub
End Class