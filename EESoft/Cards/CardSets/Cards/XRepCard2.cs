using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
namespace CardSets
{
    public partial class XRepCard2 : DevExpress.XtraReports.UI.XtraReport
    {
        public XRepCard2(DataTable dt)
        {
            InitializeComponent();
            //DataSource = dt;
            dsCards1.memberdata.Rows.Clear();
            dsCards1.memberdata.Merge(dt);
            //xlmembername.DataBindings.Add("Text", this.DataSource, "membername");
            //xlsefaName.DataBindings.Add("Text", this.DataSource, "sefaName");
            //xlsubcommite.DataBindings.Add("Text", this.DataSource, "subcommite");
            //xlLagnaName.DataBindings.Add("Text", this.DataSource, "LagnaName");
            //xrtitleName.DataBindings.Add("Text", this.DataSource, "titleName");
            xrPBImg.DataBindings.Add("ImageUrl", this.DataSource, "imgpath", Program.ImagePath + "{0}");

        }

    }
}
