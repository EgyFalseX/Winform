using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FXFW
{
    public partial class LoggerTreeFrm : Form
    {
           
        #region -   Variables   -
        private FormColorInfo FormColor;
        struct FormColorInfo
        {
            public Color success;
            public Color fail;
            public Color warning;
            public Color information;
        }
        public Logger.LogDetails[] AllLogDetails;
        #endregion
        #region -   Functions   -
        public LoggerTreeFrm()
        {
            InitializeComponent();

            FormColor.success = Color.Green;
            FormColor.fail = Color.Red;
            FormColor.warning = Color.Yellow;
            FormColor.information = Color.Blue;
        
        }
        public void AppendToLog(ref Logger.LogDetails[] _LogDetails)
        {
            AllLogDetails = _LogDetails;
            
            TreeNode Node = new TreeNode();
            Node.Text = string.Format(@"[{0}] [{1}] [{2}]: {3}", _LogDetails[_LogDetails.Length - 1].OpType, DateTime.Now.ToShortTimeString(), 
            _LogDetails[_LogDetails.Length - 1].FormTitle, _LogDetails[_LogDetails.Length - 1].message);

            switch (_LogDetails[_LogDetails.Length - 1].OpType)
            {
                case Logger.OpType.success:
                    Node.ForeColor = FormColor.success;
                    Node.ImageIndex = 0;
                    break;
                case Logger.OpType.fail:
                    Node.ForeColor = FormColor.fail;
                    Node.ImageIndex = 1;
                    break;
                case Logger.OpType.warning:
                    Node.ForeColor = FormColor.warning;
                    Node.ImageIndex = 2;
                    break;
                case Logger.OpType.information:
                    Node.ForeColor = FormColor.information;
                    Node.ImageIndex = 3;
                    break;
                default:
                    break;
            }
            TVMain.Nodes.Add(Node);
        }
        private void LoadDetails()
        {
            TxtDetails.Clear();

            Logger.LogDetails SelectedLog = AllLogDetails[TVMain.SelectedNode.Index];
            if (SelectedLog.Ex == null && SelectedLog.ExSql == null)
            {
                TxtDetails.Text = "No Details Found";
            }
            else if (SelectedLog.Ex != null && SelectedLog.ExSql == null)
            {
                TxtDetails.Text += String.Format("Message: {0}{1}", SelectedLog.Ex.Message, Environment.NewLine);
                TxtDetails.Text += String.Format("HelpLink: {0}{1}", SelectedLog.Ex.HelpLink, Environment.NewLine);
                TxtDetails.Text += String.Format("GetHashCode: {0}{1}", SelectedLog.Ex.GetHashCode(), Environment.NewLine);
                TxtDetails.Text += String.Format("Source: {0}{1}", SelectedLog.Ex.Source, Environment.NewLine);
                TxtDetails.Text += String.Format("StackTrace: {0}{1}", SelectedLog.Ex.StackTrace, Environment.NewLine);
                TxtDetails.Text += String.Format("Exception String: {0}{1}", SelectedLog.Ex.ToString(), Environment.NewLine);
            }
            else
            {
                TxtDetails.Text += String.Format("Message: {0}{1}", SelectedLog.ExSql.Message, Environment.NewLine);
                TxtDetails.Text += String.Format("Number: {0}{1}", SelectedLog.ExSql.Number, Environment.NewLine);
                TxtDetails.Text += String.Format("Source: {0}{1}", SelectedLog.ExSql.Source, Environment.NewLine);
                TxtDetails.Text += String.Format("Server: {0}{1}", SelectedLog.ExSql.Server, Environment.NewLine);
                TxtDetails.Text += String.Format("Procedure: {0}{1}", SelectedLog.ExSql.Procedure, Environment.NewLine);
                TxtDetails.Text += String.Format("Sql Error LineNumber: {0}{1}", SelectedLog.ExSql.LineNumber, Environment.NewLine);
                TxtDetails.Text += String.Format("HelpLink: {0}{1}", SelectedLog.ExSql.HelpLink, Environment.NewLine);
                for (int i = 0; i < SelectedLog.ExSql.Errors.Count; i++)
                    TxtDetails.Text += String.Format("Error {0}: {1}{2}", i, SelectedLog.ExSql.Errors[i].Message, Environment.NewLine);
                TxtDetails.Text += String.Format("ErrorCode: {0}{1}", SelectedLog.ExSql.ErrorCode, Environment.NewLine);
                TxtDetails.Text += "==================================================================== " + Environment.NewLine;
                TxtDetails.Text += String.Format("StackTrace: {0}{1}", SelectedLog.ExSql.StackTrace, Environment.NewLine);
            }
        }
        #endregion
        #region - Event Handlers -
        private void TVMain_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TVMain.SelectedImageIndex = TVMain.SelectedNode.ImageIndex;
            LoadDetails();
        }
        private void LoggerFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
        #endregion         #region -   Variables   -

    }
}
