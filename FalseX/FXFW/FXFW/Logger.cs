using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace FXFW
{
    public class Logger
    {
        #region -   Variables   -
        public static string LogFilePath = Application.StartupPath + @"\FXFWLogger.log";
        public LogDetails _LogDetails;
        private LoggerFrm LogForm;
        private LanguageInfo _Language;
        public struct LogDetails
        {
            public string message;
            public string FormTitle;
            public OpType OpType;
            public Exception Ex;
            public SqlException ExSql;
            public Form Owner;
        }
        public enum OpType
        {
            success,
            fail,
            warning,
            information,
        }
        public enum LanguageInfo
        {
            Arabic,
            English
        }
        #region Public Properties
        public bool showMSG { get; set; }
        private LanguageInfo Language
        {
            get { return _Language; }
            set
            {
                if (value == LanguageInfo.Arabic)
                {
                    //LogForm.RightToLeft = RightToLeft.Yes;
                    LogForm.Text = "نتائج";
                }
                else
                {
                   //LogForm.RightToLeft = RightToLeft.No;
                    LogForm.Text = "Log";
                }
                _Language = value;
            }
        }
        public string AppName { get; set; }
        public Image AppLogo { get; set; }
        public bool ShowHideLogWindow
        {
            get
            {
                return LogForm.Visible; 
            }
            set
            {
                if (value == true)
                    LogForm.Show();
                else
                    LogForm.Hide();
            }
        }
        #endregion
        #endregion
        #region -   Functions   -
        public Logger(LanguageInfo Lang, string ApplicationName, Image ApplicationLogo, bool ShowLogInMessage)
        {
            LogForm = new LoggerFrm() { Icon = Properties.Resources.FXFW };
            Language = Lang;
            AppName = ApplicationName;
            showMSG = ShowLogInMessage;
            AppLogo = ApplicationLogo;

            StartLog();
        }
        private string CheckExp(SqlException ex)
        {
            switch (ex.Number)
            {
                case 2627:
                    if (_Language == LanguageInfo.Arabic)
                        return "موجود مسبقا";
                    else
                        return "Already Exists";
                case 515:
                    string ReturnMe = string.Empty;
                    if (_Language == LanguageInfo.Arabic)
                        ReturnMe = "يجب مليء " + Environment.NewLine;
                    else
                        ReturnMe = "Must Enter " + Environment.NewLine;
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
                    if (_Language == LanguageInfo.Arabic)
                        return String.Format("خطاء في نوع البيان {0}من فضلك فحص الارقام و التواريخ", Environment.NewLine);
                    else
                        return String.Format("Error in data type {0} Please check data numbers and dates", Environment.NewLine);
                    
                case 242:
                    if (_Language == LanguageInfo.Arabic)
                        return String.Format("خطاء في ادخال التاريخ {0}من فضلك تأكد ان صياغة التاريخ هي {0}سنه/شهر/يوم", Environment.NewLine);
                    else
                        return String.Format("Error in data type (Date) {0} Please check that entered dates is in correct format(year/month/days)", Environment.NewLine);
                default:
                    return ex.Message;
            }
        }
        /// <summary>
        /// Should Called at the Start Point of Log
        /// </summary>
        /// <returns>void</returns>
        private void StartLog()
        {
            bool tmp = showMSG;
            showMSG = false;
            string time = string.Format("{0}-{1}-{2} {3}:{4}:{5}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            switch (_Language)
            {
                case LanguageInfo.Arabic:
                    LogThis(String.Format("========== بداء التدوين في: [ {0} ] ==========", time), AppName, OpType.information, null, null, null);
                    break;
                case LanguageInfo.English:
                    LogThis(String.Format("========== Logging Started At: [ {0} ] ==========", time), AppName, OpType.information, null, null, null);
                    break;
                default:
                    break;
            }

            showMSG = tmp;
        }
        /// <summary>
        /// Creates a Log for [success/fail/warning/information] message Raised, can be used in Catch Blocks
        /// </summary>
        /// <returns>void</returns>
        public void LogThis([Optional]string message, [Optional] string FormTitle, OpType msgType, [Optional] Exception Ex, [Optional] SqlException ExSql, [Optional] Form Owner)
        {
            try
            {
                _LogDetails = new LogDetails();

                _LogDetails.OpType = msgType;
                _LogDetails.Ex = Ex;
                _LogDetails.ExSql = ExSql;
                if (message == null)
                {
                    if (Ex != null)
                        _LogDetails.message = Ex.Message;
                    else
                        _LogDetails.message = CheckExp(ExSql);
                }
                else
                    _LogDetails.message = message;
                if (Owner == null)
                    _LogDetails.FormTitle = FormTitle;
                else
                    _LogDetails.FormTitle = Owner.Text;
                PrepareVisualLog(_LogDetails, Owner);
            }
            catch 
            {            }
        }
        private void PrepareVisualLog(LogDetails LogMe, [Optional] Form Owner)
        {
            LogForm.AppendToLog(_LogDetails);
            if (showMSG == true)
            {
                MSGBOXFrm msg = new MSGBOXFrm(LogMe, Owner){ Icon = Properties.Resources.FXFW, Text = AppName};
                msg.PictureBoxCoLogo.Image = AppLogo;
                switch (Language)
                {
                    case LanguageInfo.Arabic:
                        msg.RightToLeft = RightToLeft.Yes;
                        msg.RightToLeftLayout = true;
                        break;
                    case LanguageInfo.English:
                        msg.RightToLeft = RightToLeft.No;
                        msg.RightToLeftLayout = false;
                        break;
                    default:
                        break;
                }
                msg.ShowDialog();
            }
        }
        #endregion
    }
}
