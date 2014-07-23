Public Class EditConsultantsFrm
    Private Int1 As Int16
    Private ErrorProvider As String = Nothing
    Private Sub ReloadConsultants()
        CBCon.Items.Clear()
        ErrorProvider = Nothing
        ErrorProvider = FunLib.GetAllConsultants(RelatedFiles, True)
        If ErrorProvider <> Nothing Then
            MsgBox_(ErrorProvider, 0, 23, False, Me)
            Me.Close()
        ElseIf FunLib.AllConsultanats IsNot Nothing Then
            For Int1 = 0 To FunLib.AllConsultanats.Length - 1
                CBCon.Items.Add(FunLib.AllConsultanats(Int1).ConsName)
            Next
        Else
            MsgBox_("·« ÌÊÃœ „œÌ—Ì‰", 111, 23, False, Me)
            Me.Close()
        End If
    End Sub
    Private Sub ResetForm()
        LblCVPath.Text = "·« ÌÊÃœ"
        TxtAddress.Clear()
        TxtMail1.Clear()
        Txtmail2.Clear()
        TxtMob1.Clear()
        TxtMob2.Clear()
        TxtName.Clear()
        Txtpho1.Clear()
        TxtPho2.Clear()
        BtnSave.Enabled = False
        BtnCV.Enabled = False
        BtnDeactivate.Enabled = False
        CBCon.SelectedIndex = -1
    End Sub
    Private Sub BtnCV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCV.Click
        If CBCon.SelectedIndex <> -1 Then
            Dim OFD As New OpenFileDialog
            Dim FileInf As System.IO.FileInfo
            OFD.Filter = "All Files (*.*)|*.*"
            OFD.CheckFileExists = True
            OFD.CheckPathExists = True
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                FileInf = New System.IO.FileInfo(OFD.FileName)
                If CInt(FileInf.Length / 1048576) >= 10 Then
                    MsgBox_("«·”Ì—Â ÌÃ» «‰  ﬂÊ‰ «ﬁ· „‰ 10 „ÌÃ«", 95, 23, False, Me)
                Else
                    LblCVPath.Text = OFD.FileName
                End If
            Else
                LblCVPath.Text = "·« ÌÊÃœ"
            End If
        End If
    End Sub
    Private Sub EditConsultantsFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ReloadConsultants()
    End Sub
    Private Sub CBCon_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBCon.SelectedIndexChanged
        If CBCon.SelectedIndex <> -1 Then
            TxtAddress.Text = FunLib.AllConsultanats(CBCon.SelectedIndex).ConsAddress
            TxtMail1.Text = FunLib.AllConsultanats(CBCon.SelectedIndex).ConsEmail1
            Txtmail2.Text = FunLib.AllConsultanats(CBCon.SelectedIndex).ConsEmail2
            TxtMob1.Text = FunLib.AllConsultanats(CBCon.SelectedIndex).ConsMob1
            TxtMob2.Text = FunLib.AllConsultanats(CBCon.SelectedIndex).ConsMob2
            TxtName.Text = FunLib.AllConsultanats(CBCon.SelectedIndex).ConsName
            Txtpho1.Text = FunLib.AllConsultanats(CBCon.SelectedIndex).ConsPho1
            TxtPho2.Text = FunLib.AllConsultanats(CBCon.SelectedIndex).ConsPho2
            If FunLib.AllConsultanats(CBCon.SelectedIndex).ConsCVPath.Length = 0 Then
                LblCVPath.Text = "·« ÌÊÃœ"
            Else
                LblCVPath.Text = FunLib.AllConsultanats(CBCon.SelectedIndex).ConsCVPath
            End If
            BtnDeactivate.Enabled = True
        Else
            BtnDeactivate.Enabled = False
        End If
    End Sub
    Private Sub TxtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtName.TextChanged
        If TxtName.Text.Trim.Length = 0 Then
            BtnSave.Enabled = False
            BtnCV.Enabled = False
        ElseIf TxtName.Text.Trim.Length > 0 And CBCon.SelectedIndex <> -1 Then
            BtnSave.Enabled = True
            BtnCV.Enabled = True
        End If
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If CBCon.SelectedIndex <> -1 And TxtName.Text.Trim.Length > 0 Then
            Me.Enabled = False
            ErrorProvider = Nothing
            Dim NewPath As String = LblCVPath.Text
            If LblCVPath.Text = "·« ÌÊÃœ" Then
                ErrorProvider = FunLib.UpdateConsultants(Nothing, FunLib.AllConsultanats(CBCon.SelectedIndex).ConsID, TxtName.Text.Trim, TxtAddress.Text.Trim, TxtMob1.Text.Trim, TxtMob2.Text.Trim, Txtpho1.Text.Trim, TxtPho2.Text.Trim, TxtMail1.Text.Trim, Txtmail2.Text.Trim, "")
            Else
                If LblCVPath.Text <> FunLib.AllConsultanats(CBCon.SelectedIndex).ConsCVPath Then
                    NewPath = FunLib.Small_File_Transfer(LblCVPath.Text.Trim, RelatedFiles & "Curriculum Vitae", "CV")
                    If System.IO.File.Exists(FunLib.AllConsultanats(CBCon.SelectedIndex).ConsCVPath) And NewPath.Length > 0 Then
                        System.IO.File.Delete(FunLib.AllConsultanats(CBCon.SelectedIndex).ConsCVPath)
                    End If
                End If
                ErrorProvider = FunLib.UpdateConsultants(RelatedFiles, FunLib.AllConsultanats(CBCon.SelectedIndex).ConsID, TxtName.Text.Trim, TxtAddress.Text.Trim, TxtMob1.Text.Trim, TxtMob2.Text.Trim, Txtpho1.Text.Trim, TxtPho2.Text.Trim, TxtMail1.Text.Trim, Txtmail2.Text.Trim, NewPath)
            End If
            If ErrorProvider = Nothing Then
                FunLib.AllConsultanats(CBCon.SelectedIndex).ConsName = TxtName.Text.Trim
                FunLib.AllConsultanats(CBCon.SelectedIndex).ConsAddress = TxtAddress.Text.Trim
                FunLib.AllConsultanats(CBCon.SelectedIndex).ConsEmail1 = TxtMail1.Text.Trim
                FunLib.AllConsultanats(CBCon.SelectedIndex).ConsEmail2 = Txtmail2.Text.Trim
                FunLib.AllConsultanats(CBCon.SelectedIndex).ConsMob1 = TxtMob1.Text.Trim
                FunLib.AllConsultanats(CBCon.SelectedIndex).ConsMob2 = TxtMob2.Text.Trim
                FunLib.AllConsultanats(CBCon.SelectedIndex).ConsPho1 = Txtpho1.Text.Trim
                FunLib.AllConsultanats(CBCon.SelectedIndex).ConsPho2 = Txtpho1.Text.Trim
                If LblCVPath.Text = "·« ÌÊÃœ" Then
                    FunLib.AllConsultanats(CBCon.SelectedIndex).ConsCVPath = ""
                Else
                    If NewPath = "" Then
                        FunLib.AllConsultanats(CBCon.SelectedIndex).ConsCVPath = ""
                        MsgBox("·„ Ì „ «·Õ›Ÿ", MsgBoxStyle.Critical)
                        ResetForm()
                        ReloadConsultants()
                    Else
                        FunLib.AllConsultanats(CBCon.SelectedIndex).ConsCVPath = NewPath
                    End If
                End If
                CBCon.Items.Item(CBCon.SelectedIndex) = TxtName.Text.Trim
                MsgBox_(" „ «· ⁄œÌ·", 90, 23, True, Me)
            Else
                MsgBox_("·„ Ì „ «· ⁄œÌ·", 113, 23, False, Me)
            End If
            Me.Enabled = True
        End If
    End Sub
    Private Sub BtnDeactivate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeactivate.Click
        If MsgBox("Â· «‰  „ √ﬂœ ?", MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
            If CBCon.SelectedIndex <> -1 Then
                ErrorProvider = Nothing
                ErrorProvider = FunLib.DisactivateConsultants(FunLib.AllConsultanats(CBCon.SelectedIndex).ConsID, False)
                If ErrorProvider = Nothing Then
                    ResetForm()
                    MsgBox_(" „ «· ⁄ÿÌ·", 106, 23, True, Me)
                    ReloadConsultants()
                Else
                    MsgBox_("·„ Ì „ «· ⁄ÿÌ·", 0, 23, False, Me)
                End If
            End If
        End If
    End Sub
End Class