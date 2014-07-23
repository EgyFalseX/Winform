using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using System.Data.SqlClient;
using log4net;
using System.Data;

namespace GM.Managers
{
    public class DataManager
    {
        
        #region -   Variables   -
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(Program));
        public static DataManager defaultInstance;
        DataSources.dsQry dsQData;
        DataSources.dsQryTableAdapters.QueriesTableAdapter adpQry;
        //DataSources.dsNUTableAdapters.QueriesTableAdapter AdpQry;
        //DataSources.dsNUQryTableAdapters.QueriesTableAdapter AdpQQry;
        //DataSources.dsDataCenterTableAdapters.LogsTableAdapter adpLogs;
        #endregion
        #region -   Functions   -
        public DataManager()
        {
            dsQData = new DataSources.dsQry();
            adpQry = new DataSources.dsQryTableAdapters.QueriesTableAdapter();
            //dsData = new DataSources.dsNU();
            //AdpQry = new DataSources.dsNUTableAdapters.QueriesTableAdapter();
            //AdpQQry = new DataSources.dsNUQryTableAdapters.QueriesTableAdapter();
            //adpLogs = new DataSources.dsDataCenterTableAdapters.LogsTableAdapter();
        }
        public static bool Init()
        {
            try
            {
                defaultInstance = new DataManager();
                //if (!defaultInstance.CreateDefaultData())
                //    return false;
                Glob.LogMessage("Init ... OK", DataManager.defaultInstance, Utilities.Types.MessageType.Debug, Utilities.Types.MessagePopupType.None);
                return true;
            }
            catch (Exception ex)
            {
                Glob.LogMessage("Init ... Error", DataManager.defaultInstance, Utilities.Types.MessageType.Error, Utilities.Types.MessagePopupType.Message, ex);
                return false;
            }
        }
        public DateTime ServerDatetime
        {
            get { return (DateTime)adpQry.ServerDateTime(); }
        }
        
     
        #endregion
        
    }
}