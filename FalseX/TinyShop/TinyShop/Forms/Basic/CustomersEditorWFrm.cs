using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TinyShop.Forms.Basic
{
    public partial class CustomersEditorWFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.dsTinyData.CustomersRow _row;

        public CustomersEditorWFrm(DataSources.dsTinyData.CustomersRow row)
        {
            InitializeComponent();
            _row = row;
        }
        private void LoadBinding()
        {
            if (!_row.IsNull("CustomerName"))
                tbCustomerName.EditValue = _row.CustomerName;
            if (!_row.IsNull("CustomerAddress"))
                tbCustomerAddress.EditValue = _row.CustomerAddress;
            if (!_row.IsNull("CustomerPhone"))
                tbCustomerPhone.EditValue = _row.CustomerPhone;
        }

        private void ProductsEditorWFrm_Load(object sender, EventArgs e)
        {
            LoadBinding();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbCustomerName.EditValue != null)
                _row.CustomerName = Convert.ToString(tbCustomerName.EditValue);
            if (tbCustomerAddress.EditValue != null)
                _row.CustomerAddress = Convert.ToString(tbCustomerAddress.EditValue);
            if (tbCustomerPhone.EditValue != null)
                _row.CustomerPhone = Convert.ToString(tbCustomerPhone.EditValue);
            

            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

    }
}