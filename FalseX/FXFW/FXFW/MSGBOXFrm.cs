#define DEBUG

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FXFW
{
    public partial class MSGBOXFrm : Form
    {
        #region -   Variables   -
        private Timer FadTMR = new Timer();
        private string MSG = string.Empty;
        private Timer LBLTMR = new Timer();
        #endregion
        #region -   Functions   -
        #region -   Form Auto Move Subroutain   -
        public int x = 0;
        public int y = 0;
        public bool flg = false;
        private void MSGBOXFrm_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
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
        public void MSGBOXFrmx(string ShowedMessage, bool ShowErrorNo, string ErrorNo)
        {
#if DEBUG

            MSG = ShowedMessage;
            PnlErrorNo.Visible = ShowErrorNo;
            LblErrorNo.Text = ErrorNo;
            if (ShowErrorNo)
            {
                TxtMSG.ForeColor = Color.Red;
                this.pictureBoxIcon.Image = global::FXFW.Properties.Resources.MSGBOX_Error;
            }
            else
            {
                TxtMSG.ForeColor = Color.Green;
                this.pictureBoxIcon.Image = global::FXFW.Properties.Resources.MSGBOX_Info;
            }
#endif
        }
        public MSGBOXFrm(Logger.LogDetails Logthis, [System.Runtime.InteropServices.Optional] Form Owner)
        {
            InitializeComponent();

            MSG = Logthis.message;
            LblErrorNo.Text = string.Empty;
            switch (Logthis.OpType)
            {
                case Logger.OpType.success:

                    pictureBoxIcon.Image = global::FXFW.Properties.Resources.MSGBOX_Info;
                    TxtMSG.ForeColor = Color.Green;
                    break;
                case Logger.OpType.fail:
                    pictureBoxIcon.Image = global::FXFW.Properties.Resources.MSGBOX_Error;
                    TxtMSG.ForeColor = Color.Red;
                    break;
                default:
                    if (Logthis.ExSql == null)
                    {
                        pictureBoxIcon.Image = global::FXFW.Properties.Resources.MSGBOX_Info;
                        TxtMSG.ForeColor = Color.Green;

                    }
                    else
                    {
                        LblErrorNo.Text = Logthis.ExSql.Number.ToString();
                        TxtMSG.ForeColor = Color.Red;
                        PnlErrorNo.Visible = true;
                    }
                    break;
            }
            LblOpType.Text = Logthis.OpType.ToString();

        }
        #endregion
        #region - Event Handlers -

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
            FadTMR.Enabled = false;
            this.Close();
        }
        #endregion         #region -   Variables   -
        
    }
}