using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace Members
{
    public partial class XRepBarcodeTester : DevExpress.XtraReports.UI.XtraReport
    {
        public XRepBarcodeTester()
        {
            InitializeComponent();
            
        }
        private void XRepBarcodeTester_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            //foreach (ParameterInfo info in e.ParametersInformation)
            //{
            //    if (info.Parameter.Name == "pramType")
            //    {
            //        LookUpEdit LUE = new LookUpEdit();
            //        LUE.Properties.DataSource = "";
            //        LUE.Properties.DisplayMember = "Syndicate";
            //        LUE.Properties.ValueMember = "SyndicateId";
            //        LUE.Properties.Columns.Add(new LookUpColumnInfo("id", 0, "اسم النوع"));
            //        info.Editor = LUE;
            //        info.Parameter.Value = DBNull.Value;
            //        //xrBarCodeTest.Symbology.
                    
            //    }
            //}
        }
        private void XRepBarcodeTester_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            //LoadDataSource(Parameters["paramprintdate"].Value);
            //DateTime date = (DateTime)Parameters["paramprintdate"].Value;
            //xRep06_QTableAdapter.Fill(teachersUnionDataSet1.XRep06_Q, date);
            object w = 0;
            object h = 0;
            object value = 0;
            foreach (ParameterInfo info in e.ParametersInformation)
            {
                if (info.Parameter.Name == "pramValue")
                {
                    value = info.Parameter.Value;
                }
                else if (info.Parameter.Name == "pramWidth")
                {
                    w = info.Parameter.Value;
                }
                else if (info.Parameter.Name == "pramHight")
                {
                    h = info.Parameter.Value;
                }
            }
            xrBarCodeTest.SizeF = new SizeF(Convert.ToSingle(w), Convert.ToSingle(h));
            xrBarCodeTest.Text = value.ToString();

        }

        

    }
}
