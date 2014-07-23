Public Class NewFileTypesFrm
    Private MadeChanges As Boolean = False

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
            End If
        Else
            LblIconPath.Text = "·« ÌÊÃœ"
        End If
    End Sub
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
    Private Sub TxtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtName.TextChanged
        If TxtName.Text.Trim.Length > 0 And TxtExt.Text.Trim.Length > 0 Then
            BtnSave.Enabled = True
        Else
            BtnSave.Enabled = False
        End If
    End Sub
    Private Sub TxtExt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtExt.TextChanged
        If TxtName.Text.Trim.Length > 0 And TxtExt.Text.Trim.Length > 0 Then
            BtnSave.Enabled = True
        Else
            BtnSave.Enabled = False
        End If
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Dim TargetFile As String = ""
        If LblIconPath.Text <> "·« ÌÊÃœ" Then
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
            If LblIconPath.Text <> "·« ÌÊÃœ" Then
                Result = FunLib.AddNewFileType(TxtName.Text.Trim, TargetFile.Substring(RelatedFiles.Length), TxtDes.Text.Trim, TxtExt.Text.Trim)
            Else
                Result = FunLib.AddNewFileType(TxtName.Text.Trim, "", TxtDes.Text.Trim, TxtExt.Text.Trim)
            End If
            If Val(Result) > 0 Then
                MsgBox_(" „ «·«÷«›Â", 125, 23, True, Me)
                TxtName.Clear()
                TxtExt.Clear()
                TxtDes.Clear()
                LblIconPath.Text = "·« ÌÊÃœ"
                MadeChanges = True
                TxtName.Focus()
            Else
                MsgBox_(Result, 0, 23, False, Me)
            End If
        End If
    End Sub
    Private Sub NewFileTypesFrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MadeChanges = True Then
            FrmMainForm.AppCantExit = True
            FrmMainForm.Close()
            FrmMainForm = New MainForm
            FrmMainForm.Show()
        End If
    End Sub
End Class