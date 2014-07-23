Imports System.Data.OleDb
Imports Microsoft.Office.Interop
Module MModule
    Public Function DeleteRow___________NotUsed______________(ByVal ID As String, ByVal TableName As String) As String
        Try
            OLECmd.CommandText = "Delete From [" & TableName & "] Where [ID]=" & ID
            OLECon.Open()
            OLECmd.ExecuteNonQuery()
        Catch ex As Exception
            OLECon.Close()
            Return ex.Message
        End Try
        OLECon.Close()
        Return Nothing
    End Function
    'DB Vars
    Public OLECon As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:Database Password=Mohamed Aly Omer;Data Source=""" & Application.StartupPath & "\" & "DataBase\WearHouseDB.mdb""")
    Public OLETrans As OleDb.OleDbTransaction
    Public OLECmd As New OleDbCommand("", OLECon, OLETrans)
    Public OLEDr As OleDbDataReader
    Public OLEDA As OleDbDataAdapter
    Public SqlDS As New DataSet
    'Forms Definations
    Public FrmMSG As MSGBOXFrm
    Public FrmBills As New BillsFrm
    Public FrmCustomerInsertion As New CustomerInsertionFrm
    Public FrmCustomerPayment As New CustomerPaymentFrm
    Public FrmStorage As New StorageFrm
    Public FrmTypesInsertion As New TypesInsertionFrm
    Public FrmEditor As New EditorFrm
    Public FrmOptions As New OptionsFrm
    Public FrmSupplier As New SupplierFrm
    Public FrmQueries As New QueriesFrm
    Public FrmSpendType As New SpendTypeFrm
    Public FrmSpending As New SpendingFrm
    Public FrmReturners As New ReturnersFrm
    Public FrmDiscounts As New DiscountsFrm
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
    Public Function CreateOLEDS(ByVal Cmdtxt As String) As DataSet
        SqlDS = New DataSet
        OLECmd.CommandText = Cmdtxt
        OLEDA = New OleDbDataAdapter(Cmdtxt, OLECon.ConnectionString)
        OLEDA.Fill(SqlDS)
        Return SqlDS
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
    Public Function SelectTypeCount(ByVal TypeID As String, ByRef Count As String) As String
        Try
            OLECmd.CommandText = "SELECT SUM(AddingCount) AS ExCount FROM Adding Where TypeID=" & TypeID
            OLECon.Open()
            Count = Val(OLECmd.ExecuteScalar.ToString.Trim)
            OLECmd.CommandText = "SELECT SUM([Count]) AS FalseX FROM BillTypes WHERE (TypeID = " & TypeID & ")"
            Count -= Val(OLECmd.ExecuteScalar.ToString.Trim)
        Catch ex As Exception
            OLECon.Close()
            Return ex.Message
        End Try
        OLECon.Close()
        Return Nothing
    End Function
    Public Function InsertBill(ByVal CmdTxt As String) As String
        Try
            OLECmd.CommandText = CmdTxt
            OLECon.Open()
            OLECmd.ExecuteNonQuery()
        Catch ex As Exception
            OLECon.Close()
            Return ex.Message
        End Try
        OLECon.Close()
        Return Nothing
    End Function
    Public Sub CloseWindows()
        FrmBills.Close()
        FrmCustomerInsertion.Close()
        FrmCustomerPayment.Close()
        FrmStorage.Close()
        FrmTypesInsertion.Close()
        FrmSpendType.Close()
        FrmSpending.Close()
        FrmEditor.Close()
        FrmOptions.Close()
        FrmQueries.Close()
        FrmReturners.Close()
        FrmDiscounts.Close()
    End Sub
    Public Sub ExportToExcel(ByVal dt As DataTable, ByVal Result As String, ByVal SheetName As String)
        Dim ThisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
        Dim originalCulture As System.Globalization.CultureInfo = ThisThread.CurrentCulture
        Try
            ThisThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
            Dim oApp As New Excel.Application
            Dim oBook As Excel.Workbook = oApp.Workbooks.Add
            Dim oSheet As Excel.Worksheet = CType(oBook.Worksheets(1), Excel.Worksheet)
            oSheet.Name = SheetName
            oApp.Visible = False
            Dim c As Long = Asc("A")
            For Each dc As DataColumn In dt.Columns
                oSheet.Range(Chr(c) & "1").Value = dc.ColumnName.ToString
                oSheet.Range(Chr(c) & "1").Font.Bold = True
                c += 1
            Next
            Dim i As Long = 2
            For Each dr As DataRow In dt.Rows
                c = Asc("A")
                For Each dc As DataColumn In dt.Columns
                    oSheet.Range(Chr(c) & i.ToString).Value = dr.Item(dc.ColumnName)
                    c += 1
                Next
                i += 1
            Next
            c -= 1
            oSheet.Range(Chr(c) & i.ToString).Value = Result
            oApp.Visible = True
            oSheet.Range("A1", "Z1").EntireColumn.AutoFit()
        Catch ex As Exception
            MessageBox.Show("Source [" & ex.Source & "] Description [" & ex.Message & "]")
        Finally
            ThisThread.CurrentCulture = originalCulture
        End Try
    End Sub
#Region "       -=[ Static ]=-      "
    'If SecSTR <> CharToBinary(GetProcessorId) Then
    '        MsgBox_("Unrecognized PC Config", False, Me)
    '        Process.GetCurrentProcess.Kill()
    'End If
    Public SecSTR As String = "00111001010011110100111001001010010011110100101001001111010011110011011000110110001101100011011000110110010011110011011100111001"
    'MY PC "00110110001111100011111101001010010011110100101001001111010011110011011000110110001101100011100000110110010011110100111100110110"
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