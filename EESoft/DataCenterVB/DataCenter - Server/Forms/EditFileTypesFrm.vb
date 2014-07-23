Public Class EditFileTypesFrm
    Private ErrorProvider As String = Nothing
    Private Int1 As Integer
    Private IconPathChaned As Boolean = False
    Private MadeChanges As Boolean = False
    Private Sub EditFileTypesFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ErrorProvider = Nothing
        CBTypes.Items.Clear()
        ErrorProvider = FunLib.GetAllFilesType(RelatedFiles)
        If ErrorProvider <> Nothing Then
            MsgBox_(ErrorProvider, 0, 23, False, Me)
        ElseIf FunLib.AllFilesType.Length > 0 Then
            For Int1 = 0 To FunLib.AllFilesType.Length - 1
                CBTypes.Items.Add(FunLib.AllFilesType(Int1).TypeName)
            Next
        End If
        If CBTypes.Items.Count = 0 Then
            MsgBox_("·« ÌÊÃœ «‰Ê«⁄", 116, 23, False, Me)
            Me.Close()
        End If
    End Sub
    Private Sub EditFileTypesFrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MadeChanges = True Then
            FrmMainForm.AppCantExit = True
            FrmMainForm.Close()
            FrmMainForm = New MainForm
            FrmMainForm.Show()
        End If
    End Sub
    Private Sub CBTypes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBTypes.SelectedIndexChanged
        If CBTypes.SelectedIndex <> -1 And CBTypes.Items.Count > 0 Then
            TxtName.Text = FunLib.AllFilesType(CBTypes.SelectedIndex).TypeName
            TxtDes.Text = FunLib.AllFilesType(CBTypes.SelectedIndex).TypeDesc
            TxtExt.Text = FunLib.AllFilesType(CBTypes.SelectedIndex).TypeExt
            If FunLib.AllFilesType(CBTypes.SelectedIndex).TypeIcon.Length > 0 Then
                LblIconPath.Text = FunLib.AllFilesType(CBTypes.SelectedIndex).TypeIcon
            Else
                LblIconPath.Text = "·« ÌÊÃœ"
            End If
            BtnSave.Enabled = True
            BtnDelete.Enabled = True
        Else
            BtnSave.Enabled = False
            BtnDelete.Enabled = False
        End If
    End Sub
    Private Sub BtnIcon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIcon.Click
        Dim OFD As New OpenFileDialog
        Dim FileInf As System.IO.FileInfo
        OFD.Filter = "All Files (*.*)|*.*"
        OFD.CheckFileExists = True
        OFD.CheckPathExists = True
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            FileInf = New System.IO.FileInfo(OFD.FileName)
            If CInt(FileInf.Length / 1048576) >= 10 Then
                MsgBox_("·« Ì„ﬂ‰ «÷«›… «ÌﬂÊ‰ «ﬂ»— „‰ 10 „ÌÃ«", 95, 23, False, Me)
            Else
                LblIconPath.Text = OFD.FileName
                IconPathChaned = True
            End If
        Else
            LblIconPath.Text = "·« ÌÊÃœ"
            IconPathChaned = False
        End If
    End Sub
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        MadeChanges = True
        Dim TargetFile As String = ""
        If LblIconPath.Text <> "·« ÌÊÃœ" And IconPathChaned = True Then
            'Initiate Target Path
            TargetFile = RelatedFiles & "Icons"
            'Copying File
            TargetFile = FunLib.Small_File_Transfer(LblIconPath.Text.Trim, TargetFile, "ico")
        End If
        'Saving new File Type to the database
        Dim Result As String = "no"
        If TargetFile = "Error" Then
            MsgBox_("·„ Ì „ Õ›Ÿ «·«ÌﬂÊ‰", 128, 23, False, Me)
            BtnIcon.Focus()
            Exit Sub
            If System.IO.File.Exists(TargetFile) Then
                System.IO.File.Delete(TargetFile)
            End If
        Else
            'Checking for icon path is selected or not
            If LblIconPath.Text <> "·« ÌÊÃœ" And IconPathChaned = True Then
                Result = FunLib.UpdateFileType(FunLib.AllFilesType(CBTypes.SelectedIndex).TypeID, TxtName.Text.Trim, TargetFile.Substring(RelatedFiles.Length), TxtDes.Text.Trim, TxtExt.Text.Trim)
            ElseIf LblIconPath.Text <> "·« ÌÊÃœ" And IconPathChaned = False Then
                Result = FunLib.UpdateFileType(FunLib.AllFilesType(CBTypes.SelectedIndex).TypeID, TxtName.Text.Trim, FunLib.AllFilesType(CBTypes.SelectedIndex).TypeIcon.Substring(RelatedFiles.Length), TxtDes.Text.Trim, TxtExt.Text.Trim)
            Else
                Result = FunLib.UpdateFileType(FunLib.AllFilesType(CBTypes.SelectedIndex).TypeID, TxtName.Text.Trim, "", TxtDes.Text.Trim, TxtExt.Text.Trim)
            End If
            If Result = Nothing Then
                'rebuild the FileType array
                FunLib.AllFilesType(CBTypes.SelectedIndex).TypeDesc = TxtDes.Text.Trim
                FunLib.AllFilesType(CBTypes.SelectedIndex).TypeExt = TxtExt.Text.Trim
                FunLib.AllFilesType(CBTypes.SelectedIndex).TypeName = TxtName.Text.Trim
                If LblIconPath.Text <> "·« ÌÊÃœ" Then
                    FunLib.AllFilesType(CBTypes.SelectedIndex).TypeIcon = TargetFile
                Else
                    FunLib.AllFilesType(CBTypes.SelectedIndex).TypeIcon = ""
                End If
                CBTypes.Items.Item(CBTypes.SelectedIndex) = TxtName.Text.Trim
                MsgBox_(" „ «· ⁄œÌ·", 134, 23, True, Me)
                TxtName.Focus()
            Else
                MsgBox_(Result, 0, 23, False, Me)
            End If
        End If
    End Sub
    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If MsgBox("Â· «‰  „ √ﬂœ ?", MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.No Then
            Exit Sub
        End If
        If FunLib.AllFilesType(CBTypes.SelectedIndex).TypeID = "0001" Then
            MsgBox_("·« Ì„ﬂ‰ Õ–› Â–« «·‰Ê⁄", 63, 23, False, Me)
            Exit Sub
        End If
        MadeChanges = True
        ErrorProvider = Nothing
        ErrorProvider = FunLib.DeleteFileType(FunLib.AllFilesType(CBTypes.SelectedIndex).TypeID)
        If ErrorProvider = Nothing Then
            If LblIconPath.Text <> "" Then
                If System.IO.File.Exists(LblIconPath.Text) Then
                    System.IO.File.Delete(LblIconPath.Text)
                End If
            End If
            TxtDes.Clear()
            TxtExt.Clear()
            TxtName.Clear()
            LblIconPath.Text = "·« ÌÊÃœ"
            MsgBox_(" „ «·Õ–›", 138, 23, True, Me)
            EditFileTypesFrm_Load(sender, e)
        Else
            MsgBox_(ErrorProvider, 0, 23, False, Me)
        End If
    End Sub
End Class