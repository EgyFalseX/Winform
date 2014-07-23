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
using NestleICSales.Forms.Main;
using System.Data.OleDb;
using DevExpress.Xpo;

namespace NestleICSales.Managers
{
    public class DataManager
    {
        #region -   Variables   -
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(DataManager));
        public static DataManager defaultInstance;
        public static int ConnectionTimeout = 0;
        public static int SHRINKSIZE = 10;

        DataSources.dsData dsData;
        DataSources.dsDataTableAdapters.AppRoleTableAdapter adpAppRole;
        DataSources.dsDataTableAdapters.QueriesTableAdapter AdpQry;
        DataSources.dsQryTableAdapters.QueriesTableAdapter AdpQQry;
        DataSources.dsDataTableAdapters.RoutesTableAdapter adpRoutes;
        DataSources.dsDataTableAdapters.CustomerTableAdapter adpCustomers;
        DataSources.dsDataTableAdapters.ProductTableAdapter adpProducts;
        public DataSources.dsDataTableAdapters.RouteCustomerTableAdapter adpRouteCustomer;

        public DataSources.dsDataTableAdapters.CustHierLevel3TableAdapter adpCusLv3;
        public DataSources.dsDataTableAdapters.CustHierLevel4TableAdapter adpCusLv4;
        public DataSources.dsDataTableAdapters.CustHierLevel5TableAdapter adpCusLv5;
        public DataSources.dsDataTableAdapters.CustHierLevel6TableAdapter adpCusLv6;
        public DataSources.dsDataTableAdapters.DistributionChannelTableAdapter adpDisChannel;
        public List<Utilities.Types.ReportsFormation> ExcelFileFormation;
        public DayOfWeek[] WeekEndDays = new DayOfWeek[1] { DayOfWeek.Friday };

        //public static XPServerCollectionSource XPSCSCustomer;
        
        //DataSources.dsDataCenterTableAdapters.LogsTableAdapter adpLogs;
        #endregion
        #region -   Properties   -
        public DateTime GetServerDatetime
        {
            get 
            {
                return (DateTime)AdpQQry.ScalarQuerySERVERDATETIME();
            }
        }
        public static int UnknownCityId
        {
            get { return 999999999; }
        }

        #region -   Unknown Codes   -
        #endregion

        #region -   Cashed Tables   -
        public DataSources.dsData.CustomerDataTable Customers
        {
            get { return dsData.Customer; }
        }
        public DataSources.dsData.RoutesDataTable Routes
        {
            get { return dsData.Routes; }
        }
        public DataSources.dsData.ProductDataTable Products
        {
            get { return dsData.Product; }
        }

        #endregion
        
