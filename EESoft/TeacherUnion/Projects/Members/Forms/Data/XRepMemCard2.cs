using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace Members
{
    public partial class XRepMemCard2 : DevExpress.XtraReports.UI.XtraReport
    {
        public XRepMemCard2()
        {
            InitializeComponent();
        }
        public void LoadDataSource(DataTable dt)
        {
            xlMemberName.DataBindings.Add("Text", this.DataSource, "MemberName");
            xlJob.DataBindings.Add("Text", this.DataSource, "Jobtitle");
            xlKideNumber.DataBindings.Add("Text", this.DataSource, "KideNumber");
            xlSubCommitte.DataBindings.Add("Text", this.DataSource, "Syndicate");
            xlSyndicate.DataBindings.Add("Text", this.DataSource, "SubCommitte");
            xlMemberShipNumber.DataBindings.Add("Text", this.DataSource, "MemberShipNumber");
            xrPBImg.DataBindings.Add("Image", this.DataSource, "ImgData");
            xrBarCodex.DataBindings.Add("Text", this.DataSource, "Barcode");
            xlDate.DataBindings.Add("Text", this.DataSource, "dateend", "{0:d/M/yyyy}");
            xrlInstallment.DataBindings.Add("Visible", this.DataSource, "Installment");
            //Visible
            this.DataSource = dt;
        }
    }
}
