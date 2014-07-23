Public Class DisactivatedClientsFrm
    Dim Int1 As Int16
    Dim ErrorProvider As String = Nothing
    Private Sub RefreshList()
        BtnActivate.Enabled = False
        BtnDelete.Enabled = False
        LBCon.Items.Clear()
        ErrorProvider = Nothing
        ErrorProvider = FunLib.GetAllClients(False)
        If ErrorProvider = Nothing Then
            If FunLib.AllClients Is Nothing Then
                MsgBox_("No Disactivated Clients found", 87, 23, False, Me)
                Me.Close()
            ElseIf FunLib.AllClients.Length <= 0 Then
                MsgBox_("No Disactivated Clients found", 87, 23, False, Me)
                Me.Close()
            Else
                For Int1 = 0 To FunLib.AllClients.Length - 1
                    LBCon.Items.Add(FunLib.AllClients(Int1).ClientName)
                Next
            End If
        Else
            MsgBox_(ErrorProvider, 0, 20, False, Me)
            Me.Close()
        End If
    End Sub
    Private Sub DisactivatedClientsFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshList()
    End Sub
    Private Sub BtnActivate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActivate.Click
        If MsgBox("Are you sure ?", MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
            If LBCon.SelectedIndex <> -1 Then
                FunLib.DisactivateClients(FunLib.AllClients(LBCon.SelectedIndex).ClientID, True)
                MsgBox_("Clients activated", 129, 23, True, Me)
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
                ErrorProvider = FunLib.DeleteClients(FunLib.AllClients(LBCon.SelectedIndex).ClientID)
                Select Case ErrorProvider
                    Case Nothing
                        'cant delete this Client
                        MsgBox_("Can't delete Client", 123, 23, False, Me)
                    Case "1"
                        'Client deleted
                        MsgBox_("Client is deleted", 131, 23, True, Me)
                        RefreshList()
                    Case Else
                        'Sql error
                        MsgBox_(ErrorProvider, 0, 20, False, Me)
                End Select
            End If
        End If
    End Sub
End Class