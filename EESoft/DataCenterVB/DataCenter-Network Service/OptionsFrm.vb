Imports Microsoft.Win32
Public Class OptionsFrm
    Private Enum RegAutoStartKeyValues
        GeneralPort
        DeletedFilesPath
        DataCenterAutoStart
    End Enum
    Private Sub OptionsFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If GetRegAutoStartValue("", RegAutoStartKeyValues.DataCenterAutoStart) = True Then
                CBAutoStart.Checked = True
            Else
                CBAutoStart.Checked = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            CBAutoStart.Enabled = False
            BtnApply.Enabled = False
        End Try
    End Sub
    Private Sub BtnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnApply.Click
        Try
            If CBAutoStart.Checked = True Then
                SetRegAutoStartValue(Application.ExecutablePath, RegAutoStartKeyValues.DataCenterAutoStart)
            Else
                DelRegAutoStartValue(RegAutoStartKeyValues.DataCenterAutoStart)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Function GetRegAutoStartValue(ByRef KeyValue As String, ByVal ValueName As RegAutoStartKeyValues) As Boolean
        PrepareReg()
        Dim arr() As String = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", False).GetValueNames
        Dim ForInt As Integer = 0
        For ForInt = 0 To arr.Length - 1
            If arr(ForInt) = ValueName.ToString Then
                KeyValue = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", False).GetValue(ValueName.ToString)
                Return True
            End If
        Next
        Return False
    End Function
    Private Sub SetRegAutoStartValue(ByVal KeyValue As String, ByVal ValueName As RegAutoStartKeyValues)
        PrepareReg()
        Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(ValueName.ToString, KeyValue)
    End Sub
    Private Sub DelRegAutoStartValue(ByVal ValueName As RegAutoStartKeyValues)
        PrepareReg()
        Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(ValueName.ToString)
    End Sub
End Class