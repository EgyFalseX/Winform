using System;
using System.Xml.Serialization;  // Does XML serializing for a class.
using System.Drawing;            // Required for storing a Bitmap.
using System.IO;			     // Required for using Memory stream objects.

namespace FXFW
{
    // Mark class as serializable.
    [Serializable]
    public class Settings
    {
        #region -  Properties  -
        public enum DefaultReportServerName
        {
            FalseXRS2011
        }
        public Global[] Globals = new Global[3];
        public struct Global
        {
            [XmlAttribute]
            public GlobalValue Name;
            [XmlText]
            public string GlobalValue;
        }
        public enum GlobalValue
        {
            ReportServer,
            ReportServerPath,
            CollapsedHeight
        }
        public ReportServer[] ReportServers = new ReportServer[1];
        public struct ReportServer
        {
            [XmlAttribute]
            public DefaultReportServerName Name;
            [XmlAttribute]
            public string Protocol;
            [XmlAttribute]
            public string Host;
            [XmlAttribute]
            public string Path;
            [XmlAttribute]
            public string Timeout;
        }
        public DataSource[] DataSources;
        public struct DataSource
        {
            [XmlAttribute]
            public string Name;
            [XmlAttribute]
            public bool Publish;
            [XmlAttribute]
            public bool Overwrite;
            [XmlAttribute]
            public string TargetFolder;
            [XmlAttribute]
            public DefaultReportServerName ReportServer;
            [XmlElement]
            public string ConnectionString;
            [XmlElement]
            public CredentialRetrievalValues CredentialRetrieval;
            [XmlElement]
            public bool WindowsCredentials;
            [XmlElement]
            public string UserName;
            [XmlElement]
            public string Password;
        }
        public enum CredentialRetrievalValues
        {
            Store
        }
        public ReportGroup[] Reports;
        public struct ReportGroup
        {
            [XmlAttribute]
            public string Name;
            [XmlAttribute]
            public string DataSourceName;
            [XmlAttribute]
            public string TargetFolder;
            [XmlAttribute]
            public DefaultReportServerName ReportServer;
            [XmlAttribute]
            public int CacheTime;
            [XmlElement]
            public Report[] Report;
        }
        public struct Report
        {
            [XmlAttribute]
            public string Name;
            [XmlElement("FilePath")]
            public string FilePathValue;
        }
        
        #endregion
        #region -   Functions   -
        public Settings()
        {
            ReportServers[0].Name = DefaultReportServerName.FalseXRS2011;
            ReportServers[0].Protocol = "http";
            ReportServers[0].Host = "${ReportServer}";
            ReportServers[0].Path = "${ReportServerPath}";
            ReportServers[0].Timeout = "30";
        }
        public void GlobalSettings(string ReportServer, string ReportServerPath)
        {
            Globals[0].Name = Settings.GlobalValue.ReportServer;
            Globals[0].GlobalValue = ReportServer;
            Globals[1].Name = Settings.GlobalValue.ReportServerPath;
            Globals[1].GlobalValue = ReportServerPath;
            Globals[2].Name = Settings.GlobalValue.CollapsedHeight;
            Globals[2].GlobalValue = "0.5in";
        }
        public void CreateDataSource(string Name, bool Publish, bool Overwrite, string TargetFolder, string ConnectionString, CredentialRetrievalValues CredentialRetrieval, bool WindowsCredentials, string UserName, string Password)
        {
            if (DataSources == null)
                Array.Resize<DataSource>(ref DataSources, 1);
            else
                Array.Resize<DataSource>(ref DataSources, DataSources.Length + 1);
            DataSources[DataSources.Length - 1].Name = Name;
            DataSources[DataSources.Length - 1].Publish = Publish;
            DataSources[DataSources.Length - 1].Overwrite = Overwrite;
            DataSources[DataSources.Length - 1].TargetFolder = TargetFolder;
            DataSources[DataSources.Length - 1].ReportServer = DefaultReportServerName.FalseXRS2011;
            DataSources[DataSources.Length - 1].ConnectionString = ConnectionString;
            DataSources[DataSources.Length - 1].CredentialRetrieval = CredentialRetrieval;
            DataSources[DataSources.Length - 1].WindowsCredentials = WindowsCredentials;
            DataSources[DataSources.Length - 1].UserName = UserName;
            DataSources[DataSources.Length - 1].Password = Password;
        }
        public void CreateReport(string GroupName, string DataSourceName, string TargetFolder, int CacheTime, Report[] MyReports)
        {
            if (Reports == null)
                Array.Resize<ReportGroup>(ref Reports, 1);
            else
                Array.Resize<ReportGroup>(ref Reports, Reports.Length + 1);
            Reports[Reports.Length - 1].Name = GroupName;
            Reports[Reports.Length - 1].DataSourceName = DataSourceName;
            Reports[Reports.Length - 1].TargetFolder = TargetFolder;
            Reports[Reports.Length - 1].ReportServer = DefaultReportServerName.FalseXRS2011;
            Reports[Reports.Length - 1].CacheTime = CacheTime;
            //foreach (Report item in MyReports)
            //{
            //    if (Reports[Reports.Length - 1].Report == null)
            //        Array.Resize<Report>(ref Reports[Reports.Length - 1].Report, 1);
            //    else
            //        Array.Resize<Report>(ref Reports[Reports.Length - 1].Report, Reports[Reports.Length - 1].Report.Length + 1);
            //    if (item.FilePathValue.StartsWith(@"\"))
            //        Reports[Reports.Length - 1].Report[Reports[Reports.Length - 1].Report.Length - 1].FilePathValue = item.FilePathValue;
            //    else
            //        Reports[Reports.Length - 1].Report[Reports[Reports.Length - 1].Report.Length - 1].FilePathValue = @"\" + item.FilePathValue;
            //    Reports[Reports.Length - 1].Report[Reports[Reports.Length - 1].Report.Length - 1].Name = item.Name;
            //}
            Reports[Reports.Length - 1].Report = MyReports;
        }

        #endregion
    }
    public class SerializeThis
    {
        public static void Serialize(Settings rptSettings, string fileName)
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(Settings));
                TextWriter tw = File.CreateText(fileName);
                xs.Serialize(tw, rptSettings);
                tw.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static Settings Deserialize(string fileName)
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(Settings));
                TextReader tr = File.OpenText(fileName);
                Settings xcd = (Settings)xs.Deserialize(tr);
                tr.Close();
                return xcd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}
