using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SqlInstaller
{
    class ConfigurationFile
    {
        #region -   Variables   -
        private readonly string cfgFileName = "ConfigurationFile.ini";
        /// <summary>
        /// Specify the Instance ID for the SQL Server features you have specified. SQL Server directory structure, registry structure, and service names will reflect the instance ID of the SQL Server instance. 
        /// Ex. INSTANCEID="SQLEXPRESS"
        /// </summary>
        private string _INSTANCEID = string.Empty;
        public string INSTANCEID
        {
            get { return _INSTANCEID; }
            set { _INSTANCEID = String.Format("INSTANCEID=\"{0}\"", value); }
        }
        /// <summary>
        /// Specifies a Setup work flow, like INSTALL, UNINSTALL, or UPGRADE. This is a required parameter. 
        /// Ex. ACTION="Install"
        /// </summary>
        private string _ACTION = string.Empty;
        public string ACTION
        {
            get { return _ACTION; }
            set { _ACTION = String.Format("ACTION=\"{0}\"", value); }
        }
        /// <summary>
        /// Specifies features to install, uninstall, or upgrade. The list of top-level features include SQL, AS, RS, IS, and Tools. The SQL feature will install the database engine, replication, and full-text. The Tools feature will install Management Tools, Books online, Business Intelligence Development Studio, and other shared components. 
        /// Ex. FEATURES=SQLENGINE,REPLICATION,FULLTEXT,RS,BIDS,SSMS
        /// </summary>
        private string _FEATURES = string.Empty;
        public string FEATURES
        {
            get { return _FEATURES; }
            set { _FEATURES = String.Format("FEATURES=\"{0}\"", value); }
        }
        /// <summary>
        /// Displays the command line parameters usage  
        /// Ex. HELP="False"
        /// </summary>
        private string _HELP = string.Empty;
        public bool HELP
        {
            get 
            {
                string Data = _HELP.Replace("HELP=", "");
                Data = Data.Replace("\"", "");
                bool returnMe = Convert.ToBoolean(Data);
                return returnMe;
            }
            set 
            { _HELP = String.Format("HELP=\"{0}\"", value); }
        }
        /// <summary>
        /// Specifies that the detailed Setup log should be piped to the console. 
        /// Ex. INDICATEPROGRESS="False"
        /// </summary>
        private string _INDICATEPROGRESS = string.Empty;
        public bool INDICATEPROGRESS
        {
            get
            {
                string Data = _INDICATEPROGRESS.Replace("INDICATEPROGRESS=", "");
                Data = Data.Replace("\"", "");
                bool returnMe = Convert.ToBoolean(Data);
                return returnMe;
            }
            set
            { _INDICATEPROGRESS = String.Format("INDICATEPROGRESS=\"{0}\"", value); }
        }
        /// <summary>
        /// Setup will not display any user interface.
        /// Ex. QUIET="True"
        /// </summary>
        private string _QUIET = string.Empty;
        public bool QUIET
        {
            get
            {
                string Data = _QUIET.Replace("QUIET=", "");
                Data = Data.Replace("\"", "");
                bool returnMe = Convert.ToBoolean(Data);
                return returnMe;
            }
            set
            { _QUIET = String.Format("QUIET=\"{0}\"", value); }
        }
        /// <summary>
        /// Setup will display progress only without any user interaction. 
        /// Ex. QUIETSIMPLE="False"
        /// </summary>
        private string _QUIETSIMPLE = string.Empty;
        public bool QUIETSIMPLE
        {
            get
            {
                string Data = _QUIETSIMPLE.Replace("QUIETSIMPLE=", "");
                Data = Data.Replace("\"", "");
                bool returnMe = Convert.ToBoolean(Data);
                return returnMe;
            }
            set
            { _QUIETSIMPLE = String.Format("QUIETSIMPLE=\"{0}\"", value); }
        }
        /// <summary>
        /// Specifies that Setup should install into WOW64. This command line argument is not supported on an IA64 or a 32-bit system. 
        /// Ex. X86="False"
        /// </summary>
        private string _X86 = string.Empty;
        public bool X86
        {
            get
            {
                string Data = _X86.Replace("X86=", "");
                Data = Data.Replace("\"", "");
                bool returnMe = Convert.ToBoolean(Data);
                return returnMe;
            }
            set
            { _X86 = String.Format("X86=\"{0}\"", value); }
        }
        /// <summary>
        /// Specifies the path to the installation media folder where setup.exe is located. 
        /// Ex. MEDIASOURCE="e:\bc96357610aa9082601cf9c731\"
        /// </summary>
        private string _MEDIASOURCE = string.Empty;
        public string MEDIASOURCE
        {
            get { return _MEDIASOURCE; }
            set 
            {
                if (value.EndsWith("\""))
                    _MEDIASOURCE = String.Format("MEDIASOURCE=\"{0}\"", value);
                else
                    _MEDIASOURCE = String.Format("MEDIASOURCE=\"{0}\"\\", value);
            }
        }
        /// <summary>
        /// Specify if errors can be reported to Microsoft to improve future SQL Server releases. Specify 1 or True to enable and 0 or False to disable this feature. 
        /// Ex. ERRORREPORTING="False"
        /// </summary>
        private string _ERRORREPORTING = string.Empty;
        public bool ERRORREPORTING
        {
            get
            {
                string Data = _ERRORREPORTING.Replace("ERRORREPORTING=", "");
                Data = Data.Replace("\"", "");
                bool returnMe = Convert.ToBoolean(Data);
                return returnMe;
            }
            set
            { _ERRORREPORTING = String.Format("ERRORREPORTING=\"{0}\"", value); }
        }
        /// <summary>
        /// Specify the root installation directory for native shared components.
        /// Ex. INSTANCEDIR="C:\Program Files\Microsoft SQL Server"
        /// Ex. INSTALLSHAREDDIR="C:\Program Files\Microsoft SQL Server"
        /// </summary>
        private string _INSTANCEDIR = string.Empty;
        private string _INSTALLSHAREDDIR = string.Empty;
        public string INSTANCEDIR
        {
            get { return _INSTANCEDIR; }
            set
            {
                if (value.EndsWith("\""))
                {
                    _INSTANCEDIR = String.Format("INSTANCEDIR=\"{0}\"Microsoft SQL Server\\", value);
                    _INSTALLSHAREDDIR = String.Format("INSTALLSHAREDDIR=\"{0}\"Microsoft SQL Server\\", value);
                }
                else
                {
                    _INSTANCEDIR = String.Format("INSTANCEDIR=\"{0}\"\\Microsoft SQL Server\\", value);
                    _INSTALLSHAREDDIR = String.Format("INSTALLSHAREDDIR=\"{0}\"\\Microsoft SQL Server\\", value);
                }
            }
        }
        /// <summary>
        /// Specify that SQL Server feature usage data can be collected and sent to Microsoft. Specify 1 or True to enable and 0 or False to disable this feature.  
        /// Ex. SQMREPORTING="False"
        /// </summary>
        private string _SQMREPORTING = string.Empty;
        public bool SQMREPORTING
        {
            get
            {
                string Data = _SQMREPORTING.Replace("SQMREPORTING=", "");
                Data = Data.Replace("\"", "");
                bool returnMe = Convert.ToBoolean(Data);
                return returnMe;
            }
            set
            { _SQMREPORTING = String.Format("SQMREPORTING=\"{0}\"", value); }
        }
        /// <summary>
        /// Specify a default or named instance. MSSQLSERVER is the default instance for non-Express editions and SQLExpress for Express editions. This parameter is required when installing the SQL Server Database Engine (SQL), Analysis Services (AS), or Reporting Services (RS). 
        /// Ex. INSTANCENAME="SQLEXPRESS"
        /// </summary>
        private string _INSTANCENAME = string.Empty;
        public string INSTANCENAME
        {
            get { return _INSTANCENAME; }
            set { _INSTANCENAME = String.Format("INSTANCENAME=\"{0}\"", value); }
        }
        /// <summary>
        /// Agent account name 
        /// Ex. AGTSVCACCOUNT="NT AUTHORITY\NETWORK SERVICE"
        /// </summary>
        private string _AGTSVCACCOUNT = string.Empty;
        public string AGTSVCACCOUNT
        {
            get { return _AGTSVCACCOUNT; }
            set { _AGTSVCACCOUNT = String.Format("AGTSVCACCOUNT=\"{0}\"", value); }
        }
        /// <summary>
        /// Auto-start service after installation. 
        /// Ex. AGTSVCSTARTUPTYPE="Disabled"
        /// </summary>
        private string _AGTSVCSTARTUPTYPE = string.Empty;
        public string AGTSVCSTARTUPTYPE
        {
            get { return _AGTSVCSTARTUPTYPE; }
            set { _AGTSVCSTARTUPTYPE= String.Format("AGTSVCSTARTUPTYPE=\"{0}\"", value); }
        }
        /// <summary>
        /// Startup type for Integration Services.
        /// Ex. ISSVCSTARTUPTYPE="Automatic"
        /// </summary>
        private string _ISSVCSTARTUPTYPE = string.Empty;
        public string ISSVCSTARTUPTYPE
        {
            get { return _ISSVCSTARTUPTYPE; }
            set { _ISSVCSTARTUPTYPE = String.Format("ISSVCSTARTUPTYPE=\"{0}\"", value); }
        }
        /// <summary>
        /// Account for Integration Services: Domain\User or system account. 
        /// Ex. ISSVCACCOUNT="NT AUTHORITY\NetworkService"
        /// </summary>
        private string _ISSVCACCOUNT = string.Empty;
        public string ISSVCACCOUNT
        {
            get { return _ISSVCACCOUNT; }
            set { _ISSVCACCOUNT = String.Format("ISSVCACCOUNT=\"{0}\"", value); }
        }
        /// <summary>
        /// Controls the service startup type setting after the service has been created.
        /// Ex. ASSVCSTARTUPTYPE="Automatic"
        /// </summary>
        private string _ASSVCSTARTUPTYPE = string.Empty;
        public string ASSVCSTARTUPTYPE
        {
            get { return _ASSVCSTARTUPTYPE; }
            set { _ASSVCSTARTUPTYPE = String.Format("ASSVCSTARTUPTYPE=\"{0}\"", value); }
        }
        /// <summary>
        /// The collation to be used by Analysis Services. 
        /// Ex. ASCOLLATION="Latin1_General_CI_AS"
        /// </summary>
        private string _ASCOLLATION = string.Empty;
        public string ASCOLLATION
        {
            get { return _ASCOLLATION; }
            set { _ASCOLLATION = String.Format("ASCOLLATION=\"{0}\"", value); }
        }
        /// <summary>
        ///  location for the Analysis Services data files. 
        /// Ex. ASDATADIR="Data"
        /// </summary>
        private string _ASDATADIR = string.Empty;
        public string ASDATADIR
        {
            get { return _ASDATADIR; }
            set { _ASDATADIR = String.Format("ASDATADIR=\"{0}\"", value); }
        }
        /// <summary>
        ///  The location for the Analysis Services log files.
        /// Ex. ASLOGDIR="Log"
        /// </summary>
        private string _ASLOGDIR = string.Empty;
        public string ASLOGDIR
        {
            get { return _ASLOGDIR; }
            set { _ASLOGDIR = String.Format("ASLOGDIR=\"{0}\"", value); }
        }
        /// <summary>
        ///  The location for the Analysis Services backup files. 
        /// Ex. ASBACKUPDIR="Backup"
        /// </summary>
        private string _ASBACKUPDIR = string.Empty;
        public string ASBACKUPDIR
        {
            get { return _ASBACKUPDIR; }
            set { _ASBACKUPDIR = String.Format("ASBACKUPDIR=\"{0}\"", value); }
        }
        /// <summary>
        ///  The location for the Analysis Services temporary files. 
        /// Ex. ASTEMPDIR="Temp"
        /// </summary>
        private string _ASTEMPDIR = string.Empty;
        public string ASTEMPDIR
        {
            get { return _ASTEMPDIR; }
            set { _ASTEMPDIR = String.Format("ASTEMPDIR=\"{0}\"", value); }
        }
        /// <summary>
        ///  The location for the Analysis Services configuration files.
        /// Ex. ASCONFIGDIR="Config"
        /// </summary>
        private string _ASCONFIGDIR = string.Empty;
        public string ASCONFIGDIR
        {
            get { return _ASCONFIGDIR; }
            set { _ASCONFIGDIR = String.Format("ASCONFIGDIR=\"{0}\"", value); }
        }
        /// <summary>
        ///  Specifies whether or not the MSOLAP provider is allowed to run in process. 
        /// Ex. ASPROVIDERMSOLAP="1"
        /// </summary>
        private string _ASPROVIDERMSOLAP = string.Empty;
        public string ASPROVIDERMSOLAP
        {
            get { return _ASPROVIDERMSOLAP; }
            set { _ASPROVIDERMSOLAP = String.Format("ASPROVIDERMSOLAP=\"{0}\"", value); }
        }
        /// <summary>
        ///  Startup type for the SQL Server service.
        /// Ex. SQLSVCSTARTUPTYPE="Automatic"
        /// </summary>
        private string _SQLSVCSTARTUPTYPE = string.Empty;
        public string SQLSVCSTARTUPTYPE
        {
            get { return _SQLSVCSTARTUPTYPE; }
            set { _SQLSVCSTARTUPTYPE = String.Format("SQLSVCSTARTUPTYPE=\"{0}\"", value); }
        }
        /// <summary>
        ///  Level to enable FILESTREAM feature at (0, 1, 2 or 3).
        /// Ex. FILESTREAMLEVEL="0"
        /// </summary>
        private string _FILESTREAMLEVEL = string.Empty;
        public string FILESTREAMLEVEL
        {
            get { return _FILESTREAMLEVEL; }
            set { _FILESTREAMLEVEL = String.Format("FILESTREAMLEVEL=\"{0}\"", value); }
        }
        /// <summary>
        /// Set to "1" to enable RANU for SQL Server Express. 
        /// Ex. ENABLERANU="True"
        /// </summary>
        private string _ENABLERANU = string.Empty;
        public bool ENABLERANU
        {
            get
            {
                string Data = _ENABLERANU.Replace("ENABLERANU=", "");
                Data = Data.Replace("\"", "");
                bool returnMe = Convert.ToBoolean(Data);
                return returnMe;
            }
            set
            { _ENABLERANU = String.Format("ENABLERANU=\"{0}\"", value); }
        }
        /// <summary>
        ///  Specifies a Windows collation or an SQL collation to use for the Database Engine. 
        /// Ex. SQLCOLLATION="Arabic_CI_AS"
        /// </summary>
        private string _SQLCOLLATION = string.Empty;
        public string SQLCOLLATION
        {
            get { return _SQLCOLLATION; }
            set { _SQLCOLLATION = String.Format("SQLCOLLATION=\"{0}\"", value); }
        }
        /// <summary>
        ///  Account for SQL Server service: Domain\User or system account. 
        /// Ex. SQLSVCACCOUNT="NT AUTHORITY\SYSTEM"
        /// </summary>
        private string _SQLSVCACCOUNT = string.Empty;
        public string SQLSVCACCOUNT
        {
            get { return _SQLSVCACCOUNT; }
            set { _SQLSVCACCOUNT = String.Format("SQLSVCACCOUNT=\"{0}\"", value); }
        }
        /// <summary>
        ///  Windows account(s) to provision as SQL Server system administrators.
        /// Ex. SQLSYSADMINACCOUNTS="Builtin\Administrators"
        /// </summary>
        private string _SQLSYSADMINACCOUNTS = string.Empty;
        public string SQLSYSADMINACCOUNTS
        {
            get { return _SQLSYSADMINACCOUNTS; }
            set { _SQLSYSADMINACCOUNTS = String.Format("SQLSYSADMINACCOUNTS=\"{0}\"", value); }
        }
        /// <summary>
        ///  The default is Windows Authentication. Use "SQL" for Mixed Mode Authentication. 
        /// Ex. SECURITYMODE="SQL"
        /// </summary>
        private string _SECURITYMODE = string.Empty;
        public string SECURITYMODE
        {
            get { return _SECURITYMODE; }
            set { _SECURITYMODE = String.Format("SECURITYMODE=\"{0}\"", value); }
        }
        /// <summary>
        /// Provision current user as a Database Engine system administrator for SQL Server 2008 Express. 
        /// Ex. ADDCURRENTUSERASSQLADMIN="True"
        /// </summary>
        private string _ADDCURRENTUSERASSQLADMIN = string.Empty;
        public bool ADDCURRENTUSERASSQLADMIN
        {
            get
            {
                string Data = _ADDCURRENTUSERASSQLADMIN.Replace("ADDCURRENTUSERASSQLADMIN=", "");
                Data = Data.Replace("\"", "");
                bool returnMe = Convert.ToBoolean(Data);
                return returnMe;
            }
            set
            { _ADDCURRENTUSERASSQLADMIN = String.Format("ADDCURRENTUSERASSQLADMIN=\"{0}\"", value); }
        }
        /// <summary>
        ///  Specify 0 to disable or 1 to enable the TCP/IP protocol. 
        /// Ex. TCPENABLED="1"
        /// </summary>
        private string _TCPENABLED = string.Empty;
        public string TCPENABLED
        {
            get { return _TCPENABLED; }
            set { _TCPENABLED = String.Format("TCPENABLED=\"{0}\"", value); }
        }
        /// <summary>
        ///  Specify 0 to disable or 1 to enable the Named Pipes protocol.  
        /// Ex. NPENABLED="0"
        /// </summary>
        private string _NPENABLED = string.Empty;
        public string NPENABLED
        {
            get { return _NPENABLED; }
            set { _NPENABLED = String.Format("NPENABLED=\"{0}\"", value); }
        }
        /// <summary>
        ///  Startup type for Browser Service.  
        /// Ex. BROWSERSVCSTARTUPTYPE="Automatic"
        /// </summary>
        private string _BROWSERSVCSTARTUPTYPE = string.Empty;
        public string BROWSERSVCSTARTUPTYPE
        {
            get { return _BROWSERSVCSTARTUPTYPE; }
            set { _BROWSERSVCSTARTUPTYPE = String.Format("BROWSERSVCSTARTUPTYPE=\"{0}\"", value); }
        }
        /// <summary>
        ///  Specifies which account the report server NT service should execute under.  When omitted or when the value is empty string, the default built-in account for the current operating system.
        ///The username part of RSSVCACCOUNT is a maximum of 20 characters long and
        ///The domain part of RSSVCACCOUNT is a maximum of 254 characters long.  
        /// Ex. RSSVCACCOUNT="NT AUTHORITY\SYSTEM"
        /// </summary>
        private string _RSSVCACCOUNT = string.Empty;
        public string RSSVCACCOUNT
        {
            get { return _RSSVCACCOUNT; }
            set { _RSSVCACCOUNT = String.Format("RSSVCACCOUNT=\"{0}\"", value); }
        }
        /// <summary>
        ///  Specifies how the startup mode of the report server NT service.  When
        ///Manual - Service startup is manual mode (default).
        ///Automatic - Service startup is automatic mode.
        ///Disabled - Service is disabled
        /// Ex. RSSVCSTARTUPTYPE="Automatic"
        private string _RSSVCSTARTUPTYPE = string.Empty;
        public string RSSVCSTARTUPTYPE
        {
            get { return _RSSVCSTARTUPTYPE; }
            set { _RSSVCSTARTUPTYPE = String.Format("RSSVCSTARTUPTYPE=\"{0}\"", value); }
        }
        /// <summary>
        ///  Specifies which mode report server is installed in.
        ///Default value: “FilesOnly” 
        /// Ex. RSINSTALLMODE="DefaultNativeMode"
        private string _RSINSTALLMODE = string.Empty;
        public string RSINSTALLMODE
        {
            get { return _RSINSTALLMODE; }
            set { _RSINSTALLMODE = String.Format("RSINSTALLMODE=\"{0}\"", value); }
        }

        #endregion
        #region -   Functions   -
        public ConfigurationFile()
        {
            INSTANCEID = "SQLEXPRESS";
            ACTION = "Install";
            HELP = true;
            INDICATEPROGRESS = false;
            QUIET = true;
            QUIETSIMPLE = false;
            X86 = false;
            MEDIASOURCE = @"C:\";
            ERRORREPORTING = false;
            INSTANCEDIR = @"C:\Program Files\";
            SQMREPORTING = false;
            INSTANCENAME = "SQLEXPRESS";
            AGTSVCACCOUNT = @"NT AUTHORITY\NETWORK SERVICE";
            AGTSVCSTARTUPTYPE = "Disabled";
            ISSVCSTARTUPTYPE = "Automatic";
            ISSVCACCOUNT = @"NT AUTHORITY\NetworkService";
            ASSVCSTARTUPTYPE = "Automatic";
            ASCOLLATION = "Latin1_General_CI_AS";
            ASDATADIR = "Data";
            ASLOGDIR = "Log";
            ASBACKUPDIR = "Backup";
            ASTEMPDIR = "Temp";
            ASCONFIGDIR = "Config";
            ASPROVIDERMSOLAP = "1";
            SQLSVCSTARTUPTYPE = "Automatic";
            FILESTREAMLEVEL = "0";
            ENABLERANU = true;
            SQLCOLLATION = "Arabic_CI_AS";
            SQLSVCACCOUNT = @"NT AUTHORITY\SYSTEM";
            SQLSYSADMINACCOUNTS = @"Builtin\Administrators";
            SECURITYMODE = "SQL";
            ADDCURRENTUSERASSQLADMIN = true;
            TCPENABLED = "1";
            NPENABLED = "0";
            BROWSERSVCSTARTUPTYPE = "Automatic";
            RSSVCACCOUNT = @"NT AUTHORITY\SYSTEM";
            RSSVCSTARTUPTYPE = "Automatic";
            RSINSTALLMODE = "DefaultNativeMode";
        }
        public void CreateConfigFile(string FolderPath)
        {
            StreamWriter sw = new StreamWriter(FolderPath + cfgFileName);
            sw.WriteLine(INSTANCEID);
            sw.WriteLine(ACTION);
            sw.WriteLine(HELP);
            sw.WriteLine(INDICATEPROGRESS);
            sw.WriteLine(QUIET);
            sw.WriteLine(QUIETSIMPLE);
            sw.WriteLine(X86);
            sw.WriteLine(MEDIASOURCE);
            sw.WriteLine(ERRORREPORTING);
            sw.WriteLine(INSTANCEDIR);
            sw.WriteLine(SQMREPORTING);
            sw.WriteLine(INSTANCENAME);
            sw.WriteLine(AGTSVCACCOUNT);
            sw.WriteLine(AGTSVCSTARTUPTYPE);
            sw.WriteLine(ISSVCSTARTUPTYPE);
            sw.WriteLine(ISSVCACCOUNT);
            sw.WriteLine(ASSVCSTARTUPTYPE);
            sw.WriteLine(ASCOLLATION);
            sw.WriteLine(ASDATADIR);
            sw.WriteLine(ASLOGDIR);
            sw.WriteLine(ASBACKUPDIR);
            sw.WriteLine(ASTEMPDIR);
            sw.WriteLine(ASCONFIGDIR);
            sw.WriteLine(ASPROVIDERMSOLAP);
            sw.WriteLine(SQLSVCSTARTUPTYPE);
            sw.WriteLine(FILESTREAMLEVEL);
            sw.WriteLine(ENABLERANU);
            sw.WriteLine(SQLCOLLATION);
            sw.WriteLine(SQLSVCACCOUNT);
            sw.WriteLine(SQLSYSADMINACCOUNTS);
            sw.WriteLine(SECURITYMODE);
            sw.WriteLine(ADDCURRENTUSERASSQLADMIN);
            sw.WriteLine(TCPENABLED);
            sw.WriteLine(NPENABLED);
            sw.WriteLine(BROWSERSVCSTARTUPTYPE);
            sw.WriteLine(RSSVCACCOUNT);
            sw.WriteLine(RSSVCSTARTUPTYPE);
            sw.WriteLine(RSINSTALLMODE);
            sw.Flush();
            sw.Close();
            sw.Dispose();
            sw = null;
        }
        #endregion
    }
}
