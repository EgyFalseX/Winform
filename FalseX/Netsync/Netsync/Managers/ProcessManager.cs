using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Netsync.Data;
using Netsync.Opcode;
using nsLib.Opcode;

namespace Netsync.Managers
{
    public class ProcessManager
    {
        #region -   Variables   -
        public static ProcessManager DefaultInstance;
        public static Queue<DataContext> ProcessQ;
        private const long _maximumQCount = 1024;
        private WaitHandle waitHandle = null;
        private DateTime startTime = DateTime.Now;
        #endregion
        #region -   Functions   -
        public long RespondNextId
        {
            get
            {
                lock (ProcessQ)
                {
                    return ProcessQ.Count;
                }
            }
        }
        public void QueueProcess(OpCodeProcess opcode, List<Dictionary<string, object>> sendData = null)
        {
            DataContext data = new DataContext(opcode, sendData);
            if (ProcessQ.Count + 1 == _maximumQCount)
                ProcessQ.Dequeue();//discard the last item
            //Logger.DebugFormat("Queue Respond: {0} - {1}", data.ID, data.OPCODE.ToString());
            lock (ProcessQ)
            { ProcessQ.Enqueue(data); }
            ThreadPool.RegisterWaitForSingleObject(waitHandle, FireProcess, null, 100, true);
        }
        private void FireProcess(object o, bool TimeOut)
        {
            DataContext data;
            lock (ProcessQ)
            { data = ProcessQ.Dequeue(); }
            OpcodesHandler.DefaultInstance.MainHandler(data, false);
        }
        #endregion
    }
}
