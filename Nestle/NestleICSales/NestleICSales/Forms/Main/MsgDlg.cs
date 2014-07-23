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
        public static DialogResult Show(string msg, NestleICSales.Utilities.Types.MessageType msgType, Exception ex = null)
        {
            return new MsgDlg(msg, msgType, ex).ShowDialog();
        }
        public MsgDlg(string msg, NestleICSales.Utilities.Types.MessageType msgType, Exception ex)
        {
            InitializeComponent();
            
            SetButtons(msgType);
            SetIconAndLog(msg, msgType, ex);

            if (ex != null)
            {
                this.Size = new Size(410, 291);
                tbStackTrace.Visible = true;
                tbStackTrace.Text = ex.StackTrace;
            }
            else
            {
                this.Size = new Size(410, 170);
                tbStackTrace.Visible = false;
            }

            tbMSG.EditValue = msg;
        }
        private void SetButtons(NestleICSales.Utilities.Types.MessageType msgType)
        {
            switch (msgType)
            {
                case NestleICSales.Utilities.Types.MessageType.Success:
                case NestleICSales.Utilities.Types.MessageType.Error:
                case NestleICSales.Utilities.Types.MessageType.Info:
                case NestleICSales.Utilities.Types.MessageType.Debug:
                case NestleICSales.Utilities.Types.MessageType.Fatal:
                case NestleICSales.Utilities.Types.MessageType.Warn:
                    btnYes.Visible = false;
                    btnNo.Visible = false;
                    btnClose.Visible = true;
                    break;
                case NestleICSales.Utilities.Types.MessageType.Question:
                    btnYes.Visible = true;
                    btnNo.Visible = true;
                    btnClose.Visible = false;
                    break;
            }
        }
        private void SetIconAndLog(string msg, NestleICSales.Utilities.Types.MessageType msgType, Exception ex)
        {
            switch (msgType)
            {
                case NestleICSales.Utilities.Types.MessageType.Success:
                    pb.Image = NestleICSales.Properties.Resources.MSG_Success;
                    tbMSG.ForeColor = SuccessColor;
                    if (ex  == null)
                        Logger.Info(msg);
                    else
                        Logger.Info(msg, ex);
                    break;
                case NestleICSales.Utilities.Types.MessageType.Error:
                    pb.Image = NestleICSales.Properties.Resources.MSG_Error;
                    tbMSG.ForeColor = ErrorColor;
                    if (ex == null)
                        Logger.Error(msg);
                    else
                        Logger.Error(msg, ex);
                    break;
                case NestleICSales.Utilities.Types.MessageType.Info:
                    pb.Image = NestleICSales.Properties.Resources.MSG_Information;
                    tbMSG.ForeColor = InfoColor;
                    if (ex == null)
                        Logger.Info(msg);
                    else
                        Logger.Info(msg, ex);
                    break;
                case NestleICSales.Utilities.Types.MessageType.Debug:
                    pb.Image = NestleICSales.Properties.Resources.MSG_Information;
                    tbMSG.ForeColor = InfoColor;
                    if (ex == null)
                        Logger.Debug(msg);
                    else
                        Logger.Debug(msg, ex);
                    break;
                case NestleICSales.Utilities.Types.MessageType.Fatal:
                    pb.Image = NestleICSales.Properties.Resources.MSG_Error;
                    tbMSG.ForeColor = ErrorColor;
                    if (ex == null)
                        Logger.Fatal(msg);
                    else
                        Logger.Fatal(msg, ex);
                    break;
                case NestleICSales.Utilities.Types.MessageType.Warn:
                    pb.Image = NestleICSales.Properties.Resources.MSG_Information;
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
        public static void ShowAlert(string Msg, NestleICSales.Utilities.Types.MessageType msgType, Form CallForm)
        {
            DevExpress.XtraBars.Alerter.AlertInfo info = new DevExpress.XtraBars.Alerter.AlertInfo(Application.ProductName, Msg);
            switch (msgType)
            {
                case NestleICSales.Utilities.Types.MessageType.Success:
                    info.Image = NestleICSales.Properties.Resources.done;
                    break;
                case NestleICSales.Utilities.Types.MessageType.Error:
                    info.Image = NestleICSales.Properties.Resources.error;
                    break;
                case NestleICSales.Utilities.Types.MessageType.Info:
                    info.Image = NestleICSales.Properties.Resources.info;
                    break;
                case NestleICSales.Utilities.Types.MessageType.Debug:
                    info.Image = NestleICSales.Properties.Resources.info;
                    break;
                case NestleICSales.Utilities.Types.MessageType.Fatal:
                    info.Image = NestleICSales.Properties.Resources.error;
                    break;
                case NestleICSales.Utilities.Types.MessageType.Warn:
                    info.Image = NestleICSales.Properties.Resources.info;
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
