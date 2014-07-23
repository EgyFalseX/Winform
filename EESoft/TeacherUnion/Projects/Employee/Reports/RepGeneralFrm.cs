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

namespace Employee
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
            if (FXFW.SqlDB.SSRSDomain == string.Empty)
                RVGeneral.ServerReport.ReportServerCredentials.NetworkCredentials = new System.Net.NetworkCredential(FXFW.SqlDB.SSRSUserName, FXFW.SqlDB.SSRSPassword);
            else
                RVGeneral.ServerReport.ReportServerCredentials.NetworkCredentials = new System.Net.NetworkCredential(FXFW.SqlDB.SSRSUserName, FXFW.SqlDB.SSRSPassword, FXFW.SqlDB.SSRSDomain);
            try
            {
                Text = String.Format("{0} - {1}", FXFW.SqlDB.SQLRep[rptSelectedIndex].RepCaption, Text);
                RVGeneral.ServerReport.ReportPath = FXFW.SqlDB.ReportPath + FXFW.SqlDB.SQLRep[rptSelectedIndex].RepFileName.Replace(".rdl", "");
                RVGeneral.ServerReport.ReportServerUrl = new Uri(FXFW.SqlDB.ReportURL, UriKind.Absolute);
                foreach (ReportParameterInfo item in RVGeneral.ServerReport.GetParameters())
                {
                    if (item.Name == "asase_code")
                        RVGeneral.ServerReport.SetParameters(new ReportParameter("asase_code", FXFW.SqlDB.asase_code));
                    break;
                }
                RVGeneral.RefreshReport();
            }
            catch (Exception ex)
            {
                Program.ShowMsg(ex.Message, true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, ex, null, this);
            }
        }
        private DataSet GetDataSet()
        {
            //RVGeneral.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            //RVGeneral.LocalReport.ReportPath = @"g:\My Work Area\WorkArea\Projects\Student\Related Files\StudentReports\StudentReports\StudentInfoRPT.rdl";
            //DataSet ds = GetDataSet();
            //ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables[0]);
            //RVGeneral.LocalReport.DataSources.Clear();
            //RVGeneral.LocalReport.DataSources.Add(rds);
            //RVGeneral.LocalReport.SetParameters(new ReportParameter("asase_code", "1"));
            //RVGeneral.RefreshReport();

            string strConnString = FXFW.SqlDB.SqlConStr;
            SqlConnection conn = new SqlConnection(strConnString);
            conn.Open();
            string sql = @"Select ...";
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            return ds;
        }
    }
}