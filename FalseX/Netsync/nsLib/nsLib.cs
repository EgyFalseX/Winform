using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using nsLib.Opcode;
using System.Threading;

namespace nsLib
{
    public class nsLib
    {
        public nsLib(int port, string ipAddress)
        {
            config.PORT = port;
            config.IP = ipAddress;
        }
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
        public bool ConnectMe()
        {
            bool ReturnMe = false;
            byte[] Buffers = Utilities.Buffers.GetBuffer(1);
            Socket Sok = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Buffers[0] = (byte)OpCodeProcess.C_Registration;
            try
            {
                Sok.Connect(config.IP, config.PORT);
                if (Sok.Connected == true)
                {
                    Sok.Send(Buffers, Buffers.Length, SocketFlags.None);
                }
                Sok.Receive(Buffers, SocketFlags.None);
                ReturnMe = true;
            }
            catch (Exception ex)
            {
                Utilities.Uti.LogMessage(ex.Message);
            }

            return ReturnMe;
        }

        public void C_SendFile(string cfilePath, string sfilePath, ref Utilities.UpdateInfo notify)
        {
            /*UpdateInfo[0] = Complate - bool
             * UpdateInfo[1] = Cancel - bool
            * UpdateInfo[2] = ProgreeBarFile Max Value - int
            * UpdateInfo[3] = ProgreeBarFile Value - int
            */
            ThreadPool.QueueUserWorkItem((o) => 
            {
                Utilities.UpdateInfo uInfo = (Utilities.UpdateInfo)o;

                FileStream fs = File.OpenRead(cfilePath);
                byte[] Buffers;
                Socket Sok = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                Buffers = GetCmd(OpCodeProcess.C_SendFile, string.Format("{0};{1}", fs.Length, sfilePath));

                Sok.Connect(config.IP, config.PORT);
                if (Sok.Connected == true)
                {
                    Sok.Send(Buffers, Buffers.Length, SocketFlags.None);
                }

                Sok.Receive(Buffers, SocketFlags.None);
                if (Buffers[0] != (byte)OpCodeProcess.S_OK)
                    throw new Exception("Server Refuse");

                int readed = 0;
                Buffers = Utilities.Buffers.GetBuffer();

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
                    readed = fs.Read(Buffers, 0, Buffers.Length - 1);
                    Sok.Send(Buffers, readed, SocketFlags.None);
                    i += readed;
                    uInfo.SetValue(3, i);// File progress value
                }
                fs.Flush(); fs.Close(); fs.Dispose();
                uInfo.SetValue(3, 0);// File progress value
                uInfo.SetValue(0, true);//Op Complated
            }, notify);
        }

        public bool C_SendFiles(List<string[]> filePaths,ref Utilities.UpdateInfo notify)
        {
            /* UpdateInfo[0] = Cancel/Complate - bool
             * UpdateInfo[1] = ProgreeBarFiles Max Value - int
             * UpdateInfo[2] = ProgreeBarFiles Value - int
             * UpdateInfo[3] = ProgreeBarFile Max Value - int
             * UpdateInfo[4] = ProgreeBarFile Value - int
             */

            notify.SetValue(1, filePaths.Count);

            byte[] Buffers;
            Socket Sok = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            string contains = string.Empty;
            foreach (string[] item in filePaths)
            {
                //item[0] = client filename ; item[1] = server filename
                contains += new FileInfo(item[0]).Length + ";" + item[1] + ";";
            }
            contains = contains.Substring(0, contains.Length - 1);
            Buffers = GetCmd(OpCodeProcess.C_SendFiles, contains);

            Sok.Connect(config.IP, config.PORT);
            if (Sok.Connected == true)
            {
                Sok.Send(Buffers, Buffers.Length, SocketFlags.None);
            }

            Sok.Receive(Buffers, SocketFlags.None);
            if (Buffers[0] != (byte)OpCodeProcess.S_OK)
                throw new Exception("Server Refuse");

            int readed = 0;
            Buffers = new byte[4097];
            foreach (string[] item in filePaths)
            {
                FileStream fs = File.OpenRead(item[0]);
                
                notify.SetValue(3, fs.Length);
                notify.SetValue(4, 0);
                
                for (int i = 0; i < fs.Length; )
                {
                    readed = fs.Read(Buffers, 0, Buffers.Length - 1);
                    Sok.Send(Buffers, readed, SocketFlags.None);
                    i += readed;
                    notify.SetValue(4, Convert.ToInt32(notify.GetValue(4)) + readed);// File progress value
                }
                fs.Flush(); fs.Close(); fs.Dispose();
                notify.SetValue(2, Convert.ToInt32(notify.GetValue(2)) + 1);// Files progress value
            }
            return true;
        }

