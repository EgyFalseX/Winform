using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Fellowship.Qry
{
    public partial class Qry004 : DevExpress.XtraEditors.XtraForm
    {
        public Qry004()
        {
            InitializeComponent();
            XPSCS.Session.ConnectionString = Properties.Settings.Default.FellowshipConnectionString;
        }

        private void btnPrintExport_Click(object sender, EventArgs e)
        {
            // Check whether the GridControl can be previewed.
            if (!gridControlData.IsPrintingAvailable)
            {
                Program.ShowMsg("The 'DevExpress.XtraPrinting' library is not found", true, this);
                return;
            }

            // Open the Preview window.
            gridControlData.ShowRibbonPrintPreview();
        }

        private void Qry001_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSFellowship.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dSFellowship.Users);
            // TODO: This line of code loads data into the 'dSFellowship.CdJobId' table. You can move, or remove it, as needed.
            this.cdJobIdTableAdapter.Fill(this.dSFellowship.CdJobId);
            // TODO: This line of code loads data into the 'dSFellowship.CdMoahel' table. You can move, or remove it, as needed.
            this.cdMoahelTableAdapter.Fill(this.dSFellowship.CdMoahel);
            // TODO: This line of code loads data into the 'dSFellowship.CDEDARET' table. You can move, or remove it, as needed.
            this.cDEDARETTableAdapter.Fill(this.dSFellowship.CDEDARET);
            // TODO: This line of code loads data into the 'dSFellowship.CDGov' table. You can move, or remove it, as needed.
            this.cDGovTableAdapter.Fill(this.dSFellowship.CDGov);
            // TODO: This line of code loads data into the 'dSFellowship.school' table. You can move, or remove it, as needed.
            this.schoolTableAdapter.Fill(this.dSFellowship.school);

        }
    }
}