using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace System.Windows.Forms
{
    public partial class msgDlg : DevExpress.XtraEditors.XtraForm
    {
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