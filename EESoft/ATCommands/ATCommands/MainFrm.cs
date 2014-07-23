using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;
using System.IO.Ports;
using System.Threading;
using System.Data.SqlClient;
using System.Runtime.Serialization.Formatters.Binary;
using Alias = System.Windows.Forms;
using ATCommands.Uti;
using System.Management;
using DevExpress.XtraSplashScreen;


namespace ATCommands
{
    public partial class MainFrm : XtraForm
    {

        #region -   Variables   -
        //SMS objclsSMS = new SMS();
        private readonly DevExpress.XtraBars.RibbonGalleryBarItem rgbiSkins = new DevExpress.XtraBars.RibbonGalleryBarItem();
        public DataTable ActionLogTbl = new DataTable("FX2011-10");
        public AutoResetEvent receiveNow;
        enum messageStatus
        {
            «—”·  = 1,
            ›‘·  = 2,
            Ã«Â“Â = 3
        }
        List<PhoneList> SelectedPhones = new List<PhoneList>();
            
        DataSources.dsMsg ds = new DataSources.dsMsg();
        DataSources.dsMsgTableAdapters.TempMsgTableAdapter adpMsg = new DataSources.dsMsgTableAdapters.TempMsgTableAdapter();
        DataSources.dsMsgTableAdapters.QueriesTableAdapter adpQry = new DataSources.dsMsgTableAdapters.QueriesTableAdapter();

