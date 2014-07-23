using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using DbSyc_Server.Logging;

namespace DbSyc_Server
{
    public class svc
    {
        public Socket _lSok;
        public IPEndPoint IPEndP;
        public int _port = 0;
        public svc(int port)
        {
            _port = port;
        }
        public void OnStart()
        {
            IPEndP = new IPEndPoint(IPAddress.Any, _port);
            try
            {
                Socket handlerSocket;
                Thread thdRecHandler;
                _lSok = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                _lSok.Bind(IPEndP);
                _lSok.Listen(-1);
                Log.LogMessage("Server Started ....");
                do
                {
                    handlerSocket = _lSok.Accept();
                    if (handlerSocket.Connected)
                    {
                        Log.LogMessage("Recived connection from " + ((IPEndPoint)handlerSocket.RemoteEndPoint).Address);
                        thdRecHandler = new Thread(SystemAnalyser);
                        thdRecHandler.Start(handlerSocket);
                    }
                } while (true);
            }
            catch (Exception ex)
            {
                if (ex.TargetSite.Name != "Accept")
                    Log.LogMessage(ex.Message);
                
            }
        }
        public void SystemAnalyser(object obj)
        {
            Socket Sok = (Socket)(obj);
            byte[] Buffers = new byte[4097];
            try
            {
                Sok.Receive(Buffers, 1, SocketFlags.None);
                OpCodeProcess cmd = (OpCodeProcess)Buffers[0];
                switch (cmd)
                {
                    case OpCodeProcess.C_SendFile:
                        Log.LogMessage("connection from " + ((IPEndPoint)Sok.RemoteEndPoint).Address + " Request Send File");
                        ThreadPool.QueueUserWorkItem((o) => { C_SendFile(Sok); });
                        break;
                    case  OpCodeProcess.C_ReciveFile:
                        Log.LogMessage("connection from " + ((IPEndPoint)Sok.RemoteEndPoint).Address + " Request Recive File");
                        ThreadPool.QueueUserWorkItem((o) => { C_ReciveFile(Sok); });
                        break;
                }
            }
            catch
            {
                Sok.Close();
                Sok = null;
                return;
            }
        }
        public void OnStop()
        {
            if (_lSok != null)
            {
                _lSok.Close();
                _lSok = null;
            }
            Log.LogMessage("Server Stoped ....");
        }

        private void C_SendFile(Socket sok)
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
            try
            {
                sok.Receive(buffers, 4, SocketFlags.None);
                PacketSize = BitConverter.ToInt32(buffers, 0);
                buffers = Buffers.GetBuffer(PacketSize);

                sok.Receive(buffers, buffers.Length, SocketFlags.None);//Receive Options

                string[] info = Encoding.Unicode.GetString(buffers).Trim().Split(';');
                long FileLenth = Convert.ToInt64(info[0]);
                string FileName = info[1];

                sok.Send(new byte[] { (byte)OpCodeProcess.S_OK });//Send OK

                FileStream fs = null;
                fs = File.OpenWrite(FileName);

                buffers = Buffers.GetBuffer();

                for (int i = 0; i < FileLenth; )//Receive File Contains
                {
                    if (!sok.Connected)
                    {
                        fs.Flush(); fs.Close(); fs.Dispose();
                        File.Delete(FileName);
                        return;
                    }
                    readSize = sok.Receive(buffers, buffers.Length, SocketFlags.None);
                    fs.Write(buffers, 0, readSize);
                    i += readSize;
                }
                fs.Flush(); fs.Close(); fs.Dispose();
                Log.LogMessage(string.Format("connection from {0} Send File complated [{1}]", ((IPEndPoint)sok.RemoteEndPoint).Address, FileName));
                sok.Disconnect(false); sok.Dispose();
            }
            catch (Exception ex)
            {
                Log.LogMessage(ex.Message, true);
                sok.Dispose();
            }
        }
        private void C_ReciveFile(Socket sok)
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

                sok.Receive(buffers, 4, SocketFlags.None);
                PacketSize = BitConverter.ToInt32(buffers, 0);
                buffers = Buffers.GetBuffer(PacketSize);

                sok.Receive(buffers, buffers.Length, SocketFlags.None);//Receive Options

                string filePath = Encoding.Unicode.GetString(buffers).Trim();
                long fileLen = new FileInfo(filePath).Length;

                //create respond command
                byte[] len = BitConverter.GetBytes(fileLen);
                byte[] cmd = new byte[len.Length + 1];
                Array.Copy(new byte[] { (byte)OpCodeProcess.S_OK }, cmd, 1);
                Array.Copy(len, 0, cmd, 1, len.Length);

                sok.Send(cmd);//Send OK

                fs = File.OpenRead(filePath);
                buffers = Buffers.GetBuffer();

                for (int i = 0; i < fileLen; )//Send File Contains
                {
                    readSize = fs.Read(buffers, 0, buffers.Length);
                    if (sok.Connected)
                        sok.Send(buffers, readSize, SocketFlags.None);
                    else
                    {
                        fs.Close(); fs.Dispose();
                        File.Delete(filePath);
                        return;
                    }
                    i += readSize;
                }
                fs.Close(); fs.Dispose();
                Log.LogMessage(string.Format("connection from {0} Revice File complated [{1}]", ((IPEndPoint)sok.RemoteEndPoint).Address, filePath));
                sok.Disconnect(false); sok.Dispose();
            }
            catch (Exception ex)
            {
                Log.LogMessage(ex.Message, true);
                sok.Dispose();
            }
            
        }

    }

}
