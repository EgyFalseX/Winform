using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace Members
{
    public partial class XRep04 : DevExpress.XtraReports.UI.XtraReport
    {
        public XRep04()
        {
            InitializeComponent();
            
        }

        private void XRep03_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            //LoadDataSource(Parameters["paramprintdate"].Value);
            DateTime dateStart = (DateTime)Parameters["paramprintdateStart"].Value;
            DateTime dateEnd = (DateTime)Parameters["paramprintdateEnd"].Value;

            xRep04_QTableAdapter.Fill(teachersUnionDataSet1.XRep04_Q, dateStart, dateEnd);
        }

    }
}
