Imports System.Net
Imports System.Net.Sockets
Imports Microsoft.Win32
Module MModule
    'Forms
    Public FrmOptions As New OptionsFrm
    Public FrmMain As New MainFrm
    'Options
    Public DeletedFilesPath As String = ""
    Public GeneralPort As Int16
    'Public AutoStart As String
    Public FileIfo As String
    Public EnableCommand As Boolean = False
    Public Enum Commands 'this is the commands between the server and the client
        Ping ' command 0
        SendFile 'command 1
        ReciveFile 'command 2
        CreateFile 'command 3
        CreateFolder 'command 4
        RemoveFolder 'Command 5
        RemoveFile 'Command 6
        MoveFolder 'Command 7
    End Enum
    Public Enum RegKeyValues
        GeneralPort
        DeletedFilesPath
    End Enum
    Public Sub PrepareReg()
        Dim RegKey As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE", True)
        Dim arr() As String
        Dim ForInt As Integer = 0
        arr = Registry.LocalMachine.OpenSubKey("SOFTWARE").GetSubKeyNames
        For ForInt = 0 To arr.Length - 1
            If arr(ForInt) = "Mena Data Center" Then
            End If
        Next
        RegKey.CreateSubKey("Mena Data Center")
    End Sub
    Public Sub SetRegValue(ByVal KeyValue As String, ByVal ValueName As RegKeyValues)
        PrepareReg()
        Registry.LocalMachine.OpenSubKey("SOFTWARE\Mena Data Center", True).SetValue(ValueName.ToString, KeyValue)
    End Sub
    Public Function GetRegValue(ByRef KeyValue As String, ByVal ValueName As RegKeyValues) As Boolean
        PrepareReg()
        Dim arr() As String = Registry.LocalMachine.OpenSubKey("SOFTWARE\Mena Data Center", False).GetValueNames
        Dim ForInt As Integer = 0
        For ForInt = 0 To arr.Length - 1
            If arr(ForInt) = ValueName.ToString Then
                KeyValue = Registry.LocalMachine.OpenSubKey("SOFTWARE\Mena Data Center", False).GetValue(ValueName.ToString)
                Return True
            End If
        Next
        Return False
    End Function
End Module