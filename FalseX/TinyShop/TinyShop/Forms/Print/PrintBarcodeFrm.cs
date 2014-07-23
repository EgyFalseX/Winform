using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using TinyShop.Reports;

namespace TinyShop.Forms.Print
{
    public partial class PrintBarcodeFrm : DevExpress.XtraEditors.XtraForm
    {
        public PrintBarcodeFrm()
        {
            InitializeComponent();
        }

        private void PrintBarcodeFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsTinyData.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dsTinyData.Products);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (LUEItems.EditValue == null)
            {
                return;
            }
            DataSources.dsTinyData.ProductsRow row = (DataSources.dsTinyData.ProductsRow)((DataRowView)LUEItems.GetSelectedDataRow()).Row;
            XrepBarcode rep = new XrepBarcode(row.ProductNumber, row.SellPrice.ToString());
            // Create a Print Tool and show the Print Preview form. 
            ReportPrintTool printTool = new ReportPrintTool(rep);
            printTool.ShowPreview();
        }
    }
}