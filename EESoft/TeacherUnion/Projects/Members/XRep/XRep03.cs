using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace Members
{
    public partial class XRep03 : DevExpress.XtraReports.UI.XtraReport
    {
        public XRep03()
        {
            InitializeComponent();
            
        }

        private void XRep03_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            //LoadDataSource(Parameters["paramprintdate"].Value);
            DateTime date = (DateTime)Parameters["paramprintdate"].Value;
            
            xRep03_QTableAdapter.Fill(teachersUnionDataSet1.XRep03_Q, date);
        }
    }
}
