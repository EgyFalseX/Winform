using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraEditors;

namespace GM.Reports
{
    public partial class XRep01 : DevExpress.XtraReports.UI.XtraReport
    {
        public XRep01()
        {
            InitializeComponent();
        }

        private void XRep01_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            //report01Adapter

            if (Parameters["pramGovId"].Value == DBNull.Value || Parameters["pramFrom"].Value == DBNull.Value || Parameters["pramTo"].Value == DBNull.Value)
            {
                return;
            }
            int GovId = Convert.ToInt32(Parameters["pramGovId"].Value);
            DateTime from = Convert.ToDateTime(Parameters["pramFrom"].Value);
            DateTime to = Convert.ToDateTime(Parameters["pramTo"].Value);

            report01TableAdapter.Fill(dsQry.Report01,from, to, GovId);


            foreach (ParameterInfo pram in e.ParametersInformation)
            {
                if (pram.Parameter.Name == "pramGovId")
                {
                    lblGov.Text = ((LookUpEdit)pram.Editor).Text;
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
