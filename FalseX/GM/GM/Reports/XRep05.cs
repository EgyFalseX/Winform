using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraEditors;

namespace GM.Reports
{
    public partial class XRep05 : DevExpress.XtraReports.UI.XtraReport
    {
        DataSources.dsGMTableAdapters.GovTableAdapter adpGov = new DataSources.dsGMTableAdapters.GovTableAdapter();
        DataSources.dsGMTableAdapters.AreaTableAdapter adpArea = new DataSources.dsGMTableAdapters.AreaTableAdapter();
        public XRep05()
        {
            InitializeComponent();

            adpGov.Fill(dsGM.Gov);
            adpArea.Fill(dsGM.Area);
        }
        private void XRep01_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            if (Parameters["pramPlumberId"].Value == DBNull.Value || Parameters["pramFrom"].Value == DBNull.Value || Parameters["pramTo"].Value == DBNull.Value)
            {
                return;
            }
            int PlumberId = Convert.ToInt32(Parameters["pramPlumberId"].Value);
            DateTime from = Convert.ToDateTime(Parameters["pramFrom"].Value);
            DateTime to = Convert.ToDateTime(Parameters["pramTo"].Value);

            report05TableAdapter.Fill(dsQry.Report05, PlumberId, from, to);

            foreach (ParameterInfo pram in e.ParametersInformation)
            {
                if (pram.Parameter.Name == "pramPlumberId")
                {
                    int id = (int)pram.Parameter.Value;

                    DataSources.dsGM.PlumberRow row = dsGM.Plumber.FindByPlumberId(id);
                    lblPlumberName.Text = row.PlumberName;
                    lblPlumberPhone.Text = row.PlumberPhone;
                    lblPlumberMobile.Text = row.PlumberMobile;
                    lblGovName.Text = row.AreaRow.GovRow.GovName;
                    lblAreaName.Text = row.AreaRow.AreaName;
                    lblPlumberAddress.Text = row.PlumberAddress;
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
