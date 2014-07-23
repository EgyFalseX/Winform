using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;


namespace CardSets
{
    public partial class MainFrm : XtraForm
    {
        public MainFrm()
        {
            InitializeComponent();
        }
        private void iExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }
        private void iAbout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Programmed by E-E-Soft", "About Us", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MainFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsCards.memberdata' table. You can move, or remove it, as needed.
            this.memberdataTableAdapter.Fill(this.dsCards.memberdata);
        }
        private void StudentItem_ItemChanged(object sender, EventArgs e)
        {
            GCQueryOptions.Visible = true;
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dt = dsCards.memberdata.Copy();
            //for (int i = dt.Rows.Count - 1; i >= 0; i--)
            //{
            //    if ((bool)dt.Rows[i]["chk"] == false)
            //        dt.Rows.RemoveAt(i);
            //}
            XRepCard front = new XRepCard(dt);
            front.ShowPreview();
        }
        private void btnPrint2_Click(object sender, EventArgs e)
        {
            DataTable dt = dsCards.memberdata.Copy();
            XRepCard2 front = new XRepCard2(dt);
            front.ShowPreview();
        }
        private void btnPrintEditor_Click(object sender, EventArgs e)
        {
            DataTable dt = dsCards.memberdata.Copy();
            for (int i = dt.Rows.Count - 1; i >= 0; i--)
            {
                if ((bool)dt.Rows[i]["chk"] == false)
                    dt.Rows.RemoveAt(i);
            }

            XRepCard front = new XRepCard(dt);
            front.ShowDesigner();
        }

        

    }
}