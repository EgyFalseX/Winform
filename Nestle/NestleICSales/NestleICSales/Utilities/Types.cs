using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NestleICSales.Utilities
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
            Warn,
            Question
        }
        public enum XmlFileType
        {
            R3,
        }
        public struct ReportsFormation
        {
            public string TabelName { get; set; }
            public int HeaderCount { get; set; }
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
            ZRDD = 1,
            F2 = 2,
            S1 = 3,
            S2 = 4,
            ZG2Q = 5,
            ZL2Q = 6,
            RE = 7
        }
        public enum ConditionType
        {
            R100 = 1,
            Z001 = 2,
            Z101 = 3,
            ZPR0 = 4
        }
        public enum RouteStatus
        {
            Unknown = 1,
            Online,
            Canceled,
            Paused
        }

        public enum RouteCustomerState : short
        {
            Active = 1,
            Pause = 2,
            Terminated = 3,
            Unknown = 9999
        }

        public enum SalesUnit
        {
            CS = 1,
            EA = 2
        }

    }
}
