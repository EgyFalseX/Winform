using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Netsync.Opcode;
using Netsync.Clients;
using nsLib.Opcode;

namespace Netsync
{
    public class NS
    {
        public Socket LSok;
        public IPEndPoint IPEndP;
        public nsLib.nsLib lib;

        public void OnStart()
        {
            IPEndP = new IPEndPoint(IPAddress.Any, Properties.Settings.Default.Port);
            try
            {
                Socket handlerSocket;
                Thread thdRecHandler;
                LSok = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                LSok.Bind(IPEndP);
                LSok.Listen(-1);
                do
                {
                    handlerSocket = LSok.Accept();
                    if (handlerSocket.Connected)
                    {
                        thdRecHandler = new Thread(SystemAnalyser);
                        thdRecHandler.Start(handlerSocket);
                    }
                } while (true);
            }
            catch (Exception ex)
            {
                if (ex.TargetSite.Name != "Accept")
                    nsLib.Utilities.Uti.LogMessage(ex.Message);
            }
        }
        public void SystemAnalyser(object obj)
        {
            Socket Sok = (Socket)(obj);
            byte[] Buffers = new byte[4097];
            //short Readed;
            //FileStream fs = null;
            try
            {
                Sok.Receive(Buffers, 1, SocketFlags.None);
                OpCodeProcess cmd = (OpCodeProcess)Buffers[0];

                Client cln = null;
                bool ExistedClient = Managers.ClientManager.DefaultInstance.Clients.TryGetValue(((IPEndPoint)Sok.RemoteEndPoint).Address, out cln);
                if (ExistedClient)
                {
                    Data.DataContext dc = new Data.DataContext(cmd) { SOK = Sok };
                    cln.AddProcess(dc);
                }
                else
                {
                    if (cmd != OpCodeProcess.C_Registration)
                        return;
                    Managers.ClientManager.DefaultInstance.RegisterClient(Sok);
                }
                
            }
            catch
            {
                //fs = null;
                Sok.Close();
                Sok = null;
                return;
            }
        }
        public void OnStop()
        {
            if (LSok != null)
            {
                LSok.Close();
                LSok = null;
            }
        }

    }
}
