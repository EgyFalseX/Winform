Public Class NewContractorsFrm
    Private ErrorProvider As String = Nothing
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
    Private Sub TxtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtName.TextChanged
        If TxtName.Text.Trim.Length > 0 Then
            BtnSave.Enabled = True
        Else
            BtnSave.Enabled = True
        End If
    End Sub
    Private Sub ClearText()
        TxtAddress.Clear()
        TxtMail1.Clear()
        TxtMail2.Clear()
        TxtMob1.Clear()
        TxtMob2.Clear()
        TxtName.Clear()
        Txtpho1.Clear()
        TxtPho2.Clear()
        BtnSave.Enabled = False
        TxtName.Focus()
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        ErrorProvider = Nothing
        ErrorProvider = FunLib.AddNewContractor(TxtName.Text.Trim, TxtAddress.Text.Trim, TxtMob1.Text.Trim, TxtMob2.Text.Trim, Txtpho1.Text.Trim, TxtPho2.Text.Trim, Txtmail1.Text.Trim, Txtmail2.Text.Trim)
        Select Case ErrorProvider
            Case Nothing
                'Saved
                MsgBox_(" „ «·«÷«›Â", 109, 23, True, Me)
                ClearText()
            Case "Contractor Name In Used"
                'In Use name
                MsgBox_("«·«”„ „” Œœ„ ”«»ﬁ«", 97, 23, False, Me)
            Case Else
                'SQL Error
                MsgBox_(ErrorProvider, 0, 23, False, Me)
        End Select
    End Sub
End Class