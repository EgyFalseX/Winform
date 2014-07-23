Imports System.Data.OleDb
Module MModule
    Public UserLoginInfo As New UserPriv
    'DB Vars
    'Public OLECon As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:Database Password=Mohamed Aly Omer;Data Source=""" & Application.StartupPath & "\" & "AccountingLiteDB.mdb""")
    Public OLECon As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:Database Password=Protected By Allah;Data Source=""" & Application.StartupPath & "\AccountingLiteDB.mdb""")
    Public OLECmd As New OleDbCommand("", OLECon)
    Public OLEDA As OleDbDataAdapter
    Public OLEDR As OleDbDataReader
    Public SqlTable As New DataTable
    'Forms Definations
    Public FrmSupplier As New SupplierFrm
    Public FrmMSG As MSGBOXFrm
    Public FrmTypesInsertion As New TypesInsertionFrm
    Public FrmIncomingInsertion As New IncomingInsertionFrm
    Public FrmBills As New BillsFrm
    Public FrmOptions As New OptionsFrm
    Public FrmEditor As New EditorFrm
    Public FrmQueries As New QueriesFrm
    Public FrmAdminDlg As New AdminDlgFrm
    Public FrmPrinting As New PrintingFrm
    Public FrmDialyPrinting As New DialyPrintingFrm
    Public Structure UserPriv
        Dim UserType As UserTypes
        Dim ID As String
        Dim Pass As String
    End Structure
    Public Enum UserTypes
        Viewer
        Entering
        Admin
        SA
    End Enum

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
    Public Function verifyLoginInfo(ByVal UserName As String, ByVal UserPass As String) As String
        Dim UID As String = Nothing
        Try
            OLECon.Open()
            OLECmd.CommandText = "SELECT UserTypeID FROM Users WHERE (UserName = '" & UserName & "') AND (UserPass = '" & UserPass & "')"
            UID = OLECmd.ExecuteScalar
            If UID = Nothing Then
                OLECmd.CommandText = "SELECT AdminName FROM SAdmin WHERE (AdminName = '" & UserName & "') AND (AdminPass = '" & UserPass & "')"
                UID = OLECmd.ExecuteScalar
                OLECon.Close()
                If UID = Nothing Then
                    Return Nothing
                Else
                    Return "SA"
                End If
            Else
                Return UID
            End If
        Catch ex As Exception
            OLECon.Close()
            MsgBox(ex.Message)
            Return ex.Message
        End Try
        OLECon.Close()
        Return Nothing
    End Function
    Public Function CreateOLETable(ByVal Cmdtxt As String) As DataTable
        SqlTable = New DataTable
        OLECmd.CommandText = Cmdtxt
        OLEDA = New OleDbDataAdapter(Cmdtxt, OLECon.ConnectionString)
        OLEDA.Fill(SqlTable)
        Return SqlTable
    End Function
    Public Function Insertion_Updateing_Deleting(ByVal CmdTxt As String) As String
        Try
            OLECmd.CommandText = CmdTxt
            OLECon.Open()
            OLECmd.ExecuteNonQuery()
        Catch ex As Exception
            OLECon.Close()
            MsgBox(ex.Message)
            Return ex.Message
        End Try
        OLECon.Close()
        Return Nothing
    End Function
    Public Function Insertion_Updateing_Deleting(ByVal CmdTxt As String, ByRef EffectedID As String) As String
        Try
            OLECmd.CommandText = CmdTxt
            OLECon.Open()
            OLECmd.ExecuteNonQuery()
            OLECmd.CommandText = "Select @@Identity"
            EffectedID = OLECmd.ExecuteScalar.ToString.Trim
        Catch ex As Exception
            OLECon.Close()
            MsgBox(ex.Message)
            Return ex.Message
        End Try
        OLECon.Close()
        Return Nothing
    End Function
    Public Function SelectTypeCount(ByVal TypeID As String, ByRef Count As String) As String
        Try
            OLECmd.CommandText = "SELECT SUM(InCount) - (Select Sum(ConCount) From ContainZ Where TypeID=" & TypeID & ") AS FalseX FROM Incoming Where  TypeID=" & TypeID
            OLECon.Open()
            Count = Val(OLECmd.ExecuteScalar.ToString.Trim)
        Catch ex As Exception
            OLECon.Close()
            Return ex.Message
        End Try
        OLECon.Close()
        Return Nothing
    End Function
    Public Sub CloseWindows()
        FrmTypesInsertion.Close()
        FrmIncomingInsertion.Close()
        FrmBills.Close()
        FrmOptions.Close()
        FrmEditor.Close()
        FrmQueries.Close()
        FrmAdminDlg.Close()
        FrmDialyPrinting.Close()
    End Sub
    Public Function ItemsCostInStorage(ByVal Cmd As String, ByRef Result As Int16) As String

        Try
            Result = 0
            OLECon.Open()
            OLECmd.CommandText = Cmd
            OLEDR = OLECmd.ExecuteReader
            Do While OLEDR.Read
                Result += Val(OLEDR.GetValue(0).ToString)
            Loop
        Catch ex As Exception
            OLECon.Close()
            'MsgBox(ex.Message)
            Return ex.Message
        End Try
        OLECon.Close()
        Return Nothing
    End Function
    Public Function Return1Value(ByVal cmd As String, ByRef Result As String) As String
        Try
            OLECon.Open()
            OLECmd.CommandText = cmd
            Result = OLECmd.ExecuteScalar()
        Catch ex As Exception
            OLECon.Close()
            Return ex.Message
        End Try
        OLECon.Close()
        Return Nothing
    End Function