        #endregion
        #region -   Functions   -
        public MainFrm()
        {
            InitializeComponent();
            InitSkinGallery();
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(rgbiSkins, true, true);
        }
        void InitSkinGallery()
        {
            DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            ribbonControl.Items.Add(rgbiSkins);
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(rgbiSkins, true);
        }
        private static UserSettings LoadSettings(string fileName)
        {
            UserSettings us = null;
            BinaryFormatter binFormat = new BinaryFormatter();
            System.IO.Stream fStream = new System.IO.FileStream(fileName, System.IO.FileMode.Open);
            try { us = binFormat.Deserialize(fStream) as UserSettings; }
            finally { fStream.Close(); }
            return us;
        }
        private static void SaveSettings(UserSettings us)
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            using (System.IO.Stream fStream = new System.IO.FileStream(MyCL.StyleSettingsPath, System.IO.FileMode.Create, System.IO.FileAccess.Write, System.IO.FileShare.None))
            {
                binFormat.Serialize(fStream, us);
                fStream.Close();
            }
        }
        private void LoadPorts()
        { 
            CBEPort.Properties.Items.AddRange(SerialPort.GetPortNames());
        }
        private static DataTable LoadSetting()
        {
            return MyCL.LoadDataTable(@"Select ServiceNum From Setting");
        }
        private static DataTable LoadUsers()
        {
            return MyCL.LoadDataTable(@"Select UserID, UserName, PassWord From Users");
        }
        private static DataTable LoadTemplates()
        {
            return MyCL.LoadDataTable(@"Select TemplateId, TemplateTitle, TemplateBody From Templates");
        }
        private static DataTable LoadGroups()
        {
            return MyCL.LoadDataTable(@"Select Groupid, GroupName From Groups");
        }
        private static DataTable LoadContacts()
        {
            return MyCL.LoadDataTable(@"Select ContactID, ContactName, ContactNumber, GroupID From Contacts");
            //Groups.TableName = "Groups";
            //Contacts.TableName = "Contacts";
            //DataSet dataSetGroupContact = new DataSet("dataSetGroupContact");
            //dataSetGroupContact.Tables.AddRange(new System.Data.DataTable[] { Groups, Contacts });
            //dataSetGroupContact.Relations.Add("LvlContacts", Groups.Columns["GroupName"], Contacts.Columns["GroupID"]);
            //gridControlMain.MainView = gridViewGroups;
            //gridControlMain.DataSource = dataSetGroupContact;
            //gridControlMain.DataMember = "Groups";
        }
        private static DataTable LoadMessages()
        {
            //Convert(nvarchar, SendTime, 103) AS 
            return MyCL.LoadDataTable(@"Select messageid, messageBody, number, (Select StatusName From messageStatus Where Statusid = Messages.status) AS status, 
            SendTime From Messages");
        }
        private static DataTable LoadStyle()
        {
            DataTable dtStyles = new DataTable();
            //Columns
            dtStyles.Columns.Add("StykeName");
            //Rows
            dtStyles.Rows.Add("Black");
            dtStyles.Rows.Add("Blue");
            dtStyles.Rows.Add("Caramel");
            dtStyles.Rows.Add("DevExpress Dark Style");
            dtStyles.Rows.Add("DevExpress Style");
            dtStyles.Rows.Add("iMaginary");
            dtStyles.Rows.Add("Lilian");
            dtStyles.Rows.Add("Money Twins");
            dtStyles.Rows.Add("Office 2007 Black");
            dtStyles.Rows.Add("Office 2007 Blue");
            dtStyles.Rows.Add("Office 2007 Green");
            dtStyles.Rows.Add("Office 2007 Pink");
            dtStyles.Rows.Add("Office 2007 Silver");
            dtStyles.Rows.Add("Office 2010 Black");
            dtStyles.Rows.Add("Office 2010 Blue");
            dtStyles.Rows.Add("Office 2010 Silver");
            dtStyles.Rows.Add("Blueprint");
            dtStyles.Rows.Add("Coffee");
            dtStyles.Rows.Add("Dark Side");
            dtStyles.Rows.Add("Darkroom");
            dtStyles.Rows.Add("Foggy");
            dtStyles.Rows.Add("Glass Oceans");
            dtStyles.Rows.Add("High Contrast");
            dtStyles.Rows.Add("Liquid Sky");
            dtStyles.Rows.Add("London Liquid Sky");
            dtStyles.Rows.Add("McSkin");
            dtStyles.Rows.Add("Pumpkin");
            dtStyles.Rows.Add("Seven");
            dtStyles.Rows.Add("Seven Classic");
            dtStyles.Rows.Add("Sharp");
            dtStyles.Rows.Add("Sharp Plus");
            dtStyles.Rows.Add("Springtime");
            dtStyles.Rows.Add("Stardust");
            dtStyles.Rows.Add("Summer 2008");
            dtStyles.Rows.Add("The Asphalt World");
            dtStyles.Rows.Add("Valentine");
            dtStyles.Rows.Add("Whiteprint");
            dtStyles.Rows.Add("Xmas 2008 Blue");
            return dtStyles;
        }
        private static void Fixe_schoolDBTable(ref DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                switch (row["alsofof_code"].ToString())// Alsofoof
                {
                    case "0":// „ÂÌœÌ
                        row["alsofof_code_Name"] = " „ÂÌœÌ";
                        break;
                    case "1"://—Ê÷Â «Ê·
                        row["alsofof_code_Name"] = "—Ê÷Â √Ê·";
                        break;
                    case "2"://—Ê÷Â À«‰Ì
                        row["alsofof_code_Name"] = "—Ê÷Â À«‰Ì";
                        break;
                    case "3"://«Ê·Ì «» œ«∆Ì
                        row["alsofof_code_Name"] = "√Ê·Ì «» œ«∆Ì";
                        break;
                    case "4"://À«‰Ì «» œ«∆Ì
                        row["alsofof_code_Name"] = "À«‰Ì «» œ«∆Ì";
                        break;
                    case "5"://À«·À «» œ«∆Ì
                        row["alsofof_code_Name"] = "À«·À «» œ«∆Ì";
                        break;
                    case "6"://—«»⁄ «» œ«∆Ì
                        row["alsofof_code_Name"] = "—«»⁄ «» œ«∆Ì";
                        break;
                    case "7"://Œ«„” «» œ«∆Ì
                        row["alsofof_code_Name"] = "Œ«„” «» œ«∆Ì";
                        break;
                    case "8"://”«œ” «» œ«∆Ì
                        row["alsofof_code_Name"] = "”«œ” «» œ«∆Ì";
                        break;

                    case "10"://«Ê·Ì «⁄œ«œÌ
                        row["alsofof_code_Name"] = "√Ê·Ì «⁄œ«œÌ";
                        break;
                    case "11"://À«‰Ì «⁄œ«œÌ
                        row["alsofof_code_Name"] = "À«‰Ì «⁄œ«œÌ";
                        break;
                    case "12"://À«·À «⁄œ«œÌ
                        row["alsofof_code_Name"] = "À«·À «⁄œ«œÌ";
                        break;

                    case "31"://«Ê·Ì À«‰ÊÌ
                        row["alsofof_code_Name"] = "√Ê·Ì À«‰ÊÌ";
                        break;
                    case "32"://À«‰Ì À«‰ÊÌ
                        row["alsofof_code_Name"] = "À«‰Ì À«‰ÊÌ";
                        break;
                    case "33"://À«·À À«‰ÊÌ
                        row["alsofof_code_Name"] = "À«·À À«‰ÊÌ";
                        break;
                    default:
                        break;
                }
                switch (row["fasl_code"].ToString())// Al Fosool
                {
                    case "1":
                        row["fasl_code_Name"] = "√Ê·";
                        break;
                    case "2":
                        row["fasl_code_Name"] = "À«‰Ì";
                        break;
                    case "3":
                        row["fasl_code_Name"] = "À«·À";
                        break;
                    case "4":
                        row["fasl_code_Name"] = "—«»⁄";
                        break;
                    case "5":
                        row["fasl_code_Name"] = "Œ«„”";
                        break;
                    case "6":
                        row["fasl_code_Name"] = "”«œ”";
                        break;
                    case "7":
                        row["fasl_code_Name"] = "”«»⁄";
                        break;
                    case "8":
                        row["fasl_code_Name"] = "À«„‰";
                        break;
                    case "9":
                        row["fasl_code_Name"] = " «”⁄";
                        break;
                    case "10":
                        row["fasl_code_Name"] = "⁄«‘—";
                        break;
                    default:
                        break;
                }
            }
        }
        private static void FixDatanetTable(ref DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                switch (row["manth_code"].ToString())// ﬂÊœ «·«Œ »«—
                {
                    case "1"://‰’› «· —„
                        row["manth_code_Name"] = "‰’› «· —„";
                        break;
                    case "2"://‰’› «·⁄«„
                        row["manth_code_Name"] = "‰’› «·⁄«„";
                        break;
                    case "3"://«Œ— «·⁄«„
                        row["manth_code_Name"] = "«Œ— «·⁄«„";
                        break;
                    default:
                        break;
                }
                
            }
        }
        private static DataTable Loade_schoolDB()
        {
            return MyCL.LoadDataTable(@"Select ID, Stu_DB_Path, Result_DB_Path, acc_sms_DB_Path, malafatSms_DB_Path From e_schoolDB");
        }
        private DataTable Loade_dataschool()
        {
            GCstu_Dayz.Visible = false;
            GCstu_BirthDay.Visible = false;
            GCstu_age.Visible = false;
            GCstu_eyab_date_from.Visible = false;
            MyCL.SchoolDBPath = MyCL.LoadDataTable("Select Stu_DB_Path From e_schoolDB").Rows[0][0].ToString();
            if (MyCL.SchoolDBPath == string.Empty || !System.IO.File.Exists(MyCL.SchoolDBPath))
            {
                MyCL.ShowMsg("Œÿ«¡ ›Ì „”«— ﬁ«⁄œÂ »Ì«‰«  «·ÿ·«»", true, this, true);
                return new DataTable();
            }
            /*SELECT student.stu_name, student_t.asase_code, student.walealkmrname, student_t.fasl_code, student_t.alsofof_code, student.waleaalkamr_mobile
              FROM student INNER JOIN student_t ON student.stu_code = student_t.stu_code
              WHERE (((student_t.asase_code)=(select max(student_t.asase_code) from student_t )) AND ((student_t.alsofof_code)=3));
            */
            DataTable dt = MyCL.LoadDataTable(@"SELECT stu_code, alsofof_code, fasl_code, ' ' AS alsofof_code_Name, ' ' AS fasl_code_Name,
            (Select stu_name From student Where stu_code = student_t.stu_code) AS stu_name,
            (Select walealkmrname From student Where stu_code = student_t.stu_code) AS walealkmrname,
            (Select waleaalkamr_mobile From student Where stu_code = student_t.stu_code) AS waleaalkamr_mobile,'0' AS Dayz, '' AS BirthDay, '0' AS age,
            'False' AS checked FROM student_t WHERE (asase_code = (SELECT MAX(asase_code) FROM student_t))", MyCL.SchoolDBPath);
            Fixe_schoolDBTable(ref dt);
            return dt;
        }
        private DataTable Loade_Qry()
        {
            //GCstu_Dayz.Visible = false;
            //GCstu_BirthDay.Visible = false;
            //GCstu_age.Visible = false;
            //GCstu_eyab_date_from.Visible = false;
            MyCL.SchoolDBPath = MyCL.LoadDataTable("Select Stu_DB_Path From e_schoolDB").Rows[0][0].ToString();
            if (MyCL.SchoolDBPath == string.Empty || !System.IO.File.Exists(MyCL.SchoolDBPath))
            {
                MyCL.ShowMsg("Œÿ«¡ ›Ì „”«— ﬁ«⁄œÂ »Ì«‰«  «·ÿ·«»", true, this, true);
                return new DataTable();
            }
            /*SELECT student.stu_name, student_t.asase_code, student.walealkmrname, student_t.fasl_code, student_t.alsofof_code, student.waleaalkamr_mobile
              FROM student INNER JOIN student_t ON student.stu_code = student_t.stu_code
              WHERE (((student_t.asase_code)=(select max(student_t.asase_code) from student_t )) AND ((student_t.alsofof_code)=3));
            */
            DataTable dt = MyCL.LoadDataTable(@"SELECT stu_code, alsofof_code, fasl_code, ' ' AS alsofof_code_Name, ' ' AS fasl_code_Name,
            (Select stu_name From student Where stu_code = student_t.stu_code) AS stu_name,
            (Select walealkmrname From student Where stu_code = student_t.stu_code) AS walealkmrname,
            (Select waleaalkamr_mobile From student Where stu_code = student_t.stu_code) AS waleaalkamr_mobile,'0' AS Dayz, '' AS BirthDay, '0' AS age,
            'False' AS checked FROM student_t WHERE (asase_code = (SELECT MAX(asase_code) FROM student_t))", MyCL.SchoolDBPath);
            for (int i = dt.Rows.Count - 1; i >= 0; i--)
            {
                if (dt.Rows[i]["waleaalkamr_mobile"].ToString() != string.Empty && dt.Rows[i]["waleaalkamr_mobile"].ToString().Length == 11)
                {
                    dt.Rows.Remove(dt.Rows[i]);
                }
            }
            Fixe_schoolDBTable(ref dt);
            return dt;
        }

        private DataTable Loade_dataschoolBirthDay()
        {
            GCstu_Dayz.Visible = false;
            GCstu_BirthDay.Visible = true;
            GCstu_age.Visible = true;
            GCstu_eyab_date_from.Visible = false;
            MyCL.SchoolDBPath = MyCL.LoadDataTable("Select Stu_DB_Path From e_schoolDB").Rows[0][0].ToString();
            if (MyCL.SchoolDBPath == string.Empty || !System.IO.File.Exists(MyCL.SchoolDBPath))
            {
                MyCL.ShowMsg("Œÿ«¡ ›Ì „”«— ﬁ«⁄œÂ »Ì«‰«  «·ÿ·«»", true, this, true);
                return new DataTable();
            }
            /*SELECT student.stu_name, student.Parthday, DateDiff("yyyy",student.Parthday,Date()) AS age, student_t.asase_code, student.walealkmrname, student.waleaalkamr_mobile
            FROM student INNER JOIN student_t ON student.stu_code = student_t.stu_code
            WHERE (((student_t.asase_code)=(select max(student_t.asase_code) from student_t )));
            */
            DataTable dt = MyCL.LoadDataTable(string.Format(@"SELECT stu_code, alsofof_code, fasl_code, ' ' AS alsofof_code_Name, ' ' AS fasl_code_Name,
            (Select stu_name From student Where stu_code = student_t.stu_code) AS stu_name,
            (Select walealkmrname From student Where stu_code = student_t.stu_code) AS walealkmrname,
            (Select waleaalkamr_mobile From student Where stu_code = student_t.stu_code) AS waleaalkamr_mobile,
            (Select Parthday From student Where stu_code = student_t.stu_code) AS BirthDay,
            (Select DateDiff('yyyy',Parthday,Date()) AS age From student Where stu_code = student_t.stu_code) AS age,'0' AS Dayz,
            'False' AS checked FROM student_t WHERE (asase_code = (SELECT MAX(asase_code) FROM student_t)) And ((Select Format(Parthday , 'dd') From student Where stu_code = student_t.stu_code) = {0})
            And ((Select Format(Parthday , 'mm') From student Where stu_code = student_t.stu_code) = {1})", DateTime.Today.Day, DateTime.Today.Month), MyCL.SchoolDBPath);

            Fixe_schoolDBTable(ref dt);
            return dt;
        }
        private DataTable Loade_dataschoolAbsentCount()
        {
            GCstu_Dayz.Visible = true;
            GCstu_BirthDay.Visible = false;
            GCstu_age.Visible = false;
            GCstu_eyab_date_from.Visible = false;
            MyCL.SchoolDBPath = MyCL.LoadDataTable("Select Stu_DB_Path From e_schoolDB").Rows[0][0].ToString();
            if (MyCL.SchoolDBPath == string.Empty || !System.IO.File.Exists(MyCL.SchoolDBPath))
            {
                MyCL.ShowMsg("Œÿ«¡ ›Ì „”«— ﬁ«⁄œÂ »Ì«‰«  «·ÿ·«»", true, this, true);
                return new DataTable();
            }
            /*SELECT student.stu_code, student.stu_name, student.walealkmrname, student.waleaalkamr_mobile, Count(*) AS ab_Days
            FROM student INNER JOIN stu_eyab ON student.stu_code = stu_eyab.stu_code
            WHERE (((stu_eyab.asase_code)=(select max(student_t.asase_code) from student_t )))
            GROUP BY student.stu_code, student.stu_name, student.walealkmrname, student.waleaalkamr_mobile;
            */
            DataTable dt = MyCL.LoadDataTable(@"SELECT stu_code, alsofof_code, fasl_code, ' ' AS alsofof_code_Name, ' ' AS fasl_code_Name,
            (Select stu_name From student Where stu_code = student_t.stu_code) AS stu_name,
            (Select walealkmrname From student Where stu_code = student_t.stu_code) AS walealkmrname,
            (Select waleaalkamr_mobile From student Where stu_code = student_t.stu_code) AS waleaalkamr_mobile,
            (Select Count(*) From stu_eyab Where stu_code = student_t.stu_code AND asase_code = (SELECT MAX(asase_code) FROM student_t)) AS Dayz,'' AS BirthDay, '0' AS age,
            'False' AS checked FROM student_t WHERE asase_code = (SELECT MAX(asase_code) FROM student_t)", MyCL.SchoolDBPath);

            Fixe_schoolDBTable(ref dt);
            return dt;
        }
        private DataTable Loade_dataschoolAbsent()
        {
            GCstu_Dayz.Visible = false;
            GCstu_BirthDay.Visible = false;
            GCstu_age.Visible = false;
            GCstu_eyab_date_from.Visible = true;
            MyCL.SchoolDBPath = MyCL.LoadDataTable("Select Stu_DB_Path From e_schoolDB").Rows[0][0].ToString();
            if (MyCL.SchoolDBPath == string.Empty || !System.IO.File.Exists(MyCL.SchoolDBPath))
            {
                MyCL.ShowMsg("Œÿ«¡ ›Ì „”«— ﬁ«⁄œÂ »Ì«‰«  «·ÿ·«»", true, this, true);
                return new DataTable();
            }
            /*SELECT student.stu_code, student.stu_name, student.walealkmrname, student.waleaalkamr_mobile, stu_eyab.eyab_date_from
            FROM student INNER JOIN stu_eyab ON student.stu_code = stu_eyab.stu_code
            WHERE (((stu_eyab.asase_code)=(select max(student_t.asase_code) from student_t )))
            GROUP BY student.stu_code, student.stu_name, student.walealkmrname, student.waleaalkamr_mobile, stu_eyab.eyab_date_from;
            */
            DataTable dt = MyCL.LoadDataTable(@"SELECT student.stu_code, student.stu_name, student.walealkmrname, student.waleaalkamr_mobile, stu_eyab.eyab_date_from,
            (Select alsofof_code From student_t Where stu_code = student.stu_code And asase_code = (SELECT MAX(asase_code) FROM student_t)) AS alsofof_code,
            (Select fasl_code From student_t Where stu_code = student.stu_code And asase_code = (SELECT MAX(asase_code) FROM student_t)) AS fasl_code,
            ' ' AS alsofof_code_Name, ' ' AS fasl_code_Name, '0' AS Dayz,'' AS BirthDay, '0' AS age, 'False' AS checked
            FROM student INNER JOIN stu_eyab ON student.stu_code = stu_eyab.stu_code WHERE (((stu_eyab.asase_code)=(select max(student_t.asase_code) from student_t )))
            GROUP BY student.stu_code, student.stu_name, student.walealkmrname, student.waleaalkamr_mobile, stu_eyab.eyab_date_from", MyCL.SchoolDBPath);
            Fixe_schoolDBTable(ref dt);
            return dt;
        }
        private DataTable Load_Datanet()
        {
            MyCL.DatanetDBPath = MyCL.LoadDataTable("Select Result_DB_Path From e_schoolDB").Rows[0][0].ToString();
            if (MyCL.DatanetDBPath == string.Empty || !System.IO.File.Exists(MyCL.DatanetDBPath))
            {
                MyCL.ShowMsg("Œÿ«¡ ›Ì „”«— ﬁ«⁄œÂ »Ì«‰«  «·‰ «∆Ã", true, this, true);
                return new DataTable();
            }
            DataTable dt = MyCL.LoadDataTable(@"SELECT asase_code, manth_code, stu_code, alsofof_code, fasl_code, stu_name, sumd, mobil, Format(perm, 'True/False') AS perm,
            ' ' AS alsofof_code_Name, ' ' AS fasl_code_Name, ' ' AS manth_code_Name, 'False' AS checked 
            FROM smscontrol Where asase_code = (Select Max(asase_code) From smscontrol)", MyCL.DatanetDBPath);
            Fixe_schoolDBTable(ref dt);
            FixDatanetTable(ref dt);
            return dt;
        }
        private DataTable Load_Daccount()
        {
            MyCL.acc_smsDBPath = MyCL.LoadDataTable("Select acc_sms_DB_Path From e_schoolDB").Rows[0][0].ToString();
            if (MyCL.acc_smsDBPath == string.Empty || !System.IO.File.Exists(MyCL.acc_smsDBPath))
            {
                MyCL.ShowMsg("Œÿ«¡ ›Ì „”«— ﬁ«⁄œÂ »Ì«‰«  «·Õ”«»« ", true, this, true);
                return new DataTable();
            }
            DataTable dt = MyCL.LoadDataTable(@"SELECT asase_code, stu_code, alsofof_code,' ' AS fasl_code, stu_name, sumbaky AS summony, mobil, 'False' AS checked,
            ' ' AS alsofof_code_Name, ' ' AS fasl_code_Name
            FROM smsaccount Where asase_code = (Select Max(asase_code) From smsaccount)", MyCL.acc_smsDBPath);
            // DataTable dt = MyCL.LoadDataTable(@"SELECT asase_code, stu_code, alsofof_code, fasl_code, stu_name, summony, mobil, 'False' AS checked,
            // ' ' AS alsofof_code_Name, ' ' AS fasl_code_Name
            // FROM smscontrol Where asase_code = (Select Max(asase_code) From smscontrol)", MyCL.acc_smsDBPath);
            Fixe_schoolDBTable(ref dt);
            return dt;
        }
        private DataTable Load_malafatSms()
        {
            MyCL.malafatSmsDBPath = MyCL.LoadDataTable("Select malafatSms_DB_Path From e_schoolDB").Rows[0][0].ToString();
            if (MyCL.malafatSmsDBPath == string.Empty || !System.IO.File.Exists(MyCL.malafatSmsDBPath))
            {
                MyCL.ShowMsg("Œÿ«¡ ›Ì „”«— ﬁ«⁄œÂ »Ì«‰«  «·⁄«„·Ì‰", true, this, true);
                return new DataTable();
            }
            DataTable dt = MyCL.LoadDataTable(@"SELECT empId, empname, job, mada, mobil, 'False' AS checked
            FROM smsemp", MyCL.malafatSmsDBPath);
            return dt;
        }
        public string ReadResponse(int timeout)
        {
            string buffer = string.Empty;
            try
            {
                do
                {
                    if (receiveNow.WaitOne(timeout, false))
                    {
                        string t = USBserialPort.ReadExisting();
                        buffer += t;
                    }
                    else
                    {
                        if (buffer.Contains("ERROR:"))
                        {
                            buffer = string.Empty;
                            break;
                        }
                        //if (buffer.Length > 0)
                        //    throw new ApplicationException("Response received is incomplete.");
                        //else
                        //    throw new ApplicationException("No data received from phone.");
                    }
                }
                while (!buffer.EndsWith("\r\nOK\r\n") && !buffer.EndsWith("\r\n> ") && !buffer.EndsWith("\r\nERROR\r\n"));
            }
            catch (Exception ex)
            {
                msgbox.Show(ex.Message, false, this, false);
                throw ex;
            }
            msgbox.Show(buffer, false, this, false);
            return buffer;
        }
        public string ExecCommand(string command, int responseTimeout)
        {
            
            try
            {
                USBserialPort.DiscardOutBuffer();
                USBserialPort.DiscardInBuffer();
                receiveNow.Reset();
                USBserialPort.Write(command + "\r");

                string input = ReadResponse(responseTimeout);
                if ((input.Length == 0) || ((!input.EndsWith("\r\n> ")) && (!input.EndsWith("\r\nOK\r\n"))))
                    throw new ApplicationException(" „ «” ﬁ»«· —”«·… Œÿ«¡ „‰ «·»Ê— ");
                msgbox.Show(input, false, this, false);
                return input;
            }
            catch (Exception ex)
            {
                msgbox.Show(ex.Message, false, this, false);
                throw ex;
            }
        }
        private void ReadSignal()
        {
            try
            {

                string signal = ExecCommand("AT+CSQ", 5000);
                if (signal.Contains("+CSQ:"))
                    PBSignal.EditValue = MyCL.ConvertStringToInt(signal.Substring(signal.IndexOf(Convert.ToChar(":")) + 1), ",");
                else
                    PBSignal.EditValue = "0";
            }
            catch(Exception ex)
            {
                PBSignal.EditValue = "0";
                TmrSignal.Enabled = false;
                msgbox.Show(ex.Message, false, this, false);
            }
        }
        private static string GetPDU(string ServiceCenterNumber, string Destination_Address, string User_Data)
        {
            FXPDU.SMS PDUCls = new FXPDU.SMS();
            PDUCls.TP_Data_Coding_Scheme = FXPDU.SMS.ENUM_TP_DCS.UCS2;
            PDUCls.ServiceCenterNumber = ServiceCenterNumber;
            PDUCls.TP_Destination_Address = Destination_Address;
            PDUCls.TP_User_Data = User_Data;
            PDUCls.TP_Status_Report_Request = FXPDU.SMS.ENUM_TP_SRI.No_SMS_Report;
            PDUCls.TP_Validity_Period = FXPDU.SMS.ENUM_TP_VALID_PERIOD.Maximum;
            PDUCls.TP_Message_Reference = 0;
            return PDUCls.GetSMSPDUCode();
        }
        private static string GetPDULength(string PDU)
        {
            int strLen = Convert.ToInt32(PDU.Substring(0, 2));
            strLen *= 2;
            strLen = PDU.Length - strLen - 2;
            strLen /= 2;
            return strLen.ToString();
        }
        private void SaveSentMessageLog(string messageBody, string number, messageStatus Status)
        {
            using (SqlConnection con = new SqlConnection(MyCL.SqlConStr))
            {
                SqlCommand cmd = new SqlCommand("", con);
                try
                {
                    cmd.CommandText = string.Format(@"Insert Into Messages (messageBody, number, status, SendTime) VALUES (N'{0}', N'{1}', {2}, GETDATE())", messageBody, number, (int)Status);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MyCL.ShowMsg(MyCL.CheckExp(ex), true, this, true);
                }
                con.Close();
            }
        }
        private static string getMsgVars(string msg, PhoneList phonelist)
        {
            if (msg.Contains("[«·«”„]") || msg.Contains("[«”„ «·√»]") || msg.Contains("[«”„ «·„” Œœ„]") || msg.Contains("[ﬂ·„… «·„—Ê—]"))
            {
                MyCL.SchoolDBPath = MyCL.LoadDataTable("Select Stu_DB_Path From e_schoolDB").Rows[0][0].ToString();
                if (MyCL.SchoolDBPath == string.Empty || !System.IO.File.Exists(MyCL.SchoolDBPath))
                    return string.Empty;
                DataTable dt = MyCL.LoadDataTable(String.Format("Select stu_code, stu_name, walealkmrname, waleaalkamr_mobile, user_name, pass From student Where stu_code = {0}", phonelist.ID), MyCL.SchoolDBPath);
                if (dt.Rows.Count > 0)
                {
                    if (msg.Contains("[«·«”„]"))
                        msg = msg.Replace("[«·«”„]", dt.Rows[0]["stu_name"].ToString());
                    if (msg.Contains("[«”„ «·√»]"))
                        msg = msg.Replace("[«”„ «·√»]", dt.Rows[0]["walealkmrname"].ToString());
                    if (msg.Contains("[«”„ «·„” Œœ„]"))
                        msg = msg.Replace("[«”„ «·„” Œœ„]", dt.Rows[0]["user_name"].ToString());
                    if (msg.Contains("[ﬂ·„… «·„—Ê—]"))
                        msg = msg.Replace("[ﬂ·„… «·„—Ê—]", dt.Rows[0]["pass"].ToString());
                    
                }
                else
                {
                    if (msg.Contains("[«·«”„]"))
                        msg = msg.Replace("[«·«”„]", "");
                    if (msg.Contains("[«”„ «·√»]"))
                        msg = msg.Replace("[«”„ «·√»]", "");
                    if (msg.Contains("[«”„ «·„” Œœ„]"))
                        msg = msg.Replace("[«”„ «·„” Œœ„]", "");
                    if (msg.Contains("[ﬂ·„… «·„—Ê—]"))
                        msg = msg.Replace("[ﬂ·„… «·„—Ê—]", "");
                }
            }

            if (msg.Contains("[«”„ «·⁄«„·]"))
            {
                MyCL.malafatSmsDBPath = MyCL.LoadDataTable("Select malafatSms_DB_Path From e_schoolDB").Rows[0][0].ToString();
                if (MyCL.malafatSmsDBPath == string.Empty || !System.IO.File.Exists(MyCL.malafatSmsDBPath))
                    return string.Empty;
                DataTable dt = MyCL.LoadDataTable(String.Format("Select empname From smsemp Where empId = {0}", phonelist.ID), MyCL.malafatSmsDBPath);
                if (dt.Rows.Count > 0)
                {
                    if (msg.Contains("[«”„ «·⁄«„·]"))
                        msg = msg.Replace("[«”„ «·⁄«„·]", dt.Rows[0]["empname"].ToString());
                }
                else
                {
                    if (msg.Contains("[«”„ «·⁄«„·]"))
                        msg = msg.Replace("[«”„ «·⁄«„·]", "");
                }
            }

            if (msg.Contains("[„»·€ «·Õ”«»« ]") && phonelist.asase_code != string.Empty)
            {
                MyCL.acc_smsDBPath = MyCL.LoadDataTable("Select acc_sms_DB_Path From e_schoolDB").Rows[0][0].ToString();
                if (MyCL.acc_smsDBPath == string.Empty || !System.IO.File.Exists(MyCL.acc_smsDBPath))
                    return string.Empty;
                DataTable dt = MyCL.LoadDataTable(String.Format("Select sumbaky From smsaccount Where stu_code = {0} AND asase_code = {1}", phonelist.ID, phonelist.asase_code), MyCL.acc_smsDBPath);
                if (dt.Rows.Count > 0)
                {
                    if (msg.Contains("[„»·€ «·Õ”«»« ]"))
                        msg = msg.Replace("[„»·€ «·Õ”«»« ]", dt.Rows[0]["sumbaky"].ToString());
                }
                else
                {
                    if (msg.Contains("[„»·€ «·Õ”«»« ]"))
                        msg = msg.Replace("[„»·€ «·Õ”«»« ]", "");
                }
            }

            if (msg.Contains("[«·œ—Ã…]") && phonelist.asase_code != string.Empty && phonelist.manth_code != string.Empty)
            {
                MyCL.DatanetDBPath = MyCL.LoadDataTable("Select Result_DB_Path From e_schoolDB").Rows[0][0].ToString();
                if (MyCL.DatanetDBPath == string.Empty || !System.IO.File.Exists(MyCL.DatanetDBPath))
                    return string.Empty;
                DataTable dt = MyCL.LoadDataTable(String.Format("Select sumd From smscontrol Where stu_code = {0} AND asase_code = {1} AND manth_code = {2}", phonelist.ID, phonelist.asase_code, phonelist.manth_code), MyCL.DatanetDBPath);
                if (dt.Rows.Count > 0)
                {
                    if (msg.Contains("[«·œ—Ã…]"))
                        msg = msg.Replace("[«·œ—Ã…]", dt.Rows[0]["sumd"].ToString());
                }
                else
                {
                    if (msg.Contains("[«·œ—Ã…]"))
                        msg = msg.Replace("[«·œ—Ã…]", "");
                }
            }
            return msg;
        }
        private static string[] MsgPrepare(string msg)
        {
            int loopCount = msg.Length / 70;
            if (msg.Length % 70 > 0)
                loopCount++;

            string[] returnMe = new string[0];
            for (int i = 0; i < loopCount; i++)
            {
                Array.Resize<string>(ref returnMe, returnMe.Length + 1);
                returnMe[returnMe.Length - 1] = msg.Substring(i * 70);
                if (returnMe[returnMe.Length - 1].Length > 70)
                    returnMe[returnMe.Length - 1] = returnMe[returnMe.Length - 1].Remove(70);
            }
            return returnMe;
        }
        private void AddToPhonesList(string phone, string Id, string asase = "", string manth = "")
        {
            if (phone == string.Empty || phone.Length != 11)
            {
                return;
            }
            PhoneList phonelist = new PhoneList(phone, Id, asase: asase, manth: manth);
            SelectedPhones.Add(phonelist);
            LBCSendTo.Refresh();
        }
        private bool PhoneInList(string phoneNumber)
        {
            foreach (PhoneList item in SelectedPhones)
            {
                if (phoneNumber == item.Phone)
                    return true;
            }
            return false;
        }
        private void RemoveFromhonesList(string phone, string Id, string asase = "", string manth = "")
        {
            if (phone != string.Empty)
            {
                for (int i = 0; i < SelectedPhones.Count; i++)
                {
                    if (SelectedPhones[i].Phone != phone || SelectedPhones[i].ID != Id)
                        continue;
                    if (asase != "" && SelectedPhones[i].asase_code != asase)
                        continue;
                    if (manth != "" && SelectedPhones[i].manth_code != manth)
                        continue;

                    SelectedPhones.RemoveAt(i);
                    LBCSendTo.Refresh();
                    return;
                }
            }
        }
        private int SelectedPhonesCount()
        {
            return SelectedPhones.Count;
        }
        static string DeviceFullName(string ComName)
        {
            string ReturnMe = string.Empty;
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PnPEntity WHERE Caption LIKE '%(" + ComName + ")%'");
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    ReturnMe = queryObj["Caption"].ToString();
                }
            }
            catch (ManagementException e)
            {
                MessageBox.Show(e.Message);
            }
            return ReturnMe;
        }
        #endregion
        #region - Event Handlers -

        private void MainFrm_Load(object sender, EventArgs e)
        {
            SplashFrm SC = new SplashFrm();
            SC.ShowDialog();
            LoginFrm FrmLogin = new LoginFrm();
            FrmLogin.ShowDialog();

            //Load Groups.
            repositoryItemGridLookUpEditGroupName.DataSource = LoadGroups();
            repositoryItemGridLookUpEditGroupName.DisplayMember = "GroupName";
            repositoryItemGridLookUpEditGroupName.ValueMember = "GroupName";

            ActionLogTbl.Columns.Add("details");
            LoadPorts();// Load PortsName in list.
            USBserialPort.Encoding = Encoding.GetEncoding("iso-8859-1");
            gridControlMain.MainView = gridViewSetting;
            gridControlMain.DataSource = LoadSetting();

            if (System.IO.File.Exists(MyCL.StyleSettingsPath))
                UserLookAndFeel.Default.SetSkinStyle(LoadSettings(MyCL.StyleSettingsPath).SkinName);

            LBCSendTo.DataSource = SelectedPhones;
            
        }
        private void navBarItemMessages_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridControlMain.MainView = gridViewMessages;
            gridControlMain.DataSource = LoadMessages();
        }
        private void navBarItemGroups_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridControlMain.MainView = gridViewGroups;
            gridControlMain.DataSource = LoadGroups();
            
        }
        private void navBarItemContacts_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridControlMain.MainView = gridViewContacts;
            gridControlMain.DataSource = LoadContacts();
            
        }
        private void navBarItemUsers_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridControlMain.MainView = gridViewUsers;
            gridControlMain.DataSource = LoadUsers();
        }
        private void navBarItemTemplates_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridControlMain.MainView = gridViewTemplates;
            gridControlMain.DataSource = LoadTemplates();
        }
        private void navBarItemSetting_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridControlMain.MainView = gridViewSetting;
            gridControlMain.DataSource = LoadSetting();
        }
        private void navBarItemStyles_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridControlMain.MainView = layoutViewSkinStyle;
            gridControlMain.DataSource = LoadStyle();
        }
        private void navBarIteme_schoolDB_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridControlMain.MainView = cardViewe_schoolDB;
            gridControlMain.DataSource = Loade_schoolDB();
        }
        private void navBarItemdataschool_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridControlMain.MainView = gridViewdataschool;
            gridControlMain.DataSource = Loade_dataschool();
        }
        private void navBarItemAbsent_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridControlMain.MainView = gridViewdataschool;
            gridControlMain.DataSource = Loade_dataschoolAbsent();
        }
        private void navBarItemAbsentCount_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridControlMain.MainView = gridViewdataschool;
            gridControlMain.DataSource = Loade_dataschoolAbsentCount();
        }
        private void navBarItemBirthday_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridControlMain.MainView = gridViewdataschool;
            gridControlMain.DataSource = Loade_dataschoolBirthDay();
        }
        private void navBarItemDatanet_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridControlMain.MainView = gridViewDatanet;
            gridControlMain.DataSource = Load_Datanet();
        }
        private void navBarItemacc_sms_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridControlMain.MainView = gridViewacc_sms;
            gridControlMain.DataSource = Load_Daccount();
        }
        private void navBarItemmalafatSms_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridControlMain.MainView = gridViewmalafatSms;
            gridControlMain.DataSource = Load_malafatSms();
        }
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            //System.Windows.Forms.MessageBox.Show(EXxecCommand(port, "AT+CSCS=?", 300, "What")); //Port is okay to accept 
            if (USBserialPort.IsOpen)
                USBserialPort.Close();
            
            receiveNow = new AutoResetEvent(false);
            try
            {
                USBserialPort.PortName = CBEPort.Text;
                USBserialPort.Open();
                string recievedData = ExecCommand("AT", 300);//No phone connected
                USBserialPort.DtrEnable = true;
                USBserialPort.RtsEnable = true;

                if (USBserialPort != null)
                {
                    PnlConnection.Enabled = false;
                    PnlSend.Enabled = true;
                    BtnDisconnect.Visible = true;
                    TmrSignal.Enabled = true;
                    MyCL.ShowMsg(" „ «·« ’«· „‰ Œ·«· »Ê—  : " + CBEPort.Text, false, this, true);
                    adpMsg.Fill(ds.TempMsg);
                    if (ds.TempMsg.Count > 0)
                    {
                        string msg = string.Format("Â‰«ﬂ {0} —”«∆· ·„ Ì „ «—”«·Â« Â·  —€» ›Ì «·«—”«· {1} 'Yes' = «—”«· {1} 'No' = Œ–› «·—”«∆· {1} 'Cancel' = Êﬁ› «·« ’«·", ds.TempMsg.Count, Environment.NewLine);

                        Alias.DialogResult dlgResult = MessageBox.Show(msg, "—”«·…", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                        switch (dlgResult)
                        {
                            case DialogResult.Cancel:
                                BtnDisconnect_Click(BtnDisconnect, EventArgs.Empty);
                                break;
                            case DialogResult.Yes:
                                btnSend_Click(this, EventArgs.Empty);
                                break;
                            case DialogResult.No:
                                adpMsg.DeleteQuery();//Delete All Msg.
                                break;
                        }
                        
                    }
                }
                else
                    MyCL.ShowMsg("·„ Ì „ «·« ’«· „‰ Œ·«· »Ê— ", true, this, true);//Invalid port settings
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Œÿ‹‹‹‹«¡", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                TmrSignal.Enabled = false;
                USBserialPort.Close();
                PnlConnection.Enabled = true;
                PnlSend.Enabled = false;
                BtnDisconnect.Visible = false;
                MyCL.ShowMsg(" „ ﬁÿ⁄ «·« ’«·", false, this, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Œÿ‹‹‹‹«¡", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void USBserialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (e.EventType == SerialData.Chars)
                {
                    receiveNow.Set();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(SimpleButton))//mean that button fire by click so do all jobs, else do some job
            {
                SaveMsgToTempTableToStartSending();    
            }
            adpMsg.Fill(ds.TempMsg);

            TmrSignal.Stop(); TmrSignal.Enabled = false;// stop getting the signal and get ready to send sms
            string resultMsg = string.Empty;
            try
            {
                string recievedData = ExecCommand("AT", 300);//No phone connected
                recievedData = ExecCommand("AT+CMGF=0", 300);//Failed to set message format.
                recievedData = ExecCommand("AT+CSMS=0", 300);//Failed to set message format.
                if (recievedData.Contains("ERROR"))
                {
                    MyCL.ShowMsg("·„ Ì „ «·«—”«·", true, this, true);
                    return;
                }
                PBSend.Properties.Maximum = ds.TempMsg.Count;
                PBSend.EditValue = "0";
                for (int i = 0; i < ds.TempMsg.Count; i++)
                {
                    DataSources.dsMsg.TempMsgRow msgData = ds.TempMsg[i];

                    string command = string.Empty;
                    string Logger = string.Empty;
                    PBSend.EditValue = Convert.ToInt32(PBSend.EditValue) + 1;
                    Application.DoEvents();
                    string pdu = GetPDU(TxtServiceNum.Text.Trim(), msgData.mobile, msgData.msg);
                    string pduLength = GetPDULength(pdu);
                    Logger += ExecCommand("AT+CMGS=" + pduLength, 300);//Failed to set message Length.
                    command = String.Format("{0}{1}\r", pdu, char.ConvertFromUtf32(26));
                    Logger += ExecCommand(command, 10000);//"Failed to send message
                    Logger = "\r\nOK\r\n";
                    if (recievedData.EndsWith("\r\nOK\r\n"))
                    {
                        adpMsg.Delete(msgData.Id);//delete msg when send complated
                        SaveSentMessageLog(msgData.msg, msgData.mobile, messageStatus.«—”· );
                        MyCL.ShowMsg(" „ «·«—”«· «·Ì " + msgData.mobile, false, this, false);
                    }
                    else if (recievedData.Contains("ERROR"))
                    {
                        SaveSentMessageLog(msgData.msg, msgData.mobile, messageStatus.›‘· );
                        MyCL.ShowMsg("·„ Ì „ «·«—”«· «·Ì " + msgData.mobile, true, this, false);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            TmrSignal.Enabled = true;// start getting the signal again
            PBSend.EditValue = "0";
            if (resultMsg != string.Empty)
                MyCL.ShowMsg(resultMsg, true, this, true);

            //SplashScreenManager.ShowForm(typeof(WaitWindowFrm));
            //this.Invoke(new MethodInvoker(() =>
            //{
            //}));
            //SplashScreenManager.CloseForm();
        }
        private void SaveMsgToTempTableToStartSending()
        {
            DateTime ServerDatetime = (DateTime)adpQry.ServerDatetime();

            for (int i = SelectedPhonesCount() - 1; i >= 0; i--)
            {
                if (SelectedPhones[i].Phone.Substring(0, 2) != "01" || SelectedPhones[i].Phone == string.Empty)
                {
                    RemoveFromhonesList(SelectedPhones[i].Phone, SelectedPhones[i].ID, SelectedPhones[i].asase_code, "");
                    continue;
                }
                string msgWithoutVar = getMsgVars(TxtMsg.Text, SelectedPhones[i]);// Replace [Stu_Name] And [Father]1 Name with the 1 in DB

                if (msgWithoutVar == string.Empty)
                {
                    MyCL.ShowMsg("Œÿ√ ›Ì ﬁ«⁄œ… »Ì«‰«  «·ÿ·«» / «·⁄«„·Ì‰", true, this, true);
                    return;
                }
                string[] MSGs = MsgPrepare(msgWithoutVar);// Split msg to msg[].length=70
                foreach (string msg in MSGs)
                {
                    DataSources.dsMsg.TempMsgRow row = ds.TempMsg.NewTempMsgRow();
                    row.msg = msg; row.mobile = SelectedPhones[i].Phone; row.sneddate = ServerDatetime;
                    ds.TempMsg.AddTempMsgRow(row);
                    RemoveFromhonesList(SelectedPhones[i].Phone, SelectedPhones[i].ID, SelectedPhones[i].asase_code, "");// remove phone after sned msg
                }
            }
            adpMsg.Update(ds.TempMsg);
        }

        private void BtnSaveMsg_Click(object sender, EventArgs e)
        {
            foreach (PhoneList item in SelectedPhones)
            {
                string[] msg = MsgPrepare(getMsgVars(TxtMsg.Text, item));// Split msg to msg[].length=70
                foreach (string Mymsg in msg)
                    SaveSentMessageLog(Mymsg, item.Phone, messageStatus.Ã«Â“Â);
            }
            MyCL.ShowMsg(" „ «·Õ›Ÿ", false, this, true);
        }
        private void BtnDelSendTo_Click(object sender, EventArgs e)
        {
            if (LBCSendTo.SelectedItem != null)
            {
                PhoneList selectedlist = (PhoneList)LBCSendTo.SelectedItem;
                RemoveFromhonesList(selectedlist.Phone, selectedlist.ID, selectedlist.asase_code, selectedlist.manth_code);
            }
        }
        private void barButtonItemDelAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SelectedPhones.Clear();
            LBCSendTo.Refresh();
        }
        private void repositoryItemButtonEditSettingUse_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            
            switch (gridControlMain.MainView.Name)
            {
                case "gridViewSetting":
                    DataRow rowSetting = gridViewSetting.GetFocusedDataRow();
                    TxtServiceNum.Text = rowSetting["ServiceNum"].ToString();
                    break;

                case "gridViewGroups":
                    DataRow rowGroups = gridViewGroups.GetFocusedDataRow();
                    DataTable dt = MyCL.LoadDataTable(String.Format(@"Select ContactID, ContactNumber From Contacts Where GroupID = N'{0}'", rowGroups["GroupID"]));
                    foreach (DataRow item in dt.Rows)
                    {
                        if (!PhoneInList(item["ContactNumber"].ToString()))
                            AddToPhonesList(item["ContactNumber"].ToString(), item["ContactID"].ToString());
                    }
                    break;

                case "gridViewContacts":
                    DataRow rowContacts = gridViewContacts.GetFocusedDataRow();
                    if (!PhoneInList(rowContacts["ContactNumber"].ToString()))
                        AddToPhonesList(rowContacts["ContactNumber"].ToString(), rowContacts["ContactID"].ToString());
                    break;

                case "gridViewMessages":
                    DataRow rowMessages = gridViewMessages.GetFocusedDataRow();
                    if (!PhoneInList(rowMessages["number"].ToString()))
                        AddToPhonesList(rowMessages["number"].ToString(), rowMessages["messageid"].ToString());
                    if (!TxtMsg.Text.Contains(rowMessages["messageBody"].ToString()))
                        TxtMsg.Text += rowMessages["messageBody"];    
                    break;

                case "gridViewTemplates":
                    DataRow rowTemplates = gridViewTemplates.GetFocusedDataRow();
                    TxtMsg.Text += rowTemplates["TemplateBody"];
                    break;

                case "layoutViewSkinStyle":
                    DataRow rowSkinStyle = layoutViewSkinStyle.GetFocusedDataRow();
                    UserLookAndFeel.Default.SetSkinStyle(rowSkinStyle["StykeName"].ToString());
                    UserSettings us = new UserSettings { SkinName = UserLookAndFeel.Default.ActiveSkinName };
                    SaveSettings(us);
                    break;

                case "gridViewUsers":
                    break;
                default:
                    break;
            }

        }
        private void repositoryItemButtonEditSettingDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Â· ‰  „ √ﬂœø", " Õ“Ì—...!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == Alias.DialogResult.No)
                return;
            SqlConnection con = new SqlConnection(MyCL.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                con.Open();
                switch (gridControlMain.MainView.Name)
                {
                    case "gridViewSetting":
                        DataRow rowSetting = gridViewSetting.GetFocusedDataRow();
                        cmd.CommandText = String.Format("Delete From Setting Where ServiceNum = N'{0}'", rowSetting["ServiceNum"]);
                        cmd.ExecuteNonQuery();
                        gridControlMain.DataSource = LoadSetting();
                        break;

                    case "gridViewGroups":
                        DataRow rowGroups = gridViewGroups.GetFocusedDataRow();
                        cmd.CommandText = String.Format("Delete From Groups Where Groupid = {0}", rowGroups["Groupid"]);
                        cmd.ExecuteNonQuery();
                        gridControlMain.DataSource = LoadGroups();
                        break;

                    case "gridViewContacts":
                        DataRow rowContacts = gridViewContacts.GetFocusedDataRow();
                        cmd.CommandText = String.Format("Delete From Contacts Where ContactID = {0}", rowContacts["ContactID"]);
                        cmd.ExecuteNonQuery();
                        gridControlMain.DataSource = LoadContacts();
                        break;

                    case "gridViewMessages":
                        DataRow rowMessages = gridViewMessages.GetFocusedDataRow();
                        cmd.CommandText = String.Format("Delete From Messages Where messageid = {0}", rowMessages["messageid"]);
                        cmd.ExecuteNonQuery();
                        gridControlMain.DataSource = LoadMessages();
                        break;

                    case "gridViewTemplates":
                        DataRow rowTemplates = gridViewTemplates.GetFocusedDataRow();
                        cmd.CommandText = String.Format("Delete From Templates Where TemplateId = {0}", rowTemplates["TemplateId"]);
                        cmd.ExecuteNonQuery();
                        gridControlMain.DataSource = LoadTemplates();
                        break;

                    case "gridViewUsers":
                        DataRow rowUsers = gridViewUsers.GetFocusedDataRow();
                        cmd.CommandText = String.Format("Delete From Users Where UserID = {0}", rowUsers["UserID"]);
                        cmd.ExecuteNonQuery();
                        gridControlMain.DataSource = LoadUsers();
                        break;
                    default:
                        break;
                }
                MyCL.ShowMsg(" „ «·Õ–›", false, this, true);
            }
            catch (SqlException ex)
            {
                MyCL.ShowMsg(MyCL.CheckExp(ex), true, this, true);
            }
            con.Close();
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SqlConnection con = new SqlConnection(MyCL.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                con.Open();
                switch (gridControlMain.MainView.Name)
                {
                    case "gridViewSetting":
                        DataRow rowSetting = gridViewSetting.GetFocusedDataRow();
                        cmd.CommandText = String.Format(@"IF Not exists(select * from Setting Where ServiceNum = N'{0}')
                        Insert Into Setting (ServiceNum) VALUES (N'{0}')", rowSetting["ServiceNum"]);
                        cmd.ExecuteNonQuery();
                        gridControlMain.DataSource = LoadSetting();
                        break;

                    case "gridViewGroups":
                        DataRow rowGroups = gridViewGroups.GetFocusedDataRow();
                        cmd.CommandText = String.Format(@"IF Not exists(select * from Groups Where GroupName = N'{0}')
                        Insert Into Groups (GroupName) VALUES (N'{0}')", rowGroups["GroupName"]);
                        cmd.ExecuteNonQuery();
                        gridControlMain.DataSource = LoadGroups();
                        break;

                    case "gridViewContacts":
                        DataRow rowContacts = gridViewContacts.GetFocusedDataRow();
                        if (rowContacts["ContactID"].ToString() == string.Empty)
                        {
                            cmd.CommandText = String.Format(@"Insert Into Contacts (ContactName, ContactNumber, GroupID) VALUES (N'{0}', N'{1}', N'{2}')",
                            rowContacts["ContactName"], rowContacts["ContactNumber"], rowContacts["GroupID"]);
                        }
                        else
                        {
                            cmd.CommandText = String.Format(@"Update Contacts Set ContactName = N'{0}', ContactNumber = N'{1}', GroupID = N'{2}' Where ContactID = {3}",
                            rowContacts["ContactName"], rowContacts["ContactNumber"], rowContacts["GroupID"], rowContacts["ContactID"]);
                        }
                        cmd.ExecuteNonQuery();
                        gridControlMain.DataSource = LoadContacts();
                        break;

                    case "gridViewMessages":
                        //DataRow rowMessages = gridViewMessages.GetFocusedDataRow();
                        //if (rowMessages["messageid"].ToString() == string.Empty)
                        //{
                        //    cmd.CommandText = String.Format(@"Insert Into Messages (messageBody, number, status, SendTime) VALUES (N'{0}', N'{1}', {2}, GETDATE())",
                        //    rowMessages["messageBody"], rowMessages["number"], rowMessages["status"]);
                        //}
                        //else
                        //{
                        //    cmd.CommandText = String.Format(@"Update Messages Set messageBody = N'{0}', number = N'{1}', status = {2} Where messageid = {3}",
                        //    rowMessages["messageBody"], rowMessages["number"], rowMessages["status"], rowMessages["messageid"]);
                        //}
                        //cmd.ExecuteNonQuery();
                        //gridControlMain.DataSource = LoadMessages();
                        break;

                    case "gridViewTemplates":
                        DataRow rowTemplates = gridViewTemplates.GetFocusedDataRow();
                        if (rowTemplates["TemplateId"].ToString() == string.Empty)
                        {
                            cmd.CommandText = String.Format(@"Insert Into Templates (TemplateBody) VALUES (N'{0}')", rowTemplates["TemplateBody"]);
                        }
                        else
                        {
                            cmd.CommandText = String.Format(@"Update Templates Set TemplateBody = N'{0}' Where TemplateId = {1}",
                            rowTemplates["TemplateBody"], rowTemplates["TemplateId"]);
                        }
                        cmd.ExecuteNonQuery();
                        gridControlMain.DataSource = LoadTemplates();
                        break;

                    case "gridViewUsers":
                        DataRow rowUsers = gridViewUsers.GetFocusedDataRow();
                        if (rowUsers["UserID"].ToString() == string.Empty)
                        {
                            cmd.CommandText = String.Format(@"Insert Into Users (PassWord, UserName) VALUES (N'{0}', N'{1}')",
                            rowUsers["PassWord"], rowUsers["UserName"]);
                        }
                        else
                        {
                            cmd.CommandText = String.Format(@"Update Users Set PassWord = N'{0}', UserName = N'{1}' Where UserID = {2}",
                            rowUsers["PassWord"], rowUsers["UserName"], rowUsers["UserID"]);
                        }
                        cmd.ExecuteNonQuery();
                        gridControlMain.DataSource = LoadUsers();
                        break;
                    case "cardViewe_schoolDB":
                        DataRow rowschoolDB = cardViewe_schoolDB.GetFocusedDataRow();
                        cmd.CommandText = string.Format(@"Update e_schoolDB Set Stu_DB_Path = N'{0}', Result_DB_Path = N'{1}', acc_sms_DB_Path =  N'{2}', malafatSms_DB_Path = N'{3}'",
                        rowschoolDB["Stu_DB_Path"], rowschoolDB["Result_DB_Path"], rowschoolDB["acc_sms_DB_Path"], rowschoolDB["malafatSms_DB_Path"]);
                        cmd.ExecuteNonQuery();
                        MyCL.SchoolDBPath = rowschoolDB["Stu_DB_Path"].ToString();
                        MyCL.DatanetDBPath = rowschoolDB["Result_DB_Path"].ToString();
                        MyCL.acc_smsDBPath = rowschoolDB["acc_sms_DB_Path"].ToString();
                        MyCL.malafatSmsDBPath = rowschoolDB["malafatSms_DB_Path"].ToString();
                        gridControlMain.DataSource = Loade_schoolDB();
                        break;
                    default:
                        break;
                }
                MyCL.ShowMsg(" „ «·Õ›Ÿ", false, this, true);
            }
            catch (SqlException ex)
            {
                MyCL.ShowMsg(MyCL.CheckExp(ex), true, this, true);
            }
            
        }
        private void repositoryItemButtonEditStu_DB_Path_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() { CheckFileExists = true, Filter = "School Database|dataschool.mdb|All Files(*.*)|*.*", Title = "«Œ «— ﬁ«⁄œ… »Ì«‰«  «·ÿ·«»" };
            if (ofd.ShowDialog() == Alias.DialogResult.Cancel)
                return;
            DataRow row = cardViewe_schoolDB.GetFocusedDataRow();
            if (row["ID"].ToString() == string.Empty)
                return;
            row["Stu_DB_Path"] = ofd.FileName;
        }
        private void repositoryItemButtonEditResult_DB_Path_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() { CheckFileExists = true, Filter = "Result Database|Datanet.mdb|All Files(*.*)|*.*", Title = "«Œ «— ﬁ«⁄œ… »Ì«‰«  «·‰ «∆Ã" };
            if (ofd.ShowDialog() == Alias.DialogResult.Cancel)
                return;
            DataRow row = cardViewe_schoolDB.GetFocusedDataRow();
            if (row["ID"].ToString() == string.Empty)
                return;
            row["Result_DB_Path"] = ofd.FileName;
        }
        private void repositoryItemButtonEditacc_sms_DB_Path_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() { CheckFileExists = true, Filter = "Account Database|Daccount.mdb|All Files(*.*)|*.*", Title = "«Œ «— ﬁ«⁄œ… »Ì«‰«  «·Õ”«»« " };
            if (ofd.ShowDialog() == Alias.DialogResult.Cancel)
                return;
            DataRow row = cardViewe_schoolDB.GetFocusedDataRow();
            if (row["ID"].ToString() == string.Empty)
                return;
            row["acc_sms_DB_Path"] = ofd.FileName;
        }
        private void repositoryItemButtonEditmalafatSms_DB_Path_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() { CheckFileExists = true, Filter = "malafat Database|malafatSms.mdb|All Files(*.*)|*.*", Title = "«Œ «— ﬁ«⁄œ… »Ì«‰«  «·⁄«„·Ì‰" };
            if (ofd.ShowDialog() == Alias.DialogResult.Cancel)
                return;
            DataRow row = cardViewe_schoolDB.GetFocusedDataRow();
            if (row["ID"].ToString() == string.Empty)
                return;
            row["malafatSms_DB_Path"] = ofd.FileName;
        }
        private void TmrSignal_Tick(object sender, EventArgs e)
        {
            TmrSignal.Stop(); TmrSignal.Enabled = false;
            ReadSignal();
        }
        
        private void LblMsg_DoubleClick(object sender, EventArgs e)
        {
            gridControlMain.MainView = gridViewLogDetails;
            gridControlMain.DataSource = ActionLogTbl;
        }
        private void TxtMsg_EditValueChanged(object sender, EventArgs e)
        {
            //System.Math.Round(,MidpointRounding.AwayFromZero);
            LblMsgCounter.Text = (TxtMsg.Text.Length / 70).ToString();
            if ((TxtMsg.Text.Length % 70) > 0)
                LblMsgCounter.Text = (Convert.ToInt32(LblMsgCounter.Text) + 1).ToString();
            LblCharCounter.Text = ((Convert.ToInt32(LblMsgCounter.Text) * 70) - TxtMsg.Text.Length).ToString();

            LblCharCounter.Text = "⁄œœ «·Õ—Ê›: " + LblCharCounter.Text;
            LblMsgCounter.Text = "⁄œœ «·—”«∆·: " + LblMsgCounter.Text;
        }
        private void CBAddVar_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.OK)
                return;
            if (TxtMsg.Text != string.Empty)
            {
                if (TxtMsg.Text[TxtMsg.Text.Length - 1] != Convert.ToChar(" "))
                    TxtMsg.Text += " ";
            }
            TxtMsg.Text += CBAddVar.SelectedText;
        }
        private void CMSdataschool_Opening(object sender, CancelEventArgs e)
        {
            //if (gridControlMain.MainView != gridViewdataschool)
            //    e.Cancel = true;
            switch (gridControlMain.MainView.Name)
            {
                case "gridViewdataschool":
                    toolStripMenuItemAdd.Visible = true;
                    break;

                case "gridViewMessages":
                    toolStripMenuItemAdd.Visible = false;
                    break;

                case "gridViewDatanet":
                    toolStripMenuItemAdd.Visible = true;
                    break;
                case "gridViewacc_sms":
                    toolStripMenuItemAdd.Visible = true;
                    break;
                case "gridViewmalafatSms":
                    toolStripMenuItemAdd.Visible = true;
                    break;
                default:
                    e.Cancel = true;
                    break;
            }
        }
        private void toolStripMenuItemSelectAll_Click(object sender, EventArgs e)
        {
            switch (gridControlMain.MainView.Name)
            {
                case "gridViewdataschool":
                    for (int i = 0; i < gridViewdataschool.RowCount; i++)
                    {
                        DataRowView row = (DataRowView)gridViewdataschool.GetRow(gridViewdataschool.GetVisibleRowHandle(i));
                        row["checked"] = !Convert.ToBoolean(row["checked"]);
                    }
                    break;

                case "gridViewMessages":
                    for (int i = 0; i < gridViewMessages.RowCount; i++)
                    {
                        DataRowView row = (DataRowView)gridViewMessages.GetRow(gridViewMessages.GetVisibleRowHandle(i));
                        row["checked"] = !Convert.ToBoolean(row["checked"]);
                    }
                    break;

                case "gridViewDatanet":
                    for (int i = 0; i < gridViewDatanet.RowCount; i++)
                    {
                        DataRowView row = (DataRowView)gridViewDatanet.GetRow(gridViewDatanet.GetVisibleRowHandle(i));
                        row["perm"] = !Convert.ToBoolean(row["perm"]);
                    }
                    break;
                case "gridViewacc_sms":
                    for (int i = 0; i < gridViewacc_sms.RowCount; i++)
                    {
                        DataRowView row = (DataRowView)gridViewacc_sms.GetRow(gridViewacc_sms.GetVisibleRowHandle(i));
                        row["checked"] = !Convert.ToBoolean(row["checked"]);
                    }
                    break;
                case "gridViewmalafatSms":
                    for (int i = 0; i < gridViewmalafatSms.RowCount; i++)
                    {
                        DataRowView row = (DataRowView)gridViewmalafatSms.GetRow(gridViewmalafatSms.GetVisibleRowHandle(i));
                        row["checked"] = !Convert.ToBoolean(row["checked"]);
                    }
                    break;
                default:
                    break;
            }
            
            
        }
        private void toolStripMenuItemAdd_Click(object sender, EventArgs e)
        {
            
            switch (gridControlMain.MainView.Name)
            {
                case "gridViewdataschool":
                    for (int i = 0; i < gridViewdataschool.RowCount; i++)
                    {
                        DataRowView row = (DataRowView)gridViewdataschool.GetRow(gridViewdataschool.GetVisibleRowHandle(i));
                        if (Convert.ToBoolean(row["checked"]))
                        {
                            if (!PhoneInList(row["waleaalkamr_mobile"].ToString()))
                                AddToPhonesList(row["waleaalkamr_mobile"].ToString(), row["stu_code"].ToString());
                        }
                    }
                    break;
                case "gridViewDatanet":
                    for (int i = 0; i < gridViewDatanet.RowCount; i++)
                    {
                        DataRowView row = (DataRowView)gridViewDatanet.GetRow(gridViewDatanet.GetVisibleRowHandle(i));
                        if (Convert.ToBoolean(row["perm"]))
                        {
                            if (!PhoneInList(row["mobil"].ToString()))
                                AddToPhonesList(row["mobil"].ToString(), row["stu_code"].ToString(), row["asase_code"].ToString(), row["manth_code"].ToString());
                        }
                    }
                    break;
                case "gridViewacc_sms":
                    for (int i = 0; i < gridViewacc_sms.RowCount; i++)
                    {
                        DataRowView row = (DataRowView)gridViewacc_sms.GetRow(gridViewacc_sms.GetVisibleRowHandle(i));
                        if (Convert.ToBoolean(row["checked"]))
                        {
                            if (!PhoneInList(row["mobil"].ToString()))
                                AddToPhonesList(row["mobil"].ToString(), row["stu_code"].ToString(), asase: row["asase_code"].ToString());
                        }
                    }
                    break;
                case "gridViewmalafatSms":
                    for (int i = 0; i < gridViewmalafatSms.RowCount; i++)
                    {
                        DataRowView row = (DataRowView)gridViewmalafatSms.GetRow(gridViewmalafatSms.GetVisibleRowHandle(i));
                        if (Convert.ToBoolean(row["checked"]))
                        {
                            if (!PhoneInList(row["mobil"].ToString()))
                                AddToPhonesList(row["mobil"].ToString(), row["empId"].ToString());
                        }
                    }
                    break;
                default:
                    break;
            }
        }
        private void groupItToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string GroupID = string.Empty;
            GroupSelectorFrm frm = new GroupSelectorFrm();
            if (frm.ShowDialog() != Alias.DialogResult.OK)
                return;
            GroupID = frm.GroupID;

            SqlConnection con = new SqlConnection(MyCL.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandText = "INSERT INTO Contacts (ContactName, ContactNumber, GroupID) VALUES (@ContactName, @ContactNumber, @GroupID)";
            cmd.Parameters.Add(new SqlParameter("@ContactName", SqlDbType.NVarChar));
            cmd.Parameters.Add(new SqlParameter("@ContactNumber", SqlDbType.NVarChar));
            cmd.Parameters.Add(new SqlParameter("@GroupID", SqlDbType.NVarChar));
            try
            {
                con.Open();
                switch (gridControlMain.MainView.Name)
                {
                    case "gridViewdataschool":
                        for (int i = 0; i < gridViewdataschool.RowCount; i++)
                        {
                            DataRowView row = (DataRowView)gridViewdataschool.GetRow(gridViewdataschool.GetVisibleRowHandle(i));
                            if (Convert.ToBoolean(row["checked"]))
                            {
                                cmd.Parameters["@ContactName"].Value = row["stu_name"];
                                cmd.Parameters["@ContactNumber"].Value = row["waleaalkamr_mobile"];
                                cmd.Parameters["@GroupID"].Value = GroupID;
                                cmd.ExecuteNonQuery();
                            }
                        }
                        break;
                    case "gridViewDatanet":
                        for (int i = 0; i < gridViewDatanet.RowCount; i++)
                        {
                            DataRowView row = (DataRowView)gridViewDatanet.GetRow(gridViewDatanet.GetVisibleRowHandle(i));
                            if (Convert.ToBoolean(row["perm"]))
                            {
                                cmd.Parameters["@ContactName"].Value = row["stu_name"];
                                cmd.Parameters["@ContactNumber"].Value = row["mobil"];
                                cmd.Parameters["@GroupID"].Value = GroupID;
                                cmd.ExecuteNonQuery();
                            }
                        }
                        break;
                    case "gridViewacc_sms":
                        for (int i = 0; i < gridViewacc_sms.RowCount; i++)
                        {
                            DataRowView row = (DataRowView)gridViewacc_sms.GetRow(gridViewacc_sms.GetVisibleRowHandle(i));
                            if (Convert.ToBoolean(row["checked"]))
                            {
                                cmd.Parameters["@ContactName"].Value = row["stu_name"];
                                cmd.Parameters["@ContactNumber"].Value = row["mobil"];
                                cmd.Parameters["@GroupID"].Value = GroupID;
                                cmd.ExecuteNonQuery();
                            }
                        }
                        break;
                    case "gridViewmalafatSms":
                        for (int i = 0; i < gridViewmalafatSms.RowCount; i++)
                        {
                            DataRowView row = (DataRowView)gridViewmalafatSms.GetRow(gridViewmalafatSms.GetVisibleRowHandle(i));
                            if (Convert.ToBoolean(row["checked"]))
                            {
                                cmd.Parameters["@ContactName"].Value = row["empname"];
                                cmd.Parameters["@ContactNumber"].Value = row["mobil"];
                                cmd.Parameters["@GroupID"].Value = GroupID;
                                cmd.ExecuteNonQuery();
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (SqlException ex)
            {
                MyCL.ShowMsg(MyCL.CheckExp(ex), true, this, true);
            }
            con.Close();
           
        }
        private void CBEPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBEPort.SelectedIndex < 0)
            {
                LblDeviceName.Text = string.Empty;
                return;
            }
            LblDeviceName.Text = DeviceFullName(CBEPort.Text);
        }
        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                USBserialPort.DiscardInBuffer();
                USBserialPort.DiscardOutBuffer();
                USBserialPort.Close();
                USBserialPort.Dispose();
            }
            catch { }
        }
        private void navBarItemQry_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gridControlMain.MainView = gridViewQry;
            gridControlMain.DataSource = Loade_Qry();
        }
        #endregion

        
    
    }
}