using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraEditors;
using System.Data;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraEditors.Controls;

namespace BookStore.XRep
{
    public partial class XRep02 : DevExpress.XtraReports.UI.XtraReport
    {
        public XRep02()
        {
            InitializeComponent();
        }
        private void XRep02_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            cDCompanyTableAdapter.Fill(dsBookStoreQueries1.CDCompany);
            xRep02TableAdapter.Fill(dsBookStoreQueries1.XRep02, Convert.ToInt32(e.ParametersInformation[0].Parameter.Value), Program.asase_code);
            LookUpEdit lue = (LookUpEdit)e.ParametersInformation[0].Editor;
            DataSources.dsBookStoreQueries.studentRow row = (DataSources.dsBookStoreQueries.studentRow)((DataRowView)lue.GetSelectedDataRow()).Row;
            xrlStudent.Text = row["stu_name"].ToString();
            xrlSaf.Text = row["alsofof_NAME"].ToString();
            xrlFasl.Text = row["fasl_name"].ToString();
        }

       
        private void XRep02_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            foreach (ParameterInfo info in e.ParametersInformation)
            {
                if (info.Parameter.Name == "pramPERSONID")
                {
                    DataSources.dsBookStoreQueriesTableAdapters.studentTableAdapter adp = new DataSources.dsBookStoreQueriesTableAdapters.studentTableAdapter();
                    adp.FillByasase_code_Detail1(dsBookStoreQueries1.student, Program.asase_code);

                    LookUpEdit LUE = new LookUpEdit();
                    LUE.Properties.DataSource = dsBookStoreQueries1.student;
                    LUE.Properties.DisplayMember = "stu_name";
                    LUE.Properties.ValueMember = "stu_code";
                    LUE.Properties.Columns.Add(new LookUpColumnInfo("stu_name", 0, "الاسماء"));
                    LUE.Properties.BestFit();
                    LUE.Properties.NullText = string.Empty;
                    LUE.Properties.TextEditStyle = TextEditStyles.Standard;
                    //LUE.Properties.NullText = "<اختر فرعيه>";
                    info.Editor = LUE;
                    info.Parameter.Value = DBNull.Value;
                    continue;
                }

            }
        }

    }
}
