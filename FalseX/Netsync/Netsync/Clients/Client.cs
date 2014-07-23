using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using Netsync.Data;
using System.Threading;
using Netsync.Opcode;

namespace Netsync.Clients
{
    public class Client : IDisposable
    {
        #region -   Variables   -
        public DateTime RegisterDateTime { get; set; }
        public Socket Sok { get; set; }
        private Queue<DataContext> DataQueue;
        private WaitHandle waitHandle;
        private const long _maximumQCount = 1024;

        #endregion
        #region -   Functions   -
        public Client() { }
        public Client(Socket ClientSocket)
        {
            RegisterDateTime = DateTime.Now;
            DataQueue = new Queue<DataContext>();
            Sok = ClientSocket;
            waitHandle = new EventWaitHandle(false, EventResetMode.ManualReset);
        }
        public nsLib.Utilities.Types.ClientState ConnectionState
        {
            get
            {
                if (Sok.Connected)
                    return nsLib.Utilities.Types.ClientState.Working;
                else
                    return nsLib.Utilities.Types.ClientState.Stoped;
            }
        }

        public void AddProcess(DataContext data)
        {
            if (DataQueue.Count + 1 == _maximumQCount)
                DataQueue.Dequeue();//discard the last item

            lock (DataQueue) { DataQueue.Enqueue(data); }
            ThreadPool.RegisterWaitForSingleObject(waitHandle, StartProcess, null, 100, true);
        }
        private void StartProcess(object o, bool timeOut)
        {
            try
            {
                DataContext data;
                lock (DataQueue) { data = DataQueue.Dequeue(); }
                ////////////ClientCallBack.SendRespond(data);
                if (data !=null)
                    OpcodesHandler.DefaultInstance.MainHandler(data, false);
                //Logger.DebugFormat("Data sended to client Opcode: {0}", data.OPCODE.ToString());
            }
            catch (Exception ex)
            {
                //Logger.ErrorFormat("Error While Sending Data To A Client, Error Mesaage: {0}", ex.Message);
            }
        }

        public void Dispose()
        {
            try
            {
                Sok.Close();
                Sok.Dispose();
                DataQueue.Clear();
                DataQueue = null;
            }
            catch (Exception ex)
            {
                nsLib.Utilities.Uti.LogMessage(ex.Message);
            }
        }
        #endregion

    }
}
