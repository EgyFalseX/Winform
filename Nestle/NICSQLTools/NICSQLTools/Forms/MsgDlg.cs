using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using log4net;

namespace System.Windows.Forms
{
    public partial class MsgDlg : DevExpress.XtraEditors.XtraForm
    {
        private Color SuccessColor = Color.Green;
        private Color ErrorColor = Color.Red;
        private Color InfoColor = Color.Blue;

        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(MsgDlg));
        private static DevExpress.XtraBars.Alerter.AlertControl Alert = new DevExpress.XtraBars.Alerter.AlertControl() { AutoFormDelay = 4000 };
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
        public static DialogResult Show(string msg, MessageType msgType, Exception ex = null)
        {
            using (MsgDlg msgDlg = new MsgDlg(msg, msgType, ex))
            {
                return msgDlg.ShowDialog();
            }
        }
        public MsgDlg(string msg, MessageType msgType, Exception ex)
        {
            InitializeComponent();
            
            SetButtons(msgType);
            SetIconAndLog(msg, msgType, ex);

            if (ex != null)
            {
                this.Size = new Size(410, 300);
                tbStackTrace.Visible = true;
                tbStackTrace.Text = ex.StackTrace;
            }
            else
            {
                this.Size = new Size(410, 180);
                tbStackTrace.Visible = false;
            }

            tbMSG.EditValue = msg;
        }
        private void SetButtons(MessageType msgType)
        {
            switch (msgType)
            {
                case MessageType.Success:
                case MessageType.Error:
                case MessageType.Info:
                case MessageType.Debug:
                case MessageType.Fatal:
                case MessageType.Warn:
                    btnYes.Visible = false;
                    btnNo.Visible = false;
                    btnClose.Visible = true;
                    break;
                case MessageType.Question:
                    btnYes.Visible = true;
                    btnNo.Visible = true;
                    btnClose.Visible = false;
                    break;
            }
        }
        private void SetIconAndLog(string msg, MessageType msgType, Exception ex)
        {
            switch (msgType)
            {
                case MessageType.Success:
                    pb.Image = NICSQLTools.Properties.Resources.MSG_Success;
                    tbMSG.ForeColor = SuccessColor;
                    if (ex  == null)
                        Logger.Info(msg);
                    else
                        Logger.Info(msg, ex);
                    break;
                case MessageType.Error:
                    pb.Image = NICSQLTools.Properties.Resources.MSG_Error;
                    tbMSG.ForeColor = ErrorColor;
                    if (ex == null)
                        Logger.Error(msg);
                    else
                        Logger.Error(msg, ex);
                    break;
                case MessageType.Info:
                    pb.Image = NICSQLTools.Properties.Resources.MSG_Information;
                    tbMSG.ForeColor = InfoColor;
                    if (ex == null)
                        Logger.Info(msg);
                    else
                        Logger.Info(msg, ex);
                    break;
                case MessageType.Debug:
                    pb.Image = NICSQLTools.Properties.Resources.MSG_Information;
                    tbMSG.ForeColor = InfoColor;
                    if (ex == null)
                        Logger.Debug(msg);
                    else
                        Logger.Debug(msg, ex);
                    break;
                case MessageType.Fatal:
                    pb.Image = NICSQLTools.Properties.Resources.MSG_Error;
                    tbMSG.ForeColor = ErrorColor;
                    if (ex == null)
                        Logger.Fatal(msg);
                    else
                        Logger.Fatal(msg, ex);
                    break;
                case MessageType.Warn:
                    pb.Image = NICSQLTools.Properties.Resources.MSG_Information;
                    tbMSG.ForeColor = InfoColor;
                    if (ex == null)
                        Logger.Warn(msg);
                    else
                        Logger.Warn(msg, ex);
                    break;
                default:
                    break;
            }
        }
        public static void ShowAlert(string Msg, MessageType msgType, Form CallForm)
        {
            DevExpress.XtraBars.Alerter.AlertInfo info = new DevExpress.XtraBars.Alerter.AlertInfo(Application.ProductName, Msg);
            switch (msgType)
            {
                case MessageType.Success:
                    info.Image = NICSQLTools.Properties.Resources.done;
                    break;
                case MessageType.Error:
                    info.Image = NICSQLTools.Properties.Resources.error;
                    break;
                case MessageType.Info:
                    info.Image = NICSQLTools.Properties.Resources.info;
                    break;
                case MessageType.Debug:
                    info.Image = NICSQLTools.Properties.Resources.info;
                    break;
                case MessageType.Fatal:
                    info.Image = NICSQLTools.Properties.Resources.error;
                    break;
                case MessageType.Warn:
                    info.Image = NICSQLTools.Properties.Resources.info;
                    break;
                default:
                    break;
            }
            Alert.Show(CallForm, info);
            //Application.OpenForms[0]
        }
        private void msgDlg_Load(object sender, EventArgs e)
        {
            btnNo.Focus();
            StartVisibility();
        }
        void StartVisibility()
        {
            this.Top += 15;
            Timer tmr = new Timer();
            tmr.Interval = 50;
            tmr.Tick += (o, e) => 
            {
                if (this.Opacity < 1)
                {
                    this.Opacity += 0.2;
                    this.Top -= 5;
                }
                else
                {
                    this.Opacity = 1;
                    tmr.Stop();
                }
            };
            tmr.Start();
        }
    
    }
}
