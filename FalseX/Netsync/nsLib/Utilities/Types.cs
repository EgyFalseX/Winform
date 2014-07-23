using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nsLib.Utilities
{
    public class Types
    {
        public enum ClientState
        {
            Working,
            Stoped
        }
        public enum ServerOptions : int
        {
            DefaultUserPassword = 1,
            FilesPath,
            RelatedFiles,
            DeletedFilesPath,
            ServerIP,
            ServerPort,
            StudentFilesPath,
            EmpFilePath
        }
        public enum LogType : int
        {
            Categoy = 1,
            Item,
            CategoyRole,
            CategoyUser,
            ItemRole,
            ItemUser
        }
        public enum LogOpType : int
        {
            Inset = 1,
            Update,
            Delete,

            AddAllowedRole,
            AddDeniedRole,

            EditAllowedRole,
            EditDeniedRole,

            DeleteAllowedRole,
            DeleteDeniedRole,

            AddAllowedUser,
            AddDeniedUser,

            EditAllowedUser,
            EditDeniedUser,
            
            DeleteAllowedUser,
            DeleteDeniedUser
        }
        public enum UserLevelType : int
        {
            Administrator = 1,
            User
        }
        public enum GrantType : int
        {
            allow = 1,
            deny
        }
        public enum MessageType : int
        {
            Success,
            Error,
            Info,
            Debug,
            Fatal,
            Warn
        }
    }
}
