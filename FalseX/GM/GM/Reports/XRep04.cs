using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraEditors;

namespace GM.Reports
{
    public partial class XRep04 : DevExpress.XtraReports.UI.XtraReport
    {
        //DataSources.dsGMTableAdapters.GovTableAdapter adpGov = new DataSources.dsGMTableAdapters.GovTableAdapter();
        //DataSources.dsGMTableAdapters.AreaTableAdapter adpArea = new DataSources.dsGMTableAdapters.AreaTableAdapter();
        public XRep04()
        {
            InitializeComponent();

            //adpGov.Fill(dsGM.Gov);
            //adpArea.Fill(dsGM.Area);
        }
        private void XRep01_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            if (Parameters["pramEmployeeId"].Value == DBNull.Value || Parameters["pramFrom"].Value == DBNull.Value || Parameters["pramTo"].Value == DBNull.Value)
            {
                return;
            }
            int EmployeeId = Convert.ToInt32(Parameters["pramEmployeeId"].Value);
            DateTime from = Convert.ToDateTime(Parameters["pramFrom"].Value);
            DateTime to = Convert.ToDateTime(Parameters["pramTo"].Value);

            report04TableAdapter.Fill(dsQry.Report04, EmployeeId, from, to);

            foreach (ParameterInfo pram in e.ParametersInformation)
            {
                if (pram.Parameter.Name == "pramEmployeeId")
                {
                    int id = (int)pram.Parameter.Value;

                    DataSources.dsGM.EmployeeRow row = dsGM.Employee.FindByEmployeeId(id);
                    lblEmployeeName.Text = row.EmployeeName;
                    lblEmployeePhone.Text = row.EmployeePhone;
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
