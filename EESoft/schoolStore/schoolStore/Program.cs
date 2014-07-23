using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace schoolStore
{
    static class Program
    {
        public static FXFW.SqlDB MC = new FXFW.SqlDB();
        public static string AccountIdCustomer = "11";//كود العملاء في شجرةالحسابات
        public static string AccountTreeIdCustomer = "1020010001";//اول كود شجره لاول عميل
        public static string AccountIdSuppler = "10";//كود الموردين في شجرةالحسابات
        public static string AccountTreeIdSuppler = "201001";//اول كود شجره لاول مورد
        public enum HarakaType
        {
            مرتجع = 1, مبيعات = 2
        }
        public enum DiscountType
        {
            مبلغ = 1, نسبة = 2, بدون_خصم = 3
        }
        public enum AppOptions
        {
            customer, supplier, purchasing
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            if (FXFW.SqlDB.LoadSqlDBPath("schoolStore") && Authentication())
            {
                FXFW.SqlDB.LoadSQLReports();
                Application.Run(new schoolStoreMainFrm());
            }
        }
        public static void msg(string StringMessage, bool ShowErrorNo, string StringErrorNo, Form OwnerForm)
        {
            using (MSGBOXFrm msgbox = new MSGBOXFrm(StringMessage, ShowErrorNo, StringErrorNo))
            {
                msgbox.ShowDialog(OwnerForm);
            }
        }
        public static string CheckExp(SqlException ex)
        {
            switch (ex.Number)
            {
                case 2627:
                    return "موجود مسبقا";
                case 515:
                    string ReturnMe = "يجب مليء " + Environment.NewLine;
                    int tempint = 0;
                    foreach (char Chr in ex.Message.ToCharArray())
                    {
                        //Get column name from error msg and its between ''
                        char Dot = '\'';

                        if (Chr == Dot)
                            tempint++;
                        if (tempint == 1)
                            ReturnMe += Chr;
                        else if (tempint == 2)
                            break;
                    }
                    return ReturnMe + "'";
                case 241:
                    return String.Format("خطاء في نوع البيان {0}من فضلك فحص الارقام و التواريخ", Environment.NewLine);
                case 242:
                    return String.Format("خطاء في ادخال التاريخ {0}من فضلك تأكد ان صياغة التاريخ هي {0}سنه/شهر/يوم", Environment.NewLine);
                default:
                    return ex.Message;
            }
        }
        public static bool DeleteRow(string TableName, string RowIDName, string RowIDValue)
        {
            bool ReturnMe = false;
            SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand Cmd = new SqlCommand(String.Format("DELETE FROM {0} WHERE ({1} = {2})", TableName, RowIDName, RowIDValue), Con);
            try
            {
                Con.Open();
                if (Cmd.ExecuteNonQuery().ToString() != "0")
                {
                    ReturnMe = true;
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.ErrorCode.ToString());
            }
            Con.Close();
            return ReturnMe;
        }
        public static string GetOptionValue(AppOptions AppOp)
        {
            string ReturnMe = "0";
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                cmd.CommandText = string.Format("Select opvalue From CDOptions Where opname = N'{0}'", AppOp);
                con.Open();
                ReturnMe = cmd.ExecuteScalar().ToString();
            }
            catch (SqlException)
            { }
            con.Close();
            return ReturnMe;
        }
        public static bool SetOptionValue(AppOptions AppOp, string Value)
        {
            bool ReturnMe = false;
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                cmd.CommandText = string.Format("Update CDOptions Set opvalue = N'{0}' Where opname = N'{1}'", Value, AppOp);
                con.Open();
                cmd.ExecuteNonQuery();
                ReturnMe = true;
            }
            catch (SqlException)
            { }
            con.Close();
            return ReturnMe;
        }
        public static string GetNewID(string TableName, string ColumnName)
        {
            string ReturnMe = string.Empty;
            SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand Cmd = new SqlCommand("SELECT ISNULL(MAX(" + ColumnName + ") + 1, 1) AS NewID FROM " + TableName + " AS NewID", Con);
            SqlDataReader dr;
            try
            {
                Con.Open();
                dr = Cmd.ExecuteReader();
                if (dr.HasRows)
                    dr.Read();
                ReturnMe = dr.GetValue(0).ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.ErrorCode.ToString());
            }
            Con.Close();
            return ReturnMe;
        }
        public static string GetNewID(string TableName, string ColumnName, string Condition)
        {
            string ReturnMe = string.Empty;
            SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand Cmd = new SqlCommand(String.Format("SELECT ISNULL(MAX({0}) + 1, 1) AS NewID FROM {1} Where {2}", ColumnName, TableName, Condition), Con);
            SqlDataReader dr;
            try
            {
                Con.Open();
                dr = Cmd.ExecuteReader();
                if (dr.HasRows)
                    dr.Read();
                ReturnMe = dr.GetValue(0).ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.ErrorCode.ToString());
            }
            Con.Close();
            return ReturnMe;
        }
        private static bool Authentication()
        {
            string filePath = Application.StartupPath + "\\lnc.key";
            
            if (!System.IO.File.Exists(filePath))
            {
                using (FXFW.LicenseKeyFrm dlg = new FXFW.LicenseKeyFrm(Application.ProductName))
                {
                    dlg.ShowDialog();
                }
            }

            if (!System.IO.File.Exists(filePath))
                return false;
            else
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(filePath);
                string Key = sr.ReadToEnd();
                sr.Close();
                if (FXFW.LicenseKeyFrm.Compare(Key, Application.ProductName))
                    return true;
                else
                {
                    System.IO.File.Delete(filePath);
                    Application.Restart();
                    Application.Exit();
                    return false;
                }
            }
        }
        
    }
}
