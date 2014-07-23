using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using log4net;

namespace NestleMenu.Managers
{
    public class UserManager
    {
        #region -   Variables   -
        public static UserManager defaultInstance;

        private DataSources.dsNU dsData;
        private DataSources.dsNUTableAdapters.UsersTableAdapter adpUser;

        #endregion
        #region -   Functions   -
        public UserManager()
        {
            dsData = new DataSources.dsNU();
            adpUser = new DataSources.dsNUTableAdapters.UsersTableAdapter();
        }

        public static bool Init()
        {
            try
            {
                defaultInstance = new UserManager();
                NU.LogMessage("Init ... Done", UserManager.defaultInstance, Utilities.Types.MessageType.Debug, Utilities.Types.MessagePopupType.None);
                return true;
            }
            catch (SqlException ex)
            {
                NU.LogMessage("Init ... Error", UserManager.defaultInstance, Utilities.Types.MessageType.Error, Utilities.Types.MessagePopupType.Message, ex);
                return false;
            }
        }

        public bool SignIn(string username, string password)
        {

            if (adpUser.SignIn(dsData.Users, username, password) > 0)
            {
                NU.LogMessage(string.Format("User: {0} SignIn", username), UserManager.defaultInstance, Utilities.Types.MessageType.Debug, Utilities.Types.MessagePopupType.None);
                return true;
            }
            else
            {
                NU.LogMessage(string.Format("User: {0} Error SignIn", username), UserManager.defaultInstance, Utilities.Types.MessageType.Warn, Utilities.Types.MessagePopupType.None);
                return false;
            }
        }

        public DataSources.dsNU.UsersRow UserInfo
        {
            get
            {
                if (dsData.Users.Count == 0)
                    return null;
                else
                    return dsData.Users[0];
            }
        }

        public bool SaveUserInfo()
        {
            if (adpUser.Update(UserInfo) == 1)
            {
                NU.LogMessage("Save User Info ... Done", UserManager.defaultInstance, Utilities.Types.MessageType.Debug, Utilities.Types.MessagePopupType.None);
                return true;
            }
            else
            {
                NU.LogMessage("Save User Info ... Error", UserManager.defaultInstance, Utilities.Types.MessageType.Error, Utilities.Types.MessagePopupType.None);
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