        #endregion
        #region -   Functions   -
        public DataManager()
        {
            dsData = new DataSources.dsData();
            adpAppRole = new DataSources.dsDataTableAdapters.AppRoleTableAdapter();
            AdpQry = new DataSources.dsDataTableAdapters.QueriesTableAdapter();
            AdpQQry = new DataSources.dsQryTableAdapters.QueriesTableAdapter();
            adpRoutes = new DataSources.dsDataTableAdapters.RoutesTableAdapter();
            adpCustomers = new DataSources.dsDataTableAdapters.CustomerTableAdapter();
            adpProducts = new DataSources.dsDataTableAdapters.ProductTableAdapter();
            adpRouteCustomer = new DataSources.dsDataTableAdapters.RouteCustomerTableAdapter();

            adpCusLv3 = new DataSources.dsDataTableAdapters.CustHierLevel3TableAdapter();
            adpCusLv4 = new DataSources.dsDataTableAdapters.CustHierLevel4TableAdapter();
            adpCusLv5 = new DataSources.dsDataTableAdapters.CustHierLevel5TableAdapter();
            adpCusLv6 = new DataSources.dsDataTableAdapters.CustHierLevel6TableAdapter();
            adpDisChannel = new DataSources.dsDataTableAdapters.DistributionChannelTableAdapter();

            ExcelFileFormation = LoadExcelFileFormation();// load formation about how to load xml file
            //adpLogs = new DataSources.dsDataCenterTableAdapters.LogsTableAdapter();
        }
        public static bool Init()
        {
            try
            {
                defaultInstance = new DataManager();
                if (!defaultInstance.CreateDefaultData())
                    return false;
                if (SplashScreenManager.Default.IsSplashFormVisible)
                    SplashScreenManager.Default.SendCommand(SplashScreenFrm.SplashScreenCommand.SetState, "Loading Routes ...");
                //defaultInstance.LoadAllRoute();
                if (SplashScreenManager.Default.IsSplashFormVisible)
                    SplashScreenManager.Default.SendCommand(SplashScreenFrm.SplashScreenCommand.SetState, "Loading Products ...");
                //defaultInstance.LoadAlladpProducts();
                if (SplashScreenManager.Default.IsSplashFormVisible)
                    SplashScreenManager.Default.SendCommand(SplashScreenFrm.SplashScreenCommand.SetState, "Loading Customers ...");
                //defaultInstance.LoadAllCustomers();

                //UnitOfWork UOW = new UnitOfWork() { IsObjectModifiedOnNonPersistentPropertyChange = null, TrackPropertiesModifications = false };
                //DevExpress.Xpo.Metadata.XPClassInfo ClsInfo = UOW.GetClassInfo(typeof(NestleICSales.DataSources.dsData.CustomerDataTable));
                //XPSCSCustomer = new XPServerCollectionSource(UOW, ClsInfo);
                //XPSCSCustomer.AllowEdit = true;
                //XPSCSCustomer.AllowNew = true;
                //XPSCSCustomer.AllowRemove = true;

                Logger.Debug("Init ... Done");
                return true;
            }
            catch (Exception ex)
            {
                Logger.Error("Init ... Error - " + ex.Message, ex);
                return false;
            }
        }
        public static void SetAllCommandTimeouts(object adapter, int timeout)
        {
            var commands = adapter.GetType().InvokeMember("CommandCollection",
                    System.Reflection.BindingFlags.GetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic,
                    null, adapter, new object[0]);
            var sqlCommand = (System.Data.SqlClient.SqlCommand[])commands;
            foreach (var cmd in sqlCommand)
            {
                cmd.CommandTimeout = timeout;
            }
        }
        public static string GenerateDatabaseScript(string DatabasePath)
        {
            return string.Empty;//string.Format(Properties.Settings.Default.CreateDatabaseScript.Replace("FalseX2013", DatabasePath));
        }
        public static DataTable LoadExcelFile(string strFile, string sheetName, string ColumnsNames)
        {
            DataTable dt = new DataTable();
            try
            {
                string strConnectionString = "";
                if (strFile.Trim().ToLower().EndsWith(".xlsx"))
                    strConnectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1\";", strFile);
                else if (strFile.Trim().ToLower().EndsWith(".xls"))
                    strConnectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=1\";", strFile);
                OleDbConnection con = new OleDbConnection(strConnectionString);
                string query = string.Format("SELECT {0} FROM [{1}$]", ColumnsNames, sheetName);
                OleDbDataAdapter adp = new OleDbDataAdapter(query, con);
                adp.Fill(dt);
            }
            catch (Exception ex)
            {
                MsgDlg.Show("Load Excel File Failed - " + ex.Message, NestleICSales.Utilities.Types.MessageType.Error, ex);
            }
            return dt;
        }
        public static DataTable LoadExcelFile(string strFile, int sheetIndex, string ColumnsNames)
        {
            DataTable dt = new DataTable();
            try
            {
                string strConnectionString = "";
                if (strFile.Trim().ToLower().EndsWith(".xlsx"))
                    strConnectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1\";", strFile);
                else if (strFile.Trim().ToLower().EndsWith(".xls"))
                    strConnectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=1\";", strFile);
                OleDbConnection con = new OleDbConnection(strConnectionString);
                con.Open();
                DataTable dtSchema = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                con.Close();
                if (dtSchema == null)
                    return dt;
                string sheetName = dtSchema.Rows[sheetIndex]["TABLE_NAME"].ToString();
                string query = string.Format("SELECT {0} FROM [{1}]", ColumnsNames, sheetName);
                OleDbDataAdapter adp = new OleDbDataAdapter(query, con);
                adp.Fill(dt);
            }
            catch (Exception ex)
            {
                MsgDlg.Show("Load Excel File Failed - " + ex.Message, NestleICSales.Utilities.Types.MessageType.Error, ex);
            }
            return dt;
        }
        public static int GetCityId(string CityName)
        {
            int CityId = Customer.UnknownCityId;
            switch (CityName.Trim())
            {
                //case "El Zarka for Food":
                //case "Ezbet El Borg":
                //case "Farrag for Trading":
                //case "jibouti":
                //case "Karam Ghobril Mekhail":
                //case "Khaled Al Khulaidi":
                //case "Lausanne Company":
                //case "Magdy Nagib Rizk":
                //case "Mahmoud Abdel Moaez Shebl":
                //case "Mohamed Sayed Morsi":
                //case "Movenpick":
                //case "Nasser El Harthy Company":
                //case "One Time Customer":
                //case "Sakr Group":
                //case "Samir Abou Agour":
                //case "Staff Sales":
                //case "Tenango del Valle":
                //case "Transind Company WLL":
                //case "Vitoria":
                //    CityId = DataManager.defaultInstance.UnknownCityId;
                //    break;
                case "Giza":
                case "Giza Center":
                    CityId = 3;
                    break;
                case "6th Of October":
                case "October":
                    CityId = 24;
                    break;
                case "Abo Zaabel":
                case "Abo Zabal":
                case "Abou Zabal":
                    CityId = 42;
                    break;
                case "Adel Abdel Wahab":
                    CityId = 43;
                    break;
                case "Adnan Abdel Hafiz":
                    CityId = 44;
                    break;
                case "Aga":
                    CityId = 45;
                    break;
                case "Al Ashrafiya":
                    CityId = 46;
                    break;
                case "Al Risha Al Dahabia Co":
                    CityId = 47;
                    break;
                case "Ala Baraket Allah":
                    CityId = 48;
                    break;
                case "Alexabndria":
                case "Alexadria":
                case "Alexandria":
                case "Alexndria":
                case "الأسكندرية":
                    CityId = 2;
                    break;
                case "Alsfeld":
                    CityId = 49;
                    break;
                case "Aram & Hagop Company":
                    CityId = 50;
                    break;
                case "Armant":
                    CityId = 51;
                    break;
                case "Asiout":
                case "Assiout":
                case "Assiut.":
                case "Assoiut":
                    CityId = 11;
                    break;
                case "Aswan":
                    CityId = 15;
                    break;
                case "Bahteem":
                    CityId = 52;
                    break;
                case "Banha":
                    CityId = 25;
                    break;
                case "Bani Souwaif":
                case "Bani Swaif":
                    CityId = 19;
                    break;
                case "Barageel":
                    CityId = 53;
                    break;
                case "Bassion":
                case "Basyoun":
                    CityId = 54;
                    break;
                case "Behaira":
                case "Beheira":
                case "Behira":
                case "Bhira":
                    CityId = 55;
                    break;
                case "Belbais":
                case "Belbeis":
                    CityId = 30;
                    break;
                case "Belkas":
                    CityId = 56;
                    break;
                case "Cairo":
                case "Gairo":
                case "Royal Pharma Cairo":
                case "القاهرة":
                case "Cairo NB":
                    CityId = 1;
                    break;
                case "Cairo E":
                case "Cairo East":
                    CityId = 57;
                    break;
                case "Cairo North":
                case "Cairo N":
                    CityId = 58;
                    break;
                case "Cairo W":
                case "Cairo West":
                    CityId = 59;
                    break;
                case "Com Ombo":
                case "Kom Ombo":
                case "Kom Ompo":
                    CityId = 60;
                    break;
                case "Dahab":
                    CityId = 61;
                    break;
                case "Dakahlia":
                    CityId = 62;
                    break;
                case "Damietta":
                case "Domait":
                case "Domiat":
                case "Domiatt":
                    CityId = 16;
                    break;
                case "Dekerns":
                case "Dekrnes":
                    CityId = 63;
                    break;
                case "Delta East":
                    CityId = 64;
                    break;
                case "Domiat El Gededa":
                case "Domiat El Gedida":
                    CityId = 65;
                    break;
                case "Edfo":
                case "Idfo":
                    CityId = 32;
                    break;
                case "Ein El Sokhna":
                case "El Ein El Sokhna":
                    CityId = 66;
                    break;
                case "Ek Khanka":
                case "El Khanaka":
                case "El Khanka":
                case "Khanka":
                    CityId = 67;
                    break;
                case "El Abadia":
                    CityId = 68;
                    break;
                case "El Asher":
                case "El Asher Of Ramadan":
                    CityId = 29;
                    break;
                case "El Bayadeya":
                    CityId = 69;
                    break;
                case "El Ethad for Commerce":
                    CityId = 70;
                    break;
                case "El Gezour":
                    CityId = 71;
                    break;
                case "El Kahera El Gededa":
                    CityId = 72;
                    break;
                case "El Kalag":
                case "El Kalg":
                    CityId = 73;
                    break;
                case "El Kanata":
                case "El Kanater":
                case "El Kanater El Kairia":
                case "El Kanater El Khairia":
                case "El Kanater El Khairya":
                case "El Khanater":
                    CityId = 74;
                    break;
                case "El Khasos":
                case "El Khousos":
                case "El Khousous":
                case "Khosous":
                    CityId = 75;
                    break;
                case "El Maadi":
                    CityId = 76;
                    break;
                case "El Mahala":
                case "El Mahala El Kobra":
                case "El Mahla":
                case "Mahala":
                    CityId = 9;
                    break;
                case "El Mansoura":
                case "Manosura":
                case "Manoura":
                case "Mansoua":
                case "Mansoura":
                    CityId = 8;
                    break;
                case "Gharbeya":
                case "Gharbia":
                    CityId = 77;
                    break;
                case "El Marg":
                    CityId = 78;
                    break;
                case "El Mataria":
                    CityId = 41;
                    break;
                case "El Menia":
                case "El Menya":
                case "Menia":
                    CityId = 18;
                    break;
                case "El Monofiya":
                case "Ibn Hameedo - Menofeya":
                case "Menofia":
                case "Monofia":
                case "Monofiya":
                    CityId = 79;
                    break;
                case "El Mustafa for Trading":
                    CityId = 80;
                    break;
                case "El Nahda":
                    CityId = 81;
                    break;
                case "El Salam":
                case "El Salam City":
                    CityId = 82;
                    break;
                case "El Suez":
                case "Suez":
                    CityId = 6;
                    break;
                case "El Tour":
                    CityId = 83;
                    break;
                case "El Wady El Geded":
                case "El Wady El Gedid":
                case "El Wday El Geded":
                case "ElWady ElGedid":
                    CityId = 84;
                    break;
                case "El Zakazik":
                    CityId = 14;
                    break;
                case "Gamasa":
                case "Gamassa":
                    CityId = 85;
                    break;
                case "Essna":
                    CityId = 86;
                    break;
                case "Helwan":
                    CityId = 87;
                    break;
                case "Hergada":
                case "Hurghada":
                case "Royal Pharma Hurghada":
                    CityId = 22;
                    break;
                case "Ismailia":
                    CityId = 12;
                    break;
                case "Kafr El Dawar":
                    CityId = 38;
                    break;
                case "Kafr El Sheikh":
                    CityId = 26;
                    break;
                case "South Sinai":
                    CityId = 88;
                    break;
                case "Kafr El Zayat":
                    CityId = 89;
                    break;
                case "Kafr Saad":
                    CityId = 90;
                    break;
                case "Kailoub":
                case "Kalioub":
                    CityId = 36;
                    break;
                case "Kalioub El Balad":
                    CityId = 91;
                    break;
                case "Kalioubeya":
                case "Kalioubia":
                case "Kalioubya":
                case "Kalyobia":
                case "Kalyobiya":
                    CityId = 92;
                    break;
                case "Korashia":
                    CityId = 93;
                    break;
                case "Luxor":
                    CityId = 7;
                    break;
                case "Malawy":
                    CityId = 28;
                    break;
                case "Manzala":
                    CityId = 94;
                    break;
                case "Marsa Matrouh":
                case "Matrouh":
                    CityId = 31;
                    break;
                case "Mit Ghamr":
                    CityId = 33;
                    break;
                case "Monshaat El Kanater":
                    CityId = 95;
                    break;
                case "Nagaa Hamady":
                case "Nagaa Hammady":
                case "Nagea Hamady":
                    CityId = 96;
                    break;
                case "New Domiat":
                    CityId = 97;
                    break;
                case "New Valley":
                case "New Vallley":
                case "New Vally":
                    CityId = 98;
                    break;
                case "Port  Said":
                case "Port Said":
                case "Port Saiid":
                case "Port Said for Trading":
                    CityId = 5;
                    break;
                case "Qena":
                case "Quena":
                    CityId = 20;
                    break;
                case "Raas El Bar":
                    CityId = 99;
                    break;
                case "Red Sea":
                case "The Red Sea":
                    CityId = 100;
                    break;
                case "Road El-Farag":
                    CityId = 101;
                    break;
                case "Royal Pharma Sharm":
                case "Sharm El Shaikh":
                case "Sharm El Sheikh":
                case "Sharm El Shiekh":
                case "Shram El Sheikh":
                    CityId = 102;
                    break;
                case "Samanod":
                    CityId = 103;
                    break;
                case "Shabeen El Kanater":
                case "Shabin El Kanater":
                case "Shbeen El Kanater":
                case "Shbin El Kanater":
                case "Shebeen El Kanater":
                case "Sheben El Kanater":
                case "Shebien El Kanater":
                case "Shebin El Kanater":
                case "Shiben El Kanater":
                    CityId = 104;
                    break;
                case "Sharkaia":
                case "Sharkia":
                case "Sherbin":
                    CityId = 105;
                    break;
                case "Shebeen":
                case "Shebin":
                    CityId = 106;
                    break;
                case "Shobra El Khaima":
                case "Shoubra El Khaima":
                case "Shoubra El Khaima Than":
                case "Shoubra El Khamia":
                case "Shoubra El Kheima":
                case "Shoubra El Kheima Than":
                case "Shoubra El Khiama":
                case "Shoubra El Khiema":
                case "Shoubra El Khima":
                case "Shoubra Elkhima":
                    CityId = 4;
                    break;
                case "Sohag":
                case "Sohag Centers":
                    CityId = 21;
                    break;
                case "Talkha":
                    CityId = 107;
                    break;
                case "Tanta":
                    CityId = 10;
                    break;
                case "Toukh":
                    CityId = 108;
                    break;
                case "Zakazeek":
                case "Zakazek":
                case "Zakazik":
                case "Zakzaik":
                case "Zakzek":
                case "Zakzik":
                    CityId = 14;
                    break;
                case "Zefta":
                    CityId = 109;
                    break;
            }
            return CityId;
        }
        public bool CreateDefaultData()
        {
            try
            {
                AdpQry.InsertDefaultData();
                NestleICSales.Forms.MainFrm frm = new NestleICSales.Forms.MainFrm();
                foreach (DevExpress.XtraBars.BarItem item in frm.ribbonControl.Items)
                {
                    if (item.Name != string.Empty)
                        adpAppRole.InsertQueryInsertIfNotExists(item.Name);
                }

                Logger.Debug("Create Default Data ... Done");
                return true;
            }
            catch (Exception ex)
            {
                Logger.Error("Create Default Data ... Error", ex);
                return false;
            }
            
        }
        public void GetFormPriv(int UserID, string FormName, ref bool Selecting, ref bool Inserting, ref bool Updateing, ref bool Deleting)
        {
            Selecting = false; Inserting = false; Updateing = false; Deleting = false;

            if (FormName.Substring(FormName.Length - 3).ToLower() == "frm")
                FormName = FormName.Substring(0, FormName.Length - 3);
            FormName = AppManager.defaultInstance.AppMenuName + FormName;

            //if (UserManager.defaultInstance.UserAppRoles == null)
            //    return;

            //foreach (DataSources.dsDataCenter.AppRoleRow row in UserManager.defaultInstance.UserAppRoles.Rows)
            //{
            //    if (row.MenuItemName != FormName)
            //        continue;
            //    if (row.Selecting)
            //        Selecting = row.Selecting;
            //    if (row.Inserting)
            //        Inserting = row.Inserting;
            //    if (row.Updateing)
            //        Updateing = row.Updateing;
            //    if (row.Deleting)
            //        Deleting = row.Deleting;
            //}
        }

        public bool ShrinkDatabase()
        {
            try
            {
                AdpQry.SHRINKDATA(SHRINKSIZE);
                return true;
            }
            catch (SqlException ex)
            {
                Logger.Error("Shrink Database ... Error", ex);
                return false;
            }
            
        }
       
        #region -   Refresh Cashed Tables   -
        public bool LoadAllRoute()
        {
            bool outPut = false;
            try
            {
                int count = 0;
                count = adpRoutes.Fill(dsData.Routes);
                Logger.Debug("Loading All Routes Success " + count);
            }
            catch (SqlException ex)
            {
                Logger.Error("Loading All Routes .. Failed - " + ex.Message, ex);
            }
            return outPut;
        }
        public bool LoadAllCustomers()
        {
            bool outPut = false;
            try
            {
                int count = 0;
                count = adpCustomers.Fill(dsData.Customer);
                Logger.Debug("Loading All Customers Success " + count);
            }
            catch (SqlException ex)
            {
                Logger.Error("Loading All Customers .. Failed - " + ex.Message, ex);
            }
            return outPut;
        }
        public bool LoadAlladpProducts()
        {
            bool outPut = false;
            try
            {
                int count = 0;
                count = adpProducts.Fill(dsData.Product);
                Logger.Debug("Loading All Products Success " + count);
            }
            catch (SqlException ex)
            {
                Logger.Error("Loading All Products .. Failed - " + ex.Message, ex);
            }
            return outPut;
        }
        #endregion

        public List<Utilities.Types.ReportsFormation> LoadExcelFileFormation()
        {
            List<Utilities.Types.ReportsFormation> Informations = new List<Utilities.Types.ReportsFormation>();

            Utilities.Types.ReportsFormation info = new Utilities.Types.ReportsFormation() { 
                FileType = Utilities.Types.XmlFileType.R3, HeaderCount = 21, TabelName = "R3"};
            Informations.Add(info);
            return Informations;
        }
        public DataTable FormationExcelTable(DataSet ds, Utilities.Types.ReportsFormation formation)
        {
            DataTable tbl = null;
            DataTable XmlTbl = ds.Tables[formation.TabelName];
            int JumbCount = formation.HeaderCount; //- 1;

            switch (formation.FileType)
            {
                case  Utilities.Types.XmlFileType.R3:
                    tbl = new DataSources.dsData.R3DataTable();
                    break;
            }

            try
            {
                for (int iTable = JumbCount; iTable < XmlTbl.Rows.Count; )
                {
                    DataRow row = tbl.NewRow();
                    for (int iRow = 0; iRow < JumbCount; iRow++)
                        row[XmlTbl.Rows[iRow][1].ToString()] = XmlTbl.Rows[iTable + iRow][1];
                    tbl.Rows.Add(row);
                    iTable += JumbCount ;
                }
            }
            catch (Exception ex)
            {
            }

            return tbl;
        }

        #endregion
    }
}