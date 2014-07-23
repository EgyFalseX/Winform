using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using log4net;

namespace GM.Managers
{
    public class UserManager
    {
        #region -   Variables   -
        public static UserManager defaultInstance;

        private DataSources.dsGM dsData;
        private DataSources.dsGMTableAdapters.UserTableAdapter adpUser;
        private DataSources.dsQry dsQData;
        private DataSources.dsQryTableAdapters.UserRoleDetailNamesTableAdapter adpUserRoleDetailNames;

        #endregion
        #region -   Functions   -
        public UserManager()
        {
            dsData = new DataSources.dsGM();
            adpUser = new DataSources.dsGMTableAdapters.UserTableAdapter();

            dsQData = new DataSources.dsQry();
            adpUserRoleDetailNames = new DataSources.dsQryTableAdapters.UserRoleDetailNamesTableAdapter();
        }
        public static bool Init()
        {
            try
            {
                defaultInstance = new UserManager();
                Glob.LogMessage("Init ... OK", UserManager.defaultInstance, Utilities.Types.MessageType.Debug, Utilities.Types.MessagePopupType.None);
                return true;
            }
            catch (SqlException ex)
            {
                Glob.LogMessage("Init ... Error", UserManager.defaultInstance, Utilities.Types.MessageType.Error, Utilities.Types.MessagePopupType.Message, ex);
                return false;
            }
        }
        public bool SignIn(string username, string password)
        {

            if (adpUser.FillByLogin(dsData.User, username, password) > 0)
            {

                adpUserRoleDetailNames.Fill(dsQData.UserRoleDetailNames, UserInfo.UserId);
                Glob.LogMessage(string.Format("User: {0} SignIn", username), UserManager.defaultInstance, Utilities.Types.MessageType.Debug, Utilities.Types.MessagePopupType.None);
                return true;
            }
            else
            {
                Glob.LogMessage(string.Format("User: {0} Error SignIn", username), UserManager.defaultInstance, Utilities.Types.MessageType.Warn, Utilities.Types.MessagePopupType.None);
                return false;
            }
        }
        public DataSources.dsGM.UserRow UserInfo
        {
            get
            {
                if (dsData.User.Count == 0)
                    return null;
                else
                    return dsData.User[0];
            }
        }
        public DataSources.dsQry.UserRoleDetailNamesDataTable UserRoleDetailNames
        {
            get
            {
                return dsQData.UserRoleDetailNames;
            }
        }
        public bool SaveUserInfo()
        {
            if (adpUser.Update(UserInfo) == 1)
            {
                Glob.LogMessage("Save User Info ... OK", UserManager.defaultInstance, Utilities.Types.MessageType.Debug, Utilities.Types.MessagePopupType.None);
                return true;
            }
            else
            {
                Glob.LogMessage("Save User Info ... Error", UserManager.defaultInstance, Utilities.Types.MessageType.Error, Utilities.Types.MessagePopupType.None);
                return false;
            }
        }
        public bool loggedIn
        {
            get
            {
                if (UserInfo == null)
                    return false;
                else
                    return true;
            }
        }

        #endregion

    }
}
