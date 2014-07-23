using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TinyShop.Forms.Query
{
    public partial class QryBillsDetailsFrm : DevExpress.XtraEditors.XtraForm
    {
        public QryBillsDetailsFrm()
        {
            InitializeComponent();
        }
        private void QryBillsFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsTinyData.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dsTinyData.Products);
            // TODO: This line of code loads data into the 'dsTinyData.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dsTinyData.Users);
            // TODO: This line of code loads data into the 'dsTinyData.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.dsTinyData.Suppliers);
            // TODO: This line of code loads data into the 'dsTinyData.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.dsTinyData.Customers);
            // TODO: This line of code loads data into the 'dsTinyData.BillTypes' table. You can move, or remove it, as needed.
            this.billTypesTableAdapter.Fill(this.dsTinyData.BillTypes);
            // TODO: This line of code loads data into the 'dsTinyData.QryBillDetails' table. You can move, or remove it, as needed.
            this.qryBillDetailsTableAdapter.Fill(this.dsTinyData.QryBillDetails);
        }
        private void gridViewData_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            //if (e.Column != "XXXXXXX")
            //    return;
            //DataSources.dsTinyData.QryBillDetailsRow row = (DataSources.dsTinyData.QryBillDetailsRow)gridViewData.GetDataRow(e.RowHandle);
            //if (row == null)
            //    return;
            //switch (row.BillTypeID)
            //{
            //    case (int)dbTools.misc.BillType.Baye3:
                  
            //        e.RepositoryItem = repositoryItemLookUpEditPersonIDCustomer;
            //        break;
            //    case (int)dbTools.misc.BillType.Hawaleek:
            //        break;
            //    case (int)dbTools.misc.BillType.Mortaga3:
            //        e.RepositoryItem = repositoryItemLookUpEditPersonIDCustomer;
            //        break;
            //    case (int)dbTools.misc.BillType.Tawreed:
            //        e.RepositoryItem = repositoryItemLookUpEditPersonIDSupplier;
            //        break;
            //}
        }
    
    }
}