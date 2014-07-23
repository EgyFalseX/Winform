Public Class NewConsultantsFrm
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Dim TargetFile As String = ""
        If LblCVPath.Text <> "CV Not Selected" Then
            'Initiate Target Path
            TargetFile = RelatedFiles & "Curriculum Vitae"
            'Dim FilePathFolders() As String = LblCVPath.Text.Split("\")
            'TargetFile &= "\" & FilePathFolders(FilePathFolders.Length - 1)
            'Copying File
            TargetFile = FunLib.Small_File_Transfer(LblCVPath.Text.Trim, TargetFile, "CV")
        End If
        'Saving new consultant to the database
        Dim Result As String = "no"
        If TargetFile = "" Then
            If System.IO.File.Exists(TargetFile) Then
                System.IO.File.Delete(TargetFile)
            End If
            Result = FunLib.AddNewConsultants(TxtName.Text.Trim, TxtAddress.Text.Trim, Txtpho1.Text.Trim, TxtPho2.Text.Trim, TxtMob1.Text.Trim, TxtMob2.Text.Trim, TxtMail1.Text.Trim, Txtmail2.Text.Trim, "")
        Else
            Result = FunLib.AddNewConsultants(TxtName.Text.Trim, TxtAddress.Text.Trim, Txtpho1.Text.Trim, TxtPho2.Text.Trim, TxtMob1.Text.Trim, TxtMob2.Text.Trim, TxtMail1.Text.Trim, Txtmail2.Text.Trim, TargetFile.Substring(RelatedFiles.Length))
        End If
        'Check for if the data saved or not
        If Result = "yes" Then
            MsgBox_("File transfer completed - New Consultant Saved...   ", 12, 23, True, Me)
        ElseIf Result = "no" Then
            If System.IO.File.Exists(TargetFile) Then
                System.IO.File.Delete(TargetFile)
            End If
            TxtName.Focus()
            Exit Sub
            'MsgBox("Sorry Data didnt saved Please try after restarting the program", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
    Private Sub BtnCV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCV.Click
        Dim OFD As New OpenFileDialog
        Dim FileInf As System.IO.FileInfo
        OFD.Filter = "All Files (*.*)|*.*"
        OFD.CheckFileExists = True
        OFD.CheckPathExists = True
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            FileInf = New System.IO.FileInfo(OFD.FileName)
            If CInt(FileInf.Length / 1048576) >= 10 Then
                MsgBox_("CV must be less than 10M", 95, 23, False, Me)
            Else
                LblCVPath.Text = OFD.FileName
            End If
        Else
            LblCVPath.Text = "CV Not Selected"
        End If
    End Sub
    Private Sub TxtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtName.TextChanged
        If TxtName.Text.Trim.Length > 0 Then
            BtnSave.Enabled = True
        Else
            BtnSave.Enabled = False
        End If
    End Sub
End Class