#Region "       -=[ Static ]=-      "
    Public SecSTR As String = "00110111001111100011111101001010010011110100101001001111010011110011011000110110001101100011110100110110010011110100101000111000"
    '(01001010010011110100111001001010010011110100101001001111010011110011011000110110001101100011011000110110001111010100111101001100) شركة ميشيلكو Home
    '(00110111001111100011111101001010010011110100101001001111010011110011011000110110001101100011110100110110010011110100101000111000) شركة ميشيلكو Work

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
#Region "/  Form Printing Functions    /"
    ' create a printing component
    Public WithEvents pd As Printing.PrintDocument
    ' storage for form image
    Public formImage As Bitmap
    ' create API prototype
    Public Declare Function BitBlt Lib "gdi32.dll" Alias "BitBlt" (ByVal hdcDest As IntPtr, ByVal nXDest As Integer, ByVal nYDest As _
       Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal hdcSrc As IntPtr, ByVal nXSrc As Integer, ByVal nYSrc As Integer, _
       ByVal dwRop As System.Int32) As Long

    ' Callback from PrintDocument component to
    ' do the actual printing
    Public Sub pd_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles pd.PrintPage
        e.Graphics.DrawImage(formImage, 100, 100)
    End Sub
    Public Sub GetFormImage(ByVal MyForm As Form)
        Dim g As Graphics = MyForm.CreateGraphics()
        Dim s As Size = MyForm.Size
        formImage = New Bitmap(s.Width, s.Height, g)
        Dim mg As Graphics = Graphics.FromImage(formImage)
        Dim dc1 As IntPtr = g.GetHdc
        Dim dc2 As IntPtr = mg.GetHdc
        ' added code to compute and capture the form
        ' title bar and borders
        Dim widthDiff As Integer = (MyForm.Width - MyForm.ClientRectangle.Width)
        Dim heightDiff As Integer = (MyForm.Height - MyForm.ClientRectangle.Height)
        Dim borderSize As Integer = widthDiff \ 2
        Dim heightTitleBar As Integer = heightDiff - borderSize
        BitBlt(dc2, 0, 0, MyForm.ClientRectangle.Width + widthDiff, MyForm.ClientRectangle.Height + heightDiff, dc1, 0 - borderSize, 0 - heightTitleBar, 13369376)
        g.ReleaseHdc(dc1)
        mg.ReleaseHdc(dc2)
    End Sub
#End Region
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