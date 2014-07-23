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

namespace schoolStore
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
            
            //RVGeneral.ServerReport.ReportServerCredentials.ImpersonationUser = System.Security.Principal.WindowsIdentity.GetCurrent();
            

            if (FXFW.SqlDB.SSRSDomain == string.Empty)
                RVGeneral.ServerReport.ReportServerCredentials.NetworkCredentials = new System.Net.NetworkCredential(FXFW.SqlDB.SSRSUserName, FXFW.SqlDB.SSRSPassword);
            else
                RVGeneral.ServerReport.ReportServerCredentials.NetworkCredentials = new System.Net.NetworkCredential(FXFW.SqlDB.SSRSUserName, FXFW.SqlDB.SSRSPassword, FXFW.SqlDB.SSRSDomain);
            
            try
            {
                Text = String.Format("{0} - {1}", FXFW.SqlDB.SQLRep[rptSelectedIndex].RepCaption, Text);
                RVGeneral.ServerReport.ReportPath = FXFW.SqlDB.ReportPath + FXFW.SqlDB.SQLRep[rptSelectedIndex].RepFileName.Replace(".rdl", "");
                RVGeneral.ServerReport.ReportServerUrl = new Uri(FXFW.SqlDB.ReportURL, UriKind.Absolute);
                RVGeneral.RefreshReport();
            }
            catch (Exception ex)
            {
                Program.msg(ex.Message, true, "", this);
            }

        }
    }
}