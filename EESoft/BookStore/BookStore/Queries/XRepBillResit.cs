using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace BookStore
{
    public partial class XRepBillResit : DevExpress.XtraReports.UI.XtraReport
    {
        public XRepBillResit()
        {
            InitializeComponent();
        }
        public void LoadDataSource(string StoreTrID)
        {
            pram1.Value = StoreTrID;
            this.DataSource = FXFW.SqlDB.LoadDataTable(@"Select Price, Quantity, Price * Quantity AS Total, 
                (Select SanfName From CDASNAF Where SanfID = StoreTransactionDetailes.SanfID) AS SanfName  
                From StoreTransactionDetailes Where StoreTrID = " + pram1.Value);

            cel1.DataBindings.Add("Text", this.DataSource, "SanfName");
            cel2.DataBindings.Add("Text", this.DataSource, "Quantity");
            cel3.DataBindings.Add("Text", this.DataSource, "Price");
            cel4.DataBindings.Add("Text", this.DataSource, "Total");
            

        }
    }
}
