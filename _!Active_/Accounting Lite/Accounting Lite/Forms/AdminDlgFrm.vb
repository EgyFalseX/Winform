Imports System.Windows.Forms
Public Class AdminDlgFrm
    Private Sub AdminUserNameTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminUserNameTxt.TextChanged
        If AdminUserNameTxt.TextLength > 0 Then
            AdminOKBtn.Enabled = True
        Else
            AdminOKBtn.Enabled = False
        End If
    End Sub
    Private Sub AdminPassword1Txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminPassword1Txt.TextChanged, AdminPassword2Txt.TextChanged
        If AdminPassword1Txt.TextLength > -1 And AdminPassword2Txt.TextLength > -1 And AdminPassword1Txt.Text.Trim = AdminPassword2Txt.Text.Trim Then
            AdminOKBtn.Enabled = True
        Else
            AdminOKBtn.Enabled = False
        End If
    End Sub
    Private Sub AdminUserNameRB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminUserNameRB.CheckedChanged, AdminPasswordRB.CheckedChanged
        If AdminUserNameRB.Checked = True Then
            AdminUserNameTxt.Enabled = True
            AdminPassword1Txt.Enabled = False
            AdminPassword2Txt.Enabled = False
            AdminUserNameTxt.Clear()
            AdminPassword1Txt.Clear()
            AdminPassword2Txt.Clear()
            AdminOKBtn.Enabled = False
        ElseIf AdminPasswordRB.Checked = True Then
            AdminUserNameTxt.Enabled = False
            AdminPassword1Txt.Enabled = True
            AdminPassword2Txt.Enabled = True
            AdminUserNameTxt.Clear()
            AdminPassword1Txt.Clear()
            AdminPassword2Txt.Clear()
            AdminOKBtn.Enabled = False
        Else
            AdminUserNameTxt.Enabled = False
            AdminPassword1Txt.Enabled = False
            AdminPassword2Txt.Enabled = False
        End If
    End Sub
    Private Sub AdminOKBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminOKBtn.Click
        Try
            If AdminUserNameRB.Checked = True Then
                OLECmd.CommandText = "update SAdmin set AdminName='" & AdminUserNameTxt.Text.Trim & "'"
                OLECon.Open()
                OLECMD.ExecuteNonQuery()
                MsgBox(" „  €Ì— «”„ «·„œÌ— »‰Ã«Õ", MsgBoxStyle.Information, " „  «·⁄„·ÌÂ »‰Ã«Õ")
            ElseIf AdminPasswordRB.Checked = True Then
                OLECmd.CommandText = "update SAdmin set AdminPass='" & AdminPassword1Txt.Text.Trim & "'"
                OLECon.Open()
                OLECMD.ExecuteNonQuery()
                MsgBox(" „  €Ì— ﬂ·„… „—Ê— «·„œÌ— »‰Ã«Õ", MsgBoxStyle.Information, " „  «·⁄„·ÌÂ »‰Ã«Õ")
            End If
            AdminUserNameTxt.Clear()
            AdminPassword1Txt.Clear()
            AdminPassword2Txt.Clear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        OLECon.Close()
    End Sub
    Private Sub UserUserNameTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserUserNameTxt.TextChanged, UserPassword1Txt.TextChanged, UserPassword2Txt.TextChanged, UserPrivilegeCB.SelectedIndexChanged
        If UserUserNameTxt.TextLength > 0 And UserPassword1Txt.TextLength > 0 And UserPassword2Txt.TextLength > 0 And UserPassword1Txt.Text.Trim = UserPassword2Txt.Text.Trim And UserPrivilegeCB.SelectedIndex > -1 Then
            UserOKBtn.Enabled = True
        Else
            UserOKBtn.Enabled = False
        End If
    End Sub
    Private Sub UserOKBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserOKBtn.Click
        Try
            Dim UserType As String = 1
            Select Case UserPrivilegeCB.SelectedIndex
                Case 0
                    UserType = "1" 'Entering
                Case 1
                    UserType = "2" 'Viewing
                Case 2
                    UserType = "3" 'Admin
                Case Else
                    Exit Sub
            End Select
            OLECmd.CommandText = "insert into Users (UserName,UserPass,UserTypeID) values ('" & UserUserNameTxt.Text.Trim & "','" & UserPassword1Txt.Text.Trim & "','" & UserType & "')"
            OLECon.Open()
            OLECmd.ExecuteNonQuery()
            MsgBox(" „ «÷«›… „” Œœ„ ÃœÌœ", MsgBoxStyle.Information, " „  «·⁄„·ÌÂ »‰Ã«Õ")
            UserUserNameTxt.Clear()
            UserPassword1Txt.Clear()
            UserPassword2Txt.Clear()
            UserPrivilegeCB.SelectedIndex = -1
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        OLECon.Close()
    End Sub
    Private Sub OptionCloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionCloseBtn.Click
        Me.Close()
    End Sub
End Class
