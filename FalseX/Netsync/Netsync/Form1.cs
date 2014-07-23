using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using nsLib.Opcode;

namespace Netsync
{
    public partial class Form1 : Form
    {
        static int port = Properties.Settings.Default.Port;
        static string ipAddress = "127.0.0.1";
        nsLib.nsLib lib = new nsLib.nsLib(port, ipAddress);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            ConnectMe();
            btnConnect.Text = "conected ....";
            btnsendFile.Enabled = btnsendFiles.Enabled = btnRecive.Enabled = btnRecives.Enabled = true;
        }
        private void ConnectMe()
        {
            byte[] Buffers = new byte[1];
            Socket Sok = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            int Created = 0;
            Buffers[0] = (byte)OpCodeProcess.C_Registration;

            Sok.Connect(ipAddress, port);
            if (Sok.Connected == true)
            {
                Sok.Send(Buffers, Buffers.Length, SocketFlags.None);
            }
            Sok.Receive(Buffers, SocketFlags.None);
        }

        private void btnsendFile_Click(object sender, EventArgs e)
        {
            SendFile();
            MessageBox.Show("file send complated ..");
        }
        
        private void SendFile()
        {
            //lib.C_SendFile("e:\\test", "c:\\test");
            MessageBox.Show("file send complated ..");
        }

        private void btnsendFiles_Click(object sender, EventArgs e)
        {
            SendFiles();
            //MessageBox.Show("files send complated ..");
        }

        private void SendFiles()
        {
            List<string[]> list = new List<string[]>();
            list.Add(new string[] { "e:\\test1", "c:\\test1" });
            list.Add(new string[] { "e:\\test2", "c:\\test2" });
            list.Add(new string[] { "e:\\test3", "c:\\test3" });

            nsLib.Utilities.UpdateInfo notify = new nsLib.Utilities.UpdateInfo();
            notify.AddItem(false);
            notify.AddItem(pbMultiFileS.Maximum); notify.AddItem(pbMultiFileS.Value);
            notify.AddItem(pbMultiFileS.Maximum); notify.AddItem(pbMultiFileS.Value);
            notify.OnItemChanged += notifySendFiles_OnItemChanged;

            System.Threading.ThreadPool.QueueUserWorkItem((o) =>
            {
                //lib.C_SendFiles(list, notify);
            });
        }

        void notifySendFiles_OnItemChanged(int index, object value)
        {
            this.Invoke(new MethodInvoker(() => 
            {
                switch (index)
                {
                    case 0:
                        break;
                    case 1:
                        pbMultiFilesS.Maximum = Convert.ToInt32(value);
                        break;
                    case 2:
                        pbMultiFilesS.Value = Convert.ToInt32(value);
                        break;
                    case 3:
                        pbMultiFileS.Maximum = Convert.ToInt32(value);
                        break;
                    case 4:
                        pbMultiFileS.Value = Convert.ToInt32(value);
                        break;
                }
            }));
            
        }

        private void btnRecive_Click(object sender, EventArgs e)
        {
            ReciveFile();
        }

        private void btnRecives_Click(object sender, EventArgs e)
        {
            ReciveFiles();
        }

        private void ReciveFile()
        {
            //lib.C_ReciveFile("c:\\test1", "e:\\test1");
            MessageBox.Show("file send complated ..");
        }

        private void ReciveFiles()
        {
            List<string> slist = new List<string>();
            slist.Add("e:\\test1");
            slist.Add("e:\\test2");
            slist.Add("e:\\test3");

            List<string> clist = new List<string>();
            clist.Add("c:\\test1");
            clist.Add("c:\\test2");
            clist.Add("c:\\test3");

            nsLib.Utilities.UpdateInfo noty = new nsLib.Utilities.UpdateInfo();
            noty.AddItem(false);
            noty.AddItem(pbMultiFileR.Maximum); noty.AddItem(pbMultiFileR.Value);
            noty.AddItem(pbMultiFileR.Maximum); noty.AddItem(pbMultiFileR.Value);
            noty.OnItemChanged += notifySReciveFiles_OnItemChanged;


            lib.C_ReciveFiles(clist, slist, ref noty);
            MessageBox.Show("file recive complated ..");
        }

        void notifySReciveFiles_OnItemChanged(int index, object value)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                switch (index)
                {
                    case 0:
                        break;
                    case 1:
                        pbMultiFilesR.Maximum = Convert.ToInt32(value);
                        break;
                    case 2:
                        pbMultiFilesR.Value = Convert.ToInt32(value);
                        break;
                    case 3:
                        pbMultiFileR.Maximum = Convert.ToInt32(value);
                        break;
                    case 4:
                        pbMultiFileR.Value = Convert.ToInt32(value);
                        break;
                }
            }));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        

    }
}
