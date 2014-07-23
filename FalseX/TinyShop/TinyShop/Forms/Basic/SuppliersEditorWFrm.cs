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
    public partial class SuppliersEditorWFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.dsTinyData.SuppliersRow _row;

        public SuppliersEditorWFrm(DataSources.dsTinyData.SuppliersRow row)
        {
            InitializeComponent();
            _row = row;
        }
        private void LoadBinding()
        {
            if (!_row.IsNull("supplierName"))
                tbsupplierName.EditValue = _row.supplierName;
            if (!_row.IsNull("supplierAddress"))
                tbsupplierAddress.EditValue = _row.supplierAddress;
            if (!_row.IsNull("supplierPhone"))
                tbsupplierPhone.EditValue = _row.supplierPhone;
        }

        private void ProductsEditorWFrm_Load(object sender, EventArgs e)
        {
            LoadBinding();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbsupplierName.EditValue != null)
                _row.supplierName = Convert.ToString(tbsupplierName.EditValue);
            if (tbsupplierAddress.EditValue != null)
                _row.supplierAddress = Convert.ToString(tbsupplierAddress.EditValue);
            if (tbsupplierPhone.EditValue != null)
                _row.supplierPhone = Convert.ToString(tbsupplierPhone.EditValue);
            

            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

    }
}