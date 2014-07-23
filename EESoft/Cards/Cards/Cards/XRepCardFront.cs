using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace Cards
{
    public partial class XRepCardFront : DevExpress.XtraReports.UI.XtraReport
    {
        public XRepCardFront(string Saf, string Fasl)
        {
            InitializeComponent();

            dATATableAdapter.Fill(dsCards1.DATA, Saf, Fasl);

            xrPBImg.DataBindings.Add("ImageUrl", dsCards1.DATA, "IMG", Program.ImagePath + "{0}");
        }
    }
}
