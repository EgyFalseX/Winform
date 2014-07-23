Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Public Class TransferFrm
    Private Int1 As Integer
    Private Sub BtnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBrowse.Click
        Dim OFD As New OpenFileDialog

        Dim FileInf As System.IO.FileInfo
        OFD.Filter = "All Files (*.*)|*.*"
        OFD.CheckFileExists = True
        OFD.CheckPathExists = True
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            FileInf = New System.IO.FileInfo(OFD.FileName)
            If CInt(FileInf.Length / 1048576) > 50 Then
                MsgBox_("File must be less than 50M", 94, 23, False, Me)
            Else
                LblPath.Text = OFD.FileName
                BtnUpload.Enabled = True
            End If
        Else
            LblPath.Text = "Please select the file path to upload it"
            BtnUpload.Enabled = False
        End If
    End Sub
    Private Sub BtnDownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDownload.Click
        Dim OFD As New OpenFileDialog
        OFD.Filter = "All Files (*.*)|*.*"
        OFD.CheckFileExists = False
        OFD.CheckPathExists = True
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            ReciveFile(ServerIP, REQPort, AllFoldersWithPrv.FolderInfo(FrmMainWindow.TVFolders.SelectedNode.Tag).Files(FrmMainWindow.LVFiles.SelectedIndices(0)).FilePath, OFD.FileName)
        End If
    End Sub
    Public Sub ReciveFile(ByVal IP_Address As String, ByVal RPort As Int32, ByVal ServerFilePath As String, ByVal ClientFilePath As String)
        Me.Enabled = False
        Dim Sok As New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
        Dim Readed As Int16
        Dim FileSTM As FileStream
        Try
            Dim FullString As String = FunctionLib.NetworkFunction.Commands.ReciveFile & ServerFilePath
            Dim DataB(4096) As Byte
            DataB = Encoding.Default.GetBytes(FullString)
            Sok.Connect(IP_Address, RPort)
            If Sok.Connected = True Then
                Sok.Send(DataB, DataB.Length, SocketFlags.None) 'Sending Header
                ReDim DataB(4096)
                FileSTM = File.Create(ClientFilePath.Trim)
                Do
                    Readed = Sok.Receive(DataB, 0, 4096, SocketFlags.None)
                    If Readed > 0 Then
                        FileSTM.Write(DataB, 0, Readed)
                        LblBytes.Text = Val(LblBytes.Text.Trim) + Readed
                    Else
                        Exit Do
                    End If
                    Application.DoEvents()
                Loop
                FileSTM.Close()
                LblBytes.Text = "0"
                MsgBox_("Downloading complete", 109, 23, True, Me)
            Else
                MsgBox_("No Connection available", 105, 23, False, Me)
            End If
            Sok.Close()
            Sok = Nothing
        Catch ex As Exception
            Sok = Nothing
            MsgBox_(ex.Message, 0, 23, False, Me)
        End Try
        Me.Enabled = True
    End Sub
    Private Sub BtnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpload.Click
        If MsgBox("Are you sure?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If
        Me.Enabled = False
        PBUpload.Visible = True
        Dim FullString As String
        Dim Buffers(4096) As Byte
        Dim Sok As New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
        Dim Created As Integer
        Try
            Dim FileSRM As New FileStream(LblPath.Text, FileMode.Open, FileAccess.Read)
            If FileSRM.Length = 0 Then
                MsgBox_("The file is 0 byte", 127, 23, False, Me)
                Exit Sub
            End If
            FullString = FunctionLib.NetworkFunction.Commands.SendFile & AllFoldersWithPrv.FolderInfo(FrmMainWindow.TVFolders.SelectedNode.Tag).Files(FrmMainWindow.LVFiles.SelectedIndices(0)).FilePath & "/" & DeletedFilesPath & Now.Year & "-" & Now.Month & "-" & Now.Day & "\" & "/" & FileSRM.Length
            PBUpload.Maximum = FileLen(LblPath.Text)
            PBUpload.Value = 0
            Buffers = Encoding.Default.GetBytes(FullString)
            Sok.Connect(ServerIP, REQPort)
            If Sok.Connected = True Then
                Sok.Send(Buffers, FullString.Length, SocketFlags.None)
                Sok.Receive(Buffers, 1, SocketFlags.None)
                Created = Val(Buffers(0))
                If Created = 1 Then
                    ReDim Buffers(4096)
                    Do
                        Created = FileSRM.Read(Buffers, 0, 4096)
                        If Created > 0 Then
                            Sok.Send(Buffers, Created, SocketFlags.None)
                            FrmTransfer.PBUpload.Value += Created
                            FrmTransfer.Text = "   Transfer File  " & CInt((FrmTransfer.PBUpload.Value / FrmTransfer.PBUpload.Maximum) * 100) & " %"
                        Else
                            Exit Do
                        End If
                        Application.DoEvents()
                    Loop
                    FrmTransfer.Text = "New File Properties"
                    FrmTransfer.PBUpload.Value = 0
                    FrmTransfer.PBUpload.Maximum = 100
                    MsgBox_("Transfer complete", 121, 23, True, Me)
                Else : Sok.Close() : Sok = Nothing : MsgBox_("Can't create file or sever is out of space", 51, 23, False, Me)
                End If
            End If
        Catch ex As Exception
            MsgBox_(ex.Message, 0, 23, False, Me)
        End Try
        Me.Enabled = True
        PBUpload.Visible = False
    End Sub
End Class