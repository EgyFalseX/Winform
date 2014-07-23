using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace Members
{
    public partial class XRep08 : DevExpress.XtraReports.UI.XtraReport
    {
        public XRep08()
        {
            InitializeComponent();
            appOptionsTableAdapter.Fill(dsTeachersUnionQuery1.AppOptions);
        }
        private void XRep_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            int start = Convert.ToInt32(Parameters["pramStart"].Value);
            int end = Convert.ToInt32(Parameters["pramEnd"].Value);
            rep08TableAdapter.FillByKideNumber(dsTeachersUnionQuery1.Rep08, start, end);
            
        }

    }
}
