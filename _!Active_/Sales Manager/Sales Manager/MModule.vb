Imports System.Data.OleDb
Module MModule
    'DB Vars
    'Public OLECon As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:Database Password=Mohamed Aly Omer;Data Source=""" & Application.StartupPath & "\" & "DataBase\WearHouseDB.mdb""")
    Public OLECon As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=""" & Application.StartupPath & "\" & "DataBase\Sales Manager.mdb""")
    Public OLETrans As OleDb.OleDbTransaction
    Public OLECmd As New OleDbCommand("", OLECon, OLETrans)
    Public OLEDr As OleDbDataReader
    Public OLEDA As OleDbDataAdapter
    Public SqlTable As New DataTable
    'Forms Definations
    Public FrmMSG As MSGBOXFrm
    Public FrmAddsContains As New AddsContainsFrm
    Public FrmBills As New BillsFrm
    Public FrmEditor As New EditorFrm
    Public FrmEmployeeInsertion As New EmployeeInsertionFrm
    Public FrmItemsInsertion As New ItemsInsertionFrm
    Public FrmMain As New MainFrm
    Public FrmMaintenanceIncome As New MaintenanceIncomeFrm
    Public FrmOptions As New OptionsFrm
    Public FrmReturned As New ReturnedFrm
    Public FrmSupplyerInsertion As New SupplyerInsertionFrm
    Public FrmSpending As New SpendingFrm
    'Funtions
    Public Sub MsgBox_(ByVal MSG As String, ByVal Complate As Boolean, ByVal SenderForm As Form)
        If Complate = True Then
            'SenderForm.Opacity = 0.3
            FrmMSG = New MSGBOXFrm(MSG)
            'FrmMSG.LBLMSG.Location = New Point(x, y)
            FrmMSG.BtnOk.BackColor = Color.GreenYellow
            FrmMSG.BigPnl.BackColor = Color.Green
            FrmMSG.ShowDialog(SenderForm)
            'SenderForm.Opacity = 1
        Else
            'SenderForm.Opacity = 0.3
            FrmMSG = New MSGBOXFrm(MSG)
            'FrmMSG.LBLMSG.Location = New Point(y, y)
            FrmMSG.BtnOk.BackColor = Color.Red
            FrmMSG.BigPnl.BackColor = Color.Red
            FrmMSG.ShowDialog(SenderForm)
            'SenderForm.Opacity = 1
        End If
    End Sub
    Public Function CreateOLETable(ByVal Cmdtxt As String) As DataTable
        SqlTable = New DataTable
        OLECmd.CommandText = Cmdtxt
        OLEDA = New OleDbDataAdapter(Cmdtxt, OLECon.ConnectionString)
        OLEDA.Fill(SqlTable)
        Return SqlTable
    End Function
    Public Function Insertion_Updateing_Deleting(ByVal CmdTxt As String) As String
        Try
            OLECon.Open()
            OLECmd.CommandText = CmdTxt
            OLECmd.ExecuteNonQuery()
        Catch ex As Exception
            OLECon.Close()
            MsgBox(ex.Message)
            Return ex.Message
        End Try
        OLECon.Close()
        Return Nothing
    End Function
    Public Function Insertion_Updateing_Deleting(ByVal CmdTxt As String, ByRef ID As String) As String
        Try
            OLECon.Open()
            OLECmd.CommandText = CmdTxt
            OLECmd.ExecuteNonQuery()
            OLECmd.CommandText = "Select @@Identity"
            ID = OLECmd.ExecuteScalar
        Catch ex As Exception
            OLECon.Close()
            MsgBox(ex.Message)
            Return ex.Message
        End Try
        OLECon.Close()
        Return Nothing
    End Function
#Region "       -=[ Static ]=-      "
    'If SecSTR <> CharToBinary(GetProcessorId) Then
    '        MsgBox_("Unrecognized PC Config", False, Me)
    '        Process.GetCurrentProcess.Kill()
    'End If
    Public SecSTR As String = "00111001010011110100111001001010010011110100101001001111010011110011011000110110001101100011011000110110010011110011011100111001"
    'My PC  01001010010011110100111001001010010011110100101001001111010011110011011000110110001101100011011100110110001111010011111000111101
    Public Function GetProcessorId() As String
        Dim strProcessorId As String = String.Empty
        Dim query As New System.Management.SelectQuery("Win32_processor")
        Dim search As New System.Management.ManagementObjectSearcher(query)
        Dim info As System.Management.ManagementObject
        For Each info In search.Get()
            strProcessorId = info("processorId").ToString()
        Next
        Return strProcessorId
    End Function
#Region "/  Binary Function    /"
    Public Function CharToBinary(ByVal Strings As String) As String
        Dim int As Int16
        Dim FOut As String = ""
        Dim out As String = ""
        For int = 0 To Strings.Length - 1
            Dim CorruptedStr As Int64 = Asc(Strings.Chars(int))
            CorruptedStr = (CorruptedStr * 9) / 8
            Dim mydiv As Int64
            Do While CorruptedStr <> 0
                CorruptedStr = System.Math.DivRem(CorruptedStr, 2, mydiv)
                If mydiv > 0 Then
                    out = 1 & out
                Else
                    out = 0 & out
                End If
            Loop
            out = New String("0", 8 - out.Length) & out
            FOut &= out
            out = ""
        Next
        Return FOut
    End Function
    Public Function Binarytochar(ByVal Binarystring As String) As String
        Dim fout As String = ""
        Dim Back2Normal As Int64
        Dim arr((Binarystring.Length / 8) - 1) As String
        Dim i As Int16
        For i = 0 To (Binarystring.Length / 8) - 1
            arr(i) = Binarystring.Substring(i * 8, 8)
        Next i
        For i = 0 To arr.Length - 1
            Dim str1 As String = arr(i).Substring(0, 4)
            Dim str2 As String = arr(i).Substring(4)
            Dim int As New Int16
            Dim out1 As New Int16
            Dim out2 As New Int16
            If str1.Chars(0) = "1" Then
                out1 += 8
            End If
            If str1.Chars(1) = "1" Then
                out1 += 4
            End If
            If str1.Chars(2) = "1" Then
                out1 += 2
            End If
            If str1.Chars(3) = "1" Then
                out1 += 1
            End If
            If str2.Chars(0) = "1" Then
                out2 += 8
            End If
            If str2.Chars(1) = "1" Then
                out2 += 4
            End If
            If str2.Chars(2) = "1" Then
                out2 += 2
            End If
            If str2.Chars(3) = "1" Then
                out2 += 1
            End If
            out2 = out2 * 1
            out1 = out1 * 16
            Back2Normal = out1 + out2
            Back2Normal = (Back2Normal * 8) / 9
            fout &= Chr(Back2Normal)
        Next
        Return fout
    End Function

#End Region
#End Region
End Module