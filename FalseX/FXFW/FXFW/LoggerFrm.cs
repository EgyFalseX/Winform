using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FXFW
{
    public partial class LoggerFrm : Form
    {
           
        #region -   Variables   -
        private FormColorInfo FormColor;
        struct FormColorInfo
        {
            public Color success;
            public Color fail;
            public Color warning;
            public Color information;
            public Color Caption;
        }
        #endregion
        #region -   Functions   -
        public LoggerFrm()
        {
            InitializeComponent();

            FormColor.success = Color.Green;
            FormColor.fail = Color.Red;
            FormColor.warning = Color.FromArgb(0xCC, 0xCC, 0x00);
            FormColor.information = Color.Blue;
            FormColor.Caption = Color.Black;
        
        }
        public void AppendToLog(Logger.LogDetails _LogDetails)
        {
            
            string time = string.Format("{0}-{1}-{2} {3}:{4}:{5}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);

            RTBMain.ReadOnly = false;
            RTBMain.AppendText(Environment.NewLine);
            Clipboard.SetImage(imageListMain.Images[(int)_LogDetails.OpType]);
            RTBMain.Paste();
            Clipboard.Clear();
            RTBMain.ReadOnly = true;


            int start = RTBMain.TextLength, startToSave = RTBMain.TextLength;
            RTBMain.AppendText(String.Format("[{0}] [{1}] [{2}]: ", time, _LogDetails.FormTitle, _LogDetails.OpType));
            RTBMain.Select(start, RTBMain.TextLength - start);
            RTBMain.SelectionColor = FormColor.Caption;
            RTBMain.SelectionFont = new Font(RTBMain.SelectionFont.FontFamily, RTBMain.SelectionFont.Size, FontStyle.Bold);
            
            start = RTBMain.TextLength;
            RTBMain.AppendText(_LogDetails.message);

            string DetailsText = string.Empty;
            Color detailsColor = new Color();
           
            switch (_LogDetails.OpType)
            {
                case Logger.OpType.success:
                    detailsColor = FormColor.success;
                    break;
                case Logger.OpType.fail:
                    if (_LogDetails.Ex != null && _LogDetails.ExSql == null)
                    {
                        DetailsText += String.Format("Message: {0}{1}", _LogDetails.Ex.Message, Environment.NewLine);
                        DetailsText += String.Format("HelpLink: {0}{1}", _LogDetails.Ex.HelpLink, Environment.NewLine);
                        DetailsText += String.Format("GetHashCode: {0}{1}", _LogDetails.Ex.GetHashCode(), Environment.NewLine);
                        DetailsText += String.Format("Source: {0}{1}", _LogDetails.Ex.Source, Environment.NewLine);
                        DetailsText += String.Format("StackTrace: {0}{1}", _LogDetails.Ex.StackTrace, Environment.NewLine);
                        DetailsText += String.Format("Exception String: {0}{1}", _LogDetails.Ex.ToString(), Environment.NewLine);
                        RTBMain.AppendText(Environment.NewLine + DetailsText);
                    }
                    else if (_LogDetails.Ex == null && _LogDetails.ExSql != null)
                    {
                        DetailsText += String.Format("Message: {0}{1}", _LogDetails.ExSql.Message, Environment.NewLine);
                        DetailsText += String.Format("Number: {0}{1}", _LogDetails.ExSql.Number, Environment.NewLine);
                        DetailsText += String.Format("Source: {0}{1}", _LogDetails.ExSql.Source, Environment.NewLine);
                        DetailsText += String.Format("Server: {0}{1}", _LogDetails.ExSql.Server, Environment.NewLine);
                        DetailsText += String.Format("Procedure: {0}{1}", _LogDetails.ExSql.Procedure, Environment.NewLine);
                        DetailsText += String.Format("Sql Error LineNumber: {0}{1}", _LogDetails.ExSql.LineNumber, Environment.NewLine);
                        DetailsText += String.Format("HelpLink: {0}{1}", _LogDetails.ExSql.HelpLink, Environment.NewLine);
                        for (int i = 0; i < _LogDetails.ExSql.Errors.Count; i++)
                            DetailsText += String.Format("Error {0}: {1}{2}", i, _LogDetails.ExSql.Errors[i].Message, Environment.NewLine);
                        DetailsText += String.Format("ErrorCode: {0}{1}", _LogDetails.ExSql.ErrorCode, Environment.NewLine);
                        DetailsText += "==================================================================== " + Environment.NewLine;
                        DetailsText += String.Format("StackTrace: {0}{1}", _LogDetails.ExSql.StackTrace, Environment.NewLine);
                        RTBMain.AppendText(Environment.NewLine + DetailsText);
                    }
                    detailsColor = FormColor.fail;
                    break;
                case Logger.OpType.warning:
                    detailsColor = FormColor.warning;
                    break;
                case Logger.OpType.information:
                    detailsColor = FormColor.information;
                    break;
                default:
                    break;
            }
            
            RTBMain.Select(start, RTBMain.TextLength - start);
            RTBMain.SelectionColor = detailsColor;
            RTBMain.SelectionFont = new Font(RTBMain.SelectionFont.FontFamily, RTBMain.SelectionFont.Size, FontStyle.Regular);

            //RTBMain.Select(startToSave, RTBMain.TextLength - startToSave);
            //Save Log To File
            SaveLogToFile(Environment.NewLine + RTBMain.Text.Substring(startToSave));
        }
        public void SaveLogToFile(string DataToSave) 
        {
            using (StreamWriter sw = new StreamWriter(Logger.LogFilePath, true))
            {
                sw.Write(DataToSave);
                //RTBMain.SaveFile(sw.BaseStream, RichTextBoxStreamType.PlainText);
                sw.Flush();
            }
        }
        #endregion
        #region - Event Handlers -
        private void LoggerFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
            RTBMain.SaveFile("FXFW.logger.PlainText", RichTextBoxStreamType.PlainText);
        }
        
        #endregion         #region -   Variables   -


    }
}
