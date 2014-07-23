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
    public partial class QryBillsFrm : DevExpress.XtraEditors.XtraForm
    {
        public QryBillsFrm()
        {
            InitializeComponent();
        }
        private void QryBillsFrm_Load(object sender, EventArgs e)
        {
         
            // TODO: This line of code loads data into the 'dsTinyData.BillTypes' table. You can move, or remove it, as needed.
            this.billTypesTableAdapter.Fill(this.dsTinyData.BillTypes);
            // TODO: This line of code loads data into the 'dsTinyData.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.dsTinyData.Customers);
            // TODO: This line of code loads data into the 'dsTinyData.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.dsTinyData.Suppliers);
            // TODO: This line of code loads data into the 'dsTinyData.QryBills' table. You can move, or remove it, as needed.
            this.qryBillsTableAdapter.Fill(this.dsTinyData.QryBills);

        }

    }
}