using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using log4net;

namespace NestleICSales.Managers
{
    public class UserManager
    {
        #region -   Variables   -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(UserManager));
        public static UserManager defaultInstance;
        private DataSources.dsData dsData;
        private DataSources.dsDataTableAdapters.UsersTableAdapter adpUser;
        private DataSources.dsDataTableAdapters.AppRoleTableAdapter adpAppRole;
        //private DataSources.dsDataCenterTableAdapters.ItemRoleTableAdapter adpItemRole;
        #endregion
        #region -   Functions   -
        public UserManager()
        {
            dsData = new DataSources.dsData();
            adpUser = new DataSources.dsDataTableAdapters.UsersTableAdapter();
            adpAppRole = new DataSources.dsDataTableAdapters.AppRoleTableAdapter();
            //adpItemRole = new DataSources.dsDataCenterTableAdapters.ItemRoleTableAdapter();
        }

        public static bool Init()
        {
            try
            {
                defaultInstance = new UserManager();
                Logger.Debug("Init ... Done");
                return true;
            }
            catch (SqlException ex)
            {
                Logger.Debug("Init ... Error", ex);
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
                //adpCatRole.FillByUserId(dsData.CategoryRole, UserInfo.UserID);
                //adpItemRole.FillByUserId(dsData.ItemRole, UserInfo.UserID);

                Logger.Debug(string.Format("User: {0} SignIn", UserInfo.UserName));
                return true;
            }
            else
            {
                Logger.Warn(string.Format("User: {0} Error SignIn", username));
                return false;
            }
        }

        public DataSources.dsData.UsersRow UserInfo
        {
            get
            {
                if (dsData.Users.Count == 0)
                    return null;
                else
                    return dsData.Users[0];
            }
        }

        public DataSources.dsData.AppRoleDataTable UserAppRoles
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
                Logger.Debug("Save User Info ... Done");
                return true;
            }
            else
            {
                Logger.Error("Save User Info ... Error");
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
                //adpCatRole.FillByUserId(dsData.CategoryRole, UserInfo.UserID);
                //adpItemRole.FillByUserId(dsData.ItemRole, UserInfo.UserID);
                Logger.Debug("Load User Role ... Done");
            }
            catch (SqlException ex)
            {
                Logger.Error("Load User Role ... Error - " + ex.Message, ex);
            }

        }

        #endregion

    }
}
