using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraEditors;

namespace GM.Reports
{
    public partial class XRep03 : DevExpress.XtraReports.UI.XtraReport
    {
        DataSources.dsGMTableAdapters.GovTableAdapter adpGov = new DataSources.dsGMTableAdapters.GovTableAdapter();
        DataSources.dsGMTableAdapters.AreaTableAdapter adpArea = new DataSources.dsGMTableAdapters.AreaTableAdapter();
        public XRep03()
        {
            InitializeComponent();

            adpGov.Fill(dsGM.Gov);
            adpArea.Fill(dsGM.Area);
        }
        private void XRep01_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            if (Parameters["pramTraderId"].Value == DBNull.Value || Parameters["pramFrom"].Value == DBNull.Value || Parameters["pramTo"].Value == DBNull.Value)
            {
                return;
            }
            int TraderId = Convert.ToInt32(Parameters["pramTraderId"].Value);
            DateTime from = Convert.ToDateTime(Parameters["pramFrom"].Value);
            DateTime to = Convert.ToDateTime(Parameters["pramTo"].Value);

            report03TableAdapter.Fill(dsQry.Report03, TraderId, from, to);

            foreach (ParameterInfo pram in e.ParametersInformation)
            {
                
                if (pram.Parameter.Name == "pramTraderId")
                {
                    int id = (int)pram.Parameter.Value;
                    DataSources.dsGM.TraderRow row = dsGM.Trader.FindByTraderId(id);
                    lblTraderName.Text = row.TraderName;
                    lblTraderSiteName.Text = row.TraderSiteName;
                    lblTraderPhone.Text = row.TraderPhone;
                    lblTraderMobile.Text = row.TraderMobile;
                    lblTraderAddress.Text = row.TraderAddress;
                    lblGovName.Text = row.AreaRow.GovRow.GovName;
                    lblAreaName.Text = row.AreaRow.AreaName;
                    continue;
                }
                if (pram.Parameter.Name == "pramFrom")
                {
                    lblFrom.Text = from.ToShortDateString();
                    continue;
                }
                if (pram.Parameter.Name == "pramTo")
                {
                    lblTo.Text = to.ToShortDateString();
                    continue;
                }
            }
        }

    }
}
