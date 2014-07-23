using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace TinyShop.Reports
{
    public partial class XrepBarcode : DevExpress.XtraReports.UI.XtraReport
    {
        public XrepBarcode(string barcode, string price)
        {
            InitializeComponent();
            xrBarCodeItem1.Text = barcode;
            lblPrice1.Text = string.Format(@"{0} LE", price);

            xrBarCodeItem2.Text = barcode;
            lblPrice2.Text = string.Format(@"{0} LE", price);
        }

    }
}
