Public Class DisactivatedContractorsFrm
    Dim Int1 As Int16
    Dim ErrorProvider As String = Nothing
    Private Sub RefreshList()
        BtnActivate.Enabled = False
        BtnDelete.Enabled = False
        LBCon.Items.Clear()
        ErrorProvider = Nothing
        ErrorProvider = FunLib.GetAllContractors(False)
        If ErrorProvider = Nothing Then
            If FunLib.AllContractors Is Nothing Then
                MsgBox_("No Disactivated contractors found", 71, 23, False, Me)
                Me.Close()
            ElseIf FunLib.AllContractors.Length <= 0 Then
                MsgBox_("No Disactivated contractors found", 71, 23, False, Me)
                Me.Close()
            Else
                For Int1 = 0 To FunLib.AllContractors.Length - 1
                    LBCon.Items.Add(FunLib.AllContractors(Int1).ContName)
                Next
            End If
        Else
            MsgBox_(ErrorProvider, 0, 20, False, Me)
            Me.Close()
        End If
    End Sub
    Private Sub DisactivatedContractorsFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshList()
    End Sub
    Private Sub BtnActivate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActivate.Click
        If MsgBox("Are you sure ?", MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
            If LBCon.SelectedIndex <> -1 Then
                FunLib.DisactivateContractors(FunLib.AllContractors(LBCon.SelectedIndex).ContID, True)
                MsgBox_("Contractors activated", 113, 23, True, Me)
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
        If MsgBox("Are you sure ?", MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
            If LBCon.SelectedIndex <> -1 Then
                ErrorProvider = FunLib.DeleteContractors(FunLib.AllContractors(LBCon.SelectedIndex).ContID)
                Select Case ErrorProvider
                    Case Nothing
                        'cant delete this contractor
                        MsgBox_("Can't delete contractor", 107, 23, False, Me)
                    Case "1"
                        'contractor deleted
                        MsgBox_("Contractor is deleted", 115, 23, True, Me)
                        RefreshList()
                    Case Else
                        'Sql error
                        MsgBox_(ErrorProvider, 0, 20, False, Me)
                End Select
            End If
        End If
    End Sub
End Class