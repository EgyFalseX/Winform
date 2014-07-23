using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace DbSyc_Client
{
    public static class dataSyc
    {
        public static byte[] GetCmd(OpCodeProcess opcode, string contains)
        {
            byte[] code = new byte[] { (byte)opcode };
            byte[] data = Encoding.Unicode.GetBytes(contains);
            byte[] lenth = BitConverter.GetBytes(data.Length);

            byte[] command = new byte[code.Length + data.Length + lenth.Length];

            System.Buffer.BlockCopy(code, 0, command, 0, code.Length);
            System.Buffer.BlockCopy(lenth, 0, command, code.Length, lenth.Length);
            System.Buffer.BlockCopy(data, 0, command, code.Length + lenth.Length, data.Length);

            return command;
        }
      
        public static void C_SendFile(string cfilePath, string sfilePath, ref UpdateInfo notify)
        {
            /*UpdateInfo[0] = Complate - bool
             * UpdateInfo[1] = Cancel - bool
            * UpdateInfo[2] = ProgreeBarFile Max Value - int
            * UpdateInfo[3] = ProgreeBarFile Value - int
            */
            ThreadPool.QueueUserWorkItem((o) =>
            {
                UpdateInfo uInfo = (UpdateInfo)o;

                FileStream fs = File.OpenRead(cfilePath);
                byte[] Bufferz;
                Socket Sok = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                Bufferz = GetCmd(OpCodeProcess.C_SendFile, string.Format("{0};{1}", fs.Length, sfilePath));

                Sok.Connect(Properties.Settings.Default.IP, Properties.Settings.Default.Port);
                if (Sok.Connected == true)
                {
                    Sok.Send(Bufferz, Bufferz.Length, SocketFlags.None);
                }

                Sok.Receive(Bufferz, SocketFlags.None);
                if (Bufferz[0] != (byte)OpCodeProcess.S_OK)
                    throw new Exception("Server Refuse");

                int readed = 0;
                Bufferz = Buffers.GetBuffer();

                uInfo.SetValue(2, fs.Length); uInfo.SetValue(3, 0);

                for (int i = 0; i < fs.Length; )
                {
                    if ((bool)uInfo.GetValue(0) == true)
                    {
                        fs.Flush(); fs.Close(); fs.Dispose();
                        uInfo.SetValue(1, true);//Op Canceled
                        Sok.Close();
                        return;
                    }
                    readed = fs.Read(Bufferz, 0, Bufferz.Length - 1);
                    Sok.Send(Bufferz, readed, SocketFlags.None);
                    i += readed;
                    uInfo.SetValue(3, i);// File progress value
                }
                fs.Flush(); fs.Close(); fs.Dispose();
                uInfo.SetValue(3, 0);// File progress value
                uInfo.SetValue(0, true);//Op Complated
            }, notify);
        }
        public static void C_ReciveFile(string cfilePath, string sfilePath, ref UpdateInfo notify)
        {
            /*UpdateInfo[0] = Complate - bool
            * UpdateInfo[1] = Cancel - bool
            * UpdateInfo[2] = ProgreeBarFile Max Value - int
            * UpdateInfo[3] = ProgreeBarFile Value - int
            */
            ThreadPool.QueueUserWorkItem((o) =>
            {
                //try
                //{

                //}
                //catch (Exception ex)
                //{

                //    throw;
                //}
                UpdateInfo uInfo = (UpdateInfo)o;
                FileStream fs = File.OpenWrite(cfilePath);
                byte[] Bufferz;
                Socket Sok = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                Bufferz = GetCmd(OpCodeProcess.C_ReciveFile, string.Format("{0}", sfilePath));

                Sok.Connect(Properties.Settings.Default.IP, Properties.Settings.Default.Port);
                if (Sok.Connected == true)
                {
                    Sok.Send(Bufferz, Bufferz.Length, SocketFlags.None);
                }
                Bufferz = Buffers.GetBuffer();
                Sok.Receive(Bufferz, SocketFlags.None);
                if (Bufferz[0] != (byte)OpCodeProcess.S_OK)
                    throw new Exception("Server Refuse");

                long FileLength = BitConverter.ToInt64(Bufferz, 1);

                int readed = 0;
                Bufferz = Buffers.GetBuffer();
                uInfo.SetValue(2, FileLength); uInfo.SetValue(3, 0);
                for (int i = 0; i < FileLength; )
                {
                    if ((bool)uInfo.GetValue(0) == true)
                    {
                        fs.Flush(); fs.Close(); fs.Dispose();
                        File.Delete(cfilePath);
                        uInfo.SetValue(1, true);//Op Canceled
                        Sok.Close();
                        return;
                    }
                    readed = Sok.Receive(Bufferz, SocketFlags.None);
                    fs.Write(Bufferz, 0, readed);
                    i += readed;
                    uInfo.SetValue(3, i);
                }
                fs.Flush(); fs.Close(); fs.Dispose();
                uInfo.SetValue(3, 0);// File progress value
                uInfo.SetValue(0, true);//Op Complated
            }, notify);
        }

    }
}
