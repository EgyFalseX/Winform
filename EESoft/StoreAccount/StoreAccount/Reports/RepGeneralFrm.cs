using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;

namespace StoreAccount
{
    public partial class RepGeneralFrm : DevExpress.XtraEditors.XtraForm
    {
        public int rptSelectedIndex = -1;
        public RepGeneralFrm()
        {
            InitializeComponent();
        }
        private void RepGeneralFrm_Load(object sender, EventArgs e)
        {
            try
            {
                Text = String.Format("{0} - {1}", MCls.SQLRep[rptSelectedIndex].RepCaption, Text);
                RVGeneral.ServerReport.ReportPath = MCls.ReportPath + MCls.SQLRep[rptSelectedIndex].RepFileName.Replace(".rdl", "");
                RVGeneral.ServerReport.ReportServerUrl = new Uri(MCls.ReportURL, UriKind.Absolute);
                RVGeneral.RefreshReport();
            }
            catch (Exception ex)
            {
                MCls.msg(ex.Message, true, "", this);
            }
        }
    }
}