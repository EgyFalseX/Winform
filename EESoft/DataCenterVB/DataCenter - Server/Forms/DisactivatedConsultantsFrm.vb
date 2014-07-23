Public Class DisactivatedConsultantsFrm
    Dim Int1 As Int16
    Dim ErrorProvider As String = Nothing
    Private Sub RefreshList()
        BtnActivate.Enabled = False
        BtnDelete.Enabled = False
        LBCon.Items.Clear()
        ErrorProvider = Nothing
        ErrorProvider = FunLib.GetAllConsultants(RelatedFiles, False)
        If ErrorProvider = Nothing Then
            If FunLib.AllConsultanats Is Nothing Then
                MsgBox_("·« ÌÊÃœ „œÌ—Ì‰ €Ì— „›⁄·Ì‰", 71, 23, False, Me)
                Me.Close()
            ElseIf FunLib.AllConsultanats.Length <= 0 Then
                MsgBox_("·« ÌÊÃœ „œÌ—Ì‰ €Ì— „›⁄·Ì‰", 71, 23, False, Me)
                Me.Close()
            Else
                For Int1 = 0 To FunLib.AllConsultanats.Length - 1
                    LBCon.Items.Add(FunLib.AllConsultanats(Int1).ConsName)
                Next
            End If
        Else
            MsgBox_(ErrorProvider, 0, 20, False, Me)
            Me.Close()
        End If
    End Sub
    Private Sub DisactivatedConsultantsFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshList()
    End Sub
    Private Sub BtnActivate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActivate.Click
        If MsgBox("Â· «‰  „ √ﬂœ ?", MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
            If LBCon.SelectedIndex <> -1 Then
                FunLib.DisactivateConsultants(FunLib.AllConsultanats(LBCon.SelectedIndex).ConsID, True)
                MsgBox_(" „ «· ›⁄Ì·", 113, 23, True, Me)
                RefreshList()
            End If
        End If
    End Sub
    Private Sub LBUsers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBCon.SelectedIndexChanged
        If LBCon.SelectedIndex <> -1 Then
            BtnActivate.Enabled = True
            BtnDelete.Enabled = True
        End If
    End Sub
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If MsgBox("Â· «‰  „ √ﬂœ ?", MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
            If LBCon.SelectedIndex <> -1 Then
                ErrorProvider = FunLib.DeleteConsultants(FunLib.AllConsultanats(LBCon.SelectedIndex).ConsID)
                Select Case ErrorProvider
                    Case Nothing
                        'cant delete this contractor
                        MsgBox_("·« Ì„ﬂ‰ «·Õ–›", 107, 23, False, Me)
                    Case "1"
                        'contractor deleted and trying to delete the CV
                        If System.IO.File.Exists(FunLib.AllConsultanats(LBCon.SelectedIndex).ConsCVPath) Then
                            Try
                                System.IO.File.Delete(FunLib.AllConsultanats(LBCon.SelectedIndex).ConsCVPath)
                            Catch ex As Exception
                                MsgBox_(ErrorProvider, 0, 20, False, Me)
                            End Try
                        End If
                        MsgBox_(" „ «·Õ–›", 115, 23, True, Me)
                        RefreshList()
                    Case Else
                        'Sql error
                        MsgBox_(ErrorProvider, 0, 20, False, Me)
                End Select
            End If
        End If
    End Sub
End Class