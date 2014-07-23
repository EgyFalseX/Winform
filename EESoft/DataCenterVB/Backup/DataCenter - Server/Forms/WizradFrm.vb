Public Class WizradFrm
    Private ErrorProvider As String = Nothing
    Private Int1 As Int16

    Private Sub WizradFrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        FrmMainForm = New MainForm
        FrmMainForm.Show()
    End Sub
    Private Sub WizradFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MainTreeView.ExpandAll()
        MainTreeView.Focus()
        MainTreeView.SelectedNode = MainTreeView.Nodes.Item(0).Nodes(4)
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
    Private Sub TxtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtName.TextChanged
        'If TxtName.Text.Trim.Length > 0 Then
        '    For Int1 = 0 To TxtName.Text.Trim.Length - 1
        '        If Char.IsLetterOrDigit(TxtName.Text.Trim.Chars(Int1)) = False Then
        '            TxtName.Clear()
        '        End If
        '    Next
        'End If
        If TxtName.Text.Trim.Length > 0 And TxtLocation.Text.Trim.Length > 0 Then
            BtnAdd.Enabled = True
        Else
            BtnAdd.Enabled = False
        End If
        For Int1 = 0 To sender.Text.Trim.Length - 1
            If Char.IsLetterOrDigit(sender.Text.Chars(Int1)) = False And sender.Text.Chars(Int1) <> "_" And sender.Text.Chars(Int1) <> " " Then
                sender.text = ""
                'Prepare the Error MSG
                MsgBox_("Please enter letter or digit", 98, 23, False, Me)
                Exit For
            End If
        Next
    End Sub
    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        If MsgBox("Are you sure ?", MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.No Then
            Exit Sub
        End If
        ErrorProvider = Nothing
        MainProgressBar.Visible = True
        Me.Enabled = False
        ErrorProvider = FunLib.AddNewProject(TxtName.Text.Trim, TxtLocation.Text.Trim, CDate(MCStart.SelectionEnd.ToString).ToShortDateString, CDate(MCEnd.SelectionEnd.ToString).ToShortDateString, AdminID, ProjectsPath, MainProgressBar.Value)
        If ErrorProvider = Nothing Then
            MsgBox_("All complete - New project added", 74, 23, True, Me)
            Me.Close()
        Else
            MsgBox_(ErrorProvider, 0, 23, False, Me)
        End If
        Me.Enabled = True
    End Sub
    Private Sub TxtLocation_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtLocation.TextChanged
        If TxtName.Text.Trim.Length > 0 And TxtLocation.Text.Trim.Length > 0 Then
            BtnAdd.Enabled = True
        Else
            BtnAdd.Enabled = False
        End If
    End Sub

End Class