        public void C_ReciveFile(string cfilePath, string sfilePath, ref Utilities.UpdateInfo notify)
        {
          /*UpdateInfo[0] = Complate - bool
          * UpdateInfo[1] = Cancel - bool
          * UpdateInfo[2] = ProgreeBarFile Max Value - int
          * UpdateInfo[3] = ProgreeBarFile Value - int
          */
            ThreadPool.QueueUserWorkItem((o) =>
            {
                Utilities.UpdateInfo uInfo = (Utilities.UpdateInfo)o;
                FileStream fs = File.OpenWrite(cfilePath);
                byte[] Buffers;
                Socket Sok = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                Buffers = GetCmd(OpCodeProcess.C_ReciveFile, string.Format("{0}", sfilePath));

                Sok.Connect(config.IP, config.PORT);
                if (Sok.Connected == true)
                {
                    Sok.Send(Buffers, Buffers.Length, SocketFlags.None);
                }
                Buffers = Utilities.Buffers.GetBuffer();
                Sok.Receive(Buffers, SocketFlags.None);
                if (Buffers[0] != (byte)OpCodeProcess.S_OK)
                    throw new Exception("Server Refuse");

                long FileLength = BitConverter.ToInt64(Buffers, 1);

                int readed = 0;
                Buffers = Utilities.Buffers.GetBuffer();
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
                    readed = Sok.Receive(Buffers, SocketFlags.None);
                    fs.Write(Buffers, 0, readed);
                    i += readed;
                    uInfo.SetValue(3, i);
                }
                fs.Flush(); fs.Close(); fs.Dispose();
                uInfo.SetValue(3, 0);// File progress value
                uInfo.SetValue(0, true);//Op Complated
            }, notify);
        }

        public void C_ReciveFile(MemoryStream cStream, string sfilePath, ref Utilities.UpdateInfo notify)
        {
            /*UpdateInfo[0] = Complate - bool
            * UpdateInfo[1] = Cancel - bool
            * UpdateInfo[2] = ProgreeBarFile Max Value - int
            * UpdateInfo[3] = ProgreeBarFile Value - int
            */
            ThreadPool.QueueUserWorkItem((o) =>
            {
                Utilities.UpdateInfo uInfo = (Utilities.UpdateInfo)o;
                byte[] Buffers;
                Socket Sok = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                Buffers = GetCmd(OpCodeProcess.C_ReciveFile, string.Format("{0}", sfilePath));

                Sok.Connect(config.IP, config.PORT);
                if (Sok.Connected == true)
                {
                    Sok.Send(Buffers, Buffers.Length, SocketFlags.None);
                }
                Buffers = Utilities.Buffers.GetBuffer();
                Sok.Receive(Buffers, SocketFlags.None);
                if (Buffers[0] != (byte)OpCodeProcess.S_OK)
                {
                    uInfo.SetValue(0, true);//Op Not Complated
                    return;
                }

                long FileLength = BitConverter.ToInt64(Buffers, 1);

                int readed = 0;
                Buffers = Utilities.Buffers.GetBuffer();
                uInfo.SetValue(2, FileLength); uInfo.SetValue(3, 0);
                for (int i = 0; i < FileLength; )
                {
                    if ((bool)uInfo.GetValue(0) == true)
                    {
                        //cStream.Flush(); cStream.Close(); cStream.Dispose();
                        //File.Delete(cfilePath);
                        uInfo.SetValue(1, true);//Op Canceled
                        Sok.Close();
                        return;
                    }
                    readed = Sok.Receive(Buffers, SocketFlags.None);
                    cStream.Write(Buffers, 0, readed);
                    i += readed;
                    uInfo.SetValue(3, i);
                }
                //cStream.Flush(); cStream.Close(); cStream.Dispose();
                uInfo.SetValue(3, 0);// File progress value
                uInfo.SetValue(0, true);//Op Complated
            }, notify);
        }

        public bool C_ReciveFiles(List<string> cfilePaths, List<string> sfilePaths, ref Utilities.UpdateInfo notify)
        {
            // UpdateInfo[0] = Cancel/Complate - bool 
            // UpdateInfo[1] = ProgreeBarFiles Max Value - int 
            // UpdateInfo[2] = ProgreeBarFiles Value - int
            // UpdateInfo[3] = ProgreeBarFile Max Value - int
            // UpdateInfo[4] = ProgreeBarFile Value - int

            notify.SetValue(1, sfilePaths.Count);

            byte[] Buffers;
            Socket Sok = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            string contains = string.Empty;
            foreach (string item in sfilePaths)
            {
                contains += item + ";";
            }
            contains = contains.Substring(0, contains.Length - 1);
            Buffers = GetCmd(OpCodeProcess.C_ReciveFiles, contains);

            Sok.Connect(config.IP, config.PORT);
            if (Sok.Connected == true)
            {
                Sok.Send(Buffers, Buffers.Length, SocketFlags.None);
            }
            Buffers = Utilities.Buffers.GetBuffer();
            Sok.Receive(Buffers, SocketFlags.None);
            if (Buffers[0] != (byte)OpCodeProcess.S_OK)
                throw new Exception("Server Refuse");
            List<long> FileLen = new List<long>();
            for (int i = 0; i < sfilePaths.Count; i++)
            {
                FileLen.Add(BitConverter.ToInt64(Buffers, 1 + (i * 8)));
            }

            int readSize = 0;
            Buffers = Utilities.Buffers.GetBuffer();
            for (int fileIndex = 0; fileIndex < cfilePaths.Count; fileIndex++)
            {
                notify.SetValue(3, FileLen[fileIndex]);//Set File progress Max value
                notify.SetValue(4, 0);//Set File progress value = 0

                FileStream fs = File.OpenWrite(cfilePaths[fileIndex]);
                for (int offset = 0; offset < FileLen[fileIndex]; )
                {
                    if (offset + Buffers.Length > FileLen[fileIndex])
                        readSize = Sok.Receive(Buffers, (int)(FileLen[fileIndex] - offset), SocketFlags.None);
                    else
                        readSize = Sok.Receive(Buffers, Buffers.Length, SocketFlags.None);

                    fs.Write(Buffers, 0, readSize);
                    offset += readSize;
                    notify.SetValue(4, Convert.ToInt32(notify.GetValue(4)) + readSize);//File progress value

                    if ((bool)notify.GetValue(0))
                        return false;

                }
                fs.Flush(); fs.Close(); fs.Dispose();
                notify.SetValue(2, Convert.ToInt32(notify.GetValue(2)) + 1);//Files progress value


            }
            return true;
        }

        public void C_DeleteFile(string sfilePath, ref Utilities.UpdateInfo notify)
        {
            /*UpdateInfo[0] = Complate - bool
            * UpdateInfo[1] = Cancel - bool
            */
            ThreadPool.QueueUserWorkItem((o) =>
            {
                Utilities.UpdateInfo uInfo = (Utilities.UpdateInfo)o;
                byte[] Buffers;
                Socket Sok = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                Buffers = GetCmd(OpCodeProcess.C_DeleteFile, sfilePath);

                Sok.Connect(config.IP, config.PORT);
                if (Sok.Connected == true)
                {
                    Sok.Send(Buffers, Buffers.Length, SocketFlags.None);
                }
                Buffers = Utilities.Buffers.GetBuffer();
                Sok.Receive(Buffers, SocketFlags.None);
                if (Buffers[0] != (byte)OpCodeProcess.S_OK)
                    throw new Exception("Server Refuse");
                uInfo.SetValue(0, true);//Op Complated
               
            }, notify);
        }

    }
}

