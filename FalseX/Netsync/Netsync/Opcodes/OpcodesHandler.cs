using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Reflection;
using Netsync.Data;
using Netsync.Managers;
using System.IO;
using nsLib.Opcode;
using nsLib.Utilities;
using System.Threading;

namespace Netsync.Opcode
{
    public class OpcodesHandler
    {
        #region -   Variables   -
        public static OpcodesHandler DefaultInstance = new OpcodesHandler();
        #endregion
        #region -   Functions   -
        public static void Inti()
        {
            DefaultInstance = new OpcodesHandler();
        }
        public void MainHandler(DataContext data, bool TimerOut)
        {
            MethodInfo method;
            if (!MethodManager.DefaultInstance.Methods.TryGetValue(data.OPCODE, out method))
                return;
            try
            {
                method.Invoke(OpcodesHandler.DefaultInstance, new object[] { data });
            }
            catch (Exception ex)
            {
                nsLib.Utilities.Uti.LogMessage(ex.Message);
                // log there if error occur
            }
        }
        [NetSyncAttribute(OpCodeProcess.C_Registration)]
        public void C_Registration(DataContext data)
        {
            /*info
             * Send OK/Error
             */
            if (true)
            {
                data.SOK.Send(new byte[] { (byte)OpCodeProcess.S_OK });
                data.Dispose();
            }
        }
        [NetSyncAttribute(OpCodeProcess.C_SendFile)]
        public void C_SendFile(DataContext data)
        {
            /*info
             * Receive Packet Length (4 bytes)
             * Receive 2 Options
             *      1- File Lenth
             *      2- File Name
             * Send OK/Error Confirmation
             * Receive File Contains
             * */
            byte[] buffers = new byte[5];
            int PacketSize = 0;
            int readSize = 0;
            data.SOK.Receive(buffers, 4, SocketFlags.None);
            PacketSize = BitConverter.ToInt32(buffers, 0);
            buffers = nsLib.Utilities.Buffers.GetBuffer(PacketSize);

            data.SOK.Receive(buffers, buffers.Length, SocketFlags.None);//Receive Options
            
            string[] info = Encoding.Unicode.GetString(buffers).Trim().Split(';');
            long FileLenth = Convert.ToInt64(info[0]);
            string FileName = info[1];
            
            data.SOK.Send(new byte[] { (byte)OpCodeProcess.S_OK });//Send OK

            FileStream fs = null;
            fs = File.OpenWrite(FileName);

            buffers = nsLib.Utilities.Buffers.GetBuffer();
            
            for (int i = 0; i < FileLenth;)//Receive File Contains
            {
                if (!data.SOK.Connected)
                {
                    fs.Flush(); fs.Close(); fs.Dispose();
                    data.Dispose();
                    File.Delete(FileName);
                    return;
                }
                readSize = data.SOK.Receive(buffers, buffers.Length, SocketFlags.None);
                fs.Write(buffers, 0, readSize);
                i += readSize;
            }
            fs.Flush(); fs.Close(); fs.Dispose();
            data.Dispose();
        }
        [NetSyncAttribute(OpCodeProcess.C_SendFiles)]
        public void C_SendFiles(DataContext data)
        {
            /*info
             * Receive Packet Length (4 bytes)
             * Receive Array Of Options [Lenth,FileName]
             *      1- File Lenth
             *      2- File Name
             * Send OK/Error Confirmation
             * Receive Files Contains
             * */
            byte[] buffers = Buffers.GetBuffer(5);
            int PacketSize = 0;
            int readSize = 0;
            data.SOK.Receive(buffers, 4, SocketFlags.None);
            PacketSize = BitConverter.ToInt32(buffers, 0);
            buffers = Buffers.GetBuffer(PacketSize);

            data.SOK.Receive(buffers, buffers.Length, SocketFlags.None);//Receive Options

            string[] info = Encoding.Unicode.GetString(buffers).Trim().Split(';');
            
            List<string[]> FilesInfo = new List<string[]>();
            for (int i = 0; i < info.Length; i+=2)
                FilesInfo.Add(new string[] { info[i], info[i + 1] });

            data.SOK.Send(new byte[] { (byte)OpCodeProcess.S_OK });//Send OK

            buffers = Buffers.GetBuffer();
            foreach (string[] item in FilesInfo)
            {
                FileStream fs = null;
                fs = File.OpenWrite(item[1]);
                long fileSize = Convert.ToInt64(item[0]);
                for (int i = 0; i < fileSize;)//Receive File Contains
                {
                    if (i + buffers.Length > fileSize)
                        readSize = data.SOK.Receive(buffers, (int)(fileSize - i), SocketFlags.None);
                    else
                        readSize = data.SOK.Receive(buffers, buffers.Length, SocketFlags.None);
                    fs.Write(buffers, 0, readSize);
                    i += readSize;
                }
                fs.Flush(); fs.Close(); fs.Dispose();
            }
            data.Dispose();
        }
        [NetSyncAttribute(OpCodeProcess.C_ReciveFile)]
        public void C_ReciveFile(DataContext data)
        {
            /*info
             * Receive Packet Length (4 bytes)
             * Receive List Of File Paths with ; seperator
             * Send OK/Error Confirmation
             * Receive File Contains
             * */
            try
            {
                byte[] buffers = new byte[5];
                int PacketSize = 0;
                int readSize = 0;
                FileStream fs = null;

                data.SOK.Receive(buffers, 4, SocketFlags.None);
                PacketSize = BitConverter.ToInt32(buffers, 0);
                buffers = nsLib.Utilities.Buffers.GetBuffer(PacketSize);

                data.SOK.Receive(buffers, buffers.Length, SocketFlags.None);//Receive Options

                string filePath = Encoding.Unicode.GetString(buffers).Trim();
                long fileLen = new FileInfo(filePath).Length;

                //create respond command
                byte[] len = BitConverter.GetBytes(fileLen);
                byte[] cmd = new byte[len.Length + 1];
                Array.Copy(new byte[] { (byte)OpCodeProcess.S_OK }, cmd, 1);
                Array.Copy(len, 0, cmd, 1, len.Length);

                data.SOK.Send(cmd);//Send OK

                fs = File.OpenRead(filePath);
                buffers = nsLib.Utilities.Buffers.GetBuffer();

                for (int i = 0; i < fileLen; )//Send File Contains
                {
                    readSize = fs.Read(buffers, 0, buffers.Length);
                    if (data.SOK.Connected)
                        data.SOK.Send(buffers, readSize, SocketFlags.None);
                    else
                    {
                        fs.Close(); fs.Dispose();
                        File.Delete(filePath);
                        data.Dispose();
                        return;
                    }
                    i += readSize;
                }
                fs.Close(); fs.Dispose();
            }
            catch (Exception ex)
            {
                //data.Dispose();
                //throw ex;
            }
            data.Dispose();
        }
        [NetSyncAttribute(OpCodeProcess.C_ReciveFiles)]
        public void C_ReciveFiles(DataContext data)
        {
            /*info
             * Receive Packet Length (4 bytes)
             * Receive List Of File Paths with ; seperator
             * Send OK/Error Confirmation
             * Receive File Contains
             * */
            byte[] buffers = new byte[5];
            int PacketSize = 0;
            int readSize = 0;
            FileStream fs = null;

            data.SOK.Receive(buffers, 4, SocketFlags.None);
            PacketSize = BitConverter.ToInt32(buffers, 0);
            buffers = nsLib.Utilities.Buffers.GetBuffer(PacketSize);

            data.SOK.Receive(buffers, buffers.Length, SocketFlags.None);//Receive Options
            
            string[] FilePaths = Encoding.Unicode.GetString(buffers).Trim().Split(';');

            buffers = nsLib.Utilities.Buffers.GetBuffer(1);
            buffers[0] = (byte)OpCodeProcess.S_OK;
            foreach (string item in FilePaths)
            {
                long len = 0;
                if (File.Exists(item))
                    len = new FileInfo(item).Length;
                Uti.AddBytesToArray(ref buffers, BitConverter.GetBytes(len), true);
            }
            data.SOK.Send(buffers);//Send OK

            buffers = nsLib.Utilities.Buffers.GetBuffer();
            foreach (string item in FilePaths)
            {
                if (!File.Exists(item))
                    continue;
                fs = File.OpenRead(item);
                for (int i = 0; i < fs.Length;)
                {
                    readSize = fs.Read(buffers, 0, buffers.Length);
                    data.SOK.Send(buffers, readSize, SocketFlags.None);
                    i += readSize;
                    //if (fs.Length - i < buffers.Length)
                    //{
                    //    string x;
                    //}
                }
                fs.Close(); fs.Dispose();
            }
            data.Dispose();
        }
        [NetSyncAttribute(OpCodeProcess.C_DeleteFile)]
        public void C_DeleteFile(DataContext data)
        {
            /*info
             * Receive Packet Length (4 bytes)
             * Receive File Path
             * Send OK/Error Result
             * */
            try
            {
                byte[] buffers = new byte[5];
                data.SOK.Receive(buffers, 4, SocketFlags.None);
                buffers = nsLib.Utilities.Buffers.GetBuffer(BitConverter.ToInt32(buffers, 0));

                data.SOK.Receive(buffers, buffers.Length, SocketFlags.None);//Receive Options
                string filePath = Encoding.Unicode.GetString(buffers).Trim();
                try
                {
                    if (File.Exists(filePath))
                        File.Delete(filePath);
                }
                catch { }
                data.SOK.Send(new byte[] { (byte)OpCodeProcess.S_OK });//Send OK
            }
            catch (Exception ex)
            {
                //data.Dispose();
                //throw ex;
            }
            data.Dispose();
        }
        #endregion
    }
}
