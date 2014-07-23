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

namespace NestleMenu.Managers
{
    public class DataManager
    {
        
        #region -   Variables   -
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(Program));
        public static DataManager defaultInstance;
        DataSources.dsNU dsData;
        DataSources.dsNUTableAdapters.QueriesTableAdapter AdpQry;
        DataSources.dsNUQryTableAdapters.QueriesTableAdapter AdpQQry;
        //DataSources.dsDataCenterTableAdapters.LogsTableAdapter adpLogs;
        #endregion
        #region -   Functions   -
        public DataManager()
        {
            dsData = new DataSources.dsNU();
            AdpQry = new DataSources.dsNUTableAdapters.QueriesTableAdapter();
            AdpQQry = new DataSources.dsNUQryTableAdapters.QueriesTableAdapter();
            //adpLogs = new DataSources.dsDataCenterTableAdapters.LogsTableAdapter();
        }
        public static bool Init()
        {
            try
            {
                defaultInstance = new DataManager();
                if (!defaultInstance.CreateDefaultData())
                    return false;
                NU.LogMessage("Init ... Done", DataManager.defaultInstance, Utilities.Types.MessageType.Debug, Utilities.Types.MessagePopupType.None);
                return true;
            }
            catch (Exception ex)
            {
                NU.LogMessage("Init ... Error", DataManager.defaultInstance, Utilities.Types.MessageType.Error, Utilities.Types.MessagePopupType.Message, ex);
                return false;
            }
        }
        public bool CreateDefaultData()
        {
            try
            {
                DataSources.dsNUTableAdapters.UsersTableAdapter adpUser = new DataSources.dsNUTableAdapters.UsersTableAdapter();
                if (adpUser.IsAdminExist() == 0)
                {
                    adpUser.Insert(1, "admin", "admin");
                }
                NU.LogMessage("Create Default Data ... Done", DataManager.defaultInstance, Utilities.Types.MessageType.Debug, Utilities.Types.MessagePopupType.None);
                return true;
            }
            catch (Exception ex)
            {
                NU.LogMessage("Create Default Data ... Error", DataManager.defaultInstance, Utilities.Types.MessageType.Error, Utilities.Types.MessagePopupType.None, ex);
                return false;
            }
        }
        #endregion
        
    }
}