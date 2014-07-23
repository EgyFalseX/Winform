using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using log4net;

namespace DataCenter.Managers
{
    public class UserManager
    {
        #region -   Variables   -
        public static UserManager defaultInstance;

        private DataSources.dsDataCenter dsData;

        private DataSources.dsDataCenterTableAdapters.UsersTableAdapter adpUser;
        private DataSources.dsDataCenterTableAdapters.AppRoleTableAdapter adpAppRole;
        private DataSources.dsDataCenterTableAdapters.CategoryRoleTableAdapter adpCatRole;
        private DataSources.dsDataCenterTableAdapters.ItemRoleTableAdapter adpItemRole;
        #endregion
        #region -   Functions   -
        public UserManager()
        {
            dsData = new DataSources.dsDataCenter();

            adpUser = new DataSources.dsDataCenterTableAdapters.UsersTableAdapter();
            adpAppRole = new DataSources.dsDataCenterTableAdapters.AppRoleTableAdapter();
            adpCatRole = new DataSources.dsDataCenterTableAdapters.CategoryRoleTableAdapter();
            adpItemRole = new DataSources.dsDataCenterTableAdapters.ItemRoleTableAdapter();
        }

        public static bool Init()
        {
            try
            {
                defaultInstance = new UserManager();
                DataCenterX.LogMessage("Init ... Done", typeof(UserManager), nsLib.Utilities.Types.MessageType.Debug);
                return true;
            }
            catch (SqlException ex)
            {
                DataCenterX.LogMessage("Init ... Error", typeof(UserManager), nsLib.Utilities.Types.MessageType.Error, ex);
                return false;
            }
        }

        public bool SignIn(string username, string password)
        {
            if (adpUser.FillBySginIn(dsData.Users, username, password) == 1)
            {
                UserInfo.LastActivityDate = AppManager.defaultInstance.ServerDateTime();
                adpUser.Update(UserInfo);

                adpAppRole.FillByUserId(dsData.AppRole, UserInfo.UserID);
                adpCatRole.FillByUserId(dsData.CategoryRole, UserInfo.UserID);
                adpItemRole.FillByUserId(dsData.ItemRole, UserInfo.UserID);

                DataCenterX.LogMessage(string.Format("User: {0} SignIn", UserInfo.UserName), typeof(UserManager), nsLib.Utilities.Types.MessageType.Debug);
                return true;
            }
            else
            {
                DataCenterX.LogMessage(string.Format("User: {0} Error SignIn", UserInfo.UserName), typeof(UserManager), nsLib.Utilities.Types.MessageType.Warn, null, true);
                return false;
            }
        }

        public DataSources.dsDataCenter.UsersRow UserInfo
        {
            get
            {
                if (dsData.Users.Count == 0)
                    return null;
                else
                    return dsData.Users[0];
            }
        }

        public DataSources.dsDataCenter.AppRoleDataTable UserAppRoles
        {
            get
            {
                if (dsData.Users.Count == 0)
                    return null;
                else
                    return dsData.AppRole;
            }
        }

        public bool SaveUserInfo()
        {
            if (adpUser.Update(UserInfo) == 1)
            {
                DataCenterX.LogMessage("Save User Info ... Done", typeof(UserManager), nsLib.Utilities.Types.MessageType.Debug);
                return true;
            }
            else
            {
                DataCenterX.LogMessage("Save User Info ... Error", typeof(UserManager), nsLib.Utilities.Types.MessageType.Error);
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

        public void LoadUserRole()
        {
            try
            {
                adpAppRole.FillByUserId(dsData.AppRole, UserInfo.UserID);
                adpCatRole.FillByUserId(dsData.CategoryRole, UserInfo.UserID);
                adpItemRole.FillByUserId(dsData.ItemRole, UserInfo.UserID);
                DataCenterX.LogMessage("Load User Role ... Done", typeof(UserManager), nsLib.Utilities.Types.MessageType.Debug);
            }
            catch (SqlException ex)
            {
                DataCenterX.LogMessage("Load User Role ... Error", typeof(UserManager), nsLib.Utilities.Types.MessageType.Error, ex);

            }

        }

        #endregion

    }
}
