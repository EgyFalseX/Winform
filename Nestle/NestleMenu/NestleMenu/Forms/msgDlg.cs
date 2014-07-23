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
    public enum msgType
    {
        Info,
        Error,
        Warning
    }

    public partial class msgDlg : DevExpress.XtraEditors.XtraForm
    {
        private static DevExpress.XtraBars.Alerter.AlertControl Alert = new DevExpress.XtraBars.Alerter.AlertControl() { AutoFormDelay = 4000 };
        public enum msgButtons: int
        {
            Close = 0,
            YesNo,
        }
        public static DialogResult Show(string msg, msgButtons btn = msgButtons.Close)
        {
            return new msgDlg(msg, btn).ShowDialog();
        }
        public msgDlg(string msg, msgButtons btn = msgButtons.Close)
        {
            InitializeComponent();
            switch (btn)
            {
                case msgButtons.Close:
                    btnYes.Visible = false;
                    btnNo.Visible = false;
                    btnClose.Visible = true;
                    break;
                case msgButtons.YesNo:
                    btnYes.Visible = true;
                    btnNo.Visible = true;
                    btnClose.Visible = false;
                    break;
            }
            tbMSG.EditValue = msg;
        }
        public static void ShowAlert(string Msg, NestleMenu.Utilities.Types.MessageType msgType, Form CallForm)
        {
            DevExpress.XtraBars.Alerter.AlertInfo info = new DevExpress.XtraBars.Alerter.AlertInfo(Application.ProductName, Msg);
            switch (msgType)
            {
                case NestleMenu.Utilities.Types.MessageType.Success:
                    info.Image = NestleMenu.Properties.Resources.done;
                    break;
                case NestleMenu.Utilities.Types.MessageType.Error:
                    info.Image = NestleMenu.Properties.Resources.error;
                    break;
                case NestleMenu.Utilities.Types.MessageType.Info:
                    info.Image = NestleMenu.Properties.Resources.info;
                    break;
                case NestleMenu.Utilities.Types.MessageType.Debug:
                    info.Image = NestleMenu.Properties.Resources.info;
                    break;
                case NestleMenu.Utilities.Types.MessageType.Fatal:
                    info.Image = NestleMenu.Properties.Resources.error;
                    break;
                case NestleMenu.Utilities.Types.MessageType.Warn:
                    info.Image = NestleMenu.Properties.Resources.info;
                    break;
                default:
                    break;
            }
            Alert.Show(CallForm, info);
        }
        private void MSGDLG_Load(object sender, EventArgs e)
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
