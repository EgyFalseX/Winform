using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace schoolStore
{
    public partial class MSGBOXFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Form Auto Move Subroutain   -
        public Int16 x = 0;
        public Int16 y = 0;
        public bool flg = false;
        private void MSGBOXFrm_MouseDown(object sender, MouseEventArgs e)
        {
            x = (Int16)e.X;
            y = (Int16)e.Y;
            flg = true;
        }
        private void MSGBOXFrm_MouseUp(object sender, MouseEventArgs e)
        {
            flg = false;
        }
        private void MSGBOXFrm_MouseMove(object sender, MouseEventArgs e)
        {
            if (flg)
                this.Location = new Point(this.Location.X + (e.X - x), this.Location.Y + (e.Y - y));
            else
                this.Visible = true;
        }
        #endregion

        private Timer FadTMR = new Timer();
        private string MSG = string.Empty;
        private Timer LBLTMR = new Timer();

        public MSGBOXFrm(string ShowedMessage, bool ShowErrorNo, string ErrorNo)
        {
            InitializeComponent();

            MSG = ShowedMessage;
            PnlErrorNo.Visible = ShowErrorNo;
            LblErrorNo.Text = ErrorNo;
            if (ShowErrorNo)
            {
                TxtMSG.ForeColor = Color.Red;
                this.pictureBoxIcon.Image = global::schoolStore.Properties.Resources.MSGBOX_Error;
            }
            else
            {
                TxtMSG.ForeColor = Color.Green;
                this.pictureBoxIcon.Image = global::schoolStore.Properties.Resources.MSGBOX_Info;
            }
        }
        private void MSGBOXFrm_Load(object sender, EventArgs e)
        {
            TxtMSG.Text = MSG;
            FadTMR.Interval = 30;
            this.FadTMR.Tick += new System.EventHandler(this.FadTmr_tick);
            this.LBLTMR.Tick += new System.EventHandler(this.LBLTMR_Tick);
            FadTMR.Enabled = true;
            LBLTMR.Interval = 1500;
        }
        private void FadTmr_tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
                this.Opacity += 0.029;
            else
            {
                this.Opacity = 1;
                FadTMR.Enabled = false;
            }
        }
        private void LBLTMR_Tick(object sender, EventArgs e)
        {
            if (TxtMSG.Visible == true)
                TxtMSG.Visible = false;
            else
                TxtMSG.Visible = true;
        }
        private void BtnOk_Click(object sender, EventArgs e)
        {
            LBLTMR.Enabled = false;
            this.Close();
        }
        
    }
}