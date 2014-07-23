using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NestleMenu.Utilities
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
            FilesPath = 1,
            RelatedFiles,
            DeletedFilesPath,
            DefaultUserPassword,
            ServerIP,
            ServerPort,
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
        public enum MessagePopupType : int
        {
            Message,
            Alert,
            None
        }
        public enum XmlFileType
        {
            R3,
        }
        public struct ReportsFormation
        {
            public int HeaderCount { get; set; }
            public int TableIndex { get; set; }
            public XmlFileType FileType { get; set; }
            public string FormationName 
            {
                get
                {
                    return FileType.ToString();
                }
            }

        }

        public enum BillingType
        {
            ZRDD,
            F2,
            S1,
            S2,
            ZG2Q,
            ZL2Q
        }
        public enum ConditionType
        {
            R100,
            Z001,
            Z101,
            ZPR0
        }
    }
}
