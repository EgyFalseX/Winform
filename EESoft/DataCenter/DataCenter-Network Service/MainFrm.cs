using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System;
using System.Net;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace DataCenterNetworkService
{
	public partial class MainFrm
	{
		public MainFrm()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
		#region Default Instance
		
		private static MainFrm defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static MainFrm Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new MainFrm();
                    defaultInstance.FormClosed += defaultInstance_FormClosed;
				}
				
				return defaultInstance;
			}
		}
		
		static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
		{
			defaultInstance = null;
		}
		
		#endregion
        //private struct Alsockets
        //{
        //    private Socket MySocket;
        //    private MModule.Commands Cmd;
        //    private string RelatedFile;
        //}
		//private Alsockets[] SokNfo;
		public Socket LSok;
		public IPEndPoint IPEndP;
		public Thread ThD;
        public void BtnStart_Click(Object sender, EventArgs e)
        {
            IPEndP = new IPEndPoint(IPAddress.Any, MModule.GeneralPort);
            BtnStart.Enabled = false;
            BtnStop.Enabled = true;
            AcceptButton = BtnStop;
            BtnStop.Focus();
            ThD = new Thread(OnStart);
            ThD.Start();
        }
		private void OnStart()
		{
			try
			{
				Socket handlerSocket;
				Thread thdRecHandler;
				//tcpListener.Start()
				//MsgBox("MSG 1" & vbNewLine & "server is waiting the incoming Req")
				LSok = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				LSok.Bind(IPEndP);
				LSok.Listen(-1);
				do
				{
					handlerSocket = LSok.Accept();
					if (handlerSocket.Connected)
					{
						//SyncLock (Me) 'Redim SokNfo and start new thread
						thdRecHandler = new Thread(SystemAnalyser);
						thdRecHandler.Start(handlerSocket);
						//End SyncLock
					}
				} while (true);
			}
			catch (Exception ex)
			{
				if (ex.TargetSite.Name != "Accept")
					MessageBox.Show(ex.Message);
			}
		}
        private static void SystemAnalyser(object Ojct)
        {
            Socket Sok = (Socket)(Ojct);
            short Readed;
            byte[] Buffers = new byte[4097];
            FileStream FileSTM;
            MModule.Commands CMD = new MModule.Commands();
            try
            {
                Sok.Receive(Buffers, 1, SocketFlags.None);
                CMD = (DataCenterNetworkService.MModule.Commands)(Conversion.Val(Encoding.Default.GetString(Buffers, 0, 1)));
                switch (CMD)
                {
                    case MModule.Commands.Ping: // command 0
                        break;
                    case MModule.Commands.SendFile: //Command 1
                        Readed = (short)Sok.Receive(Buffers, 4096, SocketFlags.None);
                        string FileName_1 = Encoding.Default.GetString(Buffers, 0, Readed).Trim();
                        if (!File.Exists(FileName_1))
                        {
                            Sok.Close();
                            Sok = null;
                            return;
                        }
                        else
                        {
                            FileSTM = new FileStream(FileName_1, FileMode.Open, FileAccess.Read);
                            do
                            {
                                Readed = (short)(FileSTM.Read(Buffers, 0, 4096));
                                if (Readed > 0)
                                    Sok.Send(Buffers, Readed, SocketFlags.None);
                                else
                                    break;
                            } while (true);
                            FileSTM.Close();
                        }
                        break;
                    case MModule.Commands.ReciveFile: //command 2
                        Readed = (short)(Sok.Receive(Buffers, 4096, SocketFlags.None));
                        //0-ServerFilePath 1-DeletedFilesPath 2-FileSize
                        string[] FileNames_1 = Encoding.Default.GetString(Buffers, 0, Readed).Trim().Split("/".ToCharArray());
                        //MsgBox(FileNames(0) & vbNewLine & FileNames(1) & vbNewLine & FileNames(2))
                        string[] FileName_2 = FileNames_1[0].Split("\\".ToCharArray());
                        string TargetFile = (string)(FileNames_1[1] + FileName_2[FileName_2.Length - 1]);
                        if (Directory.Exists(FileNames_1[1]) == false)
                            Directory.CreateDirectory(FileNames_1[1]);
                        if (File.Exists(FileNames_1[0]) == false)
                            goto BeginCopy;
                        int @int_1;
                        string NewFileName_1;
                        for (@int_1 = 0; @int_1 <= 10000; @int_1++)
                        {
                            NewFileName_1 = String.Format("{0}_{1}", TargetFile, @int_1);
                            if (File.Exists(NewFileName_1) == false)
                            {
                                File.Move(FileNames_1[0], NewFileName_1);
                                goto BeginCopy;
                            }
                        }
                    BeginCopy:
                        int FileSize_1 = Convert.ToInt32(0);
                        FileSTM = new FileStream(FileNames_1[0], FileMode.Create, FileAccess.Write, FileShare.Write);
                        Buffers[0] = byte.Parse("1");
                        Sok.Send(Buffers, 1, SocketFlags.None);
                        do
                        {
                            Readed = (short)(Sok.Receive(Buffers, 4096, SocketFlags.None));
                            FileSTM.Write(Buffers, 0, Readed);
                            FileSize_1 += Readed;
                            if (FileSize_1 == int.Parse(FileNames_1[2]))
                                break;
                        } while (true);
                        FileSTM.Close();
                        break;
                    case MModule.Commands.CreateFile: //command 3
                        Readed = (short)(Sok.Receive(Buffers, 4096, SocketFlags.None));
                        //0-ServerPath 1-FileName 2-FileType 3-FileSize
                        string[] FileNames = Encoding.Default.GetString(Buffers, 0, Readed).Trim().Split("/".ToCharArray());
                        //MsgBox(FileNames(0) & vbNewLine & FileNames(1) & vbNewLine & FileNames(2))
                        string NewFileName;
                        int FileSize = Convert.ToInt32(0);
                        int @int;
                        for (@int = 0; @int <= 10000; @int++)
                        {
                            NewFileName = String.Format("{0}{1}_{2}.{3}", FileNames[0], FileNames[1], @int, FileNames[2]);
                            if (File.Exists(NewFileName) == false)
                            {
                                FileSTM = new FileStream(NewFileName, FileMode.Create, FileAccess.Write, FileShare.Write);
                                Buffers[0] = byte.Parse("1");
                                Sok.Send(Buffers, 1, SocketFlags.None);
                                do
                                {
                                    Readed = (short)(Sok.Receive(Buffers, 4096, SocketFlags.None));
                                    FileSTM.Write(Buffers, 0, Readed);
                                    FileSize += Readed;
                                    if (FileSize == int.Parse(FileNames[3]))
                                        break;
                                } while (true);
                                FileSTM.Close();
                                Buffers = Encoding.Default.GetBytes(NewFileName);
                                Sok.Send(Buffers, NewFileName.Length, SocketFlags.None);
                                break;
                            }
                        }
                        break;
                    case MModule.Commands.CreateFolder: //command 4
                        Readed = (short)(Sok.Receive(Buffers, 4096, SocketFlags.None));
                        string FolderPath_1 = Encoding.Default.GetString(Buffers, 0, Readed).Trim();
                        if (Directory.Exists(FolderPath_1) == true)
                            Buffers[0] = byte.Parse("0");
                        else
                        {
                            if (Directory.CreateDirectory(FolderPath_1).Exists == false)
                                Buffers[0] = byte.Parse("0");
                            else
                                Buffers[0] = byte.Parse("1");
                        }
                        Sok.Send(Buffers, 1, SocketFlags.None);
                        break;
                    case MModule.Commands.RemoveFolder: //Command 5
                        Readed = (short)(Sok.Receive(Buffers, 4096, SocketFlags.None));
                        string[] FolderPath_2 = Encoding.Default.GetString(Buffers, 0, Readed).Trim().Split("/".ToCharArray());
                        if (Directory.Exists(FolderPath_2[0]) == true)
                        {
                            if (Directory.Exists(FolderPath_2[1]) == false)
                                Directory.CreateDirectory(FolderPath_2[1]);
                            int i1;
                            string[] FileName = FolderPath_2[0].Split("\\".ToCharArray());
                            for (i1 = 0; i1 <= int.MaxValue - 1; i1++)
                            {
                                if (Directory.Exists(String.Format("{0}{1}_{2}", FolderPath_2[1], FileName[FileName.Length - 1], i1)) == false)
                                {
                                    Directory.Move(FolderPath_2[0], String.Format("{0}{1}_{2}", FolderPath_2[1], FileName[FileName.Length - 1], i1));
                                    Buffers[0] = byte.Parse("1");
                                    break;
                                }
                            }
                        }
                        else
                        {
                            Buffers[0] = byte.Parse("0");
                        }
                        Sok.Send(Buffers, 1, SocketFlags.None);
                        break;
                    case MModule.Commands.RemoveFile: //Command 6
                        Readed = (short)(Sok.Receive(Buffers, 4096, SocketFlags.None));
                        string[] FilePath = Encoding.Default.GetString(Buffers, 0, Readed).Trim().Split("/".ToCharArray());
                        if (File.Exists(FilePath[0]) == true)
                        {
                            if (Directory.Exists(FilePath[1]) == false)
                                Directory.CreateDirectory(FilePath[1]);
                            int i1;
                            string[] FileName = FilePath[0].Split("\\".ToCharArray());
                            for (i1 = 0; i1 <= int.MaxValue - 1; i1++)
                            {
                                if (!File.Exists(String.Format("{0}{1}_{2}", FilePath[1], FileName[FileName.Length - 1], i1)))
                                {
                                    File.Move(FilePath[0], String.Format("{0}{1}_{2}", FilePath[1], FileName[FileName.Length - 1], i1));
                                    Buffers[0] = byte.Parse("1");
                                    Sok.Send(Buffers, 1, SocketFlags.None);
                                    goto endOfSelect;
                                }
                            }
                            Buffers[0] = byte.Parse("0");
                        }
                        else
                        {
                            Buffers[0] = byte.Parse("0");
                        }
                        Sok.Send(Buffers, 1, SocketFlags.None);
                        break;
                    case MModule.Commands.MoveFolder: //Command 7
                        Readed = (short)(Sok.Receive(Buffers, 4096, SocketFlags.None));
                        string[] FolderPath = Encoding.Default.GetString(Buffers, 0, Readed).Trim().Split("/".ToCharArray());
                        //TFolder(0) , DFolder(1)
                        if (Directory.Exists(FolderPath[1]) == true)
                            Buffers[0] = byte.Parse("0");
                        else
                        {
                            try
                            {
                                Directory.Move(FolderPath[0], FolderPath[1]);
                                Buffers[0] = byte.Parse("1");
                            }
                            catch
                            {
                                Buffers[0] = byte.Parse("0");
                            }
                        }
                        Sok.Send(Buffers, 1, SocketFlags.None);
                        break;
                }
            endOfSelect:
                1.GetHashCode();//nop
            }
            catch
            {
                FileSTM = null;
                Sok.Close();
                Sok = null;
                return;
            }
            FileSTM = null;
            Sok.Close();
            Sok = null;
        }
        public void BtnStop_Click(Object sender, EventArgs e)
        {
            //tcpListener.Stop()
            if (LSok != null)
            {
                LSok.Close();
                LSok = null;
            }
            BtnStart.Enabled = true;
            BtnStop.Enabled = false;
            AcceptButton = BtnStart;
            BtnStart.Focus();
        }
        public void MainFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ServiceNotifyIcon.Visible = false;
            Process.GetCurrentProcess().Kill();
        }
        public void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
        public void MainFrm_Load(Object sender, EventArgs e)
        {
            ServiceNotifyIcon.Visible = true;
            TimerZ.Start();
            //Loading Options from registry
            if (MModule.GetRegValue(MModule.RegKeyValues.GeneralPort.ToString()) == string.Empty)
            {
                BtnStart.Visible = false;
                Interaction.MsgBox(String.Format("Can't start service{0} Options is missing", Constants.vbNewLine), MsgBoxStyle.Information, null);
                Process.GetCurrentProcess().Kill();
            }
            if (MModule.GetRegValue(MModule.RegKeyValues.DeletedFilesPath.ToString()) == string.Empty)
            {
                BtnStart.Visible = false;
                Interaction.MsgBox(String.Format("Can't start service{0} Options is missing", Constants.vbNewLine), MsgBoxStyle.Information, null);
                Process.GetCurrentProcess().Kill();
            }
            MModule.GeneralPort = Convert.ToInt16(MModule.GetRegValue(MModule.RegKeyValues.GeneralPort.ToString()));
            MModule.DeletedFilesPath = MModule.GetRegValue(MModule.RegKeyValues.DeletedFilesPath.ToString());
            BtnStart_Click(sender, e);
            MModule.EnableCommand = true;
        }
        public void BtnOptions_Click(Object sender, EventArgs e)
        {
            if (MModule.FrmOptions.Visible == false)
            {
                MModule.FrmOptions = new OptionsFrm();
                MModule.FrmOptions.ShowDialog();
            }
            else
            {
                MModule.FrmOptions.Focus();
            }
        }
        public void TimerZ_Tick(Object sender, EventArgs e)
        {
            Hide();
            TimerZ.Stop();
        }
		#region    '   Safe-Thread     '
		delegate void SetTextCallback(string Args);
		//Private Sub SetValue(ByVal Args As String)
		// InvokeRequired required compares the thread ID of the
		// calling thread to the thread ID of the creating thread.
		// If these threads are different, it returns true.
		//If Me.LB.InvokeRequired Then
		//    Dim d As New SetTextCallback(AddressOf SetValue)
		//    Me.Invoke(d, New Object() {Args})
		//Else
		//    Me.LB.Items.Add(Args)
		//End If
		//End Sub
		#endregion
		#region    '   Menus Commands     '
        public void NetS_CMS_Opening(Object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MModule.EnableCommand == false) //Cant start service stop all commands
            {
                StartToolStripMenuItem.Enabled = false;
                StopToolStripMenuItem.Enabled = false;
            }
            else
            {
                if (BtnStart.Enabled == true) //Service Stoped
                {
                    StopToolStripMenuItem.Enabled = false;
                    StartToolStripMenuItem.Enabled = true;
                }
                else //Service Start
                {
                    StopToolStripMenuItem.Enabled = true;
                    StartToolStripMenuItem.Enabled = false;
                }
            }
            if (Visible == true)
            {
                ShowMainWindowToolStripMenuItem.Enabled = false;
            }
            else
            {
                ShowMainWindowToolStripMenuItem.Enabled = true;
            }
        }
        public void ShowMainWindowToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            if (Visible == false)
            {
                Visible = true;
                WindowState = FormWindowState.Normal;
            }
            else
            {
                Visible = true;
            }
        }
        public void StartToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            BtnStart_Click(sender, e);
        }
        public void StopToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            BtnStop_Click(sender, e);
        }
        public void OptionsToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            if (MModule.FrmOptions.Visible == false)
            {
                MModule.FrmOptions = new OptionsFrm();
                MModule.FrmOptions.StartPosition = FormStartPosition.CenterScreen;
                MModule.FrmOptions.ShowDialog();
            }
            else
            {
                MModule.FrmOptions.Focus();
            }
        }
        public void ExitToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            ServiceNotifyIcon.Visible = false;
            Process.GetCurrentProcess().Kill();
        }
		#endregion
	}
}
