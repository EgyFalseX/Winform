using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Netsync.Opcode;
using System.Net;
using System.Net.Sockets;
using Netsync.Managers;
using nsLib.Opcode;

namespace Netsync.Data
{
    public class DataContext 
    {
        #region -   Variables   -
        public long ID { get; set; }
        public OpCodeProcess OPCODE { get; set; }
        public DateTime DATE { get; set; }
        public List<Dictionary<string, object>> DATA { get; set; }
        public string ERROR { get; set; }
        public Socket SOK { get; set; }
        
        #endregion
        #region -   Functions   -
        private void Loading()
        {
            //ID = ProcessManager.DefaultInstance.RespondNextId;
            DATE = DateTime.Now;
        }
        public DataContext()
        {
            Loading();
        }
        public DataContext(OpCodeProcess opcode)
        {
            Loading();
            OPCODE = opcode;
        }
        public DataContext(List<Dictionary<string, object>> sendData)
        {
            Loading();
            DATA = sendData;
        }
        public DataContext(OpCodeProcess opcode, List<Dictionary<string, object>> sendData)
        {
            Loading();
            OPCODE = opcode;
            DATA = sendData;
        }
        
        public bool AddItem(Dictionary<string, object> item)
        {
            if (DATA == null)
                DATA = new List<Dictionary<string, object>>();
            DATA.Add(item);
            return true;
        }
        public bool RemoveByValue(Dictionary<string, object> item)
        {
            if (DATA == null)
                return false;

            if (DATA.Remove(item))
                return true;
            else
                return false;
        }
      
        public long ItemsCount
        {
            get
            {
                if (DATA == null)
                    return 0;
                return DATA.Count;
            }
            private set
            { }
        }

        public void Dispose()
        {
            if (SOK != null)
            {
                if (SOK.Connected)
                    SOK.Disconnect(false);
                SOK.Dispose();
            }
            if (DATA != null)
                DATA.Clear();
        }

        #endregion
    }
}
