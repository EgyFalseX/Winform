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
    public partial class ProductsEditorWFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.dsTinyData.ProductsRow _row;

        public ProductsEditorWFrm(DataSources.dsTinyData.ProductsRow row)
        {
            InitializeComponent();
            _row = row;
        }
        private void LoadBinding()
        {
            if (!_row.IsNull("ProductName"))
                tbProductName.EditValue = _row.ProductName;
            if (!_row.IsNull("ProductNumber"))
                tbProductNumber.EditValue = _row.ProductNumber;
            if (!_row.IsNull("BuyPrice"))
                tbBuyPrice.EditValue = _row.BuyPrice;
            if (!_row.IsNull("SellPrice"))
                tbSellPrice.EditValue = _row.SellPrice;
        }

        private void ProductsEditorWFrm_Load(object sender, EventArgs e)
        {
            LoadBinding();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbProductName.EditValue != null)
                _row.ProductName = Convert.ToString(tbProductName.EditValue);
            if (tbProductNumber.EditValue != null)
                _row.ProductNumber = Convert.ToString(tbProductNumber.EditValue);
            if (tbBuyPrice.EditValue != null)
                _row.BuyPrice = Convert.ToDouble(tbBuyPrice.EditValue);
            if (tbSellPrice.EditValue != null)
                _row.SellPrice = Convert.ToDouble(tbSellPrice.EditValue);
            

            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

    }
}