Public Class EditContractorsFrm
    Private Int1 As Int16
    Private ErrorProvider As String = Nothing
    Private Sub ReloadContractors()
        CBCon.Items.Clear()
        ErrorProvider = Nothing
        ErrorProvider = FunLib.GetAllContractors(True)
        If ErrorProvider <> Nothing Then
            MsgBox_(ErrorProvider, 0, 23, False, Me)
            Me.Close()
        ElseIf FunLib.AllContractors IsNot Nothing Then
            For Int1 = 0 To FunLib.AllContractors.Length - 1
                CBCon.Items.Add(FunLib.AllContractors(Int1).ContName)
            Next
        Else
            MsgBox_("No Contractors found", 111, 23, False, Me)
            Me.Close()
        End If
    End Sub
    Private Sub ResetForm()
        TxtAddress.Clear()
        Txtmail1.Clear()
        Txtmail2.Clear()
        TxtMob1.Clear()
        TxtMob2.Clear()
        TxtName.Clear()
        Txtpho1.Clear()
        TxtPho2.Clear()
        BtnSave.Enabled = False
        BtnDeactivate.Enabled = False
        CBCon.SelectedIndex = -1
    End Sub
    Private Sub EditContractorsFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ReloadContractors()
    End Sub
    Private Sub TxtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtName.TextChanged
        If TxtName.Text.Trim.Length = 0 Then
            BtnSave.Enabled = False
        ElseIf TxtName.Text.Trim.Length > 0 And CBCon.SelectedIndex <> -1 Then
            BtnSave.Enabled = True
        End If
    End Sub
    Private Sub CBCon_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBCon.SelectedIndexChanged
        If CBCon.SelectedIndex <> -1 Then
            TxtName.Text = FunLib.AllContractors(CBCon.SelectedIndex).ContName
            TxtAddress.Text = FunLib.AllContractors(CBCon.SelectedIndex).ContAddress
            TxtMob1.Text = FunLib.AllContractors(CBCon.SelectedIndex).ContMob1
            TxtMob2.Text = FunLib.AllContractors(CBCon.SelectedIndex).ContMob2
            Txtpho1.Text = FunLib.AllContractors(CBCon.SelectedIndex).ContPho1
            TxtPho2.Text = FunLib.AllContractors(CBCon.SelectedIndex).ContPho2
            Txtmail1.Text = FunLib.AllContractors(CBCon.SelectedIndex).ContEmail1
            Txtmail2.Text = FunLib.AllContractors(CBCon.SelectedIndex).ContEmail2
            BtnDeactivate.Enabled = True
        Else
            BtnDeactivate.Enabled = False
        End If
    End Sub
    Private Sub BtnDeactivate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeactivate.Click
        If MsgBox("Are you sure ?", MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
            If CBCon.SelectedIndex <> -1 Then
                ErrorProvider = Nothing
                ErrorProvider = FunLib.DisactivateContractors(FunLib.AllContractors(CBCon.SelectedIndex).ContID, False)
                If ErrorProvider = Nothing Then
                    ResetForm()
                    MsgBox_("Contractor Deactivated", 106, 23, True, Me)
                    ReloadContractors()
                Else
                    MsgBox_("Can't Deactivate Contractor", 0, 23, False, Me)
                End If
            End If
        End If
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If CBCon.SelectedIndex <> -1 And TxtName.Text.Trim.Length > 0 Then
            Me.Enabled = False
            ErrorProvider = Nothing
            ErrorProvider = FunLib.UpdateContractors(FunLib.AllContractors(CBCon.SelectedIndex).ContID, TxtName.Text.Trim, TxtAddress.Text.Trim, TxtMob1.Text.Trim, TxtMob2.Text.Trim, Txtpho1.Text.Trim, TxtPho2.Text.Trim, Txtmail1.Text.Trim, Txtmail2.Text.Trim)
            If ErrorProvider = Nothing Then
                FunLib.AllContractors(CBCon.SelectedIndex).ContName = TxtName.Text.Trim
                FunLib.AllContractors(CBCon.SelectedIndex).ContAddress = TxtAddress.Text.Trim
                FunLib.AllContractors(CBCon.SelectedIndex).ContMob1 = TxtMob1.Text.Trim
                FunLib.AllContractors(CBCon.SelectedIndex).ContMob2 = TxtMob2.Text.Trim
                FunLib.AllContractors(CBCon.SelectedIndex).ContPho1 = Txtpho1.Text.Trim
                FunLib.AllContractors(CBCon.SelectedIndex).ContPho2 = TxtPho2.Text.Trim
                FunLib.AllContractors(CBCon.SelectedIndex).ContEmail1 = Txtmail1.Text.Trim
                FunLib.AllContractors(CBCon.SelectedIndex).ContEmail2 = Txtmail2.Text.Trim
                CBCon.Items.Item(CBCon.SelectedIndex) = TxtName.Text.Trim
                MsgBox_("Contractor update complate", 90, 23, True, Me)
            Else
                MsgBox_("Update not complate", 113, 23, False, Me)
            End If
            Me.Enabled = True
        End If
    End Sub
End Class