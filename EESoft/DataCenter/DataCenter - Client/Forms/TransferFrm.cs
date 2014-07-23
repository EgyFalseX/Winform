using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;
using System.Net.Sockets;
using System.Text;
using FunctionLib;

namespace DataCenter_Client
{
	public partial class TransferFrm
	{
        public string FileID;
        public string FilePath;
		public TransferFrm()
		{
			InitializeComponent();
		}
        public void BtnBrowse_Click(Object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            FileInfo FileInf;
            OFD.Filter = "All Files (*.*)|*.*";
            OFD.CheckFileExists = true;
            OFD.CheckPathExists = true;
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                FileInf = new FileInfo(OFD.FileName);
                if ((int)(FileInf.Length / 1048576) > 50)
                    MCls.msg("الملف اكبر من 50 ميجا", true, "", this);
                else
                {
                    LblPath.Text = OFD.FileName;
                    BtnUpload.Enabled = true;
                }
            }
            else
            {
                LblPath.Text = "من فضلك اختار مسار الملف لارساله";
                BtnUpload.Enabled = false;
            }
        }
        public void BtnDownload_Click(Object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "All Files (*.*)|*.*";
            OFD.CheckFileExists = false;
            OFD.CheckPathExists = true;
            if (OFD.ShowDialog() == DialogResult.OK)
                ReciveFile(MainModule.ServerIP, int.Parse(MainModule.REQPort), MainModule.ProjectsPath + FilePath, OFD.FileName);
        }
        public void ReciveFile(string IP_Address, int RPort, string ServerFilePath, string ClientFilePath)
        {
            Enabled = false;
            Socket Sok = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            short Readed;
            FileStream FileSTM;
            try
            {
                string FullString = (int)NetworkFunction.Commands.ReciveFile + ServerFilePath;
                byte[] DataB = new byte[4097];
                DataB = Encoding.Default.GetBytes(FullString);
                Sok.Connect(IP_Address, RPort);
                if (Sok.Connected == true)
                {
                    Sok.Send(DataB, DataB.Length, SocketFlags.None); //Sending Header
                    DataB = new byte[4097];
                    FileSTM = File.Create(ClientFilePath.Trim());
                    do
                    {
                        Readed = (short)(Sok.Receive(DataB, 0, 4096, SocketFlags.None));
                        if (Readed > 0)
                        {
                            FileSTM.Write(DataB, 0, Readed);
                            LblBytes.Text = Convert.ToString((Conversion.Val(LblBytes.Text.Trim()) + Readed));
                        }
                        else
                            break;
                        Application.DoEvents();
                    } while (true);
                    FileSTM.Close();
                    LblBytes.Text = "0";
                    MCls.msg("تم التحميل", false, "", this);
                }
                else
                {
                    MCls.msg("لا يوجد اتصال", true, "", this);
                }
                Sok.Close();
            }
            catch (Exception ex)
            {
                MCls.msg(ex.Message, true, "", this);
            }
            Enabled = true;
            Sok.Dispose();
            Sok = null;
        }
        public void BtnUpload_Click(Object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            Enabled = false;
            PBUpload.Visible = true;
            string FullString;
            byte[] Buffers = new byte[4097];
            Socket Sok = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            int Created;
            try
            {
                FileStream FileSRM = new FileStream(LblPath.Text, FileMode.Open, FileAccess.Read);
                if (FileSRM.Length == 0)
                {
                    MCls.msg("حجم الملف 0", true, "", this);
                    return;
                }
                FullString = (int)NetworkFunction.Commands.SendFile + MainModule.ProjectsPath + FilePath + "/" + MainModule.DeletedFilesPath + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "\\" + "/" + FileSRM.Length;
                PBUpload.Maximum = (int)(FileSystem.FileLen(LblPath.Text));
                PBUpload.Value = 0;
                Buffers = Encoding.Default.GetBytes(FullString);
                Sok.Connect(MainModule.ServerIP, int.Parse(MainModule.REQPort));
                if (Sok.Connected == true)
                {
                    Sok.Send(Buffers, FullString.Length, SocketFlags.None);
                    Sok.Receive(Buffers, 1, SocketFlags.None);
                    Created = Convert.ToInt32(Conversion.Val(Buffers[0]));
                    if (Created == 1)
                    {
                        Buffers = new byte[4097];
                        do
                        {
                            Created = FileSRM.Read(Buffers, 0, 4096);
                            if (Created > 0)
                            {
                                Sok.Send(Buffers, Created, SocketFlags.None);
                                MainModule.FrmTransfer.PBUpload.Value += Created;
                                MainModule.FrmTransfer.Text = "   تحميل الملف  " + Convert.ToInt32((MainModule.FrmTransfer.PBUpload.Value / MainModule.FrmTransfer.PBUpload.Maximum) * 100) + " %";
                            }
                            else
                            {
                                break;
                            }
                            Application.DoEvents();
                        } while (true);
                        MainModule.FrmTransfer.Text = "خصائص الملف الجديد";
                        MainModule.FrmTransfer.PBUpload.Value = 0;
                        MainModule.FrmTransfer.PBUpload.Maximum = 100;
                        MCls.msg("تم التحميل", false, "", this);
                    }
                    else
                    {
                        Sok.Close();
                        Sok = null;
                        MCls.msg("لم يتم تحميل الملف", true, "", this);
                    }
                }
            }
            catch (Exception ex)
            {
                MCls.msg(ex.Message, true, "", this);
            }
            Enabled = true;
            PBUpload.Visible = false;
        }
	}
}
