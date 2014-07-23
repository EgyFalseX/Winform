using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using Netsync.Clients;
using System.Net;
using nsLib.Opcode;

namespace Netsync.Managers
{
    public class ClientManager
    {
        public static ClientManager DefaultInstance = new ClientManager();
        public Dictionary<IPAddress, Client> Clients;

        public ClientManager()
        {
            Inti();
        }
        public void Inti()
        {
            Clients = new Dictionary<IPAddress, Client>();
        }
        public void RegisterClient(Socket ClientSocket)
        {
            Client newClient = new Client(ClientSocket);
            lock (Clients)
            {
                Clients.Add(((IPEndPoint)ClientSocket.RemoteEndPoint).Address, newClient);
            }
            Data.DataContext ds = new Data.DataContext(OpCodeProcess.C_Registration) { SOK = ClientSocket };
            newClient.AddProcess(ds);
        }

    }

}
