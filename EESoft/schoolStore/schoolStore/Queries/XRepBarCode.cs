using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace schoolStore
{
    public partial class XRepBarCode : DevExpress.XtraReports.UI.XtraReport
    {
        public XRepBarCode()
        {
            InitializeComponent();
        }
        public void LoadDataSource(System.Data.DataTable datatablesource)
        {
            this.DataSource = datatablesource.DefaultView;
            xrBarCodeItem.DataBindings.Add("Text", datatablesource, "Sanfbarcode");
            lblModelNo.DataBindings.Add("Text", datatablesource, "ModelNo");
            lblpriceout.DataBindings.Add("Text", datatablesource, "priceout");
        }
    }
}
