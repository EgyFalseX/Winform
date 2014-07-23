using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace Members
{
    public partial class XRep01 : DevExpress.XtraReports.UI.XtraReport
    {
        int counter = 0;
        object _hafzaId = null;

        public XRep01(object HafzaId)
        {
            InitializeComponent();
            _hafzaId = HafzaId;
            LoadDataSource();
        }
        private void LoadDataSource()
        {
            DataRow dtMain = SQLProvider.SelectTBLHafzaTasleem(_hafzaId).Rows[0];
            xlHafzaId.Text = dtMain["HafzaId"].ToString();
            xlSyndicate.Text = dtMain["Syndicate"].ToString();
            xlMandoopName.Text = dtMain["MandoopName"].ToString();
            xlHafzaDate.Text = FXFW.SqlDB.ConvertToDateDMY(dtMain["HafzaDate"].ToString());
            

            DataTable dtDetails = SQLProvider.SelectTBLHafzaTasleemDeyails(_hafzaId);
            this.DataSource = dtDetails;

            xtcSyndicate.DataBindings.Add("Text", this.DataSource, "Syndicate");
            xtcMemberShipNumber.DataBindings.Add("Text", this.DataSource, "MemberShipNumber");
            xtcMemberName.DataBindings.Add("Text", this.DataSource, "MemberName");

            xlCount.Text = dtDetails.Rows.Count.ToString();


        }

        private void xtcNo_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            counter++;
            ((XRLabel)sender).Text = string.Format("Record Number = {0}", counter);
        }
    }
}
