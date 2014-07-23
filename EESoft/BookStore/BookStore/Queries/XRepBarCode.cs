using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace BookStore
{
    public partial class XRpBarCode : DevExpress.XtraReports.UI.XtraReport
    {
        public XRpBarCode()
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
