Public Class FrmControlRoom
#Region "   '   Safe-Thread     '   "
    Delegate Sub SetTextCallback(ByVal Args As String)
    Private Sub SetValue(ByVal Args As String)
        'InvokeRequired required compares the thread ID of the
        'calling thread to the thread ID of the creating thread.
        'If these threads are different, it returns true.

        If Me.TxtOutput.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf SetValue)
            Me.TxtOutput.Invoke(d, New Object() {Args})
        Else
            Me.TxtOutput.AppendText(vbNewLine & Args)
        End If
    End Sub
#End Region
    Private myProcess As New Process
    Private Structure AccInfoSTR
        Dim ID As String
        Dim Password As String
    End Structure
    Private AccInfo() As AccInfoSTR
    Private ImageLoaded As Boolean
    Private Sub StartClientless()
        myProcess.StartInfo.FileName = Application.StartupPath & "\cplvl.exe"
        myProcess.StartInfo.UseShellExecute = False : myProcess.StartInfo.RedirectStandardOutput = True
        myProcess.StartInfo.RedirectStandardInput = True : myProcess.StartInfo.CreateNoWindow = True
        myProcess.Start()
        myProcess.WaitForExit(1500) : Application.DoEvents()
        'myProcess.StandardInput.WriteLine("action=clear") : myProcess.StandardInput.WriteLine(ChrW(Keys.Enter))
        'myProcess.WaitForExit(1000)
        If IO.File.Exists(Application.StartupPath & "\imagecode.bmp") Then
            IO.File.Delete(Application.StartupPath & "\imagecode.bmp")
        End If
        Dim ThrD As New System.Threading.Thread(AddressOf StartLoging)
        ThrD.Start()
    End Sub

    Private Sub StartLoging()
        myProcess.StandardInput.WriteLine("1" & ChrW(Keys.Enter))
        Dim OutPutLine As String = ""
        Try
            Do : OutPutLine = myProcess.StandardOutput.ReadLine.ToString
                SetValue(OutPutLine) : Loop
        Catch : End Try
    End Sub
    Private Sub LoadImagecode()
        Do Until ImageLoaded = True
            If IO.File.Exists(Application.StartupPath & "\imagecode.bmp") Then
                PicBox.Image = Image.FromFile(Application.StartupPath & "\imagecode.bmp")
                PnlImageCode.Enabled = True
                ImageLoaded = True
            End If
        Loop
    End Sub
    Private Sub FrmControlRoom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        StartClientless()
        ReDim AccInfo(0)
        AccInfo(0).ID = "falseb"
        AccInfo(0).Password = "hmd3aa"
        CBServers.Items.Add("redsea")
        For i = 0 To AccInfo.Length - 1
            CBAccounts.Items.Add(AccInfo(i).ID)
        Next
    End Sub
    Private Sub BtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click
        If CBAccounts.SelectedIndex <> -1 And CBServers.SelectedIndex <> -1 Then

            myProcess.StandardInput.WriteLine("name=" & AccInfo(CBAccounts.SelectedIndex).ID.Trim) : myProcess.StandardInput.WriteLine(ChrW(Keys.Enter))
            myProcess.WaitForExit(1000) : Application.DoEvents()

            myProcess.StandardInput.WriteLine("pass=" & AccInfo(CBAccounts.SelectedIndex).Password.Trim) : myProcess.StandardInput.WriteLine(ChrW(Keys.Enter))
            myProcess.WaitForExit(1000) : Application.DoEvents()

            myProcess.StandardInput.WriteLine("server=" & CBServers.SelectedItem.ToString.Trim) : myProcess.StandardInput.WriteLine(ChrW(Keys.Enter))
            myProcess.WaitForExit(1000)

            myProcess.StandardInput.WriteLine("action=login") : myProcess.StandardInput.WriteLine(ChrW(Keys.Enter))
            myProcess.WaitForExit(1000)
            Console.WriteLine("action=login")

            Dim ThrdImg As New System.Threading.Thread(AddressOf LoadImagecode)
            ThrdImg.Start()
            BtnCLose.Enabled = True
            BtnLogin.Enabled = False
        End If
    End Sub

    Private Sub BtnCLose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCLose.Click
        Try : myProcess.Kill() : Catch : End Try
        BtnLogin.Enabled = True
        BtnCLose.Enabled = False
        PicBox.Image = Nothing
        PnlImageCode.Enabled = False
    End Sub

    Private Sub BtnSendImageCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSendImageCode.Click
        myProcess.StandardInput.WriteLine("code=" & TxtImageCode.Text.Trim) : myProcess.StandardInput.WriteLine(ChrW(Keys.Enter))
        myProcess.WaitForExit(1000)
        myProcess.StandardInput.WriteLine("action=imagecode") : myProcess.StandardInput.WriteLine(ChrW(Keys.Enter))
    End Sub
End Class
